S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 26371
Date: 2018-06-07 18:07:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf768252d, r5   = 0xf78d4f98
r6   = 0xfffac670, r7   = 0xfffac520
r8   = 0xf78d1c18, r9   = 0x00000000
r10  = 0xfffac5fc, fp   = 0xfffac670
ip   = 0x00000001, sp   = 0xfffac4f8
lr   = 0xf7682539, pc   = 0xf76eb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    282032 KB
Buffers:     11284 KB
Cached:     105988 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11684 KB
VmRSS:       11684 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 26371 TID = 26371
26371 26451 

Maps Information
f454d000 f4d4c000 rw-p [stack:26451]
f4d53000 f4d55000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d5d000 f4d61000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d6a000 f4d6c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d74000 f4d77000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d86000 f4d8b000 r-xp /usr/lib/libsystem.so.0.0.0
f4d96000 f4d99000 r-xp /lib/libattr.so.1.1.0
f4da1000 f4db1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4db9000 f4dc2000 r-xp /usr/lib/libedbus.so.1.7.99
f4dca000 f4dcb000 r-xp /usr/lib/libresponse.so.0.2.96
f4dd4000 f4dd9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f667b000 f6781000 r-xp /usr/lib/libicuuc.so.57.1
f6797000 f691f000 r-xp /usr/lib/libicui18n.so.57.1
f692f000 f693c000 r-xp /usr/lib/libail.so.0.1.0
f6945000 f694c000 r-xp /usr/lib/libminizip.so.1.0.0
f6955000 f6afe000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b1e000 f6b65000 r-xp /usr/lib/libssl.so.1.0.0
f6b71000 f6b73000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b7b000 f6b82000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b8b000 f6b92000 r-xp /lib/libcrypt-2.13.so
f6bc3000 f6bc6000 r-xp /lib/libcap.so.2.21
f6bce000 f6bd0000 r-xp /usr/lib/libiri.so
f6bd8000 f6c21000 r-xp /usr/lib/libmdm.so.1.2.69
f6c29000 f6c2f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c37000 f6c5a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c64000 f6c66000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c6e000 f6c8b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c94000 f6c98000 r-xp /usr/lib/libsmack.so.1.0.0
f6ca1000 f6cba000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cc3000 f6ccb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cd3000 f6cd9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ce2000 f6ce4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ced000 f6cfd000 r-xp /lib/libresolv-2.13.so
f6d01000 f6d19000 r-xp /usr/lib/liblzma.so.5.0.3
f6d22000 f6d24000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d2c000 f6d46000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d4e000 f6d7d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d86000 f6d95000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d9f000 f6da9000 r-xp /usr/lib/libsensord-shared.so
f6db2000 f6e85000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e90000 f6ea6000 r-xp /lib/libz.so.1.2.5
f6eae000 f6eb3000 r-xp /usr/lib/libffi.so.5.0.10
f6ebb000 f6ebc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ec4000 f6ed4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6edc000 f6ef5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6efd000 f6eff000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f07000 f6f7c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f86000 f6f8c000 r-xp /lib/librt-2.13.so
f6f95000 f6fb3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fbd000 f6fbe000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fc6000 f6fe9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ff1000 f6ff6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ffe000 f7028000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7031000 f7048000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7050000 f70b9000 r-xp /lib/libm-2.13.so
f70c2000 f7156000 r-xp /usr/lib/libstdc++.so.6.0.16
f7169000 f716e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7176000 f717d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7185000 f71af000 r-xp /usr/lib/libsensor.so.1.9.6
f71b8000 f7284000 r-xp /usr/lib/libxml2.so.2.7.8
f7291000 f7293000 r-xp /usr/lib/libiniparser.so.0
f729c000 f72a2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72ab000 f737b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f737c000 f73b0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73b9000 f73f5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73fd000 f7400000 r-xp /usr/lib/libbundle.so.0.1.22
f7408000 f740e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7416000 f7457000 r-xp /usr/lib/libeina.so.1.7.99
f7460000 f7477000 r-xp /usr/lib/libecore.so.1.7.99
f748e000 f7497000 r-xp /usr/lib/libvconf.so.0.2.45
f749f000 f74b3000 r-xp /lib/libpthread-2.13.so
f74be000 f74cb000 r-xp /usr/lib/libaul.so.0.1.0
f74d5000 f74d7000 r-xp /lib/libdl-2.13.so
f74e0000 f74eb000 r-xp /lib/libunwind.so.8.0.1
f7518000 f7520000 r-xp /lib/libgcc_s-4.6.so.1
f7521000 f7645000 r-xp /lib/libc-2.13.so
f7653000 f7655000 r-xp /usr/lib/libdlog.so.0.0.0
f765d000 f7669000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7672000 f7677000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f767f000 f768e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7696000 f769a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76a3000 f76a6000 r-xp /usr/lib/libappcore-agent.so.1.1
f76ae000 f76b0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76b8000 f76bc000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76c4000 f76e1000 r-xp /lib/ld-2.13.so
f76ea000 f76ed000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76ed000 f76f1000 r-xp /usr/lib/libsys-assert.so
f78a1000 f790f000 rw-p [heap]
fff8d000 fffae000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26371)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76eb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7682539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73893f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7387c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7393e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7399be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7399dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73ce75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73c91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7387c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7393e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7399be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7399dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73cbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73cc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73d3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d6b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d5e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e31663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72defcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72e07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7470ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf746bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf746c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf746c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76a4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76a47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76eb5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf753885c) [/lib/libc.so.6] + 0x1785c
29: (0xf76eaf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ation: waiting for rigth values
06-07 18:07:00.741+0200 W/CAPI_APPFW_APP_CONTROL(26371): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 18:07:00.741+0200 I/utils   (26371): specific action
06-07 18:07:00.741+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:00:743,0.070000,0.140000,0.070000
06-07 18:07:00.741+0200 W/gpsd    ( 3111): CALL_SENTRY(main()): GlEngine::OnStart took 302 ms (from 11445216 to 11445518) (logOverhead=0,0,0,0,0,0,0), start: 18:07:00.452
06-07 18:07:00.751+0200 W/gpsd    ( 3111): CALL_SENTRY(main()): marshal_gps_start took 310 ms (from 11445210 to 11445520) (logOverhead=0,0,0,0,0,0,0), start: 18:07:00.446
06-07 18:07:00.751+0200 W/gpsd    ( 3111): CALL_SENTRY(main()): ProcessEvent took 310 ms (from 11445210 to 11445520) (logOverhead=0,0,0,0,0,0,0), start: 18:07:00.446
06-07 18:07:00.751+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:00:745,0.993697,-0.047941,9.756057
06-07 18:07:00.751+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:00:744,1995.000000
06-07 18:07:00.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:00.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:00.811+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:00.811+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:00.821+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:00:815,-0.668273,-0.016665,0.166979
06-07 18:07:00.821+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:00:819,0.325424,-0.064606,9.923036
06-07 18:07:00.851+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:00.851+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:00.911+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:00.911+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:00.921+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:00:919,-0.694594,-0.057343,0.121514
06-07 18:07:00.921+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:00:919,0.299103,-0.105284,9.877571
06-07 18:07:00.931+0200 I/light   (26413): es.ugr.frailty.light - capturing data
06-07 18:07:00.931+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:00.931+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:00.951+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:00:944,-0.070000,0.140000,1.610000
06-07 18:07:00.951+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:00:940,0.266878,-0.035993,9.802952
06-07 18:07:00.951+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:00:941,1959.000000
06-07 18:07:00.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:00.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:01.011+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.011+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.021+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:17,0.025046,-0.071684,0.110513
06-07 18:07:01.021+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:22,0.291924,-0.107677,9.913465
06-07 18:07:01.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
06-07 18:07:01.051+0200 W/libgps  ( 3131): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(11445827), time2(11068557)
06-07 18:07:01.051+0200 W/libgps  ( 3131): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
06-07 18:07:01.051+0200 W/libgps  ( 3131): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
06-07 18:07:01.051+0200 I/libgps_d( 3131): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
06-07 18:07:01.051+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:25
06-07 18:07:01.061+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:01.061+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:01.111+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.111+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.111+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:116,0.099223,-0.078863,0.096155
06-07 18:07:01.121+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:125,0.366102,-0.114855,9.899107
06-07 18:07:01.131+0200 I/light   (26413): es.ugr.frailty.light - capturing data
06-07 18:07:01.131+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.131+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.141+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:01:136,2002.000000
06-07 18:07:01.151+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:139,0.140000,0.140000,0.420000
06-07 18:07:01.151+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:137,0.301541,-0.059504,9.801832
06-07 18:07:01.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:01.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:01.211+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.221+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.221+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:221,0.002347,-0.026638,0.114024
06-07 18:07:01.241+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:228,0.303888,-0.086142,9.915856
06-07 18:07:01.261+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:01.261+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:01.301+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.311+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.321+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:317,-0.000045,-0.031424,0.135560
06-07 18:07:01.321+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:315,0.301496,-0.090927,9.937392
06-07 18:07:01.331+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.331+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.331+0200 I/light   (26413): es.ugr.frailty.light - capturing data
06-07 18:07:01.351+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:345,0.302952,-0.070755,9.801714
06-07 18:07:01.351+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:348,-0.070000,0.070000,0.070000
06-07 18:07:01.351+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:01:343,2022.000000
06-07 18:07:01.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:01.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:01.411+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.411+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.421+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:417,0.034436,-0.053672,0.106964
06-07 18:07:01.451+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:419,0.337388,-0.124427,9.908678
06-07 18:07:01.451+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:01.461+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:01.521+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.521+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.541+0200 I/light   (26413): es.ugr.frailty.light - capturing data
06-07 18:07:01.541+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.551+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:554,0.070000,0.070000,0.140000
06-07 18:07:01.551+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:01:547,2026.000000
06-07 18:07:01.551+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.561+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:528,0.044007,-0.056065,0.128501
06-07 18:07:01.561+0200 W/gpsd    ( 3111): CALL_SENTRY(main()): GlEngine::ChipData took 141 ms (from 11446192 to 11446333) (logOverhead=0,0,0,0,0,0,0), start: 18:07:01.428
06-07 18:07:01.561+0200 W/gpsd    ( 3111): CALL_SENTRY(main()): ProcessEvent took 141 ms (from 11446192 to 11446333) (logOverhead=0,0,0,0,0,0,0), start: 18:07:01.428
06-07 18:07:01.581+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:534,0.346959,-0.126820,9.930215
06-07 18:07:01.581+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:562,0.316028,-0.087569,9.801166
06-07 18:07:01.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:01.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:01.601+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:07:01.601+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:07:01.601+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:07:01.611+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.611+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.621+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:625,0.325424,-0.107677,9.913465
06-07 18:07:01.621+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:620,0.009396,-0.020108,0.112299
06-07 18:07:01.631+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.631+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.631+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.641+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:643,-0.004961,-0.041643,0.069228
06-07 18:07:01.641+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:644,0.314680,-0.090004,9.801187
06-07 18:07:01.641+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:637,0.140000,0.070000,0.070000
06-07 18:07:01.641+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.651+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.651+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.651+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:659,0.140000,0.070000,0.070000
06-07 18:07:01.651+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.651+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:01.651+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:01.661+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:653,0.311067,-0.129212,9.870394
06-07 18:07:01.661+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:660,0.313957,-0.091526,9.801196
06-07 18:07:01.661+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.661+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:664,-0.003613,-0.039208,0.100314
06-07 18:07:01.661+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:669,0.311067,-0.129212,9.901501
06-07 18:07:01.671+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.671+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:677,0.140000,0.070000,0.070000
06-07 18:07:01.671+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.681+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.681+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.681+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:686,0.366102,-0.076570,9.879964
06-07 18:07:01.681+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:681,0.313211,-0.092949,9.801207
06-07 18:07:01.681+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:686,0.052145,0.014956,0.078768
06-07 18:07:01.691+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.691+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.691+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:698,0.070000,0.070000,0.070000
06-07 18:07:01.701+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:703,0.314811,-0.092005,9.801164
06-07 18:07:01.701+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.701+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.701+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:710,0.306281,-0.076570,9.901501
06-07 18:07:01.711+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.711+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.711+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:717,0.313805,-0.091033,9.801206
06-07 18:07:01.711+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.711+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:718,0.342174,-0.095713,9.899107
06-07 18:07:01.721+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:722,0.070000,0.070000,0.070000
06-07 18:07:01.721+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:710,-0.006929,0.016379,0.100294
06-07 18:07:01.721+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.721+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:730,0.027363,-0.003708,0.097943
06-07 18:07:01.731+0200 I/light   (26413): es.ugr.frailty.light - capturing data
06-07 18:07:01.731+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.731+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.741+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.741+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:742,0.314519,-0.091041,9.801182
06-07 18:07:01.741+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:747,-0.026667,-0.021430,0.033296
06-07 18:07:01.741+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:743,0.287139,-0.112463,9.834501
06-07 18:07:01.741+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.741+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:01:739,2029.000000
06-07 18:07:01.751+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.751+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:759,0.318245,-0.076570,9.882358
06-07 18:07:01.751+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.751+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.761+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:763,0.312797,-0.091916,9.801229
06-07 18:07:01.761+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:763,0.003727,0.014471,0.081176
06-07 18:07:01.761+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:754,0.070000,0.070000,0.070000
06-07 18:07:01.761+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.761+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:770,0.070000,0.070000,0.070000
06-07 18:07:01.771+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.771+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.771+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.771+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:779,0.291924,-0.078963,9.877571
06-07 18:07:01.771+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.781+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:779,-0.020873,0.012953,0.076342
06-07 18:07:01.781+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:778,0.070000,0.070000,0.140000
06-07 18:07:01.781+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:784,0.312429,-0.090969,9.801250
06-07 18:07:01.791+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:01.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:01.791+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.791+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.791+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:801,0.325424,-0.110070,9.870394
06-07 18:07:01.801+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.801+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:801,0.310681,-0.090023,9.801314
06-07 18:07:01.801+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:798,0.012995,-0.019101,0.069144
06-07 18:07:01.801+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:806,0.140000,0.070000,0.070000
06-07 18:07:01.811+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.811+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:818,0.310688,-0.090616,9.801309
06-07 18:07:01.811+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.811+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.821+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.821+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:822,0.012350,0.003882,0.064294
06-07 18:07:01.821+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:823,0.323031,-0.086142,9.865608
06-07 18:07:01.821+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:826,0.140000,0.070000,0.070000
06-07 18:07:01.831+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.831+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.831+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.841+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:842,0.038664,0.023617,0.100192
06-07 18:07:01.841+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.841+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:838,0.310701,-0.090200,9.801311
06-07 18:07:01.841+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:842,0.349352,-0.066999,9.901501
06-07 18:07:01.841+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:847,0.070000,0.070000,0.070000
06-07 18:07:01.851+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.851+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.851+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:858,0.311659,-0.088913,9.801293
06-07 18:07:01.851+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.851+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:859,0.029079,0.035165,0.085832
06-07 18:07:01.851+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.851+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:01.851+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:01.861+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:863,0.070000,0.070000,0.070000
06-07 18:07:01.861+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:865,0.339781,-0.055035,9.887143
06-07 18:07:01.871+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.871+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.871+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:880,0.312143,-0.087113,9.801294
06-07 18:07:01.871+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.871+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.881+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:879,0.035300,0.005165,0.057136
06-07 18:07:01.881+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:885,0.346959,-0.083749,9.858429
06-07 18:07:01.881+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:885,0.070000,0.070000,0.070000
06-07 18:07:01.891+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.891+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.891+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:898,0.313140,-0.086770,9.801265
06-07 18:07:01.891+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.891+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:01.891+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:897,0.032424,-0.013385,0.090634
06-07 18:07:01.901+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:906,0.070000,0.070000,0.070000
06-07 18:07:01.911+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:01:904,0.344566,-0.100499,9.891929
06-07 18:07:01.911+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.911+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.921+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:918,0.002712,0.017378,0.078699
06-07 18:07:01.921+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:01.921+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:918,0.314072,-0.087208,9.801231
06-07 18:07:01.961+0200 I/light   (26413): es.ugr.frailty.light - capturing data
06-07 18:07:01.961+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:01.971+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:01:966,2031.000000
06-07 18:07:01.981+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:01.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:01.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:01.991+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.001+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:01:975,0.020923,0.032174,0.119411
06-07 18:07:02.021+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.021+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:01:934,0.070000,0.070000,0.070000
06-07 18:07:02.021+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.021+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:01:986,0.313545,-0.086144,9.801258
06-07 18:07:02.021+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:30,0.070000,0.070000,0.070000
06-07 18:07:02.031+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.031+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:36,0.070000,0.070000,0.070000
06-07 18:07:02.031+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.041+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.041+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:3,0.315853,-0.069392,9.879964
06-07 18:07:02.041+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.051+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:26,0.002308,0.026323,0.076313
06-07 18:07:02.061+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:02.061+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:41,0.070000,0.070000,0.070000
06-07 18:07:02.061+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.071+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:02.071+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:75,0.070000,0.070000,0.070000
06-07 18:07:02.071+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.081+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.081+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:84,0.070000,0.070000,0.070000
06-07 18:07:02.081+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.091+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:91,-0.070000,0.070000,0.070000
06-07 18:07:02.091+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.091+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:47,0.313727,-0.084455,9.801267
06-07 18:07:02.091+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:98,0.070000,0.070000,0.070000
06-07 18:07:02.091+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.091+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:54,0.334995,-0.055035,9.920642
06-07 18:07:02.091+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.101+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:103,0.070000,0.070000,0.070000
06-07 18:07:02.101+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.101+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.101+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:92,-0.007446,0.000706,0.064342
06-07 18:07:02.111+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:109,0.070000,0.070000,0.070000
06-07 18:07:02.111+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.111+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.111+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:119,0.070000,0.070000,0.070000
06-07 18:07:02.121+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:104,0.313194,-0.083064,9.801295
06-07 18:07:02.121+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:113,0.315853,-0.059821,9.877571
06-07 18:07:02.121+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.131+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.131+0200 I/light   (26413): es.ugr.frailty.light - capturing data
06-07 18:07:02.131+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.141+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:02:138,2030.000000
06-07 18:07:02.141+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:144,0.140000,0.070000,0.070000
06-07 18:07:02.141+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:126,0.005052,-0.027006,0.085848
06-07 18:07:02.151+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.151+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.151+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:159,0.070000,0.070000,0.070000
06-07 18:07:02.161+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:134,0.312331,-0.082900,9.801325
06-07 18:07:02.161+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.161+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:158,0.017879,0.003937,0.064283
06-07 18:07:02.161+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:169,0.312164,-0.083979,9.801321
06-07 18:07:02.161+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:151,0.306281,-0.083749,9.865608
06-07 18:07:02.171+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.171+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:179,0.070000,0.070000,0.070000
06-07 18:07:02.171+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.181+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.181+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.181+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:183,0.318245,-0.110070,9.887143
06-07 18:07:02.191+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:02.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:02.191+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:194,0.312962,-0.083851,9.801296
06-07 18:07:02.191+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.201+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:187,0.010867,-0.018912,0.095393
06-07 18:07:02.201+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:198,0.070000,0.070000,0.070000
06-07 18:07:02.201+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.211+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.221+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.231+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:205,0.330210,-0.078963,9.865608
06-07 18:07:02.241+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.241+0200 W/LOCATION(26371): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 18:07:02.241+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:215,0.048354,-0.028612,0.109776
06-07 18:07:02.241+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.241+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:234,0.312927,-0.084540,9.801291
06-07 18:07:02.241+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:219,0.070000,0.070000,0.070000
06-07 18:07:02.251+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.251+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.251+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:246,0.323031,-0.102891,9.896714
06-07 18:07:02.261+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:02.261+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:02.261+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:261,0.314723,-0.085620,9.801225
06-07 18:07:02.261+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.261+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:259,0.070000,0.070000,0.070000
06-07 18:07:02.261+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:253,0.012497,0.005576,0.076280
06-07 18:07:02.261+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.271+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.271+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:274,0.070000,0.070000,0.070000
06-07 18:07:02.271+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.281+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.281+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:281,0.008308,0.016229,0.057204
06-07 18:07:02.281+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:271,0.361316,-0.112463,9.911072
06-07 18:07:02.281+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.281+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.291+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:288,-0.070000,0.070000,0.070000
06-07 18:07:02.291+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:285,0.314631,-0.085101,9.801232
06-07 18:07:02.291+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.291+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.301+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:303,-0.070000,0.070000,0.070000
06-07 18:07:02.301+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:291,0.325424,-0.078963,9.877571
06-07 18:07:02.301+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.301+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:305,0.314436,-0.084157,9.801247
06-07 18:07:02.301+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:295,-0.008350,0.013317,0.059590
06-07 18:07:02.311+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.311+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.311+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:319,-0.070000,0.070000,0.070000
06-07 18:07:02.311+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.321+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:314,0.323031,-0.069392,9.858429
06-07 18:07:02.321+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:322,0.003809,0.009979,0.090682
06-07 18:07:02.321+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:324,0.313233,-0.083211,9.801293
06-07 18:07:02.321+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.321+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:331,0.306281,-0.071785,9.860823
06-07 18:07:02.321+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.331+0200 I/light   (26413): es.ugr.frailty.light - capturing data
06-07 18:07:02.331+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.331+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.341+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.341+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:340,0.070000,0.070000,0.070000
06-07 18:07:02.341+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:02:338,2031.000000
06-07 18:07:02.341+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:335,0.000227,-0.007716,0.112171
06-07 18:07:02.341+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.341+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:351,0.007784,0.006002,0.116939
06-07 18:07:02.351+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:344,0.312854,-0.082572,9.801311
06-07 18:07:02.351+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.351+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.351+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:347,0.318245,-0.074178,9.891929
06-07 18:07:02.351+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:359,0.070000,0.070000,0.070000
06-07 18:07:02.351+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.361+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.361+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:361,0.312290,-0.082754,9.801327
06-07 18:07:02.371+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.371+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.371+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:364,0.313460,-0.090927,9.913465
06-07 18:07:02.371+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:381,0.070000,0.070000,0.070000
06-07 18:07:02.381+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.381+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:371,0.020312,-0.024923,0.064281
06-07 18:07:02.381+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:379,0.312030,-0.082243,9.801339
06-07 18:07:02.381+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.391+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.391+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.391+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:386,0.320638,-0.076570,9.918249
06-07 18:07:02.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:02.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:02.391+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:399,0.070000,0.070000,0.070000
06-07 18:07:02.391+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:392,0.020572,0.000887,0.073840
06-07 18:07:02.391+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.401+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.401+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:404,0.332602,-0.107677,9.865608
06-07 18:07:02.411+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.411+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:400,0.312581,-0.083239,9.801313
06-07 18:07:02.411+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.411+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:418,0.070000,0.070000,-0.070000
06-07 18:07:02.421+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.421+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:415,0.051128,-0.031616,0.102580
06-07 18:07:02.421+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:07:02.431+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:07:02.431+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:07:02.431+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:422,0.312925,-0.082953,9.801305
06-07 18:07:02.431+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.441+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.441+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:447,0.070000,0.070000,0.070000
06-07 18:07:02.451+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.451+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:459,0.070000,0.070000,0.070000
06-07 18:07:02.451+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:02.461+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:02.461+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.461+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:467,0.314884,-0.084217,9.801231
06-07 18:07:02.461+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:427,0.332602,-0.081356,9.875179
06-07 18:07:02.471+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.471+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:439,0.007713,-0.012760,0.095409
06-07 18:07:02.471+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.481+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.481+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:484,0.363709,-0.114855,9.903893
06-07 18:07:02.481+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.481+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:480,0.070000,0.070000,0.070000
06-07 18:07:02.491+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.501+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:487,-0.003817,0.017218,0.114625
06-07 18:07:02.501+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.501+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.511+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:496,0.315152,-0.084856,9.801217
06-07 18:07:02.511+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.521+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:502,0.140000,0.070000,0.070000
06-07 18:07:02.521+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.521+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:511,0.320638,-0.095713,9.896714
06-07 18:07:02.521+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.521+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:517,0.017450,-0.003679,0.066783
06-07 18:07:02.531+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.531+0200 I/light   (26413): es.ugr.frailty.light - capturing data
06-07 18:07:02.541+0200 I/light   (26413): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:02:539,2031.000000
06-07 18:07:02.551+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:523,0.314899,-0.084085,9.801232
06-07 18:07:02.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 18:07:02.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 18:07:02.611+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.621+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:528,0.140000,0.070000,0.070000
06-07 18:07:02.621+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:558,-0.022975,0.050586,0.088304
06-07 18:07:02.621+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.621+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:535,0.311067,-0.066999,9.915856
06-07 18:07:02.621+0200 I/gravity (26387): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:02:627,0.315744,-0.084403,9.801202
06-07 18:07:02.631+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.631+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:02.641+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:02:636,0.140000,0.070000,0.070000
06-07 18:07:02.641+0200 I/gravity (26387): es.ugr.frailty.gravity - capturing data
06-07 18:07:02.651+0200 I/gyroscope(26351): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:02.651+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:02:640,0.332602,-0.088534,9.868000
06-07 18:07:02.651+0200 I/accelerometer(26344): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:02.651+0200 I/linearacceleration(26383): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:02:645,0.002502,-0.020881,0.085941
06-07 18:07:02.661+0200 I/heartrate(26362): es.ugr.frailty.heartrate - capturing data
06-07 18:07:02.661+0200 I/heartrate(26362): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:02.661+0200 W/CRASH_MANAGER(26455): worker.c: worker_job(1205) > 11263716c6f63152838762
