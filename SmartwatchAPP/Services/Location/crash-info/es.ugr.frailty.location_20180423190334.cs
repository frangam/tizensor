S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7147
Date: 2018-04-23 19:03:34+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6f7e52d, r5   = 0xf76bc958
r6   = 0xff976a00, r7   = 0xff9768b0
r8   = 0xf76cfc18, r9   = 0x00000000
r10  = 0xff97698c, fp   = 0xff976a00
ip   = 0x00000001, sp   = 0xff976888
lr   = 0xf6f7e539, pc   = 0xf6fe7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     55884 KB
Buffers:     41384 KB
Cached:     227544 KB
VmPeak:      53540 KB
VmSize:      53536 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11976 KB
VmRSS:       11976 KB
VmData:      11264 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7147 TID = 7147
7147 7190 

Maps Information
f3e49000 f4648000 rw-p [stack:7190]
f464f000 f4651000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4659000 f465d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4666000 f4668000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4670000 f4673000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4682000 f4687000 r-xp /usr/lib/libsystem.so.0.0.0
f4692000 f4695000 r-xp /lib/libattr.so.1.1.0
f469d000 f46ad000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46b5000 f46be000 r-xp /usr/lib/libedbus.so.1.7.99
f46c6000 f46c7000 r-xp /usr/lib/libresponse.so.0.2.96
f46d0000 f46d5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5f77000 f607d000 r-xp /usr/lib/libicuuc.so.57.1
f6093000 f621b000 r-xp /usr/lib/libicui18n.so.57.1
f622b000 f6238000 r-xp /usr/lib/libail.so.0.1.0
f6241000 f6248000 r-xp /usr/lib/libminizip.so.1.0.0
f6251000 f63fa000 r-xp /usr/lib/libcrypto.so.1.0.0
f641a000 f6461000 r-xp /usr/lib/libssl.so.1.0.0
f646d000 f646f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6477000 f647e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6487000 f648e000 r-xp /lib/libcrypt-2.13.so
f64bf000 f64c2000 r-xp /lib/libcap.so.2.21
f64ca000 f64cc000 r-xp /usr/lib/libiri.so
f64d4000 f651d000 r-xp /usr/lib/libmdm.so.1.2.69
f6525000 f652b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6533000 f6556000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6560000 f6562000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f656a000 f6587000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6590000 f6594000 r-xp /usr/lib/libsmack.so.1.0.0
f659d000 f65b6000 r-xp /usr/lib/libnetwork.so.0.0.0
f65bf000 f65c7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f65cf000 f65d5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f65de000 f65e0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f65e9000 f65f9000 r-xp /lib/libresolv-2.13.so
f65fd000 f6615000 r-xp /usr/lib/liblzma.so.5.0.3
f661e000 f6620000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6628000 f6642000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f664a000 f6679000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6682000 f6691000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f669b000 f66a5000 r-xp /usr/lib/libsensord-shared.so
f66ae000 f6781000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f678c000 f67a2000 r-xp /lib/libz.so.1.2.5
f67aa000 f67af000 r-xp /usr/lib/libffi.so.5.0.10
f67b7000 f67b8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67c0000 f67d0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f67d8000 f67f1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f67f9000 f67fb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6803000 f6878000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6882000 f6888000 r-xp /lib/librt-2.13.so
f6891000 f68af000 r-xp /usr/lib/libsystemd.so.0.4.0
f68b9000 f68ba000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68c2000 f68e5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f68ed000 f68f2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f68fa000 f6924000 r-xp /usr/lib/libdbus-1.so.3.8.12
f692d000 f6944000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f694c000 f69b5000 r-xp /lib/libm-2.13.so
f69be000 f6a52000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a65000 f6a6a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6a72000 f6a79000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6a81000 f6aab000 r-xp /usr/lib/libsensor.so.1.9.6
f6ab4000 f6b80000 r-xp /usr/lib/libxml2.so.2.7.8
f6b8d000 f6b8f000 r-xp /usr/lib/libiniparser.so.0
f6b98000 f6b9e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ba7000 f6c77000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c78000 f6cac000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cb5000 f6cf1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6cf9000 f6cfc000 r-xp /usr/lib/libbundle.so.0.1.22
f6d04000 f6d0a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d12000 f6d53000 r-xp /usr/lib/libeina.so.1.7.99
f6d5c000 f6d73000 r-xp /usr/lib/libecore.so.1.7.99
f6d8a000 f6d93000 r-xp /usr/lib/libvconf.so.0.2.45
f6d9b000 f6daf000 r-xp /lib/libpthread-2.13.so
f6dba000 f6dc7000 r-xp /usr/lib/libaul.so.0.1.0
f6dd1000 f6dd3000 r-xp /lib/libdl-2.13.so
f6ddc000 f6de7000 r-xp /lib/libunwind.so.8.0.1
f6e14000 f6e1c000 r-xp /lib/libgcc_s-4.6.so.1
f6e1d000 f6f41000 r-xp /lib/libc-2.13.so
f6f4f000 f6f51000 r-xp /usr/lib/libdlog.so.0.0.0
f6f59000 f6f65000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f6e000 f6f73000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6f7b000 f6f8a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6f92000 f6f96000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6f9f000 f6fa2000 r-xp /usr/lib/libappcore-agent.so.1.1
f6faa000 f6fac000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fb4000 f6fb8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6fc0000 f6fdd000 r-xp /lib/ld-2.13.so
f6fe6000 f6fe9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f6fe9000 f6fed000 r-xp /usr/lib/libsys-assert.so
f769f000 f7726000 rw-p [heap]
ff958000 ff979000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7147)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf6fe7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6f7e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6c853f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6c83c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6c8fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6c95be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6c95dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cca75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6cc51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6c83c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6c8fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6c95be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6c95dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6cc7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cc8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ccff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46671fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf465a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf672d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6bdafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6bdc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6d6cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d67b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d685a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d68879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fa0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fa07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf6fe74f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6e3485c) [/lib/libc.so.6] + 0x1785c
29: (0xf6fe6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
erometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:290,9.233903,-0.679562,1.749153
04-23 19:03:33.349+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.349+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:354,9.968499,-0.815953,1.694118
04-23 19:03:33.349+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.359+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.359+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.359+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:322,-0.117339,0.235285,0.781544
04-23 19:03:33.359+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:365,-19.250000,-2.520000,2.380000
04-23 19:03:33.359+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:359,9.717253,-0.744168,2.182254
04-23 19:03:33.359+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.359+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:365,9.529118,-1.211522,1.974468
04-23 19:03:33.359+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.359+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:369,9.415757,-0.935594,2.761317
04-23 19:03:33.369+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.369+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.369+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:372,-0.162526,0.478808,1.037932
04-23 19:03:33.369+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:374,-17.639999,-2.170000,4.970000
04-23 19:03:33.369+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.369+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:373,9.367901,-0.665205,3.046063
04-23 19:03:33.369+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.369+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.379+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:378,9.533096,-1.170878,1.979773
04-23 19:03:33.379+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:381,9.279366,-0.380459,2.366502
04-23 19:03:33.389+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.389+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.389+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.389+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:397,-12.880000,-2.870000,7.490000
04-23 19:03:33.399+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:393,9.461221,-0.607777,2.557927
04-23 19:03:33.399+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.399+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:33.399+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:403,9.501899,-0.780060,2.660819
04-23 19:03:33.399+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.399+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:03:33:407,73
04-23 19:03:33.409+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:409,9.408579,-0.930808,2.206182
04-23 19:03:33.409+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:382,-0.249442,0.728575,0.331252
04-23 19:03:33.409+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.409+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:398,9.530427,-1.144012,2.008131
04-23 19:03:33.409+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.409+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.409+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:417,9.528809,-1.109034,2.035249
04-23 19:03:33.419+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.419+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.419+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:419,-12.250000,-2.940000,8.400000
04-23 19:03:33.429+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.429+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:424,9.533967,-1.069386,2.032308
04-23 19:03:33.429+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.429+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:427,9.518648,-0.703490,2.076970
04-23 19:03:33.429+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.429+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:435,9.533517,-1.057266,2.040740
04-23 19:03:33.429+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:415,-0.072746,0.461609,0.525619
04-23 19:03:33.429+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.439+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.439+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:441,9.529351,-1.059368,2.059026
04-23 19:03:33.439+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.439+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:443,-0.031618,0.277206,0.620079
04-23 19:03:33.439+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:434,-7.770000,-3.500000,9.240000
04-23 19:03:33.439+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:447,9.526388,-1.071495,2.066447
04-23 19:03:33.439+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:439,9.533006,-0.595813,2.000400
04-23 19:03:33.439+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.439+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.449+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.449+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:452,9.525787,-1.072463,2.068717
04-23 19:03:33.449+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.449+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:454,2.730000,-4.690000,8.610000
04-23 19:03:33.449+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.449+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:457,9.525980,-1.067620,2.070335
04-23 19:03:33.449+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:458,9.365508,-0.906880,2.057827
04-23 19:03:33.449+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.459+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:452,-0.120772,0.128560,0.147156
04-23 19:03:33.459+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.459+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:462,9.523709,-1.074546,2.077185
04-23 19:03:33.459+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:465,-0.007740,0.368005,0.010523
04-23 19:03:33.459+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.459+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:469,0.007218,0.476650,-0.068317
04-23 19:03:33.469+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.469+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.469+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.469+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.469+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:473,9.240000,-3.850000,6.860000
04-23 19:03:33.469+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:476,9.523168,-1.072433,2.080759
04-23 19:03:33.469+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:475,9.588040,-0.856631,1.986043
04-23 19:03:33.479+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:473,-0.160472,0.160740,-0.012507
04-23 19:03:33.479+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.479+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:485,0.064331,0.217916,-0.091142
04-23 19:03:33.489+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.489+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.489+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.489+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:495,4.900000,-2.660000,5.740000
04-23 19:03:33.489+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:495,9.523049,-1.073275,2.080865
04-23 19:03:33.489+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.499+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:495,0.239549,0.141625,-0.109073
04-23 19:03:33.499+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:499,9.762716,-0.930808,1.971686
04-23 19:03:33.509+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.509+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.519+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.519+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:521,9.521207,-1.087332,2.081997
04-23 19:03:33.519+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.519+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:521,3.290000,-3.500000,3.570000
04-23 19:03:33.519+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:523,9.757930,-1.308874,2.134398
04-23 19:03:33.529+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.529+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.529+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.539+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:537,9.573684,-1.100698,1.995614
04-23 19:03:33.539+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:534,1.960000,-3.500000,4.060000
04-23 19:03:33.549+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:03:33.549+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:03:33.549+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:03:33.549+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.549+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:534,9.521226,-1.093675,2.078583
04-23 19:03:33.549+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.549+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.549+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:521,0.234880,-0.235599,0.053533
04-23 19:03:33.559+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.559+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:558,2.170000,-6.860000,4.620000
04-23 19:03:33.569+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.569+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:569,0.052477,-0.013366,-0.086383
04-23 19:03:33.569+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:561,9.521976,-1.105264,2.069001
04-23 19:03:33.569+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.579+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:562,9.600004,-1.237089,1.990828
04-23 19:03:33.579+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.579+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.579+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:584,9.803394,-0.679562,1.998007
04-23 19:03:33.579+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:581,9.524270,-1.087035,2.068096
04-23 19:03:33.589+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.589+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:573,10.290000,-4.900000,4.620000
04-23 19:03:33.589+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.589+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:585,0.078778,-0.143414,-0.087755
04-23 19:03:33.589+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.589+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.589+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:33.599+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:600,9.645468,-0.775275,2.177469
04-23 19:03:33.599+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:596,0.630000,-1.470000,5.670000
04-23 19:03:33.599+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:03:33:600,74
04-23 19:03:33.599+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:594,9.522202,-1.082266,2.080088
04-23 19:03:33.609+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:598,0.281419,0.425703,-0.070995
04-23 19:03:33.609+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.609+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.609+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.619+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.619+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:622,9.521884,-1.091171,2.076886
04-23 19:03:33.619+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:617,0.121198,0.311760,0.109373
04-23 19:03:33.619+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.619+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:622,-15.190001,-5.180000,7.490000
04-23 19:03:33.629+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:623,9.544970,-0.906880,2.115255
04-23 19:03:33.629+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.629+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:630,0.022768,0.175386,0.035167
04-23 19:03:33.639+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.639+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:634,9.520751,-1.109154,2.072549
04-23 19:03:33.639+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:643,-0.017592,0.100542,0.081440
04-23 19:03:33.649+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.659+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.659+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:663,0.002683,-0.130328,-0.139148
04-23 19:03:33.659+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:659,9.520128,-1.138529,2.059440
04-23 19:03:33.659+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.669+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.669+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.679+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:674,9.522793,-1.160274,2.034837
04-23 19:03:33.679+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:679,0.242588,0.018688,-0.286359
04-23 19:03:33.679+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:670,9.504292,-0.990629,2.158326
04-23 19:03:33.679+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.679+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:687,9.523434,-1.239482,1.933401
04-23 19:03:33.679+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.689+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.689+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.689+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:694,9.521426,-1.196827,2.020010
04-23 19:03:33.699+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.699+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:695,0.163353,-0.229956,-0.194757
04-23 19:03:33.699+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:703,-20.580000,-7.490000,9.870000
04-23 19:03:33.699+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.699+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:692,9.762716,-1.119841,1.773082
04-23 19:03:33.699+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.699+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:707,-15.750000,-8.750000,11.130000
04-23 19:03:33.699+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.709+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:709,9.686146,-1.390230,1.840081
04-23 19:03:33.709+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.709+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.719+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:721,0.042686,-0.485327,-0.098574
04-23 19:03:33.719+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:721,9.519270,-1.238474,2.005008
04-23 19:03:33.719+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.729+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.729+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.729+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:734,9.517216,-1.274728,1.991999
04-23 19:03:33.729+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:735,0.121412,-0.410181,0.031284
04-23 19:03:33.739+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:711,-19.530001,-8.330000,10.640000
04-23 19:03:33.739+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.739+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:730,9.564112,-1.682154,1.921437
04-23 19:03:33.739+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:744,-21.559999,-5.600000,11.270000
04-23 19:03:33.739+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.739+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.749+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.749+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:749,9.640682,-1.648655,2.036292
04-23 19:03:33.749+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.749+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.749+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:756,9.552148,-1.469193,1.954936
04-23 19:03:33.749+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:756,0.034932,-0.194465,-0.037062
04-23 19:03:33.759+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:754,9.516011,-1.306190,1.977317
04-23 19:03:33.759+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:752,-20.719999,-6.370000,8.540000
04-23 19:03:33.759+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.759+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:765,-21.700001,-7.140000,8.050000
04-23 19:03:33.759+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.769+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.769+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.769+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:770,-26.670000,-6.090000,8.960000
04-23 19:03:33.769+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.769+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:775,-27.090000,-8.120000,10.150000
04-23 19:03:33.769+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:774,9.463614,-1.306481,1.789831
04-23 19:03:33.769+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:773,-0.052398,-0.000291,-0.187486
04-23 19:03:33.779+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.779+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:785,9.517484,-1.330848,1.953644
04-23 19:03:33.789+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.789+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:33.799+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:03:33:800,75
04-23 19:03:33.799+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:797,0.041842,-0.164666,-0.017850
04-23 19:03:33.799+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.799+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:808,-17.920000,-11.620000,12.390000
04-23 19:03:33.809+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.809+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:814,9.559326,-1.495514,1.935793
04-23 19:03:33.809+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.819+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.819+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:824,9.489935,-1.734797,1.770689
04-23 19:03:33.819+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.839+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.839+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:828,3.220000,-10.500000,13.790000
04-23 19:03:33.849+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:821,9.516508,-1.361416,1.937265
04-23 19:03:33.849+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.849+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.859+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:842,9.535398,-1.715654,1.462015
04-23 19:03:33.869+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.879+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:873,-0.026573,-0.373380,-0.166577
04-23 19:03:33.879+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.879+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.879+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:860,9.512865,-1.398704,1.928575
04-23 19:03:33.889+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:862,14.770000,-9.800000,14.910000
04-23 19:03:33.889+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.889+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.899+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:888,0.022533,-0.316950,-0.466560
04-23 19:03:33.909+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:889,9.547362,-2.136791,1.727618
04-23 19:03:33.909+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.909+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.919+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:900,26.250000,-3.360000,18.760000
04-23 19:03:33.919+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:901,9.511094,-1.433186,1.911921
04-23 19:03:33.919+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.919+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:914,9.525827,-2.179861,1.581656
04-23 19:03:33.919+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.929+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:928,9.497568,-1.490815,1.934954
04-23 19:03:33.929+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:915,0.036268,-0.703604,-0.184304
04-23 19:03:33.939+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.939+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.939+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:944,9.559326,-1.203590,1.462015
04-23 19:03:33.939+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.949+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:931,48.930000,-1.750000,17.990000
04-23 19:03:33.949+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.949+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:952,9.552148,-1.330409,1.024128
04-23 19:03:33.949+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.949+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:946,0.028259,-0.689047,-0.353298
04-23 19:03:33.949+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:958,9.671788,-1.660619,0.569492
04-23 19:03:33.949+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.949+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.959+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:962,9.671788,-2.187040,1.253839
04-23 19:03:33.959+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.959+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:963,64.190002,3.150000,20.580000
04-23 19:03:33.959+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:956,9.483783,-1.540379,1.963538
04-23 19:03:33.959+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:967,0.075543,0.336789,-0.501523
04-23 19:03:33.959+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.959+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.969+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.969+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.969+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:33:974,9.456435,-2.620141,1.631905
04-23 19:03:33.969+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:971,0.079814,0.220111,-0.986134
04-23 19:03:33.969+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.969+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:971,9.472334,-1.550520,2.010262
04-23 19:03:33.969+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:33.969+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:975,57.049999,5.110000,22.260000
04-23 19:03:33.979+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.979+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:980,0.207661,-0.084576,-1.459489
04-23 19:03:33.979+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.979+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:33:982,9.464128,-1.576043,2.028981
04-23 19:03:33.979+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:984,0.212513,-0.558434,-0.756170
04-23 19:03:33.979+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.979+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:988,0.015953,-0.918396,-0.405679
04-23 19:03:33.989+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:983,41.020000,6.090000,25.340000
04-23 19:03:33.989+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.989+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:33.989+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:33:996,-0.052292,-0.864314,-0.377546
04-23 19:03:33.999+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:33:995,27.510000,10.500000,25.830000
04-23 19:03:33.999+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:33.999+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:33.999+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:33.999+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:4,35.279999,11.830000,21.280001
04-23 19:03:33.999+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.009+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:9,49.209999,11.200000,20.580000
04-23 19:03:34.009+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.009+0200 W/LOCATION( 7147): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:03:34.009+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:15,9.459275,-1.628606,2.010009
04-23 19:03:34.009+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.009+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.009+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.019+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:21,0.060143,-0.895180,-0.329094
04-23 19:03:34.019+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:03:34:8,75
04-23 19:03:34.019+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:8,9.363115,-2.641676,1.710868
04-23 19:03:34.019+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:21,9.440482,-1.701745,2.037584
04-23 19:03:34.019+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.029+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:30,9.415407,-1.777362,2.088414
04-23 19:03:34.029+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.029+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.029+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:22,59.990002,10.010000,14.910000
04-23 19:03:34.029+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:34,0.232154,-0.461764,-0.330141
04-23 19:03:34.029+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.029+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.039+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:34,9.389114,-1.844602,2.147639
04-23 19:03:34.039+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.039+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:36,9.449257,-2.739782,1.818545
04-23 19:03:34.039+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:44,9.365458,-1.895167,2.206114
04-23 19:03:34.039+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.039+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:49,9.349038,-1.924405,2.250008
04-23 19:03:34.049+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.049+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:39,38.709999,14.980000,8.120000
04-23 19:03:34.049+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.049+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:55,0.100219,-0.020959,-0.496069
04-23 19:03:34.049+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.049+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.059+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:59,9.343789,-1.948923,2.250708
04-23 19:03:34.059+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:56,9.597611,-2.356930,1.875973
04-23 19:03:34.069+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.069+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:60,-8.330000,13.510000,6.090000
04-23 19:03:34.069+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.069+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:74,-0.243884,-0.419971,-0.286201
04-23 19:03:34.069+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.069+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.079+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:76,-34.860001,12.390000,4.900000
04-23 19:03:34.079+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:81,9.334551,-1.999126,2.245004
04-23 19:03:34.079+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:83,9.449257,-1.945365,1.753939
04-23 19:03:34.089+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.089+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.089+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:95,-27.580000,8.960000,0.910000
04-23 19:03:34.089+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:94,0.236740,-1.082829,0.071248
04-23 19:03:34.089+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.089+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.099+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:99,9.321787,-2.056662,2.246068
04-23 19:03:34.099+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:102,9.099905,-2.368894,1.964507
04-23 19:03:34.099+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.109+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:111,9.571291,-3.081956,2.316252
04-23 19:03:34.109+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.109+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.119+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.119+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:121,-19.250000,10.430000,-7.420000
04-23 19:03:34.119+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:121,0.261468,-0.405552,-0.128420
04-23 19:03:34.119+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:123,9.320841,-2.071178,2.236634
04-23 19:03:34.119+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.129+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.129+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.129+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:134,-27.930000,12.530000,-10.570000
04-23 19:03:34.129+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.139+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:134,0.090131,0.130599,-0.061559
04-23 19:03:34.139+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:132,9.583255,-2.462214,2.117648
04-23 19:03:34.139+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:137,9.323786,-2.064322,2.230692
04-23 19:03:34.139+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.149+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.149+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.149+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.149+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:155,-33.880001,9.520000,-9.800000
04-23 19:03:34.149+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:156,-0.097061,-0.295002,0.040097
04-23 19:03:34.149+0200 I/servicemanager( 6846): es.ugr.frailty.location sleep timeout
04-23 19:03:34.149+0200 W/AUL     ( 6846): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:03:34.149+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:03:34.159+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6846
04-23 19:03:34.159+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:158,9.322275,-2.079675,2.222729
04-23 19:03:34.159+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7147
04-23 19:03:34.169+0200 W/AUL     ( 6846): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7147)
04-23 19:03:34.169+0200 I/servicemanager( 6846): es.ugr.frailty.location stop request sent!
04-23 19:03:34.169+0200 I/servicemanager( 6846): App control destroyed.
04-23 19:03:34.169+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.169+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.169+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:174,-28.280001,3.150000,-9.590000
04-23 19:03:34.169+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.169+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:149,9.410972,-1.940579,2.175076
04-23 19:03:34.169+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.179+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:182,9.226725,-2.359323,2.270789
04-23 19:03:34.179+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:177,9.318298,-2.117050,2.204040
04-23 19:03:34.179+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:175,0.095875,-1.074065,0.024131
04-23 19:03:34.179+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.189+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.189+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.189+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:194,-17.500000,4.130000,-13.720000
04-23 19:03:34.189+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.189+0200 I/heartrate( 6875): capturing data from es.ugr.frailty.heartrate
04-23 19:03:34.189+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:197,9.313001,-2.135084,2.209031
04-23 19:03:34.189+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:194,0.267348,-0.924227,0.526171
04-23 19:03:34.199+0200 I/heartrate( 6875): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:03:34:200,75
04-23 19:03:34.199+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:191,9.418150,-3.153740,2.246860
04-23 19:03:34.199+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.199+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:206,9.585647,-3.041277,2.730211
04-23 19:03:34.209+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.209+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.219+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.219+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:221,-7.560000,5.390000,-19.600000
04-23 19:03:34.219+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:221,-0.033634,-0.468307,0.107221
04-23 19:03:34.219+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:223,9.317342,-2.123989,2.201407
04-23 19:03:34.219+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.229+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.229+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.229+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:234,-6.580000,2.310000,-20.230000
04-23 19:03:34.229+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.229+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:237,9.328673,-2.087359,2.188417
04-23 19:03:34.229+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:234,-0.035583,0.023091,0.112452
04-23 19:03:34.239+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:230,9.279366,-2.603391,2.316252
04-23 19:03:34.239+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.239+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:245,9.281759,-2.100898,2.313859
04-23 19:03:34.249+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.249+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.249+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.249+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:254,-2.520000,0.910000,-15.400000
04-23 19:03:34.259+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.259+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:256,0.118191,0.187458,0.089550
04-23 19:03:34.259+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:258,9.339957,-2.048320,2.177146
04-23 19:03:34.269+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:263,9.446864,-1.899901,2.277967
04-23 19:03:34.269+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.269+0200 I/linearacceleration( 7163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:03:34.279+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:279,6.650000,3.010000,-14.770000
04-23 19:03:34.279+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.279+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:287,9.480364,-1.385444,2.562713
04-23 19:03:34.289+0200 I/gyroscope( 7134): capturing data from es.ugr.frailty.gyroscope
04-23 19:03:34.289+0200 I/gyroscope( 7134): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:03:34:294,18.620001,-0.980000,-12.880000
04-23 19:03:34.289+0200 I/accelerometer( 7121): capturing data from es.ugr.frailty.accelerometer
04-23 19:03:34.289+0200 I/gravity ( 7175): capturing data from es.ugr.frailty.gravity
04-23 19:03:34.289+0200 I/gravity ( 7175): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:03:34:298,9.350836,-1.985091,2.188989
04-23 19:03:34.299+0200 I/linearacceleration( 7163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:03:34:279,0.140407,0.662876,0.385567
04-23 19:03:34.299+0200 I/accelerometer( 7121): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:03:34:298,9.355937,-1.229911,2.557927
04-23 19:03:34.299+0200 W/CRASH_MANAGER( 5847): worker.c: worker_job(1205) > 11071476c6f63152450301
