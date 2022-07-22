S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 8049
Date: 2018-04-12 18:52:36+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x8bc42a00
r4   = 0xf7521e89, r5   = 0xf72567fc
r6   = 0x00000000, r7   = 0xfff9a408
r8   = 0x00000041, r9   = 0xf709d824
r10  = 0xf7c2ff00, fp   = 0x00000000
ip   = 0xf73f20b0, sp   = 0xfff9a158
lr   = 0xf7521f79, pc   = 0xf73f20b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     61032 KB
Buffers:     46172 KB
Cached:     221292 KB
VmPeak:      45580 KB
VmSize:      45004 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7108 KB
VmRSS:        7108 KB
VmData:      35176 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8049 TID = 8049
8049 8058 8059 8060 8061 

Maps Information
f4b2e000 f532d000 rw-p [stack:8061]
f532e000 f5b2d000 rw-p [stack:8060]
f5b2e000 f632d000 rw-p [stack:8059]
f632e000 f6b31000 rw-p [stack:8058]
f6b31000 f6b34000 r-xp /lib/libattr.so.1.1.0
f6b3c000 f6b43000 r-xp /lib/libcrypt-2.13.so
f6b74000 f6b77000 r-xp /lib/libcap.so.2.21
f6b7f000 f6b81000 r-xp /usr/lib/libiri.so
f6b89000 f6b8b000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b93000 f6b95000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b9e000 f6c6a000 r-xp /usr/lib/libxml2.so.2.7.8
f6c78000 f6c95000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c9e000 f6ca2000 r-xp /usr/lib/libsmack.so.1.0.0
f6cab000 f6cc1000 r-xp /lib/libz.so.1.2.5
f6cc9000 f6ccb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cd3000 f6cd8000 r-xp /usr/lib/libffi.so.5.0.10
f6ce0000 f6ce1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ce9000 f6cf9000 r-xp /lib/libresolv-2.13.so
f6cfd000 f6d15000 r-xp /usr/lib/liblzma.so.5.0.3
f6d1d000 f6d1f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d27000 f6d41000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d49000 f6d78000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d81000 f6d90000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d99000 f6da3000 r-xp /usr/lib/libsensord-shared.so
f6dac000 f6de0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6de9000 f6ebc000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ec7000 f6ecd000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ed6000 f6f4b000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f55000 f6f5b000 r-xp /lib/librt-2.13.so
f6f64000 f6f82000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f8c000 f6f8d000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f95000 f6fb8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fc0000 f6fc5000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fcd000 f709d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f709e000 f70c8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70d1000 f70e8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70f0000 f7159000 r-xp /lib/libm-2.13.so
f7162000 f71f6000 r-xp /usr/lib/libstdc++.so.6.0.16
f7209000 f720e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7216000 f721d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7225000 f724f000 r-xp /usr/lib/libsensor.so.1.9.6
f7258000 f725b000 r-xp /usr/lib/libbundle.so.0.1.22
f7263000 f7269000 r-xp /usr/lib/libappsvc.so.0.1.0
f7271000 f72b2000 r-xp /usr/lib/libeina.so.1.7.99
f72bb000 f72d2000 r-xp /usr/lib/libecore.so.1.7.99
f72e9000 f72f2000 r-xp /usr/lib/libvconf.so.0.2.45
f72fa000 f730e000 r-xp /lib/libpthread-2.13.so
f7319000 f7326000 r-xp /usr/lib/libaul.so.0.1.0
f7330000 f7332000 r-xp /lib/libdl-2.13.so
f733b000 f7346000 r-xp /lib/libunwind.so.8.0.1
f7373000 f737b000 r-xp /lib/libgcc_s-4.6.so.1
f737c000 f74a0000 r-xp /lib/libc-2.13.so
f74ae000 f74b0000 r-xp /usr/lib/libdlog.so.0.0.0
f74b8000 f74c4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74cd000 f74d1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74da000 f74dd000 r-xp /usr/lib/libappcore-agent.so.1.1
f74fb000 f7518000 r-xp /lib/ld-2.13.so
f7521000 f7523000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f7523000 f7527000 r-xp /usr/lib/libsys-assert.so
f7c25000 f7c67000 rw-p [heap]
fff7b000 fff9c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8049)
Call Stack Count: 1
 0: strlen + 0x4 (0xf73f20b4) [/lib/libc.so.6] + 0x760b4
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
d_main_loop(611) > Launch on type-based process-pool
04-12 18:52:31.579+0200 W/AUL_PAD ( 3381): launchpad.c: __send_result_to_caller(272) > Check app launching
04-12 18:52:31.579+0200 W/AUL_PAD ( 7997): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
04-12 18:52:31.579+0200 W/AUL_PAD ( 7997): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
04-12 18:52:31.579+0200 W/AUL_PAD ( 7997): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
04-12 18:52:31.579+0200 W/AUL_PAD ( 7997): launchpad_loader.c: main(680) > [candidate] dlopen(es.ugr.frailty.frailtylauncher)
04-12 18:52:31.599+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:52:31.629+0200 I/efl-extension( 7997): efl_extension.c: eext_mod_init(40) > Init
04-12 18:52:31.629+0200 I/UXT     ( 7997): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-12 18:52:31.629+0200 W/AUL_PAD ( 7997): launchpad_loader.c: main(690) > [candidate] dlsym
04-12 18:52:31.629+0200 W/AUL_PAD ( 7997): launchpad_loader.c: main(694) > [candidate] dl_main(es.ugr.frailty.frailtylauncher)
04-12 18:52:31.639+0200 I/CAPI_APPFW_APPLICATION( 7997): app_main.c: ui_app_main(704) > app_efl_main
04-12 18:52:31.639+0200 I/CAPI_APPFW_APPLICATION( 7997): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-12 18:52:31.679+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.frailtylauncher) pid(7997) type(uiapp) bg(0)
04-12 18:52:31.679+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:31.689+0200 W/AUL     ( 7986): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7997)
04-12 18:52:31.689+0200 E/W_TASKMANAGER( 7986): task.c: taskmanager_launch_task_info(1075) > [taskmanager_launch_task_info:1075] _launch_app() failed(7997)
04-12 18:52:31.689+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7997]
04-12 18:52:31.689+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7986
04-12 18:52:31.689+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7997) was created
04-12 18:52:31.689+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:31.699+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7986
04-12 18:52:31.699+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:31.699+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 18:52:31.699+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:31.749+0200 E/EFL     ( 7997): ecore_evas<7997> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
04-12 18:52:31.829+0200 I/APP_CORE( 7997): appcore-efl.c: __do_app(453) > [APP 7997] Event: RESET State: CREATED
04-12 18:52:31.829+0200 I/CAPI_APPFW_APPLICATION( 7997): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-12 18:52:31.839+0200 I/APP_CORE( 7997): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-12 18:52:31.839+0200 I/APP_CORE( 7997): appcore-efl.c: __do_app(524) > [APP 7997] Initial Launching, call the resume_cb
04-12 18:52:31.839+0200 I/CAPI_APPFW_APPLICATION( 7997): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-12 18:52:31.849+0200 W/APP_CORE( 7997): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2c00002
04-12 18:52:31.899+0200 I/APP_CORE( 7986): appcore-efl.c: __do_app(453) > [APP 7986] Event: PAUSE State: RUNNING
04-12 18:52:31.899+0200 I/CAPI_APPFW_APPLICATION( 7986): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-12 18:52:31.909+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[7986] goes to (4)
04-12 18:52:31.909+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(7986) status(bg) type(uiapp)
04-12 18:52:31.919+0200 I/APP_CORE( 7997): appcore-efl.c: __do_app(453) > [APP 7997] Event: RESUME State: RUNNING
04-12 18:52:31.919+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[7997] goes to (3)
04-12 18:52:31.919+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(7997) status(fg) type(uiapp)
04-12 18:52:32.009+0200 I/efl-extension( 8024): efl_extension.c: eext_mod_init(40) > Init
04-12 18:52:32.069+0200 I/UXT     ( 8024): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-12 18:52:32.099+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:52:32.099+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:52:32.109+0200 E/APP_CORE( 7986): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
04-12 18:52:32.109+0200 I/APP_CORE( 7986): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 18:52:32.109+0200 I/CAPI_APPFW_APPLICATION( 7986): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0xf7de9970, obj: 0xf7de9970
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: _object_deleted_cb(618) > done
04-12 18:52:32.109+0200 E/EFL     ( 7986): elementary<7986> elm_interface_scrollable.c:1962 _elm_scroll_content_region_show_internal() [0xf7de9970 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0xf7e080c0
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0xf7df8d50 is freed
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7de9970, elm_scroller, func : 0xf3daa419
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7e080c0, elm_image, func : 0xf3daa419
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-12 18:52:32.109+0200 I/efl-extension( 7986): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0xf7de9970 : elm_scroller] rotary callabck is deleted
04-12 18:52:32.119+0200 I/APP_CORE( 7986): appcore-efl.c: __after_loop(1243) > [APP 7986] After terminate() callback
04-12 18:52:32.159+0200 I/AUL_PAD ( 8024): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 18:52:32.169+0200 I/UXT     ( 7986): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
04-12 18:52:32.169+0200 I/UXT     ( 7986): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
04-12 18:52:32.169+0200 I/UXT     ( 7986): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 18:52:32.199+0200 E/MALI    ( 8024): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
04-12 18:52:32.289+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 18:52:32.309+0200 W/AUL_PAD ( 7986): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 18:52:32.309+0200 I/efl-extension( 7986): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 18:52:32.749+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7986 pgid = 7986
04-12 18:52:32.749+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 18:52:32.799+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:32.809+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7997
04-12 18:52:32.809+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:32.829+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:32.839+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 18:52:32.839+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7997
04-12 18:52:32.839+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7986
04-12 18:52:32.839+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7986)
04-12 18:52:32.849+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:33.039+0200 I/AUL_PAD ( 8035): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 18:52:33.269+0200 E/EFL     ( 7997): ecore_x<7997> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11618530 button=1
04-12 18:52:33.269+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] mouse move
04-12 18:52:33.269+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] mouse move
04-12 18:52:33.269+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] hold(0), freeze(0)
04-12 18:52:33.279+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] mouse move
04-12 18:52:33.279+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] hold(0), freeze(0)
04-12 18:52:33.289+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] mouse move
04-12 18:52:33.289+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] hold(0), freeze(0)
04-12 18:52:33.299+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] mouse move
04-12 18:52:33.299+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] hold(0), freeze(0)
04-12 18:52:33.309+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] mouse move
04-12 18:52:33.309+0200 E/EFL     ( 7997): elementary<7997> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7a4e1d0 : elm_list] hold(0), freeze(0)
04-12 18:52:33.349+0200 E/EFL     ( 7997): ecore_x<7997> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11618617 button=1
04-12 18:52:33.359+0200 W/AUL     ( 7997): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 18:52:33.359+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:52:33.359+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7997
04-12 18:52:33.369+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8038
04-12 18:52:33.369+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:52:33.399+0200 E/CAPI_APPFW_APPLICATION( 8038): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:52:33.399+0200 E/CAPI_APPFW_APPLICATION( 8038): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:52:33.399+0200 W/AUL     ( 8038): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 18:52:33.419+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8038
04-12 18:52:33.419+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(8038) type(svcapp) bg(0)
04-12 18:52:33.419+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:52:33.419+0200 W/AUL     ( 7997): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8038)
04-12 18:52:33.419+0200 I/utils   ( 7997): es.ugr.frailty.servicemanager launch request sent!
04-12 18:52:33.419+0200 I/utils   ( 7997): App control destroyed.
04-12 18:52:33.419+0200 I/CAPI_APPFW_APPLICATION( 7997): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 18:52:33.419+0200 I/CAPI_APPFW_APPLICATION( 7997): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 18:52:33.429+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8038]
04-12 18:52:33.429+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8038
04-12 18:52:33.449+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8041
04-12 18:52:33.449+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:52:33.479+0200 E/CAPI_APPFW_APPLICATION( 8041): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:52:33.479+0200 E/CAPI_APPFW_APPLICATION( 8041): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:52:33.499+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8041
04-12 18:52:33.499+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(8041) type(svcapp) bg(0)
04-12 18:52:33.499+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8038) was created
04-12 18:52:33.499+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8041) was created
04-12 18:52:33.499+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:33.499+0200 W/AUL     ( 8038): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8041)
04-12 18:52:33.499+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8041]
04-12 18:52:33.509+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8038
04-12 18:52:33.509+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:33.519+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8038
04-12 18:52:33.519+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:33.519+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:33.519+0200 I/servicemanager( 8038): es.ugr.frailty.httppostreq launch request sent!
04-12 18:52:33.529+0200 I/servicemanager( 8038): App control destroyed.
04-12 18:52:33.529+0200 W/AUL     ( 8038): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 18:52:33.539+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:52:33.539+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8038
04-12 18:52:33.549+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8044
04-12 18:52:33.549+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:52:33.559+0200 E/CAPI_APPFW_APPLICATION( 8044): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:52:33.579+0200 E/CAPI_APPFW_APPLICATION( 8044): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:52:33.579+0200 W/CAPI_APPFW_APP_CONTROL( 8044): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:52:33.589+0200 W/CAPI_APPFW_APP_CONTROL( 8044): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:52:33.599+0200 I/CAPI_NETWORK_CONNECTION( 8041): connection.c: connection_create(453) > New handle created[0xf7892be0]
04-12 18:52:33.599+0200 W/CAPI_APPFW_APP_CONTROL( 8041): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:52:33.599+0200 W/CAPI_APPFW_APP_CONTROL( 8041): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:52:33.599+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8044
04-12 18:52:33.599+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(8044) type(svcapp) bg(0)
04-12 18:52:33.599+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:33.609+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8041
04-12 18:52:33.609+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8044) was created
04-12 18:52:33.609+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:33.619+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8044]
04-12 18:52:33.619+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8041
04-12 18:52:33.619+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:33.619+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:33.629+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:33.639+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8044
04-12 18:52:33.639+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:33.649+0200 W/AUL     ( 8038): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8044)
04-12 18:52:33.649+0200 I/servicemanager( 8038): es.ugr.frailty.recorder launch request sent!
04-12 18:52:33.649+0200 I/servicemanager( 8038): App control destroyed.
04-12 18:52:33.649+0200 I/servicemanager( 8038): Frailty Service Manager created
04-12 18:52:33.649+0200 W/CAPI_APPFW_APP_CONTROL( 8038): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:52:33.649+0200 W/CAPI_APPFW_APP_CONTROL( 8038): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:52:33.649+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:33.659+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8044
04-12 18:52:33.659+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:33.699+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:52:33.699+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:52:33.699+0200 W/APP_CORE( 7997): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 18:52:33.709+0200 W/APP_CORE( 7997): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2c00002] -> redirected win[602a64] for es.ugr.frailty.frailtylauncher[7997]
04-12 18:52:33.729+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 18:52:33.749+0200 I/APP_CORE( 7997): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 18:52:33.749+0200 I/APP_CORE( 7997): appcore-efl.c: __after_loop(1234) > [APP 7997] PAUSE before termination
04-12 18:52:33.749+0200 I/CAPI_APPFW_APPLICATION( 7997): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 18:52:33.749+0200 I/CAPI_APPFW_APPLICATION( 7997): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 18:52:33.749+0200 I/APP_CORE( 7997): appcore-efl.c: __after_loop(1243) > [APP 7997] After terminate() callback
04-12 18:52:33.759+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:52:33.759+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:52:33.759+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:52:33.759+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:52:33.759+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:52:33.759+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 18:52:33.759+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 18:52:33.759+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:52:33.759+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:52:33.759+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 18:52:33.769+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:52:33.819+0200 I/UXT     ( 7997): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 18:52:33.839+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:52:33.849+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 18:52:33.859+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 18:52:33.869+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 18:52:33.879+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 18:52:33.889+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 18:52:33.889+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:52:33.889+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:52:33.889+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:52:33.889+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:52:33.889+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:52:33.899+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 18:52:33.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:52:33.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:52:33.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:52:33.899+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 18:52:33.899+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:52:33.899+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 18:52:33.919+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 18:52:33.919+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:52:33.919+0200 W/APPS    ( 2742): apps_main.c: _time_changed_cb(308) >  date : 12->12
04-12 18:52:33.919+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): rotary.c: rotary_attach(138) > rotary_attach:0xf8477e70
04-12 18:52:33.919+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf8477e70, elm_layout, _activated_obj : 0xf83b6fd0, activated : 1
04-12 18:52:33.919+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 18:52:33.919+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 18:52:33.919+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 18:52:33.919+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:52:33.919+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 18:52:33.929+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:52:33.929+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:52:33.939+0200 I/efl-extension( 7997): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 18:52:33.949+0200 W/AUL_PAD ( 7997): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 18:52:33.959+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7997 pgid = 7997
04-12 18:52:33.959+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 18:52:33.989+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 18:52:33.989+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7997
04-12 18:52:33.989+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7997)
04-12 18:52:34.099+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:52:34.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:52:34.929+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:52:34.929+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 18:52:34.939+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:34.949+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 18:52:34.949+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:52:34.949+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:52:34.949+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:52:34.949+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:52:34.949+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:52:34.959+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:52:34.959+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:52:34.959+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:52:34.959+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:52:34.959+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:52:34.959+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:52:34.959+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:52:34.959+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:52:34.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:52:34.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:52:34.969+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:52:34.969+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:52:34.969+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 18:52:34.979+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:52:34.979+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:52:35.709+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:52:36.649+0200 I/servicemanager( 8038): accelerometer alive timeout
04-12 18:52:36.649+0200 W/AUL     ( 8038): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:52:36.649+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:52:36.649+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8038
04-12 18:52:36.669+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:52:36.679+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8049
04-12 18:52:36.729+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8049
04-12 18:52:36.729+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(8049) type(svcapp) bg(0)
04-12 18:52:36.729+0200 W/AUL     ( 8038): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8049)
04-12 18:52:36.739+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8049]
04-12 18:52:36.739+0200 I/servicemanager( 8038): es.ugr.frailty.accelerometer launch request sent!
04-12 18:52:36.739+0200 I/servicemanager( 8038): App control destroyed.
04-12 18:52:36.759+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:36.769+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8049
04-12 18:52:36.769+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:36.779+0200 E/CAPI_APPFW_APPLICATION( 8049): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:52:36.779+0200 E/CAPI_APPFW_APPLICATION( 8049): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:52:36.779+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8049) was created
04-12 18:52:36.779+0200 I/accelerometer( 8049): Starting es.ugr.frailty.accelerometer service
04-12 18:52:36.789+0200 I/accelerometer( 8049): sensor supported
04-12 18:52:36.789+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:52:36.799+0200 I/accelerometer( 8049): es.ugr.frailty.accelerometer listener started
04-12 18:52:36.799+0200 W/CAPI_APPFW_APP_CONTROL( 8049): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:52:36.799+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8049
04-12 18:52:36.799+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:52:36.809+0200 I/utils   ( 8049): accelerometer utils fecha 12/04/2018,18:52:36
04-12 18:52:36.809+0200 I/accelerometer( 8049): accelerometer fecha conseguida
04-12 18:52:36.809+0200 I/accelerometer( 8049): accelerometer fecha 12/04/2018,18:52:36
04-12 18:52:36.809+0200 I/accelerometer( 8049): accelerometer: 12/04/2018,18:52:36,0.196211,0.052642,9.767502
04-12 18:52:36.899+0200 W/AUL     ( 8065): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:52:36.899+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:52:36.899+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:52:36.899+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8049
04-12 18:52:36.899+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:52:36.899+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8049
04-12 18:52:36.899+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8049)
04-12 18:52:36.959+0200 W/CRASH_MANAGER( 8064): worker.c: worker_job(1205) > 1108049616363152355195
