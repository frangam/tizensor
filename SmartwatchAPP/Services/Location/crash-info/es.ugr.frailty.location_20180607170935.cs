S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16868
Date: 2018-06-07 17:09:35+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6f8c52d, r5   = 0xf759df98
r6   = 0xffc92d60, r7   = 0xffc92c10
r8   = 0xf759ac18, r9   = 0x00000000
r10  = 0xffc92cec, fp   = 0xffc92d60
ip   = 0x00000001, sp   = 0xffc92be8
lr   = 0xf6f8c539, pc   = 0xf6ff5228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    190928 KB
Buffers:     10564 KB
Cached:      60112 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11576 KB
VmRSS:       11572 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16868 TID = 16868
16868 16872 

Maps Information
f3e57000 f4656000 rw-p [stack:16872]
f465d000 f465f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4667000 f466b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4674000 f4676000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f467e000 f4681000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4690000 f4695000 r-xp /usr/lib/libsystem.so.0.0.0
f46a0000 f46a3000 r-xp /lib/libattr.so.1.1.0
f46ab000 f46bb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46c3000 f46cc000 r-xp /usr/lib/libedbus.so.1.7.99
f46d4000 f46d5000 r-xp /usr/lib/libresponse.so.0.2.96
f46de000 f46e3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5f85000 f608b000 r-xp /usr/lib/libicuuc.so.57.1
f60a1000 f6229000 r-xp /usr/lib/libicui18n.so.57.1
f6239000 f6246000 r-xp /usr/lib/libail.so.0.1.0
f624f000 f6256000 r-xp /usr/lib/libminizip.so.1.0.0
f625f000 f6408000 r-xp /usr/lib/libcrypto.so.1.0.0
f6428000 f646f000 r-xp /usr/lib/libssl.so.1.0.0
f647b000 f647d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6485000 f648c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6495000 f649c000 r-xp /lib/libcrypt-2.13.so
f64cd000 f64d0000 r-xp /lib/libcap.so.2.21
f64d8000 f64da000 r-xp /usr/lib/libiri.so
f64e2000 f652b000 r-xp /usr/lib/libmdm.so.1.2.69
f6533000 f6539000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6541000 f6564000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f656e000 f6570000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6578000 f6595000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f659e000 f65a2000 r-xp /usr/lib/libsmack.so.1.0.0
f65ab000 f65c4000 r-xp /usr/lib/libnetwork.so.0.0.0
f65cd000 f65d5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f65dd000 f65e3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f65ec000 f65ee000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f65f7000 f6607000 r-xp /lib/libresolv-2.13.so
f660b000 f6623000 r-xp /usr/lib/liblzma.so.5.0.3
f662c000 f662e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6636000 f6650000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6658000 f6687000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6690000 f669f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66a9000 f66b3000 r-xp /usr/lib/libsensord-shared.so
f66bc000 f678f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f679a000 f67b0000 r-xp /lib/libz.so.1.2.5
f67b8000 f67bd000 r-xp /usr/lib/libffi.so.5.0.10
f67c5000 f67c6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67ce000 f67de000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f67e6000 f67ff000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6807000 f6809000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6811000 f6886000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6890000 f6896000 r-xp /lib/librt-2.13.so
f689f000 f68bd000 r-xp /usr/lib/libsystemd.so.0.4.0
f68c7000 f68c8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68d0000 f68f3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f68fb000 f6900000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6908000 f6932000 r-xp /usr/lib/libdbus-1.so.3.8.12
f693b000 f6952000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f695a000 f69c3000 r-xp /lib/libm-2.13.so
f69cc000 f6a60000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a73000 f6a78000 r-xp /usr/lib/libctx-client.so.0.8.3
f6a80000 f6a87000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6a8f000 f6ab9000 r-xp /usr/lib/libsensor.so.1.9.6
f6ac2000 f6b8e000 r-xp /usr/lib/libxml2.so.2.7.8
f6b9b000 f6b9d000 r-xp /usr/lib/libiniparser.so.0
f6ba6000 f6bac000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bb5000 f6c85000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c86000 f6cba000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cc3000 f6cff000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d07000 f6d0a000 r-xp /usr/lib/libbundle.so.0.1.22
f6d12000 f6d18000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d20000 f6d61000 r-xp /usr/lib/libeina.so.1.7.99
f6d6a000 f6d81000 r-xp /usr/lib/libecore.so.1.7.99
f6d98000 f6da1000 r-xp /usr/lib/libvconf.so.0.2.45
f6da9000 f6dbd000 r-xp /lib/libpthread-2.13.so
f6dc8000 f6dd5000 r-xp /usr/lib/libaul.so.0.1.0
f6ddf000 f6de1000 r-xp /lib/libdl-2.13.so
f6dea000 f6df5000 r-xp /lib/libunwind.so.8.0.1
f6e22000 f6e2a000 r-xp /lib/libgcc_s-4.6.so.1
f6e2b000 f6f4f000 r-xp /lib/libc-2.13.so
f6f5d000 f6f5f000 r-xp /usr/lib/libdlog.so.0.0.0
f6f67000 f6f73000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f7c000 f6f81000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6f89000 f6f98000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fa0000 f6fa4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fad000 f6fb0000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fb8000 f6fba000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fc2000 f6fc6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6fce000 f6feb000 r-xp /lib/ld-2.13.so
f6ff4000 f6ff7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f6ff7000 f6ffb000 r-xp /usr/lib/libsys-assert.so
f756a000 f75db000 rw-p [heap]
ffc74000 ffc95000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16868)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf6ff5228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6f8c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6c933f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6c91c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6c9de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ca3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ca3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cd875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6cd31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6c91c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6c9de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ca3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ca3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6cd5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cd6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6cddf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46751fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4668171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf673b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6be8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6bea7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6d7aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d75b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d765a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d76879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fae183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fae7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf6ff55c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6e4285c) [/lib/libc.so.6] + 0x1785c
29: (0xf6ff4f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
nt
06-07 17:09:34.611+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16778), cmd(0)
06-07 17:09:34.611+0200 W/CAPI_APPFW_APP_CONTROL(16778): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:09:34.611+0200 I/utils   (16778): specific action
06-07 17:09:34.611+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.621+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:611,-0.560000,0.280000,0.280000
06-07 17:09:34.621+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.631+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:620,-0.547956,-1.406980,9.707682
06-07 17:09:34.631+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.631+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:34.631+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:593,0.069164,-0.210054,-0.153605
06-07 17:09:34.631+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:602,-0.440554,-1.734163,9.642042
06-07 17:09:34.641+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.641+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:630,-0.210000,0.490000,0.280000
06-07 17:09:34.641+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.641+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.641+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:34:640,81
06-07 17:09:34.651+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:646,0.230609,-0.259817,-0.048372
06-07 17:09:34.651+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:654,-0.422603,-1.796933,9.631346
06-07 17:09:34.651+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.651+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:662,-0.396260,-1.844882,9.623397
06-07 17:09:34.661+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:638,-0.540778,-1.471586,9.724431
06-07 17:09:34.661+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.661+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.661+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:650,0.420000,0.350000,0.140000
06-07 17:09:34.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:670,0.185344,0.023313,0.012829
06-07 17:09:34.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:678,0.036735,-0.200154,-0.149056
06-07 17:09:34.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.681+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.681+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:668,-0.526421,-1.495514,9.767502
06-07 17:09:34.691+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.691+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:696,-0.559920,-1.500300,9.700503
06-07 17:09:34.691+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.691+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:700,-0.524028,-1.438086,9.719646
06-07 17:09:34.691+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.701+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.701+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:707,-0.393299,-1.886246,9.615497
06-07 17:09:34.701+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.701+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:687,1.050000,0.210000,0.070000
06-07 17:09:34.701+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.711+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:682,0.112238,-0.669645,-0.003178
06-07 17:09:34.711+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.711+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:717,0.296985,-0.730444,-0.022895
06-07 17:09:34.711+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.711+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:713,0.770000,-0.140000,-0.140000
06-07 17:09:34.711+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.711+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:721,0.487209,-0.849529,0.042836
06-07 17:09:34.711+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.721+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:711,-0.400874,-1.945959,9.603277
06-07 17:09:34.721+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.721+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:728,-0.396353,-1.998660,9.592635
06-07 17:09:34.721+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.721+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:724,0.490000,0.070000,-0.140000
06-07 17:09:34.731+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:705,-0.516850,-1.442872,9.726824
06-07 17:09:34.731+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.731+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.731+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:738,-0.586242,-1.466800,9.755538
06-07 17:09:34.731+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.741+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:739,-0.070000,-0.070000,0.070000
06-07 17:09:34.741+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.741+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:732,-0.401743,-2.054777,9.580547
06-07 17:09:34.741+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.741+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:749,-0.350000,-0.070000,0.070000
06-07 17:09:34.741+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:750,-0.396806,-2.089202,9.573305
06-07 17:09:34.741+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.751+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:725,0.018194,-0.452228,-0.054500
06-07 17:09:34.751+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.751+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.751+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:760,-0.154657,-0.367793,0.051507
06-07 17:09:34.751+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.761+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:743,-0.581456,-1.512264,9.722038
06-07 17:09:34.761+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.761+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:768,-0.550349,-1.521835,9.671788
06-07 17:09:34.761+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:763,0.070000,-0.280000,0.070000
06-07 17:09:34.761+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.761+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:754,-0.382700,-2.118640,9.567408
06-07 17:09:34.771+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:764,0.056307,-0.439685,0.264723
06-07 17:09:34.771+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.771+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:774,0.700000,0.140000,0.070000
06-07 17:09:34.771+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:778,-0.106139,-0.470733,0.043262
06-07 17:09:34.771+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.781+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.781+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.781+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:786,1.470000,0.560000,0.140000
06-07 17:09:34.781+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:787,-0.478565,-1.483550,9.714860
06-07 17:09:34.781+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.781+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:791,-0.376036,-2.151586,9.560317
06-07 17:09:34.791+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.791+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:34.791+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:796,-0.370120,-2.157767,9.559155
06-07 17:09:34.791+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.791+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.791+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:34:797,519.000000
06-07 17:09:34.801+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:782,-0.064857,-0.524686,-0.078649
06-07 17:09:34.801+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.811+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:802,-0.524028,-1.500300,9.748360
06-07 17:09:34.811+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.821+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.831+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:34.851+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:34:848,81
06-07 17:09:34.871+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:807,0.231702,-0.602724,-0.090549
06-07 17:09:34.871+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.871+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:800,-0.355831,-2.143425,9.562923
06-07 17:09:34.871+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.881+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:873,-0.512064,-1.392623,9.700503
06-07 17:09:34.881+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.881+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:839,1.400000,0.280000,0.140000
06-07 17:09:34.891+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:884,-0.345794,-2.138483,9.564398
06-07 17:09:34.891+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.891+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.891+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:882,0.205631,-0.776675,0.046954
06-07 17:09:34.891+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.901+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:898,0.140000,0.280000,0.280000
06-07 17:09:34.901+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:889,-0.514457,-1.371087,9.698111
06-07 17:09:34.901+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.911+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:902,0.093683,-0.609731,0.075580
06-07 17:09:34.921+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:914,-0.770000,0.070000,0.770000
06-07 17:09:34.921+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.921+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.921+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.931+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:899,-0.341204,-2.136624,9.564978
06-07 17:09:34.931+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.931+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:928,-1.890000,-0.840000,0.280000
06-07 17:09:34.931+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.931+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:935,0.260050,-0.476731,0.100671
06-07 17:09:34.931+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.941+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:928,-0.418744,-1.428515,9.616754
06-07 17:09:34.941+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:944,-2.100000,-0.770000,0.140000
06-07 17:09:34.941+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:939,-0.341407,-2.137452,9.564786
06-07 17:09:34.951+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.951+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.961+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:34.971+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:944,0.245761,-0.381002,-0.025132
06-07 17:09:34.971+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:34.971+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:957,-0.533599,-1.433301,9.772287
06-07 17:09:34.971+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:34.981+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:961,-1.820000,0.140000,0.350000
06-07 17:09:34.981+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:34.991+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:34.991+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:34:974,-0.342821,-2.131255,9.566118
06-07 17:09:34.991+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:34:996,534.000000
06-07 17:09:34.991+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:34:984,-0.547956,-1.497907,9.781858
06-07 17:09:34.991+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.001+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:34:979,0.142405,-0.436194,-0.021821
06-07 17:09:35.001+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.001+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:34:988,-0.350000,0.210000,0.280000
06-07 17:09:35.001+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.011+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.011+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:5,-0.341497,-2.114530,9.569876
06-07 17:09:35.021+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:16,-0.588634,-1.550549,9.815358
06-07 17:09:35.021+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:7,0.085172,-0.488302,-0.003259
06-07 17:09:35.021+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.021+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.031+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:11,0.490000,0.280000,0.280000
06-07 17:09:35.031+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.031+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:35.041+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:32,0.090161,-0.489868,0.016076
06-07 17:09:35.041+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.041+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:49,0.038933,-0.429066,-0.191039
06-07 17:09:35.041+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.041+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:35:44,81
06-07 17:09:35.051+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:09:35.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:09:35.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:09:35.071+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:35,-0.332052,-2.091947,9.575171
06-07 17:09:35.071+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.071+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:77,-0.330589,-2.084256,9.576898
06-07 17:09:35.071+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:56,-0.533599,-1.557728,9.731609
06-07 17:09:35.081+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:40,0.840000,0.280000,0.140000
06-07 17:09:35.081+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.081+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:87,0.630000,-1.260000,-0.210000
06-07 17:09:35.081+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.091+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.101+0200 W/LOCATION(16868): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:09:35.111+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:105,-0.524028,-1.488336,9.621540
06-07 17:09:35.111+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.111+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.111+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:120,-0.334312,-2.073714,9.579057
06-07 17:09:35.121+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:53,0.193142,-0.390755,-0.015335
06-07 17:09:35.121+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.121+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:91,-0.700000,-0.560000,-0.420000
06-07 17:09:35.121+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.131+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.131+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:139,-0.334254,-2.048154,9.584557
06-07 17:09:35.131+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.141+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:135,-3.430000,-0.210000,0.280000
06-07 17:09:35.141+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:119,-0.445065,-1.447658,9.647861
06-07 17:09:35.141+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.141+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:151,-0.466600,-1.459622,9.707682
06-07 17:09:35.151+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:129,0.128662,-0.286519,0.015263
06-07 17:09:35.151+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.151+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.161+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:143,-0.327926,-2.022368,9.590249
06-07 17:09:35.161+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.161+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:156,0.000379,-0.253531,-0.055856
06-07 17:09:35.161+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:157,-2.030000,-0.980000,0.630000
06-07 17:09:35.161+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.161+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.161+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.171+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:171,-0.630000,-1.680000,0.070000
06-07 17:09:35.171+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.171+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:173,-0.015040,-0.165968,0.006590
06-07 17:09:35.181+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:172,-0.524028,-1.445265,9.719646
06-07 17:09:35.181+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:167,-0.328943,-2.014846,9.591797
06-07 17:09:35.181+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.181+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.181+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.191+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:35.191+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:195,-0.528814,-1.450050,9.796216
06-07 17:09:35.191+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:35:200,544.000000
06-07 17:09:35.191+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:194,0.114114,0.004683,0.092018
06-07 17:09:35.201+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:195,-3.150000,-2.100000,-0.070000
06-07 17:09:35.201+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.201+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:191,-0.330545,-2.006933,9.593401
06-07 17:09:35.201+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.211+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.211+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:216,0.036001,-0.025888,0.088718
06-07 17:09:35.211+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.211+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:221,-0.552742,-1.533799,9.705289
06-07 17:09:35.221+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:215,-0.332788,-2.000824,9.594600
06-07 17:09:35.221+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:210,-5.670000,-1.750000,0.070000
06-07 17:09:35.221+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.221+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.231+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.231+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.231+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:35.241+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:234,-4.620000,-1.400000,0.560000
06-07 17:09:35.241+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:35:240,81
06-07 17:09:35.241+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:237,0.003519,-0.011875,0.048885
06-07 17:09:35.251+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.251+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.251+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:241,-0.550349,-1.495514,9.722038
06-07 17:09:35.251+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:244,-0.335089,-1.994320,9.595874
06-07 17:09:35.251+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.261+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.261+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:258,0.012300,-0.046108,0.169315
06-07 17:09:35.271+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:269,-0.538385,-1.505085,9.695717
06-07 17:09:35.271+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:273,-0.330729,-1.981718,9.598635
06-07 17:09:35.271+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:259,-7.770000,-6.090000,1.890000
06-07 17:09:35.271+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.281+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.281+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.291+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.291+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:296,-0.567099,-1.457229,9.702895
06-07 17:09:35.291+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:286,-0.030921,-0.102467,0.048475
06-07 17:09:35.301+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:287,-12.460000,-7.700000,2.170000
06-07 17:09:35.301+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.301+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.301+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.301+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:300,-0.329231,-1.988638,9.597256
06-07 17:09:35.301+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.311+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:320,-0.335698,-1.998328,9.595018
06-07 17:09:35.321+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:310,0.081450,0.070490,0.016095
06-07 17:09:35.321+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:308,-11.970000,-8.330000,2.100000
06-07 17:09:35.321+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.321+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.321+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:316,-0.497707,-1.473979,9.762716
06-07 17:09:35.331+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.331+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.331+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:333,0.084268,-0.025860,0.015727
06-07 17:09:35.341+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:329,-12.040000,-9.310000,1.960000
06-07 17:09:35.341+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:35.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391375349,000000, pattern:[H:mm][0;m
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:35.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:09:35.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:09][0;m
06-07 17:09:35.351+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.351+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:341,-0.507278,-1.430908,9.662218
06-07 17:09:35.351+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:343,-0.340988,-1.999334,9.594623
06-07 17:09:35.361+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.361+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.361+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:355,-14.840000,-7.420000,0.910000
06-07 17:09:35.361+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.371+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:372,-0.339161,-1.994011,9.595795
06-07 17:09:35.371+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:363,-0.060799,-0.042868,0.129568
06-07 17:09:35.371+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:380,-22.960001,-2.590000,-0.910000
06-07 17:09:35.371+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.381+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:386,-0.106974,-0.100177,0.057629
06-07 17:09:35.381+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:372,-0.538385,-1.488336,9.753145
06-07 17:09:35.381+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.391+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.391+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.391+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:35.391+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:35:400,549.000000
06-07 17:09:35.391+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.401+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:398,-0.555135,-1.497907,9.760324
06-07 17:09:35.401+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:394,-0.339617,-1.999079,9.594724
06-07 17:09:35.411+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:400,-33.459999,0.910000,-2.940000
06-07 17:09:35.411+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.411+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.411+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.421+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:408,0.015564,-0.053708,0.091523
06-07 17:09:35.431+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.431+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:35.431+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:441,0.001773,-0.097316,0.008995
06-07 17:09:35.441+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:35:441,81
06-07 17:09:35.441+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:425,-0.340549,-2.003891,9.593687
06-07 17:09:35.451+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.451+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:425,-37.170002,-2.870000,-3.360000
06-07 17:09:35.451+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:430,-0.492921,-1.509871,9.762716
06-07 17:09:35.451+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.451+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.461+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.471+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:460,-0.337714,-2.000122,9.594574
06-07 17:09:35.471+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:469,-0.012128,-0.118569,0.033995
06-07 17:09:35.481+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.491+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:495,-0.337835,-1.994060,9.595831
06-07 17:09:35.491+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:469,-0.519243,-1.459622,9.762716
06-07 17:09:35.501+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:468,-31.150000,-6.440000,-3.500000
06-07 17:09:35.501+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.501+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.501+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.521+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:517,-25.830000,-5.530000,-2.380000
06-07 17:09:35.521+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:513,-0.521635,-1.385444,9.729217
06-07 17:09:35.531+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.531+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.541+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.541+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:512,0.058196,-0.053937,0.128351
06-07 17:09:35.551+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.551+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:550,-19.460001,-3.570000,-0.210000
06-07 17:09:35.551+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:536,-0.339116,-1.985471,9.597567
06-07 17:09:35.561+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.561+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:551,-0.531207,-1.361516,9.748360
06-07 17:09:35.561+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:563,0.007504,0.035615,0.029359
06-07 17:09:35.561+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.571+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.571+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.581+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:582,-0.526421,-1.423729,9.705289
06-07 17:09:35.581+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:579,-25.549999,-2.730000,-3.290000
06-07 17:09:35.581+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:572,-0.340187,-1.977364,9.599202
06-07 17:09:35.581+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.591+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:583,-0.033053,0.048695,0.138172
06-07 17:09:35.591+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:35.591+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.591+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.591+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.601+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:35:600,551.000000
06-07 17:09:35.601+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:594,-0.339614,-1.972838,9.600154
06-07 17:09:35.601+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:602,-26.460001,-3.430000,-3.640000
06-07 17:09:35.611+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.611+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:604,-0.555135,-1.445265,9.714860
06-07 17:09:35.611+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:603,-0.038950,0.066427,0.026366
06-07 17:09:35.611+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.611+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.621+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.621+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:627,0.017156,0.043963,0.065409
06-07 17:09:35.631+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:618,-0.339255,-1.967006,9.601363
06-07 17:09:35.631+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:622,-22.469999,-2.240000,-2.310000
06-07 17:09:35.631+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.631+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:632,-0.531207,-1.476372,9.755538
06-07 17:09:35.631+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:35.631+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.641+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.641+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:35:641,80
06-07 17:09:35.641+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.641+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:652,-0.009739,0.029866,0.078814
06-07 17:09:35.651+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:642,-18.200001,-5.740000,-2.520000
06-07 17:09:35.651+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:641,-0.338188,-1.968948,9.601003
06-07 17:09:35.651+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.651+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.651+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:655,-0.504886,-1.462015,9.717253
06-07 17:09:35.651+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.661+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:665,-0.340518,-1.968874,9.600936
06-07 17:09:35.671+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.671+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:676,-0.586242,-1.548156,9.757930
06-07 17:09:35.671+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:664,-14.420000,-2.800000,-2.730000
06-07 17:09:35.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:670,0.042545,-0.062108,0.075212
06-07 17:09:35.671+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.681+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.681+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.681+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:687,-5.880000,1.190000,-3.080000
06-07 17:09:35.691+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.691+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:692,-0.027914,-0.012309,0.042072
06-07 17:09:35.691+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.691+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:691,-0.340045,-1.967439,9.601247
06-07 17:09:35.701+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.701+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:705,4.550000,0.350000,-2.730000
06-07 17:09:35.701+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.711+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:699,-0.526421,-1.533799,9.705289
06-07 17:09:35.711+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:711,0.029451,-0.002812,0.087603
06-07 17:09:35.711+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.711+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:713,-0.338144,-1.965043,9.601805
06-07 17:09:35.721+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.721+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.731+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.751+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:722,-0.538385,-1.574477,9.705289
06-07 17:09:35.751+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:729,9.940000,0.700000,-2.100000
06-07 17:09:35.751+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.751+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:749,0.040942,0.014895,0.053793
06-07 17:09:35.751+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.761+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:750,-0.338553,-1.968036,9.601177
06-07 17:09:35.761+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.761+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.771+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:774,-0.341838,-1.967064,9.601260
06-07 17:09:35.771+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:773,0.005542,-0.059285,0.060413
06-07 17:09:35.771+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:764,-0.507278,-1.430908,9.726824
06-07 17:09:35.771+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:765,7.980000,2.030000,-1.330000
06-07 17:09:35.771+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.781+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.781+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.781+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.791+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:786,9.450000,2.100000,-0.140000
06-07 17:09:35.791+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:35.791+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:35:789,-0.459422,-1.339981,9.839286
06-07 17:09:35.791+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:35:792,-0.037120,0.015493,0.108897
06-07 17:09:35.791+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:35:798,551.000000
06-07 17:09:35.801+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:35.801+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:35.801+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:35.801+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:35:794,-0.342903,-1.957142,9.603250
06-07 17:09:35.811+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:35.811+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:35:807,12.880000,3.220000,0.700000
06-07 17:09:35.811+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11168686c6f63152838417
