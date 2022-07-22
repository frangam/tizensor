S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 6066
Date: 2018-04-12 18:24:16+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf4

Register Information
r0   = 0x000000f6, r1   = 0x000000f4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xff82c9d0
r6   = 0xf6ff2605, r7   = 0x000000f6
r8   = 0x00000000, r9   = 0x00000000
r10  = 0xf6ff2604, fp   = 0xff82c9c4
ip   = 0xff82caa0, sp   = 0xff82c458
lr   = 0xf6e8ce8c, pc   = 0xf6ec20b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     77852 KB
Buffers:     39828 KB
Cached:     214292 KB
VmPeak:      45264 KB
VmSize:      44880 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7088 KB
VmRSS:        7088 KB
VmData:      35052 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6066 TID = 6066
6066 6075 6076 6077 6078 

Maps Information
f45fe000 f4dfd000 rw-p [stack:6078]
f4dfe000 f55fd000 rw-p [stack:6077]
f55fe000 f5dfd000 rw-p [stack:6076]
f5dfe000 f6601000 rw-p [stack:6075]
f6601000 f6604000 r-xp /lib/libattr.so.1.1.0
f660c000 f6613000 r-xp /lib/libcrypt-2.13.so
f6644000 f6647000 r-xp /lib/libcap.so.2.21
f664f000 f6651000 r-xp /usr/lib/libiri.so
f6659000 f665b000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6663000 f6665000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f666e000 f673a000 r-xp /usr/lib/libxml2.so.2.7.8
f6748000 f6765000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f676e000 f6772000 r-xp /usr/lib/libsmack.so.1.0.0
f677b000 f6791000 r-xp /lib/libz.so.1.2.5
f6799000 f679b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f67a3000 f67a8000 r-xp /usr/lib/libffi.so.5.0.10
f67b0000 f67b1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67b9000 f67c9000 r-xp /lib/libresolv-2.13.so
f67cd000 f67e5000 r-xp /usr/lib/liblzma.so.5.0.3
f67ed000 f67ef000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67f7000 f6811000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6819000 f6848000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6851000 f6860000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6869000 f6873000 r-xp /usr/lib/libsensord-shared.so
f687c000 f68b0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f68b9000 f698c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6997000 f699d000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f69a6000 f6a1b000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a25000 f6a2b000 r-xp /lib/librt-2.13.so
f6a34000 f6a52000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a5c000 f6a5d000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a65000 f6a88000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a90000 f6a95000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a9d000 f6b6d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6b6e000 f6b98000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ba1000 f6bb8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bc0000 f6c29000 r-xp /lib/libm-2.13.so
f6c32000 f6cc6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cd9000 f6cde000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ce6000 f6ced000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cf5000 f6d1f000 r-xp /usr/lib/libsensor.so.1.9.6
f6d28000 f6d2b000 r-xp /usr/lib/libbundle.so.0.1.22
f6d33000 f6d39000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d41000 f6d82000 r-xp /usr/lib/libeina.so.1.7.99
f6d8b000 f6da2000 r-xp /usr/lib/libecore.so.1.7.99
f6db9000 f6dc2000 r-xp /usr/lib/libvconf.so.0.2.45
f6dca000 f6dde000 r-xp /lib/libpthread-2.13.so
f6de9000 f6df6000 r-xp /usr/lib/libaul.so.0.1.0
f6e00000 f6e02000 r-xp /lib/libdl-2.13.so
f6e0b000 f6e16000 r-xp /lib/libunwind.so.8.0.1
f6e43000 f6e4b000 r-xp /lib/libgcc_s-4.6.so.1
f6e4c000 f6f70000 r-xp /lib/libc-2.13.so
f6f7e000 f6f80000 r-xp /usr/lib/libdlog.so.0.0.0
f6f88000 f6f94000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f9d000 f6fa1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6faa000 f6fad000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fcb000 f6fe8000 r-xp /lib/ld-2.13.so
f6ff1000 f6ff3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f6ff3000 f6ff7000 r-xp /usr/lib/libsys-assert.so
f72a8000 f72c9000 rw-p [heap]
ff80d000 ff82e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6066)
Call Stack Count: 1
 0: strlen + 0x4 (0xf6ec20b4) [/lib/libc.so.6] + 0x760b4
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: accelerometer
App ID: es.ugr.frailty.accelerometer
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
_list] mouse move
04-12 18:24:12.929+0200 E/EFL     ( 6014): elementary<6014> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7365f90 : elm_list] hold(0), freeze(0)
04-12 18:24:12.939+0200 E/EFL     ( 6014): elementary<6014> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7365f90 : elm_list] mouse move
04-12 18:24:12.939+0200 E/EFL     ( 6014): elementary<6014> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7365f90 : elm_list] hold(0), freeze(0)
04-12 18:24:13.049+0200 E/EFL     ( 6014): elementary<6014> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7365f90 : elm_list] mouse move
04-12 18:24:13.049+0200 E/EFL     ( 6014): elementary<6014> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7365f90 : elm_list] hold(0), freeze(0)
04-12 18:24:13.059+0200 E/EFL     ( 6014): ecore_x<6014> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=9918323 button=1
04-12 18:24:13.059+0200 W/AUL     ( 6014): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 18:24:13.059+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:24:13.059+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6014
04-12 18:24:13.079+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6055
04-12 18:24:13.079+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:24:13.099+0200 E/CAPI_APPFW_APPLICATION( 6055): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:24:13.099+0200 E/CAPI_APPFW_APPLICATION( 6055): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:24:13.109+0200 W/AUL     ( 6055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 18:24:13.129+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6055
04-12 18:24:13.129+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(6055) type(svcapp) bg(0)
04-12 18:24:13.129+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:24:13.129+0200 W/AUL     ( 6014): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6055)
04-12 18:24:13.129+0200 I/utils   ( 6014): es.ugr.frailty.servicemanager launch request sent!
04-12 18:24:13.129+0200 I/utils   ( 6014): App control destroyed.
04-12 18:24:13.129+0200 I/CAPI_APPFW_APPLICATION( 6014): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 18:24:13.129+0200 I/CAPI_APPFW_APPLICATION( 6014): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 18:24:13.139+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6055]
04-12 18:24:13.139+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6055
04-12 18:24:13.149+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6058
04-12 18:24:13.159+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:24:13.189+0200 E/CAPI_APPFW_APPLICATION( 6058): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:24:13.189+0200 E/CAPI_APPFW_APPLICATION( 6058): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:24:13.199+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6058
04-12 18:24:13.199+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(6058) type(svcapp) bg(0)
04-12 18:24:13.199+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6055) was created
04-12 18:24:13.199+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6058) was created
04-12 18:24:13.209+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:24:13.219+0200 W/AUL     ( 6055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6058)
04-12 18:24:13.219+0200 I/servicemanager( 6055): es.ugr.frailty.httppostreq launch request sent!
04-12 18:24:13.219+0200 I/servicemanager( 6055): App control destroyed.
04-12 18:24:13.219+0200 W/AUL     ( 6055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 18:24:13.219+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6058]
04-12 18:24:13.219+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6055
04-12 18:24:13.219+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:24:13.229+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6055
04-12 18:24:13.229+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:24:13.229+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6055
04-12 18:24:13.249+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6059
04-12 18:24:13.249+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:24:13.279+0200 E/CAPI_APPFW_APPLICATION( 6059): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:24:13.279+0200 E/CAPI_APPFW_APPLICATION( 6059): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:24:13.279+0200 W/CAPI_APPFW_APP_CONTROL( 6059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:24:13.289+0200 W/CAPI_APPFW_APP_CONTROL( 6059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:24:13.299+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6059
04-12 18:24:13.299+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6059) type(svcapp) bg(0)
04-12 18:24:13.299+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:24:13.299+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6059) was created
04-12 18:24:13.299+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:24:13.299+0200 W/AUL     ( 6055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6059)
04-12 18:24:13.299+0200 I/servicemanager( 6055): es.ugr.frailty.recorder launch request sent!
04-12 18:24:13.299+0200 I/servicemanager( 6055): App control destroyed.
04-12 18:24:13.299+0200 I/servicemanager( 6055): Frailty Service Manager created
04-12 18:24:13.299+0200 W/CAPI_APPFW_APP_CONTROL( 6055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:24:13.309+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6059]
04-12 18:24:13.329+0200 W/CAPI_APPFW_APP_CONTROL( 6055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:24:13.329+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:24:13.339+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6058
04-12 18:24:13.339+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:24:13.349+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:24:13.359+0200 I/CAPI_NETWORK_CONNECTION( 6058): connection.c: connection_create(453) > New handle created[0xf7861be0]
04-12 18:24:13.359+0200 W/CAPI_APPFW_APP_CONTROL( 6058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:24:13.359+0200 W/CAPI_APPFW_APP_CONTROL( 6058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:24:13.359+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6059
04-12 18:24:13.359+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:24:13.369+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:24:13.379+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6058
04-12 18:24:13.379+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:24:13.389+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:24:13.399+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6059
04-12 18:24:13.399+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:24:13.419+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:24:13.419+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:24:13.419+0200 W/APP_CORE( 6014): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 18:24:13.419+0200 W/APP_CORE( 6014): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[601084] for es.ugr.frailty.frailtylauncher[6014]
04-12 18:24:13.449+0200 I/APP_CORE( 6014): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 18:24:13.459+0200 I/APP_CORE( 6014): appcore-efl.c: __after_loop(1234) > [APP 6014] PAUSE before termination
04-12 18:24:13.459+0200 I/CAPI_APPFW_APPLICATION( 6014): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 18:24:13.459+0200 I/CAPI_APPFW_APPLICATION( 6014): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 18:24:13.459+0200 I/APP_CORE( 6014): appcore-efl.c: __after_loop(1243) > [APP 6014] After terminate() callback
04-12 18:24:13.459+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:24:13.459+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:24:13.459+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:13.459+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:13.459+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:24:13.469+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 18:24:13.469+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:24:13.469+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:24:13.469+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 18:24:13.469+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 18:24:13.519+0200 I/UXT     ( 6014): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 18:24:13.519+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 18:24:13.529+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 18:24:13.529+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:24:13.529+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:24:13.529+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:24:13.529+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 18:24:13.529+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:24:13.539+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:24:13.539+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:13.539+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:13.539+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:24:13.539+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:24:13.539+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 18:24:13.559+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 18:24:13.559+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): main.c: home_resume(531) > clock/widget resumed
04-12 18:24:13.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:24:13.559+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 18:24:13.559+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:24:13.559+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 18:24:13.559+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-12 18:24:13.559+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-12 18:24:13.559+0200 W/W_INDICATOR( 2666): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-12 18:24:13.559+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(39), length(2)
04-12 18:24:13.559+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 39%
04-12 18:24:13.559+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 39, isCharging: 0
04-12 18:24:13.559+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_40
04-12 18:24:13.559+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-12 18:24:13.569+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_resume(1124) > widget_resume
04-12 18:24:13.569+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(fg) type(watchapp)
04-12 18:24:13.569+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppResume(560) > 
04-12 18:24:13.569+0200 W/SHealthCommon( 2887): SHealthMessagePortConnection.cpp: Send(512) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:24:13.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:13.579+0200 I/CAPI_WIDGET_APPLICATION( 2887): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
04-12 18:24:13.579+0200 W/AUL     ( 2887): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.shealth.widget.pedometer) pid(2887) status(fg) type(widgetapp)
04-12 18:24:13.579+0200 I/CAPI_WIDGET_APPLICATION( 2887): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
04-12 18:24:13.579+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:13.579+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:13.589+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: OnPortMessageReceived(135) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
04-12 18:24:13.589+0200 W/SHealthCommon( 2887): SHealthMessagePortConnection.cpp: Send(512) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:24:13.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:13.589+0200 I/CAPI_WIDGET_APPLICATION( 2887): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
04-12 18:24:13.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:13.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:13.589+0200 W/SHealthCommon( 2887): SHealthMessagePortConnection.cpp: Send(512) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:24:13.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:13.599+0200 I/CAPI_WIDGET_APPLICATION( 2887): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
04-12 18:24:13.599+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: OnPortMessageReceived(135) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
04-12 18:24:13.599+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: OnPortMessageReceived(135) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
04-12 18:24:13.649+0200 I/efl-extension( 6014): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 18:24:13.649+0200 W/AUL_PAD ( 6014): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 18:24:13.669+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6014 pgid = 6014
04-12 18:24:13.669+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 18:24:13.699+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 18:24:13.709+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6014
04-12 18:24:13.709+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6014)
04-12 18:24:13.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:13.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:13.879+0200 W/SHealthWidget( 2887): HrLogWidgetViewController.cpp: OnTimerTick(131) > [1;35m##24Hour Widget Update[0;m
04-12 18:24:13.879+0200 W/WSLib   ( 2887): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1523557453889,000000, pattern:[HH:mm][0;m
04-12 18:24:13.879+0200 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-12 18:24:13.879+0200 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-12 18:24:13.879+0200 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-12 18:24:13.879+0200 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-12 18:24:13.879+0200 E/WSLib   ( 2887): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-12 18:24:13.879+0200 W/WSLib   ( 2887): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[18:24][0;m
04-12 18:24:13.879+0200 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-12 18:24:13.879+0200 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-12 18:24:13.879+0200 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-12 18:24:13.879+0200 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-12 18:24:13.899+0200 W/SHealthAppCommon( 2887): TodayLogItemDataGenerator.cpp: CreateDataList(84) > [1;35m BEGIN >>>>[0;m
04-12 18:24:13.899+0200 W/SHealthAppCommon( 2887): TodayLogItemDataGenerator.cpp: PushSessionEvent(161) > [1;35mTIMELINE :: NOTWEARING Time[2018/4/12 0:0:0 ~ 2018/4/12 18:24:13], Calorie :[1300,284028][0;m
04-12 18:24:13.899+0200 W/SHealthAppCommon( 2887): TodayLogItemDataGenerator.cpp: CreateDataList(112) > [1;35m END <<<<[0;m
04-12 18:24:13.899+0200 W/SHealthAppCommon( 2887): TimeLineWidthVisual.cpp: UpdateTimeLine(570) > [1;35mMODE_HOME[0;m
04-12 18:24:13.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:13.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:13.999+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [9919.263355] layer(0x21e250) not usable
04-12 18:24:13.999+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [9919.263411] layer(0x21e250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 18:24:13.999+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [9919.263437] layer[0x21dcf0]zpos[0]
04-12 18:24:14.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:14.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:14.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:14.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:24:14.559+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:14.559+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:24:14.559+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 18:24:14.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:24:14.579+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 18:24:14.589+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:24:14.589+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:24:14.589+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:24:14.589+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:24:14.589+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:24:14.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:14.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:14.599+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:24:14.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:14.599+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:24:14.599+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:24:14.599+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:24:14.599+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:24:14.609+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:24:14.609+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:24:14.609+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:14.609+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:24:14.609+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:24:14.609+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 18:24:14.609+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:24:14.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:24:14.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:14.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:14.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:14.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:15.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:15.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:15.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:15.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:15.419+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:24:15.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:15.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:15.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:15.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:15.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:15.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:16.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:16.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:16.309+0200 I/servicemanager( 6055): accelerometer alive timeout
04-12 18:24:16.309+0200 W/AUL     ( 6055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:24:16.309+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:24:16.309+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6055
04-12 18:24:16.329+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6066
04-12 18:24:16.329+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:24:16.379+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6066
04-12 18:24:16.379+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6066) type(svcapp) bg(0)
04-12 18:24:16.379+0200 W/AUL     ( 6055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6066)
04-12 18:24:16.379+0200 I/servicemanager( 6055): es.ugr.frailty.accelerometer launch request sent!
04-12 18:24:16.379+0200 I/servicemanager( 6055): App control destroyed.
04-12 18:24:16.379+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6066]
04-12 18:24:16.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:16.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:16.409+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:24:16.419+0200 E/CAPI_APPFW_APPLICATION( 6066): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:24:16.419+0200 E/CAPI_APPFW_APPLICATION( 6066): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:24:16.419+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6066
04-12 18:24:16.419+0200 I/accelerometer( 6066): Starting es.ugr.frailty.accelerometer service
04-12 18:24:16.429+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6066) was created
04-12 18:24:16.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:24:16.439+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:24:16.439+0200 I/accelerometer( 6066): sensor supported
04-12 18:24:16.449+0200 I/accelerometer( 6066): es.ugr.frailty.accelerometer listener started
04-12 18:24:16.449+0200 W/CAPI_APPFW_APP_CONTROL( 6066): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:24:16.449+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6066
04-12 18:24:16.449+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:24:16.579+0200 W/AUL     ( 6081): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:24:16.579+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:24:16.579+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:24:16.579+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6066
04-12 18:24:16.579+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:24:16.589+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6066
04-12 18:24:16.589+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6066)
04-12 18:24:16.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:24:16.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:24:16.649+0200 W/CRASH_MANAGER( 6080): worker.c: worker_job(1205) > 1106066616363152355025
