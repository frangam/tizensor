S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17096
Date: 2018-06-07 17:10:23+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76f852d, r5   = 0xf7e51958
r6   = 0xffd20060, r7   = 0xffd1ff10
r8   = 0xf7e64c18, r9   = 0x00000000
r10  = 0xffd1ffec, fp   = 0xffd20060
ip   = 0x00000001, sp   = 0xffd1fee8
lr   = 0xf76f8539, pc   = 0xf7761228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    141868 KB
Buffers:     12120 KB
Cached:      58476 KB
VmPeak:      53556 KB
VmSize:      53552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11716 KB
VmRSS:       11712 KB
VmData:      11280 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17096 TID = 17096
17096 17129 

Maps Information
f45c3000 f4dc2000 rw-p [stack:17129]
f4dc9000 f4dcb000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dd3000 f4dd7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4de0000 f4de2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dea000 f4ded000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dfc000 f4e01000 r-xp /usr/lib/libsystem.so.0.0.0
f4e0c000 f4e0f000 r-xp /lib/libattr.so.1.1.0
f4e17000 f4e27000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e2f000 f4e38000 r-xp /usr/lib/libedbus.so.1.7.99
f4e40000 f4e41000 r-xp /usr/lib/libresponse.so.0.2.96
f4e4a000 f4e4f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66f1000 f67f7000 r-xp /usr/lib/libicuuc.so.57.1
f680d000 f6995000 r-xp /usr/lib/libicui18n.so.57.1
f69a5000 f69b2000 r-xp /usr/lib/libail.so.0.1.0
f69bb000 f69c2000 r-xp /usr/lib/libminizip.so.1.0.0
f69cb000 f6b74000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b94000 f6bdb000 r-xp /usr/lib/libssl.so.1.0.0
f6be7000 f6be9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bf1000 f6bf8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c01000 f6c08000 r-xp /lib/libcrypt-2.13.so
f6c39000 f6c3c000 r-xp /lib/libcap.so.2.21
f6c44000 f6c46000 r-xp /usr/lib/libiri.so
f6c4e000 f6c97000 r-xp /usr/lib/libmdm.so.1.2.69
f6c9f000 f6ca5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cad000 f6cd0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cda000 f6cdc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ce4000 f6d01000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d0a000 f6d0e000 r-xp /usr/lib/libsmack.so.1.0.0
f6d17000 f6d30000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d39000 f6d41000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d49000 f6d4f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d58000 f6d5a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d63000 f6d73000 r-xp /lib/libresolv-2.13.so
f6d77000 f6d8f000 r-xp /usr/lib/liblzma.so.5.0.3
f6d98000 f6d9a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6da2000 f6dbc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dc4000 f6df3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dfc000 f6e0b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e15000 f6e1f000 r-xp /usr/lib/libsensord-shared.so
f6e28000 f6efb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f06000 f6f1c000 r-xp /lib/libz.so.1.2.5
f6f24000 f6f29000 r-xp /usr/lib/libffi.so.5.0.10
f6f31000 f6f32000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f3a000 f6f4a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f52000 f6f6b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f73000 f6f75000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f7d000 f6ff2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ffc000 f7002000 r-xp /lib/librt-2.13.so
f700b000 f7029000 r-xp /usr/lib/libsystemd.so.0.4.0
f7033000 f7034000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f703c000 f705f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7067000 f706c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7074000 f709e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70a7000 f70be000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70c6000 f712f000 r-xp /lib/libm-2.13.so
f7138000 f71cc000 r-xp /usr/lib/libstdc++.so.6.0.16
f71df000 f71e4000 r-xp /usr/lib/libctx-client.so.0.8.3
f71ec000 f71f3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71fb000 f7225000 r-xp /usr/lib/libsensor.so.1.9.6
f722e000 f72fa000 r-xp /usr/lib/libxml2.so.2.7.8
f7307000 f7309000 r-xp /usr/lib/libiniparser.so.0
f7312000 f7318000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7321000 f73f1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73f2000 f7426000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f742f000 f746b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7473000 f7476000 r-xp /usr/lib/libbundle.so.0.1.22
f747e000 f7484000 r-xp /usr/lib/libappsvc.so.0.1.0
f748c000 f74cd000 r-xp /usr/lib/libeina.so.1.7.99
f74d6000 f74ed000 r-xp /usr/lib/libecore.so.1.7.99
f7504000 f750d000 r-xp /usr/lib/libvconf.so.0.2.45
f7515000 f7529000 r-xp /lib/libpthread-2.13.so
f7534000 f7541000 r-xp /usr/lib/libaul.so.0.1.0
f754b000 f754d000 r-xp /lib/libdl-2.13.so
f7556000 f7561000 r-xp /lib/libunwind.so.8.0.1
f758e000 f7596000 r-xp /lib/libgcc_s-4.6.so.1
f7597000 f76bb000 r-xp /lib/libc-2.13.so
f76c9000 f76cb000 r-xp /usr/lib/libdlog.so.0.0.0
f76d3000 f76df000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76e8000 f76ed000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76f5000 f7704000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f770c000 f7710000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7719000 f771c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7724000 f7726000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f772e000 f7732000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f773a000 f7757000 r-xp /lib/ld-2.13.so
f7760000 f7763000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7763000 f7767000 r-xp /usr/lib/libsys-assert.so
f7e34000 f7ebf000 rw-p [heap]
ffd01000 ffd22000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17096)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7761228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76f8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73ff3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73fdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7409e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf740fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf740fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf744475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf743f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73fdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7409e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf740fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf740fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7441e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7442017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7449f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4de11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dd4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ea7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7354fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73567a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74e6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74e1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74e25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74e2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf771a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf771a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77615c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75ae85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7760f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
(17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:226,-1.792158,-3.269163,9.070343
06-07 17:10:22.221+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.221+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:230,-1.794346,-3.269297,9.069862
06-07 17:10:22.221+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:225,0.008600,-0.025630,0.049906
06-07 17:10:22.221+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.231+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.231+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:236,0.007602,0.001236,-0.002738
06-07 17:10:22.231+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.241+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.241+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:241,-0.019302,-0.029633,0.030733
06-07 17:10:22.241+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.241+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:246,-1.808974,-3.292524,9.080762
06-07 17:10:22.241+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.241+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:247,-0.042991,-0.031782,0.023689
06-07 17:10:22.241+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.251+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:253,-0.030080,-0.024181,0.033601
06-07 17:10:22.251+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.251+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:258,0.001047,-0.001663,0.008112
06-07 17:10:22.251+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.261+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:263,-0.026241,-0.017914,0.075574
06-07 17:10:22.261+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:214,0.140000,0.280000,0.070000
06-07 17:10:22.261+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.261+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.261+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:22.271+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:22:273,81
06-07 17:10:22.271+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:251,-1.830509,-3.278167,9.116654
06-07 17:10:22.271+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.271+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:268,0.009601,-0.061140,0.058758
06-07 17:10:22.271+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.271+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:279,-1.808974,-3.302095,9.123833
06-07 17:10:22.271+0200 W/CAPI_APPFW_APP_CONTROL(16997): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:10:22.271+0200 I/utils   (16997): specific action
06-07 17:10:22.271+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.271+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:10:22.271+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16997), cmd(0)
06-07 17:10:22.281+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:235,-1.792848,-3.269587,9.070054
06-07 17:10:22.281+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.281+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:282,-0.008894,-0.042643,0.017975
06-07 17:10:22.281+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.281+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:291,-0.007543,-0.024488,0.030239
06-07 17:10:22.291+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:267,0.070000,0.070000,0.070000
06-07 17:10:22.291+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.291+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:284,-1.828116,-3.285345,9.116654
06-07 17:10:22.291+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.291+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:298,0.140000,0.070000,0.070000
06-07 17:10:22.291+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.291+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.301+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:287,-1.793564,-3.270449,9.069602
06-07 17:10:22.301+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.301+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:304,-0.033437,0.051018,0.021234
06-07 17:10:22.301+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:301,-1.782653,-3.251846,9.123833
06-07 17:10:22.301+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:309,-1.794038,-3.270952,9.069326
06-07 17:10:22.301+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.301+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.311+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:314,-1.828116,-3.273381,9.080762
06-07 17:10:22.311+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.311+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.321+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:302,0.210000,0.070000,0.070000
06-07 17:10:22.321+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.321+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:324,-0.009792,-0.030386,0.092943
06-07 17:10:22.321+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:320,-1.756332,-3.275774,9.135797
06-07 17:10:22.321+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:327,0.140000,0.140000,0.070000
06-07 17:10:22.321+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.321+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.321+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:331,0.140000,-0.140000,0.070000
06-07 17:10:22.331+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:333,-1.806581,-3.297310,9.123833
06-07 17:10:22.331+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.331+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:339,-1.804188,-3.275774,9.097511
06-07 17:10:22.331+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.331+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:313,-1.795448,-3.270978,9.069038
06-07 17:10:22.341+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.341+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:344,-0.027706,-0.001837,0.034837
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:22.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391422350,000000, pattern:[H:mm][0;m
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:22.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:22.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:10:22.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:10][0;m
06-07 17:10:22.341+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.351+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:353,-1.856830,-3.299703,9.131011
06-07 17:10:22.351+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.351+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:358,-1.801795,-3.309274,9.083155
06-07 17:10:22.351+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.351+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.361+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:346,-1.795113,-3.272235,9.068651
06-07 17:10:22.361+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.361+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:365,-0.033433,-0.067231,0.027187
06-07 17:10:22.361+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:368,-1.793149,-3.271920,9.069153
06-07 17:10:22.361+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:363,-1.763510,-3.294917,9.154939
06-07 17:10:22.361+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.361+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.371+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.371+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:374,-1.811367,-3.292524,9.133404
06-07 17:10:22.371+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:376,-0.070000,-0.140000,-0.140000
06-07 17:10:22.371+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.371+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.371+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:380,0.350000,-0.140000,-0.140000
06-07 17:10:22.371+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:380,-1.785046,-3.304488,9.099905
06-07 17:10:22.371+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.381+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.381+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.381+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:389,0.005455,-0.023354,0.029126
06-07 17:10:22.381+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:385,-1.785046,-3.297310,9.119047
06-07 17:10:22.391+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.391+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:372,-1.793646,-3.271680,9.069141
06-07 17:10:22.391+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.391+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:396,-1.785046,-3.270989,9.066404
06-07 17:10:22.391+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:398,-1.792647,-3.272225,9.069142
06-07 17:10:22.391+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.391+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.391+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.401+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:384,0.420000,-0.140000,0.070000
06-07 17:10:22.401+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.401+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:404,-0.013318,0.022864,0.051007
06-07 17:10:22.401+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:407,0.560000,-0.280000,0.140000
06-07 17:10:22.401+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.401+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:402,-1.811367,-3.302095,9.099905
06-07 17:10:22.401+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.401+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:411,0.280000,-0.350000,0.140000
06-07 17:10:22.411+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:413,-1.835295,-3.304488,9.092726
06-07 17:10:22.411+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.411+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:419,-1.823331,-3.297310,9.102298
06-07 17:10:22.411+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.421+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.421+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:22.421+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:22:426,813.000000
06-07 17:10:22.421+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:426,-0.040933,-0.030453,0.012222
06-07 17:10:22.421+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:402,-1.792064,-3.272462,9.069172
06-07 17:10:22.421+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:424,-1.794617,-3.275774,9.075976
06-07 17:10:22.421+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.431+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.431+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:434,-1.792304,-3.272706,9.069036
06-07 17:10:22.431+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.431+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:436,-1.823331,-3.292524,9.142976
06-07 17:10:22.431+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.431+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.441+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:444,0.022743,-0.024066,0.034818
06-07 17:10:22.441+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:441,-1.787439,-3.335595,9.126225
06-07 17:10:22.441+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.441+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:451,-1.806581,-3.316452,9.085547
06-07 17:10:22.451+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.451+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.451+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:456,0.210000,-0.630000,0.070000
06-07 17:10:22.451+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.451+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:457,-1.804188,-3.299703,9.097511
06-07 17:10:22.451+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.451+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.461+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:439,-1.793251,-3.273129,9.068697
06-07 17:10:22.461+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.461+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:465,0.075558,-0.031913,0.077682
06-07 17:10:22.461+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:467,-1.795664,-3.274112,9.067864
06-07 17:10:22.461+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:22.461+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:460,0.280000,-0.770000,0.070000
06-07 17:10:22.461+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.471+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:22:472,80
06-07 17:10:22.471+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:462,-1.830509,-3.225525,9.087940
06-07 17:10:22.471+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:473,0.280000,0.070000,0.070000
06-07 17:10:22.471+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.481+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:482,-1.806581,-3.306881,9.159724
06-07 17:10:22.481+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.481+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.481+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.481+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.481+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:490,0.021553,-0.034201,0.091807
06-07 17:10:22.481+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:491,0.350000,0.840000,0.210000
06-07 17:10:22.491+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:488,-1.825724,-3.275774,9.102298
06-07 17:10:22.491+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.491+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:487,-1.797090,-3.274610,9.067402
06-07 17:10:22.491+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.501+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.501+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:504,-0.074340,0.019345,0.060517
06-07 17:10:22.501+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:501,-1.830509,-3.340380,9.095119
06-07 17:10:22.501+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.511+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:514,0.350000,0.560000,-0.070000
06-07 17:10:22.511+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:506,-1.797040,-3.274455,9.067468
06-07 17:10:22.501+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.511+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.511+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.521+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:524,-1.792224,-3.294917,9.097511
06-07 17:10:22.521+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.521+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.521+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:524,-0.053630,-0.016182,0.003057
06-07 17:10:22.521+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:520,-1.797687,-3.273809,9.067573
06-07 17:10:22.531+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:531,-0.350000,-0.560000,-0.140000
06-07 17:10:22.531+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:535,-1.811367,-3.249453,9.119047
06-07 17:10:22.531+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.531+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.531+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.531+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.541+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:545,0.010617,-0.046911,0.050591
06-07 17:10:22.541+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:545,-0.350000,-0.280000,-0.070000
06-07 17:10:22.541+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:542,-1.837688,-3.302095,9.080762
06-07 17:10:22.541+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.551+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:544,-1.796645,-3.275215,9.067272
06-07 17:10:22.551+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:554,-1.773082,-3.292524,9.104690
06-07 17:10:22.551+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.551+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.551+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.551+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.561+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:565,0.010108,-0.060369,0.058465
06-07 17:10:22.561+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:566,0.560000,0.700000,0.210000
06-07 17:10:22.561+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:561,-1.720440,-3.299703,9.147761
06-07 17:10:22.561+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.561+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:559,-1.797073,-3.276544,9.066707
06-07 17:10:22.561+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.571+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:573,-1.773082,-3.302095,9.162118
06-07 17:10:22.571+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.571+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:579,-1.866402,-3.249453,9.131011
06-07 17:10:22.571+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.571+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:577,-1.796789,-3.276495,9.066781
06-07 17:10:22.581+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.581+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.581+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:589,0.770000,0.560000,0.210000
06-07 17:10:22.581+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.581+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:584,-1.844866,-3.285345,9.073583
06-07 17:10:22.591+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.591+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:593,-0.013755,-0.016256,0.032534
06-07 17:10:22.591+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:586,-1.798018,-3.273937,9.067461
06-07 17:10:22.591+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:596,-1.782653,-3.314059,9.121440
06-07 17:10:22.591+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.591+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.591+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.591+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.601+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:604,0.009885,-0.013017,0.004066
06-07 17:10:22.601+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:605,0.560000,0.560000,0.280000
06-07 17:10:22.601+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:602,-1.785046,-3.328416,9.128618
06-07 17:10:22.601+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.611+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:603,-1.797076,-3.273149,9.067932
06-07 17:10:22.611+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:614,-1.808974,-3.285345,9.102298
06-07 17:10:22.611+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.611+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.611+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.621+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.621+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:22.621+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:626,0.420000,0.560000,0.070000
06-07 17:10:22.621+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:625,-0.039080,-0.003773,0.037704
06-07 17:10:22.621+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:22:630,813.000000
06-07 17:10:22.631+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:624,-1.797679,-3.271563,9.068385
06-07 17:10:22.631+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:620,-1.785046,-3.282953,9.073583
06-07 17:10:22.631+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.631+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.631+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:638,-1.835295,-3.273381,9.107083
06-07 17:10:22.631+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.631+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.641+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:644,-0.024403,0.020681,0.033171
06-07 17:10:22.641+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:644,0.490000,0.350000,0.070000
06-07 17:10:22.641+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.641+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:650,-1.820938,-3.249453,9.102298
06-07 17:10:22.641+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:641,-1.798049,-3.272317,9.068040
06-07 17:10:22.651+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.651+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:656,-1.796755,-3.271642,9.068540
06-07 17:10:22.651+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.651+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:660,-1.795825,-3.268458,9.069872
06-07 17:10:22.661+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.661+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.661+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.661+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:666,-0.041611,-0.016226,0.054723
06-07 17:10:22.701+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:22.711+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.711+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:668,0.560000,0.210000,0.140000
06-07 17:10:22.711+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:22:712,80
06-07 17:10:22.721+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.721+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:717,-0.021435,-0.030475,0.056498
06-07 17:10:22.731+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.731+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.731+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:671,-1.795998,-3.267789,9.070079
06-07 17:10:22.741+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.741+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:740,-1.840081,-3.285345,9.123833
06-07 17:10:22.741+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:730,0.140000,-0.140000,0.070000
06-07 17:10:22.751+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.751+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:736,-0.013188,-0.059870,0.063643
06-07 17:10:22.761+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:751,-1.794635,-3.267894,9.070311
06-07 17:10:22.761+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.761+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.771+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.791+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:760,-0.210000,-0.210000,0.070000
06-07 17:10:22.791+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.801+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:770,-0.022640,-0.025909,0.051868
06-07 17:10:22.801+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:810,-0.280000,0.350000,0.070000
06-07 17:10:22.811+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:802,-1.792061,-3.268798,9.070494
06-07 17:10:22.811+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.811+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:775,-1.820938,-3.297310,9.126225
06-07 17:10:22.811+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.821+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:22.821+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.821+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.821+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:819,-0.064964,-0.047264,0.026624
06-07 17:10:22.831+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:22:826,812.000000
06-07 17:10:22.831+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:836,-0.280000,0.350000,0.070000
06-07 17:10:22.831+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:825,-1.813759,-3.326023,9.133404
06-07 17:10:22.841+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.841+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.841+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:831,-1.791236,-3.269164,9.070525
06-07 17:10:22.851+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.851+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:847,-0.042089,-0.036502,-0.001396
06-07 17:10:22.851+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.861+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.871+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:22.871+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:858,-1.823331,-3.292524,9.121440
06-07 17:10:22.871+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:863,-0.070000,-0.420000,-0.070000
06-07 17:10:22.871+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:864,-1.793270,-3.267148,9.070849
06-07 17:10:22.871+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.871+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:22:876,80
06-07 17:10:22.881+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.881+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.881+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:875,-0.021198,-0.042772,-0.000720
06-07 17:10:22.881+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:888,-0.070000,-1.120000,-0.280000
06-07 17:10:22.891+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.901+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:904,0.050096,-0.037965,0.027905
06-07 17:10:22.901+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:888,-1.866402,-3.316452,9.095119
06-07 17:10:22.901+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.901+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:895,-1.795154,-3.268047,9.070153
06-07 17:10:22.911+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.911+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.911+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:916,0.140000,-1.050000,-0.140000
06-07 17:10:22.921+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:922,-1.844866,-3.306881,9.066404
06-07 17:10:22.921+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.931+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:923,-1.795219,-3.269089,9.069764
06-07 17:10:22.931+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.931+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:932,0.032091,-0.014082,0.030030
06-07 17:10:22.941+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.941+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.941+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.961+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:942,0.280000,-0.350000,0.140000
06-07 17:10:22.961+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:953,-1.825724,-3.314059,9.066404
06-07 17:10:22.961+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:958,-1.794931,-3.269935,9.069517
06-07 17:10:22.961+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.961+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:962,0.007254,-0.013951,0.017458
06-07 17:10:22.971+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:22.971+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:975,0.210000,0.490000,0.210000
06-07 17:10:22.971+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:22.981+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:22.981+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:22.991+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:22:986,-1.753939,-3.309274,9.095119
06-07 17:10:22.991+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:22:989,-0.019727,-0.001559,0.036624
06-07 17:10:22.991+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:22:998,-0.070000,0.560000,0.210000
06-07 17:10:22.991+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:22:988,-1.796215,-3.269608,9.069380
06-07 17:10:23.001+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:23.001+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:23.001+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:23.001+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:23.011+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:23:11,-0.021398,-0.048234,0.058729
06-07 17:10:23.021+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:23:11,-1.796535,-3.270134,9.069127
06-07 17:10:23.031+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:23.031+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:23.031+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:23.041+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:23:13,-1.770689,-3.285345,9.097511
06-07 17:10:23.041+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:23:46,-0.013242,-0.010345,0.051602
06-07 17:10:23.041+0200 W/LOCATION(17096): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:10:23.041+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:23:18,-0.070000,0.140000,0.210000
06-07 17:10:23.041+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:23.041+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:23.051+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:23:51,-1.798470,-3.269120,9.069110
06-07 17:10:23.061+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:23.061+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:23:56,-1.792224,-3.285345,9.085547
06-07 17:10:23.061+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:23.061+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:23.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:10:23.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:10:23.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:10:23.071+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:23:72,80
06-07 17:10:23.071+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:23:59,0.350000,-0.140000,-0.070000
06-07 17:10:23.071+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:23:40,813.000000
06-07 17:10:23.071+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:23.081+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:23.091+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:23:69,-0.003814,-0.002896,0.042099
06-07 17:10:23.091+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:23:87,-1.818545,-3.273381,9.104690
06-07 17:10:23.091+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:23:78,-1.799503,-3.266835,9.069728
06-07 17:10:23.091+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:23.111+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:23.111+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:23:87,0.420000,0.140000,0.070000
06-07 17:10:23.111+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:23:117,-1.800571,-3.266154,9.069761
06-07 17:10:23.111+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:23.111+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:23.121+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:23:106,-0.005932,0.070241,0.041779
06-07 17:10:23.121+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:23:124,0.420000,0.280000,0.140000
06-07 17:10:23.121+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:23.131+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:23:126,-1.820938,-3.321238,9.126225
06-07 17:10:23.131+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:23.141+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:23.141+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:23:135,-0.020066,-0.019256,0.041475
06-07 17:10:23.141+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:23.161+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:23:145,-1.800691,-3.266615,9.069571
06-07 17:10:23.161+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:23.161+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:23:165,-1.813759,-3.282953,9.119047
06-07 17:10:23.171+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:23:154,0.420000,0.140000,0.070000
06-07 17:10:23.171+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:23.171+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:23.181+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:23:173,-0.034174,-0.016325,0.085458
06-07 17:10:23.181+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:23.181+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:23.181+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:23:178,-1.801438,-3.269188,9.068496
06-07 17:10:23.191+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:23:180,0.210000,-0.140000,0.070000
06-07 17:10:23.201+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:23.201+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:23:196,-0.017236,-0.035808,0.087766
06-07 17:10:23.201+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:23.211+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:23:195,-1.804188,-3.275774,9.109475
06-07 17:10:23.211+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:23.211+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:23:213,0.280000,-0.350000,-0.070000
06-07 17:10:23.221+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:23.221+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:23.221+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:23:227,812.000000
06-07 17:10:23.221+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:23:214,-1.802777,-3.270379,9.067801
06-07 17:10:23.231+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:23.241+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:23:227,-1.806581,-3.201597,9.109475
06-07 17:10:23.241+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:23.241+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:23:249,-1.804525,-3.271288,9.067124
06-07 17:10:23.251+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:23.251+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:23:230,0.032998,0.000790,0.048870
06-07 17:10:23.251+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:23.261+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:23.271+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:23:275,80
06-07 17:10:23.271+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:23:247,0.070000,-0.280000,-0.140000
06-07 17:10:23.271+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:23.291+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11170966c6f63152838422
