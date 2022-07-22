S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18215
Date: 2018-06-07 17:13:36+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf706452d, r5   = 0xf71b8f98
r6   = 0xffdf7620, r7   = 0xffdf74d0
r8   = 0xf71b5c18, r9   = 0x00000000
r10  = 0xffdf75ac, fp   = 0xffdf7620
ip   = 0x00000001, sp   = 0xffdf74a8
lr   = 0xf7064539, pc   = 0xf70cd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     90884 KB
Buffers:     15212 KB
Cached:      87044 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11512 KB
VmRSS:       11512 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18215 TID = 18215
18215 18226 

Maps Information
f3f2f000 f472e000 rw-p [stack:18226]
f4735000 f4737000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f473f000 f4743000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f474c000 f474e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4756000 f4759000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4768000 f476d000 r-xp /usr/lib/libsystem.so.0.0.0
f4778000 f477b000 r-xp /lib/libattr.so.1.1.0
f4783000 f4793000 r-xp /usr/lib/libmdm-common.so.1.1.24
f479b000 f47a4000 r-xp /usr/lib/libedbus.so.1.7.99
f47ac000 f47ad000 r-xp /usr/lib/libresponse.so.0.2.96
f47b6000 f47bb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f605d000 f6163000 r-xp /usr/lib/libicuuc.so.57.1
f6179000 f6301000 r-xp /usr/lib/libicui18n.so.57.1
f6311000 f631e000 r-xp /usr/lib/libail.so.0.1.0
f6327000 f632e000 r-xp /usr/lib/libminizip.so.1.0.0
f6337000 f64e0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6500000 f6547000 r-xp /usr/lib/libssl.so.1.0.0
f6553000 f6555000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f655d000 f6564000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f656d000 f6574000 r-xp /lib/libcrypt-2.13.so
f65a5000 f65a8000 r-xp /lib/libcap.so.2.21
f65b0000 f65b2000 r-xp /usr/lib/libiri.so
f65ba000 f6603000 r-xp /usr/lib/libmdm.so.1.2.69
f660b000 f6611000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6619000 f663c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6646000 f6648000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6650000 f666d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6676000 f667a000 r-xp /usr/lib/libsmack.so.1.0.0
f6683000 f669c000 r-xp /usr/lib/libnetwork.so.0.0.0
f66a5000 f66ad000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66b5000 f66bb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66c4000 f66c6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66cf000 f66df000 r-xp /lib/libresolv-2.13.so
f66e3000 f66fb000 r-xp /usr/lib/liblzma.so.5.0.3
f6704000 f6706000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f670e000 f6728000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6730000 f675f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6768000 f6777000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6781000 f678b000 r-xp /usr/lib/libsensord-shared.so
f6794000 f6867000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6872000 f6888000 r-xp /lib/libz.so.1.2.5
f6890000 f6895000 r-xp /usr/lib/libffi.so.5.0.10
f689d000 f689e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68a6000 f68b6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68be000 f68d7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68df000 f68e1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68e9000 f695e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6968000 f696e000 r-xp /lib/librt-2.13.so
f6977000 f6995000 r-xp /usr/lib/libsystemd.so.0.4.0
f699f000 f69a0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69a8000 f69cb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69d3000 f69d8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69e0000 f6a0a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a13000 f6a2a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a32000 f6a9b000 r-xp /lib/libm-2.13.so
f6aa4000 f6b38000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b4b000 f6b50000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b58000 f6b5f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b67000 f6b91000 r-xp /usr/lib/libsensor.so.1.9.6
f6b9a000 f6c66000 r-xp /usr/lib/libxml2.so.2.7.8
f6c73000 f6c75000 r-xp /usr/lib/libiniparser.so.0
f6c7e000 f6c84000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c8d000 f6d5d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d5e000 f6d92000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d9b000 f6dd7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ddf000 f6de2000 r-xp /usr/lib/libbundle.so.0.1.22
f6dea000 f6df0000 r-xp /usr/lib/libappsvc.so.0.1.0
f6df8000 f6e39000 r-xp /usr/lib/libeina.so.1.7.99
f6e42000 f6e59000 r-xp /usr/lib/libecore.so.1.7.99
f6e70000 f6e79000 r-xp /usr/lib/libvconf.so.0.2.45
f6e81000 f6e95000 r-xp /lib/libpthread-2.13.so
f6ea0000 f6ead000 r-xp /usr/lib/libaul.so.0.1.0
f6eb7000 f6eb9000 r-xp /lib/libdl-2.13.so
f6ec2000 f6ecd000 r-xp /lib/libunwind.so.8.0.1
f6efa000 f6f02000 r-xp /lib/libgcc_s-4.6.so.1
f6f03000 f7027000 r-xp /lib/libc-2.13.so
f7035000 f7037000 r-xp /usr/lib/libdlog.so.0.0.0
f703f000 f704b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7054000 f7059000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7061000 f7070000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7078000 f707c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7085000 f7088000 r-xp /usr/lib/libappcore-agent.so.1.1
f7090000 f7092000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f709a000 f709e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70a6000 f70c3000 r-xp /lib/ld-2.13.so
f70cc000 f70cf000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70cf000 f70d3000 r-xp /usr/lib/libsys-assert.so
f7185000 f7213000 rw-p [heap]
ffdd8000 ffdf9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18215)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70cd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7064539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d6b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d69c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d75e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d7bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d7bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6db075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6dab1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d69c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d75e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d7bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d7bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6dade5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dae017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6db5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf474d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4740171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6813663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cc0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cc27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e52ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e4db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e4e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e4e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7086183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70867fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70cd5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f1a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf70ccf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
e(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:35.991+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:35:995,0.048830,-0.005140,0.083251
06-07 17:13:36.001+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.001+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.011+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:35:999,0.315136,-0.092140,9.801152
06-07 17:13:36.011+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:9,0.031077,-0.024557,0.068923
06-07 17:13:36.011+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.011+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:7,0.140000,0.070000,0.070000
06-07 17:13:36.021+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.021+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:9,0.373280,-0.078963,9.832108
06-07 17:13:36.021+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.021+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:25,0.030036,-0.009255,0.068964
06-07 17:13:36.021+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.031+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.031+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:30,0.315039,-0.091978,9.801157
06-07 17:13:36.041+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:33,0.140000,0.070000,0.070000
06-07 17:13:36.041+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:39,0.005217,-0.035339,0.080958
06-07 17:13:36.041+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.051+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.051+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:59,0.314764,-0.089685,9.801187
06-07 17:13:36.061+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:54,0.082209,0.028175,0.030707
06-07 17:13:36.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:13:36.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:13:36.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:13:36.061+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.061+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:36,0.325424,-0.076570,9.839286
06-07 17:13:36.071+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.071+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.071+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.081+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:84,0.299103,-0.078963,9.872787
06-07 17:13:36.081+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.081+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:79,0.315094,-0.089279,9.801180
06-07 17:13:36.081+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:90,0.272782,-0.076570,9.868000
06-07 17:13:36.091+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.091+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:75,0.022210,-0.021220,0.023596
06-07 17:13:36.091+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:97,0.279960,-0.088534,9.915856
06-07 17:13:36.091+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.101+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:103,0.289532,-0.105284,9.923036
06-07 17:13:36.101+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.111+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:36.111+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:36:115,694.000000
06-07 17:13:36.111+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:108,0.325424,-0.086142,9.887143
06-07 17:13:36.121+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.121+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:126,0.325424,-0.098106,9.889536
06-07 17:13:36.121+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:132,0.315853,-0.100499,9.896714
06-07 17:13:36.131+0200 W/LOCATION(18215): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:13:36.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.131+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:36.131+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:36.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:138,0.320638,-0.071785,9.877571
06-07 17:13:36.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.141+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:145,0.344566,-0.110070,9.863215
06-07 17:13:36.141+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.141+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.151+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:150,0.337388,-0.129212,9.841680
06-07 17:13:36.151+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.151+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:157,0.339781,-0.088534,9.896714
06-07 17:13:36.151+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.151+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.161+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:87,0.070000,0.070000,0.140000
06-07 17:13:36.161+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:163,0.287139,-0.110070,9.884750
06-07 17:13:36.161+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.161+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:170,0.275175,-0.059821,9.858429
06-07 17:13:36.171+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.171+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.171+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:176,0.344566,-0.081356,9.860823
06-07 17:13:36.171+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.171+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:170,0.315082,-0.090157,9.801172
06-07 17:13:36.181+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:182,0.306281,-0.059821,9.848858
06-07 17:13:36.181+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.181+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:165,0.005043,-0.018163,0.083436
06-07 17:13:36.181+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:188,0.330210,-0.090927,9.870394
06-07 17:13:36.181+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.191+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:194,0.363709,-0.138784,9.894321
06-07 17:13:36.191+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:185,0.070000,0.140000,0.140000
06-07 17:13:36.191+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.191+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.191+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:200,0.382852,-0.059821,9.899107
06-07 17:13:36.201+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.201+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:206,0.363709,-0.119641,9.891929
06-07 17:13:36.201+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.201+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.211+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:212,0.320638,-0.083749,9.901501
06-07 17:13:36.211+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.211+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.211+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:219,0.299103,-0.098106,9.820145
06-07 17:13:36.221+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.221+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:217,0.314290,-0.090835,9.801191
06-07 17:13:36.221+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:226,0.299103,-0.090927,9.870394
06-07 17:13:36.221+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.231+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:231,0.320638,-0.114855,9.951750
06-07 17:13:36.231+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.231+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:206,0.005300,0.001629,0.102576
06-07 17:13:36.231+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:237,0.299103,-0.043071,9.911072
06-07 17:13:36.231+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.241+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:243,0.303888,-0.038285,9.832108
06-07 17:13:36.241+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.241+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.241+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.241+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:249,0.354138,-0.098106,9.851252
06-07 17:13:36.251+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.251+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:232,0.070000,0.140000,0.070000
06-07 17:13:36.251+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.251+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:253,-0.008467,0.020325,0.069055
06-07 17:13:36.261+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.261+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:256,0.314065,-0.091751,9.801190
06-07 17:13:36.261+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.271+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:275,-0.014471,0.016597,0.071398
06-07 17:13:36.271+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:263,0.351745,-0.131605,9.896714
06-07 17:13:36.271+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.271+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:264,0.070000,0.140000,0.070000
06-07 17:13:36.281+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:286,0.301496,-0.131605,9.954143
06-07 17:13:36.281+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.281+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.291+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:283,0.316244,-0.091084,9.801126
06-07 17:13:36.291+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:293,0.070000,0.070000,0.070000
06-07 17:13:36.291+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.291+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.291+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.301+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:36.311+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:36:314,695.000000
06-07 17:13:36.311+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:300,0.289532,-0.133998,9.887143
06-07 17:13:36.311+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:302,-0.023369,-0.027178,0.092905
06-07 17:13:36.311+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.311+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:306,0.070000,0.070000,0.070000
06-07 17:13:36.321+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.321+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:315,0.317631,-0.091864,9.801074
06-07 17:13:36.321+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.331+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:36.331+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:36.331+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:321,0.334995,-0.064606,9.896714
06-07 17:13:36.331+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.341+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:331,0.040675,-0.059591,0.054572
06-07 17:13:36.341+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.351+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.351+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:326,0.070000,0.070000,0.070000
06-07 17:13:36.351+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.361+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:344,0.317998,-0.092952,9.801052
06-07 17:13:36.361+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.371+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:361,0.070000,0.070000,0.070000
06-07 17:13:36.371+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:360,0.356531,-0.112463,9.889536
06-07 17:13:36.371+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.371+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.381+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:360,0.026863,-0.011592,0.095331
06-07 17:13:36.381+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.381+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:379,0.315147,-0.090574,9.801167
06-07 17:13:36.391+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:388,0.070000,0.140000,0.070000
06-07 17:13:36.391+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.391+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:383,0.325424,-0.093320,9.906286
06-07 17:13:36.391+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.401+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:390,0.023900,-0.032819,0.088174
06-07 17:13:36.401+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:404,0.311898,-0.091306,9.801264
06-07 17:13:36.401+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.411+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.421+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.431+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:423,0.140000,0.070000,0.070000
06-07 17:13:36.431+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:409,0.318245,-0.047856,9.822537
06-07 17:13:36.431+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:423,0.025225,0.004667,0.035580
06-07 17:13:36.431+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.441+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.441+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.441+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:448,0.012742,0.035350,0.081057
06-07 17:13:36.451+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:440,0.310070,-0.090574,9.801329
06-07 17:13:36.451+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:444,0.339781,-0.088534,9.884750
06-07 17:13:36.451+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.461+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.461+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:450,0.070000,0.070000,0.070000
06-07 17:13:36.461+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.471+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:467,0.325424,-0.112463,9.882358
06-07 17:13:36.471+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.481+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:483,0.140000,0.070000,0.070000
06-07 17:13:36.481+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.481+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.481+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:465,0.311407,-0.090546,9.801287
06-07 17:13:36.481+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.491+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:490,0.070000,0.070000,0.070000
06-07 17:13:36.491+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:482,0.017529,0.009537,0.083432
06-07 17:13:36.501+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.501+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.501+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:492,0.315853,-0.112463,9.911072
06-07 17:13:36.501+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:506,0.070000,0.070000,0.070000
06-07 17:13:36.501+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.501+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:36.511+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:36:514,697.000000
06-07 17:13:36.511+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:500,0.310184,-0.090016,9.801330
06-07 17:13:36.511+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.511+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:513,0.070000,0.070000,0.070000
06-07 17:13:36.511+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.521+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:525,0.210000,0.070000,0.070000
06-07 17:13:36.521+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.521+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:513,0.019688,-0.048545,0.071469
06-07 17:13:36.531+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.531+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:531,0.070000,0.070000,0.070000
06-07 17:13:36.531+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.531+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:36.531+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:36.531+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:538,0.070000,0.070000,0.070000
06-07 17:13:36.541+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.541+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:523,0.308674,-0.107677,9.841680
06-07 17:13:36.541+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:537,0.311886,-0.090409,9.801272
06-07 17:13:36.541+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.541+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.551+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.551+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:551,0.070000,0.070000,0.070000
06-07 17:13:36.561+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:548,0.014253,0.001356,0.083473
06-07 17:13:36.561+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.561+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.561+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:555,0.363709,-0.074178,9.846465
06-07 17:13:36.571+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.581+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:562,0.313122,-0.091459,9.801223
06-07 17:13:36.581+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:571,0.070000,0.070000,0.070000
06-07 17:13:36.581+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.581+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.591+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:574,0.036080,-0.042161,0.061925
06-07 17:13:36.591+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.591+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:590,0.070000,0.070000,0.070000
06-07 17:13:36.601+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.601+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:585,0.356531,-0.112463,9.896714
06-07 17:13:36.601+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.611+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:608,0.070000,0.070000,0.070000
06-07 17:13:36.611+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:605,0.020311,-0.006913,0.083521
06-07 17:13:36.611+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:36.611+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18020), cmd(0)
06-07 17:13:36.611+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:595,0.315137,-0.093715,9.801137
06-07 17:13:36.621+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.621+0200 W/CAPI_APPFW_APP_CONTROL(18020): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:36.621+0200 I/utils   (18020): specific action
06-07 17:13:36.621+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.621+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:629,0.315460,-0.092196,9.801141
06-07 17:13:36.631+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.631+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:620,0.334995,-0.119641,9.875179
06-07 17:13:36.631+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:629,0.140000,0.070000,0.070000
06-07 17:13:36.641+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.651+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.651+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:640,0.019891,0.014739,0.083535
06-07 17:13:36.651+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.651+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:648,0.140000,0.070000,0.070000
06-07 17:13:36.651+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.661+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:649,0.272782,-0.052642,9.906286
06-07 17:13:36.661+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.661+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:660,0.315799,-0.092683,9.801126
06-07 17:13:36.671+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:665,0.070000,0.070000,0.070000
06-07 17:13:36.671+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.671+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.671+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:665,0.000416,-0.014874,0.071573
06-07 17:13:36.681+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.681+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:683,0.140000,0.070000,0.070000
06-07 17:13:36.681+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:675,0.270389,-0.112463,9.863215
06-07 17:13:36.691+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.691+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.691+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:690,0.315127,-0.091765,9.801156
06-07 17:13:36.701+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:703,0.070000,0.070000,0.140000
06-07 17:13:36.701+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:692,0.015251,-0.019159,0.052420
06-07 17:13:36.711+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.711+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:36.711+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.721+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:36:717,699.000000
06-07 17:13:36.721+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:705,0.289532,-0.081356,9.951750
06-07 17:13:36.721+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.721+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:725,0.005396,0.019830,0.064401
06-07 17:13:36.731+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.731+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:721,0.316168,-0.092491,9.801116
06-07 17:13:36.731+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:36.731+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:36.731+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:733,0.070000,0.070000,0.070000
06-07 17:13:36.741+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.741+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.741+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.741+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:736,0.344566,-0.093320,9.891929
06-07 17:13:36.751+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:749,0.316366,-0.093228,9.801103
06-07 17:13:36.751+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:753,0.070000,0.070000,0.070000
06-07 17:13:36.751+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.761+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:765,0.296710,-0.083749,9.877571
06-07 17:13:36.761+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.761+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.761+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:751,0.032399,0.011329,0.073937
06-07 17:13:36.761+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.771+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:770,0.070000,0.070000,0.140000
06-07 17:13:36.771+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.771+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.781+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:775,0.315963,-0.093883,9.801109
06-07 17:13:36.791+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:776,0.012363,0.013001,0.064388
06-07 17:13:36.791+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:786,0.070000,0.070000,0.140000
06-07 17:13:36.791+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.791+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.791+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:13:36.791+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:13:36.791+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:36.801+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:788,0.358923,-0.102891,9.906286
06-07 17:13:36.801+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:36.801+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.811+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18010
06-07 17:13:36.811+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18010)
06-07 17:13:36.811+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:13:36.811+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:36.811+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:13:36.811+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:13:36.811+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:36.811+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:36.821+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:802,0.315783,-0.091704,9.801135
06-07 17:13:36.821+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:802,0.005157,0.050470,0.057202
06-07 17:13:36.831+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18020
06-07 17:13:36.831+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.831+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18020)
06-07 17:13:36.831+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:13:36.831+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:36.831+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:13:36.831+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:13:36.841+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:36.841+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:820,0.346959,-0.117248,9.863215
06-07 17:13:36.841+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:36.841+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.841+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:822,0.070000,0.070000,0.140000
06-07 17:13:36.841+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:13:36.851+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:846,-0.010782,0.033196,0.107398
06-07 17:13:36.851+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:846,0.312222,-0.092576,9.801241
06-07 17:13:36.861+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:36.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18034), cmd(0)
06-07 17:13:36.861+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:36.861+0200 I/utils   (18034): specific action
06-07 17:13:36.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:13:36.861+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:13:36.861+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:36.861+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:13:36.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:13:36.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:36.861+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:36.871+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.871+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:856,0.351745,-0.138784,9.899107
06-07 17:13:36.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18215
06-07 17:13:36.871+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.881+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:858,0.070000,0.070000,0.140000
06-07 17:13:36.881+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18215)
06-07 17:13:36.881+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:13:36.881+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:36.881+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:13:36.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:13:36.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:36.881+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:36.891+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18050
06-07 17:13:36.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18050)
06-07 17:13:36.901+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:13:36.901+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:36.901+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:13:36.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:13:36.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:36.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:36.901+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:904,0.323031,-0.059821,9.899107
06-07 17:13:36.911+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:36.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18054
06-07 17:13:36.911+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18054)
06-07 17:13:36.911+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:13:36.911+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:36.911+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:13:36.911+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:13:36.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:36.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:36.921+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:36:920,700.000000
06-07 17:13:36.931+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:881,0.014335,-0.023683,0.085810
06-07 17:13:36.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:13:36.931+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:36.931+0200 I/utils   (18075): specific action
06-07 17:13:36.931+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:889,0.311610,-0.092837,9.801258
06-07 17:13:36.931+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:36.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(18075), cmd(0)
06-07 17:13:36.931+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:36.931+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:13:36.931+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:13:36.931+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:36.931+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:13:36.931+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:13:36.931+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:36.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:36.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:36.941+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:13:36.951+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:36.951+0200 I/utils   (18079): specific action
06-07 17:13:36.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:13:36.951+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:13:36.951+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:36.951+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:13:36.951+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:13:36.951+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:908,0.140000,0.070000,0.140000
06-07 17:13:36.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:36.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:36.951+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:961,0.310917,-0.094897,9.801261
06-07 17:13:36.961+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.961+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:36.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:13:36.961+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:36.961+0200 I/utils   (18111): specific action
06-07 17:13:36.961+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:13:36.961+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:13:36.961+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:36.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:36.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(18079), cmd(0)
06-07 17:13:36.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:36.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(18111), cmd(0)
06-07 17:13:36.971+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:36:969,0.323031,-0.100499,9.882358
06-07 17:13:36.971+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:946,-0.012174,0.037042,0.066680
06-07 17:13:36.981+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:36.981+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:36.981+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:36:971,0.070000,0.070000,0.070000
06-07 17:13:36.991+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:36.991+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:37.001+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:36:990,-0.025349,-0.015228,0.095339
06-07 17:13:37.011+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:36:995,0.311710,-0.096047,9.801224
06-07 17:13:37.031+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:37:2,0.301496,-0.071785,9.903893
06-07 17:13:37.031+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:37.041+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:37:48,0.007576,-0.031440,0.085715
06-07 17:13:37.051+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:37.051+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:37:5,0.070000,0.070000,0.070000
06-07 17:13:37.051+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:37.061+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:37.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:13:37.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:13:37.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:13:37.071+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:37:66,0.312230,-0.095435,9.801213
06-07 17:13:37.071+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:37:72,0.070000,0.070000,0.070000
06-07 17:13:37.081+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:37:70,0.337388,-0.105284,9.887143
06-07 17:13:37.081+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:37.081+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:37.091+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:37.091+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:37.091+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:37:101,0.330210,-0.112463,9.858429
06-07 17:13:37.101+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:37:105,0.140000,0.070000,0.070000
06-07 17:13:37.101+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:37:97,0.311713,-0.094523,9.801239
06-07 17:13:37.111+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:37.111+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:37:116,703.000000
06-07 17:13:37.111+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:37:91,0.010063,-0.022994,0.092902
06-07 17:13:37.111+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:37.111+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:37.121+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:37:125,0.024594,0.008958,0.104869
06-07 17:13:37.121+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:37.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:37:135,0.323031,-0.112463,9.913465
06-07 17:13:37.131+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11182156c6f63152838441
