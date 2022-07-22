S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19573
Date: 2018-04-23 19:41:03+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70a252d, r5   = 0xf72d3f98
r6   = 0xffa14600, r7   = 0xffa144b0
r8   = 0xf72d0c18, r9   = 0x00000000
r10  = 0xffa1458c, fp   = 0xffa14600
ip   = 0x00000001, sp   = 0xffa14488
lr   = 0xf70a2539, pc   = 0xf710b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8632 KB
Buffers:     55748 KB
Cached:     234672 KB
VmPeak:      53592 KB
VmSize:      53424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12088 KB
VmRSS:       12088 KB
VmData:      11152 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19573 TID = 19573
19573 19588 

Maps Information
f3f6d000 f476c000 rw-p [stack:19588]
f4773000 f4775000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f477d000 f4781000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f478a000 f478c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4794000 f4797000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47a6000 f47ab000 r-xp /usr/lib/libsystem.so.0.0.0
f47b6000 f47b9000 r-xp /lib/libattr.so.1.1.0
f47c1000 f47d1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47d9000 f47e2000 r-xp /usr/lib/libedbus.so.1.7.99
f47ea000 f47eb000 r-xp /usr/lib/libresponse.so.0.2.96
f47f4000 f47f9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f609b000 f61a1000 r-xp /usr/lib/libicuuc.so.57.1
f61b7000 f633f000 r-xp /usr/lib/libicui18n.so.57.1
f634f000 f635c000 r-xp /usr/lib/libail.so.0.1.0
f6365000 f636c000 r-xp /usr/lib/libminizip.so.1.0.0
f6375000 f651e000 r-xp /usr/lib/libcrypto.so.1.0.0
f653e000 f6585000 r-xp /usr/lib/libssl.so.1.0.0
f6591000 f6593000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f659b000 f65a2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65ab000 f65b2000 r-xp /lib/libcrypt-2.13.so
f65e3000 f65e6000 r-xp /lib/libcap.so.2.21
f65ee000 f65f0000 r-xp /usr/lib/libiri.so
f65f8000 f6641000 r-xp /usr/lib/libmdm.so.1.2.69
f6649000 f664f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6657000 f667a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6684000 f6686000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f668e000 f66ab000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66b4000 f66b8000 r-xp /usr/lib/libsmack.so.1.0.0
f66c1000 f66da000 r-xp /usr/lib/libnetwork.so.0.0.0
f66e3000 f66eb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66f3000 f66f9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6702000 f6704000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f670d000 f671d000 r-xp /lib/libresolv-2.13.so
f6721000 f6739000 r-xp /usr/lib/liblzma.so.5.0.3
f6742000 f6744000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f674c000 f6766000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f676e000 f679d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67a6000 f67b5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67bf000 f67c9000 r-xp /usr/lib/libsensord-shared.so
f67d2000 f68a5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68b0000 f68c6000 r-xp /lib/libz.so.1.2.5
f68ce000 f68d3000 r-xp /usr/lib/libffi.so.5.0.10
f68db000 f68dc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68e4000 f68f4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68fc000 f6915000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f691d000 f691f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6927000 f699c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69a6000 f69ac000 r-xp /lib/librt-2.13.so
f69b5000 f69d3000 r-xp /usr/lib/libsystemd.so.0.4.0
f69dd000 f69de000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69e6000 f6a09000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a11000 f6a16000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a1e000 f6a48000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a51000 f6a68000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a70000 f6ad9000 r-xp /lib/libm-2.13.so
f6ae2000 f6b76000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b89000 f6b8e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b96000 f6b9d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ba5000 f6bcf000 r-xp /usr/lib/libsensor.so.1.9.6
f6bd8000 f6ca4000 r-xp /usr/lib/libxml2.so.2.7.8
f6cb1000 f6cb3000 r-xp /usr/lib/libiniparser.so.0
f6cbc000 f6cc2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ccb000 f6d9b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d9c000 f6dd0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dd9000 f6e15000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e1d000 f6e20000 r-xp /usr/lib/libbundle.so.0.1.22
f6e28000 f6e2e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e36000 f6e77000 r-xp /usr/lib/libeina.so.1.7.99
f6e80000 f6e97000 r-xp /usr/lib/libecore.so.1.7.99
f6eae000 f6eb7000 r-xp /usr/lib/libvconf.so.0.2.45
f6ebf000 f6ed3000 r-xp /lib/libpthread-2.13.so
f6ede000 f6eeb000 r-xp /usr/lib/libaul.so.0.1.0
f6ef5000 f6ef7000 r-xp /lib/libdl-2.13.so
f6f00000 f6f0b000 r-xp /lib/libunwind.so.8.0.1
f6f38000 f6f40000 r-xp /lib/libgcc_s-4.6.so.1
f6f41000 f7065000 r-xp /lib/libc-2.13.so
f7073000 f7075000 r-xp /usr/lib/libdlog.so.0.0.0
f707d000 f7089000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7092000 f7097000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f709f000 f70ae000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70b6000 f70ba000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70c3000 f70c6000 r-xp /usr/lib/libappcore-agent.so.1.1
f70ce000 f70d0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70d8000 f70dc000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70e4000 f7101000 r-xp /lib/ld-2.13.so
f710a000 f710d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f710d000 f7111000 r-xp /usr/lib/libsys-assert.so
f72a0000 f7309000 rw-p [heap]
ff9f5000 ffa16000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19573)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf710b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70a2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6da93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6da7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6db3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6db9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6db9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dee75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6de91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6da7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6db3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6db9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6db9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6debe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dec017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6df3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf478b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf477e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6851663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cfefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d007a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e90ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e8bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e8c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e8c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70c4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70c47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf710b4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f5885c) [/lib/libc.so.6] + 0x1785c
29: (0xf710af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
00 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:572,-5.170890,-7.822137,3.158526
04-23 19:41:02.579+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.579+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:588,-5.236057,-7.613526,3.284557
04-23 19:41:02.579+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.589+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:598,-5.178068,-7.929814,3.058028
04-23 19:41:02.589+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.599+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:594,2.730000,-0.700000,0.980000
04-23 19:41:02.599+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.599+0200 E/CAPI_TELEPHONY(18958): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:41:02.609+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:609,2.100000,0.420000,1.190000
04-23 19:41:02.609+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:602,0.067211,-0.331515,-0.247013
04-23 19:41:02.609+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.609+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.609+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:615,0.191090,-0.043108,-0.320447
04-23 19:41:02.609+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.609+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:616,-0.140000,2.100000,1.470000
04-23 19:41:02.609+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.609+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:619,0.237451,0.135955,-0.142781
04-23 19:41:02.619+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.619+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:620,1.190000,2.520000,0.280000
04-23 19:41:02.619+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.619+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:624,-5.235800,-7.613424,3.285203
04-23 19:41:02.619+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.619+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:625,10.920000,2.870000,-1.470000
04-23 19:41:02.619+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.619+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.629+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:629,14.420000,2.800000,-2.730000
04-23 19:41:02.629+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.629+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:632,-5.046463,-7.652246,2.971886
04-23 19:41:02.629+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.629+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:634,10.290000,1.330000,-2.240000
04-23 19:41:02.629+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.629+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:636,-4.998606,-7.477571,3.141776
04-23 19:41:02.629+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.629+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:639,0.139088,-0.050787,0.091069
04-23 19:41:02.639+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.639+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:627,-5.233762,-7.613707,3.287793
04-23 19:41:02.639+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.639+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:643,-0.185982,-0.689387,0.368440
04-23 19:41:02.639+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:644,-5.228053,-7.615658,3.292355
04-23 19:41:02.639+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.639+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.639+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:648,-0.311332,-0.699400,0.445234
04-23 19:41:02.649+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.649+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.649+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:654,-0.378077,-0.334260,0.362937
04-23 19:41:02.649+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:656,1.820000,-0.700000,-0.700000
04-23 19:41:02.649+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:640,-5.096712,-7.664211,3.376273
04-23 19:41:02.649+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.649+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.659+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:647,-5.230699,-7.605125,3.312439
04-23 19:41:02.659+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.659+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:662,-0.520969,-0.045489,0.435494
04-23 19:41:02.659+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.659+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:665,-5.243340,-7.585223,3.337988
04-23 19:41:02.659+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.659+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:666,-0.634324,-0.189351,0.428505
04-23 19:41:02.659+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.669+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.669+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:672,-1.050000,-2.380000,1.680000
04-23 19:41:02.669+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:673,-0.719632,-0.440848,0.566517
04-23 19:41:02.669+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:662,-5.419744,-8.303094,3.656233
04-23 19:41:02.669+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.679+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:669,-5.261591,-7.561002,3.364119
04-23 19:41:02.679+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:679,-5.539384,-8.315059,3.737589
04-23 19:41:02.679+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.679+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.679+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:684,-5.608776,-7.939385,3.675375
04-23 19:41:02.679+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.679+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:684,-5.274389,-7.546393,3.376855
04-23 19:41:02.679+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.679+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:688,-5.764310,-7.630712,3.773481
04-23 19:41:02.679+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.679+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:689,-5.283720,-7.534477,3.388855
04-23 19:41:02.689+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:691,-5.895915,-7.750352,3.792624
04-23 19:41:02.689+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.689+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.689+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.689+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:696,-0.722264,-0.888258,0.786620
04-23 19:41:02.689+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:697,-1.050000,-4.690000,1.820000
04-23 19:41:02.699+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.699+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:695,-5.994020,-7.987241,3.943372
04-23 19:41:02.699+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.699+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:705,-5.280815,-7.531656,3.399637
04-23 19:41:02.699+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:706,-6.005985,-8.422735,4.175476
04-23 19:41:02.699+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.699+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.709+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:712,-0.193963,-0.503442,0.744732
04-23 19:41:02.709+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.709+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:712,3.780000,-5.320000,2.240000
04-23 19:41:02.709+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.719+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:717,-5.272155,-7.523037,3.432009
04-23 19:41:02.719+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:718,-5.474778,-8.035098,4.144369
04-23 19:41:02.719+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.719+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.729+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.729+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:732,-0.078196,-0.337386,0.645361
04-23 19:41:02.729+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.729+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:734,-5.267959,-7.508372,3.470351
04-23 19:41:02.729+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:732,9.870000,-3.150000,0.910000
04-23 19:41:02.729+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:737,-5.350351,-7.860423,4.077370
04-23 19:41:02.739+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.739+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.749+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:752,-0.087178,-0.222837,0.870229
04-23 19:41:02.749+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:751,15.120000,-0.980000,-0.700000
04-23 19:41:02.749+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.749+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.749+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:756,-5.267674,-7.483771,3.523515
04-23 19:41:02.749+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:756,-5.355137,-7.731210,4.340580
04-23 19:41:02.759+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.759+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.769+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.769+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:772,-0.123355,-0.209154,1.175988
04-23 19:41:02.769+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:772,18.760000,0.280000,-3.080000
04-23 19:41:02.769+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.769+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:774,-5.266145,-7.452912,3.590573
04-23 19:41:02.769+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:778,-5.391029,-7.692925,4.699504
04-23 19:41:02.789+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.789+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.789+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.789+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:797,-0.376131,-0.479295,1.379320
04-23 19:41:02.789+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.799+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:797,21.770000,-0.350000,-7.000000
04-23 19:41:02.799+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:801,-5.642276,-7.932207,4.969893
04-23 19:41:02.799+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:800,-5.264522,-7.428086,3.643999
04-23 19:41:02.799+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.809+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.809+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:812,26.180000,-0.840000,-10.850000
04-23 19:41:02.809+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:813,-0.284434,-0.269624,0.990898
04-23 19:41:02.809+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.809+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.819+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:819,-5.258509,-7.398883,3.711468
04-23 19:41:02.819+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:820,-5.548956,-7.697710,4.634897
04-23 19:41:02.819+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.819+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.829+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:832,-0.204306,0.031383,0.913858
04-23 19:41:02.829+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.829+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.839+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:838,-5.462814,-7.367501,4.625326
04-23 19:41:02.839+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:832,30.380001,-0.840000,-15.400000
04-23 19:41:02.839+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:838,-5.250891,-7.366488,3.785945
04-23 19:41:02.839+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.839+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.839+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.849+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:02:852,-0.168853,0.298090,0.755632
04-23 19:41:02.849+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:02.859+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:853,33.389999,1.190000,-18.129999
04-23 19:41:02.859+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:02:858,-5.419744,-7.068398,4.541577
04-23 19:41:02.859+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:853,-5.247591,-7.330105,3.860407
04-23 19:41:02.869+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.869+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.879+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:881,32.200001,-0.210000,-18.480000
04-23 19:41:02.899+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:02.909+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:882,-5.234411,-7.297472,3.939319
04-23 19:41:02.909+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.909+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:916,-5.215862,-7.270110,4.013809
04-23 19:41:02.909+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.919+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.919+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:924,34.230000,0.280000,-18.129999
04-23 19:41:02.919+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:02.929+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:922,-5.199215,-7.239534,4.089951
04-23 19:41:02.929+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:02.929+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:02:938,-5.192615,-7.197308,4.172038
04-23 19:41:03.019+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:21,-0.026190,0.283242,0.867811
04-23 19:41:03.019+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.019+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.029+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:02:930,39.619999,0.560000,-16.940001
04-23 19:41:03.029+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.029+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:26,0.120949,0.135754,0.702757
04-23 19:41:03.039+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:26,-5.273781,-7.046863,4.728218
04-23 19:41:03.039+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.039+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:44,-5.113462,-7.161718,4.642076
04-23 19:41:03.039+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.039+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.049+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:49,0.085651,-0.075855,0.642624
04-23 19:41:03.049+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.049+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:57,0.028325,0.108923,0.477948
04-23 19:41:03.059+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:37,46.130001,-0.070000,-16.100000
04-23 19:41:03.059+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.059+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:64,49.209999,-1.540000,-13.790000
04-23 19:41:03.059+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.069+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.069+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:48,-5.130211,-7.345965,4.656433
04-23 19:41:03.069+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.069+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:74,0.103081,0.262908,0.321683
04-23 19:41:03.069+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.069+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.079+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:79,0.100660,0.240704,0.159546
04-23 19:41:03.079+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.079+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:81,-5.190194,-7.148782,4.257604
04-23 19:41:03.079+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.079+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:84,0.425033,0.047667,-0.009645
04-23 19:41:03.079+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.079+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:85,-5.186750,-7.104101,4.335869
04-23 19:41:03.079+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.079+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:89,0.632237,0.244113,-0.305000
04-23 19:41:03.089+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.089+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:78,-5.170890,-7.130611,4.567898
04-23 19:41:03.089+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.089+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:93,0.849129,0.618854,-0.539737
04-23 19:41:03.089+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:68,46.759998,-3.990000,-12.180000
04-23 19:41:03.089+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.089+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.089+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:98,44.099998,-7.560000,-11.830000
04-23 19:41:03.089+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:99,1.157708,0.863143,-0.754823
04-23 19:41:03.089+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.099+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.099+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:95,-5.089533,-6.934400,4.493721
04-23 19:41:03.099+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.099+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:103,1.402232,0.973958,-0.820658
04-23 19:41:03.099+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.099+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:107,-5.089533,-6.908078,4.417150
04-23 19:41:03.099+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.099+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:108,1.558114,0.525101,-1.283092
04-23 19:41:03.109+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:89,-5.164244,-7.075622,4.408690
04-23 19:41:03.109+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.109+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:103,45.150002,-6.930000,-14.700000
04-23 19:41:03.109+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.109+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.109+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:110,-4.761717,-7.056434,4.326223
04-23 19:41:03.109+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.119+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:114,1.590008,0.264105,-1.513021
04-23 19:41:03.119+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:118,44.240002,-4.900000,-18.340000
04-23 19:41:03.119+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.119+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:121,-5.137067,-7.053154,4.475930
04-23 19:41:03.119+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.119+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:127,-5.113044,-7.029448,4.540268
04-23 19:41:03.119+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.129+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.129+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:126,37.869999,-2.100000,-20.790001
04-23 19:41:03.129+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.129+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:134,1.535518,0.259897,-1.370198
04-23 19:41:03.129+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:136,28.910000,1.120000,-22.540001
04-23 19:41:03.129+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.129+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:131,-5.082393,-7.018228,4.591746
04-23 19:41:03.129+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.129+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:139,23.799999,6.090000,-24.639999
04-23 19:41:03.139+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:122,-4.532006,-6.831509,4.103691
04-23 19:41:03.139+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.139+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:141,-5.044456,-7.021615,4.628258
04-23 19:41:03.139+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.139+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:144,-4.287938,-6.434300,3.936193
04-23 19:41:03.139+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.139+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:146,-5.002173,-7.045365,4.638047
04-23 19:41:03.139+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.139+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.149+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:148,-3.955336,-6.166305,3.785445
04-23 19:41:03.149+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.149+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:152,1.349093,0.359960,-1.293088
04-23 19:41:03.149+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:154,-3.680161,-6.044270,3.771089
04-23 19:41:03.149+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.149+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:150,-4.964433,-7.074656,4.634008
04-23 19:41:03.149+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.149+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.149+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:159,-4.933541,-7.098148,4.631075
04-23 19:41:03.159+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:160,24.430000,12.740000,-25.969999
04-23 19:41:03.159+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.159+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.159+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:166,-4.917692,-7.112743,4.625535
04-23 19:41:03.159+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:158,-3.486342,-6.496514,3.345166
04-23 19:41:03.159+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.159+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.169+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:172,-4.925962,-7.127008,4.594675
04-23 19:41:03.169+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:172,0.825965,0.594694,-1.378475
04-23 19:41:03.169+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:164,28.210001,19.670000,-27.370001
04-23 19:41:03.169+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.179+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.179+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:183,-3.412165,-6.781260,3.125026
04-23 19:41:03.179+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.179+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:188,-3.428915,-6.814759,3.263810
04-23 19:41:03.179+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.189+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:179,33.320000,29.960001,-29.680000
04-23 19:41:03.189+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.189+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.189+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.189+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:196,0.795950,1.006168,-1.838143
04-23 19:41:03.189+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:197,-4.944764,-7.164178,4.516000
04-23 19:41:03.199+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:194,24.219999,38.080002,-28.210001
04-23 19:41:03.199+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.199+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:192,-3.584448,-6.738188,3.337988
04-23 19:41:03.199+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.199+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:205,-0.420000,42.349998,-24.570000
04-23 19:41:03.199+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:208,-4.091727,-6.518049,3.247060
04-23 19:41:03.199+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.199+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.209+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.209+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:213,-4.130012,-6.120840,2.756532
04-23 19:41:03.209+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:212,-4.962005,-7.221093,4.405077
04-23 19:41:03.209+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.209+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:213,0.766895,0.796877,-1.718790
04-23 19:41:03.209+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.209+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:218,-4.177868,-6.367301,2.797210
04-23 19:41:03.219+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:221,-22.750000,44.939999,-19.530001
04-23 19:41:03.219+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.219+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.229+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:232,0.219430,-0.837934,-0.820629
04-23 19:41:03.229+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:232,-4.964458,-7.286390,4.293373
04-23 19:41:03.229+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.229+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.229+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:236,-18.340000,43.330002,-17.500000
04-23 19:41:03.229+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:236,-4.742575,-8.059027,3.584448
04-23 19:41:03.239+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.239+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.249+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:250,-0.359572,-1.933155,-0.024577
04-23 19:41:03.249+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.249+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:256,7.840000,43.189999,-15.400000
04-23 19:41:03.259+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:41:03.259+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:41:03.259+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:41:03.269+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.269+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:274,-0.243886,-1.005905,0.140186
04-23 19:41:03.269+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.269+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:251,-4.984431,-7.301975,4.243464
04-23 19:41:03.269+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.279+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.289+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:283,-5.324030,-9.219545,4.268795
04-23 19:41:03.289+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:281,-5.007767,-7.303012,4.214103
04-23 19:41:03.289+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:279,19.670000,43.889999,-16.660000
04-23 19:41:03.289+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.299+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.299+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:301,9.240000,42.000000,-19.040001
04-23 19:41:03.299+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.309+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.309+0200 W/LOCATION(19573): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:41:03.309+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:304,0.296299,0.024046,0.138441
04-23 19:41:03.309+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.319+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.319+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:323,-5.017565,-7.309686,4.190813
04-23 19:41:03.319+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.319+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:314,-11.130000,41.299999,-18.129999
04-23 19:41:03.319+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:320,0.270205,0.537998,0.262230
04-23 19:41:03.329+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.329+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:307,-5.228317,-8.307880,4.383651
04-23 19:41:03.329+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.329+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:333,0.624998,0.670714,0.713244
04-23 19:41:03.329+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.329+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:335,-4.711468,-7.278966,4.352544
04-23 19:41:03.329+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.329+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:339,-27.719999,41.369999,-13.860000
04-23 19:41:03.339+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:340,-4.747360,-6.771688,4.453043
04-23 19:41:03.339+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.339+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:345,-4.402793,-6.654440,4.864608
04-23 19:41:03.339+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.339+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.349+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:352,0.471421,-0.253943,1.372909
04-23 19:41:03.349+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.349+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:357,-41.369999,41.369999,-14.630000
04-23 19:41:03.349+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:328,-5.027791,-7.325154,4.151364
04-23 19:41:03.349+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:353,-4.548756,-7.606783,5.484349
04-23 19:41:03.359+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.359+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:364,-5.020177,-7.352840,4.111441
04-23 19:41:03.359+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.359+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.359+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.369+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:372,0.160174,-1.416461,2.264964
04-23 19:41:03.369+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.369+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:376,-27.580000,35.070000,-15.750000
04-23 19:41:03.369+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:373,-4.826324,-8.822337,6.321837
04-23 19:41:03.379+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:369,-4.986498,-7.405876,4.056873
04-23 19:41:03.379+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.379+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:389,-4.959527,-7.450504,4.007925
04-23 19:41:03.389+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.389+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.389+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.389+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:397,0.159525,-1.446010,2.129665
04-23 19:41:03.399+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:402,-7.910000,34.720001,-17.570000
04-23 19:41:03.399+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:398,-4.800002,-8.896514,6.137590
04-23 19:41:03.399+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.399+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.399+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.409+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.409+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:412,0.130278,-0.940235,1.713753
04-23 19:41:03.409+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:413,-4.809574,-8.415558,5.699703
04-23 19:41:03.409+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:416,9.520000,27.930000,-14.630000
04-23 19:41:03.419+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:409,-4.939851,-7.475323,3.985950
04-23 19:41:03.419+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.419+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.419+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.429+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.429+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:432,0.786357,0.373561,1.700891
04-23 19:41:03.439+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:432,-4.146761,-7.101898,5.694918
04-23 19:41:03.439+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:434,10.010000,20.580000,-8.260000
04-23 19:41:03.439+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:428,-4.933119,-7.475459,3.994026
04-23 19:41:03.439+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.439+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:446,-4.908044,-7.458199,4.056693
04-23 19:41:03.439+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.449+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.449+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:452,0.900066,0.262981,1.458763
04-23 19:41:03.449+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.449+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:456,-2.170000,16.940001,-6.930000
04-23 19:41:03.449+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:453,-4.007978,-7.195218,5.515456
04-23 19:41:03.449+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.459+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:463,-4.869109,-7.461265,4.097766
04-23 19:41:03.459+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.469+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.469+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.469+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:472,0.853952,-0.289087,0.632844
04-23 19:41:03.469+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:476,-11.550000,14.840000,-8.680000
04-23 19:41:03.469+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:473,-4.015156,-7.750352,4.730610
04-23 19:41:03.479+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.479+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:484,-4.818721,-7.496859,4.092360
04-23 19:41:03.489+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.489+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.489+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:498,0.731780,-0.770343,-0.488770
04-23 19:41:03.489+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.499+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:501,-17.500000,18.129999,-9.310000
04-23 19:41:03.499+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:498,-4.086941,-8.267202,3.603590
04-23 19:41:03.499+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.499+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:507,-4.777842,-7.558086,4.027151
04-23 19:41:03.509+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.509+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.519+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:520,0.205157,-0.290372,-0.899732
04-23 19:41:03.519+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.529+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.539+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:532,0.317084,-0.075543,-0.444165
04-23 19:41:03.539+0200 I/accelerometer(19534): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:41:03:518,-4.572684,-7.848458,3.127419
04-23 19:41:03.539+0200 I/gyroscope(19547): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:41:03:538,-22.680000,18.760000,-4.130000
04-23 19:41:03.539+0200 I/accelerometer(19534): capturing data from es.ugr.frailty.accelerometer
04-23 19:41:03.539+0200 I/gyroscope(19547): capturing data from es.ugr.frailty.gyroscope
04-23 19:41:03.539+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.539+0200 I/linearacceleration(19560): capturing data from es.ugr.frailty.linearacceleration
04-23 19:41:03.549+0200 I/gravity (19576): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:41:03:549,-4.777306,-7.605417,3.937686
04-23 19:41:03.549+0200 I/gravity (19576): capturing data from es.ugr.frailty.gravity
04-23 19:41:03.549+0200 I/linearacceleration(19560): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:41:03:552,0.808933,-0.296244,-0.530306
04-23 19:41:03.549+0200 W/CRASH_MANAGER(18968): worker.c: worker_job(1205) > 11195736c6f63152450526
