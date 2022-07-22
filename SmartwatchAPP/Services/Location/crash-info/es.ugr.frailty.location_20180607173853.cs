S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23371
Date: 2018-06-07 17:38:53+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf707452d, r5   = 0xf77ebf98
r6   = 0xffb63450, r7   = 0xffb63300
r8   = 0xf77e8c18, r9   = 0x00000000
r10  = 0xffb633dc, fp   = 0xffb63450
ip   = 0x00000001, sp   = 0xffb632d8
lr   = 0xf7074539, pc   = 0xf70dd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    274928 KB
Buffers:      8556 KB
Cached:     107312 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11472 KB
VmRSS:       11472 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23371 TID = 23371
23371 23445 

Maps Information
f3f3f000 f473e000 rw-p [stack:23445]
f4745000 f4747000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f474f000 f4753000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f475c000 f475e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4766000 f4769000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4778000 f477d000 r-xp /usr/lib/libsystem.so.0.0.0
f4788000 f478b000 r-xp /lib/libattr.so.1.1.0
f4793000 f47a3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47ab000 f47b4000 r-xp /usr/lib/libedbus.so.1.7.99
f47bc000 f47bd000 r-xp /usr/lib/libresponse.so.0.2.96
f47c6000 f47cb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f606d000 f6173000 r-xp /usr/lib/libicuuc.so.57.1
f6189000 f6311000 r-xp /usr/lib/libicui18n.so.57.1
f6321000 f632e000 r-xp /usr/lib/libail.so.0.1.0
f6337000 f633e000 r-xp /usr/lib/libminizip.so.1.0.0
f6347000 f64f0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6510000 f6557000 r-xp /usr/lib/libssl.so.1.0.0
f6563000 f6565000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f656d000 f6574000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f657d000 f6584000 r-xp /lib/libcrypt-2.13.so
f65b5000 f65b8000 r-xp /lib/libcap.so.2.21
f65c0000 f65c2000 r-xp /usr/lib/libiri.so
f65ca000 f6613000 r-xp /usr/lib/libmdm.so.1.2.69
f661b000 f6621000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6629000 f664c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6656000 f6658000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6660000 f667d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6686000 f668a000 r-xp /usr/lib/libsmack.so.1.0.0
f6693000 f66ac000 r-xp /usr/lib/libnetwork.so.0.0.0
f66b5000 f66bd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66c5000 f66cb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66d4000 f66d6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66df000 f66ef000 r-xp /lib/libresolv-2.13.so
f66f3000 f670b000 r-xp /usr/lib/liblzma.so.5.0.3
f6714000 f6716000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f671e000 f6738000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6740000 f676f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6778000 f6787000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6791000 f679b000 r-xp /usr/lib/libsensord-shared.so
f67a4000 f6877000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6882000 f6898000 r-xp /lib/libz.so.1.2.5
f68a0000 f68a5000 r-xp /usr/lib/libffi.so.5.0.10
f68ad000 f68ae000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68b6000 f68c6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68ce000 f68e7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68ef000 f68f1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68f9000 f696e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6978000 f697e000 r-xp /lib/librt-2.13.so
f6987000 f69a5000 r-xp /usr/lib/libsystemd.so.0.4.0
f69af000 f69b0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69b8000 f69db000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69e3000 f69e8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69f0000 f6a1a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a23000 f6a3a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a42000 f6aab000 r-xp /lib/libm-2.13.so
f6ab4000 f6b48000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b5b000 f6b60000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b68000 f6b6f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b77000 f6ba1000 r-xp /usr/lib/libsensor.so.1.9.6
f6baa000 f6c76000 r-xp /usr/lib/libxml2.so.2.7.8
f6c83000 f6c85000 r-xp /usr/lib/libiniparser.so.0
f6c8e000 f6c94000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c9d000 f6d6d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d6e000 f6da2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dab000 f6de7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6def000 f6df2000 r-xp /usr/lib/libbundle.so.0.1.22
f6dfa000 f6e00000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e08000 f6e49000 r-xp /usr/lib/libeina.so.1.7.99
f6e52000 f6e69000 r-xp /usr/lib/libecore.so.1.7.99
f6e80000 f6e89000 r-xp /usr/lib/libvconf.so.0.2.45
f6e91000 f6ea5000 r-xp /lib/libpthread-2.13.so
f6eb0000 f6ebd000 r-xp /usr/lib/libaul.so.0.1.0
f6ec7000 f6ec9000 r-xp /lib/libdl-2.13.so
f6ed2000 f6edd000 r-xp /lib/libunwind.so.8.0.1
f6f0a000 f6f12000 r-xp /lib/libgcc_s-4.6.so.1
f6f13000 f7037000 r-xp /lib/libc-2.13.so
f7045000 f7047000 r-xp /usr/lib/libdlog.so.0.0.0
f704f000 f705b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7064000 f7069000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7071000 f7080000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7088000 f708c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7095000 f7098000 r-xp /usr/lib/libappcore-agent.so.1.1
f70a0000 f70a2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70aa000 f70ae000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70b6000 f70d3000 r-xp /lib/ld-2.13.so
f70dc000 f70df000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70df000 f70e3000 r-xp /usr/lib/libsys-assert.so
f77b8000 f7829000 rw-p [heap]
ffb44000 ffb65000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23371)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70dd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7074539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d7b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d79c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d85e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d8bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d8bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dc075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6dbb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d79c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d85e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d8bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d8bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6dbde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dbe017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6dc5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf475d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4750171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6823663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cd0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cd27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e62ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e5db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e5e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e5e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7096183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70967fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70dd5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f2a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf70dcf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
,-0.124427,9.827322
06-07 17:38:52.551+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.561+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:563,0.026201,-0.023984,0.025974
06-07 17:38:52.561+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:558,-0.070000,0.070000,0.070000
06-07 17:38:52.561+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.561+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:571,0.305756,-0.099985,9.801373
06-07 17:38:52.571+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.571+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.571+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.571+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.581+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:579,0.325424,-0.105284,9.769895
06-07 17:38:52.581+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:579,-0.070000,0.070000,0.070000
06-07 17:38:52.581+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:580,0.307123,-0.101238,9.801317
06-07 17:38:52.581+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:585,0.019668,-0.005299,-0.031478
06-07 17:38:52.591+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.591+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.591+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.591+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.601+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:598,0.308114,-0.101577,9.801282
06-07 17:38:52.601+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:600,0.334995,-0.095713,9.796216
06-07 17:38:52.611+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:598,-0.070000,0.070000,0.070000
06-07 17:38:52.611+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:604,0.027873,0.005525,-0.005101
06-07 17:38:52.611+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.611+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.611+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.621+0200 I/heartrate(23353): es.ugr.frailty.heartrate - capturing data
06-07 17:38:52.621+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.621+0200 I/heartrate(23353): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:52.621+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:621,0.308975,-0.101142,9.801260
06-07 17:38:52.621+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:622,0.070000,0.070000,0.070000
06-07 17:38:52.621+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:627,0.022095,0.044150,0.030827
06-07 17:38:52.621+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:622,0.330210,-0.057428,9.832108
06-07 17:38:52.631+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.631+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.631+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.631+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:640,0.296710,-0.062213,9.846465
06-07 17:38:52.631+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:640,-0.070000,0.070000,0.070000
06-07 17:38:52.631+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.641+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:640,0.309992,-0.099209,9.801248
06-07 17:38:52.641+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:645,-0.012265,0.038929,0.045205
06-07 17:38:52.651+0200 I/light   (23406): es.ugr.frailty.light - capturing data
06-07 17:38:52.651+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.651+0200 I/light   (23406): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:52:661,614.000000
06-07 17:38:52.651+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.661+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.661+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:665,0.025003,0.039388,0.047610
06-07 17:38:52.661+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.661+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:662,-0.070000,0.070000,0.070000
06-07 17:38:52.661+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:666,0.334995,-0.059821,9.848858
06-07 17:38:52.661+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:670,0.309529,-0.097531,9.801279
06-07 17:38:52.671+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.671+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.671+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.671+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:679,0.356531,-0.083749,9.820145
06-07 17:38:52.671+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:679,-0.070000,0.070000,0.070000
06-07 17:38:52.671+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.681+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:679,0.310704,-0.095887,9.801258
06-07 17:38:52.681+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:684,0.047001,0.013782,0.018866
06-07 17:38:52.691+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.691+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.691+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.691+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:701,0.312828,-0.095478,9.801194
06-07 17:38:52.701+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.701+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:700,0.330210,-0.114855,10.025927
06-07 17:38:52.701+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:701,-0.070000,0.070000,0.070000
06-07 17:38:52.701+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:706,0.019506,-0.018968,0.224669
06-07 17:38:52.711+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.711+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.711+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:719,0.140000,0.140000,0.070000
06-07 17:38:52.711+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.711+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.721+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:724,0.000632,-0.019377,0.100307
06-07 17:38:52.721+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:725,0.312507,-0.095919,9.801200
06-07 17:38:52.721+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:719,0.313460,-0.114855,9.901501
06-07 17:38:52.731+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.731+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.741+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.741+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.741+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:743,0.315853,-0.114855,9.779467
06-07 17:38:52.741+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:743,-0.070000,0.140000,0.070000
06-07 17:38:52.751+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:749,0.003346,-0.018937,-0.021733
06-07 17:38:52.751+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:749,0.312328,-0.096867,9.801196
06-07 17:38:52.751+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.751+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.751+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.751+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.761+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:759,0.332602,-0.107677,9.726824
06-07 17:38:52.761+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:759,0.311980,-0.097529,9.801201
06-07 17:38:52.761+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:759,0.070000,0.140000,0.070000
06-07 17:38:52.761+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:765,0.020274,-0.010810,-0.074372
06-07 17:38:52.771+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.771+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.771+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:779,0.140000,0.140000,0.070000
06-07 17:38:52.771+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.781+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.781+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:786,-0.005699,0.020959,0.114655
06-07 17:38:52.781+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:780,0.306281,-0.076570,9.915856
06-07 17:38:52.781+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:786,0.312292,-0.097697,9.801189
06-07 17:38:52.791+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.791+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.791+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.801+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.801+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:801,0.140000,0.140000,0.070000
06-07 17:38:52.801+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:801,0.325424,-0.078963,9.760324
06-07 17:38:52.801+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:801,0.311088,-0.096289,9.801242
06-07 17:38:52.811+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:806,0.013132,0.018734,-0.040866
06-07 17:38:52.811+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.811+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.811+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.821+0200 I/heartrate(23353): es.ugr.frailty.heartrate - capturing data
06-07 17:38:52.821+0200 I/heartrate(23353): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:52.821+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.831+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:820,-0.070000,0.070000,0.070000
06-07 17:38:52.831+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:821,0.332602,-0.114855,9.834501
06-07 17:38:52.831+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.831+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.831+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:820,0.311904,-0.095623,9.801222
06-07 17:38:52.841+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.841+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:833,0.021514,-0.018566,0.033259
06-07 17:38:52.841+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:844,0.070000,0.070000,0.070000
06-07 17:38:52.851+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.851+0200 I/light   (23406): es.ugr.frailty.light - capturing data
06-07 17:38:52.851+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:856,-0.022373,-0.009661,0.021316
06-07 17:38:52.851+0200 I/light   (23406): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:52:859,608.000000
06-07 17:38:52.861+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.861+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:848,0.312465,-0.096332,9.801197
06-07 17:38:52.861+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:846,0.289532,-0.105284,9.822537
06-07 17:38:52.861+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.861+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.861+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.871+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:866,0.070000,0.070000,0.070000
06-07 17:38:52.871+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.871+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:871,0.313460,-0.090927,9.863215
06-07 17:38:52.871+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:873,0.310874,-0.096589,9.801246
06-07 17:38:52.881+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.881+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.881+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:875,0.000995,0.005405,0.062018
06-07 17:38:52.881+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.881+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:883,0.070000,0.070000,0.070000
06-07 17:38:52.881+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:887,0.301496,-0.122034,9.856036
06-07 17:38:52.891+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:890,-0.009378,-0.025445,0.054790
06-07 17:38:52.891+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.891+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:888,0.310501,-0.096120,9.801262
06-07 17:38:52.891+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.891+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:898,-0.070000,0.070000,0.070000
06-07 17:38:52.891+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.891+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:900,0.310055,-0.097455,9.801263
06-07 17:38:52.901+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.901+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:905,0.002959,-0.040271,-0.005046
06-07 17:38:52.901+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:906,0.313460,-0.136391,9.796216
06-07 17:38:52.911+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.911+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.921+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:919,0.140000,0.070000,0.070000
06-07 17:38:52.921+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.921+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:919,0.309659,-0.098956,9.801260
06-07 17:38:52.921+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.921+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:926,0.020155,-0.003043,0.064345
06-07 17:38:52.921+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:929,0.330210,-0.100499,9.865608
06-07 17:38:52.931+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.931+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.941+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:942,-0.070000,0.070000,0.070000
06-07 17:38:52.941+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:941,0.310604,-0.099132,9.801229
06-07 17:38:52.941+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.941+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.941+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:948,-0.008163,-0.008721,0.016491
06-07 17:38:52.941+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:949,0.301496,-0.107677,9.817751
06-07 17:38:52.951+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.951+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.951+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:959,0.070000,0.070000,0.070000
06-07 17:38:52.951+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:959,0.309731,-0.099360,9.801254
06-07 17:38:52.951+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.951+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.961+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:965,-0.001929,-0.006152,0.078735
06-07 17:38:52.961+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:965,0.308674,-0.105284,9.879964
06-07 17:38:52.971+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.971+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.981+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:982,0.070000,0.070000,0.070000
06-07 17:38:52.981+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:52.981+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:52.981+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:982,0.309162,-0.099428,9.801271
06-07 17:38:52.981+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:52:989,-0.015414,0.003647,0.035639
06-07 17:38:52.991+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:52:988,0.294317,-0.095713,9.836893
06-07 17:38:52.991+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:52.991+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:52.991+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:52:999,0.070000,0.070000,0.070000
06-07 17:38:53.001+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.001+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.001+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:52:999,0.308004,-0.099062,9.801311
06-07 17:38:53.001+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:7,0.023440,0.025251,0.081086
06-07 17:38:53.001+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:7,0.332602,-0.074178,9.882358
06-07 17:38:53.011+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.011+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.011+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:19,0.308602,-0.097691,9.801307
06-07 17:38:53.011+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.011+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:19,0.070000,0.070000,-0.070000
06-07 17:38:53.021+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.021+0200 I/heartrate(23353): es.ugr.frailty.heartrate - capturing data
06-07 17:38:53.021+0200 I/heartrate(23353): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:53.021+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:27,0.015027,0.022492,0.026011
06-07 17:38:53.021+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:25,0.323031,-0.076570,9.827322
06-07 17:38:53.031+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.031+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.041+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.041+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:41,0.309307,-0.096815,9.801292
06-07 17:38:53.041+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:41,-0.070000,0.070000,0.070000
06-07 17:38:53.041+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.041+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:47,0.311067,-0.088534,9.906286
06-07 17:38:53.041+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:48,0.002465,0.009156,0.104980
06-07 17:38:53.051+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.051+0200 I/light   (23406): es.ugr.frailty.light - capturing data
06-07 17:38:53.051+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:59,-0.070000,0.070000,0.070000
06-07 17:38:53.051+0200 I/light   (23406): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:53:60,604.000000
06-07 17:38:53.061+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.061+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.061+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:67,0.037652,-0.010862,0.033209
06-07 17:38:53.061+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.061+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:66,0.309325,-0.096505,9.801295
06-07 17:38:53.071+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.071+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:74,0.346959,-0.107677,9.834501
06-07 17:38:53.071+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.081+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:80,-0.070000,0.070000,0.070000
06-07 17:38:53.081+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.081+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.081+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:87,-0.034151,-0.011172,0.069098
06-07 17:38:53.081+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:87,0.275175,-0.107677,9.870394
06-07 17:38:53.081+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:82,0.311143,-0.097151,9.801231
06-07 17:38:53.091+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.091+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.091+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.091+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.101+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:99,0.309293,-0.097783,9.801284
06-07 17:38:53.101+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:100,0.334995,-0.136391,9.832108
06-07 17:38:53.101+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:100,-0.070000,0.070000,0.070000
06-07 17:38:53.101+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:105,0.023852,-0.039240,0.030877
06-07 17:38:53.111+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.111+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.111+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.111+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:119,-0.070000,0.070000,0.070000
06-07 17:38:53.111+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.121+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:125,0.025702,-0.000322,0.047574
06-07 17:38:53.121+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:120,0.310679,-0.099683,9.801221
06-07 17:38:53.121+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:121,0.334995,-0.098106,9.848858
06-07 17:38:53.131+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.131+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.141+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.141+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:141,0.311067,-0.076570,9.846465
06-07 17:38:53.141+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:141,-0.070000,0.070000,0.070000
06-07 17:38:53.141+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.151+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.151+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.161+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:159,0.303888,-0.074178,9.805787
06-07 17:38:53.161+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:146,0.000388,0.023113,0.045244
06-07 17:38:53.161+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.171+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:155,0.311817,-0.099725,9.801184
06-07 17:38:53.171+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.171+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:166,0.140000,0.070000,0.070000
06-07 17:38:53.171+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.171+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.181+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:183,0.140000,0.070000,0.070000
06-07 17:38:53.181+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:175,-0.007929,0.025547,0.004603
06-07 17:38:53.181+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.181+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:181,0.311067,-0.078963,9.877571
06-07 17:38:53.191+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.191+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.191+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:189,0.311111,-0.098273,9.801221
06-07 17:38:53.191+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:199,0.140000,0.070000,0.070000
06-07 17:38:53.201+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.201+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:193,-0.000044,0.019310,0.076350
06-07 17:38:53.201+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.201+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:207,-0.020635,-0.020463,0.057163
06-07 17:38:53.201+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:206,0.310167,-0.096786,9.801266
06-07 17:38:53.201+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.211+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.211+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:202,0.289532,-0.117248,9.858429
06-07 17:38:53.211+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.211+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:219,0.210000,0.140000,0.070000
06-07 17:38:53.211+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.221+0200 I/heartrate(23353): es.ugr.frailty.heartrate - capturing data
06-07 17:38:53.221+0200 I/heartrate(23353): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:53.221+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:225,-0.010362,0.009437,0.037986
06-07 17:38:53.221+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:222,0.299103,-0.086142,9.839286
06-07 17:38:53.221+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:214,0.309465,-0.095578,9.801300
06-07 17:38:53.221+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.231+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:233,0.307331,-0.096095,9.801362
06-07 17:38:53.231+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.231+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.231+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.231+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:240,-0.070000,0.140000,0.070000
06-07 17:38:53.241+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.241+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:245,0.020486,0.045845,0.030746
06-07 17:38:53.241+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:241,0.327817,-0.050249,9.832108
06-07 17:38:53.241+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:246,0.306829,-0.095708,9.801381
06-07 17:38:53.251+0200 I/light   (23406): es.ugr.frailty.light - capturing data
06-07 17:38:53.251+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.251+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:259,0.307804,-0.093688,9.801371
06-07 17:38:53.251+0200 I/light   (23406): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:53:258,600.000000
06-07 17:38:53.251+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.251+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.261+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.261+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:264,0.287139,-0.071785,9.836893
06-07 17:38:53.271+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:266,-0.070000,0.070000,0.070000
06-07 17:38:53.271+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:265,-0.019690,0.023923,0.035512
06-07 17:38:53.271+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.271+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.271+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.281+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:281,0.024799,-0.011596,0.069023
06-07 17:38:53.281+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.281+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:280,0.306936,-0.092744,9.801407
06-07 17:38:53.281+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:281,0.332602,-0.105284,9.870394
06-07 17:38:53.281+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:286,-0.070000,0.070000,0.070000
06-07 17:38:53.291+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.291+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.291+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:299,0.308155,-0.093432,9.801362
06-07 17:38:53.291+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.291+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.301+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:304,-0.070000,0.070000,0.070000
06-07 17:38:53.301+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:299,0.018488,-0.017326,0.042665
06-07 17:38:53.301+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:304,0.325424,-0.110070,9.844072
06-07 17:38:53.311+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.311+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.311+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:320,0.308528,-0.094018,9.801345
06-07 17:38:53.311+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:321,-0.001873,-0.023817,0.037924
06-07 17:38:53.321+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.321+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.321+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:326,0.070000,0.070000,0.070000
06-07 17:38:53.321+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:328,0.306281,-0.117248,9.839286
06-07 17:38:53.331+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.341+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.351+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:342,0.307964,-0.094924,9.801353
06-07 17:38:53.351+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:349,0.306281,-0.136391,9.815358
06-07 17:38:53.351+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.351+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.371+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:366,0.308011,-0.096996,9.801332
06-07 17:38:53.371+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:368,0.339781,-0.119641,9.798609
06-07 17:38:53.371+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.381+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.381+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:386,0.070000,0.070000,0.070000
06-07 17:38:53.381+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.391+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.391+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.401+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:383,0.309909,-0.098337,9.801259
06-07 17:38:53.411+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.411+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:395,-0.070000,0.070000,0.070000
06-07 17:38:53.411+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.411+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:403,0.315853,-0.095713,9.844072
06-07 17:38:53.411+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:401,-0.002247,-0.042373,0.014013
06-07 17:38:53.421+0200 I/heartrate(23353): es.ugr.frailty.heartrate - capturing data
06-07 17:38:53.421+0200 I/heartrate(23353): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:53.421+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.421+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.431+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:424,0.310448,-0.098476,9.801240
06-07 17:38:53.441+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:433,0.031816,-0.024717,-0.002745
06-07 17:38:53.441+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:426,-0.140000,0.070000,0.070000
06-07 17:38:53.441+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:435,0.296710,-0.095713,9.844072
06-07 17:38:53.441+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.441+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.451+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.451+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.451+0200 I/light   (23406): es.ugr.frailty.light - capturing data
06-07 17:38:53.451+0200 I/light   (23406): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:53:458,596.000000
06-07 17:38:53.461+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:455,-0.140000,0.070000,0.070000
06-07 17:38:53.471+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:465,0.007842,0.001283,0.042741
06-07 17:38:53.471+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:454,0.309807,-0.098457,9.801261
06-07 17:38:53.481+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:467,0.318245,-0.100499,9.896714
06-07 17:38:53.481+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.481+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.481+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:38:53.481+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:38:53.481+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:38:53.491+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.501+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.501+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:502,-0.013199,0.002624,0.042813
06-07 17:38:53.511+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:495,0.310142,-0.098639,9.801249
06-07 17:38:53.511+0200 W/LOCATION(23371): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:38:53.511+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:497,-0.070000,0.070000,0.070000
06-07 17:38:53.511+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.521+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.521+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.521+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:506,0.301496,-0.078963,9.860823
06-07 17:38:53.521+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.531+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:536,0.311067,-0.086142,9.824929
06-07 17:38:53.531+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:527,0.309779,-0.097800,9.801269
06-07 17:38:53.541+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:533,0.007797,-0.002022,0.095474
06-07 17:38:53.541+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:535,-0.070000,0.070000,0.070000
06-07 17:38:53.541+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.541+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.551+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.551+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.561+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:556,-0.008311,0.019494,0.059562
06-07 17:38:53.561+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:552,0.309902,-0.097366,9.801269
06-07 17:38:53.561+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.571+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.571+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:560,-0.070000,0.070000,0.070000
06-07 17:38:53.571+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.571+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:562,0.301496,-0.117248,9.858429
06-07 17:38:53.571+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.581+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:585,0.318245,-0.122034,9.875179
06-07 17:38:53.581+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:573,0.309466,-0.098413,9.801271
06-07 17:38:53.581+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:579,0.000925,0.012497,0.023681
06-07 17:38:53.581+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:581,-0.070000,0.070000,0.070000
06-07 17:38:53.581+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.591+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.591+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.591+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.591+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:600,-0.070000,0.070000,0.070000
06-07 17:38:53.601+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:604,-0.008283,-0.019449,0.057160
06-07 17:38:53.601+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:605,0.330210,-0.107677,9.853643
06-07 17:38:53.601+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:594,0.309871,-0.099609,9.801247
06-07 17:38:53.611+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.611+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.611+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.611+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.621+0200 I/heartrate(23353): es.ugr.frailty.heartrate - capturing data
06-07 17:38:53.621+0200 I/heartrate(23353): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:38:53.631+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:616,0.310838,-0.100093,9.801211
06-07 17:38:53.631+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:622,-0.070000,0.070000,0.070000
06-07 17:38:53.631+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.641+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:623,0.008343,-0.024668,0.073911
06-07 17:38:53.641+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.641+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:628,0.301496,-0.122034,9.882358
06-07 17:38:53.641+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.641+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.651+0200 I/light   (23406): es.ugr.frailty.light - capturing data
06-07 17:38:53.651+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:643,0.309838,-0.100917,9.801234
06-07 17:38:53.651+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:649,-0.070000,0.070000,0.070000
06-07 17:38:53.651+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:652,0.330210,-0.131605,9.870394
06-07 17:38:53.651+0200 I/light   (23406): es.ugr.frailty.light: SM-R760,07/06/2018,17:38:53:660,593.000000
06-07 17:38:53.661+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:652,0.020743,-0.009264,0.052372
06-07 17:38:53.661+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.661+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.661+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer - capturing data
06-07 17:38:53.671+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration - capturing data
06-07 17:38:53.671+0200 I/linearacceleration(23375): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:38:53:681,-0.008375,-0.022425,0.081111
06-07 17:38:53.681+0200 I/accelerometer(23338): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:38:53:680,0.308674,-0.083749,9.836893
06-07 17:38:53.681+0200 I/gravity (23381): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:38:53:669,0.310838,-0.102432,9.801188
06-07 17:38:53.681+0200 I/gravity (23381): es.ugr.frailty.gravity - capturing data
06-07 17:38:53.681+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:38:53:670,0.070000,0.070000,0.070000
06-07 17:38:53.681+0200 I/gyroscope(23349): es.ugr.frailty.gyroscope - capturing data
06-07 17:38:53.701+0200 W/CRASH_MANAGER(23265): worker.c: worker_job(1205) > 11233716c6f63152838593
