S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7664
Date: 2018-06-12 13:48:21+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70ba52d, r5   = 0xf773dfe0
r6   = 0xffb1b0e0, r7   = 0xffb1af90
r8   = 0xf770fc18, r9   = 0x00000000
r10  = 0xffb1b06c, fp   = 0xffb1b0e0
ip   = 0x00000001, sp   = 0xffb1af68
lr   = 0xf70ba539, pc   = 0xf7123228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    182000 KB
Buffers:     28272 KB
Cached:     137992 KB
VmPeak:      53444 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11852 KB
VmRSS:       11852 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7664 TID = 7664
7664 7747 

Maps Information
f3f85000 f4784000 rw-p [stack:7747]
f478b000 f478d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4795000 f4799000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47a2000 f47a4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47ac000 f47af000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47be000 f47c3000 r-xp /usr/lib/libsystem.so.0.0.0
f47ce000 f47d1000 r-xp /lib/libattr.so.1.1.0
f47d9000 f47e9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47f1000 f47fa000 r-xp /usr/lib/libedbus.so.1.7.99
f4802000 f4803000 r-xp /usr/lib/libresponse.so.0.2.96
f480c000 f4811000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60b3000 f61b9000 r-xp /usr/lib/libicuuc.so.57.1
f61cf000 f6357000 r-xp /usr/lib/libicui18n.so.57.1
f6367000 f6374000 r-xp /usr/lib/libail.so.0.1.0
f637d000 f6384000 r-xp /usr/lib/libminizip.so.1.0.0
f638d000 f6536000 r-xp /usr/lib/libcrypto.so.1.0.0
f6556000 f659d000 r-xp /usr/lib/libssl.so.1.0.0
f65a9000 f65ab000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65b3000 f65ba000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65c3000 f65ca000 r-xp /lib/libcrypt-2.13.so
f65fb000 f65fe000 r-xp /lib/libcap.so.2.21
f6606000 f6608000 r-xp /usr/lib/libiri.so
f6610000 f6659000 r-xp /usr/lib/libmdm.so.1.2.69
f6661000 f6667000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f666f000 f6692000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f669c000 f669e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66a6000 f66c3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66cc000 f66d0000 r-xp /usr/lib/libsmack.so.1.0.0
f66d9000 f66f2000 r-xp /usr/lib/libnetwork.so.0.0.0
f66fb000 f6703000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f670b000 f6711000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f671a000 f671c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6725000 f6735000 r-xp /lib/libresolv-2.13.so
f6739000 f6751000 r-xp /usr/lib/liblzma.so.5.0.3
f675a000 f675c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6764000 f677e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6786000 f67b5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67be000 f67cd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67d7000 f67e1000 r-xp /usr/lib/libsensord-shared.so
f67ea000 f68bd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68c8000 f68de000 r-xp /lib/libz.so.1.2.5
f68e6000 f68eb000 r-xp /usr/lib/libffi.so.5.0.10
f68f3000 f68f4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68fc000 f690c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6914000 f692d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6935000 f6937000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f693f000 f69b4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69be000 f69c4000 r-xp /lib/librt-2.13.so
f69cd000 f69eb000 r-xp /usr/lib/libsystemd.so.0.4.0
f69f5000 f69f6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69fe000 f6a21000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a29000 f6a2e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a36000 f6a60000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a69000 f6a80000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a88000 f6af1000 r-xp /lib/libm-2.13.so
f6afa000 f6b8e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ba1000 f6ba6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bae000 f6bb5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bbd000 f6be7000 r-xp /usr/lib/libsensor.so.1.9.6
f6bf0000 f6cbc000 r-xp /usr/lib/libxml2.so.2.7.8
f6cc9000 f6ccb000 r-xp /usr/lib/libiniparser.so.0
f6cd4000 f6cda000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ce3000 f6db3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6db4000 f6de8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6df1000 f6e2d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e35000 f6e38000 r-xp /usr/lib/libbundle.so.0.1.22
f6e40000 f6e46000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e4e000 f6e8f000 r-xp /usr/lib/libeina.so.1.7.99
f6e98000 f6eaf000 r-xp /usr/lib/libecore.so.1.7.99
f6ec6000 f6ecf000 r-xp /usr/lib/libvconf.so.0.2.45
f6ed7000 f6eeb000 r-xp /lib/libpthread-2.13.so
f6ef6000 f6f03000 r-xp /usr/lib/libaul.so.0.1.0
f6f0d000 f6f0f000 r-xp /lib/libdl-2.13.so
f6f18000 f6f23000 r-xp /lib/libunwind.so.8.0.1
f6f50000 f6f58000 r-xp /lib/libgcc_s-4.6.so.1
f6f59000 f707d000 r-xp /lib/libc-2.13.so
f708b000 f708d000 r-xp /usr/lib/libdlog.so.0.0.0
f7095000 f70a1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70aa000 f70af000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70b7000 f70c6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70ce000 f70d2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70db000 f70de000 r-xp /usr/lib/libappcore-agent.so.1.1
f70e6000 f70e8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70f0000 f70f4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70fc000 f7119000 r-xp /lib/ld-2.13.so
f7122000 f7125000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7125000 f7129000 r-xp /usr/lib/libsys-assert.so
f7709000 f7777000 rw-p [heap]
ffafc000 ffb1d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7664)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7123228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70ba539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dc13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dbfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dcbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dd1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dd1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e0675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e011f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dbfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dcbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dd1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dd1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e03e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e04017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e0bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47a31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4796171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6869663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d16fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d187a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ea8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ea3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ea45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ea4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70dc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70dc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71235c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f7085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7122f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ontrol:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): main.c: _window_visibility_cb(964) > Window [0x2200003] is now visible(0)
06-12 13:48:20.701+0200 I/APP_CORE( 6202): appcore-efl.c: __do_app(453) > [APP 6202] Event: RESUME State: PAUSED
06-12 13:48:20.701+0200 I/CAPI_APPFW_APPLICATION( 6202): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): main.c: _appcore_resume_cb(479) > appcore resume
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-12 13:48:20.701+0200 W/APPS    ( 6202): apps_main.c: _time_changed_cb(308) >  date : 12->12
06-12 13:48:20.701+0200 W/APPS    ( 6202): AppsItem.cpp: onItemBadgeShow(686) >  badge show:[6:1]
06-12 13:48:20.701+0200 W/APPS    ( 6202): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): rotary.c: rotary_attach(138) > rotary_attach:0xed639d80
06-12 13:48:20.701+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xed639d80, elm_layout, _activated_obj : 0xf77d0238, activated : 1
06-12 13:48:20.701+0200 I/efl-extension( 6202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): win.c: win_back_gesture_disable_set(170) > disable back gesture
06-12 13:48:20.701+0200 W/W_HOME  ( 6202): win.c: win_back_gesture_disable_set(170) > disable back gesture
06-12 13:48:20.701+0200 I/wnotib  ( 6202): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
06-12 13:48:20.701+0200 E/wnotib  ( 6202): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-12 13:48:20.701+0200 W/wnotib  ( 6202): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
06-12 13:48:20.711+0200 W/healthData( 6251): health_fw_share.c: __health_notify_share_cb(331) > [1;40;33mNotification is called [category:shealth_pedometer_info][0;m
06-12 13:48:20.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:20.721+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.525722] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7647
06-12 13:48:20.731+0200 W/W_INDICATOR( 2694): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-12 13:48:20.731+0200 W/W_INDICATOR( 2694): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-12 13:48:20.731+0200 I/heartrate( 7661): es.ugr.frailty.heartrate - capturing data
06-12 13:48:20.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:20.731+0200 I/heartrate( 7661): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:48:20.741+0200 W/AUL     ( 7703): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:20.751+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.552735] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.751+0200 W/AUL     ( 7647): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:20.751+0200 I/accelerometer( 7647): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:20.751+0200 I/accelerometer( 7647): es.ugr.frailty.accelerometer - capturing data
06-12 13:48:20.761+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.564896] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:20.761+0200 I/healthData( 6349): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-12 13:48:20.761+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7703
06-12 13:48:20.771+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.575597] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.781+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:20.791+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 13:48:20.791+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:48:20.791+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 13:48:20.791+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.593673] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.801+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.605162] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.821+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.622610] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.841+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.640330] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.851+0200 W/AUL_PAD ( 3389): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-12 13:48:20.851+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.656101] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.871+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.672494] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.881+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.881+0200 I/utils   ( 7640): specific action
06-12 13:48:20.891+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7627
06-12 13:48:20.891+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7627)
06-12 13:48:20.891+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.891+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.891+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.891+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.891+0200 I/servicemanager( 7640): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 13:48:20.891+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:48:20.891+0200 I/gyroscope( 7660): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:48:20:581,-4.620000,-0.490000,1.120000
06-12 13:48:20.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:20.901+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7640
06-12 13:48:20.911+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.709165] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.911+0200 I/linearacceleration( 7665): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:48:20:579,0.036813,-0.217575,0.083705
06-12 13:48:20.911+0200 W/AUL     ( 7665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:20.911+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7643
06-12 13:48:20.911+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.911+0200 I/utils   ( 7643): specific action
06-12 13:48:20.911+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.911+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.911+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.911+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.911+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.911+0200 I/recorder( 7643): saving local data for es.ugr.frailty.linearacceleration
06-12 13:48:20.911+0200 I/recorder( 7643): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 13:48:20.921+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.726201] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.921+0200 I/heartrate( 7661): es.ugr.frailty.heartrate - capturing data
06-12 13:48:20.931+0200 I/heartrate( 7661): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:48:20.941+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.740526] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.941+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7643)
06-12 13:48:20.941+0200 I/servicemanager( 7640): request sent to service es.ugr.frailty.recorder
06-12 13:48:20.941+0200 I/servicemanager( 7640): requesting to save local data
06-12 13:48:20.941+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.941+0200 I/utils   ( 7640): specific action
06-12 13:48:20.941+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:20.941+0200 I/servicemanager( 7640): requesting to save local data for es.ugr.frailty.gyroscope
06-12 13:48:20.941+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:48:20.951+0200 I/UXT     ( 7756): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-12 13:48:20.951+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:20.951+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(81) , send fd(21), pid(7643), cmd(0)
06-12 13:48:20.951+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.758175] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.961+0200 W/AUL     ( 7660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:20.961+0200 I/accelerometer( 7647): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:48:20:757,-1.931008,6.862615,6.685547
06-12 13:48:20.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:20.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7640
06-12 13:48:20.971+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.772632] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.971+0200 W/AUL     ( 7703): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:20.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7643
06-12 13:48:20.981+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.788837] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:20.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:20.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(21), pid(7640), cmd(0)
06-12 13:48:21.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7660
06-12 13:48:21.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.021+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.825195] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.021+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.021+0200 I/utils   ( 7643): specific action
06-12 13:48:21.021+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.021+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.021+0200 I/recorder( 7643): saving local data for es.ugr.frailty.gyroscope
06-12 13:48:21.021+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7643)
06-12 13:48:21.021+0200 I/recorder( 7643): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 13:48:21.021+0200 I/servicemanager( 7640): request sent to service es.ugr.frailty.recorder
06-12 13:48:21.031+0200 I/servicemanager( 7640): requesting to save local data
06-12 13:48:21.031+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.031+0200 I/utils   ( 7640): specific action
06-12 13:48:21.031+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.031+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.031+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.041+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.041+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.840785] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.041+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.041+0200 W/AUL     ( 7660): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.041+0200 I/gyroscope( 7660): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.041+0200 I/gyroscope( 7660): es.ugr.frailty.gyroscope - capturing data
06-12 13:48:21.041+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.041+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.041+0200 I/servicemanager( 7640): requesting to save local data for es.ugr.frailty.light
06-12 13:48:21.041+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:48:21.041+0200 W/AUL     ( 7671): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.041+0200 I/gravity ( 7671): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.041+0200 I/light   ( 7703): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.041+0200 I/gravity ( 7671): es.ugr.frailty.gravity - capturing data
06-12 13:48:21.041+0200 I/gyroscope( 7660): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:48:21:45,-5.320000,-0.700000,-1.750000
06-12 13:48:21.041+0200 W/AUL     ( 7660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.041+0200 I/light   ( 7703): es.ugr.frailty.light - capturing data
06-12 13:48:21.051+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.856516] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7665
06-12 13:48:21.061+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 13:48:21.061+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 13:48:21.061+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 13:48:21.061+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 13:48:21.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.071+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.873687] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.071+0200 W/AUL     ( 7665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.071+0200 I/linearacceleration( 7665): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.071+0200 I/linearacceleration( 7665): es.ugr.frailty.linearacceleration - capturing data
06-12 13:48:21.081+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:21.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(43) , send fd(21), pid(7640), cmd(0)
06-12 13:48:21.081+0200 I/heartrate( 7661): es.ugr.frailty.heartrate - capturing data
06-12 13:48:21.081+0200 I/heartrate( 7661): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:48:21.091+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.892754] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.091+0200 W/AUL     ( 7647): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.091+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:21.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(81) , send fd(21), pid(7643), cmd(0)
06-12 13:48:21.101+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.905564] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7640
06-12 13:48:21.111+0200 I/gravity ( 7671): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:48:21:48,-1.896149,7.086069,6.508658
06-12 13:48:21.111+0200 W/AUL     ( 7671): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.111+0200 I/linearacceleration( 7665): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:48:21:82,-0.103385,-0.292796,0.076382
06-12 13:48:21.111+0200 W/AUL     ( 7665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.111+0200 I/light   ( 7703): es.ugr.frailty.light: SM-R760,12/06/2018,13:48:21:50,90.000000
06-12 13:48:21.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7643
06-12 13:48:21.121+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.924675] pp(0x509338) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.121+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.121+0200 I/utils   ( 7643): specific action
06-12 13:48:21.121+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.121+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.121+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.121+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.121+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.121+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.121+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.121+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.131+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7643)
06-12 13:48:21.131+0200 I/servicemanager( 7640): request sent to service es.ugr.frailty.recorder
06-12 13:48:21.131+0200 I/servicemanager( 7640): requesting to save local data
06-12 13:48:21.131+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.131+0200 I/utils   ( 7640): specific action
06-12 13:48:21.131+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.131+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.131+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.131+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.131+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.131+0200 I/servicemanager( 7640): requesting to save local data for es.ugr.frailty.gravity
06-12 13:48:21.131+0200 I/recorder( 7643): saving local data for es.ugr.frailty.light
06-12 13:48:21.131+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:48:21.131+0200 I/recorder( 7643): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 13:48:21.141+0200 W/AUL     ( 7703): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.151+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7660
06-12 13:48:21.161+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.171+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2552.972487] pp(0x501d60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.181+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:21.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(44) , send fd(21), pid(7640), cmd(0)
06-12 13:48:21.181+0200 W/AUL     ( 7660): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.181+0200 I/gyroscope( 7660): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.181+0200 I/gyroscope( 7660): es.ugr.frailty.gyroscope - capturing data
06-12 13:48:21.191+0200 I/gyroscope( 7660): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:48:21:192,-1.680000,0.420000,1.400000
06-12 13:48:21.191+0200 W/AUL     ( 7660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.191+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:21.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(43) , send fd(21), pid(7643), cmd(0)
06-12 13:48:21.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7647
06-12 13:48:21.211+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2553.018059] pp(0x569308) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.221+0200 I/AUL_PAD ( 7756): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-12 13:48:21.231+0200 W/AUL     ( 7647): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.231+0200 I/accelerometer( 7647): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.231+0200 I/accelerometer( 7647): es.ugr.frailty.accelerometer - capturing data
06-12 13:48:21.241+0200 I/accelerometer( 7647): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:48:21:239,-2.009971,6.900900,6.597012
06-12 13:48:21.241+0200 W/AUL     ( 7647): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.251+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7671
06-12 13:48:21.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.271+0200 W/AUL     ( 7671): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.271+0200 I/gravity ( 7671): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.271+0200 I/gravity ( 7671): es.ugr.frailty.gravity - capturing data
06-12 13:48:21.271+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2553.077617] pp(0x506980) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.281+0200 I/gravity ( 7671): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:48:21:278,-1.896036,7.073011,6.522878
06-12 13:48:21.281+0200 W/AUL     ( 7671): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7665
06-12 13:48:21.291+0200 E/MALI    ( 7756): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
06-12 13:48:21.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.311+0200 W/AUL     ( 7665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.311+0200 I/linearacceleration( 7665): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.311+0200 I/linearacceleration( 7665): es.ugr.frailty.linearacceleration - capturing data
06-12 13:48:21.311+0200 I/linearacceleration( 7665): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:48:21:314,-0.165196,-0.113586,0.240134
06-12 13:48:21.311+0200 I/heartrate( 7661): es.ugr.frailty.heartrate - capturing data
06-12 13:48:21.311+0200 I/heartrate( 7661): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:48:21.311+0200 W/AUL     ( 7665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7640
06-12 13:48:21.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7643
06-12 13:48:21.341+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.341+0200 I/utils   ( 7643): specific action
06-12 13:48:21.341+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.341+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.341+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.341+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.341+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.341+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.341+0200 I/recorder( 7643): saving local data for es.ugr.frailty.gravity
06-12 13:48:21.341+0200 I/recorder( 7643): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 13:48:21.351+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7643)
06-12 13:48:21.351+0200 I/servicemanager( 7640): request sent to service es.ugr.frailty.recorder
06-12 13:48:21.351+0200 I/servicemanager( 7640): requesting to save local data
06-12 13:48:21.351+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.351+0200 I/utils   ( 7640): specific action
06-12 13:48:21.351+0200 I/servicemanager( 7640): requesting to save local data for es.ugr.frailty.accelerometer
06-12 13:48:21.351+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:48:21.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7703
06-12 13:48:21.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.391+0200 W/AUL     ( 7703): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.391+0200 I/light   ( 7703): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.391+0200 I/light   ( 7703): es.ugr.frailty.light - capturing data
06-12 13:48:21.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:21.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(45) , send fd(21), pid(7640), cmd(0)
06-12 13:48:21.401+0200 I/light   ( 7703): es.ugr.frailty.light: SM-R760,12/06/2018,13:48:21:400,88.000000
06-12 13:48:21.401+0200 W/AUL     ( 7703): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.411+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:21.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(84) , send fd(21), pid(7643), cmd(0)
06-12 13:48:21.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7660
06-12 13:48:21.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.441+0200 W/AUL     ( 7660): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.441+0200 I/gyroscope( 7660): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.441+0200 I/gyroscope( 7660): es.ugr.frailty.gyroscope - capturing data
06-12 13:48:21.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7647
06-12 13:48:21.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.481+0200 I/heartrate( 7661): es.ugr.frailty.heartrate - capturing data
06-12 13:48:21.481+0200 I/heartrate( 7661): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:48:21.491+0200 W/AUL     ( 7647): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7671
06-12 13:48:21.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.521+0200 I/accelerometer( 7647): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.521+0200 I/accelerometer( 7647): es.ugr.frailty.accelerometer - capturing data
06-12 13:48:21.521+0200 W/AUL     ( 7671): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.521+0200 I/gravity ( 7671): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.521+0200 I/gravity ( 7671): es.ugr.frailty.gravity - capturing data
06-12 13:48:21.531+0200 I/gravity ( 7671): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:48:21:527,-1.897015,7.054913,6.542165
06-12 13:48:21.531+0200 W/AUL     ( 7671): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.531+0200 I/accelerometer( 7647): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:48:21:524,-1.868794,6.939186,6.673582
06-12 13:48:21.531+0200 W/AUL     ( 7647): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.541+0200 I/gyroscope( 7660): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:48:21:451,-0.770000,-1.330000,3.850000
06-12 13:48:21.541+0200 W/AUL     ( 7660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.541+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7665
06-12 13:48:21.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.561+0200 W/AUL     ( 7665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.561+0200 I/linearacceleration( 7665): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.571+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7640
06-12 13:48:21.571+0200 I/linearacceleration( 7665): es.ugr.frailty.linearacceleration - capturing data
06-12 13:48:21.571+0200 I/TDM     ( 1862): tdm_pp.c: tdm_pp_set_info(322) > [2553.376677] pp(0x5d1380) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
06-12 13:48:21.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7643
06-12 13:48:21.581+0200 I/linearacceleration( 7665): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:48:21:587,-0.111932,-0.000114,0.224516
06-12 13:48:21.581+0200 W/AUL     ( 7665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.591+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.591+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7643)
06-12 13:48:21.591+0200 I/servicemanager( 7640): request sent to service es.ugr.frailty.recorder
06-12 13:48:21.591+0200 I/servicemanager( 7640): requesting to save local data
06-12 13:48:21.591+0200 I/utils   ( 7643): specific action
06-12 13:48:21.591+0200 W/CAPI_APPFW_APP_CONTROL( 7643): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.591+0200 I/recorder( 7643): saving local data for es.ugr.frailty.accelerometer
06-12 13:48:21.591+0200 I/recorder( 7643): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 13:48:21.591+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.591+0200 I/utils   ( 7640): specific action
06-12 13:48:21.591+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.591+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.591+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.591+0200 W/CAPI_APPFW_APP_CONTROL( 7640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:48:21.591+0200 I/servicemanager( 7640): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 13:48:21.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.611+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7703
06-12 13:48:21.621+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.631+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:21.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(46) , send fd(21), pid(7640), cmd(0)
06-12 13:48:21.631+0200 W/AUL     ( 7703): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.631+0200 I/light   ( 7703): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.631+0200 I/light   ( 7703): es.ugr.frailty.light - capturing data
06-12 13:48:21.641+0200 W/AUL     ( 7640): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:48:21.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 13:48:21.641+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 13:48:21.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:48:21.641+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 13:48:21.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 13:48:21.641+0200 I/light   ( 7703): es.ugr.frailty.light: SM-R760,12/06/2018,13:48:21:640,77.000000
06-12 13:48:21.641+0200 W/AUL     ( 7703): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:48:21.641+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 13:48:21.641+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 13:48:21.651+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 13:48:21.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:48:21.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(88) , send fd(21), pid(7643), cmd(0)
06-12 13:48:21.651+0200 E/CAPI_LOCATION_MANAGER( 7758): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 13:48:21.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.661+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:48:21.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7671
06-12 13:48:21.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.681+0200 I/heartrate( 7661): es.ugr.frailty.heartrate - capturing data
06-12 13:48:21.681+0200 I/heartrate( 7661): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:48:21.701+0200 W/AUL     ( 7671): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 13:48:21.701+0200 I/MESSAGE_PORT( 2454): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 13:48:21.711+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7647
06-12 13:48:21.721+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.731+0200 E/CAPI_APPFW_APP_CONTROL( 6531): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 13:48:21.731+0200 W/MUSIC_CONTROL_SERVICE( 6531): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:6531]   [com.samsung.w-home]register msg port [true][0m
06-12 13:48:21.731+0200 W/AUL     ( 7647): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7640)
06-12 13:48:21.741+0200 I/accelerometer( 7647): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.741+0200 I/accelerometer( 7647): es.ugr.frailty.accelerometer - capturing data
06-12 13:48:21.741+0200 W/AUL     ( 7787): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 13:48:21.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7660
06-12 13:48:21.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.771+0200 I/gravity ( 7671): request sent to service es.ugr.frailty.servicemanager
06-12 13:48:21.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.781+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7665
06-12 13:48:21.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.811+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7640
06-12 13:48:21.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7643
06-12 13:48:21.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:48:21.841+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7703
06-12 13:48:21.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7640
06-12 13:48:21.851+0200 W/CRASH_MANAGER( 7785): worker.c: worker_job(1205) > 11076646c6f63152880410
