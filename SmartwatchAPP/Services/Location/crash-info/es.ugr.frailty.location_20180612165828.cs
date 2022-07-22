S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15767
Date: 2018-06-12 16:58:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fd852d, r5   = 0xf7306150
r6   = 0xfff57e40, r7   = 0xfff57cf0
r8   = 0xf7318c18, r9   = 0x00000000
r10  = 0xfff57dcc, fp   = 0xfff57e40
ip   = 0x00000001, sp   = 0xfff57cc8
lr   = 0xf6fd8539, pc   = 0xf7041228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    132084 KB
Buffers:     41572 KB
Cached:     167036 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11660 KB
VmRSS:       11656 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15767 TID = 15767
15767 15844 

Maps Information
f3ea3000 f46a2000 rw-p [stack:15844]
f46a9000 f46ab000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46b3000 f46b7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46c0000 f46c2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46ca000 f46cd000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46dc000 f46e1000 r-xp /usr/lib/libsystem.so.0.0.0
f46ec000 f46ef000 r-xp /lib/libattr.so.1.1.0
f46f7000 f4707000 r-xp /usr/lib/libmdm-common.so.1.1.24
f470f000 f4718000 r-xp /usr/lib/libedbus.so.1.7.99
f4720000 f4721000 r-xp /usr/lib/libresponse.so.0.2.96
f472a000 f472f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fd1000 f60d7000 r-xp /usr/lib/libicuuc.so.57.1
f60ed000 f6275000 r-xp /usr/lib/libicui18n.so.57.1
f6285000 f6292000 r-xp /usr/lib/libail.so.0.1.0
f629b000 f62a2000 r-xp /usr/lib/libminizip.so.1.0.0
f62ab000 f6454000 r-xp /usr/lib/libcrypto.so.1.0.0
f6474000 f64bb000 r-xp /usr/lib/libssl.so.1.0.0
f64c7000 f64c9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64d1000 f64d8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64e1000 f64e8000 r-xp /lib/libcrypt-2.13.so
f6519000 f651c000 r-xp /lib/libcap.so.2.21
f6524000 f6526000 r-xp /usr/lib/libiri.so
f652e000 f6577000 r-xp /usr/lib/libmdm.so.1.2.69
f657f000 f6585000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f658d000 f65b0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65ba000 f65bc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65c4000 f65e1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65ea000 f65ee000 r-xp /usr/lib/libsmack.so.1.0.0
f65f7000 f6610000 r-xp /usr/lib/libnetwork.so.0.0.0
f6619000 f6621000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6629000 f662f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6638000 f663a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6643000 f6653000 r-xp /lib/libresolv-2.13.so
f6657000 f666f000 r-xp /usr/lib/liblzma.so.5.0.3
f6678000 f667a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6682000 f669c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66a4000 f66d3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66dc000 f66eb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66f5000 f66ff000 r-xp /usr/lib/libsensord-shared.so
f6708000 f67db000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67e6000 f67fc000 r-xp /lib/libz.so.1.2.5
f6804000 f6809000 r-xp /usr/lib/libffi.so.5.0.10
f6811000 f6812000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f681a000 f682a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6832000 f684b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6853000 f6855000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f685d000 f68d2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68dc000 f68e2000 r-xp /lib/librt-2.13.so
f68eb000 f6909000 r-xp /usr/lib/libsystemd.so.0.4.0
f6913000 f6914000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f691c000 f693f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6947000 f694c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6954000 f697e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6987000 f699e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69a6000 f6a0f000 r-xp /lib/libm-2.13.so
f6a18000 f6aac000 r-xp /usr/lib/libstdc++.so.6.0.16
f6abf000 f6ac4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6acc000 f6ad3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6adb000 f6b05000 r-xp /usr/lib/libsensor.so.1.9.6
f6b0e000 f6bda000 r-xp /usr/lib/libxml2.so.2.7.8
f6be7000 f6be9000 r-xp /usr/lib/libiniparser.so.0
f6bf2000 f6bf8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c01000 f6cd1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cd2000 f6d06000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d0f000 f6d4b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d53000 f6d56000 r-xp /usr/lib/libbundle.so.0.1.22
f6d5e000 f6d64000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d6c000 f6dad000 r-xp /usr/lib/libeina.so.1.7.99
f6db6000 f6dcd000 r-xp /usr/lib/libecore.so.1.7.99
f6de4000 f6ded000 r-xp /usr/lib/libvconf.so.0.2.45
f6df5000 f6e09000 r-xp /lib/libpthread-2.13.so
f6e14000 f6e21000 r-xp /usr/lib/libaul.so.0.1.0
f6e2b000 f6e2d000 r-xp /lib/libdl-2.13.so
f6e36000 f6e41000 r-xp /lib/libunwind.so.8.0.1
f6e6e000 f6e76000 r-xp /lib/libgcc_s-4.6.so.1
f6e77000 f6f9b000 r-xp /lib/libc-2.13.so
f6fa9000 f6fab000 r-xp /usr/lib/libdlog.so.0.0.0
f6fb3000 f6fbf000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fc8000 f6fcd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fd5000 f6fe4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fec000 f6ff0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6ff9000 f6ffc000 r-xp /usr/lib/libappcore-agent.so.1.1
f7004000 f7006000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f700e000 f7012000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f701a000 f7037000 r-xp /lib/ld-2.13.so
f7040000 f7043000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7043000 f7047000 r-xp /usr/lib/libsys-assert.so
f72e8000 f7359000 rw-p [heap]
fff39000 fff5a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15767)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7041228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fd8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cdf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cddc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ce9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cefbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cefdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d2475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d1f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cddc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ce9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cefbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cefdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d21e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d22017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d29f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46c11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46b4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6787663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c34fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c367a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6dc6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dc1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dc25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dc2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6ffa183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6ffa7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70415c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6e8e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7040f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:27.561+0200 W/AUL     (15781): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:27.561+0200 I/gravity (15781): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:27.561+0200 I/gravity (15781): es.ugr.frailty.gravity - capturing data
06-12 16:58:27.571+0200 I/gravity (15781): es.ugr.frailty.gravity: SM-R760,12/06/2018,16:58:27:576,9.756289,0.171683,0.977614
06-12 16:58:27.571+0200 W/AUL     (15781): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:27.571+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:27.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 16:58:27.601+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 16:58:27.601+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 16:58:27.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface-service)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.wusvc)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (health-data-service)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.weip.consumer)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-home)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.alti-barometer-widget)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth-service)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth.widget.pedometer)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-player.music-control-service)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-transfer.consumer)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.recorder)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.heartrate)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.location)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.gravity)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.light)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.pedometer)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.servicemanager)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.recorder)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.accelerometer)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.gyroscope)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.heartrate)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.location)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.linearacceleration)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.gravity)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.pressure)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.light)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (es.ugr.frailty.pedometer)!!
06-12 16:58:27.601+0200 E/W_TASKMANAGER(15690): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-taskmanager)!!
06-12 16:58:27.611+0200 E/RUA     (15690): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 30, ncols : 5
06-12 16:58:27.631+0200 E/EFL     (15690): evas_main<15690> evas_stack.c:158 evas_object_stack_above() BITCH! evas_object_stack_above(), 0xf78e1c38 not inside same smart as 0xf78c2968!
06-12 16:58:27.631+0200 I/heartrate(15758): es.ugr.frailty.heartrate - capturing data
06-12 16:58:27.631+0200 E/EFL     (15690): elementary<15690> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0xf789d550 into part 'elm.swallow.event.0'
06-12 16:58:27.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:27.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15742
06-12 16:58:27.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:27.651+0200 W/W_HOME  ( 6202): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
06-12 16:58:27.651+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 16:58:27.651+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 16:58:27.651+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 16:58:27.651+0200 W/W_HOME  ( 6202): win.c: win_back_gesture_disable_set(173) > enable back gesture
06-12 16:58:27.651+0200 W/W_HOME  ( 6202): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
06-12 16:58:27.671+0200 I/heartrate(15758): es.ugr.frailty.heartrate: waiting for rigth values
06-12 16:58:27.671+0200 W/W_INDICATOR( 2694): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-12 16:58:27.671+0200 W/W_INDICATOR( 2694): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-12 16:58:27.681+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.132922] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:27.681+0200 W/AUL     (15742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:27.681+0200 I/accelerometer(15742): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:27.681+0200 I/accelerometer(15742): es.ugr.frailty.accelerometer - capturing data
06-12 16:58:27.691+0200 I/accelerometer(15742): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,16:58:27:696,9.748360,0.143569,0.937986
06-12 16:58:27.691+0200 W/AUL     (15742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:27.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:27.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15745
06-12 16:58:27.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:27.751+0200 I/APP_CORE(15690): appcore-efl.c: __do_app(453) > [APP 15690] Event: RESET State: CREATED
06-12 16:58:27.751+0200 I/CAPI_APPFW_APPLICATION(15690): app_main.c: app_appcore_reset(245) > app_appcore_reset
06-12 16:58:27.761+0200 W/AUL     (15745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:27.761+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:27.771+0200 I/gyroscope(15745): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:27.771+0200 I/gyroscope(15745): es.ugr.frailty.gyroscope - capturing data
06-12 16:58:27.781+0200 I/APP_CORE(15690): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-12 16:58:27.781+0200 I/APP_CORE(15690): appcore-efl.c: __do_app(524) > [APP 15690] Initial Launching, call the resume_cb
06-12 16:58:27.781+0200 I/CAPI_APPFW_APPLICATION(15690): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-12 16:58:27.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 16:58:27.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15785
06-12 16:58:27.801+0200 W/APP_CORE(15690): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00003
06-12 16:58:27.801+0200 I/gyroscope(15745): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,16:58:27:791,-0.070000,-2.380000,-2.100000
06-12 16:58:27.801+0200 W/AUL     (15745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:27.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:27.831+0200 I/heartrate(15758): es.ugr.frailty.heartrate - capturing data
06-12 16:58:27.831+0200 I/heartrate(15758): es.ugr.frailty.heartrate: waiting for rigth values
06-12 16:58:27.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15788
06-12 16:58:27.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): event_manager.c: _window_visibility_cb(466) > Window [0x2200003] is now visible(1)
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): main.c: _window_visibility_cb(964) > Window [0x2200003] is now visible(1)
06-12 16:58:27.901+0200 I/APP_CORE( 6202): appcore-efl.c: __do_app(453) > [APP 6202] Event: PAUSE State: RUNNING
06-12 16:58:27.901+0200 I/CAPI_APPFW_APPLICATION( 6202): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): main.c: _appcore_pause_cb(488) > appcore pause
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): rotary.c: rotary_deattach(156) > rotary_deattach:0xed639d80
06-12 16:58:27.901+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-12 16:58:27.901+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xed639d80, elm_layout, func : 0xf5a6bd05
06-12 16:58:27.901+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-12 16:58:27.901+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-12 16:58:27.901+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-12 16:58:27.901+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf77d0238, elm_box, _activated_obj : 0xed639d80, activated : 1
06-12 16:58:27.901+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-12 16:58:27.901+0200 E/wnotib  ( 6202): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-12 16:58:27.901+0200 I/wnotib  ( 6202): w-notification-board-basic-panel.c: _wnb_bp_is_key_event_passed(5857) > Return true for 33, -13.
06-12 16:58:27.901+0200 I/wnotib  ( 6202): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
06-12 16:58:27.901+0200 W/W_HOME  ( 6202): win.c: win_back_gesture_disable_set(173) > enable back gesture
06-12 16:58:27.901+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 16:58:27.901+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 16:58:27.901+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 16:58:27.901+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 16:58:27.901+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-12 16:58:27.901+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-12 16:58:27.901+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 16:58:27.901+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 16:58:27.911+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 16:58:27.911+0200 I/wnotib  ( 6202): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
06-12 16:58:27.911+0200 W/STARTER ( 2679): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[6202] goes to (4)
06-12 16:58:27.911+0200 E/STARTER ( 2679): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 6202)'s state(4)
06-12 16:58:27.911+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.369522] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:27.921+0200 E/wnotib  ( 6202): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-12 16:58:27.921+0200 W/wnotib  ( 6202): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [1].
06-12 16:58:27.921+0200 W/STARTER ( 2679): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[15690] goes to (3)
06-12 16:58:27.931+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.387044] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:27.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:27.941+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15735
06-12 16:58:27.951+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15738
06-12 16:58:27.951+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.403053] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:27.961+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.419963] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:27.981+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.437410] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:27.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:27.991+0200 W/LOCATION(15767): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 16:58:28.001+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 16:58:28.001+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 16:58:28.001+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 16:58:28.001+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 16:58:28.001+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.453452] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.011+0200 E/CAPI_APPFW_APP_CONTROL( 6531): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 16:58:28.011+0200 I/APP_CORE(15690): appcore-efl.c: __do_app(453) > [APP 15690] Event: RESUME State: RUNNING
06-12 16:58:28.011+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.469947] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:28.031+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15770
06-12 16:58:28.031+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.486613] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:28.051+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.503339] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.061+0200 W/APPS    ( 6202): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
06-12 16:58:28.071+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.520120] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.071+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(6202) status(bg) type(uiapp)
06-12 16:58:28.071+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:28.081+0200 W/MUSIC_CONTROL_SERVICE( 6531): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:6531]   [com.samsung.w-home]register msg port [false][0m
06-12 16:58:28.081+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.536670] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.101+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.553473] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:28.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15781
06-12 16:58:28.121+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.570927] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:28.131+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.586912] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.151+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.604216] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.171+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.620346] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.171+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(15690) status(fg) type(uiapp)
06-12 16:58:28.181+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.638375] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.191+0200 I/heartrate(15758): es.ugr.frailty.heartrate - capturing data
06-12 16:58:28.191+0200 I/heartrate(15758): es.ugr.frailty.heartrate: waiting for rigth values
06-12 16:58:28.191+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.201+0200 W/W_INDICATOR( 2694): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-12 16:58:28.201+0200 I/utils   (15738): specific action
06-12 16:58:28.201+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.201+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.201+0200 W/AUL     (15735): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15738)
06-12 16:58:28.201+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.201+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.201+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.653758] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:28.211+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.211+0200 I/servicemanager(15735): request sent to service es.ugr.frailty.recorder
06-12 16:58:28.211+0200 I/servicemanager(15735): requesting to save local data
06-12 16:58:28.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15742
06-12 16:58:28.211+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.211+0200 E/AUL     (15735): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 16:58:28.211+0200 I/recorder(15738): saving local data for es.ugr.frailty.gravity
06-12 16:58:28.211+0200 I/recorder(15738): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 16:58:28.211+0200 E/AUL     (15735): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 16:58:28.211+0200 W/W_INDICATOR( 2694): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-12 16:58:28.211+0200 E/AUL     (15735): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 16:58:28.211+0200 E/AUL     (15735): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 16:58:28.221+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.670502] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:28.221+0200 I/heartrate(15758): es.ugr.frailty.heartrate - capturing data
06-12 16:58:28.221+0200 I/heartrate(15758): es.ugr.frailty.heartrate: waiting for rigth values
06-12 16:58:28.231+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.231+0200 I/utils   (15735): specific action
06-12 16:58:28.231+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.687333] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.231+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.231+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.231+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.231+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.231+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.251+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.703917] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.271+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.720592] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.271+0200 I/servicemanager(15735): requesting to save local data for es.ugr.frailty.gravity
06-12 16:58:28.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:28.271+0200 W/AUL     (15735): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 16:58:28.271+0200 W/AUL     (15781): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:28.271+0200 W/AUL     (15742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:28.271+0200 I/accelerometer(15742): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:28.271+0200 I/accelerometer(15742): es.ugr.frailty.accelerometer - capturing data
06-12 16:58:28.281+0200 W/AUL     (15770): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:28.281+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 16:58:28.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(63) , send fd(21), pid(15738), cmd(0)
06-12 16:58:28.281+0200 W/AUL     (15788): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:28.281+0200 I/gravity (15781): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:28.281+0200 I/gravity (15781): es.ugr.frailty.gravity - capturing data
06-12 16:58:28.281+0200 I/light   (15788): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:28.281+0200 I/linearacceleration(15770): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:28.281+0200 I/light   (15788): es.ugr.frailty.light - capturing data
06-12 16:58:28.281+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.737197] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.301+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.753944] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.321+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.770602] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:28.331+0200 I/accelerometer(15742): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,16:58:28:288,9.738789,0.112463,0.763310
06-12 16:58:28.331+0200 W/AUL     (15742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:28.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15745
06-12 16:58:28.331+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.788175] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:28.341+0200 I/linearacceleration(15770): es.ugr.frailty.linearacceleration - capturing data
06-12 16:58:28.351+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [13944.804028] pp(0x504808) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 16:58:28.351+0200 I/gravity (15781): es.ugr.frailty.gravity: SM-R760,12/06/2018,16:58:28:293,9.762753,0.137232,0.916631
06-12 16:58:28.361+0200 W/AUL     (15781): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:28.361+0200 I/linearacceleration(15770): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,16:58:28:362,0.034251,-0.109383,-0.242041
06-12 16:58:28.361+0200 I/light   (15788): es.ugr.frailty.light: SM-R760,12/06/2018,16:58:28:297,61.000000
06-12 16:58:28.361+0200 W/AUL     (15788): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:28.371+0200 W/AUL     (15770): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:28.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:28.391+0200 W/AUL     (15745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:28.391+0200 I/gyroscope(15745): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:28.391+0200 I/gyroscope(15745): es.ugr.frailty.gyroscope - capturing data
06-12 16:58:28.421+0200 I/APP_CORE( 6202): appcore-efl.c: __do_app(453) > [APP 6202] Event: MEM_FLUSH State: PAUSED
06-12 16:58:28.421+0200 I/gyroscope(15745): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,16:58:28:402,-0.070000,-2.520000,-2.240000
06-12 16:58:28.421+0200 W/AUL     (15745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:28.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 16:58:28.431+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:28.431+0200 I/heartrate(15758): es.ugr.frailty.heartrate - capturing data
06-12 16:58:28.431+0200 I/heartrate(15758): es.ugr.frailty.heartrate: waiting for rigth values
06-12 16:58:28.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 16:58:28.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15690
06-12 16:58:28.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:28.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15735
06-12 16:58:28.501+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15738
06-12 16:58:28.541+0200 W/AUL     (15735): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15738)
06-12 16:58:28.541+0200 I/servicemanager(15735): request sent to service es.ugr.frailty.recorder
06-12 16:58:28.541+0200 I/servicemanager(15735): requesting to save local data
06-12 16:58:28.541+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:28.541+0200 E/AUL     (15735): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 16:58:28.541+0200 E/AUL     (15735): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 16:58:28.541+0200 E/AUL     (15735): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 16:58:28.541+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.541+0200 I/utils   (15735): specific action
06-12 16:58:28.541+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.541+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.541+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.541+0200 W/CAPI_APPFW_APP_CONTROL(15735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.541+0200 I/servicemanager(15735): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 16:58:28.541+0200 W/AUL     (15735): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 16:58:28.551+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.551+0200 I/utils   (15738): specific action
06-12 16:58:28.551+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.551+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.551+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.551+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.551+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.551+0200 W/CAPI_APPFW_APP_CONTROL(15738): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 16:58:28.551+0200 I/recorder(15738): saving local data for es.ugr.frailty.gravity
06-12 16:58:28.551+0200 I/recorder(15738): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 16:58:28.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:28.561+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15742
06-12 16:58:28.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:28.591+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 16:58:28.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 16:58:28.591+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 16:58:28.611+0200 W/AUL     (15742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:28.611+0200 I/accelerometer(15742): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:28.611+0200 I/accelerometer(15742): es.ugr.frailty.accelerometer - capturing data
06-12 16:58:28.621+0200 E/AUL     ( 2478): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-12 16:58:28.621+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 16:58:28.621+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(39) , send fd(21), pid(15735), cmd(0)
06-12 16:58:28.641+0200 I/heartrate(15758): es.ugr.frailty.heartrate - capturing data
06-12 16:58:28.641+0200 I/heartrate(15758): es.ugr.frailty.heartrate: waiting for rigth values
06-12 16:58:28.651+0200 I/accelerometer(15742): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,16:58:28:624,9.808180,0.129212,0.926022
06-12 16:58:28.651+0200 W/AUL     (15742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:28.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 16:58:28.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(21), pid(15738), cmd(0)
06-12 16:58:28.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 16:58:28.691+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 16:58:28.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 16:58:28.691+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 16:58:28.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 16:58:28.691+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 16:58:28.691+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 16:58:28.691+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 16:58:28.691+0200 E/CAPI_LOCATION_MANAGER(15847): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 16:58:28.701+0200 W/AUL     (15866): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 16:58:28.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:28.711+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15781
06-12 16:58:28.711+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 16:58:28.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:28.781+0200 I/CAPI_NETWORK_CONNECTION(15847): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 16:58:28.781+0200 I/CAPI_NETWORK_CONNECTION(15847): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 16:58:28.781+0200 I/CAPI_NETWORK_CONNECTION(15847): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 16:58:28.781+0200 I/CAPI_NETWORK_CONNECTION(15847): connection.c: connection_destroy(471) > Destroy handle: 0xf73f9c18
06-12 16:58:28.791+0200 W/AUL     (15781): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:28.791+0200 I/gravity (15781): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:28.791+0200 I/gravity (15781): es.ugr.frailty.gravity - capturing data
06-12 16:58:28.791+0200 I/gravity (15781): es.ugr.frailty.gravity: SM-R760,12/06/2018,16:58:28:802,9.770168,0.126135,0.835632
06-12 16:58:28.791+0200 W/AUL     (15781): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:28.821+0200 I/heartrate(15758): es.ugr.frailty.heartrate - capturing data
06-12 16:58:28.821+0200 I/heartrate(15758): es.ugr.frailty.heartrate: waiting for rigth values
06-12 16:58:28.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:28.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15788
06-12 16:58:28.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:28.861+0200 E/EFL     (15690): ecore_x<15690> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13945312 button=1
06-12 16:58:28.861+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] mouse move
06-12 16:58:28.871+0200 W/AUL     (15788): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:28.871+0200 I/light   (15788): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:28.871+0200 I/light   (15788): es.ugr.frailty.light - capturing data
06-12 16:58:28.871+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] mouse move
06-12 16:58:28.871+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] hold(0), freeze(0)
06-12 16:58:28.881+0200 I/light   (15788): es.ugr.frailty.light: SM-R760,12/06/2018,16:58:28:883,56.000000
06-12 16:58:28.881+0200 W/AUL     (15788): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 16:58:28.881+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:28.891+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] mouse move
06-12 16:58:28.891+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] hold(0), freeze(0)
06-12 16:58:28.911+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] mouse move
06-12 16:58:28.911+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] hold(0), freeze(0)
06-12 16:58:28.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 16:58:28.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15770
06-12 16:58:28.931+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] mouse move
06-12 16:58:28.931+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] hold(0), freeze(0)
06-12 16:58:28.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15735
06-12 16:58:28.951+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] mouse move
06-12 16:58:28.951+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] hold(0), freeze(0)
06-12 16:58:28.971+0200 W/AUL     (15770): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15735)
06-12 16:58:28.971+0200 I/linearacceleration(15770): request sent to service es.ugr.frailty.servicemanager
06-12 16:58:28.971+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] mouse move
06-12 16:58:28.971+0200 E/EFL     (15690): elementary<15690> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf786d9e0 : elm_scroller] hold(0), freeze(0)
06-12 16:58:28.981+0200 E/EFL     (15690): ecore_x<15690> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13945435 button=1
06-12 16:58:28.991+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(15735) cmd(0)
06-12 16:58:28.991+0200 I/linearacceleration(15770): es.ugr.frailty.linearacceleration - capturing data
06-12 16:58:28.991+0200 W/CRASH_MANAGER(15867): worker.c: worker_job(1205) > 11157676c6f63152881550
