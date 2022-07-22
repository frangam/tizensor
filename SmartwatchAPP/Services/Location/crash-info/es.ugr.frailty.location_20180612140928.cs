S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9730
Date: 2018-06-12 14:09:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf757e52d, r5   = 0xf7a8f150
r6   = 0xff903920, r7   = 0xff9037d0
r8   = 0xf7aa1c18, r9   = 0x00000000
r10  = 0xff9038ac, fp   = 0xff903920
ip   = 0x00000001, sp   = 0xff9037a8
lr   = 0xf757e539, pc   = 0xf75e7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    176796 KB
Buffers:     31232 KB
Cached:     140972 KB
VmPeak:      53444 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11868 KB
VmRSS:       11868 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9730 TID = 9730
9730 9731 

Maps Information
f4449000 f4c48000 rw-p [stack:9731]
f4c4f000 f4c51000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c59000 f4c5d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c66000 f4c68000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c70000 f4c73000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c82000 f4c87000 r-xp /usr/lib/libsystem.so.0.0.0
f4c92000 f4c95000 r-xp /lib/libattr.so.1.1.0
f4c9d000 f4cad000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cb5000 f4cbe000 r-xp /usr/lib/libedbus.so.1.7.99
f4cc6000 f4cc7000 r-xp /usr/lib/libresponse.so.0.2.96
f4cd0000 f4cd5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6577000 f667d000 r-xp /usr/lib/libicuuc.so.57.1
f6693000 f681b000 r-xp /usr/lib/libicui18n.so.57.1
f682b000 f6838000 r-xp /usr/lib/libail.so.0.1.0
f6841000 f6848000 r-xp /usr/lib/libminizip.so.1.0.0
f6851000 f69fa000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a1a000 f6a61000 r-xp /usr/lib/libssl.so.1.0.0
f6a6d000 f6a6f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a77000 f6a7e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a87000 f6a8e000 r-xp /lib/libcrypt-2.13.so
f6abf000 f6ac2000 r-xp /lib/libcap.so.2.21
f6aca000 f6acc000 r-xp /usr/lib/libiri.so
f6ad4000 f6b1d000 r-xp /usr/lib/libmdm.so.1.2.69
f6b25000 f6b2b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b33000 f6b56000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b60000 f6b62000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b6a000 f6b87000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b90000 f6b94000 r-xp /usr/lib/libsmack.so.1.0.0
f6b9d000 f6bb6000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bbf000 f6bc7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bcf000 f6bd5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bde000 f6be0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6be9000 f6bf9000 r-xp /lib/libresolv-2.13.so
f6bfd000 f6c15000 r-xp /usr/lib/liblzma.so.5.0.3
f6c1e000 f6c20000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c28000 f6c42000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c4a000 f6c79000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c82000 f6c91000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c9b000 f6ca5000 r-xp /usr/lib/libsensord-shared.so
f6cae000 f6d81000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d8c000 f6da2000 r-xp /lib/libz.so.1.2.5
f6daa000 f6daf000 r-xp /usr/lib/libffi.so.5.0.10
f6db7000 f6db8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dc0000 f6dd0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dd8000 f6df1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6df9000 f6dfb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e03000 f6e78000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e82000 f6e88000 r-xp /lib/librt-2.13.so
f6e91000 f6eaf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6eb9000 f6eba000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ec2000 f6ee5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6eed000 f6ef2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6efa000 f6f24000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f2d000 f6f44000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f4c000 f6fb5000 r-xp /lib/libm-2.13.so
f6fbe000 f7052000 r-xp /usr/lib/libstdc++.so.6.0.16
f7065000 f706a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7072000 f7079000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7081000 f70ab000 r-xp /usr/lib/libsensor.so.1.9.6
f70b4000 f7180000 r-xp /usr/lib/libxml2.so.2.7.8
f718d000 f718f000 r-xp /usr/lib/libiniparser.so.0
f7198000 f719e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71a7000 f7277000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7278000 f72ac000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72b5000 f72f1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72f9000 f72fc000 r-xp /usr/lib/libbundle.so.0.1.22
f7304000 f730a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7312000 f7353000 r-xp /usr/lib/libeina.so.1.7.99
f735c000 f7373000 r-xp /usr/lib/libecore.so.1.7.99
f738a000 f7393000 r-xp /usr/lib/libvconf.so.0.2.45
f739b000 f73af000 r-xp /lib/libpthread-2.13.so
f73ba000 f73c7000 r-xp /usr/lib/libaul.so.0.1.0
f73d1000 f73d3000 r-xp /lib/libdl-2.13.so
f73dc000 f73e7000 r-xp /lib/libunwind.so.8.0.1
f7414000 f741c000 r-xp /lib/libgcc_s-4.6.so.1
f741d000 f7541000 r-xp /lib/libc-2.13.so
f754f000 f7551000 r-xp /usr/lib/libdlog.so.0.0.0
f7559000 f7565000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f756e000 f7573000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f757b000 f758a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7592000 f7596000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f759f000 f75a2000 r-xp /usr/lib/libappcore-agent.so.1.1
f75aa000 f75ac000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75b4000 f75b8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75c0000 f75dd000 r-xp /lib/ld-2.13.so
f75e6000 f75e9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75e9000 f75ed000 r-xp /usr/lib/libsys-assert.so
f7a71000 f7adf000 rw-p [heap]
ff8e5000 ff906000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9730)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75e7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf757e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72853f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7283c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf728fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7295be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7295dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72ca75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72c51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7283c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf728fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7295be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7295dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72c7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72c8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72cff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c671fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c5a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d2d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71dafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71dc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf736cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7367b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73685a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7368879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75a0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75a07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75e75c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf743485c) [/lib/libc.so.6] + 0x1785c
29: (0xf75e6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
vicemanager
06-12 14:09:27.081+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:27.091+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.091+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:27:93,61.000000
06-12 14:09:27.091+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:27.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.131+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.131+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.131+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:27.141+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:27:140,-0.070000,-0.280000,-0.140000
06-12 14:09:27.141+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:27.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9552
06-12 14:09:27.191+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9552)
06-12 14:09:27.191+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.light
06-12 14:09:27.191+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.191+0200 I/servicemanager( 9467): es.ugr.frailty.pedometer alive timeout
06-12 14:09:27.191+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-12 14:09:27.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:27.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9734
06-12 14:09:27.231+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:27.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9734
06-12 14:09:27.261+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.261+0200 I/heartrate( 9716): es.ugr.frailty.heartrate - capturing data
06-12 14:09:27.261+0200 I/heartrate( 9716): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:27.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:09:27.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.301+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.301+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.301+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:09:27.301+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:27:307,0.168825,0.026553,9.805161
06-12 14:09:27.301+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:27.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.351+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.351+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.351+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:27.351+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:27:354,0.179462,-0.023928,9.997212
06-12 14:09:27.351+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:27.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.391+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.391+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.391+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:27.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.401+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:09:27:403,-0.124851,0.065752,-0.011672
06-12 14:09:27.401+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:27.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.441+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.441+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.441+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:27.451+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:27:452,61.000000
06-12 14:09:27.451+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.451+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9514) cmd(0)
06-12 14:09:27.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:27.491+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:09:27.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:09:27.501+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:09:27.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.531+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.551+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:27.551+0200 I/heartrate( 9716): es.ugr.frailty.heartrate - capturing data
06-12 14:09:27.551+0200 I/heartrate( 9716): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:27.571+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:09:27.571+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.571+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.571+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 9760
06-12 14:09:27.571+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:27.581+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:27:583,-0.070000,-0.280000,-0.140000
06-12 14:09:27.581+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.621+0200 E/CAPI_APPFW_APPLICATION( 9760): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:09:27.621+0200 E/CAPI_APPFW_APPLICATION( 9760): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:09:27.621+0200 I/utils   ( 9760): trying to start service: es.ugr.frailty.pedometer
06-12 14:09:27.621+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9760
06-12 14:09:27.621+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(9760) type(svcapp) bg(0)
06-12 14:09:27.621+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9760]
06-12 14:09:27.631+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9760)
06-12 14:09:27.631+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.631+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pedometer
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.641+0200 I/utils   ( 9760): es.ugr.frailty.pedometer sensor supported
06-12 14:09:27.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:09:27.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.651+0200 I/utils   ( 9760): es.ugr.frailty.pedometer listener started
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.661+0200 I/utils   ( 9467): specific action
06-12 14:09:27.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.661+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:09:27.661+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:27.671+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (9760) was created
06-12 14:09:27.671+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-12 14:09:27.681+0200 I/heartrate( 9716): es.ugr.frailty.heartrate - capturing data
06-12 14:09:27.681+0200 I/heartrate( 9716): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:27.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:09:27.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:09:27.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:27.751+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.751+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.751+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:09:27.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.751+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:27:756,0.167799,0.026704,9.805178
06-12 14:09:27.751+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.761+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.761+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.761+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:27.771+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:27:771,0.138784,0.045464,9.923036
06-12 14:09:27.771+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.771+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:27.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.811+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:27.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.851+0200 E/CAPI_TELEPHONY( 9545): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:09:27.851+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.851+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.851+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:27.851+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.851+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.851+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:27.861+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:09:27:861,0.001418,0.017502,0.057730
06-12 14:09:27.861+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.861+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:27:858,61.000000
06-12 14:09:27.861+0200 I/heartrate( 9716): es.ugr.frailty.heartrate - capturing data
06-12 14:09:27.861+0200 I/heartrate( 9716): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:27.861+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.871+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:27.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:27.891+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:27.891+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:27.891+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:27.891+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:27:898,-0.070000,-0.210000,-0.070000
06-12 14:09:27.891+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:27.901+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:27.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:27.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:27.931+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.931+0200 I/utils   ( 9470): specific action
06-12 14:09:27.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.941+0200 I/recorder( 9470): saving local data for es.ugr.frailty.linearacceleration
06-12 14:09:27.941+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:09:27.941+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:27.941+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:27.941+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:27.941+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.941+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.941+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:27.941+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.941+0200 I/utils   ( 9467): specific action
06-12 14:09:27.941+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.941+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.941+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.941+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.951+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.951+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:27.951+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gravity
06-12 14:09:27.951+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:27.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:27.971+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9747
06-12 14:09:27.971+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:27.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:27.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(73) , send fd(15), pid(9470), cmd(0)
06-12 14:09:28.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:28.001+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9747
06-12 14:09:28.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9552) cmd(0)
06-12 14:09:28.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:09:28.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.041+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.041+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.041+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:09:28.041+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:28:45,0.167481,0.026093,9.805185
06-12 14:09:28.041+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.061+0200 I/heartrate( 9716): es.ugr.frailty.heartrate - capturing data
06-12 14:09:28.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:28.061+0200 I/heartrate( 9716): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:28.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.081+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.081+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.081+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:28.091+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.091+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:28:93,0.098106,0.019143,10.016356
06-12 14:09:28.091+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.101+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:28.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.141+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.141+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.141+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:28.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:28.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.161+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.181+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:28.191+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:09:28:146,-0.029139,0.046893,0.129410
06-12 14:09:28.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.201+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.201+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.201+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.201+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:28.211+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.211+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.211+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.211+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:28.211+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:28:213,61.000000
06-12 14:09:28.211+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.221+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:28:215,-0.070000,-0.350000,-0.070000
06-12 14:09:28.221+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.231+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:28.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:28.241+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.241+0200 I/utils   ( 9470): specific action
06-12 14:09:28.241+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.241+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.241+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.241+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.241+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.241+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.241+0200 I/recorder( 9470): saving local data for es.ugr.frailty.gravity
06-12 14:09:28.241+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 14:09:28.251+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:28.251+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:28.251+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:28.251+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:28.251+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:28.251+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:28.251+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:28.251+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.251+0200 I/utils   ( 9467): specific action
06-12 14:09:28.251+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.251+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.251+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.251+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.251+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.251+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.251+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.251+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.light
06-12 14:09:28.251+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:28.261+0200 I/heartrate( 9716): es.ugr.frailty.heartrate - capturing data
06-12 14:09:28.261+0200 I/heartrate( 9716): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:28.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:09:28.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:28.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(88) , send fd(15), pid(9467), cmd(0)
06-12 14:09:28.281+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:28.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(78) , send fd(15), pid(9470), cmd(0)
06-12 14:09:28.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:09:28.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:09:28.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.341+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.341+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.341+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:09:28.341+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:28:344,0.167436,0.029623,9.805176
06-12 14:09:28.341+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:28.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.371+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.371+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.371+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:28.381+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:28:380,0.160319,0.086142,9.879964
06-12 14:09:28.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.381+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:28.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.411+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.411+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.411+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:28.411+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:09:28:419,0.003404,0.000865,0.177282
06-12 14:09:28.411+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:28.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.451+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.451+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.451+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:28.461+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.461+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:28:463,61.000000
06-12 14:09:28.461+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.461+0200 I/heartrate( 9716): es.ugr.frailty.heartrate - capturing data
06-12 14:09:28.461+0200 I/heartrate( 9716): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:28.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:28.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:09:28.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:09:28.501+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:09:28.511+0200 W/LOCATION( 9730): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:09:28.511+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.511+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.511+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:28.511+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.531+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:28:520,-0.070000,-0.350000,-0.070000
06-12 14:09:28.531+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.541+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:28.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:28.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.551+0200 I/utils   ( 9470): specific action
06-12 14:09:28.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.551+0200 I/recorder( 9470): saving local data for es.ugr.frailty.light
06-12 14:09:28.551+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 14:09:28.561+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:28.561+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:28.561+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:28.561+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:28.561+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:28.561+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:09:28.561+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.561+0200 I/utils   ( 9467): specific action
06-12 14:09:28.561+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.561+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.561+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.561+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.561+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.561+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.561+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:28.561+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.light
06-12 14:09:28.561+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:28.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:28.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9760
06-12 14:09:28.591+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.601+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:28.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(57) , send fd(15), pid(9470), cmd(0)
06-12 14:09:28.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:28.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9760
06-12 14:09:28.621+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:09:28.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.661+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.661+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.661+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:09:28.661+0200 I/heartrate( 9716): es.ugr.frailty.heartrate - capturing data
06-12 14:09:28.661+0200 I/heartrate( 9716): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:28.671+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:28:669,0.156677,0.019963,9.805378
06-12 14:09:28.671+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:28.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.701+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.701+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.701+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:28.711+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:28:712,0.126820,0.047856,9.908678
06-12 14:09:28.711+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.711+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:28.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:28.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:28.751+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:09:28.751+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:28.751+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:28.751+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:28.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:28.771+0200 W/CRASH_MANAGER( 9591): worker.c: worker_job(1205) > 11097306c6f63152880536
