S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5843
Date: 2018-04-23 18:25:53+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70dc52d, r5   = 0xf7680f98
r6   = 0xff84fe18, r7   = 0xff84fcc8
r8   = 0xf767dc18, r9   = 0x00000000
r10  = 0xff84fda4, fp   = 0xff84fe18
ip   = 0x00000001, sp   = 0xff84fca0
lr   = 0xf70dc539, pc   = 0xf7145228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5772 KB
Buffers:     68924 KB
Cached:     219564 KB
VmPeak:      52516 KB
VmSize:      52512 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11940 KB
VmRSS:       11936 KB
VmData:      10240 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5843 TID = 5843
5843 5877 

Maps Information
f3fa7000 f47a6000 rw-p [stack:5877]
f47ad000 f47af000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47b7000 f47bb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47c4000 f47c6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47ce000 f47d1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47e0000 f47e5000 r-xp /usr/lib/libsystem.so.0.0.0
f47f0000 f47f3000 r-xp /lib/libattr.so.1.1.0
f47fb000 f480b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4813000 f481c000 r-xp /usr/lib/libedbus.so.1.7.99
f4824000 f4825000 r-xp /usr/lib/libresponse.so.0.2.96
f482e000 f4833000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60d5000 f61db000 r-xp /usr/lib/libicuuc.so.57.1
f61f1000 f6379000 r-xp /usr/lib/libicui18n.so.57.1
f6389000 f6396000 r-xp /usr/lib/libail.so.0.1.0
f639f000 f63a6000 r-xp /usr/lib/libminizip.so.1.0.0
f63af000 f6558000 r-xp /usr/lib/libcrypto.so.1.0.0
f6578000 f65bf000 r-xp /usr/lib/libssl.so.1.0.0
f65cb000 f65cd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65d5000 f65dc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65e5000 f65ec000 r-xp /lib/libcrypt-2.13.so
f661d000 f6620000 r-xp /lib/libcap.so.2.21
f6628000 f662a000 r-xp /usr/lib/libiri.so
f6632000 f667b000 r-xp /usr/lib/libmdm.so.1.2.69
f6683000 f6689000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6691000 f66b4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66be000 f66c0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66c8000 f66e5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66ee000 f66f2000 r-xp /usr/lib/libsmack.so.1.0.0
f66fb000 f6714000 r-xp /usr/lib/libnetwork.so.0.0.0
f671d000 f6725000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f672d000 f6733000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f673c000 f673e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6747000 f6757000 r-xp /lib/libresolv-2.13.so
f675b000 f6773000 r-xp /usr/lib/liblzma.so.5.0.3
f677c000 f677e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6786000 f67a0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67a8000 f67d7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67e0000 f67ef000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67f9000 f6803000 r-xp /usr/lib/libsensord-shared.so
f680c000 f68df000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68ea000 f6900000 r-xp /lib/libz.so.1.2.5
f6908000 f690d000 r-xp /usr/lib/libffi.so.5.0.10
f6915000 f6916000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f691e000 f692e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6936000 f694f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6957000 f6959000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6961000 f69d6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69e0000 f69e6000 r-xp /lib/librt-2.13.so
f69ef000 f6a0d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a17000 f6a18000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a20000 f6a43000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a4b000 f6a50000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a58000 f6a82000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a8b000 f6aa2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aaa000 f6b13000 r-xp /lib/libm-2.13.so
f6b1c000 f6bb0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bc3000 f6bc8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bd0000 f6bd7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bdf000 f6c09000 r-xp /usr/lib/libsensor.so.1.9.6
f6c12000 f6cde000 r-xp /usr/lib/libxml2.so.2.7.8
f6ceb000 f6ced000 r-xp /usr/lib/libiniparser.so.0
f6cf6000 f6cfc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d05000 f6dd5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dd6000 f6e0a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e13000 f6e4f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e57000 f6e5a000 r-xp /usr/lib/libbundle.so.0.1.22
f6e62000 f6e68000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e70000 f6eb1000 r-xp /usr/lib/libeina.so.1.7.99
f6eba000 f6ed1000 r-xp /usr/lib/libecore.so.1.7.99
f6ee8000 f6ef1000 r-xp /usr/lib/libvconf.so.0.2.45
f6ef9000 f6f0d000 r-xp /lib/libpthread-2.13.so
f6f18000 f6f25000 r-xp /usr/lib/libaul.so.0.1.0
f6f2f000 f6f31000 r-xp /lib/libdl-2.13.so
f6f3a000 f6f45000 r-xp /lib/libunwind.so.8.0.1
f6f72000 f6f7a000 r-xp /lib/libgcc_s-4.6.so.1
f6f7b000 f709f000 r-xp /lib/libc-2.13.so
f70ad000 f70af000 r-xp /usr/lib/libdlog.so.0.0.0
f70b7000 f70c3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70cc000 f70d1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70d9000 f70e8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70f0000 f70f4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70fd000 f7100000 r-xp /usr/lib/libappcore-agent.so.1.1
f7108000 f710a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7112000 f7116000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f711e000 f713b000 r-xp /lib/ld-2.13.so
f7144000 f7147000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7147000 f714b000 r-xp /usr/lib/libsys-assert.so
f764d000 f76d8000 rw-p [heap]
ff831000 ff852000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5843)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7145228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70dc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6de33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6de1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dede57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6df3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6df3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e2875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e231f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6de1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dede57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6df3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6df3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e25e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e26017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e2a8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71140bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf47b8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf688b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d38fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d3a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ecaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ec5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ec65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ec6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70fe183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70fe7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71454f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f9285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7144f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.481+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.491+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:493,3.787838,-5.781059,7.221539
04-23 18:25:52.491+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:487,-0.910000,-0.280000,0.070000
04-23 18:25:52.501+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.501+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.511+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:505,0.770000,-0.210000,-0.140000
04-23 18:25:52.521+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.521+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:505,3.744767,-5.666204,7.269395
04-23 18:25:52.521+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.521+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:526,1.540000,-0.140000,-0.140000
04-23 18:25:52.531+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:527,3.780660,-5.654240,7.331609
04-23 18:25:52.531+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.531+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.541+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:541,3.756732,-5.544170,7.322037
04-23 18:25:52.541+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:540,1.540000,-0.420000,0.490000
04-23 18:25:52.551+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.551+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.551+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:556,-1.960000,-1.190000,0.980000
04-23 18:25:52.561+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:555,3.749553,-5.560920,7.288538
04-23 18:25:52.561+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.561+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.571+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:573,-2.940000,-1.470000,0.280000
04-23 18:25:52.571+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:574,3.737589,-5.647062,7.171289
04-23 18:25:52.581+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.581+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.581+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:52.591+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:52:592,88
04-23 18:25:52.591+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:591,0.210000,-1.260000,0.490000
04-23 18:25:52.591+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:592,3.833302,-5.685347,7.298109
04-23 18:25:52.601+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.601+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.601+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:610,-1.820000,0.350000,0.140000
04-23 18:25:52.621+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:608,3.708875,-5.668597,7.147361
04-23 18:25:52.621+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.621+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.621+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:629,-2.170000,1.050000,-0.210000
04-23 18:25:52.631+0200 W/LOCATION( 5843): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:25:52.631+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:628,3.785445,-5.783452,7.252645
04-23 18:25:52.631+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.631+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.631+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:639,0.210000,1.540000,0.140000
04-23 18:25:52.641+0200 W/LOCATION( 5843): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:25:52.651+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:639,3.744767,-5.637490,7.238289
04-23 18:25:52.651+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.651+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:656,0.350000,1.190000,-0.840000
04-23 18:25:52.661+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.671+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.671+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:669,3.802195,-5.714060,7.226324
04-23 18:25:52.681+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.681+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:687,3.723232,-5.529813,7.202396
04-23 18:25:52.681+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:680,1.400000,0.700000,0.280000
04-23 18:25:52.691+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.701+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:52.711+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:697,-0.210000,-0.420000,0.560000
04-23 18:25:52.751+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:52:712,3.756732,-5.649454,7.324430
04-23 18:25:52.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:52.821+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_create(453) > New handle created[0xf3c26ba8]
04-23 18:25:52.821+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 18:25:52.821+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 18:25:52.821+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 18:25:52.821+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:25:52.831+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:25:52.831+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:25:52.841+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:52.851+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:52.851+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:25:52.851+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:25:52.851+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:25:52.851+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:25:52.851+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:25:52.851+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:25:52.851+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:25:52.851+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:25:52.851+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:25:52.861+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:52.871+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:52.871+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:25:52.871+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:52.891+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:52.891+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:52:895,88
04-23 18:25:52.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:52.931+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:52.941+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:52.941+0200 E/LOCATION( 2317): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 18:25:52.941+0200 I/LOCATION( 2317): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 18:25:52.941+0200 I/LOCATION( 2317): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:25:52.981+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:52.981+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:52:978,-2.100000,0.280000,0.560000
04-23 18:25:52.981+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:52.991+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:52:993,88
04-23 18:25:52.991+0200 W/LOCATION( 5843): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:25:52.991+0200 I/LOCATION( 5843): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:25:52.991+0200 I/LOCATION( 5843): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:25:52.991+0200 I/location( 5843): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:25:52.991+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.001+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.001+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:1,3.718446,-5.687739,7.310073
04-23 18:25:53.011+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.011+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:11,-2.170000,-0.560000,0.630000
04-23 18:25:53.011+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:15,3.771089,-5.584848,7.188039
04-23 18:25:53.021+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.021+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:26,-1.400000,-0.700000,0.350000
04-23 18:25:53.031+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.031+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.031+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:35,3.708875,-5.718846,7.240681
04-23 18:25:53.031+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:39,0.490000,-1.050000,0.070000
04-23 18:25:53.031+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.051+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.051+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:44,3.797409,-5.726025,7.192825
04-23 18:25:53.051+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.061+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:64,3.809374,-5.644669,7.255038
04-23 18:25:53.071+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:56,1.400000,-0.420000,0.630000
04-23 18:25:53.071+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.071+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:75,0.700000,-0.210000,0.630000
04-23 18:25:53.081+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.081+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:87,3.775874,-5.649454,7.317252
04-23 18:25:53.081+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.091+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.091+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:96,3.780660,-5.663811,7.250252
04-23 18:25:53.101+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:91,0.700000,0.210000,0.420000
04-23 18:25:53.101+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.101+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.101+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:106,-0.770000,0.560000,0.140000
04-23 18:25:53.111+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.111+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:108,3.754339,-5.627919,7.183254
04-23 18:25:53.121+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:119,0.420000,0.490000,-0.070000
04-23 18:25:53.121+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.121+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:131,3.802195,-5.647062,7.276574
04-23 18:25:53.131+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.131+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:141,0.350000,1.050000,-0.070000
04-23 18:25:53.141+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.141+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:145,3.756732,-5.656632,7.243074
04-23 18:25:53.151+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.151+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:155,-0.140000,0.560000,0.350000
04-23 18:25:53.151+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.151+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:160,3.785445,-5.608776,7.281359
04-23 18:25:53.151+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.161+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.171+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:170,3.754339,-5.685347,7.245467
04-23 18:25:53.171+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:164,-0.630000,0.210000,0.140000
04-23 18:25:53.171+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.171+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:179,-0.840000,-0.140000,0.490000
04-23 18:25:53.171+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.181+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:184,3.739982,-5.592027,7.252645
04-23 18:25:53.181+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:53.191+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:53:193,87
04-23 18:25:53.191+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.191+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:197,-2.170000,-0.420000,0.350000
04-23 18:25:53.191+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.201+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.201+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:202,3.751946,-5.728417,7.267002
04-23 18:25:53.201+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.211+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:214,3.766303,-5.697310,7.197611
04-23 18:25:53.211+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:208,-1.050000,-0.350000,0.280000
04-23 18:25:53.221+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.221+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:227,-0.070000,-0.490000,0.560000
04-23 18:25:53.221+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.221+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:231,3.728018,-5.647062,7.214360
04-23 18:25:53.231+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.231+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:235,-0.770000,-0.210000,-0.420000
04-23 18:25:53.231+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.241+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:244,3.823731,-5.697310,7.286145
04-23 18:25:53.241+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.241+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:250,-1.820000,-1.330000,0.700000
04-23 18:25:53.241+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.251+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:254,3.694518,-5.548956,7.245467
04-23 18:25:53.251+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.261+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:264,-4.830000,-1.960000,-0.350000
04-23 18:25:53.261+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.261+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:269,3.797409,-5.625526,7.250252
04-23 18:25:53.271+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.271+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.281+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:275,-2.660000,-2.100000,0.070000
04-23 18:25:53.281+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:281,3.739982,-5.795416,7.219146
04-23 18:25:53.281+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.291+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.291+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:295,3.670590,-5.659025,7.357929
04-23 18:25:53.291+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:289,0.840000,-2.730000,0.840000
04-23 18:25:53.291+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.301+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:304,-3.570000,-1.470000,-0.910000
04-23 18:25:53.301+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.361+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:25:53.361+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,G)
04-23 18:25:53.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 18:25:53.371+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:25:53.371+0200 I/LOCATION( 5843): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:25:53.371+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.381+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:309,3.921836,-5.551349,7.245467
04-23 18:25:53.381+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:383,-6.580000,1.960000,-4.690000
04-23 18:25:53.381+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.381+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:53.391+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:53:393,87
04-23 18:25:53.401+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.401+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:405,-2.100000,-1.050000,1.680000
04-23 18:25:53.401+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:392,3.780660,-5.946165,7.128219
04-23 18:25:53.401+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.411+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.421+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:411,3.821337,-5.228317,7.245467
04-23 18:25:53.421+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.421+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:426,3.804588,-6.053841,7.030113
04-23 18:25:53.421+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:417,-12.180000,0.280000,-5.460000
04-23 18:25:53.421+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.431+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.431+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:438,3.878766,-5.816952,7.089933
04-23 18:25:53.431+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:432,-2.940000,-0.210000,-2.100000
04-23 18:25:53.431+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.451+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.451+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:455,3.857230,-5.493921,7.221539
04-23 18:25:53.451+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:443,0.210000,-1.610000,1.260000
04-23 18:25:53.451+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.451+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:460,-5.250000,-0.630000,-3.010000
04-23 18:25:53.451+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.461+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:464,3.869194,-5.994020,6.855437
04-23 18:25:53.461+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.471+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:470,4.410000,0.560000,-2.660000
04-23 18:25:53.471+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.471+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:479,3.890730,-6.032306,7.147361
04-23 18:25:53.471+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.481+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:483,3.430000,1.050000,0.280000
04-23 18:25:53.481+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.481+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:491,3.931407,-5.324030,7.365108
04-23 18:25:53.491+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.491+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:499,-5.530000,-0.840000,0.560000
04-23 18:25:53.491+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.501+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:504,3.802195,-5.670990,7.156933
04-23 18:25:53.501+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.511+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:513,-2.310000,-0.840000,0.420000
04-23 18:25:53.511+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.511+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:518,3.933800,-5.965307,7.125826
04-23 18:25:53.521+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.521+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:526,0.140000,-0.280000,2.170000
04-23 18:25:53.521+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.531+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:531,3.847659,-5.711668,7.128219
04-23 18:25:53.531+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.531+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:540,-0.070000,-1.820000,2.590000
04-23 18:25:53.541+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.541+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:549,3.780660,-5.682954,7.233503
04-23 18:25:53.541+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.551+0200 E/location( 5843): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:25:53.551+0200 W/AUL     ( 5843): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:25:53.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:25:53.551+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.551+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 5843
04-23 18:25:53.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5575
04-23 18:25:53.561+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.571+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:25:53.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(5575), cmd(0)
04-23 18:25:53.571+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:554,-3.080000,-0.560000,-0.770000
04-23 18:25:53.571+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.571+0200 W/AUL     ( 5843): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5575)
04-23 18:25:53.571+0200 I/location( 5843): request sent to service es.ugr.frailty.servicemanager
04-23 18:25:53.571+0200 W/CAPI_APPFW_APP_CONTROL( 5843): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.571+0200 I/utils   ( 5843): specific action
04-23 18:25:53.581+0200 I/utils   ( 5575): specific action
04-23 18:25:53.581+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:561,3.885944,-5.800202,7.006185
04-23 18:25:53.581+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:53.591+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.591+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.591+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.591+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:25:53.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:25:53.591+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 5575
04-23 18:25:53.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5582
04-23 18:25:53.601+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:25:53.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(5582), cmd(0)
04-23 18:25:53.601+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.601+0200 I/utils   ( 5582): specific action
04-23 18:25:53.601+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.601+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.601+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.601+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:53.601+0200 I/recorder( 5582): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:25:53.601+0200 I/recorder( 5582): guardando datos en local
04-23 18:25:53.611+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:53:593,87
04-23 18:25:53.611+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:580,2.660000,0.140000,-0.280000
04-23 18:25:53.611+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.621+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5582)
04-23 18:25:53.621+0200 I/servicemanager( 5575): request sent to service es.ugr.frailty.recorder
04-23 18:25:53.621+0200 I/servicemanager( 5575): requesting to save local data
04-23 18:25:53.621+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.621+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:627,0.630000,0.630000,0.140000
04-23 18:25:53.621+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:592,3.881158,-5.639884,7.190433
04-23 18:25:53.631+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.631+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:635,3.828516,-5.666204,7.204789
04-23 18:25:53.631+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.641+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:639,-1.330000,0.140000,0.280000
04-23 18:25:53.641+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.641+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:650,3.859623,-5.783452,7.188039
04-23 18:25:53.641+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.651+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:654,-0.350000,-0.070000,0.770000
04-23 18:25:53.651+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.661+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.661+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:664,3.792624,-5.757132,7.111469
04-23 18:25:53.661+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:667,-0.910000,-0.630000,-0.070000
04-23 18:25:53.671+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.671+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:675,3.835695,-5.783452,7.101898
04-23 18:25:53.681+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.681+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:685,0.770000,-0.630000,-0.910000
04-23 18:25:53.681+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.681+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:690,3.852444,-5.869594,7.149754
04-23 18:25:53.681+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.691+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:694,1.470000,-0.350000,0.350000
04-23 18:25:53.691+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.701+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:704,3.945765,-5.644669,7.142576
04-23 18:25:53.701+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.711+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.711+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:715,3.842873,-5.759524,7.149754
04-23 18:25:53.711+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:708,-0.210000,0.350000,0.350000
04-23 18:25:53.721+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.721+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:727,-0.560000,0.140000,0.560000
04-23 18:25:53.721+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.721+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:731,3.881158,-5.682954,7.152147
04-23 18:25:53.731+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.731+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:735,-0.770000,-0.560000,2.240000
04-23 18:25:53.731+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.781+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:53.791+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:53:794,87
04-23 18:25:53.791+0200 I/LOCATION( 5843): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:25:53.791+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.801+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:804,-3.500000,-0.140000,-0.560000
04-23 18:25:53.811+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:742,3.792624,-5.661418,7.298109
04-23 18:25:53.811+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.821+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.831+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:816,3.818945,-5.826523,6.989435
04-23 18:25:53.831+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:827,2.030000,-0.560000,0.910000
04-23 18:25:53.831+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.831+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.841+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:839,3.881158,-5.867201,7.113862
04-23 18:25:53.851+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.861+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:844,-0.840000,-0.420000,0.420000
04-23 18:25:53.861+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.861+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:856,3.871587,-5.603990,7.216753
04-23 18:25:53.881+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:53.881+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:53.891+0200 E/LOCATION( 2317): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 18:25:53.891+0200 I/LOCATION( 2317): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 18:25:53.891+0200 I/LOCATION( 2317): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:25:53.931+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.951+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:867,-1.610000,-0.770000,0.070000
04-23 18:25:53.951+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:25:53.961+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:936,3.902694,-5.819345,7.068398
04-23 18:25:53.961+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.971+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:53.971+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:972,0.630000,-0.350000,0.280000
04-23 18:25:53.981+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:53.981+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:53:987,1.190000,0.630000,0.210000
04-23 18:25:53.981+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:53.991+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:53:993,87
04-23 18:25:53.991+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:53:978,3.926622,-5.821737,7.082755
04-23 18:25:53.991+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.001+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.011+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:2,3.883551,-5.733203,7.133004
04-23 18:25:54.011+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:8,-0.700000,0.630000,0.630000
04-23 18:25:54.011+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.021+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.021+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:23,3.960121,-5.699703,7.192825
04-23 18:25:54.021+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:27,-0.910000,1.260000,0.910000
04-23 18:25:54.021+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.031+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.031+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:33,3.835695,-5.797810,7.171289
04-23 18:25:54.031+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:38,-0.560000,0.560000,1.190000
04-23 18:25:54.041+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.041+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:45,3.811767,-5.690133,7.183254
04-23 18:25:54.041+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.051+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:53,-2.380000,0.490000,0.770000
04-23 18:25:54.061+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.061+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.071+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:65,3.917051,-5.807381,7.135397
04-23 18:25:54.071+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.071+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:71,-1.820000,0.630000,0.420000
04-23 18:25:54.081+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.081+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:77,3.795017,-5.807381,7.049256
04-23 18:25:54.091+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.091+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:87,1.750000,-0.560000,1.890000
04-23 18:25:54.091+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:95,3.938586,-5.680561,7.226324
04-23 18:25:54.091+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.111+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.111+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:101,-2.940000,0.770000,-0.700000
04-23 18:25:54.111+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.121+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:115,3.885944,-5.886343,6.955935
04-23 18:25:54.121+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.131+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:133,3.900301,-5.864808,7.073184
04-23 18:25:54.131+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:123,3.710000,0.490000,-0.700000
04-23 18:25:54.141+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.141+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.161+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:145,1.540000,0.140000,-0.770000
04-23 18:25:54.161+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:152,3.905087,-5.563312,7.197611
04-23 18:25:54.161+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.161+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.161+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:171,3.804588,-5.606383,7.238289
04-23 18:25:54.171+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:168,-1.750000,-1.400000,0.980000
04-23 18:25:54.171+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.181+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.181+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:54.191+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:54:194,87
04-23 18:25:54.191+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:181,-6.020000,-0.420000,0.280000
04-23 18:25:54.191+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.191+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:185,3.917051,-5.587241,7.092326
04-23 18:25:54.201+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.211+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:199,-3.080000,-0.980000,-0.630000
04-23 18:25:54.211+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.211+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:208,3.847659,-6.108876,7.018148
04-23 18:25:54.211+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.231+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:224,4.000800,-5.816952,7.073184
04-23 18:25:54.231+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:221,-0.210000,0.980000,-0.490000
04-23 18:25:54.231+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.231+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.241+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:239,-0.700000,2.100000,-1.820000
04-23 18:25:54.241+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.251+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:242,3.826123,-5.819345,7.054041
04-23 18:25:54.251+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.251+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:260,3.909872,-5.618347,7.166504
04-23 18:25:54.361+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:25:54.361+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,G)
04-23 18:25:54.361+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 18:25:54.361+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:25:54.391+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:54.401+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:54:401,87
04-23 18:25:54.401+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:252,0.280000,1.400000,0.210000
04-23 18:25:54.401+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.401+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.411+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:408,-0.280000,1.190000,-0.350000
04-23 18:25:54.421+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.421+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:412,3.816552,-5.886343,6.948757
04-23 18:25:54.421+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.431+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:427,3.850000,1.050000,0.280000
04-23 18:25:54.431+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.431+0200 I/accelerometer( 5812): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:54:431,3.929015,-5.771489,7.166504
04-23 18:25:54.431+0200 I/accelerometer( 5812): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:54.441+0200 I/gyroscope( 5825): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:54:439,-0.350000,1.260000,-0.560000
04-23 18:25:54.441+0200 I/gyroscope( 5825): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:54.441+0200 W/CRASH_MANAGER( 5651): worker.c: worker_job(1205) > 11058436c6f63152450075
