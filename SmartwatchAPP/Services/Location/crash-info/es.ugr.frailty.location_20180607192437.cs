S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 30160
Date: 2018-06-07 19:24:37+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70c852d, r5   = 0xf75d3150
r6   = 0xff847240, r7   = 0xff8470f0
r8   = 0xf75e5c18, r9   = 0x00000000
r10  = 0xff8471cc, fp   = 0xff847240
ip   = 0x00000001, sp   = 0xff8470c8
lr   = 0xf70c8539, pc   = 0xf7131228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    237640 KB
Buffers:     13592 KB
Cached:     106740 KB
VmPeak:      53448 KB
VmSize:      53444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11680 KB
VmRSS:       11680 KB
VmData:      11172 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 30160 TID = 30160
30160 30240 

Maps Information
f3f93000 f4792000 rw-p [stack:30240]
f4799000 f479b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47a3000 f47a7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47b0000 f47b2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47ba000 f47bd000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47cc000 f47d1000 r-xp /usr/lib/libsystem.so.0.0.0
f47dc000 f47df000 r-xp /lib/libattr.so.1.1.0
f47e7000 f47f7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47ff000 f4808000 r-xp /usr/lib/libedbus.so.1.7.99
f4810000 f4811000 r-xp /usr/lib/libresponse.so.0.2.96
f481a000 f481f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60c1000 f61c7000 r-xp /usr/lib/libicuuc.so.57.1
f61dd000 f6365000 r-xp /usr/lib/libicui18n.so.57.1
f6375000 f6382000 r-xp /usr/lib/libail.so.0.1.0
f638b000 f6392000 r-xp /usr/lib/libminizip.so.1.0.0
f639b000 f6544000 r-xp /usr/lib/libcrypto.so.1.0.0
f6564000 f65ab000 r-xp /usr/lib/libssl.so.1.0.0
f65b7000 f65b9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65c1000 f65c8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65d1000 f65d8000 r-xp /lib/libcrypt-2.13.so
f6609000 f660c000 r-xp /lib/libcap.so.2.21
f6614000 f6616000 r-xp /usr/lib/libiri.so
f661e000 f6667000 r-xp /usr/lib/libmdm.so.1.2.69
f666f000 f6675000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f667d000 f66a0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66aa000 f66ac000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66b4000 f66d1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66da000 f66de000 r-xp /usr/lib/libsmack.so.1.0.0
f66e7000 f6700000 r-xp /usr/lib/libnetwork.so.0.0.0
f6709000 f6711000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6719000 f671f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6728000 f672a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6733000 f6743000 r-xp /lib/libresolv-2.13.so
f6747000 f675f000 r-xp /usr/lib/liblzma.so.5.0.3
f6768000 f676a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6772000 f678c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6794000 f67c3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67cc000 f67db000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67e5000 f67ef000 r-xp /usr/lib/libsensord-shared.so
f67f8000 f68cb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68d6000 f68ec000 r-xp /lib/libz.so.1.2.5
f68f4000 f68f9000 r-xp /usr/lib/libffi.so.5.0.10
f6901000 f6902000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f690a000 f691a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6922000 f693b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6943000 f6945000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f694d000 f69c2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69cc000 f69d2000 r-xp /lib/librt-2.13.so
f69db000 f69f9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a03000 f6a04000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a0c000 f6a2f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a37000 f6a3c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a44000 f6a6e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a77000 f6a8e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a96000 f6aff000 r-xp /lib/libm-2.13.so
f6b08000 f6b9c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6baf000 f6bb4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bbc000 f6bc3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bcb000 f6bf5000 r-xp /usr/lib/libsensor.so.1.9.6
f6bfe000 f6cca000 r-xp /usr/lib/libxml2.so.2.7.8
f6cd7000 f6cd9000 r-xp /usr/lib/libiniparser.so.0
f6ce2000 f6ce8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cf1000 f6dc1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dc2000 f6df6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dff000 f6e3b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e43000 f6e46000 r-xp /usr/lib/libbundle.so.0.1.22
f6e4e000 f6e54000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e5c000 f6e9d000 r-xp /usr/lib/libeina.so.1.7.99
f6ea6000 f6ebd000 r-xp /usr/lib/libecore.so.1.7.99
f6ed4000 f6edd000 r-xp /usr/lib/libvconf.so.0.2.45
f6ee5000 f6ef9000 r-xp /lib/libpthread-2.13.so
f6f04000 f6f11000 r-xp /usr/lib/libaul.so.0.1.0
f6f1b000 f6f1d000 r-xp /lib/libdl-2.13.so
f6f26000 f6f31000 r-xp /lib/libunwind.so.8.0.1
f6f5e000 f6f66000 r-xp /lib/libgcc_s-4.6.so.1
f6f67000 f708b000 r-xp /lib/libc-2.13.so
f7099000 f709b000 r-xp /usr/lib/libdlog.so.0.0.0
f70a3000 f70af000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70b8000 f70bd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70c5000 f70d4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70dc000 f70e0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70e9000 f70ec000 r-xp /usr/lib/libappcore-agent.so.1.1
f70f4000 f70f6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70fe000 f7102000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f710a000 f7127000 r-xp /lib/ld-2.13.so
f7130000 f7133000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7133000 f7137000 r-xp /usr/lib/libsys-assert.so
f75b5000 f7625000 rw-p [heap]
ff828000 ff849000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30160)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7131228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70c8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dcf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dcdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dd9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ddfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ddfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e1475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e0f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dcdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dd9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ddfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ddfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e11e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e12017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e19f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47b11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47a4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6877663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d24fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d267a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6eb6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6eb1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6eb25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6eb2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70ea183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70ea7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71315c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f7e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7130f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ference_get_int(3247) : key(music-control-service_native/playing_diration) error
06-07 19:24:36.271+0200 W/MUSIC_CONTROL_SERVICE( 3247): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3247]   preference_get_int() .. [0xfef00030][0m
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-07 19:24:36.271+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 19:24:36.271+0200 W/W_HOME  ( 2762): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-07 19:24:36.271+0200 E/W_HOME  ( 2762): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-07 19:24:36.271+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:260,0.504167,-1.343748,4.753965
06-07 19:24:36.271+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.271+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.271+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:271,41.650002,81.059998,-7.210000
06-07 19:24:36.281+0200 I/TIZEN_N_SOUND_MANAGER( 3247): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-07 19:24:36.281+0200 W/TIZEN_N_SOUND_MANAGER( 3247): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
06-07 19:24:36.281+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:275,2.352145,5.726025,11.294124
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-07 19:24:36.281+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 19:24:36.281+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.281+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.281+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:283,0.511221,-1.342840,-2.554946
06-07 19:24:36.291+0200 I/heartrate(30138): es.ugr.frailty.heartrate - capturing data
06-07 19:24:36.291+0200 I/heartrate(30138): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:24:36.291+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:284,1.847978,7.069773,6.540158
06-07 19:24:36.291+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:291,62.160000,14.280000,10.570000
06-07 19:24:36.291+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.291+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.291+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:294,2.493321,5.807381,3.857230
06-07 19:24:36.291+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.301+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:303,2.734996,7.996813,5.735595
06-07 19:24:36.301+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:302,1.982100,7.150220,6.412177
06-07 19:24:36.301+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:301,0.851525,0.941026,-0.809540
06-07 19:24:36.301+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.301+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.301+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:311,1.883472,7.055787,6.545135
06-07 19:24:36.311+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.311+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:312,57.049999,-21.210001,16.030001
06-07 19:24:36.311+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.311+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:316,1.919755,7.143342,6.438757
06-07 19:24:36.311+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.311+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.321+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:322,1.998831,7.262644,6.279257
06-07 19:24:36.321+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:318,2.617748,8.245667,3.218346
06-07 19:24:36.321+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:322,0.697993,1.102325,-3.220411
06-07 19:24:36.321+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.321+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.321+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.331+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:334,9.310000,-6.300000,10.430000
06-07 19:24:36.331+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.331+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:334,2.079821,7.384701,6.108267
06-07 19:24:36.331+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:335,-1.118272,2.325397,1.514166
06-07 19:24:36.331+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:339,0.880559,9.588040,7.793423
06-07 19:24:36.341+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.341+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.341+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.351+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:353,-9.030000,-12.040000,8.470000
06-07 19:24:36.351+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.351+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:356,2.068326,7.376083,6.122565
06-07 19:24:36.351+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:358,1.289732,6.879365,5.402994
06-07 19:24:36.351+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:353,-0.790090,-0.505336,-0.705273
06-07 19:24:36.361+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.361+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.361+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.371+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:373,-20.860001,10.080000,1.540000
06-07 19:24:36.371+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:373,-0.386172,0.120630,0.098774
06-07 19:24:36.371+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.371+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:377,2.030387,7.343637,6.174052
06-07 19:24:36.371+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:379,1.682154,7.496714,6.221339
06-07 19:24:36.381+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.381+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.381+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.391+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:392,-29.750000,26.389999,-8.330000
06-07 19:24:36.391+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.391+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:397,1.975478,7.287681,6.257602
06-07 19:24:36.391+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:392,-0.254912,-0.275239,-0.268565
06-07 19:24:36.391+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:398,1.775474,7.068398,5.905487
06-07 19:24:36.401+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.401+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.411+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.411+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:414,-3.920000,1.890000,4.200000
06-07 19:24:36.411+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.431+0200 I/light   (30190): es.ugr.frailty.light - capturing data
06-07 19:24:36.441+0200 I/light   (30190): es.ugr.frailty.light: SM-R760,07/06/2018,19:24:36:439,10917.000000
06-07 19:24:36.451+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.461+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:420,2.488536,6.496514,5.883951
06-07 19:24:36.481+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:416,1.973343,7.278274,6.269214
06-07 19:24:36.481+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:414,0.513058,-0.791167,-0.373651
06-07 19:24:36.491+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.491+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.491+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.511+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:458,-39.970001,-146.580002,17.500000
06-07 19:24:36.521+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.531+0200 I/heartrate(30138): es.ugr.frailty.heartrate - capturing data
06-07 19:24:36.531+0200 I/heartrate(30138): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:24:36.531+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:512,2.185040,7.337122,6.128835
06-07 19:24:36.551+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 19:24:36.551+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 19:24:36.551+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 19:24:36.551+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:506,-1.925486,-0.374980,2.675158
06-07 19:24:36.551+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.561+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:561,0.281960,-1.862344,0.786422
06-07 19:24:36.561+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.571+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:570,1.615301,0.618002,-1.142028
06-07 19:24:36.571+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.581+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:580,0.838456,0.482956,-1.715889
06-07 19:24:36.581+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.581+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:587,0.326393,0.552348,-1.476607
06-07 19:24:36.581+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.591+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:595,-1.895042,1.816313,1.984624
06-07 19:24:36.591+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.601+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:601,-0.951609,0.069374,0.702994
06-07 19:24:36.601+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.601+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:608,-0.796063,-0.365213,0.345784
06-07 19:24:36.601+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.611+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:615,0.202663,-0.119461,0.200375
06-07 19:24:36.611+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.621+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:622,0.139647,-0.366366,-0.739116
06-07 19:24:36.621+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.631+0200 I/light   (30190): es.ugr.frailty.light - capturing data
06-07 19:24:36.631+0200 I/light   (30190): es.ugr.frailty.light: SM-R760,07/06/2018,19:24:36:637,11048.000000
06-07 19:24:36.631+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.641+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:634,0.125449,-0.244216,0.803943
06-07 19:24:36.641+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:506,0.047856,6.903293,8.944371
06-07 19:24:36.641+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:644,2.028968,7.323776,6.198062
06-07 19:24:36.641+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.641+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.651+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:537,31.360001,69.019997,-19.530001
06-07 19:24:36.651+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:653,2.013788,7.279361,6.255074
06-07 19:24:36.651+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.651+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.651+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:660,2.105011,7.377428,6.108427
06-07 19:24:36.661+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.661+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.661+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:666,2.194145,7.463054,5.971510
06-07 19:24:36.661+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.671+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:673,2.217413,7.506302,5.908374
06-07 19:24:36.671+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:653,0.230542,-0.561707,5.682302
06-07 19:24:36.671+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.671+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.671+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:679,2.164758,7.517360,5.913840
06-07 19:24:36.671+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:665,2.467000,5.474778,6.915257
06-07 19:24:36.671+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.681+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.681+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:673,40.250000,38.009998,-5.320000
06-07 19:24:36.681+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:684,0.266932,-0.694709,-2.202566
06-07 19:24:36.681+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.691+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.691+0200 I/heartrate(30138): es.ugr.frailty.heartrate - capturing data
06-07 19:24:36.691+0200 I/heartrate(30138): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:24:36.691+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:689,3.644269,7.941778,5.056034
06-07 19:24:36.691+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:685,2.142303,7.520461,5.918073
06-07 19:24:36.691+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.691+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.701+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:703,2.852244,7.762317,4.539185
06-07 19:24:36.701+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:697,0.632651,1.073390,-1.599252
06-07 19:24:36.701+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:695,53.340000,-1.610000,13.020000
06-07 19:24:36.701+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.701+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.701+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.711+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:708,2.090464,7.492192,5.972219
06-07 19:24:36.711+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:714,2.340181,7.831708,4.778467
06-07 19:24:36.711+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:711,0.361091,0.822691,-2.127273
06-07 19:24:36.711+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.711+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.721+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:714,24.710001,-25.270000,14.210000
06-07 19:24:36.721+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.721+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:725,0.299103,9.279366,7.956135
06-07 19:24:36.721+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.721+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.731+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:724,2.066376,7.415505,6.075422
06-07 19:24:36.731+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:734,-0.105971,0.653897,-0.283518
06-07 19:24:36.731+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.731+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:730,1.265803,7.575676,6.611369
06-07 19:24:36.731+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.741+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:734,0.910000,-7.770000,1.050000
06-07 19:24:36.741+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:743,1.368695,7.152147,6.259624
06-07 19:24:36.741+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.741+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.741+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.751+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:752,-0.845487,-0.707181,-0.026276
06-07 19:24:36.751+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:743,2.071354,7.386037,6.109528
06-07 19:24:36.751+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.751+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:748,2.344966,7.401000,6.118448
06-07 19:24:36.751+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.751+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:751,-1.680000,-5.390000,-5.180000
06-07 19:24:36.761+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:763,2.230111,7.125826,5.233103
06-07 19:24:36.761+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.761+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.761+0200 I/servicemanager(30116): es.ugr.frailty.accelerometer alive timeout
06-07 19:24:36.761+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 19:24:36.761+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.761+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:771,-0.542501,0.164314,0.291167
06-07 19:24:36.771+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 19:24:36.771+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 30116
06-07 19:24:36.771+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:761,2.231175,7.392219,6.045439
06-07 19:24:36.771+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.771+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:768,2.660000,-15.610000,5.110000
06-07 19:24:36.781+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.781+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30123
06-07 19:24:36.791+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:781,2.090381,7.332595,6.167150
06-07 19:24:36.791+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30123)
06-07 19:24:36.791+0200 I/servicemanager(30116): es.ugr.frailty.accelerometer launch request sent!
06-07 19:24:36.791+0200 I/servicemanager(30116): App control destroyed.
06-07 19:24:36.791+0200 I/servicemanager(30116): es.ugr.frailty.gyroscope alive timeout
06-07 19:24:36.791+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 19:24:36.791+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 19:24:36.791+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 30116
06-07 19:24:36.791+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:788,-7.770000,13.720000,-2.730000
06-07 19:24:36.801+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.801+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30135
06-07 19:24:36.811+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:808,2.093946,7.403833,6.080216
06-07 19:24:36.811+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.811+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:812,-38.709999,28.700001,-6.720000
06-07 19:24:36.811+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.821+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:821,2.161406,7.503236,5.932971
06-07 19:24:36.821+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30135)
06-07 19:24:36.821+0200 I/servicemanager(30116): es.ugr.frailty.gyroscope launch request sent!
06-07 19:24:36.821+0200 I/servicemanager(30116): App control destroyed.
06-07 19:24:36.821+0200 I/servicemanager(30116): es.ugr.frailty.heartrate alive timeout
06-07 19:24:36.821+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 19:24:36.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 19:24:36.821+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 30116
06-07 19:24:36.821+0200 I/light   (30190): es.ugr.frailty.light - capturing data
06-07 19:24:36.831+0200 I/light   (30190): es.ugr.frailty.light: SM-R760,07/06/2018,19:24:36:835,10837.000000
06-07 19:24:36.831+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.831+0200 W/LOCATION(30160): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 19:24:36.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30138
06-07 19:24:36.851+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 19:24:36.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(30138), cmd(0)
06-07 19:24:36.851+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:824,-23.799999,12.180000,-0.420000
06-07 19:24:36.851+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.851+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30138)
06-07 19:24:36.851+0200 I/servicemanager(30116): es.ugr.frailty.heartrate launch request sent!
06-07 19:24:36.851+0200 I/servicemanager(30116): App control destroyed.
06-07 19:24:36.851+0200 I/servicemanager(30116): es.ugr.frailty.location alive timeout
06-07 19:24:36.851+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 19:24:36.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 19:24:36.861+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 30116
06-07 19:24:36.861+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:855,2.235717,7.579368,5.807335
06-07 19:24:36.861+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:864,-61.180000,-137.690002,9.170000
06-07 19:24:36.861+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30160
06-07 19:24:36.871+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 19:24:36.881+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30160)
06-07 19:24:36.881+0200 I/servicemanager(30116): es.ugr.frailty.location launch request sent!
06-07 19:24:36.881+0200 I/servicemanager(30116): App control destroyed.
06-07 19:24:36.881+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 19:24:36.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(30135), cmd(0)
06-07 19:24:36.881+0200 I/servicemanager(30116): es.ugr.frailty.linearacceleration alive timeout
06-07 19:24:36.881+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 19:24:36.881+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 19:24:36.881+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 30116
06-07 19:24:36.881+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.881+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:875,2.227048,7.619538,5.757889
06-07 19:24:36.891+0200 I/heartrate(30138): es.ugr.frailty.heartrate - capturing data
06-07 19:24:36.891+0200 I/heartrate(30138): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:24:36.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30162
06-07 19:24:36.891+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.891+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:887,-0.021268,-0.066195,-0.268330
06-07 19:24:36.901+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.901+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30162)
06-07 19:24:36.901+0200 I/servicemanager(30116): es.ugr.frailty.linearacceleration launch request sent!
06-07 19:24:36.901+0200 I/servicemanager(30116): App control destroyed.
06-07 19:24:36.901+0200 I/servicemanager(30116): es.ugr.frailty.gravity alive timeout
06-07 19:24:36.901+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 19:24:36.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 19:24:36.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 30116
06-07 19:24:36.911+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:895,35.840000,97.160004,-21.210001
06-07 19:24:36.911+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:891,2.191825,7.171289,6.879365
06-07 19:24:36.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30171
06-07 19:24:36.911+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.921+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.921+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:917,-0.228583,-0.057499,-0.249880
06-07 19:24:36.921+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30171)
06-07 19:24:36.921+0200 I/servicemanager(30116): es.ugr.frailty.gravity launch request sent!
06-07 19:24:36.921+0200 I/servicemanager(30116): App control destroyed.
06-07 19:24:36.921+0200 I/servicemanager(30116): es.ugr.frailty.pressure alive timeout
06-07 19:24:36.921+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 19:24:36.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 19:24:36.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 30116
06-07 19:24:36.931+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:908,2.227451,7.661014,5.702430
06-07 19:24:36.931+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30186
06-07 19:24:36.931+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.941+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:934,48.930000,22.400000,2.520000
06-07 19:24:36.941+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 19:24:36.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(30171), cmd(0)
06-07 19:24:36.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 19:24:36.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(30186), cmd(0)
06-07 19:24:36.951+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:931,2.301895,6.824330,11.791830
06-07 19:24:36.951+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:36.951+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30186)
06-07 19:24:36.951+0200 I/servicemanager(30116): es.ugr.frailty.pressure launch request sent!
06-07 19:24:36.951+0200 I/servicemanager(30116): App control destroyed.
06-07 19:24:36.951+0200 I/servicemanager(30116): es.ugr.frailty.light alive timeout
06-07 19:24:36.951+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 19:24:36.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 19:24:36.961+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 30116
06-07 19:24:36.961+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:948,2.217018,7.695390,5.660052
06-07 19:24:36.971+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:36.971+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:952,-0.138218,0.325577,1.088564
06-07 19:24:36.971+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:36:965,2.498107,6.697510,3.842873
06-07 19:24:36.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30190
06-07 19:24:36.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 19:24:36.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(30190), cmd(0)
06-07 19:24:36.981+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:36.981+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30190)
06-07 19:24:36.981+0200 I/servicemanager(30116): es.ugr.frailty.light launch request sent!
06-07 19:24:36.981+0200 I/servicemanager(30116): App control destroyed.
06-07 19:24:36.981+0200 I/servicemanager(30116): es.ugr.frailty.pedometer alive timeout
06-07 19:24:36.981+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 19:24:36.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 19:24:36.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 30116
06-07 19:24:36.991+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:968,34.790001,-17.639999,13.370000
06-07 19:24:36.991+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:36.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30193
06-07 19:24:37.001+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:36:989,-0.184330,-0.503551,0.474809
06-07 19:24:37.001+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:36:985,2.234331,7.692771,5.656803
06-07 19:24:37.001+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:37.001+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 19:24:37.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(30193), cmd(0)
06-07 19:24:37.011+0200 W/AUL     (30116): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30193)
06-07 19:24:37.011+0200 I/servicemanager(30116): es.ugr.frailty.pedometer launch request sent!
06-07 19:24:37.011+0200 I/servicemanager(30116): App control destroyed.
06-07 19:24:37.011+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:36:998,-4.970000,-36.119999,8.120000
06-07 19:24:37.011+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:37.011+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:37:9,2.225407,7.689197,5.665174
06-07 19:24:37.011+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:37:19,2.723032,8.405986,4.567898
06-07 19:24:37.011+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:37.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 19:24:37.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(30123), cmd(0)
06-07 19:24:37.021+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:37.021+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:12,0.362109,-0.643122,0.818229
06-07 19:24:37.021+0200 I/light   (30190): es.ugr.frailty.light - capturing data
06-07 19:24:37.031+0200 I/light   (30190): es.ugr.frailty.light: SM-R760,07/06/2018,19:24:37:34,10762.000000
06-07 19:24:37.031+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:37.031+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:37:23,12.040000,-7.910000,-2.450000
06-07 19:24:37.051+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.051+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 19:24:37.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(30162), cmd(0)
06-07 19:24:37.051+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:37.051+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:57,1.533860,1.151340,-3.002104
06-07 19:24:37.061+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:37:30,2.455036,8.226524,3.952943
06-07 19:24:37.061+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:37.061+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:37:47,2.198211,7.666057,5.706998
06-07 19:24:37.061+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:37:64,30.730000,-27.650000,8.680000
06-07 19:24:37.071+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:37.071+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.071+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:37:69,2.055435,8.157133,5.649454
06-07 19:24:37.071+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:37:77,2.096052,7.654247,5.761028
06-07 19:24:37.081+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:84,0.322916,0.285687,-2.039937
06-07 19:24:37.081+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:37.081+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:37.091+0200 I/heartrate(30138): es.ugr.frailty.heartrate - capturing data
06-07 19:24:37.091+0200 I/heartrate(30138): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:24:37.091+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:37.091+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.091+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:37:92,29.190001,-10.710000,7.490000
06-07 19:24:37.101+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:37:102,2.098621,7.646520,5.770347
06-07 19:24:37.101+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:37:93,1.390230,6.872187,5.781059
06-07 19:24:37.101+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:37.111+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:37.111+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:105,-0.129448,0.173924,-1.199870
06-07 19:24:37.111+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:37.121+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.121+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:37:114,2.590000,-3.640000,8.680000
06-07 19:24:37.131+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:37.131+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:37:119,1.684547,7.783852,6.049056
06-07 19:24:37.131+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:37:124,2.244703,7.765461,5.552414
06-07 19:24:37.131+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:37.131+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:129,-0.852896,-0.350507,2.416613
06-07 19:24:37.141+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:37.151+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.151+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:37:139,7.140000,10.780000,7.910000
06-07 19:24:37.151+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:37.161+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:37:146,2.206182,7.594819,5.434100
06-07 19:24:37.171+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:155,-0.261075,-0.184441,0.156482
06-07 19:24:37.171+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.171+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:37.181+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:179,0.208594,-0.074865,0.294724
06-07 19:24:37.181+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.181+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:188,0.151442,-0.045615,-1.849096
06-07 19:24:37.191+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.191+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:37:151,2.350803,7.804150,5.453381
06-07 19:24:37.191+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:196,0.258898,0.228019,1.080007
06-07 19:24:37.191+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:37.191+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.201+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:202,2.039159,-3.090825,1.446108
06-07 19:24:37.201+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:24:37:172,-10.010000,5.810000,-6.370000
06-07 19:24:37.201+0200 I/gyroscope(30135): es.ugr.frailty.gyroscope - capturing data
06-07 19:24:37.201+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.201+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:24:37:182,1.988436,7.637890,5.410172
06-07 19:24:37.201+0200 I/accelerometer(30123): es.ugr.frailty.accelerometer - capturing data
06-07 19:24:37.201+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:208,0.233957,-0.107186,-2.162641
06-07 19:24:37.211+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.211+0200 I/gravity (30171): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:24:37:201,2.376330,7.827116,5.409224
06-07 19:24:37.211+0200 I/gravity (30171): es.ugr.frailty.gravity - capturing data
06-07 19:24:37.221+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:24:37:216,0.613303,0.978077,-1.630826
06-07 19:24:37.221+0200 I/linearacceleration(30162): es.ugr.frailty.linearacceleration - capturing data
06-07 19:24:37.231+0200 I/light   (30190): es.ugr.frailty.light - capturing data
06-07 19:24:37.231+0200 I/light   (30190): es.ugr.frailty.light: SM-R760,07/06/2018,19:24:37:238,10808.000000
06-07 19:24:37.281+0200 W/CRASH_MANAGER(30257): worker.c: worker_job(1205) > 11301606c6f63152839227
