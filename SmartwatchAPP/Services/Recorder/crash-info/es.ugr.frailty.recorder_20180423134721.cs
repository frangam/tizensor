S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 17708
Date: 2018-04-23 13:47:21+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7542648, r1   = 0xf76391b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf76391b8, r5   = 0x00012cd0
r6   = 0xf764be88, r7   = 0xf7542250
r8   = 0x000005e0, r9   = 0xf7025824
r10  = 0xf76319d8, fp   = 0x00000000
ip   = 0xf7541030, sp   = 0xffae43e0
lr   = 0xf74855d0, pc   = 0xf74819fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     82732 KB
Buffers:     30296 KB
Cached:     148580 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7752 KB
VmRSS:        7752 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6bbc000 f6bbf000 r-xp /lib/libattr.so.1.1.0
f6bc8000 f6bcf000 r-xp /lib/libcrypt-2.13.so
f6bff000 f6c02000 r-xp /lib/libcap.so.2.21
f6c0a000 f6c0c000 r-xp /usr/lib/libiri.so
f6c14000 f6c31000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c3a000 f6c3e000 r-xp /usr/lib/libsmack.so.1.0.0
f6c48000 f6c4a000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c52000 f6c57000 r-xp /usr/lib/libffi.so.5.0.10
f6c5f000 f6c60000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c68000 f6c6a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c72000 f6c74000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c7e000 f6c8e000 r-xp /lib/libresolv-2.13.so
f6c92000 f6caa000 r-xp /usr/lib/liblzma.so.5.0.3
f6cb2000 f6cb4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cbc000 f6ceb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cf4000 f6d03000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d0c000 f6d16000 r-xp /usr/lib/libsensord-shared.so
f6d1f000 f6d53000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d5c000 f6e2f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e3a000 f6e50000 r-xp /lib/libz.so.1.2.5
f6e58000 f6e5e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e67000 f6edc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ee6000 f6f00000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f08000 f6f0e000 r-xp /lib/librt-2.13.so
f6f17000 f6f35000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f3f000 f6f40000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f48000 f6f4d000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f55000 f7025000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7026000 f7050000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7059000 f7070000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7078000 f70e1000 r-xp /lib/libm-2.13.so
f70ea000 f717e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7191000 f7196000 r-xp /usr/lib/libctx-client.so.0.8.3
f719e000 f71a5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71ad000 f71d7000 r-xp /usr/lib/libsensor.so.1.9.6
f71e0000 f72ac000 r-xp /usr/lib/libxml2.so.2.7.8
f72b9000 f72bb000 r-xp /usr/lib/libiniparser.so.0
f72c4000 f72c7000 r-xp /usr/lib/libbundle.so.0.1.22
f72cf000 f72d5000 r-xp /usr/lib/libappsvc.so.0.1.0
f72dd000 f7300000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7308000 f7349000 r-xp /usr/lib/libeina.so.1.7.99
f7352000 f7369000 r-xp /usr/lib/libecore.so.1.7.99
f7380000 f7389000 r-xp /usr/lib/libvconf.so.0.2.45
f7391000 f73a5000 r-xp /lib/libpthread-2.13.so
f73b0000 f73bd000 r-xp /usr/lib/libaul.so.0.1.0
f73c7000 f73c9000 r-xp /lib/libdl-2.13.so
f73d2000 f73dd000 r-xp /lib/libunwind.so.8.0.1
f740a000 f7412000 r-xp /lib/libgcc_s-4.6.so.1
f7413000 f7537000 r-xp /lib/libc-2.13.so
f7545000 f7547000 r-xp /usr/lib/libdlog.so.0.0.0
f754f000 f755b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7564000 f7569000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7571000 f7575000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f757e000 f7580000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7589000 f758c000 r-xp /usr/lib/libappcore-agent.so.1.1
f75aa000 f75c7000 r-xp /lib/ld-2.13.so
f75d0000 f75d3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f75d3000 f75d7000 r-xp /usr/lib/libsys-assert.so
f7627000 f7675000 rw-p [heap]
ffac6000 ffae7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17708)
Call Stack Count: 1
 0: (0xf74819fc) [/lib/libc.so.6] + 0x6e9fc
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: recorder
App ID: es.ugr.frailty.recorder
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
1): Application.cpp: SOnAppPause(315) > [1;35m ###[0;m
04-23 13:47:11.001+0200 W/SHealthCommon(17411): SHealthMessagePortConnection.cpp: Send(512) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 13:47:11.001+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:47:11.001+0200 W/SHealthAlertViewer(17411): InactiveTimeAlertView.cpp: onAnimationFinished(201) > [1;40;33mNot Completedly[0;m
04-23 13:47:11.001+0200 W/SHealthAlertViewer(17411): InactiveTimeAlertView.cpp: onAnimationFinished(201) > [1;40;33mNot Completedly[0;m
04-23 13:47:11.011+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 930835254, next duetime: 1524484051
04-23 13:47:11.011+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(930835254)
04-23 13:47:11.001+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:47:11.011+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1524493503), due_time(1524484051)
04-23 13:47:11.021+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-23 13:47:11.031+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 13:47:11.031+0200 W/SHealthCommon( 3087): SHealthMessagePortConnection.cpp: OnPortMessageReceived(135) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
04-23 13:47:11.041+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-23 13:47:11.041+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 23-4-2018, 11:47:31 (UTC).
04-23 13:47:11.041+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-23 13:47:11.041+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-23 13:47:11.071+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 13:47:11.081+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 13:47:11.081+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 13:47:11.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:11.151+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:11:148,71
04-23 13:47:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:11.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491231292,000000, pattern:[H:mm][0;m
04-23 13:47:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:11.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:11.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:11.281+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xf818b358) is deleting
04-23 13:47:11.281+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xf818b358) is deleting
04-23 13:47:11.281+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xf818aa88) is deleting
04-23 13:47:11.281+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xf818aa88) is deleting
04-23 13:47:11.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:11.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:11:348,71
04-23 13:47:11.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:11.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:11:549,71
04-23 13:47:11.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:11.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:11:748,71
04-23 13:47:11.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:11.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:11:948,71
04-23 13:47:12.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:12.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:12:149,72
04-23 13:47:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:12.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491232293,000000, pattern:[H:mm][0;m
04-23 13:47:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:12.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:12.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:12.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:12.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:12:349,72
04-23 13:47:12.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:12.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:12:549,72
04-23 13:47:12.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:12.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:12:749,72
04-23 13:47:12.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:12.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:12:949,72
04-23 13:47:13.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:13.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:13:149,72
04-23 13:47:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:13.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491233293,000000, pattern:[H:mm][0;m
04-23 13:47:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:13.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:13.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:13.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:13.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:13:350,72
04-23 13:47:13.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:13.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:13:549,72
04-23 13:47:13.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:13.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:13:750,72
04-23 13:47:13.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:13.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:13:950,72
04-23 13:47:14.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:14.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:14:150,72
04-23 13:47:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:14.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491234297,000000, pattern:[H:mm][0;m
04-23 13:47:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:14.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:14.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:14.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:14.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:14:350,72
04-23 13:47:14.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:14.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:14:551,72
04-23 13:47:14.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:14.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:14:750,72
04-23 13:47:14.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:14.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:14:950,72
04-23 13:47:15.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:15.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:15:151,72
04-23 13:47:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:15.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491235298,000000, pattern:[H:mm][0;m
04-23 13:47:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:15.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:15.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:15.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:15.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:15:351,72
04-23 13:47:15.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:15.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:15:551,72
04-23 13:47:15.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:15.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:15:751,72
04-23 13:47:15.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:15.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:15:951,72
04-23 13:47:16.011+0200 I/APP_CORE(17411): appcore-efl.c: __do_app(453) > [APP 17411] Event: MEM_FLUSH State: PAUSED
04-23 13:47:16.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:16.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:16:151,71
04-23 13:47:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:16.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491236295,000000, pattern:[H:mm][0;m
04-23 13:47:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:16.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:16.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:16.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:16.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:16:352,72
04-23 13:47:16.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:16.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:16:551,71
04-23 13:47:16.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:16.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:16:752,72
04-23 13:47:16.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:16.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:16:952,71
04-23 13:47:17.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:17.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:17:152,72
04-23 13:47:17.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:17.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:17.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:17.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:17.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491237299,000000, pattern:[H:mm][0;m
04-23 13:47:17.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:17.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:17.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:17.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:17.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:17.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:17.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:17.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:17:352,71
04-23 13:47:17.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:17.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:17:553,72
04-23 13:47:17.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:17.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:17:752,72
04-23 13:47:17.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:17.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:17:952,72
04-23 13:47:18.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:18.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:18:153,72
04-23 13:47:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:18.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491238297,000000, pattern:[H:mm][0;m
04-23 13:47:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:18.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:18.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:18.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:18.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:18:353,72
04-23 13:47:18.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:18.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:18:553,72
04-23 13:47:18.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:18.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:18:754,72
04-23 13:47:18.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:18.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:18:953,72
04-23 13:47:19.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:19.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:19:153,72
04-23 13:47:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:19.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491239297,000000, pattern:[H:mm][0;m
04-23 13:47:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:19.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:19.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:19.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:19.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:19:354,72
04-23 13:47:19.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:19.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:19:553,72
04-23 13:47:19.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:19.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:19:754,72
04-23 13:47:19.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:19.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:19:954,72
04-23 13:47:20.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:20.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:20:154,72
04-23 13:47:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:20.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491240297,000000, pattern:[H:mm][0;m
04-23 13:47:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:20.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:20.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:20.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:20.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:20:354,72
04-23 13:47:20.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:20.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:20:555,72
04-23 13:47:20.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:20.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:20:754,72
04-23 13:47:20.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:20.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:20:954,72
04-23 13:47:21.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:21.151+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:21:155,72
04-23 13:47:21.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:47:21.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:47:21.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:47:21.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:47:21.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:21.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:21.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:21.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:21.301+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491241309,000000, pattern:[H:mm][0;m
04-23 13:47:21.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:21.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:21.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:21.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:21.301+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:21.301+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:21.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:47:21.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:47:21.311+0200 I/utils   (17422): specific action
04-23 13:47:21.311+0200 I/httppostreq(17422): internet connection check received
04-23 13:47:21.311+0200 I/httppostreq(17422): internet connection != null
04-23 13:47:21.311+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:47:21.311+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:47:21.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:47:21.311+0200 I/httppostreq(17422): internet connection type...
04-23 13:47:21.311+0200 I/httppostreq(17422): internet connection type 1
04-23 13:47:21.311+0200 I/httppostreq(17422): internet available
04-23 13:47:21.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:47:21.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:47:21.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:47:21.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:47:21.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:47:21.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:47:21.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:47:21.341+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:47:21.341+0200 I/utils   (17419): specific action
04-23 13:47:21.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:47:21.341+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:47:21.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:47:21.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:47:21.341+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:47:21.341+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:47:21.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:47:21.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:47:21.351+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17695
04-23 13:47:21.361+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:47:21.361+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:21.391+0200 E/CAPI_APPFW_APPLICATION(17695): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:47:21.391+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:21:370,72
04-23 13:47:21.391+0200 E/CAPI_APPFW_APPLICATION(17695): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:47:21.401+0200 I/utils   (17695): trying to start service: es.ugr.frailty.accelerometer
04-23 13:47:21.401+0200 I/utils   (17695): es.ugr.frailty.accelerometer sensor supported
04-23 13:47:21.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 17695
04-23 13:47:21.411+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(17695) type(svcapp) bg(0)
04-23 13:47:21.411+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (17695) was created
04-23 13:47:21.411+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17695]
04-23 13:47:21.421+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17695)
04-23 13:47:21.421+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:47:21.421+0200 I/servicemanager(17419): App control destroyed.
04-23 13:47:21.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:21.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:21.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:21.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:21.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:21.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:21.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:21.421+0200 I/servicemanager(17419): deleting timer 0
04-23 13:47:21.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:21.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:21.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:21.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:21.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:21.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:21.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:21.421+0200 I/servicemanager(17419): deleting timer 1
04-23 13:47:21.441+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:21.441+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:21.441+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:21.441+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:21.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:47:21.451+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17695
04-23 13:47:21.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:47:21.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17695
04-23 13:47:21.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:47:21.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:21.531+0200 I/servicemanager(17419): deleting timer 2
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:21.531+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:21.531+0200 I/servicemanager(17419): deleting timer 3
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:21.531+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:21.531+0200 I/servicemanager(17419): deleting timer 4
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:21.531+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:21.531+0200 I/servicemanager(17419): deleting timer 5
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:21.531+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:21.531+0200 I/servicemanager(17419): deleting timer 6
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:21.531+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:21.531+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:21.531+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:21.531+0200 I/servicemanager(17419): deleting timer 7
04-23 13:47:21.531+0200 I/servicemanager(17419): deleting timer 8
04-23 13:47:21.531+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:47:21.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:47:21.551+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:47:21.561+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:47:21.561+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17708
04-23 13:47:21.561+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:21.601+0200 E/CAPI_APPFW_APPLICATION(17708): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:47:21.601+0200 E/CAPI_APPFW_APPLICATION(17708): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:47:21.601+0200 I/utils   (17708): specific action
04-23 13:47:21.601+0200 I/recorder(17708): obteniendo datos locales...
04-23 13:47:21.611+0200 I/recorder(17708): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:47:21.611+0200 I/recorder(17708): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:47:21.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __check_cmdline(540) > error founded when being launched with 17708
04-23 13:47:21.671+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1117708726563152448404
