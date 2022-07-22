S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5564
Date: 2018-04-23 20:04:51+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf716e52d, r5   = 0xf7978f98
r6   = 0xff88a6e0, r7   = 0xff88a590
r8   = 0xf7975c18, r9   = 0x00000000
r10  = 0xff88a66c, fp   = 0xff88a6e0
ip   = 0x00000001, sp   = 0xff88a568
lr   = 0xf716e539, pc   = 0xf71d7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     67876 KB
Buffers:     36516 KB
Cached:     223480 KB
VmPeak:      53564 KB
VmSize:      53560 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12028 KB
VmRSS:       12028 KB
VmData:      11288 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5564 TID = 5564
5564 5611 

Maps Information
f4039000 f4838000 rw-p [stack:5611]
f483f000 f4841000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4849000 f484d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4856000 f4858000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4860000 f4863000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4872000 f4877000 r-xp /usr/lib/libsystem.so.0.0.0
f4882000 f4885000 r-xp /lib/libattr.so.1.1.0
f488d000 f489d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48a5000 f48ae000 r-xp /usr/lib/libedbus.so.1.7.99
f48b6000 f48b7000 r-xp /usr/lib/libresponse.so.0.2.96
f48c0000 f48c5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6167000 f626d000 r-xp /usr/lib/libicuuc.so.57.1
f6283000 f640b000 r-xp /usr/lib/libicui18n.so.57.1
f641b000 f6428000 r-xp /usr/lib/libail.so.0.1.0
f6431000 f6438000 r-xp /usr/lib/libminizip.so.1.0.0
f6441000 f65ea000 r-xp /usr/lib/libcrypto.so.1.0.0
f660a000 f6651000 r-xp /usr/lib/libssl.so.1.0.0
f665d000 f665f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6667000 f666e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6677000 f667e000 r-xp /lib/libcrypt-2.13.so
f66af000 f66b2000 r-xp /lib/libcap.so.2.21
f66ba000 f66bc000 r-xp /usr/lib/libiri.so
f66c4000 f670d000 r-xp /usr/lib/libmdm.so.1.2.69
f6715000 f671b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6723000 f6746000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6750000 f6752000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f675a000 f6777000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6780000 f6784000 r-xp /usr/lib/libsmack.so.1.0.0
f678d000 f67a6000 r-xp /usr/lib/libnetwork.so.0.0.0
f67af000 f67b7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67bf000 f67c5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67ce000 f67d0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67d9000 f67e9000 r-xp /lib/libresolv-2.13.so
f67ed000 f6805000 r-xp /usr/lib/liblzma.so.5.0.3
f680e000 f6810000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6818000 f6832000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f683a000 f6869000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6872000 f6881000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f688b000 f6895000 r-xp /usr/lib/libsensord-shared.so
f689e000 f6971000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f697c000 f6992000 r-xp /lib/libz.so.1.2.5
f699a000 f699f000 r-xp /usr/lib/libffi.so.5.0.10
f69a7000 f69a8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69b0000 f69c0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69c8000 f69e1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69e9000 f69eb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69f3000 f6a68000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a72000 f6a78000 r-xp /lib/librt-2.13.so
f6a81000 f6a9f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aa9000 f6aaa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ab2000 f6ad5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6add000 f6ae2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aea000 f6b14000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b1d000 f6b34000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b3c000 f6ba5000 r-xp /lib/libm-2.13.so
f6bae000 f6c42000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c55000 f6c5a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c62000 f6c69000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c71000 f6c9b000 r-xp /usr/lib/libsensor.so.1.9.6
f6ca4000 f6d70000 r-xp /usr/lib/libxml2.so.2.7.8
f6d7d000 f6d7f000 r-xp /usr/lib/libiniparser.so.0
f6d88000 f6d8e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d97000 f6e67000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e68000 f6e9c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ea5000 f6ee1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ee9000 f6eec000 r-xp /usr/lib/libbundle.so.0.1.22
f6ef4000 f6efa000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f02000 f6f43000 r-xp /usr/lib/libeina.so.1.7.99
f6f4c000 f6f63000 r-xp /usr/lib/libecore.so.1.7.99
f6f7a000 f6f83000 r-xp /usr/lib/libvconf.so.0.2.45
f6f8b000 f6f9f000 r-xp /lib/libpthread-2.13.so
f6faa000 f6fb7000 r-xp /usr/lib/libaul.so.0.1.0
f6fc1000 f6fc3000 r-xp /lib/libdl-2.13.so
f6fcc000 f6fd7000 r-xp /lib/libunwind.so.8.0.1
f7004000 f700c000 r-xp /lib/libgcc_s-4.6.so.1
f700d000 f7131000 r-xp /lib/libc-2.13.so
f713f000 f7141000 r-xp /usr/lib/libdlog.so.0.0.0
f7149000 f7155000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f715e000 f7163000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f716b000 f717a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7182000 f7186000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f718f000 f7192000 r-xp /usr/lib/libappcore-agent.so.1.1
f719a000 f719c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71a4000 f71a8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71b0000 f71cd000 r-xp /lib/ld-2.13.so
f71d6000 f71d9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71d9000 f71dd000 r-xp /usr/lib/libsys-assert.so
f7945000 f79d2000 rw-p [heap]
ff86b000 ff88c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5564)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71d7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf716e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e753f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e73c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e7fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e85be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e85dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6eba75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6eb51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e73c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e7fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e85be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e85dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6eb7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6eb8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ebff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48571fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf484a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf691d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6dcafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dcc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f5cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f57b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f585a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f58879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7190183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71907fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71d74f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf702485c) [/lib/libc.so.6] + 0x1785c
29: (0xf71d6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0,-1.960000,0.350000
04-23 20:04:50.869+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:50.869+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:50.879+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:50:882,0.980000,-1.820000,0.350000
04-23 20:04:50.879+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:50:882,0.076570,9.793823,0.847059
04-23 20:04:50.879+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:50.889+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:50:873,-0.015107,0.046793,-0.017597
04-23 20:04:50.889+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:50.889+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.155754] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:50.889+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:50.899+0200 W/SHealthService( 3097): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 20:04:50.899+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:50:902,0.021535,9.824929,0.868595
04-23 20:04:50.899+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:50:896,-0.007257,0.046833,0.005816
04-23 20:04:50.899+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:50:893,0.062782,9.770999,0.833077
04-23 20:04:50.899+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:50.909+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:50.909+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:50.909+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:50.919+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:50:921,0.045464,9.808180,0.782453
04-23 20:04:50.919+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:50:911,0.064089,9.771154,0.831158
04-23 20:04:50.919+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:50.919+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.186834] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:50.919+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:50:916,0.014128,0.042012,-0.012901
04-23 20:04:50.919+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:50:913,0.980000,-1.820000,0.350000
04-23 20:04:50.929+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:50.929+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:50:930,0.065500,9.771356,0.828679
04-23 20:04:50.919+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:50.929+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:50.929+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:04:50.929+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:04:50.939+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:50.939+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:50:940,0.013789,0.027610,-0.033874
04-23 20:04:50.939+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:50.939+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:50:935,1.050000,-1.890000,0.350000
04-23 20:04:50.939+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:50.949+0200 W/SHealthService( 3097): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 20:04:50.959+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.225457] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:50.959+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:50:945,0.012482,0.022669,0.015901
04-23 20:04:50.959+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:50.969+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:50:947,0.980000,-1.960000,0.280000
04-23 20:04:50.969+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:50.969+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:50:944,0.033500,9.796216,0.806381
04-23 20:04:50.969+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:50.969+0200 W/SHealthService( 3097): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 20:04:50.989+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:50:940,0.066846,9.771339,0.828758
04-23 20:04:50.989+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:50.989+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:50:986,0.062213,9.836893,0.799203
04-23 20:04:50.989+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:50.989+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.255284] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:50.989+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:04:50.989+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:04:50.999+0200 W/SHealthCommon( 3097): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1524441600000,000000[0;m
04-23 20:04:50.999+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:50:970,-0.043965,0.053574,0.039916
04-23 20:04:50.999+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:50.999+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:50:997,0.023928,9.781858,0.772882
04-23 20:04:51.009+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:50:994,0.065054,9.770933,0.833674
04-23 20:04:51.009+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.009+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:50:975,0.980000,-1.750000,0.280000
04-23 20:04:51.009+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.009+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.009+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:15,1.120000,-1.960000,0.350000
04-23 20:04:51.009+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.019+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:18,0.045464,9.789038,0.823131
04-23 20:04:51.019+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:14,0.064265,9.771000,0.832952
04-23 20:04:51.019+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.019+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.287629] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.029+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:9,-0.021383,0.036840,-0.046305
04-23 20:04:51.029+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.029+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.039+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:35,-0.031554,0.025283,-0.027293
04-23 20:04:51.039+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.039+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:19,1.120000,-2.100000,0.350000
04-23 20:04:51.039+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.059+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.320995] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.059+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:45,-0.002052,0.065893,-0.033750
04-23 20:04:51.059+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.059+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:68,-0.039045,0.010913,-0.060805
04-23 20:04:51.069+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:51,-0.070000,0.070000,0.140000
04-23 20:04:51.069+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.069+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:74,-0.070000,0.070000,0.070000
04-23 20:04:51.069+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.069+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.079+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:80,-0.017615,0.018005,-0.009537
04-23 20:04:51.079+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.079+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:78,-0.070000,-0.070000,0.070000
04-23 20:04:51.089+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.353338] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.089+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.099+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:97,-0.070000,-0.070000,0.070000
04-23 20:04:51.099+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:84,-0.008881,0.034821,-0.000856
04-23 20:04:51.099+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.099+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.109+0200 W/SHealthCommon( 3097): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-23 20:04:51.119+0200 I/HealthDataService( 2920): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 20:04:51.119+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.388618] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.129+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:111,-0.070000,-0.070000,0.140000
04-23 20:04:51.129+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.129+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:04:51.129+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:04:51.129+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:107,-0.058525,0.042131,-0.007236
04-23 20:04:51.139+0200 I/healthData( 3097): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 20:04:51.139+0200 W/healthData( 2851): health_fw_share.c: __health_notify_share_cb(331) > [1;40;33mNotification is called [category:shealth_pedometer_info][0;m
04-23 20:04:51.139+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:119,0.052642,9.805787,0.832702
04-23 20:04:51.139+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.139+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:147,0.002393,9.812965,0.827917
04-23 20:04:51.139+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.139+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:26,0.062973,9.770946,0.833687
04-23 20:04:51.139+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.149+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.149+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:152,0.063079,9.771032,0.832668
04-23 20:04:51.149+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.159+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:157,0.061523,9.770967,0.833559
04-23 20:04:51.159+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.420941] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.159+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.159+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:165,0.060918,9.770834,0.835153
04-23 20:04:51.159+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.159+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:137,-0.210000,0.140000,0.070000
04-23 20:04:51.159+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.169+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:170,0.060662,9.770720,0.836503
04-23 20:04:51.169+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:153,-0.015199,0.030282,-0.020550
04-23 20:04:51.169+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.169+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.169+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:174,-0.031748,0.037688,-0.004250
04-23 20:04:51.169+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.169+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:175,0.058069,9.770492,0.839345
04-23 20:04:51.169+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.179+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:151,0.045464,9.801002,0.815953
04-23 20:04:51.179+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:179,0.057767,9.770350,0.841013
04-23 20:04:51.179+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.179+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.179+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:171,-0.070000,0.140000,0.070000
04-23 20:04:51.179+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.179+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:186,0.056436,9.770186,0.843008
04-23 20:04:51.179+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.189+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:191,0.056070,9.770127,0.843714
04-23 20:04:51.189+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.189+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.454624] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.189+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:04:51.189+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:04:51.199+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:196,0.055612,9.770051,0.844626
04-23 20:04:51.199+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.199+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:178,-0.012303,0.045008,-0.010704
04-23 20:04:51.199+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.199+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:204,0.055623,9.770133,0.843676
04-23 20:04:51.199+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.199+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:207,-0.013365,0.033208,-0.010306
04-23 20:04:51.199+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.199+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:209,0.055618,9.769979,0.845452
04-23 20:04:51.209+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.209+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:188,-0.070000,0.140000,0.070000
04-23 20:04:51.209+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.209+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:213,0.055840,9.769933,0.845979
04-23 20:04:51.209+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:215,-0.070000,0.070000,0.140000
04-23 20:04:51.209+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.209+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:185,0.026321,9.808180,0.835095
04-23 20:04:51.209+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.209+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.219+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:221,0.055718,9.770180,0.843133
04-23 20:04:51.219+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.487452] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.219+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:222,0.045464,9.815358,0.830309
04-23 20:04:51.219+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.219+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:211,-0.003428,0.038053,-0.039726
04-23 20:04:51.219+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.229+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:232,0.043071,9.803394,0.832702
04-23 20:04:51.229+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:218,-0.070000,0.070000,0.070000
04-23 20:04:51.229+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.229+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.239+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.239+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:232,-0.002970,0.052486,0.009611
04-23 20:04:51.239+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.239+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:243,0.054021,9.770062,0.844596
04-23 20:04:51.239+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:244,0.001804,0.038047,-0.010973
04-23 20:04:51.239+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.239+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:237,0.052642,9.808180,0.803988
04-23 20:04:51.239+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.239+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:248,-0.005368,0.035808,-0.084534
04-23 20:04:51.239+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.249+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:249,0.052642,9.822537,0.854238
04-23 20:04:51.249+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.249+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:237,-0.070000,-0.070000,0.070000
04-23 20:04:51.249+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.249+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:254,0.057428,9.808180,0.832702
04-23 20:04:51.249+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.259+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.521264] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.259+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.259+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:255,-0.070000,-0.070000,0.070000
04-23 20:04:51.269+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:266,0.053070,9.770046,0.844846
04-23 20:04:51.269+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.269+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:259,0.050249,9.805787,0.760918
04-23 20:04:51.269+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.269+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:275,-0.070000,-0.070000,0.070000
04-23 20:04:51.269+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.269+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.269+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:276,0.016750,9.808180,0.813560
04-23 20:04:51.279+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:281,0.052176,9.769963,0.845861
04-23 20:04:51.279+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.279+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:252,-0.039090,0.038247,-0.032419
04-23 20:04:51.279+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:279,-0.070000,0.070000,0.070000
04-23 20:04:51.279+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.289+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:286,0.031107,9.836893,0.806381
04-23 20:04:51.289+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.289+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.555649] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.289+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.299+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.299+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:292,-0.024612,0.066713,-0.036752
04-23 20:04:51.299+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:300,0.031107,9.791430,0.820738
04-23 20:04:51.299+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.299+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:303,0.051324,9.770039,0.845037
04-23 20:04:51.299+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:299,-0.070000,0.070000,0.070000
04-23 20:04:51.309+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.309+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.309+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:313,-0.070000,0.070000,0.070000
04-23 20:04:51.309+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.309+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:310,-0.022914,0.021368,-0.023858
04-23 20:04:51.309+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.309+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.319+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:314,0.031107,9.812965,0.787239
04-23 20:04:51.319+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.319+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:321,-0.021963,0.042919,-0.057607
04-23 20:04:51.319+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.319+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.588180] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.329+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:321,0.051864,9.770044,0.844938
04-23 20:04:51.329+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:04:51.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:04:51.329+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:04:51.329+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:04:51.329+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:04:51.339+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:317,-0.140000,0.070000,0.070000
04-23 20:04:51.339+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.339+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.339+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:344,0.051027,9.770093,0.844434
04-23 20:04:51.349+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:344,-0.070000,0.070000,0.070000
04-23 20:04:51.349+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.359+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:331,0.007644,0.074109,-0.015551
04-23 20:04:51.359+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.623340] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.359+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:326,0.059821,9.844072,0.830309
04-23 20:04:51.359+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.359+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.359+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:368,0.031107,9.817751,0.794417
04-23 20:04:51.359+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.369+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:367,0.052187,9.769998,0.845462
04-23 20:04:51.369+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.369+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:354,-0.070000,0.070000,0.070000
04-23 20:04:51.369+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.369+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:372,-0.020217,0.047712,-0.050619
04-23 20:04:51.369+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.369+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.379+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:376,0.069392,9.815358,0.830309
04-23 20:04:51.379+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:380,0.052918,9.770185,0.843257
04-23 20:04:51.379+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:381,0.017528,0.045314,-0.014628
04-23 20:04:51.379+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.379+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:378,-0.070000,-0.070000,0.070000
04-23 20:04:51.379+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.379+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.379+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:387,0.064606,9.829715,0.784846
04-23 20:04:51.389+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:393,0.013579,0.059622,-0.059588
04-23 20:04:51.389+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.389+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.655572] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.389+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:04:51.389+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:04:51.399+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.399+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.399+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:397,0.055035,9.822537,0.784846
04-23 20:04:51.399+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:403,0.002848,0.052540,-0.060616
04-23 20:04:51.399+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:403,0.053157,9.770317,0.841703
04-23 20:04:51.399+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.399+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:388,-0.070000,-0.070000,0.070000
04-23 20:04:51.399+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.409+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.409+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:413,-0.036168,0.006888,-0.015340
04-23 20:04:51.409+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:412,-0.070000,-0.070000,0.070000
04-23 20:04:51.409+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.409+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:409,0.016750,9.777073,0.827917
04-23 20:04:51.409+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.409+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.419+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:421,0.051580,9.770150,0.843738
04-23 20:04:51.419+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.419+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:426,0.004271,0.033077,-0.023358
04-23 20:04:51.429+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.690125] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.429+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:417,-0.070000,-0.070000,0.140000
04-23 20:04:51.429+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.429+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.439+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.439+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:442,0.051990,9.770147,0.843738
04-23 20:04:51.449+0200 W/LOCATION( 5564): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:04:51.449+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:420,0.057428,9.803394,0.818345
04-23 20:04:51.449+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.459+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.722494] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.459+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.459+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:463,-0.046794,0.021280,-0.049321
04-23 20:04:51.469+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.469+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:466,0.049869,9.770051,0.844980
04-23 20:04:51.469+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:442,-0.140000,0.140000,0.070000
04-23 20:04:51.469+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.469+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.469+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:473,-0.008920,0.054782,-0.023000
04-23 20:04:51.479+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.479+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:454,0.004786,9.791430,0.794417
04-23 20:04:51.479+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.489+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:484,0.000380,0.014201,-0.069706
04-23 20:04:51.489+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.754837] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.489+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.499+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:481,0.049678,9.770009,0.845481
04-23 20:04:51.499+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.499+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:502,-0.004215,0.016636,-0.120456
04-23 20:04:51.499+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:478,-0.140000,0.140000,0.070000
04-23 20:04:51.499+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.499+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:485,0.043071,9.824929,0.820738
04-23 20:04:51.499+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.509+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:508,-0.070000,0.140000,0.070000
04-23 20:04:51.509+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.509+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:516,-0.070000,0.140000,0.070000
04-23 20:04:51.509+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.509+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.519+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.788201] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.529+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:521,-0.004387,0.049963,-0.058634
04-23 20:04:51.529+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:503,0.049850,9.770182,0.843479
04-23 20:04:51.529+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.529+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:04:51.529+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:04:51.539+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.539+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:543,-0.001938,0.023287,-0.044941
04-23 20:04:51.539+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:539,0.049795,9.770536,0.839358
04-23 20:04:51.539+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.549+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:511,0.050249,9.784252,0.775275
04-23 20:04:51.549+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.559+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.821922] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.559+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.559+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:566,-0.018621,-0.010318,-0.034152
04-23 20:04:51.569+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:555,0.045464,9.786645,0.725025
04-23 20:04:51.569+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.569+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.579+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:520,-0.070000,0.140000,0.070000
04-23 20:04:51.579+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.589+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.855252] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.589+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:551,0.049728,9.770641,0.838141
04-23 20:04:51.589+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:04:51.589+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:04:51.599+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:581,0.000466,0.044660,-0.021515
04-23 20:04:51.599+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.599+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.599+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:577,0.045464,9.820145,0.784846
04-23 20:04:51.609+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.609+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:604,-0.008368,-0.007933,0.008964
04-23 20:04:51.619+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:04:51.619+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:04:51.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:04:51.619+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:04:51.619+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.889657] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.629+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:608,0.049783,9.770699,0.837468
04-23 20:04:51.629+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:586,-0.070000,0.140000,0.070000
04-23 20:04:51.629+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.629+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:634,-0.070000,0.140000,0.070000
04-23 20:04:51.629+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.629+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.629+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5564
04-23 20:04:51.629+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.629+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5564)
04-23 20:04:51.639+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:04:51.639+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:04:51.639+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:614,0.047856,9.793823,0.794417
04-23 20:04:51.639+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.639+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:646,0.031107,9.760324,0.803988
04-23 20:04:51.639+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.659+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.924057] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.659+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:639,-0.042062,0.047123,-0.063056
04-23 20:04:51.659+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.669+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:641,0.049046,9.770649,0.838095
04-23 20:04:51.669+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.669+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:638,-0.140000,0.140000,0.070000
04-23 20:04:51.689+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.955547] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.699+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:04:51:676,0.049241,9.770628,0.838330
04-23 20:04:51.699+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:672,0.013073,0.157500,-0.121664
04-23 20:04:51.699+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.699+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:04:51.709+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:04:51.709+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:04:51:650,0.050249,9.815358,0.815953
04-23 20:04:51.709+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:04:51.719+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:04:51:710,-0.070000,0.070000,0.070000
04-23 20:04:51.719+0200 E/AUL_AMD ( 2481): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 20:04:51.719+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:04:51.719+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5564), cmd(0)
04-23 20:04:51.729+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [766.992331] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.739+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:04:51.739+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:04:51.739+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:04:51.739+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:04:51.739+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:04:51.739+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:04:51.739+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:04:51.739+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:04:51.749+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:04:51.759+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [767.023238] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:04:51.769+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:04:51:709,0.026911,-0.002799,-0.050220
04-23 20:04:51.769+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:04:51.779+0200 W/AUL     ( 5622): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:04:51.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:04:51.779+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:04:51.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5302
04-23 20:04:51.779+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:04:51.779+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5302
04-23 20:04:51.779+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5302)
04-23 20:04:51.789+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [767.056682] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.789+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:04:51.789+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:04:51.799+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:04:51.799+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:04:51.829+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [767.093367] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.859+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [767.125170] pp(0x456580) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:04:51.859+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11055646c6f63152450669
