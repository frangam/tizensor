S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 6469
Date: 2018-04-23 14:34:18+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf703c648, r1   = 0xf75331b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf75331b8, r5   = 0x00012cd0
r6   = 0xf7545e88, r7   = 0xf703c250
r8   = 0x00000618, r9   = 0xf6b1f824
r10  = 0xf752b9d8, fp   = 0x00000000
ip   = 0xf703b030, sp   = 0xffdee8e0
lr   = 0xf6f7f5d0, pc   = 0xf6f7b9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     63156 KB
Buffers:     38904 KB
Cached:     220980 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7692 KB
VmRSS:        7688 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f66b6000 f66b9000 r-xp /lib/libattr.so.1.1.0
f66c2000 f66c9000 r-xp /lib/libcrypt-2.13.so
f66f9000 f66fc000 r-xp /lib/libcap.so.2.21
f6704000 f6706000 r-xp /usr/lib/libiri.so
f670e000 f672b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6734000 f6738000 r-xp /usr/lib/libsmack.so.1.0.0
f6742000 f6744000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f674c000 f6751000 r-xp /usr/lib/libffi.so.5.0.10
f6759000 f675a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6762000 f6764000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f676c000 f676e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6778000 f6788000 r-xp /lib/libresolv-2.13.so
f678c000 f67a4000 r-xp /usr/lib/liblzma.so.5.0.3
f67ac000 f67ae000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67b6000 f67e5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67ee000 f67fd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6806000 f6810000 r-xp /usr/lib/libsensord-shared.so
f6819000 f684d000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6856000 f6929000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6934000 f694a000 r-xp /lib/libz.so.1.2.5
f6952000 f6958000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6961000 f69d6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69e0000 f69fa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a02000 f6a08000 r-xp /lib/librt-2.13.so
f6a11000 f6a2f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a39000 f6a3a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a42000 f6a47000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a4f000 f6b1f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6b20000 f6b4a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b53000 f6b6a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b72000 f6bdb000 r-xp /lib/libm-2.13.so
f6be4000 f6c78000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c8b000 f6c90000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c98000 f6c9f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ca7000 f6cd1000 r-xp /usr/lib/libsensor.so.1.9.6
f6cda000 f6da6000 r-xp /usr/lib/libxml2.so.2.7.8
f6db3000 f6db5000 r-xp /usr/lib/libiniparser.so.0
f6dbe000 f6dc1000 r-xp /usr/lib/libbundle.so.0.1.22
f6dc9000 f6dcf000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dd7000 f6dfa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e02000 f6e43000 r-xp /usr/lib/libeina.so.1.7.99
f6e4c000 f6e63000 r-xp /usr/lib/libecore.so.1.7.99
f6e7a000 f6e83000 r-xp /usr/lib/libvconf.so.0.2.45
f6e8b000 f6e9f000 r-xp /lib/libpthread-2.13.so
f6eaa000 f6eb7000 r-xp /usr/lib/libaul.so.0.1.0
f6ec1000 f6ec3000 r-xp /lib/libdl-2.13.so
f6ecc000 f6ed7000 r-xp /lib/libunwind.so.8.0.1
f6f04000 f6f0c000 r-xp /lib/libgcc_s-4.6.so.1
f6f0d000 f7031000 r-xp /lib/libc-2.13.so
f703f000 f7041000 r-xp /usr/lib/libdlog.so.0.0.0
f7049000 f7055000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f705e000 f7063000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f706b000 f706f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7078000 f707a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7083000 f7086000 r-xp /usr/lib/libappcore-agent.so.1.1
f70a4000 f70c1000 r-xp /lib/ld-2.13.so
f70ca000 f70cd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f70cd000 f70d1000 r-xp /usr/lib/libsys-assert.so
f7521000 f756f000 rw-p [heap]
ffdd0000 ffdf1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6469)
Call Stack Count: 1
 0: (0xf6f7b9fc) [/lib/libc.so.6] + 0x6e9fc
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
EFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 14:34:01.701+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 14:34:01.701+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 14:34:01.701+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3238]   bundle_add_str() .. [0xffffffea][0m
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:01.701+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 14:34:01.701+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 14:34:01.701+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 14:34:01.701+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 14:34:01.701+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 14:34:01.701+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 14:34:01.701+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:01.701+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:01.711+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 14:34:01.711+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 14:34:01.711+0200 I/TIZEN_N_SOUND_MANAGER( 3238): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 14:34:01.711+0200 W/TIZEN_N_SOUND_MANAGER( 3238): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:34:01.711+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:01.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:01.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:01.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:01.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:02.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:02.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:02.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:02.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:02.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:02.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:02.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:02.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:02.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:02.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:03.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:03.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:03.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:03.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:03.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:03.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:03.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:03.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:03.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:03.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:04.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:04.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:04.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:04.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:04.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:04.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:04.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:04.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:04.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:04.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:05.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:05.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:05.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:05.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:05.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:05.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:05.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:05.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:05.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:05.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:06.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:06.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:06.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:06.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:06.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:06.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:06.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:06.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:06.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:06.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:07.191+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 14:34:07.191+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 14:34:07.191+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 14:34:07.191+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 14:34:07.191+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 14:34:07.191+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 14:34:07.191+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 14:34:07.191+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 14:34:07.191+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 14:34:07.191+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 14:34:07.191+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:34:07.191+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 14:34:07.191+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 14:34:07.191+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 14:34:07.191+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 14:34:07.191+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 14:34:07.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:07.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:07.201+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [742.869362] layer(0x5ac2c0) now usable
04-23 14:34:07.201+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [742.869421] layer[0x5abe10]zpos[1]
04-23 14:34:07.201+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [742.869464] layer(0x5ac310) now usable
04-23 14:34:07.201+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [742.869483] layer[0x5abf30]zpos[2]
04-23 14:34:07.201+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [742.869517] layer(0x5ac250) now usable
04-23 14:34:07.201+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [742.869534] layer[0x5abcf0]zpos[0]
04-23 14:34:07.201+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [742.869561] dpms[0 -> 3]sync[1]
04-23 14:34:07.201+0200 I/TDM     ( 1785): 
04-23 14:34:07.211+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 14:34:07.211+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 14:34:07.211+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 14:34:07.211+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 14:34:07.221+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 14:34:07.221+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 14:34:07.221+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 14:34:07.221+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 14:34:07.351+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [743.011264] dpms[3 -> 3]done
04-23 14:34:07.351+0200 I/TDM     ( 1785): 
04-23 14:34:07.351+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 14:34:07.361+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 14:34:07.361+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 14:34:07.371+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 14:34:07.371+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 14:34:07.381+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 14:34:07.381+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 14:34:07.381+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 14:34:07.381+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 14:34:07.381+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 14:34:07.381+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 14:34:07.391+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 14:34:07.391+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 14:34:07.391+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 14:34:07.391+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 14:34:07.391+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:34:07.391+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 14:34:07.391+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:34:07.391+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 14:34:07.391+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:07.391+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 14:34:07.391+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:34:07.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:34:07.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:34:07.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:34:07.391+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 14:34:07.401+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 14:34:07.401+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 14:34:07.401+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 14:34:07.401+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 14:34:07.891+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 14:34:12.411+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 14:34:17.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:34:17.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:17.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:18.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:34:18.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:34:18.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:34:18.001+0200 I/utils   ( 4443): specific action
04-23 14:34:18.001+0200 I/httppostreq( 4443): internet connection check received
04-23 14:34:18.001+0200 I/httppostreq( 4443): internet connection != null
04-23 14:34:18.001+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:34:18.001+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:34:18.011+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:34:18.011+0200 I/httppostreq( 4443): internet connection type...
04-23 14:34:18.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:34:18.011+0200 I/httppostreq( 4443): internet available
04-23 14:34:18.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:34:18.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:18.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:34:18.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:34:18.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:34:18.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:34:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:18.031+0200 I/utils   ( 4440): specific action
04-23 14:34:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:18.031+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:34:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:18.031+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:34:18.031+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:34:18.031+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:34:18.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:18.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:18.051+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6440
04-23 14:34:18.051+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:18.101+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6440
04-23 14:34:18.101+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6440) type(svcapp) bg(0)
04-23 14:34:18.101+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6440)
04-23 14:34:18.101+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:34:18.101+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:34:18.101+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:34:18.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:18.101+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6440]
04-23 14:34:18.101+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:18.121+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6443
04-23 14:34:18.121+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:18.131+0200 E/CAPI_APPFW_APPLICATION( 6440): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.131+0200 E/CAPI_APPFW_APPLICATION( 6440): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.131+0200 I/utils   ( 6440): trying to start service: es.ugr.frailty.accelerometer
04-23 14:34:18.141+0200 I/utils   ( 6440): es.ugr.frailty.accelerometer sensor supported
04-23 14:34:18.151+0200 I/utils   ( 6440): es.ugr.frailty.accelerometer listener started
04-23 14:34:18.151+0200 I/accelerometer( 6440): stopping es.ugr.frailty.accelerometer service
04-23 14:34:18.151+0200 E/CAPI_APPFW_APP_CONTROL( 6440): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.151+0200 E/accelerometer( 6440): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:34:18.151+0200 I/CAPI_APPFW_APPLICATION( 6440): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:34:18.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6443
04-23 14:34:18.171+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(6443) type(svcapp) bg(0)
04-23 14:34:18.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:18.181+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6440
04-23 14:34:18.181+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6440) was created
04-23 14:34:18.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:34:18.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:34:18.181+0200 E/CAPI_APPFW_APPLICATION( 6443): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.181+0200 E/CAPI_APPFW_APPLICATION( 6443): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:18.181+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6443) was created
04-23 14:34:18.181+0200 I/utils   ( 6443): trying to start service: es.ugr.frailty.gyroscope
04-23 14:34:18.181+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6443]
04-23 14:34:18.181+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6443)
04-23 14:34:18.181+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:34:18.181+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:34:18.181+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:34:18.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:18.181+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:18.201+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6457
04-23 14:34:18.201+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:18.201+0200 I/utils   ( 6443): es.ugr.frailty.gyroscope sensor supported
04-23 14:34:18.211+0200 I/utils   ( 6443): es.ugr.frailty.gyroscope listener started
04-23 14:34:18.211+0200 I/gyroscope( 6443): stopping es.ugr.frailty.gyroscope service
04-23 14:34:18.211+0200 E/CAPI_APPFW_APP_CONTROL( 6443): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.211+0200 E/gyroscope( 6443): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:34:18.211+0200 I/CAPI_APPFW_APPLICATION( 6443): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:34:18.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6457
04-23 14:34:18.251+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(6457) type(svcapp) bg(0)
04-23 14:34:18.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:18.261+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6443
04-23 14:34:18.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:34:18.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:34:18.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:18.261+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6440
04-23 14:34:18.271+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6457)
04-23 14:34:18.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:18.271+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:34:18.281+0200 E/CAPI_APPFW_APPLICATION( 6457): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.281+0200 E/CAPI_APPFW_APPLICATION( 6457): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.281+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6457) was created
04-23 14:34:18.281+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6457]
04-23 14:34:18.281+0200 I/utils   ( 6457): trying to start service: es.ugr.frailty.heartrate
04-23 14:34:18.281+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:34:18.281+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:34:18.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:34:18.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:34:18.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:34:18.281+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:34:18.281+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:34:18.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:34:18.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:34:18.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:34:18.281+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:34:18.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:34:18.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:34:18.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:34:18.281+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:34:18.281+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:34:18.281+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:34:18.281+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:34:18.281+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:34:18.281+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:34:18.281+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:34:18.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:18.281+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:18.291+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6469
04-23 14:34:18.291+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:18.301+0200 I/utils   ( 6457): es.ugr.frailty.heartrate sensor supported
04-23 14:34:18.341+0200 E/CAPI_APPFW_APPLICATION( 6469): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.341+0200 E/CAPI_APPFW_APPLICATION( 6469): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.341+0200 I/utils   ( 6469): specific action
04-23 14:34:18.341+0200 I/recorder( 6469): obteniendo datos locales...
04-23 14:34:18.351+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6469
04-23 14:34:18.351+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6469) type(svcapp) bg(0)
04-23 14:34:18.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:18.361+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6457
04-23 14:34:18.361+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6469) was created
04-23 14:34:18.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:18.371+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6469]
04-23 14:34:18.371+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6469)
04-23 14:34:18.371+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:34:18.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:18.381+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:18.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6469
04-23 14:34:18.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:18.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:18.391+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:18.411+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:18.421+0200 I/utils   ( 6457): es.ugr.frailty.heartrate listener started
04-23 14:34:18.421+0200 I/heartrate( 6457): stopping es.ugr.frailty.heartrate service
04-23 14:34:18.421+0200 E/CAPI_APPFW_APP_CONTROL( 6457): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:34:18.421+0200 E/heartrate( 6457): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:34:18.421+0200 I/CAPI_APPFW_APPLICATION( 6457): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:34:18.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:34:18.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:34:18.421+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:18.431+0200 I/accelerometer( 6440): es.ugr.frailty.accelerometer listener destroyed
04-23 14:34:18.441+0200 I/recorder( 6469): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:34:18.441+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:34:18.451+0200 I/recorder( 6469): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:34:18.471+0200 I/gyroscope( 6443): es.ugr.frailty.gyroscope listener destroyed
04-23 14:34:18.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:18.511+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6443
04-23 14:34:18.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:18.541+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:18.551+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1106469726563152448685
