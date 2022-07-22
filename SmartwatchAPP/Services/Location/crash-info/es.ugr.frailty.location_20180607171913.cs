S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19919
Date: 2018-06-07 17:19:13+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf770652d, r5   = 0xf7a4df98
r6   = 0xff94b1e0, r7   = 0xff94b090
r8   = 0xf7a4ac18, r9   = 0x00000000
r10  = 0xff94b16c, fp   = 0xff94b1e0
ip   = 0x00000001, sp   = 0xff94b068
lr   = 0xf7706539, pc   = 0xf776f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    243392 KB
Buffers:      2156 KB
Cached:      53268 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11476 KB
VmRSS:       11476 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19919 TID = 19919
19919 19932 

Maps Information
f45d1000 f4dd0000 rw-p [stack:19932]
f4dd7000 f4dd9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4de1000 f4de5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dee000 f4df0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4df8000 f4dfb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e0a000 f4e0f000 r-xp /usr/lib/libsystem.so.0.0.0
f4e1a000 f4e1d000 r-xp /lib/libattr.so.1.1.0
f4e25000 f4e35000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e3d000 f4e46000 r-xp /usr/lib/libedbus.so.1.7.99
f4e4e000 f4e4f000 r-xp /usr/lib/libresponse.so.0.2.96
f4e58000 f4e5d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66ff000 f6805000 r-xp /usr/lib/libicuuc.so.57.1
f681b000 f69a3000 r-xp /usr/lib/libicui18n.so.57.1
f69b3000 f69c0000 r-xp /usr/lib/libail.so.0.1.0
f69c9000 f69d0000 r-xp /usr/lib/libminizip.so.1.0.0
f69d9000 f6b82000 r-xp /usr/lib/libcrypto.so.1.0.0
f6ba2000 f6be9000 r-xp /usr/lib/libssl.so.1.0.0
f6bf5000 f6bf7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bff000 f6c06000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c0f000 f6c16000 r-xp /lib/libcrypt-2.13.so
f6c47000 f6c4a000 r-xp /lib/libcap.so.2.21
f6c52000 f6c54000 r-xp /usr/lib/libiri.so
f6c5c000 f6ca5000 r-xp /usr/lib/libmdm.so.1.2.69
f6cad000 f6cb3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cbb000 f6cde000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ce8000 f6cea000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cf2000 f6d0f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d18000 f6d1c000 r-xp /usr/lib/libsmack.so.1.0.0
f6d25000 f6d3e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d47000 f6d4f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d57000 f6d5d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d66000 f6d68000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d71000 f6d81000 r-xp /lib/libresolv-2.13.so
f6d85000 f6d9d000 r-xp /usr/lib/liblzma.so.5.0.3
f6da6000 f6da8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6db0000 f6dca000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dd2000 f6e01000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e0a000 f6e19000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e23000 f6e2d000 r-xp /usr/lib/libsensord-shared.so
f6e36000 f6f09000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f14000 f6f2a000 r-xp /lib/libz.so.1.2.5
f6f32000 f6f37000 r-xp /usr/lib/libffi.so.5.0.10
f6f3f000 f6f40000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f48000 f6f58000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f60000 f6f79000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f81000 f6f83000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f8b000 f7000000 r-xp /usr/lib/libsqlite3.so.0.8.6
f700a000 f7010000 r-xp /lib/librt-2.13.so
f7019000 f7037000 r-xp /usr/lib/libsystemd.so.0.4.0
f7041000 f7042000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f704a000 f706d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7075000 f707a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7082000 f70ac000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70b5000 f70cc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70d4000 f713d000 r-xp /lib/libm-2.13.so
f7146000 f71da000 r-xp /usr/lib/libstdc++.so.6.0.16
f71ed000 f71f2000 r-xp /usr/lib/libctx-client.so.0.8.3
f71fa000 f7201000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7209000 f7233000 r-xp /usr/lib/libsensor.so.1.9.6
f723c000 f7308000 r-xp /usr/lib/libxml2.so.2.7.8
f7315000 f7317000 r-xp /usr/lib/libiniparser.so.0
f7320000 f7326000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f732f000 f73ff000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7400000 f7434000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f743d000 f7479000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7481000 f7484000 r-xp /usr/lib/libbundle.so.0.1.22
f748c000 f7492000 r-xp /usr/lib/libappsvc.so.0.1.0
f749a000 f74db000 r-xp /usr/lib/libeina.so.1.7.99
f74e4000 f74fb000 r-xp /usr/lib/libecore.so.1.7.99
f7512000 f751b000 r-xp /usr/lib/libvconf.so.0.2.45
f7523000 f7537000 r-xp /lib/libpthread-2.13.so
f7542000 f754f000 r-xp /usr/lib/libaul.so.0.1.0
f7559000 f755b000 r-xp /lib/libdl-2.13.so
f7564000 f756f000 r-xp /lib/libunwind.so.8.0.1
f759c000 f75a4000 r-xp /lib/libgcc_s-4.6.so.1
f75a5000 f76c9000 r-xp /lib/libc-2.13.so
f76d7000 f76d9000 r-xp /usr/lib/libdlog.so.0.0.0
f76e1000 f76ed000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76f6000 f76fb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7703000 f7712000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f771a000 f771e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7727000 f772a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7732000 f7734000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f773c000 f7740000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7748000 f7765000 r-xp /lib/ld-2.13.so
f776e000 f7771000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7771000 f7775000 r-xp /usr/lib/libsys-assert.so
f7a1a000 f7aa8000 rw-p [heap]
ff92c000 ff94d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19919)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf776f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7706539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf740d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf740bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7417e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf741dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf741ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf745275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf744d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf740bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7417e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf741dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf741ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf744fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7450017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7457f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4def1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4de2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6eb5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7362fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73647a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74f4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74efb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74f05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74f0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7728183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77287fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf776f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75bc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf776ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
7:19:11.301+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:19:11.301+0200 I/utils   (19621): specific action
06-07 17:19:11.301+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:19:11.301+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:19:11.301+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:11.301+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:19:11.301+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:19:11.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:11.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:11.311+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19919
06-07 17:19:11.321+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:11.321+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(19919), cmd(0)
06-07 17:19:11.321+0200 W/CAPI_APPFW_APP_CONTROL(19919): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:19:11.321+0200 I/utils   (19919): specific action
06-07 17:19:11.321+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19919)
06-07 17:19:11.321+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:19:11.321+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:11.321+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:19:11.321+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:19:11.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:11.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:11.341+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19639
06-07 17:19:11.341+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19639)
06-07 17:19:11.341+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:19:11.341+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:11.341+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:19:11.341+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:19:11.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:11.351+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:11.361+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19651
06-07 17:19:11.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19651)
06-07 17:19:11.361+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:19:11.361+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:11.361+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:19:11.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:19:11.371+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:11.371+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:11.381+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:19:11.391+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:11.391+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(19663), cmd(0)
06-07 17:19:11.391+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:19:11.391+0200 I/utils   (19663): specific action
06-07 17:19:11.391+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:19:11.391+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:19:11.391+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:11.391+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:19:11.391+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:19:11.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:11.391+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:11.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:19:11.411+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:19:11.411+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:19:11.411+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:11.411+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:19:11.411+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:19:11.411+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:11.411+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:11.411+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:11.411+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:11.421+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:19:11.421+0200 I/utils   (19670): specific action
06-07 17:19:11.431+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:19:11.431+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:11.431+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(19670), cmd(0)
06-07 17:19:11.431+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:11.431+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(19682), cmd(0)
06-07 17:19:11.431+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:207,0.017186,-0.014273,0.054602
06-07 17:19:11.441+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:19:11.441+0200 I/utils   (19682): specific action
06-07 17:19:11.441+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:19:11.441+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:19:11.441+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:11.441+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:11.441+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:11:448,826.000000
06-07 17:19:11.461+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:19:11:456,0.308991,-0.103046,9.801239
06-07 17:19:11.461+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:19:11.471+0200 E/RESOURCED( 2560): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
06-07 17:19:11.521+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.521+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:527,0.009648,-0.025763,0.052224
06-07 17:19:11.531+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:19:11.531+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:11.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(19651), cmd(0)
06-07 17:19:11.531+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:19:11.531+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:11.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(19651), cmd(0)
06-07 17:19:11.541+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:19:11.541+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:11.541+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(19651), cmd(0)
06-07 17:19:11.551+0200 W/AUL     (19975): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
06-07 17:19:11.551+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:19:11.551+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:19:11.551+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 19031
06-07 17:19:11.551+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:19:11.561+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19031
06-07 17:19:11.561+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19031)
06-07 17:19:11.581+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.581+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:588,0.012228,0.006206,0.035477
06-07 17:19:11.581+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.591+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:596,-0.002221,-0.032562,0.057011
06-07 17:19:11.591+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.601+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:602,0.012168,0.014547,0.033098
06-07 17:19:11.601+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.611+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:610,0.047191,0.002056,0.066619
06-07 17:19:11.611+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.611+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:11.611+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:11.611+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:618,0.013670,-0.002656,0.047553
06-07 17:19:11.621+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.621+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:626,0.003126,-0.009557,0.030837
06-07 17:19:11.621+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.621+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:11.631+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:11:636,829.000000
06-07 17:19:11.641+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:632,-0.004266,-0.028135,0.038027
06-07 17:19:11.641+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:220,0.284746,-0.148355,9.815358
06-07 17:19:11.641+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:228,0.070000,0.070000,0.070000
06-07 17:19:11.641+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.641+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.651+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.661+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:654,0.013085,-0.029390,0.054770
06-07 17:19:11.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:669,0.070000,-0.070000,0.070000
06-07 17:19:11.671+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:652,0.318245,-0.086142,9.791430
06-07 17:19:11.671+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.681+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.691+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:695,0.034379,-0.018649,-0.005032
06-07 17:19:11.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:701,0.140000,0.070000,0.070000
06-07 17:19:11.691+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:683,0.311067,-0.083749,9.817751
06-07 17:19:11.701+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.711+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.721+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.721+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:709,0.332602,-0.069392,9.841680
06-07 17:19:11.721+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.731+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:716,0.028290,-0.005983,0.030910
06-07 17:19:11.731+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.741+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:730,0.070000,0.070000,0.070000
06-07 17:19:11.741+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:729,0.289532,-0.112463,9.856036
06-07 17:19:11.741+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.751+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:750,0.017822,0.018039,0.030939
06-07 17:19:11.761+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.771+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.771+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:759,0.337388,-0.122034,9.777073
06-07 17:19:11.771+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.801+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:767,0.070000,0.070000,0.070000
06-07 17:19:11.801+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.811+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:785,-0.006448,0.031359,0.066832
06-07 17:19:11.811+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:799,0.318245,-0.114855,9.853643
06-07 17:19:11.811+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:11.811+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:11.811+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.811+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.821+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:825,0.334995,-0.105284,9.820145
06-07 17:19:11.821+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:819,0.140000,0.070000,0.070000
06-07 17:19:11.831+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:11.831+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:11:836,825.000000
06-07 17:19:11.831+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.841+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:831,-0.041580,0.020070,0.073969
06-07 17:19:11.841+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.841+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:848,0.303888,-0.071785,9.839286
06-07 17:19:11.851+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.851+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:852,0.070000,0.070000,0.070000
06-07 17:19:11.861+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:866,0.013484,0.011714,0.021239
06-07 17:19:11.861+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.871+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.871+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:878,-0.070000,0.070000,0.070000
06-07 17:19:11.871+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:870,0.301496,-0.086142,9.834501
06-07 17:19:11.871+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.881+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:889,0.323031,-0.107677,9.829715
06-07 17:19:11.891+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:884,-0.024966,-0.003379,-0.000299
06-07 17:19:11.891+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.901+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:907,0.342174,-0.095713,9.836893
06-07 17:19:11.911+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:902,-0.070000,-0.070000,0.070000
06-07 17:19:11.911+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:914,0.004862,-0.034185,0.033169
06-07 17:19:11.911+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.921+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.921+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:926,0.303888,-0.112463,9.841680
06-07 17:19:11.921+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.931+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:937,-0.005382,-0.015671,0.040385
06-07 17:19:11.931+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.931+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:941,0.325424,-0.100499,9.903893
06-07 17:19:11.941+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:932,-0.070000,-0.070000,-0.070000
06-07 17:19:11.941+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.951+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.951+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.951+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:959,0.011755,-0.015074,0.045165
06-07 17:19:11.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:955,-0.070000,-0.070000,-0.070000
06-07 17:19:11.961+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:963,0.303888,-0.050249,9.841680
06-07 17:19:11.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.971+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.971+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:976,0.308674,-0.126820,9.839286
06-07 17:19:11.971+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:11:980,-0.070000,0.070000,-0.070000
06-07 17:19:11.981+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:11.981+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:11:989,-0.015005,0.011805,0.023648
06-07 17:19:11.981+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:11.991+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:11:995,0.299103,-0.102891,9.836893
06-07 17:19:11.991+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:11.991+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.001+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:8,0.007340,0.013486,-0.000312
06-07 17:19:12.001+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.011+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:5,0.070000,0.070000,-0.070000
06-07 17:19:12.011+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:12.011+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:12.021+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.021+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.021+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:13,0.332602,-0.078963,9.820145
06-07 17:19:12.021+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:12.031+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:12:35,827.000000
06-07 17:19:12.041+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:46,0.031325,-0.006477,0.021214
06-07 17:19:12.041+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.041+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:32,0.070000,0.070000,-0.070000
06-07 17:19:12.051+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:55,0.346959,-0.040678,9.877571
06-07 17:19:12.051+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.051+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.051+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.061+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:69,0.013767,0.000673,0.054738
06-07 17:19:12.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:76,0.070000,0.070000,-0.070000
06-07 17:19:12.071+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:65,0.334995,-0.124427,9.848858
06-07 17:19:12.071+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.081+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.091+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.091+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:96,-0.005545,-0.023489,0.011670
06-07 17:19:12.101+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:105,0.070000,0.070000,-0.070000
06-07 17:19:12.101+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:85,0.318245,-0.083749,9.817751
06-07 17:19:12.101+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.111+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.111+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.111+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:110,0.320638,-0.100499,9.824929
06-07 17:19:12.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:19:12.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:19:12.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:19:12.131+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.131+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:136,0.301496,-0.098106,9.834501
06-07 17:19:12.141+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:119,-0.020050,-0.015023,0.052365
06-07 17:19:12.141+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:130,0.070000,0.070000,0.070000
06-07 17:19:12.141+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.141+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.141+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.151+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:156,0.320638,-0.069392,9.870394
06-07 17:19:12.151+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:152,-0.023699,-0.019233,0.033194
06-07 17:19:12.161+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:165,0.070000,0.070000,0.070000
06-07 17:19:12.161+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.161+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.181+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.181+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:172,0.287139,-0.122034,9.805787
06-07 17:19:12.181+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:188,0.070000,0.070000,0.070000
06-07 17:19:12.191+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.191+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:175,-0.000873,-0.025618,0.037945
06-07 17:19:12.191+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:197,0.368495,-0.107677,9.836893
06-07 17:19:12.191+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.191+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.201+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:205,0.004268,-0.024706,0.030766
06-07 17:19:12.201+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:208,0.070000,0.070000,0.070000
06-07 17:19:12.211+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.211+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:216,0.330210,-0.095713,9.829715
06-07 17:19:12.211+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:12.211+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:12.211+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.221+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:230,0.025661,-0.021291,0.006852
06-07 17:19:12.221+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:12.231+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:12:235,828.000000
06-07 17:19:12.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.231+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.231+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:242,0.320638,-0.119641,9.827322
06-07 17:19:12.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:245,-0.070000,0.070000,-0.070000
06-07 17:19:12.251+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.251+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.251+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:258,0.318245,-0.078963,9.827322
06-07 17:19:12.251+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:262,0.003231,-0.020475,0.037994
06-07 17:19:12.261+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.271+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.271+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:272,-0.070000,-0.070000,-0.070000
06-07 17:19:12.271+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:19:12.271+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:281,0.334995,-0.105284,9.851252
06-07 17:19:12.281+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:19:12:285,0.041752,0.023365,0.052353
06-07 17:19:12.281+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.291+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.291+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:297,0.320638,-0.107677,9.846465
06-07 17:19:12.291+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:295,0.070000,-0.070000,-0.070000
06-07 17:19:12.301+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.301+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.311+0200 E/RESOURCED( 2560): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
06-07 17:19:12.321+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:314,0.337388,-0.112463,9.798609
06-07 17:19:12.391+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.391+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:396,0.327817,-0.117248,9.868000
06-07 17:19:12.391+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.401+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:332,0.070000,-0.070000,-0.070000
06-07 17:19:12.401+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.401+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:409,0.070000,-0.070000,-0.070000
06-07 17:19:12.401+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.421+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:400,0.294317,-0.090927,9.868000
06-07 17:19:12.421+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.421+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:428,0.299103,-0.071785,9.868000
06-07 17:19:12.421+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:12.421+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.441+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:414,0.070000,0.070000,-0.070000
06-07 17:19:12.441+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:12.441+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.441+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:450,0.140000,0.070000,-0.070000
06-07 17:19:12.461+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:12.461+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:431,0.308674,-0.133998,9.832108
06-07 17:19:12.461+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.461+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:468,0.332602,-0.088534,9.805787
06-07 17:19:12.461+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.471+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.471+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:476,0.070000,0.070000,-0.070000
06-07 17:19:12.471+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:480,0.339781,-0.095713,9.860823
06-07 17:19:12.481+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.481+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.491+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:495,0.260818,-0.143569,9.803394
06-07 17:19:12.491+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:499,-0.070000,-0.070000,-0.070000
06-07 17:19:12.501+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.511+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.521+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:12:454,829.000000
06-07 17:19:12.531+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:516,0.325424,-0.117248,9.844072
06-07 17:19:12.531+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.531+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:537,0.070000,-0.070000,-0.070000
06-07 17:19:12.541+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:545,0.308674,-0.090927,9.791430
06-07 17:19:12.551+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.551+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:19:12.551+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:12.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(19639), cmd(0)
06-07 17:19:12.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:19:12.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:12.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(19639), cmd(0)
06-07 17:19:12.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:19:12.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:19:12.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(19639), cmd(0)
06-07 17:19:12.561+0200 W/AUL     (19976): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.linearacceleration]
06-07 17:19:12.561+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:19:12.561+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:19:12.561+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 19479
06-07 17:19:12.561+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:19:12.561+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.581+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19479
06-07 17:19:12.581+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19479)
06-07 17:19:12.581+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:572,0.070000,-0.070000,-0.070000
06-07 17:19:12.611+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19605) cmd(0)
06-07 17:19:12.611+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:12.611+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:12.631+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:12.631+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:12:637,830.000000
06-07 17:19:12.641+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:575,0.306281,-0.074178,9.820145
06-07 17:19:12.651+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.651+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.651+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:656,0.320638,-0.045464,9.822537
06-07 17:19:12.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:663,0.140000,-0.070000,-0.070000
06-07 17:19:12.661+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.671+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.681+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:675,0.299103,-0.138784,9.824929
06-07 17:19:12.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:689,0.070000,-0.070000,-0.070000
06-07 17:19:12.691+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.701+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:704,0.311067,-0.114855,9.829715
06-07 17:19:12.711+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.711+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.721+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:724,0.327817,-0.078963,9.805787
06-07 17:19:12.721+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:717,0.070000,0.070000,-0.070000
06-07 17:19:12.731+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.741+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.741+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:747,0.070000,0.070000,-0.070000
06-07 17:19:12.751+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:742,0.277567,-0.107677,9.767502
06-07 17:19:12.751+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.771+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.781+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:783,0.070000,0.070000,0.070000
06-07 17:19:12.781+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:765,0.320638,-0.052642,9.810574
06-07 17:19:12.791+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.801+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.801+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:796,0.301496,-0.066999,9.848858
06-07 17:19:12.811+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.811+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:12.811+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:12.831+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:12.851+0200 W/LOCATION(19919): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:19:12.871+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:12:841,832.000000
06-07 17:19:12.881+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:822,0.313460,-0.119641,9.827322
06-07 17:19:12.901+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.911+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:820,0.070000,0.070000,0.070000
06-07 17:19:12.921+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.931+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:917,0.318245,-0.102891,9.824929
06-07 17:19:12.931+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.941+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:930,0.070000,0.070000,0.070000
06-07 17:19:12.941+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:939,0.349352,-0.076570,9.844072
06-07 17:19:12.951+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.961+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.971+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:12:962,-0.070000,-0.140000,0.070000
06-07 17:19:12.981+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:969,0.358923,-0.090927,9.827322
06-07 17:19:12.981+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:12.981+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:12.981+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:12:990,0.323031,-0.114855,9.846465
06-07 17:19:13.001+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:13:0,0.070000,-0.140000,0.070000
06-07 17:19:13.001+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:13.011+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:13.021+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:19:13.021+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:19:13.021+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:13:14,0.303888,-0.076570,9.803394
06-07 17:19:13.021+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:13:29,0.070000,0.070000,0.070000
06-07 17:19:13.031+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:13.031+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:19:13:36,834.000000
06-07 17:19:13.041+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:13.051+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:13.061+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:19:13:65,0.070000,0.070000,0.070000
06-07 17:19:13.061+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:13:46,0.337388,-0.083749,9.851252
06-07 17:19:13.061+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:13.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:19:13.101+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:19:13:75,0.301496,-0.117248,9.820145
06-07 17:19:13.101+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:19:13.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:19:13.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:19:13.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:19:13.171+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:19:13.171+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:19:13.171+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:13.171+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:13.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19935
06-07 17:19:13.191+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19935)
06-07 17:19:13.191+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:19:13.191+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:13.191+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:19:13.191+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:19:13.191+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:13.191+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:13.201+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19605
06-07 17:19:13.201+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19605)
06-07 17:19:13.201+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:19:13.201+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:13.201+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:19:13.201+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:19:13.201+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:13.211+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:13.221+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:19:13.221+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:19:13.221+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:19:13.221+0200 I/servicemanager(19582): App control destroyed.
06-07 17:19:13.221+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:19:13.221+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:19:13.221+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:19:13.231+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:19:13.241+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:19:13.271+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 19979
06-07 17:19:13.271+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 17:19:13.271+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11199196c6f63152838475
