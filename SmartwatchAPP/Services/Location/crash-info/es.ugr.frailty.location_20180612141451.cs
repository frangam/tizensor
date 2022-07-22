S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11767
Date: 2018-06-12 14:14:51+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf708a52d, r5   = 0xf766d150
r6   = 0xfffca550, r7   = 0xfffca400
r8   = 0xf767fc18, r9   = 0x00000000
r10  = 0xfffca4dc, fp   = 0xfffca550
ip   = 0x00000001, sp   = 0xfffca3d8
lr   = 0xf708a539, pc   = 0xf70f3228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    171456 KB
Buffers:     32532 KB
Cached:     144296 KB
VmPeak:      53708 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11852 KB
VmRSS:       11852 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11767 TID = 11767
11767 11793 

Maps Information
f3f55000 f4754000 rw-p [stack:11793]
f475b000 f475d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4765000 f4769000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4772000 f4774000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f477c000 f477f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f478e000 f4793000 r-xp /usr/lib/libsystem.so.0.0.0
f479e000 f47a1000 r-xp /lib/libattr.so.1.1.0
f47a9000 f47b9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47c1000 f47ca000 r-xp /usr/lib/libedbus.so.1.7.99
f47d2000 f47d3000 r-xp /usr/lib/libresponse.so.0.2.96
f47dc000 f47e1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6083000 f6189000 r-xp /usr/lib/libicuuc.so.57.1
f619f000 f6327000 r-xp /usr/lib/libicui18n.so.57.1
f6337000 f6344000 r-xp /usr/lib/libail.so.0.1.0
f634d000 f6354000 r-xp /usr/lib/libminizip.so.1.0.0
f635d000 f6506000 r-xp /usr/lib/libcrypto.so.1.0.0
f6526000 f656d000 r-xp /usr/lib/libssl.so.1.0.0
f6579000 f657b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6583000 f658a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6593000 f659a000 r-xp /lib/libcrypt-2.13.so
f65cb000 f65ce000 r-xp /lib/libcap.so.2.21
f65d6000 f65d8000 r-xp /usr/lib/libiri.so
f65e0000 f6629000 r-xp /usr/lib/libmdm.so.1.2.69
f6631000 f6637000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f663f000 f6662000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f666c000 f666e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6676000 f6693000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f669c000 f66a0000 r-xp /usr/lib/libsmack.so.1.0.0
f66a9000 f66c2000 r-xp /usr/lib/libnetwork.so.0.0.0
f66cb000 f66d3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66db000 f66e1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66ea000 f66ec000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66f5000 f6705000 r-xp /lib/libresolv-2.13.so
f6709000 f6721000 r-xp /usr/lib/liblzma.so.5.0.3
f672a000 f672c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6734000 f674e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6756000 f6785000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f678e000 f679d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67a7000 f67b1000 r-xp /usr/lib/libsensord-shared.so
f67ba000 f688d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6898000 f68ae000 r-xp /lib/libz.so.1.2.5
f68b6000 f68bb000 r-xp /usr/lib/libffi.so.5.0.10
f68c3000 f68c4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68cc000 f68dc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68e4000 f68fd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6905000 f6907000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f690f000 f6984000 r-xp /usr/lib/libsqlite3.so.0.8.6
f698e000 f6994000 r-xp /lib/librt-2.13.so
f699d000 f69bb000 r-xp /usr/lib/libsystemd.so.0.4.0
f69c5000 f69c6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69ce000 f69f1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69f9000 f69fe000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a06000 f6a30000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a39000 f6a50000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a58000 f6ac1000 r-xp /lib/libm-2.13.so
f6aca000 f6b5e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b71000 f6b76000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b7e000 f6b85000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b8d000 f6bb7000 r-xp /usr/lib/libsensor.so.1.9.6
f6bc0000 f6c8c000 r-xp /usr/lib/libxml2.so.2.7.8
f6c99000 f6c9b000 r-xp /usr/lib/libiniparser.so.0
f6ca4000 f6caa000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cb3000 f6d83000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d84000 f6db8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dc1000 f6dfd000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e05000 f6e08000 r-xp /usr/lib/libbundle.so.0.1.22
f6e10000 f6e16000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e1e000 f6e5f000 r-xp /usr/lib/libeina.so.1.7.99
f6e68000 f6e7f000 r-xp /usr/lib/libecore.so.1.7.99
f6e96000 f6e9f000 r-xp /usr/lib/libvconf.so.0.2.45
f6ea7000 f6ebb000 r-xp /lib/libpthread-2.13.so
f6ec6000 f6ed3000 r-xp /usr/lib/libaul.so.0.1.0
f6edd000 f6edf000 r-xp /lib/libdl-2.13.so
f6ee8000 f6ef3000 r-xp /lib/libunwind.so.8.0.1
f6f20000 f6f28000 r-xp /lib/libgcc_s-4.6.so.1
f6f29000 f704d000 r-xp /lib/libc-2.13.so
f705b000 f705d000 r-xp /usr/lib/libdlog.so.0.0.0
f7065000 f7071000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f707a000 f707f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7087000 f7096000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f709e000 f70a2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70ab000 f70ae000 r-xp /usr/lib/libappcore-agent.so.1.1
f70b6000 f70b8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70c0000 f70c4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70cc000 f70e9000 r-xp /lib/ld-2.13.so
f70f2000 f70f5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70f5000 f70f9000 r-xp /usr/lib/libsys-assert.so
f764f000 f76bd000 rw-p [heap]
fffab000 fffcc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11767)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70f3228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf708a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d913f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d8fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d9be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6da1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6da1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dd675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6dd11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d8fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d9be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6da1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6da1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6dd3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dd4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ddbf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47731fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4766171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6839663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ce6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ce87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e78ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e73b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e745a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e74879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70ac183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70ac7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70f35c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f4085c) [/lib/libc.so.6] + 0x1785c
29: (0xf70f2f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
_real_send(909) > send fail to client
06-12 14:14:49.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(11723), cmd(0)
06-12 14:14:49.481+0200 I/light   (11800): es.ugr.frailty.light: SM-R760,12/06/2018,14:14:49:489,37.000000
06-12 14:14:49.481+0200 W/AUL     (11800): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:49.491+0200 I/utils   (11726): specific action
06-12 14:14:49.491+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.491+0200 I/recorder(11726): saving local data for es.ugr.frailty.accelerometer
06-12 14:14:49.491+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:14:49.491+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.491+0200 I/utils   (11726): specific action
06-12 14:14:49.491+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.491+0200 I/recorder(11726): saving local data for es.ugr.frailty.accelerometer
06-12 14:14:49.491+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:14:49.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:14:49.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11794
06-12 14:14:49.521+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:49.521+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:49.531+0200 I/utils   (11812): es.ugr.frailty.pedometer sensor supported
06-12 14:14:49.531+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:49.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(40) , send fd(21), pid(11726), cmd(0)
06-12 14:14:49.531+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:49.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(11726), cmd(0)
06-12 14:14:49.541+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (11812) was created
06-12 14:14:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:49.561+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:14:49.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:49.591+0200 I/LOCATION(11767): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 14:14:49.591+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:49.591+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:49.591+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:14:49.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:49.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:49.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:49.611+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11782
06-12 14:14:49.621+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:49.631+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:49.631+0200 I/gravity (11782): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:49.631+0200 I/gravity (11782): es.ugr.frailty.gravity - capturing data
06-12 14:14:49.641+0200 I/gravity (11782): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:14:49:644,0.219334,0.058228,9.804024
06-12 14:14:49.641+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:49.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:49.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:14:49.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:14:49.651+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.651+0200 I/utils   (11726): specific action
06-12 14:14:49.651+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.661+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.661+0200 I/recorder(11726): saving local data for es.ugr.frailty.gyroscope
06-12 14:14:49.661+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:14:49.661+0200 I/utils   (11812): es.ugr.frailty.pedometer listener started
06-12 14:14:49.671+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11726)
06-12 14:14:49.671+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.recorder
06-12 14:14:49.671+0200 I/servicemanager(11723): requesting to save local data
06-12 14:14:49.671+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.671+0200 I/utils   (11723): specific action
06-12 14:14:49.671+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:14:49.671+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:14:49.671+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:14:49:598,0.007719,0.016979,-0.082496
06-12 14:14:49.671+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:49.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:14:49.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:49.711+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:49.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(11723), cmd(0)
06-12 14:14:49.721+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:49.721+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:49.721+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:49.731+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:49.731+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:14:49.731+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:49.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(40) , send fd(21), pid(11726), cmd(0)
06-12 14:14:49.741+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:14:49:736,0.155533,0.043071,9.901501
06-12 14:14:49.741+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:49.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:49.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11733
06-12 14:14:49.761+0200 I/location(11767): es.ugr.frailty.location: waiting for rigth values
06-12 14:14:49.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:49.771+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:49.771+0200 I/gyroscope(11733): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:49.771+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope - capturing data
06-12 14:14:49.771+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:14:49:778,0.070000,-0.210000,-0.070000
06-12 14:14:49.771+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:49.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:49.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:49.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:14:49.811+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11767
06-12 14:14:49.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:49.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11800
06-12 14:14:49.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:49.851+0200 W/AUL     (11800): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:49.851+0200 I/light   (11800): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:49.851+0200 I/light   (11800): es.ugr.frailty.light - capturing data
06-12 14:14:49.851+0200 I/light   (11800): es.ugr.frailty.light: SM-R760,12/06/2018,14:14:49:858,37.000000
06-12 14:14:49.851+0200 W/AUL     (11800): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:49.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:14:49.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:49.911+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11782
06-12 14:14:49.911+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:49.911+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:49.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:49.931+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:49.931+0200 I/gravity (11782): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:49.931+0200 I/gravity (11782): es.ugr.frailty.gravity - capturing data
06-12 14:14:49.941+0200 I/gravity (11782): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:14:49:937,0.213342,0.071776,9.804067
06-12 14:14:49.941+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:49.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:49.951+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:14:49.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:14:49.961+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.961+0200 I/utils   (11726): specific action
06-12 14:14:49.961+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.961+0200 I/recorder(11726): saving local data for es.ugr.frailty.accelerometer
06-12 14:14:49.961+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:14:49.971+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11726)
06-12 14:14:49.971+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.recorder
06-12 14:14:49.971+0200 I/servicemanager(11723): requesting to save local data
06-12 14:14:49.971+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.971+0200 I/utils   (11723): specific action
06-12 14:14:49.971+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:49.971+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:14:49.971+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:14:49.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:49.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:14:49.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:49.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:50.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.021+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.021+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.021+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:14:50.021+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:50.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(21), pid(11723), cmd(0)
06-12 14:14:50.021+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:14:50:24,-0.049709,0.100728,0.022788
06-12 14:14:50.021+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:50.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(48) , send fd(21), pid(11726), cmd(0)
06-12 14:14:50.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.071+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:14:50.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.101+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.101+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.101+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:14:50.111+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:14:50:110,0.186640,0.083749,9.906286
06-12 14:14:50.111+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.111+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:50.111+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:50.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11733
06-12 14:14:50.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.181+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.181+0200 I/gyroscope(11733): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.181+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope - capturing data
06-12 14:14:50.191+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:14:50.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:14:50.191+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:14:50.191+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:14:50:191,0.070000,-0.210000,-0.070000
06-12 14:14:50.191+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:50.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:50.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:14:50.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.231+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11800
06-12 14:14:50.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:14:50.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11800
06-12 14:14:50.281+0200 W/AUL     (11800): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.281+0200 I/light   (11800): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.281+0200 I/light   (11800): es.ugr.frailty.light - capturing data
06-12 14:14:50.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.301+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11782
06-12 14:14:50.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.311+0200 E/CAPI_TELEPHONY(11795): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:14:50.321+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:50.321+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:50.321+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.331+0200 I/gravity (11782): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.331+0200 I/gravity (11782): es.ugr.frailty.gravity - capturing data
06-12 14:14:50.341+0200 I/gravity (11782): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:14:50:334,0.209101,0.075684,9.804129
06-12 14:14:50.341+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.341+0200 I/light   (11800): es.ugr.frailty.light: SM-R760,12/06/2018,14:14:50:288,37.000000
06-12 14:14:50.341+0200 W/AUL     (11800): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:14:50.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:14:50.351+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.351+0200 I/utils   (11726): specific action
06-12 14:14:50.351+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.351+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.351+0200 I/recorder(11726): saving local data for es.ugr.frailty.gyroscope
06-12 14:14:50.351+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:14:50.361+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11726)
06-12 14:14:50.361+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.recorder
06-12 14:14:50.371+0200 I/servicemanager(11723): requesting to save local data
06-12 14:14:50.371+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.371+0200 I/utils   (11723): specific action
06-12 14:14:50.371+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:14:50.371+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:14:50.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:50.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:50.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:14:50.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:14:50.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:14:50.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:14:50.401+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:14:50.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.421+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.421+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.421+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:14:50.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:50.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(21), pid(11723), cmd(0)
06-12 14:14:50.431+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:14:50:425,0.067929,0.000953,0.063569
06-12 14:14:50.431+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.431+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:50.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(52) , send fd(21), pid(11726), cmd(0)
06-12 14:14:50.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.451+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:14:50.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.471+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.471+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.471+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:14:50.481+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:14:50:483,0.200997,0.081356,9.722038
06-12 14:14:50.481+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.501+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:50.501+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:50.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11733
06-12 14:14:50.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.531+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.531+0200 I/gyroscope(11733): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.531+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope - capturing data
06-12 14:14:50.541+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:14:50:535,0.070000,-0.210000,-0.070000
06-12 14:14:50.541+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:14:50.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11769
06-12 14:14:50.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:14:50.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:50.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:50.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.621+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11782
06-12 14:14:50.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11800
06-12 14:14:50.671+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.701+0200 W/AUL     (11800): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.701+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:50.701+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:50.701+0200 I/light   (11800): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.701+0200 I/light   (11800): es.ugr.frailty.light - capturing data
06-12 14:14:50.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:14:50.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:14:50.731+0200 I/gravity (11782): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.731+0200 I/gravity (11782): es.ugr.frailty.gravity - capturing data
06-12 14:14:50.741+0200 I/gravity (11782): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:14:50:739,0.209034,0.071809,9.804159
06-12 14:14:50.741+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11726)
06-12 14:14:50.741+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.recorder
06-12 14:14:50.741+0200 I/servicemanager(11723): requesting to save local data
06-12 14:14:50.741+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.741+0200 I/utils   (11723): specific action
06-12 14:14:50.741+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.741+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:14:50.741+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:14:50.741+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.751+0200 I/light   (11800): es.ugr.frailty.light: SM-R760,12/06/2018,14:14:50:709,37.000000
06-12 14:14:50.751+0200 W/AUL     (11800): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.751+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.751+0200 I/utils   (11726): specific action
06-12 14:14:50.751+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.751+0200 I/recorder(11726): saving local data for es.ugr.frailty.accelerometer
06-12 14:14:50.751+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:14:50.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.771+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:14:50.781+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.791+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.791+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.791+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:14:50.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:50.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:50.791+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:50.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(21), pid(11723), cmd(0)
06-12 14:14:50.801+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:14:50:798,-0.015820,-0.032547,0.092283
06-12 14:14:50.801+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.811+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:50.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(56) , send fd(21), pid(11726), cmd(0)
06-12 14:14:50.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:14:50.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.851+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.851+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.851+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:14:50.851+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:14:50:858,0.143569,0.165105,9.827322
06-12 14:14:50.851+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.871+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11733
06-12 14:14:50.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:50.891+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:50.891+0200 I/gyroscope(11733): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:50.891+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope - capturing data
06-12 14:14:50.891+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:14:50:898,0.070000,-0.280000,-0.070000
06-12 14:14:50.891+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:50.911+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:50.911+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:50.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:14:50.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:14:50.941+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11812
06-12 14:14:50.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:50.971+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:14:50.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:14:50.981+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.981+0200 I/utils   (11726): specific action
06-12 14:14:50.981+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.981+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.981+0200 I/recorder(11726): saving local data for es.ugr.frailty.gyroscope
06-12 14:14:50.981+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:14:50.991+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11726)
06-12 14:14:50.991+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.recorder
06-12 14:14:50.991+0200 I/servicemanager(11723): requesting to save local data
06-12 14:14:50.991+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.991+0200 I/utils   (11723): specific action
06-12 14:14:50.991+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.991+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.991+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.991+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:50.991+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:14:50.991+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:14:50.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:50.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:51.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11782
06-12 14:14:51.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:51.031+0200 W/LOCATION(11767): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:14:51.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:51.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(21), pid(11723), cmd(0)
06-12 14:14:51.041+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:51.041+0200 I/gravity (11782): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:51.041+0200 I/gravity (11782): es.ugr.frailty.gravity - capturing data
06-12 14:14:51.051+0200 I/gravity (11782): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:14:51:51,0.206397,0.076461,9.804179
06-12 14:14:51.051+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:51.051+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:51.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(58) , send fd(21), pid(11726), cmd(0)
06-12 14:14:51.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.071+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11800
06-12 14:14:51.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:51.101+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:51.111+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:51.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:14:51.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:51.131+0200 W/AUL     (11800): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:51.131+0200 I/light   (11800): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:51.131+0200 I/light   (11800): es.ugr.frailty.light - capturing data
06-12 14:14:51.131+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:51.131+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:51.131+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:14:51.141+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:14:51:137,0.024789,0.012583,-0.111195
06-12 14:14:51.141+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:51.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:14:51.161+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:51.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:14:51.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:14:51.191+0200 I/light   (11800): es.ugr.frailty.light: SM-R760,12/06/2018,14:14:51:134,37.000000
06-12 14:14:51.191+0200 W/AUL     (11800): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:51.191+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:14:51.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:51.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:51.201+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:51.201+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:51.201+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:14:51.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11733
06-12 14:14:51.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:51.231+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:51.231+0200 I/gyroscope(11733): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:51.231+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope - capturing data
06-12 14:14:51.231+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:14:51:235,0.070000,-0.280000,-0.070000
06-12 14:14:51.231+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:51.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:14:51.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:14:51.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11782
06-12 14:14:51.291+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:14:51:205,0.251246,0.100499,9.868000
06-12 14:14:51.291+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:51.301+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:51.301+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:51.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:14:51.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:14:51.321+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:51.321+0200 I/utils   (11726): specific action
06-12 14:14:51.321+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:51.321+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:51.321+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:51.321+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:51.321+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:51.321+0200 I/recorder(11726): saving local data for es.ugr.frailty.linearacceleration
06-12 14:14:51.321+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:14:51.341+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11726)
06-12 14:14:51.351+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.recorder
06-12 14:14:51.351+0200 I/servicemanager(11723): requesting to save local data
06-12 14:14:51.351+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:14:51.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11782
06-12 14:14:51.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:51.391+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:51.391+0200 I/gravity (11782): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:51.391+0200 I/gravity (11782): es.ugr.frailty.gravity - capturing data
06-12 14:14:51.391+0200 I/gravity (11782): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:14:51:396,0.207702,0.069614,9.804203
06-12 14:14:51.391+0200 W/AUL     (11782): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:14:51.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:14:51.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:14:51.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:51.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(62) , send fd(21), pid(11726), cmd(0)
06-12 14:14:51.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:14:51.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:14:51.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:14:51.401+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:14:51.411+0200 I/utils   (11723): specific action
06-12 14:14:51.411+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:14:51.411+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:14:51.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:14:51.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:51.441+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:14:51.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(21), pid(11723), cmd(0)
06-12 14:14:51.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11800
06-12 14:14:51.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:51.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:14:51.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11733
06-12 14:14:51.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:14:51.531+0200 I/heartrate(11754): es.ugr.frailty.heartrate - capturing data
06-12 14:14:51.541+0200 W/AUL     (11733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:14:51.551+0200 I/heartrate(11754): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:14:51.551+0200 I/gyroscope(11733): request sent to service es.ugr.frailty.servicemanager
06-12 14:14:51.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:14:51.561+0200 I/gyroscope(11733): es.ugr.frailty.gyroscope - capturing data
06-12 14:14:51.581+0200 W/CRASH_MANAGER(11848): worker.c: worker_job(1205) > 11117676c6f63152880569
