S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17495
Date: 2018-06-07 17:11:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf732252d, r5   = 0xf7671f98
r6   = 0xffbf6890, r7   = 0xffbf6740
r8   = 0xf766ec18, r9   = 0x00000000
r10  = 0xffbf681c, fp   = 0xffbf6890
ip   = 0x00000001, sp   = 0xffbf6718
lr   = 0xf7322539, pc   = 0xf738b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    166336 KB
Buffers:      9512 KB
Cached:      51612 KB
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
PID = 17495 TID = 17495
17495 17501 

Maps Information
f41ed000 f49ec000 rw-p [stack:17501]
f49f3000 f49f5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49fd000 f4a01000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a0a000 f4a0c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a14000 f4a17000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a26000 f4a2b000 r-xp /usr/lib/libsystem.so.0.0.0
f4a36000 f4a39000 r-xp /lib/libattr.so.1.1.0
f4a41000 f4a51000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a59000 f4a62000 r-xp /usr/lib/libedbus.so.1.7.99
f4a6a000 f4a6b000 r-xp /usr/lib/libresponse.so.0.2.96
f4a74000 f4a79000 r-xp /usr/lib/libproc-stat.so.0.2.96
f631b000 f6421000 r-xp /usr/lib/libicuuc.so.57.1
f6437000 f65bf000 r-xp /usr/lib/libicui18n.so.57.1
f65cf000 f65dc000 r-xp /usr/lib/libail.so.0.1.0
f65e5000 f65ec000 r-xp /usr/lib/libminizip.so.1.0.0
f65f5000 f679e000 r-xp /usr/lib/libcrypto.so.1.0.0
f67be000 f6805000 r-xp /usr/lib/libssl.so.1.0.0
f6811000 f6813000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f681b000 f6822000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f682b000 f6832000 r-xp /lib/libcrypt-2.13.so
f6863000 f6866000 r-xp /lib/libcap.so.2.21
f686e000 f6870000 r-xp /usr/lib/libiri.so
f6878000 f68c1000 r-xp /usr/lib/libmdm.so.1.2.69
f68c9000 f68cf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68d7000 f68fa000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6904000 f6906000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f690e000 f692b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6934000 f6938000 r-xp /usr/lib/libsmack.so.1.0.0
f6941000 f695a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6963000 f696b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6973000 f6979000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6982000 f6984000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f698d000 f699d000 r-xp /lib/libresolv-2.13.so
f69a1000 f69b9000 r-xp /usr/lib/liblzma.so.5.0.3
f69c2000 f69c4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69cc000 f69e6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69ee000 f6a1d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a26000 f6a35000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a3f000 f6a49000 r-xp /usr/lib/libsensord-shared.so
f6a52000 f6b25000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b30000 f6b46000 r-xp /lib/libz.so.1.2.5
f6b4e000 f6b53000 r-xp /usr/lib/libffi.so.5.0.10
f6b5b000 f6b5c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b64000 f6b74000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b7c000 f6b95000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b9d000 f6b9f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ba7000 f6c1c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c26000 f6c2c000 r-xp /lib/librt-2.13.so
f6c35000 f6c53000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c5d000 f6c5e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c66000 f6c89000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c91000 f6c96000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c9e000 f6cc8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cd1000 f6ce8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cf0000 f6d59000 r-xp /lib/libm-2.13.so
f6d62000 f6df6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e09000 f6e0e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e16000 f6e1d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e25000 f6e4f000 r-xp /usr/lib/libsensor.so.1.9.6
f6e58000 f6f24000 r-xp /usr/lib/libxml2.so.2.7.8
f6f31000 f6f33000 r-xp /usr/lib/libiniparser.so.0
f6f3c000 f6f42000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f4b000 f701b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f701c000 f7050000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7059000 f7095000 r-xp /usr/lib/libSLP-location.so.0.9.24
f709d000 f70a0000 r-xp /usr/lib/libbundle.so.0.1.22
f70a8000 f70ae000 r-xp /usr/lib/libappsvc.so.0.1.0
f70b6000 f70f7000 r-xp /usr/lib/libeina.so.1.7.99
f7100000 f7117000 r-xp /usr/lib/libecore.so.1.7.99
f712e000 f7137000 r-xp /usr/lib/libvconf.so.0.2.45
f713f000 f7153000 r-xp /lib/libpthread-2.13.so
f715e000 f716b000 r-xp /usr/lib/libaul.so.0.1.0
f7175000 f7177000 r-xp /lib/libdl-2.13.so
f7180000 f718b000 r-xp /lib/libunwind.so.8.0.1
f71b8000 f71c0000 r-xp /lib/libgcc_s-4.6.so.1
f71c1000 f72e5000 r-xp /lib/libc-2.13.so
f72f3000 f72f5000 r-xp /usr/lib/libdlog.so.0.0.0
f72fd000 f7309000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7312000 f7317000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f731f000 f732e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7336000 f733a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7343000 f7346000 r-xp /usr/lib/libappcore-agent.so.1.1
f734e000 f7350000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7358000 f735c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7364000 f7381000 r-xp /lib/ld-2.13.so
f738a000 f738d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f738d000 f7391000 r-xp /usr/lib/libsys-assert.so
f763e000 f76af000 rw-p [heap]
ffbd7000 ffbf8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17495)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf738b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7322539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70293f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7027c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7033e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7039be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7039dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf706e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70691f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7027c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7033e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7039be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7039dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf706be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf706c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7073f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a0b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49fe171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ad1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f7efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f807a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7110ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf710bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf710c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf710c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7344183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73447fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf738b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf71d885c) [/lib/libc.so.6] + 0x1785c
29: (0xf738af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:552,-0.993021,-4.969893,8.516055
06-07 17:11:43.551+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.551+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:560,-1.007378,-4.957928,8.496914
06-07 17:11:43.561+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:526,-0.063292,-0.047796,0.077973
06-07 17:11:43.561+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.561+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.561+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.571+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:557,-0.972454,-4.929837,8.421486
06-07 17:11:43.571+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:569,-0.973879,-4.967500,8.501699
06-07 17:11:43.581+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.581+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:576,-0.023339,-0.085618,0.037757
06-07 17:11:43.581+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:571,-0.140000,-0.280000,-0.070000
06-07 17:11:43.591+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.591+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.601+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.601+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:591,-0.972982,-4.928286,8.422333
06-07 17:11:43.601+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:610,0.002550,-0.083873,0.118961
06-07 17:11:43.611+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.621+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:603,-0.937986,-4.943572,8.513663
06-07 17:11:43.621+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:598,0.350000,0.140000,0.070000
06-07 17:11:43.621+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.621+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.631+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.641+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:640,-0.022889,-0.024527,0.074722
06-07 17:11:43.641+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:624,-0.973431,-4.926643,8.423243
06-07 17:11:43.651+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:636,0.210000,0.420000,0.140000
06-07 17:11:43.651+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.661+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.661+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:639,-0.947558,-5.008178,8.482556
06-07 17:11:43.661+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.661+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.671+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:43.671+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:43:680,749.000000
06-07 17:11:43.681+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:660,-0.972216,-4.926145,8.423674
06-07 17:11:43.681+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.681+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:673,-0.018175,-0.001770,0.046713
06-07 17:11:43.681+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:668,0.070000,-0.140000,0.070000
06-07 17:11:43.681+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:691,-0.971239,-4.925623,8.424091
06-07 17:11:43.691+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.691+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:675,-0.947558,-4.957928,8.475377
06-07 17:11:43.691+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.691+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.691+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:700,0.070000,-0.140000,0.070000
06-07 17:11:43.701+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:704,-0.976272,-4.955536,8.484949
06-07 17:11:43.701+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.711+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.711+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:704,0.027817,-0.012893,0.088937
06-07 17:11:43.711+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.711+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.721+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:43.721+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:43:726,78
06-07 17:11:43.721+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:712,-0.970697,-4.925360,8.424308
06-07 17:11:43.721+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.721+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:716,0.070000,0.280000,0.070000
06-07 17:11:43.721+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.731+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:722,0.016302,-0.036071,0.083241
06-07 17:11:43.731+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:722,-0.978664,-4.969893,8.470592
06-07 17:11:43.731+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.731+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.731+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:733,-0.968839,-4.925572,8.424397
06-07 17:11:43.741+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.741+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:736,0.140000,0.070000,0.070000
06-07 17:11:43.741+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:744,-0.959522,-4.979464,8.482556
06-07 17:11:43.751+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.751+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.751+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:745,-0.004055,-0.060498,0.082810
06-07 17:11:43.761+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:757,-0.990629,-4.965107,8.506484
06-07 17:11:43.761+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.761+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:768,0.035645,-0.061019,0.096750
06-07 17:11:43.761+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:752,-0.967056,-4.925461,8.424667
06-07 17:11:43.761+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.771+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.771+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:760,0.210000,-0.140000,-0.070000
06-07 17:11:43.771+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.771+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:774,-0.969421,-4.924726,8.424826
06-07 17:11:43.781+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:776,-0.964308,-4.979464,8.472985
06-07 17:11:43.781+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.781+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.791+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.791+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:802,-0.968924,-4.922389,8.426248
06-07 17:11:43.801+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:783,0.140000,0.140000,0.140000
06-07 17:11:43.801+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.801+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:795,-0.993021,-4.945964,8.528020
06-07 17:11:43.801+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:792,0.049460,-0.011034,0.055856
06-07 17:11:43.801+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.801+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:811,0.140000,0.350000,0.210000
06-07 17:11:43.811+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.811+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:814,-0.995414,-4.979464,8.482556
06-07 17:11:43.811+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.821+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.821+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:824,-0.969751,-4.921586,8.426622
06-07 17:11:43.821+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.821+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:830,0.280000,-0.210000,0.140000
06-07 17:11:43.821+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:818,-0.064860,-0.070642,0.074908
06-07 17:11:43.831+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.831+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:830,-1.000200,-4.998606,8.539984
06-07 17:11:43.831+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.841+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.841+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:841,-0.002037,-0.010932,0.014818
06-07 17:11:43.841+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:849,-0.972513,-4.919710,8.427400
06-07 17:11:43.841+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.841+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:845,-0.947558,-4.938786,8.463413
06-07 17:11:43.851+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.851+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.861+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:865,-0.964308,-4.965107,8.506484
06-07 17:11:43.861+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:854,0.840000,-0.210000,0.070000
06-07 17:11:43.861+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.861+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.861+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.871+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:43.871+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:43:880,749.000000
06-07 17:11:43.881+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:878,-0.964308,-4.972286,8.532805
06-07 17:11:43.881+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:861,-0.016422,-0.052345,0.088838
06-07 17:11:43.881+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:872,-0.972418,-4.918087,8.428357
06-07 17:11:43.881+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.881+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.891+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:873,0.770000,0.280000,0.210000
06-07 17:11:43.891+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.891+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.901+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:895,-0.954736,-4.960321,8.511270
06-07 17:11:43.901+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:893,-0.069561,0.005138,0.058702
06-07 17:11:43.901+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.901+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.901+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:905,0.210000,-0.070000,-0.140000
06-07 17:11:43.911+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:902,-0.970421,-4.916562,8.429477
06-07 17:11:43.911+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:43.911+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:43.921+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:912,-0.993021,-4.910072,8.480164
06-07 17:11:43.921+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:43.921+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:11:43.921+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:11:43.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:43.921+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:43.931+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:931,-0.990629,-4.998606,8.482556
06-07 17:11:43.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
06-07 17:11:43.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
06-07 17:11:43.941+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:11:43.941+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:43.941+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:11:43.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:11:43.941+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:43.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:43.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17548
06-07 17:11:43.951+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:949,-0.985843,-4.953143,8.482556
06-07 17:11:43.951+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:43.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17548)
06-07 17:11:43.961+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:11:43.961+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:43.961+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:11:43.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:11:43.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:43.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:43.961+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:43:927,78
06-07 17:11:43.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15106
06-07 17:11:43.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15106)
06-07 17:11:43.971+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:11:43.971+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:43.971+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:11:43.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:11:43.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:43.971+0200 W/CAPI_APPFW_APP_CONTROL(15106): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:43.971+0200 I/utils   (15106): specific action
06-07 17:11:43.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:43.981+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:43:915,-0.025664,-0.024379,0.122932
06-07 17:11:43.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17495
06-07 17:11:43.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:43.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(15106), cmd(0)
06-07 17:11:43.991+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:43.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17495)
06-07 17:11:43.991+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:11:43.991+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:43.991+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:11:43.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:11:43.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:43.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:43.991+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:43:925,-0.490000,-0.350000,-0.140000
06-07 17:11:44.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17504
06-07 17:11:44.001+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:43:925,-0.968565,-4.920326,8.427494
06-07 17:11:44.011+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:43:974,-0.954736,-5.003392,8.508877
06-07 17:11:44.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17504)
06-07 17:11:44.011+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:11:44.011+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:44.011+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:11:44.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:11:44.011+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:44.011+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:44.011+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.011+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.021+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17469
06-07 17:11:44.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17469)
06-07 17:11:44.021+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:11:44.021+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:44.021+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:11:44.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:11:44.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:44.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:44.031+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:10,0.024955,-0.019076,0.119762
06-07 17:11:44.041+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:11:44.041+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:44.041+0200 I/utils   (12603): specific action
06-07 17:11:44.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:44.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:11:44.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(12603), cmd(0)
06-07 17:11:44.041+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:11:44.041+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:44.041+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:11:44.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:11:44.051+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:27,-0.140000,-0.140000,-0.140000
06-07 17:11:44.061+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:55,0.034432,-0.142733,0.070949
06-07 17:11:44.061+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:26,-0.968540,-4.920057,8.427654
06-07 17:11:44.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:11:44.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:11:44.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:11:44.061+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:44.061+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:32,-0.959522,-4.936393,8.511270
06-07 17:11:44.071+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:44.071+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.071+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16749
06-07 17:11:44.081+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:44.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(16749), cmd(0)
06-07 17:11:44.081+0200 W/CAPI_APPFW_APP_CONTROL(16749): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:44.081+0200 I/utils   (16749): specific action
06-07 17:11:44.081+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:44.091+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16749)
06-07 17:11:44.091+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:11:44.091+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:44.091+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:11:44.091+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:11:44.091+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.091+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:44.091+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:44.091+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:101,0.001327,-0.038974,0.081793
06-07 17:11:44.101+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:44:93,749.000000
06-07 17:11:44.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:11:44.101+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:44.101+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:87,-0.968293,-4.920202,8.427598
06-07 17:11:44.111+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.101+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:11:44.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:44.111+0200 I/utils   (12618): specific action
06-07 17:11:44.111+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(12618), cmd(0)
06-07 17:11:44.111+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:11:44.111+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:44.111+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:79,0.140000,0.140000,0.070000
06-07 17:11:44.111+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:116,-0.966845,-4.921496,8.427009
06-07 17:11:44.111+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.121+0200 W/CAPI_APPFW_APP_CONTROL(17548): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:44.121+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:44.121+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(17548), cmd(0)
06-07 17:11:44.121+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:44.121+0200 I/utils   (17548): specific action
06-07 17:11:44.121+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:97,-0.988236,-4.957928,8.518449
06-07 17:11:44.121+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.121+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:44:129,78
06-07 17:11:44.131+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.131+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:124,-0.968068,-4.921577,8.426821
06-07 17:11:44.131+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.131+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.131+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:139,-0.968689,-4.921535,8.426774
06-07 17:11:44.141+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.141+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:146,-0.969325,-4.922356,8.426221
06-07 17:11:44.141+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.141+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:151,-0.968317,-4.923052,8.425931
06-07 17:11:44.141+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.151+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:155,-0.967029,-4.921351,8.427073
06-07 17:11:44.151+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.151+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:134,0.210000,0.210000,0.070000
06-07 17:11:44.151+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:160,-0.968036,-4.922672,8.426185
06-07 17:11:44.161+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.161+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:166,-0.969734,-4.921706,8.426554
06-07 17:11:44.161+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.161+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:44.161+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(17469), cmd(0)
06-07 17:11:44.161+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:150,0.004232,-0.052229,0.086009
06-07 17:11:44.161+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:151,-0.935594,-4.960321,8.506484
06-07 17:11:44.161+0200 W/CAPI_APPFW_APP_CONTROL(17469): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:44.161+0200 I/utils   (17469): specific action
06-07 17:11:44.161+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.171+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.171+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:174,-0.970997,-4.921523,8.426516
06-07 17:11:44.171+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.171+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.181+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:181,-0.972077,-4.920868,8.426773
06-07 17:11:44.181+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.181+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:186,-0.972208,-4.919292,8.427678
06-07 17:11:44.181+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.181+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:174,0.210000,0.210000,0.140000
06-07 17:11:44.191+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.191+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:194,-0.972413,-4.920922,8.426702
06-07 17:11:44.191+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.191+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:185,-0.976272,-4.955536,8.520842
06-07 17:11:44.191+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.201+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:201,0.210000,0.210000,0.140000
06-07 17:11:44.201+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:182,0.030553,-0.073764,0.069260
06-07 17:11:44.201+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.201+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:210,-1.000200,-4.950750,8.504091
06-07 17:11:44.211+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.211+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:203,-0.972783,-4.922695,8.425625
06-07 17:11:44.211+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.221+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.221+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:212,-0.029514,-0.064047,0.109993
06-07 17:11:44.221+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.221+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:223,-1.031307,-4.974678,8.501699
06-07 17:11:44.221+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:229,-0.028569,-0.081896,0.089046
06-07 17:11:44.221+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:225,0.210000,0.210000,0.070000
06-07 17:11:44.231+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.231+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:224,-0.972239,-4.923651,8.425129
06-07 17:11:44.231+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.241+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.241+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.241+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:242,-0.993021,-5.012963,8.461020
06-07 17:11:44.251+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.251+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:245,0.350000,-0.070000,0.070000
06-07 17:11:44.251+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.261+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:248,-0.032132,-0.117707,0.077271
06-07 17:11:44.261+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.261+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:264,-0.969093,-5.010571,8.542377
06-07 17:11:44.261+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.261+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:264,0.560000,-0.140000,0.070000
06-07 17:11:44.261+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.271+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:245,-0.972281,-4.922375,8.425870
06-07 17:11:44.271+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.271+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:272,-0.995414,-4.953143,8.496914
06-07 17:11:44.271+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:44.271+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:44:280,749.000000
06-07 17:11:44.281+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.281+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:266,0.021131,-0.057929,0.082103
06-07 17:11:44.281+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:286,-0.990629,-4.931608,8.468199
06-07 17:11:44.281+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.291+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:279,-0.970679,-4.923446,8.425429
06-07 17:11:44.291+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:294,-0.945165,-4.941179,8.511270
06-07 17:11:44.291+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.291+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:273,0.280000,0.280000,0.070000
06-07 17:11:44.291+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.301+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:302,-0.957129,-4.962714,8.506484
06-07 17:11:44.301+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.301+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:309,-0.976272,-4.986642,8.506484
06-07 17:11:44.301+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.301+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.311+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:315,-0.969673,-4.923015,8.425797
06-07 17:11:44.311+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:315,-0.935594,-4.986642,8.520842
06-07 17:11:44.311+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.321+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:44.321+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:322,-0.921237,-4.936393,8.480164
06-07 17:11:44.321+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.321+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:44:327,78
06-07 17:11:44.321+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.321+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:329,-1.033699,-4.996214,8.499306
06-07 17:11:44.331+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.331+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:304,0.031338,0.009892,0.116157
06-07 17:11:44.331+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.331+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:338,-0.969093,-4.936393,8.439486
06-07 17:11:44.331+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.341+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.341+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:332,-0.140000,0.280000,0.140000
06-07 17:11:44.341+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.341+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:347,-0.985843,-4.977071,8.513663
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:44.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391504353,000000, pattern:[H:mm][0;m
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:44.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:44.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:11:44.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:11][0;m
06-07 17:11:44.361+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:341,-0.019919,-0.042056,0.078160
06-07 17:11:44.361+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.361+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:345,-0.970557,-4.924108,8.425056
06-07 17:11:44.361+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.371+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:346,-0.140000,0.280000,-0.070000
06-07 17:11:44.371+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.381+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:377,0.490000,0.280000,0.070000
06-07 17:11:44.381+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.401+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.401+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:366,-0.037956,-0.036577,0.098555
06-07 17:11:44.401+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:44.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(17504), cmd(0)
06-07 17:11:44.401+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:374,-0.970248,-4.923045,8.425713
06-07 17:11:44.401+0200 W/CAPI_APPFW_APP_CONTROL(17504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:44.401+0200 I/utils   (17504): specific action
06-07 17:11:44.401+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.401+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:408,-1.038485,-4.917251,8.484949
06-07 17:11:44.401+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.411+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:415,-0.995414,-4.945964,8.549555
06-07 17:11:44.411+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.411+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.421+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:423,-0.947558,-4.938786,8.547162
06-07 17:11:44.421+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.421+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:413,-0.024986,-0.030471,0.068336
06-07 17:11:44.421+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.421+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:430,-0.937986,-5.060820,8.499306
06-07 17:11:44.431+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.431+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:424,-0.970358,-4.923001,8.425725
06-07 17:11:44.431+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.431+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:438,-0.969093,-4.955536,8.511270
06-07 17:11:44.431+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.441+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:394,0.280000,0.280000,0.140000
06-07 17:11:44.441+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.441+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:445,-0.964308,-4.972286,8.513663
06-07 17:11:44.441+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:448,-0.350000,0.280000,0.070000
06-07 17:11:44.441+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:44.441+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.441+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:44:451,-0.280000,-0.140000,0.140000
06-07 17:11:44.451+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:452,-0.937986,-4.993821,8.496914
06-07 17:11:44.451+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.451+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:458,-0.997807,-4.984250,8.537591
06-07 17:11:44.451+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:44.451+0200 I/utils   (17419): specific action
06-07 17:11:44.451+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:44.451+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(17419), cmd(0)
06-07 17:11:44.451+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.461+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:44:431,-0.018502,0.014027,0.077538
06-07 17:11:44.461+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:465,-0.995414,-5.003392,8.516055
06-07 17:11:44.461+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:44.461+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.461+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:44:471,-1.000200,-5.039285,8.504091
06-07 17:11:44.471+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:44.471+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:44:439,-0.969872,-4.925314,8.424430
06-07 17:11:44.471+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:44.471+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:44.481+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11174956c6f63152838430
