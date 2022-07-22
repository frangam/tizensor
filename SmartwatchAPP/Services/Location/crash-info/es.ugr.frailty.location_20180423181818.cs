S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4231
Date: 2018-04-23 18:18:18+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf718c52d, r5   = 0xf7288f98
r6   = 0xfff6b950, r7   = 0xfff6b800
r8   = 0xf7285c18, r9   = 0x00000000
r10  = 0xfff6b8dc, fp   = 0xfff6b950
ip   = 0x00000001, sp   = 0xfff6b7d8
lr   = 0xf718c539, pc   = 0xf71f5228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8036 KB
Buffers:     68648 KB
Cached:     221100 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12144 KB
VmRSS:       12144 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4231 TID = 4231
4231 4235 

Maps Information
f4057000 f4856000 rw-p [stack:4235]
f485d000 f485f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4867000 f486b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4874000 f4876000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f487e000 f4881000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4890000 f4895000 r-xp /usr/lib/libsystem.so.0.0.0
f48a0000 f48a3000 r-xp /lib/libattr.so.1.1.0
f48ab000 f48bb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48c3000 f48cc000 r-xp /usr/lib/libedbus.so.1.7.99
f48d4000 f48d5000 r-xp /usr/lib/libresponse.so.0.2.96
f48de000 f48e3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6185000 f628b000 r-xp /usr/lib/libicuuc.so.57.1
f62a1000 f6429000 r-xp /usr/lib/libicui18n.so.57.1
f6439000 f6446000 r-xp /usr/lib/libail.so.0.1.0
f644f000 f6456000 r-xp /usr/lib/libminizip.so.1.0.0
f645f000 f6608000 r-xp /usr/lib/libcrypto.so.1.0.0
f6628000 f666f000 r-xp /usr/lib/libssl.so.1.0.0
f667b000 f667d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6685000 f668c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6695000 f669c000 r-xp /lib/libcrypt-2.13.so
f66cd000 f66d0000 r-xp /lib/libcap.so.2.21
f66d8000 f66da000 r-xp /usr/lib/libiri.so
f66e2000 f672b000 r-xp /usr/lib/libmdm.so.1.2.69
f6733000 f6739000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6741000 f6764000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f676e000 f6770000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6778000 f6795000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f679e000 f67a2000 r-xp /usr/lib/libsmack.so.1.0.0
f67ab000 f67c4000 r-xp /usr/lib/libnetwork.so.0.0.0
f67cd000 f67d5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67dd000 f67e3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67ec000 f67ee000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67f7000 f6807000 r-xp /lib/libresolv-2.13.so
f680b000 f6823000 r-xp /usr/lib/liblzma.so.5.0.3
f682c000 f682e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6836000 f6850000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6858000 f6887000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6890000 f689f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68a9000 f68b3000 r-xp /usr/lib/libsensord-shared.so
f68bc000 f698f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f699a000 f69b0000 r-xp /lib/libz.so.1.2.5
f69b8000 f69bd000 r-xp /usr/lib/libffi.so.5.0.10
f69c5000 f69c6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69ce000 f69de000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69e6000 f69ff000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a07000 f6a09000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a11000 f6a86000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a90000 f6a96000 r-xp /lib/librt-2.13.so
f6a9f000 f6abd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ac7000 f6ac8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ad0000 f6af3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6afb000 f6b00000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b08000 f6b32000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b3b000 f6b52000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b5a000 f6bc3000 r-xp /lib/libm-2.13.so
f6bcc000 f6c60000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c73000 f6c78000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c80000 f6c87000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c8f000 f6cb9000 r-xp /usr/lib/libsensor.so.1.9.6
f6cc2000 f6d8e000 r-xp /usr/lib/libxml2.so.2.7.8
f6d9b000 f6d9d000 r-xp /usr/lib/libiniparser.so.0
f6da6000 f6dac000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6db5000 f6e85000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e86000 f6eba000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ec3000 f6eff000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f07000 f6f0a000 r-xp /usr/lib/libbundle.so.0.1.22
f6f12000 f6f18000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f20000 f6f61000 r-xp /usr/lib/libeina.so.1.7.99
f6f6a000 f6f81000 r-xp /usr/lib/libecore.so.1.7.99
f6f98000 f6fa1000 r-xp /usr/lib/libvconf.so.0.2.45
f6fa9000 f6fbd000 r-xp /lib/libpthread-2.13.so
f6fc8000 f6fd5000 r-xp /usr/lib/libaul.so.0.1.0
f6fdf000 f6fe1000 r-xp /lib/libdl-2.13.so
f6fea000 f6ff5000 r-xp /lib/libunwind.so.8.0.1
f7022000 f702a000 r-xp /lib/libgcc_s-4.6.so.1
f702b000 f714f000 r-xp /lib/libc-2.13.so
f715d000 f715f000 r-xp /usr/lib/libdlog.so.0.0.0
f7167000 f7173000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f717c000 f7181000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7189000 f7198000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71a0000 f71a4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71ad000 f71b0000 r-xp /usr/lib/libappcore-agent.so.1.1
f71b8000 f71ba000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71c2000 f71c6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71ce000 f71eb000 r-xp /lib/ld-2.13.so
f71f4000 f71f7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71f7000 f71fb000 r-xp /usr/lib/libsys-assert.so
f7255000 f72b7000 rw-p [heap]
fff4d000 fff6e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4231)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71f5228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf718c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e933f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e91c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e9de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ea3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ea3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ed875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ed31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e91c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e9de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ea3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ea3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ed5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ed6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6eddf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48751fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4868171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf693b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6de8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dea7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f7aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f75b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f765a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f76879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71ae183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71ae7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71f54f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf704285c) [/lib/libc.so.6] + 0x1785c
29: (0xf71f4f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
3 18:18:17.701+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.701+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 18:18:17.701+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [true][0m
04-23 18:18:17.711+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:18:17.711+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:715,7.049256,0.880559,7.941778
04-23 18:18:17.711+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:710,57.750000,20.650000,-20.160000
04-23 18:18:17.721+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2775
04-23 18:18:17.721+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.721+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.731+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 18:18:17.731+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 18:18:17.731+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 18:18:17.731+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 18:18:17.731+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 18:18:17.731+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3238]   bundle_add_str() .. [0xffffffea][0m
04-23 18:18:17.731+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 18:18:17.731+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 18:18:17.731+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 18:18:17.731+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 18:18:17.731+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 18:18:17.731+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 18:18:17.731+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 18:18:17.731+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 18:18:17.741+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 18:18:17.741+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 18:18:17.741+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 18:18:17.741+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 18:18:17.741+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 18:18:17.741+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 18:18:17.741+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 18:18:17.751+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 18:18:17.751+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:17.751+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:734,6.343372,0.148355,7.379465
04-23 18:18:17.751+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:17.751+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 18:18:17.751+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 18:18:17.751+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 18:18:17.751+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 18:18:17.751+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:757,6.326623,-1.816152,7.013363
04-23 18:18:17.751+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:734,14.280000,26.110001,-21.490000
04-23 18:18:17.761+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.761+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.761+0200 I/TIZEN_N_SOUND_MANAGER( 3238): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 18:18:17.771+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:766,-20.020000,34.299999,-19.740000
04-23 18:18:17.771+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.771+0200 W/TIZEN_N_SOUND_MANAGER( 3238): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 18:18:17.771+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 18:18:17.781+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:776,-20.020000,38.990002,-29.260000
04-23 18:18:17.781+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:774,5.900701,-1.813759,7.776673
04-23 18:18:17.781+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.781+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.781+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:789,1.190000,41.160000,-27.719999
04-23 18:18:17.781+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:789,6.900900,0.394816,7.915457
04-23 18:18:17.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:18:17.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:18:17.801+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.801+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.811+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:811,-19.250000,37.029999,-21.280001
04-23 18:18:17.811+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:810,5.826523,0.306281,7.958528
04-23 18:18:17.821+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.821+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.831+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:832,-52.849998,36.470001,-16.100000
04-23 18:18:17.831+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:834,6.139983,0.655633,8.580662
04-23 18:18:17.841+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.841+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.851+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:850,-79.870003,28.139999,-18.410000
04-23 18:18:17.851+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:851,4.969893,-2.210968,9.908678
04-23 18:18:17.861+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.871+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.871+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:875,-93.029999,20.650000,-21.840000
04-23 18:18:17.871+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:874,4.704289,-2.890530,9.774680
04-23 18:18:17.881+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.901+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:892,5.127820,-2.775674,8.812766
04-23 18:18:17.901+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.911+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:913,-101.709999,13.230000,-27.719999
04-23 18:18:17.911+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.931+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.941+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:923,5.529813,-2.517249,8.130811
04-23 18:18:17.941+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:929,-93.730003,12.670000,-29.469999
04-23 18:18:17.941+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.951+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:17.951+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:17.951+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.971+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:958,-71.540001,13.230000,-30.100000
04-23 18:18:17.971+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:954,5.560920,-2.266003,8.204988
04-23 18:18:17.971+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.971+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:17.991+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:17:982,6.317052,-2.184647,7.489535
04-23 18:18:17.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:18:17.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:18:17.991+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:17.991+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:17:983,-51.170002,16.590000,-27.230000
04-23 18:18:18.001+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.011+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:4,6.752545,-1.706082,7.020542
04-23 18:18:18.011+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:6,-66.500000,21.420000,-19.389999
04-23 18:18:18.011+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.011+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.031+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:20,-105.769997,28.139999,-6.860000
04-23 18:18:18.031+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:19,6.183054,-0.571885,5.996413
04-23 18:18:18.031+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.031+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.041+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:38,5.458029,-1.593620,6.142376
04-23 18:18:18.041+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.041+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:39,-145.250000,23.590000,13.440001
04-23 18:18:18.041+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.051+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:47,6.290731,-2.220540,6.386444
04-23 18:18:18.051+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:52,-176.610001,39.480000,20.230000
04-23 18:18:18.051+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.051+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.051+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:57,-247.869995,44.660000,24.150000
04-23 18:18:18.051+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:57,5.166104,-3.065206,5.716454
04-23 18:18:18.061+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.061+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.071+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:71,-277.480011,29.680000,40.670002
04-23 18:18:18.071+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:73,4.208975,-4.759324,5.424529
04-23 18:18:18.081+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.081+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.091+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:89,-253.190002,22.190001,54.459999
04-23 18:18:18.091+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:92,4.711468,-5.919843,4.955536
04-23 18:18:18.101+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.101+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.111+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:112,5.247460,-5.247460,3.680161
04-23 18:18:18.111+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:112,-215.040009,21.420000,61.389999
04-23 18:18:18.121+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.131+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.131+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:132,-173.039993,27.930000,67.199997
04-23 18:18:18.141+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:131,5.123034,-7.544570,3.682554
04-23 18:18:18.141+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.141+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.151+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:18.151+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:18.151+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:152,3.479164,-11.344372,4.163511
04-23 18:18:18.151+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:150,-140.699997,21.629999,54.180000
04-23 18:18:18.161+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.161+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.171+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:173,3.378666,-9.552148,3.680161
04-23 18:18:18.171+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:173,-66.849998,13.510000,32.759998
04-23 18:18:18.181+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.181+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
04-23 18:18:18.181+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-23 18:18:18.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:18:18.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:18:18.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:18:18.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:18:18.191+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:192,-20.440001,6.580000,24.710001
04-23 18:18:18.201+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.201+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:206,3.771089,-8.453842,3.160919
04-23 18:18:18.211+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [14193.871750] layer(0x5ac2c0) now usable
04-23 18:18:18.211+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [14193.871785] layer[0x5abe10]zpos[1]
04-23 18:18:18.211+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [14193.871818] layer(0x5ac310) now usable
04-23 18:18:18.211+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [14193.871833] layer[0x5abf30]zpos[2]
04-23 18:18:18.211+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [14193.871866] layer(0x5ac250) now usable
04-23 18:18:18.211+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [14193.871881] layer[0x5abcf0]zpos[0]
04-23 18:18:18.211+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [14193.872004] dpms[0 -> 3]sync[1]
04-23 18:18:18.211+0200 I/TDM     ( 1785): 
04-23 18:18:18.221+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:18:18.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:18:18.221+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:18:18.221+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.231+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 18:18:18.231+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [gesture]
04-23 18:18:18.231+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 18:18:18.241+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 18:18:18.241+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 18:18:18.241+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 18:18:18.241+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 18:18:18.241+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 18:18:18.241+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 18:18:18.241+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 18:18:18.241+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 18:18:18.241+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 18:18:18.241+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:18:18.241+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.241+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 18:18:18.251+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 18:18:18.251+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 18:18:18.251+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:232,-4.760000,2.800000,25.340000
04-23 18:18:18.251+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.251+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 18:18:18.251+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 18:18:18.251+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 18:18:18.261+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 18:18:18.261+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 18:18:18.261+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 18:18:18.261+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 18:18:18.261+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 18:18:18.271+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:249,4.208975,-8.164310,3.053242
04-23 18:18:18.271+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:261,9.660000,8.960000,21.490000
04-23 18:18:18.271+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.271+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.271+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:279,-9.870000,14.770000,13.860000
04-23 18:18:18.281+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.281+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:286,-52.009998,8.820000,15.050000
04-23 18:18:18.281+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:277,4.407579,-7.427321,3.799802
04-23 18:18:18.281+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.281+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.291+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:291,-67.269997,-1.120000,19.600000
04-23 18:18:18.291+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:292,3.833302,-7.386643,4.266403
04-23 18:18:18.291+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.301+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:304,3.589234,-7.743174,4.240082
04-23 18:18:18.301+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.301+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.311+0200 W/LOCATION( 4231): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:18:18.311+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:312,-43.610001,-2.240000,18.340000
04-23 18:18:18.311+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:311,4.359723,-8.453842,4.280759
04-23 18:18:18.311+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.321+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:322,4.575077,-9.410972,4.443472
04-23 18:18:18.321+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.331+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:331,-9.870000,0.980000,12.250000
04-23 18:18:18.331+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.331+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:336,4.101298,-10.853845,4.816752
04-23 18:18:18.341+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.351+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:351,9.590000,1.820000,3.080000
04-23 18:18:18.351+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:18.351+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:18.351+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.351+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:357,4.067799,-11.033305,5.374279
04-23 18:18:18.361+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.371+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [14194.030960] dpms[3 -> 3]done
04-23 18:18:18.371+0200 I/TDM     ( 1785): 
04-23 18:18:18.371+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:371,29.610001,3.220000,-3.850000
04-23 18:18:18.371+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 18:18:18.381+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 18:18:18.381+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 18:18:18.381+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 18:18:18.381+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [gesture]
04-23 18:18:18.381+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 18:18:18.381+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 18:18:18.381+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 18:18:18.391+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 18:18:18.391+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 18:18:18.391+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 18:18:18.391+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 18:18:18.391+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 18:18:18.391+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:18:18.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:18:18.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:18:18.391+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:18:18.391+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 18:18:18.391+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 18:18:18.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 18:18:18.401+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 18:18:18.401+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 18:18:18.401+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 18:18:18.401+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 18:18:18.401+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 18:18:18.401+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.401+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 18:18:18.401+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 18:18:18.411+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.411+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 18:18:18.411+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 18:18:18.411+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 18:18:18.411+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:411,29.330000,0.070000,-2.590000
04-23 18:18:18.421+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:415,4.079762,-8.056634,5.048856
04-23 18:18:18.421+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.421+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.431+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:433,3.814159,-7.238289,3.964907
04-23 18:18:18.431+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:428,12.950000,-3.150000,3.010000
04-23 18:18:18.431+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.431+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:440,-7.000000,-4.620000,8.190000
04-23 18:18:18.431+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.441+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:444,3.823731,-7.077969,3.940979
04-23 18:18:18.441+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.441+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:450,-17.639999,-2.100000,10.850000
04-23 18:18:18.441+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.451+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:454,3.936193,-7.537392,4.089334
04-23 18:18:18.451+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.451+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:459,4.163511,-8.307880,4.134798
04-23 18:18:18.461+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.471+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:471,-13.930000,1.680000,11.480000
04-23 18:18:18.471+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.471+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:476,4.216154,-8.228917,3.818945
04-23 18:18:18.481+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.481+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:489,-1.470000,5.320000,9.380000
04-23 18:18:18.491+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.491+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:495,4.220939,-8.015956,3.751946
04-23 18:18:18.501+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.501+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:509,-1.960000,10.220000,9.450000
04-23 18:18:18.501+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.511+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:513,3.979264,-8.044669,4.242475
04-23 18:18:18.521+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.521+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:530,-6.790000,12.320000,10.850000
04-23 18:18:18.541+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.541+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:546,3.759124,-8.099705,4.433900
04-23 18:18:18.541+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.541+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.551+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:18.551+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:18.551+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:551,3.436093,-5.867201,4.536791
04-23 18:18:18.551+0200 W/AUL     ( 4245): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 18:18:18.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:18:18.551+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:18:18.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 3896
04-23 18:18:18.551+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:18:18.561+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 18:18:18.561+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 18:18:18.561+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:18:18.561+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 18:18:18.561+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 18:18:18.561+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 18:18:18.561+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 18:18:18.571+0200 E/CAPI_LOCATION_MANAGER( 2317): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 18:18:18.571+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 18:18:18.581+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3896
04-23 18:18:18.581+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3896)
04-23 18:18:18.581+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:18:18.601+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.611+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:609,4.127619,-10.018748,4.539185
04-23 18:18:18.611+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.611+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:618,4.847858,-8.633304,4.314260
04-23 18:18:18.611+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.631+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:553,-5.530000,11.340000,8.960000
04-23 18:18:18.631+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.641+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:643,-26.530001,3.010000,16.100000
04-23 18:18:18.641+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.641+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:647,-8.120000,7.910000,4.970000
04-23 18:18:18.641+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.651+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:652,-14.350000,10.850000,-0.070000
04-23 18:18:18.651+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.651+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:655,-20.650000,1.330000,3.080000
04-23 18:18:18.651+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.651+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:659,-8.960000,-0.140000,3.290000
04-23 18:18:18.661+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:623,4.134798,-7.798209,4.321437
04-23 18:18:18.661+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.661+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:665,3.799802,-8.185846,4.347759
04-23 18:18:18.661+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.661+0200 I/gyroscope( 4206): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:18.671+0200 I/gyroscope( 4206): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:18:671,5.810000,2.590000,-1.960000
04-23 18:18:18.671+0200 I/accelerometer( 4193): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:18:669,4.012764,-8.731410,4.445865
04-23 18:18:18.671+0200 I/accelerometer( 4193): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:18.681+0200 W/CRASH_MANAGER( 4246): worker.c: worker_job(1205) > 11042316c6f63152450029
