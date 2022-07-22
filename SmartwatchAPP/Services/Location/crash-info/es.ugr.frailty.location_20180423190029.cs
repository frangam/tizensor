S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5810
Date: 2018-04-23 19:00:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75e052d, r5   = 0xf7806958
r6   = 0xff82b3c0, r7   = 0xff82b270
r8   = 0xf7819c18, r9   = 0x00000000
r10  = 0xff82b34c, fp   = 0xff82b3c0
ip   = 0x00000001, sp   = 0xff82b248
lr   = 0xf75e0539, pc   = 0xf7649228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     66388 KB
Buffers:     37612 KB
Cached:     224328 KB
VmPeak:      53452 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12096 KB
VmRSS:       12096 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5810 TID = 5810
5810 5839 

Maps Information
f44ab000 f4caa000 rw-p [stack:5839]
f4cb1000 f4cb3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cbb000 f4cbf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cc8000 f4cca000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cd2000 f4cd5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ce4000 f4ce9000 r-xp /usr/lib/libsystem.so.0.0.0
f4cf4000 f4cf7000 r-xp /lib/libattr.so.1.1.0
f4cff000 f4d0f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d17000 f4d20000 r-xp /usr/lib/libedbus.so.1.7.99
f4d28000 f4d29000 r-xp /usr/lib/libresponse.so.0.2.96
f4d32000 f4d37000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65d9000 f66df000 r-xp /usr/lib/libicuuc.so.57.1
f66f5000 f687d000 r-xp /usr/lib/libicui18n.so.57.1
f688d000 f689a000 r-xp /usr/lib/libail.so.0.1.0
f68a3000 f68aa000 r-xp /usr/lib/libminizip.so.1.0.0
f68b3000 f6a5c000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a7c000 f6ac3000 r-xp /usr/lib/libssl.so.1.0.0
f6acf000 f6ad1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ad9000 f6ae0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ae9000 f6af0000 r-xp /lib/libcrypt-2.13.so
f6b21000 f6b24000 r-xp /lib/libcap.so.2.21
f6b2c000 f6b2e000 r-xp /usr/lib/libiri.so
f6b36000 f6b7f000 r-xp /usr/lib/libmdm.so.1.2.69
f6b87000 f6b8d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b95000 f6bb8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bc2000 f6bc4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bcc000 f6be9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bf2000 f6bf6000 r-xp /usr/lib/libsmack.so.1.0.0
f6bff000 f6c18000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c21000 f6c29000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c31000 f6c37000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c40000 f6c42000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c4b000 f6c5b000 r-xp /lib/libresolv-2.13.so
f6c5f000 f6c77000 r-xp /usr/lib/liblzma.so.5.0.3
f6c80000 f6c82000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c8a000 f6ca4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cac000 f6cdb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ce4000 f6cf3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cfd000 f6d07000 r-xp /usr/lib/libsensord-shared.so
f6d10000 f6de3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dee000 f6e04000 r-xp /lib/libz.so.1.2.5
f6e0c000 f6e11000 r-xp /usr/lib/libffi.so.5.0.10
f6e19000 f6e1a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e22000 f6e32000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e3a000 f6e53000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e5b000 f6e5d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e65000 f6eda000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ee4000 f6eea000 r-xp /lib/librt-2.13.so
f6ef3000 f6f11000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f1b000 f6f1c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f24000 f6f47000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f4f000 f6f54000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f5c000 f6f86000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f8f000 f6fa6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fae000 f7017000 r-xp /lib/libm-2.13.so
f7020000 f70b4000 r-xp /usr/lib/libstdc++.so.6.0.16
f70c7000 f70cc000 r-xp /usr/lib/libctx-client.so.0.8.3
f70d4000 f70db000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70e3000 f710d000 r-xp /usr/lib/libsensor.so.1.9.6
f7116000 f71e2000 r-xp /usr/lib/libxml2.so.2.7.8
f71ef000 f71f1000 r-xp /usr/lib/libiniparser.so.0
f71fa000 f7200000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7209000 f72d9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72da000 f730e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7317000 f7353000 r-xp /usr/lib/libSLP-location.so.0.9.24
f735b000 f735e000 r-xp /usr/lib/libbundle.so.0.1.22
f7366000 f736c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7374000 f73b5000 r-xp /usr/lib/libeina.so.1.7.99
f73be000 f73d5000 r-xp /usr/lib/libecore.so.1.7.99
f73ec000 f73f5000 r-xp /usr/lib/libvconf.so.0.2.45
f73fd000 f7411000 r-xp /lib/libpthread-2.13.so
f741c000 f7429000 r-xp /usr/lib/libaul.so.0.1.0
f7433000 f7435000 r-xp /lib/libdl-2.13.so
f743e000 f7449000 r-xp /lib/libunwind.so.8.0.1
f7476000 f747e000 r-xp /lib/libgcc_s-4.6.so.1
f747f000 f75a3000 r-xp /lib/libc-2.13.so
f75b1000 f75b3000 r-xp /usr/lib/libdlog.so.0.0.0
f75bb000 f75c7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75d0000 f75d5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75dd000 f75ec000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75f4000 f75f8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7601000 f7604000 r-xp /usr/lib/libappcore-agent.so.1.1
f760c000 f760e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7616000 f761a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7622000 f763f000 r-xp /lib/ld-2.13.so
f7648000 f764b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f764b000 f764f000 r-xp /usr/lib/libsys-assert.so
f77e9000 f785a000 rw-p [heap]
ff80c000 ff82d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5810)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7649228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75e0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72e73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72e5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72f1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72f7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72f7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf732c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73271f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72e5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72f1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72f7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72f7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7329e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf732a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7331f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cc91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cbc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d8f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf723cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf723e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73ceca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73c9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73ca5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73ca879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7602183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76027fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76494f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf749685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7648f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:28:903,-0.006804,-0.065339,0.171331
04-23 19:00:28.899+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:28.899+0200 I/heartrate( 5710): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:00:28:901,72
04-23 19:00:28.899+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:28.899+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:28:907,9.698111,-0.803988,1.371087
04-23 19:00:28.899+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:28:909,30.660000,-2.590000,13.020000
04-23 19:00:28.909+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:28.909+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:28.919+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:28.919+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:28:921,0.043218,0.054697,-0.357108
04-23 19:00:28.919+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:28:921,25.340000,-0.140000,15.190001
04-23 19:00:28.919+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:28:923,9.741181,-0.708275,0.882952
04-23 19:00:28.929+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:28.929+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:28.939+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:28:941,0.088420,-0.309355,-0.624946
04-23 19:00:28.939+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:28.939+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:28:941,22.680000,1.120000,16.660000
04-23 19:00:28.939+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:28:946,9.781858,-1.098306,0.634098
04-23 19:00:28.959+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:28.959+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:28.959+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:28:968,46.410000,3.570000,16.030001
04-23 19:00:28.959+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:28:968,0.169198,-0.942594,-0.431237
04-23 19:00:28.959+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:28.969+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:28:972,9.858429,-1.777867,0.830309
04-23 19:00:28.969+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:28.969+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:28.979+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:28:981,76.370003,8.400000,12.180000
04-23 19:00:28.979+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:28:981,0.107638,-0.648928,-0.417445
04-23 19:00:28.979+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:28.989+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:28:989,9.786645,-1.548156,0.878166
04-23 19:00:28.989+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:28.989+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:28.999+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:1,90.580002,9.310000,11.550000
04-23 19:00:28.999+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:28.999+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:2,0.022751,-0.067202,-0.514398
04-23 19:00:29.009+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:9,9.690931,-1.009771,0.830309
04-23 19:00:29.019+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.019+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:00:29.019+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:00:29.019+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:00:29.019+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.039+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:27,86.309998,11.340000,9.870000
04-23 19:00:29.039+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.039+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:32,-0.071070,-0.085030,-0.532313
04-23 19:00:29.039+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.039+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.049+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:47,0.014917,-0.850506,-0.292739
04-23 19:00:29.049+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:44,9.588040,-1.045663,0.863809
04-23 19:00:29.059+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:48,85.050003,7.770000,9.520000
04-23 19:00:29.059+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.059+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.059+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.069+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:69,0.406947,-0.600498,-0.932180
04-23 19:00:29.069+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.079+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:72,71.470001,10.360000,5.040000
04-23 19:00:29.079+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.079+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:81,0.501845,0.427828,-0.535510
04-23 19:00:29.079+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:87,26.040001,16.309999,2.380000
04-23 19:00:29.079+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:68,9.664611,-1.828116,1.155733
04-23 19:00:29.089+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.089+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:94,10.042676,-1.619941,0.579063
04-23 19:00:29.089+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.089+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.089+0200 I/heartrate( 5710): capturing data from es.ugr.frailty.heartrate
04-23 19:00:29.099+0200 I/heartrate( 5710): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:00:29:101,71
04-23 19:00:29.099+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:101,-0.201347,0.296724,-0.244352
04-23 19:00:29.099+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.109+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:100,10.133603,-0.617348,0.983450
04-23 19:00:29.109+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.109+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.119+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:119,9.427721,-0.736989,1.299303
04-23 19:00:29.119+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.119+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:110,-19.460001,17.360001,3.220000
04-23 19:00:29.119+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.129+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:128,9.365508,-1.500300,1.832902
04-23 19:00:29.129+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:122,-0.259377,-0.459802,0.267862
04-23 19:00:29.129+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:132,-41.790001,10.640000,2.660000
04-23 19:00:29.129+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.129+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.139+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:141,9.635897,-1.725225,1.813759
04-23 19:00:29.139+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.139+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:142,0.018379,-0.644797,0.230593
04-23 19:00:29.139+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:147,-33.389999,5.670000,-3.080000
04-23 19:00:29.159+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.159+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.159+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:167,0.203540,-0.433231,0.003750
04-23 19:00:29.159+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:167,9.817751,-1.543371,1.586441
04-23 19:00:29.159+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.169+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:172,-23.520000,8.190000,-9.100000
04-23 19:00:29.169+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.169+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.179+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:181,9.868000,-1.036092,1.493121
04-23 19:00:29.179+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:181,0.252730,0.081855,-0.077600
04-23 19:00:29.179+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.189+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.189+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.199+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:201,9.655040,-0.641276,1.725225
04-23 19:00:29.199+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:187,-22.049999,9.450000,-9.800000
04-23 19:00:29.199+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.199+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:201,0.036235,0.462160,0.165930
04-23 19:00:29.209+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:210,-23.799999,8.050000,-8.610000
04-23 19:00:29.209+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.209+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.219+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.219+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:221,9.489935,-0.875773,1.770689
04-23 19:00:29.219+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:221,-0.131674,0.198791,0.208526
04-23 19:00:29.219+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:223,-21.980000,6.230000,-6.160000
04-23 19:00:29.229+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.229+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.239+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:241,-0.007718,0.528820,0.291667
04-23 19:00:29.239+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:242,9.614362,-0.533599,1.859223
04-23 19:00:29.239+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.249+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:248,-24.920000,1.960000,-7.000000
04-23 19:00:29.259+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.259+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.269+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.279+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:269,-0.059461,0.406013,0.246390
04-23 19:00:29.279+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.289+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:275,9.566505,-0.624527,1.811367
04-23 19:00:29.289+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:286,0.010163,0.183415,0.261229
04-23 19:00:29.289+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.299+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:299,9.640682,-0.823131,1.813759
04-23 19:00:29.299+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.309+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.319+0200 I/heartrate( 5710): capturing data from es.ugr.frailty.heartrate
04-23 19:00:29.319+0200 I/heartrate( 5710): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:00:29:324,71
04-23 19:00:29.319+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:269,-36.470001,0.280000,-6.790000
04-23 19:00:29.329+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:309,0.032859,-0.149519,-0.059967
04-23 19:00:29.329+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.329+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.339+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:314,9.667004,-1.146162,1.476372
04-23 19:00:29.339+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.349+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:335,0.198937,-0.203327,-0.259218
04-23 19:00:29.349+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.349+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:345,9.836893,-1.205983,1.249053
04-23 19:00:29.359+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:342,-37.099998,-3.570000,-3.850000
04-23 19:00:29.359+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.359+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.369+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:355,0.141567,0.008052,-0.318184
04-23 19:00:29.369+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:371,9.784252,-1.000200,1.155733
04-23 19:00:29.369+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.379+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:380,0.023909,-0.111960,-0.296960
04-23 19:00:29.379+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:364,-26.670000,-6.020000,-1.540000
04-23 19:00:29.379+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.389+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.389+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:389,-13.370000,-6.720000,-0.910000
04-23 19:00:29.389+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.389+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:393,9.671788,-1.115055,1.146162
04-23 19:00:29.389+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:396,-3.850000,-5.460000,-0.910000
04-23 19:00:29.389+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.389+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.399+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:401,6.090000,-1.960000,-0.840000
04-23 19:00:29.399+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.399+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.399+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:407,8.610000,-3.290000,-1.960000
04-23 19:00:29.399+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.409+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:401,0.131393,-0.053363,-0.156714
04-23 19:00:29.409+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.409+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:411,5.390000,-2.030000,-2.450000
04-23 19:00:29.409+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:407,9.781858,-1.057628,1.268196
04-23 19:00:29.409+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:414,0.109314,-0.064608,-0.079054
04-23 19:00:29.409+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.409+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.419+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:421,3.150000,-2.170000,-2.800000
04-23 19:00:29.419+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.419+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:422,9.762716,-1.062413,1.330409
04-23 19:00:29.419+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.419+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:427,0.100032,-0.067572,-0.231097
04-23 19:00:29.419+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:428,9.755538,-1.060020,1.167697
04-23 19:00:29.429+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.439+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.439+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.439+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:441,-1.050000,-2.590000,-2.170000
04-23 19:00:29.439+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:443,0.144537,-0.115764,-0.338270
04-23 19:00:29.439+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:443,9.803394,-1.103091,1.040878
04-23 19:00:29.459+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.459+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.469+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:469,0.135906,-0.216973,-0.026839
04-23 19:00:29.469+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.469+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:469,0.210000,2.450000,-3.220000
04-23 19:00:29.479+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.479+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:483,-0.005019,-0.088307,0.271181
04-23 19:00:29.479+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.489+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:475,9.798609,-1.203590,1.325624
04-23 19:00:29.489+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.489+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:489,5.740000,0.910000,-4.480000
04-23 19:00:29.489+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:494,9.657433,-1.079163,1.622334
04-23 19:00:29.499+0200 I/heartrate( 5710): capturing data from es.ugr.frailty.heartrate
04-23 19:00:29.499+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.499+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:504,9.561719,-0.954736,1.674976
04-23 19:00:29.499+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.499+0200 I/heartrate( 5710): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:00:29:502,71
04-23 19:00:29.499+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.509+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:510,11.340000,-2.310000,-4.690000
04-23 19:00:29.509+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:512,-0.099987,0.030190,0.314186
04-23 19:00:29.509+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.519+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.519+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:522,9.803394,-0.921237,1.299303
04-23 19:00:29.519+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:524,0.141090,0.048708,-0.067981
04-23 19:00:29.519+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.529+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:530,11.480000,-4.830000,-4.620000
04-23 19:00:29.539+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.539+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.549+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:544,9.834501,-0.899701,1.418944
04-23 19:00:29.549+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.549+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:543,0.167860,0.051348,0.069151
04-23 19:00:29.549+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:554,3.150000,-1.960000,-4.410000
04-23 19:00:29.559+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.559+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.559+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:567,9.647861,-1.050449,1.272982
04-23 19:00:29.569+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.569+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:567,1.540000,-1.400000,-3.430000
04-23 19:00:29.569+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:573,-0.021276,-0.114106,-0.069199
04-23 19:00:29.569+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.569+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.579+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:581,9.621540,-0.930808,1.050449
04-23 19:00:29.579+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:581,4.410000,-2.100000,-2.660000
04-23 19:00:29.579+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.579+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:587,-0.049376,0.002394,-0.281053
04-23 19:00:29.589+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.589+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.589+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.599+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:601,9.772287,-0.674776,1.110270
04-23 19:00:29.599+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:602,0.097853,0.250968,-0.200719
04-23 19:00:29.609+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:601,11.480000,-2.940000,-3.430000
04-23 19:00:29.609+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.619+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.619+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.619+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:622,9.903893,-0.641276,1.459622
04-23 19:00:29.629+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:624,12.600000,-0.350000,-4.690000
04-23 19:00:29.629+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:622,0.224832,0.259952,0.165817
04-23 19:00:29.629+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.629+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.639+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:642,9.576077,-0.626920,1.548156
04-23 19:00:29.639+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:642,-0.105086,0.248169,0.252129
04-23 19:00:29.639+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.649+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:649,1.190000,1.050000,-5.250000
04-23 19:00:29.659+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.659+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.669+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:670,9.473185,-1.069592,1.464408
04-23 19:00:29.669+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:669,-0.209100,-0.216374,0.162187
04-23 19:00:29.669+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.669+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.669+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.679+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:682,0.114501,-0.288024,-0.107622
04-23 19:00:29.699+0200 I/heartrate( 5710): capturing data from es.ugr.frailty.heartrate
04-23 19:00:29.699+0200 W/LOCATION( 5810): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:00:29.709+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:677,-5.810000,-2.800000,-1.400000
04-23 19:00:29.709+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.709+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.709+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:714,1.400000,-5.390000,-0.840000
04-23 19:00:29.709+0200 I/heartrate( 5710): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:00:29:707,71
04-23 19:00:29.719+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.719+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:724,8.750000,0.420000,-2.170000
04-23 19:00:29.719+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:682,9.796216,-1.148555,1.194018
04-23 19:00:29.719+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.719+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.729+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:713,0.234788,-0.089664,-0.252623
04-23 19:00:29.729+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:731,14.630000,1.820000,-2.730000
04-23 19:00:29.729+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.729+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.739+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:732,9.918249,-0.957129,1.031307
04-23 19:00:29.739+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:742,11.830000,1.470000,-3.780000
04-23 19:00:29.739+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:738,0.149059,0.264543,-0.310960
04-23 19:00:29.739+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.749+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.759+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:751,9.834501,-0.600598,0.959522
04-23 19:00:29.759+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.759+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.759+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:754,0.042933,0.236629,0.020439
04-23 19:00:29.769+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:768,8.890000,-0.280000,-2.100000
04-23 19:00:29.769+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.769+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.779+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:765,9.731609,-0.607777,1.280160
04-23 19:00:29.779+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.779+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:775,-0.130946,0.129300,0.109617
04-23 19:00:29.779+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.779+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:782,13.020000,-2.170000,-1.820000
04-23 19:00:29.779+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:785,-0.006971,-0.086277,-0.000087
04-23 19:00:29.789+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:784,9.559326,-0.693919,1.371087
04-23 19:00:29.789+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.789+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.789+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.799+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:801,26.389999,0.840000,-3.570000
04-23 19:00:29.799+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:801,0.092725,-0.331873,-0.118476
04-23 19:00:29.799+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:797,9.683753,-0.897308,1.265803
04-23 19:00:29.809+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.809+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:813,9.784252,-1.138984,1.143769
04-23 19:00:29.809+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.809+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.819+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:822,37.170002,4.060000,-6.860000
04-23 19:00:29.819+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:822,0.166901,0.170751,-0.174273
04-23 19:00:29.819+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.829+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:829,9.858429,-0.638884,1.086342
04-23 19:00:29.829+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.829+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.839+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:841,23.799999,3.500000,-5.180000
04-23 19:00:29.839+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:841,-0.005325,0.439384,0.079599
04-23 19:00:29.839+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.849+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:847,9.688539,-0.342174,1.339981
04-23 19:00:29.859+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.859+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.859+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:867,7.350000,-0.280000,-3.150000
04-23 19:00:29.859+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:867,-0.076139,0.035818,0.133932
04-23 19:00:29.869+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.869+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:873,9.619147,-0.710668,1.404587
04-23 19:00:29.869+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.869+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.879+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:881,5.390000,-0.490000,-3.080000
04-23 19:00:29.879+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.879+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:881,0.069412,-0.387872,-0.198822
04-23 19:00:29.879+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:886,9.765109,-1.124627,1.074377
04-23 19:00:29.889+0200 I/heartrate( 5710): capturing data from es.ugr.frailty.heartrate
04-23 19:00:29.889+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.899+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.899+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.899+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:901,17.080000,2.100000,-4.900000
04-23 19:00:29.899+0200 I/heartrate( 5710): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:00:29:901,71
04-23 19:00:29.899+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:903,9.951750,-0.830309,1.428515
04-23 19:00:29.909+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:906,0.255019,-0.083648,0.169033
04-23 19:00:29.909+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.909+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.919+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.919+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:923,9.710074,-0.449851,1.416551
04-23 19:00:29.919+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:922,0.013541,0.287244,0.149934
04-23 19:00:29.919+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:922,22.260000,3.570000,-7.000000
04-23 19:00:29.929+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.929+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.939+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.939+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:941,-0.011616,0.500372,-0.135832
04-23 19:00:29.939+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:943,9.686146,-0.205783,1.138984
04-23 19:00:29.939+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:941,11.620000,1.820000,-6.510000
04-23 19:00:29.959+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.959+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.959+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:967,-2.590000,-0.070000,-3.080000
04-23 19:00:29.959+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.959+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:967,0.094409,0.114985,-0.158083
04-23 19:00:29.969+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:971,9.796216,-0.550349,1.107877
04-23 19:00:29.969+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.969+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.969+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:29.979+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:29:981,0.137159,-0.081214,0.146103
04-23 19:00:29.979+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:29:981,9.841680,-0.734596,1.397408
04-23 19:00:29.979+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:29:981,0.910000,2.730000,-3.570000
04-23 19:00:29.999+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:29.999+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:30:6,-0.101674,-0.055404,0.325363
04-23 19:00:29.999+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:29.999+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:30.009+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:30:10,9.602397,-0.705883,1.581656
04-23 19:00:30.029+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:00:30.029+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:00:30.029+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:00:30.029+0200 W/libgps_d( 3158): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 19:00:30.029+0200 W/libgps  ( 3158): [proxy__gps_stop][line = 1067]: called.
04-23 19:00:30.029+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:00:30.029+0200 W/libgps_d( 3158): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 19:00:30.029+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 19:00:30.029+0200 W/libgps_d( 3158): GpsiHookStateGps              : EXIT
04-23 19:00:30.029+0200 W/libgps_d( 3158): GpsiHookStateIdle             : ENTRY
04-23 19:00:30.029+0200 E/CAPI_LOCATION_MANAGER( 3701): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:00:30.039+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:00:30.049+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:2
04-23 19:00:30.059+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:30.069+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:30:72,-0.026443,0.165594,0.272137
04-23 19:00:30.069+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:30:10,9.030000,2.660000,-5.460000
04-23 19:00:30.069+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:30.069+0200 I/servicemanager( 5682): es.ugr.frailty.location sleep timeout
04-23 19:00:30.069+0200 W/AUL     ( 5682): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:00:30.069+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:00:30.079+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5682
04-23 19:00:30.089+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 19:00:30.089+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 5848
04-23 19:00:30.099+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 19:00:30.099+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 19:00:30.099+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 19:00:30.099+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: connection_destroy(471) > Destroy handle: 0xf3f236d8
04-23 19:00:30.139+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5848
04-23 19:00:30.139+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(5848) type(svcapp) bg(0)
04-23 19:00:30.139+0200 W/AUL     ( 5682): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5848)
04-23 19:00:30.139+0200 I/servicemanager( 5682): es.ugr.frailty.location stop request sent!
04-23 19:00:30.139+0200 I/heartrate( 5710): capturing data from es.ugr.frailty.heartrate
04-23 19:00:30.159+0200 I/servicemanager( 5682): App control destroyed.
04-23 19:00:30.159+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5848]
04-23 19:00:30.169+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: connection_create(453) > New handle created[0xf7a20790]
04-23 19:00:30.169+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 19:00:30.169+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 19:00:30.169+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 19:00:30.169+0200 I/CAPI_NETWORK_CONNECTION( 3701): connection.c: connection_get_type(507) > Connected Network = 2
04-23 19:00:30.169+0200 W/LOCATION( 3701): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:00:30.169+0200 W/LOCATION( 3701): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:00:30.179+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:30.179+0200 I/AUL     ( 3701): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:00:30.179+0200 I/linearacceleration( 5826): capturing data from es.ugr.frailty.linearacceleration
04-23 19:00:30.199+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:00:30.199+0200 I/AUL     ( 3701): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:00:30.199+0200 E/LOCATION( 3701): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 19:00:30.199+0200 I/LOCATION( 3701): location.c: location_new(269) > method: 1
04-23 19:00:30.199+0200 W/LOCATION( 3701): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:00:30.199+0200 W/LOCATION( 3701): module-internal.c: module_new(311) > module (gps) open success
04-23 19:00:30.199+0200 W/LOCATION( 3701): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:00:30.199+0200 W/LOCATION( 3701): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:00:30.199+0200 W/LOCATION( 3701): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:00:30.199+0200 W/LOCATION( 3701): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:00:30.199+0200 W/LOCATION( 3701): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:00:30.209+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5848
04-23 19:00:30.209+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:00:30.209+0200 I/accelerometer( 5784): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:00:30:187,9.676575,-0.476172,1.540978
04-23 19:00:30.209+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:30:80,12.180000,1.960000,-6.930000
04-23 19:00:30.209+0200 I/gyroscope( 5797): capturing data from es.ugr.frailty.gyroscope
04-23 19:00:30.219+0200 I/accelerometer( 5784): capturing data from es.ugr.frailty.accelerometer
04-23 19:00:30.219+0200 I/gyroscope( 5797): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:00:30:222,4.690000,2.100000,-5.110000
04-23 19:00:30.219+0200 I/AUL     ( 3701): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:00:30.219+0200 I/linearacceleration( 5826): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:00:30:192,0.058791,0.290315,0.109421
04-23 19:00:30.219+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:00:30.229+0200 I/AUL     ( 3701): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:00:30.229+0200 E/LOCATION( 3701): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:00:30.229+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5848
04-23 19:00:30.239+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:00:30.249+0200 I/heartrate( 5710): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:00:30:141,71
04-23 19:00:30.249+0200 W/CRASH_MANAGER( 5847): worker.c: worker_job(1205) > 11058106c6f63152450282
