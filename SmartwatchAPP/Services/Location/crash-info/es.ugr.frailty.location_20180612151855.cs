S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14405
Date: 2018-06-12 15:18:55+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf760252d, r5   = 0xf7a70150
r6   = 0xff96e640, r7   = 0xff96e4f0
r8   = 0xf7a82c18, r9   = 0x00000000
r10  = 0xff96e5cc, fp   = 0xff96e640
ip   = 0x00000001, sp   = 0xff96e4c8
lr   = 0xf7602539, pc   = 0xf766b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    134872 KB
Buffers:     37228 KB
Cached:     165140 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11660 KB
VmRSS:       11660 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14405 TID = 14405
14405 14492 

Maps Information
f44cd000 f4ccc000 rw-p [stack:14492]
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
f7a52000 f7ac0000 rw-p [heap]
ff94f000 ff970000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14405)
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
)
06-12 15:18:53.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 15:18:53.711+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.513809] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.711+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14446
06-12 15:18:53.721+0200 I/APP_CORE(14258): appcore-efl.c: __do_app(453) > [APP 14258] Event: RESUME State: RUNNING
06-12 15:18:53.731+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.530554] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.741+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:53.741+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.547217] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.741+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:53.741+0200 I/gyroscope(14391): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:53.741+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope - capturing data
06-12 15:18:53.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:53.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14388
06-12 15:18:53.761+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.563812] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:53.781+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.580577] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.781+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:53.791+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.597419] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.791+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:53.801+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(6202) status(bg) type(uiapp)
06-12 15:18:53.801+0200 W/AUL     (14388): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:53.801+0200 I/accelerometer(14388): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:53.801+0200 I/accelerometer(14388): es.ugr.frailty.accelerometer - capturing data
06-12 15:18:53.811+0200 I/utils   (14380): specific action
06-12 15:18:53.811+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:53.811+0200 I/servicemanager(14380): requesting to save local data for es.ugr.frailty.gyroscope
06-12 15:18:53.811+0200 W/AUL     (14380): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 15:18:53.811+0200 W/W_INDICATOR( 2694): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-12 15:18:53.811+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.613988] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.811+0200 W/W_INDICATOR( 2694): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-12 15:18:53.811+0200 W/W_INDICATOR( 2694): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-12 15:18:53.811+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,15:18:53:781,0.630000,0.350000,-4.480000
06-12 15:18:53.811+0200 W/AUL     (14391): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:53.811+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:53.811+0200 I/utils   (14383): specific action
06-12 15:18:53.811+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:53.811+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:53.811+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:53.811+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:53.811+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:53.811+0200 I/recorder(14383): saving local data for es.ugr.frailty.linearacceleration
06-12 15:18:53.811+0200 I/recorder(14383): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 15:18:53.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:53.831+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.630649] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14430
06-12 15:18:53.831+0200 I/accelerometer(14388): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,15:18:53:811,9.748360,0.160319,0.899701
06-12 15:18:53.831+0200 W/AUL     (14388): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:53.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:53.861+0200 W/AUL     (14430): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:53.861+0200 I/gravity (14430): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:53.861+0200 I/gravity (14430): es.ugr.frailty.gravity - capturing data
06-12 15:18:53.861+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.664259] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.861+0200 I/linearacceleration(14417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,15:18:53:547,-0.032696,0.086246,0.195535
06-12 15:18:53.861+0200 W/AUL     (14417): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:53.861+0200 I/light   (14450): es.ugr.frailty.light: SM-R760,12/06/2018,15:18:53:798,33.000000
06-12 15:18:53.861+0200 W/AUL     (14450): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:53.871+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(14258) status(fg) type(uiapp)
06-12 15:18:53.881+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.681940] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.891+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.697478] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.911+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.718362] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 15:18:53.941+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.747808] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.961+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.767031] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 15:18:53.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(41) , send fd(15), pid(14383), cmd(0)
06-12 15:18:53.981+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.781016] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:53.981+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:53.991+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:53.991+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.797801] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:54.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.001+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14380
06-12 15:18:54.011+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.814385] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:54.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14383
06-12 15:18:54.031+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.831252] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:54.031+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.031+0200 W/AUL     (14380): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14383)
06-12 15:18:54.031+0200 I/servicemanager(14380): request sent to service es.ugr.frailty.recorder
06-12 15:18:54.031+0200 I/servicemanager(14380): requesting to save local data
06-12 15:18:54.031+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.031+0200 I/utils   (14383): specific action
06-12 15:18:54.031+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.031+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.031+0200 I/recorder(14383): saving local data for es.ugr.frailty.gyroscope
06-12 15:18:54.031+0200 I/recorder(14383): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 15:18:54.031+0200 I/utils   (14380): specific action
06-12 15:18:54.031+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.031+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.031+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.031+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.031+0200 I/servicemanager(14380): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 15:18:54.031+0200 W/AUL     (14380): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 15:18:54.041+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7985.847813] pp(0x502408) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:54.051+0200 I/location(14405): es.ugr.frailty.location: waiting for rigth values
06-12 15:18:54.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14391
06-12 15:18:54.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.091+0200 W/AUL     (14391): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.091+0200 I/gyroscope(14391): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.091+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope - capturing data
06-12 15:18:54.101+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,15:18:54:102,0.770000,-0.350000,-4.900000
06-12 15:18:54.101+0200 W/AUL     (14391): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.101+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 15:18:54.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(40) , send fd(15), pid(14380), cmd(0)
06-12 15:18:54.111+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 15:18:54.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(41) , send fd(15), pid(14383), cmd(0)
06-12 15:18:54.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14388
06-12 15:18:54.141+0200 I/APP_CORE( 6202): appcore-efl.c: __do_app(453) > [APP 6202] Event: MEM_FLUSH State: PAUSED
06-12 15:18:54.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.181+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:54.191+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:54.191+0200 W/AUL     (14388): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.191+0200 I/accelerometer(14388): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.191+0200 I/accelerometer(14388): es.ugr.frailty.accelerometer - capturing data
06-12 15:18:54.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.221+0200 I/gravity (14430): es.ugr.frailty.gravity: SM-R760,12/06/2018,15:18:53:866,9.723691,0.236036,1.250802
06-12 15:18:54.221+0200 W/AUL     (14430): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.231+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14417
06-12 15:18:54.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.251+0200 W/AUL     (14417): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.251+0200 I/linearacceleration(14417): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.251+0200 I/linearacceleration(14417): es.ugr.frailty.linearacceleration - capturing data
06-12 15:18:54.281+0200 I/linearacceleration(14417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,15:18:54:263,-0.003169,0.015315,-0.008345
06-12 15:18:54.281+0200 W/AUL     (14417): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14450
06-12 15:18:54.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.321+0200 W/AUL     (14450): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.321+0200 I/light   (14450): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.321+0200 I/light   (14450): es.ugr.frailty.light - capturing data
06-12 15:18:54.321+0200 E/AUL     ( 2478): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-12 15:18:54.321+0200 I/light   (14450): es.ugr.frailty.light: SM-R760,12/06/2018,15:18:54:324,77.000000
06-12 15:18:54.321+0200 W/AUL     (14450): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.321+0200 I/accelerometer(14388): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,15:18:54:202,9.784252,0.124427,0.842274
06-12 15:18:54.321+0200 W/AUL     (14388): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 15:18:54.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14258
06-12 15:18:54.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14380
06-12 15:18:54.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14383
06-12 15:18:54.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 15:18:54.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 15:18:54.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 15:18:54.391+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 15:18:54.411+0200 E/CAPI_TELEPHONY(14493): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 15:18:54.411+0200 W/AUL     (14380): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14383)
06-12 15:18:54.411+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:54.421+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:54.421+0200 I/servicemanager(14380): request sent to service es.ugr.frailty.recorder
06-12 15:18:54.421+0200 I/servicemanager(14380): requesting to save local data
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 I/utils   (14383): specific action
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 I/recorder(14383): saving local data for es.ugr.frailty.linearacceleration
06-12 15:18:54.421+0200 I/recorder(14383): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 15:18:54.421+0200 I/utils   (14380): specific action
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.421+0200 I/servicemanager(14380): requesting to save local data for es.ugr.frailty.gravity
06-12 15:18:54.421+0200 W/AUL     (14380): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 15:18:54.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 15:18:54.441+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14450
06-12 15:18:54.441+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 15:18:54.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(14380), cmd(0)
06-12 15:18:54.441+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 15:18:54.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(48) , send fd(15), pid(14383), cmd(0)
06-12 15:18:54.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14391
06-12 15:18:54.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.501+0200 W/AUL     (14391): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.501+0200 I/gyroscope(14391): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.501+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope - capturing data
06-12 15:18:54.511+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,15:18:54:504,0.140000,0.350000,-0.210000
06-12 15:18:54.511+0200 W/AUL     (14391): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.531+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14430
06-12 15:18:54.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.561+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 15:18:54.561+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 15:18:54.561+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 15:18:54.561+0200 W/AUL     (14430): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.561+0200 I/gravity (14430): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.561+0200 I/gravity (14430): es.ugr.frailty.gravity - capturing data
06-12 15:18:54.581+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:54.581+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:54.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14417
06-12 15:18:54.601+0200 I/gravity (14430): es.ugr.frailty.gravity: SM-R760,12/06/2018,15:18:54:569,9.739296,0.199511,1.129907
06-12 15:18:54.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.601+0200 W/AUL     (14430): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.621+0200 W/AUL     (14417): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.621+0200 I/linearacceleration(14417): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.621+0200 I/linearacceleration(14417): es.ugr.frailty.linearacceleration - capturing data
06-12 15:18:54.621+0200 I/linearacceleration(14417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,15:18:54:625,0.071008,0.044028,-0.041845
06-12 15:18:54.621+0200 W/AUL     (14417): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.651+0200 I/efl-extension(14504): efl_extension.c: eext_mod_init(40) > Init
06-12 15:18:54.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14450
06-12 15:18:54.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.681+0200 W/AUL     (14450): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.681+0200 I/light   (14450): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.681+0200 I/light   (14450): es.ugr.frailty.light - capturing data
06-12 15:18:54.681+0200 I/light   (14450): es.ugr.frailty.light: SM-R760,12/06/2018,15:18:54:684,86.000000
06-12 15:18:54.681+0200 W/AUL     (14450): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.691+0200 E/EFL     (14258): ecore_x<14258> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7986492 button=1
06-12 15:18:54.691+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] mouse move
06-12 15:18:54.691+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] mouse move
06-12 15:18:54.691+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] hold(0), freeze(0)
06-12 15:18:54.701+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] mouse move
06-12 15:18:54.701+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] hold(0), freeze(0)
06-12 15:18:54.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.711+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14388
06-12 15:18:54.721+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.741+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] mouse move
06-12 15:18:54.741+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] hold(0), freeze(0)
06-12 15:18:54.741+0200 W/AUL     (14388): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.741+0200 I/accelerometer(14388): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.741+0200 I/accelerometer(14388): es.ugr.frailty.accelerometer - capturing data
06-12 15:18:54.751+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] mouse move
06-12 15:18:54.751+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] hold(0), freeze(0)
06-12 15:18:54.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 15:18:54.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14380
06-12 15:18:54.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14383
06-12 15:18:54.811+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:54.811+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.821+0200 W/AUL     (14380): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14383)
06-12 15:18:54.821+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] mouse move
06-12 15:18:54.821+0200 E/EFL     (14258): elementary<14258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7552930 : elm_scroller] hold(0), freeze(0)
06-12 15:18:54.821+0200 I/servicemanager(14380): request sent to service es.ugr.frailty.recorder
06-12 15:18:54.831+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:54.831+0200 I/servicemanager(14380): requesting to save local data
06-12 15:18:54.831+0200 I/utils   (14383): specific action
06-12 15:18:54.831+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.831+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.831+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.831+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.831+0200 E/EFL     (14258): ecore_x<14258> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7986636 button=1
06-12 15:18:54.851+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.851+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.851+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:54.851+0200 I/utils   (14380): specific action
06-12 15:18:54.851+0200 I/servicemanager(14380): requesting to save local data for es.ugr.frailty.accelerometer
06-12 15:18:54.851+0200 I/recorder(14383): saving local data for es.ugr.frailty.gravity
06-12 15:18:54.851+0200 I/recorder(14383): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 15:18:54.851+0200 W/AUL     (14380): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 15:18:54.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 15:18:54.851+0200 I/accelerometer(14388): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,15:18:54:751,9.812965,0.050249,0.808774
06-12 15:18:54.851+0200 W/AUL     (14388): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.851+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 15:18:54.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14380), cmd(0)
06-12 15:18:54.871+0200 I/UXT     (14504): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-12 15:18:54.871+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 15:18:54.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(52) , send fd(15), pid(14383), cmd(0)
06-12 15:18:54.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.901+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14391
06-12 15:18:54.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.931+0200 W/AUL     (14391): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.931+0200 I/gyroscope(14391): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.931+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope - capturing data
06-12 15:18:54.941+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,15:18:54:941,-0.140000,0.140000,0.560000
06-12 15:18:54.941+0200 W/AUL     (14391): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:54.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:54.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14430
06-12 15:18:54.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:54.981+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7986.784548] pp(0x5c8898) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:54.981+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:54.981+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:54.981+0200 I/AUL_PAD (14504): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-12 15:18:54.991+0200 W/AUL     (14430): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:54.991+0200 I/gravity (14430): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:54.991+0200 I/gravity (14430): es.ugr.frailty.gravity - capturing data
06-12 15:18:55.001+0200 I/gravity (14430): es.ugr.frailty.gravity: SM-R760,12/06/2018,15:18:55:0,9.750745,0.146962,1.035261
06-12 15:18:55.001+0200 W/AUL     (14430): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:55.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:55.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14417
06-12 15:18:55.031+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7986.833074] pp(0x6181e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:55.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:55.041+0200 E/MALI    (14504): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
06-12 15:18:55.061+0200 W/AUL     (14417): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:55.061+0200 I/linearacceleration(14417): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:55.061+0200 I/linearacceleration(14417): es.ugr.frailty.linearacceleration - capturing data
06-12 15:18:55.061+0200 I/linearacceleration(14417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,15:18:55:64,-0.014246,0.031416,-0.277167
06-12 15:18:55.061+0200 W/AUL     (14417): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:55.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:55.081+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14450
06-12 15:18:55.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:55.111+0200 W/AUL     (14450): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:55.111+0200 I/light   (14450): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:55.111+0200 I/light   (14450): es.ugr.frailty.light - capturing data
06-12 15:18:55.111+0200 I/light   (14450): es.ugr.frailty.light: SM-R760,12/06/2018,15:18:55:116,85.000000
06-12 15:18:55.111+0200 W/AUL     (14450): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:55.141+0200 W/LOCATION(14405): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 15:18:55.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 15:18:55.161+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-12 15:18:55.161+0200 W/AUL     (14258): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.frailtylauncher)
06-12 15:18:55.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:55.181+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:55.181+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:55.181+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14380
06-12 15:18:55.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14383
06-12 15:18:55.201+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [7987.002416] pp(0x5c8898) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 15:18:55.201+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:55.201+0200 W/AUL     (14380): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14383)
06-12 15:18:55.201+0200 I/servicemanager(14380): request sent to service es.ugr.frailty.recorder
06-12 15:18:55.201+0200 I/servicemanager(14380): requesting to save local data
06-12 15:18:55.201+0200 W/CAPI_APPFW_APP_CONTROL(14380): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:55.201+0200 I/utils   (14383): specific action
06-12 15:18:55.201+0200 W/CAPI_APPFW_APP_CONTROL(14383): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 15:18:55.201+0200 I/recorder(14383): saving local data for es.ugr.frailty.accelerometer
06-12 15:18:55.211+0200 I/recorder(14383): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 15:18:55.211+0200 I/utils   (14380): specific action
06-12 15:18:55.211+0200 I/servicemanager(14380): requesting to save local data for es.ugr.frailty.accelerometer
06-12 15:18:55.211+0200 W/AUL     (14380): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 15:18:55.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:55.241+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14388
06-12 15:18:55.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:55.261+0200 W/AUL     (14388): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:55.271+0200 I/accelerometer(14388): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:55.271+0200 I/accelerometer(14388): es.ugr.frailty.accelerometer - capturing data
06-12 15:18:55.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 15:18:55.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(14380), cmd(0)
06-12 15:18:55.271+0200 I/accelerometer(14388): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,15:18:55:274,9.772287,0.179462,0.844666
06-12 15:18:55.271+0200 W/AUL     (14388): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:55.281+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 15:18:55.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(55) , send fd(15), pid(14383), cmd(0)
06-12 15:18:55.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 15:18:55.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14461
06-12 15:18:55.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:55.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14391
06-12 15:18:55.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:55.381+0200 W/AUL     (14391): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:55.381+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:55.381+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:55.381+0200 I/gyroscope(14391): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:55.381+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope - capturing data
06-12 15:18:55.391+0200 I/gyroscope(14391): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,15:18:55:391,-0.070000,0.140000,1.120000
06-12 15:18:55.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 15:18:55.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 15:18:55.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 15:18:55.391+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 15:18:55.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:55.391+0200 W/AUL     (14391): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:55.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14430
06-12 15:18:55.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:55.431+0200 W/AUL     (14430): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:55.431+0200 I/gravity (14430): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:55.431+0200 I/gravity (14430): es.ugr.frailty.gravity - capturing data
06-12 15:18:55.441+0200 I/gravity (14430): es.ugr.frailty.gravity: SM-R760,12/06/2018,15:18:55:440,9.764201,0.153478,0.898444
06-12 15:18:55.441+0200 W/AUL     (14430): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 15:18:55.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:55.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14417
06-12 15:18:55.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:55.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 15:18:55.481+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 15:18:55.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 15:18:55.481+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 15:18:55.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 15:18:55.481+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 15:18:55.481+0200 E/CAPI_LOCATION_MANAGER(14493): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 15:18:55.481+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 15:18:55.481+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 15:18:55.491+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 15:18:55.501+0200 W/AUL     (14520): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 15:18:55.511+0200 W/AUL     (14417): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:55.511+0200 I/linearacceleration(14417): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:55.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:55.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14450
06-12 15:18:55.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14380
06-12 15:18:55.551+0200 W/AUL     (14450): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14380)
06-12 15:18:55.561+0200 I/linearacceleration(14417): es.ugr.frailty.linearacceleration - capturing data
06-12 15:18:55.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 15:18:55.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14258
06-12 15:18:55.591+0200 I/AUL_AMD ( 2478): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-12 15:18:55.601+0200 I/heartrate(14392): es.ugr.frailty.heartrate - capturing data
06-12 15:18:55.601+0200 I/light   (14450): request sent to service es.ugr.frailty.servicemanager
06-12 15:18:55.601+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(2218) > pad pid(-5)
06-12 15:18:55.601+0200 I/heartrate(14392): es.ugr.frailty.heartrate: waiting for rigth values
06-12 15:18:55.601+0200 W/AUL_PAD ( 3389): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
06-12 15:18:55.601+0200 W/AUL_PAD ( 3389): launchpad.c: __send_result_to_caller(272) > Check app launching
06-12 15:18:55.601+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 15:18:55.601+0200 W/AUL_PAD (14293): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
06-12 15:18:55.601+0200 W/AUL_PAD (14293): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
06-12 15:18:55.601+0200 W/AUL_PAD (14293): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
06-12 15:18:55.601+0200 W/AUL_PAD (14293): launchpad_loader.c: main(680) > [candidate] dlopen(es.ugr.frailty.frailtylauncher)
06-12 15:18:55.631+0200 I/light   (14450): es.ugr.frailty.light - capturing data
06-12 15:18:55.631+0200 I/light   (14450): es.ugr.frailty.light: SM-R760,12/06/2018,15:18:55:634,84.000000
06-12 15:18:55.641+0200 I/CAPI_NETWORK_CONNECTION(14493): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 15:18:55.641+0200 I/CAPI_NETWORK_CONNECTION(14493): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 15:18:55.641+0200 I/CAPI_NETWORK_CONNECTION(14493): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 15:18:55.641+0200 I/CAPI_NETWORK_CONNECTION(14493): connection.c: connection_destroy(471) > Destroy handle: 0xf7dacc18
06-12 15:18:55.651+0200 I/linearacceleration(14417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,15:18:55:626,0.007290,0.036201,-0.260417
06-12 15:18:55.661+0200 I/efl-extension(14293): efl_extension.c: eext_mod_init(40) > Init
06-12 15:18:55.671+0200 I/UXT     (14293): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-12 15:18:55.671+0200 W/AUL_PAD (14293): launchpad_loader.c: main(690) > [candidate] dlsym
06-12 15:18:55.671+0200 W/AUL_PAD (14293): launchpad_loader.c: main(694) > [candidate] dl_main(es.ugr.frailty.frailtylauncher)
06-12 15:18:55.671+0200 I/CAPI_APPFW_APPLICATION(14293): app_main.c: ui_app_main(704) > app_efl_main
06-12 15:18:55.671+0200 W/CRASH_MANAGER(14523): worker.c: worker_job(1205) > 11144056c6f63152880953
