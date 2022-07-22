S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17180
Date: 2018-06-07 17:10:39+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf721252d, r5   = 0xf7582f98
r6   = 0xffb23420, r7   = 0xffb232d0
r8   = 0xf757fc18, r9   = 0x00000000
r10  = 0xffb233ac, fp   = 0xffb23420
ip   = 0x00000001, sp   = 0xffb232a8
lr   = 0xf7212539, pc   = 0xf727b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     54280 KB
Buffers:     12692 KB
Cached:      57812 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11492 KB
VmRSS:       11492 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17180 TID = 17180
17180 17186 

Maps Information
f40dd000 f48dc000 rw-p [stack:17186]
f48e3000 f48e5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48ed000 f48f1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48fa000 f48fc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4904000 f4907000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4916000 f491b000 r-xp /usr/lib/libsystem.so.0.0.0
f4926000 f4929000 r-xp /lib/libattr.so.1.1.0
f4931000 f4941000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4949000 f4952000 r-xp /usr/lib/libedbus.so.1.7.99
f495a000 f495b000 r-xp /usr/lib/libresponse.so.0.2.96
f4964000 f4969000 r-xp /usr/lib/libproc-stat.so.0.2.96
f620b000 f6311000 r-xp /usr/lib/libicuuc.so.57.1
f6327000 f64af000 r-xp /usr/lib/libicui18n.so.57.1
f64bf000 f64cc000 r-xp /usr/lib/libail.so.0.1.0
f64d5000 f64dc000 r-xp /usr/lib/libminizip.so.1.0.0
f64e5000 f668e000 r-xp /usr/lib/libcrypto.so.1.0.0
f66ae000 f66f5000 r-xp /usr/lib/libssl.so.1.0.0
f6701000 f6703000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f670b000 f6712000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f671b000 f6722000 r-xp /lib/libcrypt-2.13.so
f6753000 f6756000 r-xp /lib/libcap.so.2.21
f675e000 f6760000 r-xp /usr/lib/libiri.so
f6768000 f67b1000 r-xp /usr/lib/libmdm.so.1.2.69
f67b9000 f67bf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67c7000 f67ea000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67f4000 f67f6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67fe000 f681b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6824000 f6828000 r-xp /usr/lib/libsmack.so.1.0.0
f6831000 f684a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6853000 f685b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6863000 f6869000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6872000 f6874000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f687d000 f688d000 r-xp /lib/libresolv-2.13.so
f6891000 f68a9000 r-xp /usr/lib/liblzma.so.5.0.3
f68b2000 f68b4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68bc000 f68d6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68de000 f690d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6916000 f6925000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f692f000 f6939000 r-xp /usr/lib/libsensord-shared.so
f6942000 f6a15000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a20000 f6a36000 r-xp /lib/libz.so.1.2.5
f6a3e000 f6a43000 r-xp /usr/lib/libffi.so.5.0.10
f6a4b000 f6a4c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a54000 f6a64000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a6c000 f6a85000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a8d000 f6a8f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a97000 f6b0c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b16000 f6b1c000 r-xp /lib/librt-2.13.so
f6b25000 f6b43000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b4d000 f6b4e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b56000 f6b79000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b81000 f6b86000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b8e000 f6bb8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bc1000 f6bd8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6be0000 f6c49000 r-xp /lib/libm-2.13.so
f6c52000 f6ce6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cf9000 f6cfe000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d06000 f6d0d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d15000 f6d3f000 r-xp /usr/lib/libsensor.so.1.9.6
f6d48000 f6e14000 r-xp /usr/lib/libxml2.so.2.7.8
f6e21000 f6e23000 r-xp /usr/lib/libiniparser.so.0
f6e2c000 f6e32000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e3b000 f6f0b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f0c000 f6f40000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f49000 f6f85000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f8d000 f6f90000 r-xp /usr/lib/libbundle.so.0.1.22
f6f98000 f6f9e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fa6000 f6fe7000 r-xp /usr/lib/libeina.so.1.7.99
f6ff0000 f7007000 r-xp /usr/lib/libecore.so.1.7.99
f701e000 f7027000 r-xp /usr/lib/libvconf.so.0.2.45
f702f000 f7043000 r-xp /lib/libpthread-2.13.so
f704e000 f705b000 r-xp /usr/lib/libaul.so.0.1.0
f7065000 f7067000 r-xp /lib/libdl-2.13.so
f7070000 f707b000 r-xp /lib/libunwind.so.8.0.1
f70a8000 f70b0000 r-xp /lib/libgcc_s-4.6.so.1
f70b1000 f71d5000 r-xp /lib/libc-2.13.so
f71e3000 f71e5000 r-xp /usr/lib/libdlog.so.0.0.0
f71ed000 f71f9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7202000 f7207000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f720f000 f721e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7226000 f722a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7233000 f7236000 r-xp /usr/lib/libappcore-agent.so.1.1
f723e000 f7240000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7248000 f724c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7254000 f7271000 r-xp /lib/ld-2.13.so
f727a000 f727d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f727d000 f7281000 r-xp /usr/lib/libsys-assert.so
f754f000 f75c0000 rw-p [heap]
ffb04000 ffb25000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17180)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf727b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7212539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f193f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f17c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f23e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f29be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f29dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f5e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f591f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f17c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f23e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f29be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f29dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f5be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f5c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f63f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48fb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48ee171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69c1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e6efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e707a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7000ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ffbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ffc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ffc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7234183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72347fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf727b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70c885c) [/lib/libc.so.6] + 0x1785c
29: (0xf727af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.linearacceleration - capturing data
06-07 17:10:38.461+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:462,0.490000,0.280000,0.210000
06-07 17:10:38.461+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.461+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:470,-0.033062,-0.011774,0.055702
06-07 17:10:38.471+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.471+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:476,-1.752448,-3.356891,9.046026
06-07 17:10:38.471+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.471+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:38.481+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:474,0.420000,0.490000,0.140000
06-07 17:10:38.481+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:38:482,79
06-07 17:10:38.481+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.481+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:481,-1.752312,-3.356004,9.046382
06-07 17:10:38.481+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.481+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:491,0.210000,-0.070000,0.140000
06-07 17:10:38.491+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:462,-1.808974,-3.326023,9.071191
06-07 17:10:38.491+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.491+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.491+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:500,-0.030008,-0.027905,-0.010472
06-07 17:10:38.491+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.491+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.501+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:505,0.210000,-0.210000,-0.140000
06-07 17:10:38.501+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:497,-1.761117,-3.369094,9.032906
06-07 17:10:38.501+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.501+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:509,-1.737189,-3.340380,9.095119
06-07 17:10:38.501+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.501+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.511+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:505,-0.065900,-0.023120,0.066098
06-07 17:10:38.511+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.511+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:492,-1.753472,-3.354204,9.046824
06-07 17:10:38.511+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.521+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:515,0.280000,-0.070000,-0.070000
06-07 17:10:38.521+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.521+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:513,-1.837688,-3.342773,9.090333
06-07 17:10:38.521+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.521+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:529,-1.794617,-3.333202,9.109475
06-07 17:10:38.521+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.531+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:524,-1.755429,-3.352313,9.047146
06-07 17:10:38.531+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.531+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:529,0.560000,-0.070000,-0.070000
06-07 17:10:38.531+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.531+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:519,-0.045271,-0.029272,0.059587
06-07 17:10:38.531+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.531+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:542,-0.048134,-0.018233,0.004589
06-07 17:10:38.541+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:538,-1.756059,-3.351264,9.047413
06-07 17:10:38.541+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.541+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:546,0.770000,-0.070000,0.140000
06-07 17:10:38.551+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:533,-1.768296,-3.383451,9.176475
06-07 17:10:38.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:558,-1.765903,-3.385844,9.090333
06-07 17:10:38.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.551+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:556,0.560000,0.070000,0.140000
06-07 17:10:38.561+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.561+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.561+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:567,-0.039599,-0.003652,0.055186
06-07 17:10:38.561+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.561+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:570,0.350000,0.140000,0.140000
06-07 17:10:38.571+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:550,-1.754411,-3.350303,9.048088
06-07 17:10:38.571+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.571+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.571+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:578,-1.752675,-3.349889,9.048577
06-07 17:10:38.571+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.581+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:562,-1.739582,-3.419343,9.138189
06-07 17:10:38.581+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.581+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:582,0.280000,0.210000,0.140000
06-07 17:10:38.581+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:571,-0.006881,0.018598,0.079693
06-07 17:10:38.581+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.581+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.591+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:583,-1.751395,-3.349807,9.048856
06-07 17:10:38.591+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.591+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:591,0.036767,-0.041908,0.041269
06-07 17:10:38.591+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:586,-1.780260,-3.270989,9.111869
06-07 17:10:38.601+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.601+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:597,0.350000,-0.210000,0.140000
06-07 17:10:38.601+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.601+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.611+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:614,0.420000,-0.210000,0.070000
06-07 17:10:38.611+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:616,-1.749853,-3.348168,9.049761
06-07 17:10:38.611+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:606,-1.792224,-3.378666,9.071191
06-07 17:10:38.611+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.621+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:611,-0.021587,-0.015179,0.047537
06-07 17:10:38.621+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.621+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.621+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.621+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:628,0.630000,0.630000,0.280000
06-07 17:10:38.621+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:631,-1.751352,-3.347982,9.049540
06-07 17:10:38.631+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:38.631+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:38:637,819.000000
06-07 17:10:38.631+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.631+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:624,-1.792224,-3.330809,9.121440
06-07 17:10:38.631+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.641+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:629,-0.014447,0.031768,0.040426
06-07 17:10:38.641+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.641+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:643,0.490000,0.350000,0.210000
06-07 17:10:38.651+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.651+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.651+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:657,-1.751789,-3.346117,9.050145
06-07 17:10:38.651+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.651+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:662,-1.752561,-3.344835,9.050469
06-07 17:10:38.661+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:657,0.210000,0.350000,0.140000
06-07 17:10:38.661+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:644,-1.765903,-3.369094,9.090333
06-07 17:10:38.661+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.661+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:668,-1.794617,-3.366701,9.114261
06-07 17:10:38.661+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.661+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.671+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:650,-0.006660,-0.020717,0.038211
06-07 17:10:38.671+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.671+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:678,0.010426,-0.022353,0.040068
06-07 17:10:38.671+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:673,0.210000,0.210000,0.070000
06-07 17:10:38.671+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:38.671+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.681+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:38:683,79
06-07 17:10:38.681+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:672,-1.828116,-3.357130,9.059227
06-07 17:10:38.681+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.681+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:689,-1.730011,-3.330809,9.090333
06-07 17:10:38.681+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.681+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:684,0.070000,0.700000,0.140000
06-07 17:10:38.691+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.691+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.691+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.691+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:701,0.024503,-0.045672,0.073736
06-07 17:10:38.701+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:697,0.210000,0.700000,0.210000
06-07 17:10:38.701+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:697,-1.751851,-3.344009,9.050912
06-07 17:10:38.701+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.701+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.701+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:708,-1.750015,-3.343915,9.051302
06-07 17:10:38.701+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.711+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:715,-0.000136,-0.028661,0.049766
06-07 17:10:38.711+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.711+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:712,0.210000,0.700000,0.210000
06-07 17:10:38.711+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.711+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:693,-1.765903,-3.378666,9.150154
06-07 17:10:38.711+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.721+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:725,-1.820938,-3.302095,9.083155
06-07 17:10:38.721+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.721+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:729,-1.794617,-3.316452,9.107083
06-07 17:10:38.721+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:724,0.210000,-0.210000,0.070000
06-07 17:10:38.721+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.721+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.721+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.731+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:735,-1.751046,-3.341352,9.052049
06-07 17:10:38.731+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:720,0.017573,-0.044284,0.014006
06-07 17:10:38.731+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.741+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.741+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:740,0.210000,-0.210000,0.070000
06-07 17:10:38.741+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.741+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:746,-1.750613,-3.339046,9.052983
06-07 17:10:38.741+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.741+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:751,-1.750850,-3.338395,9.053178
06-07 17:10:38.751+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:750,0.210000,0.210000,0.070000
06-07 17:10:38.751+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:733,-1.794617,-3.297310,9.097511
06-07 17:10:38.751+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.751+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.751+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:760,-1.756332,-3.335595,9.102298
06-07 17:10:38.751+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.761+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:743,-0.006557,0.016139,0.011796
06-07 17:10:38.761+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.761+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:768,0.007495,-0.012656,0.024550
06-07 17:10:38.761+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.761+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:764,0.070000,-0.070000,0.140000
06-07 17:10:38.761+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.771+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:764,-1.756332,-3.402594,9.123833
06-07 17:10:38.771+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.771+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.781+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:779,0.070000,-0.770000,0.140000
06-07 17:10:38.781+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.791+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:792,0.350000,-0.210000,0.070000
06-07 17:10:38.791+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.811+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:805,0.490000,0.560000,0.210000
06-07 17:10:38.811+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.821+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:822,0.210000,0.350000,0.070000
06-07 17:10:38.831+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:10:38.831+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(17092), cmd(0)
06-07 17:10:38.831+0200 W/CAPI_APPFW_APP_CONTROL(17092): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:10:38.831+0200 I/utils   (17092): specific action
06-07 17:10:38.831+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.841+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:843,-0.280000,-0.070000,-0.070000
06-07 17:10:38.851+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.851+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:38.851+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:858,-0.280000,-0.070000,-0.070000
06-07 17:10:38.851+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:38:861,819.000000
06-07 17:10:38.861+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.871+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:38.881+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:872,0.420000,0.490000,0.140000
06-07 17:10:38.881+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.881+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:38:883,79
06-07 17:10:38.891+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:889,0.630000,0.420000,0.280000
06-07 17:10:38.901+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.911+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:772,0.039112,0.005388,0.038603
06-07 17:10:38.911+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.921+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:779,-1.761117,-3.345166,9.107083
06-07 17:10:38.931+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:780,-1.752038,-3.336302,9.053720
06-07 17:10:38.931+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:921,0.490000,0.280000,0.210000
06-07 17:10:38.931+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.941+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.941+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.951+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:928,0.010037,0.010305,0.033795
06-07 17:10:38.951+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:38.961+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:951,-1.770689,-3.388237,9.071191
06-07 17:10:38.961+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:948,-1.753444,-3.334988,9.053931
06-07 17:10:38.961+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:953,0.210000,0.280000,0.140000
06-07 17:10:38.971+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:38.971+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:38.981+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:38.991+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:38:965,0.003267,-0.051931,0.054935
06-07 17:10:38.991+0200 W/LOCATION(17180): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:10:38.991+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.001+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:38:985,-1.768296,-3.383451,9.080762
06-07 17:10:39.001+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.001+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:38:986,-1.752726,-3.334072,9.054408
06-07 17:10:39.011+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.011+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:38:995,0.280000,0.280000,0.070000
06-07 17:10:39.011+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.021+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:11,-1.751546,-3.364309,9.078369
06-07 17:10:39.021+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.021+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:4,-0.030514,-0.035389,0.083517
06-07 17:10:39.031+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.031+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:39.031+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:39:37,820.000000
06-07 17:10:39.031+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:27,-1.789831,-3.330809,9.090333
06-07 17:10:39.031+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.041+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:23,-1.752648,-3.332209,9.055109
06-07 17:10:39.041+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.041+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:25,0.280000,0.700000,0.070000
06-07 17:10:39.041+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.051+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:45,-1.823331,-3.419343,9.097511
06-07 17:10:39.051+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:10:39.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:10:39.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:10:39.061+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:36,-0.040298,-0.005184,0.060096
06-07 17:10:39.071+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:61,-1.763510,-3.359523,9.109475
06-07 17:10:39.071+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.071+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:55,0.140000,0.070000,0.070000
06-07 17:10:39.071+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:76,-1.765903,-3.340380,9.099905
06-07 17:10:39.071+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.071+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:39.081+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.081+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:39:83,79
06-07 17:10:39.081+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:56,-1.755155,-3.331626,9.054837
06-07 17:10:39.081+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:86,-0.019768,-0.019451,0.053221
06-07 17:10:39.091+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.091+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.091+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:81,-1.744368,-3.340380,9.075976
06-07 17:10:39.091+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.101+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.101+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:99,0.140000,-0.210000,0.070000
06-07 17:10:39.111+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:101,-1.744368,-3.354738,9.121440
06-07 17:10:39.111+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.111+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:113,-0.011087,-0.008731,-0.016335
06-07 17:10:39.111+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.121+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:118,-1.797010,-3.337988,9.083155
06-07 17:10:39.121+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.121+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:102,-1.755130,-3.331921,9.054734
06-07 17:10:39.121+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.131+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:128,-1.753939,-3.357130,9.083155
06-07 17:10:39.131+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.141+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.141+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:139,-1.816152,-3.364309,9.061620
06-07 17:10:39.141+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.141+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:136,-1.757023,-3.332813,9.054039
06-07 17:10:39.141+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:129,-0.070000,-0.070000,0.070000
06-07 17:10:39.141+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.161+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.161+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:146,0.019614,-0.016370,0.045630
06-07 17:10:39.161+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:149,-1.799403,-3.345166,9.128618
06-07 17:10:39.161+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.161+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.161+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:167,-1.799403,-3.357130,9.075976
06-07 17:10:39.161+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.171+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:155,-0.280000,-0.280000,-0.070000
06-07 17:10:39.171+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:172,0.000353,0.062022,0.083682
06-07 17:10:39.171+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.181+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:169,-1.760186,-3.331011,9.054087
06-07 17:10:39.181+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:172,-1.787439,-3.347559,9.092726
06-07 17:10:39.181+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.181+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.181+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.181+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:188,-1.758725,-3.357130,9.064013
06-07 17:10:39.181+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.191+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:199,-0.055664,-0.005793,0.018584
06-07 17:10:39.191+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:192,-1.751546,-3.378666,9.126225
06-07 17:10:39.201+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.201+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:186,-0.350000,-0.420000,-0.140000
06-07 17:10:39.201+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.201+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:192,-1.761557,-3.331213,9.053746
06-07 17:10:39.211+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:205,-1.789831,-3.316452,9.099905
06-07 17:10:39.211+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.211+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:212,-0.210000,-0.350000,-0.140000
06-07 17:10:39.211+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.221+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.221+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:217,-1.751546,-3.366701,9.068797
06-07 17:10:39.221+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.221+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:226,-1.763670,-3.330493,9.053599
06-07 17:10:39.231+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:39.231+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:226,-0.037181,0.004020,0.016785
06-07 17:10:39.231+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.231+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:39:237,818.000000
06-07 17:10:39.241+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:226,-1.727618,-3.397808,9.099905
06-07 17:10:39.241+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.241+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:247,-1.706082,-3.316452,9.080762
06-07 17:10:39.241+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.241+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.251+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.251+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:241,-0.210000,-0.210000,-0.070000
06-07 17:10:39.261+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.261+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:257,-1.789831,-3.347559,9.059227
06-07 17:10:39.261+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.261+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:254,-0.038345,-0.001945,0.016592
06-07 17:10:39.271+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:254,-1.763830,-3.326845,9.054910
06-07 17:10:39.271+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.271+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:267,-1.813759,-3.364309,9.061620
06-07 17:10:39.271+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.271+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:39.281+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:271,-0.210000,-0.070000,-0.070000
06-07 17:10:39.281+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:39:284,79
06-07 17:10:39.281+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.281+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.281+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:280,0.010272,-0.045774,-0.021823
06-07 17:10:39.281+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:290,-1.744368,-3.373880,9.135797
06-07 17:10:39.291+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:294,-0.210000,-0.070000,-0.070000
06-07 17:10:39.291+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:283,-1.763069,-3.328179,9.054567
06-07 17:10:39.291+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.291+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.301+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:304,0.034815,-0.017585,0.040318
06-07 17:10:39.301+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.301+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.311+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.311+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:305,-1.763007,-3.327362,9.054880
06-07 17:10:39.311+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:10:39.311+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(17060), cmd(0)
06-07 17:10:39.321+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:313,-0.210000,-0.140000,-0.070000
06-07 17:10:39.321+0200 W/CAPI_APPFW_APP_CONTROL(17060): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:10:39.321+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:324,-0.067042,-0.018077,0.035964
06-07 17:10:39.321+0200 I/utils   (17060): specific action
06-07 17:10:39.321+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.321+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.331+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:335,0.070000,0.070000,0.070000
06-07 17:10:39.331+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.331+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:331,-1.763648,-3.325286,9.055518
06-07 17:10:39.331+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.341+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:315,-1.727618,-3.385844,9.085547
06-07 17:10:39.341+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.341+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:39.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391439352,000000, pattern:[H:mm][0;m
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:39.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:10:39.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:10][0;m
06-07 17:10:39.341+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:340,-0.026951,-0.010367,0.053841
06-07 17:10:39.351+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.351+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:346,-1.764254,-3.324850,9.055560
06-07 17:10:39.351+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:347,-1.761117,-3.416951,9.114261
06-07 17:10:39.351+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.361+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:349,-0.070000,0.140000,0.140000
06-07 17:10:39.361+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:362,0.000920,-0.062099,0.120600
06-07 17:10:39.361+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.361+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:363,-1.741975,-3.361916,9.099905
06-07 17:10:39.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.371+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.371+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:371,-1.762223,-3.325636,9.055667
06-07 17:10:39.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:380,-1.804188,-3.378666,9.128618
06-07 17:10:39.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.381+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:372,-0.070000,0.070000,0.070000
06-07 17:10:39.381+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.381+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.381+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:389,-1.761665,-3.324050,9.056357
06-07 17:10:39.391+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:381,0.002953,-0.065564,0.033994
06-07 17:10:39.391+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.391+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:393,-0.070000,0.350000,0.070000
06-07 17:10:39.391+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.401+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.401+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:398,0.027997,-0.098510,0.081804
06-07 17:10:39.411+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.411+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:406,-1.763961,-3.326002,9.055194
06-07 17:10:39.421+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:409,0.140000,0.140000,0.070000
06-07 17:10:39.421+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:384,-1.749153,-3.373880,9.109475
06-07 17:10:39.421+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.421+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.421+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:421,-0.012527,0.052140,0.056355
06-07 17:10:39.431+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:39.431+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.441+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.441+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:39:439,818.000000
06-07 17:10:39.441+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:439,-1.763510,-3.404987,9.044869
06-07 17:10:39.441+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.451+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:433,0.140000,0.140000,0.070000
06-07 17:10:39.451+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.451+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:447,-0.025705,-0.052883,0.016415
06-07 17:10:39.461+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:435,-1.764270,-3.324345,9.055742
06-07 17:10:39.461+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.471+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.471+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:451,-1.741975,-3.359523,9.097511
06-07 17:10:39.481+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:39.491+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:473,-1.764633,-3.326075,9.055037
06-07 17:10:39.491+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:460,-0.420000,-0.070000,0.070000
06-07 17:10:39.501+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.511+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.511+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.521+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:483,-0.024811,-0.008369,0.065612
06-07 17:10:39.531+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:509,-1.751546,-3.352344,9.087940
06-07 17:10:39.531+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.531+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.531+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:517,-0.210000,0.140000,-0.070000
06-07 17:10:39.541+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:522,-1.765221,-3.328309,9.054100
06-07 17:10:39.541+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:39:538,-1.727618,-3.407379,9.054441
06-07 17:10:39.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:39.551+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:39:488,79
06-07 17:10:39.561+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:39.561+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:39:537,0.002478,-0.045010,0.035297
06-07 17:10:39.561+0200 I/linearacceleration(17109): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:39.561+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:39:551,0.140000,0.280000,0.070000
06-07 17:10:39.561+0200 I/gyroscope(17092): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:39.571+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:39:565,-1.764757,-3.328881,9.053981
06-07 17:10:39.571+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11171806c6f63152838423
