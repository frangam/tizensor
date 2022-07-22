S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16629
Date: 2018-06-07 17:08:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf743252d, r5   = 0xf765f958
r6   = 0xffc5b640, r7   = 0xffc5b4f0
r8   = 0xf7672c18, r9   = 0x00000000
r10  = 0xffc5b5cc, fp   = 0xffc5b640
ip   = 0x00000001, sp   = 0xffc5b4c8
lr   = 0xf7432539, pc   = 0xf749b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     78604 KB
Buffers:      9120 KB
Cached:      49772 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11484 KB
VmRSS:       11484 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16629 TID = 16629
16629 16647 

Maps Information
f42fd000 f4afc000 rw-p [stack:16647]
f4b03000 f4b05000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b0d000 f4b11000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b1a000 f4b1c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b24000 f4b27000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b36000 f4b3b000 r-xp /usr/lib/libsystem.so.0.0.0
f4b46000 f4b49000 r-xp /lib/libattr.so.1.1.0
f4b51000 f4b61000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b69000 f4b72000 r-xp /usr/lib/libedbus.so.1.7.99
f4b7a000 f4b7b000 r-xp /usr/lib/libresponse.so.0.2.96
f4b84000 f4b89000 r-xp /usr/lib/libproc-stat.so.0.2.96
f642b000 f6531000 r-xp /usr/lib/libicuuc.so.57.1
f6547000 f66cf000 r-xp /usr/lib/libicui18n.so.57.1
f66df000 f66ec000 r-xp /usr/lib/libail.so.0.1.0
f66f5000 f66fc000 r-xp /usr/lib/libminizip.so.1.0.0
f6705000 f68ae000 r-xp /usr/lib/libcrypto.so.1.0.0
f68ce000 f6915000 r-xp /usr/lib/libssl.so.1.0.0
f6921000 f6923000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f692b000 f6932000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f693b000 f6942000 r-xp /lib/libcrypt-2.13.so
f6973000 f6976000 r-xp /lib/libcap.so.2.21
f697e000 f6980000 r-xp /usr/lib/libiri.so
f6988000 f69d1000 r-xp /usr/lib/libmdm.so.1.2.69
f69d9000 f69df000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69e7000 f6a0a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a14000 f6a16000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a1e000 f6a3b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a44000 f6a48000 r-xp /usr/lib/libsmack.so.1.0.0
f6a51000 f6a6a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a73000 f6a7b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a83000 f6a89000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a92000 f6a94000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a9d000 f6aad000 r-xp /lib/libresolv-2.13.so
f6ab1000 f6ac9000 r-xp /usr/lib/liblzma.so.5.0.3
f6ad2000 f6ad4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6adc000 f6af6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6afe000 f6b2d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b36000 f6b45000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b4f000 f6b59000 r-xp /usr/lib/libsensord-shared.so
f6b62000 f6c35000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c40000 f6c56000 r-xp /lib/libz.so.1.2.5
f6c5e000 f6c63000 r-xp /usr/lib/libffi.so.5.0.10
f6c6b000 f6c6c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c74000 f6c84000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c8c000 f6ca5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cad000 f6caf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cb7000 f6d2c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d36000 f6d3c000 r-xp /lib/librt-2.13.so
f6d45000 f6d63000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d6d000 f6d6e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d76000 f6d99000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6da1000 f6da6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dae000 f6dd8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6de1000 f6df8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e00000 f6e69000 r-xp /lib/libm-2.13.so
f6e72000 f6f06000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f19000 f6f1e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f26000 f6f2d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f35000 f6f5f000 r-xp /usr/lib/libsensor.so.1.9.6
f6f68000 f7034000 r-xp /usr/lib/libxml2.so.2.7.8
f7041000 f7043000 r-xp /usr/lib/libiniparser.so.0
f704c000 f7052000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f705b000 f712b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f712c000 f7160000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7169000 f71a5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71ad000 f71b0000 r-xp /usr/lib/libbundle.so.0.1.22
f71b8000 f71be000 r-xp /usr/lib/libappsvc.so.0.1.0
f71c6000 f7207000 r-xp /usr/lib/libeina.so.1.7.99
f7210000 f7227000 r-xp /usr/lib/libecore.so.1.7.99
f723e000 f7247000 r-xp /usr/lib/libvconf.so.0.2.45
f724f000 f7263000 r-xp /lib/libpthread-2.13.so
f726e000 f727b000 r-xp /usr/lib/libaul.so.0.1.0
f7285000 f7287000 r-xp /lib/libdl-2.13.so
f7290000 f729b000 r-xp /lib/libunwind.so.8.0.1
f72c8000 f72d0000 r-xp /lib/libgcc_s-4.6.so.1
f72d1000 f73f5000 r-xp /lib/libc-2.13.so
f7403000 f7405000 r-xp /usr/lib/libdlog.so.0.0.0
f740d000 f7419000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7422000 f7427000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f742f000 f743e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7446000 f744a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7453000 f7456000 r-xp /usr/lib/libappcore-agent.so.1.1
f745e000 f7460000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7468000 f746c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7474000 f7491000 r-xp /lib/ld-2.13.so
f749a000 f749d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f749d000 f74a1000 r-xp /usr/lib/libsys-assert.so
f7642000 f76b3000 rw-p [heap]
ffc3c000 ffc5d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16629)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf749b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7432539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71393f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7137c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7143e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7149be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7149dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf717e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71791f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7137c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7143e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7149be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7149dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf717be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf717c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7183f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b1b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b0e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6be1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf708efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70907a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7220ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf721bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf721c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf721c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7454183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74547fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf749b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf72e885c) [/lib/libc.so.6] + 0x1785c
29: (0xf749af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
n(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.091+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:08:46.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(16582), cmd(0)
06-07 17:08:46.091+0200 W/CAPI_APPFW_APP_CONTROL(16582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:08:46.091+0200 I/utils   (16582): specific action
06-07 17:08:46.091+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.101+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:103,2.330616,-0.348655,9.519299
06-07 17:08:46.101+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:90,-0.980000,-0.280000,0.070000
06-07 17:08:46.101+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.101+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.101+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:108,2.335693,-0.349189,9.518035
06-07 17:08:46.101+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.111+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:113,2.335289,-0.351958,9.518032
06-07 17:08:46.111+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:98,-0.153439,-0.007342,0.098719
06-07 17:08:46.111+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.111+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.111+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:118,2.333008,-0.351260,9.518618
06-07 17:08:46.111+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.111+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:109,2.232504,-0.334995,9.631111
06-07 17:08:46.121+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:113,-1.400000,0.070000,0.140000
06-07 17:08:46.121+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:122,2.331321,-0.347080,9.519184
06-07 17:08:46.121+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.121+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:123,-0.081250,0.026534,0.077187
06-07 17:08:46.121+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:128,2.327076,-0.345779,9.520270
06-07 17:08:46.121+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.121+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.121+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.131+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:133,2.326642,-0.344398,9.520426
06-07 17:08:46.131+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.131+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:141,2.308350,-0.342241,9.524956
06-07 17:08:46.141+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.141+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:135,-1.260000,0.210000,-0.140000
06-07 17:08:46.141+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:148,-0.134003,0.109585,0.100530
06-07 17:08:46.141+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:137,2.215754,-0.385244,9.597611
06-07 17:08:46.141+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.151+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:46.151+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:46:159,563.000000
06-07 17:08:46.151+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.161+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.161+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.161+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:165,2.285768,-0.333886,9.530696
06-07 17:08:46.161+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:169,-0.153852,0.050370,0.090391
06-07 17:08:46.161+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:155,-0.350000,0.210000,-0.140000
06-07 17:08:46.161+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:165,2.213361,-0.330210,9.619147
06-07 17:08:46.171+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.171+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.171+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.171+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:180,2.184647,-0.284746,9.635897
06-07 17:08:46.181+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.181+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:177,-0.560000,0.140000,-0.070000
06-07 17:08:46.181+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:185,2.278536,-0.327132,9.532661
06-07 17:08:46.181+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.181+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:184,-0.120893,0.068212,0.065376
06-07 17:08:46.181+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.191+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.191+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:193,-0.560000,0.140000,0.140000
06-07 17:08:46.191+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.201+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.201+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:46.201+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:46:207,80
06-07 17:08:46.201+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:196,2.170290,-0.275175,9.578469
06-07 17:08:46.211+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:203,2.290954,-0.327837,9.529661
06-07 17:08:46.211+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.211+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:200,-0.122852,-0.014525,0.081971
06-07 17:08:46.211+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.211+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:218,-0.094989,0.067067,0.087013
06-07 17:08:46.221+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:212,-0.910000,0.350000,0.350000
06-07 17:08:46.221+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.221+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:222,2.213361,-0.296710,9.566505
06-07 17:08:46.221+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:228,1.260000,1.120000,-0.140000
06-07 17:08:46.221+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.221+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.231+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.231+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:235,2.306156,-0.328578,9.525968
06-07 17:08:46.231+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.231+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.231+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:234,-0.091550,0.113747,0.105201
06-07 17:08:46.241+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.241+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:242,2.313024,-0.330430,9.524239
06-07 17:08:46.241+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:235,2.251646,-0.301496,9.621540
06-07 17:08:46.251+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.251+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.251+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:245,2.380000,0.910000,-0.350000
06-07 17:08:46.251+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:251,-0.026890,0.066315,0.081700
06-07 17:08:46.261+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.261+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:260,2.322019,-0.329191,9.522093
06-07 17:08:46.261+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.261+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:270,-0.029736,0.078983,0.041630
06-07 17:08:46.271+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:257,2.182254,-0.356531,9.616754
06-07 17:08:46.271+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.271+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:267,0.560000,0.070000,-0.350000
06-07 17:08:46.271+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.271+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:279,2.254039,-0.325424,9.595219
06-07 17:08:46.281+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.281+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:287,2.199004,-0.241675,9.619147
06-07 17:08:46.281+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.291+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:292,2.177469,-0.296710,9.609575
06-07 17:08:46.291+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.291+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.291+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.291+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:282,2.328574,-0.328910,9.520501
06-07 17:08:46.291+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.291+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:298,2.206182,-0.277567,9.585647
06-07 17:08:46.291+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.301+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:299,-0.123902,0.041439,0.064466
06-07 17:08:46.301+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:304,2.203789,-0.358923,9.602397
06-07 17:08:46.301+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.301+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.301+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:309,-0.090091,0.103112,0.070980
06-07 17:08:46.301+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.301+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:310,2.213361,-0.275175,9.611969
06-07 17:08:46.311+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.311+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:316,2.194218,-0.220140,9.635897
06-07 17:08:46.311+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.311+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:296,-1.890000,-0.210000,0.140000
06-07 17:08:46.321+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:321,2.251646,-0.260818,9.614362
06-07 17:08:46.321+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.321+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:327,2.261217,-0.248854,9.571291
06-07 17:08:46.321+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.331+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:332,2.182254,-0.287139,9.590433
06-07 17:08:46.331+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.331+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:302,2.330094,-0.328906,9.520129
06-07 17:08:46.331+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.331+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:336,-2.170000,-0.280000,0.140000
06-07 17:08:46.331+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:339,2.222932,-0.227318,9.595219
06-07 17:08:46.331+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.331+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.331+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.341+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:345,2.332459,-0.328922,9.519549
06-07 17:08:46.341+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:346,2.237289,-0.258425,9.631111
06-07 17:08:46.341+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:46.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391326353,000000, pattern:[H:mm][0;m
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:08:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:08:46.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:08:46.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:08][0;m
06-07 17:08:46.351+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:313,-0.084730,0.070766,0.109018
06-07 17:08:46.351+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:46.351+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.351+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:46:360,564.000000
06-07 17:08:46.361+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:362,2.203789,-0.277567,9.674182
06-07 17:08:46.361+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:343,-1.890000,0.280000,0.140000
06-07 17:08:46.361+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.361+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:351,2.332531,-0.329423,9.519515
06-07 17:08:46.361+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:368,2.222932,-0.287139,9.590433
06-07 17:08:46.361+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.361+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.371+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.371+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:375,2.215754,-0.311067,9.573684
06-07 17:08:46.371+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.371+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:379,-1.820000,0.350000,0.140000
06-07 17:08:46.371+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:381,2.254039,-0.256032,9.556933
06-07 17:08:46.381+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.381+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.381+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:387,2.182254,-0.263210,9.578469
06-07 17:08:46.381+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:376,-0.124784,0.051342,0.153681
06-07 17:08:46.381+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.391+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.391+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:393,-1.540000,0.140000,0.210000
06-07 17:08:46.391+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.391+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.391+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:393,2.331941,-0.326466,9.519761
06-07 17:08:46.391+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:400,2.194218,-0.267996,9.655040
06-07 17:08:46.401+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:46.401+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.401+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:396,-0.107162,0.041767,0.070304
06-07 17:08:46.401+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:46:408,80
06-07 17:08:46.401+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:398,-1.260000,0.280000,0.210000
06-07 17:08:46.401+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.401+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.411+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:415,-0.116706,0.017855,0.054134
06-07 17:08:46.411+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:415,-0.980000,-0.280000,0.070000
06-07 17:08:46.411+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.411+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:420,-0.700000,-0.210000,-0.280000
06-07 17:08:46.411+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.421+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:412,2.324862,-0.323385,9.521598
06-07 17:08:46.421+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.421+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.421+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:425,2.187040,-0.256032,9.717253
06-07 17:08:46.421+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.421+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:429,2.302085,-0.316679,9.527355
06-07 17:08:46.421+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:431,-0.350000,0.490000,-0.420000
06-07 17:08:46.431+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.431+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.431+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:435,-0.078492,0.073391,0.037418
06-07 17:08:46.431+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:439,2.220540,-0.220140,9.590433
06-07 17:08:46.431+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.441+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.441+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:436,-0.070000,0.770000,-0.350000
06-07 17:08:46.441+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.441+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:448,1.890000,0.770000,0.070000
06-07 17:08:46.441+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.451+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:453,4.060000,-0.140000,0.420000
06-07 17:08:46.451+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.451+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.451+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:447,2.264212,-0.305415,9.536795
06-07 17:08:46.451+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:460,2.227718,-0.253639,9.611969
06-07 17:08:46.451+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:448,-0.149687,0.063256,0.058708
06-07 17:08:46.461+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.461+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:458,3.430000,-0.350000,0.420000
06-07 17:08:46.461+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.461+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.461+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:469,2.235898,-0.294423,9.543818
06-07 17:08:46.461+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:470,3.640000,-0.630000,-0.140000
06-07 17:08:46.471+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.471+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:466,-0.130643,0.055389,0.133442
06-07 17:08:46.471+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.471+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.471+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.471+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:479,-0.115046,0.060647,0.189898
06-07 17:08:46.481+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:484,7.070000,-0.140000,-0.770000
06-07 17:08:46.481+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:476,2.208194,-0.284952,9.550553
06-07 17:08:46.481+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:481,2.194218,-0.332602,9.568897
06-07 17:08:46.481+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.481+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.491+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:493,2.153645,-0.272393,9.563368
06-07 17:08:46.491+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:492,-0.043672,0.085276,0.053638
06-07 17:08:46.491+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.491+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.491+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.491+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:501,8.120000,0.770000,-0.980000
06-07 17:08:46.501+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:499,-0.008180,0.040784,0.068151
06-07 17:08:46.501+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.501+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.501+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:509,2.091963,-0.251482,9.577621
06-07 17:08:46.501+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:510,-0.013976,-0.047651,0.018344
06-07 17:08:46.501+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.511+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:504,2.258825,-0.196211,9.600004
06-07 17:08:46.511+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:515,0.105180,0.076181,0.036636
06-07 17:08:46.511+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.511+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.521+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:524,5.810000,0.210000,-1.050000
06-07 17:08:46.521+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.521+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.521+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:524,2.263610,-0.114855,9.643075
06-07 17:08:46.521+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:531,0.171647,0.136627,0.065454
06-07 17:08:46.531+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:529,2.048772,-0.232586,9.587430
06-07 17:08:46.531+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.531+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.531+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:540,2.218147,-0.114855,9.592826
06-07 17:08:46.531+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:540,3.360000,0.070000,-0.980000
06-07 17:08:46.541+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.541+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:546,0.169375,0.117730,0.005396
06-07 17:08:46.541+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.541+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:550,2.024842,-0.219681,9.592817
06-07 17:08:46.551+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:46.551+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.551+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:560,1.960000,0.420000,-0.840000
06-07 17:08:46.551+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.551+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.551+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.561+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:46:559,565.000000
06-07 17:08:46.561+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:564,0.200483,0.181396,-0.014348
06-07 17:08:46.571+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:568,2.225325,-0.038285,9.578469
06-07 17:08:46.571+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:570,2.009795,-0.206688,9.596270
06-07 17:08:46.571+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.571+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.571+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.571+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:580,1.890000,0.140000,-0.840000
06-07 17:08:46.581+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:581,2.246860,-0.062213,9.638289
06-07 17:08:46.581+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.581+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:582,1.996544,-0.195618,9.599267
06-07 17:08:46.591+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:590,0.237065,0.144475,0.042020
06-07 17:08:46.591+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.591+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.601+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:601,1.960000,0.700000,-0.560000
06-07 17:08:46.601+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:46.601+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:601,2.237289,-0.007178,9.576077
06-07 17:08:46.601+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:46:607,80
06-07 17:08:46.601+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.601+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.611+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:614,0.240745,0.188440,-0.023190
06-07 17:08:46.611+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:615,1.978119,-0.182360,9.603342
06-07 17:08:46.611+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.611+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.621+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:624,0.700000,1.050000,-0.700000
06-07 17:08:46.621+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.621+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:624,2.232504,-0.014357,9.571291
06-07 17:08:46.621+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.621+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:631,1.971663,-0.172627,9.604849
06-07 17:08:46.631+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:629,0.254385,0.168003,-0.032051
06-07 17:08:46.631+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.631+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.631+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:639,0.070000,1.120000,-0.630000
06-07 17:08:46.631+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:639,2.232504,-0.110070,9.650253
06-07 17:08:46.641+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.641+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:646,0.260840,0.062557,0.045404
06-07 17:08:46.641+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.641+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:650,1.975835,-0.169194,9.604053
06-07 17:08:46.651+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.651+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:660,0.840000,0.840000,-0.490000
06-07 17:08:46.651+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.661+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.661+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:665,0.218383,0.073481,0.046201
06-07 17:08:46.661+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:665,2.194218,-0.095713,9.650253
06-07 17:08:46.661+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.661+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:669,1.969880,-0.163672,9.605371
06-07 17:08:46.671+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.671+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:681,1.330000,0.350000,-0.280000
06-07 17:08:46.671+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.681+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.681+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:685,2.179861,-0.055035,9.698111
06-07 17:08:46.681+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.681+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:690,1.956071,-0.155523,9.608329
06-07 17:08:46.681+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:686,0.209981,0.108637,0.092739
06-07 17:08:46.691+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.691+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:701,0.630000,0.350000,-0.070000
06-07 17:08:46.691+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.701+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.701+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:706,0.245326,0.114845,0.017997
06-07 17:08:46.701+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:705,2.201397,-0.040678,9.626326
06-07 17:08:46.701+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.701+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:711,1.950447,-0.148666,9.609581
06-07 17:08:46.711+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.721+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:725,0.630000,0.070000,0.140000
06-07 17:08:46.721+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.721+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:729,0.294021,0.117559,-0.002398
06-07 17:08:46.721+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.731+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.731+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.731+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:735,2.244468,-0.031107,9.607183
06-07 17:08:46.731+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.731+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:739,0.140000,0.210000,0.070000
06-07 17:08:46.731+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.731+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:741,2.266003,-0.062213,9.643075
06-07 17:08:46.741+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:744,0.320194,0.079590,0.032451
06-07 17:08:46.741+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:734,1.945809,-0.141804,9.610624
06-07 17:08:46.741+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.751+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:752,1.949613,-0.137737,9.609913
06-07 17:08:46.751+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:46.751+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.761+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:46:759,572.000000
06-07 17:08:46.761+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.771+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:768,2.242075,0.028714,9.652647
06-07 17:08:46.791+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.801+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:803,2.194218,-0.016750,9.616754
06-07 17:08:46.801+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:46.811+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.821+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:760,0.490000,0.140000,0.070000
06-07 17:08:46.821+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.821+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:46:814,80
06-07 17:08:46.831+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:820,0.292462,0.166451,0.042734
06-07 17:08:46.841+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.851+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.851+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.851+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:859,0.252605,0.112079,0.005097
06-07 17:08:46.851+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.861+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:856,2.225325,-0.050249,9.652647
06-07 17:08:46.871+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:830,-0.140000,0.350000,0.070000
06-07 17:08:46.871+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:851,1.941613,-0.128829,9.611656
06-07 17:08:46.871+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.871+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.881+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:878,1.943822,-0.123759,9.611276
06-07 17:08:46.891+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.891+0200 W/LOCATION(16629): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:08:46.891+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:883,-0.420000,0.070000,0.070000
06-07 17:08:46.901+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:864,0.281503,0.073510,0.041371
06-07 17:08:46.901+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.911+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.911+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.921+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:916,-0.280000,0.070000,-0.070000
06-07 17:08:46.921+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.921+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:899,2.215754,-0.114855,9.645468
06-07 17:08:46.921+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.931+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:920,1.954118,-0.121141,9.609221
06-07 17:08:46.941+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:911,0.261636,0.006286,0.036246
06-07 17:08:46.941+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.951+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.951+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:08:46.951+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:934,2.225325,-0.014357,9.585647
06-07 17:08:46.951+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:08:46:960,574.000000
06-07 17:08:46.951+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:46.961+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:931,0.070000,0.210000,0.140000
06-07 17:08:46.961+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.961+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:957,0.258278,0.107012,-0.020933
06-07 17:08:46.961+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:46.971+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:953,1.967047,-0.121368,9.606580
06-07 17:08:46.971+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:46.971+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:46:981,1.967286,-0.116166,9.606595
06-07 17:08:46.981+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:46:965,2.194218,0.021535,9.640682
06-07 17:08:46.991+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:967,-0.420000,0.070000,0.630000
06-07 17:08:46.991+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:46.991+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:47.001+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:46:970,0.226932,0.137701,0.034087
06-07 17:08:47.001+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:08:47.001+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:08:47:9,80
06-07 17:08:47.001+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:46:997,-1.820000,0.070000,0.910000
06-07 17:08:47.011+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:47.011+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:47.021+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:47:3,2.220540,0.045464,9.611969
06-07 17:08:47.021+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:47.021+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:47.031+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:47:15,0.250059,0.156091,0.005963
06-07 17:08:47.031+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:47.031+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:47:17,1.970480,-0.110628,9.606006
06-07 17:08:47.031+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:47.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:08:47.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:08:47.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:08:47.061+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:47:35,-1.540000,-0.070000,0.630000
06-07 17:08:47.061+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:47:34,2.220540,-0.059821,9.643075
06-07 17:08:47.071+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:47:39,0.224064,0.047442,0.042399
06-07 17:08:47.071+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:08:47.071+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:47.081+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:47:43,1.996475,-0.107262,9.600676
06-07 17:08:47.081+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:47.091+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:08:47.101+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:08:47:82,2.191825,-0.098106,9.647861
06-07 17:08:47.101+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:08:47:96,-0.350000,0.070000,0.070000
06-07 17:08:47.111+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:08:47.121+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:08:47:78,0.165004,0.010265,0.053558
06-07 17:08:47.121+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:47:88,2.026821,-0.108371,9.594302
06-07 17:08:47.121+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:47.121+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:08:47:129,2.038045,-0.108586,9.591922
06-07 17:08:47.131+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:08:47.131+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11166296c6f63152838412
