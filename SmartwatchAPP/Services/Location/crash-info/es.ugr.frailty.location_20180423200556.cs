S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5926
Date: 2018-04-23 20:05:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf740452d, r5   = 0xf7c02f98
r6   = 0xffc8c870, r7   = 0xffc8c720
r8   = 0xf7bffc18, r9   = 0x00000000
r10  = 0xffc8c7fc, fp   = 0xffc8c870
ip   = 0x00000001, sp   = 0xffc8c6f8
lr   = 0xf7404539, pc   = 0xf746d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    112736 KB
Buffers:     36720 KB
Cached:     182324 KB
VmPeak:      52492 KB
VmSize:      52488 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11640 KB
VmRSS:       11640 KB
VmData:      10216 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5926 TID = 5926
5926 5937 

Maps Information
f42cf000 f4ace000 rw-p [stack:5937]
f4ad5000 f4ad7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4adf000 f4ae3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4aec000 f4aee000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4af6000 f4af9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b08000 f4b0d000 r-xp /usr/lib/libsystem.so.0.0.0
f4b18000 f4b1b000 r-xp /lib/libattr.so.1.1.0
f4b23000 f4b33000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b3b000 f4b44000 r-xp /usr/lib/libedbus.so.1.7.99
f4b4c000 f4b4d000 r-xp /usr/lib/libresponse.so.0.2.96
f4b56000 f4b5b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63fd000 f6503000 r-xp /usr/lib/libicuuc.so.57.1
f6519000 f66a1000 r-xp /usr/lib/libicui18n.so.57.1
f66b1000 f66be000 r-xp /usr/lib/libail.so.0.1.0
f66c7000 f66ce000 r-xp /usr/lib/libminizip.so.1.0.0
f66d7000 f6880000 r-xp /usr/lib/libcrypto.so.1.0.0
f68a0000 f68e7000 r-xp /usr/lib/libssl.so.1.0.0
f68f3000 f68f5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68fd000 f6904000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f690d000 f6914000 r-xp /lib/libcrypt-2.13.so
f6945000 f6948000 r-xp /lib/libcap.so.2.21
f6950000 f6952000 r-xp /usr/lib/libiri.so
f695a000 f69a3000 r-xp /usr/lib/libmdm.so.1.2.69
f69ab000 f69b1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69b9000 f69dc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69e6000 f69e8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69f0000 f6a0d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a16000 f6a1a000 r-xp /usr/lib/libsmack.so.1.0.0
f6a23000 f6a3c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a45000 f6a4d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a55000 f6a5b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a64000 f6a66000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a6f000 f6a7f000 r-xp /lib/libresolv-2.13.so
f6a83000 f6a9b000 r-xp /usr/lib/liblzma.so.5.0.3
f6aa4000 f6aa6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aae000 f6ac8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ad0000 f6aff000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b08000 f6b17000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b21000 f6b2b000 r-xp /usr/lib/libsensord-shared.so
f6b34000 f6c07000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c12000 f6c28000 r-xp /lib/libz.so.1.2.5
f6c30000 f6c35000 r-xp /usr/lib/libffi.so.5.0.10
f6c3d000 f6c3e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c46000 f6c56000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c5e000 f6c77000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c7f000 f6c81000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c89000 f6cfe000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d08000 f6d0e000 r-xp /lib/librt-2.13.so
f6d17000 f6d35000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d3f000 f6d40000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d48000 f6d6b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d73000 f6d78000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d80000 f6daa000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6db3000 f6dca000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dd2000 f6e3b000 r-xp /lib/libm-2.13.so
f6e44000 f6ed8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6eeb000 f6ef0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ef8000 f6eff000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f07000 f6f31000 r-xp /usr/lib/libsensor.so.1.9.6
f6f3a000 f7006000 r-xp /usr/lib/libxml2.so.2.7.8
f7013000 f7015000 r-xp /usr/lib/libiniparser.so.0
f701e000 f7024000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f702d000 f70fd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70fe000 f7132000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f713b000 f7177000 r-xp /usr/lib/libSLP-location.so.0.9.24
f717f000 f7182000 r-xp /usr/lib/libbundle.so.0.1.22
f718a000 f7190000 r-xp /usr/lib/libappsvc.so.0.1.0
f7198000 f71d9000 r-xp /usr/lib/libeina.so.1.7.99
f71e2000 f71f9000 r-xp /usr/lib/libecore.so.1.7.99
f7210000 f7219000 r-xp /usr/lib/libvconf.so.0.2.45
f7221000 f7235000 r-xp /lib/libpthread-2.13.so
f7240000 f724d000 r-xp /usr/lib/libaul.so.0.1.0
f7257000 f7259000 r-xp /lib/libdl-2.13.so
f7262000 f726d000 r-xp /lib/libunwind.so.8.0.1
f729a000 f72a2000 r-xp /lib/libgcc_s-4.6.so.1
f72a3000 f73c7000 r-xp /lib/libc-2.13.so
f73d5000 f73d7000 r-xp /usr/lib/libdlog.so.0.0.0
f73df000 f73eb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73f4000 f73f9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7401000 f7410000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7418000 f741c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7425000 f7428000 r-xp /usr/lib/libappcore-agent.so.1.1
f7430000 f7432000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f743a000 f743e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7446000 f7463000 r-xp /lib/ld-2.13.so
f746c000 f746f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f746f000 f7473000 r-xp /usr/lib/libsys-assert.so
f7bcf000 f7c54000 rw-p [heap]
ffc6d000 ffc8e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5926)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf746d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7404539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf710b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7109c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7115e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf711bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf711bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf715075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf714b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7109c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7115e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf711bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf711bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf714de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf714e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7155f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4aed1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ae0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bb3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7060fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70627a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71f2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71edb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71ee5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71ee879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7426183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74267fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf746d4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf72ba85c) [/lib/libc.so.6] + 0x1785c
29: (0xf746cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
n( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:47.799+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:47:806,0.021506,0.021260,-0.038419
04-23 20:05:47.799+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:47:803,0.043071,9.791430,0.806381
04-23 20:05:47.799+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:47.809+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:47:812,0.043166,9.772724,0.813872
04-23 20:05:47.809+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:47.819+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:47:819,-0.070000,0.070000,0.070000
04-23 20:05:47.969+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:47.969+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:47.989+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:47.999+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:47.999+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:48:3,0.035892,9.822537,0.760918
04-23 20:05:47.999+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:48:4,-0.007273,0.049813,-0.052954
04-23 20:05:47.999+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:48.009+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:48.009+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:48:12,0.044145,9.771974,0.822782
04-23 20:05:48.009+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:48:17,-0.070000,0.070000,0.070000
04-23 20:05:48.169+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:48.169+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:48.189+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:48.199+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:48.199+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:48:204,0.050249,9.793823,0.765703
04-23 20:05:48.199+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:48:203,0.006104,0.021850,-0.057078
04-23 20:05:48.199+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:48.209+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:48:212,0.042396,9.772597,0.815434
04-23 20:05:48.209+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:48.229+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:48:219,-0.140000,0.070000,0.070000
04-23 20:05:48.299+0200 I/servicemanager( 5532): es.ugr.frailty.accelerometer sleep timeout
04-23 20:05:48.299+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 20:05:48.299+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.299+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:48.309+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5543
04-23 20:05:48.309+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.309+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5543), cmd(0)
04-23 20:05:48.319+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5543)
04-23 20:05:48.319+0200 I/servicemanager( 5532): es.ugr.frailty.accelerometer stop request sent!
04-23 20:05:48.319+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:48.319+0200 I/accelerometer( 5543): stopping es.ugr.frailty.accelerometer service
04-23 20:05:48.349+0200 W/AUL     ( 5543): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:05:48.369+0200 I/servicemanager( 5532): es.ugr.frailty.gyroscope sleep timeout
04-23 20:05:48.369+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 20:05:48.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.369+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:48.369+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:48.369+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:48.379+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5545
04-23 20:05:48.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.379+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5543
04-23 20:05:48.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:05:48.389+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:48.399+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:48:403,0.043746,0.045154,-0.052124
04-23 20:05:48.399+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:48.399+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:48:407,0.046051,9.773245,0.807436
04-23 20:05:48.419+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5545)
04-23 20:05:48.419+0200 I/servicemanager( 5532): es.ugr.frailty.gyroscope stop request sent!
04-23 20:05:48.419+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:48.419+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.419+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(5532), cmd(0)
04-23 20:05:48.419+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.419+0200 I/utils   ( 5532): specific action
04-23 20:05:48.419+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:05:48.439+0200 W/AUL     ( 5543): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:05:48.439+0200 I/accelerometer( 5543): request sent to service es.ugr.frailty.servicemanager
04-23 20:05:48.439+0200 I/CAPI_APPFW_APPLICATION( 5543): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:05:48.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:05:48.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:05:48.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.449+0200 I/gyroscope( 5545): stopping es.ugr.frailty.gyroscope service
04-23 20:05:48.449+0200 W/AUL     ( 5545): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:05:48.449+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:48.459+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:05:48.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.459+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.459+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5545
04-23 20:05:48.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:05:48.469+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5545), cmd(0)
04-23 20:05:48.469+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(5538), cmd(0)
04-23 20:05:48.489+0200 I/utils   ( 5538): specific action
04-23 20:05:48.489+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.489+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 20:05:48.489+0200 I/recorder( 5538): guardando datos en local
04-23 20:05:48.519+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:48.529+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:05:48.529+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:05:48.529+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:05:48.529+0200 I/servicemanager( 5532): es.ugr.frailty.heartrate sleep timeout
04-23 20:05:48.529+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 20:05:48.539+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:48.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.549+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:48.559+0200 W/AUL     ( 5545): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:05:48.559+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5555
04-23 20:05:48.559+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.559+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5555), cmd(0)
04-23 20:05:48.559+0200 I/heartrate( 5555): stopping es.ugr.frailty.heartrate service
04-23 20:05:48.559+0200 E/CAPI_APPFW_APP_CONTROL( 5555): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:05:48.559+0200 E/heartrate( 5555): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:05:48.559+0200 I/CAPI_APPFW_APPLICATION( 5555): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:05:48.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:05:48.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:05:48.569+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5555)
04-23 20:05:48.569+0200 I/servicemanager( 5532): es.ugr.frailty.heartrate stop request sent!
04-23 20:05:48.569+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:48.569+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.569+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(5532), cmd(0)
04-23 20:05:48.599+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:48.599+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:48:607,-0.002980,0.042113,0.018088
04-23 20:05:48.599+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:48.609+0200 I/gyroscope( 5545): request sent to service es.ugr.frailty.servicemanager
04-23 20:05:48.609+0200 I/CAPI_APPFW_APPLICATION( 5545): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:05:48.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:05:48.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:05:48.609+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.609+0200 I/utils   ( 5532): specific action
04-23 20:05:48.609+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.609+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:05:48.609+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:48:612,0.060417,9.774221,0.794557
04-23 20:05:48.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.609+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:48.619+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:05:48.629+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.629+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:05:48.629+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.629+0200 I/utils   ( 5538): specific action
04-23 20:05:48.629+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.629+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.629+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 20:05:48.629+0200 I/recorder( 5538): guardando datos en local
04-23 20:05:48.629+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer listener destroyed
04-23 20:05:48.629+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:05:48.629+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:05:48.629+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:05:48.659+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:48.669+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:48.719+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:48.729+0200 I/servicemanager( 5532): es.ugr.frailty.linearacceleration sleep timeout
04-23 20:05:48.729+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
04-23 20:05:48.729+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:48.749+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.759+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:48.759+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5580
04-23 20:05:48.769+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.769+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5580), cmd(0)
04-23 20:05:48.769+0200 I/linearacceleration( 5580): stopping es.ugr.frailty.linearacceleration service
04-23 20:05:48.769+0200 W/AUL     ( 5580): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:05:48.769+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5580)
04-23 20:05:48.769+0200 I/servicemanager( 5532): es.ugr.frailty.linearacceleration stop request sent!
04-23 20:05:48.769+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:48.779+0200 I/heartrate( 5555): es.ugr.frailty.heartrate listener destroyed
04-23 20:05:48.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.779+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5580
04-23 20:05:48.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:05:48.789+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:05:48.799+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.799+0200 W/AUL     ( 5580): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:05:48.799+0200 I/utils   ( 5532): specific action
04-23 20:05:48.799+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.799+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.799+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.799+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.799+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:05:48.799+0200 I/linearacceleration( 5580): request sent to service es.ugr.frailty.servicemanager
04-23 20:05:48.799+0200 I/CAPI_APPFW_APPLICATION( 5580): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:05:48.799+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:05:48.799+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:05:48.799+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:48.809+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:48:811,0.055525,9.772617,0.814408
04-23 20:05:48.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.819+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:48.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:05:48.829+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:05:48.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.829+0200 I/utils   ( 5538): specific action
04-23 20:05:48.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.829+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
04-23 20:05:48.839+0200 I/recorder( 5538): guardando datos en local
04-23 20:05:48.839+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:05:48.839+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:05:48.839+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:05:48.839+0200 I/servicemanager( 5532): es.ugr.frailty.gravity sleep timeout
04-23 20:05:48.839+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:05:48.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.839+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:48.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5595
04-23 20:05:48.859+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5595), cmd(0)
04-23 20:05:48.859+0200 I/gravity ( 5595): stopping es.ugr.frailty.gravity service
04-23 20:05:48.859+0200 W/AUL     ( 5595): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:05:48.859+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5595)
04-23 20:05:48.859+0200 I/servicemanager( 5532): es.ugr.frailty.gravity stop request sent!
04-23 20:05:48.859+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:48.909+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope listener destroyed
04-23 20:05:48.909+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:48.909+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5595
04-23 20:05:48.919+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:05:48.919+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:48.919+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:05:48.919+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.939+0200 W/AUL     ( 5595): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:05:48.939+0200 I/gravity ( 5595): request sent to service es.ugr.frailty.servicemanager
04-23 20:05:48.939+0200 I/CAPI_APPFW_APPLICATION( 5595): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:05:48.939+0200 I/utils   ( 5532): specific action
04-23 20:05:48.969+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.979+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.979+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:05:48.979+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:05:48.979+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.979+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.979+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:48.999+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:05:49.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:49.029+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:49.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:05:49.039+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:49.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:05:49.039+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:49.039+0200 I/utils   ( 5538): specific action
04-23 20:05:49.049+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:49.049+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:49.049+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:49.049+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:49.049+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:49.049+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:49.049+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
04-23 20:05:49.049+0200 I/recorder( 5538): guardando datos en local
04-23 20:05:49.049+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:05:49.049+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:05:49.049+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:05:49.059+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:49.069+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:49.099+0200 W/AUL     ( 5909): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 20:05:49.099+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:05:49.099+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:05:49.099+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5555
04-23 20:05:49.099+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:05:49.099+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5555
04-23 20:05:49.099+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5555)
04-23 20:05:49.169+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:49.179+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:05:49.199+0200 W/AUL     ( 5912): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 20:05:49.199+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:05:49.199+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:05:49.199+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5543
04-23 20:05:49.199+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:05:49.209+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5543
04-23 20:05:49.209+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5543)
04-23 20:05:49.209+0200 I/gravity ( 5595): es.ugr.frailty.gravity listener destroyed
04-23 20:05:49.229+0200 W/AUL     ( 5913): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 20:05:49.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:05:49.229+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:05:49.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5545
04-23 20:05:49.229+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:05:49.229+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5545
04-23 20:05:49.229+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5545)
04-23 20:05:49.259+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration listener destroyed
04-23 20:05:49.389+0200 W/AUL     ( 5916): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
04-23 20:05:49.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:05:49.389+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:05:49.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5595
04-23 20:05:49.389+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:05:49.389+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5595
04-23 20:05:49.399+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5595)
04-23 20:05:49.429+0200 W/AUL     ( 5917): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.linearacceleration]
04-23 20:05:49.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:05:49.429+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:05:49.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5580
04-23 20:05:49.429+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:05:49.429+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5580
04-23 20:05:49.429+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5580)
04-23 20:05:50.439+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:05:50.559+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:05:50.609+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:05:50.799+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:05:50.979+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:05:54.309+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:05:54.309+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:05:54.309+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:54.309+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:54.319+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 5926
04-23 20:05:54.319+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:05:54.369+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5926
04-23 20:05:54.369+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(5926) type(svcapp) bg(0)
04-23 20:05:54.369+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5926)
04-23 20:05:54.369+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:05:54.369+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:54.369+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5926]
04-23 20:05:54.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:05:54.399+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5926
04-23 20:05:54.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:05:54.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:05:54.409+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5926
04-23 20:05:54.419+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:05:54.459+0200 E/CAPI_APPFW_APPLICATION( 5926): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:05:54.459+0200 E/CAPI_APPFW_APPLICATION( 5926): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:05:54.459+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (5926) was created
04-23 20:05:54.489+0200 W/LOCATION( 5926): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:05:54.489+0200 E/LOCATION( 5926): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:05:54.489+0200 E/PKGMGR_INFO( 5926): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:05:54.509+0200 W/LOCATION( 5926): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:54.519+0200 I/LOCATION( 5926): location.c: location_new(269) > method: 0
04-23 20:05:54.519+0200 W/LOCATION( 5926): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:54.539+0200 W/LOCATION( 5926): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:54.539+0200 W/LOCATION( 5926): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:54.549+0200 W/LOCATION( 5926): module-internal.c: module_new(311) > module (gps) open success
04-23 20:05:54.549+0200 W/LOCATION( 5926): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:05:54.559+0200 W/LOCATION( 5926): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:05:54.559+0200 W/LOCATION( 5926): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:54.559+0200 W/LOCATION( 5926): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:54.559+0200 W/LOCATION( 5926): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:54.579+0200 W/LOCATION( 5926): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:05:54.589+0200 W/LOCATION( 5926): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:05:54.599+0200 W/LOCATION( 5926): module-internal.c: module_new(311) > module (wps) open success
04-23 20:05:54.599+0200 W/LOCATION( 5926): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:05:54.609+0200 W/LOCATION( 5926): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:05:54.609+0200 W/LOCATION( 5926): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:05:54.609+0200 W/LOCATION( 5926): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:05:54.639+0200 W/LOCATION( 5926): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:05:54.639+0200 I/LOCATION( 5926): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7bffc18
04-23 20:05:54.639+0200 I/LOCATION( 5926): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:05:54.639+0200 I/LOCATION( 5926): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7bffc18
04-23 20:05:54.639+0200 I/LOCATION( 5926): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:05:54.639+0200 I/location( 5926): es.ugr.frailty.location: creado servicio de localización
04-23 20:05:54.699+0200 I/LOCATION( 5926): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:05:54.789+0200 W/LOCATION( 5926): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:54.789+0200 W/LOCATION( 5926): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:54.789+0200 I/LOCATION( 5926): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:05:54.859+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:05:54.859+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:05:54.859+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:05:54.859+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:05:54.859+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:05:54.859+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:05:54.859+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:54.859+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:54.859+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:05:54.859+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:05:54.859+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:05:54.859+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:05:54.859+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:05:54.859+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:05:54.859+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:05:54.859+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:05:54.859+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:05:54.859+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:05:54.909+0200 W/LOCATION( 5926): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:05:54.909+0200 W/LOCATION( 5926): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:05:55.039+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:55.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f15d88]
04-23 20:05:55.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:05:55.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:05:55.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:05:55.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:05:55.099+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:05:55.099+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(830365), time2(817276)
04-23 20:05:55.099+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:05:55.099+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:05:55.099+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:05:55.099+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:05:55.099+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:55.099+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:55.109+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:55.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:55.119+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:05:55.119+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:05:55.119+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:55.119+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:05:55.119+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:05:55.119+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:05:55.119+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:55.119+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:55.119+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:55.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:55.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:55.129+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:05:55.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:55.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:55.219+0200 W/LOCATION( 5926): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:05:55.219+0200 I/LOCATION( 5926): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:05:55.219+0200 I/LOCATION( 5926): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:05:55.219+0200 I/location( 5926): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:05:55.299+0200 I/LOCATION( 5926): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:05:55.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:05:55.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:55.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:05:55.369+0200 E/location( 5926): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:05:55.369+0200 W/AUL     ( 5926): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:05:55.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:55.369+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5926
04-23 20:05:55.379+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:05:55.379+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:55.379+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:05:55.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.379+0200 I/utils   ( 5532): specific action
04-23 20:05:55.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.379+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:05:55.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:55.379+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:55.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:05:55.389+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:55.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:05:55.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.389+0200 I/utils   ( 5538): specific action
04-23 20:05:55.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.389+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:05:55.389+0200 I/recorder( 5538): guardando datos en local
04-23 20:05:55.389+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:05:55.389+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:05:55.389+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:05:55.389+0200 W/AUL     ( 5926): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:05:55.389+0200 I/location( 5926): request sent to service es.ugr.frailty.servicemanager
04-23 20:05:55.389+0200 W/CAPI_APPFW_APP_CONTROL( 5926): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:55.389+0200 I/utils   ( 5926): specific action
04-23 20:05:56.089+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:05:56.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:05:56.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:56.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:05:56.719+0200 W/LOCATION( 5926): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:05:56.879+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11059266c6f63152450675
