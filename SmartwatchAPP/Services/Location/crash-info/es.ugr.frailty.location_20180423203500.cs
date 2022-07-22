S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10566
Date: 2018-04-23 20:35:00+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf723052d, r5   = 0xf7aa6f98
r6   = 0xffa9eb30, r7   = 0xffa9e9e0
r8   = 0xf7aa3c18, r9   = 0x00000000
r10  = 0xffa9eabc, fp   = 0xffa9eb30
ip   = 0x00000001, sp   = 0xffa9e9b8
lr   = 0xf7230539, pc   = 0xf7299228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    141168 KB
Buffers:     37228 KB
Cached:     156664 KB
VmPeak:      53460 KB
VmSize:      53432 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11904 KB
VmRSS:       11904 KB
VmData:      11160 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10566 TID = 10566
10566 10569 

Maps Information
f40fb000 f48fa000 rw-p [stack:10569]
f4901000 f4903000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f490b000 f490f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4918000 f491a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4922000 f4925000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4934000 f4939000 r-xp /usr/lib/libsystem.so.0.0.0
f4944000 f4947000 r-xp /lib/libattr.so.1.1.0
f494f000 f495f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4967000 f4970000 r-xp /usr/lib/libedbus.so.1.7.99
f4978000 f4979000 r-xp /usr/lib/libresponse.so.0.2.96
f4982000 f4987000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6229000 f632f000 r-xp /usr/lib/libicuuc.so.57.1
f6345000 f64cd000 r-xp /usr/lib/libicui18n.so.57.1
f64dd000 f64ea000 r-xp /usr/lib/libail.so.0.1.0
f64f3000 f64fa000 r-xp /usr/lib/libminizip.so.1.0.0
f6503000 f66ac000 r-xp /usr/lib/libcrypto.so.1.0.0
f66cc000 f6713000 r-xp /usr/lib/libssl.so.1.0.0
f671f000 f6721000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6729000 f6730000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6739000 f6740000 r-xp /lib/libcrypt-2.13.so
f6771000 f6774000 r-xp /lib/libcap.so.2.21
f677c000 f677e000 r-xp /usr/lib/libiri.so
f6786000 f67cf000 r-xp /usr/lib/libmdm.so.1.2.69
f67d7000 f67dd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67e5000 f6808000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6812000 f6814000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f681c000 f6839000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6842000 f6846000 r-xp /usr/lib/libsmack.so.1.0.0
f684f000 f6868000 r-xp /usr/lib/libnetwork.so.0.0.0
f6871000 f6879000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6881000 f6887000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6890000 f6892000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f689b000 f68ab000 r-xp /lib/libresolv-2.13.so
f68af000 f68c7000 r-xp /usr/lib/liblzma.so.5.0.3
f68d0000 f68d2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68da000 f68f4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68fc000 f692b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6934000 f6943000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f694d000 f6957000 r-xp /usr/lib/libsensord-shared.so
f6960000 f6a33000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a3e000 f6a54000 r-xp /lib/libz.so.1.2.5
f6a5c000 f6a61000 r-xp /usr/lib/libffi.so.5.0.10
f6a69000 f6a6a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a72000 f6a82000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a8a000 f6aa3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6aab000 f6aad000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ab5000 f6b2a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b34000 f6b3a000 r-xp /lib/librt-2.13.so
f6b43000 f6b61000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b6b000 f6b6c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b74000 f6b97000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b9f000 f6ba4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bac000 f6bd6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bdf000 f6bf6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bfe000 f6c67000 r-xp /lib/libm-2.13.so
f6c70000 f6d04000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d17000 f6d1c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d24000 f6d2b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d33000 f6d5d000 r-xp /usr/lib/libsensor.so.1.9.6
f6d66000 f6e32000 r-xp /usr/lib/libxml2.so.2.7.8
f6e3f000 f6e41000 r-xp /usr/lib/libiniparser.so.0
f6e4a000 f6e50000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e59000 f6f29000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f2a000 f6f5e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f67000 f6fa3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fab000 f6fae000 r-xp /usr/lib/libbundle.so.0.1.22
f6fb6000 f6fbc000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fc4000 f7005000 r-xp /usr/lib/libeina.so.1.7.99
f700e000 f7025000 r-xp /usr/lib/libecore.so.1.7.99
f703c000 f7045000 r-xp /usr/lib/libvconf.so.0.2.45
f704d000 f7061000 r-xp /lib/libpthread-2.13.so
f706c000 f7079000 r-xp /usr/lib/libaul.so.0.1.0
f7083000 f7085000 r-xp /lib/libdl-2.13.so
f708e000 f7099000 r-xp /lib/libunwind.so.8.0.1
f70c6000 f70ce000 r-xp /lib/libgcc_s-4.6.so.1
f70cf000 f71f3000 r-xp /lib/libc-2.13.so
f7201000 f7203000 r-xp /usr/lib/libdlog.so.0.0.0
f720b000 f7217000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7220000 f7225000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f722d000 f723c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7244000 f7248000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7251000 f7254000 r-xp /usr/lib/libappcore-agent.so.1.1
f725c000 f725e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7266000 f726a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7272000 f728f000 r-xp /lib/ld-2.13.so
f7298000 f729b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f729b000 f729f000 r-xp /usr/lib/libsys-assert.so
f7a73000 f7ae0000 rw-p [heap]
ffa80000 ffaa1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10566)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7299228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7230539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f373f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f35c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f41e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f47be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f47dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f7c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f771f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f35c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f41e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f47be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f47dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f79e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f7a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f81f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49191fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf490c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69df663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e8cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e8e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf701eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7019b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf701a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf701a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7252183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72527fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf729953f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf70e685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7298f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ta from es.ugr.frailty.heartrate
04-23 20:34:51.519+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:51.639+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:51.639+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:51:644,0.059821,9.791430,0.782453
04-23 20:34:51.639+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:51.639+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:51:649,-0.140000,0.070000,0.070000
04-23 20:34:51.649+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:51.649+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:51.649+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:51:655,0.021420,0.022171,-0.072223
04-23 20:34:51.649+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:51:659,0.031417,9.768284,0.866037
04-23 20:34:51.719+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:51.719+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:51.839+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:51.839+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:51.839+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:51:844,0.047856,9.851252,0.789631
04-23 20:34:51.839+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:51.849+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:51:845,-0.140000,0.070000,0.070000
04-23 20:34:51.849+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:51.849+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:51:850,0.042003,9.770605,0.838989
04-23 20:34:51.849+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:51:854,0.016440,0.082968,-0.076406
04-23 20:34:51.939+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:51.939+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:51.999+0200 I/servicemanager(10115): es.ugr.frailty.accelerometer sleep timeout
04-23 20:34:51.999+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 20:34:52.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.009+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:52.019+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10126
04-23 20:34:52.019+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.019+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10126), cmd(0)
04-23 20:34:52.019+0200 I/accelerometer(10126): stopping es.ugr.frailty.accelerometer service
04-23 20:34:52.019+0200 W/AUL     (10126): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:34:52.019+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10126)
04-23 20:34:52.019+0200 I/servicemanager(10115): es.ugr.frailty.accelerometer stop request sent!
04-23 20:34:52.019+0200 I/servicemanager(10115): App control destroyed.
04-23 20:34:52.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.029+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10126
04-23 20:34:52.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:34:52.039+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:34:52.039+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.049+0200 W/AUL     (10126): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:34:52.049+0200 I/utils   (10115): specific action
04-23 20:34:52.049+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:34:52.049+0200 I/accelerometer(10126): request sent to service es.ugr.frailty.servicemanager
04-23 20:34:52.049+0200 I/CAPI_APPFW_APPLICATION(10126): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:34:52.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:34:52.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:34:52.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.059+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:52.069+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:34:52.069+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.069+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:34:52.069+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.079+0200 I/utils   (10120): specific action
04-23 20:34:52.079+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.079+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 20:34:52.079+0200 I/recorder(10120): guardando datos en local
04-23 20:34:52.079+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:34:52.079+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:34:52.079+0200 I/servicemanager(10115): requesting to save local data
04-23 20:34:52.079+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:52.039+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:52.079+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:52.089+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:52:88,0.044891,9.771334,0.830311
04-23 20:34:52.099+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:52:90,-0.070000,0.070000,0.070000
04-23 20:34:52.109+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:52:95,0.001068,0.051932,-0.032608
04-23 20:34:52.119+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:52.119+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:52.129+0200 I/servicemanager(10115): es.ugr.frailty.gyroscope sleep timeout
04-23 20:34:52.129+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 20:34:52.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.129+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:52.139+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10129
04-23 20:34:52.139+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10129)
04-23 20:34:52.139+0200 I/servicemanager(10115): es.ugr.frailty.gyroscope stop request sent!
04-23 20:34:52.139+0200 I/servicemanager(10115): App control destroyed.
04-23 20:34:52.149+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.149+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10129), cmd(0)
04-23 20:34:52.149+0200 I/gyroscope(10129): stopping es.ugr.frailty.gyroscope service
04-23 20:34:52.149+0200 W/AUL     (10129): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:34:52.149+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.159+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10129
04-23 20:34:52.159+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.169+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:34:52.169+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.169+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:34:52.169+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.169+0200 I/utils   (10115): specific action
04-23 20:34:52.169+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.169+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:34:52.169+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.169+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.179+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:52.189+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:34:52.189+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.189+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:34:52.189+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.189+0200 I/utils   (10120): specific action
04-23 20:34:52.189+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.189+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.189+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 20:34:52.189+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:34:52.189+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:34:52.189+0200 I/servicemanager(10115): requesting to save local data
04-23 20:34:52.189+0200 W/AUL     (10129): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:34:52.189+0200 I/gyroscope(10129): request sent to service es.ugr.frailty.servicemanager
04-23 20:34:52.189+0200 I/CAPI_APPFW_APPLICATION(10129): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:34:52.189+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:34:52.189+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:34:52.189+0200 I/recorder(10120): guardando datos en local
04-23 20:34:52.199+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer listener destroyed
04-23 20:34:52.229+0200 I/servicemanager(10115): es.ugr.frailty.heartrate sleep timeout
04-23 20:34:52.229+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 20:34:52.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.229+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:52.229+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10143
04-23 20:34:52.239+0200 I/heartrate(10143): stopping es.ugr.frailty.heartrate service
04-23 20:34:52.239+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10143), cmd(0)
04-23 20:34:52.239+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10143)
04-23 20:34:52.239+0200 I/servicemanager(10115): es.ugr.frailty.heartrate stop request sent!
04-23 20:34:52.239+0200 I/servicemanager(10115): App control destroyed.
04-23 20:34:52.239+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:52.239+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:52:244,-0.016177,0.044024,-0.019144
04-23 20:34:52.239+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:52.249+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:52:249,0.045254,9.771116,0.832835
04-23 20:34:52.249+0200 E/CAPI_APPFW_APP_CONTROL(10143): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:34:52.249+0200 E/heartrate(10143): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.heartrate; data: 
04-23 20:34:52.249+0200 I/CAPI_APPFW_APPLICATION(10143): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:34:52.249+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:34:52.249+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:34:52.269+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.299+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.329+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope listener destroyed
04-23 20:34:52.349+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.349+0200 W/AUL     (10522): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 20:34:52.349+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:34:52.349+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:34:52.349+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10126
04-23 20:34:52.349+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:34:52.359+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10126
04-23 20:34:52.359+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10126)
04-23 20:34:52.359+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.379+0200 I/heartrate(10143): es.ugr.frailty.heartrate listener destroyed
04-23 20:34:52.439+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:52.439+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:52:447,0.040743,9.770502,0.840248
04-23 20:34:52.439+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:52.449+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:52:451,-0.004576,0.039457,-0.095846
04-23 20:34:52.459+0200 I/servicemanager(10115): es.ugr.frailty.linearacceleration sleep timeout
04-23 20:34:52.459+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
04-23 20:34:52.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.459+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:52.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10167
04-23 20:34:52.469+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10167)
04-23 20:34:52.469+0200 I/servicemanager(10115): es.ugr.frailty.linearacceleration stop request sent!
04-23 20:34:52.469+0200 I/servicemanager(10115): App control destroyed.
04-23 20:34:52.469+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10167), cmd(0)
04-23 20:34:52.469+0200 I/linearacceleration(10167): stopping es.ugr.frailty.linearacceleration service
04-23 20:34:52.479+0200 W/AUL     (10167): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:34:52.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.479+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10167
04-23 20:34:52.489+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:34:52.489+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.489+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:34:52.499+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.499+0200 I/utils   (10115): specific action
04-23 20:34:52.499+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.499+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.509+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.519+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.519+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:34:52.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.519+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:52.539+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:34:52.539+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:34:52.539+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.539+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:34:52.539+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:34:52.539+0200 I/servicemanager(10115): requesting to save local data
04-23 20:34:52.539+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.539+0200 I/utils   (10120): specific action
04-23 20:34:52.539+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.539+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.539+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.539+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.539+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.539+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
04-23 20:34:52.539+0200 I/recorder(10120): guardando datos en local
04-23 20:34:52.539+0200 I/servicemanager(10115): es.ugr.frailty.gravity sleep timeout
04-23 20:34:52.549+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:34:52.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.549+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:52.549+0200 W/AUL     (10525): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 20:34:52.559+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10179
04-23 20:34:52.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:34:52.559+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:34:52.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10143
04-23 20:34:52.559+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:34:52.559+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.559+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10179), cmd(0)
04-23 20:34:52.559+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10143
04-23 20:34:52.559+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10143)
04-23 20:34:52.559+0200 I/gravity (10179): stopping es.ugr.frailty.gravity service
04-23 20:34:52.559+0200 W/AUL     (10179): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:34:52.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.569+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10179)
04-23 20:34:52.569+0200 I/servicemanager(10115): es.ugr.frailty.gravity stop request sent!
04-23 20:34:52.569+0200 I/servicemanager(10115): App control destroyed.
04-23 20:34:52.569+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10179
04-23 20:34:52.569+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:34:52.579+0200 W/AUL     (10179): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:34:52.579+0200 I/gravity (10179): request sent to service es.ugr.frailty.servicemanager
04-23 20:34:52.579+0200 I/CAPI_APPFW_APPLICATION(10179): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:34:52.579+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:34:52.579+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:34:52.579+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.579+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:34:52.579+0200 W/AUL     (10167): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:34:52.579+0200 I/linearacceleration(10167): request sent to service es.ugr.frailty.servicemanager
04-23 20:34:52.579+0200 I/CAPI_APPFW_APPLICATION(10167): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:34:52.579+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:34:52.579+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:34:52.589+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.589+0200 I/utils   (10115): specific action
04-23 20:34:52.589+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.589+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.589+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.589+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.589+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.589+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:34:52.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:52.589+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:52.599+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:34:52.609+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:34:52.609+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:34:52.609+0200 I/servicemanager(10115): requesting to save local data
04-23 20:34:52.609+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:52.609+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:34:52.609+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.609+0200 I/utils   (10120): specific action
04-23 20:34:52.609+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.609+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.609+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.609+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.609+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.609+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:52.609+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
04-23 20:34:52.609+0200 I/recorder(10120): guardando datos en local
04-23 20:34:52.629+0200 W/AUL     (10526): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 20:34:52.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:34:52.629+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:34:52.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10129
04-23 20:34:52.629+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:34:52.659+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10129
04-23 20:34:52.659+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10129)
04-23 20:34:52.669+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.679+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.689+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.699+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:34:52.709+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration listener destroyed
04-23 20:34:52.739+0200 I/gravity (10179): es.ugr.frailty.gravity listener destroyed
04-23 20:34:52.849+0200 W/AUL     (10530): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.linearacceleration]
04-23 20:34:52.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:34:52.849+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:34:52.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10167
04-23 20:34:52.849+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:34:52.849+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10167
04-23 20:34:52.849+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10167)
04-23 20:34:52.879+0200 W/AUL     (10532): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
04-23 20:34:52.879+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:34:52.879+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:34:52.879+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10179
04-23 20:34:52.879+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:34:52.879+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10179
04-23 20:34:52.879+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10179)
04-23 20:34:54.059+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:34:54.189+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:34:54.249+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:34:54.579+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:34:54.589+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:34:58.259+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:34:58.259+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:34:58.259+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:58.259+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:58.289+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10566
04-23 20:34:58.289+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:34:58.339+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10566
04-23 20:34:58.339+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(10566) type(svcapp) bg(0)
04-23 20:34:58.339+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10566)
04-23 20:34:58.339+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:34:58.339+0200 I/servicemanager(10115): App control destroyed.
04-23 20:34:58.349+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10566]
04-23 20:34:58.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:34:58.379+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10566
04-23 20:34:58.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:34:58.399+0200 E/CAPI_APPFW_APPLICATION(10566): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:34:58.399+0200 E/CAPI_APPFW_APPLICATION(10566): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:34:58.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:34:58.409+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10566
04-23 20:34:58.409+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10566) was created
04-23 20:34:58.419+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:34:58.429+0200 W/LOCATION(10566): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:34:58.429+0200 E/LOCATION(10566): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:34:58.429+0200 E/PKGMGR_INFO(10566): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:34:58.439+0200 W/LOCATION(10566): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:34:58.459+0200 I/LOCATION(10566): location.c: location_new(269) > method: 0
04-23 20:34:58.459+0200 W/LOCATION(10566): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:34:58.459+0200 W/LOCATION(10566): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:34:58.469+0200 W/LOCATION(10566): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:34:58.469+0200 W/LOCATION(10566): module-internal.c: module_new(311) > module (gps) open success
04-23 20:34:58.479+0200 W/LOCATION(10566): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:34:58.479+0200 W/LOCATION(10566): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:34:58.479+0200 W/LOCATION(10566): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:34:58.479+0200 W/LOCATION(10566): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:34:58.479+0200 W/LOCATION(10566): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:34:58.499+0200 W/LOCATION(10566): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:34:58.499+0200 W/LOCATION(10566): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:34:58.509+0200 W/LOCATION(10566): module-internal.c: module_new(311) > module (wps) open success
04-23 20:34:58.509+0200 W/LOCATION(10566): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:34:58.509+0200 W/LOCATION(10566): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:34:58.509+0200 W/LOCATION(10566): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:34:58.509+0200 W/LOCATION(10566): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:34:58.529+0200 W/LOCATION(10566): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:34:58.529+0200 I/LOCATION(10566): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7aa3c18
04-23 20:34:58.529+0200 I/LOCATION(10566): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:34:58.529+0200 I/LOCATION(10566): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7aa3c18
04-23 20:34:58.529+0200 I/LOCATION(10566): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:34:58.529+0200 I/location(10566): es.ugr.frailty.location: creado servicio de localización
04-23 20:34:58.579+0200 I/LOCATION(10566): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:34:58.609+0200 W/LOCATION(10566): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:34:58.609+0200 W/LOCATION(10566): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:34:58.609+0200 I/LOCATION(10566): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:34:58.669+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:34:58.669+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:34:58.669+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:34:58.669+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:34:58.669+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:34:58.669+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:34:58.669+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:34:58.669+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:34:58.669+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:34:58.669+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:34:58.669+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:34:58.669+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:34:58.669+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:34:58.669+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:34:58.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:34:58.679+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:34:58.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:34:58.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:34:58.729+0200 W/LOCATION(10566): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:34:58.729+0200 W/LOCATION(10566): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:34:58.799+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:34:58.829+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1b6a8]
04-23 20:34:58.829+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:34:58.829+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:34:58.829+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:34:58.829+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:34:58.839+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:34:58.839+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:34:58.849+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:34:58.859+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:34:58.859+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:34:58.859+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:34:58.859+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:34:58.859+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:34:58.859+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:34:58.859+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:34:58.859+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:34:58.859+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:34:58.859+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:34:58.859+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:34:58.869+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:34:58.869+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:34:58.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:34:58.919+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:34:58.919+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2574181), time2(2560981)
04-23 20:34:58.919+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:34:58.919+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:34:58.919+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:34:58.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:34:58.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:34:58.949+0200 W/LOCATION(10566): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:34:58.949+0200 I/LOCATION(10566): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:34:58.949+0200 I/LOCATION(10566): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:34:58.949+0200 I/location(10566): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:34:59.039+0200 I/LOCATION(10566): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:34:59.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:34:59.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:34:59.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:34:59.089+0200 W/AUL     (10566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:34:59.089+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:59.099+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10566
04-23 20:34:59.099+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:34:59.099+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.099+0200 I/utils   (10115): specific action
04-23 20:34:59.099+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:59.099+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:34:59.109+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.109+0200 W/AUL     (10566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:34:59.109+0200 I/location(10566): request sent to service es.ugr.frailty.servicemanager
04-23 20:34:59.109+0200 I/location(10566): es.ugr.frailty.location: SM-R760,23/04/2018,20:34:59:97,nan,37.171719,-3.592982,0.000000,0,0.000000,62.000000,-1.000000
04-23 20:34:59.109+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.109+0200 W/CAPI_APPFW_APP_CONTROL(10566): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.109+0200 I/utils   (10566): specific action
04-23 20:34:59.109+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.109+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:34:59.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:34:59.109+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:34:59.119+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:34:59.119+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:34:59.119+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:34:59.119+0200 I/servicemanager(10115): requesting to save local data
04-23 20:34:59.119+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:34:59.119+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:34:59.119+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.119+0200 I/utils   (10120): specific action
04-23 20:34:59.119+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.119+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.119+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.119+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:34:59.119+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:34:59.119+0200 I/recorder(10120): guardando datos en local
04-23 20:34:59.929+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:35:00.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:00.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:00.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:00.669+0200 W/LOCATION(10566): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:35:00.879+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11105666c6f63152450850
