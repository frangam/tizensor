S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7010
Date: 2018-04-23 19:03:24+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72f052d, r5   = 0xf76b6f98
r6   = 0xffd10b40, r7   = 0xffd109f0
r8   = 0xf76b3c18, r9   = 0x00000000
r10  = 0xffd10acc, fp   = 0xffd10b40
ip   = 0x00000001, sp   = 0xffd109c8
lr   = 0xf72f0539, pc   = 0xf7359228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     57292 KB
Buffers:     40972 KB
Cached:     227004 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11876 KB
VmRSS:       11876 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7010 TID = 7010
7010 7052 

Maps Information
f41bb000 f49ba000 rw-p [stack:7052]
f49c1000 f49c3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49cb000 f49cf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49d8000 f49da000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49e2000 f49e5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49f4000 f49f9000 r-xp /usr/lib/libsystem.so.0.0.0
f4a04000 f4a07000 r-xp /lib/libattr.so.1.1.0
f4a0f000 f4a1f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a27000 f4a30000 r-xp /usr/lib/libedbus.so.1.7.99
f4a38000 f4a39000 r-xp /usr/lib/libresponse.so.0.2.96
f4a42000 f4a47000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62e9000 f63ef000 r-xp /usr/lib/libicuuc.so.57.1
f6405000 f658d000 r-xp /usr/lib/libicui18n.so.57.1
f659d000 f65aa000 r-xp /usr/lib/libail.so.0.1.0
f65b3000 f65ba000 r-xp /usr/lib/libminizip.so.1.0.0
f65c3000 f676c000 r-xp /usr/lib/libcrypto.so.1.0.0
f678c000 f67d3000 r-xp /usr/lib/libssl.so.1.0.0
f67df000 f67e1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67e9000 f67f0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67f9000 f6800000 r-xp /lib/libcrypt-2.13.so
f6831000 f6834000 r-xp /lib/libcap.so.2.21
f683c000 f683e000 r-xp /usr/lib/libiri.so
f6846000 f688f000 r-xp /usr/lib/libmdm.so.1.2.69
f6897000 f689d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68a5000 f68c8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68d2000 f68d4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68dc000 f68f9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6902000 f6906000 r-xp /usr/lib/libsmack.so.1.0.0
f690f000 f6928000 r-xp /usr/lib/libnetwork.so.0.0.0
f6931000 f6939000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6941000 f6947000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6950000 f6952000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f695b000 f696b000 r-xp /lib/libresolv-2.13.so
f696f000 f6987000 r-xp /usr/lib/liblzma.so.5.0.3
f6990000 f6992000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f699a000 f69b4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69bc000 f69eb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69f4000 f6a03000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a0d000 f6a17000 r-xp /usr/lib/libsensord-shared.so
f6a20000 f6af3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6afe000 f6b14000 r-xp /lib/libz.so.1.2.5
f6b1c000 f6b21000 r-xp /usr/lib/libffi.so.5.0.10
f6b29000 f6b2a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b32000 f6b42000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b4a000 f6b63000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b6b000 f6b6d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b75000 f6bea000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bf4000 f6bfa000 r-xp /lib/librt-2.13.so
f6c03000 f6c21000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c2b000 f6c2c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c34000 f6c57000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c5f000 f6c64000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c6c000 f6c96000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c9f000 f6cb6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cbe000 f6d27000 r-xp /lib/libm-2.13.so
f6d30000 f6dc4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6dd7000 f6ddc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6de4000 f6deb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6df3000 f6e1d000 r-xp /usr/lib/libsensor.so.1.9.6
f6e26000 f6ef2000 r-xp /usr/lib/libxml2.so.2.7.8
f6eff000 f6f01000 r-xp /usr/lib/libiniparser.so.0
f6f0a000 f6f10000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f19000 f6fe9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fea000 f701e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7027000 f7063000 r-xp /usr/lib/libSLP-location.so.0.9.24
f706b000 f706e000 r-xp /usr/lib/libbundle.so.0.1.22
f7076000 f707c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7084000 f70c5000 r-xp /usr/lib/libeina.so.1.7.99
f70ce000 f70e5000 r-xp /usr/lib/libecore.so.1.7.99
f70fc000 f7105000 r-xp /usr/lib/libvconf.so.0.2.45
f710d000 f7121000 r-xp /lib/libpthread-2.13.so
f712c000 f7139000 r-xp /usr/lib/libaul.so.0.1.0
f7143000 f7145000 r-xp /lib/libdl-2.13.so
f714e000 f7159000 r-xp /lib/libunwind.so.8.0.1
f7186000 f718e000 r-xp /lib/libgcc_s-4.6.so.1
f718f000 f72b3000 r-xp /lib/libc-2.13.so
f72c1000 f72c3000 r-xp /usr/lib/libdlog.so.0.0.0
f72cb000 f72d7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72e0000 f72e5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72ed000 f72fc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7304000 f7308000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7311000 f7314000 r-xp /usr/lib/libappcore-agent.so.1.1
f731c000 f731e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7326000 f732a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7332000 f734f000 r-xp /lib/ld-2.13.so
f7358000 f735b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f735b000 f735f000 r-xp /usr/lib/libsys-assert.so
f7683000 f76f4000 rw-p [heap]
ffcf2000 ffd13000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7010)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7359228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72f0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ff73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ff5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7001e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7007be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7007dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf703c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70371f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ff5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7001e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7007be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7007dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7039e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf703a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7041f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49d91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49cc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a9f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f4cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f4e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70deca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70d9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70da5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70da879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7312183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73127fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73594f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf71a685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7358f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
23.729+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.729+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:716,-19.670000,-13.370000,-0.770000
04-23 19:03:23.739+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.739+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:741,-4.271172,-0.625137,2.718605
04-23 19:03:23.739+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.739+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:737,7.172846,0.103447,6.686551
04-23 19:03:23.739+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.749+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:743,-18.270000,-11.270000,2.590000
04-23 19:03:23.749+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.749+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:749,3.022135,-0.507278,9.509077
04-23 19:03:23.749+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.749+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:750,7.221060,0.054645,6.635036
04-23 19:03:23.749+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.749+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:755,-4.222049,-0.702571,2.753523
04-23 19:03:23.749+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.759+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:753,-23.170000,-11.970000,3.360000
04-23 19:03:23.759+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:761,-4.169224,-0.150964,2.797092
04-23 19:03:23.759+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.759+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.759+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:767,-18.620001,-7.560000,2.590000
04-23 19:03:23.759+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.769+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:759,7.260852,0.008874,6.591686
04-23 19:03:23.769+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.769+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:769,3.141776,-0.485743,9.183653
04-23 19:03:23.769+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:03:23.769+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:03:23.769+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:774,7.289051,-0.027330,6.560440
04-23 19:03:23.769+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.769+0200 E/CAPI_APPFW_APP_CONTROL( 3301): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 19:03:23.769+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3301]   [com.samsung.w-home]register msg port [true][0m
04-23 19:03:23.769+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:03:23.769+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:775,-4.256819,-0.352460,2.996986
04-23 19:03:23.779+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.779+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2773
04-23 19:03:23.779+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3301]   [MUSIC_PLAYER_EVENT][0m
04-23 19:03:23.779+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.779+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:778,7.315806,-0.078327,6.530178
04-23 19:03:23.779+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.779+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 19:03:23.779+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 19:03:23.779+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: preference_get_int(1132) > preference_get_int(3301) : key(music-control-service_native/playing_diration) error
04-23 19:03:23.779+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3301]   preference_get_int() .. [0xfef00030][0m
04-23 19:03:23.789+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:772,-18.129999,-7.000000,-1.260000
04-23 19:03:23.789+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.789+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:23.789+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:03:23.789+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3301]   bundle_add_str() .. [0xffffffea][0m
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:03:23.789+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:03:23.789+0200 W/W_HOME  ( 2773): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 19:03:23.789+0200 E/W_HOME  ( 2773): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 19:03:23.789+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:03:23.789+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:03:23.789+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3301]   [MUSIC_PLAYER_EVENT][0m
04-23 19:03:23.799+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 19:03:23.799+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 19:03:23.799+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: preference_get_int(1132) > preference_get_int(3301) : key(music-control-service_native/playing_diration) error
04-23 19:03:23.799+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:794,-11.340000,-5.110000,-3.640000
04-23 19:03:23.799+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3301]   preference_get_int() .. [0xfef00030][0m
04-23 19:03:23.799+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:03:23.799+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:789,3.160919,-0.327817,9.202796
04-23 19:03:23.799+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:791,7.322388,-0.126327,6.522044
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:03:23.799+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:03:23.799+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:03:23.799+0200 W/W_HOME  ( 2773): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 19:03:23.799+0200 E/W_HOME  ( 2773): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 19:03:23.799+0200 I/TIZEN_N_SOUND_MANAGER( 3301): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 19:03:23.799+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:809,7.317574,-0.134422,6.527283
04-23 19:03:23.809+0200 W/TIZEN_N_SOUND_MANAGER( 3301): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 19:03:23.809+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:805,1.190000,1.400000,-4.900000
04-23 19:03:23.809+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:03:23.809+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:03:23.809+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:03:23.809+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.819+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:812,7.313926,-0.132711,6.531406
04-23 19:03:23.819+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.819+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:816,7.350000,1.470000,-5.390000
04-23 19:03:23.819+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.819+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:783,-4.319520,-0.409550,2.839223
04-23 19:03:23.819+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:820,3.275774,-0.586242,9.207582
04-23 19:03:23.829+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.829+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:824,7.313363,-0.138169,6.531923
04-23 19:03:23.829+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.829+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.829+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:826,3.570000,2.940000,-7.280000
04-23 19:03:23.829+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.839+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:837,7.301453,-0.170202,6.544478
04-23 19:03:23.839+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.839+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:839,-5.810000,2.940000,-4.970000
04-23 19:03:23.839+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.839+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:832,-4.116598,-0.254602,2.638499
04-23 19:03:23.839+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:849,-8.190000,-2.100000,-2.100000
04-23 19:03:23.849+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.849+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:838,3.203990,-0.722632,9.267403
04-23 19:03:23.849+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.849+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:846,7.288207,-0.198466,6.558433
04-23 19:03:23.849+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.849+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.849+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:853,-4.217890,-0.398992,2.515436
04-23 19:03:23.859+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:855,3.208775,-0.882952,9.334401
04-23 19:03:23.859+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.859+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:856,7.282255,-0.213624,6.564565
04-23 19:03:23.859+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:859,-2.520000,-3.010000,-0.070000
04-23 19:03:23.859+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.869+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.869+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.869+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:871,-0.070000,-4.270000,2.240000
04-23 19:03:23.869+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.869+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:874,7.250032,-0.241007,6.599192
04-23 19:03:23.869+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.879+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:867,-3.990715,-0.205911,2.473711
04-23 19:03:23.879+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.879+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:875,3.180061,-1.004985,9.317651
04-23 19:03:23.879+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:880,2.730000,-8.260000,2.520000
04-23 19:03:23.879+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.879+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.879+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:882,7.172992,-0.278086,6.681410
04-23 19:03:23.889+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.889+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:886,-4.038249,-0.373836,2.473174
04-23 19:03:23.889+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:893,7.037078,-0.320238,6.822563
04-23 19:03:23.889+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:887,3.500000,-8.470000,3.360000
04-23 19:03:23.899+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:890,3.172883,-0.748954,9.140583
04-23 19:03:23.899+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.899+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.899+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:906,-3.952464,-0.427925,2.539046
04-23 19:03:23.909+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.909+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.909+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:915,6.867191,-0.356287,6.991790
04-23 19:03:23.909+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.909+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:910,1.260000,-10.780000,7.420000
04-23 19:03:23.909+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.919+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.919+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:917,3.316452,-0.315853,9.169296
04-23 19:03:23.929+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:919,6.757555,-0.366688,7.097279
04-23 19:03:23.929+0200 W/LOCATION( 7010): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:03:23.929+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.929+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:937,6.729653,-0.350948,7.124535
04-23 19:03:23.929+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.939+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:922,-2.660000,-11.550000,8.400000
04-23 19:03:23.939+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.939+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.939+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:944,-5.950000,-10.570000,9.380000
04-23 19:03:23.939+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.939+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:914,-3.884580,-0.324727,2.548897
04-23 19:03:23.939+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:949,-6.230000,-10.360000,8.680000
04-23 19:03:23.949+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:940,6.641526,-0.334146,7.207556
04-23 19:03:23.949+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.949+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:944,3.388237,-0.203390,8.997013
04-23 19:03:23.949+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.949+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:954,6.354438,-0.330097,7.462073
04-23 19:03:23.949+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.949+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.949+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:958,-3.430000,-6.580000,6.370000
04-23 19:03:23.949+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.959+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.969+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:963,-3.710000,-2.590000,5.180000
04-23 19:03:23.969+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.969+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:957,-3.888850,-0.456020,2.474858
04-23 19:03:23.969+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.969+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:968,5.944820,-0.333566,7.792190
04-23 19:03:23.969+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:974,-10.500000,-1.960000,3.570000
04-23 19:03:23.969+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.979+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:982,-3.150000,0.560000,1.120000
04-23 19:03:23.979+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:960,3.402594,-0.346959,8.863015
04-23 19:03:23.979+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.979+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.979+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:23.979+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:978,-3.934748,-0.601235,2.775509
04-23 19:03:23.979+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:23:989,2.252983,-0.145142,9.543238
04-23 19:03:23.989+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:23.989+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:03:23.989+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:986,8.330000,3.430000,-0.140000
04-23 19:03:23.989+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.989+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:23.989+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:23:987,3.278167,-0.605384,9.049655
04-23 19:03:23.989+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:03:23.989+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:03:23.989+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:23:995,9.450000,1.260000,-1.330000
04-23 19:03:23.999+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.999+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:3,3.150000,-0.770000,-0.770000
04-23 19:03:23.999+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.999+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:23.999+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:7,-2.870000,-3.850000,-0.420000
04-23 19:03:23.999+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:23.999+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:23:996,-4.001151,-0.223025,3.001390
04-23 19:03:24.009+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.009+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.009+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:8,3.230310,-0.612563,9.236296
04-23 19:03:24.009+0200 I/servicemanager( 6846): es.ugr.frailty.location sleep timeout
04-23 19:03:24.009+0200 W/AUL     ( 6846): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:03:24.009+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:03:24.009+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:15,2.278538,-0.145690,9.537160
04-23 19:03:24.009+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6846
04-23 19:03:24.009+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:11,-2.520000,-3.710000,0.070000
04-23 19:03:24.009+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.019+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:21,-1.540000,-5.320000,0.070000
04-23 19:03:24.019+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7010
04-23 19:03:24.019+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.019+0200 W/AUL     ( 6846): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7010)
04-23 19:03:24.019+0200 I/servicemanager( 6846): es.ugr.frailty.location stop request sent!
04-23 19:03:24.019+0200 I/servicemanager( 6846): App control destroyed.
04-23 19:03:24.019+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.029+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.029+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:14,-4.144691,-0.107253,3.099042
04-23 19:03:24.029+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:31,2.224258,-0.127887,9.550220
04-23 19:03:24.029+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.029+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:29,-2.520000,-2.940000,-2.170000
04-23 19:03:24.039+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:41,-4.141043,-0.097000,3.023135
04-23 19:03:24.039+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:34,3.134598,-0.253639,9.013763
04-23 19:03:24.039+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.039+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.039+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.039+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:48,2.149395,-0.107545,9.567597
04-23 19:03:24.049+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.049+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:47,-9.310000,-4.060000,-3.920000
04-23 19:03:24.049+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.049+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:46,3.182454,-0.088534,9.346365
04-23 19:03:24.049+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.049+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:58,3.194418,0.026321,9.377472
04-23 19:03:24.059+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:53,-4.291228,-0.369110,2.977154
04-23 19:03:24.059+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.059+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.059+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.059+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:68,2.149207,-0.108791,9.567625
04-23 19:03:24.069+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:70,3.034099,-0.248854,9.544970
04-23 19:03:24.069+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:65,-4.159677,-0.315541,2.639175
04-23 19:03:24.069+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.069+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:78,-4.127288,-0.129351,2.644363
04-23 19:03:24.069+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:57,-12.810000,-5.110000,-5.950000
04-23 19:03:24.069+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.079+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.079+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:82,-8.540000,-4.340000,-10.220000
04-23 19:03:24.079+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.079+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:83,-4.006480,-0.372617,2.643017
04-23 19:03:24.079+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.079+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.079+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.079+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:89,2.155035,-0.115559,9.566236
04-23 19:03:24.089+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:90,3.053242,-0.495314,9.595219
04-23 19:03:24.089+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:88,-4.046043,-0.481625,2.668211
04-23 19:03:24.089+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.089+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:86,-1.050000,-1.190000,-13.930000
04-23 19:03:24.099+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.099+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:102,-3.964217,-0.604866,2.652991
04-23 19:03:24.099+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:103,-1.050000,-1.190000,-16.030001
04-23 19:03:24.099+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.099+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.099+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:107,-10.220000,0.700000,-16.799999
04-23 19:03:24.099+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.099+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:107,-3.857017,-0.684747,2.495088
04-23 19:03:24.099+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.109+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.109+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.109+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:114,2.056677,-0.097853,9.588059
04-23 19:03:24.109+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:115,3.227918,-0.244068,9.341579
04-23 19:03:24.109+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:112,-3.694309,-0.392667,2.148793
04-23 19:03:24.109+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.119+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:123,-3.441103,0.050836,2.072017
04-23 19:03:24.119+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.119+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.119+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.129+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:129,3.141776,-0.318245,9.413363
04-23 19:03:24.129+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:127,-3.341416,0.147558,1.872478
04-23 19:03:24.129+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.129+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:138,-3.238932,-0.012813,1.655459
04-23 19:03:24.129+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.139+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.149+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:149,3.266203,-0.303888,9.470792
04-23 19:03:24.149+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:128,5.718418,-0.251560,7.962838
04-23 19:03:24.149+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.149+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:142,-3.076272,-0.275287,1.587582
04-23 19:03:24.149+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.149+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:158,5.813487,-0.250811,7.893723
04-23 19:03:24.159+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:159,-2.714510,-0.278997,1.444106
04-23 19:03:24.159+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:110,-22.330000,2.030000,-17.080000
04-23 19:03:24.159+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.159+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.159+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.169+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:169,3.275774,-0.339781,9.454042
04-23 19:03:24.169+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.169+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:169,-18.200001,3.780000,-17.710001
04-23 19:03:24.169+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.169+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:176,0.881615,-0.108498,-0.529474
04-23 19:03:24.169+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.169+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:171,5.660117,-0.259407,8.004134
04-23 19:03:24.179+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:181,0.903916,0.057156,-0.190795
04-23 19:03:24.179+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.179+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.179+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.189+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:178,-9.100000,8.190000,-17.080000
04-23 19:03:24.189+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:24.189+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:03:24.189+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.189+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:190,3.213561,-0.428315,9.415757
04-23 19:03:24.189+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:189,2.069911,-0.111208,9.585066
04-23 19:03:24.189+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:03:24.189+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:03:24.189+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:186,0.970160,0.154208,-0.172749
04-23 19:03:24.199+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.199+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:194,-0.630000,10.430000,-14.840000
04-23 19:03:24.199+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.199+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:205,4.690000,10.850000,-11.480000
04-23 19:03:24.199+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:204,0.884704,-0.141309,-0.022628
04-23 19:03:24.209+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.209+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.209+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:215,2.158979,-0.133676,9.565110
04-23 19:03:24.209+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:216,3.201597,-0.409173,9.348758
04-23 19:03:24.209+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.209+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.219+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.219+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.219+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:227,2.183912,-0.144315,9.559293
04-23 19:03:24.229+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:229,3.036492,-0.406780,9.322437
04-23 19:03:24.229+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:222,0.904034,-0.386523,0.027594
04-23 19:03:24.239+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:221,4.480000,11.200000,-7.000000
04-23 19:03:24.239+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.239+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.239+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.239+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.239+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:249,2.194280,-0.152100,9.556798
04-23 19:03:24.249+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:245,1.540000,9.310000,-3.640000
04-23 19:03:24.249+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:250,3.048456,-0.437887,9.394222
04-23 19:03:24.249+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:244,1.072883,-0.128509,-0.224656
04-23 19:03:24.249+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.249+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.259+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.259+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.259+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:268,2.180688,-0.151439,9.559918
04-23 19:03:24.269+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:269,3.120241,-0.330210,9.327222
04-23 19:03:24.269+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:261,4.830000,6.370000,-1.820000
04-23 19:03:24.269+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:260,1.085099,-0.220392,-0.174696
04-23 19:03:24.269+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.269+0200 I/gyroscope( 6997): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:24.279+0200 I/gyroscope( 6997): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:24:281,10.990000,7.910000,-0.070000
04-23 19:03:24.279+0200 I/gravity ( 7039): capturing data from es.ugr.frailty.gravity
04-23 19:03:24.279+0200 I/accelerometer( 6984): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:24.279+0200 I/gravity ( 7039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:24:289,2.164799,-0.146199,9.563611
04-23 19:03:24.289+0200 I/accelerometer( 6984): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:24:290,3.156133,-0.129212,9.415757
04-23 19:03:24.289+0200 I/linearacceleration( 7025): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:24:280,-2.452215,-0.052328,1.507954
04-23 19:03:24.289+0200 I/linearacceleration( 7025): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:24.299+0200 W/CRASH_MANAGER( 5847): worker.c: worker_job(1205) > 11070106c6f63152450300
