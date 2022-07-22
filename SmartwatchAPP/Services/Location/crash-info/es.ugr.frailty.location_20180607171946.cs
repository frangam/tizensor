S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20048
Date: 2018-06-07 17:19:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf736e52d, r5   = 0xf7504f98
r6   = 0xff9c5ef0, r7   = 0xff9c5da0
r8   = 0xf7501c18, r9   = 0x00000000
r10  = 0xff9c5e7c, fp   = 0xff9c5ef0
ip   = 0x00000001, sp   = 0xff9c5d78
lr   = 0xf736e539, pc   = 0xf73d7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    285616 KB
Buffers:      3744 KB
Cached:      60704 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11772 KB
VmRSS:       11768 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20048 TID = 20048
20048 20052 

Maps Information
f4239000 f4a38000 rw-p [stack:20052]
f4a3f000 f4a41000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a49000 f4a4d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a56000 f4a58000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a60000 f4a63000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a72000 f4a77000 r-xp /usr/lib/libsystem.so.0.0.0
f4a82000 f4a85000 r-xp /lib/libattr.so.1.1.0
f4a8d000 f4a9d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4aa5000 f4aae000 r-xp /usr/lib/libedbus.so.1.7.99
f4ab6000 f4ab7000 r-xp /usr/lib/libresponse.so.0.2.96
f4ac0000 f4ac5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6367000 f646d000 r-xp /usr/lib/libicuuc.so.57.1
f6483000 f660b000 r-xp /usr/lib/libicui18n.so.57.1
f661b000 f6628000 r-xp /usr/lib/libail.so.0.1.0
f6631000 f6638000 r-xp /usr/lib/libminizip.so.1.0.0
f6641000 f67ea000 r-xp /usr/lib/libcrypto.so.1.0.0
f680a000 f6851000 r-xp /usr/lib/libssl.so.1.0.0
f685d000 f685f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6867000 f686e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6877000 f687e000 r-xp /lib/libcrypt-2.13.so
f68af000 f68b2000 r-xp /lib/libcap.so.2.21
f68ba000 f68bc000 r-xp /usr/lib/libiri.so
f68c4000 f690d000 r-xp /usr/lib/libmdm.so.1.2.69
f6915000 f691b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6923000 f6946000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6950000 f6952000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f695a000 f6977000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6980000 f6984000 r-xp /usr/lib/libsmack.so.1.0.0
f698d000 f69a6000 r-xp /usr/lib/libnetwork.so.0.0.0
f69af000 f69b7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69bf000 f69c5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69ce000 f69d0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69d9000 f69e9000 r-xp /lib/libresolv-2.13.so
f69ed000 f6a05000 r-xp /usr/lib/liblzma.so.5.0.3
f6a0e000 f6a10000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a18000 f6a32000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a3a000 f6a69000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a72000 f6a81000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a8b000 f6a95000 r-xp /usr/lib/libsensord-shared.so
f6a9e000 f6b71000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b7c000 f6b92000 r-xp /lib/libz.so.1.2.5
f6b9a000 f6b9f000 r-xp /usr/lib/libffi.so.5.0.10
f6ba7000 f6ba8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bb0000 f6bc0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6bc8000 f6be1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6be9000 f6beb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bf3000 f6c68000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c72000 f6c78000 r-xp /lib/librt-2.13.so
f6c81000 f6c9f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ca9000 f6caa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cb2000 f6cd5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cdd000 f6ce2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cea000 f6d14000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d1d000 f6d34000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d3c000 f6da5000 r-xp /lib/libm-2.13.so
f6dae000 f6e42000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e55000 f6e5a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e62000 f6e69000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e71000 f6e9b000 r-xp /usr/lib/libsensor.so.1.9.6
f6ea4000 f6f70000 r-xp /usr/lib/libxml2.so.2.7.8
f6f7d000 f6f7f000 r-xp /usr/lib/libiniparser.so.0
f6f88000 f6f8e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f97000 f7067000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7068000 f709c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70a5000 f70e1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70e9000 f70ec000 r-xp /usr/lib/libbundle.so.0.1.22
f70f4000 f70fa000 r-xp /usr/lib/libappsvc.so.0.1.0
f7102000 f7143000 r-xp /usr/lib/libeina.so.1.7.99
f714c000 f7163000 r-xp /usr/lib/libecore.so.1.7.99
f717a000 f7183000 r-xp /usr/lib/libvconf.so.0.2.45
f718b000 f719f000 r-xp /lib/libpthread-2.13.so
f71aa000 f71b7000 r-xp /usr/lib/libaul.so.0.1.0
f71c1000 f71c3000 r-xp /lib/libdl-2.13.so
f71cc000 f71d7000 r-xp /lib/libunwind.so.8.0.1
f7204000 f720c000 r-xp /lib/libgcc_s-4.6.so.1
f720d000 f7331000 r-xp /lib/libc-2.13.so
f733f000 f7341000 r-xp /usr/lib/libdlog.so.0.0.0
f7349000 f7355000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f735e000 f7363000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f736b000 f737a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7382000 f7386000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f738f000 f7392000 r-xp /usr/lib/libappcore-agent.so.1.1
f739a000 f739c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73a4000 f73a8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73b0000 f73cd000 r-xp /lib/ld-2.13.so
f73d6000 f73d9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73d9000 f73dd000 r-xp /usr/lib/libsys-assert.so
f74d1000 f7542000 rw-p [heap]
ff9a7000 ff9c8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20048)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73d7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf736e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70753f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7073c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf707fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7085be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7085dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70ba75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70b51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7073c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf707fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7085be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7085dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70b7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70b8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70bff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a571fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a4a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b1d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6fcafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fcc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf715cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7157b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71585a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7158879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7390183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73907fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73d75c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf722485c) [/lib/libc.so.6] + 0x1785c
29: (0xf73d6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0:01.221+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19935
06-07 17:20:01.231+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19935)
06-07 17:20:01.231+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:20:01.231+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:01.231+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:20:01.231+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:20:01.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:01.231+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:01.241+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20019
06-07 17:20:01.251+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:01.251+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:01.251+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20019)
06-07 17:20:01.251+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:20:01.251+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:01.251+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:20:01.251+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:20:01.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:01.251+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:01.261+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:20:01.261+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:01.271+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:01.271+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(19621), cmd(0)
06-07 17:20:01.271+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:01.271+0200 I/utils   (19621): specific action
06-07 17:20:01.281+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:20:01.281+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:20:01.281+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:01.281+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:20:01.281+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:20:01.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:01.281+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:01.291+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20076
06-07 17:20:01.291+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:01.291+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(20076), cmd(0)
06-07 17:20:01.301+0200 W/CAPI_APPFW_APP_CONTROL(20076): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:01.301+0200 I/utils   (20076): specific action
06-07 17:20:01.301+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20076)
06-07 17:20:01.301+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:20:01.301+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:01.301+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:20:01.301+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:20:01.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:01.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:01.311+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19983
06-07 17:20:01.311+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19983)
06-07 17:20:01.311+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:20:01.321+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:01.321+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:20:01.321+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:20:01.321+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:01.321+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:01.331+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19995
06-07 17:20:01.331+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19995)
06-07 17:20:01.331+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:20:01.331+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:01.331+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:20:01.331+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:20:01.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:01.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:01.341+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:20:01.351+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:01.351+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(19663), cmd(0)
06-07 17:20:01.361+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:01.361+0200 I/utils   (19663): specific action
06-07 17:20:01.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:20:01.361+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:20:01.361+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:01.361+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:20:01.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:20:01.361+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:01:275,911.000000
06-07 17:20:01.361+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:01.361+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:01.371+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:20:01.381+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:20:01.381+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:20:01.381+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:01.381+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:20:01.381+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:20:01.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:01.391+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:01.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:20:01.401+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:01.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(19682), cmd(0)
06-07 17:20:01.401+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:01.401+0200 I/utils   (19682): specific action
06-07 17:20:01.411+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:20:01.411+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:20:01.411+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:01.411+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(19670), cmd(0)
06-07 17:20:01.411+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:01.411+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:01.411+0200 I/utils   (19670): specific action
06-07 17:20:01.411+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.411+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.421+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:01:428,0.309438,-0.090679,9.801348
06-07 17:20:01.431+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:204,0.024585,-0.059248,0.076143
06-07 17:20:01.431+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:01.431+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:426,0.070000,-0.070000,0.070000
06-07 17:20:01.431+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:215,0.318245,-0.081356,9.875179
06-07 17:20:01.441+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:01.451+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:01.451+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:01.451+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.451+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:460,0.320638,-0.093320,9.870394
06-07 17:20:01.461+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:01.471+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:01:471,924.000000
06-07 17:20:01.481+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.481+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:450,0.035839,-0.040132,0.083366
06-07 17:20:01.481+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:01:491,0.306710,-0.088341,9.801455
06-07 17:20:01.491+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:484,0.140000,0.070000,0.070000
06-07 17:20:01.501+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:01.501+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:508,-0.013367,-0.031313,0.042746
06-07 17:20:01.501+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:01.511+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.511+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.511+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:518,0.320638,-0.078963,9.872787
06-07 17:20:01.511+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:521,0.140000,-0.070000,0.070000
06-07 17:20:01.521+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:01:531,0.305029,-0.087112,9.801517
06-07 17:20:01.531+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:01.531+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:541,0.061908,-0.003686,0.090579
06-07 17:20:01.541+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:01.541+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.541+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.551+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:01:559,0.305128,-0.088714,9.801500
06-07 17:20:01.571+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:554,0.306281,-0.136391,9.853643
06-07 17:20:01.571+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:01.571+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:579,0.007029,0.008273,0.057151
06-07 17:20:01.581+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:555,0.070000,-0.070000,0.070000
06-07 17:20:01.581+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.581+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.581+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:01.581+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:590,0.306281,-0.076570,9.836893
06-07 17:20:01.601+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:01:600,0.305072,-0.088435,9.801505
06-07 17:20:01.601+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:01.611+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:599,-0.070000,0.070000,0.070000
06-07 17:20:01.611+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:01.631+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.631+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.631+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:614,0.006399,-0.013503,0.030848
06-07 17:20:01.701+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:01.701+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:01.711+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:01.731+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:01:714,954.000000
06-07 17:20:01.781+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:626,0.351745,-0.095713,9.836893
06-07 17:20:01.791+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:01.801+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:01.801+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:01:640,0.304829,-0.090999,9.801489
06-07 17:20:01.801+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:637,-0.070000,0.140000,0.070000
06-07 17:20:01.801+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.811+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.821+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:814,0.327817,-0.098106,9.841680
06-07 17:20:01.831+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:802,-0.008637,-0.029451,0.050020
06-07 17:20:01.831+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:01:835,0.304514,-0.090625,9.801502
06-07 17:20:01.831+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:01.851+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:01.851+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:01.851+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:826,-0.070000,0.070000,0.070000
06-07 17:20:01.851+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:01.861+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:01.881+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:01:868,951.000000
06-07 17:20:01.881+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.891+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:852,0.020894,0.019506,0.030861
06-07 17:20:01.891+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.901+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:01.911+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:917,-0.006181,0.011273,0.035660
06-07 17:20:01.921+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:889,0.354138,-0.129212,9.848858
06-07 17:20:01.921+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:01.921+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:898,-0.070000,0.070000,0.070000
06-07 17:20:01.921+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.921+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:01:897,0.304291,-0.089455,9.801519
06-07 17:20:01.931+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.931+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:937,0.315853,-0.081356,9.858429
06-07 17:20:01.951+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:955,0.070000,0.070000,0.070000
06-07 17:20:01.951+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:01.971+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:01:959,0.303496,-0.090986,9.801530
06-07 17:20:01.971+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:01.981+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:01.981+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:01.981+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:01:968,0.013414,-0.013340,0.038032
06-07 17:20:02.011+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.011+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:6,0.305310,-0.090815,9.801476
06-07 17:20:02.021+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:01:995,0.140000,0.070000,0.070000
06-07 17:20:02.031+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:01:996,0.332602,-0.114855,9.834501
06-07 17:20:02.031+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.031+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.051+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:02.051+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:02.051+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.061+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:23,0.005740,-0.000891,0.057196
06-07 17:20:02.061+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:02.061+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:02:69,950.000000
06-07 17:20:02.071+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.071+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:59,0.306023,-0.091360,9.801448
06-07 17:20:02.091+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:46,0.291924,-0.100499,9.836893
06-07 17:20:02.111+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:50,0.140000,0.070000,0.140000
06-07 17:20:02.111+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.111+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.111+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:20:02.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:20:02.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:20:02.131+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:90,-0.054660,0.023231,0.064395
06-07 17:20:02.131+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:125,0.070000,0.070000,0.070000
06-07 17:20:02.141+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.151+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:133,0.296710,-0.095713,9.858429
06-07 17:20:02.161+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:125,0.305873,-0.089233,9.801473
06-07 17:20:02.171+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.171+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.171+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.171+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:155,0.012149,-0.016033,0.057137
06-07 17:20:02.191+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.211+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:205,-0.036325,0.001577,0.085878
06-07 17:20:02.251+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:02.251+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:02.251+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20019) cmd(0)
06-07 17:20:02.251+0200 W/LOCATION(20076): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:20:02.261+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:02.261+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:02:268,947.000000
06-07 17:20:02.271+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:190,0.305857,-0.089234,9.801473
06-07 17:20:02.271+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:181,0.070000,0.070000,0.070000
06-07 17:20:02.281+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.281+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:185,0.284746,-0.074178,9.868000
06-07 17:20:02.281+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.291+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:296,0.070000,0.070000,0.070000
06-07 17:20:02.291+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.311+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.321+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:302,0.305783,-0.088548,9.801481
06-07 17:20:02.321+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.331+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:321,-0.024196,-0.015591,0.061866
06-07 17:20:02.341+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.341+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:316,0.323031,-0.076570,9.839286
06-07 17:20:02.341+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.361+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:351,0.306328,-0.088258,9.801467
06-07 17:20:02.371+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.371+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19983) cmd(0)
06-07 17:20:02.371+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:345,0.070000,0.070000,0.070000
06-07 17:20:02.391+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.391+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:366,0.313460,-0.062213,9.796216
06-07 17:20:02.401+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.411+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19995) cmd(0)
06-07 17:20:02.411+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.421+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:385,-0.000962,-0.062884,0.068995
06-07 17:20:02.421+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:415,0.307726,-0.088848,9.801418
06-07 17:20:02.431+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.431+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:405,0.070000,0.070000,0.070000
06-07 17:20:02.451+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:02.451+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:02.451+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:440,0.303888,-0.112463,9.820145
06-07 17:20:02.451+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.451+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.461+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:02.461+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:02:471,950.000000
06-07 17:20:02.471+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:444,0.041644,-0.023919,0.035540
06-07 17:20:02.471+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:475,0.305565,-0.087719,9.801496
06-07 17:20:02.481+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.491+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.501+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:465,0.070000,0.070000,0.070000
06-07 17:20:02.511+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.511+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.511+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:505,-0.048735,-0.003344,0.055110
06-07 17:20:02.521+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:502,0.313460,-0.112463,9.858429
06-07 17:20:02.531+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.531+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.551+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:558,0.004357,0.049323,0.045094
06-07 17:20:02.561+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:524,0.070000,0.070000,0.070000
06-07 17:20:02.561+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:529,0.305626,-0.086888,9.801501
06-07 17:20:02.581+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:552,0.323031,-0.071785,9.853643
06-07 17:20:02.581+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.591+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:601,0.022987,-0.004112,0.006653
06-07 17:20:02.601+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.601+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.601+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.621+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:614,0.305390,-0.084142,9.801533
06-07 17:20:02.631+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:618,0.313460,-0.105284,9.856036
06-07 17:20:02.631+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.631+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:615,0.070000,-0.070000,0.070000
06-07 17:20:02.641+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.641+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.651+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:02.651+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:02.651+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.661+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:02.661+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:640,-0.003064,-0.001554,0.061831
06-07 17:20:02.691+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:02:695,978.000000
06-07 17:20:02.701+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.711+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:650,0.070000,0.070000,0.070000
06-07 17:20:02.711+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:703,0.306281,-0.088534,9.846465
06-07 17:20:02.711+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:652,0.307030,-0.083744,9.801485
06-07 17:20:02.711+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.711+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.721+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.751+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:719,0.003976,-0.031130,0.052107
06-07 17:20:02.761+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:730,0.306852,-0.084119,9.801487
06-07 17:20:02.771+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:740,0.327817,-0.122034,9.848858
06-07 17:20:02.781+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.781+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:727,0.140000,0.070000,0.070000
06-07 17:20:02.781+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.791+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:795,0.027414,-0.014709,0.033065
06-07 17:20:02.821+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.831+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.851+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:02.851+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:02.861+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:02.871+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:02:873,979.000000
06-07 17:20:02.881+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.881+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:794,0.307606,-0.084059,9.801464
06-07 17:20:02.891+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.921+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:843,0.140000,0.070000,0.070000
06-07 17:20:02.921+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:844,0.311067,-0.074178,9.832108
06-07 17:20:02.921+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:905,0.014399,0.017885,0.062078
06-07 17:20:02.931+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.931+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:912,0.308017,-0.086714,9.801428
06-07 17:20:02.941+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:02.951+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:944,0.140000,-0.070000,0.070000
06-07 17:20:02.951+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:02.951+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:02.981+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:02.991+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:02:952,0.299103,-0.117248,9.846465
06-07 17:20:02.991+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:02:995,0.140000,-0.070000,0.070000
06-07 17:20:02.991+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:03.001+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:02:964,-0.031702,0.006083,0.009464
06-07 17:20:03.001+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:03.001+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:02:974,0.308728,-0.089080,9.801384
06-07 17:20:03.001+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:03:6,0.330210,-0.136391,9.870394
06-07 17:20:03.011+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:03.021+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:03.031+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:03.041+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:03:15,0.003416,-0.018696,0.068826
06-07 17:20:03.051+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:03.051+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:03.051+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:03.061+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:03:31,0.310077,-0.090721,9.801327
06-07 17:20:03.061+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:03.071+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:03:76,976.000000
06-07 17:20:03.061+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:03:36,0.070000,-0.070000,0.070000
06-07 17:20:03.081+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:03.081+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:03.081+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:03:46,0.303888,-0.098106,9.856036
06-07 17:20:03.091+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:03:63,0.041483,0.007606,0.030518
06-07 17:20:03.101+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:03:93,0.308980,-0.092027,9.801350
06-07 17:20:03.111+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:03.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:20:03.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:20:03.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:20:03.131+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:03.131+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:03:102,0.140000,0.140000,0.070000
06-07 17:20:03.141+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:03.151+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:03.161+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:03:141,0.014328,-0.045000,0.033115
06-07 17:20:03.171+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:03:122,0.311067,-0.098106,9.805787
06-07 17:20:03.171+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:03.171+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:20:03.171+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:20:03.171+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:03.171+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:03.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19935
06-07 17:20:03.191+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19935)
06-07 17:20:03.191+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:20:03.191+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:03.191+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:20:03.191+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:20:03.191+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:03.191+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:03.211+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20019
06-07 17:20:03.211+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20019)
06-07 17:20:03.211+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:20:03.211+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:03.211+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:20:03.211+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:20:03.211+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:03.211+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:03.231+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:20:03.231+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:03.231+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(19621), cmd(0)
06-07 17:20:03.241+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:03.241+0200 I/utils   (19621): specific action
06-07 17:20:03.241+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:20:03.241+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:20:03.241+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:03.241+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:20:03.241+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:20:03.251+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:03.251+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:03.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:03.251+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:03.261+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20076
06-07 17:20:03.261+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:03.271+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:03:275,972.000000
06-07 17:20:03.271+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20076)
06-07 17:20:03.271+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:20:03.271+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:03.281+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:20:03.281+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:20:03.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:03.281+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:03.291+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19983
06-07 17:20:03.301+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19983)
06-07 17:20:03.301+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:03:307,0.320638,-0.098106,9.877571
06-07 17:20:03.301+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:20:03.301+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:03.301+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:20:03.301+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:03.301+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:20:03.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:03.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:03.321+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19995
06-07 17:20:03.321+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19995)
06-07 17:20:03.321+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:20:03.321+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:03.321+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:20:03.321+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:20:03.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:03.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:03.341+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:20:03.351+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:03.351+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(34) , send fd(15), pid(19663), cmd(0)
06-07 17:20:03.351+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:03.351+0200 I/utils   (19663): specific action
06-07 17:20:03.351+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:20:03.361+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:20:03.361+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:03.361+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:20:03.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:20:03.361+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:03.361+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:03.371+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:20:03.381+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:20:03.381+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:03.381+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(34) , send fd(15), pid(19670), cmd(0)
06-07 17:20:03.381+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:20:03.381+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:03.391+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:20:03.391+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:20:03.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:03.391+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:03.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:20:03.411+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:03.411+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(34) , send fd(15), pid(19682), cmd(0)
06-07 17:20:03.411+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:03.411+0200 I/utils   (19682): specific action
06-07 17:20:03.411+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:03.411+0200 I/utils   (19670): specific action
06-07 17:20:03.411+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:20:03.411+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:20:03.411+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:03.451+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:03.451+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:03.461+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:03.471+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:03:471,967.000000
06-07 17:20:03.531+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:03.531+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:03:536,0.017992,0.000902,0.054806
06-07 17:20:03.571+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:03:158,-0.070000,0.070000,0.070000
06-07 17:20:03.571+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:03.571+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:03:156,0.311217,-0.092022,9.801278
06-07 17:20:03.571+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:03.591+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:03.601+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11200486c6f63152838478
