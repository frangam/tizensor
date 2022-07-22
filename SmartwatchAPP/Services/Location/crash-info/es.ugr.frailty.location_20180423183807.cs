S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8627
Date: 2018-04-23 18:38:07+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf726052d, r5   = 0xf75d1f98
r6   = 0xff933878, r7   = 0xff933728
r8   = 0xf75cec18, r9   = 0x00000000
r10  = 0xff933804, fp   = 0xff933878
ip   = 0x00000001, sp   = 0xff933700
lr   = 0xf7260539, pc   = 0xf72c9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8524 KB
Buffers:     69348 KB
Cached:     216612 KB
VmPeak:      53548 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11976 KB
VmRSS:       11976 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8627 TID = 8627
8627 8665 

Maps Information
f412b000 f492a000 rw-p [stack:8665]
f4931000 f4933000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f493b000 f493f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4948000 f494a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4952000 f4955000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4964000 f4969000 r-xp /usr/lib/libsystem.so.0.0.0
f4974000 f4977000 r-xp /lib/libattr.so.1.1.0
f497f000 f498f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4997000 f49a0000 r-xp /usr/lib/libedbus.so.1.7.99
f49a8000 f49a9000 r-xp /usr/lib/libresponse.so.0.2.96
f49b2000 f49b7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6259000 f635f000 r-xp /usr/lib/libicuuc.so.57.1
f6375000 f64fd000 r-xp /usr/lib/libicui18n.so.57.1
f650d000 f651a000 r-xp /usr/lib/libail.so.0.1.0
f6523000 f652a000 r-xp /usr/lib/libminizip.so.1.0.0
f6533000 f66dc000 r-xp /usr/lib/libcrypto.so.1.0.0
f66fc000 f6743000 r-xp /usr/lib/libssl.so.1.0.0
f674f000 f6751000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6759000 f6760000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6769000 f6770000 r-xp /lib/libcrypt-2.13.so
f67a1000 f67a4000 r-xp /lib/libcap.so.2.21
f67ac000 f67ae000 r-xp /usr/lib/libiri.so
f67b6000 f67ff000 r-xp /usr/lib/libmdm.so.1.2.69
f6807000 f680d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6815000 f6838000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6842000 f6844000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f684c000 f6869000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6872000 f6876000 r-xp /usr/lib/libsmack.so.1.0.0
f687f000 f6898000 r-xp /usr/lib/libnetwork.so.0.0.0
f68a1000 f68a9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68b1000 f68b7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68c0000 f68c2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68cb000 f68db000 r-xp /lib/libresolv-2.13.so
f68df000 f68f7000 r-xp /usr/lib/liblzma.so.5.0.3
f6900000 f6902000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f690a000 f6924000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f692c000 f695b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6964000 f6973000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f697d000 f6987000 r-xp /usr/lib/libsensord-shared.so
f6990000 f6a63000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a6e000 f6a84000 r-xp /lib/libz.so.1.2.5
f6a8c000 f6a91000 r-xp /usr/lib/libffi.so.5.0.10
f6a99000 f6a9a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6aa2000 f6ab2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6aba000 f6ad3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6adb000 f6add000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ae5000 f6b5a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b64000 f6b6a000 r-xp /lib/librt-2.13.so
f6b73000 f6b91000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b9b000 f6b9c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ba4000 f6bc7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bcf000 f6bd4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bdc000 f6c06000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c0f000 f6c26000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c2e000 f6c97000 r-xp /lib/libm-2.13.so
f6ca0000 f6d34000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d47000 f6d4c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d54000 f6d5b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d63000 f6d8d000 r-xp /usr/lib/libsensor.so.1.9.6
f6d96000 f6e62000 r-xp /usr/lib/libxml2.so.2.7.8
f6e6f000 f6e71000 r-xp /usr/lib/libiniparser.so.0
f6e7a000 f6e80000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e89000 f6f59000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f5a000 f6f8e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f97000 f6fd3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fdb000 f6fde000 r-xp /usr/lib/libbundle.so.0.1.22
f6fe6000 f6fec000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ff4000 f7035000 r-xp /usr/lib/libeina.so.1.7.99
f703e000 f7055000 r-xp /usr/lib/libecore.so.1.7.99
f706c000 f7075000 r-xp /usr/lib/libvconf.so.0.2.45
f707d000 f7091000 r-xp /lib/libpthread-2.13.so
f709c000 f70a9000 r-xp /usr/lib/libaul.so.0.1.0
f70b3000 f70b5000 r-xp /lib/libdl-2.13.so
f70be000 f70c9000 r-xp /lib/libunwind.so.8.0.1
f70f6000 f70fe000 r-xp /lib/libgcc_s-4.6.so.1
f70ff000 f7223000 r-xp /lib/libc-2.13.so
f7231000 f7233000 r-xp /usr/lib/libdlog.so.0.0.0
f723b000 f7247000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7250000 f7255000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f725d000 f726c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7274000 f7278000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7281000 f7284000 r-xp /usr/lib/libappcore-agent.so.1.1
f728c000 f728e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7296000 f729a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72a2000 f72bf000 r-xp /lib/ld-2.13.so
f72c8000 f72cb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72cb000 f72cf000 r-xp /usr/lib/libsys-assert.so
f759e000 f7627000 rw-p [heap]
ff914000 ff935000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8627)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72c9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7260539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f673f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f65c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f71e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f77be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f77dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fac75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fa71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f65c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f71e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f77be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f77dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fa9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6faa017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fae8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf72980bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf493c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a0f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ebcfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ebe7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf704eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7049b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf704a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf704a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7282183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72827fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72c94f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf711685c) [/lib/libc.so.6] + 0x1785c
29: (0xf72c8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
start_cb(666) > state: 0 -> 1
04-23 18:38:04.031+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-23 18:38:04.031+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-23 18:38:04.031+0200 W/W_HOME  ( 2775): event_manager.c: _move_module_anim_end_cb(680) > state: 1 -> 0
04-23 18:38:04.031+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:38:04.031+0200 W/W_HOME  ( 2775): rotary.c: rotary_deattach(156) > rotary_deattach:0xf7a23968
04-23 18:38:04.031+0200 I/efl-extension( 2775): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-23 18:38:04.031+0200 I/efl-extension( 2775): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7a23968, elm_layout, func : 0xf72c5d05
04-23 18:38:04.031+0200 I/efl-extension( 2775): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-23 18:38:04.031+0200 I/efl-extension( 2775): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-23 18:38:04.031+0200 I/efl-extension( 2775): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-23 18:38:04.031+0200 I/efl-extension( 2775): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf788a450, elm_box, _activated_obj : 0xf7a23968, activated : 1
04-23 18:38:04.031+0200 I/efl-extension( 2775): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-23 18:38:04.031+0200 E/wnotib  ( 2775): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-23 18:38:04.031+0200 I/wnotib  ( 2775): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
04-23 18:38:04.031+0200 W/W_HOME  ( 2775): gesture.c: _manual_render(182) > 
04-23 18:38:04.041+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 18:38:04.041+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 18:38:04.041+0200 W/AUL     ( 2701): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2775)
04-23 18:38:04.041+0200 E/ALARM_MANAGER( 2472): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2701].
04-23 18:38:04.041+0200 E/ALARM_MANAGER( 2472): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(144909727)
04-23 18:38:04.041+0200 E/ALARM_MANAGER( 2472): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(97378666) is OVER.
04-23 18:38:04.041+0200 E/ALARM_MANAGER( 2472): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
04-23 18:38:04.041+0200 E/ALARM_MANAGER( 2472): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(405561765) is OVER.
04-23 18:38:04.041+0200 E/ALARM_MANAGER( 2472): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2077840997) is OVER.
04-23 18:38:04.051+0200 E/ALARM_MANAGER( 2472): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-23 18:38:04.051+0200 E/ALARM_MANAGER( 2472): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-23 18:38:04.051+0200 E/ALARM_MANAGER( 2472): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 23-4-2018, 21:48:26 (UTC).
04-23 18:38:04.051+0200 E/ALARM_MANAGER( 2472): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-23 18:38:04.051+0200 E/ALARM_MANAGER( 2472): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-23 18:38:04.051+0200 E/ALARM_MANAGER( 2472): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[144909727] is removed.
04-23 18:38:04.061+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [2775]
04-23 18:38:04.091+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 18:38:04.111+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:04.111+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:04.161+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
04-23 18:38:04.161+0200 W/W_HOME  ( 2775): event_manager.c: _apptray_visibility_cb(604) > apps,hide,start
04-23 18:38:04.161+0200 W/W_HOME  ( 2775): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
04-23 18:38:04.161+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:38:04.161+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:38:04.161+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 18:38:04.161+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:38:04.161+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:38:04.161+0200 W/W_HOME  ( 2775): clock_manager.c: _compositing_set(205) > hwc:1
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): noti_broker.c: _apptray_visibility_cb(793) > apps,hide,start
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80002
04-23 18:38:04.171+0200 W/wnotib  ( 2775): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80002
04-23 18:38:04.171+0200 I/wnotib  ( 2775): w-notification-board-broker-main.c: _wnb_handle_view_event(1396) > Unhandled type: 0x80002
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): event_manager.c: _apptray_visibility_cb(604) > apps,hide
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): noti_broker.c: _apptray_visibility_cb(793) > apps,hide
04-23 18:38:04.171+0200 W/W_HOME  ( 2775): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80001
04-23 18:38:04.171+0200 W/wnotib  ( 2775): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80001
04-23 18:38:04.171+0200 I/wnotib  ( 2775): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 0
04-23 18:38:04.171+0200 W/wnotib  ( 2775): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 0.
04-23 18:38:04.171+0200 E/APPS    ( 2775): apps_main.c: apps_main_pause(984) >  paused already
04-23 18:38:04.171+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 18:38:04.171+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 18:38:04.171+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 18:38:04.191+0200 W/W_HOME  ( 2775): clock_manager.c: _hwc_enabled_success_cb(153) > hwc enabled
04-23 18:38:04.191+0200 W/W_HOME  ( 2775): clock_manager.c: _hwc_enabled_success_cb(156) > do manual_render to show HWC window
04-23 18:38:04.231+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:04.231+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:04.431+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:04.431+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:04.631+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:04.631+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:04.831+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:04.831+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:05.031+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:05.031+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:05.031+0200 W/AUL_AMD ( 2476): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-23 18:38:05.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
04-23 18:38:05.231+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:05.231+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:05.321+0200 I/servicemanager( 8361): es.ugr.frailty.accelerometer alive timeout
04-23 18:38:05.321+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 18:38:05.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:38:05.321+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8361
04-23 18:38:05.331+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 8600
04-23 18:38:05.331+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 18:38:05.371+0200 E/CAPI_APPFW_APPLICATION( 8600): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:38:05.371+0200 E/CAPI_APPFW_APPLICATION( 8600): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:38:05.371+0200 I/utils   ( 8600): trying to start service: es.ugr.frailty.accelerometer
04-23 18:38:05.371+0200 I/utils   ( 8600): es.ugr.frailty.accelerometer sensor supported
04-23 18:38:05.381+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8600
04-23 18:38:05.381+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(8600) type(svcapp) bg(0)
04-23 18:38:05.381+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (8600) was created
04-23 18:38:05.391+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8600]
04-23 18:38:05.391+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8600)
04-23 18:38:05.391+0200 I/servicemanager( 8361): es.ugr.frailty.accelerometer launch request sent!
04-23 18:38:05.391+0200 I/servicemanager( 8361): App control destroyed.
04-23 18:38:05.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:38:05.411+0200 I/utils   ( 8600): es.ugr.frailty.accelerometer listener started
04-23 18:38:05.411+0200 W/CAPI_APPFW_APP_CONTROL( 8600): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:05.411+0200 I/utils   ( 8600): specific action
04-23 18:38:05.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8600
04-23 18:38:05.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:38:05.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:38:05.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8600
04-23 18:38:05.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:38:05.451+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:05.451+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:05.501+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:05.511+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:05:514,9.578469,-1.107877,1.945365
04-23 18:38:05.631+0200 I/servicemanager( 8361): es.ugr.frailty.gyroscope alive timeout
04-23 18:38:05.631+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:05.631+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 18:38:05.631+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:05.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:38:05.631+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8361
04-23 18:38:05.651+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 18:38:05.651+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 8613
04-23 18:38:05.691+0200 E/CAPI_APPFW_APPLICATION( 8613): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:38:05.691+0200 E/CAPI_APPFW_APPLICATION( 8613): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:38:05.691+0200 I/utils   ( 8613): trying to start service: es.ugr.frailty.gyroscope
04-23 18:38:05.691+0200 I/utils   ( 8613): es.ugr.frailty.gyroscope sensor supported
04-23 18:38:05.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8613
04-23 18:38:05.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(8613) type(svcapp) bg(0)
04-23 18:38:05.701+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (8613) was created
04-23 18:38:05.701+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8613)
04-23 18:38:05.701+0200 I/servicemanager( 8361): es.ugr.frailty.gyroscope launch request sent!
04-23 18:38:05.701+0200 I/servicemanager( 8361): App control destroyed.
04-23 18:38:05.711+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8613]
04-23 18:38:05.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:38:05.731+0200 I/utils   ( 8613): es.ugr.frailty.gyroscope listener started
04-23 18:38:05.731+0200 W/CAPI_APPFW_APP_CONTROL( 8613): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:05.731+0200 I/utils   ( 8613): specific action
04-23 18:38:05.731+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:05.731+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8613
04-23 18:38:05.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:38:05.751+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:05:736,9.745967,-1.493121,2.117648
04-23 18:38:05.761+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:38:05.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8613
04-23 18:38:05.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:38:05.831+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:05.831+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:05.861+0200 I/servicemanager( 8361): es.ugr.frailty.location alive timeout
04-23 18:38:05.861+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 18:38:05.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:38:05.861+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8361
04-23 18:38:05.871+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 8627
04-23 18:38:05.871+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 18:38:05.911+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:05.921+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:05.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8627
04-23 18:38:05.921+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(8627) type(svcapp) bg(0)
04-23 18:38:05.931+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8627]
04-23 18:38:05.931+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8627)
04-23 18:38:05.931+0200 I/servicemanager( 8361): es.ugr.frailty.location launch request sent!
04-23 18:38:05.931+0200 I/servicemanager( 8361): App control destroyed.
04-23 18:38:05.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:38:05.951+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8627
04-23 18:38:05.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:38:05.961+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:05:926,9.693325,-1.402194,1.469193
04-23 18:38:05.961+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:05:923,2.310000,-1.890000,0.350000
04-23 18:38:05.971+0200 I/servicemanager( 8361): es.ugr.frailty.pedometer alive timeout
04-23 18:38:05.971+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
04-23 18:38:05.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:38:05.971+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8361
04-23 18:38:05.981+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 8640
04-23 18:38:05.981+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 18:38:06.011+0200 E/CAPI_APPFW_APPLICATION( 8627): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:38:06.011+0200 E/CAPI_APPFW_APPLICATION( 8627): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:38:06.021+0200 E/CAPI_APPFW_APPLICATION( 8640): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:38:06.021+0200 E/CAPI_APPFW_APPLICATION( 8640): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:38:06.021+0200 I/utils   ( 8640): trying to start service: es.ugr.frailty.pedometer
04-23 18:38:06.031+0200 I/utils   ( 8640): es.ugr.frailty.pedometer sensor supported
04-23 18:38:06.031+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:06.031+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:06.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8640
04-23 18:38:06.031+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(8640) type(svcapp) bg(0)
04-23 18:38:06.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:38:06.041+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8640]
04-23 18:38:06.041+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8640)
04-23 18:38:06.041+0200 I/servicemanager( 8361): es.ugr.frailty.pedometer launch request sent!
04-23 18:38:06.041+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8627
04-23 18:38:06.041+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (8627) was created
04-23 18:38:06.041+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (8640) was created
04-23 18:38:06.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:38:06.051+0200 I/servicemanager( 8361): App control destroyed.
04-23 18:38:06.051+0200 I/utils   ( 8640): es.ugr.frailty.pedometer listener started
04-23 18:38:06.051+0200 W/CAPI_APPFW_APP_CONTROL( 8640): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.051+0200 I/utils   ( 8640): specific action
04-23 18:38:06.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:38:06.061+0200 W/LOCATION( 8627): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 18:38:06.061+0200 E/LOCATION( 8627): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 18:38:06.061+0200 E/PKGMGR_INFO( 8627): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 18:38:06.071+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8640
04-23 18:38:06.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:38:06.081+0200 W/LOCATION( 8627): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:38:06.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:38:06.121+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8640
04-23 18:38:06.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:38:06.131+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:06.141+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:06.141+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:06:143,9.784252,-1.512264,1.799403
04-23 18:38:06.141+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:06:145,-18.830000,-0.420000,-2.590000
04-23 18:38:06.161+0200 I/LOCATION( 8627): location.c: location_new(269) > method: 0
04-23 18:38:06.161+0200 W/LOCATION( 8627): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:38:06.181+0200 W/LOCATION( 8627): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:38:06.181+0200 W/LOCATION( 8627): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:38:06.191+0200 W/LOCATION( 8627): module-internal.c: module_new(311) > module (gps) open success
04-23 18:38:06.201+0200 W/LOCATION( 8627): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:38:06.201+0200 W/LOCATION( 8627): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:38:06.201+0200 W/LOCATION( 8627): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:38:06.201+0200 W/LOCATION( 8627): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:38:06.201+0200 W/LOCATION( 8627): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:38:06.221+0200 W/LOCATION( 8627): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 18:38:06.231+0200 W/LOCATION( 8627): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 18:38:06.231+0200 W/LOCATION( 8627): module-internal.c: module_new(311) > module (wps) open success
04-23 18:38:06.231+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:06.231+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:38:06.241+0200 W/LOCATION( 8627): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 18:38:06.241+0200 W/LOCATION( 8627): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 18:38:06.241+0200 W/LOCATION( 8627): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:38:06.241+0200 W/LOCATION( 8627): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:38:06.261+0200 W/LOCATION( 8627): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 18:38:06.261+0200 I/LOCATION( 8627): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf75cec18
04-23 18:38:06.261+0200 I/LOCATION( 8627): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 18:38:06.261+0200 I/LOCATION( 8627): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf75cec18
04-23 18:38:06.261+0200 I/LOCATION( 8627): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 18:38:06.261+0200 I/location( 8627): es.ugr.frailty.location: creado servicio de localización
04-23 18:38:06.301+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:06.301+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:06.311+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:06:313,-6.230000,-1.400000,-8.820000
04-23 18:38:06.321+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:06:314,9.521042,-0.990629,1.349552
04-23 18:38:06.341+0200 I/LOCATION( 8627): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 18:38:06.381+0200 W/LOCATION( 8627): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:38:06.381+0200 W/LOCATION( 8627): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:38:06.381+0200 I/LOCATION( 8627): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:38:06.431+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:06.441+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:38:06:442,84
04-23 18:38:06.451+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 18:38:06.451+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 18:38:06.451+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 18:38:06.451+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 18:38:06.451+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 18:38:06.451+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 18:38:06.451+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 18:38:06.451+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 18:38:06.451+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:38:06.451+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:38:06.451+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 18:38:06.451+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 18:38:06.451+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 18:38:06.451+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 18:38:06.451+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 18:38:06.451+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 18:38:06.451+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 18:38:06.451+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 18:38:06.501+0200 W/LOCATION( 8627): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:38:06.501+0200 W/LOCATION( 8627): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:38:06.511+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:06.521+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:06.521+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:06:523,13.790000,5.740000,6.090000
04-23 18:38:06.521+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:06:525,9.573684,-0.947558,1.402194
04-23 18:38:06.581+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:38:06.611+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_create(453) > New handle created[0xf1216828]
04-23 18:38:06.611+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 18:38:06.611+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 18:38:06.611+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 18:38:06.621+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:38:06.621+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:38:06.621+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:38:06.631+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:38:06.631+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:06.641+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:38:06:642,84
04-23 18:38:06.641+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:38:06.641+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:38:06.641+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:38:06.641+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:38:06.641+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:38:06.641+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:38:06.641+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:38:06.641+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:38:06.641+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:38:06.641+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:38:06.661+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:38:06.661+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:38:06.661+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:38:06.671+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:38:06.681+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:38:06.681+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(15382343), time2(15375235)
04-23 18:38:06.681+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 18:38:06.681+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:38:06.681+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:38:06.681+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:38:06.711+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:06.721+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:38:06.731+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:06:724,-10.990000,2.170000,20.930000
04-23 18:38:06.741+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:06.751+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:06:753,9.573684,-1.488336,1.430908
04-23 18:38:06.751+0200 W/LOCATION( 8627): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:38:06.751+0200 I/LOCATION( 8627): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:38:06.751+0200 I/LOCATION( 8627): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:38:06.751+0200 I/location( 8627): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:38:06.831+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:06.841+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:38:06:842,84
04-23 18:38:06.841+0200 I/LOCATION( 8627): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:38:06.891+0200 E/location( 8627): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:38:06.891+0200 W/AUL     ( 8627): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:38:06.891+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:38:06.891+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8627
04-23 18:38:06.901+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8361
04-23 18:38:06.901+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.901+0200 I/utils   ( 8361): specific action
04-23 18:38:06.901+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.901+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.901+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.901+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:38:06.901+0200 W/AUL     ( 8627): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8361)
04-23 18:38:06.901+0200 I/location( 8627): request sent to service es.ugr.frailty.servicemanager
04-23 18:38:06.901+0200 W/CAPI_APPFW_APP_CONTROL( 8627): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.901+0200 I/utils   ( 8627): specific action
04-23 18:38:06.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:38:06.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8361
04-23 18:38:06.911+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:06.911+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:06:916,9.394222,-1.983650,1.828116
04-23 18:38:06.911+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:06.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8367
04-23 18:38:06.911+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:38:06.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8361), cmd(0)
04-23 18:38:06.911+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:06:920,-9.870000,3.500000,5.880000
04-23 18:38:06.921+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.921+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8367)
04-23 18:38:06.921+0200 I/servicemanager( 8361): request sent to service es.ugr.frailty.recorder
04-23 18:38:06.921+0200 I/servicemanager( 8361): requesting to save local data
04-23 18:38:06.921+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:38:06.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(8367), cmd(0)
04-23 18:38:06.921+0200 I/utils   ( 8367): specific action
04-23 18:38:06.921+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.921+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.921+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.921+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:38:06.921+0200 I/recorder( 8367): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:38:06.921+0200 I/recorder( 8367): guardando datos en local
04-23 18:38:07.031+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:07.041+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:38:07:43,84
04-23 18:38:07.111+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.111+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.111+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:117,-12.670000,-2.030000,-7.560000
04-23 18:38:07.121+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:117,9.396614,-1.806581,1.593620
04-23 18:38:07.231+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:07.241+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:38:07:243,84
04-23 18:38:07.311+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.311+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.321+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:317,9.499505,-1.284946,2.191825
04-23 18:38:07.331+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:320,6.650000,2.240000,-6.860000
04-23 18:38:07.361+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:38:07.361+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 18:38:07.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 18:38:07.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:38:07.381+0200 E/CAPI_LOCATION_MANAGER( 2317): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 18:38:07.401+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:38:07.401+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.421+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:38:07.421+0200 E/LOCATION( 2317): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 18:38:07.421+0200 I/LOCATION( 2317): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 18:38:07.421+0200 I/LOCATION( 2317): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:38:07.431+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:38:07.441+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:412,9.533006,-1.758725,1.667797
04-23 18:38:07.441+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.441+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.441+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:38:07:442,84
04-23 18:38:07.451+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:448,12.390000,1.400000,-4.270000
04-23 18:38:07.451+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:447,9.628718,-1.335195,2.067399
04-23 18:38:07.451+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.461+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.471+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:466,12.880000,2.870000,-4.480000
04-23 18:38:07.471+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:463,9.492328,-1.124627,1.916651
04-23 18:38:07.471+0200 I/LOCATION( 8627): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:38:07.471+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.481+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.481+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:482,9.552148,-1.703690,2.026721
04-23 18:38:07.491+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:485,2.590000,0.350000,-2.940000
04-23 18:38:07.491+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.491+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.491+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:498,9.463614,-1.892723,1.859223
04-23 18:38:07.501+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:499,-6.860000,0.840000,-2.380000
04-23 18:38:07.501+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.501+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.511+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:510,0.070000,1.890000,-2.730000
04-23 18:38:07.511+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:509,9.561719,-1.808974,1.861616
04-23 18:38:07.511+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.511+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.521+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:522,9.480364,-1.691726,2.160719
04-23 18:38:07.521+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:522,6.790000,0.980000,-3.150000
04-23 18:38:07.521+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.531+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.531+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:535,9.473185,-1.514657,2.129612
04-23 18:38:07.531+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:533,8.960000,1.890000,-3.780000
04-23 18:38:07.531+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.541+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:544,9.590000,1.890000,-3.220000
04-23 18:38:07.551+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.551+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:560,9.559326,-1.552942,1.878366
04-23 18:38:07.561+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.561+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:565,4.900000,-2.520000,-3.360000
04-23 18:38:07.571+0200 I/accelerometer( 8600): capturing data from es.ugr.frailty.accelerometer
04-23 18:38:07.571+0200 I/accelerometer( 8600): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:38:07:575,9.623933,-1.605584,1.820938
04-23 18:38:07.571+0200 I/gyroscope( 8613): capturing data from es.ugr.frailty.gyroscope
04-23 18:38:07.571+0200 I/gyroscope( 8613): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:38:07:580,5.670000,0.350000,-3.640000
04-23 18:38:07.611+0200 W/CRASH_MANAGER( 8438): worker.c: worker_job(1205) > 11086276c6f63152450148
