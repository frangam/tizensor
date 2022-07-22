S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 31424
Date: 2018-04-23 17:39:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf766652d, r5   = 0xf791af98
r6   = 0xffd92440, r7   = 0xffd922f0
r8   = 0xf7917c18, r9   = 0x00000000
r10  = 0xffd923cc, fp   = 0xffd92440
ip   = 0x00000001, sp   = 0xffd91170
lr   = 0xf7666539, pc   = 0xf76cf2aa
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     14644 KB
Buffers:     67080 KB
Cached:     216352 KB
VmPeak:      53460 KB
VmSize:      53404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11900 KB
VmRSS:       11900 KB
VmData:      11132 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 31424 TID = 31424
31424 31440 

Maps Information
f4531000 f4d30000 rw-p [stack:31440]
f4d37000 f4d39000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d41000 f4d45000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d4e000 f4d50000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d58000 f4d5b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d6a000 f4d6f000 r-xp /usr/lib/libsystem.so.0.0.0
f4d7a000 f4d7d000 r-xp /lib/libattr.so.1.1.0
f4d85000 f4d95000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d9d000 f4da6000 r-xp /usr/lib/libedbus.so.1.7.99
f4dae000 f4daf000 r-xp /usr/lib/libresponse.so.0.2.96
f4db8000 f4dbd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f665f000 f6765000 r-xp /usr/lib/libicuuc.so.57.1
f677b000 f6903000 r-xp /usr/lib/libicui18n.so.57.1
f6913000 f6920000 r-xp /usr/lib/libail.so.0.1.0
f6929000 f6930000 r-xp /usr/lib/libminizip.so.1.0.0
f6939000 f6ae2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b02000 f6b49000 r-xp /usr/lib/libssl.so.1.0.0
f6b55000 f6b57000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b5f000 f6b66000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b6f000 f6b76000 r-xp /lib/libcrypt-2.13.so
f6ba7000 f6baa000 r-xp /lib/libcap.so.2.21
f6bb2000 f6bb4000 r-xp /usr/lib/libiri.so
f6bbc000 f6c05000 r-xp /usr/lib/libmdm.so.1.2.69
f6c0d000 f6c13000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c1b000 f6c3e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c48000 f6c4a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c52000 f6c6f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c78000 f6c7c000 r-xp /usr/lib/libsmack.so.1.0.0
f6c85000 f6c9e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6ca7000 f6caf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cb7000 f6cbd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cc6000 f6cc8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cd1000 f6ce1000 r-xp /lib/libresolv-2.13.so
f6ce5000 f6cfd000 r-xp /usr/lib/liblzma.so.5.0.3
f6d06000 f6d08000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d10000 f6d2a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d32000 f6d61000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d6a000 f6d79000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d83000 f6d8d000 r-xp /usr/lib/libsensord-shared.so
f6d96000 f6e69000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e74000 f6e8a000 r-xp /lib/libz.so.1.2.5
f6e92000 f6e97000 r-xp /usr/lib/libffi.so.5.0.10
f6e9f000 f6ea0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ea8000 f6eb8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ec0000 f6ed9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ee1000 f6ee3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6eeb000 f6f60000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f6a000 f6f70000 r-xp /lib/librt-2.13.so
f6f79000 f6f97000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fa1000 f6fa2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6faa000 f6fcd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fd5000 f6fda000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fe2000 f700c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7015000 f702c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7034000 f709d000 r-xp /lib/libm-2.13.so
f70a6000 f713a000 r-xp /usr/lib/libstdc++.so.6.0.16
f714d000 f7152000 r-xp /usr/lib/libctx-client.so.0.8.3
f715a000 f7161000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7169000 f7193000 r-xp /usr/lib/libsensor.so.1.9.6
f719c000 f7268000 r-xp /usr/lib/libxml2.so.2.7.8
f7275000 f7277000 r-xp /usr/lib/libiniparser.so.0
f7280000 f7286000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f728f000 f735f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7360000 f7394000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f739d000 f73d9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73e1000 f73e4000 r-xp /usr/lib/libbundle.so.0.1.22
f73ec000 f73f2000 r-xp /usr/lib/libappsvc.so.0.1.0
f73fa000 f743b000 r-xp /usr/lib/libeina.so.1.7.99
f7444000 f745b000 r-xp /usr/lib/libecore.so.1.7.99
f7472000 f747b000 r-xp /usr/lib/libvconf.so.0.2.45
f7483000 f7497000 r-xp /lib/libpthread-2.13.so
f74a2000 f74af000 r-xp /usr/lib/libaul.so.0.1.0
f74b9000 f74bb000 r-xp /lib/libdl-2.13.so
f74c4000 f74cf000 r-xp /lib/libunwind.so.8.0.1
f74fc000 f7504000 r-xp /lib/libgcc_s-4.6.so.1
f7505000 f7629000 r-xp /lib/libc-2.13.so
f7637000 f7639000 r-xp /usr/lib/libdlog.so.0.0.0
f7641000 f764d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7656000 f765b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7663000 f7672000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f767a000 f767e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7687000 f768a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7692000 f7694000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f769c000 f76a0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76a8000 f76c5000 r-xp /lib/ld-2.13.so
f76ce000 f76d1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76d1000 f76d5000 r-xp /usr/lib/libsys-assert.so
f78e7000 f794b000 rw-p [heap]
ffd73000 ffd94000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31424)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf76cf2aa) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12aa
 1: (0xf7666539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf736d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf736bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7377e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf737dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf737ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73b275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73ad1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf736bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7377e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf737dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf737ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73afe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73b0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73b7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d4f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d42171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e15663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72c2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72c47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7454ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf744fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74505a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7450879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7688183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76887fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76cf6bb) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16bb
