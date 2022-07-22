S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 27120
Date: 2018-04-23 16:20:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74f452d, r5   = 0xf768df98
r6   = 0xff8bd7b0, r7   = 0xff8bd660
r8   = 0xf768ac18, r9   = 0x00000000
r10  = 0xff8bd73c, fp   = 0xff8bd7b0
ip   = 0x00000001, sp   = 0xff8bc4e0
lr   = 0xf74f4539, pc   = 0xf755d2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     21000 KB
Buffers:     63756 KB
Cached:     218944 KB
VmPeak:      53524 KB
VmSize:      53520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11632 KB
VmRSS:       11632 KB
VmData:      11248 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 27120 TID = 27120
27120 27123 

Maps Information
f43bf000 f4bbe000 rw-p [stack:27123]
f4bc5000 f4bc7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bcf000 f4bd3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bdc000 f4bde000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4be6000 f4be9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bf8000 f4bfd000 r-xp /usr/lib/libsystem.so.0.0.0
f4c08000 f4c0b000 r-xp /lib/libattr.so.1.1.0
f4c13000 f4c23000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c2b000 f4c34000 r-xp /usr/lib/libedbus.so.1.7.99
f4c3c000 f4c3d000 r-xp /usr/lib/libresponse.so.0.2.96
f4c46000 f4c4b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64ed000 f65f3000 r-xp /usr/lib/libicuuc.so.57.1
f6609000 f6791000 r-xp /usr/lib/libicui18n.so.57.1
f67a1000 f67ae000 r-xp /usr/lib/libail.so.0.1.0
f67b7000 f67be000 r-xp /usr/lib/libminizip.so.1.0.0
f67c7000 f6970000 r-xp /usr/lib/libcrypto.so.1.0.0
f6990000 f69d7000 r-xp /usr/lib/libssl.so.1.0.0
f69e3000 f69e5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69ed000 f69f4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69fd000 f6a04000 r-xp /lib/libcrypt-2.13.so
f6a35000 f6a38000 r-xp /lib/libcap.so.2.21
f6a40000 f6a42000 r-xp /usr/lib/libiri.so
f6a4a000 f6a93000 r-xp /usr/lib/libmdm.so.1.2.69
f6a9b000 f6aa1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6aa9000 f6acc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ad6000 f6ad8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ae0000 f6afd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b06000 f6b0a000 r-xp /usr/lib/libsmack.so.1.0.0
f6b13000 f6b2c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b35000 f6b3d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b45000 f6b4b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b54000 f6b56000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b5f000 f6b6f000 r-xp /lib/libresolv-2.13.so
f6b73000 f6b8b000 r-xp /usr/lib/liblzma.so.5.0.3
f6b94000 f6b96000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b9e000 f6bb8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bc0000 f6bef000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bf8000 f6c07000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c11000 f6c1b000 r-xp /usr/lib/libsensord-shared.so
f6c24000 f6cf7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d02000 f6d18000 r-xp /lib/libz.so.1.2.5
f6d20000 f6d25000 r-xp /usr/lib/libffi.so.5.0.10
f6d2d000 f6d2e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d36000 f6d46000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d4e000 f6d67000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d6f000 f6d71000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d79000 f6dee000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6df8000 f6dfe000 r-xp /lib/librt-2.13.so
f6e07000 f6e25000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e2f000 f6e30000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e38000 f6e5b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e63000 f6e68000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e70000 f6e9a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ea3000 f6eba000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ec2000 f6f2b000 r-xp /lib/libm-2.13.so
f6f34000 f6fc8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fdb000 f6fe0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fe8000 f6fef000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ff7000 f7021000 r-xp /usr/lib/libsensor.so.1.9.6
f702a000 f70f6000 r-xp /usr/lib/libxml2.so.2.7.8
f7103000 f7105000 r-xp /usr/lib/libiniparser.so.0
f710e000 f7114000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f711d000 f71ed000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71ee000 f7222000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f722b000 f7267000 r-xp /usr/lib/libSLP-location.so.0.9.24
f726f000 f7272000 r-xp /usr/lib/libbundle.so.0.1.22
f727a000 f7280000 r-xp /usr/lib/libappsvc.so.0.1.0
f7288000 f72c9000 r-xp /usr/lib/libeina.so.1.7.99
f72d2000 f72e9000 r-xp /usr/lib/libecore.so.1.7.99
f7300000 f7309000 r-xp /usr/lib/libvconf.so.0.2.45
f7311000 f7325000 r-xp /lib/libpthread-2.13.so
f7330000 f733d000 r-xp /usr/lib/libaul.so.0.1.0
f7347000 f7349000 r-xp /lib/libdl-2.13.so
f7352000 f735d000 r-xp /lib/libunwind.so.8.0.1
f738a000 f7392000 r-xp /lib/libgcc_s-4.6.so.1
f7393000 f74b7000 r-xp /lib/libc-2.13.so
f74c5000 f74c7000 r-xp /usr/lib/libdlog.so.0.0.0
f74cf000 f74db000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74e4000 f74e9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74f1000 f7500000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7508000 f750c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7515000 f7518000 r-xp /usr/lib/libappcore-agent.so.1.1
f7520000 f7522000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f752a000 f752e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7536000 f7553000 r-xp /lib/ld-2.13.so
f755c000 f755f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f755f000 f7563000 r-xp /usr/lib/libsys-assert.so
f765a000 f76dd000 rw-p [heap]
ff89e000 ff8bf000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27120)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf755d2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf74f4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71fb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71f9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7205e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf720bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf720bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf724075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf723b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71f9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7205e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf720bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf720bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf723de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf723e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7245f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bdd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bd0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ca3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7150fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71527a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72e2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72ddb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72de5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72de879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7516183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75167fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf755d6c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf73aa85c) [/lib/libc.so.6] + 0x1785c
29: (0xf755cfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:52.811+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:52:813,79
04-23 16:19:52.961+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:52.961+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:52.971+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:52:966,3.974478,-0.634098,8.592626
04-23 16:19:52.981+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:52:972,5.530000,-2.030000,0.700000
04-23 16:19:53.001+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:53.011+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:53:13,80
04-23 16:19:53.161+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:53.161+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:53.171+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:53:172,6.230000,-0.420000,0.350000
04-23 16:19:53.171+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:53:166,4.304688,-0.638884,9.006584
04-23 16:19:53.201+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:53.211+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:53:213,80
04-23 16:19:53.361+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:53.361+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:53.371+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:53:367,4.072584,-0.870987,9.080762
04-23 16:19:53.371+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:53:373,-3.220000,-0.280000,2.170000
04-23 16:19:53.401+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:53.411+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:53:413,80
04-23 16:19:53.561+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:53.561+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:53.571+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:53:573,5.810000,-2.100000,-0.770000
04-23 16:19:53.571+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:53:566,4.500899,-1.004985,9.090333
04-23 16:19:53.601+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:53.611+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:53:613,80
04-23 16:19:53.761+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:53.761+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:53.771+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:53:773,-7.280000,-10.360000,-3.010000
04-23 16:19:53.771+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:53:766,4.283153,-0.736989,8.499306
04-23 16:19:53.801+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:53.811+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:53:813,80
04-23 16:19:53.961+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:53.961+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:53.971+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:53:967,4.311867,-0.124427,8.793623
04-23 16:19:53.971+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:53:973,-2.380000,-13.160000,16.660000
04-23 16:19:54.001+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:54.011+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:54:13,80
04-23 16:19:54.161+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:54.161+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:54.171+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:54:167,4.630112,-0.748954,9.198010
04-23 16:19:54.181+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:54:173,-7.630000,-0.980000,10.080000
04-23 16:19:54.201+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:54.211+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:54:214,80
04-23 16:19:54.361+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:54.361+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:54.371+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:54:367,4.945964,-0.512064,8.678767
04-23 16:19:54.371+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:54:373,7.420000,10.010000,-0.980000
04-23 16:19:54.401+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:54.411+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:54:414,80
04-23 16:19:54.561+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:54.561+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:54.571+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:54:574,7.490000,8.400000,4.690000
04-23 16:19:54.581+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:54:567,5.115855,-1.091127,9.609575
04-23 16:19:54.601+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:54.611+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:54:614,80
04-23 16:19:54.761+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:54.761+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:54.771+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:54:774,-15.820000,-14.070000,-37.939999
04-23 16:19:54.781+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:54:767,5.874380,-1.368695,7.838887
04-23 16:19:54.801+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:54.811+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:54:814,80
04-23 16:19:54.961+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:54.961+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:54.971+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:54:967,5.235496,0.471386,7.908278
04-23 16:19:54.981+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:54:974,14.980000,7.700000,-43.540001
04-23 16:19:55.001+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:55.011+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:55:14,80
04-23 16:19:55.161+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:55.161+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:55.171+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:55:168,1.923829,0.940379,8.389235
04-23 16:19:55.181+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:55:174,66.220001,57.610001,-23.100000
04-23 16:19:55.201+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:55.211+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:55:214,81
04-23 16:19:55.361+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:55.361+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:55.371+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:55:367,2.902494,0.894916,10.030712
04-23 16:19:55.381+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:55:374,-0.490000,-11.410000,-2.030000
04-23 16:19:55.401+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:55.411+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:55:414,80
04-23 16:19:55.561+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:55.561+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:55.571+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:55:567,4.472186,-0.043071,8.851050
04-23 16:19:55.571+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:55:574,9.590000,5.880000,7.630000
04-23 16:19:55.601+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:55.611+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:55:614,79
04-23 16:19:55.761+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:19:55.761+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:19:55.771+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:19:55:768,3.163311,0.983450,10.004392
04-23 16:19:55.781+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:19:55:774,3.780000,0.210000,-2.310000
04-23 16:19:55.781+0200 I/servicemanager(26979): es.ugr.frailty.accelerometer sleep timeout
04-23 16:19:55.781+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 16:19:55.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:55.791+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:19:55.811+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26990
04-23 16:19:55.811+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:19:55.811+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26990)
04-23 16:19:55.821+0200 I/servicemanager(26979): es.ugr.frailty.accelerometer stop request sent!
04-23 16:19:55.821+0200 I/servicemanager(26979): App control destroyed.
04-23 16:19:55.831+0200 I/heartrate(27005): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:19:55:824,80
04-23 16:19:55.831+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:19:55.831+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26990), cmd(0)
04-23 16:19:55.831+0200 I/accelerometer(26990): stopping es.ugr.frailty.accelerometer service
04-23 16:19:55.831+0200 W/AUL     (26990): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:19:55.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:55.841+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26990
04-23 16:19:55.861+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:19:55.871+0200 W/AUL     (26990): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:19:55.871+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:19:55.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:19:55.871+0200 I/accelerometer(26990): request sent to service es.ugr.frailty.servicemanager
04-23 16:19:55.871+0200 I/CAPI_APPFW_APPLICATION(26990): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:19:55.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:19:55.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:19:55.871+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:55.871+0200 I/utils   (26979): specific action
04-23 16:19:55.871+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:19:55.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:55.881+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:19:55.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:19:55.891+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:19:55.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26984), cmd(0)
04-23 16:19:55.891+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:55.891+0200 I/utils   (26984): specific action
04-23 16:19:55.891+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:55.891+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 16:19:55.901+0200 I/recorder(26984): guardando datos en local
04-23 16:19:55.901+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:19:55.901+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:19:55.901+0200 I/servicemanager(26979): requesting to save local data
04-23 16:19:55.901+0200 I/servicemanager(26979): es.ugr.frailty.gyroscope sleep timeout
04-23 16:19:55.901+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 16:19:55.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:55.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:19:55.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26992
04-23 16:19:55.921+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:19:55.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26992), cmd(0)
04-23 16:19:55.921+0200 I/gyroscope(26992): stopping es.ugr.frailty.gyroscope service
04-23 16:19:55.921+0200 W/AUL     (26992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:19:55.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:55.921+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26992)
04-23 16:19:55.921+0200 I/servicemanager(26979): es.ugr.frailty.gyroscope stop request sent!
04-23 16:19:55.921+0200 I/servicemanager(26979): App control destroyed.
04-23 16:19:55.921+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26992
04-23 16:19:55.941+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:19:55.941+0200 W/AUL     (26992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:19:55.941+0200 I/gyroscope(26992): request sent to service es.ugr.frailty.servicemanager
04-23 16:19:55.941+0200 I/CAPI_APPFW_APPLICATION(26992): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:19:55.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:19:55.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:19:55.941+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:19:55.941+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:19:55.941+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:19:55.961+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:19:55.961+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:55.961+0200 I/utils   (26979): specific action
04-23 16:19:55.961+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:55.961+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:19:55.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:55.971+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:19:55.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:19:55.981+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:55.981+0200 I/utils   (26984): specific action
04-23 16:19:55.981+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:55.981+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:55.981+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 16:19:55.991+0200 I/recorder(26984): guardando datos en local
04-23 16:19:55.991+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:19:55.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26984), cmd(0)
04-23 16:19:55.991+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:19:55.991+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:19:55.991+0200 I/servicemanager(26979): requesting to save local data
04-23 16:19:55.991+0200 I/servicemanager(26979): es.ugr.frailty.heartrate sleep timeout
04-23 16:19:55.991+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 16:19:55.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:55.991+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:19:56.001+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:19:56.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 27005
04-23 16:19:56.011+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:19:56.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(27005), cmd(0)
04-23 16:19:56.011+0200 I/heartrate(27005): stopping es.ugr.frailty.heartrate service
04-23 16:19:56.011+0200 W/AUL     (27005): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:19:56.011+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:19:56.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:56.011+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27005)
04-23 16:19:56.011+0200 I/servicemanager(26979): es.ugr.frailty.heartrate stop request sent!
04-23 16:19:56.011+0200 I/servicemanager(26979): App control destroyed.
04-23 16:19:56.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 27005
04-23 16:19:56.021+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer listener destroyed
04-23 16:19:56.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:19:56.031+0200 W/AUL     (27005): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:19:56.031+0200 I/heartrate(27005): request sent to service es.ugr.frailty.servicemanager
04-23 16:19:56.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:19:56.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:19:56.031+0200 I/CAPI_APPFW_APPLICATION(27005): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:19:56.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:19:56.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:19:56.031+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:56.031+0200 I/utils   (26979): specific action
04-23 16:19:56.031+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:56.031+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:56.031+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:19:56.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:56.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:19:56.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:19:56.041+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:19:56.041+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:19:56.041+0200 I/servicemanager(26979): requesting to save local data
04-23 16:19:56.051+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:19:56.051+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26984), cmd(0)
04-23 16:19:56.051+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:56.051+0200 I/utils   (26984): specific action
04-23 16:19:56.051+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:56.051+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:56.051+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:19:56.051+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
04-23 16:19:56.051+0200 I/recorder(26984): guardando datos en local
04-23 16:19:56.051+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope listener destroyed
04-23 16:19:56.081+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:19:56.091+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:19:56.111+0200 I/heartrate(27005): es.ugr.frailty.heartrate listener destroyed
04-23 16:19:56.141+0200 W/AUL     (27115): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 16:19:56.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:19:56.141+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:19:56.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26990
04-23 16:19:56.141+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:19:56.151+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26990
04-23 16:19:56.151+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26990)
04-23 16:19:56.191+0200 W/AUL     (27117): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 16:19:56.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:19:56.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:19:56.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26992
04-23 16:19:56.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:19:56.191+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26992
04-23 16:19:56.191+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26992)
04-23 16:19:56.251+0200 W/AUL     (27119): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 16:19:56.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:19:56.251+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:19:56.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27005
04-23 16:19:56.251+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:19:56.261+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27005
04-23 16:19:56.261+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27005)
04-23 16:19:57.881+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:19:57.941+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:19:58.031+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:19:59.261+0200 I/servicemanager(26979): es.ugr.frailty.location alive timeout
04-23 16:19:59.261+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:19:59.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:19:59.261+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:19:59.291+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 27120
04-23 16:19:59.291+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:19:59.341+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27120
04-23 16:19:59.341+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(27120) type(svcapp) bg(0)
04-23 16:19:59.351+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27120]
04-23 16:19:59.351+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27120)
04-23 16:19:59.351+0200 I/servicemanager(26979): es.ugr.frailty.location launch request sent!
04-23 16:19:59.351+0200 I/servicemanager(26979): App control destroyed.
04-23 16:19:59.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:19:59.381+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27120
04-23 16:19:59.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:19:59.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:19:59.401+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27120
04-23 16:19:59.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:19:59.421+0200 E/CAPI_APPFW_APPLICATION(27120): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:19:59.421+0200 E/CAPI_APPFW_APPLICATION(27120): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:19:59.421+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (27120) was created
04-23 16:19:59.441+0200 W/LOCATION(27120): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:19:59.441+0200 E/LOCATION(27120): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:19:59.441+0200 E/PKGMGR_INFO(27120): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:19:59.451+0200 W/LOCATION(27120): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:19:59.471+0200 I/LOCATION(27120): location.c: location_new(269) > method: 0
04-23 16:19:59.471+0200 W/LOCATION(27120): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:19:59.471+0200 W/LOCATION(27120): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:19:59.481+0200 W/LOCATION(27120): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:19:59.481+0200 W/LOCATION(27120): module-internal.c: module_new(311) > module (gps) open success
04-23 16:19:59.491+0200 W/LOCATION(27120): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:19:59.491+0200 W/LOCATION(27120): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:19:59.491+0200 W/LOCATION(27120): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:19:59.491+0200 W/LOCATION(27120): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:19:59.491+0200 W/LOCATION(27120): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:19:59.511+0200 W/LOCATION(27120): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:19:59.511+0200 W/LOCATION(27120): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:19:59.511+0200 W/LOCATION(27120): module-internal.c: module_new(311) > module (wps) open success
04-23 16:19:59.521+0200 W/LOCATION(27120): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:19:59.521+0200 W/LOCATION(27120): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:19:59.521+0200 W/LOCATION(27120): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:19:59.521+0200 W/LOCATION(27120): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:19:59.541+0200 W/LOCATION(27120): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:19:59.541+0200 I/LOCATION(27120): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf768ac18
04-23 16:19:59.541+0200 I/LOCATION(27120): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:19:59.541+0200 I/LOCATION(27120): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf768ac18
04-23 16:19:59.541+0200 I/LOCATION(27120): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:19:59.541+0200 I/location(27120): es.ugr.frailty.location: creado servicio de localización
04-23 16:19:59.581+0200 I/LOCATION(27120): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:19:59.621+0200 W/LOCATION(27120): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:19:59.621+0200 W/LOCATION(27120): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:19:59.621+0200 I/LOCATION(27120): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:19:59.681+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:19:59.681+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:19:59.681+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:19:59.681+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:19:59.681+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:19:59.681+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:19:59.681+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:19:59.681+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:19:59.681+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:19:59.691+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:19:59.691+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:19:59.691+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:19:59.691+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:19:59.701+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:19:59.711+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:19:59.711+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:19:59.711+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:19:59.711+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 16:19:59.711+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:19:59.721+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:19:59.731+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:19:59.731+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:19:59.731+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:19:59.741+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:19:59.751+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:19:59.751+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:19:59.751+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 16:19:59.751+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:19:59.751+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:19:59.751+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:19:59.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:19:59.781+0200 W/LOCATION(27120): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:19:59.781+0200 W/LOCATION(27120): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:19:59.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:19:59.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734c800]
04-23 16:19:59.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:19:59.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:19:59.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:19:59.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:19:59.931+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:19:59.931+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:19:59.941+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:19:59.961+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:19:59.961+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:19:59.961+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:19:59.961+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:19:59.961+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:19:59.961+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:19:59.961+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:19:59.961+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:19:59.961+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:19:59.961+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:19:59.971+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:19:59.981+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:19:59.981+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:19:59.981+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:00.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:00.051+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 7095413 to 7095714) (logOverhead=0,0,0,0,0,0,0), start: 16:19:59.758
04-23 16:20:00.051+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 305 ms (from 7095411 to 7095716) (logOverhead=0,0,0,0,0,0,0), start: 16:19:59.757
04-23 16:20:00.051+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 306 ms (from 7095411 to 7095717) (logOverhead=0,0,0,0,0,0,0), start: 16:19:59.756
04-23 16:20:00.061+0200 W/LOCATION(27120): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:20:00.071+0200 I/LOCATION(27120): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:20:00.071+0200 I/LOCATION(27120): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:20:00.071+0200 I/location(27120): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:20:00.171+0200 I/LOCATION(27120): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:20:00.221+0200 E/location(27120): es.ugr.frailty.location: error intentando obtener la última localización
04-23 16:20:00.221+0200 W/AUL     (27120): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:20:00.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:20:00.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 27120
04-23 16:20:00.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:20:00.231+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.231+0200 I/utils   (26979): specific action
04-23 16:20:00.231+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.231+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.231+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.231+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:20:00.231+0200 W/AUL     (27120): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:20:00.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:20:00.231+0200 I/location(27120): request sent to service es.ugr.frailty.servicemanager
04-23 16:20:00.231+0200 W/CAPI_APPFW_APP_CONTROL(27120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.231+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:20:00.231+0200 I/utils   (27120): specific action
04-23 16:20:00.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:20:00.241+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.241+0200 I/utils   (26984): specific action
04-23 16:20:00.241+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.241+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.241+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.241+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:00.241+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:20:00.241+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:20:00.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:20:00.241+0200 I/recorder(26984): guardando datos en local
04-23 16:20:00.241+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:20:00.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(26984), cmd(0)
04-23 16:20:00.241+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:20:00.241+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:20:00.251+0200 I/servicemanager(26979): requesting to save local data
04-23 16:20:00.641+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:20:00.641+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(7096309), time2(7032979)
04-23 16:20:00.641+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:20:00.641+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:20:00.651+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:20:00.651+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:20:00.861+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 132 ms (from 7096394 to 7096526) (logOverhead=0,0,0,0,0,0,0), start: 16:20:00.739
04-23 16:20:00.861+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 132 ms (from 7096394 to 7096526) (logOverhead=0,0,0,0,0,0,0), start: 16:20:00.739
04-23 16:20:00.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:20:00.921+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:20:00.921+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:20:01.021+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 16:20:01.741+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:20:01.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:20:01.741+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:20:02.041+0200 W/LOCATION(27120): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 16:20:02.271+0200 W/AUL     (27134): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:20:02.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:20:02.271+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:20:02.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27028
04-23 16:20:02.271+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:20:02.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:20:02.281+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:20:02.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:20:02.281+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:20:02.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:20:02.281+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:20:02.281+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:20:02.281+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:20:02.281+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:20:02.291+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27028
04-23 16:20:02.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27028)
04-23 16:20:02.301+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:02.361+0200 I/servicemanager(26979): es.ugr.frailty.location sleep timeout
04-23 16:20:02.361+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:20:02.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:20:02.361+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:20:02.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:20:02.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:20:02.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:20:02.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734c800
04-23 16:20:02.381+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 27140
04-23 16:20:02.421+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:20:02.421+0200 W/CRASH_MANAGER(27136): worker.c: worker_job(1205) > 11271206c6f63152449320
