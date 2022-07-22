S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23901
Date: 2018-06-07 17:41:48+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf761652d, r5   = 0xf7af5f98
r6   = 0xffd251d0, r7   = 0xffd25080
r8   = 0xf7af2c18, r9   = 0x00000000
r10  = 0xffd2515c, fp   = 0xffd251d0
ip   = 0x00000001, sp   = 0xffd25058
lr   = 0xf7616539, pc   = 0xf767f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    270876 KB
Buffers:     11348 KB
Cached:     110300 KB
VmPeak:      53460 KB
VmSize:      53440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11624 KB
VmRSS:       11624 KB
VmData:      11168 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23901 TID = 23901
23901 23971 

Maps Information
f44e1000 f4ce0000 rw-p [stack:23971]
f4ce7000 f4ce9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cf1000 f4cf5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cfe000 f4d00000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d08000 f4d0b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d1a000 f4d1f000 r-xp /usr/lib/libsystem.so.0.0.0
f4d2a000 f4d2d000 r-xp /lib/libattr.so.1.1.0
f4d35000 f4d45000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d4d000 f4d56000 r-xp /usr/lib/libedbus.so.1.7.99
f4d5e000 f4d5f000 r-xp /usr/lib/libresponse.so.0.2.96
f4d68000 f4d6d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f660f000 f6715000 r-xp /usr/lib/libicuuc.so.57.1
f672b000 f68b3000 r-xp /usr/lib/libicui18n.so.57.1
f68c3000 f68d0000 r-xp /usr/lib/libail.so.0.1.0
f68d9000 f68e0000 r-xp /usr/lib/libminizip.so.1.0.0
f68e9000 f6a92000 r-xp /usr/lib/libcrypto.so.1.0.0
f6ab2000 f6af9000 r-xp /usr/lib/libssl.so.1.0.0
f6b05000 f6b07000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b0f000 f6b16000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b1f000 f6b26000 r-xp /lib/libcrypt-2.13.so
f6b57000 f6b5a000 r-xp /lib/libcap.so.2.21
f6b62000 f6b64000 r-xp /usr/lib/libiri.so
f6b6c000 f6bb5000 r-xp /usr/lib/libmdm.so.1.2.69
f6bbd000 f6bc3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6bcb000 f6bee000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bf8000 f6bfa000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c02000 f6c1f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c28000 f6c2c000 r-xp /usr/lib/libsmack.so.1.0.0
f6c35000 f6c4e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c57000 f6c5f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c67000 f6c6d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c76000 f6c78000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c81000 f6c91000 r-xp /lib/libresolv-2.13.so
f6c95000 f6cad000 r-xp /usr/lib/liblzma.so.5.0.3
f6cb6000 f6cb8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cc0000 f6cda000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ce2000 f6d11000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d1a000 f6d29000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d33000 f6d3d000 r-xp /usr/lib/libsensord-shared.so
f6d46000 f6e19000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e24000 f6e3a000 r-xp /lib/libz.so.1.2.5
f6e42000 f6e47000 r-xp /usr/lib/libffi.so.5.0.10
f6e4f000 f6e50000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e58000 f6e68000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e70000 f6e89000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e91000 f6e93000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e9b000 f6f10000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f1a000 f6f20000 r-xp /lib/librt-2.13.so
f6f29000 f6f47000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f51000 f6f52000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f5a000 f6f7d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f85000 f6f8a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f92000 f6fbc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fc5000 f6fdc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fe4000 f704d000 r-xp /lib/libm-2.13.so
f7056000 f70ea000 r-xp /usr/lib/libstdc++.so.6.0.16
f70fd000 f7102000 r-xp /usr/lib/libctx-client.so.0.8.3
f710a000 f7111000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7119000 f7143000 r-xp /usr/lib/libsensor.so.1.9.6
f714c000 f7218000 r-xp /usr/lib/libxml2.so.2.7.8
f7225000 f7227000 r-xp /usr/lib/libiniparser.so.0
f7230000 f7236000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f723f000 f730f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7310000 f7344000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f734d000 f7389000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7391000 f7394000 r-xp /usr/lib/libbundle.so.0.1.22
f739c000 f73a2000 r-xp /usr/lib/libappsvc.so.0.1.0
f73aa000 f73eb000 r-xp /usr/lib/libeina.so.1.7.99
f73f4000 f740b000 r-xp /usr/lib/libecore.so.1.7.99
f7422000 f742b000 r-xp /usr/lib/libvconf.so.0.2.45
f7433000 f7447000 r-xp /lib/libpthread-2.13.so
f7452000 f745f000 r-xp /usr/lib/libaul.so.0.1.0
f7469000 f746b000 r-xp /lib/libdl-2.13.so
f7474000 f747f000 r-xp /lib/libunwind.so.8.0.1
f74ac000 f74b4000 r-xp /lib/libgcc_s-4.6.so.1
f74b5000 f75d9000 r-xp /lib/libc-2.13.so
f75e7000 f75e9000 r-xp /usr/lib/libdlog.so.0.0.0
f75f1000 f75fd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7606000 f760b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7613000 f7622000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f762a000 f762e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7637000 f763a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7642000 f7644000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f764c000 f7650000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7658000 f7675000 r-xp /lib/ld-2.13.so
f767e000 f7681000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7681000 f7685000 r-xp /usr/lib/libsys-assert.so
f7ac2000 f7b31000 rw-p [heap]
ffd06000 ffd27000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23901)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf767f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7616539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf731d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf731bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7327e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf732dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf732ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf736275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf735d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf731bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7327e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf732dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf732ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf735fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7360017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7367f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cff1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cf2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6dc5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7272fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72747a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7404ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73ffb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74005a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7400879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7638183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76387fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf767f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf74cc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf767ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
07/06/2018,17:41:48:171,-0.280000,0.560000,0.070000
06-07 17:41:48.171+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:171,0.299103,-0.076570,9.805787
06-07 17:41:48.171+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.181+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.181+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:185,-0.024438,-0.007874,0.039955
06-07 17:41:48.181+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.181+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.191+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:186,0.305892,-0.050079,9.801750
06-07 17:41:48.191+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:191,-0.070000,0.070000,0.070000
06-07 17:41:48.191+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:192,0.282353,-0.057428,9.841680
06-07 17:41:48.191+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.191+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.191+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.201+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.211+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:205,0.017139,-0.000170,0.104536
06-07 17:41:48.211+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:205,0.323031,-0.050249,9.906286
06-07 17:41:48.211+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:205,0.305155,-0.049494,9.801776
06-07 17:41:48.211+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:211,0.280000,-0.210000,0.070000
06-07 17:41:48.211+0200 I/heartrate(23886): es.ugr.frailty.heartrate - capturing data
06-07 17:41:48.211+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.221+0200 I/heartrate(23886): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:41:48.221+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.221+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:226,-0.015623,0.018387,-0.096487
06-07 17:41:48.221+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.221+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.231+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:232,-0.070000,-0.210000,0.070000
06-07 17:41:48.231+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:227,0.289532,-0.031107,9.705289
06-07 17:41:48.231+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:232,0.305274,-0.048789,9.801776
06-07 17:41:48.241+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.241+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.241+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.241+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:246,-0.001385,0.003325,-0.055809
06-07 17:41:48.241+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.251+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:251,0.307548,-0.049865,9.801700
06-07 17:41:48.251+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:252,-0.630000,0.770000,0.070000
06-07 17:41:48.251+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:247,0.303888,-0.045464,9.745967
06-07 17:41:48.261+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.261+0200 I/light   (23941): es.ugr.frailty.light - capturing data
06-07 17:41:48.261+0200 I/light   (23941): es.ugr.frailty.light: SM-R760,07/06/2018,17:41:48:266,717.000000
06-07 17:41:48.261+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:266,0.017876,-0.024312,-0.036591
06-07 17:41:48.261+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.261+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.271+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.271+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:272,0.325424,-0.074178,9.765109
06-07 17:41:48.271+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:272,-0.210000,0.560000,0.070000
06-07 17:41:48.271+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.281+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.281+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:277,0.308804,-0.051383,9.801652
06-07 17:41:48.281+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:285,0.014227,-0.027580,0.169239
06-07 17:41:48.281+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.281+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.291+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:288,0.323031,-0.078963,9.970891
06-07 17:41:48.291+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:293,0.350000,-0.630000,0.140000
06-07 17:41:48.291+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:293,0.308630,-0.051997,9.801655
06-07 17:41:48.291+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.301+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.301+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:305,-0.026277,-0.019788,0.051989
06-07 17:41:48.301+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.301+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.311+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:306,0.282353,-0.071785,9.853643
06-07 17:41:48.311+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:312,0.420000,-0.560000,0.140000
06-07 17:41:48.311+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:311,0.305995,-0.052167,9.801736
06-07 17:41:48.321+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.321+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.321+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:326,0.017036,-0.029189,0.068658
06-07 17:41:48.321+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.321+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.331+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:327,0.323031,-0.081356,9.870394
06-07 17:41:48.341+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:334,-0.350000,0.210000,0.140000
06-07 17:41:48.351+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:41:48.351+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:41:48.351+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:41:48.351+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.351+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.361+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:362,-0.021454,-0.000784,-0.041320
06-07 17:41:48.361+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.371+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:364,0.287139,-0.055035,9.760324
06-07 17:41:48.371+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.371+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.371+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:377,0.311067,-0.028714,9.882358
06-07 17:41:48.381+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.381+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:381,0.004615,0.025370,0.080647
06-07 17:41:48.381+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:387,0.308674,-0.069392,9.796216
06-07 17:41:48.381+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.391+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:333,0.308593,-0.054251,9.801643
06-07 17:41:48.391+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:394,0.002434,-0.016671,-0.005509
06-07 17:41:48.391+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.391+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:377,0.070000,0.350000,0.070000
06-07 17:41:48.391+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.391+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.401+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:404,0.070000,-0.140000,0.070000
06-07 17:41:48.401+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:405,0.277567,-0.141177,9.695717
06-07 17:41:48.401+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.401+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.411+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:412,0.140000,-0.140000,0.070000
06-07 17:41:48.411+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.411+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:401,0.306452,-0.054084,9.801711
06-07 17:41:48.411+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:411,-0.028364,-0.087928,-0.106015
06-07 17:41:48.411+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:418,0.210000,0.140000,0.070000
06-07 17:41:48.411+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.411+0200 I/heartrate(23886): es.ugr.frailty.heartrate - capturing data
06-07 17:41:48.421+0200 I/heartrate(23886): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:41:48.421+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.421+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.421+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.421+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:427,0.318245,-0.055035,9.767502
06-07 17:41:48.421+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:426,0.014325,0.002034,-0.034271
06-07 17:41:48.431+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:423,0.306240,-0.052721,9.801725
06-07 17:41:48.431+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.431+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:430,0.280000,0.560000,0.140000
06-07 17:41:48.431+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:437,0.305932,-0.053249,9.801732
06-07 17:41:48.431+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.431+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.431+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.441+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:445,0.303888,-0.093320,9.877571
06-07 17:41:48.441+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:445,0.002105,-0.037060,0.075727
06-07 17:41:48.441+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.441+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:443,0.303920,-0.057069,9.801773
06-07 17:41:48.441+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.441+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:450,-0.420000,0.210000,0.070000
06-07 17:41:48.451+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:454,0.301784,-0.056260,9.801844
06-07 17:41:48.451+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.451+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:460,0.303865,-0.058870,9.801764
06-07 17:41:48.461+0200 I/light   (23941): es.ugr.frailty.light - capturing data
06-07 17:41:48.461+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.461+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:466,0.291924,-0.088534,9.858429
06-07 17:41:48.461+0200 I/light   (23941): es.ugr.frailty.light: SM-R760,07/06/2018,17:41:48:466,708.000000
06-07 17:41:48.461+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.461+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.461+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.471+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:472,-0.011941,-0.029665,0.056664
06-07 17:41:48.471+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:472,0.280000,-0.280000,0.070000
06-07 17:41:48.471+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:472,0.302424,-0.059740,9.801804
06-07 17:41:48.471+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.481+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.481+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:485,0.299981,-0.060242,9.801876
06-07 17:41:48.481+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.481+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.481+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:490,0.280000,-0.140000,0.070000
06-07 17:41:48.481+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:486,0.275175,-0.081356,9.793823
06-07 17:41:48.491+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:490,-0.027250,-0.021616,-0.007980
06-07 17:41:48.491+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.491+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.501+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:504,0.300241,-0.059856,9.801870
06-07 17:41:48.501+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:505,-0.070000,0.280000,0.070000
06-07 17:41:48.501+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.501+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.501+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:509,0.313460,-0.050249,9.805787
06-07 17:41:48.501+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:510,0.013479,0.009993,0.003911
06-07 17:41:48.511+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.511+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.521+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:525,-0.070000,0.280000,0.070000
06-07 17:41:48.521+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:524,0.302599,-0.060634,9.801793
06-07 17:41:48.521+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.521+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.521+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:529,0.354138,-0.074178,9.784252
06-07 17:41:48.521+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:530,0.053897,-0.014322,-0.017618
06-07 17:41:48.541+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.541+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.541+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:546,0.305390,-0.060307,9.801708
06-07 17:41:48.541+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:546,0.070682,0.010385,0.008780
06-07 17:41:48.541+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.541+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.551+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:552,0.373280,-0.050249,9.810574
06-07 17:41:48.551+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:554,-0.070000,0.210000,0.070000
06-07 17:41:48.561+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.571+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.591+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:579,0.301712,-0.059395,9.801827
06-07 17:41:48.601+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.611+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:567,0.008070,-0.009085,0.121327
06-07 17:41:48.621+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:614,0.302554,-0.058462,9.801807
06-07 17:41:48.621+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.631+0200 I/heartrate(23886): es.ugr.frailty.heartrate - capturing data
06-07 17:41:48.631+0200 I/heartrate(23886): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:41:48.631+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.631+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.631+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.661+0200 I/light   (23941): es.ugr.frailty.light - capturing data
06-07 17:41:48.661+0200 I/light   (23941): es.ugr.frailty.light: SM-R760,07/06/2018,17:41:48:666,691.000000
06-07 17:41:48.671+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:643,0.313460,-0.069392,9.923036
06-07 17:41:48.671+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:629,0.303434,-0.059250,9.801775
06-07 17:41:48.671+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.671+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:644,0.560000,0.420000,0.140000
06-07 17:41:48.681+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.691+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.701+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:645,0.045248,0.021110,0.008746
06-07 17:41:48.701+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:692,0.346959,-0.038285,9.810574
06-07 17:41:48.701+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.701+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:687,0.303107,-0.060258,9.801780
06-07 17:41:48.711+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.711+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:701,-0.070000,0.560000,0.070000
06-07 17:41:48.711+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.721+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.721+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:712,-0.013022,0.001034,0.006372
06-07 17:41:48.731+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.741+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:723,0.301796,-0.061785,9.801810
06-07 17:41:48.751+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.751+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:727,0.289532,-0.057428,9.808180
06-07 17:41:48.751+0200 W/LOCATION(23901): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:41:48.751+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.751+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:732,-0.420000,0.350000,0.070000
06-07 17:41:48.761+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.761+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:760,0.300936,-0.063346,9.801826
06-07 17:41:48.761+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:740,-0.001938,-0.031677,0.056654
06-07 17:41:48.761+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.771+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:767,0.301496,-0.090927,9.858429
06-07 17:41:48.771+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:772,0.280000,-0.560000,0.070000
06-07 17:41:48.771+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.771+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.771+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:774,-0.015969,-0.037848,0.047078
06-07 17:41:48.781+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.781+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:783,0.298736,-0.063715,9.801891
06-07 17:41:48.781+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.781+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:790,0.006878,-0.041106,-0.000809
06-07 17:41:48.791+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.791+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:784,0.287139,-0.098106,9.848858
06-07 17:41:48.791+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.791+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:790,0.140000,-0.070000,0.070000
06-07 17:41:48.791+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.791+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.801+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:803,0.308674,-0.102891,9.801002
06-07 17:41:48.801+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:799,-0.013797,-0.015617,-0.029539
06-07 17:41:48.801+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.801+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:799,0.299903,-0.063146,9.801860
06-07 17:41:48.811+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:805,0.140000,0.350000,0.070000
06-07 17:41:48.811+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.811+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:817,0.299079,-0.059408,9.801908
06-07 17:41:48.811+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.811+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:812,0.041045,0.006288,0.023038
06-07 17:41:48.811+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.811+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.811+0200 I/heartrate(23886): es.ugr.frailty.heartrate - capturing data
06-07 17:41:48.811+0200 I/heartrate(23886): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:41:48.821+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:823,0.082949,0.053575,-0.115714
06-07 17:41:48.821+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:823,0.287139,-0.078963,9.772287
06-07 17:41:48.821+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.821+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.831+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.831+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:824,0.140000,0.420000,0.070000
06-07 17:41:48.831+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.831+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:832,0.062237,0.033087,0.020629
06-07 17:41:48.831+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.841+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:842,0.140000,-0.070000,0.070000
06-07 17:41:48.841+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:832,0.298966,-0.057126,9.801926
06-07 17:41:48.841+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.841+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:838,0.339781,-0.057428,9.824929
06-07 17:41:48.841+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.841+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.841+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:843,0.019279,-0.024230,0.051718
06-07 17:41:48.851+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.851+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:852,0.382852,-0.009571,9.686146
06-07 17:41:48.851+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:849,0.297677,-0.057451,9.801963
06-07 17:41:48.851+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:855,0.630000,0.140000,0.070000
06-07 17:41:48.861+0200 I/light   (23941): es.ugr.frailty.light - capturing data
06-07 17:41:48.861+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.861+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.861+0200 I/light   (23941): es.ugr.frailty.light: SM-R760,07/06/2018,17:41:48:866,682.000000
06-07 17:41:48.861+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.861+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:856,0.001426,-0.023905,0.063645
06-07 17:41:48.871+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:869,0.361316,-0.026321,9.822537
06-07 17:41:48.871+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.871+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:876,-0.055181,0.020556,0.032595
06-07 17:41:48.871+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:868,0.299249,-0.058841,9.801907
06-07 17:41:48.871+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.871+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:872,0.350000,0.140000,0.070000
06-07 17:41:48.881+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.881+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.881+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.891+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:886,0.053856,0.004583,0.025292
06-07 17:41:48.891+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.891+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:886,0.295496,-0.057225,9.802030
06-07 17:41:48.891+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.901+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:888,0.318245,-0.081356,9.853643
06-07 17:41:48.901+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.901+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:890,0.350000,0.210000,0.070000
06-07 17:41:48.901+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:898,0.033359,-0.019965,0.051651
06-07 17:41:48.901+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.901+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.901+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:911,-0.070000,-0.490000,0.070000
06-07 17:41:48.911+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:910,0.299103,-0.081356,9.865608
06-07 17:41:48.911+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:906,0.296851,-0.056605,9.801992
06-07 17:41:48.911+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.911+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:915,-0.003498,-0.019222,0.056470
06-07 17:41:48.921+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.921+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.921+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.921+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:927,0.244068,-0.038285,9.834501
06-07 17:41:48.921+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:927,0.045164,0.029364,-0.015334
06-07 17:41:48.931+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:922,0.297815,-0.057349,9.801959
06-07 17:41:48.931+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.931+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.931+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:938,0.043106,-0.050786,0.032578
06-07 17:41:48.931+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:931,0.280000,-0.140000,0.070000
06-07 17:41:48.931+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.941+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.941+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.941+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:939,0.297010,-0.058078,9.801979
06-07 17:41:48.941+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.951+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:946,0.349352,-0.052642,9.827322
06-07 17:41:48.951+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:949,0.210000,-0.140000,0.070000
06-07 17:41:48.951+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.951+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:950,-0.011254,-0.036924,-0.020001
06-07 17:41:48.951+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.951+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.961+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:956,0.299067,-0.056891,9.801924
06-07 17:41:48.961+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:960,0.330210,-0.076570,9.853643
06-07 17:41:48.961+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:963,0.019043,0.031502,0.142672
06-07 17:41:48.961+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.961+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.971+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:964,0.070000,0.140000,0.070000
06-07 17:41:48.971+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.971+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.971+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:976,0.015853,-0.001567,0.070827
06-07 17:41:48.981+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:48.981+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:975,0.300785,-0.058789,9.801860
06-07 17:41:48.981+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:980,0.294317,-0.076570,9.858429
06-07 17:41:48.981+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:48.991+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:48.991+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:983,0.070000,0.140000,0.070000
06-07 17:41:48.991+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:48.991+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:48:988,0.028003,0.012995,-0.012927
06-07 17:41:48.991+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.001+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:48:999,-0.070000,-0.070000,-0.070000
06-07 17:41:49.001+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:48:994,0.299202,-0.060216,9.801900
06-07 17:41:49.001+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.001+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:48:997,0.342174,-0.028714,9.786645
06-07 17:41:49.001+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:5,-0.014076,0.027009,0.068470
06-07 17:41:49.001+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.011+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.011+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:10,0.297607,-0.058254,9.801960
06-07 17:41:49.011+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:13,0.342174,-0.107677,9.834501
06-07 17:41:49.011+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:17,0.210000,-0.070000,-0.070000
06-07 17:41:49.011+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.021+0200 I/heartrate(23886): es.ugr.frailty.heartrate - capturing data
06-07 17:41:49.021+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.021+0200 I/heartrate(23886): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:41:49.021+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.021+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.021+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:26,0.025388,0.006147,-0.005754
06-07 17:41:49.031+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:25,0.297421,-0.058459,9.801965
06-07 17:41:49.031+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:31,0.140000,0.280000,-0.070000
06-07 17:41:49.031+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.031+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:40,0.298822,-0.058116,9.801924
06-07 17:41:49.031+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:32,0.289532,-0.095713,9.781858
06-07 17:41:49.041+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.041+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.041+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.041+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:46,0.035395,-0.045100,0.128226
06-07 17:41:49.041+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:48,0.140000,0.560000,-0.070000
06-07 17:41:49.051+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.051+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:47,0.318245,-0.028714,9.944571
06-07 17:41:49.051+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.051+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.061+0200 I/light   (23941): es.ugr.frailty.light - capturing data
06-07 17:41:49.061+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.061+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:60,0.313460,-0.059821,9.872787
06-07 17:41:49.061+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:56,0.297643,-0.056397,9.801970
06-07 17:41:49.061+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.061+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:70,0.027707,-0.009232,-0.003278
06-07 17:41:49.061+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:62,-0.140000,0.700000,0.070000
06-07 17:41:49.071+0200 I/light   (23941): es.ugr.frailty.light: SM-R760,07/06/2018,17:41:49:67,695.000000
06-07 17:41:49.071+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.071+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.071+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:72,0.297207,-0.055399,9.801989
06-07 17:41:49.081+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.081+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.081+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:80,0.325424,-0.045464,9.789038
06-07 17:41:49.081+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:86,0.047242,-0.004755,0.075670
06-07 17:41:49.081+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:77,-0.140000,0.210000,0.070000
06-07 17:41:49.081+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.081+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.091+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:90,0.300110,-0.057767,9.801887
06-07 17:41:49.091+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:93,0.210000,-0.350000,0.070000
06-07 17:41:49.091+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.091+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.101+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:95,0.284746,-0.031107,9.870394
06-07 17:41:49.101+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:104,0.024676,0.006979,0.018274
06-07 17:41:49.101+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.101+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.111+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:105,0.299717,-0.057459,9.801901
06-07 17:41:49.111+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.121+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:113,0.323031,-0.050249,9.796216
06-07 17:41:49.121+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:110,0.350000,-0.210000,0.070000
06-07 17:41:49.121+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.121+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.121+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:128,-0.140000,-0.070000,0.070000
06-07 17:41:49.131+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.131+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:123,0.300748,-0.057228,9.801870
06-07 17:41:49.131+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.141+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:137,0.332602,-0.100499,9.930215
06-07 17:41:49.141+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.141+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.151+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:137,0.014830,0.016039,0.039815
06-07 17:41:49.151+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.151+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:146,0.301023,-0.056717,9.801865
06-07 17:41:49.151+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.151+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:151,0.350000,-0.070000,-0.070000
06-07 17:41:49.161+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:157,0.033298,-0.003739,0.066153
06-07 17:41:49.161+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.161+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:153,0.327817,-0.066999,9.798609
06-07 17:41:49.161+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.161+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.171+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:169,0.015694,0.017795,0.061394
06-07 17:41:49.171+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:165,0.301697,-0.056081,9.801847
06-07 17:41:49.171+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:41:49:171,0.210000,-0.070000,-0.070000
06-07 17:41:49.181+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.181+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:186,-0.000940,0.009591,-0.034328
06-07 17:41:49.181+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:173,0.346959,-0.062213,9.877571
06-07 17:41:49.181+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.181+0200 I/gyroscope(23867): es.ugr.frailty.gyroscope - capturing data
06-07 17:41:49.181+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer - capturing data
06-07 17:41:49.191+0200 I/accelerometer(23864): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:41:49:196,0.325424,-0.050249,9.820145
06-07 17:41:49.201+0200 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-07 17:41:49.201+0200 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
06-07 17:41:49.201+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:41:49.201+0200 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-07 17:41:49.201+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-07 17:41:49.201+0200 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
06-07 17:41:49.201+0200 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
06-07 17:41:49.201+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 17:41:49.201+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
06-07 17:41:49.231+0200 I/heartrate(23886): es.ugr.frailty.heartrate - capturing data
06-07 17:41:49.231+0200 I/heartrate(23886): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:41:49.231+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.241+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:243,0.017153,-0.000783,0.027838
06-07 17:41:49.241+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.251+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:250,0.038940,0.013288,0.011080
06-07 17:41:49.251+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.251+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:260,0.018877,-0.044915,0.025460
06-07 17:41:49.261+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.261+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:267,-0.024984,-0.019049,0.070960
06-07 17:41:49.261+0200 I/light   (23941): es.ugr.frailty.light - capturing data
06-07 17:41:49.271+0200 I/light   (23941): es.ugr.frailty.light: SM-R760,07/06/2018,17:41:49:273,702.000000
06-07 17:41:49.281+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:41:49.281+0200 I/linearacceleration(23904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:41:49:286,0.024705,-0.039827,0.003908
06-07 17:41:49.281+0200 I/gravity (23915): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:41:49:193,0.302552,-0.056080,9.801822
06-07 17:41:49.281+0200 I/gravity (23915): es.ugr.frailty.gravity - capturing data
06-07 17:41:49.291+0200 W/CRASH_MANAGER(23977): worker.c: worker_job(1205) > 11239016c6f63152838610
