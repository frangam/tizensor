S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: httppostreq
PID: 13302
Date: 2018-04-12 20:49:54+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/httppostreq
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xa343734

Register Information
r0   = 0x00000000, r1   = 0xf708e738
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x32323630, r5   = 0x392c3331
r6   = 0xf6ca5a35, r7   = 0x3031382e
r8   = 0x00000041, r9   = 0xf6d42824
r10  = 0xf7809dd8, fp   = 0x00000000
ip   = 0x00000020, sp   = 0xffea3258
lr   = 0xf706b9f8, pc   = 0x0a343734
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     40552 KB
Buffers:     57176 KB
Cached:     226960 KB
VmPeak:      21180 KB
VmSize:      21176 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        9128 KB
VmRSS:        9128 KB
VmData:       9636 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        9612 KB
VmPTE:          40 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13302 TID = 13302
13302 13304 

Maps Information
f5d08000 f650c000 rw-p [stack:13304]
f650c000 f650e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6516000 f6518000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6522000 f6532000 r-xp /usr/lib/libmdm-common.so.1.1.24
f653a000 f653c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6544000 f6549000 r-xp /usr/lib/libffi.so.5.0.10
f6551000 f6552000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f655a000 f656a000 r-xp /lib/libresolv-2.13.so
f656f000 f6587000 r-xp /usr/lib/liblzma.so.5.0.3
f658f000 f6591000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6599000 f65b3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f65bb000 f6687000 r-xp /usr/lib/libxml2.so.2.7.8
f6694000 f6696000 r-xp /usr/lib/libiniparser.so.0
f669f000 f66e8000 r-xp /usr/lib/libmdm.so.1.2.69
f66f0000 f66f6000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66fe000 f6732000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f673b000 f680e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6819000 f681f000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6828000 f689d000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68a7000 f6910000 r-xp /lib/libm-2.13.so
f6919000 f691f000 r-xp /lib/librt-2.13.so
f6928000 f6946000 r-xp /usr/lib/libsystemd.so.0.4.0
f6950000 f6951000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6959000 f697c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6984000 f6989000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6991000 f69bb000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69c4000 f69db000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69e3000 f69f9000 r-xp /lib/libz.so.1.2.5
f6a01000 f6baa000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bca000 f6c11000 r-xp /usr/lib/libssl.so.1.0.0
f6c1d000 f6c4b000 r-xp /usr/lib/libidn.so.11.5.44
f6c53000 f6c5c000 r-xp /usr/lib/libcares.so.2.1.0
f6c65000 f6c6a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6c72000 f6d42000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d43000 f6d5c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d64000 f6d67000 r-xp /usr/lib/libbundle.so.0.1.22
f6d6f000 f6d75000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d7d000 f6dbe000 r-xp /usr/lib/libeina.so.1.7.99
f6dc7000 f6dde000 r-xp /usr/lib/libecore.so.1.7.99
f6df5000 f6dfe000 r-xp /usr/lib/libvconf.so.0.2.45
f6e06000 f6e1a000 r-xp /lib/libpthread-2.13.so
f6e25000 f6e32000 r-xp /usr/lib/libaul.so.0.1.0
f6e3c000 f6e3e000 r-xp /lib/libdl-2.13.so
f6e47000 f6e52000 r-xp /lib/libunwind.so.8.0.1
f6e7f000 f6e87000 r-xp /lib/libgcc_s-4.6.so.1
f6e88000 f6fac000 r-xp /lib/libc-2.13.so
f6fba000 f6fbc000 r-xp /usr/lib/libdlog.so.0.0.0
f6fc4000 f7008000 r-xp /usr/lib/libcurl.so.4.3.0
f7011000 f7021000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f7029000 f702d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7036000 f7039000 r-xp /usr/lib/libappcore-agent.so.1.1
f7057000 f7074000 r-xp /lib/ld-2.13.so
f707d000 f707f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/httppostreq
f707f000 f7083000 r-xp /usr/lib/libsys-assert.so
f7805000 f7868000 rw-p [heap]
ffe84000 ffea5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13302)
Call Stack Count: 1
 0: (0xa343734) (null)
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: httppostreq
App ID: es.ugr.frailty.httppostreq
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
TOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 20:49:04.759+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 20:49:04.759+0200 W/W_HOME  ( 2742): main.c: home_pause(547) > clock/widget paused
04-12 20:49:04.759+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 20:49:04.769+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-12 20:49:04.769+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-12 20:49:04.759+0200 W/SHealthCommon( 3180): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-12 20:49:04.769+0200 W/W_INDICATOR( 2666): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 20:49:04.769+0200 W/SHealthService( 3180): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 20:49:04.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 20:49:04.769+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 20:49:04.769+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 20:49:04.779+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:04,0.191426,0.098106,9.808180
04-12 20:49:04.779+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_pause(1113) > widget_pause
04-12 20:49:04.779+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(bg) type(watchapp)
04-12 20:49:04.779+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppPause(552) > 
04-12 20:49:04.799+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:04,0.212961,0.040678,9.868000
04-12 20:49:04.969+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:04,0.148355,0.105284,9.834501
04-12 20:49:05.169+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:05,0.177069,0.055035,9.779467
04-12 20:49:05.269+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 20:49:05.379+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:05,0.141177,0.047856,9.856036
04-12 20:49:05.569+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:05,0.217747,0.035892,9.815358
04-12 20:49:05.779+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:05,0.193819,0.047856,9.846465
04-12 20:49:05.979+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:05,0.167498,0.074178,9.827322
04-12 20:49:06.179+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:06,0.174676,0.050249,9.822537
04-12 20:49:06.379+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:06,0.205783,0.033500,9.848858
04-12 20:49:06.579+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:06,0.212961,0.038285,9.822537
04-12 20:49:06.779+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:06,0.229711,0.045464,9.839286
04-12 20:49:06.979+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:06,0.157926,0.095713,9.824929
04-12 20:49:07.179+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:07,0.234497,0.069392,9.815358
04-12 20:49:07.379+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:07,0.148355,0.078963,9.841680
04-12 20:49:07.579+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:07,0.177069,0.066999,9.824929
04-12 20:49:07.779+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:07,0.236889,0.026321,9.801002
04-12 20:49:07.979+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:07,0.191426,0.074178,9.848858
04-12 20:49:08.179+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:08,0.205783,0.019143,9.834501
04-12 20:49:08.379+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:08,0.181855,0.076570,9.844072
04-12 20:49:08.579+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:08,0.177069,0.062213,9.820145
04-12 20:49:08.789+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:08,0.205783,0.014357,9.856036
04-12 20:49:08.989+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:08,0.157926,0.093320,9.834501
04-12 20:49:09.189+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:09,0.181855,0.071785,9.796216
04-12 20:49:09.389+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:09,0.165105,0.078963,9.820145
04-12 20:49:09.589+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:09,0.186640,0.004786,9.856036
04-12 20:49:09.779+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 20:49:09.789+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:09,0.160319,0.047856,9.879964
04-12 20:49:09.989+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:09,0.186640,0.026321,9.815358
04-12 20:49:10.189+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:10,0.167498,0.033500,9.810574
04-12 20:49:10.389+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:10,0.174676,0.038285,9.870394
04-12 20:49:10.589+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:10,0.191426,0.026321,9.805787
04-12 20:49:10.789+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:10,0.153141,0.059821,9.824929
04-12 20:49:10.989+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:10,0.189033,0.055035,9.841680
04-12 20:49:11.189+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:11,0.193819,0.074178,9.856036
04-12 20:49:11.389+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:11,0.157926,-0.021535,9.865608
04-12 20:49:11.589+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:11,0.220140,0.019143,9.815358
04-12 20:49:11.789+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:11,0.210568,0.050249,9.774680
04-12 20:49:11.989+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:11,0.186640,0.064606,9.884750
04-12 20:49:12.189+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:12,0.162712,0.045464,9.820145
04-12 20:49:12.389+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:12,0.177069,0.086142,9.808180
04-12 20:49:12.589+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:12,0.239282,0.014357,9.863215
04-12 20:49:12.789+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:12,0.203390,0.071785,9.841680
04-12 20:49:12.989+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:12,0.196211,0.055035,9.856036
04-12 20:49:13.189+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:13,0.189033,0.076570,9.829715
04-12 20:49:13.399+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:13,0.198604,0.098106,9.848858
04-12 20:49:13.599+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:13,0.179462,0.043071,9.836893
04-12 20:49:13.799+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:13,0.217747,-0.007178,9.815358
04-12 20:49:13.999+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:13,0.167498,0.062213,9.839286
04-12 20:49:14.199+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:14,0.229711,0.074178,9.829715
04-12 20:49:14.399+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:14,0.165105,0.071785,9.868000
04-12 20:49:14.599+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:14,0.224925,0.062213,9.815358
04-12 20:49:14.799+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:14,0.205783,0.045464,9.822537
04-12 20:49:14.999+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:15,0.177069,0.050249,9.841680
04-12 20:49:15.199+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:15,0.208176,0.055035,9.839286
04-12 20:49:15.399+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:15,0.129212,0.031107,9.824929
04-12 20:49:15.599+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:15,0.205783,0.052642,9.836893
04-12 20:49:15.799+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:15,0.174676,0.083749,9.863215
04-12 20:49:15.999+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:16,0.165105,0.083749,9.865608
04-12 20:49:16.199+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:16,0.177069,0.083749,9.827322
04-12 20:49:16.399+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:16,0.186640,0.090927,9.860823
04-12 20:49:16.599+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:16,0.205783,0.059821,9.863215
04-12 20:49:16.799+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:16,0.184247,0.033500,9.853643
04-12 20:49:16.999+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:17,0.165105,0.076570,9.856036
04-12 20:49:17.199+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:17,0.208176,0.052642,9.858429
04-12 20:49:17.399+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:17,0.150748,0.059821,9.827322
04-12 20:49:17.609+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:17,0.200997,0.076570,9.820145
04-12 20:49:17.809+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:17,0.186640,0.038285,9.801002
04-12 20:49:18.009+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:18,0.200997,0.081356,9.896714
04-12 20:49:18.209+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:18,0.186640,0.064606,9.836893
04-12 20:49:18.409+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:18,0.215354,0.090927,9.810574
04-12 20:49:18.609+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:18,0.174676,0.035892,9.822537
04-12 20:49:18.809+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:18,0.193819,0.055035,9.856036
04-12 20:49:19.009+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:19,0.208176,0.035892,9.827322
04-12 20:49:19.209+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:19,0.210568,0.047856,9.851252
04-12 20:49:19.409+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:19,0.215354,-0.023928,9.853643
04-12 20:49:19.609+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:19,0.196211,0.057428,9.829715
04-12 20:49:19.809+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:19,0.189033,0.016750,9.872787
04-12 20:49:20.009+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:20,0.229711,0.019143,9.834501
04-12 20:49:20.209+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:20,0.205783,0.035892,9.853643
04-12 20:49:20.409+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:20,0.184247,0.086142,9.860823
04-12 20:49:20.609+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:20,0.234497,0.078963,9.832108
04-12 20:49:20.809+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:20,0.172283,0.031107,9.839286
04-12 20:49:21.009+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:21,0.222532,-0.002393,9.851252
04-12 20:49:21.209+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:21,0.179462,0.031107,9.815358
04-12 20:49:21.409+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:21,0.174676,0.052642,9.815358
04-12 20:49:21.609+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:21,0.184247,0.055035,9.848858
04-12 20:49:21.809+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:21,0.196211,0.095713,9.846465
04-12 20:49:22.009+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:22,0.217747,0.055035,9.851252
04-12 20:49:22.209+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:22,0.205783,0.064606,9.812965
04-12 20:49:22.419+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:22,0.198604,0.081356,9.836893
04-12 20:49:22.619+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:22,0.165105,0.083749,9.824929
04-12 20:49:22.819+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:22,0.229711,0.031107,9.786645
04-12 20:49:23.019+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:23,0.148355,0.119641,9.829715
04-12 20:49:23.219+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:23,0.186640,0.069392,9.798609
04-12 20:49:23.419+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:23,0.179462,0.038285,9.829715
04-12 20:49:23.619+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:23,0.222532,0.038285,9.839286
04-12 20:49:23.819+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:23,0.198604,0.031107,9.882358
04-12 20:49:24.019+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:24,0.222532,0.050249,9.858429
04-12 20:49:24.219+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:24,0.186640,0.064606,9.858429
04-12 20:49:24.419+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:24,0.203390,0.064606,9.741181
04-12 20:49:24.619+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:24,0.184247,0.052642,9.834501
04-12 20:49:24.819+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:24,0.198604,0.040678,9.774680
04-12 20:49:25.019+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:25,0.167498,0.040678,9.944571
04-12 20:49:25.219+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:25,0.191426,0.062213,9.815358
04-12 20:49:25.419+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:25,0.191426,0.055035,9.839286
04-12 20:49:25.619+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:25,0.210568,0.141177,9.836893
04-12 20:49:25.819+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:25,0.174676,0.014357,9.844072
04-12 20:49:26.019+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:26,0.169890,0.138784,9.875179
04-12 20:49:26.219+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:26,0.212961,0.043071,9.829715
04-12 20:49:26.419+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:26,0.186640,0.038285,9.829715
04-12 20:49:26.619+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:26,0.186640,0.028714,9.851252
04-12 20:49:26.819+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:26,0.160319,0.059821,9.872787
04-12 20:49:27.019+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:27,0.205783,0.047856,9.762716
04-12 20:49:27.219+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:27,0.193819,0.095713,9.824929
04-12 20:49:27.429+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:27,0.193819,0.102891,9.834501
04-12 20:49:27.619+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:27,0.217747,0.050249,9.875179
04-12 20:49:27.829+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:27,0.189033,0.078963,9.841680
04-12 20:49:28.029+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:28,0.150748,0.126820,9.815358
04-12 20:49:28.229+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:28,0.205783,-0.002393,9.834501
04-12 20:49:28.429+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:28,0.150748,0.078963,9.903893
04-12 20:49:28.629+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:28,0.198604,0.040678,9.851252
04-12 20:49:28.829+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:28,0.200997,0.026321,9.827322
04-12 20:49:29.029+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:29,0.177069,0.031107,9.798609
04-12 20:49:29.229+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:29,0.162712,0.062213,9.853643
04-12 20:49:29.429+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:29,0.203390,0.069392,9.815358
04-12 20:49:29.629+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:29,0.150748,0.069392,9.851252
04-12 20:49:29.829+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:29,0.193819,0.035892,9.810574
04-12 20:49:30.029+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:30,0.165105,0.033500,9.805787
04-12 20:49:30.229+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:30,0.172283,0.038285,9.844072
04-12 20:49:30.429+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:30,0.208176,0.038285,9.803394
04-12 20:49:30.629+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:30,0.172283,0.059821,9.836893
04-12 20:49:30.829+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:30,0.177069,0.052642,9.851252
04-12 20:49:31.029+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:31,0.184247,0.066999,9.844072
04-12 20:49:31.229+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:31,0.198604,0.062213,9.846465
04-12 20:49:31.429+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:31,0.153141,0.064606,9.848858
04-12 20:49:31.629+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:31,0.172283,0.045464,9.853643
04-12 20:49:31.829+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:31,0.198604,0.066999,9.815358
04-12 20:49:32.029+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:32,0.208176,0.050249,9.848858
04-12 20:49:32.239+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:32,0.210568,0.083749,9.829715
04-12 20:49:32.439+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:32,0.191426,0.045464,9.803394
04-12 20:49:32.639+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:32,0.169890,0.059821,9.822537
04-12 20:49:32.839+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:32,0.189033,0.076570,9.846465
04-12 20:49:33.039+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:33,0.174676,0.095713,9.870394
04-12 20:49:33.239+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:33,0.198604,0.033500,9.848858
04-12 20:49:33.439+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:33,0.200997,0.023928,9.851252
04-12 20:49:33.639+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:33,0.179462,0.047856,9.836893
04-12 20:49:33.839+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:33,0.203390,0.064606,9.844072
04-12 20:49:34.039+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:34,0.191426,0.043071,9.827322
04-12 20:49:34.239+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:34,0.174676,0.062213,9.834501
04-12 20:49:34.439+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:34,0.184247,0.062213,9.812965
04-12 20:49:34.639+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:34,0.162712,0.100499,9.789038
04-12 20:49:34.839+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:34,0.177069,0.023928,9.832108
04-12 20:49:35.039+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:35,0.205783,0.055035,9.836893
04-12 20:49:35.239+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:35,0.160319,0.081356,9.853643
04-12 20:49:35.439+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:35,0.200997,0.071785,9.832108
04-12 20:49:35.639+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:35,0.179462,0.100499,9.801002
04-12 20:49:35.839+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:35,0.217747,0.064606,9.798609
04-12 20:49:36.049+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:36,0.200997,0.062213,9.875179
04-12 20:49:36.249+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:36,0.148355,0.064606,9.805787
04-12 20:49:36.449+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:36,0.193819,0.031107,9.856036
04-12 20:49:36.649+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:36,0.191426,0.078963,9.812965
04-12 20:49:36.849+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:36,0.196211,0.112463,9.810574
04-12 20:49:37.049+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:37,0.191426,0.078963,9.841680
04-12 20:49:37.249+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:37,0.191426,0.064606,9.824929
04-12 20:49:37.449+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:37,0.186640,0.040678,9.832108
04-12 20:49:37.649+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:37,0.193819,0.038285,9.846465
04-12 20:49:37.849+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:37,0.174676,0.055035,9.863215
04-12 20:49:38.049+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:38,0.198604,0.062213,9.841680
04-12 20:49:38.249+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:38,0.174676,0.081356,9.858429
04-12 20:49:38.449+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:38,0.174676,0.069392,9.834501
04-12 20:49:38.649+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:38,0.200997,0.052642,9.851252
04-12 20:49:38.849+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:38,0.174676,0.086142,9.793823
04-12 20:49:39.049+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:39,0.165105,0.038285,9.779467
04-12 20:49:39.249+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:39,0.150748,0.076570,9.834501
04-12 20:49:39.449+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:39,0.203390,0.050249,9.820145
04-12 20:49:39.649+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:39,0.174676,0.047856,9.848858
04-12 20:49:39.849+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:39,0.167498,0.083749,9.829715
04-12 20:49:40.059+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:40,0.155533,0.052642,9.824929
04-12 20:49:40.259+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:40,0.165105,0.064606,9.820145
04-12 20:49:40.459+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:40,0.227318,0.031107,9.841680
04-12 20:49:40.659+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:40,0.193819,0.047856,9.856036
04-12 20:49:40.859+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:40,0.186640,0.038285,9.805787
04-12 20:49:41.059+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:41,0.169890,0.057428,9.803394
04-12 20:49:41.259+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:41,0.157926,0.035892,9.834501
04-12 20:49:41.459+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:41,0.198604,0.019143,9.844072
04-12 20:49:41.659+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:41,0.200997,0.057428,9.796216
04-12 20:49:41.859+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:41,0.239282,0.035892,9.853643
04-12 20:49:42.059+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:42,0.186640,0.033500,9.863215
04-12 20:49:42.259+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:42,0.189033,0.074178,9.796216
04-12 20:49:42.459+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:42,0.196211,0.088534,9.846465
04-12 20:49:42.659+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:42,0.138784,0.107677,9.870394
04-12 20:49:42.859+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:42,0.184247,0.021535,9.801002
04-12 20:49:43.059+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:43,0.148355,0.100499,9.834501
04-12 20:49:43.269+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:43,0.186640,0.043071,9.879964
04-12 20:49:43.469+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:43,0.193819,0.040678,9.856036
04-12 20:49:43.669+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:43,0.177069,0.035892,9.851252
04-12 20:49:43.869+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:43,0.179462,0.057428,9.868000
04-12 20:49:44.069+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:44,0.205783,0.059821,9.824929
04-12 20:49:44.269+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:44,0.203390,0.076570,9.817751
04-12 20:49:44.469+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:44,0.157926,0.028714,9.848858
04-12 20:49:44.669+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:44,0.198604,0.050249,9.798609
04-12 20:49:44.869+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:44,0.167498,0.069392,9.848858
04-12 20:49:45.069+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:45,0.200997,0.064606,9.877571
04-12 20:49:45.269+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:45,0.208176,0.095713,9.834501
04-12 20:49:45.469+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:45,0.160319,0.071785,9.844072
04-12 20:49:45.669+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:45,0.191426,0.055035,9.815358
04-12 20:49:45.869+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:45,0.191426,0.004786,9.832108
04-12 20:49:46.069+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:46,0.155533,0.062213,9.812965
04-12 20:49:46.269+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:46,0.167498,0.050249,9.829715
04-12 20:49:46.469+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:46,0.212961,0.090927,9.860823
04-12 20:49:46.669+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:46,0.198604,0.069392,9.824929
04-12 20:49:46.869+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:46,0.179462,0.047856,9.860823
04-12 20:49:47.069+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:47,0.203390,0.043071,9.865608
04-12 20:49:47.269+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:47,0.193819,0.062213,9.810574
04-12 20:49:47.479+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:47,0.200997,0.043071,9.853643
04-12 20:49:47.679+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:47,0.193819,0.040678,9.860823
04-12 20:49:47.879+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:47,0.205783,-0.004786,9.841680
04-12 20:49:48.079+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:48,0.179462,0.090927,9.827322
04-12 20:49:48.279+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:48,0.203390,0.059821,9.841680
04-12 20:49:48.479+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:48,0.217747,0.064606,9.846465
04-12 20:49:48.679+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:48,0.162712,0.057428,9.841680
04-12 20:49:48.879+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:48,0.150748,0.045464,9.812965
04-12 20:49:49.079+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:49,0.184247,0.050249,9.834501
04-12 20:49:49.279+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:49,0.189033,0.069392,9.812965
04-12 20:49:49.479+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:49,0.246461,0.052642,9.834501
04-12 20:49:49.679+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:49,0.143569,0.069392,9.829715
04-12 20:49:49.879+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:49,0.198604,0.055035,9.812965
04-12 20:49:50.079+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:50,0.186640,0.059821,9.856036
04-12 20:49:50.279+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:50,0.212961,0.069392,9.822537
04-12 20:49:50.479+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:50,0.186640,0.033500,9.870394
04-12 20:49:50.679+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:50,0.198604,0.045464,9.844072
04-12 20:49:50.879+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:50,0.167498,0.057428,9.822537
04-12 20:49:51.079+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:51,0.193819,0.047856,9.827322
04-12 20:49:51.279+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:51,0.193819,0.035892,9.868000
04-12 20:49:51.489+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:51,0.143569,0.031107,9.858429
04-12 20:49:51.689+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:51,0.205783,0.043071,9.853643
04-12 20:49:51.889+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:51,0.181855,0.093320,9.868000
04-12 20:49:52.089+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:52,0.200997,0.083749,9.853643
04-12 20:49:52.289+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:52,0.215354,0.050249,9.846465
04-12 20:49:52.489+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:52,0.215354,-0.004786,9.798609
04-12 20:49:52.689+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:52,0.193819,0.059821,9.815358
04-12 20:49:52.889+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:52,0.179462,0.059821,9.841680
04-12 20:49:53.089+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:53,0.205783,0.016750,9.903893
04-12 20:49:53.289+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:53,0.172283,0.100499,9.820145
04-12 20:49:53.489+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:53,0.227318,0.043071,9.808180
04-12 20:49:53.689+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:53,0.177069,0.076570,9.844072
04-12 20:49:53.889+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:53,0.229711,0.066999,9.856036
04-12 20:49:54.089+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:54,0.181855,0.071785,9.827322
04-12 20:49:54.289+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:54,0.167498,0.064606,9.841680
04-12 20:49:54.489+0200 I/utils   (13310): accelerometer: SM-R760,12/04/2018,20:49:54,0.181855,0.066999,9.836893
04-12 20:49:54.559+0200 I/servicemanager(13299): accelerometer sleep timeout
04-12 20:49:54.559+0200 W/AUL     (13299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 20:49:54.559+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 20:49:54.559+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 13299
04-12 20:49:54.579+0200 W/AUL_AMD ( 2499): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13310
04-12 20:49:54.579+0200 W/AUL     (13299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13310)
04-12 20:49:54.579+0200 I/servicemanager(13299): es.ugr.frailty.accelerometer stop request sent!
04-12 20:49:54.579+0200 I/servicemanager(13299): App control destroyed.
04-12 20:49:54.579+0200 E/AUL_AMD ( 2499): amd_launch.c: __real_send(909) > send fail to client
04-12 20:49:54.579+0200 W/AUL_AMD ( 2499): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(13310), cmd(0)
04-12 20:49:54.579+0200 I/utils   (13310): Stopping es.ugr.frailty.accelerometer service
04-12 20:49:54.579+0200 W/AUL     (13310): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 20:49:54.579+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 20:49:54.589+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 13310
04-12 20:49:54.609+0200 W/AUL_AMD ( 2499): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13299
04-12 20:49:54.609+0200 E/AUL_AMD ( 2499): amd_launch.c: __real_send(909) > send fail to client
04-12 20:49:54.609+0200 W/AUL_AMD ( 2499): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(13299), cmd(0)
04-12 20:49:54.609+0200 W/CAPI_APPFW_APP_CONTROL(13299): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 20:49:54.609+0200 I/servicemanager(13299): Requesting Record Service. Service ID: es.ugr.frailty.accelerometer
04-12 20:49:54.609+0200 I/servicemanager(13299): Requesting Record Service. Data received: SM-R760,12/04/2018,20:48:54,0.191426,0.040678,9.810574
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.205783,0.062213,9.781858
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.220140,0.066999,9.824929
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.177069,0.028714,9.798609
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.203390,0.047856,9.781858
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.205783,0.062213,9.829715
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.157926,-0.009571,9.829715
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.167498,0.076570,9.848858
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.174676,0.062213,9.879964
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.200997,0.047856,9.832108
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.198604,-0.004786,9.863215
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.191426,0.069392,9.836893
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.196211,0.047856,9.832108
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.212961,0.062213,9.853643
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.191426,0.071785,9.817751
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:56,0.215354,0.031107,9.796216
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:56,0.198604,0.014357,9.841680
04-12 20:49:54.609+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:56,0.184247,0.05264
04-12 20:49:54.609+0200 W/AUL     (13299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 20:49:54.619+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 20:49:54.619+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 13299
04-12 20:49:54.629+0200 W/AUL_AMD ( 2499): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13303
04-12 20:49:54.639+0200 E/AUL_AMD ( 2499): amd_launch.c: __real_send(909) > send fail to client
04-12 20:49:54.639+0200 W/AUL_AMD ( 2499): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(13303), cmd(0)
04-12 20:49:54.639+0200 W/CAPI_APPFW_APP_CONTROL(13303): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 20:49:54.639+0200 I/recorder(13303): Requesting Record Service. Service ID: es.ugr.frailty.accelerometer
04-12 20:49:54.639+0200 I/recorder(13303): Requesting Record Service. Data received: SM-R760,12/04/2018,20:48:54,0.191426,0.040678,9.810574
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:54,0.205783,0.062213,9.781858
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:54,0.220140,0.066999,9.824929
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:54,0.177069,0.028714,9.798609
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:54,0.203390,0.047856,9.781858
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.205783,0.062213,9.829715
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.157926,-0.009571,9.829715
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.167498,0.076570,9.848858
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.174676,0.062213,9.879964
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.200997,0.047856,9.832108
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.198604,-0.004786,9.863215
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.191426,0.069392,9.836893
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.196211,0.047856,9.832108
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.212961,0.062213,9.853643
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:55,0.191426,0.071785,9.817751
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:56,0.215354,0.031107,9.796216
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:56,0.198604,0.014357,9.841680
04-12 20:49:54.639+0200 I/recorder(13303): SM-R760,12/04/2018,20:48:56,0.184247,0.05264
04-12 20:49:54.639+0200 W/AUL     (13299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13303)
04-12 20:49:54.649+0200 I/servicemanager(13299): request sent to service es.ugr.frailty.recorder with message: es.ugr.frailty.accelerometer and data: SM-R760,12/04/2018,20:48:54,0.191426,0.040678,9.810574
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.205783,0.062213,9.781858
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.220140,0.066999,9.824929
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.177069,0.028714,9.798609
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.203390,0.047856,9.781858
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.205783,0.062213,9.829715
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.157926,-0.009571,9.829715
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.167498,0.076570,9.848858
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.174676,0.062213,9.879964
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.200997,0.047856,9.832108
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.198604,-0.004786,9.863215
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.191426,0.069392,9.836893
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.196211,0.047856,9.832108
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.212961,0.062213,9.853643
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.191426,0.071785,9.817751
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:56,0.215354,0.031107,9.796216
04-12 20:49:54.649+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:56,0.198604,0.0
04-12 20:49:54.649+0200 W/AUL     (13299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 20:49:54.649+0200 W/AUL     (13310): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13299)
04-12 20:49:54.649+0200 I/utils   (13310): request sent to service es.ugr.frailty.servicemanager
04-12 20:49:54.649+0200 I/CAPI_APPFW_APPLICATION(13310): service_app_main.c: service_app_exit(441) > service_app_exit
04-12 20:49:54.649+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 20:49:54.659+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 13299
04-12 20:49:54.669+0200 W/AUL_AMD ( 2499): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13302
04-12 20:49:54.669+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 20:49:54.669+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 20:49:54.669+0200 E/AUL_AMD ( 2499): amd_launch.c: __real_send(909) > send fail to client
04-12 20:49:54.669+0200 W/AUL_AMD ( 2499): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(13302), cmd(0)
04-12 20:49:54.679+0200 W/CAPI_APPFW_APP_CONTROL(13302): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 20:49:54.679+0200 I/httppostreq(13302): Requesting HTTP POST Request Service. Service ID: es.ugr.frailty.accelerometer Data received: SM-R760,12/04/2018,20:48:54,0.191426,0.040678,9.810574
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:54,0.205783,0.062213,9.781858
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:54,0.220140,0.066999,9.824929
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:54,0.177069,0.028714,9.798609
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:54,0.203390,0.047856,9.781858
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.205783,0.062213,9.829715
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.157926,-0.009571,9.829715
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.167498,0.076570,9.848858
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.174676,0.062213,9.879964
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.200997,0.047856,9.832108
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.198604,-0.004786,9.863215
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.191426,0.069392,9.836893
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.196211,0.047856,9.832108
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.212961,0.062213,9.853643
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:55,0.191426,0.071785,9.817751
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:56,0.215354,0.031107,9.796216
04-12 20:49:54.679+0200 I/httppostreq(13302): SM-R760,12/04/2018,20:48:56,0.198604,0.014357,9
04-12 20:49:54.679+0200 W/AUL     (13299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13302)
04-12 20:49:54.679+0200 I/servicemanager(13299): request sent to service es.ugr.frailty.httppostreq with message: es.ugr.frailty.accelerometer and data: SM-R760,12/04/2018,20:48:54,0.191426,0.040678,9.810574
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.205783,0.062213,9.781858
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.220140,0.066999,9.824929
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.177069,0.028714,9.798609
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:54,0.203390,0.047856,9.781858
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.205783,0.062213,9.829715
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.157926,-0.009571,9.829715
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.167498,0.076570,9.848858
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.174676,0.062213,9.879964
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.200997,0.047856,9.832108
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.198604,-0.004786,9.863215
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.191426,0.069392,9.836893
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.196211,0.047856,9.832108
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.212961,0.062213,9.853643
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:55,0.191426,0.071785,9.817751
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:56,0.215354,0.031107,9.796216
04-12 20:49:54.679+0200 I/servicemanager(13299): SM-R760,12/04/2018,20:48:56,0.198604,
04-12 20:49:54.749+0200 E/PKGMGR_INFO( 2938): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-12 20:49:54.759+0200 E/PKGMGR_INFO( 2938): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-12 20:49:54.769+0200 I/utils   (13310): es.ugr.frailty.accelerometer listener destroyed
04-12 20:49:54.879+0200 W/AUL     (13331): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.httppostreq]
04-12 20:49:54.879+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 20:49:54.879+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 20:49:54.879+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 13302
04-12 20:49:54.879+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 20:49:54.889+0200 W/AUL     (13334): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 20:49:54.899+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 20:49:54.899+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 20:49:54.899+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 13310
04-12 20:49:54.899+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 20:49:54.899+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 13302
04-12 20:49:54.899+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(13302)
04-12 20:49:54.899+0200 W/CRASH_MANAGER(13329): worker.c: worker_job(1205) > 1113302687474152355899
