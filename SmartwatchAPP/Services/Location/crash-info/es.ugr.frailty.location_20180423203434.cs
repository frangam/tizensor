S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10407
Date: 2018-04-23 20:34:34+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf732452d, r5   = 0xf7627f98
r6   = 0xffa189c0, r7   = 0xffa18870
r8   = 0xf7624c18, r9   = 0x00000000
r10  = 0xffa1894c, fp   = 0xffa189c0
ip   = 0x00000001, sp   = 0xffa18848
lr   = 0xf7324539, pc   = 0xf738d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     86512 KB
Buffers:     37000 KB
Cached:     156024 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11816 KB
VmRSS:       11816 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10407 TID = 10407
10407 10410 

Maps Information
f41ef000 f49ee000 rw-p [stack:10410]
f49f5000 f49f7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49ff000 f4a03000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a0c000 f4a0e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a16000 f4a19000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a28000 f4a2d000 r-xp /usr/lib/libsystem.so.0.0.0
f4a38000 f4a3b000 r-xp /lib/libattr.so.1.1.0
f4a43000 f4a53000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a5b000 f4a64000 r-xp /usr/lib/libedbus.so.1.7.99
f4a6c000 f4a6d000 r-xp /usr/lib/libresponse.so.0.2.96
f4a76000 f4a7b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f631d000 f6423000 r-xp /usr/lib/libicuuc.so.57.1
f6439000 f65c1000 r-xp /usr/lib/libicui18n.so.57.1
f65d1000 f65de000 r-xp /usr/lib/libail.so.0.1.0
f65e7000 f65ee000 r-xp /usr/lib/libminizip.so.1.0.0
f65f7000 f67a0000 r-xp /usr/lib/libcrypto.so.1.0.0
f67c0000 f6807000 r-xp /usr/lib/libssl.so.1.0.0
f6813000 f6815000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f681d000 f6824000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f682d000 f6834000 r-xp /lib/libcrypt-2.13.so
f6865000 f6868000 r-xp /lib/libcap.so.2.21
f6870000 f6872000 r-xp /usr/lib/libiri.so
f687a000 f68c3000 r-xp /usr/lib/libmdm.so.1.2.69
f68cb000 f68d1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68d9000 f68fc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6906000 f6908000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6910000 f692d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6936000 f693a000 r-xp /usr/lib/libsmack.so.1.0.0
f6943000 f695c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6965000 f696d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6975000 f697b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6984000 f6986000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f698f000 f699f000 r-xp /lib/libresolv-2.13.so
f69a3000 f69bb000 r-xp /usr/lib/liblzma.so.5.0.3
f69c4000 f69c6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69ce000 f69e8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69f0000 f6a1f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a28000 f6a37000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a41000 f6a4b000 r-xp /usr/lib/libsensord-shared.so
f6a54000 f6b27000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b32000 f6b48000 r-xp /lib/libz.so.1.2.5
f6b50000 f6b55000 r-xp /usr/lib/libffi.so.5.0.10
f6b5d000 f6b5e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b66000 f6b76000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b7e000 f6b97000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b9f000 f6ba1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ba9000 f6c1e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c28000 f6c2e000 r-xp /lib/librt-2.13.so
f6c37000 f6c55000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c5f000 f6c60000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c68000 f6c8b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c93000 f6c98000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ca0000 f6cca000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cd3000 f6cea000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cf2000 f6d5b000 r-xp /lib/libm-2.13.so
f6d64000 f6df8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e0b000 f6e10000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e18000 f6e1f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e27000 f6e51000 r-xp /usr/lib/libsensor.so.1.9.6
f6e5a000 f6f26000 r-xp /usr/lib/libxml2.so.2.7.8
f6f33000 f6f35000 r-xp /usr/lib/libiniparser.so.0
f6f3e000 f6f44000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f4d000 f701d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f701e000 f7052000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f705b000 f7097000 r-xp /usr/lib/libSLP-location.so.0.9.24
f709f000 f70a2000 r-xp /usr/lib/libbundle.so.0.1.22
f70aa000 f70b0000 r-xp /usr/lib/libappsvc.so.0.1.0
f70b8000 f70f9000 r-xp /usr/lib/libeina.so.1.7.99
f7102000 f7119000 r-xp /usr/lib/libecore.so.1.7.99
f7130000 f7139000 r-xp /usr/lib/libvconf.so.0.2.45
f7141000 f7155000 r-xp /lib/libpthread-2.13.so
f7160000 f716d000 r-xp /usr/lib/libaul.so.0.1.0
f7177000 f7179000 r-xp /lib/libdl-2.13.so
f7182000 f718d000 r-xp /lib/libunwind.so.8.0.1
f71ba000 f71c2000 r-xp /lib/libgcc_s-4.6.so.1
f71c3000 f72e7000 r-xp /lib/libc-2.13.so
f72f5000 f72f7000 r-xp /usr/lib/libdlog.so.0.0.0
f72ff000 f730b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7314000 f7319000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7321000 f7330000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7338000 f733c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7345000 f7348000 r-xp /usr/lib/libappcore-agent.so.1.1
f7350000 f7352000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f735a000 f735e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7366000 f7383000 r-xp /lib/ld-2.13.so
f738c000 f738f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f738f000 f7393000 r-xp /usr/lib/libsys-assert.so
f75f4000 f7656000 rw-p [heap]
ff9fa000 ffa1b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10407)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf738d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7324539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf702b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7029c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7035e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf703bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf703bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf707075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf706b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7029c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7035e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf703bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf703bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf706de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf706e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7075f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a0d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a00171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ad3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f80fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f827a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7112ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf710db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf710e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf710e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7346183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73467fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf738d53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf71da85c) [/lib/libc.so.6] + 0x1785c
29: (0xf738cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.649+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:649,0.038177,9.769827,0.848183
04-23 20:34:33.649+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.649+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:658,0.052642,9.767502,0.808774
04-23 20:34:33.659+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:660,0.036312,9.769578,0.851127
04-23 20:34:33.659+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.659+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:664,0.036226,9.769764,0.848992
04-23 20:34:33.659+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.659+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:668,0.037172,9.769852,0.847940
04-23 20:34:33.659+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.669+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.669+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:673,-0.001279,0.004828,-0.067880
04-23 20:34:33.669+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:673,-0.070000,-0.070000,0.070000
04-23 20:34:33.669+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.669+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.669+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:677,0.037273,9.769997,0.846258
04-23 20:34:33.679+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:678,0.035892,9.774680,0.780060
04-23 20:34:33.679+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.679+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.679+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.689+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:692,0.036908,9.769991,0.846341
04-23 20:34:33.689+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:692,-0.010952,0.033398,-0.042270
04-23 20:34:33.689+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.689+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:696,0.026321,9.803394,0.803988
04-23 20:34:33.689+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:697,-0.070000,-0.070000,0.070000
04-23 20:34:33.699+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.699+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.709+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:712,0.036897,9.770030,0.845892
04-23 20:34:33.709+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:712,-0.003408,0.059724,-0.042352
04-23 20:34:33.709+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.709+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.709+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:33.709+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:716,0.033500,9.829715,0.803988
04-23 20:34:33.709+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:33.709+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:716,-0.070000,-0.070000,0.070000
04-23 20:34:33.719+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.729+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.729+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:732,0.069392,9.798609,0.801596
04-23 20:34:33.729+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.729+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:734,0.032495,0.028579,-0.044296
04-23 20:34:33.729+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.739+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:738,0.038600,9.770232,0.843481
04-23 20:34:33.739+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:742,-0.070000,-0.070000,0.070000
04-23 20:34:33.749+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.749+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.749+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:755,0.011649,0.018806,-0.075385
04-23 20:34:33.759+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:757,0.050249,9.789038,0.768096
04-23 20:34:33.759+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.759+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.759+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.769+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:764,0.039310,9.770439,0.841047
04-23 20:34:33.769+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.769+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.769+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:775,0.038273,9.770420,0.841312
04-23 20:34:33.769+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:775,-0.024953,0.025777,-0.053808
04-23 20:34:33.779+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:763,-0.140000,0.140000,0.070000
04-23 20:34:33.779+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:772,0.014357,9.796216,0.787239
04-23 20:34:33.779+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.789+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.789+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.789+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.789+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:789,-0.070000,-0.070000,0.070000
04-23 20:34:33.799+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.799+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:793,0.038203,9.770507,0.840311
04-23 20:34:33.799+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:799,-0.004773,0.023403,-0.056466
04-23 20:34:33.799+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:794,0.033500,9.793823,0.784846
04-23 20:34:33.799+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:804,-0.070000,-0.070000,0.070000
04-23 20:34:33.799+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.809+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.809+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:813,0.038589,9.770552,0.839768
04-23 20:34:33.809+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:813,0.043071,9.805787,0.803988
04-23 20:34:33.809+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.809+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.819+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:820,0.004868,0.035280,-0.036323
04-23 20:34:33.819+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:822,-0.070000,-0.070000,0.070000
04-23 20:34:33.819+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.829+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.829+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.829+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:833,0.064606,9.841680,0.780060
04-23 20:34:33.839+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.839+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:833,0.039985,9.770820,0.836583
04-23 20:34:33.839+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:839,0.026017,0.071128,-0.059708
04-23 20:34:33.839+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:843,-0.070000,-0.070000,0.070000
04-23 20:34:33.849+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.849+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.849+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:855,0.041109,9.770666,0.838321
04-23 20:34:33.849+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:855,0.057428,9.815358,0.823131
04-23 20:34:33.849+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.849+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.859+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:862,0.017443,0.044538,-0.013452
04-23 20:34:33.859+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:863,-0.070000,-0.070000,0.140000
04-23 20:34:33.859+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.859+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.869+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:873,0.041712,9.770776,0.837013
04-23 20:34:33.869+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:873,0.050249,9.762716,0.789631
04-23 20:34:33.869+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.869+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.879+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:879,0.009140,-0.007950,-0.048690
04-23 20:34:33.879+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:882,-0.070000,-0.070000,0.070000
04-23 20:34:33.879+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.889+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.889+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:893,0.042175,9.771122,0.832931
04-23 20:34:33.889+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:893,0.047856,9.810574,0.739382
04-23 20:34:33.889+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.889+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.899+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:899,0.006145,0.039798,-0.097631
04-23 20:34:33.899+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:901,-0.070000,-0.070000,0.070000
04-23 20:34:33.909+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.909+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.909+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:913,0.023928,9.777073,0.811167
04-23 20:34:33.909+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.919+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:914,0.041456,9.771009,0.834289
04-23 20:34:33.919+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:923,-0.018247,0.005951,-0.021764
04-23 20:34:33.929+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:33.929+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:33.929+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.929+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.939+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.939+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:936,0.041460,9.771071,0.833561
04-23 20:34:33.939+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:943,-0.070000,0.070000,0.070000
04-23 20:34:33.939+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:33.939+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:941,-0.003171,-0.003508,-0.042265
04-23 20:34:33.939+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.949+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.949+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.959+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:953,0.038285,9.767502,0.792024
04-23 20:34:33.959+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:954,0.040420,9.771162,0.832555
04-23 20:34:33.959+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:960,-0.024711,0.017966,-0.072644
04-23 20:34:33.969+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.969+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.979+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:974,0.041609,9.771328,0.830542
04-23 20:34:33.979+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:33:982,0.021793,0.029840,-0.042924
04-23 20:34:33.979+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.989+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:33:992,0.016750,9.789038,0.760918
04-23 20:34:33.989+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:33.999+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:33.999+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:33.999+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:33:998,0.043287,9.771353,0.830164
04-23 20:34:34.009+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.009+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:33:949,0.070000,-0.070000,0.070000
04-23 20:34:34.019+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.019+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:7,0.032569,0.036852,-0.009804
04-23 20:34:34.029+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.029+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:11,0.062213,9.801002,0.789631
04-23 20:34:34.029+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.029+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:18,0.042974,9.771294,0.830876
04-23 20:34:34.029+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:28,0.070000,-0.070000,0.070000
04-23 20:34:34.039+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.039+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.049+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:50,0.070000,-0.070000,0.070000
04-23 20:34:34.049+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.049+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:42,-0.009787,0.015292,-0.014212
04-23 20:34:34.049+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:44,0.074178,9.808180,0.820738
04-23 20:34:34.049+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:47,0.044054,9.771329,0.830410
04-23 20:34:34.049+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:56,0.070000,-0.070000,0.070000
04-23 20:34:34.049+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.059+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:62,0.070000,-0.070000,0.070000
04-23 20:34:34.059+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:34:34.059+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:34:34.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:34:34.069+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.069+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.069+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:73,0.070000,-0.070000,0.070000
04-23 20:34:34.069+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.079+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.079+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:80,0.070000,-0.280000,0.070000
04-23 20:34:34.079+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.079+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:84,0.042363,9.771245,0.831481
04-23 20:34:34.079+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.079+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:86,0.070000,-0.140000,0.140000
04-23 20:34:34.079+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.089+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:76,0.033500,9.786645,0.815953
04-23 20:34:34.089+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.089+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:74,0.019239,-0.046863,-0.024495
04-23 20:34:34.089+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.089+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:93,-0.070000,-0.140000,0.140000
04-23 20:34:34.089+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:97,0.062213,9.724431,0.806381
04-23 20:34:34.099+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:88,0.043410,9.771531,0.828061
04-23 20:34:34.099+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.099+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:101,-0.039268,0.000958,-0.019243
04-23 20:34:34.099+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.099+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.099+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:107,0.015065,0.036935,-0.094491
04-23 20:34:34.099+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.109+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:108,0.004786,9.772287,0.811167
04-23 20:34:34.109+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.109+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:104,0.041331,9.771213,0.831919
04-23 20:34:34.109+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:113,-0.070000,-0.140000,0.140000
04-23 20:34:34.109+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.109+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:34.109+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:34.109+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.109+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:114,0.057428,9.808180,0.736989
04-23 20:34:34.119+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:118,0.041845,9.771338,0.830408
04-23 20:34:34.119+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:121,-0.050588,0.019899,-0.012109
04-23 20:34:34.119+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.119+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.119+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:127,0.004132,0.053717,-0.078180
04-23 20:34:34.119+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:127,-0.007178,9.791430,0.815953
04-23 20:34:34.119+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.119+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.129+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:133,-0.070000,-0.070000,0.070000
04-23 20:34:34.129+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:132,0.041495,9.771204,0.832010
04-23 20:34:34.129+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.129+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.129+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:137,0.045464,9.824929,0.753739
04-23 20:34:34.129+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.129+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:139,-0.010739,0.029663,-0.002492
04-23 20:34:34.139+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:142,0.031107,9.801002,0.827917
04-23 20:34:34.149+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.149+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.149+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.149+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:156,-0.070000,-0.070000,0.070000
04-23 20:34:34.149+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:157,0.040252,9.771097,0.833318
04-23 20:34:34.149+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.159+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:156,-0.029531,-0.008488,-0.030415
04-23 20:34:34.159+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:161,0.011964,9.762716,0.801596
04-23 20:34:34.159+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.159+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.169+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:172,-0.070000,-0.070000,0.070000
04-23 20:34:34.169+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:172,0.040201,9.771062,0.833741
04-23 20:34:34.169+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.169+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.169+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:177,-0.004359,0.027512,-0.024544
04-23 20:34:34.169+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:177,0.035892,9.798609,0.808774
04-23 20:34:34.189+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.189+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.189+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:194,-0.070000,-0.070000,0.070000
04-23 20:34:34.189+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:194,0.041636,9.771243,0.831545
04-23 20:34:34.189+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.189+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.199+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:200,0.026798,0.032332,-0.046502
04-23 20:34:34.199+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:201,0.066999,9.803394,0.787239
04-23 20:34:34.209+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.209+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.209+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:213,0.043451,9.771350,0.830186
04-23 20:34:34.209+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:213,-0.070000,-0.070000,0.070000
04-23 20:34:34.209+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.209+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.219+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:218,0.076570,9.791430,0.801596
04-23 20:34:34.219+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:219,0.034934,0.020187,-0.029950
04-23 20:34:34.219+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.229+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.229+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:234,0.043013,9.771177,0.832247
04-23 20:34:34.229+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:233,-0.070000,0.070000,0.070000
04-23 20:34:34.229+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.239+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.239+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:243,0.031107,9.801002,0.832702
04-23 20:34:34.249+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.249+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.259+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:242,-0.012345,0.029652,0.002517
04-23 20:34:34.259+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.259+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:255,0.042034,9.770964,0.834793
04-23 20:34:34.259+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:256,-0.070000,0.070000,0.070000
04-23 20:34:34.259+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.269+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:265,0.019143,9.817751,0.839881
04-23 20:34:34.269+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.269+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.269+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:275,0.026321,9.791430,0.794417
04-23 20:34:34.279+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:276,0.041443,9.770956,0.834915
04-23 20:34:34.279+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:275,-0.023871,0.046574,0.007634
04-23 20:34:34.279+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.279+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.279+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.289+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:290,-0.015713,0.020467,-0.040376
04-23 20:34:34.289+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.299+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:298,0.001628,0.063545,-0.009391
04-23 20:34:34.299+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.299+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:305,0.041667,9.770889,0.835680
04-23 20:34:34.309+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.309+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:313,-0.022524,0.039684,-0.031692
04-23 20:34:34.309+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:293,0.043071,9.834501,0.825524
04-23 20:34:34.309+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.309+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:34.309+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:34.309+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.319+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:321,0.040750,9.770829,0.836431
04-23 20:34:34.319+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:291,-0.070000,-0.070000,0.070000
04-23 20:34:34.319+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.329+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.329+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.339+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:334,0.039641,9.770806,0.836749
04-23 20:34:34.339+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:331,-0.070000,-0.070000,0.070000
04-23 20:34:34.339+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.349+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.359+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:355,0.039050,9.770832,0.836479
04-23 20:34:34.359+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:351,-0.070000,-0.070000,0.070000
04-23 20:34:34.359+0200 W/LOCATION(10407): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:34:34.359+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.369+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.369+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:334,-0.026393,0.070850,-0.046800
04-23 20:34:34.369+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.379+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:374,0.036893,9.770649,0.838718
04-23 20:34:34.379+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:323,0.019143,9.810574,0.803988
04-23 20:34:34.379+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.379+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:370,-0.070000,-0.070000,0.070000
04-23 20:34:34.379+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.389+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.389+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:382,-0.015712,0.046945,-0.047117
04-23 20:34:34.389+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.389+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:393,0.037482,9.771056,0.833935
04-23 20:34:34.389+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:390,-0.070000,-0.140000,0.070000
04-23 20:34:34.399+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.399+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:386,0.014357,9.841680,0.789631
04-23 20:34:34.399+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.399+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:404,-0.070000,-0.070000,0.070000
04-23 20:34:34.399+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.409+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:413,0.035988,9.770831,0.836628
04-23 20:34:34.409+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.419+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:420,-0.070000,-0.070000,0.070000
04-23 20:34:34.419+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:398,-0.048622,0.013420,-0.034883
04-23 20:34:34.419+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.419+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.419+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:426,0.008570,0.020782,-0.108908
04-23 20:34:34.419+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:426,-0.070000,-0.070000,0.070000
04-23 20:34:34.429+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:406,0.023928,9.817751,0.789631
04-23 20:34:34.429+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.429+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.429+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:434,0.035916,9.770523,0.840217
04-23 20:34:34.429+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.439+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:440,-0.070000,-0.070000,0.070000
04-23 20:34:34.439+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:434,-0.009571,9.784252,0.801596
04-23 20:34:34.439+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.439+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:445,0.045464,9.791430,0.729811
04-23 20:34:34.439+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.449+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.449+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.449+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.449+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:454,0.070000,-0.070000,0.070000
04-23 20:34:34.449+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:455,0.033075,9.770294,0.842999
04-23 20:34:34.459+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:453,-0.035089,0.020374,-0.003626
04-23 20:34:34.459+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.459+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:466,-0.004881,0.037349,0.039145
04-23 20:34:34.459+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.459+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.459+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.469+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:472,-0.070000,0.210000,0.140000
04-23 20:34:34.469+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:473,0.031310,9.769864,0.848032
04-23 20:34:34.469+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:451,0.002393,9.791430,0.830309
04-23 20:34:34.469+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.479+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:471,-0.062237,0.011335,-0.062550
04-23 20:34:34.479+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.479+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.479+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.489+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:492,-0.070000,-0.070000,0.140000
04-23 20:34:34.489+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:493,0.030245,9.769486,0.852415
04-23 20:34:34.489+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:480,0.031107,9.808180,0.875773
04-23 20:34:34.489+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.499+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:501,-0.026321,9.781858,0.777667
04-23 20:34:34.499+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.499+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:506,-0.009571,9.812965,0.777667
04-23 20:34:34.499+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.509+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.509+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.509+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:513,-0.070000,-0.070000,0.140000
04-23 20:34:34.509+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:514,0.030025,9.769218,0.855487
04-23 20:34:34.509+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:488,-0.042647,0.042671,-0.065332
04-23 20:34:34.509+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.509+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:34.509+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:34.519+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:519,-0.028917,0.011994,-0.041650
04-23 20:34:34.519+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.529+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.529+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.529+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:533,-0.070000,0.070000,0.070000
04-23 20:34:34.529+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:534,0.031481,9.769602,0.851037
04-23 20:34:34.529+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:527,-0.011102,0.029122,-0.041248
04-23 20:34:34.529+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:510,0.002393,9.781858,0.806381
04-23 20:34:34.529+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.539+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.539+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:542,0.019143,9.798609,0.811167
04-23 20:34:34.539+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.549+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.549+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.549+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:554,-0.070000,-0.140000,0.070000
04-23 20:34:34.549+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:554,0.032302,9.769605,0.850984
04-23 20:34:34.549+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:543,0.027403,0.048532,-0.075427
04-23 20:34:34.549+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.559+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:551,0.057428,9.817751,0.780060
04-23 20:34:34.559+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.559+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:560,0.013982,0.012257,-0.018335
04-23 20:34:34.569+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.569+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.569+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:574,0.032296,9.769696,0.849930
04-23 20:34:34.569+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:573,-0.070000,-0.140000,0.070000
04-23 20:34:34.569+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.579+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:567,0.045464,9.781858,0.832702
04-23 20:34:34.579+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:579,-0.003588,0.021826,-0.058960
04-23 20:34:34.579+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.579+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:586,0.028714,9.791430,0.792024
04-23 20:34:34.579+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.579+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.589+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:592,-0.070000,-0.140000,0.070000
04-23 20:34:34.589+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:593,0.033444,9.769986,0.846547
04-23 20:34:34.589+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.589+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.589+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:598,0.052642,9.757930,0.782453
04-23 20:34:34.599+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:597,0.020347,-0.011766,-0.067477
04-23 20:34:34.609+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.609+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.609+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:613,-0.070000,-0.140000,0.140000
04-23 20:34:34.609+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.609+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:613,0.033189,9.769795,0.848749
04-23 20:34:34.609+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.619+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:617,0.021535,9.822537,0.803988
04-23 20:34:34.619+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:620,-0.011909,0.052551,-0.042558
04-23 20:34:34.629+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.629+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.629+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.629+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.629+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:638,0.005096,0.016850,-0.083046
04-23 20:34:34.629+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:634,0.070000,-0.070000,0.070000
04-23 20:34:34.639+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:634,0.033592,9.770077,0.845495
04-23 20:34:34.639+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:637,0.038285,9.786645,0.765703
04-23 20:34:34.649+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:34.649+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.649+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.649+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:34.649+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:654,0.070000,-0.140000,0.070000
04-23 20:34:34.649+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:34:654,0.033742,9.770002,0.846344
04-23 20:34:34.659+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:655,-0.000092,0.033318,-0.008007
04-23 20:34:34.659+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:34:658,0.033500,9.803394,0.837488
04-23 20:34:34.669+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:34.669+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.669+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:676,-0.000242,0.030999,-0.027999
04-23 20:34:34.669+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:34:674,0.070000,-0.140000,0.070000
04-23 20:34:34.689+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:34.689+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:34:693,0.018756,0.035772,-0.070924
04-23 20:34:34.699+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11104076c6f63152450847
