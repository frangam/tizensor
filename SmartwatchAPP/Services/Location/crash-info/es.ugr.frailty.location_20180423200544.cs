S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5855
Date: 2018-04-23 20:05:44+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf755a52d, r5   = 0xf7ce6f98
r6   = 0xffc45570, r7   = 0xffc45420
r8   = 0xf7ce3c18, r9   = 0x00000000
r10  = 0xffc454fc, fp   = 0xffc45570
ip   = 0x00000001, sp   = 0xffc453f8
lr   = 0xf755a539, pc   = 0xf75c3228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5380 KB
Buffers:     37264 KB
Cached:     199668 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12112 KB
VmRSS:       12112 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5855 TID = 5855
5855 5876 

Maps Information
f4425000 f4c24000 rw-p [stack:5876]
f4c2b000 f4c2d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c35000 f4c39000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c42000 f4c44000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c4c000 f4c4f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c5e000 f4c63000 r-xp /usr/lib/libsystem.so.0.0.0
f4c6e000 f4c71000 r-xp /lib/libattr.so.1.1.0
f4c79000 f4c89000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c91000 f4c9a000 r-xp /usr/lib/libedbus.so.1.7.99
f4ca2000 f4ca3000 r-xp /usr/lib/libresponse.so.0.2.96
f4cac000 f4cb1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6553000 f6659000 r-xp /usr/lib/libicuuc.so.57.1
f666f000 f67f7000 r-xp /usr/lib/libicui18n.so.57.1
f6807000 f6814000 r-xp /usr/lib/libail.so.0.1.0
f681d000 f6824000 r-xp /usr/lib/libminizip.so.1.0.0
f682d000 f69d6000 r-xp /usr/lib/libcrypto.so.1.0.0
f69f6000 f6a3d000 r-xp /usr/lib/libssl.so.1.0.0
f6a49000 f6a4b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a53000 f6a5a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a63000 f6a6a000 r-xp /lib/libcrypt-2.13.so
f6a9b000 f6a9e000 r-xp /lib/libcap.so.2.21
f6aa6000 f6aa8000 r-xp /usr/lib/libiri.so
f6ab0000 f6af9000 r-xp /usr/lib/libmdm.so.1.2.69
f6b01000 f6b07000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b0f000 f6b32000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b3c000 f6b3e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b46000 f6b63000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b6c000 f6b70000 r-xp /usr/lib/libsmack.so.1.0.0
f6b79000 f6b92000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b9b000 f6ba3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bab000 f6bb1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bba000 f6bbc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bc5000 f6bd5000 r-xp /lib/libresolv-2.13.so
f6bd9000 f6bf1000 r-xp /usr/lib/liblzma.so.5.0.3
f6bfa000 f6bfc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c04000 f6c1e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c26000 f6c55000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c5e000 f6c6d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c77000 f6c81000 r-xp /usr/lib/libsensord-shared.so
f6c8a000 f6d5d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d68000 f6d7e000 r-xp /lib/libz.so.1.2.5
f6d86000 f6d8b000 r-xp /usr/lib/libffi.so.5.0.10
f6d93000 f6d94000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d9c000 f6dac000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6db4000 f6dcd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6dd5000 f6dd7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ddf000 f6e54000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e5e000 f6e64000 r-xp /lib/librt-2.13.so
f6e6d000 f6e8b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e95000 f6e96000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e9e000 f6ec1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ec9000 f6ece000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ed6000 f6f00000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f09000 f6f20000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f28000 f6f91000 r-xp /lib/libm-2.13.so
f6f9a000 f702e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7041000 f7046000 r-xp /usr/lib/libctx-client.so.0.8.3
f704e000 f7055000 r-xp /usr/lib/libctx-shared.so.0.8.3
f705d000 f7087000 r-xp /usr/lib/libsensor.so.1.9.6
f7090000 f715c000 r-xp /usr/lib/libxml2.so.2.7.8
f7169000 f716b000 r-xp /usr/lib/libiniparser.so.0
f7174000 f717a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7183000 f7253000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7254000 f7288000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7291000 f72cd000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72d5000 f72d8000 r-xp /usr/lib/libbundle.so.0.1.22
f72e0000 f72e6000 r-xp /usr/lib/libappsvc.so.0.1.0
f72ee000 f732f000 r-xp /usr/lib/libeina.so.1.7.99
f7338000 f734f000 r-xp /usr/lib/libecore.so.1.7.99
f7366000 f736f000 r-xp /usr/lib/libvconf.so.0.2.45
f7377000 f738b000 r-xp /lib/libpthread-2.13.so
f7396000 f73a3000 r-xp /usr/lib/libaul.so.0.1.0
f73ad000 f73af000 r-xp /lib/libdl-2.13.so
f73b8000 f73c3000 r-xp /lib/libunwind.so.8.0.1
f73f0000 f73f8000 r-xp /lib/libgcc_s-4.6.so.1
f73f9000 f751d000 r-xp /lib/libc-2.13.so
f752b000 f752d000 r-xp /usr/lib/libdlog.so.0.0.0
f7535000 f7541000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f754a000 f754f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7557000 f7566000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f756e000 f7572000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f757b000 f757e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7586000 f7588000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7590000 f7594000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f759c000 f75b9000 r-xp /lib/ld-2.13.so
f75c2000 f75c5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75c5000 f75c9000 r-xp /usr/lib/libsys-assert.so
f7cb3000 f7d3d000 rw-p [heap]
ffc26000 ffc47000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5855)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75c3228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf755a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72613f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf725fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf726be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7271be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7271dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72a675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72a11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf725fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf726be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7271be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7271dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72a3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72a4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72abf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c431fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c36171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d09663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71b6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71b87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7348ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7343b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73445a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7344879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf757c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf757c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75c34f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf741085c) [/lib/libc.so.6] + 0x1785c
29: (0xf75c2f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ty ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:298,0.058968,9.773615,0.802102
04-23 20:05:43.309+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:303,0.010087,0.055978,-0.032663
04-23 20:05:43.309+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:302,0.066999,9.829715,0.768096
04-23 20:05:43.309+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.309+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.309+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.309+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.329+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:323,0.056912,9.773737,0.800759
04-23 20:05:43.329+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:320,-0.070000,0.070000,0.070000
04-23 20:05:43.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:05:43.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:43.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:05:43.339+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:325,0.047856,9.808180,0.784846
04-23 20:05:43.339+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.339+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.349+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.349+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:327,-0.007450,0.034350,-0.014895
04-23 20:05:43.359+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:363,0.059821,9.834501,0.792024
04-23 20:05:43.359+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.359+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:356,-0.070000,0.070000,-0.070000
04-23 20:05:43.369+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:358,0.055307,9.773829,0.799741
04-23 20:05:43.369+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:367,0.003820,0.060618,-0.007014
04-23 20:05:43.369+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.369+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.369+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.379+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.379+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:43.379+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:43.389+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:380,-0.070000,0.070000,-0.070000
04-23 20:05:43.389+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:391,-0.007899,0.005636,0.018652
04-23 20:05:43.389+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:382,0.056001,9.773883,0.799039
04-23 20:05:43.389+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:384,0.047856,9.779467,0.818345
04-23 20:05:43.389+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.399+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.399+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.409+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.409+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:414,0.055035,9.808180,0.815953
04-23 20:05:43.409+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:414,0.055756,9.773830,0.799694
04-23 20:05:43.419+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:423,-0.001051,0.034418,0.015445
04-23 20:05:43.419+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:412,-0.070000,0.070000,0.070000
04-23 20:05:43.419+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.429+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.429+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.429+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.439+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:445,-0.051062,0.046565,-0.058581
04-23 20:05:43.439+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:434,-0.070000,0.070000,0.070000
04-23 20:05:43.449+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:443,0.004786,9.820145,0.744168
04-23 20:05:43.449+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:440,0.056086,9.773762,0.800507
04-23 20:05:43.449+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.449+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.449+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.459+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.469+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:464,0.055848,9.773580,0.802749
04-23 20:05:43.479+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:460,-0.140000,0.070000,0.070000
04-23 20:05:43.479+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:465,0.064606,9.820145,0.811167
04-23 20:05:43.479+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.479+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.479+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:469,0.008663,0.046746,0.006220
04-23 20:05:43.479+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.489+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.499+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:492,-0.070000,0.070000,0.070000
04-23 20:05:43.499+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:502,-0.017722,0.018015,-0.041590
04-23 20:05:43.509+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:499,0.035892,9.791430,0.763310
04-23 20:05:43.509+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:495,0.055943,9.773398,0.804947
04-23 20:05:43.509+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.509+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.509+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.519+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.519+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:527,0.052642,9.786645,0.772882
04-23 20:05:43.529+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:520,-0.140000,0.210000,0.070000
04-23 20:05:43.529+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:524,0.053615,9.773416,0.804900
04-23 20:05:43.529+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.529+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.529+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.539+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:528,-0.001625,0.013346,-0.033381
04-23 20:05:43.539+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.619+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:43.619+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:43.619+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:545,0.021535,9.786645,0.789631
04-23 20:05:43.619+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:541,-0.070000,0.070000,0.070000
04-23 20:05:43.629+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.629+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:563,0.054267,9.773299,0.806263
04-23 20:05:43.629+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.629+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.629+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:626,-0.031998,0.013319,-0.016353
04-23 20:05:43.629+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.639+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:645,-0.017746,0.020475,-0.035228
04-23 20:05:43.639+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:642,0.053533,9.773326,0.805985
04-23 20:05:43.649+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:638,-0.070000,0.070000,0.070000
04-23 20:05:43.649+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:640,0.035892,9.793823,0.770489
04-23 20:05:43.649+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.649+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.649+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.659+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.659+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:665,0.033500,9.796216,0.760918
04-23 20:05:43.659+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:669,-0.018761,0.022964,-0.046047
04-23 20:05:43.669+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:660,-0.070000,0.070000,0.070000
04-23 20:05:43.669+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.669+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:664,0.053639,9.773348,0.805717
04-23 20:05:43.669+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.669+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.679+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.689+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:684,0.014357,9.796216,0.775275
04-23 20:05:43.689+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:681,-0.070000,0.070000,0.070000
04-23 20:05:43.689+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:686,0.052261,9.773252,0.806965
04-23 20:05:43.689+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.689+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.689+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.689+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:689,-0.037267,0.022962,-0.031711
04-23 20:05:43.699+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:703,-0.070000,0.070000,0.070000
04-23 20:05:43.699+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.709+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:708,0.051624,9.773254,0.806985
04-23 20:05:43.709+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:713,-0.000350,0.022726,0.014155
04-23 20:05:43.709+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:710,0.050249,9.796216,0.818345
04-23 20:05:43.709+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.709+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.719+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.719+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:724,-0.070000,0.070000,0.070000
04-23 20:05:43.719+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.719+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:729,0.050599,9.773490,0.804190
04-23 20:05:43.739+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:733,0.016750,9.798609,0.803988
04-23 20:05:43.739+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.739+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:736,-0.031956,0.024986,0.001293
04-23 20:05:43.739+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.739+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.739+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.759+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:748,-0.070000,0.070000,-0.070000
04-23 20:05:43.759+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:758,-0.032172,0.087379,-0.103767
04-23 20:05:43.759+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.769+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:755,0.016750,9.860823,0.701097
04-23 20:05:43.769+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:753,0.048706,9.773623,0.802696
04-23 20:05:43.769+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:43.769+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:43.769+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.769+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.769+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.779+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:785,0.040678,9.801002,0.777667
04-23 20:05:43.779+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:789,-0.006869,0.027712,-0.029132
04-23 20:05:43.789+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:783,0.048922,9.773443,0.804864
04-23 20:05:43.789+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:775,-0.070000,0.140000,-0.070000
04-23 20:05:43.789+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.789+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.789+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.789+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:799,-0.070000,0.070000,0.070000
04-23 20:05:43.799+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:803,0.047547,9.773290,0.806800
04-23 20:05:43.799+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.799+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:807,0.059821,9.765109,0.799203
04-23 20:05:43.809+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.809+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.809+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.809+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:811,0.013643,-0.008372,-0.005357
04-23 20:05:43.819+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:823,0.046178,9.773481,0.804560
04-23 20:05:43.819+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.819+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:828,0.019143,9.796216,0.835095
04-23 20:05:43.829+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:817,-0.070000,0.070000,0.070000
04-23 20:05:43.829+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.829+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:831,-0.026929,0.022741,0.030450
04-23 20:05:43.829+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.839+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.839+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.839+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:844,0.057428,9.844072,0.760918
04-23 20:05:43.839+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:842,0.046072,9.773475,0.804645
04-23 20:05:43.849+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:839,-0.070000,0.070000,0.070000
04-23 20:05:43.849+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.849+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:853,0.010846,0.070453,-0.041930
04-23 20:05:43.859+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.859+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.859+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:869,0.046582,9.773620,0.802848
04-23 20:05:43.869+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.869+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:872,0.002393,9.836893,0.753739
04-23 20:05:43.869+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:860,-0.070000,-0.070000,0.070000
04-23 20:05:43.879+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.879+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:884,-0.070000,-0.070000,-0.070000
04-23 20:05:43.879+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.879+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.879+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:876,-0.042763,0.063286,-0.049341
04-23 20:05:43.889+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.909+0200 W/LOCATION( 5855): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:05:43.919+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.919+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:891,0.045155,9.773607,0.803081
04-23 20:05:43.929+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:894,0.090927,9.801002,0.758525
04-23 20:05:43.929+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:900,0.045350,0.027083,-0.040748
04-23 20:05:43.929+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.939+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.949+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:954,0.045577,9.773918,0.799273
04-23 20:05:43.949+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.959+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:946,0.009571,9.798609,0.768096
04-23 20:05:43.959+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:933,-0.070000,-0.070000,-0.070000
04-23 20:05:43.969+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.969+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:43.969+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:43.969+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:43.969+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:43.969+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:961,-0.033779,0.024477,-0.028678
04-23 20:05:43.979+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:43.989+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:43:995,0.033473,0.019357,-0.010086
04-23 20:05:43.989+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:43:986,0.043350,9.774132,0.796774
04-23 20:05:43.999+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:43:975,-0.070000,0.070000,-0.070000
04-23 20:05:43.999+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:43.999+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:43:982,0.078963,9.793823,0.782453
04-23 20:05:43.999+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.009+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.009+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.009+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:13,0.045490,9.774467,0.792539
04-23 20:05:44.019+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:6,-0.070000,-0.070000,-0.070000
04-23 20:05:44.019+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.029+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:15,0.045464,9.817751,0.784846
04-23 20:05:44.029+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:28,0.001856,0.043145,-0.006075
04-23 20:05:44.029+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.029+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.039+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:46,0.047856,9.815358,0.796810
04-23 20:05:44.049+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.049+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:33,-0.140000,-0.070000,-0.070000
04-23 20:05:44.059+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:43,0.043608,9.774606,0.790921
04-23 20:05:44.059+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.069+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.069+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.079+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:57,0.002424,0.040822,0.005127
04-23 20:05:44.079+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.079+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:71,-0.070000,0.140000,-0.070000
04-23 20:05:44.079+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:82,0.007178,9.815358,0.784846
04-23 20:05:44.089+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:79,0.045432,9.774536,0.791683
04-23 20:05:44.099+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.099+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:93,-0.038395,0.040912,-0.007932
04-23 20:05:44.099+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.099+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.109+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.109+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:104,-0.070000,0.070000,0.070000
04-23 20:05:44.119+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:123,0.006821,0.053006,-0.014320
04-23 20:05:44.119+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:112,0.052642,9.827322,0.780060
04-23 20:05:44.119+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.129+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:111,0.045574,9.774446,0.792778
04-23 20:05:44.129+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.129+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.139+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:143,0.057428,9.798609,0.787239
04-23 20:05:44.139+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.149+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:133,-0.070000,0.070000,0.070000
04-23 20:05:44.149+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:154,0.013300,0.024413,-0.008714
04-23 20:05:44.149+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.149+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:138,0.045822,9.774316,0.794380
04-23 20:05:44.159+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.159+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.159+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.179+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:161,-0.070000,0.070000,0.070000
04-23 20:05:44.179+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.179+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:167,0.047856,9.824929,0.794417
04-23 20:05:44.179+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:165,0.044127,9.774196,0.795953
04-23 20:05:44.189+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.189+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.189+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:177,0.003188,0.050799,-0.002316
04-23 20:05:44.199+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.199+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:194,0.044668,9.774130,0.796733
04-23 20:05:44.199+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:189,-0.070000,0.070000,0.070000
04-23 20:05:44.199+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:196,0.071785,9.801002,0.777667
04-23 20:05:44.209+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.209+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.219+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.219+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:209,0.026367,0.026947,-0.019942
04-23 20:05:44.219+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:225,0.045418,9.774055,0.797610
04-23 20:05:44.219+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:220,-0.140000,0.140000,0.070000
04-23 20:05:44.229+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.229+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:232,0.040678,9.808180,0.794417
04-23 20:05:44.239+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:44.239+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:44.239+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.239+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.249+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.249+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:239,-0.004993,0.034226,-0.004412
04-23 20:05:44.259+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.259+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:254,0.045671,9.773953,0.798829
04-23 20:05:44.259+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:05:44.259+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:05:44.259+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:44.259+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:248,-0.070000,0.070000,0.070000
04-23 20:05:44.269+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.269+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:258,0.098106,9.829715,0.851845
04-23 20:05:44.279+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:44.289+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5855
04-23 20:05:44.289+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5855)
04-23 20:05:44.299+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:05:44.299+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:44.299+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.299+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.319+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:270,0.051047,0.055764,0.053054
04-23 20:05:44.319+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.319+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:304,-0.070000,0.070000,0.070000
04-23 20:05:44.319+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:326,0.000958,0.048694,-0.036786
04-23 20:05:44.319+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:313,0.047059,9.773951,0.798791
04-23 20:05:44.319+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.329+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:315,0.047856,9.822537,0.763310
04-23 20:05:44.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:05:44.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:44.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:05:44.339+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.349+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.359+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.359+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:335,-0.070000,0.070000,0.070000
04-23 20:05:44.369+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:354,0.046898,9.773844,0.800096
04-23 20:05:44.369+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.369+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:359,0.069392,9.798609,0.792024
04-23 20:05:44.379+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.379+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.379+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:369,0.019991,0.025104,-0.012053
04-23 20:05:44.389+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.389+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:378,-0.070000,0.070000,0.070000
04-23 20:05:44.399+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.399+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:399,-0.018361,0.039407,-0.006616
04-23 20:05:44.399+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:388,0.049401,9.773505,0.804077
04-23 20:05:44.399+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:392,0.031107,9.812965,0.796810
04-23 20:05:44.409+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.409+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:417,0.049468,9.773559,0.803426
04-23 20:05:44.409+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.419+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.419+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:411,-0.070000,0.070000,0.070000
04-23 20:05:44.429+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.429+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:436,-0.070000,0.070000,0.070000
04-23 20:05:44.429+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.439+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:423,0.062213,9.798609,0.823131
04-23 20:05:44.439+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.439+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:445,0.050561,9.773497,0.804105
04-23 20:05:44.439+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:429,0.011653,0.025112,0.019027
04-23 20:05:44.439+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.449+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:449,0.055035,9.805787,0.799203
04-23 20:05:44.459+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.459+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.469+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.469+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:44.469+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:44.469+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:477,0.043071,9.815358,0.780060
04-23 20:05:44.469+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:454,0.005261,0.032400,-0.006283
04-23 20:05:44.469+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.479+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:474,0.049774,9.773387,0.805486
04-23 20:05:44.479+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:470,-0.140000,0.070000,0.070000
04-23 20:05:44.479+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.479+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:483,-0.007430,0.042152,-0.027576
04-23 20:05:44.479+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.489+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.499+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.509+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:492,-0.070000,0.140000,0.070000
04-23 20:05:44.509+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.509+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:502,0.011964,9.834501,0.748954
04-23 20:05:44.509+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:512,-0.038905,0.061351,-0.059335
04-23 20:05:44.509+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:498,0.050501,9.773206,0.807637
04-23 20:05:44.519+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.519+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.529+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:520,-0.070000,0.070000,0.070000
04-23 20:05:44.529+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.529+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:539,-0.024317,0.044608,-0.021153
04-23 20:05:44.539+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.539+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:530,0.050869,9.773150,0.808288
04-23 20:05:44.539+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:533,0.026321,9.817751,0.787239
04-23 20:05:44.539+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:546,-0.070000,-0.070000,0.070000
04-23 20:05:44.539+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.539+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.549+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.559+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:563,0.037231,0.056539,-0.030434
04-23 20:05:44.559+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.569+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:552,0.050638,9.773143,0.808391
04-23 20:05:44.569+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.569+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:555,0.086142,9.829715,0.777667
04-23 20:05:44.569+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.569+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:577,0.048910,9.773176,0.808101
04-23 20:05:44.569+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:571,-0.070000,0.070000,0.070000
04-23 20:05:44.579+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:44.579+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:44.579+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.589+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.609+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:582,0.007178,9.829715,0.789631
04-23 20:05:44.609+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.609+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:590,-0.040798,0.056606,-0.019334
04-23 20:05:44.619+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.619+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.619+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:623,0.047976,9.773108,0.808965
04-23 20:05:44.619+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:614,-0.070000,0.070000,0.070000
04-23 20:05:44.629+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:625,0.055035,9.801002,0.799203
04-23 20:05:44.629+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:632,0.005105,0.027804,-0.008575
04-23 20:05:44.629+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.639+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.639+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.639+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:648,0.049930,9.773197,0.807778
04-23 20:05:44.649+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.659+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:641,-0.070000,0.070000,0.070000
04-23 20:05:44.659+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.659+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:653,0.086142,9.801002,0.768096
04-23 20:05:44.659+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.669+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:661,0.038110,0.027919,-0.041177
04-23 20:05:44.679+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:671,-0.070000,0.070000,0.070000
04-23 20:05:44.679+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.679+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:685,0.038285,9.786645,0.768096
04-23 20:05:44.689+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.689+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.689+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:677,0.048032,9.773083,0.809273
04-23 20:05:44.689+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.699+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.709+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:703,-0.070000,0.140000,0.070000
04-23 20:05:44.709+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:694,-0.010215,0.013640,-0.042101
04-23 20:05:44.709+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:710,0.048500,9.773005,0.810197
04-23 20:05:44.719+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.719+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:725,-0.004681,0.034835,-0.057022
04-23 20:05:44.719+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.719+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:712,0.045464,9.808180,0.748954
04-23 20:05:44.729+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:733,-0.070000,0.140000,0.070000
04-23 20:05:44.729+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.729+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.729+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:737,0.050145,9.773345,0.805975
04-23 20:05:44.739+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.749+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:758,-0.037458,0.048973,-0.018509
04-23 20:05:44.759+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.759+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.759+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:768,-0.070000,0.070000,-0.070000
04-23 20:05:44.769+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:745,0.011964,9.822537,0.784846
04-23 20:05:44.779+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.789+0200 I/heartrate( 5555): capturing data from es.ugr.frailty.heartrate
04-23 20:05:44.799+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:773,0.049422,9.773564,0.803355
04-23 20:05:44.799+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.809+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:815,0.045464,9.779467,0.784846
04-23 20:05:44.809+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.809+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.819+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.819+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:826,-0.070000,0.070000,-0.070000
04-23 20:05:44.819+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.829+0200 I/heartrate( 5555): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:05:44.829+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:821,-0.003622,0.005579,-0.014587
04-23 20:05:44.829+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.839+0200 I/gravity ( 5595): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:05:44:807,0.049086,9.773888,0.799433
04-23 20:05:44.839+0200 I/gravity ( 5595): capturing data from es.ugr.frailty.gravity
04-23 20:05:44.849+0200 I/accelerometer( 5543): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:05:44:820,0.033500,9.812965,0.799203
04-23 20:05:44.849+0200 I/linearacceleration( 5580): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:05:44:840,-0.013976,0.039155,-0.001274
04-23 20:05:44.859+0200 I/accelerometer( 5543): capturing data from es.ugr.frailty.accelerometer
04-23 20:05:44.859+0200 I/gyroscope( 5545): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:05:44:830,-0.070000,-0.070000,-0.070000
04-23 20:05:44.859+0200 I/gyroscope( 5545): capturing data from es.ugr.frailty.gyroscope
04-23 20:05:44.859+0200 I/linearacceleration( 5580): capturing data from es.ugr.frailty.linearacceleration
04-23 20:05:44.879+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11058556c6f63152450674
