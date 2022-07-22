S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21850
Date: 2018-04-23 16:00:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74ea52d, r5   = 0xf7671f98
r6   = 0xffd3f0f8, r7   = 0xffd3efa8
r8   = 0xf766ec18, r9   = 0x00000000
r10  = 0xffd3f084, fp   = 0xffd3f0f8
ip   = 0x00000001, sp   = 0xffd3de28
lr   = 0xf74ea539, pc   = 0xf75532b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     13844 KB
Buffers:     59716 KB
Cached:     230692 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12028 KB
VmRSS:       12028 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21850 TID = 21850
21850 21853 

Maps Information
f43b5000 f4bb4000 rw-p [stack:21853]
f4bbb000 f4bbd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bc5000 f4bc9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bd2000 f4bd4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bdc000 f4bdf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bee000 f4bf3000 r-xp /usr/lib/libsystem.so.0.0.0
f4bfe000 f4c01000 r-xp /lib/libattr.so.1.1.0
f4c09000 f4c19000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c21000 f4c2a000 r-xp /usr/lib/libedbus.so.1.7.99
f4c32000 f4c33000 r-xp /usr/lib/libresponse.so.0.2.96
f4c3c000 f4c41000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64e3000 f65e9000 r-xp /usr/lib/libicuuc.so.57.1
f65ff000 f6787000 r-xp /usr/lib/libicui18n.so.57.1
f6797000 f67a4000 r-xp /usr/lib/libail.so.0.1.0
f67ad000 f67b4000 r-xp /usr/lib/libminizip.so.1.0.0
f67bd000 f6966000 r-xp /usr/lib/libcrypto.so.1.0.0
f6986000 f69cd000 r-xp /usr/lib/libssl.so.1.0.0
f69d9000 f69db000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69e3000 f69ea000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69f3000 f69fa000 r-xp /lib/libcrypt-2.13.so
f6a2b000 f6a2e000 r-xp /lib/libcap.so.2.21
f6a36000 f6a38000 r-xp /usr/lib/libiri.so
f6a40000 f6a89000 r-xp /usr/lib/libmdm.so.1.2.69
f6a91000 f6a97000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a9f000 f6ac2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6acc000 f6ace000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ad6000 f6af3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6afc000 f6b00000 r-xp /usr/lib/libsmack.so.1.0.0
f6b09000 f6b22000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b2b000 f6b33000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b3b000 f6b41000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b4a000 f6b4c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b55000 f6b65000 r-xp /lib/libresolv-2.13.so
f6b69000 f6b81000 r-xp /usr/lib/liblzma.so.5.0.3
f6b8a000 f6b8c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b94000 f6bae000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bb6000 f6be5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bee000 f6bfd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c07000 f6c11000 r-xp /usr/lib/libsensord-shared.so
f6c1a000 f6ced000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cf8000 f6d0e000 r-xp /lib/libz.so.1.2.5
f6d16000 f6d1b000 r-xp /usr/lib/libffi.so.5.0.10
f6d23000 f6d24000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d2c000 f6d3c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d44000 f6d5d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d65000 f6d67000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d6f000 f6de4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dee000 f6df4000 r-xp /lib/librt-2.13.so
f6dfd000 f6e1b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e25000 f6e26000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e2e000 f6e51000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e59000 f6e5e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e66000 f6e90000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e99000 f6eb0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6eb8000 f6f21000 r-xp /lib/libm-2.13.so
f6f2a000 f6fbe000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fd1000 f6fd6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fde000 f6fe5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fed000 f7017000 r-xp /usr/lib/libsensor.so.1.9.6
f7020000 f70ec000 r-xp /usr/lib/libxml2.so.2.7.8
f70f9000 f70fb000 r-xp /usr/lib/libiniparser.so.0
f7104000 f710a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7113000 f71e3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71e4000 f7218000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7221000 f725d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7265000 f7268000 r-xp /usr/lib/libbundle.so.0.1.22
f7270000 f7276000 r-xp /usr/lib/libappsvc.so.0.1.0
f727e000 f72bf000 r-xp /usr/lib/libeina.so.1.7.99
f72c8000 f72df000 r-xp /usr/lib/libecore.so.1.7.99
f72f6000 f72ff000 r-xp /usr/lib/libvconf.so.0.2.45
f7307000 f731b000 r-xp /lib/libpthread-2.13.so
f7326000 f7333000 r-xp /usr/lib/libaul.so.0.1.0
f733d000 f733f000 r-xp /lib/libdl-2.13.so
f7348000 f7353000 r-xp /lib/libunwind.so.8.0.1
f7380000 f7388000 r-xp /lib/libgcc_s-4.6.so.1
f7389000 f74ad000 r-xp /lib/libc-2.13.so
f74bb000 f74bd000 r-xp /usr/lib/libdlog.so.0.0.0
f74c5000 f74d1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74da000 f74df000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74e7000 f74f6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74fe000 f7502000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f750b000 f750e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7516000 f7518000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7520000 f7524000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f752c000 f7549000 r-xp /lib/ld-2.13.so
f7552000 f7555000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7555000 f7559000 r-xp /usr/lib/libsys-assert.so
f763e000 f76af000 rw-p [heap]
ffd20000 ffd41000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21850)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf75532b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf74ea539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71f13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7201be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7201dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf723675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72311f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7201be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7201dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7233e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7234017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72388d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf75220bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4bc6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c99663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7146fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71487a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72d8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72d3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72d45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72d4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf750c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf750c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75536a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf73a085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7552fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
, cmd(0)
04-23 16:00:42.561+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:42.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19708), cmd(0)
04-23 16:00:42.561+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:42.561+0200 I/utils   (19708): specific action
04-23 16:00:42.561+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:42.561+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:42.561+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:42.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:42.561+0200 W/AUL     (21513): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:42.561+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:42.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:42.571+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:42.571+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:42.571+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:42.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:42.571+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:42.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:42.571+0200 I/utils   (21185): specific action
04-23 16:00:42.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:42.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:42.571+0200 I/heartrate(21513): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:42.571+0200 I/CAPI_APPFW_APPLICATION(21513): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:00:42.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:42.581+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
04-23 16:00:42.581+0200 I/recorder(21185): guardando datos en local
04-23 16:00:42.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:00:42.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:00:42.661+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:00:42.671+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:00:42.711+0200 I/heartrate(21513): es.ugr.frailty.heartrate listener destroyed
04-23 16:00:42.871+0200 W/AUL     (21832): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 16:00:42.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:42.871+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:42.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21513
04-23 16:00:42.871+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:42.871+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21513
04-23 16:00:42.871+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21513)
04-23 16:00:43.011+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:43.871+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:00:43.871+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:43.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:43.871+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:43.881+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21837
04-23 16:00:43.891+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:43.941+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21837
04-23 16:00:43.941+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21837) type(svcapp) bg(0)
04-23 16:00:43.941+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21837)
04-23 16:00:43.941+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:00:43.941+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:43.941+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21837]
04-23 16:00:43.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:43.971+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21837
04-23 16:00:43.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:43.971+0200 E/CAPI_APPFW_APPLICATION(21837): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:43.971+0200 E/CAPI_APPFW_APPLICATION(21837): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:43.981+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21837) was created
04-23 16:00:43.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:43.991+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21837
04-23 16:00:44.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:44.021+0200 W/LOCATION(21837): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:44.021+0200 E/LOCATION(21837): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:44.021+0200 E/PKGMGR_INFO(21837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:44.021+0200 W/LOCATION(21837): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:44.041+0200 I/LOCATION(21837): location.c: location_new(269) > method: 0
04-23 16:00:44.051+0200 W/LOCATION(21837): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:44.051+0200 W/LOCATION(21837): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:44.061+0200 W/LOCATION(21837): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:44.071+0200 W/LOCATION(21837): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:44.081+0200 W/LOCATION(21837): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:44.091+0200 W/LOCATION(21837): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:44.091+0200 W/LOCATION(21837): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:44.091+0200 W/LOCATION(21837): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:44.091+0200 W/LOCATION(21837): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:44.111+0200 W/LOCATION(21837): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:44.111+0200 W/LOCATION(21837): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:44.121+0200 W/LOCATION(21837): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:44.121+0200 W/LOCATION(21837): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:44.121+0200 W/LOCATION(21837): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:44.121+0200 W/LOCATION(21837): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:44.121+0200 W/LOCATION(21837): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:44.141+0200 W/LOCATION(21837): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:44.141+0200 I/LOCATION(21837): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7155c18
04-23 16:00:44.141+0200 I/LOCATION(21837): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:44.151+0200 I/LOCATION(21837): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7155c18
04-23 16:00:44.151+0200 I/LOCATION(21837): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:44.151+0200 I/location(21837): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:44.201+0200 I/LOCATION(21837): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:44.241+0200 W/LOCATION(21837): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:44.241+0200 W/LOCATION(21837): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:44.251+0200 I/LOCATION(21837): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:44.331+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:44.331+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:44.331+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:44.331+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:44.331+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:44.331+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:44.331+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:44.331+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:44.331+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:44.331+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:44.331+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:44.341+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:44.341+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:44.341+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:44.341+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:44.341+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:44.341+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:44.341+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:44.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:44.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:44.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:44.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:44.421+0200 W/LOCATION(21837): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:44.421+0200 W/LOCATION(21837): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:44.501+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:44.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e246b8]
04-23 16:00:44.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:44.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:44.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:44.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:44.551+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:44.551+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:44.571+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:44.571+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:44.571+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5940237), time2(5931802)
04-23 16:00:44.571+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:00:44.571+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:44.571+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:44.571+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:44.581+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:44.581+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:44.581+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:44.581+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:44.581+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:44.581+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:44.581+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:44.581+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:44.581+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:44.581+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:44.581+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:44.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:44.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:44.601+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:44.601+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:44.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:44.661+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:44.671+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:44.671+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:44.671+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:44.671+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:44.701+0200 W/LOCATION(21837): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:44.701+0200 I/LOCATION(21837): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:44.701+0200 I/LOCATION(21837): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:44.701+0200 I/location(21837): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:44.791+0200 I/LOCATION(21837): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:44.841+0200 W/AUL     (21837): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:44.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:44.841+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21837
04-23 16:00:44.851+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:44.851+0200 W/AUL     (21837): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:44.851+0200 I/location(21837): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:44.851+0200 I/location(21837): stopping es.ugr.frailty.location service
04-23 16:00:44.851+0200 E/CAPI_APPFW_APP_CONTROL(21837): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:00:44.851+0200 E/location(21837): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:00:44.851+0200 I/CAPI_APPFW_APPLICATION(21837): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:00:44.851+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:44.851+0200 I/utils   (19708): specific action
04-23 16:00:44.851+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:44.851+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:44.851+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:44.851+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:44.851+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:44.851+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:44.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:44.861+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:44.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:44.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:44.871+0200 I/utils   (21185): specific action
04-23 16:00:44.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:44.871+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:44.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:44.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:44.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:44.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:44.871+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:44.871+0200 I/recorder(21185): guardando datos en local
04-23 16:00:44.871+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:44.871+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:44.871+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:44.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:00:44.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:00:44.911+0200 W/LOCATION(21837): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:44.911+0200 I/LOCATION(21837): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:44.911+0200 I/LOCATION(21837): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:44.991+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:00:44.991+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:00:44.991+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:44.991+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:00:44.991+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:00:44.991+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:00:44.991+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:00:44.991+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:44.991+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:00:45.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:45.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:45.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:45.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:45.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e246b8
04-23 16:00:45.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01c60]
04-23 16:00:45.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:45.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:45.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:45.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:45.211+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:45.211+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:45.221+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:45.231+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:45.231+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:45.231+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:45.231+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:45.231+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:45.231+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:45.231+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:45.231+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:45.231+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:45.231+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:45.231+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:45.241+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:45.241+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:45.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:45.291+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:45.301+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:45.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:45.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:45.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:45.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01c60
04-23 16:00:45.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e109b8]
04-23 16:00:45.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:45.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:45.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:45.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:45.461+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:45.461+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:45.481+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:45.511+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:45.511+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:45.511+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:45.511+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:45.511+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:45.511+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:45.511+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:45.511+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:45.511+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:45.511+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:45.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:45.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:45.541+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:45.541+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:45.591+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:45.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:45.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:45.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:45.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e109b8
04-23 16:00:45.771+0200 W/AUL     (21849): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:00:45.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:45.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:45.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21790
04-23 16:00:45.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:45.781+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21790
04-23 16:00:45.781+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21790)
04-23 16:00:45.941+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:00:45.941+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:45.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:45.941+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:45.961+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21850
04-23 16:00:45.961+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:46.001+0200 E/CAPI_APPFW_APPLICATION(21850): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:46.001+0200 E/CAPI_APPFW_APPLICATION(21850): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:46.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21850
04-23 16:00:46.011+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21850) type(svcapp) bg(0)
04-23 16:00:46.011+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21850)
04-23 16:00:46.011+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:00:46.011+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:46.011+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21850]
04-23 16:00:46.021+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21850) was created
04-23 16:00:46.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:46.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21850
04-23 16:00:46.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:46.041+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21850
04-23 16:00:46.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:46.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:46.061+0200 W/LOCATION(21850): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:46.061+0200 E/LOCATION(21850): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:46.061+0200 E/PKGMGR_INFO(21850): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:46.061+0200 W/LOCATION(21850): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:46.081+0200 I/LOCATION(21850): location.c: location_new(269) > method: 0
04-23 16:00:46.081+0200 W/LOCATION(21850): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:46.091+0200 W/LOCATION(21850): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:46.091+0200 W/LOCATION(21850): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:46.101+0200 W/LOCATION(21850): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:46.101+0200 W/LOCATION(21850): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:46.101+0200 W/LOCATION(21850): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:46.101+0200 W/LOCATION(21850): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:46.101+0200 W/LOCATION(21850): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:46.111+0200 W/LOCATION(21850): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:46.131+0200 W/LOCATION(21850): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:46.131+0200 W/LOCATION(21850): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:46.141+0200 W/LOCATION(21850): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:46.141+0200 W/LOCATION(21850): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:46.141+0200 W/LOCATION(21850): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:46.141+0200 W/LOCATION(21850): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:46.141+0200 W/LOCATION(21850): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:46.161+0200 W/LOCATION(21850): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:46.161+0200 I/LOCATION(21850): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf766ec18
04-23 16:00:46.161+0200 I/LOCATION(21850): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:46.161+0200 I/LOCATION(21850): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf766ec18
04-23 16:00:46.161+0200 I/LOCATION(21850): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:46.171+0200 I/location(21850): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:46.211+0200 I/LOCATION(21850): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:46.251+0200 W/LOCATION(21850): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:46.251+0200 W/LOCATION(21850): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:46.251+0200 I/LOCATION(21850): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:46.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:46.351+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:46.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:46.351+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:46.351+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:46.351+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:46.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:46.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:46.351+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:46.351+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:46.351+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:46.351+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:46.351+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:46.351+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:46.351+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:46.351+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:46.351+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:46.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:46.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:46.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:46.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:46.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:46.441+0200 W/LOCATION(21850): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:46.441+0200 W/LOCATION(21850): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:46.551+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:46.591+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:46.591+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5942254), time2(5931802)
04-23 16:00:46.591+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:00:46.591+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:46.591+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:46.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:46.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e17d70]
04-23 16:00:46.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:46.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:46.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:46.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:46.611+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:46.611+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:46.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:46.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:46.621+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:46.621+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:46.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:46.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:46.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:46.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:46.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:46.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:46.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:46.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:46.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:46.641+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:46.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:46.691+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:46.711+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:46.721+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:46.721+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:46.721+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:46.721+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:46.741+0200 W/LOCATION(21850): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:46.741+0200 I/LOCATION(21850): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:46.741+0200 I/LOCATION(21850): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:46.741+0200 I/location(21850): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:46.841+0200 I/LOCATION(21850): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:46.871+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:46.901+0200 W/AUL     (21850): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:46.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:46.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21850
04-23 16:00:46.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:46.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.911+0200 I/utils   (19708): specific action
04-23 16:00:46.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.911+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:46.911+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:46.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:46.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:46.911+0200 W/AUL     (21850): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:46.911+0200 I/location(21850): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:46.921+0200 W/CAPI_APPFW_APP_CONTROL(21850): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.921+0200 I/utils   (21850): specific action
04-23 16:00:46.921+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:46.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:46.931+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:46.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:46.931+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.931+0200 I/utils   (21185): specific action
04-23 16:00:46.931+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.931+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.931+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.931+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:46.931+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:46.931+0200 I/recorder(21185): guardando datos en local
04-23 16:00:46.931+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:46.931+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:46.931+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:46.961+0200 I/LOCATION(21850): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:47.061+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11218506c6f63152449204
