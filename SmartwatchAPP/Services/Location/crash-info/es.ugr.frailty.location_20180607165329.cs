S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12046
Date: 2018-06-07 16:53:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf720252d, r5   = 0xf78b5f98
r6   = 0xffac6790, r7   = 0xffac6640
r8   = 0xf78b2c18, r9   = 0x00000000
r10  = 0xffac671c, fp   = 0xffac6790
ip   = 0x00000001, sp   = 0xffac6618
lr   = 0xf7202539, pc   = 0xf726b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     40704 KB
Buffers:     15888 KB
Cached:     130076 KB
VmPeak:      52604 KB
VmSize:      52600 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11784 KB
VmRSS:       11784 KB
VmData:      10328 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12046 TID = 12046
12046 12052 

Maps Information
f40cd000 f48cc000 rw-p [stack:12052]
f48d3000 f48d5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48dd000 f48e1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48ea000 f48ec000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48f4000 f48f7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4906000 f490b000 r-xp /usr/lib/libsystem.so.0.0.0
f4916000 f4919000 r-xp /lib/libattr.so.1.1.0
f4921000 f4931000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4939000 f4942000 r-xp /usr/lib/libedbus.so.1.7.99
f494a000 f494b000 r-xp /usr/lib/libresponse.so.0.2.96
f4954000 f4959000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61fb000 f6301000 r-xp /usr/lib/libicuuc.so.57.1
f6317000 f649f000 r-xp /usr/lib/libicui18n.so.57.1
f64af000 f64bc000 r-xp /usr/lib/libail.so.0.1.0
f64c5000 f64cc000 r-xp /usr/lib/libminizip.so.1.0.0
f64d5000 f667e000 r-xp /usr/lib/libcrypto.so.1.0.0
f669e000 f66e5000 r-xp /usr/lib/libssl.so.1.0.0
f66f1000 f66f3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66fb000 f6702000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f670b000 f6712000 r-xp /lib/libcrypt-2.13.so
f6743000 f6746000 r-xp /lib/libcap.so.2.21
f674e000 f6750000 r-xp /usr/lib/libiri.so
f6758000 f67a1000 r-xp /usr/lib/libmdm.so.1.2.69
f67a9000 f67af000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67b7000 f67da000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67e4000 f67e6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67ee000 f680b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6814000 f6818000 r-xp /usr/lib/libsmack.so.1.0.0
f6821000 f683a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6843000 f684b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6853000 f6859000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6862000 f6864000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f686d000 f687d000 r-xp /lib/libresolv-2.13.so
f6881000 f6899000 r-xp /usr/lib/liblzma.so.5.0.3
f68a2000 f68a4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68ac000 f68c6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68ce000 f68fd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6906000 f6915000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f691f000 f6929000 r-xp /usr/lib/libsensord-shared.so
f6932000 f6a05000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a10000 f6a26000 r-xp /lib/libz.so.1.2.5
f6a2e000 f6a33000 r-xp /usr/lib/libffi.so.5.0.10
f6a3b000 f6a3c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a44000 f6a54000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a5c000 f6a75000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a7d000 f6a7f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a87000 f6afc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b06000 f6b0c000 r-xp /lib/librt-2.13.so
f6b15000 f6b33000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b3d000 f6b3e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b46000 f6b69000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b71000 f6b76000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b7e000 f6ba8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bb1000 f6bc8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bd0000 f6c39000 r-xp /lib/libm-2.13.so
f6c42000 f6cd6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ce9000 f6cee000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cf6000 f6cfd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d05000 f6d2f000 r-xp /usr/lib/libsensor.so.1.9.6
f6d38000 f6e04000 r-xp /usr/lib/libxml2.so.2.7.8
f6e11000 f6e13000 r-xp /usr/lib/libiniparser.so.0
f6e1c000 f6e22000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e2b000 f6efb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6efc000 f6f30000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f39000 f6f75000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f7d000 f6f80000 r-xp /usr/lib/libbundle.so.0.1.22
f6f88000 f6f8e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f96000 f6fd7000 r-xp /usr/lib/libeina.so.1.7.99
f6fe0000 f6ff7000 r-xp /usr/lib/libecore.so.1.7.99
f700e000 f7017000 r-xp /usr/lib/libvconf.so.0.2.45
f701f000 f7033000 r-xp /lib/libpthread-2.13.so
f703e000 f704b000 r-xp /usr/lib/libaul.so.0.1.0
f7055000 f7057000 r-xp /lib/libdl-2.13.so
f7060000 f706b000 r-xp /lib/libunwind.so.8.0.1
f7098000 f70a0000 r-xp /lib/libgcc_s-4.6.so.1
f70a1000 f71c5000 r-xp /lib/libc-2.13.so
f71d3000 f71d5000 r-xp /usr/lib/libdlog.so.0.0.0
f71dd000 f71e9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71f2000 f71f7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71ff000 f720e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7216000 f721a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7223000 f7226000 r-xp /usr/lib/libappcore-agent.so.1.1
f722e000 f7230000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7238000 f723c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7244000 f7261000 r-xp /lib/ld-2.13.so
f726a000 f726d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f726d000 f7271000 r-xp /usr/lib/libsys-assert.so
f7882000 f7923000 rw-p [heap]
ffaa7000 ffac8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12046)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf726b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7202539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f093f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f07c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f13e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f19be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f19dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f4e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f491f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f07c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f13e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f19be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f19dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f4be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f4c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f53f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48eb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48de171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69b1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e5efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e607a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ff0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6febb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fec5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fec879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7224183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72247fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf726b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70b885c) [/lib/libc.so.6] + 0x1785c
29: (0xf726af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
lty.gyroscope: SM-R760,07/06/2018,16:53:28:727,-0.070000,-0.070000,0.070000
06-07 16:53:28.751+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:28:755,-0.006654,0.040376,0.026776
06-07 16:53:28.751+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:28:729,2.597693,-0.206527,9.454085
06-07 16:53:28.751+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:28.751+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:28.751+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:28:735,2.663212,-0.208176,9.492328
06-07 16:53:28.761+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:28:765,2.595490,-0.208241,9.454653
06-07 16:53:28.771+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:28.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:28.791+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:28:786,0.020880,0.054614,0.062648
06-07 16:53:28.801+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:28:776,2.687140,-0.157926,9.499505
06-07 16:53:28.801+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:28.801+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:28:771,-0.560000,-0.070000,0.140000
06-07 16:53:28.821+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:28.821+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:28:826,89
06-07 16:53:28.821+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:28.821+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:28.831+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:28.841+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:28:843,1074.000000
06-07 16:53:28.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:28.851+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:28:853,2.682354,-0.143569,9.492328
06-07 16:53:28.861+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:28:814,2.590047,-0.208540,9.456139
06-07 16:53:28.861+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:28.871+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:28:836,0.140000,-0.070000,0.280000
06-07 16:53:28.871+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:28.871+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:28.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:28:857,0.003534,-0.014391,0.003981
06-07 16:53:28.881+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:28.891+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:28:872,2.590652,-0.207096,9.456004
06-07 16:53:28.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:28:905,-0.025205,-0.180556,0.037910
06-07 16:53:28.901+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:28:889,2.696711,-0.177069,9.513863
06-07 16:53:28.911+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:28.921+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:28:896,0.770000,-0.420000,0.070000
06-07 16:53:28.921+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:28.931+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:28.931+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:28.941+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:28:920,2.591800,-0.204528,9.455746
06-07 16:53:28.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:28:944,-0.006645,-0.092726,0.128303
06-07 16:53:28.951+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:28.951+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:28:936,2.665605,-0.167498,9.473185
06-07 16:53:28.961+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:28:940,-0.490000,0.140000,-0.140000
06-07 16:53:28.961+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:28.971+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:28:979,2.737389,-0.184247,9.482756
06-07 16:53:28.981+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:28.981+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:28.981+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:28:987,-0.098562,-0.057242,0.166835
06-07 16:53:28.991+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:28:969,2.587754,-0.204353,9.456858
06-07 16:53:29.001+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:28:991,0.840000,-0.140000,-0.140000
06-07 16:53:29.001+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.001+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.031+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:29.031+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:29.051+0200 W/LOCATION(12046): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:53:29.061+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:29:46,89
06-07 16:53:29.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:53:29.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:53:29.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:53:29.071+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:29:46,1075.000000
06-07 16:53:29.081+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.091+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:17,2.576755,-0.202017,9.459910
06-07 16:53:29.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:100,-0.082293,0.009746,0.059548
06-07 16:53:29.101+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.111+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:93,2.708675,-0.150748,9.470792
06-07 16:53:29.131+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.141+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.151+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.151+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:125,0.700000,0.070000,-0.070000
06-07 16:53:29.171+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:152,2.580044,-0.200381,9.459049
06-07 16:53:29.191+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:174,0.016776,-0.014258,0.050303
06-07 16:53:29.201+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.201+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:170,2.675175,-0.148355,9.487542
06-07 16:53:29.211+0200 E/CAPI_NETWORK_WIFI(10916): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
06-07 16:53:29.211+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:29.221+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:29:222,89
06-07 16:53:29.221+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.231+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:213,1.260000,-0.700000,-0.070000
06-07 16:53:29.231+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:29.241+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:29:243,1062.000000
06-07 16:53:29.251+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.251+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.251+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:259,2.679961,-0.160319,9.516255
06-07 16:53:29.311+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:255,2.580553,-0.201565,9.458885
06-07 16:53:29.321+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.321+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:269,0.020222,0.013730,0.081432
06-07 16:53:29.321+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:331,0.490000,0.280000,0.210000
06-07 16:53:29.331+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.331+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:29.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:29.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:29.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:29.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390409350,000000, pattern:[H:mm][0;m
06-07 16:53:29.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:29.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:29.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:29.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:29.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:53:29.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:53][0;m
06-07 16:53:29.351+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.361+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.361+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:359,2.660819,-0.157926,9.554541
06-07 16:53:29.371+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:358,2.572442,-0.200037,9.461126
06-07 16:53:29.381+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.381+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.381+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:370,-0.026087,0.030781,0.040611
06-07 16:53:29.381+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.391+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:382,0.490000,-0.070000,0.070000
06-07 16:53:29.391+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:399,2.703890,-0.143569,9.523434
06-07 16:53:29.401+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:405,-0.008929,-0.028547,0.106091
06-07 16:53:29.411+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:397,2.565423,-0.197626,9.463082
06-07 16:53:29.411+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:29.421+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:29:423,89
06-07 16:53:29.421+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.421+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:430,-0.420000,-0.070000,0.070000
06-07 16:53:29.431+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.431+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:29.431+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:29:441,1013.000000
06-07 16:53:29.431+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.441+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.451+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:456,2.565681,-0.196768,9.463031
06-07 16:53:29.461+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.461+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:464,-0.003596,-0.020400,0.066994
06-07 16:53:29.471+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:475,0.350000,0.420000,-0.140000
06-07 16:53:29.471+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:450,2.701497,-0.153141,9.442079
06-07 16:53:29.471+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.481+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.481+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:488,2.675175,-0.177069,9.444471
06-07 16:53:29.491+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.491+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:497,2.573558,-0.198905,9.460847
06-07 16:53:29.501+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.511+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:517,0.210000,0.630000,-0.350000
06-07 16:53:29.511+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11823) cmd(0)
06-07 16:53:29.511+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.521+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.521+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:499,-0.002393,0.038033,0.089561
06-07 16:53:29.531+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.541+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.541+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:541,2.584036,-0.200577,9.457954
06-07 16:53:29.551+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:557,-0.140000,-0.280000,-0.560000
06-07 16:53:29.561+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:528,2.663212,-0.157926,9.492328
06-07 16:53:29.561+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.571+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:542,0.011228,0.031865,0.053488
06-07 16:53:29.571+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.571+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11827) cmd(0)
06-07 16:53:29.571+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.581+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:585,2.592020,-0.204499,9.455686
06-07 16:53:29.591+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.601+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:604,0.560000,0.560000,-0.280000
06-07 16:53:29.601+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:579,2.665605,-0.167498,9.501899
06-07 16:53:29.611+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.611+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:587,0.028056,-0.014842,0.085924
06-07 16:53:29.611+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.611+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:29.621+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11854) cmd(0)
06-07 16:53:29.621+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:29:623,89
06-07 16:53:29.621+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:631,2.708675,-0.205783,9.535398
06-07 16:53:29.641+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:29.641+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:29:646,1010.000000
06-07 16:53:29.641+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.651+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.661+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:637,2.577210,-0.201426,9.459799
06-07 16:53:29.661+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.681+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:661,0.102829,-0.018605,0.120676
06-07 16:53:29.681+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:681,2.703890,-0.212961,9.458827
06-07 16:53:29.681+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:663,0.420000,0.140000,-0.280000
06-07 16:53:29.681+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.691+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.691+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.691+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:701,0.022009,-0.024761,0.023775
06-07 16:53:29.701+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:692,2.575397,-0.198553,9.460354
06-07 16:53:29.711+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.711+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.721+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:729,2.584194,-0.201514,9.457891
06-07 16:53:29.731+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.731+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:712,0.070000,-0.210000,-0.280000
06-07 16:53:29.731+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.741+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:725,2.677568,-0.222532,9.475577
06-07 16:53:29.761+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.761+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:744,0.039484,0.037504,0.041387
06-07 16:53:29.761+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.771+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:750,0.070000,-0.070000,0.070000
06-07 16:53:29.781+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.781+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.781+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:788,0.036408,0.011913,0.078846
06-07 16:53:29.791+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:776,2.585494,-0.202460,9.457517
06-07 16:53:29.791+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:770,2.646462,-0.138784,9.537791
06-07 16:53:29.801+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.801+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.811+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:29.821+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:29:823,89
06-07 16:53:29.831+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:815,2.660819,-0.105284,9.530612
06-07 16:53:29.831+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:793,0.070000,-0.070000,0.070000
06-07 16:53:29.831+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:29.831+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:29:841,1020.000000
06-07 16:53:29.841+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.851+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.851+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:818,2.585288,-0.203567,9.457549
06-07 16:53:29.851+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:847,0.074600,-0.061883,0.045737
06-07 16:53:29.861+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.861+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:850,-0.210000,0.070000,0.070000
06-07 16:53:29.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.881+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.881+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:873,2.590539,-0.204373,9.456095
06-07 16:53:29.891+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:865,2.691926,-0.165105,9.501899
06-07 16:53:29.911+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.921+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:29.931+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:885,0.067351,-0.060541,0.054038
06-07 16:53:29.931+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:897,0.420000,-0.280000,0.070000
06-07 16:53:29.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:29.951+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:29:947,0.029627,-0.051898,0.064563
06-07 16:53:29.951+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:29:943,2.582451,-0.205958,9.458272
06-07 16:53:29.951+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:29.961+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:925,2.665605,-0.169890,9.504292
06-07 16:53:29.971+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:29:980,0.420000,0.070000,-0.070000
06-07 16:53:29.971+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:29.991+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.011+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.011+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:11,2.631674,-0.235113,9.444014
06-07 16:53:30.011+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:30.021+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:30:23,89
06-07 16:53:30.021+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.041+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:30.051+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:30:48,1025.000000
06-07 16:53:30.061+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:29:992,2.689533,-0.150748,9.458827
06-07 16:53:30.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:53:30.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:53:30.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:53:30.081+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.081+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.091+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:59,0.420000,-0.210000,0.280000
06-07 16:53:30.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:35,0.036614,-0.033434,0.054424
06-07 16:53:30.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.091+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.101+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:90,2.713461,-0.189033,9.446864
06-07 16:53:30.121+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:101,2.678827,-0.206089,9.431426
06-07 16:53:30.121+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:125,0.770000,-0.140000,0.210000
06-07 16:53:30.131+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.131+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:105,0.068379,0.021900,0.060117
06-07 16:53:30.141+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.141+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.141+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.151+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:141,2.720639,-0.179462,9.511470
06-07 16:53:30.151+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:149,0.082130,0.049170,0.026752
06-07 16:53:30.161+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:164,0.630000,-0.490000,0.350000
06-07 16:53:30.161+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.161+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:148,2.724160,-0.215724,9.418217
06-07 16:53:30.171+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.171+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.181+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.191+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:177,2.675175,-0.169890,9.492328
06-07 16:53:30.201+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.201+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:195,2.767724,-0.231825,9.405124
06-07 16:53:30.211+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:194,0.073805,-0.022791,0.029404
06-07 16:53:30.211+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:30.221+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:30:223,89
06-07 16:53:30.221+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.231+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.231+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:30.241+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:30:242,1026.000000
06-07 16:53:30.241+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:202,0.350000,-0.210000,-0.280000
06-07 16:53:30.241+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.261+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:219,2.672783,-0.169890,9.473185
06-07 16:53:30.261+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.261+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:264,0.070000,-0.070000,-0.140000
06-07 16:53:30.271+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:256,2.732833,-0.231701,9.415324
06-07 16:53:30.271+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:250,0.082637,0.003356,0.052219
06-07 16:53:30.271+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:279,2.667997,-0.133998,9.537791
06-07 16:53:30.281+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.281+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.291+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.291+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:299,2.715047,-0.219228,9.420767
06-07 16:53:30.311+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.321+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:298,0.100814,0.036912,0.049167
06-07 16:53:30.321+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:305,0.070000,0.280000,-0.350000
06-07 16:53:30.321+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.321+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.321+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:323,2.691926,-0.162712,9.509077
06-07 16:53:30.321+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.341+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:335,2.736469,-0.230565,9.414295
06-07 16:53:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:30.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390410350,000000, pattern:[H:mm][0;m
06-07 16:53:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:30.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:53:30.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:53][0;m
06-07 16:53:30.361+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.361+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:336,0.099917,-0.034116,0.018921
06-07 16:53:30.371+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:341,-0.140000,0.350000,-0.210000
06-07 16:53:30.371+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.371+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.381+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.381+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:387,2.700172,-0.219751,9.425029
06-07 16:53:30.391+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:376,2.620141,-0.165105,9.480364
06-07 16:53:30.391+0200 I/servicemanager(11799): es.ugr.frailty.accelerometer alive timeout
06-07 16:53:30.391+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:53:30.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:30.391+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:30.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11823
06-07 16:53:30.401+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11823)
06-07 16:53:30.401+0200 I/servicemanager(11799): es.ugr.frailty.accelerometer launch request sent!
06-07 16:53:30.401+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:30.401+0200 I/servicemanager(11799): es.ugr.frailty.gyroscope alive timeout
06-07 16:53:30.401+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:53:30.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:30.411+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:30.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11827
06-07 16:53:30.421+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:30.421+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11827)
06-07 16:53:30.421+0200 I/servicemanager(11799): es.ugr.frailty.gyroscope launch request sent!
06-07 16:53:30.421+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:30.421+0200 I/servicemanager(11799): es.ugr.frailty.heartrate alive timeout
06-07 16:53:30.421+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:53:30.421+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:30.421+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:30.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11839
06-07 16:53:30.441+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:30.451+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11839)
06-07 16:53:30.451+0200 I/servicemanager(11799): es.ugr.frailty.heartrate launch request sent!
06-07 16:53:30.451+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:30.451+0200 I/servicemanager(11799): es.ugr.frailty.location alive timeout
06-07 16:53:30.451+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:53:30.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:30.451+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:30.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12046
06-07 16:53:30.461+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12046)
06-07 16:53:30.461+0200 I/servicemanager(11799): es.ugr.frailty.location launch request sent!
06-07 16:53:30.461+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:30.461+0200 I/servicemanager(11799): es.ugr.frailty.linearacceleration alive timeout
06-07 16:53:30.461+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:53:30.471+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:30.471+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:30.481+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11854
06-07 16:53:30.481+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11854)
06-07 16:53:30.481+0200 I/servicemanager(11799): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:53:30.481+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:30.481+0200 I/servicemanager(11799): es.ugr.frailty.gravity alive timeout
06-07 16:53:30.481+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:53:30.481+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:30:450,1023.000000
06-07 16:53:30.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:30.481+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:30.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11864
06-07 16:53:30.501+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11864)
06-07 16:53:30.501+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:30:429,89
06-07 16:53:30.501+0200 I/servicemanager(11799): es.ugr.frailty.gravity launch request sent!
06-07 16:53:30.501+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:30.501+0200 I/servicemanager(11799): es.ugr.frailty.pressure alive timeout
06-07 16:53:30.501+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:53:30.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:30.501+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:30.511+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11875
06-07 16:53:30.511+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:30.511+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(11875), cmd(0)
06-07 16:53:30.511+0200 W/CAPI_APPFW_APP_CONTROL(11875): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:30.511+0200 I/utils   (11875): specific action
06-07 16:53:30.521+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11875)
06-07 16:53:30.521+0200 I/servicemanager(11799): es.ugr.frailty.pressure launch request sent!
06-07 16:53:30.521+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:30.521+0200 I/servicemanager(11799): es.ugr.frailty.light alive timeout
06-07 16:53:30.521+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:53:30.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:30.521+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:30.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11887
06-07 16:53:30.531+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11887)
06-07 16:53:30.531+0200 I/servicemanager(11799): es.ugr.frailty.light launch request sent!
06-07 16:53:30.531+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:30.531+0200 I/servicemanager(11799): es.ugr.frailty.pedometer alive timeout
06-07 16:53:30.531+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:53:30.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:30.541+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:30.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11894
06-07 16:53:30.551+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:30.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(11839), cmd(0)
06-07 16:53:30.551+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:30.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(11887), cmd(0)
06-07 16:53:30.551+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:30.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(11894), cmd(0)
06-07 16:53:30.551+0200 W/CAPI_APPFW_APP_CONTROL(11894): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:30.551+0200 I/utils   (11894): specific action
06-07 16:53:30.551+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11894)
06-07 16:53:30.551+0200 I/servicemanager(11799): es.ugr.frailty.pedometer launch request sent!
06-07 16:53:30.531+0200 W/CAPI_APPFW_APP_CONTROL(11887): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:30.551+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:30.551+0200 I/utils   (11887): specific action
06-07 16:53:30.561+0200 W/CAPI_APPFW_APP_CONTROL(11839): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:30.561+0200 I/utils   (11839): specific action
06-07 16:53:30.561+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.561+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:567,2.714900,-0.222256,9.420738
06-07 16:53:30.561+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.571+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:572,2.658186,-0.220474,9.436939
06-07 16:53:30.571+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.581+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:582,2.596202,-0.208547,9.454450
06-07 16:53:30.581+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.581+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:588,2.654692,-0.208334,9.438198
06-07 16:53:30.581+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.591+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:594,2.585746,-0.185632,9.457793
06-07 16:53:30.591+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.601+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:602,2.538109,-0.182133,9.470756
06-07 16:53:30.601+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.601+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:609,2.462411,-0.157468,9.491160
06-07 16:53:30.601+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.621+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:30.621+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:30:626,88
06-07 16:53:30.621+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:395,0.210000,0.350000,-0.350000
06-07 16:53:30.631+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.631+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:30.641+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:30:645,1022.000000
06-07 16:53:30.641+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:394,0.116158,-0.009003,0.071727
06-07 16:53:30.641+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:618,2.466113,-0.157999,9.490191
06-07 16:53:30.661+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.661+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.661+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:667,0.052485,0.020575,0.031201
06-07 16:53:30.661+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:637,2.713461,-0.165105,9.516255
06-07 16:53:30.661+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.711+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:674,0.770000,0.350000,0.070000
06-07 16:53:30.711+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.721+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:729,2.634498,-0.174676,9.487542
06-07 16:53:30.731+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.731+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.731+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:725,2.468247,-0.159078,9.489617
06-07 16:53:30.731+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.741+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:748,-0.140000,-0.140000,-0.070000
06-07 16:53:30.741+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:738,0.112145,0.003807,0.002924
06-07 16:53:30.751+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.761+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:765,2.734996,-0.198604,9.444471
06-07 16:53:30.771+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:763,2.484815,-0.161041,9.485259
06-07 16:53:30.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.771+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:30.771+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:30.781+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:30:787,0.280000,-0.210000,-0.070000
06-07 16:53:30.781+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:30.791+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:30:796,2.725425,-0.301496,9.425328
06-07 16:53:30.791+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:30:795,2.487058,-0.163489,9.484630
06-07 16:53:30.791+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:30:780,0.080781,-0.030550,0.043653
06-07 16:53:30.801+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:30.811+0200 W/CRASH_MANAGER(11751): worker.c: worker_job(1205) > 11120466c6f63152838320
