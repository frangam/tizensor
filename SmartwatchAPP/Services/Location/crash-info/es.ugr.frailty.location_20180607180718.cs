S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 26555
Date: 2018-06-07 18:07:18+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf715452d, r5   = 0xf794f958
r6   = 0xff96c1f0, r7   = 0xff96c0a0
r8   = 0xf7962c18, r9   = 0x00000000
r10  = 0xff96c17c, fp   = 0xff96c1f0
ip   = 0x00000001, sp   = 0xff96c078
lr   = 0xf7154539, pc   = 0xf71bd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    273876 KB
Buffers:     11744 KB
Cached:     106476 KB
VmPeak:      53636 KB
VmSize:      53632 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11800 KB
VmRSS:       11800 KB
VmData:      11360 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 26555 TID = 26555
26555 26656 

Maps Information
f401f000 f481e000 rw-p [stack:26656]
f4825000 f4827000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f482f000 f4833000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f483c000 f483e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4846000 f4849000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4858000 f485d000 r-xp /usr/lib/libsystem.so.0.0.0
f4868000 f486b000 r-xp /lib/libattr.so.1.1.0
f4873000 f4883000 r-xp /usr/lib/libmdm-common.so.1.1.24
f488b000 f4894000 r-xp /usr/lib/libedbus.so.1.7.99
f489c000 f489d000 r-xp /usr/lib/libresponse.so.0.2.96
f48a6000 f48ab000 r-xp /usr/lib/libproc-stat.so.0.2.96
f614d000 f6253000 r-xp /usr/lib/libicuuc.so.57.1
f6269000 f63f1000 r-xp /usr/lib/libicui18n.so.57.1
f6401000 f640e000 r-xp /usr/lib/libail.so.0.1.0
f6417000 f641e000 r-xp /usr/lib/libminizip.so.1.0.0
f6427000 f65d0000 r-xp /usr/lib/libcrypto.so.1.0.0
f65f0000 f6637000 r-xp /usr/lib/libssl.so.1.0.0
f6643000 f6645000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f664d000 f6654000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f665d000 f6664000 r-xp /lib/libcrypt-2.13.so
f6695000 f6698000 r-xp /lib/libcap.so.2.21
f66a0000 f66a2000 r-xp /usr/lib/libiri.so
f66aa000 f66f3000 r-xp /usr/lib/libmdm.so.1.2.69
f66fb000 f6701000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6709000 f672c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6736000 f6738000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6740000 f675d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6766000 f676a000 r-xp /usr/lib/libsmack.so.1.0.0
f6773000 f678c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6795000 f679d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67a5000 f67ab000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67b4000 f67b6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67bf000 f67cf000 r-xp /lib/libresolv-2.13.so
f67d3000 f67eb000 r-xp /usr/lib/liblzma.so.5.0.3
f67f4000 f67f6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67fe000 f6818000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6820000 f684f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6858000 f6867000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6871000 f687b000 r-xp /usr/lib/libsensord-shared.so
f6884000 f6957000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6962000 f6978000 r-xp /lib/libz.so.1.2.5
f6980000 f6985000 r-xp /usr/lib/libffi.so.5.0.10
f698d000 f698e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6996000 f69a6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69ae000 f69c7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69cf000 f69d1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69d9000 f6a4e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a58000 f6a5e000 r-xp /lib/librt-2.13.so
f6a67000 f6a85000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a8f000 f6a90000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a98000 f6abb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ac3000 f6ac8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ad0000 f6afa000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b03000 f6b1a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b22000 f6b8b000 r-xp /lib/libm-2.13.so
f6b94000 f6c28000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c3b000 f6c40000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c48000 f6c4f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c57000 f6c81000 r-xp /usr/lib/libsensor.so.1.9.6
f6c8a000 f6d56000 r-xp /usr/lib/libxml2.so.2.7.8
f6d63000 f6d65000 r-xp /usr/lib/libiniparser.so.0
f6d6e000 f6d74000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d7d000 f6e4d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e4e000 f6e82000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e8b000 f6ec7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ecf000 f6ed2000 r-xp /usr/lib/libbundle.so.0.1.22
f6eda000 f6ee0000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ee8000 f6f29000 r-xp /usr/lib/libeina.so.1.7.99
f6f32000 f6f49000 r-xp /usr/lib/libecore.so.1.7.99
f6f60000 f6f69000 r-xp /usr/lib/libvconf.so.0.2.45
f6f71000 f6f85000 r-xp /lib/libpthread-2.13.so
f6f90000 f6f9d000 r-xp /usr/lib/libaul.so.0.1.0
f6fa7000 f6fa9000 r-xp /lib/libdl-2.13.so
f6fb2000 f6fbd000 r-xp /lib/libunwind.so.8.0.1
f6fea000 f6ff2000 r-xp /lib/libgcc_s-4.6.so.1
f6ff3000 f7117000 r-xp /lib/libc-2.13.so
f7125000 f7127000 r-xp /usr/lib/libdlog.so.0.0.0
f712f000 f713b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7144000 f7149000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7151000 f7160000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7168000 f716c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7175000 f7178000 r-xp /usr/lib/libappcore-agent.so.1.1
f7180000 f7182000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f718a000 f718e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7196000 f71b3000 r-xp /lib/ld-2.13.so
f71bc000 f71bf000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71bf000 f71c3000 r-xp /usr/lib/libsys-assert.so
f7932000 f79d1000 rw-p [heap]
ff94d000 ff96e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26555)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71bd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7154539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e5b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e59c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e65e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e6bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e6bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ea075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e9b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e59c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e65e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e6bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e6bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e9de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e9e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ea5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf483d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4830171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6903663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6db0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6db27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f42ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f3db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f3e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f3e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7176183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71767fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71bd5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf700a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf71bcf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.411+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:417,0.327548,-0.079102,9.800859
06-07 18:07:17.421+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:403,-0.140000,-0.070000,0.070000
06-07 18:07:17.421+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.421+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.421+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:427,0.354138,-0.078963,9.832108
06-07 18:07:17.431+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.431+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.431+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:429,-0.140000,0.070000,0.070000
06-07 18:07:17.441+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:436,0.329234,-0.079379,9.800800
06-07 18:07:17.441+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.441+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:447,-0.140000,0.070000,0.070000
06-07 18:07:17.451+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.451+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:457,0.329509,-0.078711,9.800797
06-07 18:07:17.461+0200 I/heartrate(26551): es.ugr.frailty.heartrate - capturing data
06-07 18:07:17.461+0200 I/heartrate(26551): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:17.461+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:439,0.330210,-0.062213,9.784252
06-07 18:07:17.471+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:417,0.028392,-0.001069,0.031179
06-07 18:07:17.471+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.471+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.481+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.491+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:478,-0.070000,0.070000,0.070000
06-07 18:07:17.491+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:484,0.002662,0.016888,-0.016607
06-07 18:07:17.491+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.501+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:488,0.318245,-0.100499,9.834501
06-07 18:07:17.501+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:07:17.501+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:502,-0.010988,-0.021119,0.033701
06-07 18:07:17.511+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:07:17.511+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:07:17.511+0200 I/light   (26605): es.ugr.frailty.light - capturing data
06-07 18:07:17.511+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.521+0200 I/light   (26605): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:17:522,1996.000000
06-07 18:07:17.521+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.521+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.521+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:529,0.328343,-0.079567,9.800829
06-07 18:07:17.521+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:530,0.334995,-0.066999,9.858429
06-07 18:07:17.531+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.531+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.531+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:526,0.070000,0.070000,0.070000
06-07 18:07:17.531+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.531+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.541+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:536,0.005486,0.011712,0.057632
06-07 18:07:17.541+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:539,0.289532,-0.071785,9.824929
06-07 18:07:17.541+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.541+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.541+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:544,0.328104,-0.078786,9.800843
06-07 18:07:17.551+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:544,0.070000,0.070000,0.070000
06-07 18:07:17.551+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.551+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.551+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:550,-0.039977,0.006927,0.024133
06-07 18:07:17.551+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:554,0.320638,-0.040678,9.827322
06-07 18:07:17.551+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.551+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.561+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:561,0.070000,0.070000,0.070000
06-07 18:07:17.561+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:561,0.325714,-0.078283,9.800927
06-07 18:07:17.561+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:565,-0.008871,0.038033,0.026525
06-07 18:07:17.561+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:569,0.330210,-0.069392,9.812965
06-07 18:07:17.571+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.571+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.571+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.571+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.571+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:579,0.342174,-0.069392,9.860823
06-07 18:07:17.581+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:578,0.004495,0.008891,0.012038
06-07 18:07:17.581+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.581+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.581+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:580,0.070000,0.070000,0.070000
06-07 18:07:17.581+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.581+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:584,0.325095,-0.076304,9.800963
06-07 18:07:17.581+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:589,0.313460,-0.110070,9.872787
06-07 18:07:17.591+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.591+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:589,0.017079,0.006912,0.059859
06-07 18:07:17.591+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.591+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.591+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:591,0.070000,0.070000,0.070000
06-07 18:07:17.591+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:597,0.324834,-0.075807,9.800976
06-07 18:07:17.591+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.601+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:603,0.327817,-0.090927,9.836893
06-07 18:07:17.601+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.601+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:600,-0.011374,-0.034263,0.071811
06-07 18:07:17.601+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.601+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:608,0.325055,-0.075321,9.800972
06-07 18:07:17.601+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:610,0.002762,-0.015606,0.035921
06-07 18:07:17.611+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:605,0.070000,0.070000,0.070000
06-07 18:07:17.611+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.611+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.611+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:617,0.344566,-0.105284,9.834501
06-07 18:07:17.611+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:617,0.070000,0.070000,0.070000
06-07 18:07:17.611+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.611+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.621+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.621+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:622,0.070000,0.070000,0.070000
06-07 18:07:17.621+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:623,0.020738,-0.028512,0.033500
06-07 18:07:17.621+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:627,0.323829,-0.076772,9.801002
06-07 18:07:17.621+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.631+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.631+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.631+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:637,0.001945,-0.023241,0.033492
06-07 18:07:17.631+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.631+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:637,0.325424,-0.100499,9.834501
06-07 18:07:17.631+0200 I/heartrate(26551): es.ugr.frailty.heartrate - capturing data
06-07 18:07:17.631+0200 I/heartrate(26551): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:17.641+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:641,-0.070000,0.070000,0.070000
06-07 18:07:17.641+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:635,0.323478,-0.077258,9.801009
06-07 18:07:17.641+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.641+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:648,0.324668,-0.078683,9.800959
06-07 18:07:17.641+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.651+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.651+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:655,0.339781,-0.086142,9.865608
06-07 18:07:17.651+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:655,0.015113,-0.007459,0.064650
06-07 18:07:17.651+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.651+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.651+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:660,-0.070000,0.070000,0.070000
06-07 18:07:17.651+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:660,0.324798,-0.079834,9.800944
06-07 18:07:17.661+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.661+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.671+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:675,-0.006553,0.020013,0.033557
06-07 18:07:17.671+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.671+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:675,0.318245,-0.059821,9.834501
06-07 18:07:17.671+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.671+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:680,-0.070000,0.070000,0.070000
06-07 18:07:17.681+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:681,0.325558,-0.080241,9.800916
06-07 18:07:17.691+0200 I/light   (26605): es.ugr.frailty.light - capturing data
06-07 18:07:17.691+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.691+0200 I/light   (26605): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:17:696,2017.000000
06-07 18:07:17.691+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:696,0.311067,-0.045464,9.879964
06-07 18:07:17.691+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.691+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.701+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:701,-0.014491,0.034778,0.079048
06-07 18:07:17.701+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.701+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:702,0.325376,-0.079387,9.800929
06-07 18:07:17.701+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:707,-0.070000,0.070000,0.070000
06-07 18:07:17.711+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.711+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.711+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:716,0.324916,-0.077863,9.800957
06-07 18:07:17.711+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.711+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:716,0.327817,-0.114855,9.860823
06-07 18:07:17.711+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.711+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:721,-0.070000,0.070000,0.070000
06-07 18:07:17.721+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:722,0.002441,-0.035468,0.059894
06-07 18:07:17.721+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.721+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.731+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:735,0.279960,-0.100499,9.841680
06-07 18:07:17.731+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:735,0.325130,-0.079704,9.800935
06-07 18:07:17.731+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.731+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.741+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:741,-0.070000,0.070000,0.070000
06-07 18:07:17.741+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:741,-0.044955,-0.022635,0.040723
06-07 18:07:17.751+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.751+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.751+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.751+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:757,0.322753,-0.080868,9.801003
06-07 18:07:17.751+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:756,0.330210,-0.033500,9.796216
06-07 18:07:17.751+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.761+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:756,-0.070000,0.070000,0.070000
06-07 18:07:17.761+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:762,0.005079,0.046204,-0.004719
06-07 18:07:17.761+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.761+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.771+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.771+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.781+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:775,0.342174,-0.093320,9.832108
06-07 18:07:17.781+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:775,0.323653,-0.078793,9.800991
06-07 18:07:17.791+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.791+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:785,-0.070000,-0.070000,0.070000
06-07 18:07:17.791+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.801+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.801+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:800,-0.070000,-0.070000,0.070000
06-07 18:07:17.801+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:786,0.019421,-0.012452,0.031105
06-07 18:07:17.801+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:797,0.311067,-0.088534,9.844072
06-07 18:07:17.811+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.811+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.811+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.821+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:819,-0.070000,0.140000,0.140000
06-07 18:07:17.821+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:806,0.324961,-0.079632,9.800941
06-07 18:07:17.821+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.821+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:822,0.313460,-0.100499,9.858429
06-07 18:07:17.821+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.831+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:825,-0.012586,-0.009742,0.043081
06-07 18:07:17.831+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:829,0.324166,-0.080163,9.800963
06-07 18:07:17.831+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:836,0.070000,0.070000,0.140000
06-07 18:07:17.831+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.831+0200 I/heartrate(26551): es.ugr.frailty.heartrate - capturing data
06-07 18:07:17.831+0200 I/heartrate(26551): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:17.831+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.841+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.841+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:845,0.351745,-0.050249,9.779467
06-07 18:07:17.841+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:843,-0.011501,-0.020867,0.057488
06-07 18:07:17.851+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.851+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.851+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:856,-0.070000,0.070000,0.140000
06-07 18:07:17.851+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.851+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:851,0.323019,-0.080941,9.800995
06-07 18:07:17.861+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.861+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:864,0.027579,0.029914,-0.021497
06-07 18:07:17.861+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:857,0.337388,-0.081356,9.810574
06-07 18:07:17.861+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.861+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:866,0.324463,-0.079665,9.800957
06-07 18:07:17.871+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.871+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.871+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:876,0.342174,-0.069392,9.848858
06-07 18:07:17.871+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:877,-0.070000,0.070000,0.070000
06-07 18:07:17.871+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.871+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:871,0.014369,-0.000415,0.009579
06-07 18:07:17.871+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.881+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:882,0.325212,-0.079878,9.800931
06-07 18:07:17.881+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:885,0.017710,0.010273,0.047901
06-07 18:07:17.891+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.891+0200 I/light   (26605): es.ugr.frailty.light - capturing data
06-07 18:07:17.891+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:896,-0.070000,0.070000,0.070000
06-07 18:07:17.891+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.891+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.901+0200 I/light   (26605): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:17:897,2026.000000
06-07 18:07:17.901+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.901+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:903,-0.006967,0.024843,0.062284
06-07 18:07:17.901+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:901,0.318245,-0.055035,9.863215
06-07 18:07:17.901+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:907,0.326082,-0.079509,9.800904
06-07 18:07:17.911+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.911+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.911+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:916,-0.070000,0.070000,0.140000
06-07 18:07:17.911+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.911+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.921+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:917,0.296710,-0.102891,9.879964
06-07 18:07:17.921+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:922,-0.029372,-0.023383,0.079060
06-07 18:07:17.921+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:922,0.325857,-0.078455,9.800920
06-07 18:07:17.931+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.931+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.931+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:936,-0.140000,-0.070000,0.070000
06-07 18:07:17.931+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:936,0.346959,-0.093320,9.824929
06-07 18:07:17.931+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.931+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.941+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:942,0.021102,-0.014865,0.024009
06-07 18:07:17.941+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:941,0.324913,-0.079935,9.800941
06-07 18:07:17.951+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.951+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.951+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:956,-0.070000,0.070000,0.070000
06-07 18:07:17.951+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:956,0.289532,-0.050249,9.781858
06-07 18:07:17.951+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:17.951+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:17.961+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:17:961,0.326093,-0.080687,9.800895
06-07 18:07:17.961+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:17:962,-0.035381,0.029686,-0.019082
06-07 18:07:17.961+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:17.981+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:17.981+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:17:986,-0.070000,-0.070000,0.070000
06-07 18:07:17.991+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:17:975,0.311067,-0.100499,9.853643
06-07 18:07:17.991+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.001+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.021+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.031+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:14,-0.015026,-0.019812,0.052749
06-07 18:07:18.041+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:16,0.325059,-0.079377,9.800940
06-07 18:07:18.041+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.041+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.041+0200 I/heartrate(26551): es.ugr.frailty.heartrate - capturing data
06-07 18:07:18.041+0200 I/heartrate(26551): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:18.041+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.051+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:53,-0.070000,0.070000,0.070000
06-07 18:07:18.051+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.061+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:65,-0.070000,0.070000,0.070000
06-07 18:07:18.071+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:74,0.324366,-0.080499,9.800954
06-07 18:07:18.071+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:29,0.315853,-0.076570,9.836893
06-07 18:07:18.071+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.081+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:70,-0.009206,0.002806,0.035954
06-07 18:07:18.081+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:85,0.380459,-0.066999,9.896714
06-07 18:07:18.081+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.081+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.091+0200 I/light   (26605): es.ugr.frailty.light - capturing data
06-07 18:07:18.091+0200 I/light   (26605): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:18:97,2027.000000
06-07 18:07:18.091+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.101+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.111+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:104,0.324056,-0.080434,9.800964
06-07 18:07:18.121+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:109,0.056093,0.013500,0.095760
06-07 18:07:18.121+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:106,-0.070000,0.070000,0.070000
06-07 18:07:18.121+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.121+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.121+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:118,0.311067,-0.055035,9.803394
06-07 18:07:18.131+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.131+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.141+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:140,-0.012989,0.025399,0.002430
06-07 18:07:18.151+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:142,0.326556,-0.079954,9.800885
06-07 18:07:18.151+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:137,-0.070000,0.070000,0.140000
06-07 18:07:18.151+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:145,0.325424,-0.083749,9.851252
06-07 18:07:18.151+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.151+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.151+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.161+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.171+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:163,-0.070000,0.070000,0.140000
06-07 18:07:18.171+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:174,0.327817,-0.098106,9.820145
06-07 18:07:18.171+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:165,0.326083,-0.078892,9.800910
06-07 18:07:18.171+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:164,-0.001132,-0.003795,0.050366
06-07 18:07:18.171+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.171+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.181+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:185,-0.070000,0.070000,0.070000
06-07 18:07:18.181+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.191+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.201+0200 W/LOCATION(26555): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 18:07:18.201+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:190,0.001734,-0.019214,0.019235
06-07 18:07:18.201+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:197,0.326101,-0.079240,9.800906
06-07 18:07:18.201+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.201+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.211+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:199,0.315853,-0.081356,9.822537
06-07 18:07:18.211+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.211+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:218,0.327817,-0.074178,9.860823
06-07 18:07:18.211+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.211+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:220,-0.010248,-0.002116,0.021631
06-07 18:07:18.211+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.211+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.221+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:223,0.325424,-0.102891,9.779467
06-07 18:07:18.221+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:225,0.326283,-0.080256,9.800892
06-07 18:07:18.221+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.221+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:212,0.070000,0.070000,0.070000
06-07 18:07:18.221+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.221+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.231+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:229,0.289532,-0.035892,9.846465
06-07 18:07:18.231+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.231+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:234,0.140000,0.070000,0.070000
06-07 18:07:18.231+0200 I/heartrate(26551): es.ugr.frailty.heartrate - capturing data
06-07 18:07:18.231+0200 I/heartrate(26551): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:18.231+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:238,0.332602,-0.064606,9.822537
06-07 18:07:18.231+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.241+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:224,0.001533,0.006078,0.059931
06-07 18:07:18.241+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.241+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:245,0.327817,-0.083749,9.829715
06-07 18:07:18.241+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.251+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.251+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:252,0.339781,-0.114855,9.834501
06-07 18:07:18.251+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:235,0.325256,-0.080133,9.800927
06-07 18:07:18.251+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.251+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.261+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:261,0.320638,-0.076570,9.815358
06-07 18:07:18.261+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.261+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:266,0.325424,-0.131605,9.872787
06-07 18:07:18.261+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:249,0.000168,-0.022758,-0.021461
06-07 18:07:18.261+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:256,-0.070000,0.070000,0.070000
06-07 18:07:18.261+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:260,0.324502,-0.079509,9.800957
06-07 18:07:18.261+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.271+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.271+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.271+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.271+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:275,-0.034971,0.043617,0.045508
06-07 18:07:18.271+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.281+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:283,-0.070000,0.070000,0.070000
06-07 18:07:18.281+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:277,0.320638,-0.059821,9.844072
06-07 18:07:18.281+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.281+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:277,0.324723,-0.080757,9.800940
06-07 18:07:18.281+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.281+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:290,0.070000,0.070000,0.070000
06-07 18:07:18.281+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.291+0200 I/light   (26605): es.ugr.frailty.light - capturing data
06-07 18:07:18.291+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:284,0.007879,0.016150,0.021598
06-07 18:07:18.291+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.291+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.291+0200 I/light   (26605): es.ugr.frailty.light: SM-R760,07/06/2018,18:07:18:297,2027.000000
06-07 18:07:18.301+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:300,0.323031,-0.047856,9.820145
06-07 18:07:18.301+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:290,0.323543,-0.078676,9.800996
06-07 18:07:18.301+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.301+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:308,0.323470,-0.077839,9.801004
06-07 18:07:18.301+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.301+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:295,-0.070000,-0.070000,0.070000
06-07 18:07:18.301+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.311+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.311+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:300,0.004274,-0.005072,0.028719
06-07 18:07:18.311+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.311+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:317,0.284746,-0.093320,9.815358
06-07 18:07:18.321+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:314,-0.070000,-0.070000,0.070000
06-07 18:07:18.321+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.321+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:312,0.324086,-0.078279,9.800981
06-07 18:07:18.321+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.321+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:327,-0.070000,-0.070000,0.070000
06-07 18:07:18.321+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.321+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:329,0.325318,-0.080134,9.800925
06-07 18:07:18.321+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.331+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.331+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:319,0.016311,-0.037017,0.033497
06-07 18:07:18.331+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.331+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:336,0.320638,-0.047856,9.834501
06-07 18:07:18.331+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:331,-0.140000,-0.070000,0.070000
06-07 18:07:18.331+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.341+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:344,-0.070000,-0.070000,0.070000
06-07 18:07:18.341+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.341+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:337,-0.003447,0.001708,0.014378
06-07 18:07:18.341+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.341+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:348,-0.070000,-0.070000,0.070000
06-07 18:07:18.341+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:350,0.000106,-0.051471,0.071861
06-07 18:07:18.341+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.341+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.351+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.351+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:333,0.325531,-0.080132,9.800918
06-07 18:07:18.351+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:357,0.346959,-0.095713,9.839286
06-07 18:07:18.351+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.361+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:354,-0.070000,-0.070000,0.070000
06-07 18:07:18.361+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.361+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:368,0.070000,-0.070000,0.070000
06-07 18:07:18.361+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:353,-0.004893,0.020312,0.043155
06-07 18:07:18.361+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.361+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.371+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.371+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:376,0.342174,-0.071785,9.815358
06-07 18:07:18.371+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:362,0.326196,-0.082823,9.800874
06-07 18:07:18.371+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.381+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:373,-0.003165,0.034967,0.019271
06-07 18:07:18.381+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.381+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:384,0.326397,-0.081882,9.800875
06-07 18:07:18.381+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.381+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:375,0.140000,0.070000,0.070000
06-07 18:07:18.391+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.391+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.391+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:396,-0.070000,0.070000,0.070000
06-07 18:07:18.391+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:397,0.349352,-0.066999,9.836893
06-07 18:07:18.391+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:390,0.326788,-0.080422,9.800874
06-07 18:07:18.391+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:387,-0.041651,-0.011438,0.014483
06-07 18:07:18.391+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.401+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.401+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:07:18:407,-0.006149,0.032566,0.033628
06-07 18:07:18.411+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.411+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.411+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:417,0.210000,0.070000,0.070000
06-07 18:07:18.411+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:419,0.351745,-0.050249,9.856036
06-07 18:07:18.421+0200 I/linearacceleration(26568): es.ugr.frailty.linearacceleration - capturing data
06-07 18:07:18.421+0200 I/gravity (26581): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:07:18:410,0.324978,-0.081243,9.800927
06-07 18:07:18.421+0200 I/gravity (26581): es.ugr.frailty.gravity - capturing data
06-07 18:07:18.421+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.431+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.431+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:435,0.140000,0.070000,0.070000
06-07 18:07:18.431+0200 I/heartrate(26551): es.ugr.frailty.heartrate - capturing data
06-07 18:07:18.431+0200 I/heartrate(26551): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:07:18.441+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:07:18:436,0.332602,-0.107677,9.817751
06-07 18:07:18.441+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.451+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:455,0.210000,0.070000,0.070000
06-07 18:07:18.451+0200 I/accelerometer(26526): es.ugr.frailty.accelerometer - capturing data
06-07 18:07:18.491+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:07:18.491+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:07:18.491+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:07:18.501+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.501+0200 I/light   (26605): es.ugr.frailty.light - capturing data
06-07 18:07:18.501+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:505,0.210000,0.070000,0.070000
06-07 18:07:18.501+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.501+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:510,0.070000,0.070000,0.070000
06-07 18:07:18.511+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.511+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:07:18:521,0.070000,0.070000,0.070000
06-07 18:07:18.531+0200 I/gyroscope(26538): es.ugr.frailty.gyroscope - capturing data
06-07 18:07:18.531+0200 W/CRASH_MANAGER(26455): worker.c: worker_job(1205) > 11265556c6f63152838763
