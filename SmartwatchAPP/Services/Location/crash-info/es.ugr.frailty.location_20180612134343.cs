S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7217
Date: 2018-06-12 13:43:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf723852d, r5   = 0xf7738150
r6   = 0xffb73800, r7   = 0xffb736b0
r8   = 0xf774ac18, r9   = 0x00000000
r10  = 0xffb7378c, fp   = 0xffb73800
ip   = 0x00000001, sp   = 0xffb73688
lr   = 0xf7238539, pc   = 0xf72a1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    186116 KB
Buffers:     27184 KB
Cached:     137352 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11676 KB
VmRSS:       11676 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7217 TID = 7217
7217 7317 

Maps Information
f4103000 f4902000 rw-p [stack:7317]
f4909000 f490b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4913000 f4917000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4920000 f4922000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f492a000 f492d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f493c000 f4941000 r-xp /usr/lib/libsystem.so.0.0.0
f494c000 f494f000 r-xp /lib/libattr.so.1.1.0
f4957000 f4967000 r-xp /usr/lib/libmdm-common.so.1.1.24
f496f000 f4978000 r-xp /usr/lib/libedbus.so.1.7.99
f4980000 f4981000 r-xp /usr/lib/libresponse.so.0.2.96
f498a000 f498f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6231000 f6337000 r-xp /usr/lib/libicuuc.so.57.1
f634d000 f64d5000 r-xp /usr/lib/libicui18n.so.57.1
f64e5000 f64f2000 r-xp /usr/lib/libail.so.0.1.0
f64fb000 f6502000 r-xp /usr/lib/libminizip.so.1.0.0
f650b000 f66b4000 r-xp /usr/lib/libcrypto.so.1.0.0
f66d4000 f671b000 r-xp /usr/lib/libssl.so.1.0.0
f6727000 f6729000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6731000 f6738000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6741000 f6748000 r-xp /lib/libcrypt-2.13.so
f6779000 f677c000 r-xp /lib/libcap.so.2.21
f6784000 f6786000 r-xp /usr/lib/libiri.so
f678e000 f67d7000 r-xp /usr/lib/libmdm.so.1.2.69
f67df000 f67e5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67ed000 f6810000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f681a000 f681c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6824000 f6841000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f684a000 f684e000 r-xp /usr/lib/libsmack.so.1.0.0
f6857000 f6870000 r-xp /usr/lib/libnetwork.so.0.0.0
f6879000 f6881000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6889000 f688f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6898000 f689a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68a3000 f68b3000 r-xp /lib/libresolv-2.13.so
f68b7000 f68cf000 r-xp /usr/lib/liblzma.so.5.0.3
f68d8000 f68da000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68e2000 f68fc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6904000 f6933000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f693c000 f694b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6955000 f695f000 r-xp /usr/lib/libsensord-shared.so
f6968000 f6a3b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a46000 f6a5c000 r-xp /lib/libz.so.1.2.5
f6a64000 f6a69000 r-xp /usr/lib/libffi.so.5.0.10
f6a71000 f6a72000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a7a000 f6a8a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a92000 f6aab000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ab3000 f6ab5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6abd000 f6b32000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b3c000 f6b42000 r-xp /lib/librt-2.13.so
f6b4b000 f6b69000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b73000 f6b74000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b7c000 f6b9f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ba7000 f6bac000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bb4000 f6bde000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6be7000 f6bfe000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c06000 f6c6f000 r-xp /lib/libm-2.13.so
f6c78000 f6d0c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d1f000 f6d24000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d2c000 f6d33000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d3b000 f6d65000 r-xp /usr/lib/libsensor.so.1.9.6
f6d6e000 f6e3a000 r-xp /usr/lib/libxml2.so.2.7.8
f6e47000 f6e49000 r-xp /usr/lib/libiniparser.so.0
f6e52000 f6e58000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e61000 f6f31000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f32000 f6f66000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f6f000 f6fab000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fb3000 f6fb6000 r-xp /usr/lib/libbundle.so.0.1.22
f6fbe000 f6fc4000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fcc000 f700d000 r-xp /usr/lib/libeina.so.1.7.99
f7016000 f702d000 r-xp /usr/lib/libecore.so.1.7.99
f7044000 f704d000 r-xp /usr/lib/libvconf.so.0.2.45
f7055000 f7069000 r-xp /lib/libpthread-2.13.so
f7074000 f7081000 r-xp /usr/lib/libaul.so.0.1.0
f708b000 f708d000 r-xp /lib/libdl-2.13.so
f7096000 f70a1000 r-xp /lib/libunwind.so.8.0.1
f70ce000 f70d6000 r-xp /lib/libgcc_s-4.6.so.1
f70d7000 f71fb000 r-xp /lib/libc-2.13.so
f7209000 f720b000 r-xp /usr/lib/libdlog.so.0.0.0
f7213000 f721f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7228000 f722d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7235000 f7244000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f724c000 f7250000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7259000 f725c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7264000 f7266000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f726e000 f7272000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f727a000 f7297000 r-xp /lib/ld-2.13.so
f72a0000 f72a3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72a3000 f72a7000 r-xp /usr/lib/libsys-assert.so
f771a000 f778b000 rw-p [heap]
ffb54000 ffb75000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7217)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72a1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7238539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f3f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f3dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f49e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f4fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f4fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f8475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f7f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f3dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f49e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f4fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f4fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f81e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f82017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f89f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49211fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4914171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69e7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e94fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e967a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7026ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7021b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70225a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7022879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf725a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf725a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72a15c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70ee85c) [/lib/libc.so.6] + 0x1785c
29: (0xf72a0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
2/06/2018,13:43:40:58,106.000000
06-12 13:43:40.071+0200 I/gyroscope( 7213): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:43:40:60,31.080000,-12.460000,19.600000
06-12 13:43:40.071+0200 W/AUL     ( 7251): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.081+0200 W/AUL     ( 7213): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.081+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2271.883638] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:43:40.081+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7213
06-12 13:43:40.081+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 13:43:40.081+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 13:43:40.081+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 13:43:40.081+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 13:43:40.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7204
06-12 13:43:40.101+0200 W/AUL     ( 7204): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7207)
06-12 13:43:40.101+0200 I/servicemanager( 7204): request sent to service es.ugr.frailty.recorder
06-12 13:43:40.101+0200 I/servicemanager( 7204): requesting to save local data
06-12 13:43:40.101+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.101+0200 I/utils   ( 7204): specific action
06-12 13:43:40.101+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.101+0200 I/servicemanager( 7204): requesting to save local data for es.ugr.frailty.gyroscope
06-12 13:43:40.101+0200 W/AUL     ( 7204): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:43:40.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:43:40.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7251
06-12 13:43:40.121+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2271.920833] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7204
06-12 13:43:40.121+0200 W/AUL     ( 7213): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7204)
06-12 13:43:40.131+0200 I/gyroscope( 7213): request sent to service es.ugr.frailty.servicemanager
06-12 13:43:40.131+0200 W/AUL     ( 7251): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7204)
06-12 13:43:40.131+0200 I/light   ( 7251): request sent to service es.ugr.frailty.servicemanager
06-12 13:43:40.131+0200 I/light   ( 7251): es.ugr.frailty.light - capturing data
06-12 13:43:40.141+0200 I/light   ( 7251): es.ugr.frailty.light: SM-R760,12/06/2018,13:43:40:140,108.000000
06-12 13:43:40.141+0200 W/AUL     ( 7251): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.141+0200 W/W_HOME  ( 6202): clock_manager.c: _hwc_disabled_timer_cb(125) > hwc disabled
06-12 13:43:40.141+0200 I/gyroscope( 7213): es.ugr.frailty.gyroscope - capturing data
06-12 13:43:40.141+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2271.948165] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.141+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.151+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:43:40.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(7204), cmd(0)
06-12 13:43:40.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:43:40.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7204
06-12 13:43:40.161+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2271.961454] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.161+0200 I/utils   ( 7207): specific action
06-12 13:43:40.161+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.161+0200 I/recorder( 7207): saving local data for es.ugr.frailty.accelerometer
06-12 13:43:40.161+0200 I/recorder( 7207): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 13:43:40.161+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7207
06-12 13:43:40.171+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:43:40.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(7207), cmd(0)
06-12 13:43:40.181+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2271.985160] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.181+0200 W/AUL     ( 7204): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7207)
06-12 13:43:40.181+0200 I/servicemanager( 7204): request sent to service es.ugr.frailty.recorder
06-12 13:43:40.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:43:40.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7251
06-12 13:43:40.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 13:43:40.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 13:43:40.191+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:40.201+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:40.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7204
06-12 13:43:40.211+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.010818] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.221+0200 W/AUL     ( 7251): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7204)
06-12 13:43:40.221+0200 I/light   ( 7251): request sent to service es.ugr.frailty.servicemanager
06-12 13:43:40.221+0200 I/light   ( 7251): es.ugr.frailty.light - capturing data
06-12 13:43:40.221+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.025341] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.221+0200 I/light   ( 7251): es.ugr.frailty.light: SM-R760,12/06/2018,13:43:40:229,103.000000
06-12 13:43:40.221+0200 W/AUL     ( 7251): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.231+0200 I/servicemanager( 7204): requesting to save local data
06-12 13:43:40.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:43:40.231+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7251
06-12 13:43:40.231+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7204
06-12 13:43:40.251+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.050537] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.261+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.063415] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.261+0200 W/APPS    ( 6202): AppsItem.cpp: onItemBadgeShow(686) >  badge show:[6:1]
06-12 13:43:40.261+0200 I/utils   ( 7204): specific action
06-12 13:43:40.261+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.261+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.261+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.261+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.261+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.261+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.261+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.261+0200 I/servicemanager( 7204): requesting to save local data for es.ugr.frailty.light
06-12 13:43:40.261+0200 W/AUL     ( 7204): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:43:40.261+0200 W/W_HOME  ( 6202): event_manager.c: _move_module_anim_end_cb(680) > state: 1 -> 0
06-12 13:43:40.261+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 13:43:40.261+0200 W/W_HOME  ( 6202): rotary.c: rotary_deattach(156) > rotary_deattach:0xf79b2330
06-12 13:43:40.261+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-12 13:43:40.261+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf79b2330, elm_layout, func : 0xf5a6bd05
06-12 13:43:40.261+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-12 13:43:40.261+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-12 13:43:40.261+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-12 13:43:40.261+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf77d0238, elm_box, _activated_obj : 0xf79b2330, activated : 1
06-12 13:43:40.261+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-12 13:43:40.261+0200 E/wnotib  ( 6202): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-12 13:43:40.261+0200 I/wnotib  ( 6202): w-notification-board-basic-panel.c: _wnb_bp_is_key_event_passed(5857) > Return true for 33, -13.
06-12 13:43:40.261+0200 I/wnotib  ( 6202): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
06-12 13:43:40.271+0200 W/AUL     ( 7251): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7204)
06-12 13:43:40.271+0200 I/light   ( 7251): request sent to service es.ugr.frailty.servicemanager
06-12 13:43:40.271+0200 I/light   ( 7251): es.ugr.frailty.light - capturing data
06-12 13:43:40.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:43:40.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(7204), cmd(0)
06-12 13:43:40.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:43:40.281+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.084641] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7204
06-12 13:43:40.291+0200 W/AUL     ( 7220): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.291+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.291+0200 I/utils   ( 7207): specific action
06-12 13:43:40.291+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7207
06-12 13:43:40.291+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.291+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.301+0200 W/AUL     ( 7204): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7207)
06-12 13:43:40.301+0200 I/servicemanager( 7204): request sent to service es.ugr.frailty.recorder
06-12 13:43:40.301+0200 I/servicemanager( 7204): requesting to save local data
06-12 13:43:40.301+0200 W/CAPI_APPFW_APP_CONTROL( 7204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.301+0200 I/utils   ( 7204): specific action
06-12 13:43:40.301+0200 I/servicemanager( 7204): requesting to save local data for es.ugr.frailty.accelerometer
06-12 13:43:40.301+0200 W/AUL     ( 7204): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:43:40.301+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.311+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.311+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.311+0200 I/recorder( 7207): saving local data for es.ugr.frailty.gravity
06-12 13:43:40.321+0200 I/recorder( 7207): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 13:43:40.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:43:40.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7220
06-12 13:43:40.321+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.128630] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.331+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7204
06-12 13:43:40.341+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.142107] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.341+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:43:40.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(7204), cmd(0)
06-12 13:43:40.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(27), pid(7207), cmd(0)
06-12 13:43:40.351+0200 W/AUL     ( 7220): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7204)
06-12 13:43:40.351+0200 I/linearacceleration( 7220): request sent to service es.ugr.frailty.servicemanager
06-12 13:43:40.351+0200 I/linearacceleration( 7220): es.ugr.frailty.linearacceleration - capturing data
06-12 13:43:40.351+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.158765] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.361+0200 I/utils   ( 7207): specific action
06-12 13:43:40.361+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.361+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.361+0200 I/recorder( 7207): saving local data for es.ugr.frailty.gyroscope
06-12 13:43:40.361+0200 I/recorder( 7207): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): event_manager.c: _apptray_visibility_cb(604) > apps,show
06-12 13:43:40.361+0200 I/gravity ( 7225): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:43:39:846,3.526564,-1.102914,9.083903
06-12 13:43:40.361+0200 W/AUL     ( 7225): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 1
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-12 13:43:40.361+0200 I/accelerometer( 7211): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:43:39:871,3.826123,-1.519442,8.468199
06-12 13:43:40.361+0200 W/AUL     ( 7211): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): main.c: home_pause(547) > clock/widget paused
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-12 13:43:40.361+0200 W/APPS    ( 6202): apps_main.c: _time_changed_cb(308) >  date : 12->12
06-12 13:43:40.361+0200 W/APPS    ( 6202): AppsItem.cpp: onItemBadgeShow(686) >  badge show:[6:1]
06-12 13:43:40.361+0200 W/W_INDICATOR( 2694): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-12 13:43:40.361+0200 W/W_INDICATOR( 2694): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-12 13:43:40.361+0200 W/APPS    ( 6202): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): rotary.c: rotary_attach(138) > rotary_attach:0xed639d80
06-12 13:43:40.361+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xed639d80, elm_layout, _activated_obj : 0xf77d0238, activated : 1
06-12 13:43:40.361+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): win.c: win_back_gesture_disable_set(170) > disable back gesture
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): win.c: win_back_gesture_disable_set(170) > disable back gesture
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): noti_broker.c: _apptray_visibility_cb(793) > apps,show
06-12 13:43:40.361+0200 W/W_HOME  ( 6202): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80000
06-12 13:43:40.361+0200 W/wnotib  ( 6202): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80000
06-12 13:43:40.361+0200 E/wnotib  ( 6202): w-notification-board-action.c: wnb_action_is_event_receivable(5137) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-12 13:43:40.361+0200 I/wnotib  ( 6202): w-notification-board-basic-panel.c: _wnb_bp_close_second_depth_view(5936) > wnotib_action_drawer_is_event_receivable: 0, third_depth_genlist: (nil), _wnb_bp_is_third_depth_thread_view: 0, wnotib_common_is_toast_popup_displayed: 0
06-12 13:43:40.361+0200 E/wnotib  ( 6202): w-notification-board-action.c: wnb_action_is_event_receivable(5137) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-12 13:43:40.361+0200 I/wnotib  ( 6202): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
06-12 13:43:40.361+0200 W/wnotib  ( 6202): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [1].
06-12 13:43:40.361+0200 E/APPS    ( 6202): apps_main.c: apps_main_resume(1022) >  resumed already
06-12 13:43:40.371+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.371+0200 I/utils   ( 7207): specific action
06-12 13:43:40.371+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.371+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.371+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.371+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.371+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.371+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.371+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.371+0200 W/CAPI_APPFW_APP_CONTROL( 7207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:43:40.371+0200 I/recorder( 7207): saving local data for es.ugr.frailty.light
06-12 13:43:40.371+0200 I/recorder( 7207): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 13:43:40.381+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.184255] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.391+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:40.391+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:40.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 13:43:40.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 13:43:40.401+0200 I/gyroscope( 7213): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:43:40:152,9.240000,-4.130000,9.100000
06-12 13:43:40.401+0200 W/AUL     ( 7213): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.401+0200 I/light   ( 7251): es.ugr.frailty.light: SM-R760,12/06/2018,13:43:40:274,104.000000
06-12 13:43:40.401+0200 W/AUL     ( 7251): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.401+0200 I/linearacceleration( 7220): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:43:40:361,-0.064930,0.113752,0.188146
06-12 13:43:40.401+0200 W/AUL     ( 7220): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:43:40.411+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.217147] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.411+0200 W/LOCATION( 7217): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
06-12 13:43:40.411+0200 E/LOCATION( 7217): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
06-12 13:43:40.411+0200 E/PKGMGR_INFO( 7217): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
06-12 13:43:40.431+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 13:43:40.451+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.250289] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.461+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.262447] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.461+0200 W/WATCH_CORE( 6251): appcore-watch.c: __widget_pause(1113) > widget_pause
06-12 13:43:40.461+0200 W/AUL     ( 6251): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(6251) status(bg) type(watchapp)
06-12 13:43:40.461+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppPause(552) > 
06-12 13:43:40.491+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.292363] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.511+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.318729] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.521+0200 I/LOCATION( 7217): location.c: location_new(269) > method: 0
06-12 13:43:40.521+0200 W/LOCATION( 7217): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-12 13:43:40.531+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 13:43:40.531+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 13:43:40.541+0200 W/LOCATION( 7217): module-internal.c: module_new(311) > module (gps) open success
06-12 13:43:40.541+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
06-12 13:43:40.551+0200 W/LOCATION( 7217): module-internal.c: module_new(311) > module (remote_gps) open success
06-12 13:43:40.551+0200 W/LOCATION( 7217): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-12 13:43:40.551+0200 W/LOCATION( 7217): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-12 13:43:40.551+0200 W/LOCATION( 7217): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-12 13:43:40.571+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(wps) is found
06-12 13:43:40.571+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(wps) is found
06-12 13:43:40.581+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.380449] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.581+0200 W/LOCATION( 7217): module-internal.c: module_new(311) > module (wps) open success
06-12 13:43:40.581+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
06-12 13:43:40.591+0200 W/LOCATION( 7217): module-internal.c: module_new(311) > module (remote_wps) open success
06-12 13:43:40.591+0200 W/LOCATION( 7217): location-wps.c: __update_remote_connection_status(215) > update FALSE
06-12 13:43:40.591+0200 W/LOCATION( 7217): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
06-12 13:43:40.601+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.401881] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.621+0200 W/LOCATION( 7217): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
06-12 13:43:40.621+0200 I/LOCATION( 7217): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf774ac18
06-12 13:43:40.621+0200 I/LOCATION( 7217): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
06-12 13:43:40.621+0200 I/LOCATION( 7217): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf774ac18
06-12 13:43:40.621+0200 I/LOCATION( 7217): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
06-12 13:43:40.621+0200 I/location( 7217): es.ugr.frailty.location: creado servicio de localización
06-12 13:43:40.651+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:40.651+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:40.681+0200 I/LOCATION( 7217): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
06-12 13:43:40.731+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.530524] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.731+0200 W/LOCATION( 7217): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-12 13:43:40.731+0200 W/LOCATION( 7217): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-12 13:43:40.731+0200 I/LOCATION( 7217): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 13:43:40.801+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2272.605222] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:40.801+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:40.801+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:40.821+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
06-12 13:43:40.821+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
06-12 13:43:40.821+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
06-12 13:43:40.821+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
06-12 13:43:40.821+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
06-12 13:43:40.821+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
06-12 13:43:40.821+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:43:40.821+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:43:40.821+0200 W/gpsd    ( 3103): WakeLock(Acquire,GPSD)
06-12 13:43:40.831+0200 W/gpsd    ( 3103): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
06-12 13:43:40.831+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:2, msg id:26
06-12 13:43:40.831+0200 D/gpsd_d  ( 3103): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
06-12 13:43:40.831+0200 W/gpsd    ( 3103): WakeLock(Release,GPSD)
06-12 13:43:40.831+0200 W/gpsd    ( 3103): WakeLock(Acquire,GPSD)
06-12 13:43:40.841+0200 W/gpsd    ( 3103): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
06-12 13:43:40.841+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:2, msg id:27
06-12 13:43:40.841+0200 W/gpsd    ( 3103): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
06-12 13:43:40.841+0200 W/gpsd    ( 3103): WakeLock(Release,GPSD)
06-12 13:43:40.841+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
06-12 13:43:40.841+0200 W/gpsd    ( 3103): WakeLock(Acquire,GPSD)
06-12 13:43:40.851+0200 W/gpsd    ( 3103): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
06-12 13:43:40.851+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:8
06-12 13:43:40.851+0200 W/gpsd    ( 3103): WakeLock(Release,GPSD)
06-12 13:43:40.861+0200 W/gpsd    ( 3103): WakeLock(Acquire,GPSD)
06-12 13:43:40.861+0200 W/gpsd    ( 3103): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
06-12 13:43:40.861+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:1
06-12 13:43:40.861+0200 W/gpsd    ( 3103): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
06-12 13:43:40.861+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf7586cb0), size(4)
06-12 13:43:40.861+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
06-12 13:43:40.861+0200 W/gpsd    ( 3103): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
06-12 13:43:40.861+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
06-12 13:43:40.871+0200 W/gpsd    ( 3103): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
06-12 13:43:40.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
06-12 13:43:40.871+0200 E/lhd     ( 2431): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
06-12 13:43:40.901+0200 W/AUL_AMD ( 2478): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-12 13:43:40.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
06-12 13:43:40.921+0200 W/LOCATION( 7217): location-wps.c: __update_remote_connection_status(215) > update FALSE
06-12 13:43:40.921+0200 W/LOCATION( 7217): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
06-12 13:43:41.001+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:41.001+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:41.091+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 13:43:41.091+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 13:43:41.091+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 13:43:41.091+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 13:43:41.121+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:43:41.171+0200 W/gpsd    ( 3103): CALL_SENTRY(main()): GlEngine::OnStart took 300 ms (from 2272671 to 2272971) (logOverhead=0,0,0,0,0,0,0), start: 13:43:40.875
06-12 13:43:41.171+0200 W/gpsd    ( 3103): CALL_SENTRY(main()): marshal_gps_start took 304 ms (from 2272669 to 2272973) (logOverhead=0,0,0,0,0,0,0), start: 13:43:40.873
06-12 13:43:41.171+0200 W/gpsd    ( 3103): CALL_SENTRY(main()): ProcessEvent took 305 ms (from 2272669 to 2272974) (logOverhead=0,0,0,0,0,0,0), start: 13:43:40.872
06-12 13:43:41.191+0200 I/CAPI_NETWORK_CONNECTION( 7318): connection.c: connection_create(453) > New handle created[0xf7516bc8]
06-12 13:43:41.191+0200 I/CAPI_NETWORK_CONNECTION( 7318): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
06-12 13:43:41.191+0200 I/CAPI_NETWORK_CONNECTION( 7318): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
06-12 13:43:41.191+0200 I/CAPI_NETWORK_CONNECTION( 7318): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
06-12 13:43:41.191+0200 I/CAPI_NETWORK_CONNECTION( 7318): connection.c: connection_get_type(507) > Connected Network = 2
06-12 13:43:41.201+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:41.211+0200 I/AUL     ( 7318): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 13:43:41.211+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:41.221+0200 I/AUL     ( 7318): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 13:43:41.221+0200 E/LOCATION( 7318): location-common-util.c: location_is_onboard_gps_use_only(156) > Fail to get app_id. Err[-1]
06-12 13:43:41.221+0200 E/PKGMGR_INFO( 7318): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
06-12 13:43:41.241+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 13:43:41.241+0200 E/EFL     ( 6202): ecore_x<6202> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2273045 button=1
06-12 13:43:41.241+0200 W/APPS    ( 6202): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [271, 80]
06-12 13:43:41.261+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2273.067470] pp(0x5fb9e8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:43:41.271+0200 I/AUL     ( 7318): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 13:43:41.281+0200 I/AUL     ( 7318): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 13:43:41.281+0200 E/LOCATION( 7318): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
06-12 13:43:41.281+0200 I/LOCATION( 7318): location.c: location_new(269) > method: 1
06-12 13:43:41.291+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 13:43:41.311+0200 W/LOCATION( 7318): module-internal.c: module_new(311) > module (gps) open success
06-12 13:43:41.311+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
06-12 13:43:41.321+0200 W/LOCATION( 7318): module-internal.c: module_new(311) > module (remote_gps) open success
06-12 13:43:41.321+0200 W/LOCATION( 7318): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-12 13:43:41.321+0200 W/LOCATION( 7318): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-12 13:43:41.321+0200 W/LOCATION( 7318): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-12 13:43:41.321+0200 E/EFL     ( 6202): ecore_x<6202> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2273124 button=1
06-12 13:43:41.321+0200 W/APPS    ( 6202): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [271, 80]->[272, 84]
06-12 13:43:41.321+0200 E/APPS    ( 6202): AppsViewNecklace.cpp: __GetAppsItemByTouchIndex(6919) >  Can't Find AppsItem at [-1]
06-12 13:43:41.321+0200 W/APPS    ( 6202): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[0], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[1], HideNextPage[0], ItemListSize[18]
06-12 13:43:41.321+0200 E/APPS    ( 6202): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
06-12 13:43:41.321+0200 W/APPS    ( 6202): AppsViewNecklace.cpp: onClickedRecentApps(3232) >  item(WDS_TASKMGR_BUTTON2_RECENT_APPS_ABB) launched, open(0)
06-12 13:43:41.321+0200 W/AUL     ( 6202): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-taskmanager)
06-12 13:43:41.331+0200 I/AUL     ( 7318): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 13:43:41.341+0200 I/AUL     ( 7318): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 13:43:41.341+0200 E/LOCATION( 7318): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
06-12 13:43:41.341+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:43:41.341+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:43:41.391+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:43:41.401+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:41.411+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:41.411+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
06-12 13:43:41.411+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2273216), time2(1878703)
06-12 13:43:41.411+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
06-12 13:43:41.411+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
06-12 13:43:41.411+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
06-12 13:43:41.411+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:2, msg id:25
06-12 13:43:41.431+0200 W/LOCATION( 7217): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-12 13:43:41.431+0200 I/LOCATION( 7217): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-12 13:43:41.431+0200 I/LOCATION( 7217): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-12 13:43:41.431+0200 I/location( 7217): es.ugr.frailty.location:iniciado servicio de localización
06-12 13:43:41.551+0200 I/LOCATION( 7217): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 13:43:41.591+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:41.591+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:41.601+0200 I/location( 7217): es.ugr.frailty.location: waiting for rigth values
06-12 13:43:41.791+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:41.791+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:41.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 13:43:41.921+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:43:41.921+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 13:43:41.991+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:41.991+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:42.081+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 13:43:42.091+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 13:43:42.091+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 13:43:42.091+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 13:43:42.191+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:42.191+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:42.311+0200 E/CAPI_TELEPHONY( 7318): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 13:43:42.331+0200 E/EFL     ( 2316): ecore_x<2316> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2200003 time=2273124
06-12 13:43:42.391+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:42.391+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:42.591+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:42.601+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:42.791+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:42.791+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:42.861+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 13:43:42.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:43:42.861+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 13:43:42.951+0200 W/LOCATION( 7217): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 13:43:42.991+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:42.991+0200 I/heartrate( 7215): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:43:43.091+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 13:43:43.091+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 13:43:43.091+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 13:43:43.091+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 13:43:43.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 13:43:43.191+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 13:43:43.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:43:43.191+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 13:43:43.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 13:43:43.191+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 13:43:43.191+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 13:43:43.191+0200 E/CAPI_LOCATION_MANAGER( 7318): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 13:43:43.191+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 13:43:43.201+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:43:43.341+0200 I/CAPI_NETWORK_CONNECTION( 7318): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 13:43:43.341+0200 I/CAPI_NETWORK_CONNECTION( 7318): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 13:43:43.341+0200 I/CAPI_NETWORK_CONNECTION( 7318): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 13:43:43.341+0200 I/CAPI_NETWORK_CONNECTION( 7318): connection.c: connection_destroy(471) > Destroy handle: 0xf7516bc8
06-12 13:43:43.391+0200 I/heartrate( 7215): es.ugr.frailty.heartrate - capturing data
06-12 13:43:43.391+0200 W/CRASH_MANAGER( 7328): worker.c: worker_job(1205) > 11072176c6f63152880382
