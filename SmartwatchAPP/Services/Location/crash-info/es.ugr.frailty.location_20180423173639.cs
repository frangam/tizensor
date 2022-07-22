S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 31136
Date: 2018-04-23 17:36:39+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf744652d, r5   = 0xf77fbf98
r6   = 0xff87f3b0, r7   = 0xff87f260
r8   = 0xf77f8c18, r9   = 0x00000000
r10  = 0xff87f33c, fp   = 0xff87f3b0
ip   = 0x00000001, sp   = 0xff87e0e0
lr   = 0xf7446539, pc   = 0xf74af2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     20824 KB
Buffers:     66872 KB
Cached:     214584 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11644 KB
VmRSS:       11644 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 31136 TID = 31136
31136 31139 

Maps Information
f4311000 f4b10000 rw-p [stack:31139]
f4b17000 f4b19000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b21000 f4b25000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b2e000 f4b30000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b38000 f4b3b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b4a000 f4b4f000 r-xp /usr/lib/libsystem.so.0.0.0
f4b5a000 f4b5d000 r-xp /lib/libattr.so.1.1.0
f4b65000 f4b75000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b7d000 f4b86000 r-xp /usr/lib/libedbus.so.1.7.99
f4b8e000 f4b8f000 r-xp /usr/lib/libresponse.so.0.2.96
f4b98000 f4b9d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f643f000 f6545000 r-xp /usr/lib/libicuuc.so.57.1
f655b000 f66e3000 r-xp /usr/lib/libicui18n.so.57.1
f66f3000 f6700000 r-xp /usr/lib/libail.so.0.1.0
f6709000 f6710000 r-xp /usr/lib/libminizip.so.1.0.0
f6719000 f68c2000 r-xp /usr/lib/libcrypto.so.1.0.0
f68e2000 f6929000 r-xp /usr/lib/libssl.so.1.0.0
f6935000 f6937000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f693f000 f6946000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f694f000 f6956000 r-xp /lib/libcrypt-2.13.so
f6987000 f698a000 r-xp /lib/libcap.so.2.21
f6992000 f6994000 r-xp /usr/lib/libiri.so
f699c000 f69e5000 r-xp /usr/lib/libmdm.so.1.2.69
f69ed000 f69f3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69fb000 f6a1e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a28000 f6a2a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a32000 f6a4f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a58000 f6a5c000 r-xp /usr/lib/libsmack.so.1.0.0
f6a65000 f6a7e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a87000 f6a8f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a97000 f6a9d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6aa6000 f6aa8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ab1000 f6ac1000 r-xp /lib/libresolv-2.13.so
f6ac5000 f6add000 r-xp /usr/lib/liblzma.so.5.0.3
f6ae6000 f6ae8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6af0000 f6b0a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b12000 f6b41000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b4a000 f6b59000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b63000 f6b6d000 r-xp /usr/lib/libsensord-shared.so
f6b76000 f6c49000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c54000 f6c6a000 r-xp /lib/libz.so.1.2.5
f6c72000 f6c77000 r-xp /usr/lib/libffi.so.5.0.10
f6c7f000 f6c80000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c88000 f6c98000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ca0000 f6cb9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cc1000 f6cc3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ccb000 f6d40000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d4a000 f6d50000 r-xp /lib/librt-2.13.so
f6d59000 f6d77000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d81000 f6d82000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d8a000 f6dad000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6db5000 f6dba000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dc2000 f6dec000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6df5000 f6e0c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e14000 f6e7d000 r-xp /lib/libm-2.13.so
f6e86000 f6f1a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f2d000 f6f32000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f3a000 f6f41000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f49000 f6f73000 r-xp /usr/lib/libsensor.so.1.9.6
f6f7c000 f7048000 r-xp /usr/lib/libxml2.so.2.7.8
f7055000 f7057000 r-xp /usr/lib/libiniparser.so.0
f7060000 f7066000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f706f000 f713f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7140000 f7174000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f717d000 f71b9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71c1000 f71c4000 r-xp /usr/lib/libbundle.so.0.1.22
f71cc000 f71d2000 r-xp /usr/lib/libappsvc.so.0.1.0
f71da000 f721b000 r-xp /usr/lib/libeina.so.1.7.99
f7224000 f723b000 r-xp /usr/lib/libecore.so.1.7.99
f7252000 f725b000 r-xp /usr/lib/libvconf.so.0.2.45
f7263000 f7277000 r-xp /lib/libpthread-2.13.so
f7282000 f728f000 r-xp /usr/lib/libaul.so.0.1.0
f7299000 f729b000 r-xp /lib/libdl-2.13.so
f72a4000 f72af000 r-xp /lib/libunwind.so.8.0.1
f72dc000 f72e4000 r-xp /lib/libgcc_s-4.6.so.1
f72e5000 f7409000 r-xp /lib/libc-2.13.so
f7417000 f7419000 r-xp /usr/lib/libdlog.so.0.0.0
f7421000 f742d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7436000 f743b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7443000 f7452000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f745a000 f745e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7467000 f746a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7472000 f7474000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f747c000 f7480000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7488000 f74a5000 r-xp /lib/ld-2.13.so
f74ae000 f74b1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74b1000 f74b5000 r-xp /usr/lib/libsys-assert.so
f77c8000 f7839000 rw-p [heap]
ff860000 ff881000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31136)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74af2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7446539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf714d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf714bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7157e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf715dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf715ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf719275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf718d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf714bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7157e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf715dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf715ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf718fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7190017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7197f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b2f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b22171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bf5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70a2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70a47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7234ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf722fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72305a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7230879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7468183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74687fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74af6c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf72fc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf74aefa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
 message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 17:36:01.531+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:36:01.531+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:36:01.531+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:36:01.531+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 17:36:01.531+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [true][0m
04-23 17:36:01.531+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:36:01.541+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2775
04-23 17:36:01.541+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 17:36:01.551+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 17:36:01.551+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 17:36:01.551+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 17:36:01.551+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 17:36:01.551+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3238]   bundle_add_str() .. [0xffffffea][0m
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:36:01.551+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 17:36:01.551+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 17:36:01.551+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 17:36:01.551+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 17:36:01.551+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 17:36:01.551+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 17:36:01.551+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 17:36:01.551+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:36:01.561+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 17:36:01.561+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 17:36:01.561+0200 I/TIZEN_N_SOUND_MANAGER( 3238): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 17:36:01.561+0200 W/TIZEN_N_SOUND_MANAGER( 3238): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:36:01.561+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:36:01.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:36:01.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:36:01.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:36:01.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:36:01.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:36:01.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:36:02.161+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
04-23 17:36:02.161+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-23 17:36:02.161+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:36:02.161+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:36:02.181+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 17:36:02.181+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 17:36:02.181+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 17:36:02.181+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 17:36:02.181+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 17:36:02.181+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 17:36:02.181+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 17:36:02.191+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 17:36:02.191+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 17:36:02.191+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 17:36:02.191+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 17:36:02.191+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 17:36:02.191+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 17:36:02.191+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:36:02.191+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [gesture]
04-23 17:36:02.191+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 17:36:02.191+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 17:36:02.191+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 17:36:02.191+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 17:36:02.191+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 17:36:02.201+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [11657.866793] layer(0x5ac2c0) now usable
04-23 17:36:02.201+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [11657.866826] layer[0x5abe10]zpos[1]
04-23 17:36:02.201+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [11657.866867] layer(0x5ac310) now usable
04-23 17:36:02.201+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [11657.866886] layer[0x5abf30]zpos[2]
04-23 17:36:02.201+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [11657.866920] layer(0x5ac250) now usable
04-23 17:36:02.201+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [11657.866939] layer[0x5abcf0]zpos[0]
04-23 17:36:02.201+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [11657.867113] dpms[0 -> 3]sync[1]
04-23 17:36:02.201+0200 I/TDM     ( 1785): 
04-23 17:36:02.211+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:36:02.211+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:36:02.211+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 17:36:02.211+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 17:36:02.211+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 17:36:02.211+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 17:36:02.221+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 102 ms (from 11657783 to 11657885) (logOverhead=0,0,0,0,0,0,0), start: 17:36:02.128
04-23 17:36:02.221+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 102 ms (from 11657783 to 11657885) (logOverhead=0,0,0,0,0,0,0), start: 17:36:02.128
04-23 17:36:02.221+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:36:02.331+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [11657.991282] dpms[3 -> 3]done
04-23 17:36:02.331+0200 I/TDM     ( 1785): 
04-23 17:36:02.331+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 17:36:02.331+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 17:36:02.341+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 17:36:02.341+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 17:36:02.341+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 17:36:02.351+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [gesture]
04-23 17:36:02.351+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 17:36:02.351+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 17:36:02.351+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 17:36:02.361+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 17:36:02.361+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 17:36:02.361+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 17:36:02.361+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 17:36:02.361+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:36:02.361+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:36:02.361+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 17:36:02.361+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:36:02.361+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:36:02.381+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 17:36:02.381+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 17:36:02.381+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 17:36:02.391+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 17:36:02.391+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 17:36:02.391+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 17:36:02.391+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 17:36:02.391+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 17:36:02.391+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 17:36:02.391+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 17:36:02.871+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 17:36:04.941+0200 E/wnoti-ancs( 3002): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][4][0][15][0][0][0][0][0][0][0][0][0][0]
04-23 17:36:07.381+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 17:36:18.311+0200 E/CAPI_SYSTEM_INFO( 3568): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
04-23 17:36:18.311+0200 E/CAPI_SYSTEM_INFO( 3568): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
04-23 17:36:35.841+0200 I/servicemanager(30105): es.ugr.frailty.location alive timeout
04-23 17:36:35.841+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:36:35.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:36:35.851+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:36:35.871+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 31136
04-23 17:36:35.881+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:36:35.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 31136
04-23 17:36:35.921+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(31136) type(svcapp) bg(0)
04-23 17:36:35.931+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(31136)
04-23 17:36:35.941+0200 I/servicemanager(30105): es.ugr.frailty.location launch request sent!
04-23 17:36:35.941+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [31136]
04-23 17:36:35.941+0200 I/servicemanager(30105): App control destroyed.
04-23 17:36:35.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:36:35.971+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 31136
04-23 17:36:35.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:36:35.981+0200 E/CAPI_APPFW_APPLICATION(31136): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:36:35.981+0200 E/CAPI_APPFW_APPLICATION(31136): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:36:35.981+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (31136) was created
04-23 17:36:35.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:36:36.001+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 31136
04-23 17:36:36.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:36:36.011+0200 W/LOCATION(31136): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:36:36.011+0200 E/LOCATION(31136): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:36:36.011+0200 E/PKGMGR_INFO(31136): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:36:36.021+0200 W/LOCATION(31136): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:36:36.041+0200 I/LOCATION(31136): location.c: location_new(269) > method: 0
04-23 17:36:36.041+0200 W/LOCATION(31136): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:36:36.041+0200 W/LOCATION(31136): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:36:36.051+0200 W/LOCATION(31136): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:36:36.051+0200 W/LOCATION(31136): module-internal.c: module_new(311) > module (gps) open success
04-23 17:36:36.051+0200 W/LOCATION(31136): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:36:36.061+0200 W/LOCATION(31136): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:36:36.061+0200 W/LOCATION(31136): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:36:36.061+0200 W/LOCATION(31136): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:36:36.061+0200 W/LOCATION(31136): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:36:36.081+0200 W/LOCATION(31136): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:36:36.081+0200 W/LOCATION(31136): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:36:36.091+0200 W/LOCATION(31136): module-internal.c: module_new(311) > module (wps) open success
04-23 17:36:36.091+0200 W/LOCATION(31136): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:36:36.091+0200 W/LOCATION(31136): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:36:36.091+0200 W/LOCATION(31136): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:36:36.091+0200 W/LOCATION(31136): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:36:36.111+0200 W/LOCATION(31136): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:36:36.111+0200 I/LOCATION(31136): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77f8c18
04-23 17:36:36.111+0200 I/LOCATION(31136): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:36:36.111+0200 I/LOCATION(31136): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77f8c18
04-23 17:36:36.111+0200 I/LOCATION(31136): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:36:36.121+0200 I/location(31136): es.ugr.frailty.location: creado servicio de localización
04-23 17:36:36.161+0200 I/LOCATION(31136): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:36:36.201+0200 W/LOCATION(31136): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:36:36.201+0200 W/LOCATION(31136): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:36:36.201+0200 I/LOCATION(31136): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:36:36.261+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:36:36.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:36:36.261+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:36:36.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:36:36.261+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:36:36.261+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:36:36.261+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:36:36.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:36:36.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:36:36.261+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:36:36.261+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:36:36.261+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:36:36.261+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:36:36.271+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:36:36.281+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:36:36.281+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:36:36.281+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:36:36.291+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:36:36.291+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:36:36.301+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:36:36.311+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:36:36.311+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:36:36.311+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:36:36.321+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:36:36.321+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:36:36.321+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:36:36.331+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:36:36.331+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:36:36.331+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:36:36.331+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:36:36.331+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:36:36.361+0200 W/LOCATION(31136): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:36:36.361+0200 W/LOCATION(31136): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:36:36.441+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:36:36.481+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_create(453) > New handle created[0xf43267e0]
04-23 17:36:36.481+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:36:36.481+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:36:36.481+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:36:36.481+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:36:36.501+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:36:36.501+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:36:36.511+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:36:36.521+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:36:36.521+0200 E/LOCATION(30823): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:36:36.521+0200 I/LOCATION(30823): location.c: location_new(269) > method: 1
04-23 17:36:36.521+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:36:36.521+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (gps) open success
04-23 17:36:36.521+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:36:36.521+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:36:36.521+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:36:36.521+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:36:36.521+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:36:36.531+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:36:36.541+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:36:36.541+0200 E/LOCATION(30823): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:36:36.551+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:36:36.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:36:36.631+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 11691990 to 11692291) (logOverhead=0,0,0,0,0,0,0), start: 17:36:36.335
04-23 17:36:36.631+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 307 ms (from 11691988 to 11692295) (logOverhead=0,0,0,0,0,0,0), start: 17:36:36.333
04-23 17:36:36.631+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 307 ms (from 11691988 to 11692295) (logOverhead=0,0,0,0,0,0,0), start: 17:36:36.334
04-23 17:36:36.661+0200 W/LOCATION(31136): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:36:36.661+0200 I/LOCATION(31136): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:36:36.661+0200 I/LOCATION(31136): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:36:36.661+0200 I/location(31136): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:36:36.811+0200 I/LOCATION(31136): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:36:36.881+0200 E/location(31136): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:36:36.881+0200 W/AUL     (31136): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:36:36.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:36:36.881+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 31136
04-23 17:36:36.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:36:36.891+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.891+0200 I/utils   (30105): specific action
04-23 17:36:36.891+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.891+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.891+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.891+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:36:36.901+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:36:36.901+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:36:36.901+0200 W/AUL     (31136): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:36:36.901+0200 I/location(31136): request sent to service es.ugr.frailty.servicemanager
04-23 17:36:36.901+0200 W/CAPI_APPFW_APP_CONTROL(31136): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.901+0200 I/utils   (31136): specific action
04-23 17:36:36.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:36:36.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:36:36.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:36:36.911+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.911+0200 I/utils   (30110): specific action
04-23 17:36:36.911+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.911+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.911+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.911+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:36:36.911+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:36:36.911+0200 I/recorder(30110): guardando datos en local
04-23 17:36:36.911+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:36:36.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30110), cmd(0)
04-23 17:36:36.911+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:36:36.911+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:36:36.911+0200 I/servicemanager(30105): requesting to save local data
04-23 17:36:37.001+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:36:37.001+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(11692668), time2(11629351)
04-23 17:36:37.001+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:36:37.001+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:36:37.001+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:36:37.001+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:36:37.401+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 123 ms (from 11692939 to 11693062) (logOverhead=0,0,0,0,0,0,0), start: 17:36:37.284
04-23 17:36:37.401+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 123 ms (from 11692939 to 11693062) (logOverhead=0,0,0,0,0,0,0), start: 17:36:37.284
04-23 17:36:37.431+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:36:37.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:36:37.431+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:36:37.591+0200 E/CAPI_TELEPHONY(30823): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:36:38.301+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:36:38.301+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:36:38.301+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:36:38.951+0200 I/servicemanager(30105): es.ugr.frailty.location sleep timeout
04-23 17:36:38.951+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:36:38.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:36:38.961+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:36:38.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 31136
04-23 17:36:39.021+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(31136)
04-23 17:36:39.021+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:36:39.021+0200 I/servicemanager(30105): es.ugr.frailty.location stop request sent!
04-23 17:36:39.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(31136), cmd(0)
04-23 17:36:39.021+0200 I/servicemanager(30105): App control destroyed.
04-23 17:36:39.021+0200 I/location(31136): stopping es.ugr.frailty.location service
04-23 17:36:39.021+0200 E/CAPI_APPFW_APP_CONTROL(31136): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 17:36:39.021+0200 E/location(31136): request sending failed to service es.ugr.frailty.servicemanager
04-23 17:36:39.021+0200 I/CAPI_APPFW_APPLICATION(31136): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:36:39.021+0200 W/LOCATION(31136): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:36:39.051+0200 I/servicemanager(30105): es.ugr.frailty.location alive timeout
04-23 17:36:39.051+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:36:39.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:36:39.051+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:36:39.061+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 31136
04-23 17:36:39.071+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(31136)
04-23 17:36:39.071+0200 I/servicemanager(30105): es.ugr.frailty.location launch request sent!
04-23 17:36:39.071+0200 I/servicemanager(30105): App control destroyed.
04-23 17:36:39.221+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 17:36:39.221+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:36:39.221+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(31136), cmd(0)
04-23 17:36:39.231+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:36:39.231+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:36:39.231+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:36:39.231+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:36:39.231+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:36:39.231+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:36:39.231+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:36:39.231+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:36:39.231+0200 E/CAPI_LOCATION_MANAGER(30823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:36:39.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:36:39.321+0200 W/AUL     (31151): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:36:39.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:36:39.321+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:36:39.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 31059
04-23 17:36:39.321+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:36:39.321+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:36:39.321+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:36:39.321+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:36:39.321+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_destroy(471) > Destroy handle: 0xf43267e0
04-23 17:36:39.351+0200 W/CRASH_MANAGER(31149): worker.c: worker_job(1205) > 11311366c6f63152449779
