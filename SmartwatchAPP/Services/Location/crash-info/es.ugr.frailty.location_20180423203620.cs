S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11012
Date: 2018-04-23 20:36:20+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf740e52d, r5   = 0xf7706f98
r6   = 0xff81eae0, r7   = 0xff81e990
r8   = 0xf7703c18, r9   = 0x00000000
r10  = 0xff81ea6c, fp   = 0xff81eae0
ip   = 0x00000001, sp   = 0xff81e968
lr   = 0xf740e539, pc   = 0xf7477228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    129872 KB
Buffers:     38016 KB
Cached:     158104 KB
VmPeak:      53576 KB
VmSize:      53572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12392 KB
VmRSS:       12392 KB
VmData:      11300 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11012 TID = 11012
11012 11015 

Maps Information
f42d9000 f4ad8000 rw-p [stack:11015]
f4adf000 f4ae1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ae9000 f4aed000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4af6000 f4af8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b00000 f4b03000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b12000 f4b17000 r-xp /usr/lib/libsystem.so.0.0.0
f4b22000 f4b25000 r-xp /lib/libattr.so.1.1.0
f4b2d000 f4b3d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b45000 f4b4e000 r-xp /usr/lib/libedbus.so.1.7.99
f4b56000 f4b57000 r-xp /usr/lib/libresponse.so.0.2.96
f4b60000 f4b65000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6407000 f650d000 r-xp /usr/lib/libicuuc.so.57.1
f6523000 f66ab000 r-xp /usr/lib/libicui18n.so.57.1
f66bb000 f66c8000 r-xp /usr/lib/libail.so.0.1.0
f66d1000 f66d8000 r-xp /usr/lib/libminizip.so.1.0.0
f66e1000 f688a000 r-xp /usr/lib/libcrypto.so.1.0.0
f68aa000 f68f1000 r-xp /usr/lib/libssl.so.1.0.0
f68fd000 f68ff000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6907000 f690e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6917000 f691e000 r-xp /lib/libcrypt-2.13.so
f694f000 f6952000 r-xp /lib/libcap.so.2.21
f695a000 f695c000 r-xp /usr/lib/libiri.so
f6964000 f69ad000 r-xp /usr/lib/libmdm.so.1.2.69
f69b5000 f69bb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69c3000 f69e6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69f0000 f69f2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69fa000 f6a17000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a20000 f6a24000 r-xp /usr/lib/libsmack.so.1.0.0
f6a2d000 f6a46000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a4f000 f6a57000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a5f000 f6a65000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a6e000 f6a70000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a79000 f6a89000 r-xp /lib/libresolv-2.13.so
f6a8d000 f6aa5000 r-xp /usr/lib/liblzma.so.5.0.3
f6aae000 f6ab0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ab8000 f6ad2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ada000 f6b09000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b12000 f6b21000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b2b000 f6b35000 r-xp /usr/lib/libsensord-shared.so
f6b3e000 f6c11000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c1c000 f6c32000 r-xp /lib/libz.so.1.2.5
f6c3a000 f6c3f000 r-xp /usr/lib/libffi.so.5.0.10
f6c47000 f6c48000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c50000 f6c60000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c68000 f6c81000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c89000 f6c8b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c93000 f6d08000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d12000 f6d18000 r-xp /lib/librt-2.13.so
f6d21000 f6d3f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d49000 f6d4a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d52000 f6d75000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d7d000 f6d82000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d8a000 f6db4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dbd000 f6dd4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ddc000 f6e45000 r-xp /lib/libm-2.13.so
f6e4e000 f6ee2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ef5000 f6efa000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f02000 f6f09000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f11000 f6f3b000 r-xp /usr/lib/libsensor.so.1.9.6
f6f44000 f7010000 r-xp /usr/lib/libxml2.so.2.7.8
f701d000 f701f000 r-xp /usr/lib/libiniparser.so.0
f7028000 f702e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7037000 f7107000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7108000 f713c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7145000 f7181000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7189000 f718c000 r-xp /usr/lib/libbundle.so.0.1.22
f7194000 f719a000 r-xp /usr/lib/libappsvc.so.0.1.0
f71a2000 f71e3000 r-xp /usr/lib/libeina.so.1.7.99
f71ec000 f7203000 r-xp /usr/lib/libecore.so.1.7.99
f721a000 f7223000 r-xp /usr/lib/libvconf.so.0.2.45
f722b000 f723f000 r-xp /lib/libpthread-2.13.so
f724a000 f7257000 r-xp /usr/lib/libaul.so.0.1.0
f7261000 f7263000 r-xp /lib/libdl-2.13.so
f726c000 f7277000 r-xp /lib/libunwind.so.8.0.1
f72a4000 f72ac000 r-xp /lib/libgcc_s-4.6.so.1
f72ad000 f73d1000 r-xp /lib/libc-2.13.so
f73df000 f73e1000 r-xp /usr/lib/libdlog.so.0.0.0
f73e9000 f73f5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73fe000 f7403000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f740b000 f741a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7422000 f7426000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f742f000 f7432000 r-xp /usr/lib/libappcore-agent.so.1.1
f743a000 f743c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7444000 f7448000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7450000 f746d000 r-xp /lib/ld-2.13.so
f7476000 f7479000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7479000 f747d000 r-xp /usr/lib/libsys-assert.so
f76d3000 f7763000 rw-p [heap]
ff800000 ff821000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11012)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7477228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf740e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71153f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7113c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf711fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7125be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7125dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf715a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71551f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7113c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf711fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7125be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7125dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7157e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7158017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf715ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4af71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4aea171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bbd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf706afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf706c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71fcca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71f7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71f85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71f8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7430183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74307fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf747753f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf72c485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7476f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
r.frailty.gravity: SM-R760,23/04/2018,20:36:10:300,0.048355,9.772012,0.822093
04-23 20:36:10.469+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:36:10.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:10.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:10:501,0.038931,9.770632,0.838825
04-23 20:36:10.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:10.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:10:703,0.026113,9.769093,0.857049
04-23 20:36:10.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:10.899+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_cal_charging_rem_time(1294) > data_avail_chg = 1, index_chg = 0
04-23 20:36:10.899+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_cal_charging_rem_time(1296) > last_wall_time_chg = 1524508390, curr_wall_time = 1524508570
04-23 20:36:10.899+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_cal_charging_rem_time(1297) > time diff before averaging = 180 seconds
04-23 20:36:10.899+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_get_time_diff_avg(1206) > time_diff after averaging= 117 seconds
04-23 20:36:10.899+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_cal_charging_rem_time(1337) > Capacity = 21, charging remaining time = 119 minutes
04-23 20:36:10.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:10:903,0.037793,9.773151,0.808987
04-23 20:36:11.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:11.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:11:100,0.038178,9.772413,0.817839
04-23 20:36:11.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:11.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:11:301,0.040266,9.771507,0.828493
04-23 20:36:11.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:11.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:11:500,0.043266,9.771165,0.832377
04-23 20:36:11.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:11.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:11:700,0.045037,9.771250,0.831287
04-23 20:36:11.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:11.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:11:901,0.058948,9.772559,0.814861
04-23 20:36:12.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:12.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:12:99,0.053070,9.771738,0.825047
04-23 20:36:12.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:12.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:12:300,0.050739,9.771236,0.831112
04-23 20:36:12.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:12.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:12:501,0.050005,9.771362,0.829672
04-23 20:36:12.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:12.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:12:700,0.039094,9.771036,0.834097
04-23 20:36:12.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:12.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:12:900,0.034481,9.773680,0.802733
04-23 20:36:13.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:13.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:13:99,0.036733,9.773061,0.810138
04-23 20:36:13.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:13.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:13:300,0.040514,9.772243,0.819771
04-23 20:36:13.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:13.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:13:500,0.040742,9.772613,0.815334
04-23 20:36:13.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:13.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:13:700,0.037747,9.772511,0.816700
04-23 20:36:13.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:13.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:13:900,0.031769,9.770942,0.835507
04-23 20:36:14.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:14.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:14:102,0.034936,9.770938,0.835422
04-23 20:36:14.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:14.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:14:301,0.029874,9.770326,0.842748
04-23 20:36:14.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:14.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:14:500,0.020200,9.767262,0.877818
04-23 20:36:14.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:14.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:14:700,0.026525,9.770059,0.845956
04-23 20:36:14.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:14.949+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:14:903,0.020318,9.766964,0.881132
04-23 20:36:15.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:15.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:15:99,0.029559,9.774376,0.794413
04-23 20:36:15.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:15.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:15:300,0.033343,9.772714,0.814456
04-23 20:36:15.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:15.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:15:501,0.043814,9.771852,0.824240
04-23 20:36:15.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:15.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:15:700,0.026263,9.769681,0.850313
04-23 20:36:15.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:15.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:15:900,0.023307,9.768750,0.861021
04-23 20:36:16.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:16.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:16:100,0.026955,9.770260,0.843612
04-23 20:36:16.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:16.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:16:300,0.028546,9.770836,0.836864
04-23 20:36:16.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:16.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:16:500,0.023289,9.768540,0.863400
04-23 20:36:16.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:16.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:16:700,0.043881,9.772301,0.818902
04-23 20:36:16.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:16.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:16:900,0.035110,9.771645,0.827109
04-23 20:36:17.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:17.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:17:102,0.031717,9.770759,0.837644
04-23 20:36:17.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:17.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:17:300,0.019132,9.766936,0.881460
04-23 20:36:17.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:17.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:17:500,0.017036,9.766212,0.889499
04-23 20:36:17.599+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:36:17.599+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:36:17.599+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:17.599+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:17.619+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11012
04-23 20:36:17.619+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:36:17.669+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11012
04-23 20:36:17.669+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11012) type(svcapp) bg(0)
04-23 20:36:17.679+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11012]
04-23 20:36:17.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:17.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:17:705,0.032305,9.769616,0.850847
04-23 20:36:17.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:17.709+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11012
04-23 20:36:17.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:17.719+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11012)
04-23 20:36:17.719+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:36:17.719+0200 I/servicemanager(10115): App control destroyed.
04-23 20:36:17.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:17.739+0200 E/CAPI_APPFW_APPLICATION(11012): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:17.739+0200 E/CAPI_APPFW_APPLICATION(11012): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:17.739+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11012
04-23 20:36:17.739+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11012) was created
04-23 20:36:17.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:17.759+0200 W/LOCATION(11012): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:36:17.759+0200 E/LOCATION(11012): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:36:17.759+0200 E/PKGMGR_INFO(11012): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:36:17.769+0200 W/LOCATION(11012): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:17.789+0200 I/LOCATION(11012): location.c: location_new(269) > method: 0
04-23 20:36:17.789+0200 W/LOCATION(11012): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:17.789+0200 W/LOCATION(11012): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:17.799+0200 W/LOCATION(11012): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:17.799+0200 W/LOCATION(11012): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:17.809+0200 W/LOCATION(11012): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:17.809+0200 W/LOCATION(11012): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:17.809+0200 W/LOCATION(11012): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:17.809+0200 W/LOCATION(11012): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:17.809+0200 W/LOCATION(11012): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:17.829+0200 W/LOCATION(11012): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:17.829+0200 W/LOCATION(11012): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:17.839+0200 W/LOCATION(11012): module-internal.c: module_new(311) > module (wps) open success
04-23 20:36:17.839+0200 W/LOCATION(11012): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:36:17.839+0200 W/LOCATION(11012): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:36:17.839+0200 W/LOCATION(11012): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:17.839+0200 W/LOCATION(11012): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:17.859+0200 W/LOCATION(11012): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:36:17.859+0200 I/LOCATION(11012): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7703c18
04-23 20:36:17.859+0200 I/LOCATION(11012): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:36:17.859+0200 I/LOCATION(11012): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7703c18
04-23 20:36:17.859+0200 I/LOCATION(11012): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:36:17.859+0200 I/location(11012): es.ugr.frailty.location: creado servicio de localización
04-23 20:36:17.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:17.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:17:899,0.034505,9.770967,0.835111
04-23 20:36:17.909+0200 I/LOCATION(11012): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:36:17.949+0200 W/LOCATION(11012): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:17.949+0200 W/LOCATION(11012): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:17.949+0200 I/LOCATION(11012): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:18.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:36:18.009+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:36:18.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:36:18.009+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:36:18.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:36:18.009+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:36:18.009+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:36:18.009+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:36:18.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:18.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:18.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:36:18.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:36:18.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:36:18.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:36:18.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:36:18.009+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:36:18.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:36:18.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:36:18.079+0200 W/LOCATION(11012): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:18.079+0200 W/LOCATION(11012): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:18.099+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:18.099+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:18.099+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:18.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:107,0.042999,9.770010,0.845838
04-23 20:36:18.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:119,0.043816,9.770026,0.845611
04-23 20:36:18.129+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:142,0.043008,9.770019,0.845739
04-23 20:36:18.149+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.159+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:160,0.044535,9.770255,0.842923
04-23 20:36:18.169+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.179+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:180,0.046089,9.770346,0.841788
04-23 20:36:18.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:18.189+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.199+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:201,0.044820,9.770310,0.842265
04-23 20:36:18.209+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:219,0.044432,9.770205,0.843501
04-23 20:36:18.229+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf73268f0]
04-23 20:36:18.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:36:18.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:36:18.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:36:18.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:18.239+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:240,0.045418,9.770286,0.842524
04-23 20:36:18.239+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:18.239+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:18.249+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:18.249+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.259+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:261,0.044870,9.770237,0.843113
04-23 20:36:18.259+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:18.259+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:18.259+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:18.259+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:18.259+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:18.259+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:18.259+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:18.259+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:18.259+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:18.259+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:18.269+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:18.269+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.279+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:279,0.044023,9.770082,0.844949
04-23 20:36:18.279+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:18.279+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:18.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:18.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:36:18.289+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2653556), time2(2640324)
04-23 20:36:18.289+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:36:18.289+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:36:18.289+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:36:18.289+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:36:18.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:303,0.044797,9.770175,0.843835
04-23 20:36:18.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:320,0.044517,9.770130,0.844374
04-23 20:36:18.329+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:18.329+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.329+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:339,0.042333,9.769916,0.846955
04-23 20:36:18.359+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.359+0200 W/LOCATION(11012): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:36:18.359+0200 I/LOCATION(11012): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:18.359+0200 I/LOCATION(11012): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:18.359+0200 I/location(11012): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:36:18.369+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:364,0.043420,9.770060,0.845237
04-23 20:36:18.369+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.379+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:380,0.043207,9.770053,0.845326
04-23 20:36:18.389+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.399+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:399,0.043459,9.770061,0.845220
04-23 20:36:18.409+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.419+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:419,0.041890,9.769873,0.847474
04-23 20:36:18.429+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.439+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:439,0.043863,9.769964,0.846317
04-23 20:36:18.449+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.459+0200 I/LOCATION(11012): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:18.459+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:460,0.042587,9.769956,0.846483
04-23 20:36:18.469+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.479+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:479,0.043132,9.769905,0.847036
04-23 20:36:18.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:499,0.042244,9.769881,0.847365
04-23 20:36:18.499+0200 W/AUL     (11012): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:36:18.509+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:18.509+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11012
04-23 20:36:18.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:519,0.042083,9.770171,0.844015
04-23 20:36:18.519+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:36:18.519+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.519+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:18.519+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:36:18.519+0200 I/utils   (10115): specific action
04-23 20:36:18.519+0200 W/AUL     (11012): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:36:18.519+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.519+0200 I/location(11012): request sent to service es.ugr.frailty.servicemanager
04-23 20:36:18.519+0200 I/location(11012): es.ugr.frailty.location: SM-R760,23/04/2018,20:36:18:509,nan,37.171673,-3.594138,0.000000,0,0.000000,43.000000,-1.000000
04-23 20:36:18.519+0200 W/CAPI_APPFW_APP_CONTROL(11012): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.519+0200 I/utils   (11012): specific action
04-23 20:36:18.519+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.519+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.519+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:36:18.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:18.519+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:18.529+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:36:18.529+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.529+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:18.529+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:36:18.529+0200 I/utils   (10120): specific action
04-23 20:36:18.529+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.529+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.529+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.529+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:18.529+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:36:18.529+0200 I/recorder(10120): guardando datos en local
04-23 20:36:18.529+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:36:18.529+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:36:18.529+0200 I/servicemanager(10115): requesting to save local data
04-23 20:36:18.529+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.529+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:539,0.040572,9.770010,0.845956
04-23 20:36:18.549+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.559+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:561,0.041175,9.770131,0.844524
04-23 20:36:18.569+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.579+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:580,0.041166,9.770092,0.844978
04-23 20:36:18.589+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.599+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:600,0.040596,9.770250,0.843172
04-23 20:36:18.609+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.619+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:621,0.039375,9.770157,0.844321
04-23 20:36:18.629+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.639+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:641,0.039469,9.770190,0.843922
04-23 20:36:18.649+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.659+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:662,0.039215,9.770202,0.843800
04-23 20:36:18.669+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.679+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:681,0.039094,9.770072,0.845312
04-23 20:36:18.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:701,0.038631,9.769929,0.846986
04-23 20:36:18.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:720,0.038410,9.770064,0.845431
04-23 20:36:18.729+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.739+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:740,0.037872,9.769878,0.847602
04-23 20:36:18.749+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.759+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:761,0.038625,9.770245,0.843329
04-23 20:36:18.769+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.779+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:781,0.038406,9.770231,0.843494
04-23 20:36:18.789+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.799+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:801,0.038010,9.770036,0.845779
04-23 20:36:18.809+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.819+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:820,0.036571,9.769896,0.847463
04-23 20:36:18.829+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.839+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:841,0.038730,9.770185,0.844021
04-23 20:36:18.849+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.859+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:862,0.037608,9.770019,0.845992
04-23 20:36:18.869+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.879+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:881,0.038904,9.770057,0.845497
04-23 20:36:18.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:901,0.039015,9.770102,0.844968
04-23 20:36:18.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.919+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:921,0.040256,9.770226,0.843468
04-23 20:36:18.929+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.939+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:940,0.039842,9.770358,0.841962
04-23 20:36:18.949+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.959+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:960,0.040370,9.770392,0.841540
04-23 20:36:18.969+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.979+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:981,0.041099,9.770489,0.840383
04-23 20:36:18.989+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:18.999+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:18:999,0.040651,9.770500,0.840276
04-23 20:36:19.009+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.019+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:20,0.040357,9.770583,0.839324
04-23 20:36:19.029+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.039+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:41,0.040774,9.770905,0.835540
04-23 20:36:19.049+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.059+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:61,0.041141,9.770921,0.835338
04-23 20:36:19.069+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.079+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:80,0.041374,9.770922,0.835316
04-23 20:36:19.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:19.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:19.089+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:19.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:100,0.041370,9.770882,0.835789
04-23 20:36:19.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:121,0.042390,9.770971,0.834694
04-23 20:36:19.129+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:141,0.041183,9.770988,0.834553
04-23 20:36:19.169+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.199+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:174,0.040291,9.770761,0.837246
04-23 20:36:19.199+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.209+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:211,0.040229,9.770660,0.838429
04-23 20:36:19.209+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:221,0.039253,9.770590,0.839298
04-23 20:36:19.219+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.229+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:230,0.038659,9.770689,0.838166
04-23 20:36:19.229+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.239+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:241,0.039355,9.770795,0.836898
04-23 20:36:19.249+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.269+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:261,0.040143,9.770992,0.834552
04-23 20:36:19.269+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.279+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:282,0.041092,9.770870,0.835941
04-23 20:36:19.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:303,0.041453,9.770959,0.834877
04-23 20:36:19.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:319,0.040899,9.770821,0.836522
04-23 20:36:19.329+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.339+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:339,0.038662,9.770571,0.839550
04-23 20:36:19.339+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:36:19.349+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.359+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:360,0.037539,9.770444,0.841066
04-23 20:36:19.369+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.379+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:379,0.035576,9.770107,0.845053
04-23 20:36:19.389+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.399+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:400,0.038711,9.770525,0.840075
04-23 20:36:19.409+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.419+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:420,0.039167,9.770502,0.840317
04-23 20:36:19.429+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.439+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:440,0.039612,9.770476,0.840603
04-23 20:36:19.449+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.459+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:462,0.038765,9.770602,0.839171
04-23 20:36:19.469+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.479+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:480,0.037284,9.770455,0.840949
04-23 20:36:19.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:500,0.038385,9.770478,0.840636
04-23 20:36:19.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:520,0.038861,9.770429,0.841183
04-23 20:36:19.529+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.539+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:539,0.041010,9.770503,0.840221
04-23 20:36:19.549+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.559+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:561,0.041582,9.770560,0.839526
04-23 20:36:19.569+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.579+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:580,0.041228,9.770501,0.840231
04-23 20:36:19.589+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.599+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:600,0.040091,9.770363,0.841899
04-23 20:36:19.609+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.619+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:620,0.041849,9.770507,0.840139
04-23 20:36:19.629+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.639+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:640,0.038672,9.770194,0.843922
04-23 20:36:19.649+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.659+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:661,0.038570,9.770153,0.844395
04-23 20:36:19.669+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.679+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:680,0.038127,9.770234,0.843481
04-23 20:36:19.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:701,0.039567,9.770175,0.844094
04-23 20:36:19.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:719,0.040489,9.770246,0.843240
04-23 20:36:19.729+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.739+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:739,0.039171,9.770042,0.845647
04-23 20:36:19.749+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.759+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:761,0.038722,9.769637,0.850341
04-23 20:36:19.769+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.779+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:779,0.039885,9.769826,0.848107
04-23 20:36:19.789+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.799+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:799,0.039488,9.769830,0.848083
04-23 20:36:19.809+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.819+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:820,0.038552,9.769650,0.850199
04-23 20:36:19.829+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.839+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:839,0.038023,9.769547,0.851414
04-23 20:36:19.849+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.859+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:860,0.037834,9.769570,0.851149
04-23 20:36:19.869+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.879+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:880,0.036853,9.769566,0.851247
04-23 20:36:19.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:899,0.034906,9.769291,0.854468
04-23 20:36:19.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.919+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:921,0.032858,9.768918,0.858808
04-23 20:36:19.929+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.939+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:941,0.032704,9.768784,0.860336
04-23 20:36:19.949+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.959+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:961,0.031972,9.768728,0.860996
04-23 20:36:19.969+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.979+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:19:979,0.033413,9.768735,0.860868
04-23 20:36:19.989+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:19.999+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:0,0.035060,9.769132,0.856286
04-23 20:36:20.009+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.029+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:23,0.032236,9.768818,0.859971
04-23 20:36:20.029+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.039+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:43,0.033495,9.769198,0.855586
04-23 20:36:20.049+0200 W/LOCATION(11012): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:36:20.049+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:20.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:20.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:20.079+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:81,0.032744,9.769087,0.856889
04-23 20:36:20.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:95,0.032355,9.769021,0.857646
04-23 20:36:20.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:106,0.031546,9.768898,0.859084
04-23 20:36:20.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:120,0.031552,9.768886,0.859221
04-23 20:36:20.129+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:139,0.031784,9.768968,0.858279
04-23 20:36:20.149+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.159+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:161,0.032239,9.769172,0.855936
04-23 20:36:20.169+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.179+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:180,0.031188,9.769029,0.857608
04-23 20:36:20.189+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.199+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:199,0.030752,9.768901,0.859075
04-23 20:36:20.209+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:20:219,0.032186,9.769217,0.855425
04-23 20:36:20.249+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:20.249+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11110126c6f63152450858
