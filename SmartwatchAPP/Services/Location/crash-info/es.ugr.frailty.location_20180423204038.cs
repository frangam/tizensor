S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12206
Date: 2018-04-23 20:40:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73e252d, r5   = 0xf79b5f98
r6   = 0xff96ea40, r7   = 0xff96e8f0
r8   = 0xf79b2c18, r9   = 0x00000000
r10  = 0xff96e9cc, fp   = 0xff96ea40
ip   = 0x00000001, sp   = 0xff96e8c8
lr   = 0xf73e2539, pc   = 0xf744b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    119576 KB
Buffers:     40120 KB
Cached:     160900 KB
VmPeak:      53460 KB
VmSize:      53424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11788 KB
VmRSS:       11788 KB
VmData:      11152 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12206 TID = 12206
12206 12209 

Maps Information
f42ad000 f4aac000 rw-p [stack:12209]
f4ab3000 f4ab5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4abd000 f4ac1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4aca000 f4acc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ad4000 f4ad7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ae6000 f4aeb000 r-xp /usr/lib/libsystem.so.0.0.0
f4af6000 f4af9000 r-xp /lib/libattr.so.1.1.0
f4b01000 f4b11000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b19000 f4b22000 r-xp /usr/lib/libedbus.so.1.7.99
f4b2a000 f4b2b000 r-xp /usr/lib/libresponse.so.0.2.96
f4b34000 f4b39000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63db000 f64e1000 r-xp /usr/lib/libicuuc.so.57.1
f64f7000 f667f000 r-xp /usr/lib/libicui18n.so.57.1
f668f000 f669c000 r-xp /usr/lib/libail.so.0.1.0
f66a5000 f66ac000 r-xp /usr/lib/libminizip.so.1.0.0
f66b5000 f685e000 r-xp /usr/lib/libcrypto.so.1.0.0
f687e000 f68c5000 r-xp /usr/lib/libssl.so.1.0.0
f68d1000 f68d3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68db000 f68e2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68eb000 f68f2000 r-xp /lib/libcrypt-2.13.so
f6923000 f6926000 r-xp /lib/libcap.so.2.21
f692e000 f6930000 r-xp /usr/lib/libiri.so
f6938000 f6981000 r-xp /usr/lib/libmdm.so.1.2.69
f6989000 f698f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6997000 f69ba000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69c4000 f69c6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69ce000 f69eb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69f4000 f69f8000 r-xp /usr/lib/libsmack.so.1.0.0
f6a01000 f6a1a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a23000 f6a2b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a33000 f6a39000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a42000 f6a44000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a4d000 f6a5d000 r-xp /lib/libresolv-2.13.so
f6a61000 f6a79000 r-xp /usr/lib/liblzma.so.5.0.3
f6a82000 f6a84000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a8c000 f6aa6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6aae000 f6add000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ae6000 f6af5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6aff000 f6b09000 r-xp /usr/lib/libsensord-shared.so
f6b12000 f6be5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bf0000 f6c06000 r-xp /lib/libz.so.1.2.5
f6c0e000 f6c13000 r-xp /usr/lib/libffi.so.5.0.10
f6c1b000 f6c1c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c24000 f6c34000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c3c000 f6c55000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c5d000 f6c5f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c67000 f6cdc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ce6000 f6cec000 r-xp /lib/librt-2.13.so
f6cf5000 f6d13000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d1d000 f6d1e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d26000 f6d49000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d51000 f6d56000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d5e000 f6d88000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d91000 f6da8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6db0000 f6e19000 r-xp /lib/libm-2.13.so
f6e22000 f6eb6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ec9000 f6ece000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ed6000 f6edd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ee5000 f6f0f000 r-xp /usr/lib/libsensor.so.1.9.6
f6f18000 f6fe4000 r-xp /usr/lib/libxml2.so.2.7.8
f6ff1000 f6ff3000 r-xp /usr/lib/libiniparser.so.0
f6ffc000 f7002000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f700b000 f70db000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70dc000 f7110000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7119000 f7155000 r-xp /usr/lib/libSLP-location.so.0.9.24
f715d000 f7160000 r-xp /usr/lib/libbundle.so.0.1.22
f7168000 f716e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7176000 f71b7000 r-xp /usr/lib/libeina.so.1.7.99
f71c0000 f71d7000 r-xp /usr/lib/libecore.so.1.7.99
f71ee000 f71f7000 r-xp /usr/lib/libvconf.so.0.2.45
f71ff000 f7213000 r-xp /lib/libpthread-2.13.so
f721e000 f722b000 r-xp /usr/lib/libaul.so.0.1.0
f7235000 f7237000 r-xp /lib/libdl-2.13.so
f7240000 f724b000 r-xp /lib/libunwind.so.8.0.1
f7278000 f7280000 r-xp /lib/libgcc_s-4.6.so.1
f7281000 f73a5000 r-xp /lib/libc-2.13.so
f73b3000 f73b5000 r-xp /usr/lib/libdlog.so.0.0.0
f73bd000 f73c9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73d2000 f73d7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73df000 f73ee000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73f6000 f73fa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7403000 f7406000 r-xp /usr/lib/libappcore-agent.so.1.1
f740e000 f7410000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7418000 f741c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7424000 f7441000 r-xp /lib/ld-2.13.so
f744a000 f744d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f744d000 f7451000 r-xp /usr/lib/libsys-assert.so
f7982000 f79ed000 rw-p [heap]
ff950000 ff971000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12206)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf744b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73e2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70e93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70e7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70f3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70f9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70f9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf712e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71291f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70e7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70f3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70f9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70f9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf712be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf712c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7133f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4acb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4abe171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b91663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf703efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70407a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71d0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71cbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71cc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71cc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7404183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74047fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf744b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf729885c) [/lib/libc.so.6] + 0x1785c
29: (0xf744af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:13,-0.070000,-0.070000,0.140000
04-23 20:40:38.019+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:40:38.019+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.019+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.019+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.019+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:27,0.045464,9.817751,0.792024
04-23 20:40:38.019+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:27,0.006507,0.046000,-0.033649
04-23 20:40:38.019+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:24,0.039418,9.771797,0.825114
04-23 20:40:38.029+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.029+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:33,-0.070000,-0.070000,0.070000
04-23 20:40:38.029+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.029+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.039+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:42,0.013224,0.024419,-0.037875
04-23 20:40:38.039+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:43,0.052642,9.796216,0.787239
04-23 20:40:38.039+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.039+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.039+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:46,-0.070000,-0.070000,0.070000
04-23 20:40:38.039+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:48,0.040206,9.771879,0.824100
04-23 20:40:38.049+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.049+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.059+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:61,-0.001921,0.033908,0.006210
04-23 20:40:38.059+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:61,0.038285,9.805787,0.830309
04-23 20:40:38.059+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.059+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.059+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:66,-0.070000,-0.070000,0.070000
04-23 20:40:38.059+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:66,0.040270,9.771729,0.825881
04-23 20:40:38.069+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.069+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.079+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:80,-0.004377,0.029273,-0.055393
04-23 20:40:38.079+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.079+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:80,0.035892,9.801002,0.770489
04-23 20:40:38.079+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.079+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:85,0.040211,9.771848,0.824470
04-23 20:40:38.079+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:87,0.070000,-0.070000,0.070000
04-23 20:40:38.089+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.089+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.099+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.099+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:102,-0.054568,0.033939,-0.044410
04-23 20:40:38.099+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.099+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:38.099+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:38.099+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:101,-0.014357,9.805787,0.780060
04-23 20:40:38.109+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:108,0.070000,-0.070000,0.070000
04-23 20:40:38.109+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:108,0.037753,9.771708,0.826252
04-23 20:40:38.109+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.109+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.119+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:121,0.069392,9.784252,0.780060
04-23 20:40:38.119+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.119+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.119+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:122,0.031639,0.012545,-0.046191
04-23 20:40:38.119+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:127,-0.070000,-0.070000,0.070000
04-23 20:40:38.129+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:128,0.039424,9.771898,0.823916
04-23 20:40:38.129+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.129+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.139+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:142,0.023928,9.786645,0.796810
04-23 20:40:38.139+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:143,-0.015496,0.014747,-0.027107
04-23 20:40:38.139+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.139+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.149+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:149,-0.070000,-0.070000,0.140000
04-23 20:40:38.149+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:150,0.038997,9.771688,0.826430
04-23 20:40:38.149+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.149+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.159+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:160,0.028714,9.793823,0.784846
04-23 20:40:38.159+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:161,-0.010283,0.022136,-0.041584
04-23 20:40:38.159+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.159+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.159+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:167,-0.070000,-0.070000,0.070000
04-23 20:40:38.169+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:168,0.038664,9.771692,0.826393
04-23 20:40:38.169+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.169+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.179+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:180,0.013978,0.058022,-0.043940
04-23 20:40:38.179+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.179+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.179+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:181,0.052642,9.829715,0.782453
04-23 20:40:38.179+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:187,0.039481,9.771819,0.824849
04-23 20:40:38.189+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:187,-0.070000,-0.070000,0.070000
04-23 20:40:38.189+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.189+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.199+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.199+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:201,-0.070000,0.070000,0.070000
04-23 20:40:38.199+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:201,0.013161,0.026790,-0.020861
04-23 20:40:38.199+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.209+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:203,0.052642,9.798609,0.803988
04-23 20:40:38.209+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:210,0.040247,9.771796,0.825081
04-23 20:40:38.209+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.209+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.219+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.219+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:221,-0.070000,0.070000,0.070000
04-23 20:40:38.219+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.219+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:223,0.019143,9.793823,0.792024
04-23 20:40:38.219+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:220,-0.021104,0.022027,-0.033056
04-23 20:40:38.229+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:228,0.039387,9.771708,0.826164
04-23 20:40:38.239+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.239+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.239+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:243,-0.070000,0.070000,0.070000
04-23 20:40:38.239+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:243,0.008469,0.017329,-0.046104
04-23 20:40:38.239+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.239+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.249+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:250,0.039940,9.771785,0.825239
04-23 20:40:38.249+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:252,0.047856,9.789038,0.780060
04-23 20:40:38.249+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.249+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.259+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:261,-0.070000,0.070000,0.070000
04-23 20:40:38.259+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.259+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.259+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:262,-0.013619,0.031610,-0.042786
04-23 20:40:38.269+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:270,0.039435,9.771762,0.825526
04-23 20:40:38.269+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:269,0.026321,9.803394,0.782453
04-23 20:40:38.269+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.269+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.279+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:281,0.013207,0.041203,-0.045466
04-23 20:40:38.279+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:281,-0.070000,-0.070000,0.070000
04-23 20:40:38.279+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.279+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.289+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:290,0.040220,9.771888,0.824004
04-23 20:40:38.289+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:289,0.052642,9.812965,0.780060
04-23 20:40:38.289+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.289+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.299+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:301,-0.070000,0.070000,0.070000
04-23 20:40:38.299+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:301,0.017208,0.053041,-0.036766
04-23 20:40:38.299+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.299+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.299+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:38.299+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:38.309+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:309,0.041176,9.771965,0.823038
04-23 20:40:38.309+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:308,0.057428,9.824929,0.787239
04-23 20:40:38.309+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.309+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.319+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:321,-0.070000,0.070000,0.070000
04-23 20:40:38.319+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:321,0.013859,0.002715,-0.009478
04-23 20:40:38.319+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.319+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.319+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:327,0.041978,9.771885,0.823950
04-23 20:40:38.329+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:329,0.055035,9.774680,0.813560
04-23 20:40:38.339+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.339+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:344,-0.034799,0.007582,-0.051068
04-23 20:40:38.339+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.349+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:351,-0.070000,0.070000,0.070000
04-23 20:40:38.349+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.349+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.349+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.359+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.359+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:358,0.007178,9.779467,0.772882
04-23 20:40:38.359+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.379+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:363,0.040451,9.771810,0.824913
04-23 20:40:38.379+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.379+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:387,0.040056,9.771690,0.826344
04-23 20:40:38.379+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.389+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:362,-0.011737,0.065084,-0.001782
04-23 20:40:38.389+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.389+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:365,-0.070000,-0.140000,0.070000
04-23 20:40:38.389+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.399+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:372,0.028714,9.836893,0.823131
04-23 20:40:38.409+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:395,0.012586,0.041275,-0.051069
04-23 20:40:38.409+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.419+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:393,0.040820,9.771852,0.824390
04-23 20:40:38.419+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.429+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.429+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:435,0.052642,9.812965,0.775275
04-23 20:40:38.429+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.429+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:402,-0.070000,-0.140000,0.070000
04-23 20:40:38.439+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.439+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:443,-0.070000,-0.070000,0.070000
04-23 20:40:38.439+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.449+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:415,-0.002535,0.019578,0.001133
04-23 20:40:38.449+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.459+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:440,0.038285,9.791430,0.825524
04-23 20:40:38.459+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.459+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:455,0.011785,0.017320,-0.017208
04-23 20:40:38.459+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:449,-0.070000,-0.070000,0.070000
04-23 20:40:38.459+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.459+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.469+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:429,0.040857,9.771718,0.825982
04-23 20:40:38.469+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.469+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:471,-0.000893,0.053233,-0.024611
04-23 20:40:38.469+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.469+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:474,0.041571,9.771696,0.826206
04-23 20:40:38.469+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:477,0.018137,0.010186,-0.012922
04-23 20:40:38.479+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.479+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:465,0.052642,9.789038,0.808774
04-23 20:40:38.479+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.479+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:484,-0.018770,0.053287,-0.070645
04-23 20:40:38.479+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:485,0.040678,9.824929,0.801596
04-23 20:40:38.479+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.479+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:470,-0.140000,-0.070000,0.070000
04-23 20:40:38.479+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.479+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.489+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:491,-0.070000,-0.070000,0.070000
04-23 20:40:38.489+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.489+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:492,0.041683,9.771672,0.826481
04-23 20:40:38.489+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.489+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.499+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:489,0.059821,9.781858,0.813560
04-23 20:40:38.499+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.499+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:501,-0.044341,0.057966,-0.043106
04-23 20:40:38.499+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:496,-0.070000,-0.070000,0.070000
04-23 20:40:38.499+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.499+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:38.499+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:38.499+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:497,0.042699,9.771643,0.826777
04-23 20:40:38.499+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.509+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:509,-0.070000,-0.070000,0.070000
04-23 20:40:38.509+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:506,0.023928,9.824929,0.756132
04-23 20:40:38.509+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.509+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:511,0.041948,9.771749,0.825559
04-23 20:40:38.509+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.509+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.519+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.519+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:519,0.039984,9.771650,0.826821
04-23 20:40:38.519+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.519+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:525,0.039506,9.771535,0.828208
04-23 20:40:38.519+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:520,-0.013663,-0.011327,-0.010868
04-23 20:40:38.519+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:523,-0.070000,-0.140000,0.070000
04-23 20:40:38.519+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:516,-0.002393,9.829715,0.782453
04-23 20:40:38.519+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.529+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:532,0.026321,9.760324,0.815953
04-23 20:40:38.529+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.529+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.529+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.539+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:542,-0.032328,0.010324,-0.002685
04-23 20:40:38.539+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.539+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:546,-0.070000,-0.140000,0.070000
04-23 20:40:38.539+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:546,0.007178,9.781858,0.825524
04-23 20:40:38.539+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:542,0.038149,9.771346,0.830498
04-23 20:40:38.549+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.549+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.549+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.559+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:561,-0.011828,0.034441,-0.048045
04-23 20:40:38.559+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.559+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:561,0.037746,9.771382,0.830087
04-23 20:40:38.559+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:566,-0.070000,-0.140000,0.070000
04-23 20:40:38.559+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:563,0.026321,9.805787,0.782453
04-23 20:40:38.569+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.569+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.569+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.579+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:581,0.000539,0.005691,-0.002170
04-23 20:40:38.579+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.579+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:581,0.038087,9.771119,0.833167
04-23 20:40:38.589+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:589,-0.070000,-0.140000,0.140000
04-23 20:40:38.589+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.589+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.599+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:581,0.038285,9.777073,0.827917
04-23 20:40:38.599+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:601,0.000198,0.060989,-0.045928
04-23 20:40:38.599+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.599+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.609+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:612,-0.070000,-0.140000,0.070000
04-23 20:40:38.609+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.609+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:605,0.038254,9.771209,0.832106
04-23 20:40:38.619+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:612,0.038285,9.832108,0.787239
04-23 20:40:38.619+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.619+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.619+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.629+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:621,-0.059789,0.001079,-0.064010
04-23 20:40:38.629+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:630,-0.070000,-0.140000,0.070000
04-23 20:40:38.629+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.629+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.639+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:625,0.035540,9.771029,0.834334
04-23 20:40:38.639+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.639+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:632,-0.021535,9.772287,0.768096
04-23 20:40:38.639+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:642,-0.006826,0.006043,-0.054274
04-23 20:40:38.639+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.649+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:648,-0.070000,-0.140000,0.070000
04-23 20:40:38.649+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.649+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.659+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:661,-0.070000,-0.140000,0.070000
04-23 20:40:38.659+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:646,0.035380,9.771092,0.833597
04-23 20:40:38.659+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.659+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:661,-0.032987,0.025124,-0.000894
04-23 20:40:38.659+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:653,0.028714,9.777073,0.780060
04-23 20:40:38.669+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.679+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:40:38.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:40:38.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:40:38.689+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.689+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:675,0.002393,9.796216,0.832702
04-23 20:40:38.689+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.689+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:694,-0.070000,-0.140000,0.070000
04-23 20:40:38.689+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:684,0.016255,0.039712,-0.082623
04-23 20:40:38.699+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:696,0.050249,9.810574,0.753739
04-23 20:40:38.699+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.699+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.699+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.699+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:673,0.033994,9.770862,0.836362
04-23 20:40:38.699+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:38.699+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:38.699+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:704,0.031107,9.769895,0.818345
04-23 20:40:38.699+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.709+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:705,-0.140000,-0.140000,0.070000
04-23 20:40:38.709+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:713,0.034945,9.771205,0.832292
04-23 20:40:38.709+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:703,-0.003838,-0.001310,-0.013947
04-23 20:40:38.709+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.709+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.719+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:721,0.047856,9.808180,0.777667
04-23 20:40:38.719+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:721,0.034933,9.771099,0.833541
04-23 20:40:38.719+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.719+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.719+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:726,-0.070000,-0.140000,0.070000
04-23 20:40:38.719+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.719+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:727,0.035716,9.771281,0.831370
04-23 20:40:38.729+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:731,0.012924,0.037081,-0.055874
04-23 20:40:38.729+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.729+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.729+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.739+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:742,0.026321,9.774680,0.813560
04-23 20:40:38.739+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.739+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:742,0.035437,9.771189,0.832461
04-23 20:40:38.739+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:747,-0.070000,-0.140000,0.070000
04-23 20:40:38.739+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:742,-0.009395,0.003399,-0.017810
04-23 20:40:38.749+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.759+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:761,0.055035,9.781858,0.782453
04-23 20:40:38.759+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.759+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.769+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:769,0.019598,0.010670,-0.050008
04-23 20:40:38.769+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.769+0200 W/LOCATION(12206): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:40:38.779+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:766,-0.070000,-0.070000,0.070000
04-23 20:40:38.779+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.779+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.779+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:784,-0.070000,-0.070000,0.140000
04-23 20:40:38.779+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.789+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:776,0.036536,9.771347,0.830558
04-23 20:40:38.789+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:784,-0.000643,0.039227,-0.021784
04-23 20:40:38.789+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.789+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:795,0.036810,9.771152,0.832844
04-23 20:40:38.789+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.789+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:789,0.035892,9.810574,0.808774
04-23 20:40:38.789+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.799+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:801,-0.005703,-0.003650,-0.062355
04-23 20:40:38.799+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:802,0.031107,9.767502,0.770489
04-23 20:40:38.799+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.799+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:808,-0.070000,0.070000,0.070000
04-23 20:40:38.809+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.809+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:814,0.036687,9.771215,0.832099
04-23 20:40:38.809+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.809+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.819+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:821,-0.010366,0.039358,-0.023325
04-23 20:40:38.819+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:821,0.026321,9.810574,0.808774
04-23 20:40:38.819+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.819+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:826,-0.070000,0.070000,0.070000
04-23 20:40:38.819+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.829+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:832,0.036337,9.771113,0.833307
04-23 20:40:38.829+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.829+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.839+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:842,0.100499,9.793823,0.760918
04-23 20:40:38.839+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.839+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:842,0.064161,0.022710,-0.072390
04-23 20:40:38.839+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:847,-0.070000,0.070000,0.070000
04-23 20:40:38.839+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.849+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:852,0.039577,9.771586,0.827598
04-23 20:40:38.849+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.849+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.859+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:861,0.028714,9.793823,0.796810
04-23 20:40:38.859+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:861,-0.010864,0.022237,-0.030788
04-23 20:40:38.859+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.859+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:866,-0.070000,0.070000,0.070000
04-23 20:40:38.859+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.869+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:870,0.039205,9.771525,0.828333
04-23 20:40:38.869+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.869+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.879+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:882,0.052642,9.805787,0.825524
04-23 20:40:38.879+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:882,0.013437,0.034262,-0.002810
04-23 20:40:38.879+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.879+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:887,-0.070000,0.070000,0.070000
04-23 20:40:38.879+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.889+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:891,0.039984,9.771417,0.829579
04-23 20:40:38.889+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.889+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.899+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:901,0.050249,9.836893,0.813560
04-23 20:40:38.899+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.899+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:901,0.010265,0.065476,-0.016019
04-23 20:40:38.899+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.899+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:40:38.899+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:40:38.899+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:909,0.040748,9.771240,0.831619
04-23 20:40:38.909+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:905,-0.070000,0.070000,0.140000
04-23 20:40:38.909+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.909+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.919+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.919+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:921,0.011894,0.039333,-0.077880
04-23 20:40:38.919+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:924,-0.070000,-0.070000,0.070000
04-23 20:40:38.919+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:921,0.052642,9.810574,0.753739
04-23 20:40:38.919+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.929+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:930,0.041483,9.771518,0.828314
04-23 20:40:38.929+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.929+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.939+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:942,-0.010376,0.019913,-0.043469
04-23 20:40:38.939+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.939+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:946,-0.070000,-0.070000,0.070000
04-23 20:40:38.939+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.949+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:950,0.041146,9.771541,0.828063
04-23 20:40:38.949+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:942,0.031107,9.791430,0.784846
04-23 20:40:38.949+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.949+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.959+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:961,0.001925,0.017497,-0.031253
04-23 20:40:38.959+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:961,0.043071,9.789038,0.796810
04-23 20:40:38.959+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.959+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.959+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:967,0.041399,9.771541,0.828050
04-23 20:40:38.969+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:965,-0.140000,-0.070000,0.070000
04-23 20:40:38.969+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:38.969+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:38.979+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:38:981,-0.048577,0.005532,-0.019276
04-23 20:40:38.979+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:38:981,-0.007178,9.777073,0.808774
04-23 20:40:38.979+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:38.979+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:38:985,-0.140000,-0.070000,0.070000
04-23 20:40:38.979+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:38.979+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:38:989,0.039258,9.771338,0.830534
04-23 20:40:38.999+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:39.009+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:39:4,0.006205,-0.008622,-0.057652
04-23 20:40:39.009+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:39.009+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:39.019+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:39:22,-0.022976,0.039114,-0.025097
04-23 20:40:39.019+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:39:18,0.045464,9.762716,0.772882
04-23 20:40:39.019+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:39.029+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:39.029+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:39.029+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:39:35,0.039726,9.771460,0.829085
04-23 20:40:39.029+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:39.029+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:39:30,-0.140000,-0.070000,0.070000
04-23 20:40:39.029+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:40:39.039+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:40:39:42,0.030602,0.032027,-0.014270
04-23 20:40:39.039+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:40:39.039+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:39:39,0.038790,9.771367,0.830222
04-23 20:40:39.039+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:40:39.039+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:40:39:48,-0.070000,-0.070000,0.070000
04-23 20:40:39.039+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:40:39:48,0.040388,9.771381,0.829978
04-23 20:40:39.039+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:40:39:39,0.016750,9.810574,0.803988
04-23 20:40:39.049+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:40:39.049+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11122066c6f63152450883
