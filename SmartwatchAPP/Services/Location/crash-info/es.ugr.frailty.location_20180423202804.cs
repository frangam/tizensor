S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8556
Date: 2018-04-23 20:28:04+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf717452d, r5   = 0xf739ef98
r6   = 0xffc674c0, r7   = 0xffc67370
r8   = 0xf739bc18, r9   = 0x00000000
r10  = 0xffc6744c, fp   = 0xffc674c0
ip   = 0x00000001, sp   = 0xffc67348
lr   = 0xf7174539, pc   = 0xf71dd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5548 KB
Buffers:     41208 KB
Cached:     159040 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11548 KB
VmRSS:       11548 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8556 TID = 8556
8556 8563 

Maps Information
f403f000 f483e000 rw-p [stack:8563]
f4845000 f4847000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f484f000 f4853000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f485c000 f485e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4866000 f4869000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4878000 f487d000 r-xp /usr/lib/libsystem.so.0.0.0
f4888000 f488b000 r-xp /lib/libattr.so.1.1.0
f4893000 f48a3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48ab000 f48b4000 r-xp /usr/lib/libedbus.so.1.7.99
f48bc000 f48bd000 r-xp /usr/lib/libresponse.so.0.2.96
f48c6000 f48cb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f616d000 f6273000 r-xp /usr/lib/libicuuc.so.57.1
f6289000 f6411000 r-xp /usr/lib/libicui18n.so.57.1
f6421000 f642e000 r-xp /usr/lib/libail.so.0.1.0
f6437000 f643e000 r-xp /usr/lib/libminizip.so.1.0.0
f6447000 f65f0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6610000 f6657000 r-xp /usr/lib/libssl.so.1.0.0
f6663000 f6665000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f666d000 f6674000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f667d000 f6684000 r-xp /lib/libcrypt-2.13.so
f66b5000 f66b8000 r-xp /lib/libcap.so.2.21
f66c0000 f66c2000 r-xp /usr/lib/libiri.so
f66ca000 f6713000 r-xp /usr/lib/libmdm.so.1.2.69
f671b000 f6721000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6729000 f674c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6756000 f6758000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6760000 f677d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6786000 f678a000 r-xp /usr/lib/libsmack.so.1.0.0
f6793000 f67ac000 r-xp /usr/lib/libnetwork.so.0.0.0
f67b5000 f67bd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67c5000 f67cb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67d4000 f67d6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67df000 f67ef000 r-xp /lib/libresolv-2.13.so
f67f3000 f680b000 r-xp /usr/lib/liblzma.so.5.0.3
f6814000 f6816000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f681e000 f6838000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6840000 f686f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6878000 f6887000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6891000 f689b000 r-xp /usr/lib/libsensord-shared.so
f68a4000 f6977000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6982000 f6998000 r-xp /lib/libz.so.1.2.5
f69a0000 f69a5000 r-xp /usr/lib/libffi.so.5.0.10
f69ad000 f69ae000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69b6000 f69c6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69ce000 f69e7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69ef000 f69f1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69f9000 f6a6e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a78000 f6a7e000 r-xp /lib/librt-2.13.so
f6a87000 f6aa5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aaf000 f6ab0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ab8000 f6adb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ae3000 f6ae8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6af0000 f6b1a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b23000 f6b3a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b42000 f6bab000 r-xp /lib/libm-2.13.so
f6bb4000 f6c48000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c5b000 f6c60000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c68000 f6c6f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c77000 f6ca1000 r-xp /usr/lib/libsensor.so.1.9.6
f6caa000 f6d76000 r-xp /usr/lib/libxml2.so.2.7.8
f6d83000 f6d85000 r-xp /usr/lib/libiniparser.so.0
f6d8e000 f6d94000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d9d000 f6e6d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e6e000 f6ea2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6eab000 f6ee7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6eef000 f6ef2000 r-xp /usr/lib/libbundle.so.0.1.22
f6efa000 f6f00000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f08000 f6f49000 r-xp /usr/lib/libeina.so.1.7.99
f6f52000 f6f69000 r-xp /usr/lib/libecore.so.1.7.99
f6f80000 f6f89000 r-xp /usr/lib/libvconf.so.0.2.45
f6f91000 f6fa5000 r-xp /lib/libpthread-2.13.so
f6fb0000 f6fbd000 r-xp /usr/lib/libaul.so.0.1.0
f6fc7000 f6fc9000 r-xp /lib/libdl-2.13.so
f6fd2000 f6fdd000 r-xp /lib/libunwind.so.8.0.1
f700a000 f7012000 r-xp /lib/libgcc_s-4.6.so.1
f7013000 f7137000 r-xp /lib/libc-2.13.so
f7145000 f7147000 r-xp /usr/lib/libdlog.so.0.0.0
f714f000 f715b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7164000 f7169000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7171000 f7180000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7188000 f718c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7195000 f7198000 r-xp /usr/lib/libappcore-agent.so.1.1
f71a0000 f71a2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71aa000 f71ae000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71b6000 f71d3000 r-xp /lib/ld-2.13.so
f71dc000 f71df000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71df000 f71e3000 r-xp /usr/lib/libsys-assert.so
f736b000 f73dc000 rw-p [heap]
ffc48000 ffc69000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8556)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71dd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7174539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e7b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e79c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e85e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e8bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e8bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ec075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ebb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e79c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e85e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e8bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e8bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ebde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ebe017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ec5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf485d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4850171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6923663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6dd0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dd27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f62ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f5db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f5e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f5e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7196183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71967fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71dd4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf702a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf71dcf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
roscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:458,-0.070000,-0.070000,0.070000
04-23 20:28:03.479+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.479+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:484,-0.070000,-0.140000,-0.070000
04-23 20:28:03.479+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.479+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:473,-0.035463,0.027362,-0.044970
04-23 20:28:03.489+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.489+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:493,0.018779,9.771420,0.830299
04-23 20:28:03.489+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.509+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.509+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:501,-0.045898,0.051653,-0.073176
04-23 20:28:03.509+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:497,0.004786,9.824929,0.768096
04-23 20:28:03.509+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.509+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.519+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.519+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:524,0.045464,9.805787,0.801596
04-23 20:28:03.529+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:516,-0.070000,-0.140000,-0.070000
04-23 20:28:03.529+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.529+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:522,0.019892,9.772072,0.822562
04-23 20:28:03.539+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.539+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.539+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:532,-0.014843,0.053979,-0.067679
04-23 20:28:03.549+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.549+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:28:03.549+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:28:03.549+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:546,0.019247,9.772589,0.816404
04-23 20:28:03.549+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:547,0.009571,9.846465,0.748954
04-23 20:28:03.549+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:540,-0.070000,-0.070000,-0.070000
04-23 20:28:03.549+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.559+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:562,-0.070000,-0.070000,-0.070000
04-23 20:28:03.559+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.559+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.559+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:554,0.026685,0.034368,-0.028704
04-23 20:28:03.569+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.569+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:577,-0.010320,0.074393,-0.073608
04-23 20:28:03.569+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.579+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:573,0.014357,9.781858,0.842274
04-23 20:28:03.579+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:571,0.019177,9.772208,0.820956
04-23 20:28:03.579+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.579+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.589+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.589+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:584,-0.070000,-0.070000,0.070000
04-23 20:28:03.589+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:593,0.019450,9.772156,0.821570
04-23 20:28:03.589+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:590,0.021535,9.767502,0.775275
04-23 20:28:03.599+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.599+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:598,-0.004890,0.009270,0.025870
04-23 20:28:03.599+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.599+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.609+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:606,-0.070000,-0.070000,0.070000
04-23 20:28:03.609+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:612,0.019517,9.772621,0.816016
04-23 20:28:03.609+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.619+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.619+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:611,0.023928,9.801002,0.789631
04-23 20:28:03.619+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.619+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.629+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:633,0.020209,9.772425,0.818350
04-23 20:28:03.629+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.629+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:637,0.019161,9.772095,0.822300
04-23 20:28:03.629+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.639+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:642,0.020225,9.772110,0.822094
04-23 20:28:03.639+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.639+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:646,0.017613,9.771500,0.829375
04-23 20:28:03.639+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.649+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:652,0.019091,9.771702,0.826958
04-23 20:28:03.649+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.649+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:656,0.019369,9.771594,0.828224
04-23 20:28:03.649+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.659+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:660,0.021659,9.771695,0.826979
04-23 20:28:03.659+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.659+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:664,0.020340,9.771341,0.831177
04-23 20:28:03.659+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.669+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:670,0.021808,9.771519,0.829059
04-23 20:28:03.669+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.669+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:674,0.023198,9.771492,0.829332
04-23 20:28:03.669+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.689+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:633,-0.070000,-0.070000,-0.070000
04-23 20:28:03.719+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:678,0.021652,9.771238,0.832355
04-23 20:28:03.719+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.759+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:28:03.759+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:28:03.769+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:621,0.002358,-0.004706,-0.045681
04-23 20:28:03.769+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:724,0.021121,9.771037,0.834731
04-23 20:28:03.769+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.769+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.769+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.789+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:668,0.031107,9.858429,0.820738
04-23 20:28:03.789+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:783,0.004478,0.028846,-0.031938
04-23 20:28:03.789+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.789+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:789,-0.070000,-0.070000,0.070000
04-23 20:28:03.799+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.799+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:785,0.023769,9.771115,0.833740
04-23 20:28:03.799+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.799+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.819+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:816,-0.070000,0.070000,0.070000
04-23 20:28:03.819+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:801,-0.004786,9.808180,0.780060
04-23 20:28:03.829+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:813,0.023709,9.770854,0.836797
04-23 20:28:03.829+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.829+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:815,0.011590,0.085808,0.004722
04-23 20:28:03.829+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:837,0.038285,9.805787,0.792024
04-23 20:28:03.829+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.839+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.839+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.849+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:845,-0.070000,-0.070000,0.070000
04-23 20:28:03.849+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:848,0.023415,9.770568,0.840143
04-23 20:28:03.849+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.859+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:853,-0.024995,0.035755,-0.038290
04-23 20:28:03.869+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.869+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.869+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:875,-0.070000,-0.070000,0.070000
04-23 20:28:03.869+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:874,0.023139,9.770525,0.840646
04-23 20:28:03.879+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.879+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:883,0.019124,0.033692,-0.030276
04-23 20:28:03.879+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:863,-0.038285,9.789038,0.801596
04-23 20:28:03.879+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.889+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.889+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.889+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.889+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:897,0.024674,9.770659,0.839044
04-23 20:28:03.899+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:890,0.045464,9.829715,0.784846
04-23 20:28:03.899+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.899+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:901,-0.070000,-0.070000,0.070000
04-23 20:28:03.909+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:904,-0.058510,0.016928,-0.020499
04-23 20:28:03.909+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.909+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.909+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.909+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:918,0.024670,9.770526,0.840591
04-23 20:28:03.919+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:911,0.021535,9.796216,0.801596
04-23 20:28:03.919+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.929+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:925,0.027851,0.058215,-0.044529
04-23 20:28:03.929+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:922,-0.070000,-0.140000,0.070000
04-23 20:28:03.929+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.929+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.939+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.939+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:933,0.064606,9.789038,0.811167
04-23 20:28:03.949+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.949+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:28:03.949+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:28:03.949+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:953,0.002445,0.024514,-0.025363
04-23 20:28:03.949+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:949,-0.070000,-0.070000,0.070000
04-23 20:28:03.959+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:942,0.024099,9.770274,0.843529
04-23 20:28:03.959+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:964,-0.009571,9.805787,0.815953
04-23 20:28:03.959+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.969+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.969+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.969+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:976,0.070000,-0.070000,0.070000
04-23 20:28:03.969+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:03:979,0.045237,0.017444,-0.017058
04-23 20:28:03.979+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.979+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:970,0.023007,9.769953,0.847282
04-23 20:28:03.979+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:03.979+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:03.989+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:03:985,0.047856,9.791430,0.794417
04-23 20:28:03.989+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:03.989+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:03:996,0.070000,-0.140000,0.070000
04-23 20:28:03.999+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:03:991,0.022643,9.769704,0.850157
04-23 20:28:03.999+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:03.999+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.009+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:0,-0.031230,0.034092,-0.011026
04-23 20:28:04.009+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.019+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.019+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:6,0.047856,9.781858,0.818345
04-23 20:28:04.019+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.029+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:21,0.022869,9.770064,0.845988
04-23 20:28:04.029+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:24,-0.070000,-0.140000,0.070000
04-23 20:28:04.039+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.039+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.049+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:52,0.022318,9.770489,0.841091
04-23 20:28:04.049+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:28,0.027516,0.020089,-0.036759
04-23 20:28:04.049+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.049+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:37,-0.011964,9.798609,0.746561
04-23 20:28:04.059+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.059+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.069+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:59,-0.070000,-0.070000,0.070000
04-23 20:28:04.069+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:73,0.021446,9.770914,0.836154
04-23 20:28:04.069+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.069+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:63,0.026049,0.010340,-0.010714
04-23 20:28:04.069+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.069+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:66,0.007178,9.808180,0.796810
04-23 20:28:04.079+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.079+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:81,-0.070000,-0.070000,0.070000
04-23 20:28:04.079+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.089+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.089+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:84,-0.035163,0.027117,-0.082771
04-23 20:28:04.089+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:88,0.074178,9.772287,0.827917
04-23 20:28:04.089+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.099+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:93,0.022797,9.771555,0.828605
04-23 20:28:04.099+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.109+0200 W/LOCATION( 8556): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:28:04.119+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:123,0.019143,9.796216,0.839881
04-23 20:28:04.119+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.119+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:102,-0.070000,-0.070000,0.070000
04-23 20:28:04.129+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.129+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:109,-0.014474,0.036942,-0.035545
04-23 20:28:04.129+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.129+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:136,-0.070000,-0.070000,0.070000
04-23 20:28:04.139+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.149+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:130,0.022668,9.771497,0.829284
04-23 20:28:04.149+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.149+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:28:04.149+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:28:04.149+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.159+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:154,0.022885,9.771197,0.832808
04-23 20:28:04.159+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:144,0.053056,0.001250,-0.006814
04-23 20:28:04.159+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.159+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:149,0.014357,9.769895,0.827917
04-23 20:28:04.159+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.169+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:176,0.014357,9.798609,0.780060
04-23 20:28:04.169+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.169+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:167,-0.070000,0.070000,0.070000
04-23 20:28:04.179+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:173,-0.004627,0.025101,0.006141
04-23 20:28:04.189+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.189+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.189+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:195,-0.070000,-0.070000,0.070000
04-23 20:28:04.189+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.199+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:182,0.021595,9.770978,0.835409
04-23 20:28:04.199+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:200,-0.009352,-0.000959,-0.008881
04-23 20:28:04.209+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.209+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:218,0.021175,9.770862,0.836774
04-23 20:28:04.209+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.219+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:223,-0.070000,0.070000,0.070000
04-23 20:28:04.219+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:204,0.052642,9.832108,0.803988
04-23 20:28:04.219+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.219+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.239+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.239+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:244,0.022169,9.771304,0.831573
04-23 20:28:04.239+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:231,0.021535,9.793823,0.806381
04-23 20:28:04.239+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.249+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:253,-0.070000,0.070000,0.070000
04-23 20:28:04.249+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:233,-0.009058,0.028041,-0.060082
04-23 20:28:04.249+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.249+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.259+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.259+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.269+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:263,0.009571,9.827322,0.818345
04-23 20:28:04.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:04.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:04.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:04.279+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:260,0.029503,0.061584,-0.036658
04-23 20:28:04.309+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:266,0.019806,9.770756,0.838042
04-23 20:28:04.309+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.309+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.309+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:277,-0.070000,0.070000,0.070000
04-23 20:28:04.309+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:317,-0.002393,9.841680,0.827917
04-23 20:28:04.309+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.319+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:322,-0.003139,0.023164,-0.032662
04-23 20:28:04.319+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.329+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:325,0.019689,9.770623,0.839591
04-23 20:28:04.329+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:334,-0.070000,-0.070000,0.070000
04-23 20:28:04.329+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.339+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.339+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.349+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:28:04.349+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:28:04.349+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.359+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:346,-0.015098,0.056796,-0.022246
04-23 20:28:04.369+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:343,0.011964,9.808180,0.835095
04-23 20:28:04.369+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.369+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.369+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:356,0.019525,9.771184,0.833043
04-23 20:28:04.369+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:376,0.023928,9.815358,0.727418
04-23 20:28:04.379+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.379+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:363,-0.070000,-0.070000,0.070000
04-23 20:28:04.389+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.389+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:394,-0.070000,-0.070000,0.070000
04-23 20:28:04.399+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.399+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:384,-0.026491,0.071405,-0.015612
04-23 20:28:04.399+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.399+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:390,0.019932,9.771792,0.825873
04-23 20:28:04.399+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:407,0.014357,9.803394,0.796810
04-23 20:28:04.409+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:413,-0.011043,0.038227,-0.012187
04-23 20:28:04.409+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.409+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:417,0.020210,9.772260,0.820311
04-23 20:28:04.409+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.419+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:423,-0.070000,-0.070000,-0.070000
04-23 20:28:04.419+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.419+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.429+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.429+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:437,0.001285,0.045654,-0.122739
04-23 20:28:04.439+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.459+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:433,0.007178,9.808180,0.775275
04-23 20:28:04.459+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.459+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.459+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:443,0.021678,9.772270,0.820151
04-23 20:28:04.459+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.469+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:450,-0.070000,-0.070000,-0.070000
04-23 20:28:04.469+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:473,0.022613,9.771950,0.823936
04-23 20:28:04.469+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:471,-0.008512,0.033330,-0.049178
04-23 20:28:04.469+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:466,0.052642,9.774680,0.803988
04-23 20:28:04.479+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.479+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:483,-0.070000,-0.210000,-0.070000
04-23 20:28:04.479+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.479+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.489+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.489+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:494,-0.015139,0.037691,-0.065817
04-23 20:28:04.509+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.509+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:491,0.016750,9.767502,0.777667
04-23 20:28:04.519+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.519+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.519+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:498,0.022155,9.771671,0.827241
04-23 20:28:04.529+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:539,0.031196,0.003766,-0.032166
04-23 20:28:04.539+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.539+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:519,-0.070000,-0.070000,0.070000
04-23 20:28:04.539+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.549+0200 I/servicemanager( 8242): es.ugr.frailty.location sleep timeout
04-23 20:28:04.549+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:28:04.549+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:535,0.023928,9.772287,0.847059
04-23 20:28:04.549+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:28:04.549+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:28:04.549+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.549+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.559+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:544,0.021709,9.771523,0.829017
04-23 20:28:04.569+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.569+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:572,-0.006047,-0.004053,-0.050938
04-23 20:28:04.569+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:555,-0.070000,-0.070000,0.070000
04-23 20:28:04.569+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:579,0.023327,9.771539,0.828774
04-23 20:28:04.579+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:570,-0.007178,9.827322,0.768096
04-23 20:28:04.579+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:04.589+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:04.589+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.589+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.599+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.599+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8556
04-23 20:28:04.599+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8556)
04-23 20:28:04.599+0200 I/servicemanager( 8242): es.ugr.frailty.location stop request sent!
04-23 20:28:04.599+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:28:04.609+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:593,-0.070000,-0.070000,0.070000
04-23 20:28:04.609+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:602,0.009571,9.834501,0.784846
04-23 20:28:04.619+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.629+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.629+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:613,0.024519,9.771531,0.828834
04-23 20:28:04.629+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:609,0.001261,0.000791,0.017775
04-23 20:28:04.629+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.629+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:639,0.045464,9.801002,0.827917
04-23 20:28:04.639+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.649+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:630,-0.070000,-0.070000,0.070000
04-23 20:28:04.649+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.659+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:646,-0.030064,0.056125,-0.064712
04-23 20:28:04.659+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.659+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:650,0.025986,9.771367,0.830714
04-23 20:28:04.669+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.669+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.669+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:660,-0.070000,-0.070000,-0.070000
04-23 20:28:04.679+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.679+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:667,-0.031107,9.815358,0.825524
04-23 20:28:04.689+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.689+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:674,-0.012023,0.063523,-0.050564
04-23 20:28:04.689+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:676,0.025395,9.771018,0.834838
04-23 20:28:04.699+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.699+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:697,0.014357,9.808180,0.784846
04-23 20:28:04.709+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.719+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:717,0.026647,9.770761,0.837788
04-23 20:28:04.719+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:691,-0.070000,0.070000,0.070000
04-23 20:28:04.729+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.729+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.739+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.739+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:718,0.024289,0.030140,-0.008857
04-23 20:28:04.759+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:28:04.759+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:28:04.769+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:743,0.019143,9.793823,0.787239
04-23 20:28:04.769+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.779+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:740,-0.070000,0.070000,0.070000
04-23 20:28:04.779+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:789,-0.053276,0.044054,-0.006049
04-23 20:28:04.789+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:782,0.027803,9.770755,0.837837
04-23 20:28:04.789+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.789+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.789+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:799,-0.070000,-0.140000,-0.070000
04-23 20:28:04.799+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:802,0.031107,9.822537,0.794417
04-23 20:28:04.799+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.809+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.809+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:814,0.027661,9.770675,0.838769
04-23 20:28:04.809+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:818,-0.005449,0.037424,-0.053197
04-23 20:28:04.809+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.819+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.829+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.829+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.829+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:838,0.026700,9.770592,0.839764
04-23 20:28:04.839+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:843,-0.000546,0.023200,-0.052352
04-23 20:28:04.839+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:824,0.070000,-0.140000,-0.070000
04-23 20:28:04.839+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:829,0.028714,9.798609,0.799203
04-23 20:28:04.839+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.839+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.849+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:853,-0.070000,-0.140000,-0.070000
04-23 20:28:04.849+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:856,0.047856,9.829715,0.794417
04-23 20:28:04.859+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.859+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.879+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.879+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.879+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:870,0.011582,0.051353,-0.038625
04-23 20:28:04.889+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:865,0.027768,9.770793,0.837388
04-23 20:28:04.889+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.889+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.889+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:885,-0.070000,-0.070000,0.070000
04-23 20:28:04.899+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:903,0.028664,9.771070,0.834126
04-23 20:28:04.909+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:890,0.038285,9.779467,0.847059
04-23 20:28:04.909+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.909+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.909+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:916,0.009571,9.812965,0.830309
04-23 20:28:04.919+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:04.919+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:909,0.008782,0.026816,-0.026670
04-23 20:28:04.919+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:04.929+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:915,-0.070000,-0.070000,0.070000
04-23 20:28:04.929+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:04.939+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:04:932,0.027646,0.057455,-0.025894
04-23 20:28:04.939+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:04.949+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:926,0.029306,9.770852,0.836649
04-23 20:28:04.949+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:28:04.949+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:28:04.949+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:05.009+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:04:967,0.029677,9.771232,0.832188
04-23 20:28:05.009+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:05.009+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:05:18,0.016607,0.007196,0.026908
04-23 20:28:05.009+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:04:947,-0.070000,-0.070000,0.070000
04-23 20:28:05.019+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:05.019+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:04:950,0.009571,9.801002,0.799203
04-23 20:28:05.019+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:05.019+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:05.029+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:05.039+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:05:26,0.070000,-0.070000,0.070000
04-23 20:28:05.039+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:05:29,0.052642,9.798609,0.799203
04-23 20:28:05.039+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:05.039+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:05.049+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:05:53,-0.070000,0.070000,0.070000
04-23 20:28:05.049+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:05:56,0.045464,9.810574,0.794417
04-23 20:28:05.049+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:05:46,-0.013042,0.041016,0.006374
04-23 20:28:05.049+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:05:39,0.028525,9.771115,0.833587
04-23 20:28:05.059+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:05.059+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:05.059+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:05:65,0.026639,9.770846,0.836802
04-23 20:28:05.069+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:05.069+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:05:73,-0.012583,0.029330,-0.028038
04-23 20:28:05.069+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:05.069+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:05:79,0.052642,9.834501,0.839881
04-23 20:28:05.079+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:05:83,-0.070000,0.140000,0.070000
04-23 20:28:05.079+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:05.079+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11085566c6f63152450808