28: __libc_start_main + 0x114 (0xf751c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf76cefa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
s_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:39:06.901+0200 I/LOCATION(31424): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:39:06.901+0200 I/location(31424): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:39:06.901+0200 W/CAPI_APPFW_APP_CONTROL(31424): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:39:06.901+0200 I/utils   (31424): specific action
04-23 17:39:06.921+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:06.921+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:06.931+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:39:06.931+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(11842596), time2(11692669)
04-23 17:39:06.931+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:39:06.931+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:39:06.931+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:39:06.931+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:39:06.991+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:06.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:39:06.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:39:06.991+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:06:998,9.552148,-0.832702,3.022135
04-23 17:39:07.021+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [11842.681212] dpms[3 -> 3]done
04-23 17:39:07.021+0200 I/TDM     ( 1785): 
04-23 17:39:07.021+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 17:39:07.021+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 17:39:07.031+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 17:39:07.031+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 17:39:07.041+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 17:39:07.041+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [gesture]
04-23 17:39:07.041+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 17:39:07.041+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 17:39:07.041+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 17:39:07.061+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 17:39:07.061+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 17:39:07.061+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 17:39:07.061+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 17:39:07.061+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 17:39:07.061+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 17:39:07.061+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 17:39:07.061+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:39:07.061+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:39:07.061+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 17:39:07.061+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:39:07.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:39:07.081+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.091+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 17:39:07.091+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 17:39:07.091+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:86,16.870001,-22.330000,0.280000
04-23 17:39:07.091+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 17:39:07.091+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 17:39:07.101+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 17:39:07.101+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 17:39:07.101+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 17:39:07.121+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:07.121+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:07.251+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.251+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.261+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:257,9.542577,0.416351,1.701297
04-23 17:39:07.261+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:257,52.709999,-10.500000,-17.430000
04-23 17:39:07.321+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:07.321+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:07.461+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.461+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.461+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:467,9.657433,1.122234,1.356731
04-23 17:39:07.471+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:467,33.950001,-1.540000,-14.770000
04-23 17:39:07.511+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 122 ms (from 11843057 to 11843179) (logOverhead=0,0,0,0,0,0,0), start: 17:39:07.402
04-23 17:39:07.511+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 122 ms (from 11843057 to 11843179) (logOverhead=0,0,0,0,0,0,0), start: 17:39:07.402
04-23 17:39:07.521+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:07.521+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:07.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:39:07.551+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:39:07.551+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:39:07.571+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 17:39:07.571+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.581+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.581+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:580,9.497113,1.574477,1.368695
04-23 17:39:07.581+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:580,19.809999,0.280000,-16.660000
04-23 17:39:07.591+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.591+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.591+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:596,9.674182,1.737189,0.868595
04-23 17:39:07.591+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:596,1.260000,2.940000,-14.560000
04-23 17:39:07.611+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.611+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.621+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:620,-8.190000,4.970000,-12.110000
04-23 17:39:07.621+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:620,9.504292,1.282553,1.607977
04-23 17:39:07.631+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.631+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.631+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:637,-1.610000,3.150000,-11.830000
04-23 17:39:07.641+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:638,9.456435,1.229911,1.978864
04-23 17:39:07.651+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.651+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.661+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:660,0.070000,1.960000,-14.350000
04-23 17:39:07.661+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:660,9.384650,1.612763,2.112862
04-23 17:39:07.671+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.671+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.681+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:679,-16.100000,-3.920000,-15.190001
04-23 17:39:07.681+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:679,9.451650,1.890330,1.651048
04-23 17:39:07.691+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.691+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.711+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:699,-32.340000,-5.460000,-13.090000
04-23 17:39:07.711+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.721+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:07.721+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:07.721+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:703,9.499505,1.663012,1.715654
04-23 17:39:07.721+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.731+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:728,9.537791,1.146162,1.234696
04-23 17:39:07.731+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.741+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:723,-27.790001,-2.870000,-10.290000
04-23 17:39:07.741+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.751+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:743,9.645468,2.009971,2.000400
04-23 17:39:07.751+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.771+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:761,9.413363,2.074577,1.629512
04-23 17:39:07.781+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:747,-19.670000,3.220000,-12.670000
04-23 17:39:07.781+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.781+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.781+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:789,9.530612,1.892723,1.521835
04-23 17:39:07.791+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.801+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:799,9.650253,1.643869,1.316052
04-23 17:39:07.801+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:792,-25.760000,3.010000,-9.030000
04-23 17:39:07.801+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.811+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:809,-27.230000,1.750000,-7.630000
04-23 17:39:07.811+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.811+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.811+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:816,-26.460001,2.660000,-6.020000
04-23 17:39:07.811+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.811+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:819,9.667004,1.919044,1.856830
04-23 17:39:07.831+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:822,-22.750000,4.410000,-4.620000
04-23 17:39:07.831+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.831+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.841+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:839,9.365508,2.045863,1.622334
04-23 17:39:07.851+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:840,-25.410000,5.180000,-2.660000
04-23 17:39:07.851+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.851+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.861+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:863,-25.549999,2.310000,-0.490000
04-23 17:39:07.861+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:857,9.480364,1.653440,1.976472
04-23 17:39:07.871+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.871+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.881+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:879,9.511470,1.397408,1.861616
04-23 17:39:07.881+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:882,-11.620000,3.780000,0.280000
04-23 17:39:07.891+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.891+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.901+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:899,9.564112,1.658226,1.974079
04-23 17:39:07.901+0200 E/CAPI_TELEPHONY(31441): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:39:07.901+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:902,4.200000,5.110000,0.280000
04-23 17:39:07.911+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.911+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.911+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:920,1.470000,7.350000,-0.280000
04-23 17:39:07.911+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:920,9.477970,2.033899,2.041078
04-23 17:39:07.921+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:07.921+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:07.931+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.931+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.931+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:940,-8.050000,5.600000,2.450000
04-23 17:39:07.941+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:940,9.250652,1.684547,1.830509
04-23 17:39:07.951+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.951+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.961+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:961,-0.560000,0.280000,2.590000
04-23 17:39:07.961+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:961,9.609575,1.442872,1.691726
04-23 17:39:07.971+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:07.971+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.981+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:07:982,9.760324,1.682154,2.270789
04-23 17:39:07.981+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:07:982,10.990000,3.220000,1.260000
04-23 17:39:07.991+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:07.991+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.001+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:0,11.200000,2.240000,2.730000
04-23 17:39:08.001+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:0,9.379865,1.655833,2.313859
04-23 17:39:08.011+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.011+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.021+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:22,2.730000,1.050000,2.730000
04-23 17:39:08.021+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:22,9.367901,1.866402,1.974079
04-23 17:39:08.031+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.031+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.041+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:42,-4.970000,0.210000,4.900000
04-23 17:39:08.041+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:42,9.236296,1.574477,1.782653
04-23 17:39:08.051+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.051+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.061+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:59,9.736395,1.588834,1.864009
04-23 17:39:08.061+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:59,-6.090000,-0.070000,3.570000
04-23 17:39:08.071+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.071+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.081+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:81,-1.610000,5.250000,1.190000
04-23 17:39:08.081+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:81,9.638289,1.328017,1.368695
04-23 17:39:08.091+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.091+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.101+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:101,9.707682,1.392623,1.816152
04-23 17:39:08.101+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:101,4.480000,5.530000,0.070000
04-23 17:39:08.111+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.111+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.121+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:08.121+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:08.121+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:122,2.240000,5.040000,-1.890000
04-23 17:39:08.121+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:122,9.540184,1.550549,1.564906
04-23 17:39:08.131+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.131+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.141+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:142,-9.800000,1.120000,-0.700000
04-23 17:39:08.141+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:142,9.456435,1.440479,1.856830
04-23 17:39:08.151+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.151+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.161+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:161,-14.000000,0.770000,-0.070000
04-23 17:39:08.161+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:163,9.568897,1.655833,2.603391
04-23 17:39:08.171+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.171+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.181+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:179,-13.720000,-1.890000,0.910000
04-23 17:39:08.181+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:180,9.343972,1.737189,2.481357
04-23 17:39:08.191+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.191+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.201+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:200,-13.930000,-7.210000,2.940000
04-23 17:39:08.211+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:202,9.334401,1.866402,2.426322
04-23 17:39:08.211+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.211+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.221+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:220,9.444471,1.986043,2.146362
04-23 17:39:08.221+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:221,-17.430000,-10.080000,5.180000
04-23 17:39:08.241+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.241+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.241+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:245,-20.090000,-11.340000,8.050000
04-23 17:39:08.251+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.261+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:251,9.523434,1.854438,1.811367
04-23 17:39:08.261+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.271+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:261,-15.050000,-8.890000,9.100000
04-23 17:39:08.271+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.281+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:272,9.695717,1.691726,1.758725
04-23 17:39:08.281+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:280,-13.720000,-6.510000,10.360000
04-23 17:39:08.281+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.291+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.301+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:292,9.757930,2.009971,1.758725
04-23 17:39:08.301+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.301+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:307,9.571291,2.141576,1.698904
04-23 17:39:08.301+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:299,-24.780001,-5.180000,14.000000
04-23 17:39:08.311+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.321+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:319,-45.360001,-6.720000,16.030001
04-23 17:39:08.321+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:08.321+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:08.321+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.321+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:327,9.425328,1.849652,1.478764
04-23 17:39:08.331+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.341+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:341,-59.709999,-7.910000,19.460001
04-23 17:39:08.341+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.351+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:349,9.542577,1.299303,1.866402
04-23 17:39:08.351+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.361+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:361,-62.369999,-7.420000,20.299999
04-23 17:39:08.361+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.361+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:368,9.504292,1.117448,2.127219
04-23 17:39:08.371+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.371+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:379,-50.189999,-8.960000,19.180000
04-23 17:39:08.371+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.381+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:384,9.607183,0.734596,1.785046
04-23 17:39:08.391+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.391+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.401+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:400,-37.799999,-7.840000,18.270000
04-23 17:39:08.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:39:08.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:39:08.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:39:08.411+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.411+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:400,9.781858,0.887737,1.641476
04-23 17:39:08.411+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.411+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:419,-31.780001,-6.160000,18.900000
04-23 17:39:08.421+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:423,9.676575,0.928415,1.481157
04-23 17:39:08.431+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.431+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.441+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:442,9.621540,1.115055,1.591227
04-23 17:39:08.441+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:442,-41.439999,-4.620000,20.580000
04-23 17:39:08.451+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.451+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.451+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:460,-49.910000,-4.620000,23.660000
04-23 17:39:08.461+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:461,9.525827,0.882952,1.715654
04-23 17:39:08.471+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.471+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.481+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:481,9.655040,0.897308,1.928615
04-23 17:39:08.491+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:481,-45.920002,-7.350000,24.290001
04-23 17:39:08.491+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.491+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.501+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:500,9.698111,0.672383,1.897508
04-23 17:39:08.501+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:499,-40.250000,-8.190000,24.920000
04-23 17:39:08.511+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.511+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.521+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:08.521+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:08.521+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:522,9.592826,0.401994,1.739582
04-23 17:39:08.521+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:522,-38.709999,-7.630000,25.480000
04-23 17:39:08.531+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.531+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.541+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:541,-37.029999,-5.810000,25.410000
04-23 17:39:08.541+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:541,9.743573,0.162712,1.605584
04-23 17:39:08.551+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.551+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.561+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:560,-30.170000,-2.730000,25.830000
04-23 17:39:08.561+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:560,9.676575,0.088534,1.505085
04-23 17:39:08.571+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.571+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.581+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:580,9.468399,-0.110070,1.787439
04-23 17:39:08.581+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:580,-14.070000,-4.410000,27.719999
04-23 17:39:08.591+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.591+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.601+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:603,9.408579,-0.650848,2.251646
04-23 17:39:08.601+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:603,11.410000,-6.370000,27.299999
04-23 17:39:08.611+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.611+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.621+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:622,9.518648,-1.469193,1.883151
04-23 17:39:08.621+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:622,50.750000,-8.960000,25.760000
04-23 17:39:08.631+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.631+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.641+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:642,9.894321,-1.251446,0.610170
04-23 17:39:08.651+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:642,83.300003,-4.830000,19.460001
04-23 17:39:08.651+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.661+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:659,106.820000,4.130000,16.100000
04-23 17:39:08.661+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.671+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.681+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:670,9.966106,-0.638884,0.047856
04-23 17:39:08.681+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.681+0200 W/LOCATION(31424): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:39:08.691+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:680,121.940002,11.200000,13.720000
04-23 17:39:08.691+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.701+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:690,9.966106,-0.464208,0.143569
04-23 17:39:08.701+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.711+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:699,118.720001,19.110001,9.030000
04-23 17:39:08.711+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:708,9.930215,-0.512064,0.892523
04-23 17:39:08.711+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.721+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:08.721+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:08.721+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.721+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:719,111.300003,23.240000,4.900000
04-23 17:39:08.731+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:727,9.590433,-0.591027,1.000200
04-23 17:39:08.731+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.731+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.741+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:740,120.120003,19.670000,1.890000
04-23 17:39:08.741+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:741,9.566505,-0.844666,1.208375
04-23 17:39:08.751+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.751+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.761+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:761,150.220001,19.740000,-5.040000
04-23 17:39:08.761+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:761,9.707682,-1.210768,1.816152
04-23 17:39:08.771+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.771+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.771+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:779,161.490005,25.620001,-15.050000
04-23 17:39:08.771+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:779,10.085747,0.445065,2.380858
04-23 17:39:08.791+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.791+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.791+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:799,79.029999,24.290001,-14.000000
04-23 17:39:08.791+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:799,9.573684,2.009971,1.914258
04-23 17:39:08.811+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.811+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.811+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:820,-10.010000,12.110000,-5.040000
04-23 17:39:08.821+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:820,9.140583,1.483550,1.765903
04-23 17:39:08.831+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.831+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.831+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:840,-44.590000,3.710000,-2.100000
04-23 17:39:08.841+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:840,9.633504,-0.033500,2.519642
04-23 17:39:08.851+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.851+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.851+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:859,-21.629999,5.740000,-6.510000
04-23 17:39:08.861+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:859,9.810574,-0.971486,2.474179
04-23 17:39:08.871+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.871+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.871+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:879,9.693325,-0.519243,2.823531
04-23 17:39:08.881+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:879,3.430000,8.890000,-13.790000
04-23 17:39:08.891+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.891+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.891+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:899,3.500000,6.930000,-15.260000
04-23 17:39:08.891+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:899,9.439686,0.677169,2.746960
04-23 17:39:08.911+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.911+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.911+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:919,-14.980000,-0.560000,-12.040000
04-23 17:39:08.911+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:919,9.387043,0.854238,2.402394
04-23 17:39:08.921+0200 I/heartrate(31414): capturing data from es.ugr.frailty.heartrate
04-23 17:39:08.921+0200 I/heartrate(31414): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:39:08.941+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.941+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:947,-26.809999,-3.640000,-10.360000
04-23 17:39:08.941+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.951+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:952,9.710074,0.588634,2.419144
04-23 17:39:08.951+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.951+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:959,-27.930000,-2.940000,-9.730000
04-23 17:39:08.951+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.981+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:963,9.683753,-0.208176,2.895315
04-23 17:39:08.981+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:08.991+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:08.991+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:08:995,-15.610000,2.100000,-12.950000
04-23 17:39:08.991+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:09.011+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:08:988,9.458827,-0.081356,3.127419
04-23 17:39:09.011+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:09.011+0200 W/AUL     (31456): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:39:09.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:39:09.011+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:39:09.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 31136
04-23 17:39:09.011+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:39:09.021+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 31136
04-23 17:39:09.021+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(31136)
04-23 17:39:09.021+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:39:09.021+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:39:09.021+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:39:09.021+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:39:09.021+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:39:09.021+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:39:09.021+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:39:09.021+0200 E/CAPI_LOCATION_MANAGER(31441): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:39:09.021+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:39:09.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:39:09.031+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:09:18,9.324830,0.665205,2.746960
04-23 17:39:09.031+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:09:1,-9.030000,-4.340000,-13.300000
04-23 17:39:09.031+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:09.031+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:09.041+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:09:43,9.420543,0.976272,2.237289
04-23 17:39:09.041+0200 I/gyroscope(31401): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:39:09:43,-17.290001,-9.940000,-11.410000
04-23 17:39:09.041+0200 I/gyroscope(31401): capturing data from es.ugr.frailty.gyroscope
04-23 17:39:09.041+0200 I/accelerometer(31398): capturing data from es.ugr.frailty.accelerometer
04-23 17:39:09.061+0200 I/accelerometer(31398): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:39:09:52,9.619147,0.832702,1.744368
04-23 17:39:09.081+0200 I/CAPI_NETWORK_CONNECTION(31441): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:39:09.081+0200 I/CAPI_NETWORK_CONNECTION(31441): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:39:09.081+0200 I/CAPI_NETWORK_CONNECTION(31441): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:39:09.081+0200 I/CAPI_NETWORK_CONNECTION(31441): connection.c: connection_destroy(471) > Destroy handle: 0xf4203a70
04-23 17:39:09.081+0200 W/CRASH_MANAGER(31454): worker.c: worker_job(1205) > 11314246c6f63152449794
