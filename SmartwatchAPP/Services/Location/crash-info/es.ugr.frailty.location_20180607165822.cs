S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13595
Date: 2018-06-07 16:58:22+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf752452d, r5   = 0xf7c08f98
r6   = 0xff80aa50, r7   = 0xff80a900
r8   = 0xf7c05c18, r9   = 0x00000000
r10  = 0xff80a9dc, fp   = 0xff80aa50
ip   = 0x00000001, sp   = 0xff80a8d8
lr   = 0xf7524539, pc   = 0xf758d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     27220 KB
Buffers:      7480 KB
Cached:      52044 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11388 KB
VmRSS:       11388 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13595 TID = 13595
13595 13601 

Maps Information
f43ef000 f4bee000 rw-p [stack:13601]
f4bf5000 f4bf7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bff000 f4c03000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c0c000 f4c0e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c16000 f4c19000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c28000 f4c2d000 r-xp /usr/lib/libsystem.so.0.0.0
f4c38000 f4c3b000 r-xp /lib/libattr.so.1.1.0
f4c43000 f4c53000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c5b000 f4c64000 r-xp /usr/lib/libedbus.so.1.7.99
f4c6c000 f4c6d000 r-xp /usr/lib/libresponse.so.0.2.96
f4c76000 f4c7b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f651d000 f6623000 r-xp /usr/lib/libicuuc.so.57.1
f6639000 f67c1000 r-xp /usr/lib/libicui18n.so.57.1
f67d1000 f67de000 r-xp /usr/lib/libail.so.0.1.0
f67e7000 f67ee000 r-xp /usr/lib/libminizip.so.1.0.0
f67f7000 f69a0000 r-xp /usr/lib/libcrypto.so.1.0.0
f69c0000 f6a07000 r-xp /usr/lib/libssl.so.1.0.0
f6a13000 f6a15000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a1d000 f6a24000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a2d000 f6a34000 r-xp /lib/libcrypt-2.13.so
f6a65000 f6a68000 r-xp /lib/libcap.so.2.21
f6a70000 f6a72000 r-xp /usr/lib/libiri.so
f6a7a000 f6ac3000 r-xp /usr/lib/libmdm.so.1.2.69
f6acb000 f6ad1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ad9000 f6afc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b06000 f6b08000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b10000 f6b2d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b36000 f6b3a000 r-xp /usr/lib/libsmack.so.1.0.0
f6b43000 f6b5c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b65000 f6b6d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b75000 f6b7b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b84000 f6b86000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b8f000 f6b9f000 r-xp /lib/libresolv-2.13.so
f6ba3000 f6bbb000 r-xp /usr/lib/liblzma.so.5.0.3
f6bc4000 f6bc6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bce000 f6be8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bf0000 f6c1f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c28000 f6c37000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c41000 f6c4b000 r-xp /usr/lib/libsensord-shared.so
f6c54000 f6d27000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d32000 f6d48000 r-xp /lib/libz.so.1.2.5
f6d50000 f6d55000 r-xp /usr/lib/libffi.so.5.0.10
f6d5d000 f6d5e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d66000 f6d76000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d7e000 f6d97000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d9f000 f6da1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6da9000 f6e1e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e28000 f6e2e000 r-xp /lib/librt-2.13.so
f6e37000 f6e55000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e5f000 f6e60000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e68000 f6e8b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e93000 f6e98000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ea0000 f6eca000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ed3000 f6eea000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ef2000 f6f5b000 r-xp /lib/libm-2.13.so
f6f64000 f6ff8000 r-xp /usr/lib/libstdc++.so.6.0.16
f700b000 f7010000 r-xp /usr/lib/libctx-client.so.0.8.3
f7018000 f701f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7027000 f7051000 r-xp /usr/lib/libsensor.so.1.9.6
f705a000 f7126000 r-xp /usr/lib/libxml2.so.2.7.8
f7133000 f7135000 r-xp /usr/lib/libiniparser.so.0
f713e000 f7144000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f714d000 f721d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f721e000 f7252000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f725b000 f7297000 r-xp /usr/lib/libSLP-location.so.0.9.24
f729f000 f72a2000 r-xp /usr/lib/libbundle.so.0.1.22
f72aa000 f72b0000 r-xp /usr/lib/libappsvc.so.0.1.0
f72b8000 f72f9000 r-xp /usr/lib/libeina.so.1.7.99
f7302000 f7319000 r-xp /usr/lib/libecore.so.1.7.99
f7330000 f7339000 r-xp /usr/lib/libvconf.so.0.2.45
f7341000 f7355000 r-xp /lib/libpthread-2.13.so
f7360000 f736d000 r-xp /usr/lib/libaul.so.0.1.0
f7377000 f7379000 r-xp /lib/libdl-2.13.so
f7382000 f738d000 r-xp /lib/libunwind.so.8.0.1
f73ba000 f73c2000 r-xp /lib/libgcc_s-4.6.so.1
f73c3000 f74e7000 r-xp /lib/libc-2.13.so
f74f5000 f74f7000 r-xp /usr/lib/libdlog.so.0.0.0
f74ff000 f750b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7514000 f7519000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7521000 f7530000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7538000 f753c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7545000 f7548000 r-xp /usr/lib/libappcore-agent.so.1.1
f7550000 f7552000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f755a000 f755e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7566000 f7583000 r-xp /lib/ld-2.13.so
f758c000 f758f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f758f000 f7593000 r-xp /usr/lib/libsys-assert.so
f7bd5000 f7c5f000 rw-p [heap]
ff7ec000 ff80d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13595)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf758d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7524539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf722b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7229c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7235e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf723bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf723bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf727075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf726b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7229c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7235e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf723bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf723bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf726de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf726e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7275f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c0d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c00171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cd3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7180fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71827a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7312ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf730db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf730e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf730e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7546183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75467fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf758d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf73da85c) [/lib/libc.so.6] + 0x1785c
29: (0xf758cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
vity: SM-R760,07/06/2018,16:58:21:979,2.325656,-0.840402,9.489754
06-07 16:58:21.971+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:21.981+0200 W/CAPI_APPFW_APP_CONTROL(13437): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:21.981+0200 I/utils   (13437): specific action
06-07 16:58:21.981+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:21.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:58:21.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:21.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13437), cmd(0)
06-07 16:58:21.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:21.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(13455), cmd(0)
06-07 16:58:21.981+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:21:988,2.347359,-0.911665,9.549755
06-07 16:58:21.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:21.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(12603), cmd(0)
06-07 16:58:21.981+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:21.981+0200 I/utils   (12603): specific action
06-07 16:58:21.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:58:21.981+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:21.981+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:58:21.981+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:21.981+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:58:21.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:58:21.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:21.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:21.991+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:21:984,2.329157,-0.844753,9.488509
06-07 16:58:21.991+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:21:993,2.414358,-0.856631,9.480364
06-07 16:58:21.991+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:21.991+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:1,2.404787,-0.842274,9.454042
06-07 16:58:22.001+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:58:22.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:22.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12614), cmd(0)
06-07 16:58:22.001+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:5,2.330893,-0.843093,9.488231
06-07 16:58:22.001+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:22.001+0200 I/utils   (12614): specific action
06-07 16:58:22.001+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:58:22.001+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:58:22.001+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:22.001+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:58:22.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:58:22.001+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:10,2.328316,-0.838867,9.489238
06-07 16:58:22.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:22.001+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.011+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:22.011+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.011+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:17,2.347359,-0.746561,9.485149
06-07 16:58:22.011+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:58:22.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:22.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12618), cmd(0)
06-07 16:58:22.021+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:15,2.324180,-0.830458,9.490991
06-07 16:58:22.021+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:22.021+0200 I/utils   (12618): specific action
06-07 16:58:22.021+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:58:22.021+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:58:22.021+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:22.021+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:21:978,-0.350000,0.070000,0.350000
06-07 16:58:22.021+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.021+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:30,2.321292,-0.822999,9.492348
06-07 16:58:22.021+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.031+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:21:971,0.022143,-0.075842,0.059488
06-07 16:58:22.031+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:22,2.333002,-0.722632,9.626326
06-07 16:58:22.031+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.031+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:22.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13501), cmd(0)
06-07 16:58:22.031+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:33,0.630000,0.210000,-0.070000
06-07 16:58:22.031+0200 W/CAPI_APPFW_APP_CONTROL(13501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:22.031+0200 I/utils   (13501): specific action
06-07 16:58:22.031+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:35,2.318467,-0.818058,9.493464
06-07 16:58:22.031+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.031+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.041+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.041+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:38,2.270789,-0.722632,9.635897
06-07 16:58:22.041+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.041+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:48,2.333002,-0.777667,9.477970
06-07 16:58:22.041+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:43,0.088702,-0.016228,-0.009390
06-07 16:58:22.041+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.041+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.051+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:49,1.120000,0.140000,-0.070000
06-07 16:58:22.051+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.051+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:54,0.075630,0.002479,-0.034467
06-07 16:58:22.061+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:58:22.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:58:22.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:58:22.061+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:62,0.630000,-0.490000,0.280000
06-07 16:58:22.061+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.061+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:44,2.321004,-0.817831,9.492865
06-07 16:58:22.071+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.071+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:70,0.016466,0.096532,-0.003081
06-07 16:58:22.071+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:54,2.328217,-0.890130,9.506684
06-07 16:58:22.071+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:76,2.321715,-0.821976,9.492332
06-07 16:58:22.071+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.071+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.081+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.081+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:74,-0.140000,-0.630000,0.070000
06-07 16:58:22.081+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.081+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:84,0.004686,0.116235,0.137088
06-07 16:58:22.081+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:85,2.322906,-0.824410,9.491830
06-07 16:58:22.081+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.081+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:91,1.050000,0.140000,0.140000
06-07 16:58:22.091+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.091+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:87,2.388037,-0.902094,9.463614
06-07 16:58:22.091+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.091+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.091+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:100,2.464607,-0.873380,9.530612
06-07 16:58:22.091+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.101+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:92,2.325418,-0.824072,9.491244
06-07 16:58:22.101+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:98,-0.053392,0.107826,0.144906
06-07 16:58:22.101+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.101+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:103,0.700000,0.840000,-0.140000
06-07 16:58:22.101+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.101+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:107,2.322356,-0.824707,9.491939
06-07 16:58:22.101+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.111+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.111+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:105,2.306681,-0.868595,9.607183
06-07 16:58:22.111+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.111+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:110,0.011710,0.045332,-0.014378
06-07 16:58:22.111+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.111+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:22.111+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:120,2.352145,-0.806381,9.623933
06-07 16:58:22.121+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:112,2.323920,-0.823842,9.491632
06-07 16:58:22.121+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.121+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:22:123,83
06-07 16:58:22.121+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:116,1.050000,0.560000,-1.190000
06-07 16:58:22.121+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:127,2.320640,-0.822867,9.492518
06-07 16:58:22.121+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.131+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.131+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:130,0.009749,-0.072072,0.013220
06-07 16:58:22.131+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.131+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:136,2.333002,-0.851845,9.525827
06-07 16:58:22.131+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.131+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:132,2.317747,-0.824717,9.493065
06-07 16:58:22.131+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:22.131+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.141+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.141+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:141,2.335395,-0.899701,9.489935
06-07 16:58:22.141+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.141+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:22:144,822.000000
06-07 16:58:22.141+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:146,2.100000,-0.280000,-0.350000
06-07 16:58:22.141+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:149,2.347359,-0.859023,9.600004
06-07 16:58:22.141+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.151+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.151+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:144,2.314728,-0.823173,9.493936
06-07 16:58:22.151+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.151+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:138,0.067033,-0.084263,-0.029251
06-07 16:58:22.151+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:159,2.310231,-0.818826,9.495406
06-07 16:58:22.151+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.151+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.161+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:158,-0.490000,-0.910000,-0.280000
06-07 16:58:22.161+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:155,2.373680,-0.839881,9.693325
06-07 16:58:22.161+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:164,0.142893,-0.051404,0.038280
06-07 16:58:22.161+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.161+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.161+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:170,2.397608,-0.681954,9.609575
06-07 16:58:22.161+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:171,-0.016224,-0.044185,0.115354
06-07 16:58:22.171+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.171+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:164,2.316338,-0.813129,9.494408
06-07 16:58:22.171+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.171+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:177,-1.120000,-1.190000,-0.280000
06-07 16:58:22.171+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:179,2.323270,-0.813904,9.492648
06-07 16:58:22.171+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.171+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.181+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:184,0.026726,0.017691,0.132689
06-07 16:58:22.181+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:184,2.342573,-0.775275,9.501899
06-07 16:58:22.181+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.181+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.181+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:189,2.342573,-0.859023,9.485149
06-07 16:58:22.181+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:189,0.010646,-0.027137,0.033889
06-07 16:58:22.181+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.191+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.191+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.191+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.191+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:197,2.388037,-0.875773,9.576077
06-07 16:58:22.191+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:201,0.350000,-0.490000,-0.280000
06-07 16:58:22.191+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:197,2.324481,-0.815416,9.492222
06-07 16:58:22.201+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:195,0.011475,-0.075859,-0.001697
06-07 16:58:22.201+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.201+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:209,0.026719,-0.036156,0.107486
06-07 16:58:22.201+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.211+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.211+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.211+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.211+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:215,2.407180,-0.820738,9.573684
06-07 16:58:22.211+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:219,2.320388,-0.813343,9.493401
06-07 16:58:22.211+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:214,0.055933,-0.015163,0.200260
06-07 16:58:22.211+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:216,2.030000,0.420000,-0.700000
06-07 16:58:22.211+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.221+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:224,0.082881,0.141219,0.115640
06-07 16:58:22.221+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.221+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:229,0.032342,0.043551,0.006493
06-07 16:58:22.221+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.231+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:234,0.026235,-0.045894,-0.009258
06-07 16:58:22.231+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.231+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.231+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.231+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.231+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:240,2.330609,-0.756132,9.511470
06-07 16:58:22.241+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:244,2.318040,-0.809441,9.494308
06-07 16:58:22.241+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:239,0.064767,-0.061869,0.083428
06-07 16:58:22.241+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:241,1.680000,0.560000,-0.770000
06-07 16:58:22.241+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.241+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:250,0.082698,-0.005322,0.081462
06-07 16:58:22.251+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.251+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:256,0.010222,0.057211,0.018069
06-07 16:58:22.251+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.251+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:262,-0.032895,0.098772,-0.047443
06-07 16:58:22.271+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.281+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.281+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.281+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:286,-0.420000,0.700000,-0.770000
06-07 16:58:22.291+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:284,2.318726,-0.807213,9.494329
06-07 16:58:22.291+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.291+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:298,2.313434,-0.799943,9.496236
06-07 16:58:22.291+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.291+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:294,2.285146,-0.710668,9.446864
06-07 16:58:22.301+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.301+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.311+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:306,0.980000,1.260000,-1.330000
06-07 16:58:22.311+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.311+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.311+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:22.321+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:22:323,83
06-07 16:58:22.321+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:322,0.490000,0.560000,-1.050000
06-07 16:58:22.321+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.321+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:320,2.316252,-0.897308,9.583255
06-07 16:58:22.331+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:323,-0.002474,-0.090095,0.088925
06-07 16:58:22.331+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:303,2.310860,-0.802668,9.496633
06-07 16:58:22.331+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.331+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.331+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.331+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:22.341+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:22:342,824.000000
06-07 16:58:22.341+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:333,-1.890000,-0.350000,-0.630000
06-07 16:58:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:58:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:58:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:58:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:58:22.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390702350,000000, pattern:[H:mm][0;m
06-07 16:58:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:58:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:58:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:58:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:58:22.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:58:22.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:58][0;m
06-07 16:58:22.341+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.341+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:338,2.315099,-0.805813,9.495334
06-07 16:58:22.351+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.351+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:357,2.327606,-0.811924,9.491755
06-07 16:58:22.351+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:342,2.277967,-0.794417,9.576077
06-07 16:58:22.351+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:343,-0.035467,0.005526,0.079841
06-07 16:58:22.351+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.361+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.361+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:351,-3.640000,0.420000,0.070000
06-07 16:58:22.361+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.361+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.361+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:369,-5.110000,0.490000,-0.070000
06-07 16:58:22.371+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:362,2.346161,-0.818317,9.486636
06-07 16:58:22.371+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.371+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:372,0.086749,0.017822,0.043551
06-07 16:58:22.371+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:373,2.397608,-0.784846,9.540184
06-07 16:58:22.371+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:380,2.342662,-0.816649,9.487645
06-07 16:58:22.371+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.381+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.381+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:384,-0.630000,0.350000,-0.770000
06-07 16:58:22.381+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.391+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.391+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:392,2.452643,-0.734596,9.535398
06-07 16:58:22.391+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:389,0.137545,0.071216,0.040065
06-07 16:58:22.391+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:397,2.334117,-0.819100,9.489539
06-07 16:58:22.391+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.391+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.401+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:402,2.170000,1.120000,0.140000
06-07 16:58:22.401+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.401+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:403,-0.071175,0.041435,0.110642
06-07 16:58:22.401+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.401+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:410,0.034698,-0.167526,0.144475
06-07 16:58:22.411+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.411+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:409,2.256432,-0.770489,9.602397
06-07 16:58:22.411+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:416,-3.430000,-0.560000,0.140000
06-07 16:58:22.411+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.411+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.411+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:421,2.348820,-0.822346,9.485630
06-07 16:58:22.421+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.421+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:427,0.083660,0.079660,0.021432
06-07 16:58:22.421+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:424,2.380858,-0.985843,9.631111
06-07 16:58:22.421+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.431+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:433,0.003671,-0.049495,0.017145
06-07 16:58:22.431+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.441+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.441+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.441+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:448,-2.800000,-0.420000,0.140000
06-07 16:58:22.451+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:450,2.356670,-0.830354,9.482985
06-07 16:58:22.451+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.451+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:442,2.426322,-0.736989,9.509077
06-07 16:58:22.451+0200 W/LOCATION(13595): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:58:22.451+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.461+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:464,2.337788,-0.868595,9.506684
06-07 16:58:22.461+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.461+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.461+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:469,0.420000,0.910000,-0.630000
06-07 16:58:22.471+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:471,2.299503,-0.952343,9.556933
06-07 16:58:22.471+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.471+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.471+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:459,2.350411,-0.834485,9.484176
06-07 16:58:22.471+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:477,-0.049318,-0.129997,0.071303
06-07 16:58:22.471+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.471+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.481+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:485,2.341700,-0.834966,9.486288
06-07 16:58:22.481+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:481,2.225325,-0.894916,9.559326
06-07 16:58:22.481+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.491+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.491+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:494,2.270789,-0.780060,9.506684
06-07 16:58:22.491+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.491+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:495,0.910000,0.140000,-1.120000
06-07 16:58:22.491+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.491+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:499,2.333980,-0.827980,9.488803
06-07 16:58:22.491+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.491+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:501,1.820000,0.350000,-1.750000
06-07 16:58:22.501+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:482,-0.131345,-0.064562,0.076342
06-07 16:58:22.501+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.501+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:507,2.356930,-0.820738,9.530612
06-07 16:58:22.501+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:507,-0.079622,0.054425,0.022509
06-07 16:58:22.501+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.511+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.511+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:515,0.015230,0.014228,0.044324
06-07 16:58:22.511+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:516,2.356930,-0.782453,9.583255
06-07 16:58:22.511+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.511+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.511+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:22.511+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:521,0.022950,0.045527,0.094452
06-07 16:58:22.521+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:22:523,83
06-07 16:58:22.521+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.521+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:521,2.324497,-0.820919,9.491743
06-07 16:58:22.521+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:528,2.870000,1.260000,-0.770000
06-07 16:58:22.531+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.531+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:22.531+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.531+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:541,0.020470,0.012145,0.184832
06-07 16:58:22.541+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:22:542,821.000000
06-07 16:58:22.541+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.541+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:546,2.322266,-0.816543,9.492666
06-07 16:58:22.541+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:549,2.344966,-0.808774,9.676575
06-07 16:58:22.551+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.551+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.551+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.551+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:556,2.321990,-0.815275,9.492844
06-07 16:58:22.551+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:555,0.910000,0.350000,-0.700000
06-07 16:58:22.551+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.561+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:556,0.077735,-0.044873,0.066660
06-07 16:58:22.571+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.571+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.571+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.571+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:577,2.326713,-0.817412,9.491503
06-07 16:58:22.571+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:578,0.025369,-0.053320,0.078447
06-07 16:58:22.571+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:564,0.210000,-0.630000,0.070000
06-07 16:58:22.571+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.581+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:576,2.400001,-0.861416,9.559326
06-07 16:58:22.581+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.581+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:585,0.070000,-1.120000,0.210000
06-07 16:58:22.581+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:587,2.347359,-0.868595,9.571291
06-07 16:58:22.591+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.591+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.591+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:597,2.326607,-0.819001,9.491392
06-07 16:58:22.591+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:597,0.070895,-0.053575,-0.013533
06-07 16:58:22.591+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.591+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.601+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:602,2.397608,-0.870987,9.477970
06-07 16:58:22.601+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:602,0.350000,-0.490000,0.210000
06-07 16:58:22.611+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.611+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.611+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:617,0.071002,-0.063951,0.063148
06-07 16:58:22.611+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.611+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.611+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:621,1.190000,-0.490000,-0.490000
06-07 16:58:22.621+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:617,2.328014,-0.819017,9.491046
06-07 16:58:22.621+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:623,2.397608,-0.882952,9.554541
06-07 16:58:22.631+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.631+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.631+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.631+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:641,2.321125,-0.814726,9.493102
06-07 16:58:22.641+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:641,3.220000,0.420000,-0.770000
06-07 16:58:22.641+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:646,0.028916,0.017422,0.061102
06-07 16:58:22.641+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.651+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.651+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.651+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.651+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:656,2.800000,-0.630000,-0.420000
06-07 16:58:22.651+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:659,2.315865,-0.808206,9.494944
06-07 16:58:22.661+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:656,-0.026408,0.132771,0.068617
06-07 16:58:22.661+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:654,2.356930,-0.801596,9.552148
06-07 16:58:22.661+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.661+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:671,2.294717,-0.681954,9.561719
06-07 16:58:22.671+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.671+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.671+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.671+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:677,0.840000,-0.070000,-0.420000
06-07 16:58:22.671+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:680,2.312485,-0.800134,9.496451
06-07 16:58:22.671+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:677,0.031494,0.133430,0.009348
06-07 16:58:22.681+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.681+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:688,2.347359,-0.674776,9.504292
06-07 16:58:22.691+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.691+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.691+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.691+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:696,-0.280000,-0.280000,-0.070000
06-07 16:58:22.691+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:700,2.315443,-0.794764,9.496181
06-07 16:58:22.691+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:697,0.037267,0.077502,-0.073516
06-07 16:58:22.701+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.701+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:707,2.349752,-0.722632,9.422935
06-07 16:58:22.711+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.711+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.711+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:716,-1.260000,-0.280000,0.280000
06-07 16:58:22.711+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.711+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:22.711+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:720,2.321755,-0.794334,9.494676
06-07 16:58:22.721+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:717,0.027130,-0.014010,0.063145
06-07 16:58:22.721+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:22:724,83
06-07 16:58:22.721+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:22.721+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:22:729,2.342573,-0.808774,9.559326
06-07 16:58:22.731+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.731+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.741+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:22.741+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.741+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:742,-0.420000,-0.070000,0.910000
06-07 16:58:22.741+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:22:747,824.000000
06-07 16:58:22.751+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.751+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:22:742,2.322608,-0.795914,9.494335
06-07 16:58:22.751+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:22.751+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:22:746,0.027997,-0.117332,0.100543
06-07 16:58:22.751+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:756,0.980000,0.420000,0.700000
06-07 16:58:22.751+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:22.771+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:22.781+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:22:777,0.070000,-0.350000,0.770000
06-07 16:58:22.781+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11135956c6f63152838350
