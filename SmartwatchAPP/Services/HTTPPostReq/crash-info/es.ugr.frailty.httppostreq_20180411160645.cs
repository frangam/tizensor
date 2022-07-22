S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: httppostreq
PID: 18325
Date: 2018-04-11 16:06:45+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/httppostreq
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2f34302e

Register Information
r0   = 0x00000000, r1   = 0xf72d6738
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x382e392c, r5   = 0x35323135
r6   = 0xf6eeda35, r7   = 0x31310a32
r8   = 0x00000041, r9   = 0xf6f8a824
r10  = 0xf73f2dd8, fp   = 0x00000000
ip   = 0x00000020, sp   = 0xff88de18
lr   = 0xf72b39f8, pc   = 0x2f34302e
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     47892 KB
Buffers:     61572 KB
Cached:     202336 KB
VmPeak:      21180 KB
VmSize:      21176 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        9100 KB
VmRSS:        9100 KB
VmData:       9636 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        9612 KB
VmPTE:          44 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18325 TID = 18325
18325 18327 

Maps Information
f5f50000 f6754000 rw-p [stack:18327]
f6754000 f6756000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f675e000 f6760000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f676a000 f677a000 r-xp /usr/lib/libmdm-common.so.1.1.24
f6782000 f6784000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f678c000 f6791000 r-xp /usr/lib/libffi.so.5.0.10
f6799000 f679a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67a2000 f67b2000 r-xp /lib/libresolv-2.13.so
f67b7000 f67cf000 r-xp /usr/lib/liblzma.so.5.0.3
f67d7000 f67d9000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67e1000 f67fb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6803000 f68cf000 r-xp /usr/lib/libxml2.so.2.7.8
f68dc000 f68de000 r-xp /usr/lib/libiniparser.so.0
f68e7000 f6930000 r-xp /usr/lib/libmdm.so.1.2.69
f6938000 f693e000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6946000 f697a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6983000 f6a56000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a61000 f6a67000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a70000 f6ae5000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6aef000 f6b58000 r-xp /lib/libm-2.13.so
f6b61000 f6b67000 r-xp /lib/librt-2.13.so
f6b70000 f6b8e000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b98000 f6b99000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ba1000 f6bc4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bcc000 f6bd1000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bd9000 f6c03000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c0c000 f6c23000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c2b000 f6c41000 r-xp /lib/libz.so.1.2.5
f6c49000 f6df2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6e12000 f6e59000 r-xp /usr/lib/libssl.so.1.0.0
f6e65000 f6e93000 r-xp /usr/lib/libidn.so.11.5.44
f6e9b000 f6ea4000 r-xp /usr/lib/libcares.so.2.1.0
f6ead000 f6eb2000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6eba000 f6f8a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f8b000 f6fa4000 r-xp /usr/lib/libnetwork.so.0.0.0
f6fac000 f6faf000 r-xp /usr/lib/libbundle.so.0.1.22
f6fb7000 f6fbd000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fc5000 f7006000 r-xp /usr/lib/libeina.so.1.7.99
f700f000 f7026000 r-xp /usr/lib/libecore.so.1.7.99
f703d000 f7046000 r-xp /usr/lib/libvconf.so.0.2.45
f704e000 f7062000 r-xp /lib/libpthread-2.13.so
f706d000 f707a000 r-xp /usr/lib/libaul.so.0.1.0
f7084000 f7086000 r-xp /lib/libdl-2.13.so
f708f000 f709a000 r-xp /lib/libunwind.so.8.0.1
f70c7000 f70cf000 r-xp /lib/libgcc_s-4.6.so.1
f70d0000 f71f4000 r-xp /lib/libc-2.13.so
f7202000 f7204000 r-xp /usr/lib/libdlog.so.0.0.0
f720c000 f7250000 r-xp /usr/lib/libcurl.so.4.3.0
f7259000 f7269000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f7271000 f7275000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f727e000 f7281000 r-xp /usr/lib/libappcore-agent.so.1.1
f729f000 f72bc000 r-xp /lib/ld-2.13.so
f72c5000 f72c7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/httppostreq
f72c7000 f72cb000 r-xp /usr/lib/libsys-assert.so
f73ee000 f7451000 rw-p [heap]
ff86e000 ff88f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18325)
Call Stack Count: 1
 0: (0x2f34302e) (null)
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
apptray edit visibility : 0
04-11 16:05:56.221+0200 W/W_HOME  ( 2761): main.c: home_pause(547) > clock/widget paused
04-11 16:05:56.221+0200 W/W_HOME  ( 2761): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-11 16:05:56.221+0200 I/MESSAGE_PORT( 2451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 16:05:56.231+0200 E/CAPI_APPFW_APP_CONTROL( 3258): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-11 16:05:56.231+0200 W/MUSIC_CONTROL_SERVICE( 3258): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3258]   [com.samsung.w-home]register msg port [false][0m
04-11 16:05:56.231+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-11 16:05:56.241+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-11 16:05:56.241+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-11 16:05:56.241+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-11 16:05:56.241+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-11 16:05:56.241+0200 W/WATCH_CORE( 2852): appcore-watch.c: __widget_pause(1113) > widget_pause
04-11 16:05:56.241+0200 W/AUL     ( 2852): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2852) status(bg) type(watchapp)
04-11 16:05:56.241+0200 E/watchface-loader( 2852): watchface-loader.cpp: OnAppPause(552) > 
04-11 16:05:56.251+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:56:264,0.236889,0.028714,9.822537
04-11 16:05:56.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:56:441,0.232104,0.040678,9.832108
04-11 16:05:56.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:56:637,0.256032,0.038285,9.786645
04-11 16:05:56.731+0200 I/APP_CORE( 2761): appcore-efl.c: __do_app(453) > [APP 2761] Event: MEM_FLUSH State: PAUSED
04-11 16:05:56.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:56:837,0.186640,0.045464,9.815358
04-11 16:05:57.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:57:37,0.217747,0.050249,9.791430
04-11 16:05:57.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:57:237,0.241675,0.069392,9.801002
04-11 16:05:57.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:57:437,0.263210,0.045464,9.791430
04-11 16:05:57.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:57:637,0.263210,0.038285,9.846465
04-11 16:05:57.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:57:837,0.258425,0.047856,9.772287
04-11 16:05:58.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:58:37,0.222532,0.095713,9.801002
04-11 16:05:58.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:58:237,0.196211,0.081356,9.815358
04-11 16:05:58.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:58:437,0.232104,0.031107,9.829715
04-11 16:05:58.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:58:637,0.222532,0.059821,9.798609
04-11 16:05:58.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:58:837,0.241675,0.050249,9.801002
04-11 16:05:59.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:59:37,0.200997,0.052642,9.841680
04-11 16:05:59.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:59:237,0.251246,0.086142,9.815358
04-11 16:05:59.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:59:437,0.227318,0.071785,9.832108
04-11 16:05:59.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:59:640,0.220140,0.066999,9.829715
04-11 16:05:59.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:05:59:837,0.220140,0.057428,9.789038
04-11 16:06:00.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:00:37,0.296710,0.031107,9.808180
04-11 16:06:00.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:00:237,0.217747,0.066999,9.817751
04-11 16:06:00.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:00:436,0.258425,0.076570,9.801002
04-11 16:06:00.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:00:637,0.229711,0.078963,9.877571
04-11 16:06:00.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:00:836,0.248854,0.052642,9.822537
04-11 16:06:01.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:01:37,0.193819,0.045464,9.832108
04-11 16:06:01.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:01:237,0.229711,0.023928,9.793823
04-11 16:06:01.241+0200 I/APP_CORE( 2761): appcore-efl.c: __do_app(453) > [APP 2761] Event: MEM_FLUSH State: PAUSED
04-11 16:06:01.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:01:436,0.215354,0.052642,9.839286
04-11 16:06:01.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:01:636,0.239282,0.043071,9.812965
04-11 16:06:01.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:01:836,0.224925,0.112463,9.793823
04-11 16:06:02.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:02:36,0.253639,0.059821,9.822537
04-11 16:06:02.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:02:236,0.217747,0.066999,9.836893
04-11 16:06:02.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:02:436,0.253639,0.059821,9.851252
04-11 16:06:02.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:02:636,0.220140,0.038285,9.827322
04-11 16:06:02.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:02:836,0.210568,0.057428,9.822537
04-11 16:06:03.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:03:36,0.239282,0.047856,9.791430
04-11 16:06:03.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:03:236,0.212961,0.052642,9.822537
04-11 16:06:03.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:03:436,0.208176,0.057428,9.865608
04-11 16:06:03.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:03:636,0.244068,0.045464,9.844072
04-11 16:06:03.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:03:836,0.253639,0.071785,9.851252
04-11 16:06:04.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:04:36,0.251246,0.066999,9.822537
04-11 16:06:04.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:04:236,0.227318,0.064606,9.829715
04-11 16:06:04.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:04:436,0.196211,0.064606,9.863215
04-11 16:06:04.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:04:635,0.234497,0.107677,9.781858
04-11 16:06:04.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:04:835,0.239282,0.031107,9.839286
04-11 16:06:05.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:05:35,0.229711,0.057428,9.820145
04-11 16:06:05.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:05:235,0.203390,0.038285,9.848858
04-11 16:06:05.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:05:435,0.234497,0.040678,9.824929
04-11 16:06:05.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:05:636,0.239282,0.023928,9.834501
04-11 16:06:05.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:05:835,0.205783,-0.004786,9.839286
04-11 16:06:06.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:06:35,0.224925,0.045464,9.858429
04-11 16:06:06.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:06:235,0.203390,0.102891,9.779467
04-11 16:06:06.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:06:435,0.253639,0.047856,9.812965
04-11 16:06:06.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:06:635,0.229711,0.062213,9.836893
04-11 16:06:06.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:06:835,0.222532,0.074178,9.834501
04-11 16:06:07.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:07:35,0.239282,0.050249,9.863215
04-11 16:06:07.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:07:235,0.258425,0.064606,9.841680
04-11 16:06:07.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:07:435,0.217747,0.047856,9.829715
04-11 16:06:07.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:07:635,0.227318,0.038285,9.836893
04-11 16:06:07.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:07:835,0.260818,0.014357,9.858429
04-11 16:06:08.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:08:35,0.260818,0.052642,9.846465
04-11 16:06:08.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:08:234,0.212961,0.086142,9.827322
04-11 16:06:08.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:08:435,0.220140,0.047856,9.832108
04-11 16:06:08.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:08:634,0.208176,0.035892,9.882358
04-11 16:06:08.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:08:834,0.205783,0.062213,9.801002
04-11 16:06:09.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:09:34,0.200997,0.112463,9.832108
04-11 16:06:09.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:09:234,0.212961,0.055035,9.879964
04-11 16:06:09.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:09:434,0.260818,0.112463,9.793823
04-11 16:06:09.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:09:634,0.169890,0.050249,9.808180
04-11 16:06:09.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:09:834,0.232104,0.062213,9.812965
04-11 16:06:10.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:10:34,0.227318,0.045464,9.803394
04-11 16:06:10.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:10:234,0.208176,0.102891,9.820145
04-11 16:06:10.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:10:434,0.220140,0.062213,9.834501
04-11 16:06:10.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:10:634,0.236889,0.081356,9.832108
04-11 16:06:10.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:10:834,0.246461,0.066999,9.805787
04-11 16:06:11.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:11:34,0.282353,0.028714,9.872787
04-11 16:06:11.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:11:234,0.229711,0.009571,9.884750
04-11 16:06:11.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:11:434,0.239282,0.062213,9.958927
04-11 16:06:11.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:11:634,0.229711,0.023928,9.777073
04-11 16:06:11.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:11:833,0.253639,0.026321,9.700503
04-11 16:06:12.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:12:34,0.205783,0.071785,9.820145
04-11 16:06:12.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:12:234,0.236889,0.047856,9.841680
04-11 16:06:12.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:12:433,0.251246,0.133998,9.882358
04-11 16:06:12.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:12:634,0.227318,0.131605,9.899107
04-11 16:06:12.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:12:833,0.227318,0.019143,9.841680
04-11 16:06:13.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:13:33,0.179462,0.126820,9.896714
04-11 16:06:13.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:13:233,0.244068,0.019143,9.851252
04-11 16:06:13.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:13:433,0.232104,0.043071,9.841680
04-11 16:06:13.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:13:633,0.212961,0.047856,9.827322
04-11 16:06:13.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:13:833,0.186640,0.117248,9.736395
04-11 16:06:14.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:14:33,0.251246,0.074178,9.853643
04-11 16:06:14.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:14:233,0.208176,0.023928,9.805787
04-11 16:06:14.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:14:433,0.196211,0.047856,9.851252
04-11 16:06:14.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:14:633,0.232104,0.086142,9.889536
04-11 16:06:14.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:14:833,0.246461,0.093320,9.834501
04-11 16:06:15.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:15:33,0.229711,0.083749,9.824929
04-11 16:06:15.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:15:233,0.208176,0.055035,9.853643
04-11 16:06:15.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:15:433,0.236889,0.043071,9.810574
04-11 16:06:15.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:15:633,0.224925,0.071785,9.875179
04-11 16:06:15.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:15:833,0.251246,0.083749,9.822537
04-11 16:06:16.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:16:32,0.191426,0.066999,9.832108
04-11 16:06:16.231+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:16:233,0.210568,0.035892,9.820145
04-11 16:06:16.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:16:433,0.234497,0.069392,9.755538
04-11 16:06:16.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:16:632,0.244068,0.083749,9.822537
04-11 16:06:16.831+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:16:832,0.244068,0.064606,9.863215
04-11 16:06:17.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:17:32,0.236889,0.071785,9.844072
04-11 16:06:17.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:17:232,0.253639,0.038285,9.812965
04-11 16:06:17.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:17:432,0.208176,0.033500,9.858429
04-11 16:06:17.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:17:632,0.217747,0.040678,9.820145
04-11 16:06:17.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:17:832,0.224925,0.086142,9.822537
04-11 16:06:18.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:18:32,0.220140,0.057428,9.834501
04-11 16:06:18.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:18:232,0.246461,0.086142,9.798609
04-11 16:06:18.431+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:18:432,0.251246,0.050249,9.817751
04-11 16:06:18.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:18:632,0.224925,0.038285,9.815358
04-11 16:06:18.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:18:832,0.224925,0.062213,9.796216
04-11 16:06:19.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:19:32,0.241675,0.038285,9.846465
04-11 16:06:19.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:19:232,0.222532,0.059821,9.836893
04-11 16:06:19.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:19:432,0.258425,0.074178,9.848858
04-11 16:06:19.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:19:632,0.210568,0.088534,9.789038
04-11 16:06:19.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:19:832,0.239282,0.066999,9.839286
04-11 16:06:20.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:20:32,0.210568,0.088534,9.839286
04-11 16:06:20.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:20:231,0.205783,0.062213,9.832108
04-11 16:06:20.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:20:431,0.224925,0.028714,9.853643
04-11 16:06:20.631+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:20:633,0.232104,0.088534,9.767502
04-11 16:06:20.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:20:831,0.251246,0.014357,9.844072
04-11 16:06:21.031+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:21:32,0.191426,0.090927,9.834501
04-11 16:06:21.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:21:231,0.212961,0.107677,9.839286
04-11 16:06:21.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:21:431,0.227318,0.038285,9.836893
04-11 16:06:21.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:21:632,0.239282,0.110070,9.822537
04-11 16:06:21.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:21:831,0.258425,0.078963,9.815358
04-11 16:06:22.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:22:31,0.227318,0.043071,9.798609
04-11 16:06:22.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:22:231,0.200997,0.126820,9.808180
04-11 16:06:22.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:22:431,0.234497,0.078963,9.829715
04-11 16:06:22.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:22:631,0.234497,-0.007178,9.801002
04-11 16:06:22.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:22:831,0.212961,0.057428,9.865608
04-11 16:06:23.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:23:31,0.272782,0.062213,9.779467
04-11 16:06:23.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:23:230,0.248854,0.038285,9.868000
04-11 16:06:23.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:23:431,0.198604,0.069392,9.789038
04-11 16:06:23.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:23:631,0.220140,0.062213,9.832108
04-11 16:06:23.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:23:831,0.227318,0.078963,9.832108
04-11 16:06:24.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:24:31,0.208176,0.052642,9.805787
04-11 16:06:24.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:24:230,0.220140,0.078963,9.846465
04-11 16:06:24.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:24:430,0.227318,0.078963,9.817751
04-11 16:06:24.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:24:630,0.205783,0.081356,9.834501
04-11 16:06:24.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:24:830,0.234497,0.071785,9.829715
04-11 16:06:25.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:25:30,0.227318,0.057428,9.812965
04-11 16:06:25.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:25:230,0.208176,0.124427,9.834501
04-11 16:06:25.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:25:430,0.203390,0.086142,9.872787
04-11 16:06:25.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:25:630,0.232104,0.066999,9.827322
04-11 16:06:25.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:25:830,0.224925,0.083749,9.808180
04-11 16:06:26.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:26:30,0.184247,0.047856,9.822537
04-11 16:06:26.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:26:230,0.189033,0.033500,9.789038
04-11 16:06:26.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:26:430,0.215354,0.078963,9.714860
04-11 16:06:26.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:26:630,0.251246,0.040678,9.841680
04-11 16:06:26.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:26:830,0.210568,0.093320,9.796216
04-11 16:06:27.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:27:30,0.251246,0.062213,9.836893
04-11 16:06:27.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:27:230,0.198604,0.057428,9.839286
04-11 16:06:27.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:27:430,0.263210,0.007178,9.860823
04-11 16:06:27.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:27:630,0.193819,0.090927,9.789038
04-11 16:06:27.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:27:830,0.251246,0.014357,9.805787
04-11 16:06:28.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:28:29,0.222532,0.055035,9.839286
04-11 16:06:28.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:28:230,0.258425,0.078963,9.858429
04-11 16:06:28.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:28:430,0.179462,0.098106,9.815358
04-11 16:06:28.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:28:629,0.256032,0.093320,9.820145
04-11 16:06:28.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:28:829,0.222532,0.066999,9.817751
04-11 16:06:29.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:29:29,0.241675,0.081356,9.860823
04-11 16:06:29.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:29:229,0.232104,0.009571,9.829715
04-11 16:06:29.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:29:429,0.258425,0.078963,9.846465
04-11 16:06:29.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:29:629,0.227318,0.098106,9.815358
04-11 16:06:29.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:29:829,0.229711,0.059821,9.810574
04-11 16:06:30.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:30:29,0.181855,0.083749,9.836893
04-11 16:06:30.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:30:229,0.227318,0.071785,9.848858
04-11 16:06:30.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:30:429,0.256032,0.059821,9.915856
04-11 16:06:30.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:30:629,0.234497,0.035892,9.789038
04-11 16:06:30.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:30:829,0.239282,0.023928,9.863215
04-11 16:06:31.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:31:29,0.229711,0.081356,9.822537
04-11 16:06:31.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:31:229,0.217747,0.076570,9.834501
04-11 16:06:31.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:31:429,0.239282,0.062213,9.820145
04-11 16:06:31.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:31:629,0.208176,0.078963,9.829715
04-11 16:06:31.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:31:829,0.224925,0.047856,9.846465
04-11 16:06:32.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:32:29,0.234497,0.076570,9.824929
04-11 16:06:32.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:32:228,0.236889,0.071785,9.834501
04-11 16:06:32.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:32:429,0.229711,0.078963,9.856036
04-11 16:06:32.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:32:628,0.222532,0.059821,9.817751
04-11 16:06:32.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:32:828,0.229711,0.035892,9.846465
04-11 16:06:33.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:33:29,0.217747,0.076570,9.815358
04-11 16:06:33.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:33:228,0.244068,0.062213,9.805787
04-11 16:06:33.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:33:428,0.241675,0.110070,9.927821
04-11 16:06:33.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:33:628,0.260818,0.059821,9.834501
04-11 16:06:33.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:33:828,0.184247,0.098106,9.836893
04-11 16:06:34.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:34:28,0.239282,0.045464,9.839286
04-11 16:06:34.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:34:228,0.222532,0.064606,9.868000
04-11 16:06:34.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:34:428,0.227318,0.055035,9.832108
04-11 16:06:34.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:34:628,0.229711,0.059821,9.822537
04-11 16:06:34.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:34:828,0.260818,0.064606,9.832108
04-11 16:06:35.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:35:28,0.208176,0.057428,9.812965
04-11 16:06:35.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:35:228,0.260818,0.009571,9.808180
04-11 16:06:35.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:35:428,0.239282,0.026321,9.817751
04-11 16:06:35.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:35:628,0.239282,0.078963,9.822537
04-11 16:06:35.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:35:828,0.208176,0.033500,9.810574
04-11 16:06:36.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:36:28,0.229711,0.095713,9.834501
04-11 16:06:36.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:36:228,0.205783,0.102891,9.856036
04-11 16:06:36.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:36:427,0.256032,0.064606,9.853643
04-11 16:06:36.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:36:628,0.260818,0.076570,9.829715
04-11 16:06:36.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:36:827,0.236889,0.035892,9.853643
04-11 16:06:37.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:37:28,0.210568,0.102891,9.848858
04-11 16:06:37.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:37:228,0.241675,0.026321,9.822537
04-11 16:06:37.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:37:427,0.212961,0.028714,9.851252
04-11 16:06:37.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:37:627,0.222532,0.064606,9.817751
04-11 16:06:37.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:37:827,0.236889,0.074178,9.827322
04-11 16:06:38.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:38:27,0.244068,0.052642,9.860823
04-11 16:06:38.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:38:227,0.200997,0.062213,9.846465
04-11 16:06:38.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:38:427,0.189033,0.074178,9.834501
04-11 16:06:38.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:38:627,0.174676,0.074178,9.856036
04-11 16:06:38.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:38:827,0.258425,0.095713,9.834501
04-11 16:06:39.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:39:27,0.236889,0.081356,9.805787
04-11 16:06:39.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:39:227,0.205783,0.052642,9.856036
04-11 16:06:39.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:39:427,0.232104,0.050249,9.779467
04-11 16:06:39.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:39:627,0.232104,0.093320,9.815358
04-11 16:06:39.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:39:827,0.227318,0.038285,9.844072
04-11 16:06:40.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:40:27,0.244068,0.076570,9.786645
04-11 16:06:40.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:40:227,0.208176,0.064606,9.836893
04-11 16:06:40.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:40:427,0.236889,0.038285,9.824929
04-11 16:06:40.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:40:626,0.248854,0.064606,9.860823
04-11 16:06:40.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:40:827,0.222532,0.098106,9.832108
04-11 16:06:41.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:41:26,0.267996,0.076570,9.851252
04-11 16:06:41.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:41:226,0.224925,0.057428,9.832108
04-11 16:06:41.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:41:427,0.248854,0.045464,9.839286
04-11 16:06:41.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:41:627,0.220140,0.066999,9.863215
04-11 16:06:41.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:41:826,0.222532,0.062213,9.793823
04-11 16:06:42.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:42:26,0.222532,0.023928,9.851252
04-11 16:06:42.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:42:226,0.234497,0.071785,9.834501
04-11 16:06:42.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:42:426,0.227318,0.083749,9.829715
04-11 16:06:42.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:42:626,0.246461,0.050249,9.798609
04-11 16:06:42.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:42:826,0.229711,0.035892,9.803394
04-11 16:06:43.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:43:26,0.265603,0.071785,9.834501
04-11 16:06:43.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:43:226,0.222532,0.059821,9.801002
04-11 16:06:43.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:43:426,0.220140,0.069392,9.824929
04-11 16:06:43.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:43:626,0.215354,0.088534,9.824929
04-11 16:06:43.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:43:826,0.246461,0.055035,9.805787
04-11 16:06:44.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:44:26,0.222532,0.055035,9.841680
04-11 16:06:44.221+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:44:225,0.220140,0.074178,9.815358
04-11 16:06:44.421+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:44:426,0.198604,0.076570,9.868000
04-11 16:06:44.621+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:44:626,0.227318,0.083749,9.848858
04-11 16:06:44.821+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:44:825,0.239282,0.057428,9.868000
04-11 16:06:45.021+0200 I/accelerometer(18333): accelerometer: 11/04/2018,16:06:45:26,0.229711,0.055035,9.853643
04-11 16:06:45.101+0200 I/servicemanager(18322): accelerometer sleep timeout
04-11 16:06:45.101+0200 W/AUL     (18322): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-11 16:06:45.101+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(669) > __request_handler: 0
04-11 16:06:45.101+0200 W/AUL_AMD ( 2475): amd_launch.c: _start_app(1782) > caller pid : 18322
04-11 16:06:45.121+0200 W/AUL_AMD ( 2475): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18333
04-11 16:06:45.131+0200 W/AUL     (18322): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18333)
04-11 16:06:45.131+0200 I/servicemanager(18322): es.ugr.frailty.accelerometer stop request sent!
04-11 16:06:45.131+0200 I/servicemanager(18322): App control destroyed.
04-11 16:06:45.131+0200 E/AUL_AMD ( 2475): amd_launch.c: __real_send(909) > send fail to client
04-11 16:06:45.131+0200 W/AUL_AMD ( 2475): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(18333), cmd(0)
04-11 16:06:45.131+0200 I/accelerometer(18333): Stopping accelerometer service
04-11 16:06:45.131+0200 W/AUL     (18333): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-11 16:06:45.131+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(669) > __request_handler: 0
04-11 16:06:45.141+0200 W/AUL_AMD ( 2475): amd_launch.c: _start_app(1782) > caller pid : 18333
04-11 16:06:45.151+0200 W/AUL_AMD ( 2475): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18322
04-11 16:06:45.161+0200 E/AUL_AMD ( 2475): amd_launch.c: __real_send(909) > send fail to client
04-11 16:06:45.161+0200 W/AUL_AMD ( 2475): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(18322), cmd(0)
04-11 16:06:45.161+0200 W/CAPI_APPFW_APP_CONTROL(18322): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 16:06:45.161+0200 I/servicemanager(18322): Requesting Record Service. Service ID: es.ugr.frailty.accelerometer
04-11 16:06:45.161+0200 I/servicemanager(18322): Requesting Record Service. Data received: 11/04/2018,16:05:45:101,0.217747,0.105284,9.827322
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:45:201,0.232104,0.055035,9.801002
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:45:301,0.241675,0.066999,9.844072
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:45:401,0.275175,0.074178,9.798609
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:45:501,0.260818,0.057428,9.820145
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:45:601,0.244068,0.081356,9.832108
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:45:701,0.227318,0.078963,9.786645
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:45:802,0.244068,0.076570,9.815358
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:45:901,0.212961,0.078963,9.817751
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:3,0.275175,0.066999,9.760324
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:101,0.241675,0.057428,9.846465
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:201,0.239282,0.050249,9.815358
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:301,0.215354,0.040678,9.801002
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:401,0.227318,0.083749,9.827322
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:501,0.258425,0.055035,9.832108
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:601,0.208176,0.055035,9.810574
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:701,0.246461,0.078963,9.796216
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:800,0.210568,0.045464,9.793823
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:05:46:901,0.251246,0.078963,9.803394
04-11 16:06:45.161+0200 I/servicemanager(18322): 11/04/2018,16:
04-11 16:06:45.161+0200 W/AUL     (18322): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-11 16:06:45.161+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(669) > __request_handler: 0
04-11 16:06:45.171+0200 W/AUL_AMD ( 2475): amd_launch.c: _start_app(1782) > caller pid : 18322
04-11 16:06:45.181+0200 W/AUL_AMD ( 2475): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18326
04-11 16:06:45.191+0200 E/AUL_AMD ( 2475): amd_launch.c: __real_send(909) > send fail to client
04-11 16:06:45.191+0200 W/AUL_AMD ( 2475): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(18326), cmd(0)
04-11 16:06:45.191+0200 W/CAPI_APPFW_APP_CONTROL(18326): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 16:06:45.191+0200 I/recorder(18326): Requesting Record Service. Service ID: es.ugr.frailty.accelerometer
04-11 16:06:45.191+0200 I/recorder(18326): Requesting Record Service. Data received: 11/04/2018,16:05:45:101,0.217747,0.105284,9.827322
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:45:201,0.232104,0.055035,9.801002
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:45:301,0.241675,0.066999,9.844072
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:45:401,0.275175,0.074178,9.798609
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:45:501,0.260818,0.057428,9.820145
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:45:601,0.244068,0.081356,9.832108
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:45:701,0.227318,0.078963,9.786645
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:45:802,0.244068,0.076570,9.815358
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:45:901,0.212961,0.078963,9.817751
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:3,0.275175,0.066999,9.760324
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:101,0.241675,0.057428,9.846465
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:201,0.239282,0.050249,9.815358
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:301,0.215354,0.040678,9.801002
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:401,0.227318,0.083749,9.827322
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:501,0.258425,0.055035,9.832108
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:601,0.208176,0.055035,9.810574
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:701,0.246461,0.078963,9.796216
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:800,0.210568,0.045464,9.793823
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:05:46:901,0.251246,0.078963,9.803394
04-11 16:06:45.191+0200 I/recorder(18326): 11/04/2018,16:
04-11 16:06:45.191+0200 W/AUL     (18322): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18326)
04-11 16:06:45.191+0200 I/servicemanager(18322): request sent to service es.ugr.frailty.recorder with message: es.ugr.frailty.accelerometer and data: 11/04/2018,16:05:45:101,0.217747,0.105284,9.827322
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:45:201,0.232104,0.055035,9.801002
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:45:301,0.241675,0.066999,9.844072
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:45:401,0.275175,0.074178,9.798609
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:45:501,0.260818,0.057428,9.820145
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:45:601,0.244068,0.081356,9.832108
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:45:701,0.227318,0.078963,9.786645
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:45:802,0.244068,0.076570,9.815358
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:45:901,0.212961,0.078963,9.817751
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:46:3,0.275175,0.066999,9.760324
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:46:101,0.241675,0.057428,9.846465
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:46:201,0.239282,0.050249,9.815358
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:46:301,0.215354,0.040678,9.801002
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:46:401,0.227318,0.083749,9.827322
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:46:501,0.258425,0.055035,9.832108
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:46:601,0.208176,0.055035,9.810574
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:46:701,0.246461,0.078963,9.796216
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/2018,16:05:46:800,0.210568,0.045464,9.793823
04-11 16:06:45.191+0200 I/servicemanager(18322): 11/04/
04-11 16:06:45.191+0200 W/AUL     (18322): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-11 16:06:45.201+0200 W/AUL     (18333): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18322)
04-11 16:06:45.201+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(669) > __request_handler: 0
04-11 16:06:45.201+0200 I/accelerometer(18333): request sent to service es.ugr.frailty.servicemanager
04-11 16:06:45.201+0200 I/CAPI_APPFW_APPLICATION(18333): service_app_main.c: service_app_exit(441) > service_app_exit
04-11 16:06:45.201+0200 W/AUL_AMD ( 2475): amd_launch.c: _start_app(1782) > caller pid : 18322
04-11 16:06:45.211+0200 W/AUL_AMD ( 2475): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18325
04-11 16:06:45.221+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(669) > __request_handler: 22
04-11 16:06:45.221+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(999) > app status : 4
04-11 16:06:45.221+0200 E/AUL_AMD ( 2475): amd_launch.c: __real_send(909) > send fail to client
04-11 16:06:45.221+0200 W/AUL_AMD ( 2475): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(18325), cmd(0)
04-11 16:06:45.221+0200 W/CAPI_APPFW_APP_CONTROL(18325): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 16:06:45.221+0200 I/httppostreq(18325): Requesting HTTP POST Request Service. Service ID: es.ugr.frailty.accelerometer Data received: 11/04/2018,16:05:45:101,0.217747,0.105284,9.827322
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:45:201,0.232104,0.055035,9.801002
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:45:301,0.241675,0.066999,9.844072
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:45:401,0.275175,0.074178,9.798609
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:45:501,0.260818,0.057428,9.820145
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:45:601,0.244068,0.081356,9.832108
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:45:701,0.227318,0.078963,9.786645
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:45:802,0.244068,0.076570,9.815358
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:45:901,0.212961,0.078963,9.817751
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:46:3,0.275175,0.066999,9.760324
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:46:101,0.241675,0.057428,9.846465
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:46:201,0.239282,0.050249,9.815358
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:46:301,0.215354,0.040678,9.801002
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:46:401,0.227318,0.083749,9.827322
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:46:501,0.258425,0.055035,9.832108
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:46:601,0.208176,0.055035,9.810574
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:46:701,0.246461,0.078963,9.796216
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16:05:46:800,0.210568,0.045464,9.793823
04-11 16:06:45.221+0200 I/httppostreq(18325): 11/04/2018,16
04-11 16:06:45.221+0200 W/AUL     (18322): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18325)
04-11 16:06:45.221+0200 I/servicemanager(18322): request sent to service es.ugr.frailty.httppostreq with message: es.ugr.frailty.accelerometer and data: 11/04/2018,16:05:45:101,0.217747,0.105284,9.827322
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:45:201,0.232104,0.055035,9.801002
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:45:301,0.241675,0.066999,9.844072
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:45:401,0.275175,0.074178,9.798609
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:45:501,0.260818,0.057428,9.820145
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:45:601,0.244068,0.081356,9.832108
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:45:701,0.227318,0.078963,9.786645
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:45:802,0.244068,0.076570,9.815358
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:45:901,0.212961,0.078963,9.817751
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:46:3,0.275175,0.066999,9.760324
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:46:101,0.241675,0.057428,9.846465
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:46:201,0.239282,0.050249,9.815358
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:46:301,0.215354,0.040678,9.801002
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:46:401,0.227318,0.083749,9.827322
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:46:501,0.258425,0.055035,9.832108
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:46:601,0.208176,0.055035,9.810574
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:46:701,0.246461,0.078963,9.796216
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/04/2018,16:05:46:800,0.210568,0.045464,9.793823
04-11 16:06:45.221+0200 I/servicemanager(18322): 11/
04-11 16:06:45.251+0200 E/PKGMGR_INFO( 2976): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-11 16:06:45.271+0200 E/PKGMGR_INFO( 2976): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-11 16:06:45.281+0200 I/accelerometer(18333): accelerometer listener destroyed.
04-11 16:06:45.411+0200 W/AUL     (18352): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-11 16:06:45.411+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 16:06:45.421+0200 W/AUL_AMD ( 2475): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 16:06:45.421+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 18333
04-11 16:06:45.421+0200 W/AUL_AMD ( 2475): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 16:06:45.431+0200 I/AUL_AMD ( 2475): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18333
04-11 16:06:45.431+0200 W/AUL     ( 2475): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(18333)
04-11 16:06:45.501+0200 W/AUL     (18354): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.httppostreq]
04-11 16:06:45.501+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 16:06:45.501+0200 W/AUL_AMD ( 2475): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 16:06:45.501+0200 W/AUL_AMD ( 2475): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 18325
04-11 16:06:45.501+0200 W/AUL_AMD ( 2475): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 16:06:45.511+0200 I/AUL_AMD ( 2475): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18325
04-11 16:06:45.511+0200 W/AUL     ( 2475): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(18325)
04-11 16:06:45.611+0200 W/CRASH_MANAGER(18356): worker.c: worker_job(1205) > 1118325687474152345560
