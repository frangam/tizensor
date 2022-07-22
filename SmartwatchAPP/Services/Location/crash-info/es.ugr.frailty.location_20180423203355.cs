S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10164
Date: 2018-04-23 20:33:55+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72ee52d, r5   = 0xf78cdf98
r6   = 0xfffb8ad0, r7   = 0xfffb8980
r8   = 0xf78cac18, r9   = 0x00000000
r10  = 0xfffb8a5c, fp   = 0xfffb8ad0
ip   = 0x00000001, sp   = 0xfffb8958
lr   = 0xf72ee539, pc   = 0xf7357228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    136820 KB
Buffers:     36588 KB
Cached:     155764 KB
VmPeak:      53548 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12028 KB
VmRSS:       12028 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10164 TID = 10164
10164 10194 

Maps Information
f41b9000 f49b8000 rw-p [stack:10194]
f49bf000 f49c1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49c9000 f49cd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49d6000 f49d8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49e0000 f49e3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49f2000 f49f7000 r-xp /usr/lib/libsystem.so.0.0.0
f4a02000 f4a05000 r-xp /lib/libattr.so.1.1.0
f4a0d000 f4a1d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a25000 f4a2e000 r-xp /usr/lib/libedbus.so.1.7.99
f4a36000 f4a37000 r-xp /usr/lib/libresponse.so.0.2.96
f4a40000 f4a45000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62e7000 f63ed000 r-xp /usr/lib/libicuuc.so.57.1
f6403000 f658b000 r-xp /usr/lib/libicui18n.so.57.1
f659b000 f65a8000 r-xp /usr/lib/libail.so.0.1.0
f65b1000 f65b8000 r-xp /usr/lib/libminizip.so.1.0.0
f65c1000 f676a000 r-xp /usr/lib/libcrypto.so.1.0.0
f678a000 f67d1000 r-xp /usr/lib/libssl.so.1.0.0
f67dd000 f67df000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67e7000 f67ee000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67f7000 f67fe000 r-xp /lib/libcrypt-2.13.so
f682f000 f6832000 r-xp /lib/libcap.so.2.21
f683a000 f683c000 r-xp /usr/lib/libiri.so
f6844000 f688d000 r-xp /usr/lib/libmdm.so.1.2.69
f6895000 f689b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68a3000 f68c6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68d0000 f68d2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68da000 f68f7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6900000 f6904000 r-xp /usr/lib/libsmack.so.1.0.0
f690d000 f6926000 r-xp /usr/lib/libnetwork.so.0.0.0
f692f000 f6937000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f693f000 f6945000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f694e000 f6950000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6959000 f6969000 r-xp /lib/libresolv-2.13.so
f696d000 f6985000 r-xp /usr/lib/liblzma.so.5.0.3
f698e000 f6990000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6998000 f69b2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69ba000 f69e9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69f2000 f6a01000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a0b000 f6a15000 r-xp /usr/lib/libsensord-shared.so
f6a1e000 f6af1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6afc000 f6b12000 r-xp /lib/libz.so.1.2.5
f6b1a000 f6b1f000 r-xp /usr/lib/libffi.so.5.0.10
f6b27000 f6b28000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b30000 f6b40000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b48000 f6b61000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b69000 f6b6b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b73000 f6be8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bf2000 f6bf8000 r-xp /lib/librt-2.13.so
f6c01000 f6c1f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c29000 f6c2a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c32000 f6c55000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c5d000 f6c62000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c6a000 f6c94000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c9d000 f6cb4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cbc000 f6d25000 r-xp /lib/libm-2.13.so
f6d2e000 f6dc2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6dd5000 f6dda000 r-xp /usr/lib/libctx-client.so.0.8.3
f6de2000 f6de9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6df1000 f6e1b000 r-xp /usr/lib/libsensor.so.1.9.6
f6e24000 f6ef0000 r-xp /usr/lib/libxml2.so.2.7.8
f6efd000 f6eff000 r-xp /usr/lib/libiniparser.so.0
f6f08000 f6f0e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f17000 f6fe7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fe8000 f701c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7025000 f7061000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7069000 f706c000 r-xp /usr/lib/libbundle.so.0.1.22
f7074000 f707a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7082000 f70c3000 r-xp /usr/lib/libeina.so.1.7.99
f70cc000 f70e3000 r-xp /usr/lib/libecore.so.1.7.99
f70fa000 f7103000 r-xp /usr/lib/libvconf.so.0.2.45
f710b000 f711f000 r-xp /lib/libpthread-2.13.so
f712a000 f7137000 r-xp /usr/lib/libaul.so.0.1.0
f7141000 f7143000 r-xp /lib/libdl-2.13.so
f714c000 f7157000 r-xp /lib/libunwind.so.8.0.1
f7184000 f718c000 r-xp /lib/libgcc_s-4.6.so.1
f718d000 f72b1000 r-xp /lib/libc-2.13.so
f72bf000 f72c1000 r-xp /usr/lib/libdlog.so.0.0.0
f72c9000 f72d5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72de000 f72e3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72eb000 f72fa000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7302000 f7306000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f730f000 f7312000 r-xp /usr/lib/libappcore-agent.so.1.1
f731a000 f731c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7324000 f7328000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7330000 f734d000 r-xp /lib/ld-2.13.so
f7356000 f7359000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7359000 f735d000 r-xp /usr/lib/libsys-assert.so
f789a000 f7923000 rw-p [heap]
fff9a000 fffbb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10164)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7357228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72ee539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ff53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ff3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fffe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7005be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7005dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf703a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70351f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ff3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fffe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7005be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7005dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7037e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7038017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf703ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49d71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49ca171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a9d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f4afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f4c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70dcca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70d7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70d85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70d8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7310183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73107fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf735753f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf71a485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7356f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
:55.059+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:33:55.059+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:33:55.069+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.338310] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.079+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:60,-0.070000,-0.070000,0.140000
04-23 20:33:55.079+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.079+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.079+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:88,0.070000,0.140000,0.140000
04-23 20:33:55.089+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.089+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:33:55.089+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:33:55.089+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:59,-0.031027,0.018215,-0.009407
04-23 20:33:55.089+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.089+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:91,-0.016750,9.789038,0.844666
04-23 20:33:55.089+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.099+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:93,0.070000,0.070000,0.070000
04-23 20:33:55.099+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.365966] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.099+0200 W/SHealthService( 3097): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 20:33:55.099+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.109+0200 W/SHealthService( 3097): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 20:33:55.109+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.109+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:113,-0.022692,0.001743,-0.058082
04-23 20:33:55.119+0200 W/SHealthCommon( 3097): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1524441600000,000000[0;m
04-23 20:33:55.119+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:120,0.016750,9.786645,0.854238
04-23 20:33:55.119+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:99,0.044342,9.767972,0.868990
04-23 20:33:55.119+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.119+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.129+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.398183] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.129+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.139+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:115,0.070000,0.070000,-0.070000
04-23 20:33:55.139+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.139+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:130,-0.033853,0.020992,-0.040166
04-23 20:33:55.139+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:129,0.044118,9.768353,0.864699
04-23 20:33:55.149+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.149+0200 W/SHealthCommon( 3097): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-23 20:33:55.149+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.149+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:154,0.043866,9.768263,0.865738
04-23 20:33:55.149+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:145,0.070000,0.070000,0.070000
04-23 20:33:55.149+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.149+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:158,-0.001271,0.021066,-0.053037
04-23 20:33:55.149+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:143,0.023928,9.769895,0.808774
04-23 20:33:55.159+0200 I/HealthDataService( 2920): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 20:33:55.159+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:159,0.070000,0.070000,0.070000
04-23 20:33:55.159+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.159+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.169+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:165,0.070000,0.070000,0.070000
04-23 20:33:55.169+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.169+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.433833] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.169+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:175,-0.070000,0.070000,0.070000
04-23 20:33:55.169+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.179+0200 I/healthData( 3097): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 20:33:55.179+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:166,0.011964,9.789038,0.827917
04-23 20:33:55.179+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.179+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:181,-0.070000,0.140000,0.070000
04-23 20:33:55.179+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.189+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.189+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.189+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:191,0.043071,9.789038,0.815953
04-23 20:33:55.189+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.189+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:195,-0.008226,0.020684,-0.012854
04-23 20:33:55.189+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.189+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:196,0.035892,9.789038,0.851845
04-23 20:33:55.189+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:33:55.189+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:33:55.199+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.466300] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.199+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.199+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:194,0.043967,9.768540,0.862598
04-23 20:33:55.199+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.209+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:192,-0.070000,-0.070000,0.070000
04-23 20:33:55.209+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.209+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:211,0.043071,9.810574,0.777667
04-23 20:33:55.209+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.209+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:218,0.045464,9.805787,0.856631
04-23 20:33:55.209+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:212,0.044170,9.768452,0.863583
04-23 20:33:55.209+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.219+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.219+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:223,0.043071,9.789038,0.803988
04-23 20:33:55.219+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.219+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:214,-0.070000,-0.070000,0.070000
04-23 20:33:55.219+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.229+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:229,0.052642,9.817751,0.859023
04-23 20:33:55.229+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:198,-0.000795,0.042311,-0.088071
04-23 20:33:55.229+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.239+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.500304] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.239+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.239+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:222,0.044264,9.768563,0.862324
04-23 20:33:55.239+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.239+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:244,0.019143,9.767502,0.782453
04-23 20:33:55.239+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.239+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:235,0.001496,0.037247,-0.005968
04-23 20:33:55.249+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:232,-0.070000,-0.070000,0.070000
04-23 20:33:55.249+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.249+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:251,0.023928,9.815358,0.878166
04-23 20:33:55.249+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.249+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.249+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:255,0.038285,9.777073,0.796810
04-23 20:33:55.249+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.259+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:260,0.059821,9.810574,0.796810
04-23 20:33:55.259+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:257,-0.001099,0.020586,-0.059595
04-23 20:33:55.259+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.259+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:249,0.044787,9.768446,0.863624
04-23 20:33:55.259+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.259+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:254,0.070000,-0.140000,0.070000
04-23 20:33:55.259+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.269+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.534139] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.269+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.269+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:265,0.008378,0.049188,-0.003301
04-23 20:33:55.269+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.269+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:270,0.070000,-0.140000,0.070000
04-23 20:33:55.279+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.279+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:278,0.064606,9.829715,0.760918
04-23 20:33:55.279+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:266,0.043711,9.768545,0.862550
04-23 20:33:55.279+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:279,-0.025645,-0.000944,-0.081171
04-23 20:33:55.279+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.279+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.289+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:33:55.289+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:287,0.070000,-0.140000,0.070000
04-23 20:33:55.289+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:33:55.289+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.289+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:292,-0.019783,0.046813,0.015616
04-23 20:33:55.289+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.289+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:298,-0.004653,0.008750,-0.068292
04-23 20:33:55.299+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.299+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.299+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.567775] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.309+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:292,0.066999,9.796216,0.827917
04-23 20:33:55.309+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:309,0.070000,-0.140000,0.070000
04-23 20:33:55.309+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.309+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:303,0.016943,0.042099,-0.066587
04-23 20:33:55.309+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.309+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:297,0.042939,9.768323,0.865102
04-23 20:33:55.309+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.309+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:317,0.023928,9.815358,0.815953
04-23 20:33:55.309+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:316,0.020758,0.060944,-0.099067
04-23 20:33:55.309+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.319+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:322,0.021983,0.026952,-0.026392
04-23 20:33:55.319+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.319+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:322,0.042878,9.768475,0.863397
04-23 20:33:55.319+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.319+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.319+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.319+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:329,0.070000,0.070000,0.140000
04-23 20:33:55.329+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:326,-0.022286,0.046000,-0.037213
04-23 20:33:55.339+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.600877] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.339+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.349+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.349+0200 I/servicemanager(10115): es.ugr.frailty.location sleep timeout
04-23 20:33:55.349+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:33:55.359+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:330,0.064606,9.784252,0.835095
04-23 20:33:55.359+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:331,0.043848,9.768771,0.859985
04-23 20:33:55.359+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:33:55.359+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:33:55.369+0200 W/LOCATION(10164): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:33:55.369+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10164
04-23 20:33:55.379+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10164)
04-23 20:33:55.379+0200 I/servicemanager(10115): es.ugr.frailty.location stop request sent!
04-23 20:33:55.379+0200 I/servicemanager(10115): App control destroyed.
04-23 20:33:55.379+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.646717] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.379+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:353,-0.070000,0.070000,0.140000
04-23 20:33:55.379+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.389+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:390,0.055035,9.798609,0.825524
04-23 20:33:55.389+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.389+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:396,0.071785,9.755538,0.830309
04-23 20:33:55.389+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:346,0.019302,0.014874,-0.017881
04-23 20:33:55.389+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.389+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:33:55.389+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:33:55.399+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.399+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.666550] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.399+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:392,-0.070000,0.070000,0.140000
04-23 20:33:55.399+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.399+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:399,0.031107,9.817751,0.806381
04-23 20:33:55.409+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.409+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.409+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:414,0.019143,9.808180,0.803988
04-23 20:33:55.409+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:405,0.045016,9.769264,0.854308
04-23 20:33:55.409+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.419+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:423,0.008529,0.029352,-0.028783
04-23 20:33:55.419+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.419+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:420,0.046214,9.769358,0.853165
04-23 20:33:55.419+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.429+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.429+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:415,-0.070000,0.070000,0.070000
04-23 20:33:55.429+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:430,0.045304,9.769379,0.852976
04-23 20:33:55.429+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.429+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:433,0.024580,-0.013606,-0.025247
04-23 20:33:55.429+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.429+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.699436] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.439+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.439+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:430,0.059821,9.834501,0.820738
04-23 20:33:55.439+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.439+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:441,-0.017568,0.048707,-0.050242
04-23 20:33:55.439+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.449+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:440,0.046506,9.769257,0.854307
04-23 20:33:55.449+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.449+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:450,-0.028832,0.039104,-0.052305
04-23 20:33:55.449+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.449+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:449,0.014357,9.808180,0.768096
04-23 20:33:55.449+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:454,0.047204,9.769144,0.855557
04-23 20:33:55.459+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.459+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:447,-0.070000,0.070000,0.070000
04-23 20:33:55.459+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.459+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:463,0.048675,9.769044,0.856624
04-23 20:33:55.459+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.469+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:461,0.013084,0.065435,-0.035740
04-23 20:33:55.469+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.469+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.732652] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.469+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.469+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:467,0.047975,9.769076,0.856294
04-23 20:33:55.469+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.479+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:477,0.064606,9.779467,0.818345
04-23 20:33:55.479+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:464,-0.070000,0.070000,0.070000
04-23 20:33:55.479+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:474,-0.033135,0.039040,-0.087485
04-23 20:33:55.479+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.479+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.479+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.479+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:488,0.018576,0.010240,-0.036324
04-23 20:33:55.479+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.489+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:33:55.489+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:33:55.489+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:481,0.046737,9.769066,0.856479
04-23 20:33:55.489+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.489+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:492,0.078963,9.791430,0.763310
04-23 20:33:55.489+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:495,0.047492,9.769140,0.855581
04-23 20:33:55.489+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.489+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:490,-0.070000,0.070000,0.070000
04-23 20:33:55.499+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:492,0.031901,0.022130,-0.090468
04-23 20:33:55.499+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.766805] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.499+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.509+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.509+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:511,-0.022437,0.014506,-0.063725
04-23 20:33:55.509+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:499,0.046031,9.769227,0.854669
04-23 20:33:55.509+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.509+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.519+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:520,0.047062,9.769300,0.853779
04-23 20:33:55.519+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.519+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.519+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:529,-0.026290,0.059912,-0.039190
04-23 20:33:55.529+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:524,0.048758,9.769746,0.848571
04-23 20:33:55.529+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.529+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:535,0.047826,9.769803,0.847964
04-23 20:33:55.529+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.529+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.799121] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.539+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:516,-0.070000,0.070000,0.070000
04-23 20:33:55.539+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.539+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:520,0.026321,9.784252,0.784846
04-23 20:33:55.539+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:540,0.046709,9.769765,0.848467
04-23 20:33:55.539+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.539+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.549+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:546,0.070000,0.070000,0.070000
04-23 20:33:55.549+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:549,-0.025174,0.016880,-0.054049
04-23 20:33:55.549+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.549+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.549+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:555,-0.070000,0.070000,0.070000
04-23 20:33:55.549+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:546,0.021535,9.829715,0.808774
04-23 20:33:55.549+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.549+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:554,0.045650,9.769765,0.848529
04-23 20:33:55.559+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.559+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:561,0.021535,9.786645,0.794417
04-23 20:33:55.559+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.559+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.569+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.833221] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.569+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:573,-0.007365,0.016880,-0.037363
04-23 20:33:55.569+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:571,0.045445,9.769760,0.848591
04-23 20:33:55.569+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.579+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:581,0.038285,9.786645,0.811167
04-23 20:33:55.579+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.579+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.589+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:590,0.045391,9.769618,0.850226
04-23 20:33:55.589+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:588,-0.007160,0.028849,-0.027853
04-23 20:33:55.589+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.589+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:33:55.589+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:33:55.589+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:566,-0.070000,0.070000,0.070000
04-23 20:33:55.599+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.609+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.609+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.609+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.872529] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.609+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:615,-0.002321,0.062490,-0.055809
04-23 20:33:55.619+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:615,0.045570,9.769598,0.850450
04-23 20:33:55.619+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:599,0.038285,9.798609,0.820738
04-23 20:33:55.619+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.619+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:607,-0.070000,0.070000,0.070000
04-23 20:33:55.619+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.619+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.629+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.639+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.901850] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.639+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:631,0.044325,9.769659,0.849816
04-23 20:33:55.639+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:630,-0.028820,0.017047,-0.079961
04-23 20:33:55.639+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:628,0.043071,9.832108,0.794417
04-23 20:33:55.649+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.649+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:639,-0.070000,0.070000,0.070000
04-23 20:33:55.649+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.649+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.649+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:656,-0.015611,0.048092,-0.074542
04-23 20:33:55.649+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.669+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:661,0.043716,9.769772,0.848550
04-23 20:33:55.669+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.669+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:660,0.016750,9.786645,0.770489
04-23 20:33:55.669+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:663,0.070000,0.070000,0.140000
04-23 20:33:55.669+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.936105] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.669+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.669+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.669+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.679+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:686,-0.070000,0.070000,0.140000
04-23 20:33:55.689+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:33:55.689+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:33:55.689+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:683,0.028714,9.817751,0.775275
04-23 20:33:55.689+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:684,0.045283,9.769767,0.848522
04-23 20:33:55.689+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:681,0.030461,0.050373,-0.011063
04-23 20:33:55.689+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.699+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.699+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.699+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.709+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.971130] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.709+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:713,0.074178,9.820145,0.837488
04-23 20:33:55.719+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:709,0.045553,9.769884,0.847151
04-23 20:33:55.719+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:714,-0.070000,0.070000,0.070000
04-23 20:33:55.719+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:704,0.002574,0.021664,-0.056497
04-23 20:33:55.719+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.719+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.719+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.719+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.729+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2510.999718] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.739+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:728,-0.031196,0.021546,-0.031199
04-23 20:33:55.739+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:741,-0.070000,0.070000,0.070000
04-23 20:33:55.739+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.739+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:737,0.044216,9.769773,0.848508
04-23 20:33:55.739+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:731,0.047856,9.791430,0.792024
04-23 20:33:55.739+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.739+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.749+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.749+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:755,0.042583,9.769717,0.849230
04-23 20:33:55.759+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:751,-0.037037,0.040801,-0.058876
04-23 20:33:55.759+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:761,-0.070000,0.070000,0.070000
04-23 20:33:55.769+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:759,0.014357,9.791430,0.815953
04-23 20:33:55.769+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.769+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.769+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2511.035386] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.769+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.779+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.789+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:780,0.007178,9.810574,0.789631
04-23 20:33:55.789+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:33:55.789+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:33:55.799+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:775,-0.028226,0.038463,-0.064384
04-23 20:33:55.799+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:787,0.041384,9.769736,0.849075
04-23 20:33:55.799+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.799+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.799+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:781,-0.070000,0.070000,0.070000
04-23 20:33:55.799+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2511.069614] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.809+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.809+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:814,0.014357,9.808180,0.784846
04-23 20:33:55.809+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.819+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:810,0.039972,0.040837,-0.037908
04-23 20:33:55.819+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:820,0.043414,9.769897,0.847127
04-23 20:33:55.819+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.819+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:817,-0.070000,0.070000,0.070000
04-23 20:33:55.819+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.829+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.829+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.839+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2511.102386] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.839+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:830,-0.009914,0.052641,-0.040746
04-23 20:33:55.839+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:33:55:842,0.043081,9.769898,0.847124
04-23 20:33:55.839+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:33:55:834,0.081356,9.810574,0.811167
04-23 20:33:55.849+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.849+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:33:55.849+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:33:55:835,-0.070000,0.070000,0.070000
04-23 20:33:55.849+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:33:55.879+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:33:55.879+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2511.145480] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.879+0200 E/AUL_AMD ( 2481): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 20:33:55.879+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:33:55.879+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10164), cmd(0)
04-23 20:33:55.899+0200 W/AUL     (10208): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:33:55.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:33:55.899+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:33:55.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9920
04-23 20:33:55.899+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:33:55.899+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9920
04-23 20:33:55.899+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9920)
04-23 20:33:55.909+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2511.171493] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.909+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:33:55.909+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:33:55.909+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:33:55.909+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:33:55.909+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:33:55.909+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:33:55.909+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:33:55.909+0200 E/CAPI_LOCATION_MANAGER(10195): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:33:55.909+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:33:55.909+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:33:55.909+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:33:55.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:33:55.939+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2511.200402] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.949+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:860,-0.019153,0.040675,-0.035957
04-23 20:33:55.949+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.959+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:959,-0.006420,0.012020,-0.132397
04-23 20:33:55.959+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.959+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:963,0.027233,0.028372,-0.072766
04-23 20:33:55.959+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.969+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [2511.234015] pp(0x485a60) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:33:55.969+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:967,0.011416,0.040028,0.009858
04-23 20:33:55.969+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.979+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:979,-0.017962,0.040158,-0.029910
04-23 20:33:55.979+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.979+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:33:55:984,-0.016790,0.044592,-0.040236
04-23 20:33:55.979+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:33:55.999+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:33:55.999+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:33:55.999+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11101646c6f63152450843
