S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20636
Date: 2018-06-07 17:23:03+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf752252d, r5   = 0xf76c3f98
r6   = 0xffeebe00, r7   = 0xffeebcb0
r8   = 0xf76c0c18, r9   = 0x00000000
r10  = 0xffeebd8c, fp   = 0xffeebe00
ip   = 0x00000001, sp   = 0xffeebc88
lr   = 0xf7522539, pc   = 0xf758b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     19688 KB
Buffers:     11644 KB
Cached:      57944 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11744 KB
VmRSS:       11740 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20636 TID = 20636
20636 20663 

Maps Information
f43ed000 f4bec000 rw-p [stack:20663]
f4bf3000 f4bf5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bfd000 f4c01000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c0a000 f4c0c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c14000 f4c17000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c26000 f4c2b000 r-xp /usr/lib/libsystem.so.0.0.0
f4c36000 f4c39000 r-xp /lib/libattr.so.1.1.0
f4c41000 f4c51000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c59000 f4c62000 r-xp /usr/lib/libedbus.so.1.7.99
f4c6a000 f4c6b000 r-xp /usr/lib/libresponse.so.0.2.96
f4c74000 f4c79000 r-xp /usr/lib/libproc-stat.so.0.2.96
f651b000 f6621000 r-xp /usr/lib/libicuuc.so.57.1
f6637000 f67bf000 r-xp /usr/lib/libicui18n.so.57.1
f67cf000 f67dc000 r-xp /usr/lib/libail.so.0.1.0
f67e5000 f67ec000 r-xp /usr/lib/libminizip.so.1.0.0
f67f5000 f699e000 r-xp /usr/lib/libcrypto.so.1.0.0
f69be000 f6a05000 r-xp /usr/lib/libssl.so.1.0.0
f6a11000 f6a13000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a1b000 f6a22000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a2b000 f6a32000 r-xp /lib/libcrypt-2.13.so
f6a63000 f6a66000 r-xp /lib/libcap.so.2.21
f6a6e000 f6a70000 r-xp /usr/lib/libiri.so
f6a78000 f6ac1000 r-xp /usr/lib/libmdm.so.1.2.69
f6ac9000 f6acf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ad7000 f6afa000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b04000 f6b06000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b0e000 f6b2b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b34000 f6b38000 r-xp /usr/lib/libsmack.so.1.0.0
f6b41000 f6b5a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b63000 f6b6b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b73000 f6b79000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b82000 f6b84000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b8d000 f6b9d000 r-xp /lib/libresolv-2.13.so
f6ba1000 f6bb9000 r-xp /usr/lib/liblzma.so.5.0.3
f6bc2000 f6bc4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bcc000 f6be6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bee000 f6c1d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c26000 f6c35000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c3f000 f6c49000 r-xp /usr/lib/libsensord-shared.so
f6c52000 f6d25000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d30000 f6d46000 r-xp /lib/libz.so.1.2.5
f6d4e000 f6d53000 r-xp /usr/lib/libffi.so.5.0.10
f6d5b000 f6d5c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d64000 f6d74000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d7c000 f6d95000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d9d000 f6d9f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6da7000 f6e1c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e26000 f6e2c000 r-xp /lib/librt-2.13.so
f6e35000 f6e53000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e5d000 f6e5e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e66000 f6e89000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e91000 f6e96000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e9e000 f6ec8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ed1000 f6ee8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ef0000 f6f59000 r-xp /lib/libm-2.13.so
f6f62000 f6ff6000 r-xp /usr/lib/libstdc++.so.6.0.16
f7009000 f700e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7016000 f701d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7025000 f704f000 r-xp /usr/lib/libsensor.so.1.9.6
f7058000 f7124000 r-xp /usr/lib/libxml2.so.2.7.8
f7131000 f7133000 r-xp /usr/lib/libiniparser.so.0
f713c000 f7142000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f714b000 f721b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f721c000 f7250000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7259000 f7295000 r-xp /usr/lib/libSLP-location.so.0.9.24
f729d000 f72a0000 r-xp /usr/lib/libbundle.so.0.1.22
f72a8000 f72ae000 r-xp /usr/lib/libappsvc.so.0.1.0
f72b6000 f72f7000 r-xp /usr/lib/libeina.so.1.7.99
f7300000 f7317000 r-xp /usr/lib/libecore.so.1.7.99
f732e000 f7337000 r-xp /usr/lib/libvconf.so.0.2.45
f733f000 f7353000 r-xp /lib/libpthread-2.13.so
f735e000 f736b000 r-xp /usr/lib/libaul.so.0.1.0
f7375000 f7377000 r-xp /lib/libdl-2.13.so
f7380000 f738b000 r-xp /lib/libunwind.so.8.0.1
f73b8000 f73c0000 r-xp /lib/libgcc_s-4.6.so.1
f73c1000 f74e5000 r-xp /lib/libc-2.13.so
f74f3000 f74f5000 r-xp /usr/lib/libdlog.so.0.0.0
f74fd000 f7509000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7512000 f7517000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f751f000 f752e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7536000 f753a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7543000 f7546000 r-xp /usr/lib/libappcore-agent.so.1.1
f754e000 f7550000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7558000 f755c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7564000 f7581000 r-xp /lib/ld-2.13.so
f758a000 f758d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f758d000 f7591000 r-xp /usr/lib/libsys-assert.so
f7690000 f771e000 rw-p [heap]
ffecd000 ffeee000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20636)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf758b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7522539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72293f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7227c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7233e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7239be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7239dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf726e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72691f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7227c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7233e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7239be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7239dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf726be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf726c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7273f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c0b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bfe171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cd1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf717efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71807a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7310ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf730bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf730c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf730c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7544183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75447fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf758b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf73d885c) [/lib/libc.so.6] + 0x1785c
29: (0xf758af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
018,17:25:27:179,0.031556,-0.015769,0.035475
06-07 17:25:27.201+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.201+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:167,0.304405,-0.087353,9.801536
06-07 17:25:27.201+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.201+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.211+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:186,0.294317,-0.078963,9.836893
06-07 17:25:27.221+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.221+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:27.231+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:27:235,655.000000
06-07 17:25:27.241+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:223,0.305330,-0.090125,9.801481
06-07 17:25:27.251+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:215,0.140000,0.070000,0.070000
06-07 17:25:27.251+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.251+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.251+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:226,0.018713,0.050555,0.057033
06-07 17:25:27.261+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.271+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:270,0.070000,0.070000,0.070000
06-07 17:25:27.291+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:243,0.315853,-0.086142,9.894321
06-07 17:25:27.291+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.301+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.311+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:283,0.023021,0.005374,0.066622
06-07 17:25:27.311+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:275,0.304516,-0.087906,9.801527
06-07 17:25:27.311+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.311+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.311+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:305,0.334995,-0.055035,9.851252
06-07 17:25:27.331+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.341+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:325,0.304985,-0.087059,9.801519
06-07 17:25:27.351+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:27.351+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:27.361+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:324,0.070000,0.070000,0.070000
06-07 17:25:27.361+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.361+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.361+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:329,-0.026878,-0.019064,0.054622
06-07 17:25:27.361+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.371+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:347,0.303888,-0.119641,9.846465
06-07 17:25:27.381+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.401+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:374,0.305994,-0.088773,9.801473
06-07 17:25:27.401+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:375,0.070000,0.070000,0.070000
06-07 17:25:27.401+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.401+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:380,-0.022611,-0.021765,0.080956
06-07 17:25:27.411+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.421+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.421+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:398,0.315853,-0.133998,9.882358
06-07 17:25:27.421+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21012) cmd(0)
06-07 17:25:27.431+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:27.431+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:27:439,661.000000
06-07 17:25:27.451+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.451+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21017) cmd(0)
06-07 17:25:27.451+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:427,0.306547,-0.088119,9.801461
06-07 17:25:27.471+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:429,-0.027920,-0.025789,-0.000452
06-07 17:25:27.471+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:422,0.070000,0.070000,0.070000
06-07 17:25:27.471+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.471+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.481+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.501+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:460,0.303888,-0.088534,9.858429
06-07 17:25:27.501+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.511+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:495,0.140000,0.070000,0.070000
06-07 17:25:27.521+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:514,0.306995,-0.088638,9.801443
06-07 17:25:27.521+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:507,0.026279,-0.027366,0.059327
06-07 17:25:27.521+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:521,0.327817,-0.050249,9.865608
06-07 17:25:27.521+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21036) cmd(0)
06-07 17:25:27.531+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:27.531+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:27.531+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.541+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:541,0.309128,-0.089162,9.801371
06-07 17:25:27.551+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.551+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:557,0.309306,-0.089447,9.801363
06-07 17:25:27.551+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.561+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:563,0.309721,-0.089447,9.801350
06-07 17:25:27.561+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.561+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:570,0.310125,-0.090570,9.801327
06-07 17:25:27.571+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.571+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.571+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.571+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.611+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:582,0.140000,0.070000,0.070000
06-07 17:25:27.611+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:587,0.309309,-0.089506,9.801362
06-07 17:25:27.611+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:584,0.017899,-0.026008,0.078444
06-07 17:25:27.611+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.611+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.621+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:612,0.334995,-0.081356,9.896714
06-07 17:25:27.631+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.651+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:27.661+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:27:661,663.000000
06-07 17:25:27.671+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.671+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:626,0.070000,0.070000,0.070000
06-07 17:25:27.681+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:676,0.310389,-0.089888,9.801325
06-07 17:25:27.691+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:633,0.022208,-0.010810,0.033003
06-07 17:25:27.691+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.691+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.691+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.701+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:645,0.339781,-0.076570,9.856036
06-07 17:25:27.731+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.731+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:27.731+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:27.731+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:708,0.070000,0.070000,0.140000
06-07 17:25:27.741+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:717,0.310691,-0.090237,9.801311
06-07 17:25:27.741+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:717,0.005497,-0.010013,0.071294
06-07 17:25:27.741+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.751+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:741,0.339781,-0.102891,9.836893
06-07 17:25:27.761+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.771+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.781+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.791+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:791,0.327817,-0.035892,9.858429
06-07 17:25:27.791+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:774,0.070000,0.070000,0.070000
06-07 17:25:27.801+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:776,0.310618,-0.091274,9.801305
06-07 17:25:27.801+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:768,0.048123,-0.014533,0.066524
06-07 17:25:27.801+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.801+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.811+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.821+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.821+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:27.831+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:27:834,663.000000
06-07 17:25:27.841+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:847,0.332602,-0.081356,9.868000
06-07 17:25:27.861+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:818,0.050938,-0.026261,0.083263
06-07 17:25:27.861+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:819,0.311522,-0.092120,9.801268
06-07 17:25:27.871+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:822,0.070000,0.070000,0.070000
06-07 17:25:27.871+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.881+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.881+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.891+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:890,0.070000,0.070000,0.070000
06-07 17:25:27.901+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.911+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:916,0.282353,-0.102891,9.856036
06-07 17:25:27.921+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:894,0.312571,-0.093175,9.801225
06-07 17:25:27.921+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.921+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:890,-0.003213,0.036278,0.064171
06-07 17:25:27.921+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.931+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:27.931+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:27.941+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:27.941+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:27.961+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:27:954,0.311353,-0.091635,9.801278
06-07 17:25:27.961+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:941,0.287139,-0.105284,9.882358
06-07 17:25:27.971+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:942,0.070000,0.070000,0.070000
06-07 17:25:27.971+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:27.981+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:27.981+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:27:962,0.020718,-0.015062,0.066650
06-07 17:25:27.981+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:27:987,0.279960,-0.110070,9.801002
06-07 17:25:27.991+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:27:992,0.070000,0.070000,0.070000
06-07 17:25:28.001+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.001+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.011+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:10,0.311500,-0.091574,9.801273
06-07 17:25:28.031+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:25:28.031+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:25:28.031+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:25:28.041+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:28.071+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:28:78,661.000000
06-07 17:25:28.171+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:28.201+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:28.231+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:28.231+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:28:238,647.000000
06-07 17:25:28.251+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.251+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.251+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.261+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:13,-0.024012,-0.026649,0.090537
06-07 17:25:28.281+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.291+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:28:266,0.332602,-0.112463,9.860823
06-07 17:25:28.291+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:262,0.070000,0.070000,0.070000
06-07 17:25:28.301+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.301+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.311+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:285,0.310525,-0.092110,9.801300
06-07 17:25:28.321+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:303,-0.005407,-0.011692,0.085774
06-07 17:25:28.331+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.331+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:28:335,0.323031,-0.112463,9.879964
06-07 17:25:28.331+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:28.331+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:28.341+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.351+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:322,0.070000,0.070000,0.070000
06-07 17:25:28.351+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:345,0.308164,-0.093247,9.801363
06-07 17:25:28.361+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.371+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:355,0.005936,0.020472,0.047442
06-07 17:25:28.371+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.371+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.391+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:398,0.308844,-0.092935,9.801345
06-07 17:25:28.401+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.401+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:382,0.070000,0.070000,0.070000
06-07 17:25:28.411+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:28:387,0.327817,-0.098106,9.834501
06-07 17:25:28.411+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.411+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:427,0.070000,-0.070000,0.070000
06-07 17:25:28.431+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:28.441+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:25:28.441+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:25:28.441+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:28.441+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:28:439,674.000000
06-07 17:25:28.441+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:28.441+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.451+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21012
06-07 17:25:28.451+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:410,0.021008,-0.000764,0.100066
06-07 17:25:28.451+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.461+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21012)
06-07 17:25:28.461+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer launch request sent!
06-07 17:25:28.461+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:28.461+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:25:28.461+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:25:28.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:28.461+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:28.471+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21017
06-07 17:25:28.481+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21017)
06-07 17:25:28.481+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope launch request sent!
06-07 17:25:28.481+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:28.481+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:25:28.481+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:25:28.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:28.481+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:28.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21023
06-07 17:25:28.491+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:28.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(21023), cmd(0)
06-07 17:25:28.501+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21023)
06-07 17:25:28.501+0200 I/servicemanager(20992): es.ugr.frailty.heartrate launch request sent!
06-07 17:25:28.501+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:28.501+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:25:28.501+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:25:28.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:28.501+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:28.511+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21361
06-07 17:25:28.521+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:28.521+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(21361), cmd(0)
06-07 17:25:28.521+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21361)
06-07 17:25:28.521+0200 I/servicemanager(20992): es.ugr.frailty.location launch request sent!
06-07 17:25:28.521+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:28.521+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:25:28.521+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:25:28.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:28.531+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:28.541+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21036
06-07 17:25:28.541+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21036)
06-07 17:25:28.551+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:25:28.551+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:28.551+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:25:28.551+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:25:28.551+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:28.551+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:28.561+0200 W/CAPI_APPFW_APP_CONTROL(21023): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:28.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21049
06-07 17:25:28.571+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21049)
06-07 17:25:28.571+0200 I/servicemanager(20992): es.ugr.frailty.gravity launch request sent!
06-07 17:25:28.571+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:28.571+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:25:28.571+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:25:28.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:28.571+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:28.581+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21054
06-07 17:25:28.591+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:28.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(21054), cmd(0)
06-07 17:25:28.591+0200 W/CAPI_APPFW_APP_CONTROL(21054): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:28.591+0200 I/utils   (21054): specific action
06-07 17:25:28.591+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21054)
06-07 17:25:28.591+0200 I/servicemanager(20992): es.ugr.frailty.pressure launch request sent!
06-07 17:25:28.591+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:28.591+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:25:28.591+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:25:28.591+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:28.601+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:28.601+0200 W/CAPI_APPFW_APP_CONTROL(21361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:28.611+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21071
06-07 17:25:28.611+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21071)
06-07 17:25:28.611+0200 I/servicemanager(20992): es.ugr.frailty.light launch request sent!
06-07 17:25:28.611+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:28.611+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:25:28.611+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:25:28.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:28.611+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:28.621+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21084
06-07 17:25:28.631+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:28.631+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(34) , send fd(15), pid(21084), cmd(0)
06-07 17:25:28.631+0200 W/CAPI_APPFW_APP_CONTROL(21084): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:28.631+0200 I/utils   (21084): specific action
06-07 17:25:28.631+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21084)
06-07 17:25:28.631+0200 I/servicemanager(20992): es.ugr.frailty.pedometer launch request sent!
06-07 17:25:28.631+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:28.641+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:28.641+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(21071), cmd(0)
06-07 17:25:28.641+0200 I/utils   (21023): specific action
06-07 17:25:28.641+0200 W/CAPI_APPFW_APP_CONTROL(21071): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:28.641+0200 I/utils   (21071): specific action
06-07 17:25:28.641+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:28.651+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:28:654,714.000000
06-07 17:25:28.651+0200 I/utils   (21361): specific action
06-07 17:25:28.651+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:28.651+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:28.661+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:454,0.309107,-0.092256,9.801343
06-07 17:25:28.661+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.691+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:28:453,0.311067,-0.098106,9.872787
06-07 17:25:28.691+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:669,0.307992,-0.093018,9.801371
06-07 17:25:28.691+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.691+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.691+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.711+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:681,0.009247,0.043517,0.088084
06-07 17:25:28.721+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:703,0.070000,-0.070000,0.070000
06-07 17:25:28.731+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.731+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:707,0.308449,-0.094464,9.801343
06-07 17:25:28.731+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.741+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:28.741+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:28.741+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:28:707,0.354138,-0.102891,9.868000
06-07 17:25:28.741+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.751+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.761+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:761,0.070000,-0.070000,0.070000
06-07 17:25:28.781+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:736,0.011229,-0.009245,0.064168
06-07 17:25:28.781+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:765,0.308409,-0.093081,9.801357
06-07 17:25:28.781+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.791+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.801+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:28:777,0.356531,-0.114855,9.884750
06-07 17:25:28.801+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.821+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.821+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:796,0.032940,-0.018699,0.090463
06-07 17:25:28.831+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:28:829,0.303888,-0.052642,9.865608
06-07 17:25:28.831+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.841+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:28.841+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:28:846,746.000000
06-07 17:25:28.861+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:813,0.070000,-0.070000,0.070000
06-07 17:25:28.861+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:827,0.308819,-0.092983,9.801345
06-07 17:25:28.861+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.871+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.871+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.891+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:859,-0.007779,-0.025533,0.042611
06-07 17:25:28.891+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.901+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:891,0.306879,-0.093646,9.801400
06-07 17:25:28.911+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:912,0.022287,0.008614,0.071363
06-07 17:25:28.911+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:881,0.070000,-0.070000,0.070000
06-07 17:25:28.921+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.921+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:28:889,0.330210,-0.105284,9.868000
06-07 17:25:28.921+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:28.921+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.931+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:936,0.306964,-0.092609,9.801407
06-07 17:25:28.941+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:28.941+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:28.951+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:931,0.140000,-0.070000,0.070000
06-07 17:25:28.951+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:28.961+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:28:954,0.284746,-0.114855,9.891929
06-07 17:25:28.961+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:28.971+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:28.981+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.001+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:28:962,-0.003157,-0.002352,0.059381
06-07 17:25:29.011+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.011+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:28:980,0.140000,-0.070000,0.070000
06-07 17:25:29.011+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:28:992,0.306145,-0.093871,9.801421
06-07 17:25:29.021+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:12,0.303888,-0.100499,9.887143
06-07 17:25:29.031+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.031+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.041+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:25:29.041+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:25:29.041+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:25:29.041+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.051+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:29.061+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:29:60,746.000000
06-07 17:25:29.061+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:24,-0.010833,0.023323,0.037854
06-07 17:25:29.071+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.071+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:46,0.140000,-0.070000,0.070000
06-07 17:25:29.091+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:53,0.313460,-0.069392,9.848858
06-07 17:25:29.091+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.091+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:50,0.305578,-0.093541,9.801441
06-07 17:25:29.091+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.101+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.101+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:107,0.070000,-0.070000,0.070000
06-07 17:25:29.111+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:86,-0.029293,0.016091,0.068940
06-07 17:25:29.121+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.131+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:123,0.327817,-0.090927,9.901501
06-07 17:25:29.131+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.141+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:29.141+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:29.151+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:114,0.305534,-0.093511,9.801443
06-07 17:25:29.151+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.161+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.171+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:135,-0.009220,-0.009152,0.068899
06-07 17:25:29.181+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.181+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:158,0.140000,0.070000,0.070000
06-07 17:25:29.191+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.191+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:169,0.305303,-0.093077,9.801455
06-07 17:25:29.201+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.211+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:177,0.315853,-0.045464,9.889536
06-07 17:25:29.221+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:196,-0.002601,-0.038780,0.059263
06-07 17:25:29.221+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.241+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.241+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:236,0.318245,-0.098106,9.865608
06-07 17:25:29.241+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:29.251+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:29:254,765.000000
06-07 17:25:29.251+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:216,0.070000,0.070000,0.070000
06-07 17:25:29.261+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.261+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:227,0.307146,-0.091792,9.801409
06-07 17:25:29.271+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.271+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.291+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:277,0.070000,0.070000,0.070000
06-07 17:25:29.301+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:265,0.041830,0.003799,0.092736
06-07 17:25:29.311+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:285,0.306784,-0.091060,9.801427
06-07 17:25:29.311+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.321+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.321+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.321+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:318,0.041830,-0.022522,0.080772
06-07 17:25:29.331+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:301,0.339781,-0.105284,9.891929
06-07 17:25:29.331+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:29.341+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:29.341+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:346,0.305840,-0.089462,9.801472
06-07 17:25:29.341+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.361+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.361+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:338,0.070000,0.070000,0.070000
06-07 17:25:29.371+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.371+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:357,0.299103,-0.112463,9.844072
06-07 17:25:29.381+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.401+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:372,0.004633,0.001039,0.035345
06-07 17:25:29.411+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.411+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:404,0.306375,-0.090244,9.801448
06-07 17:25:29.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:391,0.070000,0.070000,0.070000
06-07 17:25:29.421+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.431+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:29.431+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:29:441,755.000000
06-07 17:25:29.451+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.451+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.461+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21012) cmd(0)
06-07 17:25:29.471+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:425,0.330210,-0.078963,9.872787
06-07 17:25:29.471+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:431,0.048651,-0.005280,0.078468
06-07 17:25:29.471+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21017) cmd(0)
06-07 17:25:29.501+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.501+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.511+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:463,0.070000,0.070000,0.070000
06-07 17:25:29.511+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:469,0.306488,-0.090869,9.801438
06-07 17:25:29.521+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.521+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.531+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:515,0.303888,-0.090927,9.860823
06-07 17:25:29.531+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:29.531+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:29.531+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:532,0.306865,-0.089099,9.801443
06-07 17:25:29.541+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.541+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:520,0.013087,0.006407,0.114348
06-07 17:25:29.551+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.561+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:528,0.070000,0.070000,0.070000
06-07 17:25:29.581+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.581+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:565,0.296710,-0.064606,9.839286
06-07 17:25:29.581+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.591+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:595,0.070000,0.070000,0.070000
06-07 17:25:29.591+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:568,0.018567,-0.043768,0.083296
06-07 17:25:29.591+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.601+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.611+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:608,0.277567,-0.071785,9.870394
06-07 17:25:29.611+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:595,0.307506,-0.088329,9.801430
06-07 17:25:29.621+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.621+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.631+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:29.631+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:29:639,746.000000
06-07 17:25:29.641+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21036) cmd(0)
06-07 17:25:29.661+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:611,-0.007410,-0.020516,0.068923
06-07 17:25:29.671+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.671+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:29.681+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:29:650,0.140000,0.070000,0.070000
06-07 17:25:29.691+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:29:660,0.306936,-0.087995,9.801451
06-07 17:25:29.691+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:29:686,0.296710,-0.095713,9.870394
06-07 17:25:29.691+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:29.701+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:29.701+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:29.721+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:29:694,-0.010355,-0.006697,0.080920
06-07 17:25:29.751+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11206366c6f63152838498
