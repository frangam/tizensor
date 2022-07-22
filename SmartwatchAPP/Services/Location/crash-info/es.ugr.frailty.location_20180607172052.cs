S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20194
Date: 2018-06-07 17:20:52+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf706652d, r5   = 0xf7762f98
r6   = 0xffeb5560, r7   = 0xffeb5410
r8   = 0xf775fc18, r9   = 0x00000000
r10  = 0xffeb54ec, fp   = 0xffeb5560
ip   = 0x00000001, sp   = 0xffeb53e8
lr   = 0xf7066539, pc   = 0xf70cf228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     13044 KB
Buffers:      6984 KB
Cached:      56544 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11700 KB
VmRSS:       11700 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20194 TID = 20194
20194 20198 

Maps Information
f3f31000 f4730000 rw-p [stack:20198]
f4737000 f4739000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4741000 f4745000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f474e000 f4750000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4758000 f475b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f476a000 f476f000 r-xp /usr/lib/libsystem.so.0.0.0
f477a000 f477d000 r-xp /lib/libattr.so.1.1.0
f4785000 f4795000 r-xp /usr/lib/libmdm-common.so.1.1.24
f479d000 f47a6000 r-xp /usr/lib/libedbus.so.1.7.99
f47ae000 f47af000 r-xp /usr/lib/libresponse.so.0.2.96
f47b8000 f47bd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f605f000 f6165000 r-xp /usr/lib/libicuuc.so.57.1
f617b000 f6303000 r-xp /usr/lib/libicui18n.so.57.1
f6313000 f6320000 r-xp /usr/lib/libail.so.0.1.0
f6329000 f6330000 r-xp /usr/lib/libminizip.so.1.0.0
f6339000 f64e2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6502000 f6549000 r-xp /usr/lib/libssl.so.1.0.0
f6555000 f6557000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f655f000 f6566000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f656f000 f6576000 r-xp /lib/libcrypt-2.13.so
f65a7000 f65aa000 r-xp /lib/libcap.so.2.21
f65b2000 f65b4000 r-xp /usr/lib/libiri.so
f65bc000 f6605000 r-xp /usr/lib/libmdm.so.1.2.69
f660d000 f6613000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f661b000 f663e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6648000 f664a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6652000 f666f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6678000 f667c000 r-xp /usr/lib/libsmack.so.1.0.0
f6685000 f669e000 r-xp /usr/lib/libnetwork.so.0.0.0
f66a7000 f66af000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66b7000 f66bd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66c6000 f66c8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66d1000 f66e1000 r-xp /lib/libresolv-2.13.so
f66e5000 f66fd000 r-xp /usr/lib/liblzma.so.5.0.3
f6706000 f6708000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6710000 f672a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6732000 f6761000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f676a000 f6779000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6783000 f678d000 r-xp /usr/lib/libsensord-shared.so
f6796000 f6869000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6874000 f688a000 r-xp /lib/libz.so.1.2.5
f6892000 f6897000 r-xp /usr/lib/libffi.so.5.0.10
f689f000 f68a0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68a8000 f68b8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68c0000 f68d9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68e1000 f68e3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68eb000 f6960000 r-xp /usr/lib/libsqlite3.so.0.8.6
f696a000 f6970000 r-xp /lib/librt-2.13.so
f6979000 f6997000 r-xp /usr/lib/libsystemd.so.0.4.0
f69a1000 f69a2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69aa000 f69cd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69d5000 f69da000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69e2000 f6a0c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a15000 f6a2c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a34000 f6a9d000 r-xp /lib/libm-2.13.so
f6aa6000 f6b3a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b4d000 f6b52000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b5a000 f6b61000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b69000 f6b93000 r-xp /usr/lib/libsensor.so.1.9.6
f6b9c000 f6c68000 r-xp /usr/lib/libxml2.so.2.7.8
f6c75000 f6c77000 r-xp /usr/lib/libiniparser.so.0
f6c80000 f6c86000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c8f000 f6d5f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d60000 f6d94000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d9d000 f6dd9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6de1000 f6de4000 r-xp /usr/lib/libbundle.so.0.1.22
f6dec000 f6df2000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dfa000 f6e3b000 r-xp /usr/lib/libeina.so.1.7.99
f6e44000 f6e5b000 r-xp /usr/lib/libecore.so.1.7.99
f6e72000 f6e7b000 r-xp /usr/lib/libvconf.so.0.2.45
f6e83000 f6e97000 r-xp /lib/libpthread-2.13.so
f6ea2000 f6eaf000 r-xp /usr/lib/libaul.so.0.1.0
f6eb9000 f6ebb000 r-xp /lib/libdl-2.13.so
f6ec4000 f6ecf000 r-xp /lib/libunwind.so.8.0.1
f6efc000 f6f04000 r-xp /lib/libgcc_s-4.6.so.1
f6f05000 f7029000 r-xp /lib/libc-2.13.so
f7037000 f7039000 r-xp /usr/lib/libdlog.so.0.0.0
f7041000 f704d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7056000 f705b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7063000 f7072000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f707a000 f707e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7087000 f708a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7092000 f7094000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f709c000 f70a0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70a8000 f70c5000 r-xp /lib/ld-2.13.so
f70ce000 f70d1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70d1000 f70d5000 r-xp /usr/lib/libsys-assert.so
f772f000 f77bd000 rw-p [heap]
ffe96000 ffeb7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20194)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70cf228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7066539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d6d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d6bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d77e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d7dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d7ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6db275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6dad1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d6bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d77e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d7dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d7ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6dafe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6db0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6db7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf474f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4742171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6815663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cc2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cc47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e54ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e4fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e505a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e50879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7088183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70887fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70cf5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f1c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf70cef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
gravity - capturing data
06-07 17:21:46.491+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:46.501+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:46:494,0.339781,-0.078963,9.793823
06-07 17:21:46.511+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:46:503,0.313119,-0.092475,9.801213
06-07 17:21:46.521+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:46.521+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:46.521+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.531+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:46.531+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:46:539,702.000000
06-07 17:21:46.541+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:46.541+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:527,-0.005350,-0.003551,0.035600
06-07 17:21:46.551+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:46.551+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:46:511,0.140000,0.070000,0.070000
06-07 17:21:46.551+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:46.561+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:46:557,0.301496,-0.078963,9.808180
06-07 17:21:46.571+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.581+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:46:563,0.313599,-0.093004,9.801193
06-07 17:21:46.581+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:46.591+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:46.591+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:46:568,0.140000,0.070000,0.070000
06-07 17:21:46.611+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:46.621+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:588,0.028860,0.013179,-0.026636
06-07 17:21:46.621+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.621+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:626,0.030328,0.026768,0.002100
06-07 17:21:46.621+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.621+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:631,-0.004068,-0.024897,-0.026600
06-07 17:21:46.621+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.631+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:635,-0.020293,0.026377,0.057142
06-07 17:21:46.631+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.631+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:641,-0.021315,0.032075,-0.017092
06-07 17:21:46.641+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.641+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:645,0.022549,-0.000464,0.018762
06-07 17:21:46.641+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.641+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:650,0.026979,-0.036661,0.030734
06-07 17:21:46.651+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.651+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:656,0.002320,-0.035299,0.025984
06-07 17:21:46.651+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.651+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:661,0.018830,0.011944,0.090614
06-07 17:21:46.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:666,0.025701,-0.010362,0.047546
06-07 17:21:46.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:670,0.005811,-0.010068,0.002110
06-07 17:21:46.671+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.671+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:675,-0.021186,0.024086,0.028458
06-07 17:21:46.671+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.671+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:680,-0.008638,0.027866,0.028429
06-07 17:21:46.681+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.681+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:685,0.016348,0.004647,0.033166
06-07 17:21:46.681+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.681+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:691,-0.012655,-0.002935,0.037956
06-07 17:21:46.691+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.691+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:696,-0.011577,-0.053230,0.013994
06-07 17:21:46.691+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.691+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:701,0.017527,-0.012303,-0.000350
06-07 17:21:46.701+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.701+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:706,0.005111,0.038354,0.037952
06-07 17:21:46.701+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:711,-0.001861,0.000437,0.033142
06-07 17:21:46.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:716,-0.006099,-0.023700,0.033123
06-07 17:21:46.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:721,0.030522,0.020310,0.045073
06-07 17:21:46.721+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.721+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:726,0.008130,-0.019105,-0.031482
06-07 17:21:46.721+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:46.721+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.721+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:46.721+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:731,0.005913,0.010203,0.018768
06-07 17:21:46.731+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.731+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:736,0.018295,-0.024116,0.018747
06-07 17:21:46.731+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.741+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:741,0.001436,0.007764,0.037900
06-07 17:21:46.741+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.741+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:746,-0.008078,0.007484,0.028324
06-07 17:21:46.741+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:46.741+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.741+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:751,0.028643,-0.028953,-0.033920
06-07 17:21:46.751+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.751+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:756,0.000893,0.010576,0.023564
06-07 17:21:46.751+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.751+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:761,0.032403,-0.009255,-0.007561
06-07 17:21:46.771+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:46:751,702.000000
06-07 17:21:46.771+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.781+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:46:601,0.356531,-0.081356,9.844072
06-07 17:21:46.811+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:46:619,0.311891,-0.092981,9.801248
06-07 17:21:46.811+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:46.811+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:46.811+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:46:623,0.140000,0.070000,0.070000
06-07 17:21:46.811+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:46:819,0.313460,-0.086142,9.822537
06-07 17:21:46.821+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:46.821+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:794,-0.023763,-0.001800,0.030763
06-07 17:21:46.831+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.831+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:46:823,0.311481,-0.092315,9.801268
06-07 17:21:46.841+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:46.861+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:46:831,0.070000,0.070000,0.070000
06-07 17:21:46.861+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:46.861+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:46.881+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:46:873,0.311378,-0.091850,9.801275
06-07 17:21:46.901+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:845,0.008456,-0.032692,-0.007556
06-07 17:21:46.901+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:46.901+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:46:867,0.270389,-0.119641,9.803394
06-07 17:21:46.911+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:46.911+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:46.931+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:46:874,0.070000,0.070000,0.140000
06-07 17:21:46.941+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:46.941+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:46:935,0.309371,-0.091519,9.801342
06-07 17:21:46.941+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:46:912,-0.047172,-0.004702,0.023585
06-07 17:21:46.941+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:46.961+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:46.961+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:46.961+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:46:955,701.000000
06-07 17:21:46.991+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:46:922,0.311067,-0.124427,9.879964
06-07 17:21:47.001+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.001+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:46:990,0.140000,0.070000,0.070000
06-07 17:21:47.001+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.021+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.021+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.031+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:38,0.070000,0.070000,0.070000
06-07 17:21:47.031+0200 I/location(20453): es.ugr.frailty.location: waiting for rigth values
06-07 17:21:47.041+0200 W/CAPI_APPFW_APP_CONTROL(20453): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:47.041+0200 I/utils   (20453): specific action
06-07 17:21:47.041+0200 W/CAPI_APPFW_APP_CONTROL(20453): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:47.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:47.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(20453), cmd(0)
06-07 17:21:47.041+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:8,0.003492,-0.002223,-0.000430
06-07 17:21:47.041+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:14,0.294317,-0.098106,9.808180
06-07 17:21:47.051+0200 I/utils   (20453): specific action
06-07 17:21:47.051+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.051+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:28,0.309419,-0.090346,9.801351
06-07 17:21:47.061+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.061+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.061+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.071+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:75,0.310139,-0.089033,9.801340
06-07 17:21:47.091+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:63,0.005814,0.000150,0.013929
06-07 17:21:47.091+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:78,0.070000,0.070000,0.070000
06-07 17:21:47.091+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.101+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:105,0.004935,0.007647,0.030710
06-07 17:21:47.101+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.101+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:75,0.327817,-0.107677,9.839286
06-07 17:21:47.101+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.111+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.131+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:124,0.140000,0.070000,0.070000
06-07 17:21:47.131+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:115,0.310946,-0.088580,9.801319
06-07 17:21:47.131+0200 E/AUL     (20358): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:21:47.141+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.141+0200 E/AUL     (20358): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:21:47.141+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:119,0.330210,-0.093320,9.791430
06-07 17:21:47.141+0200 E/AUL     (20358): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:21:47.141+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.141+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.141+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:21:47.141+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:21:47.141+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:21:47.141+0200 E/AUL     (20358): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:21:47.141+0200 E/AUL     (20358): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:21:47.141+0200 W/CAPI_APPFW_APP_CONTROL(20358): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:47.141+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:47.141+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(20358), cmd(0)
06-07 17:21:47.141+0200 I/utils   (20358): specific action
06-07 17:21:47.151+0200 W/CAPI_APPFW_APP_CONTROL(20358): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:47.151+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:47.151+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(20358), cmd(0)
06-07 17:21:47.151+0200 I/utils   (20358): specific action
06-07 17:21:47.161+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.161+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:169,0.001974,-0.030838,0.006797
06-07 17:21:47.161+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:150,0.312511,-0.088371,9.801270
06-07 17:21:47.171+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:21:47.171+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:47.171+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:21:47.171+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:47.171+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:47.171+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:47.181+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:47.181+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:47:176,703.000000
06-07 17:21:47.181+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.191+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20297
06-07 17:21:47.191+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:155,0.356531,-0.066999,9.817751
06-07 17:21:47.191+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:154,0.140000,0.070000,0.070000
06-07 17:21:47.191+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20297)
06-07 17:21:47.191+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:21:47.191+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:47.191+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:21:47.191+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:21:47.191+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.201+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.201+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.221+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:213,0.070000,0.070000,0.070000
06-07 17:21:47.221+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:219,0.008625,-0.002887,0.004436
06-07 17:21:47.231+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:202,0.314930,-0.088106,9.801196
06-07 17:21:47.231+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:214,0.294317,-0.095713,9.805787
06-07 17:21:47.241+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:47.241+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:47.241+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.241+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:247,0.315619,-0.089392,9.801162
06-07 17:21:47.251+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20330
06-07 17:21:47.251+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.251+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.251+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.251+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20330)
06-07 17:21:47.251+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:21:47.251+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:47.251+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:21:47.251+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:21:47.271+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:268,0.354138,-0.114855,9.872787
06-07 17:21:47.271+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:267,0.070000,0.070000,0.070000
06-07 17:21:47.281+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.281+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:264,-0.020094,0.028181,-0.002742
06-07 17:21:47.291+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.291+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.291+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:291,0.313389,-0.089616,9.801231
06-07 17:21:47.301+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:47.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:47.321+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.321+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:21:47.321+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:47.321+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:47.321+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(19621), cmd(0)
06-07 17:21:47.321+0200 I/utils   (19621): specific action
06-07 17:21:47.331+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:315,0.325424,-0.105284,9.863215
06-07 17:21:47.331+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:308,0.070000,0.070000,0.140000
06-07 17:21:47.341+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.341+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:47.341+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:47.351+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:47.351+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:47:354,700.000000
06-07 17:21:47.351+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:313,0.019457,-0.006865,-0.002796
06-07 17:21:47.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:21:47.361+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:21:47.361+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:47.361+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:21:47.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:21:47.361+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.361+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.381+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:47.381+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:47.381+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:329,0.312477,-0.090151,9.801256
06-07 17:21:47.381+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.381+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:375,0.311067,-0.105284,9.812965
06-07 17:21:47.391+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20453
06-07 17:21:47.391+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:367,0.140000,0.140000,0.070000
06-07 17:21:47.391+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:378,0.002185,0.000471,-0.005172
06-07 17:21:47.401+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.401+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.401+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.421+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:413,0.070000,0.140000,0.070000
06-07 17:21:47.421+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:395,0.311358,-0.090779,9.801286
06-07 17:21:47.421+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.421+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:425,0.277567,-0.131605,9.846465
06-07 17:21:47.431+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:47.431+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(20453), cmd(0)
06-07 17:21:47.431+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:418,0.004869,0.028991,-0.007575
06-07 17:21:47.441+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.441+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.441+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:447,0.140000,0.070000,0.070000
06-07 17:21:47.451+0200 W/CAPI_APPFW_APP_CONTROL(20453): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:47.451+0200 I/utils   (20453): specific action
06-07 17:21:47.451+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20453)
06-07 17:21:47.451+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:21:47.451+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:47.451+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:21:47.451+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:21:47.451+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:47.451+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:47.461+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:437,0.311432,-0.090824,9.801283
06-07 17:21:47.461+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20358
06-07 17:21:47.471+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:459,-0.011717,0.025040,-0.005203
06-07 17:21:47.481+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.481+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:473,0.311302,-0.090536,9.801290
06-07 17:21:47.491+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.491+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:461,0.315853,-0.033500,9.810574
06-07 17:21:47.491+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.491+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20358)
06-07 17:21:47.491+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:21:47.491+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:47.491+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:21:47.491+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:21:47.511+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.511+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:488,0.070000,0.070000,0.070000
06-07 17:21:47.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:47.521+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.521+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:47.521+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:498,0.001154,-0.024201,0.040219
06-07 17:21:47.521+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:508,0.325424,-0.071785,9.796216
06-07 17:21:47.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20375
06-07 17:21:47.531+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.541+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.551+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:519,0.312060,-0.090190,9.801269
06-07 17:21:47.551+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:533,0.070000,-0.070000,0.140000
06-07 17:21:47.551+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.561+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:47.571+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:47:572,702.000000
06-07 17:21:47.581+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:549,0.030241,0.005463,0.035430
06-07 17:21:47.581+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:47.581+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:47.581+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.591+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20375)
06-07 17:21:47.591+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:21:47.591+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:47.591+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:21:47.591+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:21:47.591+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:47.591+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:47.591+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:557,0.346959,-0.107677,9.851252
06-07 17:21:47.591+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:582,0.311430,-0.089786,9.801292
06-07 17:21:47.601+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.601+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:21:47.611+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.621+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.631+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:47.631+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(19663), cmd(0)
06-07 17:21:47.631+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:598,0.070000,-0.070000,0.070000
06-07 17:21:47.641+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:47.641+0200 I/utils   (19663): specific action
06-07 17:21:47.641+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.641+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:612,0.014973,0.014602,0.056991
06-07 17:21:47.651+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.651+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:624,0.334995,-0.153141,9.805787
06-07 17:21:47.651+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.661+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:21:47.661+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:21:47.661+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:47.661+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:21:47.661+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:21:47.661+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:47.661+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:47.661+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:637,0.308283,-0.091003,9.801381
06-07 17:21:47.671+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:21:47.671+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:47.671+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:47.671+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(19670), cmd(0)
06-07 17:21:47.671+0200 I/utils   (19670): specific action
06-07 17:21:47.681+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.681+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:21:47.681+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:21:47.681+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:47.681+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:21:47.681+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:21:47.691+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:655,0.070000,-0.070000,0.070000
06-07 17:21:47.691+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.691+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:700,0.070000,0.070000,0.070000
06-07 17:21:47.691+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:670,0.346959,-0.100499,9.810574
06-07 17:21:47.701+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:661,0.033190,-0.014540,0.006766
06-07 17:21:47.701+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.701+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:693,0.309306,-0.091338,9.801346
06-07 17:21:47.711+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.711+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.721+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:713,0.002549,0.031890,0.014014
06-07 17:21:47.721+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.731+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:47.731+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:47.731+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:47.731+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:47.731+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.741+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:21:47.761+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:721,0.344566,-0.102891,9.851252
06-07 17:21:47.761+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:47.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(19682), cmd(0)
06-07 17:21:47.761+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:724,0.311097,-0.091505,9.801287
06-07 17:21:47.761+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.761+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.771+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:737,0.140000,0.070000,0.070000
06-07 17:21:47.771+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:47.771+0200 I/utils   (19682): specific action
06-07 17:21:47.781+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.781+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:758,0.033186,0.021069,0.049911
06-07 17:21:47.791+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.791+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:769,0.339781,-0.074178,9.805787
06-07 17:21:47.801+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:47.801+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:47:807,699.000000
06-07 17:21:47.811+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:21:47.811+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:21:47.811+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:47.821+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.821+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:775,0.312102,-0.093398,9.801237
06-07 17:21:47.821+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.831+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:834,0.339781,-0.078963,9.834501
06-07 17:21:47.831+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:793,0.070000,0.070000,0.070000
06-07 17:21:47.841+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:798,0.021879,0.010795,0.035600
06-07 17:21:47.841+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.851+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.861+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.891+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:835,0.313416,-0.094154,9.801188
06-07 17:21:47.891+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.901+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:854,0.070000,0.070000,0.070000
06-07 17:21:47.901+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.911+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:862,0.018195,0.017745,-0.028967
06-07 17:21:47.921+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.921+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:47.921+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:47.931+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:47.941+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:47:939,696.000000
06-07 17:21:47.941+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:905,0.289532,-0.088534,9.870394
06-07 17:21:47.941+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:909,0.311907,-0.095111,9.801227
06-07 17:21:47.951+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.951+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.961+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:933,-0.026108,-0.023468,0.009354
06-07 17:21:47.961+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:914,0.070000,0.070000,0.070000
06-07 17:21:47.961+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:47.971+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:956,0.320638,-0.093320,9.815358
06-07 17:21:47.981+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:47.981+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:957,0.311239,-0.093572,9.801263
06-07 17:21:47.981+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:47.981+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:47.981+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:47:975,0.070000,0.070000,0.070000
06-07 17:21:48.001+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:48.001+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:47:994,0.311649,-0.094499,9.801241
06-07 17:21:48.011+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:47:986,-0.025099,-0.019654,0.018906
06-07 17:21:48.011+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:47:995,0.289532,-0.071785,9.834501
06-07 17:21:48.011+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:48.021+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:48.021+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:48.031+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:48:15,0.210000,0.070000,0.070000
06-07 17:21:48.031+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:48:37,0.308674,-0.100499,9.870394
06-07 17:21:48.041+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:48.041+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:48:35,0.309843,-0.094608,9.801297
06-07 17:21:48.051+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:48:22,-0.028910,-0.023207,0.038028
06-07 17:21:48.061+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:48.061+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:48:66,0.015386,0.018868,0.011683
06-07 17:21:48.071+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:48.071+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:48.071+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:48:47,0.210000,0.070000,0.070000
06-07 17:21:48.081+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:48.091+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:48:80,0.310391,-0.095683,9.801270
06-07 17:21:48.101+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:48:81,0.361316,-0.095713,9.822537
06-07 17:21:48.101+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:48.101+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:48.111+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:48:89,0.140000,0.070000,0.070000
06-07 17:21:48.121+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:48.121+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:48.121+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:48.121+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:48.131+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:48.161+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:21:48.161+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:21:48.161+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:21:48.161+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:48:141,701.000000
06-07 17:21:48.191+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20297) cmd(0)
06-07 17:21:48.191+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:48:133,0.349352,-0.095713,9.832108
06-07 17:21:48.191+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:48.211+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20330) cmd(0)
06-07 17:21:48.221+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11201946c6f63152838485
