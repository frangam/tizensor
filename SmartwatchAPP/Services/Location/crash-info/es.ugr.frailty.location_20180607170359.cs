S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15265
Date: 2018-06-07 17:03:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf734e52d, r5   = 0xf7a45f98
r6   = 0xffa3bb00, r7   = 0xffa3b9b0
r8   = 0xf7a42c18, r9   = 0x00000000
r10  = 0xffa3ba8c, fp   = 0xffa3bb00
ip   = 0x00000001, sp   = 0xffa3b988
lr   = 0xf734e539, pc   = 0xf73b7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    134260 KB
Buffers:     11052 KB
Cached:      53076 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11652 KB
VmRSS:       11652 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15265 TID = 15265
15265 15270 

Maps Information
f4219000 f4a18000 rw-p [stack:15270]
f4a1f000 f4a21000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a29000 f4a2d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a36000 f4a38000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a40000 f4a43000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a52000 f4a57000 r-xp /usr/lib/libsystem.so.0.0.0
f4a62000 f4a65000 r-xp /lib/libattr.so.1.1.0
f4a6d000 f4a7d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a85000 f4a8e000 r-xp /usr/lib/libedbus.so.1.7.99
f4a96000 f4a97000 r-xp /usr/lib/libresponse.so.0.2.96
f4aa0000 f4aa5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6347000 f644d000 r-xp /usr/lib/libicuuc.so.57.1
f6463000 f65eb000 r-xp /usr/lib/libicui18n.so.57.1
f65fb000 f6608000 r-xp /usr/lib/libail.so.0.1.0
f6611000 f6618000 r-xp /usr/lib/libminizip.so.1.0.0
f6621000 f67ca000 r-xp /usr/lib/libcrypto.so.1.0.0
f67ea000 f6831000 r-xp /usr/lib/libssl.so.1.0.0
f683d000 f683f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6847000 f684e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6857000 f685e000 r-xp /lib/libcrypt-2.13.so
f688f000 f6892000 r-xp /lib/libcap.so.2.21
f689a000 f689c000 r-xp /usr/lib/libiri.so
f68a4000 f68ed000 r-xp /usr/lib/libmdm.so.1.2.69
f68f5000 f68fb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6903000 f6926000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6930000 f6932000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f693a000 f6957000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6960000 f6964000 r-xp /usr/lib/libsmack.so.1.0.0
f696d000 f6986000 r-xp /usr/lib/libnetwork.so.0.0.0
f698f000 f6997000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f699f000 f69a5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69ae000 f69b0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69b9000 f69c9000 r-xp /lib/libresolv-2.13.so
f69cd000 f69e5000 r-xp /usr/lib/liblzma.so.5.0.3
f69ee000 f69f0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69f8000 f6a12000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a1a000 f6a49000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a52000 f6a61000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a6b000 f6a75000 r-xp /usr/lib/libsensord-shared.so
f6a7e000 f6b51000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b5c000 f6b72000 r-xp /lib/libz.so.1.2.5
f6b7a000 f6b7f000 r-xp /usr/lib/libffi.so.5.0.10
f6b87000 f6b88000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b90000 f6ba0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ba8000 f6bc1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bc9000 f6bcb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bd3000 f6c48000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c52000 f6c58000 r-xp /lib/librt-2.13.so
f6c61000 f6c7f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c89000 f6c8a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c92000 f6cb5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cbd000 f6cc2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cca000 f6cf4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cfd000 f6d14000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d1c000 f6d85000 r-xp /lib/libm-2.13.so
f6d8e000 f6e22000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e35000 f6e3a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e42000 f6e49000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e51000 f6e7b000 r-xp /usr/lib/libsensor.so.1.9.6
f6e84000 f6f50000 r-xp /usr/lib/libxml2.so.2.7.8
f6f5d000 f6f5f000 r-xp /usr/lib/libiniparser.so.0
f6f68000 f6f6e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f77000 f7047000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7048000 f707c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7085000 f70c1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70c9000 f70cc000 r-xp /usr/lib/libbundle.so.0.1.22
f70d4000 f70da000 r-xp /usr/lib/libappsvc.so.0.1.0
f70e2000 f7123000 r-xp /usr/lib/libeina.so.1.7.99
f712c000 f7143000 r-xp /usr/lib/libecore.so.1.7.99
f715a000 f7163000 r-xp /usr/lib/libvconf.so.0.2.45
f716b000 f717f000 r-xp /lib/libpthread-2.13.so
f718a000 f7197000 r-xp /usr/lib/libaul.so.0.1.0
f71a1000 f71a3000 r-xp /lib/libdl-2.13.so
f71ac000 f71b7000 r-xp /lib/libunwind.so.8.0.1
f71e4000 f71ec000 r-xp /lib/libgcc_s-4.6.so.1
f71ed000 f7311000 r-xp /lib/libc-2.13.so
f731f000 f7321000 r-xp /usr/lib/libdlog.so.0.0.0
f7329000 f7335000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f733e000 f7343000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f734b000 f735a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7362000 f7366000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f736f000 f7372000 r-xp /usr/lib/libappcore-agent.so.1.1
f737a000 f737c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7384000 f7388000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7390000 f73ad000 r-xp /lib/ld-2.13.so
f73b6000 f73b9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73b9000 f73bd000 r-xp /usr/lib/libsys-assert.so
f7a12000 f7aa0000 rw-p [heap]
ffa1d000 ffa3e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15265)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73b7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf734e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70553f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7053c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf705fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7065be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7065dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf709a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70951f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7053c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf705fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7065be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7065dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7097e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7098017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf709ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a371fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a2a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6afd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6faafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fac7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf713cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7137b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71385a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7138879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7370183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73707fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73b75c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf720485c) [/lib/libc.so.6] + 0x1785c
29: (0xf73b6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ing data
06-07 17:03:58.631+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:639,8.872586,-1.708475,3.897908
06-07 17:03:58.631+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.641+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.641+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:644,-1.190000,-0.350000,0.210000
06-07 17:03:58.641+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:646,0.041867,0.034910,0.037118
06-07 17:03:58.641+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:642,8.827361,-1.850967,3.849935
06-07 17:03:58.641+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.651+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.651+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:654,8.828326,-1.848670,3.848826
06-07 17:03:58.651+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:656,8.870193,-1.813759,3.885944
06-07 17:03:58.651+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.651+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.651+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.661+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:663,0.090975,-0.064433,-0.013400
06-07 17:03:58.661+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:663,0.490000,-1.050000,0.560000
06-07 17:03:58.661+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:660,8.829468,-1.842646,3.849095
06-07 17:03:58.661+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.661+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:670,8.920443,-1.907080,3.835695
06-07 17:03:58.671+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.671+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:676,8.829648,-1.841213,3.849367
06-07 17:03:58.671+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.671+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.681+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:683,0.630000,-0.350000,-0.350000
06-07 17:03:58.681+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.681+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:689,8.830688,-1.842407,3.846412
06-07 17:03:58.691+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.691+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:683,8.922836,-1.911865,3.933800
06-07 17:03:58.691+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:696,0.093188,-0.070652,0.084433
06-07 17:03:58.701+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.701+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.701+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:706,8.860621,-1.737189,3.869194
06-07 17:03:58.701+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.701+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:710,8.829495,-1.842466,3.849118
06-07 17:03:58.701+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:707,1.680000,0.210000,-0.630000
06-07 17:03:58.711+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.711+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:715,0.029934,0.105217,0.022782
06-07 17:03:58.721+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.721+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.721+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:729,8.843873,-1.780260,3.797409
06-07 17:03:58.721+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.721+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.731+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:729,0.700000,-0.630000,0.210000
06-07 17:03:58.731+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:733,8.830411,-1.837040,3.849612
06-07 17:03:58.731+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.731+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.741+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.741+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:747,8.831999,-1.834439,3.847208
06-07 17:03:58.741+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:744,0.140000,-0.280000,0.070000
06-07 17:03:58.761+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.781+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.781+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:58.791+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:775,0.770000,-0.140000,0.210000
06-07 17:03:58.791+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.791+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:789,8.832931,-1.833947,3.845304
06-07 17:03:58.791+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:58:792,383.000000
06-07 17:03:58.801+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:733,0.014378,0.062207,-0.051708
06-07 17:03:58.801+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.801+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.801+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:03:58.801+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:743,8.970692,-1.849652,3.838088
06-07 17:03:58.801+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.811+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:58:811,78
06-07 17:03:58.811+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:803,0.700000,-0.490000,0.350000
06-07 17:03:58.811+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:808,0.140281,-0.012612,-0.011525
06-07 17:03:58.811+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.811+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:811,8.886944,-1.816152,3.878766
06-07 17:03:58.811+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.841+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:829,8.832846,-1.832634,3.846123
06-07 17:03:58.841+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.841+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:821,0.054945,0.018287,0.031558
06-07 17:03:58.841+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:825,8.886944,-1.864009,3.751946
06-07 17:03:58.851+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.861+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.861+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:853,0.420000,-0.140000,-0.070000
06-07 17:03:58.861+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.861+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:866,8.927622,-1.897508,3.859623
06-07 17:03:58.861+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.861+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.871+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:877,1.190000,0.910000,-0.070000
06-07 17:03:58.871+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:857,0.054013,-0.030062,-0.093358
06-07 17:03:58.871+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.881+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:869,8.834760,-1.833567,3.841280
06-07 17:03:58.881+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.881+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.891+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:885,0.094776,-0.064874,0.013499
06-07 17:03:58.891+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.891+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:899,0.071326,0.108342,0.030306
06-07 17:03:58.891+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:892,8.833662,-1.835182,3.843034
06-07 17:03:58.871+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:870,8.906086,-1.725225,3.871587
06-07 17:03:58.891+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.901+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.901+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:897,-0.770000,-0.210000,0.070000
06-07 17:03:58.901+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.901+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.901+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:908,8.863015,-1.777867,3.771089
06-07 17:03:58.901+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.901+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:912,8.970692,-1.806581,3.893122
06-07 17:03:58.911+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:917,-0.420000,-0.420000,0.420000
06-07 17:03:58.911+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:912,8.835038,-1.829959,3.842360
06-07 17:03:58.911+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.921+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.921+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:903,0.029353,0.057315,-0.071945
06-07 17:03:58.921+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.921+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.921+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:931,8.836947,-1.828440,3.838690
06-07 17:03:58.921+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:931,0.135653,0.023378,0.050763
06-07 17:03:58.931+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:935,0.140000,0.140000,0.350000
06-07 17:03:58.931+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:925,8.925228,-1.895115,3.876373
06-07 17:03:58.931+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.941+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:942,8.918050,-1.942972,3.818945
06-07 17:03:58.941+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.941+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.941+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:949,8.958728,-1.885544,3.866802
06-07 17:03:58.941+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.941+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.951+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.951+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:954,8.836840,-1.826809,3.839716
06-07 17:03:58.951+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:957,0.088281,-0.066675,0.037682
06-07 17:03:58.951+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:950,0.070000,-0.070000,0.350000
06-07 17:03:58.951+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.951+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:58.961+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.961+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:58:965,386.000000
06-07 17:03:58.961+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.961+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:953,8.920443,-1.820938,3.828516
06-07 17:03:58.961+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.971+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:962,0.081210,-0.116163,-0.020771
06-07 17:03:58.971+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.971+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:977,8.836132,-1.829655,3.839990
06-07 17:03:58.971+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:978,0.122596,-0.055890,0.026811
06-07 17:03:58.971+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.981+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:974,8.908479,-1.744368,3.845266
06-07 17:03:58.981+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:973,0.490000,0.140000,-0.280000
06-07 17:03:58.981+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:58.981+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:58.981+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:58:987,8.877372,-1.780260,3.847659
06-07 17:03:58.981+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:982,0.084086,0.012554,-0.009127
06-07 17:03:58.991+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.991+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:58.991+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:58:996,0.072769,0.090014,0.006560
06-07 17:03:58.991+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:58.991+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:58:999,8.836356,-1.833492,3.837643
06-07 17:03:58.991+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.001+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:58:991,0.910000,0.700000,-0.070000
06-07 17:03:59.001+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:5,8.922836,-1.856830,3.838088
06-07 17:03:59.001+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.001+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:1,0.040683,0.052993,0.010669
06-07 17:03:59.001+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:03:59.001+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.001+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:59:11,78
06-07 17:03:59.011+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:12,0.084982,-0.027465,0.001926
06-07 17:03:59.011+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.011+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:18,-0.560000,0.490000,-0.210000
06-07 17:03:59.011+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.021+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:23,-0.840000,0.140000,0.140000
06-07 17:03:59.021+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.021+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.021+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:29,8.946764,-1.971686,3.893122
06-07 17:03:59.031+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:29,0.108625,-0.144289,0.056678
06-07 17:03:59.031+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.041+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:22,8.835710,-1.834381,3.838706
06-07 17:03:59.041+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.051+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:53,0.100906,0.052093,0.091501
06-07 17:03:59.051+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:03:59.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:03:59.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:03:59.061+0200 W/LOCATION(15265): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:03:59.071+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:51,8.939585,-1.775474,3.926622
06-07 17:03:59.071+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.071+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.071+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:60,-0.490000,0.280000,0.140000
06-07 17:03:59.071+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.071+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.071+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:77,8.884550,-1.761117,3.857230
06-07 17:03:59.081+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:81,0.046872,0.070338,0.021659
06-07 17:03:59.081+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:82,-0.280000,0.630000,-0.490000
06-07 17:03:59.091+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.091+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:88,8.836689,-1.833253,3.836990
06-07 17:03:59.091+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.091+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.091+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:95,8.918050,-1.861616,3.924229
06-07 17:03:59.101+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.101+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:102,8.837854,-1.829365,3.836162
06-07 17:03:59.101+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:103,0.081137,-0.034224,0.084960
06-07 17:03:59.101+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.111+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.111+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.111+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:107,0.770000,0.420000,-0.700000
06-07 17:03:59.121+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:120,8.838139,-1.827397,3.836445
06-07 17:03:59.121+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:119,8.872586,-1.945365,3.905087
06-07 17:03:59.121+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.121+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.121+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.131+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:136,8.838678,-1.827567,3.835121
06-07 17:03:59.131+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:115,0.034211,-0.120267,0.068093
06-07 17:03:59.131+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.141+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:150,8.837678,-1.831456,3.835571
06-07 17:03:59.151+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:132,8.874979,-1.813759,3.893122
06-07 17:03:59.151+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.151+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.151+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:129,0.770000,0.490000,-0.070000
06-07 17:03:59.151+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.151+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:59.161+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:160,8.836913,-1.827392,3.839269
06-07 17:03:59.161+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:59:165,386.000000
06-07 17:03:59.161+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.161+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:169,0.036845,0.011859,0.055820
06-07 17:03:59.161+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.161+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.171+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:175,8.838375,-1.825098,3.836994
06-07 17:03:59.171+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:156,8.901299,-1.751546,3.869194
06-07 17:03:59.181+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.181+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:161,-1.610000,-0.700000,0.280000
06-07 17:03:59.181+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.181+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:188,8.838134,-1.825618,3.837303
06-07 17:03:59.181+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:188,-0.420000,-0.560000,-0.140000
06-07 17:03:59.181+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.191+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.191+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.201+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:202,8.836303,-1.828862,3.839973
06-07 17:03:59.201+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:205,8.908479,-1.868794,3.857230
06-07 17:03:59.201+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.201+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:03:59.201+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:174,0.064997,0.077316,0.029221
06-07 17:03:59.201+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.201+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:59:211,77
06-07 17:03:59.211+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.211+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:209,8.949157,-1.883151,3.845266
06-07 17:03:59.211+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.211+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:216,8.836331,-1.826189,3.841181
06-07 17:03:59.211+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:217,8.894121,-1.890330,3.842873
06-07 17:03:59.211+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:215,0.072147,-0.042605,0.016049
06-07 17:03:59.211+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.221+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.221+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:230,8.837222,-1.822944,3.840672
06-07 17:03:59.231+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:193,1.330000,0.280000,-0.560000
06-07 17:03:59.231+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.231+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.231+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:238,0.770000,-0.070000,-0.560000
06-07 17:03:59.231+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.241+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.241+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:245,8.886944,-1.727618,3.902694
06-07 17:03:59.241+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.241+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:242,8.837714,-1.823777,3.839144
06-07 17:03:59.241+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.241+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:249,8.918050,-1.813759,3.895515
06-07 17:03:59.251+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:225,0.111935,-0.060208,0.004594
06-07 17:03:59.251+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.251+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:259,0.056407,-0.066553,0.003729
06-07 17:03:59.251+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:255,8.837571,-1.824045,3.839347
06-07 17:03:59.261+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.271+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:272,8.837476,-1.826177,3.838553
06-07 17:03:59.271+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.271+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:243,-0.140000,-0.840000,0.560000
06-07 17:03:59.271+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.271+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.281+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:279,8.837977,-1.821930,3.839416
06-07 17:03:59.281+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:284,8.932407,-1.914258,3.952943
06-07 17:03:59.281+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.281+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.281+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:288,8.913264,-1.799403,3.833302
06-07 17:03:59.281+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.291+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:291,8.838597,-1.820621,3.838609
06-07 17:03:59.291+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.301+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:292,0.049373,0.096427,0.063347
06-07 17:03:59.301+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:280,0.350000,-0.490000,-0.140000
06-07 17:03:59.301+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.301+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:305,8.837004,-1.822325,3.841470
06-07 17:03:59.301+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:308,1.540000,0.700000,-0.490000
06-07 17:03:59.301+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.311+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.311+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.311+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:316,0.080574,0.012417,0.056962
06-07 17:03:59.311+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.311+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:321,0.094430,-0.092328,0.113527
06-07 17:03:59.321+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:313,0.350000,0.070000,-0.140000
06-07 17:03:59.321+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.321+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.321+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.321+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:327,8.915657,-1.768296,3.811767
06-07 17:03:59.331+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:317,8.838364,-1.819579,3.839641
06-07 17:03:59.331+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:330,0.074667,0.021219,-0.005307
06-07 17:03:59.331+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.331+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:338,0.078653,0.054029,-0.029703
06-07 17:03:59.331+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:328,-0.910000,-0.420000,0.280000
06-07 17:03:59.331+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.341+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.341+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.341+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:345,-0.420000,-0.630000,-0.070000
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:03:59.341+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:03:59.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391039350,000000, pattern:[H:mm][0;m
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:03:59.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:03:59.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:03:59.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:03][0;m
06-07 17:03:59.341+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:350,1.190000,-0.210000,-0.350000
06-07 17:03:59.341+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.351+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.351+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:355,0.074901,0.032141,-0.015911
06-07 17:03:59.351+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.351+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:59.361+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:59:364,385.000000
06-07 17:03:59.361+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:349,8.839777,-1.815935,3.838112
06-07 17:03:59.361+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:360,0.078273,0.018926,0.040654
06-07 17:03:59.361+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.371+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:354,0.700000,-0.210000,-0.350000
06-07 17:03:59.371+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:359,8.913264,-1.787439,3.823731
06-07 17:03:59.371+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.371+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.371+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.371+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:377,0.630000,0.280000,-0.280000
06-07 17:03:59.371+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:373,0.058244,-0.023157,0.010925
06-07 17:03:59.381+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.381+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.381+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:381,8.918050,-1.797010,3.878766
06-07 17:03:59.381+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:389,-0.350000,0.280000,0.070000
06-07 17:03:59.381+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.391+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:386,0.043988,-0.050508,0.024560
06-07 17:03:59.391+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:394,-0.070000,-0.070000,0.280000
06-07 17:03:59.391+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.401+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.401+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.401+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:385,8.840664,-1.814531,3.836734
06-07 17:03:59.401+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:406,0.122299,-0.016739,0.054905
06-07 17:03:59.401+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:03:59.401+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:401,-0.070000,-0.350000,-0.140000
06-07 17:03:59.401+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.401+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:59:412,78
06-07 17:03:59.411+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:413,1.120000,0.490000,-0.420000
06-07 17:03:59.411+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.421+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:408,8.898908,-1.837688,3.847659
06-07 17:03:59.421+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.421+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.421+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:430,0.108717,0.053279,0.062989
06-07 17:03:59.421+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:429,0.770000,0.420000,-0.280000
06-07 17:03:59.431+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.431+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:422,8.840562,-1.813501,3.837456
06-07 17:03:59.441+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.451+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.451+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.461+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:452,0.082632,0.025738,0.033154
06-07 17:03:59.461+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:439,8.884550,-1.864009,3.862016
06-07 17:03:59.461+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.471+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.471+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:471,8.963513,-1.830509,3.890730
06-07 17:03:59.471+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.481+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:478,0.117833,0.032312,-0.016919
06-07 17:03:59.481+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.491+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:483,8.949157,-1.761117,3.900301
06-07 17:03:59.491+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.491+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:465,-0.280000,-0.630000,0.280000
06-07 17:03:59.501+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:486,8.841214,-1.813771,3.835825
06-07 17:03:59.501+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.501+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:508,-0.070000,-0.210000,0.350000
06-07 17:03:59.501+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.501+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.511+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:513,-0.420000,0.140000,0.280000
06-07 17:03:59.511+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.511+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:491,0.060232,-0.078955,-0.029049
06-07 17:03:59.511+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:498,8.922836,-1.787439,3.871587
06-07 17:03:59.521+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:513,8.840440,-1.814397,3.837312
06-07 17:03:59.531+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.531+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.551+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.551+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:03:59.561+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:03:59:564,386.000000
06-07 17:03:59.561+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:562,8.840204,-1.813177,3.838433
06-07 17:03:59.561+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:544,8.958728,-1.777867,3.821337
06-07 17:03:59.571+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.571+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:545,0.068552,-0.013438,0.037742
06-07 17:03:59.571+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.571+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:576,8.840895,-1.810179,3.838256
06-07 17:03:59.571+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.571+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.581+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:521,-0.140000,0.700000,-0.280000
06-07 17:03:59.581+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:583,8.841067,-1.808982,3.838423
06-07 17:03:59.581+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.581+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.581+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:589,8.842319,-1.807500,3.836237
06-07 17:03:59.591+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.591+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:596,8.842377,-1.810634,3.834627
06-07 17:03:59.591+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.601+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:585,8.901299,-1.887937,3.809374
06-07 17:03:59.601+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:587,0.630000,0.420000,-0.070000
06-07 17:03:59.601+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:604,8.841748,-1.810090,3.836332
06-07 17:03:59.601+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.601+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:03:59.601+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.611+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:612,8.840360,-1.809304,3.839900
06-07 17:03:59.611+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:03:59:611,77
06-07 17:03:59.611+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.611+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.611+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:578,0.078066,0.006446,0.115923
06-07 17:03:59.621+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:621,8.839785,-1.810531,3.840647
06-07 17:03:59.621+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.621+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.621+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:628,8.840319,-1.810285,3.839533
06-07 17:03:59.631+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.631+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:636,8.840659,-1.808828,3.839437
06-07 17:03:59.631+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:618,8.910872,-1.820938,3.873980
06-07 17:03:59.631+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.631+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.641+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:644,8.840917,-1.809544,3.838507
06-07 17:03:59.641+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:610,0.140000,-0.210000,0.350000
06-07 17:03:59.641+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.641+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.641+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:03:59:650,0.070000,-0.490000,0.350000
06-07 17:03:59.641+0200 I/gyroscope(15211): es.ugr.frailty.gyroscope - capturing data
06-07 17:03:59.641+0200 I/gravity (15143): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:03:59:651,8.841766,-1.811047,3.835839
06-07 17:03:59.651+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:632,0.052373,-0.029990,0.054398
06-07 17:03:59.651+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration - capturing data
06-07 17:03:59.651+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:03:59:642,8.920443,-1.804188,3.950550
06-07 17:03:59.651+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:03:59.651+0200 I/linearacceleration(15220): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:03:59:659,0.087262,-0.002062,-0.001813
06-07 17:03:59.651+0200 I/gravity (15143): es.ugr.frailty.gravity - capturing data
06-07 17:03:59.661+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11152656c6f63152838383
