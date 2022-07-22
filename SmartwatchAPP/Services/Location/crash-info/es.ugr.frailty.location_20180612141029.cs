S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10306
Date: 2018-06-12 14:10:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71a252d, r5   = 0xf75f2150
r6   = 0xffdba6c0, r7   = 0xffdba570
r8   = 0xf7604c18, r9   = 0x00000000
r10  = 0xffdba64c, fp   = 0xffdba6c0
ip   = 0x00000001, sp   = 0xffdba548
lr   = 0xf71a2539, pc   = 0xf720b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    173000 KB
Buffers:     31504 KB
Cached:     143124 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11672 KB
VmRSS:       11672 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10306 TID = 10306
10306 10308 

Maps Information
f406d000 f486c000 rw-p [stack:10308]
f4873000 f4875000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f487d000 f4881000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f488a000 f488c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4894000 f4897000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48a6000 f48ab000 r-xp /usr/lib/libsystem.so.0.0.0
f48b6000 f48b9000 r-xp /lib/libattr.so.1.1.0
f48c1000 f48d1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48d9000 f48e2000 r-xp /usr/lib/libedbus.so.1.7.99
f48ea000 f48eb000 r-xp /usr/lib/libresponse.so.0.2.96
f48f4000 f48f9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f619b000 f62a1000 r-xp /usr/lib/libicuuc.so.57.1
f62b7000 f643f000 r-xp /usr/lib/libicui18n.so.57.1
f644f000 f645c000 r-xp /usr/lib/libail.so.0.1.0
f6465000 f646c000 r-xp /usr/lib/libminizip.so.1.0.0
f6475000 f661e000 r-xp /usr/lib/libcrypto.so.1.0.0
f663e000 f6685000 r-xp /usr/lib/libssl.so.1.0.0
f6691000 f6693000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f669b000 f66a2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66ab000 f66b2000 r-xp /lib/libcrypt-2.13.so
f66e3000 f66e6000 r-xp /lib/libcap.so.2.21
f66ee000 f66f0000 r-xp /usr/lib/libiri.so
f66f8000 f6741000 r-xp /usr/lib/libmdm.so.1.2.69
f6749000 f674f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6757000 f677a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6784000 f6786000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f678e000 f67ab000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67b4000 f67b8000 r-xp /usr/lib/libsmack.so.1.0.0
f67c1000 f67da000 r-xp /usr/lib/libnetwork.so.0.0.0
f67e3000 f67eb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67f3000 f67f9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6802000 f6804000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f680d000 f681d000 r-xp /lib/libresolv-2.13.so
f6821000 f6839000 r-xp /usr/lib/liblzma.so.5.0.3
f6842000 f6844000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f684c000 f6866000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f686e000 f689d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68a6000 f68b5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68bf000 f68c9000 r-xp /usr/lib/libsensord-shared.so
f68d2000 f69a5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69b0000 f69c6000 r-xp /lib/libz.so.1.2.5
f69ce000 f69d3000 r-xp /usr/lib/libffi.so.5.0.10
f69db000 f69dc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69e4000 f69f4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69fc000 f6a15000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a1d000 f6a1f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a27000 f6a9c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6aa6000 f6aac000 r-xp /lib/librt-2.13.so
f6ab5000 f6ad3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6add000 f6ade000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ae6000 f6b09000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b11000 f6b16000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b1e000 f6b48000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b51000 f6b68000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b70000 f6bd9000 r-xp /lib/libm-2.13.so
f6be2000 f6c76000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c89000 f6c8e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c96000 f6c9d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ca5000 f6ccf000 r-xp /usr/lib/libsensor.so.1.9.6
f6cd8000 f6da4000 r-xp /usr/lib/libxml2.so.2.7.8
f6db1000 f6db3000 r-xp /usr/lib/libiniparser.so.0
f6dbc000 f6dc2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dcb000 f6e9b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e9c000 f6ed0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ed9000 f6f15000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f1d000 f6f20000 r-xp /usr/lib/libbundle.so.0.1.22
f6f28000 f6f2e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f36000 f6f77000 r-xp /usr/lib/libeina.so.1.7.99
f6f80000 f6f97000 r-xp /usr/lib/libecore.so.1.7.99
f6fae000 f6fb7000 r-xp /usr/lib/libvconf.so.0.2.45
f6fbf000 f6fd3000 r-xp /lib/libpthread-2.13.so
f6fde000 f6feb000 r-xp /usr/lib/libaul.so.0.1.0
f6ff5000 f6ff7000 r-xp /lib/libdl-2.13.so
f7000000 f700b000 r-xp /lib/libunwind.so.8.0.1
f7038000 f7040000 r-xp /lib/libgcc_s-4.6.so.1
f7041000 f7165000 r-xp /lib/libc-2.13.so
f7173000 f7175000 r-xp /usr/lib/libdlog.so.0.0.0
f717d000 f7189000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7192000 f7197000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f719f000 f71ae000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71b6000 f71ba000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71c3000 f71c6000 r-xp /usr/lib/libappcore-agent.so.1.1
f71ce000 f71d0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71d8000 f71dc000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71e4000 f7201000 r-xp /lib/ld-2.13.so
f720a000 f720d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f720d000 f7211000 r-xp /usr/lib/libsys-assert.so
f75d4000 f7642000 rw-p [heap]
ffd9b000 ffdbc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10306)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf720b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71a2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ea93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ea7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6eb3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6eb9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6eb9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6eee75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ee91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ea7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6eb3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6eb9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6eb9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6eebe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6eec017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ef3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf488b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf487e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6951663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6dfefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e007a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f90ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f8bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f8c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f8c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71c4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71c47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf720b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf705885c) [/lib/libc.so.6] + 0x1785c
29: (0xf720af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ration
06-12 14:10:27.651+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:10:27.661+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:10:27.661+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:10:27.661+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:10:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:27.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.661+0200 I/utils   ( 9467): specific action
06-12 14:10:27.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.671+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.671+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.671+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.671+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.671+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gravity
06-12 14:10:27.671+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:10:27.671+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:27.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:27.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:27.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:27.711+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:27.711+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:27.711+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:27.711+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:27:718,0.148355,0.011964,9.858429
06-12 14:10:27.711+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:27.721+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:27.721+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(66) , send fd(15), pid(9470), cmd(0)
06-12 14:10:27.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:27.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:27.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:27.771+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:27.771+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:27.771+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:27.781+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:27.781+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:27:779,0.023342,-0.048389,0.153136
06-12 14:10:27.781+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:27.791+0200 I/heartrate(10292): es.ugr.frailty.heartrate - capturing data
06-12 14:10:27.791+0200 I/heartrate(10292): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:27.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:27.801+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:27.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:27.821+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:27.821+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:27.821+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:27.831+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:27.831+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:27:831,0.635476,-0.002830,9.786038
06-12 14:10:27.831+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:27.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:27.851+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:27.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:27.871+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:27.871+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:27.871+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:27.871+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:27.871+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:27:878,0.070000,-0.280000,-0.070000
06-12 14:10:27.881+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:27.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:27.891+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:27.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:10:27.901+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.901+0200 I/utils   ( 9470): specific action
06-12 14:10:27.901+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.901+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.901+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.901+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.901+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.901+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.901+0200 I/recorder( 9470): saving local data for es.ugr.frailty.gravity
06-12 14:10:27.901+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 14:10:27.911+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:10:27.911+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:10:27.911+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:10:27.911+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:27.911+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:27.911+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:27.911+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.911+0200 I/utils   ( 9467): specific action
06-12 14:10:27.911+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.911+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.911+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.911+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:27.911+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:10:27.911+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:10:27.911+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:27.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:27.941+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:27.951+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:27.961+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:27.961+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:27.961+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:27.961+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:27:965,0.244068,-0.004786,9.777073
06-12 14:10:27.961+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:27.971+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:27.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(48) , send fd(15), pid(9470), cmd(0)
06-12 14:10:27.991+0200 I/heartrate(10292): es.ugr.frailty.heartrate - capturing data
06-12 14:10:27.991+0200 I/heartrate(10292): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:27.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:27.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:28.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.021+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.021+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.021+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:28.031+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:28:29,-0.061012,0.065056,-0.080269
06-12 14:10:28.031+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:28.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.091+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.091+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.091+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:28.101+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:10:28.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:10:28.111+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:10:28.121+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:28:104,1.105909,-0.001086,9.744093
06-12 14:10:28.121+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:28.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.201+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.201+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.221+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:28.221+0200 I/heartrate(10292): es.ugr.frailty.heartrate - capturing data
06-12 14:10:28.221+0200 I/heartrate(10292): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:28.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:10:28.231+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:28.231+0200 I/utils   ( 9470): specific action
06-12 14:10:28.231+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:28.231+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:28.231+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:28.231+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:28.231+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:28.231+0200 I/recorder( 9470): saving local data for es.ugr.frailty.linearacceleration
06-12 14:10:28.231+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:10:28.241+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:10:28.241+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:10:28.241+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:10:28.241+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.241+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.241+0200 I/servicemanager( 9467): es.ugr.frailty.pressure alive timeout
06-12 14:10:28.241+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-12 14:10:28.251+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.251+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.251+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.251+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:28.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:28.291+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:28:264,-0.070000,-0.210000,-0.140000
06-12 14:10:28.291+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.311+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9514) cmd(0)
06-12 14:10:28.311+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:28.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(50) , send fd(15), pid(9470), cmd(0)
06-12 14:10:28.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:28.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.351+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.351+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.351+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:28.351+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.351+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.351+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:28.361+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:28:355,0.131605,-0.028714,10.042676
06-12 14:10:28.361+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.361+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.371+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:28:361,-0.025120,0.100948,0.058516
06-12 14:10:28.371+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:28.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.411+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.411+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.411+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.411+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.411+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:28.411+0200 I/heartrate(10292): es.ugr.frailty.heartrate - capturing data
06-12 14:10:28.411+0200 I/heartrate(10292): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:28.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:28.431+0200 E/CAPI_TELEPHONY( 9545): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:10:28.441+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 10315
06-12 14:10:28.441+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:10:28.451+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:28:417,0.721324,-0.001731,9.780086
06-12 14:10:28.451+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.491+0200 E/CAPI_APPFW_APPLICATION(10315): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:10:28.491+0200 E/CAPI_APPFW_APPLICATION(10315): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:10:28.491+0200 I/utils   (10315): trying to start service: es.ugr.frailty.pressure
06-12 14:10:28.491+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10315
06-12 14:10:28.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pressure) pid(10315) type(svcapp) bg(0)
06-12 14:10:28.491+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10315)
06-12 14:10:28.491+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10315]
06-12 14:10:28.501+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pressure
06-12 14:10:28.501+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.501+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-12 14:10:28.511+0200 I/servicemanager( 9467): es.ugr.frailty.light alive timeout
06-12 14:10:28.511+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-12 14:10:28.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:28.521+0200 I/utils   (10315): es.ugr.frailty.pressure sensor supported
06-12 14:10:28.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.531+0200 I/utils   (10315): es.ugr.frailty.pressure listener started
06-12 14:10:28.541+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.541+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.541+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:28.551+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:28:549,-0.070000,-0.280000,-0.070000
06-12 14:10:28.551+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.551+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.551+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.561+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (10315) was created
06-12 14:10:28.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.571+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:28.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.601+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.601+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.601+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:28.601+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:28:607,0.153141,0.050249,9.750752
06-12 14:10:28.601+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.611+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.611+0200 I/heartrate(10292): es.ugr.frailty.heartrate - capturing data
06-12 14:10:28.611+0200 I/heartrate(10292): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:28.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:28.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.651+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.651+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.651+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:28.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.651+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:28:657,-0.061102,0.037770,0.046288
06-12 14:10:28.651+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:28.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.701+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.701+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.701+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:28.701+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:10:28.731+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10315
06-12 14:10:28.731+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9734) cmd(0)
06-12 14:10:28.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:28.761+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:10:28.761+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 10328
06-12 14:10:28.771+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:28:709,3.729597,0.002787,9.069757
06-12 14:10:28.771+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.801+0200 I/heartrate(10292): es.ugr.frailty.heartrate - capturing data
06-12 14:10:28.801+0200 I/heartrate(10292): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:28.811+0200 E/CAPI_APPFW_APPLICATION(10328): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:10:28.811+0200 E/CAPI_APPFW_APPLICATION(10328): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:10:28.811+0200 I/utils   (10328): trying to start service: es.ugr.frailty.light
06-12 14:10:28.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10328
06-12 14:10:28.811+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.light) pid(10328) type(svcapp) bg(0)
06-12 14:10:28.811+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10328]
06-12 14:10:28.811+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10328)
06-12 14:10:28.811+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.light
06-12 14:10:28.811+0200 I/servicemanager( 9467): es.ugr.frailty.pedometer alive timeout
06-12 14:10:28.811+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-12 14:10:28.811+0200 I/utils   (10328): es.ugr.frailty.light sensor supported
06-12 14:10:28.821+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.841+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:28.841+0200 I/utils   (10328): es.ugr.frailty.light listener started
06-12 14:10:28.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.861+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.871+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.871+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.871+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.871+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.871+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.871+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.871+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.881+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (10328) was created
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 E/AUL     ( 9477): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:28.891+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:28.901+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:28:902,0.070000,-0.210000,0.210000
06-12 14:10:28.901+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.901+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10315
06-12 14:10:28.901+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:28.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.941+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:28.941+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:28.941+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:28.951+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:28:952,0.145962,-0.019143,9.894321
06-12 14:10:28.951+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.951+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:28.951+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:28.951+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(56) , send fd(15), pid(9477), cmd(0)
06-12 14:10:28.961+0200 I/light   (10328): es.ugr.frailty.light - capturing data
06-12 14:10:28.961+0200 I/light   (10328): es.ugr.frailty.light: SM-R760,12/06/2018,14:10:28:969,56.000000
06-12 14:10:28.961+0200 W/AUL     (10328): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:28.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:28.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:28.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:28.991+0200 I/heartrate(10292): es.ugr.frailty.heartrate - capturing data
06-12 14:10:28.991+0200 I/heartrate(10292): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:29.001+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:29.001+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:29.001+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:29.001+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:29:5,-0.034781,-0.005300,0.089357
06-12 14:10:29.001+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:29.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:10:29.021+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:29.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:29.061+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:29.061+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:29.061+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:29.071+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:29:69,0.507511,-0.002156,9.793509
06-12 14:10:29.071+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:29.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:29.081+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:29.091+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:10:29.091+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 10340
06-12 14:10:29.101+0200 W/LOCATION(10306): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:10:29.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:10:29.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:10:29.111+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:10:29.161+0200 E/CAPI_APPFW_APPLICATION(10340): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:10:29.161+0200 E/CAPI_APPFW_APPLICATION(10340): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:10:29.161+0200 I/utils   (10340): trying to start service: es.ugr.frailty.pedometer
06-12 14:10:29.161+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10340
06-12 14:10:29.161+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(10340) type(svcapp) bg(0)
06-12 14:10:29.171+0200 I/utils   (10340): es.ugr.frailty.pedometer sensor supported
06-12 14:10:29.171+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:29.171+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10340)
06-12 14:10:29.171+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pedometer
06-12 14:10:29.171+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10340]
06-12 14:10:29.171+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.171+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:29.191+0200 I/utils   ( 9467): specific action
06-12 14:10:29.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:29.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:29.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:29.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:29.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:29.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:29.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:29.191+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.light
06-12 14:10:29.191+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:10:29.191+0200 I/utils   (10340): es.ugr.frailty.pedometer listener started
06-12 14:10:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:29.191+0200 I/heartrate(10292): es.ugr.frailty.heartrate - capturing data
06-12 14:10:29.191+0200 I/heartrate(10292): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:29.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:29.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:29.211+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:29.211+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:29.211+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:29.211+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:29:219,0.070000,-0.280000,-0.070000
06-12 14:10:29.211+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:29.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:29.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:29.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (10340) was created
06-12 14:10:29.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:10:29.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:29.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:29.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:29.301+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:29.301+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:29.301+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.311+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:29.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10328
06-12 14:10:29.331+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.331+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.331+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.331+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.331+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.331+0200 E/AUL     ( 9474): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:29.331+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:29.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:29.341+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:29:343,0.114855,0.071785,9.870394
06-12 14:10:29.341+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:29.361+0200 W/AUL     (10328): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:29.361+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:29.361+0200 I/light   (10328): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:29.361+0200 I/light   (10328): es.ugr.frailty.light - capturing data
06-12 14:10:29.361+0200 I/light   (10328): es.ugr.frailty.light: SM-R760,12/06/2018,14:10:29:366,56.000000
06-12 14:10:29.361+0200 W/AUL     (10328): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:29.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:29.411+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:29.411+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:29.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(9474), cmd(0)
06-12 14:10:29.421+0200 W/CRASH_MANAGER(10155): worker.c: worker_job(1205) > 11103066c6f63152880542
