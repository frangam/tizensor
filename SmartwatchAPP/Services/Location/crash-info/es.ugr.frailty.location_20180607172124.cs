S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20325
Date: 2018-06-07 17:21:24+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74ce52d, r5   = 0xf7a1cf98
r6   = 0xffc31aa0, r7   = 0xffc31950
r8   = 0xf7a19c18, r9   = 0x00000000
r10  = 0xffc31a2c, fp   = 0xffc31aa0
ip   = 0x00000001, sp   = 0xffc31928
lr   = 0xf74ce539, pc   = 0xf7537228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    311240 KB
Buffers:      8268 KB
Cached:      54820 KB
VmPeak:      52416 KB
VmSize:      52412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11652 KB
VmRSS:       11652 KB
VmData:      10140 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20325 TID = 20325
20325 20329 

Maps Information
f4399000 f4b98000 rw-p [stack:20329]
f4b9f000 f4ba1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ba9000 f4bad000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bb6000 f4bb8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bc0000 f4bc3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bd2000 f4bd7000 r-xp /usr/lib/libsystem.so.0.0.0
f4be2000 f4be5000 r-xp /lib/libattr.so.1.1.0
f4bed000 f4bfd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c05000 f4c0e000 r-xp /usr/lib/libedbus.so.1.7.99
f4c16000 f4c17000 r-xp /usr/lib/libresponse.so.0.2.96
f4c20000 f4c25000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64c7000 f65cd000 r-xp /usr/lib/libicuuc.so.57.1
f65e3000 f676b000 r-xp /usr/lib/libicui18n.so.57.1
f677b000 f6788000 r-xp /usr/lib/libail.so.0.1.0
f6791000 f6798000 r-xp /usr/lib/libminizip.so.1.0.0
f67a1000 f694a000 r-xp /usr/lib/libcrypto.so.1.0.0
f696a000 f69b1000 r-xp /usr/lib/libssl.so.1.0.0
f69bd000 f69bf000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69c7000 f69ce000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69d7000 f69de000 r-xp /lib/libcrypt-2.13.so
f6a0f000 f6a12000 r-xp /lib/libcap.so.2.21
f6a1a000 f6a1c000 r-xp /usr/lib/libiri.so
f6a24000 f6a6d000 r-xp /usr/lib/libmdm.so.1.2.69
f6a75000 f6a7b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a83000 f6aa6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ab0000 f6ab2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6aba000 f6ad7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ae0000 f6ae4000 r-xp /usr/lib/libsmack.so.1.0.0
f6aed000 f6b06000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b0f000 f6b17000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b1f000 f6b25000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b2e000 f6b30000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b39000 f6b49000 r-xp /lib/libresolv-2.13.so
f6b4d000 f6b65000 r-xp /usr/lib/liblzma.so.5.0.3
f6b6e000 f6b70000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b78000 f6b92000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b9a000 f6bc9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bd2000 f6be1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6beb000 f6bf5000 r-xp /usr/lib/libsensord-shared.so
f6bfe000 f6cd1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cdc000 f6cf2000 r-xp /lib/libz.so.1.2.5
f6cfa000 f6cff000 r-xp /usr/lib/libffi.so.5.0.10
f6d07000 f6d08000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d10000 f6d20000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d28000 f6d41000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d49000 f6d4b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d53000 f6dc8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dd2000 f6dd8000 r-xp /lib/librt-2.13.so
f6de1000 f6dff000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e09000 f6e0a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e12000 f6e35000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e3d000 f6e42000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e4a000 f6e74000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e7d000 f6e94000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e9c000 f6f05000 r-xp /lib/libm-2.13.so
f6f0e000 f6fa2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fb5000 f6fba000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fc2000 f6fc9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fd1000 f6ffb000 r-xp /usr/lib/libsensor.so.1.9.6
f7004000 f70d0000 r-xp /usr/lib/libxml2.so.2.7.8
f70dd000 f70df000 r-xp /usr/lib/libiniparser.so.0
f70e8000 f70ee000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70f7000 f71c7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71c8000 f71fc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7205000 f7241000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7249000 f724c000 r-xp /usr/lib/libbundle.so.0.1.22
f7254000 f725a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7262000 f72a3000 r-xp /usr/lib/libeina.so.1.7.99
f72ac000 f72c3000 r-xp /usr/lib/libecore.so.1.7.99
f72da000 f72e3000 r-xp /usr/lib/libvconf.so.0.2.45
f72eb000 f72ff000 r-xp /lib/libpthread-2.13.so
f730a000 f7317000 r-xp /usr/lib/libaul.so.0.1.0
f7321000 f7323000 r-xp /lib/libdl-2.13.so
f732c000 f7337000 r-xp /lib/libunwind.so.8.0.1
f7364000 f736c000 r-xp /lib/libgcc_s-4.6.so.1
f736d000 f7491000 r-xp /lib/libc-2.13.so
f749f000 f74a1000 r-xp /usr/lib/libdlog.so.0.0.0
f74a9000 f74b5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74be000 f74c3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74cb000 f74da000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74e2000 f74e6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74ef000 f74f2000 r-xp /usr/lib/libappcore-agent.so.1.1
f74fa000 f74fc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7504000 f7508000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7510000 f752d000 r-xp /lib/ld-2.13.so
f7536000 f7539000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7539000 f753d000 r-xp /usr/lib/libsys-assert.so
f79e9000 f7a5b000 rw-p [heap]
ffc13000 ffc34000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20325)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7537228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74ce539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71d53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71d3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71dfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71e5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71e5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf721a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72151f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71d3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71dfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71e5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71e5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7217e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7218017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf721ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bb71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4baa171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c7d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf712afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf712c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72bcca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72b7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72b85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72b8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74f0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74f07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75375c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf738485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7536f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
celerometer)
06-07 17:22:35.371+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:35.371+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:35.381+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20297
06-07 17:22:35.381+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20297)
06-07 17:22:35.391+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:22:35.391+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:35.391+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:22:35.391+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:22:35.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:35.391+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:35.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20330
06-07 17:22:35.401+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20330)
06-07 17:22:35.401+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:22:35.401+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:35.401+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:22:35.401+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:22:35.411+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:35.411+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:35.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:22:35.421+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:35.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(19621), cmd(0)
06-07 17:22:35.431+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:35.431+0200 I/utils   (19621): specific action
06-07 17:22:35.431+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:22:35.431+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:22:35.431+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:35.431+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:22:35.431+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:22:35.431+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:35.431+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:35.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20579
06-07 17:22:35.451+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20579)
06-07 17:22:35.451+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:22:35.451+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:35.451+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:22:35.451+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:22:35.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:35.451+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:35.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20358
06-07 17:22:35.461+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20358)
06-07 17:22:35.461+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:22:35.461+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:35.471+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:22:35.471+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:22:35.471+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:35.471+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:35.481+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20375
06-07 17:22:35.481+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20375)
06-07 17:22:35.481+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:22:35.481+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:35.481+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:22:35.481+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:22:35.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:35.491+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:35.501+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:22:35.501+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:35.501+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(19663), cmd(0)
06-07 17:22:35.501+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:35.511+0200 I/utils   (19663): specific action
06-07 17:22:35.511+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:22:35.511+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:22:35.511+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:35.511+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:22:35.511+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:22:35.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:35.521+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:35.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:22:35.531+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:22:35.531+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:22:35.531+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:35.531+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:22:35.531+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:22:35.541+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:35.541+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:35.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:22:35.551+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:35.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19682), cmd(0)
06-07 17:22:35.561+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:35.561+0200 I/utils   (19682): specific action
06-07 17:22:35.561+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:22:35.561+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:22:35.561+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:35.561+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:35.561+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:35.561+0200 W/libgps_d( 3131): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
06-07 17:22:35.561+0200 W/libgps  ( 3131): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
06-07 17:22:35.561+0200 W/libgps_d( 3131): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
06-07 17:22:35.561+0200 W/libgps_d( 3131): GpsiHookStateIdle             : EXIT
06-07 17:22:35.561+0200 W/libgps_d( 3131): GpsiHookStateGps              : ENTRY
06-07 17:22:35.561+0200 W/libgps  ( 3131): [proxy__gps_start][line = 1022]: called.
06-07 17:22:35.561+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:22:35.561+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:22:35.561+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 17:22:35.561+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:26
06-07 17:22:35.561+0200 D/gpsd_d  ( 3111): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
06-07 17:22:35.561+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:27
06-07 17:22:35.561+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:8
06-07 17:22:35.561+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:1
06-07 17:22:35.571+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
06-07 17:22:35.571+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(11), data(0xf7cebb38), size(4)
06-07 17:22:35.571+0200 W/libgps_d( 3131): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
06-07 17:22:35.571+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
06-07 17:22:35.571+0200 W/libgps_d( 3131): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
06-07 17:22:35.601+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:35:375,780.000000
06-07 17:22:35.601+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:35.601+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(19670), cmd(0)
06-07 17:22:35.601+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:35.611+0200 I/utils   (19670): specific action
06-07 17:22:35.611+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:35.611+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:35:616,783.000000
06-07 17:22:35.621+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:35.621+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:35.651+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:35:369,0.070000,0.140000,0.070000
06-07 17:22:35.651+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:35.651+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:35:633,0.311185,-0.094811,9.801253
06-07 17:22:35.651+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:35:635,-0.008972,0.041789,0.042966
06-07 17:22:35.661+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:35.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:35.671+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:35.671+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:35:676,0.140000,0.070000,0.070000
06-07 17:22:35.681+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:35:677,0.005662,0.039880,0.186506
06-07 17:22:35.701+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:35:666,0.320638,-0.102891,9.817751
06-07 17:22:35.701+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:35.701+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:35.711+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:35:684,0.309043,-0.095586,9.801313
06-07 17:22:35.711+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:35:717,0.070000,0.070000,0.140000
06-07 17:22:35.721+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:35.721+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:35.731+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:35:739,-0.006303,-0.031377,0.052489
06-07 17:22:35.751+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:35:712,0.366102,-0.119641,9.832108
06-07 17:22:35.751+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:35:734,0.307893,-0.094722,9.801358
06-07 17:22:35.751+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:35.751+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:35.751+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:35.751+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:35.761+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:35.761+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:35.771+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:35:772,782.000000
06-07 17:22:35.771+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:35.781+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:35:788,0.032915,0.005769,-0.043242
06-07 17:22:35.791+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:35:785,0.354138,-0.066999,9.827322
06-07 17:22:35.801+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:35:763,0.070000,0.070000,0.070000
06-07 17:22:35.801+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:35.801+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:35:795,0.307086,-0.095968,9.801371
06-07 17:22:35.811+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:35.811+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:35.831+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:35.831+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:35:826,0.332602,-0.043071,9.803394
06-07 17:22:35.841+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:35:821,0.070000,0.070000,0.070000
06-07 17:22:35.851+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:35:830,0.017372,0.007756,-0.033636
06-07 17:22:35.851+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:35:840,0.307283,-0.095755,9.801367
06-07 17:22:35.851+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
06-07 17:22:35.851+0200 W/libgps  ( 3131): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(8780625), time2(8763905)
06-07 17:22:35.851+0200 W/libgps  ( 3131): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
06-07 17:22:35.851+0200 W/libgps  ( 3131): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
06-07 17:22:35.851+0200 I/libgps_d( 3131): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
06-07 17:22:35.851+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:25
06-07 17:22:35.861+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:35.861+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:35.871+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:35.871+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:35.891+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:35:877,0.070000,0.070000,0.070000
06-07 17:22:35.891+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:35:889,0.028874,-0.014298,0.059694
06-07 17:22:35.901+0200 W/LOCATION(20579): location-wps.c: __update_remote_connection_status(215) > update FALSE
06-07 17:22:35.901+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:35:892,0.309124,-0.096903,9.801298
06-07 17:22:35.901+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:35.901+0200 W/LOCATION(20579): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
06-07 17:22:35.911+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:35:885,0.306281,-0.043071,9.860823
06-07 17:22:35.911+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:35.921+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:35.921+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:35.931+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:35:931,0.003574,0.024758,0.114780
06-07 17:22:35.941+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:35:920,0.070000,0.070000,0.070000
06-07 17:22:35.951+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:35:929,0.299103,-0.136391,9.877571
06-07 17:22:35.951+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:35.951+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:35.951+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:35.951+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:35:932,0.309710,-0.096742,9.801281
06-07 17:22:35.961+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:35.961+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:35.971+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:35:977,786.000000
06-07 17:22:35.971+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:35.991+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:35.991+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:35:998,0.258425,-0.105284,9.789038
06-07 17:22:36.001+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:35:968,0.140000,0.070000,0.070000
06-07 17:22:36.011+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.011+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:35:990,-0.030040,0.035625,-0.014439
06-07 17:22:36.021+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:5,0.310688,-0.097435,9.801243
06-07 17:22:36.021+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.031+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.031+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.051+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:30,0.070000,0.070000,0.070000
06-07 17:22:36.051+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:40,0.028537,-0.021018,-0.009706
06-07 17:22:36.071+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:46,0.310036,-0.096595,9.801272
06-07 17:22:36.091+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.091+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:55,0.284746,-0.100499,9.791430
06-07 17:22:36.091+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.111+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.111+0200 W/LOCATION(20579): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-07 17:22:36.111+0200 I/LOCATION(20579): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-07 17:22:36.111+0200 I/LOCATION(20579): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-07 17:22:36.111+0200 I/location(20579): es.ugr.frailty.location:iniciado servicio de localización
06-07 17:22:36.121+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.121+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:129,0.308991,-0.095678,9.801314
06-07 17:22:36.151+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:22:36.151+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:22:36.151+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:22:36.151+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:36.151+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:36.161+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:137,0.294317,-0.086142,9.820145
06-07 17:22:36.161+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:36.171+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:36:173,792.000000
06-07 17:22:36.191+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:109,0.070000,0.070000,0.140000
06-07 17:22:36.191+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.191+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:125,0.012675,-0.029472,-0.007255
06-07 17:22:36.191+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.201+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:205,0.070000,0.070000,0.070000
06-07 17:22:36.201+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.201+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.211+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20330) cmd(0)
06-07 17:22:36.221+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:215,0.014316,-0.018390,0.038248
06-07 17:22:36.231+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:218,0.307107,-0.095625,9.801373
06-07 17:22:36.231+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.231+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:225,0.342174,-0.083749,9.812965
06-07 17:22:36.251+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.251+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.251+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.271+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:270,0.346959,-0.122034,9.851252
06-07 17:22:36.271+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:266,0.011202,0.008902,0.031104
06-07 17:22:36.281+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:251,0.070000,0.140000,0.070000
06-07 17:22:36.281+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:263,0.307911,-0.095797,9.801347
06-07 17:22:36.281+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20358) cmd(0)
06-07 17:22:36.301+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.301+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20375) cmd(0)
06-07 17:22:36.311+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.311+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.321+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.321+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:318,0.070000,0.140000,0.070000
06-07 17:22:36.331+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:340,0.327817,-0.129212,9.820145
06-07 17:22:36.341+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:324,-0.001628,-0.005709,-0.002371
06-07 17:22:36.351+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.351+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:323,0.308690,-0.093135,9.801348
06-07 17:22:36.351+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:36.351+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:36.351+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.361+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.361+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:36.371+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:36:374,788.000000
06-07 17:22:36.381+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:370,0.070000,0.140000,0.070000
06-07 17:22:36.381+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.391+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:396,-0.039910,0.030585,-0.016723
06-07 17:22:36.411+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:417,0.318245,-0.074178,9.848858
06-07 17:22:36.411+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:370,0.310257,-0.092726,9.801302
06-07 17:22:36.411+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.431+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.431+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.451+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.461+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:439,0.070000,0.070000,0.070000
06-07 17:22:36.461+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:443,0.310898,-0.093681,9.801273
06-07 17:22:36.461+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:448,-0.002372,0.024445,0.011923
06-07 17:22:36.471+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.481+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.481+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:461,0.356531,-0.090927,9.853643
06-07 17:22:36.481+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.501+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.511+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:486,0.140000,0.070000,0.070000
06-07 17:22:36.511+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:495,0.312976,-0.093824,9.801206
06-07 17:22:36.521+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:498,0.011978,0.001864,0.016698
06-07 17:22:36.531+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.531+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.531+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.541+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:513,0.315853,-0.122034,9.836893
06-07 17:22:36.551+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:36.551+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:36.551+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.561+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:36.571+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:36:572,788.000000
06-07 17:22:36.571+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:552,0.312803,-0.094303,9.801207
06-07 17:22:36.581+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:550,0.140000,0.070000,0.070000
06-07 17:22:36.581+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:557,0.021411,0.008775,0.047807
06-07 17:22:36.591+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.591+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:569,0.265603,-0.088534,10.001998
06-07 17:22:36.601+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.601+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.621+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.631+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:610,-0.070000,0.070000,0.070000
06-07 17:22:36.631+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:617,0.312512,-0.095938,9.801200
06-07 17:22:36.641+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:645,0.327817,-0.117248,9.956534
06-07 17:22:36.641+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.651+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:619,0.003656,-0.017842,0.033480
06-07 17:22:36.651+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.671+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.681+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:667,0.070000,0.070000,0.070000
06-07 17:22:36.691+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:669,0.312761,-0.093891,9.801211
06-07 17:22:36.691+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:695,0.332602,-0.088534,9.724431
06-07 17:22:36.701+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.711+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:670,0.001543,-0.007622,0.107654
06-07 17:22:36.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.741+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.751+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:725,0.311963,-0.090534,9.801269
06-07 17:22:36.751+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:36.751+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:36.751+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:722,-0.070000,0.070000,0.070000
06-07 17:22:36.761+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.761+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:36.771+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:36:774,790.000000
06-07 17:22:36.771+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:728,-0.007375,0.016415,0.019100
06-07 17:22:36.771+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.781+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.781+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:787,-0.070000,0.070000,0.070000
06-07 17:22:36.801+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:805,-0.011261,0.003459,-0.033582
06-07 17:22:36.801+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:758,0.311067,-0.124427,9.753145
06-07 17:22:36.801+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.811+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:797,0.309613,-0.089580,9.801352
06-07 17:22:36.811+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.821+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.821+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.831+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:814,0.327817,-0.093320,9.803394
06-07 17:22:36.841+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.851+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:830,-0.070000,0.070000,0.070000
06-07 17:22:36.851+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:843,0.017867,0.010622,-0.004881
06-07 17:22:36.861+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:835,0.307941,-0.089594,9.801404
06-07 17:22:36.881+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.881+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.891+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.891+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:864,0.356531,-0.131605,9.848858
06-07 17:22:36.911+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:891,0.140000,0.070000,0.140000
06-07 17:22:36.941+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:891,0.307058,-0.090614,9.801423
06-07 17:22:36.941+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:36.951+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:36.951+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:36.951+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:898,-0.028522,-0.011275,0.054966
06-07 17:22:36.961+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:36.961+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:36.961+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:36.961+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:36.971+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:36:975,787.000000
06-07 17:22:36.991+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:36:985,0.006916,0.013010,0.019015
06-07 17:22:37.011+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:36:956,0.387637,-0.157926,9.798609
06-07 17:22:37.021+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:37.021+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:36:970,0.070000,0.070000,0.070000
06-07 17:22:37.021+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:36:992,0.309165,-0.089894,9.801363
06-07 17:22:37.031+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:37.041+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:37.051+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:37.061+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:37:35,0.332602,-0.129212,9.796216
06-07 17:22:37.071+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:22:37.081+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:22:37:49,0.210000,0.070000,0.070000
06-07 17:22:37.091+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:22:37:63,0.310607,-0.092288,9.801295
06-07 17:22:37.091+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:37:50,-0.002404,0.005010,0.026176
06-07 17:22:37.091+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:22:37.091+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:22:37.101+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:22:37.111+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:22:37:115,-0.020833,-0.016970,-0.016920
06-07 17:22:37.131+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:22:37:93,0.339781,-0.078963,9.822537
06-07 17:22:37.151+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:22:37.151+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:22:37.151+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:22:37.151+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:37.151+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:37.151+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:22:37.161+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:37.171+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:22:37.171+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:37.171+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:37.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20297
06-07 17:22:37.191+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20297)
06-07 17:22:37.191+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:22:37.191+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:37.191+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:22:37.191+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:22:37.191+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:37.191+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:37.201+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20330
06-07 17:22:37.201+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20330)
06-07 17:22:37.211+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:22:37.211+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:37.211+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:22:37.211+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:22:37.211+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:37.211+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:37.221+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:22:37.231+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:37.231+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(19621), cmd(0)
06-07 17:22:37.231+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:37.231+0200 I/utils   (19621): specific action
06-07 17:22:37.231+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:22:37.231+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:22:37.231+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:37.231+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:22:37.231+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:22:37.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:37.241+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:37.251+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20579
06-07 17:22:37.251+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20579)
06-07 17:22:37.251+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:22:37.251+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:37.251+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:22:37.251+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:22:37.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:37.261+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:37.271+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20358
06-07 17:22:37.271+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20358)
06-07 17:22:37.271+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:22:37.281+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:37.281+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:22:37.281+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:22:37.281+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:37:175,783.000000
06-07 17:22:37.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:37.281+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:37.291+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20375
06-07 17:22:37.301+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20375)
06-07 17:22:37.301+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:22:37.301+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:37.301+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:22:37.301+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:22:37.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:37.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:37.311+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:22:37.321+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:37.321+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(19663), cmd(0)
06-07 17:22:37.321+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:22:37.321+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:37.321+0200 I/utils   (19663): specific action
06-07 17:22:37.321+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:22:37.321+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:37.321+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:22:37.321+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:22:37.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:37.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:37.341+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:22:37.341+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:22:37.341+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:22:37.341+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:37.341+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:22:37.341+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:22:37.351+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:22:37.351+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:22:37.361+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:22:37.361+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:37.361+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(37) , send fd(15), pid(19682), cmd(0)
06-07 17:22:37.371+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:37.371+0200 I/utils   (19682): specific action
06-07 17:22:37.371+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:22:37.371+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:22:37.371+0200 I/servicemanager(19582): App control destroyed.
06-07 17:22:37.371+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:22:37.371+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(19670), cmd(0)
06-07 17:22:37.381+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:22:37.381+0200 I/utils   (19670): specific action
06-07 17:22:37.381+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:22:37.381+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:22:37.381+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:22:37.381+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:22:37:388,788.000000
06-07 17:22:37.391+0200 I/LOCATION(20579): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 17:22:37.431+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11203256c6f63152838488
