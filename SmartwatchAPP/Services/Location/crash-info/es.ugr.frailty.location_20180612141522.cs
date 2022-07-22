S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12050
Date: 2018-06-12 14:15:22+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76f052d, r5   = 0xf7cfc150
r6   = 0xffa17170, r7   = 0xffa17020
r8   = 0xf7d0ec18, r9   = 0x00000000
r10  = 0xffa170fc, fp   = 0xffa17170
ip   = 0x00000001, sp   = 0xffa16ff8
lr   = 0xf76f0539, pc   = 0xf7759228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    170160 KB
Buffers:     32712 KB
Cached:     145360 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11704 KB
VmRSS:       11704 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12050 TID = 12050
12050 12052 

Maps Information
f45bb000 f4dba000 rw-p [stack:12052]
f4dc1000 f4dc3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dcb000 f4dcf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dd8000 f4dda000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4de2000 f4de5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4df4000 f4df9000 r-xp /usr/lib/libsystem.so.0.0.0
f4e04000 f4e07000 r-xp /lib/libattr.so.1.1.0
f4e0f000 f4e1f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e27000 f4e30000 r-xp /usr/lib/libedbus.so.1.7.99
f4e38000 f4e39000 r-xp /usr/lib/libresponse.so.0.2.96
f4e42000 f4e47000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66e9000 f67ef000 r-xp /usr/lib/libicuuc.so.57.1
f6805000 f698d000 r-xp /usr/lib/libicui18n.so.57.1
f699d000 f69aa000 r-xp /usr/lib/libail.so.0.1.0
f69b3000 f69ba000 r-xp /usr/lib/libminizip.so.1.0.0
f69c3000 f6b6c000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b8c000 f6bd3000 r-xp /usr/lib/libssl.so.1.0.0
f6bdf000 f6be1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6be9000 f6bf0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bf9000 f6c00000 r-xp /lib/libcrypt-2.13.so
f6c31000 f6c34000 r-xp /lib/libcap.so.2.21
f6c3c000 f6c3e000 r-xp /usr/lib/libiri.so
f6c46000 f6c8f000 r-xp /usr/lib/libmdm.so.1.2.69
f6c97000 f6c9d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ca5000 f6cc8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cd2000 f6cd4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cdc000 f6cf9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d02000 f6d06000 r-xp /usr/lib/libsmack.so.1.0.0
f6d0f000 f6d28000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d31000 f6d39000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d41000 f6d47000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d50000 f6d52000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d5b000 f6d6b000 r-xp /lib/libresolv-2.13.so
f6d6f000 f6d87000 r-xp /usr/lib/liblzma.so.5.0.3
f6d90000 f6d92000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d9a000 f6db4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dbc000 f6deb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6df4000 f6e03000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e0d000 f6e17000 r-xp /usr/lib/libsensord-shared.so
f6e20000 f6ef3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6efe000 f6f14000 r-xp /lib/libz.so.1.2.5
f6f1c000 f6f21000 r-xp /usr/lib/libffi.so.5.0.10
f6f29000 f6f2a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f32000 f6f42000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f4a000 f6f63000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f6b000 f6f6d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f75000 f6fea000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ff4000 f6ffa000 r-xp /lib/librt-2.13.so
f7003000 f7021000 r-xp /usr/lib/libsystemd.so.0.4.0
f702b000 f702c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7034000 f7057000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f705f000 f7064000 r-xp /usr/lib/libxdgmime.so.1.1.0
f706c000 f7096000 r-xp /usr/lib/libdbus-1.so.3.8.12
f709f000 f70b6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70be000 f7127000 r-xp /lib/libm-2.13.so
f7130000 f71c4000 r-xp /usr/lib/libstdc++.so.6.0.16
f71d7000 f71dc000 r-xp /usr/lib/libctx-client.so.0.8.3
f71e4000 f71eb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71f3000 f721d000 r-xp /usr/lib/libsensor.so.1.9.6
f7226000 f72f2000 r-xp /usr/lib/libxml2.so.2.7.8
f72ff000 f7301000 r-xp /usr/lib/libiniparser.so.0
f730a000 f7310000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7319000 f73e9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73ea000 f741e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7427000 f7463000 r-xp /usr/lib/libSLP-location.so.0.9.24
f746b000 f746e000 r-xp /usr/lib/libbundle.so.0.1.22
f7476000 f747c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7484000 f74c5000 r-xp /usr/lib/libeina.so.1.7.99
f74ce000 f74e5000 r-xp /usr/lib/libecore.so.1.7.99
f74fc000 f7505000 r-xp /usr/lib/libvconf.so.0.2.45
f750d000 f7521000 r-xp /lib/libpthread-2.13.so
f752c000 f7539000 r-xp /usr/lib/libaul.so.0.1.0
f7543000 f7545000 r-xp /lib/libdl-2.13.so
f754e000 f7559000 r-xp /lib/libunwind.so.8.0.1
f7586000 f758e000 r-xp /lib/libgcc_s-4.6.so.1
f758f000 f76b3000 r-xp /lib/libc-2.13.so
f76c1000 f76c3000 r-xp /usr/lib/libdlog.so.0.0.0
f76cb000 f76d7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76e0000 f76e5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76ed000 f76fc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7704000 f7708000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7711000 f7714000 r-xp /usr/lib/libappcore-agent.so.1.1
f771c000 f771e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7726000 f772a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7732000 f774f000 r-xp /lib/ld-2.13.so
f7758000 f775b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f775b000 f775f000 r-xp /usr/lib/libsys-assert.so
f7cde000 f7d4c000 rw-p [heap]
ff9f8000 ffa19000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12050)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7759228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76f0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73f73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73f5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7401e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7407be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7407dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf743c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74371f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73f5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7401e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7407be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7407dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7439e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf743a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7441f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4dd91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dcc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e9f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf734cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf734e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74deca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74d9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74da5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74da879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7712183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77127fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77595c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75a685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7758f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
2050): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-12 14:15:20.681+0200 I/LOCATION(12050): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-12 14:15:20.681+0200 I/location(12050): es.ugr.frailty.location:iniciado servicio de localización
06-12 14:15:20.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:20.701+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:20.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:15:20.721+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:20.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:15:20.731+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:20.731+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:20.731+0200 I/gravity (12055): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:20.741+0200 I/heartrate(12037): es.ugr.frailty.heartrate - capturing data
06-12 14:15:20.741+0200 I/heartrate(12037): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:15:20.751+0200 I/gravity (12055): es.ugr.frailty.gravity - capturing data
06-12 14:15:20.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:20.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12024
06-12 14:15:20.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:20.771+0200 I/gravity (12055): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:15:20:757,0.262045,2.325557,9.523314
06-12 14:15:20.771+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:20.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:20.791+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:20.791+0200 I/gyroscope(12024): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:20.791+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope - capturing data
06-12 14:15:20.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:15:20.791+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:15:20:797,58.799999,-8.960000,-11.620000
06-12 14:15:20.791+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:20.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:20.821+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:20.821+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:20.821+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:15:20.821+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:15:20:827,0.125358,-0.097930,0.217068
06-12 14:15:20.821+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:20.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:20.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:15:20.831+0200 I/LOCATION(12050): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 14:15:20.841+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:15:20.841+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 12080
06-12 14:15:20.881+0200 I/location(12050): es.ugr.frailty.location: waiting for rigth values
06-12 14:15:20.881+0200 E/CAPI_APPFW_APPLICATION(12080): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:15:20.881+0200 E/CAPI_APPFW_APPLICATION(12080): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:15:20.891+0200 I/utils   (12080): trying to start service: es.ugr.frailty.light
06-12 14:15:20.891+0200 I/utils   (12080): es.ugr.frailty.light sensor supported
06-12 14:15:20.891+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12080
06-12 14:15:20.891+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.light) pid(12080) type(svcapp) bg(0)
06-12 14:15:20.901+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12080)
06-12 14:15:20.901+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.light
06-12 14:15:20.901+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:20.901+0200 I/servicemanager(11723): es.ugr.frailty.pedometer alive timeout
06-12 14:15:20.901+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-12 14:15:20.901+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12080]
06-12 14:15:20.911+0200 I/utils   (12080): es.ugr.frailty.light listener started
06-12 14:15:20.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:20.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:15:20.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:20.941+0200 I/heartrate(12037): es.ugr.frailty.heartrate - capturing data
06-12 14:15:20.941+0200 I/heartrate(12037): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:15:20.941+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:20.941+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:20.941+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:15:20.951+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:15:20:952,0.203390,0.110070,9.762716
06-12 14:15:20.951+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:20.951+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:20.951+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:20.961+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (12080) was created
06-12 14:15:20.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:15:20.981+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12055
06-12 14:15:20.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:20.991+0200 I/light   (12080): es.ugr.frailty.light - capturing data
06-12 14:15:20.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:15:21.001+0200 I/light   (12080): es.ugr.frailty.light: SM-R760,12/06/2018,14:15:21:1,56.000000
06-12 14:15:21.001+0200 W/AUL     (12080): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.001+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12055
06-12 14:15:21.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12055
06-12 14:15:21.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.041+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.041+0200 I/gravity (12055): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.041+0200 I/gravity (12055): es.ugr.frailty.gravity - capturing data
06-12 14:15:21.051+0200 I/gravity (12055): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:15:21:50,0.206940,2.253839,9.541896
06-12 14:15:21.051+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12024
06-12 14:15:21.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.081+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.081+0200 I/gyroscope(12024): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.081+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope - capturing data
06-12 14:15:21.081+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:15:21:87,49.980000,-32.060001,-8.750000
06-12 14:15:21.081+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.101+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:15:21.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.121+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.121+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.121+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:15:21.121+0200 I/heartrate(12037): es.ugr.frailty.heartrate - capturing data
06-12 14:15:21.121+0200 I/heartrate(12037): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:15:21.121+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:15:21:124,-0.111161,-0.118133,-0.108291
06-12 14:15:21.121+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:15:21.151+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:15:21.151+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 12091
06-12 14:15:21.191+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:15:21.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:15:21.191+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:15:21.191+0200 E/CAPI_APPFW_APPLICATION(12091): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:15:21.191+0200 E/CAPI_APPFW_APPLICATION(12091): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:15:21.191+0200 I/utils   (12091): trying to start service: es.ugr.frailty.pedometer
06-12 14:15:21.201+0200 I/utils   (12091): es.ugr.frailty.pedometer sensor supported
06-12 14:15:21.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12091
06-12 14:15:21.201+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(12091) type(svcapp) bg(0)
06-12 14:15:21.201+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12091]
06-12 14:15:21.201+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.201+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12091)
06-12 14:15:21.201+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.pedometer
06-12 14:15:21.201+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.211+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.211+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.211+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.221+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.221+0200 I/utils   (11723): specific action
06-12 14:15:21.221+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.221+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.221+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.221+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.221+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:15:21.221+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:15:21.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.221+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:15:21.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.241+0200 I/utils   (12091): es.ugr.frailty.pedometer listener started
06-12 14:15:21.251+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.251+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.251+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.251+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:15:21.261+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (12091) was created
06-12 14:15:21.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:15:21.281+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.281+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:15:21:259,0.222532,-0.040678,10.009177
06-12 14:15:21.281+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12080
06-12 14:15:21.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.311+0200 W/AUL     (12080): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.311+0200 I/light   (12080): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.311+0200 I/light   (12080): es.ugr.frailty.light - capturing data
06-12 14:15:21.321+0200 I/heartrate(12037): es.ugr.frailty.heartrate - capturing data
06-12 14:15:21.321+0200 I/heartrate(12037): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:15:21.321+0200 I/light   (12080): es.ugr.frailty.light: SM-R760,12/06/2018,14:15:21:323,9.000000
06-12 14:15:21.321+0200 W/AUL     (12080): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:15:21.341+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12055
06-12 14:15:21.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.371+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.371+0200 I/gravity (12055): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.371+0200 I/gravity (12055): es.ugr.frailty.gravity - capturing data
06-12 14:15:21.381+0200 I/gravity (12055): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:15:21:382,0.107904,1.975039,9.605101
06-12 14:15:21.381+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12024
06-12 14:15:21.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:15:21.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.441+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.441+0200 I/gyroscope(12024): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.441+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope - capturing data
06-12 14:15:21.451+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.451+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.451+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:15:21.451+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:15:21:451,5.180000,-16.309999,-14.840000
06-12 14:15:21.461+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:15:21:456,0.033662,-0.099417,0.164413
06-12 14:15:21.461+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.461+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:15:21.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:15:21.481+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.481+0200 I/utils   (11726): specific action
06-12 14:15:21.481+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.481+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.481+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.481+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.481+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.481+0200 I/recorder(11726): saving local data for es.ugr.frailty.linearacceleration
06-12 14:15:21.481+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:15:21.491+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11726)
06-12 14:15:21.491+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.recorder
06-12 14:15:21.491+0200 I/servicemanager(11723): requesting to save local data
06-12 14:15:21.491+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.491+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.491+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.491+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.491+0200 I/utils   (11723): specific action
06-12 14:15:21.491+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:15:21.491+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:15:21.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:15:21.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.551+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.551+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:15:21.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(81) , send fd(21), pid(11726), cmd(0)
06-12 14:15:21.571+0200 E/CAPI_TELEPHONY(11795): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:15:21.571+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.571+0200 I/heartrate(12037): es.ugr.frailty.heartrate - capturing data
06-12 14:15:21.571+0200 I/heartrate(12037): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:15:21.571+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.571+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:15:21.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:15:21.581+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:15:21:580,0.208176,0.179462,9.801002
06-12 14:15:21.581+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12066
06-12 14:15:21.581+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.601+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12080
06-12 14:15:21.611+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.621+0200 W/AUL     (12080): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.621+0200 I/light   (12080): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.621+0200 I/light   (12080): es.ugr.frailty.light - capturing data
06-12 14:15:21.631+0200 I/light   (12080): es.ugr.frailty.light: SM-R760,12/06/2018,14:15:21:632,11.000000
06-12 14:15:21.631+0200 W/AUL     (12080): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.631+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:15:21.651+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12066
06-12 14:15:21.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12055
06-12 14:15:21.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.691+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.691+0200 I/gravity (12055): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.691+0200 I/gravity (12055): es.ugr.frailty.gravity - capturing data
06-12 14:15:21.691+0200 I/gravity (12055): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:15:21:697,-0.014460,1.518667,9.688334
06-12 14:15:21.691+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.711+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12024
06-12 14:15:21.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.721+0200 I/heartrate(12037): es.ugr.frailty.heartrate - capturing data
06-12 14:15:21.721+0200 I/heartrate(12037): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:15:21.731+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.731+0200 I/gyroscope(12024): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.731+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope - capturing data
06-12 14:15:21.731+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:15:21:734,3.290000,10.360000,-28.490000
06-12 14:15:21.731+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.731+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.761+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:15:21.771+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.781+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.781+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.781+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:15:21.781+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:15:21:788,-0.049403,-0.030459,0.303204
06-12 14:15:21.781+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.781+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.801+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:15:21.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:15:21.811+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.811+0200 I/utils   (11726): specific action
06-12 14:15:21.811+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.811+0200 I/recorder(11726): saving local data for es.ugr.frailty.accelerometer
06-12 14:15:21.811+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:15:21.821+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11726)
06-12 14:15:21.821+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.recorder
06-12 14:15:21.821+0200 I/servicemanager(11723): requesting to save local data
06-12 14:15:21.821+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.821+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.821+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.821+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:21.821+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.821+0200 I/utils   (11723): specific action
06-12 14:15:21.821+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.821+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.821+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.821+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:21.821+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:15:21.821+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:15:21.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.851+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:15:21.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.871+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.871+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.871+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.871+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:15:21.881+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:15:21.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(21), pid(11726), cmd(0)
06-12 14:15:21.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:15:21.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.911+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12080
06-12 14:15:21.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.931+0200 I/heartrate(12037): es.ugr.frailty.heartrate - capturing data
06-12 14:15:21.931+0200 I/heartrate(12037): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:15:21.941+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:21.941+0200 W/AUL     (12080): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.941+0200 I/light   (12080): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.941+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:15:21:884,0.200997,0.098106,9.923036
06-12 14:15:21.941+0200 I/light   (12080): es.ugr.frailty.light - capturing data
06-12 14:15:21.941+0200 I/light   (12080): es.ugr.frailty.light: SM-R760,12/06/2018,14:15:21:948,11.000000
06-12 14:15:21.941+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.941+0200 W/AUL     (12080): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:21.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:15:21.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:21.971+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12055
06-12 14:15:21.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:21.991+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:21.991+0200 I/gravity (12055): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:21.991+0200 I/gravity (12055): es.ugr.frailty.gravity - capturing data
06-12 14:15:21.991+0200 I/gravity (12055): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:15:21:997,-0.147541,0.773416,9.774991
06-12 14:15:21.991+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:22.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:22.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12024
06-12 14:15:22.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:22.031+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:22.031+0200 I/gyroscope(12024): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:22.031+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope - capturing data
06-12 14:15:22.031+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:15:22:35,6.370000,26.320000,-34.580002
06-12 14:15:22.031+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:22.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:22.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:15:22.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:22.071+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:22.071+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:22.071+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:15:22.081+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:15:22:83,-0.021288,0.009220,0.193085
06-12 14:15:22.081+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:22.081+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:22.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:22.091+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:15:22.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:15:22.101+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.101+0200 I/utils   (11726): specific action
06-12 14:15:22.101+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.101+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.101+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.101+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.101+0200 W/CAPI_APPFW_APP_CONTROL(11726): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.101+0200 I/recorder(11726): saving local data for es.ugr.frailty.linearacceleration
06-12 14:15:22.101+0200 I/recorder(11726): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:15:22.111+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11726)
06-12 14:15:22.111+0200 I/servicemanager(11723): request sent to service es.ugr.frailty.recorder
06-12 14:15:22.111+0200 I/servicemanager(11723): requesting to save local data
06-12 14:15:22.111+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:22.111+0200 E/AUL     (11723): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:15:22.111+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.111+0200 I/utils   (11723): specific action
06-12 14:15:22.111+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.111+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.111+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.111+0200 W/CAPI_APPFW_APP_CONTROL(11723): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:15:22.121+0200 I/servicemanager(11723): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:15:22.121+0200 W/AUL     (11723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:15:22.121+0200 I/heartrate(12037): es.ugr.frailty.heartrate - capturing data
06-12 14:15:22.121+0200 I/heartrate(12037): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:15:22.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:15:22.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12080
06-12 14:15:22.151+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:15:22.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(47) , send fd(21), pid(11723), cmd(0)
06-12 14:15:22.161+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:15:22.161+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(21), pid(11726), cmd(0)
06-12 14:15:22.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:22.181+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11730
06-12 14:15:22.191+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:15:22.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:15:22.191+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:15:22.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:22.211+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:22.211+0200 I/accelerometer(11730): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:22.211+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer - capturing data
06-12 14:15:22.221+0200 I/accelerometer(11730): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:15:22:216,0.155533,0.196211,9.769895
06-12 14:15:22.221+0200 W/AUL     (11730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:22.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:22.231+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12080
06-12 14:15:22.241+0200 W/LOCATION(12050): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:15:22.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:22.281+0200 W/AUL     (12080): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:22.281+0200 I/light   (12080): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:22.281+0200 I/light   (12080): es.ugr.frailty.light - capturing data
06-12 14:15:22.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:15:22.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12080
06-12 14:15:22.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:22.321+0200 I/heartrate(12037): es.ugr.frailty.heartrate - capturing data
06-12 14:15:22.321+0200 I/heartrate(12037): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:15:22.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:22.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12055
06-12 14:15:22.331+0200 I/light   (12080): es.ugr.frailty.light: SM-R760,12/06/2018,14:15:22:286,9.000000
06-12 14:15:22.331+0200 W/AUL     (12080): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:22.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:22.341+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:22.341+0200 I/gravity (12055): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:22.351+0200 I/gravity (12055): es.ugr.frailty.gravity - capturing data
06-12 14:15:22.351+0200 I/gravity (12055): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:15:22:354,-0.228117,0.069386,9.803751
06-12 14:15:22.351+0200 W/AUL     (12055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:22.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:22.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12024
06-12 14:15:22.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:22.391+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:22.391+0200 I/gyroscope(12024): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:22.391+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope - capturing data
06-12 14:15:22.401+0200 I/gyroscope(12024): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:15:22:402,8.400000,20.299999,-33.740002
06-12 14:15:22.401+0200 W/AUL     (12024): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:22.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:22.411+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11769
06-12 14:15:22.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11723
06-12 14:15:22.441+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11723) cmd(0)
06-12 14:15:22.461+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11723)
06-12 14:15:22.461+0200 I/linearacceleration(11769): request sent to service es.ugr.frailty.servicemanager
06-12 14:15:22.461+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration - capturing data
06-12 14:15:22.461+0200 I/linearacceleration(11769): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:15:22:465,-0.008925,0.302890,-0.311804
06-12 14:15:22.461+0200 W/AUL     (11769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:15:22.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:15:22.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11723
06-12 14:15:22.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11726
06-12 14:15:22.481+0200 W/CRASH_MANAGER(11848): worker.c: worker_job(1205) > 11120506c6f63152880572
