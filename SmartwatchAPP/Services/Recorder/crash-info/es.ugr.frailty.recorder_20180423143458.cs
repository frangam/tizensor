S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 6677
Date: 2018-04-23 14:34:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7486648, r1   = 0xf75b91b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf75b91b8, r5   = 0x00012cd0
r6   = 0xf75cbe88, r7   = 0xf7486250
r8   = 0x00000618, r9   = 0xf6f69824
r10  = 0xf75b19d8, fp   = 0x00000000
ip   = 0xf7485030, sp   = 0xffe80ec0
lr   = 0xf73c95d0, pc   = 0xf73c59fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     62904 KB
Buffers:     39364 KB
Cached:     221228 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7700 KB
VmRSS:        7696 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          32 KB
VmSwap:          0 KB

Maps Information
f6b00000 f6b03000 r-xp /lib/libattr.so.1.1.0
f6b0c000 f6b13000 r-xp /lib/libcrypt-2.13.so
f6b43000 f6b46000 r-xp /lib/libcap.so.2.21
f6b4e000 f6b50000 r-xp /usr/lib/libiri.so
f6b58000 f6b75000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b7e000 f6b82000 r-xp /usr/lib/libsmack.so.1.0.0
f6b8c000 f6b8e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b96000 f6b9b000 r-xp /usr/lib/libffi.so.5.0.10
f6ba3000 f6ba4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bac000 f6bae000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bb6000 f6bb8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bc2000 f6bd2000 r-xp /lib/libresolv-2.13.so
f6bd6000 f6bee000 r-xp /usr/lib/liblzma.so.5.0.3
f6bf6000 f6bf8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c00000 f6c2f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c38000 f6c47000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c50000 f6c5a000 r-xp /usr/lib/libsensord-shared.so
f6c63000 f6c97000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ca0000 f6d73000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d7e000 f6d94000 r-xp /lib/libz.so.1.2.5
f6d9c000 f6da2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dab000 f6e20000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e2a000 f6e44000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e4c000 f6e52000 r-xp /lib/librt-2.13.so
f6e5b000 f6e79000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e83000 f6e84000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e8c000 f6e91000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e99000 f6f69000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f6a000 f6f94000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f9d000 f6fb4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fbc000 f7025000 r-xp /lib/libm-2.13.so
f702e000 f70c2000 r-xp /usr/lib/libstdc++.so.6.0.16
f70d5000 f70da000 r-xp /usr/lib/libctx-client.so.0.8.3
f70e2000 f70e9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70f1000 f711b000 r-xp /usr/lib/libsensor.so.1.9.6
f7124000 f71f0000 r-xp /usr/lib/libxml2.so.2.7.8
f71fd000 f71ff000 r-xp /usr/lib/libiniparser.so.0
f7208000 f720b000 r-xp /usr/lib/libbundle.so.0.1.22
f7213000 f7219000 r-xp /usr/lib/libappsvc.so.0.1.0
f7221000 f7244000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f724c000 f728d000 r-xp /usr/lib/libeina.so.1.7.99
f7296000 f72ad000 r-xp /usr/lib/libecore.so.1.7.99
f72c4000 f72cd000 r-xp /usr/lib/libvconf.so.0.2.45
f72d5000 f72e9000 r-xp /lib/libpthread-2.13.so
f72f4000 f7301000 r-xp /usr/lib/libaul.so.0.1.0
f730b000 f730d000 r-xp /lib/libdl-2.13.so
f7316000 f7321000 r-xp /lib/libunwind.so.8.0.1
f734e000 f7356000 r-xp /lib/libgcc_s-4.6.so.1
f7357000 f747b000 r-xp /lib/libc-2.13.so
f7489000 f748b000 r-xp /usr/lib/libdlog.so.0.0.0
f7493000 f749f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74a8000 f74ad000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74b5000 f74b9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74c2000 f74c4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f74cd000 f74d0000 r-xp /usr/lib/libappcore-agent.so.1.1
f74ee000 f750b000 r-xp /lib/ld-2.13.so
f7514000 f7517000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7517000 f751b000 r-xp /usr/lib/libsys-assert.so
f75a7000 f75f5000 rw-p [heap]
ffe63000 ffe84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6677)
Call Stack Count: 1
 0: (0xf73c59fc) [/lib/libc.so.6] + 0x6e9fc
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
: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:45.491+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 14:34:45.491+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 14:34:45.491+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 14:34:45.491+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 14:34:45.491+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 14:34:45.491+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 14:34:45.491+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:34:45.491+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:45.501+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 14:34:45.501+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 14:34:45.501+0200 I/TIZEN_N_SOUND_MANAGER( 3238): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 14:34:45.501+0200 W/TIZEN_N_SOUND_MANAGER( 3238): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:34:45.501+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:45.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:45.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:45.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:45.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:45.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:45.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:46.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:46.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:46.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:46.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:46.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:46.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:46.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:46.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:46.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:46.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:47.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:47.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:47.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:47.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:47.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:47.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:47.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:47.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:47.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:47.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:48.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:48.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:48.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:48.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:48.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:48.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:48.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:48.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:48.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:48.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:49.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:49.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:49.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:49.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:49.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:49.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:49.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:49.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:49.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:49.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:50.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:50.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:50.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:50.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:50.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:50.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:50.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:50.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:50.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:50.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:51.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:51.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:51.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:51.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:51.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:51.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:51.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:51.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:51.961+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 14:34:51.961+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 14:34:51.961+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 14:34:51.961+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 14:34:51.961+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 14:34:51.961+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 14:34:51.961+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 14:34:51.971+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 14:34:51.971+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 14:34:51.971+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 14:34:51.971+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 14:34:51.971+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 14:34:51.971+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:34:51.981+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 14:34:51.981+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 14:34:51.981+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 14:34:51.981+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [787.643098] layer(0x5ac2c0) now usable
04-23 14:34:51.981+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [787.643144] layer[0x5abe10]zpos[1]
04-23 14:34:51.981+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [787.643187] layer(0x5ac310) now usable
04-23 14:34:51.981+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [787.643206] layer[0x5abf30]zpos[2]
04-23 14:34:51.981+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [787.643250] layer(0x5ac250) now usable
04-23 14:34:51.981+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [787.643268] layer[0x5abcf0]zpos[0]
04-23 14:34:51.981+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [787.643432] dpms[0 -> 3]sync[1]
04-23 14:34:51.981+0200 I/TDM     ( 1785): 
04-23 14:34:51.981+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 14:34:51.981+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 14:34:51.981+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 14:34:51.981+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 14:34:51.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:51.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:52.001+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 14:34:52.001+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 14:34:52.001+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 14:34:52.001+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 14:34:52.131+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [787.791265] dpms[3 -> 3]done
04-23 14:34:52.131+0200 I/TDM     ( 1785): 
04-23 14:34:52.131+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 14:34:52.141+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 14:34:52.141+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 14:34:52.141+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 14:34:52.141+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 14:34:52.161+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 14:34:52.161+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 14:34:52.161+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 14:34:52.161+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 14:34:52.161+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 14:34:52.161+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 14:34:52.161+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 14:34:52.161+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 14:34:52.161+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 14:34:52.161+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 14:34:52.161+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 14:34:52.161+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:34:52.161+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:34:52.161+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 14:34:52.161+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:34:52.161+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:52.161+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:52.161+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:34:52.171+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:52.171+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 14:34:52.171+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 14:34:52.171+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 14:34:52.171+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 14:34:52.181+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 14:34:52.181+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 14:34:52.181+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 14:34:52.671+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 14:34:57.181+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 14:34:57.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:34:57.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:57.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:58.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:34:58.011+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:34:58.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:34:58.011+0200 I/utils   ( 4443): specific action
04-23 14:34:58.011+0200 I/httppostreq( 4443): internet connection check received
04-23 14:34:58.011+0200 I/httppostreq( 4443): internet connection != null
04-23 14:34:58.011+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:34:58.011+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:34:58.011+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:34:58.011+0200 I/httppostreq( 4443): internet connection type...
04-23 14:34:58.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:34:58.011+0200 I/httppostreq( 4443): internet available
04-23 14:34:58.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:34:58.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:34:58.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:34:58.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:34:58.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:34:58.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:58.041+0200 I/utils   ( 4440): specific action
04-23 14:34:58.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:58.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:58.041+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:34:58.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:58.041+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:34:58.041+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:34:58.041+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:34:58.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:58.061+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:58.061+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6639
04-23 14:34:58.121+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6639
04-23 14:34:58.121+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6639) type(svcapp) bg(0)
04-23 14:34:58.121+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6639)
04-23 14:34:58.121+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:34:58.121+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:34:58.121+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:34:58.121+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6639]
04-23 14:34:58.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:58.131+0200 E/CAPI_APPFW_APPLICATION( 6639): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.141+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6642
04-23 14:34:58.141+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:58.151+0200 E/CAPI_APPFW_APPLICATION( 6639): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.151+0200 I/utils   ( 6639): trying to start service: es.ugr.frailty.accelerometer
04-23 14:34:58.161+0200 I/utils   ( 6639): es.ugr.frailty.accelerometer sensor supported
04-23 14:34:58.171+0200 I/utils   ( 6639): es.ugr.frailty.accelerometer listener started
04-23 14:34:58.171+0200 I/accelerometer( 6639): stopping es.ugr.frailty.accelerometer service
04-23 14:34:58.171+0200 E/CAPI_APPFW_APP_CONTROL( 6639): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.171+0200 E/accelerometer( 6639): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:34:58.171+0200 I/CAPI_APPFW_APPLICATION( 6639): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:34:58.181+0200 E/CAPI_APPFW_APPLICATION( 6642): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.181+0200 E/CAPI_APPFW_APPLICATION( 6642): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.191+0200 I/utils   ( 6642): trying to start service: es.ugr.frailty.gyroscope
04-23 14:34:58.191+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6642
04-23 14:34:58.191+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(6642) type(svcapp) bg(0)
04-23 14:34:58.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6642)
04-23 14:34:58.191+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:34:58.191+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:34:58.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:34:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6639
04-23 14:34:58.201+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6639) was created
04-23 14:34:58.201+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6642) was created
04-23 14:34:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6639
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:58.211+0200 I/utils   ( 6642): es.ugr.frailty.gyroscope sensor supported
04-23 14:34:58.221+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6661
04-23 14:34:58.231+0200 I/utils   ( 6642): es.ugr.frailty.gyroscope listener started
04-23 14:34:58.231+0200 I/gyroscope( 6642): stopping es.ugr.frailty.gyroscope service
04-23 14:34:58.231+0200 E/CAPI_APPFW_APP_CONTROL( 6642): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.231+0200 E/gyroscope( 6642): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:34:58.231+0200 I/CAPI_APPFW_APPLICATION( 6642): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:34:58.241+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6642]
04-23 14:34:58.241+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:58.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6661
04-23 14:34:58.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(6661) type(svcapp) bg(0)
04-23 14:34:58.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:34:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:34:58.281+0200 E/CAPI_APPFW_APPLICATION( 6661): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.281+0200 E/CAPI_APPFW_APPLICATION( 6661): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.291+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6661) was created
04-23 14:34:58.291+0200 I/utils   ( 6661): trying to start service: es.ugr.frailty.heartrate
04-23 14:34:58.291+0200 I/utils   ( 6661): es.ugr.frailty.heartrate sensor supported
04-23 14:34:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.301+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6642
04-23 14:34:58.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.311+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6661]
04-23 14:34:58.311+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6661)
04-23 14:34:58.311+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:34:58.311+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:34:58.321+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:34:58.321+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:34:58.321+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:34:58.321+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:34:58.321+0200 I/utils   ( 6661): es.ugr.frailty.heartrate listener started
04-23 14:34:58.321+0200 I/heartrate( 6661): stopping es.ugr.frailty.heartrate service
04-23 14:34:58.321+0200 E/CAPI_APPFW_APP_CONTROL( 6661): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.321+0200 E/heartrate( 6661): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:34:58.321+0200 I/CAPI_APPFW_APPLICATION( 6661): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:34:58.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:34:58.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:34:58.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:34:58.331+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:34:58.331+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:34:58.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:34:58.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.341+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6661
04-23 14:34:58.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.351+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6642
04-23 14:34:58.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.351+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:34:58.351+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:34:58.351+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:34:58.351+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:34:58.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.361+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:58.371+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6677
04-23 14:34:58.381+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:58.391+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.401+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.411+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6677
04-23 14:34:58.421+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6677) type(svcapp) bg(0)
04-23 14:34:58.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.421+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6677]
04-23 14:34:58.421+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6677
04-23 14:34:58.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.451+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6677)
04-23 14:34:58.451+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:34:58.471+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.481+0200 I/accelerometer( 6639): es.ugr.frailty.accelerometer listener destroyed
04-23 14:34:58.481+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.481+0200 E/CAPI_APPFW_APPLICATION( 6677): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.481+0200 E/CAPI_APPFW_APPLICATION( 6677): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.481+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6677) was created
04-23 14:34:58.481+0200 I/utils   ( 6677): specific action
04-23 14:34:58.481+0200 I/recorder( 6677): obteniendo datos locales...
04-23 14:34:58.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.511+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6661
04-23 14:34:58.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.541+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6677
04-23 14:34:58.541+0200 I/heartrate( 6661): es.ugr.frailty.heartrate listener destroyed
04-23 14:34:58.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.541+0200 I/gyroscope( 6642): es.ugr.frailty.gyroscope listener destroyed
04-23 14:34:58.541+0200 I/recorder( 6677): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:34:58.601+0200 W/AUL     ( 6684): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 14:34:58.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:34:58.601+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:34:58.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6639
04-23 14:34:58.601+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:34:58.601+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6639
04-23 14:34:58.601+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6639)
04-23 14:34:58.611+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1106677726563152448689
