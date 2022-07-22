S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5128
Date: 2018-06-14 12:15:27+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf744e52d, r5   = 0xf7981fe0
r6   = 0xfff35440, r7   = 0xfff352f0
r8   = 0xf7953c18, r9   = 0x00000000
r10  = 0xfff353cc, fp   = 0xfff35440
ip   = 0x00000001, sp   = 0xfff352c8
lr   = 0xf744e539, pc   = 0xf74b7270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     38900 KB
Buffers:     21836 KB
Cached:     115608 KB
VmPeak:      53444 KB
VmSize:      53428 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12100 KB
VmRSS:       12100 KB
VmData:      11156 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5128 TID = 5128
5128 5203 

Maps Information
f4319000 f4b18000 rw-p [stack:5203]
f4b1f000 f4b21000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b29000 f4b2d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b36000 f4b38000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b40000 f4b43000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b52000 f4b57000 r-xp /usr/lib/libsystem.so.0.0.0
f4b62000 f4b65000 r-xp /lib/libattr.so.1.1.0
f4b6d000 f4b7d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b85000 f4b8e000 r-xp /usr/lib/libedbus.so.1.7.99
f4b96000 f4b97000 r-xp /usr/lib/libresponse.so.0.2.96
f4ba0000 f4ba5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6447000 f654d000 r-xp /usr/lib/libicuuc.so.57.1
f6563000 f66eb000 r-xp /usr/lib/libicui18n.so.57.1
f66fb000 f6708000 r-xp /usr/lib/libail.so.0.1.0
f6711000 f6718000 r-xp /usr/lib/libminizip.so.1.0.0
f6721000 f68ca000 r-xp /usr/lib/libcrypto.so.1.0.0
f68ea000 f6931000 r-xp /usr/lib/libssl.so.1.0.0
f693d000 f693f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6947000 f694e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6957000 f695e000 r-xp /lib/libcrypt-2.13.so
f698f000 f6992000 r-xp /lib/libcap.so.2.21
f699a000 f699c000 r-xp /usr/lib/libiri.so
f69a4000 f69ed000 r-xp /usr/lib/libmdm.so.1.2.69
f69f5000 f69fb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a03000 f6a26000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a30000 f6a32000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a3a000 f6a57000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a60000 f6a64000 r-xp /usr/lib/libsmack.so.1.0.0
f6a6d000 f6a86000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a8f000 f6a97000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a9f000 f6aa5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6aae000 f6ab0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ab9000 f6ac9000 r-xp /lib/libresolv-2.13.so
f6acd000 f6ae5000 r-xp /usr/lib/liblzma.so.5.0.3
f6aee000 f6af0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6af8000 f6b12000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b1a000 f6b49000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b52000 f6b61000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b6b000 f6b75000 r-xp /usr/lib/libsensord-shared.so
f6b7e000 f6c51000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c5c000 f6c72000 r-xp /lib/libz.so.1.2.5
f6c7a000 f6c7f000 r-xp /usr/lib/libffi.so.5.0.10
f6c87000 f6c88000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c90000 f6ca0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ca8000 f6cc1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cc9000 f6ccb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cd3000 f6d48000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d52000 f6d70000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d7a000 f6d7b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d83000 f6da6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dae000 f6db3000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dbb000 f6de5000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dee000 f6e05000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e0d000 f6e13000 r-xp /lib/librt-2.13.so
f6e1c000 f6e85000 r-xp /lib/libm-2.13.so
f6e8e000 f6f22000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f35000 f6f3a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f42000 f6f49000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f51000 f6f7b000 r-xp /usr/lib/libsensor.so.1.9.6
f6f84000 f7050000 r-xp /usr/lib/libxml2.so.2.7.8
f705d000 f705f000 r-xp /usr/lib/libiniparser.so.0
f7068000 f706e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7077000 f7147000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7148000 f717c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7185000 f71c1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71c9000 f71cc000 r-xp /usr/lib/libbundle.so.0.1.22
f71d4000 f71da000 r-xp /usr/lib/libappsvc.so.0.1.0
f71e2000 f7223000 r-xp /usr/lib/libeina.so.1.7.99
f722c000 f7235000 r-xp /usr/lib/libvconf.so.0.2.45
f723d000 f7251000 r-xp /lib/libpthread-2.13.so
f725c000 f7269000 r-xp /usr/lib/libaul.so.0.1.0
f7273000 f7275000 r-xp /lib/libdl-2.13.so
f727e000 f7289000 r-xp /lib/libunwind.so.8.0.1
f72b6000 f72be000 r-xp /lib/libgcc_s-4.6.so.1
f72bf000 f73e3000 r-xp /lib/libc-2.13.so
f73f1000 f7408000 r-xp /usr/lib/libecore.so.1.7.99
f741f000 f7421000 r-xp /usr/lib/libdlog.so.0.0.0
f7429000 f7435000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f743e000 f7443000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f744b000 f745a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7462000 f7466000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f746f000 f7472000 r-xp /usr/lib/libappcore-agent.so.1.1
f747a000 f747c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7484000 f7488000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7490000 f74ad000 r-xp /lib/ld-2.13.so
f74b6000 f74b9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74b9000 f74bd000 r-xp /usr/lib/libsys-assert.so
f794d000 f79b9000 rw-p [heap]
fff16000 fff37000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5128)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74b7270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf744e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71553f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7153c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf715fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7165be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7165dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf719a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71951f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7153c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf715fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7165be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7165dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7197e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7198017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf719ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b371fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b2a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bfd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70aafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70ac7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7401ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73fcb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73fd5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73fd879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7470183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74707fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74b760b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf72d685c) [/lib/libc.so.6] + 0x1785c
29: (0xf74b6f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
M-R760,14/06/2018,12:15:26:630,-18.340000,-9.170000,2.240000
06-14 12:15:26.641+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.641+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:636,5.090270,-7.897780,2.807955
06-14 12:15:26.641+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:646,-34.650002,-5.040000,7.980000
06-14 12:15:26.641+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:641,0.663904,0.227911,-0.696344
06-14 12:15:26.651+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.651+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.661+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:659,5.757132,-7.951349,2.304288
06-14 12:15:26.661+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.661+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.661+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:660,5.051115,-7.959866,2.701325
06-14 12:15:26.661+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.661+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.671+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:674,4.943644,-8.050122,2.631787
06-14 12:15:26.671+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:668,-44.799999,-5.390000,11.270000
06-14 12:15:26.671+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.671+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:673,6.601797,-10.750952,4.115655
06-14 12:15:26.681+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:668,0.666862,-0.053569,-0.503667
06-14 12:15:26.681+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.681+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.681+0200 I/light   ( 5167): es.ugr.frailty.light - capturing data
06-14 12:15:26.681+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.691+0200 I/light   ( 5167): es.ugr.frailty.light: SM-R760,14/06/2018,12:15:26:693,335.000000
06-14 12:15:26.691+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:680,-43.750000,4.200000,29.540001
06-14 12:15:26.691+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.691+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:686,1.550682,-2.791086,1.414330
06-14 12:15:26.691+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.691+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:692,4.891559,-8.086548,2.617400
06-14 12:15:26.701+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:693,5.201996,-9.025726,3.077170
06-14 12:15:26.701+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:704,0.258353,-0.975604,0.445383
06-14 12:15:26.701+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:701,-13.160000,9.450000,12.670000
06-14 12:15:26.701+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.701+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.711+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:713,4.969893,-6.728617,2.596212
06-14 12:15:26.711+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:713,4.856281,-8.121456,2.574660
06-14 12:15:26.711+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.711+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.711+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:720,0.078333,1.357931,-0.021188
06-14 12:15:26.721+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:719,-27.230000,-1.190000,13.090000
06-14 12:15:26.721+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.721+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.721+0200 E/CAPI_APPFW_APP_CONTROL( 5128): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
06-14 12:15:26.721+0200 E/location( 5128): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
06-14 12:15:26.731+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:732,4.894772,-8.093935,2.588400
06-14 12:15:26.731+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:732,5.675776,-6.642475,3.086741
06-14 12:15:26.731+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.731+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.731+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:739,0.819495,1.478981,0.512081
06-14 12:15:26.741+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:738,-12.740000,-3.080000,5.810000
06-14 12:15:26.751+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.751+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.751+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.751+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:759,6.534799,-6.369694,4.003192
06-14 12:15:26.751+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:759,4.986714,-8.021742,2.637181
06-14 12:15:26.751+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.761+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:763,-16.520000,-4.970000,-7.420000
06-14 12:15:26.761+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:766,1.640027,1.724241,1.414792
06-14 12:15:26.761+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.761+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.771+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:773,4.977811,-8.025702,2.641945
06-14 12:15:26.771+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.771+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:773,5.458029,-7.953743,3.419343
06-14 12:15:26.771+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.771+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:778,-26.670000,14.910000,-11.060000
06-14 12:15:26.771+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:779,0.471314,0.067999,0.782163
06-14 12:15:26.781+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.781+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.791+0200 I/heartrate( 5119): es.ugr.frailty.heartrate - capturing data
06-14 12:15:26.791+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:793,4.524827,-8.360522,2.689533
06-14 12:15:26.791+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.801+0200 I/heartrate( 5119): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:15:26:796,88
06-14 12:15:26.801+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.801+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:804,-0.452984,-0.334820,0.047588
06-14 12:15:26.801+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:793,4.930725,-8.064487,2.611970
06-14 12:15:26.811+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.811+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.811+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:810,-33.389999,20.160000,-17.150000
06-14 12:15:26.811+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.821+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:817,4.915431,-8.067739,2.630687
06-14 12:15:26.821+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.831+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.831+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:818,4.843073,-7.417750,3.629912
06-14 12:15:26.831+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:822,-34.439999,18.270000,-16.870001
06-14 12:15:26.831+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.831+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.831+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:834,4.944973,-8.045839,2.642367
06-14 12:15:26.841+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:838,-0.087652,0.646736,1.017941
06-14 12:15:26.841+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:841,-10.360000,15.540000,-29.400000
06-14 12:15:26.841+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.841+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:841,4.453043,-7.027720,2.481357
06-14 12:15:26.851+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.851+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.851+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:859,4.958832,-8.025655,2.677544
06-14 12:15:26.851+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:859,4.893322,-8.044669,3.656233
06-14 12:15:26.851+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.861+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:853,-0.462388,1.040019,-0.149330
06-14 12:15:26.861+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.861+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.861+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.871+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:865,-20.160000,15.330000,-30.590000
06-14 12:15:26.871+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:867,-0.051650,0.001170,1.013866
06-14 12:15:26.871+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.871+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.871+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:872,4.955845,-8.016585,2.710045
06-14 12:15:26.871+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:872,4.266403,-8.133204,3.261417
06-14 12:15:26.881+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:879,-0.692429,-0.107550,0.583874
06-14 12:15:26.881+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:881,-19.040001,22.889999,-37.660000
06-14 12:15:26.881+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.881+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.881+0200 I/light   ( 5167): es.ugr.frailty.light - capturing data
06-14 12:15:26.891+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:894,3.897908,-8.896514,2.371287
06-14 12:15:26.891+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.891+0200 I/light   ( 5167): es.ugr.frailty.light: SM-R760,14/06/2018,12:15:26:894,296.000000
06-14 12:15:26.891+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:893,4.958714,-8.014237,2.711740
06-14 12:15:26.891+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.901+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:901,-1.057937,-0.879929,-0.338758
06-14 12:15:26.901+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:905,-9.940000,20.370001,-46.900002
06-14 12:15:26.901+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.901+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.911+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:913,4.983464,-7.986158,2.748953
06-14 12:15:26.911+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.911+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:913,4.074977,-10.140782,2.895315
06-14 12:15:26.911+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.911+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:918,1.610000,22.680000,-44.029999
06-14 12:15:26.921+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:920,-0.883738,-2.126545,0.183575
06-14 12:15:26.921+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.921+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.931+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:932,3.862016,-9.573684,2.938386
06-14 12:15:26.931+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.931+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:932,4.978491,-7.968229,2.809331
06-14 12:15:26.931+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.931+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:938,-1.121448,-1.587525,0.189433
06-14 12:15:26.941+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:941,9.310000,29.889999,-44.520000
06-14 12:15:26.951+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.951+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.951+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:960,4.419543,-11.693724,3.012564
06-14 12:15:26.961+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:959,4.970477,-7.961082,2.843575
06-14 12:15:26.961+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.961+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.961+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.961+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.971+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:966,-0.558948,-3.725495,0.203233
06-14 12:15:26.971+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.971+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:967,5.110000,27.790001,-27.860001
06-14 12:15:26.971+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:972,4.986470,-7.981307,2.757580
06-14 12:15:26.971+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:26.971+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:26:978,-1.484135,-3.756572,-4.099807
06-14 12:15:26.971+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:972,3.486342,-11.717653,-1.256232
06-14 12:15:26.981+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:26:983,11.620000,4.760000,-17.920000
06-14 12:15:26.981+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:26.991+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:26.991+0200 I/heartrate( 5119): es.ugr.frailty.heartrate - capturing data
06-14 12:15:26.991+0200 I/heartrate( 5119): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:15:26:996,88
06-14 12:15:26.991+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:26.991+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:26:996,3.594020,-8.432307,4.529613
06-14 12:15:27.001+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:26:994,4.912856,-7.991345,2.858782
06-14 12:15:27.001+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.001+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:1,-1.392450,-0.451001,1.772033
06-14 12:15:27.001+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:7,-12.250000,38.500000,-18.690001
06-14 12:15:27.011+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.011+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:16,4.876615,-8.033920,2.800919
06-14 12:15:27.021+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.021+0200 W/libgps_d( 3118): OnGpsExtensionMessage: message_id(1), data(0xf78e2f38), size(2752)
06-14 12:15:27.021+0200 W/libgps_d( 3118): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-14 12:15:27.021+0200 W/libgps  ( 3118): proxy__gps_sv_status_cb : called
06-14 12:15:27.031+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.031+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:36,4.800752,-8.106178,2.722689
06-14 12:15:27.041+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.041+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:37,3.177669,-10.753345,1.067199
06-14 12:15:27.041+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.041+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.051+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:46,-8.470000,6.930000,-10.290000
06-14 12:15:27.051+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.051+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:51,-1.735188,-2.762001,-1.791583
06-14 12:15:27.051+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.061+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.061+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:61,4.783688,-8.135345,2.665123
06-14 12:15:27.061+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:52,4.024727,-10.186246,2.007578
06-14 12:15:27.061+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.071+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.071+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:64,-0.851887,-2.152326,-0.793341
06-14 12:15:27.071+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.071+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:67,-25.129999,-1.890000,12.880000
06-14 12:15:27.071+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.081+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:75,4.832409,-8.078100,2.750001
06-14 12:15:27.081+0200 I/light   ( 5167): es.ugr.frailty.light - capturing data
06-14 12:15:27.081+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.091+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:78,4.043870,-8.372486,1.256232
06-14 12:15:27.091+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.091+0200 I/light   ( 5167): es.ugr.frailty.light: SM-R760,14/06/2018,12:15:27:93,251.000000
06-14 12:15:27.091+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:83,9.450000,1.330000,0.560000
06-14 12:15:27.091+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.091+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:80,-0.756881,-0.266308,-1.466457
06-14 12:15:27.101+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.101+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:100,5.544170,-7.377072,3.457629
06-14 12:15:27.101+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:94,4.944018,-7.973271,2.855524
06-14 12:15:27.101+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.101+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:102,24.430000,5.740000,5.040000
06-14 12:15:27.101+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.111+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:105,0.760483,0.758272,0.792506
06-14 12:15:27.111+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.111+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.111+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:114,5.004405,-7.912357,2.919062
06-14 12:15:27.111+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:110,6.044270,-6.570691,3.055635
06-14 12:15:27.121+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.121+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.131+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:134,4.979994,-7.927423,2.919933
06-14 12:15:27.131+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:127,5.984450,-7.460821,3.129812
06-14 12:15:27.131+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.131+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:119,39.900002,8.820000,-6.720000
06-14 12:15:27.141+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:116,1.211860,1.507410,0.305634
06-14 12:15:27.141+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:143,5.158926,-8.185846,2.816352
06-14 12:15:27.141+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.141+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.151+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.151+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:152,1.040432,0.512450,0.274288
06-14 12:15:27.151+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.151+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:160,4.922793,-7.960452,2.927064
06-14 12:15:27.161+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.161+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:150,19.600000,17.150000,-9.800000
06-14 12:15:27.161+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.161+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.161+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:166,4.936393,-8.934800,3.359523
06-14 12:15:27.171+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.171+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:173,4.899835,-7.972363,2.933159
06-14 12:15:27.171+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:169,-8.120000,24.360001,-3.010000
06-14 12:15:27.171+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.171+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:163,0.154521,-0.273489,-0.102710
06-14 12:15:27.171+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.181+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:176,4.957928,-8.236095,2.593820
06-14 12:15:27.181+0200 I/heartrate( 5119): es.ugr.frailty.heartrate - capturing data
06-14 12:15:27.181+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.191+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:184,-0.043601,-1.007377,0.439590
06-14 12:15:27.191+0200 I/heartrate( 5119): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:15:27:193,88
06-14 12:15:27.191+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.191+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:195,4.930965,-7.940472,2.967300
06-14 12:15:27.191+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.201+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:180,-14.700000,26.320000,-0.560000
06-14 12:15:27.201+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.201+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:199,5.637490,-7.405786,2.837888
06-14 12:15:27.201+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:207,2.730000,23.450001,1.120000
06-14 12:15:27.201+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.211+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.211+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.211+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:203,0.035135,-0.275644,-0.333245
06-14 12:15:27.211+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:216,4.957587,-7.929439,2.952408
06-14 12:15:27.221+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:217,5.718846,-7.585248,2.199004
06-14 12:15:27.221+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.221+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.221+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.231+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:214,12.390000,16.870001,-0.420000
06-14 12:15:27.231+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.231+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:233,5.862415,-7.661818,2.825923
06-14 12:15:27.231+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:229,0.737655,0.566577,-0.095271
06-14 12:15:27.231+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:233,4.982667,-7.908432,2.966500
06-14 12:15:27.231+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:236,5.740000,12.600000,0.210000
06-14 12:15:27.231+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.231+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.241+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:243,4.690000,15.190001,-0.980000
06-14 12:15:27.241+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:244,0.787881,0.355225,-0.768296
06-14 12:15:27.241+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.241+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:250,0.904828,0.267621,-0.126484
06-14 12:15:27.251+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.251+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.251+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:259,4.997346,-7.906878,2.945878
06-14 12:15:27.251+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.251+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:260,5.642276,-7.812566,2.414358
06-14 12:15:27.261+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.261+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:264,-1.260000,9.940000,-0.630000
06-14 12:15:27.261+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:266,0.659609,0.095866,-0.552142
06-14 12:15:27.261+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.261+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.271+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:272,5.009763,-7.899704,2.944034
06-14 12:15:27.271+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.271+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:273,5.656632,-7.625926,2.880959
06-14 12:15:27.271+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.271+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:277,-3.360000,8.400000,1.610000
06-14 12:15:27.271+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:278,0.659286,0.280952,-0.064919
06-14 12:15:27.281+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.291+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:294,5.014791,-7.890769,2.959396
06-14 12:15:27.291+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.291+0200 I/light   ( 5167): es.ugr.frailty.light - capturing data
06-14 12:15:27.291+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.301+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:299,-0.350000,4.200000,3.500000
06-14 12:15:27.301+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:305,5.503492,-7.831708,3.311667
06-14 12:15:27.301+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.301+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.301+0200 W/LOCATION( 5128): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-14 12:15:27.311+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:313,5.023043,-7.875290,2.986508
06-14 12:15:27.311+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.311+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:318,2.800000,4.060000,7.280000
06-14 12:15:27.311+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.311+0200 I/light   ( 5167): es.ugr.frailty.light: SM-R760,14/06/2018,12:15:27:303,270.000000
06-14 12:15:27.321+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:310,0.493729,0.067996,0.367633
06-14 12:15:27.321+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.321+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:323,5.460421,-7.432107,3.383451
06-14 12:15:27.321+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:327,0.445630,0.458662,0.424055
06-14 12:15:27.321+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.321+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.331+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.331+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:336,1.120000,1.540000,10.640000
06-14 12:15:27.331+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:332,5.023067,-7.868284,3.004877
06-14 12:15:27.331+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:333,0.468484,0.268507,0.430443
06-14 12:15:27.331+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.341+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:342,5.491528,-7.606783,3.416951
06-14 12:15:27.351+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.351+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.351+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:359,0.552209,0.409855,0.385753
06-14 12:15:27.351+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.361+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.361+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:364,-2.380000,-4.480000,11.480000
06-14 12:15:27.361+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:360,5.030085,-7.861258,3.011520
06-14 12:15:27.361+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:366,5.575277,-7.458428,3.390630
06-14 12:15:27.361+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.361+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.371+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.371+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:373,0.351374,0.316688,0.237933
06-14 12:15:27.371+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:374,5.022281,-7.868208,3.006390
06-14 12:15:27.371+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:376,-5.250000,-4.550000,14.210000
06-14 12:15:27.371+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.381+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:385,5.381458,-7.544570,3.249453
06-14 12:15:27.381+0200 I/heartrate( 5119): es.ugr.frailty.heartrate - capturing data
06-14 12:15:27.381+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.381+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.391+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.391+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:394,5.018282,-7.879178,2.984257
06-14 12:15:27.391+0200 I/heartrate( 5119): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:15:27:393,89
06-14 12:15:27.391+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:394,0.342428,0.282960,-0.130218
06-14 12:15:27.391+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.391+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:397,-5.180000,-5.670000,13.020000
06-14 12:15:27.401+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:404,5.364708,-7.585248,2.876173
06-14 12:15:27.401+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.401+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.411+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.411+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:414,0.329677,-0.459809,0.049842
06-14 12:15:27.411+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.411+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:418,5.347959,-8.338986,3.034099
06-14 12:15:27.411+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:414,4.996151,-7.904067,2.955434
06-14 12:15:27.411+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:418,-7.630000,-7.420000,14.070000
06-14 12:15:27.421+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.421+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.431+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.431+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.431+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:436,-0.047794,-0.360743,-0.548254
06-14 12:15:27.431+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:433,4.948357,-8.264810,2.407180
06-14 12:15:27.431+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:433,4.962139,-7.945136,2.902134
06-14 12:15:27.431+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:436,-7.770000,-7.840000,17.219999
06-14 12:15:27.451+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.451+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.451+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:460,5.032106,-7.956135,2.974278
06-14 12:15:27.451+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:460,4.925175,-7.980935,2.866656
06-14 12:15:27.451+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.451+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.461+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:464,0.069968,-0.010999,0.072145
06-14 12:15:27.461+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:464,-12.740000,-11.970000,22.120001
06-14 12:15:27.461+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.461+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.471+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.471+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.471+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:475,0.090181,0.347831,-0.162766
06-14 12:15:27.471+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:473,5.015356,-7.633104,2.703890
06-14 12:15:27.471+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:473,4.888371,-8.022306,2.813684
06-14 12:15:27.471+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:476,-17.639999,-14.560000,25.690001
06-14 12:15:27.481+0200 I/light   ( 5167): es.ugr.frailty.light - capturing data
06-14 12:15:27.481+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.491+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.491+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:494,4.838035,-8.082122,2.728206
06-14 12:15:27.491+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.491+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:496,5.144568,-8.126025,2.474179
06-14 12:15:27.491+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.491+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:499,-26.880001,-17.850000,27.860001
06-14 12:15:27.491+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:500,0.256197,-0.103719,-0.339505
06-14 12:15:27.501+0200 I/light   ( 5167): es.ugr.frailty.light: SM-R760,14/06/2018,12:15:27:494,315.000000
06-14 12:15:27.501+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.501+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.501+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.501+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.511+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:515,-29.330000,-20.020000,27.090000
06-14 12:15:27.511+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:513,4.783397,-8.145778,2.633591
06-14 12:15:27.511+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:516,5.146961,-8.463413,2.376073
06-14 12:15:27.511+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:513,0.308926,-0.381291,-0.352133
06-14 12:15:27.521+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.521+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.521+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.531+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.531+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:536,-22.960001,-18.410000,24.219999
06-14 12:15:27.531+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:533,4.733979,-8.195451,2.567960
06-14 12:15:27.531+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:536,5.067998,-8.590233,2.663212
06-14 12:15:27.531+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:533,0.284601,-0.444455,0.029621
06-14 12:15:27.551+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.551+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.551+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.561+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.561+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:565,4.697111,-8.743374,2.340181
06-14 12:15:27.561+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:565,-19.180000,-24.360001,23.030001
06-14 12:15:27.561+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:561,4.684429,-8.246636,2.493893
06-14 12:15:27.561+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.561+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.571+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:574,-13.230000,-23.730000,25.340000
06-14 12:15:27.571+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:565,-0.036868,-0.547923,-0.227779
06-14 12:15:27.571+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer - capturing data
06-14 12:15:27.571+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration - capturing data
06-14 12:15:27.581+0200 I/linearacceleration( 5135): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:15:27:584,0.201715,-0.530237,0.116676
06-14 12:15:27.581+0200 I/accelerometer( 5096): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:15:27:581,4.886144,-8.776874,2.610569
06-14 12:15:27.581+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:573,4.643301,-8.284823,2.443737
06-14 12:15:27.581+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope - capturing data
06-14 12:15:27.591+0200 I/heartrate( 5119): es.ugr.frailty.heartrate - capturing data
06-14 12:15:27.591+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.591+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:599,4.633892,-8.307592,2.383557
06-14 12:15:27.601+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.611+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:615,4.613730,-8.340072,2.308046
06-14 12:15:27.631+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.631+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:639,4.596274,-8.372952,2.222232
06-14 12:15:27.651+0200 W/libgps_d( 3118): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-14 12:15:27.651+0200 W/libgps  ( 3118): [proxy__gps_stop][line = 1067]: called.
06-14 12:15:27.651+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-14 12:15:27.651+0200 W/libgps_d( 3118): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-14 12:15:27.651+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-14 12:15:27.651+0200 W/libgps_d( 3118): GpsiHookStateGps              : EXIT
06-14 12:15:27.651+0200 W/libgps_d( 3118): GpsiHookStateIdle             : ENTRY
06-14 12:15:27.651+0200 E/CAPI_LOCATION_MANAGER( 5204): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-14 12:15:27.651+0200 W/gpsd    ( 3090): HandleIncomingMessage() dest id:0, msg id:2
06-14 12:15:27.661+0200 I/heartrate( 5119): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:15:27:598,89
06-14 12:15:27.661+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.671+0200 I/SECURE_STORAGE( 2511): ss_server_ipc.c: SsServerComm(251) > write succeed
06-14 12:15:27.671+0200 W/AUL     ( 5233): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-14 12:15:27.671+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 23
06-14 12:15:27.671+0200 W/AUL_AMD ( 2477): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-14 12:15:27.671+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 4749
06-14 12:15:27.671+0200 W/AUL_AMD ( 2477): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-14 12:15:27.671+0200 I/AUL_AMD ( 2477): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4749
06-14 12:15:27.671+0200 W/AUL     ( 2477): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4749)
06-14 12:15:27.681+0200 I/gravity ( 5148): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:15:27:672,4.572585,-8.407224,2.140198
06-14 12:15:27.681+0200 I/gravity ( 5148): es.ugr.frailty.gravity - capturing data
06-14 12:15:27.701+0200 I/gyroscope( 5098): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:15:27:595,-10.500000,-28.490000,21.280001
06-14 12:15:27.711+0200 I/light   ( 5167): es.ugr.frailty.light - capturing data
06-14 12:15:27.711+0200 W/CRASH_MANAGER( 5231): worker.c: worker_job(1205) > 11051286c6f63152897132
