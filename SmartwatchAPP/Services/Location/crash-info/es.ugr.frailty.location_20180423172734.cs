S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 30556
Date: 2018-04-23 17:27:34+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fc452d, r5   = 0xf7834958
r6   = 0xff9e7700, r7   = 0xff9e75b0
r8   = 0xf7847c18, r9   = 0x00000000
r10  = 0xff9e768c, fp   = 0xff9e7700
ip   = 0x00000001, sp   = 0xff9e6430
lr   = 0xf6fc4539, pc   = 0xf702d2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     16124 KB
Buffers:     66352 KB
Cached:     220724 KB
VmPeak:      53440 KB
VmSize:      53376 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11812 KB
VmRSS:       11812 KB
VmData:      11104 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 30556 TID = 30556
30556 30559 

Maps Information
f3e8f000 f468e000 rw-p [stack:30559]
f4695000 f4697000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f469f000 f46a3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46ac000 f46ae000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46b6000 f46b9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46c8000 f46cd000 r-xp /usr/lib/libsystem.so.0.0.0
f46d8000 f46db000 r-xp /lib/libattr.so.1.1.0
f46e3000 f46f3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46fb000 f4704000 r-xp /usr/lib/libedbus.so.1.7.99
f470c000 f470d000 r-xp /usr/lib/libresponse.so.0.2.96
f4716000 f471b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fbd000 f60c3000 r-xp /usr/lib/libicuuc.so.57.1
f60d9000 f6261000 r-xp /usr/lib/libicui18n.so.57.1
f6271000 f627e000 r-xp /usr/lib/libail.so.0.1.0
f6287000 f628e000 r-xp /usr/lib/libminizip.so.1.0.0
f6297000 f6440000 r-xp /usr/lib/libcrypto.so.1.0.0
f6460000 f64a7000 r-xp /usr/lib/libssl.so.1.0.0
f64b3000 f64b5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64bd000 f64c4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64cd000 f64d4000 r-xp /lib/libcrypt-2.13.so
f6505000 f6508000 r-xp /lib/libcap.so.2.21
f6510000 f6512000 r-xp /usr/lib/libiri.so
f651a000 f6563000 r-xp /usr/lib/libmdm.so.1.2.69
f656b000 f6571000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6579000 f659c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65a6000 f65a8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65b0000 f65cd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65d6000 f65da000 r-xp /usr/lib/libsmack.so.1.0.0
f65e3000 f65fc000 r-xp /usr/lib/libnetwork.so.0.0.0
f6605000 f660d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6615000 f661b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6624000 f6626000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f662f000 f663f000 r-xp /lib/libresolv-2.13.so
f6643000 f665b000 r-xp /usr/lib/liblzma.so.5.0.3
f6664000 f6666000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f666e000 f6688000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6690000 f66bf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66c8000 f66d7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66e1000 f66eb000 r-xp /usr/lib/libsensord-shared.so
f66f4000 f67c7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67d2000 f67e8000 r-xp /lib/libz.so.1.2.5
f67f0000 f67f5000 r-xp /usr/lib/libffi.so.5.0.10
f67fd000 f67fe000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6806000 f6816000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f681e000 f6837000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f683f000 f6841000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6849000 f68be000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68c8000 f68ce000 r-xp /lib/librt-2.13.so
f68d7000 f68f5000 r-xp /usr/lib/libsystemd.so.0.4.0
f68ff000 f6900000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6908000 f692b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6933000 f6938000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6940000 f696a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6973000 f698a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6992000 f69fb000 r-xp /lib/libm-2.13.so
f6a04000 f6a98000 r-xp /usr/lib/libstdc++.so.6.0.16
f6aab000 f6ab0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ab8000 f6abf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ac7000 f6af1000 r-xp /usr/lib/libsensor.so.1.9.6
f6afa000 f6bc6000 r-xp /usr/lib/libxml2.so.2.7.8
f6bd3000 f6bd5000 r-xp /usr/lib/libiniparser.so.0
f6bde000 f6be4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bed000 f6cbd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cbe000 f6cf2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cfb000 f6d37000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d3f000 f6d42000 r-xp /usr/lib/libbundle.so.0.1.22
f6d4a000 f6d50000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d58000 f6d99000 r-xp /usr/lib/libeina.so.1.7.99
f6da2000 f6db9000 r-xp /usr/lib/libecore.so.1.7.99
f6dd0000 f6dd9000 r-xp /usr/lib/libvconf.so.0.2.45
f6de1000 f6df5000 r-xp /lib/libpthread-2.13.so
f6e00000 f6e0d000 r-xp /usr/lib/libaul.so.0.1.0
f6e17000 f6e19000 r-xp /lib/libdl-2.13.so
f6e22000 f6e2d000 r-xp /lib/libunwind.so.8.0.1
f6e5a000 f6e62000 r-xp /lib/libgcc_s-4.6.so.1
f6e63000 f6f87000 r-xp /lib/libc-2.13.so
f6f95000 f6f97000 r-xp /usr/lib/libdlog.so.0.0.0
f6f9f000 f6fab000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fb4000 f6fb9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fc1000 f6fd0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fd8000 f6fdc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fe5000 f6fe8000 r-xp /usr/lib/libappcore-agent.so.1.1
f6ff0000 f6ff2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6ffa000 f6ffe000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7006000 f7023000 r-xp /lib/ld-2.13.so
f702c000 f702f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f702f000 f7033000 r-xp /usr/lib/libsys-assert.so
f7817000 f7874000 rw-p [heap]
ff9c8000 ff9e9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30556)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf702d2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf6fc4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ccb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cc9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cd5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cdbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cdbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d1075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d0b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cc9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cd5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cdbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cdbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d0de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d0e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d15f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46ad1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46a0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6773663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c20fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c227a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6db2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dadb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dae5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dae879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fe6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fe67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf702d6c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf6e7a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf702cfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
.041+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 17:26:41.041+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 17:26:41.041+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3238]   bundle_add_str() .. [0xffffffea][0m
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:26:41.041+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 17:26:41.041+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 17:26:41.041+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 17:26:41.041+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 17:26:41.041+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 17:26:41.041+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 17:26:41.041+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:26:41.041+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:26:41.041+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 17:26:41.041+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 17:26:41.051+0200 I/TIZEN_N_SOUND_MANAGER( 3238): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 17:26:41.051+0200 W/TIZEN_N_SOUND_MANAGER( 3238): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:26:41.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:26:41.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:41.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:41.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:41.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:41.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:41.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:41.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:41.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:41.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:41.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:42.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:42.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:42.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:42.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:42.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:42.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:42.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:42.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:42.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:42.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:43.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:43.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:43.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:43.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:43.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:43.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:43.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:43.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:43.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:43.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:44.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:44.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:44.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:44.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:44.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:44.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:44.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:44.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:44.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:44.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:45.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:45.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:45.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:45.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:45.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:45.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:45.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:45.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:45.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:45.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:46.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:46.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:46.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:46.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:46.471+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 17:26:46.471+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 17:26:46.471+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 17:26:46.471+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 17:26:46.471+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 17:26:46.471+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 17:26:46.471+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:26:46.481+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 17:26:46.481+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 17:26:46.481+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 17:26:46.481+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 17:26:46.481+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 17:26:46.481+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 17:26:46.491+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 17:26:46.491+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [11102.156595] layer(0x5ac2c0) now usable
04-23 17:26:46.491+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [11102.156647] layer[0x5abe10]zpos[1]
04-23 17:26:46.491+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [11102.156691] layer(0x5ac310) now usable
04-23 17:26:46.491+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [11102.156710] layer[0x5abf30]zpos[2]
04-23 17:26:46.491+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [11102.156753] layer(0x5ac250) now usable
04-23 17:26:46.491+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [11102.156772] layer[0x5abcf0]zpos[0]
04-23 17:26:46.491+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [11102.156924] dpms[0 -> 3]sync[1]
04-23 17:26:46.491+0200 I/TDM     ( 1785): 
04-23 17:26:46.491+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 17:26:46.491+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 17:26:46.491+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 17:26:46.491+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 17:26:46.491+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 17:26:46.501+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 17:26:46.501+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 17:26:46.511+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 17:26:46.511+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 17:26:46.511+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 17:26:46.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:26:46.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:26:46.641+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [11102.301267] dpms[3 -> 3]done
04-23 17:26:46.641+0200 I/TDM     ( 1785): 
04-23 17:26:46.641+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 17:26:46.641+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 17:26:46.651+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 17:26:46.651+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 17:26:46.651+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 17:26:46.671+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 17:26:46.671+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 17:26:46.671+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 17:26:46.671+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 17:26:46.671+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 17:26:46.671+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 17:26:46.671+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 17:26:46.671+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 17:26:46.671+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 17:26:46.671+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:26:46.681+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:26:46.681+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 17:26:46.681+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:26:46.681+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:26:46.681+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 17:26:46.691+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 17:26:46.691+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 17:26:46.691+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 17:26:46.681+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 17:26:46.691+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 17:26:46.701+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 17:26:46.701+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 17:26:46.701+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 17:26:47.181+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 17:26:51.701+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 17:26:54.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 102 ms (from 11109988 to 11110090) (logOverhead=0,0,0,0,0,0,0), start: 17:26:54.333
04-23 17:26:54.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 102 ms (from 11109988 to 11110090) (logOverhead=0,0,0,0,0,0,0), start: 17:26:54.333
04-23 17:26:54.431+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:26:54.431+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:26:54.451+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 17:26:54.451+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [16]( A5 93 02 80 0A 00 AB 4A 01 00 01 76 F9 01 A5 68)
04-23 17:26:54.451+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:27:32.021+0200 I/servicemanager(30105): es.ugr.frailty.location alive timeout
04-23 17:27:32.021+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:27:32.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:27:32.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:27:32.041+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 30556
04-23 17:27:32.051+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:27:32.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 30556
04-23 17:27:32.101+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(30556) type(svcapp) bg(0)
04-23 17:27:32.101+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30556]
04-23 17:27:32.111+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30556)
04-23 17:27:32.111+0200 I/servicemanager(30105): es.ugr.frailty.location launch request sent!
04-23 17:27:32.111+0200 I/servicemanager(30105): App control destroyed.
04-23 17:27:32.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:27:32.141+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30556
04-23 17:27:32.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:27:32.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:27:32.161+0200 E/CAPI_APPFW_APPLICATION(30556): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:27:32.161+0200 E/CAPI_APPFW_APPLICATION(30556): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:27:32.171+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30556
04-23 17:27:32.171+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (30556) was created
04-23 17:27:32.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:27:32.191+0200 W/LOCATION(30556): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:27:32.191+0200 E/LOCATION(30556): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:27:32.191+0200 E/PKGMGR_INFO(30556): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:27:32.201+0200 W/LOCATION(30556): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:27:32.221+0200 I/LOCATION(30556): location.c: location_new(269) > method: 0
04-23 17:27:32.221+0200 W/LOCATION(30556): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:27:32.221+0200 W/LOCATION(30556): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:27:32.231+0200 W/LOCATION(30556): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:27:32.231+0200 W/LOCATION(30556): module-internal.c: module_new(311) > module (gps) open success
04-23 17:27:32.231+0200 W/LOCATION(30556): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:27:32.241+0200 W/LOCATION(30556): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:27:32.241+0200 W/LOCATION(30556): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:27:32.241+0200 W/LOCATION(30556): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:27:32.241+0200 W/LOCATION(30556): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:27:32.261+0200 W/LOCATION(30556): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:27:32.261+0200 W/LOCATION(30556): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:27:32.271+0200 W/LOCATION(30556): module-internal.c: module_new(311) > module (wps) open success
04-23 17:27:32.271+0200 W/LOCATION(30556): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:27:32.281+0200 W/LOCATION(30556): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:27:32.281+0200 W/LOCATION(30556): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:27:32.281+0200 W/LOCATION(30556): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:27:32.291+0200 W/LOCATION(30556): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:27:32.291+0200 I/LOCATION(30556): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7847c18
04-23 17:27:32.291+0200 I/LOCATION(30556): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:27:32.291+0200 I/LOCATION(30556): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7847c18
04-23 17:27:32.291+0200 I/LOCATION(30556): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:27:32.301+0200 I/location(30556): es.ugr.frailty.location: creado servicio de localización
04-23 17:27:32.341+0200 I/LOCATION(30556): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:27:32.381+0200 W/LOCATION(30556): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:27:32.381+0200 W/LOCATION(30556): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:27:32.381+0200 I/LOCATION(30556): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:27:32.441+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:27:32.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:27:32.441+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:27:32.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:27:32.441+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:27:32.441+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:27:32.441+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:27:32.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:27:32.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:27:32.441+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:27:32.441+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:27:32.441+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:27:32.441+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:27:32.451+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:27:32.461+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:27:32.461+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:27:32.461+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:27:32.461+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:27:32.461+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:27:32.471+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:27:32.471+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:27:32.471+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:27:32.471+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:27:32.481+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:27:32.491+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:27:32.491+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:27:32.491+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:27:32.491+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:27:32.491+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:27:32.491+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:27:32.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:27:32.531+0200 W/LOCATION(30556): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:27:32.531+0200 W/LOCATION(30556): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:27:32.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:27:32.671+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_create(453) > New handle created[0xf749d0b8]
04-23 17:27:32.671+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:27:32.671+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:27:32.671+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:27:32.671+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:27:32.681+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:27:32.681+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:27:32.691+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:27:32.701+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:27:32.701+0200 E/LOCATION(30159): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:27:32.701+0200 I/LOCATION(30159): location.c: location_new(269) > method: 1
04-23 17:27:32.701+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:27:32.701+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (gps) open success
04-23 17:27:32.701+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:27:32.701+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:27:32.701+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:27:32.701+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:27:32.701+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:27:32.711+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:27:32.721+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:27:32.721+0200 E/LOCATION(30159): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:27:32.731+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:27:32.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:27:32.791+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 300 ms (from 11148157 to 11148457) (logOverhead=0,0,0,0,0,0,0), start: 17:27:32.502
04-23 17:27:32.801+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 304 ms (from 11148155 to 11148459) (logOverhead=0,0,0,0,0,0,0), start: 17:27:32.501
04-23 17:27:32.801+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 305 ms (from 11148155 to 11148460) (logOverhead=0,0,0,0,0,0,0), start: 17:27:32.500
04-23 17:27:32.811+0200 W/LOCATION(30556): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:27:32.811+0200 I/LOCATION(30556): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:27:32.811+0200 I/LOCATION(30556): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:27:32.811+0200 I/location(30556): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:27:32.941+0200 I/LOCATION(30556): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:27:33.011+0200 E/location(30556): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:27:33.011+0200 W/AUL     (30556): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:27:33.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:27:33.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30556
04-23 17:27:33.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:27:33.021+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.021+0200 I/utils   (30105): specific action
04-23 17:27:33.031+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.031+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.031+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.031+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:27:33.031+0200 W/AUL     (30556): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:27:33.031+0200 I/location(30556): request sent to service es.ugr.frailty.servicemanager
04-23 17:27:33.031+0200 W/CAPI_APPFW_APP_CONTROL(30556): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.031+0200 I/utils   (30556): specific action
04-23 17:27:33.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:27:33.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:27:33.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:27:33.041+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.041+0200 I/utils   (30110): specific action
04-23 17:27:33.041+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.041+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.041+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.041+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:27:33.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:27:33.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:27:33.041+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:27:33.041+0200 I/recorder(30110): guardando datos en local
04-23 17:27:33.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:27:33.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(30110), cmd(0)
04-23 17:27:33.041+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:27:33.041+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:27:33.041+0200 I/servicemanager(30105): requesting to save local data
04-23 17:27:33.161+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:27:33.161+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(11148820), time2(11085575)
04-23 17:27:33.161+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:27:33.161+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:27:33.161+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:27:33.161+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:27:33.581+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 145 ms (from 11149102 to 11149247) (logOverhead=0,0,0,0,0,0,0), start: 17:27:33.447
04-23 17:27:33.581+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 146 ms (from 11149101 to 11149247) (logOverhead=0,0,0,0,0,0,0), start: 17:27:33.446
04-23 17:27:33.641+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:27:33.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:27:33.641+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:27:33.781+0200 E/CAPI_TELEPHONY(30159): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:27:34.451+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:27:34.451+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:27:34.451+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:27:34.561+0200 W/LOCATION(30556): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:27:34.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:27:34.801+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:27:34.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:27:34.801+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:27:34.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:27:34.801+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:27:34.801+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:27:34.801+0200 E/CAPI_LOCATION_MANAGER(30159): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:27:34.801+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:27:34.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:27:34.821+0200 W/AUL     (30569): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:27:34.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:27:34.821+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:27:34.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30450
04-23 17:27:34.821+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:27:34.821+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30450
04-23 17:27:34.821+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30450)
04-23 17:27:34.871+0200 W/CRASH_MANAGER(30568): worker.c: worker_job(1205) > 11305566c6f63152449725
