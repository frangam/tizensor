S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16945
Date: 2018-06-07 17:09:51+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70d852d, r5   = 0xf76f0f98
r6   = 0xffdb16a0, r7   = 0xffdb1550
r8   = 0xf76edc18, r9   = 0x00000000
r10  = 0xffdb162c, fp   = 0xffdb16a0
ip   = 0x00000001, sp   = 0xffdb1528
lr   = 0xf70d8539, pc   = 0xf7141228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    122388 KB
Buffers:     11048 KB
Cached:      58220 KB
VmPeak:      52416 KB
VmSize:      52412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11572 KB
VmRSS:       11572 KB
VmData:      10140 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16945 TID = 16945
16945 16955 

Maps Information
f3fa3000 f47a2000 rw-p [stack:16955]
f47a9000 f47ab000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47b3000 f47b7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47c0000 f47c2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47ca000 f47cd000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47dc000 f47e1000 r-xp /usr/lib/libsystem.so.0.0.0
f47ec000 f47ef000 r-xp /lib/libattr.so.1.1.0
f47f7000 f4807000 r-xp /usr/lib/libmdm-common.so.1.1.24
f480f000 f4818000 r-xp /usr/lib/libedbus.so.1.7.99
f4820000 f4821000 r-xp /usr/lib/libresponse.so.0.2.96
f482a000 f482f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60d1000 f61d7000 r-xp /usr/lib/libicuuc.so.57.1
f61ed000 f6375000 r-xp /usr/lib/libicui18n.so.57.1
f6385000 f6392000 r-xp /usr/lib/libail.so.0.1.0
f639b000 f63a2000 r-xp /usr/lib/libminizip.so.1.0.0
f63ab000 f6554000 r-xp /usr/lib/libcrypto.so.1.0.0
f6574000 f65bb000 r-xp /usr/lib/libssl.so.1.0.0
f65c7000 f65c9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65d1000 f65d8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65e1000 f65e8000 r-xp /lib/libcrypt-2.13.so
f6619000 f661c000 r-xp /lib/libcap.so.2.21
f6624000 f6626000 r-xp /usr/lib/libiri.so
f662e000 f6677000 r-xp /usr/lib/libmdm.so.1.2.69
f667f000 f6685000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f668d000 f66b0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66ba000 f66bc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66c4000 f66e1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66ea000 f66ee000 r-xp /usr/lib/libsmack.so.1.0.0
f66f7000 f6710000 r-xp /usr/lib/libnetwork.so.0.0.0
f6719000 f6721000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6729000 f672f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6738000 f673a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6743000 f6753000 r-xp /lib/libresolv-2.13.so
f6757000 f676f000 r-xp /usr/lib/liblzma.so.5.0.3
f6778000 f677a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6782000 f679c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67a4000 f67d3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67dc000 f67eb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67f5000 f67ff000 r-xp /usr/lib/libsensord-shared.so
f6808000 f68db000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68e6000 f68fc000 r-xp /lib/libz.so.1.2.5
f6904000 f6909000 r-xp /usr/lib/libffi.so.5.0.10
f6911000 f6912000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f691a000 f692a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6932000 f694b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6953000 f6955000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f695d000 f69d2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69dc000 f69e2000 r-xp /lib/librt-2.13.so
f69eb000 f6a09000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a13000 f6a14000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a1c000 f6a3f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a47000 f6a4c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a54000 f6a7e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a87000 f6a9e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aa6000 f6b0f000 r-xp /lib/libm-2.13.so
f6b18000 f6bac000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bbf000 f6bc4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bcc000 f6bd3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bdb000 f6c05000 r-xp /usr/lib/libsensor.so.1.9.6
f6c0e000 f6cda000 r-xp /usr/lib/libxml2.so.2.7.8
f6ce7000 f6ce9000 r-xp /usr/lib/libiniparser.so.0
f6cf2000 f6cf8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d01000 f6dd1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dd2000 f6e06000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e0f000 f6e4b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e53000 f6e56000 r-xp /usr/lib/libbundle.so.0.1.22
f6e5e000 f6e64000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e6c000 f6ead000 r-xp /usr/lib/libeina.so.1.7.99
f6eb6000 f6ecd000 r-xp /usr/lib/libecore.so.1.7.99
f6ee4000 f6eed000 r-xp /usr/lib/libvconf.so.0.2.45
f6ef5000 f6f09000 r-xp /lib/libpthread-2.13.so
f6f14000 f6f21000 r-xp /usr/lib/libaul.so.0.1.0
f6f2b000 f6f2d000 r-xp /lib/libdl-2.13.so
f6f36000 f6f41000 r-xp /lib/libunwind.so.8.0.1
f6f6e000 f6f76000 r-xp /lib/libgcc_s-4.6.so.1
f6f77000 f709b000 r-xp /lib/libc-2.13.so
f70a9000 f70ab000 r-xp /usr/lib/libdlog.so.0.0.0
f70b3000 f70bf000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70c8000 f70cd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70d5000 f70e4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70ec000 f70f0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70f9000 f70fc000 r-xp /usr/lib/libappcore-agent.so.1.1
f7104000 f7106000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f710e000 f7112000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f711a000 f7137000 r-xp /lib/ld-2.13.so
f7140000 f7143000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7143000 f7147000 r-xp /usr/lib/libsys-assert.so
f76bd000 f772f000 rw-p [heap]
ffd92000 ffdb3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16945)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7141228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70d8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ddf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dddc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6de9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6defbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6defdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e2475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e1f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dddc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6de9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6defbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6defdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e21e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e22017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e29f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47c11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47b4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6887663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d34fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d367a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ec6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ec1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ec25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ec2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70fa183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70fa7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71415c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f8e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7140f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
07 17:09:50.561+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:567,-2.940000,0.140000,0.490000
06-07 17:09:50.561+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.571+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.571+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:577,-2.380000,1.120000,1.260000
06-07 17:09:50.571+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:573,0.223120,-3.844050,9.019084
06-07 17:09:50.571+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.571+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.581+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:583,0.258425,-3.737589,9.303294
06-07 17:09:50.581+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:584,0.020535,2.208880,1.343497
06-07 17:09:50.581+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.581+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.581+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:589,0.337388,-3.704089,9.001799
06-07 17:09:50.581+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.591+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:589,-0.051765,2.052005,1.474071
06-07 17:09:50.591+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.591+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.591+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:597,0.105268,2.182311,1.581463
06-07 17:09:50.591+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.591+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:593,0.220641,-3.831245,9.024592
06-07 17:09:50.591+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:50.601+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:50:605,459.000000
06-07 17:09:50.601+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:598,0.420000,-0.140000,0.350000
06-07 17:09:50.601+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.601+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.601+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.601+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:602,0.176027,1.975059,1.205311
06-07 17:09:50.611+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:613,0.287139,-3.716053,9.044869
06-07 17:09:50.611+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:613,0.224317,-3.821395,9.028677
06-07 17:09:50.611+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.611+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.621+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:625,0.186640,-3.811767,8.985049
06-07 17:09:50.621+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:622,2.800000,-1.750000,-0.210000
06-07 17:09:50.621+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.621+0200 W/CAPI_APPFW_APP_CONTROL(16876): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:09:50.621+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:09:50.621+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16876), cmd(0)
06-07 17:09:50.631+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:624,0.023536,1.752021,0.816293
06-07 17:09:50.631+0200 I/utils   (16876): specific action
06-07 17:09:50.631+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.631+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.631+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:638,0.002501,1.492393,0.801404
06-07 17:09:50.631+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.631+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:634,0.223831,-3.798287,9.038435
06-07 17:09:50.641+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:638,-0.560000,0.490000,-0.210000
06-07 17:09:50.641+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.641+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.641+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.641+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:50.641+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:50:651,84
06-07 17:09:50.641+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:651,0.270389,-3.713661,9.284152
06-07 17:09:50.651+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:648,0.222832,-3.781195,9.045623
06-07 17:09:50.651+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:655,-1.750000,2.870000,-0.630000
06-07 17:09:50.651+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:642,0.094851,1.399609,1.127722
06-07 17:09:50.661+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.661+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.661+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.661+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.661+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:670,0.308674,-3.845266,9.281759
06-07 17:09:50.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:670,0.074936,1.388381,1.048361
06-07 17:09:50.671+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:667,0.220806,-3.766229,9.051914
06-07 17:09:50.671+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.681+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:684,0.227318,-3.775874,9.207582
06-07 17:09:50.681+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:667,-1.750000,-0.140000,0.490000
06-07 17:09:50.681+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.681+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.681+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:685,0.091328,1.370709,0.731009
06-07 17:09:50.681+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.691+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:694,1.330000,-0.140000,0.350000
06-07 17:09:50.691+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:693,0.218138,-3.783448,9.044795
06-07 17:09:50.691+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.701+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.701+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.701+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:704,0.258425,-3.749553,9.064013
06-07 17:09:50.701+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:695,-0.094177,1.244660,0.601786
06-07 17:09:50.701+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.701+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:711,0.226525,-3.808102,9.034237
06-07 17:09:50.711+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:707,3.290000,1.330000,-0.140000
06-07 17:09:50.711+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.711+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.711+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:719,3.360000,0.910000,0.700000
06-07 17:09:50.711+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.721+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:722,0.231815,-3.800671,9.037231
06-07 17:09:50.721+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.721+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.721+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:724,0.203390,-3.639483,9.147761
06-07 17:09:50.721+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:713,0.137248,1.104984,0.719591
06-07 17:09:50.721+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.731+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:730,-0.700000,-0.420000,0.840000
06-07 17:09:50.731+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.731+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:732,0.233229,-3.777764,9.046795
06-07 17:09:50.731+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:740,-2.380000,-1.680000,0.280000
06-07 17:09:50.731+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.741+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.741+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:745,0.308674,-3.804588,9.291330
06-07 17:09:50.741+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.741+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:733,-0.023224,1.092535,0.660901
06-07 17:09:50.741+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.741+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:751,0.183728,0.946184,0.503336
06-07 17:09:50.751+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:746,0.227713,-3.745506,9.060337
06-07 17:09:50.751+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.751+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:757,0.225054,-3.738736,9.063200
06-07 17:09:50.751+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:751,1.610000,0.210000,0.210000
06-07 17:09:50.751+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.761+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.761+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.761+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.761+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:763,2.170000,1.260000,0.980000
06-07 17:09:50.761+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:768,0.167498,-3.972085,9.054441
06-07 17:09:50.761+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.761+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:767,0.226506,-3.747435,9.059570
06-07 17:09:50.761+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:766,0.038152,0.739763,0.533972
06-07 17:09:50.771+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:775,3.500000,2.240000,0.560000
06-07 17:09:50.771+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.771+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.771+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.781+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:781,0.225255,-3.751084,9.058091
06-07 17:09:50.781+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:784,0.131605,-3.811767,9.265009
06-07 17:09:50.781+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.781+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.781+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:788,-0.048366,0.915020,0.342907
06-07 17:09:50.781+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.781+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:785,0.280000,-1.190000,1.610000
06-07 17:09:50.791+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.791+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:797,-2.660000,-2.170000,0.630000
06-07 17:09:50.791+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:792,0.225952,-3.752610,9.057442
06-07 17:09:50.791+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.791+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:50.791+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.801+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:805,0.241675,-3.629912,9.131011
06-07 17:09:50.801+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:50:805,459.000000
06-07 17:09:50.801+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:793,0.108244,0.680751,0.657733
06-07 17:09:50.801+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.801+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.801+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:811,-0.034094,0.739325,0.552678
06-07 17:09:50.811+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:815,0.980000,-0.840000,-0.140000
06-07 17:09:50.811+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:804,0.230692,-3.755345,9.056189
06-07 17:09:50.811+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.811+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.821+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.821+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:821,0.230390,-3.735438,9.064425
06-07 17:09:50.821+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:824,0.140000,-0.140000,0.350000
06-07 17:09:50.821+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.831+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.831+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:826,0.334995,-3.670590,9.265009
06-07 17:09:50.831+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.831+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:837,-0.140000,2.940000,0.910000
06-07 17:09:50.831+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:838,0.054525,0.747015,0.461266
06-07 17:09:50.831+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:832,0.224961,-3.718353,9.071584
06-07 17:09:50.831+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.831+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.841+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.841+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:842,-0.017712,0.448494,0.284731
06-07 17:09:50.841+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.841+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:846,0.332602,-3.749553,9.119047
06-07 17:09:50.841+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.851+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:855,3.710000,1.190000,0.350000
06-07 17:09:50.851+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:845,0.227214,-3.710018,9.074939
06-07 17:09:50.861+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:50.881+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.901+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:50:874,84
06-07 17:09:50.901+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:887,0.196211,-3.773481,9.217153
06-07 17:09:50.901+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.921+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.921+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:909,0.205783,-3.548556,9.174082
06-07 17:09:50.921+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.931+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.941+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:849,-0.052198,0.554961,0.177921
06-07 17:09:50.941+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:50.951+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:927,0.226470,-3.705448,9.076825
06-07 17:09:50.951+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:50.951+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:938,3.080000,-0.490000,-0.490000
06-07 17:09:50.961+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:934,0.239282,-3.830909,9.080762
06-07 17:09:50.961+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:50.971+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:50.981+0200 W/LOCATION(16945): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:09:50.981+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:50:951,0.139052,0.506914,0.532858
06-07 17:09:50.991+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:50.991+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:50:960,0.227742,-3.714741,9.072994
06-07 17:09:50.991+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:50:966,0.155533,-3.902694,9.128618
06-07 17:09:51.001+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.001+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.001+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.001+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:6,0.004748,0.419936,0.413138
06-07 17:09:51.011+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.011+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:51:5,462.000000
06-07 17:09:51.011+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:11,0.251246,-3.936193,9.176475
06-07 17:09:51.011+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.011+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:12,0.230619,-3.731356,9.066101
06-07 17:09:50.991+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:50:985,3.850000,0.560000,-0.210000
06-07 17:09:51.011+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.021+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.021+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:20,0.169890,-3.859623,9.248260
06-07 17:09:51.021+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:16,-0.061456,0.518425,0.361167
06-07 17:09:51.021+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.021+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.031+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:35,0.181855,-3.756732,9.248260
06-07 17:09:51.031+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:28,3.080000,-1.120000,0.070000
06-07 17:09:51.031+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.041+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.051+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:44,-1.470000,-0.980000,0.490000
06-07 17:09:51.051+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:54,0.200997,-3.584448,9.119047
06-07 17:09:51.051+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:09:51.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:09:51.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:09:51.051+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.061+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:51.061+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:61,-1.330000,0.910000,-0.140000
06-07 17:09:51.061+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:51:67,83
06-07 17:09:51.071+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:65,0.229711,-3.567699,9.262616
06-07 17:09:51.071+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.071+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.071+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:22,0.229942,-3.734697,9.064742
06-07 17:09:51.081+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.081+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:80,1.190000,0.210000,-0.490000
06-07 17:09:51.081+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:35,0.116737,0.524976,0.357351
06-07 17:09:51.081+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:81,0.157926,-3.711268,9.049655
06-07 17:09:51.081+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.081+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.091+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.091+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:86,0.231498,-3.753797,9.056809
06-07 17:09:51.101+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.101+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:99,0.222532,-3.637090,8.997013
06-07 17:09:51.101+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:94,0.095315,0.284831,0.217468
06-07 17:09:51.101+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.111+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.111+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:103,4.340000,0.770000,-0.700000
06-07 17:09:51.111+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.111+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:118,0.018137,0.327482,0.142813
06-07 17:09:51.111+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:115,0.136391,-3.235096,9.080762
06-07 17:09:51.121+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:106,0.234769,-3.753330,9.056919
06-07 17:09:51.121+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.121+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:121,3.080000,0.420000,-0.630000
06-07 17:09:51.121+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.131+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.131+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:134,0.196211,-3.644269,9.291330
06-07 17:09:51.131+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:137,0.014962,0.400208,0.233812
06-07 17:09:51.131+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.141+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.141+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:129,0.234921,-3.741402,9.061849
06-07 17:09:51.141+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.141+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:142,2.100000,0.560000,-0.350000
06-07 17:09:51.151+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.151+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:147,0.095713,-3.699304,9.188439
06-07 17:09:51.151+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:160,0.560000,-1.610000,-0.560000
06-07 17:09:51.151+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.161+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.161+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:165,0.081356,-3.503092,9.327222
06-07 17:09:51.161+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:166,-0.022951,0.396169,0.293237
06-07 17:09:51.161+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:150,0.237200,-3.722730,9.069476
06-07 17:09:51.171+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.171+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.171+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.171+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:176,0.237111,-3.698130,9.079537
06-07 17:09:51.171+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.181+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:178,0.064606,-3.639483,9.217153
06-07 17:09:51.181+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:180,1.120000,-1.330000,-0.420000
06-07 17:09:51.181+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.181+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.191+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.191+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:193,-0.061998,0.399371,0.076166
06-07 17:09:51.191+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.201+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:51.201+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:51:206,464.000000
06-07 17:09:51.201+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:198,-0.034337,0.306204,0.349061
06-07 17:09:51.201+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.201+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:197,0.425922,-3.795017,9.255438
06-07 17:09:51.201+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.211+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:181,0.236004,-3.693885,9.081294
06-07 17:09:51.211+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:200,1.820000,-0.280000,-0.630000
06-07 17:09:51.211+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.211+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.221+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:224,4.340000,-0.630000,-0.420000
06-07 17:09:51.221+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:219,0.069392,-3.747160,9.097511
06-07 17:09:51.221+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:220,0.235933,-3.697255,9.079925
06-07 17:09:51.231+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.231+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:212,0.105463,0.128315,0.279113
06-07 17:09:51.231+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.231+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.241+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:236,0.112463,-3.921836,9.109475
06-07 17:09:51.241+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.241+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:51.241+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:244,4.130000,-0.350000,-0.980000
06-07 17:09:51.251+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:51:251,83
06-07 17:09:51.251+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:253,0.155533,-3.759124,9.102298
06-07 17:09:51.251+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.251+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.261+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.261+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:239,-0.007076,0.147754,0.230469
06-07 17:09:51.261+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.261+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:265,2.940000,0.210000,-1.050000
06-07 17:09:51.271+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:265,0.234857,-3.695089,9.080833
06-07 17:09:51.271+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.271+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:269,0.155533,-3.615555,9.049655
06-07 17:09:51.271+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.281+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.281+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:272,0.059627,0.175828,0.159054
06-07 17:09:51.291+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:278,0.236189,-3.688694,9.083399
06-07 17:09:51.291+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:280,2.520000,-0.070000,-0.560000
06-07 17:09:51.291+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.291+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.291+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:287,0.043071,-3.871587,9.193225
06-07 17:09:51.291+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.301+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.301+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:305,0.043735,0.290773,0.194680
06-07 17:09:51.311+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:306,0.019143,-3.967300,9.303294
06-07 17:09:51.311+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.311+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:302,1.890000,0.140000,-0.770000
06-07 17:09:51.311+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.311+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.311+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:298,0.237159,-3.681658,9.086227
06-07 17:09:51.321+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.321+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:320,-1.540000,1.400000,-0.700000
06-07 17:09:51.321+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:324,0.193819,-3.986443,9.209974
06-07 17:09:51.331+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.331+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:316,0.057458,0.279653,0.154835
06-07 17:09:51.331+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.341+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.341+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:331,0.237458,-3.669823,9.091006
06-07 17:09:51.341+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:51.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391391352,000000, pattern:[H:mm][0;m
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:51.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:09:51.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:09][0;m
06-07 17:09:51.351+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:340,0.013999,0.236274,0.189049
06-07 17:09:51.351+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.351+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:348,0.279960,-3.859623,9.138189
06-07 17:09:51.361+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:338,-1.680000,1.470000,-0.420000
06-07 17:09:51.361+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.361+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.361+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:371,0.184247,-3.969693,8.963513
06-07 17:09:51.371+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:372,1.610000,0.070000,-0.420000
06-07 17:09:51.371+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:350,0.235761,-3.662642,9.093946
06-07 17:09:51.371+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.371+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.381+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.381+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:385,2.520000,-0.490000,0.420000
06-07 17:09:51.381+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:360,0.044191,0.311543,0.317787
06-07 17:09:51.381+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.391+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.391+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:381,0.234345,-3.649179,9.099393
06-07 17:09:51.391+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.401+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:51.401+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:51:406,462.000000
06-07 17:09:51.401+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:397,0.980000,0.980000,0.560000
06-07 17:09:51.401+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:386,0.143569,-3.845266,9.111869
06-07 17:09:51.401+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.411+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.411+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:395,0.106776,0.182313,0.233793
06-07 17:09:51.411+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.421+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:418,-1.400000,0.980000,0.070000
06-07 17:09:51.421+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:401,0.236708,-3.640334,9.102874
06-07 17:09:51.421+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:414,0.138784,-3.826123,9.004191
06-07 17:09:51.421+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.421+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.431+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:433,-2.170000,1.400000,0.210000
06-07 17:09:51.431+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.431+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:419,-0.013231,0.104669,0.090026
06-07 17:09:51.441+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.441+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:442,0.239047,-3.636100,9.104506
06-07 17:09:51.441+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:446,-1.190000,-0.910000,-0.210000
06-07 17:09:51.451+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:51.451+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.451+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:51:456,83
06-07 17:09:51.451+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:432,0.155533,-3.979264,9.107083
06-07 17:09:51.451+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.461+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.461+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:457,1.470000,-2.380000,-0.350000
06-07 17:09:51.471+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.471+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:477,2.590000,-0.910000,-0.910000
06-07 17:09:51.471+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.481+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:482,0.210000,0.910000,-0.840000
06-07 17:09:51.481+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.491+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:495,1.190000,1.960000,-0.070000
06-07 17:09:51.491+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.491+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:501,0.350000,-0.070000,-0.070000
06-07 17:09:51.501+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.501+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:507,-0.560000,-0.840000,0.280000
06-07 17:09:51.501+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.511+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:513,1.120000,-0.420000,0.490000
06-07 17:09:51.511+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.511+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:462,0.246461,-3.883551,9.209974
06-07 17:09:51.511+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:518,1.470000,-0.560000,0.490000
06-07 17:09:51.511+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.521+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:524,-1.750000,0.420000,0.210000
06-07 17:09:51.521+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.521+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:530,-1.120000,1.750000,-0.070000
06-07 17:09:51.521+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.531+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:51.531+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:535,0.630000,0.770000,-0.840000
06-07 17:09:51.531+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.541+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:541,0.490000,-0.070000,-0.770000
06-07 17:09:51.541+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.541+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:546,0.980000,-0.070000,0.140000
06-07 17:09:51.541+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.551+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:466,-0.050837,0.113639,0.135855
06-07 17:09:51.551+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:51.551+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.551+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:552,1.680000,-1.260000,-0.210000
06-07 17:09:51.551+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.551+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:557,0.066498,0.215690,0.187775
06-07 17:09:51.551+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.561+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:564,0.036500,0.150805,0.174119
06-07 17:09:51.561+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.561+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:51:562,0.070000,-0.910000,0.350000
06-07 17:09:51.561+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:51.571+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:572,0.020237,0.051127,0.200253
06-07 17:09:51.571+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.571+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:51:547,0.238305,-3.628896,9.107399
06-07 17:09:51.571+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:51:556,0.126820,-3.804588,9.131011
06-07 17:09:51.581+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:578,0.011665,0.002928,-0.010324
06-07 17:09:51.581+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.581+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:51:587,-0.093987,-0.079037,0.076704
06-07 17:09:51.581+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:51.591+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11169456c6f63152838419
