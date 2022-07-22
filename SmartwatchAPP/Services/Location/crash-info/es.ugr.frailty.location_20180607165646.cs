S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13143
Date: 2018-06-07 16:56:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf703252d, r5   = 0xf7274f98
r6   = 0xff8df5c0, r7   = 0xff8df470
r8   = 0xf7271c18, r9   = 0x00000000
r10  = 0xff8df54c, fp   = 0xff8df5c0
ip   = 0x00000001, sp   = 0xff8df448
lr   = 0xf7032539, pc   = 0xf709b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    167308 KB
Buffers:      5164 KB
Cached:      61272 KB
VmPeak:      53532 KB
VmSize:      53528 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11756 KB
VmRSS:       11756 KB
VmData:      11256 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13143 TID = 13143
13143 13147 

Maps Information
f3efd000 f46fc000 rw-p [stack:13147]
f4703000 f4705000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f470d000 f4711000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f471a000 f471c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4724000 f4727000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4736000 f473b000 r-xp /usr/lib/libsystem.so.0.0.0
f4746000 f4749000 r-xp /lib/libattr.so.1.1.0
f4751000 f4761000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4769000 f4772000 r-xp /usr/lib/libedbus.so.1.7.99
f477a000 f477b000 r-xp /usr/lib/libresponse.so.0.2.96
f4784000 f4789000 r-xp /usr/lib/libproc-stat.so.0.2.96
f602b000 f6131000 r-xp /usr/lib/libicuuc.so.57.1
f6147000 f62cf000 r-xp /usr/lib/libicui18n.so.57.1
f62df000 f62ec000 r-xp /usr/lib/libail.so.0.1.0
f62f5000 f62fc000 r-xp /usr/lib/libminizip.so.1.0.0
f6305000 f64ae000 r-xp /usr/lib/libcrypto.so.1.0.0
f64ce000 f6515000 r-xp /usr/lib/libssl.so.1.0.0
f6521000 f6523000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f652b000 f6532000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f653b000 f6542000 r-xp /lib/libcrypt-2.13.so
f6573000 f6576000 r-xp /lib/libcap.so.2.21
f657e000 f6580000 r-xp /usr/lib/libiri.so
f6588000 f65d1000 r-xp /usr/lib/libmdm.so.1.2.69
f65d9000 f65df000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65e7000 f660a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6614000 f6616000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f661e000 f663b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6644000 f6648000 r-xp /usr/lib/libsmack.so.1.0.0
f6651000 f666a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6673000 f667b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6683000 f6689000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6692000 f6694000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f669d000 f66ad000 r-xp /lib/libresolv-2.13.so
f66b1000 f66c9000 r-xp /usr/lib/liblzma.so.5.0.3
f66d2000 f66d4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66dc000 f66f6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66fe000 f672d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6736000 f6745000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f674f000 f6759000 r-xp /usr/lib/libsensord-shared.so
f6762000 f6835000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6840000 f6856000 r-xp /lib/libz.so.1.2.5
f685e000 f6863000 r-xp /usr/lib/libffi.so.5.0.10
f686b000 f686c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6874000 f6884000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f688c000 f68a5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68ad000 f68af000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68b7000 f692c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6936000 f693c000 r-xp /lib/librt-2.13.so
f6945000 f6963000 r-xp /usr/lib/libsystemd.so.0.4.0
f696d000 f696e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6976000 f6999000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69a1000 f69a6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69ae000 f69d8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69e1000 f69f8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a00000 f6a69000 r-xp /lib/libm-2.13.so
f6a72000 f6b06000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b19000 f6b1e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b26000 f6b2d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b35000 f6b5f000 r-xp /usr/lib/libsensor.so.1.9.6
f6b68000 f6c34000 r-xp /usr/lib/libxml2.so.2.7.8
f6c41000 f6c43000 r-xp /usr/lib/libiniparser.so.0
f6c4c000 f6c52000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c5b000 f6d2b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d2c000 f6d60000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d69000 f6da5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6dad000 f6db0000 r-xp /usr/lib/libbundle.so.0.1.22
f6db8000 f6dbe000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dc6000 f6e07000 r-xp /usr/lib/libeina.so.1.7.99
f6e10000 f6e27000 r-xp /usr/lib/libecore.so.1.7.99
f6e3e000 f6e47000 r-xp /usr/lib/libvconf.so.0.2.45
f6e4f000 f6e63000 r-xp /lib/libpthread-2.13.so
f6e6e000 f6e7b000 r-xp /usr/lib/libaul.so.0.1.0
f6e85000 f6e87000 r-xp /lib/libdl-2.13.so
f6e90000 f6e9b000 r-xp /lib/libunwind.so.8.0.1
f6ec8000 f6ed0000 r-xp /lib/libgcc_s-4.6.so.1
f6ed1000 f6ff5000 r-xp /lib/libc-2.13.so
f7003000 f7005000 r-xp /usr/lib/libdlog.so.0.0.0
f700d000 f7019000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7022000 f7027000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f702f000 f703e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7046000 f704a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7053000 f7056000 r-xp /usr/lib/libappcore-agent.so.1.1
f705e000 f7060000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7068000 f706c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7074000 f7091000 r-xp /lib/ld-2.13.so
f709a000 f709d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f709d000 f70a1000 r-xp /usr/lib/libsys-assert.so
f7241000 f72c4000 rw-p [heap]
ff8c0000 ff8e1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13143)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf709b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7032539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d393f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d37c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d43e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d49be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d49dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d7e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d791f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d37c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d43e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d49be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d49dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d7be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d7c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d83f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf471b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf470e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67e1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c8efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c907a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e20ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e1bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e1c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e1c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7054183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70547fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf709b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6ee885c) [/lib/libc.so.6] + 0x1785c
29: (0xf709af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
,9.183202
06-07 16:56:45.721+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:718,4.690000,0.140000,-0.770000
06-07 16:56:45.721+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.721+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:45.731+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:45:731,-0.043387,-0.134339,0.155985
06-07 16:56:45.731+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.731+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.731+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:738,3.710000,-0.210000,-1.050000
06-07 16:56:45.731+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:732,1.715654,-3.091527,9.339187
06-07 16:56:45.731+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:739,1.754486,-2.953054,9.185403
06-07 16:56:45.741+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:45.741+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.741+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:45:750,-0.105831,-0.164794,0.098749
06-07 16:56:45.741+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.751+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.751+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:751,5.740000,-1.890000,-0.490000
06-07 16:56:45.751+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:756,1.648655,-3.117848,9.284152
06-07 16:56:45.751+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:756,1.749426,-2.949987,9.187354
06-07 16:56:45.771+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:45.771+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.771+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:45:775,0.042798,0.138421,-0.329124
06-07 16:56:45.771+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.771+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.771+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:776,3.710000,-3.010000,-1.610000
06-07 16:56:45.781+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:781,1.792224,-2.811567,8.858230
06-07 16:56:45.781+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:780,1.759188,-2.944158,9.187360
06-07 16:56:45.781+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:45.781+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.791+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:45:790,0.056964,0.063199,0.075256
06-07 16:56:45.791+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:791,-0.630000,-1.400000,-0.840000
06-07 16:56:45.791+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.791+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.791+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:798,1.816152,-2.880959,9.262616
06-07 16:56:45.801+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:800,1.764814,-2.942980,9.186658
06-07 16:56:45.801+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:45.801+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.811+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:45:811,0.041767,0.193627,0.063994
06-07 16:56:45.811+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:812,1.806581,-2.749353,9.250652
06-07 16:56:45.811+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.811+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.821+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:821,1.763000,-2.937303,9.188823
06-07 16:56:45.821+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:821,-3.990000,2.940000,0.420000
06-07 16:56:45.821+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:45.821+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.831+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:45:832,0.069902,0.190343,0.167114
06-07 16:56:45.831+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.831+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:832,1.832902,-2.746960,9.355937
06-07 16:56:45.831+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.831+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:839,1.760601,-2.925577,9.193023
06-07 16:56:45.841+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:842,-2.030000,3.150000,-0.420000
06-07 16:56:45.841+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:45.841+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.851+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.851+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:45:851,0.029230,0.102046,0.241878
06-07 16:56:45.851+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:852,1.789831,-2.823531,9.434900
06-07 16:56:45.851+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.851+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:45.851+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:858,1.755243,-2.921083,9.195477
06-07 16:56:45.851+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:45:858,88
06-07 16:56:45.861+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:856,-4.130000,3.640000,0.420000
06-07 16:56:45.861+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:56:45.861+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:56:45.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:45.871+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:45.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:45.871+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:45:877,743.000000
06-07 16:56:45.871+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.871+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13026
06-07 16:56:45.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13026)
06-07 16:56:45.881+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:56:45.881+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:45.881+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:56:45.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:56:45.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:45.881+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:45.881+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.891+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:885,-0.840000,3.640000,-1.050000
06-07 16:56:45.891+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:883,1.741975,-3.192025,9.609575
06-07 16:56:45.891+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.891+0200 W/CAPI_APPFW_APP_CONTROL(13026): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:45.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13058
06-07 16:56:45.891+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:45.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13026), cmd(0)
06-07 16:56:45.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13058)
06-07 16:56:45.901+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:56:45.901+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:45.901+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:56:45.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:56:45.901+0200 I/utils   (13026): specific action
06-07 16:56:45.901+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:45.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:45.901+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:893,1.744705,-2.922507,9.197029
06-07 16:56:45.901+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:904,4.410000,-0.490000,-1.330000
06-07 16:56:45.911+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:56:45.911+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:45.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12595), cmd(0)
06-07 16:56:45.911+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:45.911+0200 I/utils   (12595): specific action
06-07 16:56:45.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:56:45.911+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:56:45.911+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:45.911+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:56:45.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:56:45.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:45.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:45.911+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:907,1.806581,-3.232704,9.406186
06-07 16:56:45.921+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:919,1.744444,-2.923496,9.196764
06-07 16:56:45.921+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:45.921+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.921+0200 I/utils   (13058): specific action
06-07 16:56:45.921+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13143
06-07 16:56:45.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:45.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13058), cmd(0)
06-07 16:56:45.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:45.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13143), cmd(0)
06-07 16:56:45.931+0200 W/CAPI_APPFW_APP_CONTROL(13143): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:45.931+0200 I/utils   (13143): specific action
06-07 16:56:45.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13143)
06-07 16:56:45.931+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:56:45.931+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:45.931+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:56:45.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:56:45.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:45.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:45.931+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:934,7.280000,-2.240000,-0.910000
06-07 16:56:45.941+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13072
06-07 16:56:45.941+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:45.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13072)
06-07 16:56:45.941+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:56:45.941+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:45.941+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:56:45.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:56:45.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:45.951+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:937,1.773082,-3.069991,9.226725
06-07 16:56:45.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:45.951+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:45:957,9.240000,-6.650000,-1.610000
06-07 16:56:45.951+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:45.961+0200 W/CAPI_APPFW_APP_CONTROL(13072): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:45.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13086
06-07 16:56:45.961+0200 I/utils   (13072): specific action
06-07 16:56:45.961+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:45.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13086)
06-07 16:56:45.961+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:56:45.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:45.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13072), cmd(0)
06-07 16:56:45.961+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:45.961+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:56:45.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:56:45.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:45.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:45.961+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:45:968,-0.013268,-0.270942,0.414099
06-07 16:56:45.961+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:45.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:56:45.971+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:45.971+0200 I/utils   (12603): specific action
06-07 16:56:45.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:45.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12603), cmd(0)
06-07 16:56:45.971+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:946,1.746120,-2.917381,9.198388
06-07 16:56:45.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:56:45.971+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:56:45.971+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:45.971+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:56:45.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:56:45.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:45.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:45.971+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:45.981+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:45:984,1.755337,-2.919695,9.195899
06-07 16:56:45.981+0200 W/CAPI_APPFW_APP_CONTROL(13086): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:45.981+0200 I/utils   (13086): specific action
06-07 16:56:45.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:56:45.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:45.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13086), cmd(0)
06-07 16:56:45.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:56:45.991+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:56:45.991+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:45.991+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:56:45.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:56:45.991+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:45.991+0200 I/utils   (12614): specific action
06-07 16:56:45.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:56:45.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:56:46.001+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.001+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:6,1.753848,-2.900358,9.202300
06-07 16:56:46.001+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:56:46.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:56:46.011+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:56:46.011+0200 I/servicemanager(12566): App control destroyed.
06-07 16:56:46.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:46.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12614), cmd(0)
06-07 16:56:46.011+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:13,1.765385,-2.904849,9.198677
06-07 16:56:46.011+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.021+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:21,1.790626,-2.893655,9.197326
06-07 16:56:46.021+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.021+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:28,1.800572,-2.940105,9.180637
06-07 16:56:46.031+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:56:46.031+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:56:46.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12618), cmd(0)
06-07 16:56:46.031+0200 I/utils   (12618): specific action
06-07 16:56:46.031+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.031+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.041+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:45:974,0.061876,-0.310197,0.209157
06-07 16:56:46.041+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:45:962,1.727618,-3.132205,8.994620
06-07 16:56:46.051+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.051+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.051+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:46,1.803990,-2.998470,9.161069
06-07 16:56:46.061+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:46.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:56:46.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:56:46.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:56:46.061+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:46:66,88
06-07 16:56:46.061+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:50,5.950000,-0.700000,-1.540000
06-07 16:56:46.061+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.071+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:46.071+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:46:76,741.000000
06-07 16:56:46.081+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:58,1.744368,-2.766103,9.238688
06-07 16:56:46.081+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.081+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:63,0.028638,-0.146495,0.029961
06-07 16:56:46.091+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.101+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.101+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:85,1.820422,-3.083524,9.129531
06-07 16:56:46.101+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.111+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:100,1.739582,-2.548356,8.915657
06-07 16:56:46.111+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:113,1.830920,-3.139337,9.108385
06-07 16:56:46.111+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:107,-0.018502,-0.214824,-0.203768
06-07 16:56:46.121+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:93,-8.890000,-1.120000,-3.920000
06-07 16:56:46.131+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.131+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.131+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.131+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.141+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:138,2.122434,-2.141576,8.822337
06-07 16:56:46.141+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:143,-16.590000,5.180000,-6.510000
06-07 16:56:46.141+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.151+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:142,-0.010969,0.153593,0.042789
06-07 16:56:46.151+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:145,1.838585,-3.175559,9.094274
06-07 16:56:46.151+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.151+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.161+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.161+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:153,-24.710001,8.960000,-8.750000
06-07 16:56:46.161+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.161+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:160,2.005185,-3.244668,9.123833
06-07 16:56:46.171+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:162,-0.014266,0.352002,-0.286643
06-07 16:56:46.171+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.171+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:166,1.825126,-3.173227,9.097798
06-07 16:56:46.171+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:167,-30.380001,8.680000,-7.210000
06-07 16:56:46.171+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.171+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.171+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.181+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:180,-34.369999,4.130000,-11.690000
06-07 16:56:46.181+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.181+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:182,1.902294,-3.452843,9.604790
06-07 16:56:46.191+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:185,0.357049,0.763273,-0.376340
06-07 16:56:46.191+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.191+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:189,-28.910000,2.730000,-8.960000
06-07 16:56:46.191+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:187,1.795244,-3.141298,9.114808
06-07 16:56:46.191+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.191+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.191+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.201+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:203,-16.590000,1.890000,-9.030000
06-07 16:56:46.201+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.201+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:208,1.762448,-3.112230,9.131166
06-07 16:56:46.201+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:203,0.214560,-0.351013,-0.073493
06-07 16:56:46.201+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:202,1.840081,-3.804588,9.238688
06-07 16:56:46.201+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:212,0.490000,3.290000,-8.260000
06-07 16:56:46.211+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.211+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.211+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.211+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.221+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:225,1.751414,-3.095054,9.139123
06-07 16:56:46.221+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:219,0.101722,-0.512738,0.424152
06-07 16:56:46.221+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:222,10.500000,4.760000,-6.440000
06-07 16:56:46.221+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:222,1.835295,-3.474378,9.645468
06-07 16:56:46.221+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.221+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.221+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.231+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:235,0.036090,-0.806118,0.077619
06-07 16:56:46.231+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.241+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:232,9.800000,1.540000,-5.530000
06-07 16:56:46.241+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.251+0200 W/LOCATION(13143): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:56:46.251+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:46.251+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:46:259,88
06-07 16:56:46.261+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.261+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:246,1.756398,-3.103117,9.135432
06-07 16:56:46.261+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:240,1.830509,-3.510271,9.274581
06-07 16:56:46.261+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.261+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:252,3.570000,-0.560000,-4.830000
06-07 16:56:46.261+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.261+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.261+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:46.271+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:46:275,725.000000
06-07 16:56:46.271+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:270,-3.500000,-2.520000,-3.780000
06-07 16:56:46.271+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.281+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:271,1.774860,-3.134619,9.121098
06-07 16:56:46.281+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:269,0.014873,-0.390854,0.515937
06-07 16:56:46.281+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.281+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:273,1.634298,-3.443272,9.205189
06-07 16:56:46.281+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.281+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:283,-0.910000,-4.270000,-3.920000
06-07 16:56:46.291+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.291+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.301+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:300,1.481157,-3.247060,9.327222
06-07 16:56:46.301+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:293,-0.000411,-0.370934,0.166196
06-07 16:56:46.301+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:295,1.781850,-3.117820,9.125492
06-07 16:56:46.301+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.301+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:296,14.840000,-2.800000,-3.640000
06-07 16:56:46.301+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.301+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.311+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.311+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:313,24.010000,-3.430000,-3.710000
06-07 16:56:46.311+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.311+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:313,1.781503,-3.076517,9.139566
06-07 16:56:46.321+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:312,-0.204287,-0.267713,0.110915
06-07 16:56:46.321+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.321+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:318,26.600000,-3.360000,-3.220000
06-07 16:56:46.321+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:320,1.284946,-3.156133,9.506684
06-07 16:56:46.321+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.331+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.331+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:330,-0.343968,-0.073834,0.229424
06-07 16:56:46.331+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.331+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:335,19.389999,-1.400000,-2.520000
06-07 16:56:46.331+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.331+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:330,1.782373,-3.018340,9.158774
06-07 16:56:46.331+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.341+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:56:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:56:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:56:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:56:46.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390606349,000000, pattern:[H:mm][0;m
06-07 16:56:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:56:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:56:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:56:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:56:46.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:56:46.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:56][0;m
06-07 16:56:46.341+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:340,8.820000,-1.820000,-1.260000
06-07 16:56:46.341+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.351+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:339,1.495514,-2.928815,9.159724
06-07 16:56:46.351+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:351,5.250000,-1.750000,-1.260000
06-07 16:56:46.351+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.351+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.351+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:347,-0.510298,-0.014835,0.391876
06-07 16:56:46.351+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:361,3.920000,-1.750000,-0.840000
06-07 16:56:46.361+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:365,1.686940,-3.115455,9.200402
06-07 16:56:46.361+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:348,1.779548,-2.963682,9.177155
06-07 16:56:46.361+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.361+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.371+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.371+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:375,1.780003,-2.939791,9.184749
06-07 16:56:46.371+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:376,4.130000,1.680000,-0.420000
06-07 16:56:46.371+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.371+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:373,-0.266934,0.183415,0.028559
06-07 16:56:46.381+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.381+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.381+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.381+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:390,6.300000,3.500000,0.210000
06-07 16:56:46.391+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:382,1.966900,-3.797409,9.202796
06-07 16:56:46.391+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:388,-0.064474,-0.020401,0.061279
06-07 16:56:46.391+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.391+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:399,1.988436,-3.476771,9.293723
06-07 16:56:46.391+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:389,1.786552,-2.929891,9.186640
06-07 16:56:46.391+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.401+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.401+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.401+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.411+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:411,8.680000,3.570000,1.050000
06-07 16:56:46.411+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:406,0.210502,-0.694293,0.067364
06-07 16:56:46.411+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.411+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:406,1.798019,-2.915731,9.188908
06-07 16:56:46.411+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.421+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:422,0.213576,-0.342152,0.172626
06-07 16:56:46.421+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.421+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:416,1.890330,-3.259024,9.238688
06-07 16:56:46.421+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.431+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:423,1.795577,-2.898687,9.194776
06-07 16:56:46.431+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:432,7.070000,4.270000,1.680000
06-07 16:56:46.431+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.431+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:436,1.931008,-2.924029,9.212367
06-07 16:56:46.431+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.441+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:443,0.108480,-0.141205,0.113195
06-07 16:56:46.441+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.441+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:445,1.788109,-2.879570,9.202235
06-07 16:56:46.441+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.451+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:452,3.920000,3.920000,2.800000
06-07 16:56:46.451+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:56:46.451+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:56:46:458,88
06-07 16:56:46.451+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.461+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.461+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:456,1.799403,-2.608176,8.994620
06-07 16:56:46.461+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.471+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:56:46.471+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:475,3.360000,3.220000,1.960000
06-07 16:56:46.471+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:56:46:476,749.000000
06-07 16:56:46.471+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:466,0.149505,0.152488,0.072801
06-07 16:56:46.471+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.471+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:466,1.777563,-2.857365,9.211195
06-07 16:56:46.471+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.481+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.481+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.481+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:486,1.799403,-2.794817,9.221939
06-07 16:56:46.481+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:491,3.640000,2.660000,1.750000
06-07 16:56:46.491+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:489,0.017029,0.410163,-0.164154
06-07 16:56:46.491+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:488,1.770236,-2.838777,9.218350
06-07 16:56:46.491+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.501+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.501+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.501+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:506,0.019855,0.168865,0.044784
06-07 16:56:46.501+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.511+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:512,3.430000,0.770000,1.540000
06-07 16:56:46.521+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.521+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.521+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:504,1.899901,-2.926422,9.202796
06-07 16:56:46.521+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.531+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:532,4.410000,0.140000,0.980000
06-07 16:56:46.531+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:529,0.119898,0.013368,0.018047
06-07 16:56:46.531+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.541+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:543,0.192312,0.190109,-0.043664
06-07 16:56:46.541+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.541+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.541+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:510,1.759734,-2.822572,9.225335
06-07 16:56:46.541+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.551+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:552,4.830000,2.380000,0.490000
06-07 16:56:46.551+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:549,0.049240,0.142450,-0.026790
06-07 16:56:46.551+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.551+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:535,1.978864,-2.739782,9.142976
06-07 16:56:46.561+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:562,0.061253,0.034479,-0.006336
06-07 16:56:46.561+0200 I/gravity (13086): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:56:46:553,1.748668,-2.815178,9.229697
06-07 16:56:46.561+0200 I/gravity (13086): es.ugr.frailty.gravity - capturing data
06-07 16:56:46.561+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.561+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:56:46:568,0.049579,-0.013353,0.060381
06-07 16:56:46.561+0200 I/linearacceleration(13072): es.ugr.frailty.linearacceleration - capturing data
06-07 16:56:46.561+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.571+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope - capturing data
06-07 16:56:46.571+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:56:46:574,1.847259,-2.773281,9.162118
06-07 16:56:46.571+0200 I/accelerometer(13026): es.ugr.frailty.accelerometer - capturing data
06-07 16:56:46.571+0200 I/gyroscope(13058): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:56:46:576,5.040000,1.890000,0.560000
06-07 16:56:46.581+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11131436c6f63152838340
