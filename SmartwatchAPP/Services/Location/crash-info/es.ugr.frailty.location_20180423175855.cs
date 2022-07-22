S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 393
Date: 2018-04-23 17:58:55+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71be52d, r5   = 0xf7814f98
r6   = 0xff9c72c8, r7   = 0xff9c7178
r8   = 0xf7811c18, r9   = 0x00000000
r10  = 0xff9c7254, fp   = 0xff9c72c8
ip   = 0x00000001, sp   = 0xff9c5ff8
lr   = 0xf71be539, pc   = 0xf722727a
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     12744 KB
Buffers:     67724 KB
Cached:     217576 KB
VmPeak:      53460 KB
VmSize:      53388 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11892 KB
VmRSS:       11892 KB
VmData:      11116 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 393 TID = 393
393 400 

Maps Information
f4089000 f4888000 rw-p [stack:400]
f488f000 f4891000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4899000 f489d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48a6000 f48a8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48b0000 f48b3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48c2000 f48c7000 r-xp /usr/lib/libsystem.so.0.0.0
f48d2000 f48d5000 r-xp /lib/libattr.so.1.1.0
f48dd000 f48ed000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48f5000 f48fe000 r-xp /usr/lib/libedbus.so.1.7.99
f4906000 f4907000 r-xp /usr/lib/libresponse.so.0.2.96
f4910000 f4915000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61b7000 f62bd000 r-xp /usr/lib/libicuuc.so.57.1
f62d3000 f645b000 r-xp /usr/lib/libicui18n.so.57.1
f646b000 f6478000 r-xp /usr/lib/libail.so.0.1.0
f6481000 f6488000 r-xp /usr/lib/libminizip.so.1.0.0
f6491000 f663a000 r-xp /usr/lib/libcrypto.so.1.0.0
f665a000 f66a1000 r-xp /usr/lib/libssl.so.1.0.0
f66ad000 f66af000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66b7000 f66be000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66c7000 f66ce000 r-xp /lib/libcrypt-2.13.so
f66ff000 f6702000 r-xp /lib/libcap.so.2.21
f670a000 f670c000 r-xp /usr/lib/libiri.so
f6714000 f675d000 r-xp /usr/lib/libmdm.so.1.2.69
f6765000 f676b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6773000 f6796000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67a0000 f67a2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67aa000 f67c7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67d0000 f67d4000 r-xp /usr/lib/libsmack.so.1.0.0
f67dd000 f67f6000 r-xp /usr/lib/libnetwork.so.0.0.0
f67ff000 f6807000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f680f000 f6815000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f681e000 f6820000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6829000 f6839000 r-xp /lib/libresolv-2.13.so
f683d000 f6855000 r-xp /usr/lib/liblzma.so.5.0.3
f685e000 f6860000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6868000 f6882000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f688a000 f68b9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68c2000 f68d1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68db000 f68e5000 r-xp /usr/lib/libsensord-shared.so
f68ee000 f69c1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69cc000 f69e2000 r-xp /lib/libz.so.1.2.5
f69ea000 f69ef000 r-xp /usr/lib/libffi.so.5.0.10
f69f7000 f69f8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a00000 f6a10000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a18000 f6a31000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a39000 f6a3b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a43000 f6ab8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ac2000 f6ac8000 r-xp /lib/librt-2.13.so
f6ad1000 f6aef000 r-xp /usr/lib/libsystemd.so.0.4.0
f6af9000 f6afa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b02000 f6b25000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b2d000 f6b32000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b3a000 f6b64000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b6d000 f6b84000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b8c000 f6bf5000 r-xp /lib/libm-2.13.so
f6bfe000 f6c92000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ca5000 f6caa000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cb2000 f6cb9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cc1000 f6ceb000 r-xp /usr/lib/libsensor.so.1.9.6
f6cf4000 f6dc0000 r-xp /usr/lib/libxml2.so.2.7.8
f6dcd000 f6dcf000 r-xp /usr/lib/libiniparser.so.0
f6dd8000 f6dde000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6de7000 f6eb7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eb8000 f6eec000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ef5000 f6f31000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f39000 f6f3c000 r-xp /usr/lib/libbundle.so.0.1.22
f6f44000 f6f4a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f52000 f6f93000 r-xp /usr/lib/libeina.so.1.7.99
f6f9c000 f6fb3000 r-xp /usr/lib/libecore.so.1.7.99
f6fca000 f6fd3000 r-xp /usr/lib/libvconf.so.0.2.45
f6fdb000 f6fef000 r-xp /lib/libpthread-2.13.so
f6ffa000 f7007000 r-xp /usr/lib/libaul.so.0.1.0
f7011000 f7013000 r-xp /lib/libdl-2.13.so
f701c000 f7027000 r-xp /lib/libunwind.so.8.0.1
f7054000 f705c000 r-xp /lib/libgcc_s-4.6.so.1
f705d000 f7181000 r-xp /lib/libc-2.13.so
f718f000 f7191000 r-xp /usr/lib/libdlog.so.0.0.0
f7199000 f71a5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71ae000 f71b3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71bb000 f71ca000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71d2000 f71d6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71df000 f71e2000 r-xp /usr/lib/libappcore-agent.so.1.1
f71ea000 f71ec000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71f4000 f71f8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7200000 f721d000 r-xp /lib/ld-2.13.so
f7226000 f7229000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7229000 f722d000 r-xp /usr/lib/libsys-assert.so
f77e1000 f7843000 rw-p [heap]
ff9a8000 ff9c9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:393)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf722727a) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x127a
 1: (0xf71be539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ec53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ec3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ecfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ed5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ed5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f0a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f051f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ec3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ecfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ed5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ed5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f07e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f08017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f0c8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71f60bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf489a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf696d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e1afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e1c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6facca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fa7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fa85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fa8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71e0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71e07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf722768b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x168b
28: __libc_start_main + 0x114 (0xf707485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7226f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
cope sleep timeout
04-23 17:58:48.771+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 17:58:48.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:48.771+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:48.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 32717
04-23 17:58:48.791+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(32717)
04-23 17:58:48.791+0200 I/servicemanager(32623): es.ugr.frailty.gyroscope stop request sent!
04-23 17:58:48.791+0200 I/servicemanager(32623): App control destroyed.
04-23 17:58:48.791+0200 I/servicemanager(32623): es.ugr.frailty.heartrate sleep timeout
04-23 17:58:48.791+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 17:58:48.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:48.791+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:48.811+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 32724
04-23 17:58:48.811+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(32724)
04-23 17:58:48.811+0200 I/servicemanager(32623): es.ugr.frailty.heartrate stop request sent!
04-23 17:58:48.811+0200 I/heartrate(32724): stopping es.ugr.frailty.heartrate service
04-23 17:58:48.811+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:58:48.811+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(32724), cmd(0)
04-23 17:58:48.811+0200 I/servicemanager(32623): App control destroyed.
04-23 17:58:48.841+0200 E/CAPI_APPFW_APP_CONTROL(32724): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 17:58:48.841+0200 E/heartrate(32724): request sending failed to service es.ugr.frailty.servicemanager
04-23 17:58:48.841+0200 I/CAPI_APPFW_APPLICATION(32724): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:58:48.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:58:48.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:58:48.881+0200 I/servicemanager(32623): es.ugr.frailty.pedometer sleep timeout
04-23 17:58:48.881+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
04-23 17:58:48.891+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:48.891+0200 E/AUL_AMD ( 2476): amd_request.c: __request_handler(693) > no appinfo
04-23 17:58:48.891+0200 E/AUL_AMD ( 2476): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
04-23 17:58:48.891+0200 E/AUL_AMD ( 2476): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
04-23 17:58:48.891+0200 E/AUL_AMD ( 2476): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
04-23 17:58:48.891+0200 E/AUL_AMD ( 2476): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
04-23 17:58:48.891+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:48.891+0200 E/AUL_AMD ( 2476): amd_launch.c: _start_app(1795) > no appinfo
04-23 17:58:48.891+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:58:48.891+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
04-23 17:58:48.891+0200 E/CAPI_APPFW_APP_CONTROL(32623): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
04-23 17:58:48.891+0200 E/servicemanager(32623): es.ugr.frailty.pedometer stop request sending failed!
04-23 17:58:48.891+0200 I/servicemanager(32623): App control destroyed.
04-23 17:58:48.901+0200 I/accelerometer(32704): stopping es.ugr.frailty.accelerometer service
04-23 17:58:48.901+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:48:727,-58.660000,8.400000,-1.750000
04-23 17:58:48.901+0200 W/AUL     (32704): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:58:48.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:48.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32704
04-23 17:58:48.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 32623
04-23 17:58:48.921+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:58:48.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(32623), cmd(0)
04-23 17:58:48.921+0200 W/CAPI_APPFW_APP_CONTROL(32623): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:48.921+0200 I/utils   (32623): specific action
04-23 17:58:48.921+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:58:48.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:48.921+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:48.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 32628
04-23 17:58:48.931+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:58:48.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(32628), cmd(0)
04-23 17:58:48.931+0200 W/CAPI_APPFW_APP_CONTROL(32628): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:48.931+0200 I/utils   (32628): specific action
04-23 17:58:48.941+0200 W/CAPI_APPFW_APP_CONTROL(32628): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:48.941+0200 I/recorder(32628): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 17:58:48.941+0200 I/recorder(32628): guardando datos en local
04-23 17:58:48.941+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(32628)
04-23 17:58:48.941+0200 I/servicemanager(32623): request sent to service es.ugr.frailty.recorder
04-23 17:58:48.941+0200 I/servicemanager(32623): requesting to save local data
04-23 17:58:48.941+0200 W/AUL     (32704): launch.c: app_request_to_launchpad(298) > request cmd(0) result(32623)
04-23 17:58:48.941+0200 I/accelerometer(32704): request sent to service es.ugr.frailty.servicemanager
04-23 17:58:48.941+0200 I/CAPI_APPFW_APPLICATION(32704): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:58:48.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:58:48.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:58:48.961+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:58:48.971+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:58:48.981+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:58:48.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(32717), cmd(0)
04-23 17:58:48.991+0200 I/gyroscope(32717): stopping es.ugr.frailty.gyroscope service
04-23 17:58:48.991+0200 W/AUL     (32717): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:58:48.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:48.991+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32717
04-23 17:58:49.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 32623
04-23 17:58:49.011+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:58:49.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(32623), cmd(0)
04-23 17:58:49.011+0200 W/CAPI_APPFW_APP_CONTROL(32623): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:49.011+0200 I/utils   (32623): specific action
04-23 17:58:49.011+0200 W/CAPI_APPFW_APP_CONTROL(32623): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:49.011+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:58:49.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:49.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:49.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 32628
04-23 17:58:49.031+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 17:58:49.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:58:49.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(32628), cmd(0)
04-23 17:58:49.031+0200 W/CAPI_APPFW_APP_CONTROL(32628): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:49.031+0200 I/utils   (32628): specific action
04-23 17:58:49.031+0200 W/CAPI_APPFW_APP_CONTROL(32628): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:49.031+0200 W/CAPI_APPFW_APP_CONTROL(32628): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:49.031+0200 I/recorder(32628): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 17:58:49.031+0200 I/recorder(32628): guardando datos en local
04-23 17:58:49.041+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(32628)
04-23 17:58:49.041+0200 I/servicemanager(32623): request sent to service es.ugr.frailty.recorder
04-23 17:58:49.051+0200 I/servicemanager(32623): requesting to save local data
04-23 17:58:49.111+0200 I/heartrate(32724): es.ugr.frailty.heartrate listener destroyed
04-23 17:58:49.111+0200 W/AUL     (32717): launch.c: app_request_to_launchpad(298) > request cmd(0) result(32623)
04-23 17:58:49.111+0200 I/gyroscope(32717): request sent to service es.ugr.frailty.servicemanager
04-23 17:58:49.111+0200 I/CAPI_APPFW_APPLICATION(32717): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:58:49.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:58:49.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:58:49.161+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:58:49.171+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:58:49.251+0200 W/AUL     (  318): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 17:58:49.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:58:49.251+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:58:49.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 32724
04-23 17:58:49.251+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:58:49.251+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 32724
04-23 17:58:49.251+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(32724)
04-23 17:58:49.271+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer listener destroyed
04-23 17:58:49.281+0200 W/AUL     (  319): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:58:49.291+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:58:49.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:58:49.301+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:58:49.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 32650
04-23 17:58:49.301+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:58:49.301+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 32650
04-23 17:58:49.301+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(32650)
04-23 17:58:49.301+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:58:49.321+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope listener destroyed
04-23 17:58:49.411+0200 W/AUL     (  321): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 17:58:49.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:58:49.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:58:49.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 32704
04-23 17:58:49.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:58:49.411+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 32704
04-23 17:58:49.411+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(32704)
04-23 17:58:49.461+0200 W/AUL     (  322): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 17:58:49.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:58:49.461+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:58:49.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 32717
04-23 17:58:49.461+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:58:49.471+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 32717
04-23 17:58:49.471+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(32717)
04-23 17:58:49.961+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:58:50.841+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:58:50.941+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:58:51.121+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:58:53.661+0200 I/servicemanager(32623): es.ugr.frailty.accelerometer alive timeout
04-23 17:58:53.661+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 17:58:53.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:53.661+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:53.671+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 331
04-23 17:58:53.671+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:58:53.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 331
04-23 17:58:53.721+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(331) type(svcapp) bg(0)
04-23 17:58:53.731+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [331]
04-23 17:58:53.731+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(331)
04-23 17:58:53.731+0200 I/servicemanager(32623): es.ugr.frailty.accelerometer launch request sent!
04-23 17:58:53.731+0200 I/servicemanager(32623): App control destroyed.
04-23 17:58:53.751+0200 E/CAPI_APPFW_APPLICATION(  331): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:58:53.751+0200 E/CAPI_APPFW_APPLICATION(  331): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:58:53.751+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (331) was created
04-23 17:58:53.761+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:58:53.761+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 331
04-23 17:58:53.761+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:58:53.771+0200 I/utils   (  331): trying to start service: es.ugr.frailty.accelerometer
04-23 17:58:53.771+0200 I/utils   (  331): es.ugr.frailty.accelerometer sensor supported
04-23 17:58:53.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:58:53.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 331
04-23 17:58:53.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:58:53.801+0200 I/utils   (  331): es.ugr.frailty.accelerometer listener started
04-23 17:58:53.801+0200 W/CAPI_APPFW_APP_CONTROL(  331): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:53.801+0200 I/utils   (  331): specific action
04-23 17:58:53.841+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:53.851+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:53:851,9.946963,0.612563,0.753739
04-23 17:58:53.871+0200 I/servicemanager(32623): es.ugr.frailty.gyroscope alive timeout
04-23 17:58:53.871+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 17:58:53.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:53.871+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:53.881+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 358
04-23 17:58:53.881+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:58:53.931+0200 E/CAPI_APPFW_APPLICATION(  358): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:58:53.931+0200 E/CAPI_APPFW_APPLICATION(  358): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:58:53.931+0200 I/utils   (  358): trying to start service: es.ugr.frailty.gyroscope
04-23 17:58:53.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 358
04-23 17:58:53.931+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(358) type(svcapp) bg(0)
04-23 17:58:53.931+0200 I/utils   (  358): es.ugr.frailty.gyroscope sensor supported
04-23 17:58:53.941+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (358) was created
04-23 17:58:53.941+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [358]
04-23 17:58:53.951+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(358)
04-23 17:58:53.951+0200 I/servicemanager(32623): es.ugr.frailty.gyroscope launch request sent!
04-23 17:58:53.951+0200 I/servicemanager(32623): App control destroyed.
04-23 17:58:53.951+0200 I/servicemanager(32623): es.ugr.frailty.heartrate alive timeout
04-23 17:58:53.951+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 17:58:53.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:53.971+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:53.971+0200 I/utils   (  358): es.ugr.frailty.gyroscope listener started
04-23 17:58:53.971+0200 W/CAPI_APPFW_APP_CONTROL(  358): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:53.971+0200 I/utils   (  358): specific action
04-23 17:58:53.981+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 377
04-23 17:58:53.981+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:58:54.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 377
04-23 17:58:54.031+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(377) type(svcapp) bg(0)
04-23 17:58:54.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:58:54.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 358
04-23 17:58:54.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:58:54.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 358
04-23 17:58:54.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:58:54.041+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(377)
04-23 17:58:54.041+0200 I/servicemanager(32623): es.ugr.frailty.heartrate launch request sent!
04-23 17:58:54.051+0200 I/servicemanager(32623): App control destroyed.
04-23 17:58:54.051+0200 E/CAPI_APPFW_APPLICATION(  377): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:58:54.051+0200 E/CAPI_APPFW_APPLICATION(  377): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:58:54.051+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (377) was created
04-23 17:58:54.051+0200 I/utils   (  377): trying to start service: es.ugr.frailty.heartrate
04-23 17:58:54.061+0200 I/utils   (  377): es.ugr.frailty.heartrate sensor supported
04-23 17:58:54.071+0200 I/utils   (  377): es.ugr.frailty.heartrate listener started
04-23 17:58:54.071+0200 W/CAPI_APPFW_APP_CONTROL(  377): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:54.071+0200 I/utils   (  377): specific action
04-23 17:58:54.071+0200 I/servicemanager(32623): es.ugr.frailty.pedometer alive timeout
04-23 17:58:54.071+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
04-23 17:58:54.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:54.071+0200 E/AUL_AMD ( 2476): amd_request.c: __request_handler(693) > no appinfo
04-23 17:58:54.071+0200 E/AUL_AMD ( 2476): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
04-23 17:58:54.071+0200 E/AUL_AMD ( 2476): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
04-23 17:58:54.071+0200 E/AUL_AMD ( 2476): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
04-23 17:58:54.071+0200 E/AUL_AMD ( 2476): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
04-23 17:58:54.071+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:54.071+0200 E/AUL_AMD ( 2476): amd_launch.c: _start_app(1795) > no appinfo
04-23 17:58:54.071+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:58:54.081+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
04-23 17:58:54.081+0200 E/CAPI_APPFW_APP_CONTROL(32623): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
04-23 17:58:54.081+0200 E/servicemanager(32623): es.ugr.frailty.pedometer launch request sending failed!
04-23 17:58:54.081+0200 I/servicemanager(32623): App control destroyed.
04-23 17:58:54.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:58:54.101+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [377]
04-23 17:58:54.111+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:54.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:58:54.121+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:54.121+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 377
04-23 17:58:54.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:58:54.121+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:54:116,107.520004,-6.370000,-25.059999
04-23 17:58:54.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:58:54.131+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:54:130,9.494720,0.861416,0.614955
04-23 17:58:54.131+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 377
04-23 17:58:54.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:58:54.221+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:54.221+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:54.231+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:54:233,9.509077,2.943172,-1.198804
04-23 17:58:54.231+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:54:233,-10.500000,-15.330000,-18.549999
04-23 17:58:54.281+0200 I/heartrate(  377): capturing data from es.ugr.frailty.heartrate
04-23 17:58:54.281+0200 I/heartrate(  377): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:54.391+0200 I/servicemanager(32623): es.ugr.frailty.location alive timeout
04-23 17:58:54.391+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:58:54.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:58:54.391+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 32623
04-23 17:58:54.411+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 393
04-23 17:58:54.411+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:58:54.421+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:54.431+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:54.441+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:54:435,9.363115,3.146562,-0.370888
04-23 17:58:54.441+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:54:434,-39.689999,-4.970000,2.100000
04-23 17:58:54.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 393
04-23 17:58:54.461+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(393) type(svcapp) bg(0)
04-23 17:58:54.471+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [393]
04-23 17:58:54.471+0200 W/AUL     (32623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(393)
04-23 17:58:54.471+0200 I/servicemanager(32623): es.ugr.frailty.location launch request sent!
04-23 17:58:54.471+0200 I/servicemanager(32623): App control destroyed.
04-23 17:58:54.491+0200 I/heartrate(  377): capturing data from es.ugr.frailty.heartrate
04-23 17:58:54.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:58:54.501+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 393
04-23 17:58:54.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:58:54.511+0200 I/heartrate(  377): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:54.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:58:54.541+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 393
04-23 17:58:54.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:58:54.581+0200 E/CAPI_APPFW_APPLICATION(  393): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:58:54.581+0200 E/CAPI_APPFW_APPLICATION(  393): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:58:54.581+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (393) was created
04-23 17:58:54.611+0200 W/LOCATION(  393): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:58:54.611+0200 E/LOCATION(  393): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:58:54.611+0200 E/PKGMGR_INFO(  393): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:58:54.611+0200 W/LOCATION(  393): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:58:54.631+0200 I/LOCATION(  393): location.c: location_new(269) > method: 0
04-23 17:58:54.631+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:54.641+0200 W/LOCATION(  393): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:58:54.641+0200 W/LOCATION(  393): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:58:54.651+0200 W/LOCATION(  393): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:58:54.651+0200 W/LOCATION(  393): module-internal.c: module_new(311) > module (gps) open success
04-23 17:58:54.661+0200 W/LOCATION(  393): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:58:54.661+0200 W/LOCATION(  393): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:58:54.661+0200 W/LOCATION(  393): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:58:54.661+0200 W/LOCATION(  393): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:58:54.661+0200 W/LOCATION(  393): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:58:54.671+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:54.671+0200 I/heartrate(  377): capturing data from es.ugr.frailty.heartrate
04-23 17:58:54.671+0200 I/heartrate(  377): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:54.681+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:54:677,9.458827,2.677568,-0.143569
04-23 17:58:54.681+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:54:644,0.210000,2.100000,1.050000
04-23 17:58:54.691+0200 W/LOCATION(  393): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:58:54.691+0200 W/LOCATION(  393): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:58:54.691+0200 W/LOCATION(  393): module-internal.c: module_new(311) > module (wps) open success
04-23 17:58:54.701+0200 W/LOCATION(  393): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:58:54.701+0200 W/LOCATION(  393): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:58:54.701+0200 W/LOCATION(  393): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:58:54.701+0200 W/LOCATION(  393): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:58:54.721+0200 W/LOCATION(  393): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:58:54.721+0200 I/LOCATION(  393): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7811c18
04-23 17:58:54.721+0200 I/LOCATION(  393): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:58:54.721+0200 I/LOCATION(  393): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7811c18
04-23 17:58:54.721+0200 I/LOCATION(  393): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:58:54.721+0200 I/location(  393): es.ugr.frailty.location: creado servicio de localización
04-23 17:58:54.771+0200 I/LOCATION(  393): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:58:54.801+0200 W/LOCATION(  393): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:58:54.801+0200 W/LOCATION(  393): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:58:54.801+0200 I/LOCATION(  393): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:58:54.821+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:54.831+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:54.841+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:54:832,-31.850000,-5.600000,11.690000
04-23 17:58:54.841+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:54:835,9.499505,2.888137,-0.086142
04-23 17:58:54.871+0200 I/heartrate(  377): capturing data from es.ugr.frailty.heartrate
04-23 17:58:54.871+0200 I/heartrate(  377): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:54.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:58:54.871+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:58:54.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:58:54.871+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:58:54.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:58:54.871+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:58:54.871+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:58:54.871+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:58:54.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:58:54.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:58:54.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:58:54.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:58:54.881+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:58:54.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:58:54.881+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:58:54.881+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:58:54.881+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:58:54.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:58:54.931+0200 W/LOCATION(  393): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:58:54.931+0200 W/LOCATION(  393): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:58:55.021+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:58:55.091+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.091+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:95,-142.169998,-12.530000,47.950001
04-23 17:58:55.091+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.101+0200 I/CAPI_NETWORK_CONNECTION(32679): connection.c: connection_create(453) > New handle created[0xf41250e0]
04-23 17:58:55.101+0200 I/CAPI_NETWORK_CONNECTION(32679): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:58:55.101+0200 I/CAPI_NETWORK_CONNECTION(32679): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:58:55.101+0200 I/CAPI_NETWORK_CONNECTION(32679): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:58:55.101+0200 I/CAPI_NETWORK_CONNECTION(32679): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:58:55.111+0200 W/LOCATION(32679): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:58:55.111+0200 W/LOCATION(32679): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:58:55.121+0200 I/AUL     (32679): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:58:55.131+0200 I/AUL     (32679): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:58:55.131+0200 E/LOCATION(32679): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:58:55.131+0200 I/LOCATION(32679): location.c: location_new(269) > method: 1
04-23 17:58:55.131+0200 W/LOCATION(32679): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:58:55.131+0200 W/LOCATION(32679): module-internal.c: module_new(311) > module (gps) open success
04-23 17:58:55.131+0200 W/LOCATION(32679): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:58:55.131+0200 W/LOCATION(32679): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:58:55.141+0200 W/LOCATION(32679): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:58:55.141+0200 W/LOCATION(32679): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:58:55.141+0200 W/LOCATION(32679): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:58:55.151+0200 I/AUL     (32679): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:58:55.161+0200 I/AUL     (32679): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:58:55.161+0200 E/LOCATION(32679): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:58:55.161+0200 I/heartrate(  377): capturing data from es.ugr.frailty.heartrate
04-23 17:58:55.161+0200 I/heartrate(  377): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:55.161+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:95,9.731609,2.804388,-0.957129
04-23 17:58:55.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:58:55.201+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:58:55.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 17:58:55.201+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.201+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 174 ms (from 13030694 to 13030868) (logOverhead=0,0,0,0,0,0,0), start: 17:58:55.039
04-23 17:58:55.201+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 174 ms (from 13030694 to 13030868) (logOverhead=0,0,0,0,0,0,0), start: 17:58:55.039
04-23 17:58:55.211+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 17:58:55.211+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:58:55.211+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:58:55.211+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(13030875), time2(13020413)
04-23 17:58:55.211+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:58:55.211+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:58:55.221+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:58:55.221+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:58:55.221+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:211,5.740000,25.270000,38.220001
04-23 17:58:55.231+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:58:55.241+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:242,-43.680000,48.650002,31.850000
04-23 17:58:55.241+0200 E/CAPI_LOCATION_MANAGER(32679): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:58:55.241+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.251+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.251+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:257,-60.480000,44.240002,28.490000
04-23 17:58:55.251+0200 I/AUL     (32679): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:58:55.261+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:252,9.365508,-1.351945,0.086142
04-23 17:58:55.261+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.261+0200 I/AUL     (32679): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:58:55.261+0200 E/LOCATION(32679): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 17:58:55.261+0200 I/LOCATION(32679): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 17:58:55.261+0200 I/LOCATION(32679): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:58:55.271+0200 I/heartrate(  377): capturing data from es.ugr.frailty.heartrate
04-23 17:58:55.271+0200 I/heartrate(  377): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:55.281+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:271,9.724431,-2.237289,0.636491
04-23 17:58:55.281+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.281+0200 W/LOCATION(  393): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:58:55.281+0200 I/LOCATION(  393): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:58:55.281+0200 I/LOCATION(  393): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:58:55.281+0200 I/location(  393): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:58:55.281+0200 W/CAPI_APPFW_APP_CONTROL(  393): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:55.281+0200 I/utils   (  393): specific action
04-23 17:58:55.291+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:275,-75.599998,31.780001,19.320000
04-23 17:58:55.291+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.291+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.291+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:298,-69.860001,34.930000,5.950000
04-23 17:58:55.301+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:298,10.066606,-2.957529,1.155733
04-23 17:58:55.301+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.301+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:311,-63.980000,32.619999,-4.970000
04-23 17:58:55.311+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.311+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:315,9.939785,-1.974079,1.150948
04-23 17:58:55.321+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.331+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:334,-92.610001,29.889999,-7.140000
04-23 17:58:55.331+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.331+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:338,9.442079,-1.155733,1.332802
04-23 17:58:55.331+0200 I/LOCATION(  393): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:58:55.341+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.341+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:351,-100.309998,19.670000,-13.160000
04-23 17:58:55.351+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.351+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:355,9.908678,-2.261217,1.299303
04-23 17:58:55.361+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.361+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:371,-81.690002,23.799999,-21.420000
04-23 17:58:55.371+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.371+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:375,10.219746,-1.933401,1.282553
04-23 17:58:55.381+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.381+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.391+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:394,9.542577,-0.870987,1.634298
04-23 17:58:55.391+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:391,-69.510002,29.330000,-24.920000
04-23 17:58:55.401+0200 I/gyroscope(  358): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:55.401+0200 I/gyroscope(  358): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:55:411,-61.810001,21.280001,-26.040001
04-23 17:58:55.411+0200 I/accelerometer(  331): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:55.411+0200 I/accelerometer(  331): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:55:415,9.506684,-1.342373,1.682154
04-23 17:58:55.441+0200 W/CRASH_MANAGER(32756): worker.c: worker_job(1205) > 11003936c6f63152449913
