S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8259
Date: 2018-06-12 13:57:26+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf760252d, r5   = 0xf7c68150
r6   = 0xffa94420, r7   = 0xffa942d0
r8   = 0xf7c7ac18, r9   = 0x00000000
r10  = 0xffa943ac, fp   = 0xffa94420
ip   = 0x00000001, sp   = 0xffa942a8
lr   = 0xf7602539, pc   = 0xf766b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    180644 KB
Buffers:     29316 KB
Cached:     137348 KB
VmPeak:      52404 KB
VmSize:      52400 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11660 KB
VmRSS:       11660 KB
VmData:      10128 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8259 TID = 8259
8259 8349 

Maps Information
f44cd000 f4ccc000 rw-p [stack:8349]
f4cd3000 f4cd5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cdd000 f4ce1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cea000 f4cec000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cf4000 f4cf7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d06000 f4d0b000 r-xp /usr/lib/libsystem.so.0.0.0
f4d16000 f4d19000 r-xp /lib/libattr.so.1.1.0
f4d21000 f4d31000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d39000 f4d42000 r-xp /usr/lib/libedbus.so.1.7.99
f4d4a000 f4d4b000 r-xp /usr/lib/libresponse.so.0.2.96
f4d54000 f4d59000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65fb000 f6701000 r-xp /usr/lib/libicuuc.so.57.1
f6717000 f689f000 r-xp /usr/lib/libicui18n.so.57.1
f68af000 f68bc000 r-xp /usr/lib/libail.so.0.1.0
f68c5000 f68cc000 r-xp /usr/lib/libminizip.so.1.0.0
f68d5000 f6a7e000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a9e000 f6ae5000 r-xp /usr/lib/libssl.so.1.0.0
f6af1000 f6af3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6afb000 f6b02000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b0b000 f6b12000 r-xp /lib/libcrypt-2.13.so
f6b43000 f6b46000 r-xp /lib/libcap.so.2.21
f6b4e000 f6b50000 r-xp /usr/lib/libiri.so
f6b58000 f6ba1000 r-xp /usr/lib/libmdm.so.1.2.69
f6ba9000 f6baf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6bb7000 f6bda000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6be4000 f6be6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bee000 f6c0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c14000 f6c18000 r-xp /usr/lib/libsmack.so.1.0.0
f6c21000 f6c3a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c43000 f6c4b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c53000 f6c59000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c62000 f6c64000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c6d000 f6c7d000 r-xp /lib/libresolv-2.13.so
f6c81000 f6c99000 r-xp /usr/lib/liblzma.so.5.0.3
f6ca2000 f6ca4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cac000 f6cc6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cce000 f6cfd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d06000 f6d15000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d1f000 f6d29000 r-xp /usr/lib/libsensord-shared.so
f6d32000 f6e05000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e10000 f6e26000 r-xp /lib/libz.so.1.2.5
f6e2e000 f6e33000 r-xp /usr/lib/libffi.so.5.0.10
f6e3b000 f6e3c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e44000 f6e54000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e5c000 f6e75000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e7d000 f6e7f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e87000 f6efc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f06000 f6f0c000 r-xp /lib/librt-2.13.so
f6f15000 f6f33000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f3d000 f6f3e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f46000 f6f69000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f71000 f6f76000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f7e000 f6fa8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fb1000 f6fc8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fd0000 f7039000 r-xp /lib/libm-2.13.so
f7042000 f70d6000 r-xp /usr/lib/libstdc++.so.6.0.16
f70e9000 f70ee000 r-xp /usr/lib/libctx-client.so.0.8.3
f70f6000 f70fd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7105000 f712f000 r-xp /usr/lib/libsensor.so.1.9.6
f7138000 f7204000 r-xp /usr/lib/libxml2.so.2.7.8
f7211000 f7213000 r-xp /usr/lib/libiniparser.so.0
f721c000 f7222000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f722b000 f72fb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72fc000 f7330000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7339000 f7375000 r-xp /usr/lib/libSLP-location.so.0.9.24
f737d000 f7380000 r-xp /usr/lib/libbundle.so.0.1.22
f7388000 f738e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7396000 f73d7000 r-xp /usr/lib/libeina.so.1.7.99
f73e0000 f73f7000 r-xp /usr/lib/libecore.so.1.7.99
f740e000 f7417000 r-xp /usr/lib/libvconf.so.0.2.45
f741f000 f7433000 r-xp /lib/libpthread-2.13.so
f743e000 f744b000 r-xp /usr/lib/libaul.so.0.1.0
f7455000 f7457000 r-xp /lib/libdl-2.13.so
f7460000 f746b000 r-xp /lib/libunwind.so.8.0.1
f7498000 f74a0000 r-xp /lib/libgcc_s-4.6.so.1
f74a1000 f75c5000 r-xp /lib/libc-2.13.so
f75d3000 f75d5000 r-xp /usr/lib/libdlog.so.0.0.0
f75dd000 f75e9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75f2000 f75f7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75ff000 f760e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7616000 f761a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7623000 f7626000 r-xp /usr/lib/libappcore-agent.so.1.1
f762e000 f7630000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7638000 f763c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7644000 f7661000 r-xp /lib/ld-2.13.so
f766a000 f766d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f766d000 f7671000 r-xp /usr/lib/libsys-assert.so
f7c4a000 f7cb9000 rw-p [heap]
ffa75000 ffa96000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8259)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf766b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7602539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73093f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7307c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7313e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7319be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7319dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf734e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73491f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7307c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7313e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7319be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7319dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf734be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf734c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7353f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ceb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cde171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6db1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf725efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72607a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73f0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73ebb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73ec5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73ec879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7624183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76247fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf766b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf74b885c) [/lib/libc.so.6] + 0x1785c
29: (0xf766af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
dm_pp.c: tdm_pp_set_info(322) > [3097.442138] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:25.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8242
06-12 13:57:25.651+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.458522] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:25.671+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.474965] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.681+0200 I/heartrate( 8246): es.ugr.frailty.heartrate - capturing data
06-12 13:57:25.681+0200 I/heartrate( 8246): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:57:25.681+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:25.681+0200 I/gyroscope( 8242): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:25.681+0200 I/gyroscope( 8242): es.ugr.frailty.gyroscope - capturing data
06-12 13:57:25.691+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.492167] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.701+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.509020] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:25.711+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8240
06-12 13:57:25.721+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:25.721+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.525733] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.731+0200 W/AUL     ( 8240): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:25.741+0200 I/accelerometer( 8240): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:25.741+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.542558] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.741+0200 I/accelerometer( 8240): es.ugr.frailty.accelerometer - capturing data
06-12 13:57:25.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:25.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8273
06-12 13:57:25.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:25.751+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.559146] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.771+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:25.771+0200 I/gravity ( 8273): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:25.771+0200 I/gravity ( 8273): es.ugr.frailty.gravity - capturing data
06-12 13:57:25.771+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.575825] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:25.781+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8261
06-12 13:57:25.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:25.791+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.592646] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.801+0200 W/AUL     ( 8261): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:25.801+0200 I/linearacceleration( 8261): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:25.801+0200 I/linearacceleration( 8261): es.ugr.frailty.linearacceleration - capturing data
06-12 13:57:25.801+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.609264] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:25.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8232
06-12 13:57:25.821+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.625507] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.821+0200 I/linearacceleration( 8261): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:57:25:808,0.698917,-0.392530,-0.182062
06-12 13:57:25.821+0200 W/AUL     ( 8261): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:25.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8235
06-12 13:57:25.831+0200 I/gravity ( 8273): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:57:25:776,3.040447,-0.632689,9.301923
06-12 13:57:25.831+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:25.841+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.644802] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.851+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8235)
06-12 13:57:25.851+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.851+0200 I/utils   ( 8235): specific action
06-12 13:57:25.851+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.851+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.851+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.851+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.851+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.851+0200 I/recorder( 8235): saving local data for es.ugr.frailty.linearacceleration
06-12 13:57:25.851+0200 I/recorder( 8235): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 13:57:25.861+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.660979] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.861+0200 I/servicemanager( 8232): request sent to service es.ugr.frailty.recorder
06-12 13:57:25.861+0200 I/servicemanager( 8232): requesting to save local data
06-12 13:57:25.861+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.861+0200 I/utils   ( 8232): specific action
06-12 13:57:25.861+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.861+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.861+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.861+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.861+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.861+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.861+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:25.861+0200 I/servicemanager( 8232): requesting to save local data for es.ugr.frailty.light
06-12 13:57:25.861+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:57:25.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:25.871+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8261
06-12 13:57:25.881+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.682928] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:25.891+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.694604] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.901+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:25.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(8232), cmd(0)
06-12 13:57:25.911+0200 I/heartrate( 8246): es.ugr.frailty.heartrate - capturing data
06-12 13:57:25.911+0200 I/heartrate( 8246): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:57:25.911+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.712855] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.911+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:25.911+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(56) , send fd(21), pid(8235), cmd(0)
06-12 13:57:25.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:25.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8232
06-12 13:57:25.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8235
06-12 13:57:25.951+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.755217] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.961+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.765872] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:25.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8273
06-12 13:57:25.981+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.783738] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:25.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:25.991+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.799940] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.011+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.817276] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.031+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.832091] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.041+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.848782] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.051+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8235)
06-12 13:57:26.051+0200 I/servicemanager( 8232): request sent to service es.ugr.frailty.recorder
06-12 13:57:26.051+0200 I/servicemanager( 8232): requesting to save local data
06-12 13:57:26.051+0200 W/AUL     ( 8261): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.051+0200 I/linearacceleration( 8261): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.051+0200 I/linearacceleration( 8261): es.ugr.frailty.linearacceleration - capturing data
06-12 13:57:26.051+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(21), pid(8232), cmd(0)
06-12 13:57:26.061+0200 I/linearacceleration( 8261): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:57:26:58,0.393253,-0.168907,0.046835
06-12 13:57:26.061+0200 W/AUL     ( 8261): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.061+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.869140] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.071+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.071+0200 I/gravity ( 8273): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.071+0200 I/gravity ( 8273): es.ugr.frailty.gravity - capturing data
06-12 13:57:26.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.071+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8261
06-12 13:57:26.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.081+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.884098] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.091+0200 I/heartrate( 8246): es.ugr.frailty.heartrate - capturing data
06-12 13:57:26.091+0200 I/heartrate( 8246): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:57:26.091+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.091+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.091+0200 I/utils   ( 8232): specific action
06-12 13:57:26.091+0200 I/servicemanager( 8232): requesting to save local data for es.ugr.frailty.accelerometer
06-12 13:57:26.091+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:57:26.091+0200 I/utils   ( 8235): specific action
06-12 13:57:26.101+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.902002] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.101+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.101+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.101+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.101+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.101+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.101+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.101+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.101+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.101+0200 I/recorder( 8235): saving local data for es.ugr.frailty.light
06-12 13:57:26.101+0200 I/recorder( 8235): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 13:57:26.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.101+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8232
06-12 13:57:26.111+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.918454] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8235
06-12 13:57:26.121+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.121+0200 I/utils   ( 8235): specific action
06-12 13:57:26.121+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.121+0200 I/recorder( 8235): saving local data for es.ugr.frailty.accelerometer
06-12 13:57:26.121+0200 I/recorder( 8235): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 13:57:26.121+0200 I/accelerometer( 8240): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:57:25:759,3.503092,-0.820738,9.300901
06-12 13:57:26.121+0200 W/AUL     ( 8240): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.121+0200 I/gyroscope( 8242): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:57:25:693,-3.920000,-1.680000,3.780000
06-12 13:57:26.121+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.131+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.933607] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.141+0200 I/light   ( 8316): es.ugr.frailty.light: SM-R760,12/06/2018,13:57:25:644,110.000000
06-12 13:57:26.141+0200 W/AUL     ( 8316): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.141+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(8235), cmd(0)
06-12 13:57:26.151+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.955608] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.151+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8240
06-12 13:57:26.161+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.171+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.971188] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.171+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8235)
06-12 13:57:26.171+0200 I/servicemanager( 8232): request sent to service es.ugr.frailty.recorder
06-12 13:57:26.171+0200 I/servicemanager( 8232): requesting to save local data
06-12 13:57:26.181+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(58) , send fd(21), pid(8235), cmd(0)
06-12 13:57:26.181+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3097.984118] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.181+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.181+0200 I/utils   ( 8232): specific action
06-12 13:57:26.181+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.181+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.181+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.181+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.181+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.181+0200 I/servicemanager( 8232): requesting to save local data for es.ugr.frailty.gravity
06-12 13:57:26.181+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:57:26.181+0200 W/AUL     ( 8261): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.181+0200 I/linearacceleration( 8261): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.191+0200 I/linearacceleration( 8261): es.ugr.frailty.linearacceleration - capturing data
06-12 13:57:26.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8316
06-12 13:57:26.201+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.001348] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.201+0200 W/AUL     ( 8240): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.201+0200 I/accelerometer( 8240): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.201+0200 I/accelerometer( 8240): es.ugr.frailty.accelerometer - capturing data
06-12 13:57:26.211+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 13:57:26.221+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.020292] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(8232), cmd(0)
06-12 13:57:26.221+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 13:57:26.221+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 13:57:26.221+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 13:57:26.231+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.034526] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.231+0200 W/AUL     ( 8316): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.231+0200 I/light   ( 8316): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.231+0200 I/light   ( 8316): es.ugr.frailty.light - capturing data
06-12 13:57:26.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.251+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8232
06-12 13:57:26.251+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.051452] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8235
06-12 13:57:26.261+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.261+0200 I/utils   ( 8235): specific action
06-12 13:57:26.261+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.261+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.261+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.261+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.261+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.261+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.261+0200 I/recorder( 8235): saving local data for es.ugr.frailty.gravity
06-12 13:57:26.261+0200 I/recorder( 8235): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 13:57:26.261+0200 I/gravity ( 8273): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:57:26:75,3.391213,-0.768972,9.169446
06-12 13:57:26.261+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.271+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.077979] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.281+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8235)
06-12 13:57:26.281+0200 I/servicemanager( 8232): request sent to service es.ugr.frailty.recorder
06-12 13:57:26.281+0200 I/servicemanager( 8232): requesting to save local data
06-12 13:57:26.281+0200 I/heartrate( 8246): es.ugr.frailty.heartrate - capturing data
06-12 13:57:26.281+0200 I/heartrate( 8246): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:57:26.291+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.291+0200 I/utils   ( 8232): specific action
06-12 13:57:26.291+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.291+0200 I/servicemanager( 8232): requesting to save local data for es.ugr.frailty.gyroscope
06-12 13:57:26.291+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:57:26.291+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.093114] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8242
06-12 13:57:26.291+0200 I/light   ( 8316): es.ugr.frailty.light: SM-R760,12/06/2018,13:57:26:239,110.000000
06-12 13:57:26.291+0200 W/AUL     ( 8316): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.311+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.111532] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.321+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.126634] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.341+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.341+0200 I/gyroscope( 8242): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.341+0200 I/gyroscope( 8242): es.ugr.frailty.gyroscope - capturing data
06-12 13:57:26.341+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.143281] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.351+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(8235), cmd(0)
06-12 13:57:26.351+0200 I/gyroscope( 8242): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:57:26:345,-5.110000,-6.300000,-2.520000
06-12 13:57:26.351+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.361+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8273
06-12 13:57:26.371+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.170413] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.371+0200 I/linearacceleration( 8261): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:57:26:194,0.430124,0.072660,-0.038435
06-12 13:57:26.371+0200 I/accelerometer( 8240): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:57:26:212,3.345166,-0.830309,9.250652
06-12 13:57:26.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.381+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.183069] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.381+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(8232), cmd(0)
06-12 13:57:26.391+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.195515] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.401+0200 I/gravity ( 8273): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.411+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [3098.213811] pp(0x56a640) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:57:26.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8232
06-12 13:57:26.421+0200 I/gravity ( 8273): es.ugr.frailty.gravity - capturing data
06-12 13:57:26.421+0200 I/gravity ( 8273): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:57:26:430,3.485535,-0.764740,9.134364
06-12 13:57:26.431+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.431+0200 W/AUL     ( 8261): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.431+0200 W/AUL     ( 8240): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8235
06-12 13:57:26.431+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.431+0200 I/utils   ( 8235): specific action
06-12 13:57:26.431+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.431+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.431+0200 I/recorder( 8235): saving local data for es.ugr.frailty.gyroscope
06-12 13:57:26.431+0200 I/recorder( 8235): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 13:57:26.441+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8235)
06-12 13:57:26.441+0200 I/servicemanager( 8232): request sent to service es.ugr.frailty.recorder
06-12 13:57:26.441+0200 I/servicemanager( 8232): requesting to save local data
06-12 13:57:26.441+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.451+0200 I/utils   ( 8232): specific action
06-12 13:57:26.451+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.451+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.451+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.451+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.451+0200 I/servicemanager( 8232): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 13:57:26.451+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:57:26.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8316
06-12 13:57:26.481+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 13:57:26.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:57:26.481+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 13:57:26.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.481+0200 I/heartrate( 8246): es.ugr.frailty.heartrate - capturing data
06-12 13:57:26.481+0200 I/heartrate( 8246): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:57:26.481+0200 I/location( 8259): es.ugr.frailty.location: waiting for rigth values
06-12 13:57:26.491+0200 W/LOCATION( 8259): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 13:57:26.491+0200 W/AUL     ( 8316): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.491+0200 I/light   ( 8316): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.491+0200 I/light   ( 8316): es.ugr.frailty.light - capturing data
06-12 13:57:26.491+0200 I/light   ( 8316): es.ugr.frailty.light: SM-R760,12/06/2018,13:57:26:497,110.000000
06-12 13:57:26.491+0200 W/AUL     ( 8316): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.491+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.491+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(39) , send fd(21), pid(8232), cmd(0)
06-12 13:57:26.511+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(8235), cmd(0)
06-12 13:57:26.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8242
06-12 13:57:26.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.541+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.541+0200 I/gyroscope( 8242): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.541+0200 I/gyroscope( 8242): es.ugr.frailty.gyroscope - capturing data
06-12 13:57:26.551+0200 I/gyroscope( 8242): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:57:26:553,1.470000,-9.170000,-1.120000
06-12 13:57:26.551+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.561+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8273
06-12 13:57:26.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.581+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.581+0200 I/gravity ( 8273): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.581+0200 I/gravity ( 8273): es.ugr.frailty.gravity - capturing data
06-12 13:57:26.581+0200 I/gravity ( 8273): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:57:26:589,3.410798,-0.712882,9.166714
06-12 13:57:26.581+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8232
06-12 13:57:26.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8235
06-12 13:57:26.601+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.601+0200 I/utils   ( 8235): specific action
06-12 13:57:26.601+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.601+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.601+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.601+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.601+0200 W/CAPI_APPFW_APP_CONTROL( 8235): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.601+0200 I/recorder( 8235): saving local data for es.ugr.frailty.linearacceleration
06-12 13:57:26.601+0200 I/recorder( 8235): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 13:57:26.611+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8235)
06-12 13:57:26.611+0200 I/servicemanager( 8232): request sent to service es.ugr.frailty.recorder
06-12 13:57:26.611+0200 I/servicemanager( 8232): requesting to save local data
06-12 13:57:26.611+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.611+0200 I/utils   ( 8232): specific action
06-12 13:57:26.611+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.611+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.611+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.611+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.611+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.611+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.611+0200 W/CAPI_APPFW_APP_CONTROL( 8232): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:57:26.611+0200 I/servicemanager( 8232): requesting to save local data for es.ugr.frailty.light
06-12 13:57:26.611+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:57:26.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8240
06-12 13:57:26.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.651+0200 W/AUL     ( 8240): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.651+0200 I/accelerometer( 8240): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.651+0200 I/accelerometer( 8240): es.ugr.frailty.accelerometer - capturing data
06-12 13:57:26.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(21), pid(8232), cmd(0)
06-12 13:57:26.661+0200 I/accelerometer( 8240): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:57:26:662,3.433701,-0.801596,9.348758
06-12 13:57:26.661+0200 W/AUL     ( 8240): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.671+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:57:26.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(61) , send fd(21), pid(8235), cmd(0)
06-12 13:57:26.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.681+0200 I/heartrate( 8246): es.ugr.frailty.heartrate - capturing data
06-12 13:57:26.681+0200 I/heartrate( 8246): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:57:26.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8261
06-12 13:57:26.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.701+0200 W/AUL     ( 8261): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.701+0200 I/linearacceleration( 8261): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.701+0200 I/linearacceleration( 8261): es.ugr.frailty.linearacceleration - capturing data
06-12 13:57:26.701+0200 I/linearacceleration( 8261): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:57:26:709,0.094128,-0.465171,-0.146923
06-12 13:57:26.711+0200 W/AUL     ( 8261): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 13:57:26.721+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8331
06-12 13:57:26.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.731+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8316
06-12 13:57:26.741+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.761+0200 W/AUL     ( 8316): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.781+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8242
06-12 13:57:26.791+0200 I/light   ( 8316): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.791+0200 I/light   ( 8316): es.ugr.frailty.light - capturing data
06-12 13:57:26.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.791+0200 I/light   ( 8316): es.ugr.frailty.light: SM-R760,12/06/2018,13:57:26:795,110.000000
06-12 13:57:26.791+0200 W/AUL     ( 8316): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.801+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.801+0200 I/gyroscope( 8242): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.801+0200 I/gyroscope( 8242): es.ugr.frailty.gyroscope - capturing data
06-12 13:57:26.811+0200 I/gyroscope( 8242): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:57:26:812,2.030000,5.600000,2.380000
06-12 13:57:26.811+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8273
06-12 13:57:26.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.831+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8232)
06-12 13:57:26.831+0200 I/gravity ( 8273): request sent to service es.ugr.frailty.servicemanager
06-12 13:57:26.841+0200 I/gravity ( 8273): es.ugr.frailty.gravity - capturing data
06-12 13:57:26.841+0200 I/gravity ( 8273): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:57:26:844,3.632497,-0.920117,9.062490
06-12 13:57:26.841+0200 W/AUL     ( 8273): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:57:26.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.861+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8232
06-12 13:57:26.881+0200 I/efl-extension( 8347): efl_extension.c: eext_mod_init(40) > Init
06-12 13:57:26.881+0200 I/heartrate( 8246): es.ugr.frailty.heartrate - capturing data
06-12 13:57:26.881+0200 I/heartrate( 8246): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:57:26.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8235
06-12 13:57:26.911+0200 W/AUL     ( 8232): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8235)
06-12 13:57:26.911+0200 I/servicemanager( 8232): request sent to service es.ugr.frailty.recorder
06-12 13:57:26.911+0200 I/servicemanager( 8232): requesting to save local data
06-12 13:57:26.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:57:26.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8240
06-12 13:57:26.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8232
06-12 13:57:26.941+0200 W/CRASH_MANAGER( 8366): worker.c: worker_job(1205) > 11082596c6f63152880464
