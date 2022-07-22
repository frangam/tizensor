S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13653
Date: 2018-06-07 16:58:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72aa52d, r5   = 0xf754df98
r6   = 0xffb72b60, r7   = 0xffb72a10
r8   = 0xf754ac18, r9   = 0x00000000
r10  = 0xffb72aec, fp   = 0xffb72b60
ip   = 0x00000001, sp   = 0xffb729e8
lr   = 0xf72aa539, pc   = 0xf7313228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    280492 KB
Buffers:      7244 KB
Cached:      50952 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11704 KB
VmRSS:       11704 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13653 TID = 13653
13653 13657 

Maps Information
f4175000 f4974000 rw-p [stack:13657]
f497b000 f497d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4985000 f4989000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4992000 f4994000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f499c000 f499f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49ae000 f49b3000 r-xp /usr/lib/libsystem.so.0.0.0
f49be000 f49c1000 r-xp /lib/libattr.so.1.1.0
f49c9000 f49d9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49e1000 f49ea000 r-xp /usr/lib/libedbus.so.1.7.99
f49f2000 f49f3000 r-xp /usr/lib/libresponse.so.0.2.96
f49fc000 f4a01000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62a3000 f63a9000 r-xp /usr/lib/libicuuc.so.57.1
f63bf000 f6547000 r-xp /usr/lib/libicui18n.so.57.1
f6557000 f6564000 r-xp /usr/lib/libail.so.0.1.0
f656d000 f6574000 r-xp /usr/lib/libminizip.so.1.0.0
f657d000 f6726000 r-xp /usr/lib/libcrypto.so.1.0.0
f6746000 f678d000 r-xp /usr/lib/libssl.so.1.0.0
f6799000 f679b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67a3000 f67aa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67b3000 f67ba000 r-xp /lib/libcrypt-2.13.so
f67eb000 f67ee000 r-xp /lib/libcap.so.2.21
f67f6000 f67f8000 r-xp /usr/lib/libiri.so
f6800000 f6849000 r-xp /usr/lib/libmdm.so.1.2.69
f6851000 f6857000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f685f000 f6882000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f688c000 f688e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6896000 f68b3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68bc000 f68c0000 r-xp /usr/lib/libsmack.so.1.0.0
f68c9000 f68e2000 r-xp /usr/lib/libnetwork.so.0.0.0
f68eb000 f68f3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68fb000 f6901000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f690a000 f690c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6915000 f6925000 r-xp /lib/libresolv-2.13.so
f6929000 f6941000 r-xp /usr/lib/liblzma.so.5.0.3
f694a000 f694c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6954000 f696e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6976000 f69a5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69ae000 f69bd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69c7000 f69d1000 r-xp /usr/lib/libsensord-shared.so
f69da000 f6aad000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ab8000 f6ace000 r-xp /lib/libz.so.1.2.5
f6ad6000 f6adb000 r-xp /usr/lib/libffi.so.5.0.10
f6ae3000 f6ae4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6aec000 f6afc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b04000 f6b1d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b25000 f6b27000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b2f000 f6ba4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bae000 f6bb4000 r-xp /lib/librt-2.13.so
f6bbd000 f6bdb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6be5000 f6be6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bee000 f6c11000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c19000 f6c1e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c26000 f6c50000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c59000 f6c70000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c78000 f6ce1000 r-xp /lib/libm-2.13.so
f6cea000 f6d7e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d91000 f6d96000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d9e000 f6da5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dad000 f6dd7000 r-xp /usr/lib/libsensor.so.1.9.6
f6de0000 f6eac000 r-xp /usr/lib/libxml2.so.2.7.8
f6eb9000 f6ebb000 r-xp /usr/lib/libiniparser.so.0
f6ec4000 f6eca000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ed3000 f6fa3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fa4000 f6fd8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fe1000 f701d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7025000 f7028000 r-xp /usr/lib/libbundle.so.0.1.22
f7030000 f7036000 r-xp /usr/lib/libappsvc.so.0.1.0
f703e000 f707f000 r-xp /usr/lib/libeina.so.1.7.99
f7088000 f709f000 r-xp /usr/lib/libecore.so.1.7.99
f70b6000 f70bf000 r-xp /usr/lib/libvconf.so.0.2.45
f70c7000 f70db000 r-xp /lib/libpthread-2.13.so
f70e6000 f70f3000 r-xp /usr/lib/libaul.so.0.1.0
f70fd000 f70ff000 r-xp /lib/libdl-2.13.so
f7108000 f7113000 r-xp /lib/libunwind.so.8.0.1
f7140000 f7148000 r-xp /lib/libgcc_s-4.6.so.1
f7149000 f726d000 r-xp /lib/libc-2.13.so
f727b000 f727d000 r-xp /usr/lib/libdlog.so.0.0.0
f7285000 f7291000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f729a000 f729f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72a7000 f72b6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72be000 f72c2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72cb000 f72ce000 r-xp /usr/lib/libappcore-agent.so.1.1
f72d6000 f72d8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72e0000 f72e4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72ec000 f7309000 r-xp /lib/ld-2.13.so
f7312000 f7315000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7315000 f7319000 r-xp /usr/lib/libsys-assert.so
f751a000 f75a8000 rw-p [heap]
ffb54000 ffb75000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13653)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7313228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72aa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fb13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fafc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fbbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fc1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fc1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ff675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ff11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fafc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fbbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fc1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fc1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ff3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ff4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ffbf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49931fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4986171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a59663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f06fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f087a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7098ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7093b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70945a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7094879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72cc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72cc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73135c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf716085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7312f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
00000
06-07 16:58:37.751+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.751+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:755,2.294022,-1.804669,9.362212
06-07 16:58:37.761+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:754,-0.232281,-0.771323,0.143425
06-07 16:58:37.761+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:37.761+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.761+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:37.761+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:769,2.243342,-1.750723,9.384709
06-07 16:58:37.771+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:759,2.115255,-2.612962,9.485149
06-07 16:58:37.771+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.771+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:767,-0.171588,-0.765223,0.048759
06-07 16:58:37.771+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:37:769,30.730000,3.080000,-10.080000
06-07 16:58:37.771+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:37.771+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:778,2.122434,-2.569891,9.410972
06-07 16:58:37.781+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:37.781+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.781+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.781+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:787,2.184809,-1.644073,9.417750
06-07 16:58:37.791+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:37:781,40.180000,-0.980000,-13.510000
06-07 16:58:37.791+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:787,0.271514,-0.613386,0.291865
06-07 16:58:37.791+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:37.791+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:793,2.514857,-2.364109,9.676575
06-07 16:58:37.791+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:37:797,61.740002,-1.960000,-15.050000
06-07 16:58:37.801+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:37.801+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.801+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:807,2.127512,-1.526125,9.450663
06-07 16:58:37.801+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:807,0.172121,-0.191222,-0.219740
06-07 16:58:37.801+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.801+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:37.811+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:813,2.356930,-1.835295,9.198010
06-07 16:58:37.811+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:37:815,60.760002,-2.380000,-15.260000
06-07 16:58:37.821+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.821+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:37.821+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:825,2.102085,-1.442652,9.469444
06-07 16:58:37.821+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.821+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:827,0.380167,-0.361812,0.027308
06-07 16:58:37.821+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:37.831+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:831,2.507678,-1.887937,9.477970
06-07 16:58:37.831+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:37:832,48.230000,-7.770000,-14.910000
06-07 16:58:37.841+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:37.841+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.851+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:853,0.393629,-0.328037,0.264559
06-07 16:58:37.851+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:853,2.069423,-1.349837,9.490301
06-07 16:58:37.851+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.851+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:37.851+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:37:859,51.380001,-8.540000,-14.070000
06-07 16:58:37.851+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:858,2.495714,-1.770689,9.734003
06-07 16:58:37.861+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.861+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:37.861+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:866,1.999769,-1.176911,9.528179
06-07 16:58:37.861+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.861+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:37.871+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:867,0.318614,0.486028,0.365735
06-07 16:58:37.871+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:874,2.388037,-0.863809,9.856036
06-07 16:58:37.871+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:37:874,71.750000,-9.940000,-12.040000
06-07 16:58:37.881+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:37.881+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.881+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:37.881+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:887,1.919422,-0.967228,9.568212
06-07 16:58:37.881+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:888,0.421768,1.243910,-0.497666
06-07 16:58:37.881+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.891+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:895,2.421536,0.066999,9.030513
06-07 16:58:37.891+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:37:895,70.629997,-6.790000,-12.110000
06-07 16:58:37.901+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:37.901+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.901+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:58:37.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:58:37.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:37.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:37.901+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:907,1.873040,-0.812617,9.591755
06-07 16:58:37.911+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.911+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:916,2.469393,0.413958,9.245867
06-07 16:58:37.921+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13664
06-07 16:58:37.921+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13664)
06-07 16:58:37.921+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:58:37.921+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:37.921+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:58:37.921+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:58:37.931+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:37.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:37.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:37.931+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:37:936,82
06-07 16:58:37.941+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:927,1.851593,-0.705941,9.604355
06-07 16:58:37.941+0200 W/CAPI_APPFW_APP_CONTROL(13664): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:37.941+0200 I/utils   (13664): specific action
06-07 16:58:37.941+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.941+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:37.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13724
06-07 16:58:37.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13724)
06-07 16:58:37.951+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:58:37.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:37.951+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:37.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13664), cmd(0)
06-07 16:58:37.951+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:58:37.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:58:37.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:37.951+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.951+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:37:954,828.000000
06-07 16:58:37.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:37.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:58:37.971+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:37.971+0200 I/utils   (12595): specific action
06-07 16:58:37.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:58:37.971+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:58:37.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:37.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12595), cmd(0)
06-07 16:58:37.971+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:37.971+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:58:37.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:58:37.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:37.971+0200 W/CAPI_APPFW_APP_CONTROL(13724): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:37.971+0200 I/utils   (13724): specific action
06-07 16:58:37.971+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:37.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:37.981+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:907,0.549971,1.381186,-0.322345
06-07 16:58:37.981+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:37.981+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:964,1.834926,-0.617842,9.613621
06-07 16:58:37.981+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:37.981+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:949,2.435893,0.452243,9.667004
06-07 16:58:37.991+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:37.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13653
06-07 16:58:38.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13653)
06-07 16:58:38.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:38.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13724), cmd(0)
06-07 16:58:38.001+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:58:38.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:38.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13653), cmd(0)
06-07 16:58:38.001+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:38.001+0200 W/CAPI_APPFW_APP_CONTROL(13653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:38.001+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:58:38.001+0200 I/utils   (13653): specific action
06-07 16:58:38.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:58:38.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:38.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:38.011+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:37:983,41.230000,-8.190000,-12.040000
06-07 16:58:38.011+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:37:989,0.562853,1.264860,0.075249
06-07 16:58:38.011+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:37:997,2.462214,0.569492,9.540184
06-07 16:58:38.011+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.011+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.011+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:37:994,1.807516,-0.533579,9.623854
06-07 16:58:38.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13728
06-07 16:58:38.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13728)
06-07 16:58:38.021+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:58:38.021+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:38.021+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:58:38.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:58:38.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:38.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:38.021+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.021+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.031+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:30,0.610621,1.275432,-0.064171
06-07 16:58:38.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13685
06-07 16:58:38.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13685)
06-07 16:58:38.041+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:58:38.041+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:38.041+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:58:38.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:58:38.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:38.041+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:25,21.000000,-9.240000,-12.320000
06-07 16:58:38.041+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.041+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:38.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:58:38.051+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:38.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12603), cmd(0)
06-07 16:58:38.051+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:38.051+0200 I/utils   (12603): specific action
06-07 16:58:38.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:58:38.061+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:58:38.061+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:38.061+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:58:38.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:58:38.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:38.061+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.061+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:38.071+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:39,2.376073,0.586242,9.427721
06-07 16:58:38.071+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:35,1.773680,-0.455304,9.634165
06-07 16:58:38.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:58:38.071+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:38.071+0200 I/utils   (12614): specific action
06-07 16:58:38.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:58:38.071+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:58:38.071+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:38.071+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:58:38.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:58:38.071+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:38.081+0200 W/CAPI_APPFW_APP_CONTROL(13685): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:38.081+0200 I/utils   (13685): specific action
06-07 16:58:38.081+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.081+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:38.081+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:49,12.180000,-7.140000,-9.170000
06-07 16:58:38.081+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.091+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:58:38.091+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:70,0.541147,1.204084,-0.185900
06-07 16:58:38.091+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:58:38.091+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:58:38.091+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:38.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:38.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13685), cmd(0)
06-07 16:58:38.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:38.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12614), cmd(0)
06-07 16:58:38.091+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:58:38.091+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:58:38.091+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:58:38.091+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:96,2.333002,0.521635,9.288938
06-07 16:58:38.091+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:38.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(12618), cmd(0)
06-07 16:58:38.091+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:38.091+0200 I/utils   (12618): specific action
06-07 16:58:38.101+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.101+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:106,0.525486,1.055214,-0.334916
06-07 16:58:38.101+0200 W/CAPI_APPFW_APP_CONTROL(13728): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:38.101+0200 I/utils   (13728): specific action
06-07 16:58:38.101+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:38.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13728), cmd(0)
06-07 16:58:38.101+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:93,12.180000,-6.370000,-3.990000
06-07 16:58:38.111+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:87,1.732691,-0.383575,9.644741
06-07 16:58:38.111+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.111+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.111+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:116,1.686676,-0.314553,9.655391
06-07 16:58:38.111+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.111+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:117,13.020000,-6.720000,-0.910000
06-07 16:58:38.111+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.121+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:103,2.373680,0.466600,9.346365
06-07 16:58:38.121+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:122,13.090000,-5.180000,1.120000
06-07 16:58:38.121+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.121+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.121+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:129,2.512464,0.626920,9.145369
06-07 16:58:38.121+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.121+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:130,10.430000,-2.940000,4.410000
06-07 16:58:38.121+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:38.121+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.131+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:38:134,82
06-07 16:58:38.131+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:135,2.800000,2.940000,7.700000
06-07 16:58:38.131+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:112,0.600000,0.921904,-0.287800
06-07 16:58:38.131+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.131+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.131+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:140,0.779773,1.010494,-0.499372
06-07 16:58:38.131+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:140,-3.430000,6.650000,11.200000
06-07 16:58:38.131+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.131+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.141+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:121,4.760759,-0.779468,8.538032
06-07 16:58:38.141+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.141+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:146,4.825502,-0.708866,8.507786
06-07 16:58:38.141+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:146,-11.760000,8.820000,11.480000
06-07 16:58:38.141+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.141+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.141+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:38.151+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:152,-20.930000,12.320000,10.500000
06-07 16:58:38.151+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:38:152,835.000000
06-07 16:58:38.151+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.151+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:133,2.488536,0.820738,9.011370
06-07 16:58:38.151+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:157,-30.730000,11.970000,7.840000
06-07 16:58:38.151+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.151+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.151+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:161,2.667997,0.911665,9.324830
06-07 16:58:38.161+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:162,-25.340000,7.490000,7.560000
06-07 16:58:38.161+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.161+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:144,0.801859,1.135291,-0.644021
06-07 16:58:38.161+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.161+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:168,-9.450000,7.490000,5.740000
06-07 16:58:38.161+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:170,-2.092762,1.691134,0.786798
06-07 16:58:38.161+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.171+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.171+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:150,4.740823,-0.667280,8.558605
06-07 16:58:38.171+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.171+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:176,2.730211,0.325424,9.717253
06-07 16:58:38.171+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.171+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:178,1.687737,-0.270385,9.656543
06-07 16:58:38.171+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.181+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.181+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:174,-2.095292,1.034290,1.209467
06-07 16:58:38.181+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.181+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:186,-1.750000,7.770000,5.180000
06-07 16:58:38.201+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.201+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:207,-12.670000,4.690000,3.290000
06-07 16:58:38.211+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:180,2.553142,-0.538385,9.391829
06-07 16:58:38.211+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.211+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:187,-2.187682,0.128895,0.833223
06-07 16:58:38.211+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.221+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.221+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:227,-24.920000,1.470000,-1.050000
06-07 16:58:38.221+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:220,0.532803,-0.732208,-0.343677
06-07 16:58:38.221+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.231+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:218,2.220540,-1.002593,9.312866
06-07 16:58:38.231+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.241+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:237,2.285146,-1.165305,9.798609
06-07 16:58:38.241+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.251+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:184,1.815028,-0.370651,9.630092
06-07 16:58:38.251+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.251+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:261,1.918174,-0.460463,9.606194
06-07 16:58:38.251+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.261+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:252,-12.320000,0.350000,-0.560000
06-07 16:58:38.261+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.261+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:269,8.400000,1.260000,0.560000
06-07 16:58:38.261+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:235,0.470117,-0.794654,0.168517
06-07 16:58:38.261+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.271+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.271+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:264,1.965661,-0.517447,9.593686
06-07 16:58:38.271+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.271+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:274,0.522505,-0.857982,0.261806
06-07 16:58:38.271+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.281+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:282,1.969649,-0.534790,9.591917
06-07 16:58:38.281+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.281+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:276,2.440679,-1.318445,9.868000
06-07 16:58:38.281+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.281+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:288,2.011161,-0.563383,9.581660
06-07 16:58:38.281+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.281+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.291+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:283,0.400841,-0.336791,0.245600
06-07 16:58:38.291+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.301+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:295,9.100000,1.190000,1.470000
06-07 16:58:38.301+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.301+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:292,2.366502,-0.854238,9.839286
06-07 16:58:38.301+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.311+0200 W/LOCATION(13653): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:58:38.311+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:310,-11.340000,1.330000,2.240000
06-07 16:58:38.311+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:313,2.328217,-0.595813,9.626326
06-07 16:58:38.311+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.321+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:303,0.358567,-0.061023,0.034409
06-07 16:58:38.321+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.321+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.321+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:294,2.112001,-0.644676,9.554801
06-07 16:58:38.321+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.321+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:38.331+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:38:334,83
06-07 16:58:38.331+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:328,0.405590,-0.654564,-0.031905
06-07 16:58:38.331+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:334,2.164149,-0.701090,9.539146
06-07 16:58:38.331+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.331+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.341+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:330,-17.710001,0.630000,2.450000
06-07 16:58:38.341+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:325,2.416751,-1.217947,9.549755
06-07 16:58:38.341+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.341+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:347,2.337788,-1.335195,9.616754
06-07 16:58:38.341+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:58:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:58:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:58:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:58:38.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390718351,000000, pattern:[H:mm][0;m
06-07 16:58:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:58:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:58:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:58:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:58:38.341+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:38.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:58:38.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:58][0;m
06-07 16:58:38.351+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:38:353,823.000000
06-07 16:58:38.351+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.351+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:358,-14.420000,4.760000,2.240000
06-07 16:58:38.351+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:347,2.131412,-0.683211,9.547811
06-07 16:58:38.351+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.351+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:344,0.225786,-0.690519,0.061953
06-07 16:58:38.361+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.361+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.361+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:366,2.097255,-0.627534,9.559190
06-07 16:58:38.361+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:367,-14.630000,0.770000,0.490000
06-07 16:58:38.361+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:366,-0.015394,-0.026328,0.431745
06-07 16:58:38.361+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.371+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:351,2.148755,-0.727418,9.970891
06-07 16:58:38.371+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.371+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.371+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:375,0.046057,0.745425,0.155085
06-07 16:58:38.371+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.381+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.381+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:380,2.131401,-0.616447,9.552356
06-07 16:58:38.381+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.381+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:387,-3.290000,0.280000,-0.420000
06-07 16:58:38.391+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:379,2.177469,0.062213,9.702895
06-07 16:58:38.391+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.391+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:384,0.106535,0.718461,-0.279823
06-07 16:58:38.401+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:392,2.184876,-0.651316,9.537950
06-07 16:58:38.401+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.401+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:408,3.850000,-6.020000,0.630000
06-07 16:58:38.401+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.411+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.411+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:399,2.203789,0.090927,9.279366
06-07 16:58:38.411+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.411+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:416,2.227590,-0.673339,9.526534
06-07 16:58:38.411+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.411+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:413,0.014961,0.034991,0.207968
06-07 16:58:38.421+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.421+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:427,9.730000,-7.420000,1.820000
06-07 16:58:38.421+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.421+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:419,2.146362,-0.581456,9.760324
06-07 16:58:38.431+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:422,2.274977,-0.725327,9.511507
06-07 16:58:38.431+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.431+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.441+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:432,0.181625,0.144038,0.023769
06-07 16:58:38.441+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.441+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:446,0.119769,-0.523072,0.363002
06-07 16:58:38.441+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.441+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.441+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:452,10.780000,-7.070000,2.310000
06-07 16:58:38.451+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:440,2.283450,-0.763694,9.506473
06-07 16:58:38.451+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.451+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:442,2.366502,-0.507278,9.561719
06-07 16:58:38.451+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.461+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.461+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:467,5.180000,-6.580000,3.850000
06-07 16:58:38.461+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:450,-0.044866,-0.707973,0.038248
06-07 16:58:38.471+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:462,2.347359,-1.196411,9.889536
06-07 16:58:38.471+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.471+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:464,2.272062,-0.777969,9.508043
06-07 16:58:38.471+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.471+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.481+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.481+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:487,4.550000,-1.890000,2.660000
06-07 16:58:38.481+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:478,2.230111,-1.433301,9.549755
06-07 16:58:38.481+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.491+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:484,-0.196908,-0.439896,0.160531
06-07 16:58:38.491+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.491+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:499,-0.094594,-0.011662,0.079997
06-07 16:58:38.491+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.501+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:482,2.252532,-0.761376,9.514031
06-07 16:58:38.501+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.501+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:507,3.220000,6.230000,2.030000
06-07 16:58:38.501+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.511+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:495,2.086541,-1.203590,9.667004
06-07 16:58:38.511+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.511+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:512,2.237716,-0.717693,9.520921
06-07 16:58:38.511+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.521+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.521+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:527,-7.770000,5.180000,1.470000
06-07 16:58:38.521+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:38.531+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:38:534,83
06-07 16:58:38.531+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:502,-0.012850,0.524487,-0.461984
06-07 16:58:38.531+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:38.531+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:38:541,0.157499,0.239128,-0.320518
06-07 16:58:38.541+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:38:523,2.241978,-0.699765,9.521253
06-07 16:58:38.541+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:58:38.541+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:38.551+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:38:553,819.000000
06-07 16:58:38.551+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.551+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:38:558,-10.850000,5.810000,-0.070000
06-07 16:58:38.551+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:38:519,2.177469,-0.789631,9.588040
06-07 16:58:38.551+0200 I/accelerometer(13664): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:38.561+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:38.571+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11136536c6f63152838351
