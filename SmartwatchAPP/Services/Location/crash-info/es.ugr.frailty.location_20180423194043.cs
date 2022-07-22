S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19315
Date: 2018-04-23 19:40:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf705c52d, r5   = 0xf753df98
r6   = 0xff9e7180, r7   = 0xff9e7030
r8   = 0xf753ac18, r9   = 0x00000000
r10  = 0xff9e710c, fp   = 0xff9e7180
ip   = 0x00000001, sp   = 0xff9e7008
lr   = 0xf705c539, pc   = 0xf70c5228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8080 KB
Buffers:     55592 KB
Cached:     234304 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12264 KB
VmRSS:       12264 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19315 TID = 19315
19315 19342 

Maps Information
f3f27000 f4726000 rw-p [stack:19342]
f472d000 f472f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4737000 f473b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4744000 f4746000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f474e000 f4751000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4760000 f4765000 r-xp /usr/lib/libsystem.so.0.0.0
f4770000 f4773000 r-xp /lib/libattr.so.1.1.0
f477b000 f478b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4793000 f479c000 r-xp /usr/lib/libedbus.so.1.7.99
f47a4000 f47a5000 r-xp /usr/lib/libresponse.so.0.2.96
f47ae000 f47b3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6055000 f615b000 r-xp /usr/lib/libicuuc.so.57.1
f6171000 f62f9000 r-xp /usr/lib/libicui18n.so.57.1
f6309000 f6316000 r-xp /usr/lib/libail.so.0.1.0
f631f000 f6326000 r-xp /usr/lib/libminizip.so.1.0.0
f632f000 f64d8000 r-xp /usr/lib/libcrypto.so.1.0.0
f64f8000 f653f000 r-xp /usr/lib/libssl.so.1.0.0
f654b000 f654d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6555000 f655c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6565000 f656c000 r-xp /lib/libcrypt-2.13.so
f659d000 f65a0000 r-xp /lib/libcap.so.2.21
f65a8000 f65aa000 r-xp /usr/lib/libiri.so
f65b2000 f65fb000 r-xp /usr/lib/libmdm.so.1.2.69
f6603000 f6609000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6611000 f6634000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f663e000 f6640000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6648000 f6665000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f666e000 f6672000 r-xp /usr/lib/libsmack.so.1.0.0
f667b000 f6694000 r-xp /usr/lib/libnetwork.so.0.0.0
f669d000 f66a5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66ad000 f66b3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66bc000 f66be000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66c7000 f66d7000 r-xp /lib/libresolv-2.13.so
f66db000 f66f3000 r-xp /usr/lib/liblzma.so.5.0.3
f66fc000 f66fe000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6706000 f6720000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6728000 f6757000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6760000 f676f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6779000 f6783000 r-xp /usr/lib/libsensord-shared.so
f678c000 f685f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f686a000 f6880000 r-xp /lib/libz.so.1.2.5
f6888000 f688d000 r-xp /usr/lib/libffi.so.5.0.10
f6895000 f6896000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f689e000 f68ae000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68b6000 f68cf000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68d7000 f68d9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68e1000 f6956000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6960000 f6966000 r-xp /lib/librt-2.13.so
f696f000 f698d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6997000 f6998000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69a0000 f69c3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69cb000 f69d0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69d8000 f6a02000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a0b000 f6a22000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a2a000 f6a93000 r-xp /lib/libm-2.13.so
f6a9c000 f6b30000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b43000 f6b48000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b50000 f6b57000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b5f000 f6b89000 r-xp /usr/lib/libsensor.so.1.9.6
f6b92000 f6c5e000 r-xp /usr/lib/libxml2.so.2.7.8
f6c6b000 f6c6d000 r-xp /usr/lib/libiniparser.so.0
f6c76000 f6c7c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c85000 f6d55000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d56000 f6d8a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d93000 f6dcf000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6dd7000 f6dda000 r-xp /usr/lib/libbundle.so.0.1.22
f6de2000 f6de8000 r-xp /usr/lib/libappsvc.so.0.1.0
f6df0000 f6e31000 r-xp /usr/lib/libeina.so.1.7.99
f6e3a000 f6e51000 r-xp /usr/lib/libecore.so.1.7.99
f6e68000 f6e71000 r-xp /usr/lib/libvconf.so.0.2.45
f6e79000 f6e8d000 r-xp /lib/libpthread-2.13.so
f6e98000 f6ea5000 r-xp /usr/lib/libaul.so.0.1.0
f6eaf000 f6eb1000 r-xp /lib/libdl-2.13.so
f6eba000 f6ec5000 r-xp /lib/libunwind.so.8.0.1
f6ef2000 f6efa000 r-xp /lib/libgcc_s-4.6.so.1
f6efb000 f701f000 r-xp /lib/libc-2.13.so
f702d000 f702f000 r-xp /usr/lib/libdlog.so.0.0.0
f7037000 f7043000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f704c000 f7051000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7059000 f7068000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7070000 f7074000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f707d000 f7080000 r-xp /usr/lib/libappcore-agent.so.1.1
f7088000 f708a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7092000 f7096000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f709e000 f70bb000 r-xp /lib/ld-2.13.so
f70c4000 f70c7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70c7000 f70cb000 r-xp /usr/lib/libsys-assert.so
f750a000 f7594000 rw-p [heap]
ff9c8000 ff9e9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19315)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70c5228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf705c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d633f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d61c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d6de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d73be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d73dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6da875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6da31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d61c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d6de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d73be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d73dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6da5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6da6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6dadf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47451fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4738171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf680b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cb8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cba7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e4aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e45b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e465a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e46879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf707e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf707e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70c54f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f1285c) [/lib/libc.so.6] + 0x1785c
29: (0xf70c4f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
:42.389+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.399+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:399,-2.569613,-9.455737,0.395605
04-23 19:40:42.399+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:399,-9.442079,-9.418150,-0.531207
04-23 19:40:42.399+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.399+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.399+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:405,-7.198946,0.124277,-0.246907
04-23 19:40:42.399+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:407,334.600006,-29.120001,-98.980003
04-23 19:40:42.409+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.409+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.419+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.419+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:419,-7.817629,3.009473,-1.158915
04-23 19:40:42.419+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.419+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:423,-2.795902,-9.359369,0.869211
04-23 19:40:42.429+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:418,-10.387242,-6.446264,-0.763310
04-23 19:40:42.429+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.429+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:427,246.889999,-40.950001,-108.290001
04-23 19:40:42.439+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.439+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:439,-6.354252,1.068239,-0.103508
04-23 19:40:42.439+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.439+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:444,-9.150154,-8.291130,0.765703
04-23 19:40:42.439+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.449+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:447,-2.701752,-9.377769,0.963520
04-23 19:40:42.449+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.449+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.459+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:452,57.889999,-62.510002,-120.959999
04-23 19:40:42.459+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.459+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:459,-4.500645,-3.203693,-1.018555
04-23 19:40:42.459+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.469+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:459,-7.202396,-12.581462,-0.055035
04-23 19:40:42.469+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:465,-13.720000,-59.990002,-140.000000
04-23 19:40:42.469+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:467,-2.400135,-9.470203,0.851458
04-23 19:40:42.479+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.479+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.479+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.479+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:485,-1.679627,-1.103680,0.029101
04-23 19:40:42.479+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.489+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:485,-4.079762,-10.573883,0.880559
04-23 19:40:42.489+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.489+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.499+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:490,-2.267560,-9.488951,0.994169
04-23 19:40:42.499+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.499+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:493,98.070000,-55.860001,-134.820007
04-23 19:40:42.499+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:500,-0.529650,1.391639,-0.101647
04-23 19:40:42.499+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.499+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:505,-2.226735,-9.464848,1.276201
04-23 19:40:42.509+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:499,-2.797210,-8.097312,0.892523
04-23 19:40:42.509+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.509+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.519+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.519+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:519,-0.168481,3.420578,-1.474805
04-23 19:40:42.519+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:512,168.279999,-43.610001,-137.830002
04-23 19:40:42.519+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:523,-2.209873,-9.431414,1.528165
04-23 19:40:42.519+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.519+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:519,-2.395216,-6.044270,-0.198604
04-23 19:40:42.529+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.529+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.539+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.539+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:539,0.353043,2.748260,0.398057
04-23 19:40:42.539+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:531,173.389999,-34.020000,-129.149994
04-23 19:40:42.539+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.539+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:538,-1.856830,-6.683154,1.926222
04-23 19:40:42.549+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:543,-2.226326,-9.361629,1.890441
04-23 19:40:42.549+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.549+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.559+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:560,0.917452,1.726131,0.779949
04-23 19:40:42.559+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:559,-1.308874,-7.635497,2.670390
04-23 19:40:42.559+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:549,189.559998,-46.619999,-105.419998
04-23 19:40:42.559+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.559+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.569+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:568,-2.209651,-9.275421,2.292247
04-23 19:40:42.569+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:569,217.139999,-40.670002,-110.320000
04-23 19:40:42.579+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.579+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.579+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:587,0.974954,1.498748,0.526499
04-23 19:40:42.579+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.579+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.589+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:593,234.570007,-21.840000,-101.570000
04-23 19:40:42.589+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.589+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:587,-1.234696,-7.776673,2.818745
04-23 19:40:42.589+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.599+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:599,0.266502,1.674077,0.059185
04-23 19:40:42.599+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:592,-2.207082,-9.163611,2.706918
04-23 19:40:42.599+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.599+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.599+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:601,-1.940579,-7.489535,2.766103
04-23 19:40:42.599+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:606,185.220001,-19.670000,-100.519997
04-23 19:40:42.609+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:609,-2.162830,-9.080983,3.004712
04-23 19:40:42.609+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.609+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.619+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.619+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:618,0.681672,0.861637,-0.281680
04-23 19:40:42.619+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.619+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:623,-2.070915,-9.017571,3.250400
04-23 19:40:42.619+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:625,166.389999,-25.690001,-96.320000
04-23 19:40:42.619+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:619,-1.481157,-8.219346,2.723032
04-23 19:40:42.629+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.629+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.639+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:640,1.154464,2.040100,-0.218693
04-23 19:40:42.639+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.639+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.639+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:641,168.559998,0.910000,-88.830002
04-23 19:40:42.649+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:647,-0.916451,-6.977471,3.031706
04-23 19:40:42.649+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:647,-1.999954,-8.939538,3.500748
04-23 19:40:42.649+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.649+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.659+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:659,0.442226,3.462368,-0.059869
04-23 19:40:42.659+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.659+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:659,152.949997,16.870001,-79.239998
04-23 19:40:42.659+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.659+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:667,-1.557728,-5.477170,3.440879
04-23 19:40:42.659+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:666,-1.986859,-8.843898,3.742759
04-23 19:40:42.679+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.679+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.679+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:687,-1.267380,3.129838,2.380474
04-23 19:40:42.679+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:687,164.919998,-2.450000,-69.650002
04-23 19:40:42.689+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.689+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.689+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:693,-3.254239,-5.714060,6.123233
04-23 19:40:42.689+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.689+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.699+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:701,197.050003,-10.640000,-67.410004
04-23 19:40:42.699+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:694,-2.079868,-8.661017,4.102599
04-23 19:40:42.699+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.699+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:701,-1.164799,1.965899,3.238581
04-23 19:40:42.699+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.709+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:707,-3.244668,-6.695118,7.341179
04-23 19:40:42.709+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.719+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.719+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:719,223.860001,-0.210000,-45.430000
04-23 19:40:42.729+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:709,-2.149596,-8.444983,4.497988
04-23 19:40:42.729+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.729+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.739+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:724,-2.325824,-4.417150,6.620940
04-23 19:40:42.739+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:736,-2.250013,-8.179726,4.919341
04-23 19:40:42.739+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.749+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.749+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:738,168.839996,6.090000,-18.480000
04-23 19:40:42.749+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.759+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:764,55.369999,-19.180000,-6.790000
04-23 19:40:42.759+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.759+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:754,-0.176228,4.027832,2.122952
04-23 19:40:42.759+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:750,-2.333002,0.090927,5.199604
04-23 19:40:42.769+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.769+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:774,-2.467218,-7.847637,5.338335
04-23 19:40:42.779+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.779+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:784,-3.270989,-0.311067,7.046863
04-23 19:40:42.779+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.789+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:779,-0.082989,8.270653,0.280263
04-23 19:40:42.789+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.789+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.799+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.799+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:790,-17.150000,-23.940001,5.600000
04-23 19:40:42.799+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:806,-3.218346,-2.057827,10.016356
04-23 19:40:42.799+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:795,-2.594697,-7.646692,5.564713
04-23 19:40:42.809+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.809+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.809+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:799,-0.803771,7.536570,1.708528
04-23 19:40:42.819+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.819+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.819+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:814,-34.090000,-20.930000,16.590000
04-23 19:40:42.819+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:826,-3.452843,-2.416751,11.332408
04-23 19:40:42.819+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.819+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.819+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:820,-2.724570,-7.460408,5.752340
04-23 19:40:42.829+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:831,-3.610770,-0.641276,13.512270
04-23 19:40:42.829+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:824,-0.623650,5.588864,4.451642
04-23 19:40:42.829+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.829+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.829+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.839+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:836,-2.786106,-7.378903,5.827502
04-23 19:40:42.839+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:836,-0.728273,5.043657,5.580068
04-23 19:40:42.839+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.839+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:832,-41.369999,-32.410000,31.219999
04-23 19:40:42.839+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.839+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:846,-0.824663,6.737627,7.684768
04-23 19:40:42.839+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.839+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.849+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:838,-3.775874,-3.895515,9.499505
04-23 19:40:42.849+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:850,-0.894804,3.354069,3.557001
04-23 19:40:42.849+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:847,-90.650002,-41.790001,20.299999
04-23 19:40:42.849+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:851,-2.881070,-7.249584,5.942504
04-23 19:40:42.849+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.849+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.859+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:859,-2.881541,-7.267162,5.920765
04-23 19:40:42.859+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.859+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:859,-2.120041,-4.658825,9.231510
04-23 19:40:42.859+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.859+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:864,-2.827957,-7.294504,5.912974
04-23 19:40:42.859+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.859+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:868,-117.459999,-53.480000,32.130001
04-23 19:40:42.869+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:865,0.761500,2.608336,3.310745
04-23 19:40:42.879+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.879+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.879+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:883,-2.737288,-7.397949,5.826490
04-23 19:40:42.879+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.879+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:884,-1.052842,-5.431707,6.628119
04-23 19:40:42.879+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.879+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:888,1.775115,1.862797,0.715145
04-23 19:40:42.889+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:889,-101.500000,-44.380001,19.460001
04-23 19:40:42.889+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.889+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.889+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.899+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:899,-0.780060,-5.651847,6.853044
04-23 19:40:42.899+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.899+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:899,1.957228,1.746102,1.026554
04-23 19:40:42.899+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:899,-2.635269,-7.442882,5.816291
04-23 19:40:42.899+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:904,-58.099998,-24.360001,17.430000
04-23 19:40:42.909+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.909+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.919+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.919+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:920,-1.064806,-5.883951,6.070591
04-23 19:40:42.919+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.919+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:923,1.570463,1.558931,0.254300
04-23 19:40:42.919+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:919,-2.601192,-7.479665,5.784358
04-23 19:40:42.929+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:927,-44.799999,-9.800000,16.660000
04-23 19:40:42.929+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.929+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.939+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.939+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:939,-0.686740,-6.805188,6.235696
04-23 19:40:42.939+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.939+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:943,1.914452,0.674477,0.451338
04-23 19:40:42.939+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:939,-2.505996,-7.561533,5.719578
04-23 19:40:42.939+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:945,-62.090000,-7.210000,14.630000
04-23 19:40:42.949+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.949+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.959+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.959+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:961,0.011964,-7.432107,6.472585
04-23 19:40:42.959+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.959+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:963,2.517960,0.129426,0.753007
04-23 19:40:42.969+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:961,-2.368234,-7.667008,5.637272
04-23 19:40:42.969+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:970,-66.919998,-10.640000,10.430000
04-23 19:40:42.979+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.979+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:42.979+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:42.979+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:42.979+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:42:985,0.165105,-7.367501,7.099504
04-23 19:40:42.989+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:42.999+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:42:993,-48.439999,-8.680000,13.440001
04-23 19:40:42.999+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:1,0.263210,-5.910272,6.400801
04-23 19:40:43.009+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.009+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.019+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:42:984,-2.245569,-7.730418,5.600753
04-23 19:40:43.019+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.019+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:20,-0.555135,-6.903293,5.568098
04-23 19:40:43.019+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:14,-21.700001,0.210000,13.230000
04-23 19:40:43.019+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:24,-2.195514,-7.745916,5.599185
04-23 19:40:43.019+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.019+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.029+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:42:991,2.533339,0.299508,1.462233
04-23 19:40:43.029+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.029+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.039+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:35,2.508780,1.820147,0.800047
04-23 19:40:43.039+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.039+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:39,-1.198804,-6.680761,6.333801
04-23 19:40:43.039+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:32,3.010000,0.070000,13.580000
04-23 19:40:43.039+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:31,-2.139311,-7.740374,5.628530
04-23 19:40:43.039+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.039+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.049+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.059+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:45,1.640379,0.842623,-0.031087
04-23 19:40:43.059+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.059+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:53,39.970001,2.590000,17.710001
04-23 19:40:43.059+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:64,0.940507,1.059613,0.705272
04-23 19:40:43.059+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.059+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.059+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:60,-1.533799,-5.860023,7.269395
04-23 19:40:43.069+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:52,-2.139051,-7.650288,5.750473
04-23 19:40:43.069+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.069+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:72,46.200001,2.520000,20.299999
04-23 19:40:43.069+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:76,-2.165819,-7.508352,5.924885
04-23 19:40:43.079+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.079+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.079+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:84,-2.180337,-7.400759,6.053535
04-23 19:40:43.079+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.079+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:85,-1.864009,-6.573084,7.532606
04-23 19:40:43.079+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:70,0.605252,1.790265,1.518923
04-23 19:40:43.079+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.089+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:90,26.389999,-5.810000,17.990000
04-23 19:40:43.089+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:93,0.301810,0.935268,1.607720
04-23 19:40:43.089+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.089+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.099+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:100,-2.186310,-7.306954,6.164321
04-23 19:40:43.099+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:100,-1.878366,-6.678369,7.695317
04-23 19:40:43.099+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.099+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.099+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:106,0.301971,0.722390,1.641782
04-23 19:40:43.109+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:108,15.750000,-9.170000,18.410000
04-23 19:40:43.109+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.109+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.109+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.119+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:119,-1.861616,-6.099305,7.398607
04-23 19:40:43.119+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:119,-2.196594,-7.211976,6.271584
04-23 19:40:43.129+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.129+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:129,13.370000,-6.790000,17.360001
04-23 19:40:43.129+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.129+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.139+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:133,0.324694,1.207649,1.234286
04-23 19:40:43.139+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.139+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:139,-1.828116,-6.479764,7.645068
04-23 19:40:43.139+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.139+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:144,0.368478,0.732212,1.373484
04-23 19:40:43.139+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:139,-2.189117,-7.141084,6.354767
04-23 19:40:43.139+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:147,3.360000,-10.920000,14.700000
04-23 19:40:43.149+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.159+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:159,-1.749153,-7.515855,7.575676
04-23 19:40:43.159+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.159+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:165,-2.174281,-7.101490,6.404039
04-23 19:40:43.159+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.159+0200 W/LOCATION(19315): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:40:43.169+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:170,0.439964,-0.374771,1.220910
04-23 19:40:43.169+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.169+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:176,6.370000,-13.020000,10.080000
04-23 19:40:43.179+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.179+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.179+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:184,-1.220340,-6.948757,7.776673
04-23 19:40:43.179+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.189+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.189+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:185,17.500000,-12.040000,7.350000
04-23 19:40:43.189+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:193,0.953942,0.152734,1.372634
04-23 19:40:43.189+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.189+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:189,-2.125054,-7.041929,6.485812
04-23 19:40:43.189+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.199+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.199+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:199,12.670000,-9.870000,2.730000
04-23 19:40:43.199+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:203,-0.854238,-6.451050,7.343572
04-23 19:40:43.199+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.209+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.209+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:209,1.270817,0.590879,0.857760
04-23 19:40:43.209+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.219+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:218,10.570000,-8.330000,1.050000
04-23 19:40:43.219+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:201,-2.059544,-7.002242,6.549601
04-23 19:40:43.219+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.219+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.229+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:224,-1.999134,-6.964458,6.608340
04-23 19:40:43.229+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.229+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:221,1.188557,0.929258,0.578618
04-23 19:40:43.239+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:226,-0.870987,-6.072984,7.128219
04-23 19:40:43.239+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.239+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:239,10.850000,-8.330000,0.210000
04-23 19:40:43.239+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.239+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.249+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:252,1.006113,0.841226,0.708912
04-23 19:40:43.249+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:40:43.259+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:40:43.259+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:40:43.259+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.259+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:248,-1.945676,-6.922961,6.667634
04-23 19:40:43.259+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:244,-0.993021,-6.123233,7.317252
04-23 19:40:43.259+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.259+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.259+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:267,16.170000,-8.680000,-2.170000
04-23 19:40:43.269+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.269+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:273,1.002904,-0.150223,0.766866
04-23 19:40:43.269+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.279+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:271,-0.942772,-7.073184,7.434500
04-23 19:40:43.279+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.279+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:280,43.470001,-9.450000,-3.290000
04-23 19:40:43.279+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:285,-1.208375,-7.355537,8.092526
04-23 19:40:43.279+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:269,-1.884370,-6.896919,6.712081
04-23 19:40:43.279+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.279+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.289+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:290,-1.851304,-6.822576,6.796728
04-23 19:40:43.289+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.289+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:292,0.675995,-0.458618,1.380445
04-23 19:40:43.289+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.299+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.299+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:299,65.449997,3.150000,3.780000
04-23 19:40:43.299+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:303,-1.846797,-6.685977,6.932348
04-23 19:40:43.299+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.299+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:307,-0.995414,-4.677969,7.415358
04-23 19:40:43.309+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:301,0.855890,2.144608,0.618629
04-23 19:40:43.309+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.309+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.309+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:319,-1.877054,-6.532054,7.069605
04-23 19:40:43.309+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:318,51.099998,3.920000,8.960000
04-23 19:40:43.309+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.319+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.319+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:323,0.198142,3.091957,0.014016
04-23 19:40:43.319+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:322,-1.648655,-3.594020,6.946364
04-23 19:40:43.329+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.329+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.329+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:338,47.529999,0.280000,14.280000
04-23 19:40:43.329+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.329+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.339+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:343,-2.201397,-4.460221,8.248059
04-23 19:40:43.339+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:342,-0.324343,2.071833,1.178454
04-23 19:40:43.339+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:339,-1.923453,-6.328806,7.239954
04-23 19:40:43.349+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.349+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.349+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:359,49.070000,-0.210000,12.740000
04-23 19:40:43.349+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.359+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.359+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:363,-0.215730,0.767886,1.079891
04-23 19:40:43.359+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:363,-2.139183,-5.560920,8.319844
04-23 19:40:43.359+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:359,-1.946083,-6.176736,7.364176
04-23 19:40:43.379+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.379+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.379+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:384,-1.320838,-5.056034,8.733803
04-23 19:40:43.379+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:384,34.439999,1.820000,14.350000
04-23 19:40:43.379+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.379+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.389+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:391,0.625245,1.120702,1.369627
04-23 19:40:43.389+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:388,-1.934560,-6.048597,7.472773
04-23 19:40:43.389+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.389+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.389+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.399+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:400,-28.210001,3.710000,22.120001
04-23 19:40:43.399+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:403,0.080122,2.313401,0.777679
04-23 19:40:43.399+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.399+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:399,-1.854438,-3.735196,8.250452
04-23 19:40:43.399+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:406,-1.977101,-5.958512,7.533763
04-23 19:40:43.409+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.419+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.419+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.419+0200 I/gyroscope(19289): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:40:43:424,-99.610001,-10.290000,24.430000
04-23 19:40:43.419+0200 I/gravity (19318): capturing data from es.ugr.frailty.gravity
04-23 19:40:43.419+0200 I/gravity (19318): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:40:43:429,-1.970160,-6.041994,7.468812
04-23 19:40:43.429+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:423,0.627550,1.091511,0.020378
04-23 19:40:43.429+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:420,-1.349552,-4.867002,7.554141
04-23 19:40:43.429+0200 I/linearacceleration(19302): capturing data from es.ugr.frailty.linearacceleration
04-23 19:40:43.429+0200 I/accelerometer(19274): capturing data from es.ugr.frailty.accelerometer
04-23 19:40:43.439+0200 I/accelerometer(19274): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:40:43:439,-0.629312,-7.144968,8.461020
04-23 19:40:43.439+0200 I/linearacceleration(19302): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:40:43:439,1.340848,-1.102974,0.992208
04-23 19:40:43.449+0200 I/gyroscope(19289): capturing data from es.ugr.frailty.gyroscope
04-23 19:40:43.449+0200 W/CRASH_MANAGER(18968): worker.c: worker_job(1205) > 11193156c6f63152450524
