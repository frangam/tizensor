S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20441
Date: 2018-04-23 19:43:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75a652d, r5   = 0xf7bdaf98
r6   = 0xffd86f90, r7   = 0xffd86e40
r8   = 0xf7bd7c18, r9   = 0x00000000
r10  = 0xffd86f1c, fp   = 0xffd86f90
ip   = 0x00000001, sp   = 0xffd86e18
lr   = 0xf75a6539, pc   = 0xf760f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      6636 KB
Buffers:     56536 KB
Cached:     232064 KB
VmPeak:      53488 KB
VmSize:      53424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11968 KB
VmRSS:       11964 KB
VmData:      11152 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20441 TID = 20441
20441 20470 

Maps Information
f4471000 f4c70000 rw-p [stack:20470]
f4c77000 f4c79000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c81000 f4c85000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c8e000 f4c90000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c98000 f4c9b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4caa000 f4caf000 r-xp /usr/lib/libsystem.so.0.0.0
f4cba000 f4cbd000 r-xp /lib/libattr.so.1.1.0
f4cc5000 f4cd5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cdd000 f4ce6000 r-xp /usr/lib/libedbus.so.1.7.99
f4cee000 f4cef000 r-xp /usr/lib/libresponse.so.0.2.96
f4cf8000 f4cfd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f659f000 f66a5000 r-xp /usr/lib/libicuuc.so.57.1
f66bb000 f6843000 r-xp /usr/lib/libicui18n.so.57.1
f6853000 f6860000 r-xp /usr/lib/libail.so.0.1.0
f6869000 f6870000 r-xp /usr/lib/libminizip.so.1.0.0
f6879000 f6a22000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a42000 f6a89000 r-xp /usr/lib/libssl.so.1.0.0
f6a95000 f6a97000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a9f000 f6aa6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6aaf000 f6ab6000 r-xp /lib/libcrypt-2.13.so
f6ae7000 f6aea000 r-xp /lib/libcap.so.2.21
f6af2000 f6af4000 r-xp /usr/lib/libiri.so
f6afc000 f6b45000 r-xp /usr/lib/libmdm.so.1.2.69
f6b4d000 f6b53000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b5b000 f6b7e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b88000 f6b8a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b92000 f6baf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bb8000 f6bbc000 r-xp /usr/lib/libsmack.so.1.0.0
f6bc5000 f6bde000 r-xp /usr/lib/libnetwork.so.0.0.0
f6be7000 f6bef000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bf7000 f6bfd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c06000 f6c08000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c11000 f6c21000 r-xp /lib/libresolv-2.13.so
f6c25000 f6c3d000 r-xp /usr/lib/liblzma.so.5.0.3
f6c46000 f6c48000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c50000 f6c6a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c72000 f6ca1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6caa000 f6cb9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cc3000 f6ccd000 r-xp /usr/lib/libsensord-shared.so
f6cd6000 f6da9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6db4000 f6dca000 r-xp /lib/libz.so.1.2.5
f6dd2000 f6dd7000 r-xp /usr/lib/libffi.so.5.0.10
f6ddf000 f6de0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6de8000 f6df8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e00000 f6e19000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e21000 f6e23000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e2b000 f6ea0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6eaa000 f6eb0000 r-xp /lib/librt-2.13.so
f6eb9000 f6ed7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ee1000 f6ee2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6eea000 f6f0d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f15000 f6f1a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f22000 f6f4c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f55000 f6f6c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f74000 f6fdd000 r-xp /lib/libm-2.13.so
f6fe6000 f707a000 r-xp /usr/lib/libstdc++.so.6.0.16
f708d000 f7092000 r-xp /usr/lib/libctx-client.so.0.8.3
f709a000 f70a1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70a9000 f70d3000 r-xp /usr/lib/libsensor.so.1.9.6
f70dc000 f71a8000 r-xp /usr/lib/libxml2.so.2.7.8
f71b5000 f71b7000 r-xp /usr/lib/libiniparser.so.0
f71c0000 f71c6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71cf000 f729f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72a0000 f72d4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72dd000 f7319000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7321000 f7324000 r-xp /usr/lib/libbundle.so.0.1.22
f732c000 f7332000 r-xp /usr/lib/libappsvc.so.0.1.0
f733a000 f737b000 r-xp /usr/lib/libeina.so.1.7.99
f7384000 f739b000 r-xp /usr/lib/libecore.so.1.7.99
f73b2000 f73bb000 r-xp /usr/lib/libvconf.so.0.2.45
f73c3000 f73d7000 r-xp /lib/libpthread-2.13.so
f73e2000 f73ef000 r-xp /usr/lib/libaul.so.0.1.0
f73f9000 f73fb000 r-xp /lib/libdl-2.13.so
f7404000 f740f000 r-xp /lib/libunwind.so.8.0.1
f743c000 f7444000 r-xp /lib/libgcc_s-4.6.so.1
f7445000 f7569000 r-xp /lib/libc-2.13.so
f7577000 f7579000 r-xp /usr/lib/libdlog.so.0.0.0
f7581000 f758d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7596000 f759b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75a3000 f75b2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75ba000 f75be000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75c7000 f75ca000 r-xp /usr/lib/libappcore-agent.so.1.1
f75d2000 f75d4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75dc000 f75e0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75e8000 f7605000 r-xp /lib/ld-2.13.so
f760e000 f7611000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7611000 f7615000 r-xp /usr/lib/libsys-assert.so
f7ba7000 f7c10000 rw-p [heap]
ffd68000 ffd89000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20441)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf760f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75a6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72ad3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72abc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72b7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72bdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72bddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72f275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72ed1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72abc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72b7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72bdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72bddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72efe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72f0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72f7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c8f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c82171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d55663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7202fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72047a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7394ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf738fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73905a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7390879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75c8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75c87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf760f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf745c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf760ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
railty.accelerometer: SM-R760,23/04/2018,19:43:48:760,2.799603,0.009571,9.463614
04-23 19:43:48.779+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.779+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.779+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:788,0.350000,0.840000,0.070000
04-23 19:43:48.789+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:788,2.775674,0.028714,9.406186
04-23 19:43:48.789+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.789+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:48.789+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:48.789+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:777,5.324913,0.032392,8.234964
04-23 19:43:48.799+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.799+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:797,2.756532,-0.009571,9.516255
04-23 19:43:48.799+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.799+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.809+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:807,0.840000,0.350000,-0.070000
04-23 19:43:48.809+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:785,-2.470215,-0.046017,1.159871
04-23 19:43:48.809+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.819+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.819+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:811,2.785245,0.038285,9.449257
04-23 19:43:48.819+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.829+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:828,2.811567,0.021535,9.425328
04-23 19:43:48.829+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:823,1.190000,0.490000,0.140000
04-23 19:43:48.829+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:804,5.296139,0.034053,8.253492
04-23 19:43:48.829+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.829+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:835,5.584168,0.030589,8.061421
04-23 19:43:48.829+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:822,-2.731924,-0.040160,1.275373
04-23 19:43:48.829+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.829+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.839+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.839+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:840,-2.934192,-0.063036,1.430904
04-23 19:43:48.839+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.839+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:844,0.420000,0.630000,0.210000
04-23 19:43:48.839+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:839,5.709866,0.029536,7.972888
04-23 19:43:48.839+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.839+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:848,2.773281,-0.007178,9.389436
04-23 19:43:48.849+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.849+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:852,5.762885,0.028890,7.934652
04-23 19:43:48.849+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.849+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:854,-2.944140,0.004609,1.493069
04-23 19:43:48.849+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.849+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:857,5.942890,0.026149,7.800754
04-23 19:43:48.859+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.859+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.859+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:868,2.792424,0.043071,9.425328
04-23 19:43:48.859+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:868,0.070000,1.190000,0.420000
04-23 19:43:48.869+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.869+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:860,-3.155252,0.014529,1.619789
04-23 19:43:48.869+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.869+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:873,5.746029,0.029400,7.946866
04-23 19:43:48.869+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.879+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:877,-2.989497,0.025634,1.555033
04-23 19:43:48.879+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.879+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.879+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:884,0.070000,1.190000,0.350000
04-23 19:43:48.879+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:884,2.799603,-0.007178,9.439686
04-23 19:43:48.879+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:879,5.539731,0.032862,8.092014
04-23 19:43:48.879+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.879+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:48.889+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:48:891,75
04-23 19:43:48.889+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.889+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:890,5.277652,0.036073,8.265317
04-23 19:43:48.889+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.889+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:896,-2.740128,-0.023290,1.371599
04-23 19:43:48.899+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.899+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:901,5.264700,0.035701,8.273575
04-23 19:43:48.899+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.899+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.899+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.899+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:909,2.833102,-0.019143,9.461221
04-23 19:43:48.909+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:907,0.070000,1.120000,0.350000
04-23 19:43:48.909+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:903,-2.501978,-0.007359,1.140869
04-23 19:43:48.909+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.909+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:906,5.153838,0.036370,8.343081
04-23 19:43:48.909+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.909+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.919+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.919+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:922,0.700000,1.260000,0.560000
04-23 19:43:48.919+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:924,2.775674,0.047856,9.463614
04-23 19:43:48.919+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:918,-2.508168,-0.045272,1.242681
04-23 19:43:48.919+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.929+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:919,5.232780,0.035191,8.293802
04-23 19:43:48.929+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.929+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:932,-2.368593,0.001915,1.106175
04-23 19:43:48.929+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.929+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:935,5.129783,0.037592,8.357888
04-23 19:43:48.929+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.929+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:937,-2.421213,-0.013656,1.131526
04-23 19:43:48.939+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:940,5.079440,0.037611,8.388579
04-23 19:43:48.939+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.939+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.939+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.939+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:944,0.840000,1.190000,0.420000
04-23 19:43:48.939+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:945,2.770889,0.026321,9.434900
04-23 19:43:48.939+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.939+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:943,5.158994,0.035063,8.339900
04-23 19:43:48.939+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.949+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:950,-2.356502,-0.044770,1.031548
04-23 19:43:48.949+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.949+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:952,4.999858,0.036014,8.436261
04-23 19:43:48.949+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.949+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:955,-2.287015,0.005460,1.036749
04-23 19:43:48.949+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:956,5.075240,0.033630,8.391138
04-23 19:43:48.949+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.949+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.959+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:960,-2.359391,-0.042241,1.099786
04-23 19:43:48.959+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.959+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.959+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:967,0.700000,1.400000,0.490000
04-23 19:43:48.959+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:967,2.775674,-0.014357,9.451650
04-23 19:43:48.959+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.959+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:960,5.276949,0.031195,8.265786
04-23 19:43:48.969+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.969+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:972,-2.166756,-0.055157,1.024960
04-23 19:43:48.969+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:973,5.120993,0.033717,8.363294
04-23 19:43:48.969+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.969+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.969+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:976,5.084670,0.034392,8.385424
04-23 19:43:48.969+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:977,-2.299565,0.014226,1.072475
04-23 19:43:48.979+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.979+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.979+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.979+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:48:983,2.739782,0.011964,9.489935
04-23 19:43:48.979+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:48.979+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:987,-2.506060,-0.004874,1.169114
04-23 19:43:48.979+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:48:987,0.700000,1.190000,0.210000
04-23 19:43:48.979+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:48:983,5.218004,0.032555,8.303117
04-23 19:43:48.979+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.989+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:992,-2.345318,-0.048074,1.088356
04-23 19:43:48.989+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.989+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:48:996,-2.344888,-0.022427,1.104511
04-23 19:43:48.989+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:48.989+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:48.999+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:48.999+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:48.999+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:48.999+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:8,2.770889,-0.011964,9.475577
04-23 19:43:48.999+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.009+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:8,5.201593,0.032807,8.313407
04-23 19:43:49.009+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:11,-2.447116,-0.044519,1.172461
04-23 19:43:49.019+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.029+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.069+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:43:49.069+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:43:49.069+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:43:49.109+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:49.129+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:49:122,75
04-23 19:43:49.129+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:12,0.770000,1.120000,0.070000
04-23 19:43:49.129+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.129+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.129+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:138,2.773281,0.043071,9.461221
04-23 19:43:49.139+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:143,1.260000,0.840000,0.070000
04-23 19:43:49.139+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.139+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.149+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:150,2.792424,0.023928,9.439686
04-23 19:43:49.149+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:154,0.840000,0.770000,0.210000
04-23 19:43:49.149+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.149+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.159+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:160,2.780460,0.011964,9.427721
04-23 19:43:49.169+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:163,0.490000,0.910000,0.350000
04-23 19:43:49.169+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.169+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.169+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:175,2.794817,0.007178,9.480364
04-23 19:43:49.179+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.179+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:179,0.490000,1.050000,0.280000
04-23 19:43:49.179+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.179+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:26,5.334648,0.032041,8.228662
04-23 19:43:49.179+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.189+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:186,2.797210,-0.009571,9.461221
04-23 19:43:49.189+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:188,1.120000,1.330000,0.490000
04-23 19:43:49.189+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:49.189+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:49.189+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.199+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.209+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:212,1.330000,1.120000,0.490000
04-23 19:43:49.209+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:103,-2.561367,0.011029,1.232558
04-23 19:43:49.209+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:193,5.178983,0.034426,8.327504
04-23 19:43:49.209+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.209+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.219+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:206,2.773281,-0.004786,9.387043
04-23 19:43:49.219+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:221,5.127857,0.034743,8.359082
04-23 19:43:49.219+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.229+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.229+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:228,5.126995,0.034308,8.359612
04-23 19:43:49.229+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.229+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.229+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:234,5.204400,0.034238,8.311645
04-23 19:43:49.229+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.229+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:238,0.630000,1.120000,0.490000
04-23 19:43:49.229+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:239,5.368566,0.033257,8.206569
04-23 19:43:49.239+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.239+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:223,-2.542224,-0.008113,1.211023
04-23 19:43:49.239+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.239+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:245,5.474376,0.031662,8.136374
04-23 19:43:49.239+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.239+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:237,2.806781,-0.002393,9.413363
04-23 19:43:49.249+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:250,5.509971,0.029669,8.112319
04-23 19:43:49.249+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.249+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.249+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.249+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:254,5.775529,0.025460,7.925465
04-23 19:43:49.249+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.259+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:258,5.846924,0.024420,7.872945
04-23 19:43:49.259+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.259+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:248,-2.398523,-0.022462,1.100217
04-23 19:43:49.259+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.259+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:266,6.059894,0.022591,7.710225
04-23 19:43:49.259+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.269+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:258,2.761317,-0.038285,9.544970
04-23 19:43:49.269+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:271,5.781065,0.026979,7.921423
04-23 19:43:49.269+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.269+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:256,-0.070000,1.120000,0.210000
04-23 19:43:49.269+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.269+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.269+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:276,5.291905,0.032421,8.256214
04-23 19:43:49.269+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:270,-2.333040,-0.027564,1.121282
04-23 19:43:49.279+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.279+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.279+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:279,0.280000,0.910000,0.210000
04-23 19:43:49.279+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:284,5.133250,0.032791,8.355780
04-23 19:43:49.279+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:278,2.778067,-0.014357,9.513863
04-23 19:43:49.279+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.279+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:49.289+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:290,2.749353,-0.035892,9.492328
04-23 19:43:49.289+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.289+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:49:291,75
04-23 19:43:49.289+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.289+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:294,2.766103,0.043071,9.410972
04-23 19:43:49.289+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.289+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:286,-2.329785,-0.043880,1.101608
04-23 19:43:49.299+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.299+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:301,2.758924,0.088534,9.375079
04-23 19:43:49.299+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.299+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.299+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:300,0.770000,0.840000,-0.280000
04-23 19:43:49.299+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:308,5.505916,0.027770,8.115079
04-23 19:43:49.299+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.309+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:306,2.761317,0.033500,9.451650
04-23 19:43:49.309+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.309+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:305,-2.431119,-0.039023,1.075398
04-23 19:43:49.309+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.309+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:315,2.725425,-0.047856,9.456435
04-23 19:43:49.309+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.309+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:313,1.540000,0.700000,-0.280000
04-23 19:43:49.319+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.319+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.319+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:317,-2.561785,-0.035650,1.206795
04-23 19:43:49.319+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.319+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:324,5.723062,0.025195,7.963436
04-23 19:43:49.319+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:319,2.763710,-0.019143,9.451650
04-23 19:43:49.319+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.329+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:325,1.260000,0.840000,-0.280000
04-23 19:43:49.329+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:332,2.797210,-0.038285,9.418150
04-23 19:43:49.329+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.329+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:328,-2.713059,-0.069948,1.408595
04-23 19:43:49.329+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.329+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:338,0.140000,1.120000,0.070000
04-23 19:43:49.329+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.339+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.339+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.339+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:344,6.015762,0.021566,7.744709
04-23 19:43:49.339+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:344,2.737389,0.004786,9.449257
04-23 19:43:49.339+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:343,-0.140000,0.840000,0.210000
04-23 19:43:49.339+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.349+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:341,-2.731904,-0.044026,1.401544
04-23 19:43:49.349+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.349+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:353,0.420000,0.490000,0.630000
04-23 19:43:49.349+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.349+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:354,-3.026175,-0.061352,1.566863
04-23 19:43:49.349+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:357,0.630000,0.490000,0.560000
04-23 19:43:49.359+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.359+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.359+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:366,2.761317,0.038285,9.434900
04-23 19:43:49.369+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.369+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:365,6.005987,0.021481,7.752293
04-23 19:43:49.369+0200 W/LOCATION(20441): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:43:49.369+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.379+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.379+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.379+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:387,2.708675,-0.033500,9.475577
04-23 19:43:49.379+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:384,5.772602,0.024470,7.927601
04-23 19:43:49.389+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:381,0.700000,0.840000,0.210000
04-23 19:43:49.389+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.389+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:49.389+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:49.389+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:388,-3.080822,0.018651,1.538026
04-23 19:43:49.389+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.399+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:397,0.560000,1.050000,0.140000
04-23 19:43:49.399+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.399+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.399+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.399+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:401,-3.300969,0.065943,1.664855
04-23 19:43:49.409+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.409+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:408,6.085853,0.021178,7.689755
04-23 19:43:49.409+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:410,2.749353,0.040678,9.466006
04-23 19:43:49.409+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:413,-3.019748,0.006521,1.530227
04-23 19:43:49.409+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.419+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.419+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.429+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:422,-2.566480,-0.080277,1.200221
04-23 19:43:49.429+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.439+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:438,-2.369540,-0.051934,1.095870
04-23 19:43:49.449+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.449+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:453,-2.708706,-0.066056,1.303071
04-23 19:43:49.449+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.449+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:405,0.770000,0.910000,0.070000
04-23 19:43:49.449+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:426,5.936591,0.023602,7.805556
04-23 19:43:49.449+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:424,2.801995,0.038285,9.461221
04-23 19:43:49.459+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.459+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.459+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.459+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:458,-2.985672,-0.020409,1.485821
04-23 19:43:49.469+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.469+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:469,5.847898,0.024751,7.872221
04-23 19:43:49.469+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:475,-3.254445,0.016719,1.690191
04-23 19:43:49.479+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:468,1.050000,0.560000,0.560000
04-23 19:43:49.479+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.479+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.479+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.479+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:472,2.751746,0.011964,9.437292
04-23 19:43:49.479+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:49.479+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.489+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:49:490,75
04-23 19:43:49.489+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:488,5.899910,0.023557,7.833319
04-23 19:43:49.499+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:486,-3.297312,-0.054981,1.723285
04-23 19:43:49.499+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.499+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:488,0.840000,0.560000,0.840000
04-23 19:43:49.499+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.499+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.499+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:493,2.725425,0.009571,9.413363
04-23 19:43:49.499+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.509+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:504,-3.023249,0.016208,1.538405
04-23 19:43:49.509+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.509+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:509,0.420000,0.560000,1.120000
04-23 19:43:49.519+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.519+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:512,5.897525,0.021660,7.835121
04-23 19:43:49.519+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:519,-3.283858,0.017107,1.771466
04-23 19:43:49.519+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.519+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:515,2.727818,-0.028714,9.420543
04-23 19:43:49.519+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.529+0200 I/servicemanager(20291): es.ugr.frailty.location sleep timeout
04-23 19:43:49.529+0200 W/AUL     (20291): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:43:49.529+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:43:49.529+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20291
04-23 19:43:49.539+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:527,-3.184845,-0.011638,1.631736
04-23 19:43:49.539+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.539+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20441
04-23 19:43:49.539+0200 W/AUL     (20291): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20441)
04-23 19:43:49.539+0200 I/servicemanager(20291): es.ugr.frailty.location stop request sent!
04-23 19:43:49.539+0200 I/servicemanager(20291): App control destroyed.
04-23 19:43:49.539+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.549+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:546,-3.122473,-0.015180,1.541142
04-23 19:43:49.549+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.549+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:530,6.196542,0.017670,7.600852
04-23 19:43:49.549+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:554,-3.172092,-0.052271,1.587224
04-23 19:43:49.549+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.549+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:553,2.756532,-0.069392,9.485149
04-23 19:43:49.559+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:527,0.140000,0.560000,0.980000
04-23 19:43:49.559+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.559+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.559+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:569,6.669881,0.011587,7.189084
04-23 19:43:49.569+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.569+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:558,-3.140993,-0.091052,1.650029
04-23 19:43:49.569+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.569+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:568,-0.700000,0.490000,0.560000
04-23 19:43:49.579+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.579+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.579+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:586,6.842299,0.008877,7.025187
04-23 19:43:49.579+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:576,2.797210,-0.040678,9.432507
04-23 19:43:49.589+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:576,-3.399332,-0.058348,1.831655
04-23 19:43:49.589+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.589+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.589+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:589,0.210000,0.420000,0.630000
04-23 19:43:49.589+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:594,2.785245,-0.004786,9.487542
04-23 19:43:49.589+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:594,-3.884636,-0.016373,2.298458
04-23 19:43:49.589+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.589+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:43:49.589+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:43:49.589+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.599+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.599+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:601,-4.064231,-0.006484,2.421677
04-23 19:43:49.599+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.599+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.609+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:605,-4.067514,0.014422,2.408314
04-23 19:43:49.609+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.609+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:604,6.838403,0.009506,7.028978
04-23 19:43:49.609+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:615,-4.102731,-0.028993,2.470073
04-23 19:43:49.609+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:604,1.190000,0.700000,0.420000
04-23 19:43:49.609+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.609+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.619+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:611,2.778067,0.002393,9.446864
04-23 19:43:49.619+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.619+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:626,-4.043234,-0.020783,2.366618
04-23 19:43:49.619+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.629+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:622,6.830548,0.009851,7.036611
04-23 19:43:49.629+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:626,1.680000,1.050000,0.490000
04-23 19:43:49.639+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.639+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.639+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.639+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:636,2.770889,0.023928,9.437292
04-23 19:43:49.639+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:645,-4.067162,-0.066247,2.337903
04-23 19:43:49.649+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.649+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:654,2.727818,-0.019143,9.506684
04-23 19:43:49.649+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:647,6.724248,0.012403,7.138257
04-23 19:43:49.649+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:645,1.610000,0.980000,0.420000
04-23 19:43:49.649+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.659+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.659+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:665,-4.020050,0.015383,2.399933
04-23 19:43:49.659+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.669+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.679+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.679+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:685,-4.164259,0.026822,2.499067
04-23 19:43:49.679+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:49.679+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:673,6.787801,0.011212,7.077854
04-23 19:43:49.679+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:671,0.910000,0.420000,0.420000
04-23 19:43:49.689+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:677,2.744568,-0.009571,9.444471
04-23 19:43:49.689+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:49:690,75
04-23 19:43:49.689+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.689+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.689+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.699+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.699+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:709,-4.147105,-0.026232,2.544285
04-23 19:43:49.709+0200 I/gyroscope(20428): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:49:697,0.910000,0.420000,0.210000
04-23 19:43:49.709+0200 I/gyroscope(20428): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:49.709+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:699,6.812474,0.010938,7.054110
04-23 19:43:49.709+0200 I/gravity (20457): capturing data from es.ugr.frailty.gravity
04-23 19:43:49.709+0200 I/accelerometer(20414): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:49:702,2.720639,-0.055035,9.415757
04-23 19:43:49.729+0200 I/linearacceleration(20444): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:49.739+0200 I/gravity (20457): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:49:747,6.961469,0.006677,6.907119
04-23 19:43:49.739+0200 I/accelerometer(20414): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:49.749+0200 I/linearacceleration(20444): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:49:737,-4.054724,-0.036227,2.406370
04-23 19:43:49.749+0200 W/CRASH_MANAGER(20380): worker.c: worker_job(1205) > 11204416c6f63152450542
