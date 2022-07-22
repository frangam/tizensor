S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18453
Date: 2018-06-07 17:14:24+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf776252d, r5   = 0xf7913f98
r6   = 0xffe0f820, r7   = 0xffe0f6d0
r8   = 0xf7910c18, r9   = 0x00000000
r10  = 0xffe0f7ac, fp   = 0xffe0f820
ip   = 0x00000001, sp   = 0xffe0f6a8
lr   = 0xf7762539, pc   = 0xf77cb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    124400 KB
Buffers:      3516 KB
Cached:      70744 KB
VmPeak:      53636 KB
VmSize:      53572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11720 KB
VmRSS:       11720 KB
VmData:      11300 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18453 TID = 18453
18453 18459 

Maps Information
f462d000 f4e2c000 rw-p [stack:18459]
f4e33000 f4e35000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e3d000 f4e41000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e4a000 f4e4c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e54000 f4e57000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e66000 f4e6b000 r-xp /usr/lib/libsystem.so.0.0.0
f4e76000 f4e79000 r-xp /lib/libattr.so.1.1.0
f4e81000 f4e91000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e99000 f4ea2000 r-xp /usr/lib/libedbus.so.1.7.99
f4eaa000 f4eab000 r-xp /usr/lib/libresponse.so.0.2.96
f4eb4000 f4eb9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f675b000 f6861000 r-xp /usr/lib/libicuuc.so.57.1
f6877000 f69ff000 r-xp /usr/lib/libicui18n.so.57.1
f6a0f000 f6a1c000 r-xp /usr/lib/libail.so.0.1.0
f6a25000 f6a2c000 r-xp /usr/lib/libminizip.so.1.0.0
f6a35000 f6bde000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bfe000 f6c45000 r-xp /usr/lib/libssl.so.1.0.0
f6c51000 f6c53000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c5b000 f6c62000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c6b000 f6c72000 r-xp /lib/libcrypt-2.13.so
f6ca3000 f6ca6000 r-xp /lib/libcap.so.2.21
f6cae000 f6cb0000 r-xp /usr/lib/libiri.so
f6cb8000 f6d01000 r-xp /usr/lib/libmdm.so.1.2.69
f6d09000 f6d0f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6d17000 f6d3a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d44000 f6d46000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d4e000 f6d6b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d74000 f6d78000 r-xp /usr/lib/libsmack.so.1.0.0
f6d81000 f6d9a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6da3000 f6dab000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6db3000 f6db9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6dc2000 f6dc4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6dcd000 f6ddd000 r-xp /lib/libresolv-2.13.so
f6de1000 f6df9000 r-xp /usr/lib/liblzma.so.5.0.3
f6e02000 f6e04000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e0c000 f6e26000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e2e000 f6e5d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e66000 f6e75000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e7f000 f6e89000 r-xp /usr/lib/libsensord-shared.so
f6e92000 f6f65000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f70000 f6f86000 r-xp /lib/libz.so.1.2.5
f6f8e000 f6f93000 r-xp /usr/lib/libffi.so.5.0.10
f6f9b000 f6f9c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6fa4000 f6fb4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6fbc000 f6fd5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fdd000 f6fdf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fe7000 f705c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7066000 f706c000 r-xp /lib/librt-2.13.so
f7075000 f7093000 r-xp /usr/lib/libsystemd.so.0.4.0
f709d000 f709e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70a6000 f70c9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70d1000 f70d6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70de000 f7108000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7111000 f7128000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7130000 f7199000 r-xp /lib/libm-2.13.so
f71a2000 f7236000 r-xp /usr/lib/libstdc++.so.6.0.16
f7249000 f724e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7256000 f725d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7265000 f728f000 r-xp /usr/lib/libsensor.so.1.9.6
f7298000 f7364000 r-xp /usr/lib/libxml2.so.2.7.8
f7371000 f7373000 r-xp /usr/lib/libiniparser.so.0
f737c000 f7382000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f738b000 f745b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f745c000 f7490000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7499000 f74d5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74dd000 f74e0000 r-xp /usr/lib/libbundle.so.0.1.22
f74e8000 f74ee000 r-xp /usr/lib/libappsvc.so.0.1.0
f74f6000 f7537000 r-xp /usr/lib/libeina.so.1.7.99
f7540000 f7557000 r-xp /usr/lib/libecore.so.1.7.99
f756e000 f7577000 r-xp /usr/lib/libvconf.so.0.2.45
f757f000 f7593000 r-xp /lib/libpthread-2.13.so
f759e000 f75ab000 r-xp /usr/lib/libaul.so.0.1.0
f75b5000 f75b7000 r-xp /lib/libdl-2.13.so
f75c0000 f75cb000 r-xp /lib/libunwind.so.8.0.1
f75f8000 f7600000 r-xp /lib/libgcc_s-4.6.so.1
f7601000 f7725000 r-xp /lib/libc-2.13.so
f7733000 f7735000 r-xp /usr/lib/libdlog.so.0.0.0
f773d000 f7749000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7752000 f7757000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f775f000 f776e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7776000 f777a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7783000 f7786000 r-xp /usr/lib/libappcore-agent.so.1.1
f778e000 f7790000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7798000 f779c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f77a4000 f77c1000 r-xp /lib/ld-2.13.so
f77ca000 f77cd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77cd000 f77d1000 r-xp /usr/lib/libsys-assert.so
f78e0000 f796e000 rw-p [heap]
ffdf0000 ffe11000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18453)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf77cb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7762539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74693f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7467c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7473e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7479be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7479dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf74ae75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74a91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7467c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7473e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7479be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7479dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf74abe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf74ac017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74b3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e4b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e3e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6f11663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf73befcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73c07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7550ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf754bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf754c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf754c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7784183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77847fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77cb5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf761885c) [/lib/libc.so.6] + 0x1785c
29: (0xf77caf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
elerometer: SM-R760,07/06/2018,17:14:24:288,0.332602,-0.114855,9.879964
06-07 17:14:24.281+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.291+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:295,0.305626,-0.090120,9.801472
06-07 17:14:24.291+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:253,0.013084,-0.013481,0.061716
06-07 17:14:24.291+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.291+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.291+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.311+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:289,0.140000,0.070000,0.070000
06-07 17:14:24.311+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:309,0.303747,-0.089222,9.801538
06-07 17:14:24.311+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.311+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:306,0.284746,-0.119641,9.836893
06-07 17:14:24.321+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.331+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:300,0.040154,0.012787,0.078515
06-07 17:14:24.331+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.331+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.331+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:327,0.265603,-0.122034,9.920642
06-07 17:14:24.331+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.341+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:24.341+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:322,-0.070000,-0.070000,-0.070000
06-07 17:14:24.351+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:24:348,571.000000
06-07 17:14:24.351+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:337,0.302331,-0.089537,9.801579
06-07 17:14:24.351+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:339,-0.009944,-0.027608,0.061765
06-07 17:14:24.351+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.351+0200 W/CAPI_APPFW_APP_CONTROL(18378): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:24.351+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:24.351+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18378), cmd(0)
06-07 17:14:24.361+0200 I/utils   (18378): specific action
06-07 17:14:24.361+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.361+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:24.361+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:24.361+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:359,0.256032,-0.112463,9.884750
06-07 17:14:24.361+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.371+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:369,0.303940,-0.090189,9.801524
06-07 17:14:24.371+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.381+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.381+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:380,0.294317,-0.112463,9.932607
06-07 17:14:24.381+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.391+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:360,0.001029,0.028870,0.033072
06-07 17:14:24.391+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.391+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:389,0.302909,-0.090223,9.801556
06-07 17:14:24.401+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:375,0.070000,0.070000,-0.070000
06-07 17:14:24.401+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:398,0.301496,-0.114855,9.865608
06-07 17:14:24.401+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.401+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.411+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.411+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:414,0.302938,-0.092613,9.801533
06-07 17:14:24.421+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:398,0.006776,-0.029788,0.042624
06-07 17:14:24.421+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.421+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.421+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:420,0.311067,-0.059821,9.865608
06-07 17:14:24.431+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:414,0.070000,0.070000,-0.070000
06-07 17:14:24.431+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.431+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.431+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:440,0.337388,-0.112463,9.901501
06-07 17:14:24.441+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:435,0.304402,-0.090557,9.801506
06-07 17:14:24.441+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.441+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.451+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:438,0.140000,0.070000,-0.070000
06-07 17:14:24.451+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:456,0.334995,-0.093320,9.853643
06-07 17:14:24.451+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:455,0.305406,-0.090710,9.801474
06-07 17:14:24.461+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.461+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:431,0.019352,0.006709,0.111980
06-07 17:14:24.471+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.471+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.471+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:478,0.070000,0.070000,0.070000
06-07 17:14:24.471+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.471+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:470,0.305102,-0.089483,9.801495
06-07 17:14:24.481+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:478,0.332602,-0.112463,9.903893
06-07 17:14:24.481+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.481+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.481+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.491+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:494,0.342174,-0.126820,9.889536
06-07 17:14:24.491+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:491,0.304547,-0.089128,9.801515
06-07 17:14:24.491+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.501+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:506,0.304997,-0.088687,9.801505
06-07 17:14:24.501+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.511+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:510,0.313460,-0.055035,9.868000
06-07 17:14:24.511+0200 W/LOCATION(18453): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:14:24.521+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:493,-0.009119,0.048530,0.092841
06-07 17:14:24.521+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.531+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.531+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:482,0.070000,0.070000,0.070000
06-07 17:14:24.531+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.531+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.531+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:532,0.002538,-0.007097,0.107202
06-07 17:14:24.541+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.541+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:24.541+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:545,0.070000,0.070000,0.070000
06-07 17:14:24.541+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:24:549,572.000000
06-07 17:14:24.541+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.551+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:536,0.301613,-0.088286,9.801613
06-07 17:14:24.551+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:546,-0.009014,-0.014127,0.040169
06-07 17:14:24.551+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.561+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.561+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:543,0.323031,-0.052642,9.891929
06-07 17:14:24.561+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:565,0.017230,0.007932,0.071282
06-07 17:14:24.561+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.561+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:24.561+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:24.571+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.581+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:571,0.302679,-0.089419,9.801570
06-07 17:14:24.581+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:555,0.070000,0.070000,0.070000
06-07 17:14:24.581+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.581+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.581+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:582,0.279960,-0.110070,9.891929
06-07 17:14:24.581+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:570,0.043954,-0.020016,0.028206
06-07 17:14:24.591+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:589,0.070000,0.070000,-0.070000
06-07 17:14:24.591+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.591+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.591+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.601+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:593,0.303267,-0.088724,9.801558
06-07 17:14:24.601+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:604,0.029315,-0.015843,0.073673
06-07 17:14:24.611+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.611+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:604,0.306281,-0.129212,9.848858
06-07 17:14:24.611+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:600,0.070000,0.070000,-0.070000
06-07 17:14:24.611+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.611+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.621+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.631+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:624,0.070000,0.070000,-0.070000
06-07 17:14:24.631+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:624,0.304692,-0.089626,9.801506
06-07 17:14:24.631+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.631+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:625,0.025251,0.025618,0.047411
06-07 17:14:24.641+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.641+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.641+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:651,0.305902,-0.090684,9.801458
06-07 17:14:24.651+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:643,0.070000,0.070000,-0.070000
06-07 17:14:24.651+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:641,0.308674,-0.090927,9.870394
06-07 17:14:24.651+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:646,0.022036,-0.016953,0.076155
06-07 17:14:24.651+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.651+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.661+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.661+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.671+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:660,0.028650,0.027094,0.049839
06-07 17:14:24.671+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:663,0.287139,-0.129212,9.927821
06-07 17:14:24.671+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.671+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.681+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:673,0.070000,0.070000,-0.070000
06-07 17:14:24.681+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.681+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:678,0.306317,-0.091933,9.801434
06-07 17:14:24.681+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.681+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:691,0.070000,0.070000,-0.070000
06-07 17:14:24.691+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:678,-0.041286,0.006210,0.028326
06-07 17:14:24.691+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:687,0.303888,-0.088534,9.865608
06-07 17:14:24.691+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.701+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:701,0.307546,-0.093085,9.801384
06-07 17:14:24.701+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.701+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:703,0.003721,-0.016965,0.088145
06-07 17:14:24.701+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.711+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:713,0.140000,0.070000,-0.070000
06-07 17:14:24.711+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.721+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.721+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:711,0.323031,-0.110070,9.865608
06-07 17:14:24.721+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:720,0.308011,-0.091599,9.801384
06-07 17:14:24.721+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.731+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.731+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:735,-0.070000,0.070000,-0.070000
06-07 17:14:24.731+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.731+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:727,-0.000987,-0.019742,0.047387
06-07 17:14:24.731+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.741+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:24.741+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.741+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:24:747,569.000000
06-07 17:14:24.741+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:750,0.210000,0.070000,-0.070000
06-07 17:14:24.751+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:743,-0.031643,-0.009719,0.102412
06-07 17:14:24.751+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:736,0.330210,-0.105284,9.908678
06-07 17:14:24.751+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.751+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.761+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:742,0.306991,-0.089898,9.801432
06-07 17:14:24.761+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.761+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.761+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:24.761+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:24.771+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:769,0.140000,0.070000,-0.070000
06-07 17:14:24.771+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:763,0.033425,0.012538,0.028226
06-07 17:14:24.781+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.781+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:767,0.334995,-0.112463,9.891929
06-07 17:14:24.781+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.781+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:772,0.303682,-0.089036,9.801542
06-07 17:14:24.781+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:792,0.315853,-0.112463,9.872787
06-07 17:14:24.791+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.791+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:14:24.791+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:14:24.791+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.791+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:24.801+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:24.801+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:802,0.303286,-0.088557,9.801559
06-07 17:14:24.801+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.801+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18360
06-07 17:14:24.811+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18360)
06-07 17:14:24.811+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:14:24.811+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:24.811+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:14:24.811+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:14:24.811+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:24.811+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:24.821+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:820,0.303200,-0.089224,9.801556
06-07 17:14:24.821+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:815,0.299103,-0.110070,9.879964
06-07 17:14:24.821+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18334
06-07 17:14:24.831+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18334)
06-07 17:14:24.831+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:14:24.831+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:24.831+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:14:24.831+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:14:24.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:24.831+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:24.831+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.831+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:14:24.841+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:24.841+0200 I/utils   (18034): specific action
06-07 17:14:24.841+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:24.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18034), cmd(0)
06-07 17:14:24.851+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:842,0.296710,-0.100499,9.846465
06-07 17:14:24.851+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:14:24.851+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:14:24.851+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:24.851+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:14:24.851+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:14:24.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:24.851+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:24.861+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:846,0.304283,-0.090400,9.801512
06-07 17:14:24.861+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18453
06-07 17:14:24.861+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18453)
06-07 17:14:24.861+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:14:24.861+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:24.861+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:14:24.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:14:24.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:24.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:24.871+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:876,0.305653,-0.091194,9.801461
06-07 17:14:24.871+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:872,0.325424,-0.090927,9.858429
06-07 17:14:24.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18398
06-07 17:14:24.881+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18398)
06-07 17:14:24.881+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:14:24.881+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:24.881+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:14:24.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:14:24.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:24.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:24.891+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.891+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:896,0.351745,-0.083749,9.832108
06-07 17:14:24.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18378
06-07 17:14:24.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18378)
06-07 17:14:24.901+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:14:24.901+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:24.901+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:14:24.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:14:24.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:24.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:24.901+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:902,0.305378,-0.091641,9.801466
06-07 17:14:24.911+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.911+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:14:24.921+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:24.921+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:24.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(18075), cmd(0)
06-07 17:14:24.921+0200 I/utils   (18075): specific action
06-07 17:14:24.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:14:24.921+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:14:24.921+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:796,0.140000,0.070000,0.070000
06-07 17:14:24.921+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:24.921+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.921+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:14:24.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:14:24.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:24.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:24.931+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:787,0.073788,-0.003976,0.114306
06-07 17:14:24.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:14:24.941+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:24.941+0200 I/utils   (18079): specific action
06-07 17:14:24.941+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:24.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(18079), cmd(0)
06-07 17:14:24.941+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:24.951+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:932,-0.070000,0.070000,0.070000
06-07 17:14:24.951+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:14:24.951+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:14:24.951+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:24:952,552.000000
06-07 17:14:24.951+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:24.951+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:14:24.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:14:24.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:24.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:24.961+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:24.961+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:922,0.401994,-0.011964,9.868000
06-07 17:14:24.961+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:24.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:14:24.961+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:24.961+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:14:24.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:24.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(18111), cmd(0)
06-07 17:14:24.971+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:14:24.971+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:24.971+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:24.971+0200 I/utils   (18111): specific action
06-07 17:14:24.971+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:957,-0.070000,0.070000,0.070000
06-07 17:14:24.971+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.981+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:923,0.305513,-0.091999,9.801458
06-07 17:14:24.981+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:24.981+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:985,-0.070000,0.140000,0.070000
06-07 17:14:24.981+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.991+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:991,-0.070000,0.070000,0.070000
06-07 17:14:24.991+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:24.991+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:24.991+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:24:997,0.140000,0.070000,-0.070000
06-07 17:14:24.991+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.001+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:24:973,0.027221,0.047900,0.088013
06-07 17:14:25.001+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:3,0.070000,0.070000,-0.070000
06-07 17:14:25.001+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.001+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:25.001+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:24:997,0.307986,-0.091783,9.801383
06-07 17:14:25.001+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:9,0.070000,0.070000,-0.070000
06-07 17:14:25.001+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.011+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:15,0.070000,0.070000,-0.070000
06-07 17:14:25.011+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.021+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:21,0.070000,0.070000,-0.070000
06-07 17:14:25.021+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.021+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:24:998,0.303888,-0.038285,9.930215
06-07 17:14:25.021+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:27,0.070000,0.070000,-0.070000
06-07 17:14:25.021+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.021+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:25.031+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:25.031+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:25:15,0.014683,-0.011828,0.088105
06-07 17:14:25.031+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:33,0.070000,0.070000,-0.070000
06-07 17:14:25.031+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.031+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:39,0.070000,0.070000,-0.070000
06-07 17:14:25.031+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.041+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:45,0.070000,0.070000,-0.070000
06-07 17:14:25.041+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.051+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:25.051+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:25:39,0.307840,-0.092674,9.801379
06-07 17:14:25.061+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:25:46,0.344566,-0.122034,9.939785
06-07 17:14:25.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:14:25.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:14:25.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:14:25.061+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:51,0.140000,0.070000,-0.070000
06-07 17:14:25.061+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.071+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:74,0.140000,0.070000,-0.070000
06-07 17:14:25.071+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.071+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:25.071+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:25.071+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:80,0.140000,0.070000,-0.070000
06-07 17:14:25.081+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.081+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:25:57,0.028558,0.023884,0.047419
06-07 17:14:25.081+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:86,0.210000,0.070000,-0.070000
06-07 17:14:25.081+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.091+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:91,0.070000,0.140000,-0.070000
06-07 17:14:25.091+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.091+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:25:96,0.311067,-0.102891,9.891929
06-07 17:14:25.091+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:98,0.070000,0.070000,-0.070000
06-07 17:14:25.091+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.091+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:25.101+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:103,0.070000,0.070000,-0.070000
06-07 17:14:25.101+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.101+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:108,0.070000,0.070000,-0.070000
06-07 17:14:25.101+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.111+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:25:87,0.308007,-0.093504,9.801366
06-07 17:14:25.111+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:113,0.070000,0.070000,-0.070000
06-07 17:14:25.111+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.111+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:119,0.070000,0.070000,-0.070000
06-07 17:14:25.111+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.121+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:124,0.140000,0.070000,-0.070000
06-07 17:14:25.121+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:25.121+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.121+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:25:130,0.307356,-0.091906,9.801401
06-07 17:14:25.121+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:130,0.070000,0.070000,-0.070000
06-07 17:14:25.121+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.131+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:25.131+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:135,0.070000,0.070000,-0.070000
06-07 17:14:25.131+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:25:104,-0.014727,0.014673,0.068964
06-07 17:14:25.131+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.131+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:25.141+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:141,0.070000,0.070000,-0.070000
06-07 17:14:25.141+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.141+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:25.141+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:147,0.070000,0.070000,-0.070000
06-07 17:14:25.141+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:25:148,556.000000
06-07 17:14:25.141+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.151+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:153,0.070000,0.070000,-0.070000
06-07 17:14:25.151+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.151+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:159,0.070000,0.140000,-0.070000
06-07 17:14:25.151+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.161+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:25:145,-0.015423,-0.012971,0.061795
06-07 17:14:25.161+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:165,0.140000,0.140000,-0.070000
06-07 17:14:25.161+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.161+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:25:143,0.337388,-0.055035,9.906286
06-07 17:14:25.161+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:25.161+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:25.171+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:25.171+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:171,0.070000,0.140000,-0.070000
06-07 17:14:25.171+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.171+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:25.171+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:177,0.140000,0.140000,-0.070000
06-07 17:14:25.171+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.181+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:25.181+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:182,0.070000,0.140000,-0.070000
06-07 17:14:25.181+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:25.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(18334), cmd(0)
06-07 17:14:25.181+0200 W/CAPI_APPFW_APP_CONTROL(18334): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:25.181+0200 I/utils   (18334): specific action
06-07 17:14:25.181+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.191+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:192,0.070000,0.140000,-0.070000
06-07 17:14:25.191+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.191+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:198,0.070000,0.140000,-0.070000
06-07 17:14:25.191+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.191+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:25:177,0.306469,-0.091537,9.801433
06-07 17:14:25.201+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:203,0.070000,0.140000,-0.070000
06-07 17:14:25.201+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.201+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:25.201+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:210,0.070000,0.070000,-0.070000
06-07 17:14:25.201+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.211+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:25:192,0.311067,-0.095713,9.829715
06-07 17:14:25.211+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:214,0.070000,0.070000,-0.070000
06-07 17:14:25.211+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.211+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:25:200,-0.028547,-0.006640,0.073713
06-07 17:14:25.211+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:220,0.070000,0.070000,-0.070000
06-07 17:14:25.221+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.221+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:25.221+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:226,0.070000,0.070000,-0.070000
06-07 17:14:25.221+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.221+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:25.231+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:232,0.070000,0.070000,-0.070000
06-07 17:14:25.231+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.241+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:25:216,0.305932,-0.091404,9.801451
06-07 17:14:25.241+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:238,0.070000,0.070000,-0.070000
06-07 17:14:25.241+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:25:234,0.313460,-0.076570,9.860823
06-07 17:14:25.241+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:25:235,-0.012760,-0.008715,0.119134
06-07 17:14:25.241+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:25.251+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.251+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:256,0.070000,0.070000,-0.070000
06-07 17:14:25.251+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.251+0200 I/accelerometer(18360): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:25.261+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:25.261+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:262,0.070000,0.070000,-0.070000
06-07 17:14:25.261+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.271+0200 I/gravity (18378): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:25:255,0.306377,-0.092843,9.801423
06-07 17:14:25.281+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:272,0.070000,0.070000,-0.070000
06-07 17:14:25.281+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.291+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:295,0.070000,0.070000,-0.070000
06-07 17:14:25.301+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.311+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:25:272,0.070681,-0.049428,0.135819
06-07 17:14:25.311+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:25.311+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:25:315,0.070000,0.070000,-0.070000
06-07 17:14:25.321+0200 I/gyroscope(18334): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:25.321+0200 I/gravity (18378): es.ugr.frailty.gravity - capturing data
06-07 17:14:25.321+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11184536c6f63152838446
