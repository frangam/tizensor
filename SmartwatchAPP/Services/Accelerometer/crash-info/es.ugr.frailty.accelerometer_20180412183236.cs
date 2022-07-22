S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 6418
Date: 2018-04-12 18:32:36+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf4

Register Information
r0   = 0x000000f7, r1   = 0x000000f4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffc1dda0
r6   = 0xf77086c4, r7   = 0x000000f7
r8   = 0x00000014, r9   = 0x00000000
r10  = 0xf77086af, fp   = 0xffc1dd94
ip   = 0xffc1e2d4, sp   = 0xffc1d828
lr   = 0xf75a2e8c, pc   = 0xf75d80b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     73040 KB
Buffers:     41008 KB
Cached:     218836 KB
VmPeak:      43984 KB
VmSize:      43980 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7200 KB
VmRSS:        7200 KB
VmData:      34152 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6418 TID = 6418
6418 6427 6428 6429 6430 

Maps Information
f4d14000 f5513000 rw-p [stack:6430]
f5514000 f5d13000 rw-p [stack:6429]
f5d14000 f6513000 rw-p [stack:6428]
f6514000 f6d17000 rw-p [stack:6427]
f6d17000 f6d1a000 r-xp /lib/libattr.so.1.1.0
f6d22000 f6d29000 r-xp /lib/libcrypt-2.13.so
f6d5a000 f6d5d000 r-xp /lib/libcap.so.2.21
f6d65000 f6d67000 r-xp /usr/lib/libiri.so
f6d6f000 f6d71000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d79000 f6d7b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d84000 f6e50000 r-xp /usr/lib/libxml2.so.2.7.8
f6e5e000 f6e7b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6e84000 f6e88000 r-xp /usr/lib/libsmack.so.1.0.0
f6e91000 f6ea7000 r-xp /lib/libz.so.1.2.5
f6eaf000 f6eb1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6eb9000 f6ebe000 r-xp /usr/lib/libffi.so.5.0.10
f6ec6000 f6ec7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ecf000 f6edf000 r-xp /lib/libresolv-2.13.so
f6ee3000 f6efb000 r-xp /usr/lib/liblzma.so.5.0.3
f6f03000 f6f05000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6f0d000 f6f27000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f2f000 f6f5e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6f67000 f6f76000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6f7f000 f6f89000 r-xp /usr/lib/libsensord-shared.so
f6f92000 f6fc6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fcf000 f70a2000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f70ad000 f70b3000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70bc000 f7131000 r-xp /usr/lib/libsqlite3.so.0.8.6
f713b000 f7141000 r-xp /lib/librt-2.13.so
f714a000 f7168000 r-xp /usr/lib/libsystemd.so.0.4.0
f7172000 f7173000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f717b000 f719e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f71a6000 f71ab000 r-xp /usr/lib/libxdgmime.so.1.1.0
f71b3000 f7283000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7284000 f72ae000 r-xp /usr/lib/libdbus-1.so.3.8.12
f72b7000 f72ce000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f72d6000 f733f000 r-xp /lib/libm-2.13.so
f7348000 f73dc000 r-xp /usr/lib/libstdc++.so.6.0.16
f73ef000 f73f4000 r-xp /usr/lib/libctx-client.so.0.8.3
f73fc000 f7403000 r-xp /usr/lib/libctx-shared.so.0.8.3
f740b000 f7435000 r-xp /usr/lib/libsensor.so.1.9.6
f743e000 f7441000 r-xp /usr/lib/libbundle.so.0.1.22
f7449000 f744f000 r-xp /usr/lib/libappsvc.so.0.1.0
f7457000 f7498000 r-xp /usr/lib/libeina.so.1.7.99
f74a1000 f74b8000 r-xp /usr/lib/libecore.so.1.7.99
f74cf000 f74d8000 r-xp /usr/lib/libvconf.so.0.2.45
f74e0000 f74f4000 r-xp /lib/libpthread-2.13.so
f74ff000 f750c000 r-xp /usr/lib/libaul.so.0.1.0
f7516000 f7518000 r-xp /lib/libdl-2.13.so
f7521000 f752c000 r-xp /lib/libunwind.so.8.0.1
f7559000 f7561000 r-xp /lib/libgcc_s-4.6.so.1
f7562000 f7686000 r-xp /lib/libc-2.13.so
f7694000 f7696000 r-xp /usr/lib/libdlog.so.0.0.0
f769e000 f76aa000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76b3000 f76b7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76c0000 f76c3000 r-xp /usr/lib/libappcore-agent.so.1.1
f76e1000 f76fe000 r-xp /lib/ld-2.13.so
f7707000 f7709000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f7709000 f770d000 r-xp /usr/lib/libsys-assert.so
f7cd2000 f7d14000 rw-p [heap]
ffbff000 ffc20000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6418)
Call Stack Count: 1
 0: strlen + 0x4 (0xf75d80b4) [/lib/libc.so.6] + 0x760b4
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
sage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:33.669+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:26:33.669+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:26:33.679+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 18:26:33.679+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:34.399+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:26:34.929+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 18:26:34.979+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:26:34.999+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:26:35.009+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 18:26:35.029+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 18:26:35.039+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 18:26:35.059+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 18:26:35.309+0200 I/servicemanager( 6299): accelerometer alive timeout
04-12 18:26:35.309+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:26:35.309+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:26:35.319+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6299
04-12 18:26:35.339+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:26:35.339+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6311
04-12 18:26:35.389+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6311
04-12 18:26:35.389+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6311) type(svcapp) bg(0)
04-12 18:26:35.399+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6311)
04-12 18:26:35.399+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6311]
04-12 18:26:35.399+0200 I/servicemanager( 6299): es.ugr.frailty.accelerometer launch request sent!
04-12 18:26:35.399+0200 I/servicemanager( 6299): App control destroyed.
04-12 18:26:35.419+0200 E/CAPI_APPFW_APPLICATION( 6311): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:35.419+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:35.429+0200 E/CAPI_APPFW_APPLICATION( 6311): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:35.429+0200 I/accelerometer( 6311): Starting es.ugr.frailty.accelerometer service
04-12 18:26:35.429+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6311
04-12 18:26:35.429+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6311) was created
04-12 18:26:35.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:35.439+0200 I/accelerometer( 6311): sensor supported
04-12 18:26:35.439+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:35.449+0200 I/accelerometer( 6311): es.ugr.frailty.accelerometer listener started
04-12 18:26:35.449+0200 W/CAPI_APPFW_APP_CONTROL( 6311): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:26:35.449+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6311
04-12 18:26:35.449+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:35.469+0200 I/accelerometer( 6311): accelerometer fecha get
04-12 18:26:35.469+0200 I/accelerometer( 6311): accelerometer fecha conseguida
04-12 18:26:35.559+0200 W/AUL     ( 6327): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:26:35.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:26:35.569+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:26:35.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6311
04-12 18:26:35.569+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:26:35.569+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6311
04-12 18:26:35.569+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6311)
04-12 18:26:35.619+0200 W/CRASH_MANAGER( 6325): worker.c: worker_job(1205) > 11063116163631523550395
04-12 18:26:44.949+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 18:26:44.999+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:26:45.009+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:26:45.029+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 18:26:45.049+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 18:26:45.059+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 18:26:45.079+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 18:26:46.529+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-12 18:26:46.529+0200 W/W_HOME  ( 2742): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-12 18:26:46.529+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-12 18:26:46.529+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-12 18:26:46.529+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_enable(138) > 1
04-12 18:26:46.529+0200 W/W_HOME  ( 2742): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-12 18:26:46.529+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:46.529+0200 W/STARTER ( 2661): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-12 18:26:46.529+0200 W/STARTER ( 2661): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-12 18:26:46.529+0200 E/STARTER ( 2661): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-12 18:26:46.529+0200 E/STARTER ( 2661): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-12 18:26:46.529+0200 W/STARTER ( 2661): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-12 18:26:46.529+0200 W/STARTER ( 2661): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-12 18:26:46.549+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_unset_buffer(1602) > [10071.813784] layer(0x21e2c0) now usable
04-12 18:26:46.549+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [10071.813830] layer[0x21de10]zpos[1]
04-12 18:26:46.549+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_unset_buffer(1602) > [10071.813870] layer(0x21e310) now usable
04-12 18:26:46.549+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [10071.813890] layer[0x21df30]zpos[2]
04-12 18:26:46.549+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [10071.813916] dpms[0 -> 3]sync[1]
04-12 18:26:46.549+0200 I/TDM     ( 1957): 
04-12 18:26:46.549+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -151049460[0;m
04-12 18:26:46.549+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-12 18:26:46.549+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-12 18:26:46.559+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-12 18:26:46.559+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-12 18:26:46.559+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-12 18:26:46.569+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-12 18:26:46.579+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-12 18:26:46.579+0200 W/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-12 18:26:46.579+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-12 18:26:46.579+0200 I/HIGEAR  ( 3240): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-12 18:26:46.679+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [10071.941231] dpms[3 -> 3]done
04-12 18:26:46.679+0200 I/TDM     ( 1957): 
04-12 18:26:46.689+0200 W/SHealthCommon( 2887): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-12 18:26:46.689+0200 I/watchface-viewer( 2828): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-12 18:26:46.689+0200 W/SHealthCommon( 3180): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-12 18:26:46.689+0200 W/SHealthService( 3180): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-12 18:26:46.689+0200 W/W_INDICATOR( 2666): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-12 18:26:46.709+0200 W/STARTER ( 2661): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-12 18:26:46.709+0200 W/STARTER ( 2661): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-12 18:26:46.709+0200 W/STARTER ( 2661): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-12 18:26:46.709+0200 W/STARTER ( 2661): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
04-12 18:26:46.709+0200 E/ALARM_MANAGER( 2661): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(12-4-2018, 18:27:07), repeat(1), interval(20), type(-1073741822)
04-12 18:26:46.719+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: PAUSE State: RUNNING
04-12 18:26:46.719+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-12 18:26:46.719+0200 W/W_HOME  ( 2742): main.c: _appcore_pause_cb(488) > appcore pause
04-12 18:26:46.719+0200 W/W_HOME  ( 2742): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-12 18:26:46.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:46.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:46.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:46.719+0200 W/W_HOME  ( 2742): rotary.c: rotary_deattach(156) > rotary_deattach:0xf8477e70
04-12 18:26:46.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-12 18:26:46.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf8477e70, elm_layout, func : 0xf76d3d05
04-12 18:26:46.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-12 18:26:46.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-12 18:26:46.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-12 18:26:46.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf83b6fd0, elm_box, _activated_obj : 0xf8477e70, activated : 1
04-12 18:26:46.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 18:26:46.719+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:26:46.719+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
04-12 18:26:46.719+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-12 18:26:46.729+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2661].
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:26:46.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:46.769+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:26:46.769+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 18:26:46.779+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
04-12 18:26:46.779+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1141522173, next duetime: 1523550427
04-12 18:26:46.779+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1141522173)
04-12 18:26:46.779+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1523569706), due_time(1523550427)
04-12 18:26:46.789+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-12 18:26:46.789+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-12 18:26:46.789+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-4-2018, 16:27:07 (UTC).
04-12 18:26:46.789+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-12 18:26:46.789+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:26:46.789+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:26:46.789+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-12 18:26:46.789+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-12 18:26:46.789+0200 W/W_INDICATOR( 2666): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-12 18:26:46.799+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-12 18:26:47.259+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 18:26:51.779+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 18:27:00.549+0200 W/APPS    ( 2742): apps_main.c: _time_changed_cb(308) >  date : 12->12
04-12 18:27:06.999+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __alarm_handler_idle(1486) > Lock the display not to enter LCD OFF
04-12 18:27:06.999+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-12 18:27:07.019+0200 W/AUL     ( 2495): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(2661) type(wakeup)
04-12 18:27:07.029+0200 E/RESOURCED( 2529): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 2661
04-12 18:27:07.029+0200 E/ALARM_MANAGER( 2661): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1141522173]
04-12 18:27:07.029+0200 W/STARTER ( 2661): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(979) > [__starter_clock_mgr_homescreen_alarm_cb:979] homescreen alarm timer expired [1141522173]
04-12 18:27:07.039+0200 W/AUL     ( 2661): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
04-12 18:27:07.039+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:27:07.049+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 2661
04-12 18:27:07.059+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2742) type(uiapp) bg(0)
04-12 18:27:07.059+0200 W/AUL_AMD ( 2499): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2742
04-12 18:27:07.059+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESET State: PAUSED
04-12 18:27:07.059+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_reset(245) > app_appcore_reset
04-12 18:27:07.059+0200 W/CAPI_APPFW_APP_CONTROL( 2742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): main.c: _app_control_progress(1571) > Service value : show_clock
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): main.c: _app_control_progress(1588) > Show clock operation
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): gesture.c: _clock_show(242) > clock show
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): gesture.c: _clock_show(257) > home raise
04-12 18:27:07.059+0200 E/W_HOME  ( 2742): gesture.c: gesture_win_aux_set(402) > wm.policy.win.do.not.use.deiconify.approve:-1
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): dbus_util.c: home_dbus_home_raise_signal_send(298) > Sending HOME RAISE signal, result:0
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): gesture.c: _clock_show(260) > home raise done
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): gesture.c: _clock_show(267) > show clock
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): index.c: index_hide(337) > hide VI:0 visibility:0 vi:(nil)
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): move.c: move_back_to_home_no_anim(274) > back to home no anim
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): rotary.c: rotary_attach(138) > rotary_attach:0xf86145d0
04-12 18:27:07.059+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf86145d0, elm_layout, _activated_obj : 0xf83b6fd0, activated : 1
04-12 18:27:07.059+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): event_manager.c: _move_module_anim_start_cb(666) > state: 0 -> 1
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): event_manager.c: _move_module_anim_end_cb(680) > state: 1 -> 0
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): rotary.c: rotary_deattach(156) > rotary_deattach:0xf86145d0
04-12 18:27:07.059+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-12 18:27:07.059+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf86145d0, elm_layout, func : 0xf76d3d05
04-12 18:27:07.059+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-12 18:27:07.059+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-12 18:27:07.059+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-12 18:27:07.059+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf83b6fd0, elm_box, _activated_obj : 0xf86145d0, activated : 1
04-12 18:27:07.059+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 18:27:07.059+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:27:07.059+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
04-12 18:27:07.059+0200 W/W_HOME  ( 2742): gesture.c: _manual_render(182) > 
04-12 18:27:07.079+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:27:07.079+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:27:07.079+0200 W/AUL_AMD ( 2499): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(2742), cmd(0)
04-12 18:27:07.079+0200 W/AUL     ( 2661): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2742)
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __alarm_expired(1447) > alarm_id[1141522173] is expired.
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1141522173, next duetime: 1523550447
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(97378666) is OVER.
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(405561765) is OVER.
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2077840997) is OVER.
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-4-2018, 16:27:27 (UTC).
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-12 18:27:07.099+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __alarm_handler_idle(1512) > Unlock the display from LCD OFF
04-12 18:27:07.109+0200 W/W_INDICATOR( 2666): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-12 18:27:07.109+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-12 18:27:07.109+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2661].
04-12 18:27:07.109+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1141522173)
04-12 18:27:07.109+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(97378666) is OVER.
04-12 18:27:07.109+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
04-12 18:27:07.109+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(405561765) is OVER.
04-12 18:27:07.109+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2077840997) is OVER.
04-12 18:27:07.119+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-12 18:27:07.119+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-12 18:27:07.119+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-4-2018, 21:48:26 (UTC).
04-12 18:27:07.119+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-12 18:27:07.129+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-12 18:27:07.129+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[1141522173] is removed.
04-12 18:27:07.139+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [2742]
04-12 18:27:07.189+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _apptray_visibility_cb(604) > apps,hide,start
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): clock_manager.c: _compositing_set(205) > hwc:1
04-12 18:27:07.189+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:27:07.189+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): noti_broker.c: _apptray_visibility_cb(793) > apps,hide,start
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80002
04-12 18:27:07.189+0200 W/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80002
04-12 18:27:07.189+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_handle_view_event(1396) > Unhandled type: 0x80002
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _apptray_visibility_cb(604) > apps,hide
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): noti_broker.c: _apptray_visibility_cb(793) > apps,hide
04-12 18:27:07.189+0200 W/W_HOME  ( 2742): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80001
04-12 18:27:07.189+0200 W/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80001
04-12 18:27:07.189+0200 I/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 0
04-12 18:27:07.189+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 0.
04-12 18:27:07.189+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:27:07.189+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:27:07.189+0200 E/APPS    ( 2742): apps_main.c: apps_main_pause(984) >  paused already
04-12 18:27:07.199+0200 W/W_HOME  ( 2742): clock_manager.c: _hwc_enabled_success_cb(153) > hwc enabled
04-12 18:27:07.199+0200 W/W_HOME  ( 2742): clock_manager.c: _hwc_enabled_success_cb(156) > do manual_render to show HWC window
04-12 18:27:08.059+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:27:08.059+0200 W/AUL_AMD ( 2499): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
04-12 18:27:35.509+0200 I/servicemanager( 6299): accelerometer sleep timeout
04-12 18:27:35.509+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:27:35.509+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:27:35.519+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6299
04-12 18:27:35.529+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6383
04-12 18:27:35.539+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:27:35.589+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6383
04-12 18:27:35.589+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6383) type(svcapp) bg(0)
04-12 18:27:35.589+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6383]
04-12 18:27:35.619+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:27:35.629+0200 E/CAPI_APPFW_APPLICATION( 6383): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:27:35.629+0200 E/CAPI_APPFW_APPLICATION( 6383): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:27:35.629+0200 I/accelerometer( 6383): Starting es.ugr.frailty.accelerometer service
04-12 18:27:35.629+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6383
04-12 18:27:35.629+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6383) was created
04-12 18:27:35.629+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:27:35.629+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6383)
04-12 18:27:35.629+0200 I/servicemanager( 6299): es.ugr.frailty.accelerometer stop request sent!
04-12 18:27:35.629+0200 I/servicemanager( 6299): App control destroyed.
04-12 18:27:35.629+0200 I/accelerometer( 6383): sensor supported
04-12 18:27:35.639+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:27:35.649+0200 I/accelerometer( 6383): es.ugr.frailty.accelerometer listener started
04-12 18:27:35.649+0200 I/accelerometer( 6383): Stopping es.ugr.frailty.accelerometer service
04-12 18:27:35.649+0200 E/CAPI_APPFW_APP_CONTROL( 6383): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-12 18:27:35.649+0200 E/utils   ( 6383): request sending failed to service es.ugr.frailty.servicemanager
04-12 18:27:35.649+0200 I/CAPI_APPFW_APPLICATION( 6383): service_app_main.c: service_app_exit(441) > service_app_exit
04-12 18:27:35.649+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6383
04-12 18:27:35.659+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:27:35.659+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:27:35.659+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:27:35.729+0200 E/PKGMGR_INFO( 2938): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-12 18:27:35.739+0200 E/PKGMGR_INFO( 2938): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-12 18:27:35.749+0200 I/accelerometer( 6383): es.ugr.frailty.accelerometer listener destroyed
04-12 18:27:35.879+0200 W/AUL     ( 6397): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:27:35.879+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:27:35.879+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:27:35.879+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6383
04-12 18:27:35.879+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:27:35.899+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6383
04-12 18:27:35.909+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6383)
04-12 18:27:37.659+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:32:35.849+0200 I/servicemanager( 6299): accelerometer alive timeout
04-12 18:32:35.849+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:32:35.859+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:32:35.859+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6299
04-12 18:32:35.879+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6418
04-12 18:32:35.879+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:32:35.929+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6418
04-12 18:32:35.929+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6418) type(svcapp) bg(0)
04-12 18:32:35.939+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6418)
04-12 18:32:35.939+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6418]
04-12 18:32:35.939+0200 I/servicemanager( 6299): es.ugr.frailty.accelerometer launch request sent!
04-12 18:32:35.939+0200 I/servicemanager( 6299): App control destroyed.
04-12 18:32:35.959+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:32:35.959+0200 E/CAPI_APPFW_APPLICATION( 6418): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:32:35.959+0200 E/CAPI_APPFW_APPLICATION( 6418): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:32:35.959+0200 I/accelerometer( 6418): Starting es.ugr.frailty.accelerometer service
04-12 18:32:35.969+0200 I/accelerometer( 6418): sensor supported
04-12 18:32:35.969+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6418
04-12 18:32:35.969+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6418) was created
04-12 18:32:35.969+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:32:35.979+0200 I/accelerometer( 6418): es.ugr.frailty.accelerometer listener started
04-12 18:32:35.979+0200 W/CAPI_APPFW_APP_CONTROL( 6418): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:32:35.989+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:32:35.999+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6418
04-12 18:32:35.999+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:32:35.999+0200 I/accelerometer( 6418): accelerometer fecha get
04-12 18:32:35.999+0200 I/accelerometer( 6418): accelerometer fecha conseguida
04-12 18:32:36.119+0200 W/AUL     ( 6435): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:32:36.119+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:32:36.119+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:32:36.119+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6418
04-12 18:32:36.119+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:32:36.139+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6418
04-12 18:32:36.139+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6418)
04-12 18:32:36.139+0200 W/CRASH_MANAGER( 6432): worker.c: worker_job(1205) > 1106418616363152355075
