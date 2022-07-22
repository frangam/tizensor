S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13660
Date: 2018-06-12 14:54:40+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76da52d, r5   = 0xf77ce150
r6   = 0xffe98370, r7   = 0xffe98220
r8   = 0xf77e0c18, r9   = 0x00000000
r10  = 0xffe982fc, fp   = 0xffe98370
ip   = 0x00000001, sp   = 0xffe981f8
lr   = 0xf76da539, pc   = 0xf7743228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    160852 KB
Buffers:     35556 KB
Cached:     146492 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11792 KB
VmRSS:       11792 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13660 TID = 13660
13660 13743 

Maps Information
f45a5000 f4da4000 rw-p [stack:13743]
f4dab000 f4dad000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4db5000 f4db9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dc2000 f4dc4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dcc000 f4dcf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dde000 f4de3000 r-xp /usr/lib/libsystem.so.0.0.0
f4dee000 f4df1000 r-xp /lib/libattr.so.1.1.0
f4df9000 f4e09000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e11000 f4e1a000 r-xp /usr/lib/libedbus.so.1.7.99
f4e22000 f4e23000 r-xp /usr/lib/libresponse.so.0.2.96
f4e2c000 f4e31000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66d3000 f67d9000 r-xp /usr/lib/libicuuc.so.57.1
f67ef000 f6977000 r-xp /usr/lib/libicui18n.so.57.1
f6987000 f6994000 r-xp /usr/lib/libail.so.0.1.0
f699d000 f69a4000 r-xp /usr/lib/libminizip.so.1.0.0
f69ad000 f6b56000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b76000 f6bbd000 r-xp /usr/lib/libssl.so.1.0.0
f6bc9000 f6bcb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bd3000 f6bda000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6be3000 f6bea000 r-xp /lib/libcrypt-2.13.so
f6c1b000 f6c1e000 r-xp /lib/libcap.so.2.21
f6c26000 f6c28000 r-xp /usr/lib/libiri.so
f6c30000 f6c79000 r-xp /usr/lib/libmdm.so.1.2.69
f6c81000 f6c87000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c8f000 f6cb2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cbc000 f6cbe000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cc6000 f6ce3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cec000 f6cf0000 r-xp /usr/lib/libsmack.so.1.0.0
f6cf9000 f6d12000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d1b000 f6d23000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d2b000 f6d31000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d3a000 f6d3c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d45000 f6d55000 r-xp /lib/libresolv-2.13.so
f6d59000 f6d71000 r-xp /usr/lib/liblzma.so.5.0.3
f6d7a000 f6d7c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d84000 f6d9e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6da6000 f6dd5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dde000 f6ded000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6df7000 f6e01000 r-xp /usr/lib/libsensord-shared.so
f6e0a000 f6edd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ee8000 f6efe000 r-xp /lib/libz.so.1.2.5
f6f06000 f6f0b000 r-xp /usr/lib/libffi.so.5.0.10
f6f13000 f6f14000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f1c000 f6f2c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f34000 f6f4d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f55000 f6f57000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f5f000 f6fd4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fde000 f6fe4000 r-xp /lib/librt-2.13.so
f6fed000 f700b000 r-xp /usr/lib/libsystemd.so.0.4.0
f7015000 f7016000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f701e000 f7041000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7049000 f704e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7056000 f7080000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7089000 f70a0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70a8000 f7111000 r-xp /lib/libm-2.13.so
f711a000 f71ae000 r-xp /usr/lib/libstdc++.so.6.0.16
f71c1000 f71c6000 r-xp /usr/lib/libctx-client.so.0.8.3
f71ce000 f71d5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71dd000 f7207000 r-xp /usr/lib/libsensor.so.1.9.6
f7210000 f72dc000 r-xp /usr/lib/libxml2.so.2.7.8
f72e9000 f72eb000 r-xp /usr/lib/libiniparser.so.0
f72f4000 f72fa000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7303000 f73d3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73d4000 f7408000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7411000 f744d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7455000 f7458000 r-xp /usr/lib/libbundle.so.0.1.22
f7460000 f7466000 r-xp /usr/lib/libappsvc.so.0.1.0
f746e000 f74af000 r-xp /usr/lib/libeina.so.1.7.99
f74b8000 f74cf000 r-xp /usr/lib/libecore.so.1.7.99
f74e6000 f74ef000 r-xp /usr/lib/libvconf.so.0.2.45
f74f7000 f750b000 r-xp /lib/libpthread-2.13.so
f7516000 f7523000 r-xp /usr/lib/libaul.so.0.1.0
f752d000 f752f000 r-xp /lib/libdl-2.13.so
f7538000 f7543000 r-xp /lib/libunwind.so.8.0.1
f7570000 f7578000 r-xp /lib/libgcc_s-4.6.so.1
f7579000 f769d000 r-xp /lib/libc-2.13.so
f76ab000 f76ad000 r-xp /usr/lib/libdlog.so.0.0.0
f76b5000 f76c1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76ca000 f76cf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76d7000 f76e6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76ee000 f76f2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76fb000 f76fe000 r-xp /usr/lib/libappcore-agent.so.1.1
f7706000 f7708000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7710000 f7714000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f771c000 f7739000 r-xp /lib/ld-2.13.so
f7742000 f7745000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7745000 f7749000 r-xp /usr/lib/libsys-assert.so
f77b0000 f781e000 rw-p [heap]
ffe79000 ffe9a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13660)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7743228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76da539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73e13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73dfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73ebe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73f1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73f1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf742675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74211f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73dfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73ebe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73f1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73f1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7423e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7424017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf742bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4dc31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4db6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e89663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7336fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73387a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74c8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74c3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74c45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74c4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76fc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76fc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77435c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf759085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7742f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
rvicemanager
06-12 14:54:40.131+0200 I/linearacceleration(13676): es.ugr.frailty.linearacceleration - capturing data
06-12 14:54:40.131+0200 I/servicemanager(13633): request sent to service es.ugr.frailty.recorder
06-12 14:54:40.131+0200 I/servicemanager(13633): requesting to save local data
06-12 14:54:40.131+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.141+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.141+0200 I/light   (13694): es.ugr.frailty.light: SM-R760,12/06/2018,14:54:39:943,84.000000
06-12 14:54:40.141+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.141+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.141+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.141+0200 W/CAPI_APPFW_APP_CONTROL(13633): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.141+0200 I/utils   (13633): specific action
06-12 14:54:40.141+0200 I/servicemanager(13633): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:54:40.141+0200 W/AUL     (13633): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:54:40.141+0200 W/AUL     (13640): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:40.141+0200 I/accelerometer(13640): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:40.141+0200 I/accelerometer(13640): es.ugr.frailty.accelerometer - capturing data
06-12 14:54:40.151+0200 W/AUL     (13694): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.151+0200 I/accelerometer(13640): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:54:40:152,-0.143569,9.786645,0.827917
06-12 14:54:40.151+0200 W/AUL     (13640): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.151+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13680
06-12 14:54:40.161+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:40.171+0200 W/AUL     (13680): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:40.171+0200 I/gravity (13680): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:40.171+0200 I/gravity (13680): es.ugr.frailty.gravity - capturing data
06-12 14:54:40.181+0200 I/gravity (13680): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:54:40:181,-0.129635,9.770968,0.825686
06-12 14:54:40.181+0200 W/AUL     (13680): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.181+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:40.181+0200 I/linearacceleration(13676): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:54:40:140,0.012173,0.014100,-0.015226
06-12 14:54:40.181+0200 W/AUL     (13676): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.201+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-12 14:54:40.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13643
06-12 14:54:40.211+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-12 14:54:40.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:40.221+0200 W/SHealthCommon( 6349): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1528761600000,000000[0;m
06-12 14:54:40.231+0200 W/AUL     (13643): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:40.231+0200 I/gyroscope(13643): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:40.231+0200 I/gyroscope(13643): es.ugr.frailty.gyroscope - capturing data
06-12 14:54:40.231+0200 I/gyroscope(13643): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:54:40:238,-1.050000,0.700000,-4.340000
06-12 14:54:40.231+0200 W/AUL     (13643): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.241+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:40.241+0200 W/SHealthCommon( 6349): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
06-12 14:54:40.251+0200 I/HealthDataService( 6231): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-12 14:54:40.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface-service)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.wusvc)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (health-data-service)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.weip.consumer)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-home)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.alti-barometer-widget)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth-service)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth.widget.pedometer)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-player.music-control-service)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-transfer.consumer)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.recorder)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.heartrate)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.location)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.gravity)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.light)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.pedometer)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.recorder)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.accelerometer)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.gyroscope)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.heartrate)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.location)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.linearacceleration)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.gravity)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.pressure)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.light)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.pedometer)!!
06-12 14:54:40.261+0200 E/W_TASKMANAGER(13585): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-taskmanager)!!
06-12 14:54:40.271+0200 W/healthData( 6251): health_fw_share.c: __health_notify_share_cb(331) > [1;40;33mNotification is called [category:shealth_pedometer_info][0;m
06-12 14:54:40.281+0200 I/healthData( 6349): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-12 14:54:40.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13633
06-12 14:54:40.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13637
06-12 14:54:40.301+0200 W/CAPI_APPFW_APP_CONTROL(13637): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.301+0200 I/utils   (13637): specific action
06-12 14:54:40.301+0200 W/CAPI_APPFW_APP_CONTROL(13637): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.301+0200 I/recorder(13637): saving local data for es.ugr.frailty.accelerometer
06-12 14:54:40.301+0200 I/recorder(13637): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:54:40.311+0200 W/AUL     (13633): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13637)
06-12 14:54:40.311+0200 I/servicemanager(13633): request sent to service es.ugr.frailty.recorder
06-12 14:54:40.311+0200 I/servicemanager(13633): requesting to save local data
06-12 14:54:40.311+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.311+0200 W/CAPI_APPFW_APP_CONTROL(13633): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.311+0200 I/utils   (13633): specific action
06-12 14:54:40.311+0200 W/CAPI_APPFW_APP_CONTROL(13633): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.311+0200 I/servicemanager(13633): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:54:40.311+0200 W/AUL     (13633): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:54:40.331+0200 I/heartrate(13644): es.ugr.frailty.heartrate - capturing data
06-12 14:54:40.331+0200 I/heartrate(13644): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:54:40.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13694
06-12 14:54:40.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:40.361+0200 W/AUL     (13694): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:40.361+0200 I/light   (13694): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:40.361+0200 I/light   (13694): es.ugr.frailty.light - capturing data
06-12 14:54:40.361+0200 I/light   (13694): es.ugr.frailty.light: SM-R760,12/06/2018,14:54:40:368,88.000000
06-12 14:54:40.371+0200 W/AUL     (13694): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.371+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:54:40.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(47) , send fd(21), pid(13633), cmd(0)
06-12 14:54:40.371+0200 E/RUA     (13585): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 30, ncols : 5
06-12 14:54:40.381+0200 E/EFL     (13585): evas_main<13585> evas_stack.c:158 evas_object_stack_above() BITCH! evas_object_stack_above(), 0xf77abb90 not inside same smart as 0xf772d148!
06-12 14:54:40.381+0200 E/EFL     (13585): elementary<13585> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0xf7707498 into part 'elm.swallow.event.0'
06-12 14:54:40.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:54:40.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(40) , send fd(21), pid(13637), cmd(0)
06-12 14:54:40.421+0200 W/W_HOME  ( 6202): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
06-12 14:54:40.421+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 14:54:40.421+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 14:54:40.421+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 14:54:40.421+0200 W/W_HOME  ( 6202): win.c: win_back_gesture_disable_set(173) > enable back gesture
06-12 14:54:40.421+0200 W/W_HOME  ( 6202): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
06-12 14:54:40.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13640
06-12 14:54:40.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:40.441+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.245769] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.461+0200 W/W_INDICATOR( 2694): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-12 14:54:40.461+0200 W/W_INDICATOR( 2694): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-12 14:54:40.471+0200 W/AUL     (13640): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:40.471+0200 I/accelerometer(13640): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:40.471+0200 I/accelerometer(13640): es.ugr.frailty.accelerometer - capturing data
06-12 14:54:40.471+0200 I/accelerometer(13640): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:54:40:475,-0.174676,9.796216,0.904487
06-12 14:54:40.471+0200 W/LOCATION(13660): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:54:40.481+0200 W/AUL     (13640): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.501+0200 I/APP_CORE(13585): appcore-efl.c: __do_app(453) > [APP 13585] Event: RESET State: CREATED
06-12 14:54:40.501+0200 I/CAPI_APPFW_APPLICATION(13585): app_main.c: app_appcore_reset(245) > app_appcore_reset
06-12 14:54:40.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13680
06-12 14:54:40.521+0200 I/APP_CORE(13585): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-12 14:54:40.521+0200 I/APP_CORE(13585): appcore-efl.c: __do_app(524) > [APP 13585] Initial Launching, call the resume_cb
06-12 14:54:40.521+0200 I/CAPI_APPFW_APPLICATION(13585): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-12 14:54:40.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:40.531+0200 W/APP_CORE(13585): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00003
06-12 14:54:40.551+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:40.551+0200 W/AUL     (13680): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:40.561+0200 I/gravity (13680): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:40.561+0200 I/gravity (13680): es.ugr.frailty.gravity - capturing data
06-12 14:54:40.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.571+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13676
06-12 14:54:40.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:40.591+0200 I/gravity (13680): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:54:40:574,-0.126071,9.770789,0.828359
06-12 14:54:40.591+0200 W/AUL     (13680): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.611+0200 I/heartrate(13644): es.ugr.frailty.heartrate - capturing data
06-12 14:54:40.611+0200 W/AUL     (13676): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:40.611+0200 I/linearacceleration(13676): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:40.611+0200 I/linearacceleration(13676): es.ugr.frailty.linearacceleration - capturing data
06-12 14:54:40.611+0200 I/heartrate(13644): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:54:40.611+0200 I/linearacceleration(13676): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:54:40:616,0.040888,0.018885,-0.005655
06-12 14:54:40.611+0200 W/AUL     (13676): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.631+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.436381] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.631+0200 W/W_HOME  ( 6202): event_manager.c: _window_visibility_cb(466) > Window [0x2200003] is now visible(1)
06-12 14:54:40.631+0200 W/W_HOME  ( 6202): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
06-12 14:54:40.631+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 14:54:40.631+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 14:54:40.631+0200 W/W_HOME  ( 6202): main.c: _window_visibility_cb(964) > Window [0x2200003] is now visible(1)
06-12 14:54:40.641+0200 I/APP_CORE( 6202): appcore-efl.c: __do_app(453) > [APP 6202] Event: PAUSE State: RUNNING
06-12 14:54:40.641+0200 I/CAPI_APPFW_APPLICATION( 6202): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-12 14:54:40.641+0200 W/W_HOME  ( 6202): main.c: _appcore_pause_cb(488) > appcore pause
06-12 14:54:40.641+0200 W/W_HOME  ( 6202): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-12 14:54:40.641+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 14:54:40.641+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 14:54:40.641+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 14:54:40.641+0200 W/W_HOME  ( 6202): rotary.c: rotary_deattach(156) > rotary_deattach:0xed639d80
06-12 14:54:40.641+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-12 14:54:40.641+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xed639d80, elm_layout, func : 0xf5a6bd05
06-12 14:54:40.641+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-12 14:54:40.641+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-12 14:54:40.641+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-12 14:54:40.641+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf77d0238, elm_box, _activated_obj : 0xed639d80, activated : 1
06-12 14:54:40.641+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-12 14:54:40.641+0200 E/wnotib  ( 6202): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-12 14:54:40.641+0200 I/wnotib  ( 6202): w-notification-board-basic-panel.c: _wnb_bp_is_key_event_passed(5857) > Return true for 33, -13.
06-12 14:54:40.641+0200 I/wnotib  ( 6202): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
06-12 14:54:40.641+0200 I/APP_CORE(13585): appcore-efl.c: __do_app(453) > [APP 13585] Event: RESUME State: RUNNING
06-12 14:54:40.651+0200 W/STARTER ( 2679): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[6202] goes to (4)
06-12 14:54:40.651+0200 E/STARTER ( 2679): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 6202)'s state(4)
06-12 14:54:40.651+0200 W/STARTER ( 2679): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[13585] goes to (3)
06-12 14:54:40.661+0200 W/W_HOME  ( 6202): win.c: win_back_gesture_disable_set(173) > enable back gesture
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 14:54:40.671+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 14:54:40.671+0200 I/wnotib  ( 6202): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
06-12 14:54:40.671+0200 E/wnotib  ( 6202): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-12 14:54:40.671+0200 W/wnotib  ( 6202): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [1].
06-12 14:54:40.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13643
06-12 14:54:40.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:40.681+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.486479] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.701+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.503970] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.701+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:54:40.701+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:40.701+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:40.711+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:54:40.711+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:54:40.711+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:54:40.711+0200 E/CAPI_APPFW_APP_CONTROL( 6531): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 14:54:40.711+0200 W/AUL     (13643): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:40.711+0200 I/gyroscope(13643): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:40.711+0200 I/gyroscope(13643): es.ugr.frailty.gyroscope - capturing data
06-12 14:54:40.711+0200 W/MUSIC_CONTROL_SERVICE( 6531): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:6531]   [com.samsung.w-home]register msg port [false][0m
06-12 14:54:40.711+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.519876] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.721+0200 W/W_INDICATOR( 2694): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-12 14:54:40.721+0200 I/gyroscope(13643): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:54:40:721,-0.280000,0.280000,-1.190000
06-12 14:54:40.721+0200 W/W_INDICATOR( 2694): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-12 14:54:40.721+0200 W/AUL     (13643): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:40.731+0200 W/APPS    ( 6202): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
06-12 14:54:40.731+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.536665] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.741+0200 I/heartrate(13644): es.ugr.frailty.heartrate - capturing data
06-12 14:54:40.741+0200 I/heartrate(13644): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:54:40.751+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.553405] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.761+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13633
06-12 14:54:40.771+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.570228] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.771+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13637
06-12 14:54:40.781+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.586852] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.801+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(6202) status(bg) type(uiapp)
06-12 14:54:40.801+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:40.801+0200 W/AUL     (13633): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13637)
06-12 14:54:40.801+0200 W/CAPI_APPFW_APP_CONTROL(13637): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.801+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.603514] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.801+0200 I/servicemanager(13633): request sent to service es.ugr.frailty.recorder
06-12 14:54:40.801+0200 I/servicemanager(13633): requesting to save local data
06-12 14:54:40.801+0200 I/utils   (13637): specific action
06-12 14:54:40.801+0200 W/CAPI_APPFW_APP_CONTROL(13637): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.801+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.801+0200 W/CAPI_APPFW_APP_CONTROL(13637): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.801+0200 I/recorder(13637): saving local data for es.ugr.frailty.gyroscope
06-12 14:54:40.801+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.801+0200 I/recorder(13637): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:54:40.801+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.801+0200 E/AUL     (13633): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:54:40.801+0200 W/CAPI_APPFW_APP_CONTROL(13633): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.801+0200 I/utils   (13633): specific action
06-12 14:54:40.801+0200 W/CAPI_APPFW_APP_CONTROL(13633): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:54:40.801+0200 I/servicemanager(13633): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:54:40.801+0200 W/AUL     (13633): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:54:40.821+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.620289] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13694
06-12 14:54:40.831+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.636859] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:40.851+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.653611] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.871+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.670977] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.871+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(13585) status(fg) type(uiapp)
06-12 14:54:40.871+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:54:40.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(51) , send fd(21), pid(13633), cmd(0)
06-12 14:54:40.881+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.688245] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.881+0200 W/AUL     (13694): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:40.901+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.703631] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.911+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:54:40.911+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(46) , send fd(21), pid(13637), cmd(0)
06-12 14:54:40.921+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.722755] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13640
06-12 14:54:40.931+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.737788] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:40.961+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.762679] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.971+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.770638] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.981+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.787884] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:40.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:40.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13680
06-12 14:54:41.001+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.803966] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:41.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:41.011+0200 W/AUL     (13640): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:41.011+0200 I/heartrate(13644): es.ugr.frailty.heartrate - capturing data
06-12 14:54:41.011+0200 I/heartrate(13644): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:54:41.011+0200 I/accelerometer(13640): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:41.011+0200 I/light   (13694): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:41.011+0200 I/accelerometer(13640): es.ugr.frailty.accelerometer - capturing data
06-12 14:54:41.011+0200 I/light   (13694): es.ugr.frailty.light - capturing data
06-12 14:54:41.021+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.820627] pp(0x5675f8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:41.021+0200 W/AUL     (13680): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:41.021+0200 I/gravity (13680): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:41.021+0200 I/gravity (13680): es.ugr.frailty.gravity - capturing data
06-12 14:54:41.031+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.837400] pp(0x56bea8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:41.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:41.051+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.854086] pp(0x56bea8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:41.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13676
06-12 14:54:41.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:41.071+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [6532.870747] pp(0x56bea8) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 14:54:41.071+0200 W/AUL     (13676): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:41.071+0200 I/linearacceleration(13676): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:41.071+0200 I/linearacceleration(13676): es.ugr.frailty.linearacceleration - capturing data
06-12 14:54:41.081+0200 I/linearacceleration(13676): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:54:41:82,0.013775,0.036831,0.035266
06-12 14:54:41.081+0200 W/AUL     (13676): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:54:41.081+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:41.101+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:54:41.101+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:54:41.101+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:54:41.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:41.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13643
06-12 14:54:41.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:41.161+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 14:54:41.161+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 14:54:41.161+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:54:41.161+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 14:54:41.161+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 14:54:41.161+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 14:54:41.161+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 14:54:41.161+0200 E/CAPI_LOCATION_MANAGER(13747): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 14:54:41.161+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 14:54:41.171+0200 I/APP_CORE( 6202): appcore-efl.c: __do_app(453) > [APP 6202] Event: MEM_FLUSH State: PAUSED
06-12 14:54:41.171+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:41.181+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:54:41.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:41.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13633
06-12 14:54:41.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13637
06-12 14:54:41.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:41.231+0200 W/AUL     (13643): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:41.241+0200 I/heartrate(13644): es.ugr.frailty.heartrate - capturing data
06-12 14:54:41.241+0200 I/heartrate(13644): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:54:41.251+0200 I/CAPI_NETWORK_CONNECTION(13747): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 14:54:41.251+0200 I/CAPI_NETWORK_CONNECTION(13747): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 14:54:41.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:54:41.251+0200 I/CAPI_NETWORK_CONNECTION(13747): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 14:54:41.251+0200 I/CAPI_NETWORK_CONNECTION(13747): connection.c: connection_destroy(471) > Destroy handle: 0xf7b1b758
06-12 14:54:41.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13585
06-12 14:54:41.261+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:41.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:54:41.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13676
06-12 14:54:41.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13633
06-12 14:54:41.321+0200 W/AUL     (13676): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13633)
06-12 14:54:41.321+0200 E/AUL     ( 2478): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-12 14:54:41.331+0200 E/EFL     (13585): ecore_x<13585> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=6533136 button=1
06-12 14:54:41.331+0200 E/EFL     (13585): elementary<13585> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76d78e0 : elm_scroller] mouse move
06-12 14:54:41.341+0200 I/linearacceleration(13676): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:41.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:54:41.361+0200 I/linearacceleration(13676): es.ugr.frailty.linearacceleration - capturing data
06-12 14:54:41.371+0200 I/gyroscope(13643): request sent to service es.ugr.frailty.servicemanager
06-12 14:54:41.381+0200 E/EFL     (13585): elementary<13585> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76d78e0 : elm_scroller] mouse move
06-12 14:54:41.381+0200 E/EFL     (13585): elementary<13585> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf76d78e0 : elm_scroller] hold(0), freeze(0)
06-12 14:54:41.391+0200 E/EFL     (13585): elementary<13585> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76d78e0 : elm_scroller] mouse move
06-12 14:54:41.391+0200 E/EFL     (13585): elementary<13585> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf76d78e0 : elm_scroller] hold(0), freeze(0)
06-12 14:54:41.401+0200 E/EFL     (13585): elementary<13585> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf76d78e0 : elm_scroller] mouse move
06-12 14:54:41.401+0200 E/EFL     (13585): elementary<13585> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf76d78e0 : elm_scroller] hold(0), freeze(0)
06-12 14:54:41.411+0200 I/CAPI_NETWORK_CONNECTION(13747): connection.c: connection_create(453) > New handle created[0xf7b5ca48]
06-12 14:54:41.411+0200 I/CAPI_NETWORK_CONNECTION(13747): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
06-12 14:54:41.411+0200 I/CAPI_NETWORK_CONNECTION(13747): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
06-12 14:54:41.411+0200 I/CAPI_NETWORK_CONNECTION(13747): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
06-12 14:54:41.411+0200 I/CAPI_NETWORK_CONNECTION(13747): connection.c: connection_get_type(507) > Connected Network = 2
06-12 14:54:41.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(13633) cmd(0)
06-12 14:54:41.421+0200 W/LOCATION(13747): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-12 14:54:41.421+0200 W/LOCATION(13747): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 14:54:41.461+0200 I/AUL     (13747): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 14:54:41.471+0200 E/EFL     (13585): ecore_x<13585> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=6533269 button=1
06-12 14:54:41.471+0200 W/CRASH_MANAGER(13771): worker.c: worker_job(1205) > 11136606c6f63152880808
