S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17747
Date: 2018-04-23 19:36:15+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf767852d, r5   = 0xf7d6cf98
r6   = 0xfffce290, r7   = 0xfffce140
r8   = 0xf7d69c18, r9   = 0x00000000
r10  = 0xfffce21c, fp   = 0xfffce290
ip   = 0x00000001, sp   = 0xfffce118
lr   = 0xf7678539, pc   = 0xf76e1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11012 KB
Buffers:     54508 KB
Cached:     234556 KB
VmPeak:      53524 KB
VmSize:      53520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11916 KB
VmRSS:       11916 KB
VmData:      11248 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17747 TID = 17747
17747 17797 

Maps Information
f4543000 f4d42000 rw-p [stack:17797]
f4d49000 f4d4b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d53000 f4d57000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d60000 f4d62000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d6a000 f4d6d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d7c000 f4d81000 r-xp /usr/lib/libsystem.so.0.0.0
f4d8c000 f4d8f000 r-xp /lib/libattr.so.1.1.0
f4d97000 f4da7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4daf000 f4db8000 r-xp /usr/lib/libedbus.so.1.7.99
f4dc0000 f4dc1000 r-xp /usr/lib/libresponse.so.0.2.96
f4dca000 f4dcf000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6671000 f6777000 r-xp /usr/lib/libicuuc.so.57.1
f678d000 f6915000 r-xp /usr/lib/libicui18n.so.57.1
f6925000 f6932000 r-xp /usr/lib/libail.so.0.1.0
f693b000 f6942000 r-xp /usr/lib/libminizip.so.1.0.0
f694b000 f6af4000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b14000 f6b5b000 r-xp /usr/lib/libssl.so.1.0.0
f6b67000 f6b69000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b71000 f6b78000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b81000 f6b88000 r-xp /lib/libcrypt-2.13.so
f6bb9000 f6bbc000 r-xp /lib/libcap.so.2.21
f6bc4000 f6bc6000 r-xp /usr/lib/libiri.so
f6bce000 f6c17000 r-xp /usr/lib/libmdm.so.1.2.69
f6c1f000 f6c25000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c2d000 f6c50000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c5a000 f6c5c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c64000 f6c81000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c8a000 f6c8e000 r-xp /usr/lib/libsmack.so.1.0.0
f6c97000 f6cb0000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cb9000 f6cc1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cc9000 f6ccf000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cd8000 f6cda000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ce3000 f6cf3000 r-xp /lib/libresolv-2.13.so
f6cf7000 f6d0f000 r-xp /usr/lib/liblzma.so.5.0.3
f6d18000 f6d1a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d22000 f6d3c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d44000 f6d73000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d7c000 f6d8b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d95000 f6d9f000 r-xp /usr/lib/libsensord-shared.so
f6da8000 f6e7b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e86000 f6e9c000 r-xp /lib/libz.so.1.2.5
f6ea4000 f6ea9000 r-xp /usr/lib/libffi.so.5.0.10
f6eb1000 f6eb2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6eba000 f6eca000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ed2000 f6eeb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ef3000 f6ef5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6efd000 f6f72000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f7c000 f6f82000 r-xp /lib/librt-2.13.so
f6f8b000 f6fa9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fb3000 f6fb4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fbc000 f6fdf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fe7000 f6fec000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ff4000 f701e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7027000 f703e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7046000 f70af000 r-xp /lib/libm-2.13.so
f70b8000 f714c000 r-xp /usr/lib/libstdc++.so.6.0.16
f715f000 f7164000 r-xp /usr/lib/libctx-client.so.0.8.3
f716c000 f7173000 r-xp /usr/lib/libctx-shared.so.0.8.3
f717b000 f71a5000 r-xp /usr/lib/libsensor.so.1.9.6
f71ae000 f727a000 r-xp /usr/lib/libxml2.so.2.7.8
f7287000 f7289000 r-xp /usr/lib/libiniparser.so.0
f7292000 f7298000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72a1000 f7371000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7372000 f73a6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73af000 f73eb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73f3000 f73f6000 r-xp /usr/lib/libbundle.so.0.1.22
f73fe000 f7404000 r-xp /usr/lib/libappsvc.so.0.1.0
f740c000 f744d000 r-xp /usr/lib/libeina.so.1.7.99
f7456000 f746d000 r-xp /usr/lib/libecore.so.1.7.99
f7484000 f748d000 r-xp /usr/lib/libvconf.so.0.2.45
f7495000 f74a9000 r-xp /lib/libpthread-2.13.so
f74b4000 f74c1000 r-xp /usr/lib/libaul.so.0.1.0
f74cb000 f74cd000 r-xp /lib/libdl-2.13.so
f74d6000 f74e1000 r-xp /lib/libunwind.so.8.0.1
f750e000 f7516000 r-xp /lib/libgcc_s-4.6.so.1
f7517000 f763b000 r-xp /lib/libc-2.13.so
f7649000 f764b000 r-xp /usr/lib/libdlog.so.0.0.0
f7653000 f765f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7668000 f766d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7675000 f7684000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f768c000 f7690000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7699000 f769c000 r-xp /usr/lib/libappcore-agent.so.1.1
f76a4000 f76a6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76ae000 f76b2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76ba000 f76d7000 r-xp /lib/ld-2.13.so
f76e0000 f76e3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76e3000 f76e7000 r-xp /usr/lib/libsys-assert.so
f7d39000 f7dbc000 rw-p [heap]
fffaf000 fffd0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17747)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76e1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7678539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf737f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf737dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7389e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf738fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf738fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73c475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73bf1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf737dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7389e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf738fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf738fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73c1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73c2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73c9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d611fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d54171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e27663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72d4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72d67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7466ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7461b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74625a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7462879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf769a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf769a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76e14f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf752e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf76e0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 data from es.ugr.frailty.accelerometer
04-23 19:36:15.109+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:112,9.686146,-0.703490,0.497707
04-23 19:36:15.109+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:110,27.510000,-0.700000,-3.010000
04-23 19:36:15.109+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.109+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.119+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:120,9.608091,-1.827290,0.718317
04-23 19:36:15.119+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:120,0.344805,1.230518,-0.380152
04-23 19:36:15.119+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.119+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.119+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:125,32.410000,-1.050000,-2.800000
04-23 19:36:15.119+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:126,9.887143,-0.911665,0.344566
04-23 19:36:15.129+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.129+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.129+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.139+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:139,9.856036,-0.681954,-0.031107
04-23 19:36:15.139+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:139,0.247945,1.145335,-0.749424
04-23 19:36:15.139+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:141,9.636521,-1.677438,0.702887
04-23 19:36:15.139+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.149+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:149,25.200001,0.210000,-3.710000
04-23 19:36:15.149+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.149+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.159+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:161,9.639917,-1.671056,0.670789
04-23 19:36:15.159+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:161,0.054410,0.734666,-0.949348
04-23 19:36:15.159+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.159+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.159+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:167,15.120000,0.140000,-2.100000
04-23 19:36:15.169+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:168,9.690931,-0.942772,-0.246461
04-23 19:36:15.169+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.169+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.179+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:179,0.321403,0.065472,-0.857429
04-23 19:36:15.179+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:180,9.634753,-1.713434,0.637232
04-23 19:36:15.179+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.179+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.179+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:15.179+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:15:187,79
04-23 19:36:15.189+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:186,9.961320,-1.605584,-0.186640
04-23 19:36:15.189+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:185,23.590000,2.520000,-3.920000
04-23 19:36:15.199+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.199+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.199+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:205,0.410316,1.093693,0.039936
04-23 19:36:15.199+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.199+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:205,10.045070,-0.619741,0.677169
04-23 19:36:15.209+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 19:36:15.209+0200 W/libgps  ( 3158): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2635490), time2(2312455)
04-23 19:36:15.209+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 19:36:15.209+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 19:36:15.209+0200 I/libgps_d( 3158): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 19:36:15.209+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:25
04-23 19:36:15.209+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:210,9.642410,-1.674966,0.623538
04-23 19:36:15.209+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.209+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.209+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.219+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.219+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:219,9.681360,0.064606,0.375673
04-23 19:36:15.229+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:223,55.020000,7.980000,-5.180000
04-23 19:36:15.229+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:220,0.038950,1.739572,-0.247865
04-23 19:36:15.229+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:224,9.681451,-1.423105,0.643950
04-23 19:36:15.229+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.229+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.229+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.239+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.239+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:240,9.662218,0.308674,0.009571
04-23 19:36:15.239+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:236,46.689999,9.660000,-7.070000
04-23 19:36:15.239+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.239+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:239,9.717776,-1.152885,0.637226
04-23 19:36:15.249+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:245,-0.019233,1.731780,-0.634378
04-23 19:36:15.249+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:250,12.320000,2.170000,-2.660000
04-23 19:36:15.249+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.249+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.259+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.259+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:260,9.836893,-0.559920,0.215354
04-23 19:36:15.259+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.259+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:263,0.119117,0.592964,-0.421871
04-23 19:36:15.259+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:260,9.730206,-1.058692,0.610452
04-23 19:36:15.259+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:267,-7.630000,0.490000,4.340000
04-23 19:36:15.269+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.269+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.279+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:281,9.877571,-1.325624,0.904487
04-23 19:36:15.279+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:282,9.734032,-1.029458,0.599350
04-23 19:36:15.279+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.279+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.279+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:287,0.147366,-0.266932,0.294035
04-23 19:36:15.279+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:287,17.500000,2.660000,4.620000
04-23 19:36:15.299+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.299+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.299+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:306,9.736328,-0.997966,0.615106
04-23 19:36:15.299+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.309+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:307,9.655040,-1.261017,0.646062
04-23 19:36:15.309+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.309+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.309+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.319+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:312,-0.078992,-0.231559,0.046712
04-23 19:36:15.319+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.319+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:315,44.660000,2.660000,1.610000
04-23 19:36:15.319+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:320,9.858429,-0.588634,0.435494
04-23 19:36:15.319+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.319+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:324,0.122101,0.409332,-0.179612
04-23 19:36:15.319+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:319,9.737278,-0.987603,0.616794
04-23 19:36:15.329+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:330,21.840000,0.770000,-0.490000
04-23 19:36:15.329+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.329+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.329+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.339+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:340,9.870394,-0.200997,-0.614955
04-23 19:36:15.339+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.349+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:349,-2.940000,-0.140000,2.100000
04-23 19:36:15.349+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.359+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.359+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:360,10.102496,0.574277,-0.244068
04-23 19:36:15.379+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.379+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:339,9.741210,-0.954372,0.606950
04-23 19:36:15.379+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:342,0.133116,0.786606,-1.231749
04-23 19:36:15.379+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:366,-28.770000,10.150000,8.330000
04-23 19:36:15.389+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.389+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.389+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.399+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:383,9.439686,-0.129212,0.526421
04-23 19:36:15.409+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:15.409+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.409+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:396,0.361286,1.528649,-0.851018
04-23 19:36:15.419+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.419+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:402,-43.750000,7.140000,12.460000
04-23 19:36:15.419+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.419+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:403,9.729337,-1.085428,0.576396
04-23 19:36:15.429+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:15:413,79
04-23 19:36:15.429+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.429+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:418,9.710074,-1.024128,0.093320
04-23 19:36:15.439+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:429,-0.289651,0.956216,-0.049975
04-23 19:36:15.449+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:438,-48.160000,-3.010000,10.640000
04-23 19:36:15.449+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.449+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.459+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:438,9.726485,-1.121395,0.555282
04-23 19:36:15.459+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.459+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.459+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:468,-54.599998,2.660000,8.260000
04-23 19:36:15.469+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.469+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:473,-52.290001,7.770000,9.240000
04-23 19:36:15.469+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.469+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:458,10.112068,-1.454836,-0.193819
04-23 19:36:15.479+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:478,-33.880001,1.610000,7.560000
04-23 19:36:15.479+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.479+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:462,-0.016411,0.097267,-0.461962
04-23 19:36:15.479+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.479+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.479+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:486,-11.830000,-1.190000,4.480000
04-23 19:36:15.479+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:469,9.735931,-1.040075,0.547964
04-23 19:36:15.479+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.489+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:491,9.726036,-1.135845,0.533352
04-23 19:36:15.489+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.489+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:496,9.707417,-1.290807,0.519875
04-23 19:36:15.489+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.489+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:488,9.722038,-1.012164,0.775275
04-23 19:36:15.489+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.489+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:490,0.376137,-0.414761,-0.741782
04-23 19:36:15.499+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.499+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:505,-8.120000,1.260000,3.360000
04-23 19:36:15.499+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:501,9.705243,-1.302758,0.530528
04-23 19:36:15.499+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.499+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.509+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:511,9.699982,-1.334156,0.548417
04-23 19:36:15.509+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.509+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:512,-0.003998,0.123681,0.241922
04-23 19:36:15.509+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:503,9.487542,-1.804188,1.086342
04-23 19:36:15.509+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.509+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.509+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.519+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:519,-8.680000,2.240000,2.240000
04-23 19:36:15.519+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:515,9.692103,-1.399621,0.524002
04-23 19:36:15.519+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.519+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:523,-0.219874,-0.513381,0.566467
04-23 19:36:15.519+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:525,9.686543,-1.440355,0.516376
04-23 19:36:15.519+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:517,9.894321,-1.813759,-0.141177
04-23 19:36:15.519+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.519+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.529+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:529,0.189078,-0.511002,-0.671705
04-23 19:36:15.529+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.529+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:530,9.815358,-1.591227,0.253639
04-23 19:36:15.529+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.529+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:534,0.115376,-0.257071,-0.294778
04-23 19:36:15.529+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.529+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.529+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.539+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:539,-5.670000,2.170000,2.100000
04-23 19:36:15.539+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:539,9.682918,-1.468644,0.504555
04-23 19:36:15.539+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:538,0.113684,0.073997,-0.368468
04-23 19:36:15.539+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.539+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:536,9.805787,-1.325624,0.155533
04-23 19:36:15.539+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.549+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:547,0.045066,0.421013,0.239756
04-23 19:36:15.549+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:549,9.731609,-1.019342,0.756132
04-23 19:36:15.549+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.549+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.549+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:559,-0.006343,0.245911,0.230041
04-23 19:36:15.559+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.559+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.559+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:563,9.676575,-1.222732,0.734596
04-23 19:36:15.559+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:559,5.740000,-2.170000,0.910000
04-23 19:36:15.559+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:564,9.693548,-1.394629,0.510410
04-23 19:36:15.569+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.569+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.579+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.579+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:581,9.030000,-2.730000,-0.910000
04-23 19:36:15.579+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.579+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:15.579+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:581,9.700425,-1.344732,0.513639
04-23 19:36:15.579+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:583,0.262986,0.715068,-0.553481
04-23 19:36:15.579+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:585,9.956534,-0.679562,-0.043071
04-23 19:36:15.579+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:15:587,79
04-23 19:36:15.599+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.599+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.599+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:607,9.698640,-1.365210,0.492918
04-23 19:36:15.599+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.599+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.609+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:611,0.150826,0.734562,-0.772064
04-23 19:36:15.609+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:607,9.851252,-0.610170,-0.258425
04-23 19:36:15.609+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:611,-1.050000,3.010000,1.540000
04-23 19:36:15.609+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.609+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.609+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.619+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.619+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:619,-15.890000,6.020000,4.970000
04-23 19:36:15.619+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:621,9.638289,-0.940379,0.677169
04-23 19:36:15.619+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:619,9.684939,-1.467671,0.467199
04-23 19:36:15.619+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:623,-0.060350,0.424831,0.184250
04-23 19:36:15.629+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.629+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.629+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.639+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.639+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:641,9.689766,-1.430675,0.481646
04-23 19:36:15.639+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:643,0.101706,-0.008700,0.387039
04-23 19:36:15.649+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:641,-7.490000,2.660000,3.990000
04-23 19:36:15.649+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:643,9.786645,-1.476372,0.854238
04-23 19:36:15.649+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.649+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.649+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.659+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.659+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:660,9.689797,-1.424181,0.499918
04-23 19:36:15.659+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:661,1.890000,1.820000,2.170000
04-23 19:36:15.659+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:663,0.034665,-0.153374,-0.259113
04-23 19:36:15.669+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:663,9.724431,-1.584049,0.222532
04-23 19:36:15.669+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.669+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.689+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:36:15.689+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:36:15.689+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:36:15.689+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.689+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:681,9.848858,-1.127020,0.078963
04-23 19:36:15.689+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:682,1.680000,1.120000,0.700000
04-23 19:36:15.689+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.709+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.719+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.729+0200 W/LOCATION(17747): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:36:15.739+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:718,9.779467,-0.844666,0.198604
04-23 19:36:15.739+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:731,-2.800000,2.030000,1.820000
04-23 19:36:15.739+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.749+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:696,9.687552,-1.442619,0.490481
04-23 19:36:15.749+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.749+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.749+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:702,0.159060,0.297161,-0.420955
04-23 19:36:15.749+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.749+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:755,-3.780000,0.630000,2.730000
04-23 19:36:15.759+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:748,9.745967,-0.811167,0.358923
04-23 19:36:15.759+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.759+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:754,9.685752,-1.459550,0.475720
04-23 19:36:15.759+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.759+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.759+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:761,0.091914,0.597952,-0.291876
04-23 19:36:15.759+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.769+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:764,9.815358,-1.249053,0.387637
04-23 19:36:15.769+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.769+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:766,9.688599,-1.444268,0.464247
04-23 19:36:15.769+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:770,-1.190000,-0.280000,2.030000
04-23 19:36:15.769+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.779+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:15.779+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:770,0.060215,0.648383,-0.116796
04-23 19:36:15.779+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.789+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:15:787,78
04-23 19:36:15.789+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.789+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:782,9.820145,-1.450050,0.454636
04-23 19:36:15.789+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:790,9.695246,-1.400499,0.459566
04-23 19:36:15.789+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.789+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.799+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:794,3.570000,0.420000,0.490000
04-23 19:36:15.799+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:789,0.126760,0.195215,-0.076609
04-23 19:36:15.799+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.799+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.809+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:803,9.697181,-1.387828,0.457161
04-23 19:36:15.809+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.809+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:803,9.817751,-1.093520,0.375673
04-23 19:36:15.809+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.809+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:809,5.460000,0.070000,-0.770000
04-23 19:36:15.819+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.819+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:809,0.124899,-0.049551,-0.004930
04-23 19:36:15.819+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.819+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:820,9.683753,-0.882952,0.138784
04-23 19:36:15.819+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:824,-1.890000,1.750000,0.770000
04-23 19:36:15.829+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.829+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.829+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:816,9.698295,-1.380104,0.456918
04-23 19:36:15.829+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.829+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:826,0.120570,0.294308,-0.081488
04-23 19:36:15.829+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.839+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:834,9.779467,-1.301696,0.224925
04-23 19:36:15.839+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:837,9.699579,-1.371197,0.456478
04-23 19:36:15.839+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.839+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:842,-0.014542,0.497152,-0.318134
04-23 19:36:15.839+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.839+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:838,-3.010000,0.910000,1.400000
04-23 19:36:15.849+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.849+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.849+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:848,9.827322,-1.459622,0.504886
04-23 19:36:15.859+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.859+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:854,-0.210000,1.540000,0.770000
04-23 19:36:15.859+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.859+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:858,9.700898,-1.366184,0.443285
04-23 19:36:15.859+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.859+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:863,9.827322,-1.241875,0.246461
04-23 19:36:15.869+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:868,3.290000,-0.700000,-0.840000
04-23 19:36:15.869+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:852,0.079887,0.069501,-0.231553
04-23 19:36:15.869+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.869+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.879+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:876,0.126424,-0.093438,0.061600
04-23 19:36:15.879+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:869,9.699900,-1.375391,0.436605
04-23 19:36:15.879+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.879+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.879+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:880,9.729217,-0.981057,0.234497
04-23 19:36:15.879+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.889+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:886,1.260000,1.050000,0.070000
04-23 19:36:15.889+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:886,9.701050,-1.366949,0.437563
04-23 19:36:15.889+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.899+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:893,0.127422,0.133516,-0.190144
04-23 19:36:15.899+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.899+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.899+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:905,0.028167,0.385892,-0.203066
04-23 19:36:15.899+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.909+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.909+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:905,9.748360,-1.287339,0.423530
04-23 19:36:15.909+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:910,-0.350000,0.350000,1.190000
04-23 19:36:15.909+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:913,0.046978,0.079365,-0.007400
04-23 19:36:15.909+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:901,9.701382,-1.366704,0.430930
04-23 19:36:15.909+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.909+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.909+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.919+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:920,9.796216,-1.330409,0.287139
04-23 19:36:15.919+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:922,0.092669,0.023441,-0.135543
04-23 19:36:15.919+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.919+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:928,9.703547,-1.353851,0.422682
04-23 19:36:15.929+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:922,3.220000,-0.210000,1.190000
04-23 19:36:15.929+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.929+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:934,9.704613,-1.346202,0.422635
04-23 19:36:15.929+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.929+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.939+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.939+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:940,0.110745,0.240718,-0.152246
04-23 19:36:15.939+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:943,6.090000,-0.210000,-1.260000
04-23 19:36:15.939+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:940,9.815358,-1.105484,0.270389
04-23 19:36:15.939+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.949+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:949,9.706070,-1.337660,0.416246
04-23 19:36:15.949+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.949+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.959+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:960,0.075788,0.476244,-0.124322
04-23 19:36:15.959+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.959+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:964,2.660000,0.840000,-0.070000
04-23 19:36:15.959+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:960,9.781858,-0.861416,0.291924
04-23 19:36:15.959+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.959+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:969,9.707620,-1.327890,0.411357
04-23 19:36:15.969+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.969+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:15.979+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:15:980,0.074239,0.114729,0.095921
04-23 19:36:15.979+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:15.979+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:15.979+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:15.979+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:15:984,1.540000,0.630000,0.560000
04-23 19:36:15.979+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:15:980,9.781858,-1.213161,0.507278
04-23 19:36:15.979+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:15:987,78
04-23 19:36:15.989+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:15:986,9.711062,-1.303639,0.407643
04-23 19:36:15.989+0200 I/servicemanager(17718): es.ugr.frailty.location sleep timeout
04-23 19:36:15.989+0200 W/AUL     (17718): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:36:15.989+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:36:15.989+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17718
04-23 19:36:15.999+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:15.999+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:16.009+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17747
04-23 19:36:16.009+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:16:9,0.044476,-0.019592,0.003922
04-23 19:36:16.009+0200 W/AUL     (17718): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17747)
04-23 19:36:16.009+0200 I/servicemanager(17718): es.ugr.frailty.location stop request sent!
04-23 19:36:16.009+0200 I/servicemanager(17718): App control destroyed.
04-23 19:36:16.009+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:16.009+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:16.009+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:16:11,9.712645,-1.290101,0.412992
04-23 19:36:16.009+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:16.009+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:16.019+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:16:18,6.720000,0.140000,0.210000
04-23 19:36:16.019+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:16.019+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:16:19,9.755538,-1.323231,0.411566
04-23 19:36:16.019+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:16.019+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:16:21,0.090750,0.033869,-0.247887
04-23 19:36:16.019+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:16:22,9.714253,-1.278276,0.411926
04-23 19:36:16.029+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:16:30,9.803394,-1.256232,0.165105
04-23 19:36:16.029+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:16:26,8.750000,-0.700000,-1.400000
04-23 19:36:16.029+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:16.029+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:16.029+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:16.029+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:16.039+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:16:41,9.793823,-0.885344,0.234497
04-23 19:36:16.039+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:16:40,9.170000,-0.560000,-0.840000
04-23 19:36:16.039+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:16:40,0.079570,0.392932,-0.177429
04-23 19:36:16.039+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:16:42,9.715792,-1.270275,0.400217
04-23 19:36:16.059+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:16.059+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:16.059+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:16.069+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:16:66,0.089995,0.372967,-0.017365
04-23 19:36:16.069+0200 I/gravity (17778): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:16:70,9.718083,-1.254360,0.394746
04-23 19:36:16.069+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:16.069+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:16:63,9.805787,-0.897308,0.382852
04-23 19:36:16.069+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:16:76,3.990000,0.770000,0.910000
04-23 19:36:16.069+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:16.079+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:16.089+0200 I/gyroscope(17732): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:16:83,0.280000,0.490000,1.400000
04-23 19:36:16.089+0200 I/accelerometer(17729): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:16:83,9.726824,-1.366302,0.311067
04-23 19:36:16.089+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:16.089+0200 I/gravity (17778): capturing data from es.ugr.frailty.gravity
04-23 19:36:16.099+0200 I/gyroscope(17732): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:16.099+0200 I/accelerometer(17729): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:16.099+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:16:103,0.008740,-0.111942,-0.083679
04-23 19:36:16.149+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:16.149+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:16:153,0.153377,-0.071556,0.154653
04-23 19:36:16.149+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:16.159+0200 I/linearacceleration(17766): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:16:159,0.067235,0.167726,-0.108558
04-23 19:36:16.159+0200 I/linearacceleration(17766): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:16.169+0200 W/CRASH_MANAGER(17806): worker.c: worker_job(1205) > 11177476c6f63152450497
