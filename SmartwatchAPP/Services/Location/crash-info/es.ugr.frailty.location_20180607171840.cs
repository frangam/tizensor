S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19836
Date: 2018-06-07 17:18:40+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf741252d, r5   = 0xf7991f98
r6   = 0xffddd7a0, r7   = 0xffddd650
r8   = 0xf798ec18, r9   = 0x00000000
r10  = 0xffddd72c, fp   = 0xffddd7a0
ip   = 0x00000001, sp   = 0xffddd628
lr   = 0xf7412539, pc   = 0xf747b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      4508 KB
Buffers:     12204 KB
Cached:     111848 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11772 KB
VmRSS:       11772 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          4 KB

Threads Information
Threads: 2
PID = 19836 TID = 19836
19836 19841 

Maps Information
f42dd000 f4adc000 rw-p [stack:19841]
f4ae3000 f4ae5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4aed000 f4af1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4afa000 f4afc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b04000 f4b07000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b16000 f4b1b000 r-xp /usr/lib/libsystem.so.0.0.0
f4b26000 f4b29000 r-xp /lib/libattr.so.1.1.0
f4b31000 f4b41000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b49000 f4b52000 r-xp /usr/lib/libedbus.so.1.7.99
f4b5a000 f4b5b000 r-xp /usr/lib/libresponse.so.0.2.96
f4b64000 f4b69000 r-xp /usr/lib/libproc-stat.so.0.2.96
f640b000 f6511000 r-xp /usr/lib/libicuuc.so.57.1
f6527000 f66af000 r-xp /usr/lib/libicui18n.so.57.1
f66bf000 f66cc000 r-xp /usr/lib/libail.so.0.1.0
f66d5000 f66dc000 r-xp /usr/lib/libminizip.so.1.0.0
f66e5000 f688e000 r-xp /usr/lib/libcrypto.so.1.0.0
f68ae000 f68f5000 r-xp /usr/lib/libssl.so.1.0.0
f6901000 f6903000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f690b000 f6912000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f691b000 f6922000 r-xp /lib/libcrypt-2.13.so
f6953000 f6956000 r-xp /lib/libcap.so.2.21
f695e000 f6960000 r-xp /usr/lib/libiri.so
f6968000 f69b1000 r-xp /usr/lib/libmdm.so.1.2.69
f69b9000 f69bf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69c7000 f69ea000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69f4000 f69f6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69fe000 f6a1b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a24000 f6a28000 r-xp /usr/lib/libsmack.so.1.0.0
f6a31000 f6a4a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a53000 f6a5b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a63000 f6a69000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a72000 f6a74000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a7d000 f6a8d000 r-xp /lib/libresolv-2.13.so
f6a91000 f6aa9000 r-xp /usr/lib/liblzma.so.5.0.3
f6ab2000 f6ab4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6abc000 f6ad6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ade000 f6b0d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b16000 f6b25000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b2f000 f6b39000 r-xp /usr/lib/libsensord-shared.so
f6b42000 f6c15000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c20000 f6c36000 r-xp /lib/libz.so.1.2.5
f6c3e000 f6c43000 r-xp /usr/lib/libffi.so.5.0.10
f6c4b000 f6c4c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c54000 f6c64000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c6c000 f6c85000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c8d000 f6c8f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c97000 f6d0c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d16000 f6d1c000 r-xp /lib/librt-2.13.so
f6d25000 f6d43000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d4d000 f6d4e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d56000 f6d79000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d81000 f6d86000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d8e000 f6db8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dc1000 f6dd8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6de0000 f6e49000 r-xp /lib/libm-2.13.so
f6e52000 f6ee6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ef9000 f6efe000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f06000 f6f0d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f15000 f6f3f000 r-xp /usr/lib/libsensor.so.1.9.6
f6f48000 f7014000 r-xp /usr/lib/libxml2.so.2.7.8
f7021000 f7023000 r-xp /usr/lib/libiniparser.so.0
f702c000 f7032000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f703b000 f710b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f710c000 f7140000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7149000 f7185000 r-xp /usr/lib/libSLP-location.so.0.9.24
f718d000 f7190000 r-xp /usr/lib/libbundle.so.0.1.22
f7198000 f719e000 r-xp /usr/lib/libappsvc.so.0.1.0
f71a6000 f71e7000 r-xp /usr/lib/libeina.so.1.7.99
f71f0000 f7207000 r-xp /usr/lib/libecore.so.1.7.99
f721e000 f7227000 r-xp /usr/lib/libvconf.so.0.2.45
f722f000 f7243000 r-xp /lib/libpthread-2.13.so
f724e000 f725b000 r-xp /usr/lib/libaul.so.0.1.0
f7265000 f7267000 r-xp /lib/libdl-2.13.so
f7270000 f727b000 r-xp /lib/libunwind.so.8.0.1
f72a8000 f72b0000 r-xp /lib/libgcc_s-4.6.so.1
f72b1000 f73d5000 r-xp /lib/libc-2.13.so
f73e3000 f73e5000 r-xp /usr/lib/libdlog.so.0.0.0
f73ed000 f73f9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7402000 f7407000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f740f000 f741e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7426000 f742a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7433000 f7436000 r-xp /usr/lib/libappcore-agent.so.1.1
f743e000 f7440000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7448000 f744c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7454000 f7471000 r-xp /lib/ld-2.13.so
f747a000 f747d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f747d000 f7481000 r-xp /usr/lib/libsys-assert.so
f795e000 f79ec000 rw-p [heap]
ffdbe000 ffddf000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19836)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf747b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7412539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71193f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7117c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7123e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7129be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7129dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf715e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71591f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7117c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7123e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7129be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7129dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf715be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf715c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7163f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4afb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4aee171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bc1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf706efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70707a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7200ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71fbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71fc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71fc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7434183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74347fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf747b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf72c885c) [/lib/libc.so.6] + 0x1785c
29: (0xf747af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
meter(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:39.861+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:39.871+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:39.871+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:39:872,0.309847,-0.096572,9.801278
06-07 17:18:39.881+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:39:885,0.311067,-0.100499,9.860823
06-07 17:18:39.891+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:39:891,0.070000,0.070000,0.070000
06-07 17:18:39.891+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:39.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:39:889,-0.048136,0.022486,0.095561
06-07 17:18:39.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:39.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:39.951+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:39:952,0.265603,-0.083749,9.894321
06-07 17:18:39.961+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:39:965,0.002348,-0.023361,0.038121
06-07 17:18:39.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:39.961+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:39:903,0.308511,-0.097145,9.801314
06-07 17:18:40.021+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.021+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:39:971,0.140000,0.070000,0.070000
06-07 17:18:40.031+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.041+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:40.041+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:40:47,911.000000
06-07 17:18:40.041+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:40.041+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:40.051+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.051+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.051+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:59,0.015055,0.011069,0.049973
06-07 17:18:40.071+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:42,0.308674,-0.057428,9.877571
06-07 17:18:40.071+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:40,0.309139,-0.098783,9.801278
06-07 17:18:40.071+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:68,0.070000,0.070000,0.070000
06-07 17:18:40.081+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.101+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.101+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:107,-0.010883,-0.004853,0.066717
06-07 17:18:40.101+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:18:40.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:18:40.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:18:40.131+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:89,0.334995,-0.133998,9.863215
06-07 17:18:40.131+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:89,0.308139,-0.100269,9.801295
06-07 17:18:40.131+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.141+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.141+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.151+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:156,0.378066,-0.102891,9.834501
06-07 17:18:40.151+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:114,0.070000,-0.070000,0.070000
06-07 17:18:40.161+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.171+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:179,0.070000,-0.070000,0.070000
06-07 17:18:40.171+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:152,0.307789,-0.100410,9.801305
06-07 17:18:40.181+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.181+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.181+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:165,0.008300,-0.027296,0.069100
06-07 17:18:40.181+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.201+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:40.201+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:40.201+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:40.211+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:40:213,910.000000
06-07 17:18:40.211+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:199,0.330210,-0.098106,9.887143
06-07 17:18:40.221+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:210,0.031252,-0.017825,0.057091
06-07 17:18:40.221+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.231+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:206,0.307732,-0.099856,9.801311
06-07 17:18:40.231+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.231+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:234,-0.070000,-0.070000,0.070000
06-07 17:18:40.251+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:257,0.307312,-0.097245,9.801352
06-07 17:18:40.251+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.261+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.261+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:249,0.320638,-0.145962,9.834501
06-07 17:18:40.271+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:263,0.026674,-0.016897,0.076235
06-07 17:18:40.271+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.281+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.291+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:296,0.305561,-0.097367,9.801405
06-07 17:18:40.291+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:279,0.070000,-0.070000,0.070000
06-07 17:18:40.301+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.311+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:295,0.301496,-0.093320,9.872787
06-07 17:18:40.321+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.321+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.321+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.351+0200 W/LOCATION(19836): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:18:40.361+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:309,-0.017189,-0.016456,0.052337
06-07 17:18:40.391+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.391+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:378,0.311067,-0.069392,9.844072
06-07 17:18:40.391+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:40.391+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:40.401+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:326,0.070000,-0.070000,0.070000
06-07 17:18:40.401+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.401+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:380,0.304643,-0.096125,9.801446
06-07 17:18:40.401+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:397,0.017970,-0.039819,0.038008
06-07 17:18:40.401+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:40.411+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:40:416,898.000000
06-07 17:18:40.411+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.421+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.421+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:424,0.070000,-0.070000,0.070000
06-07 17:18:40.431+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:432,0.272782,-0.076570,9.860823
06-07 17:18:40.441+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.451+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:432,0.303535,-0.094835,9.801493
06-07 17:18:40.451+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.461+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.461+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.491+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:480,0.303999,-0.094836,9.801478
06-07 17:18:40.501+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:468,0.070000,-0.070000,0.070000
06-07 17:18:40.501+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:452,-0.011801,-0.036853,0.042758
06-07 17:18:40.501+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.511+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:479,0.282353,-0.090927,9.860823
06-07 17:18:40.511+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.521+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.531+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.531+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:524,0.070000,-0.070000,0.070000
06-07 17:18:40.541+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:545,0.304196,-0.094980,9.801471
06-07 17:18:40.541+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:521,0.001928,-0.008894,0.071508
06-07 17:18:40.541+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.551+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.561+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:540,0.306281,-0.105284,9.836893
06-07 17:18:40.561+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.561+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.571+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19600) cmd(0)
06-07 17:18:40.581+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:588,0.303588,-0.094929,9.801490
06-07 17:18:40.591+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19605) cmd(0)
06-07 17:18:40.591+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:40.591+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:40.591+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:560,0.010106,0.006949,0.093026
06-07 17:18:40.601+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:566,0.210000,0.070000,0.070000
06-07 17:18:40.601+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:40.611+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:40:614,893.000000
06-07 17:18:40.611+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.611+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.611+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:593,0.308674,-0.074178,9.870394
06-07 17:18:40.641+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.621+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.641+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:624,0.005671,0.047768,0.030804
06-07 17:18:40.641+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19639) cmd(0)
06-07 17:18:40.651+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:633,0.070000,0.070000,0.070000
06-07 17:18:40.651+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.671+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:657,0.318245,-0.167498,9.848858
06-07 17:18:40.671+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:648,0.302435,-0.095526,9.801520
06-07 17:18:40.671+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:667,-0.018200,-0.007821,0.076260
06-07 17:18:40.681+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.681+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:680,0.070000,-0.070000,0.070000
06-07 17:18:40.701+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.711+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.711+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:692,0.349352,-0.114855,9.841680
06-07 17:18:40.711+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:691,0.303046,-0.095171,9.801504
06-07 17:18:40.711+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.721+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.731+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19651) cmd(0)
06-07 17:18:40.741+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:717,-0.005816,0.018282,0.066648
06-07 17:18:40.731+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:735,0.303564,-0.094527,9.801495
06-07 17:18:40.741+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.781+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:763,-0.011244,0.023190,0.064203
06-07 17:18:40.791+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:732,0.070000,-0.070000,0.070000
06-07 17:18:40.791+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:745,0.342174,-0.126820,9.877571
06-07 17:18:40.791+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.791+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:40.791+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:40.791+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.801+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.801+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:40.811+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:40:814,894.000000
06-07 17:18:40.821+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:803,0.303672,-0.095211,9.801485
06-07 17:18:40.821+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.831+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:805,-0.070000,-0.070000,0.070000
06-07 17:18:40.841+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:809,0.337388,-0.133998,9.868000
06-07 17:18:40.851+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.861+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:835,0.027960,-0.006767,0.071341
06-07 17:18:40.861+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.861+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.891+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:869,0.303856,-0.096377,9.801468
06-07 17:18:40.891+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:872,-0.070000,-0.070000,0.070000
06-07 17:18:40.891+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.901+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:875,0.346959,-0.105284,9.822537
06-07 17:18:40.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.901+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:895,0.019496,-0.010449,0.052151
06-07 17:18:40.941+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:910,0.303207,-0.094502,9.801506
06-07 17:18:40.941+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.951+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:40.951+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:920,0.140000,0.070000,0.070000
06-07 17:18:40.951+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:922,0.327817,-0.033500,9.848858
06-07 17:18:40.951+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:40.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:40.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:40:967,0.140000,0.070000,0.070000
06-07 17:18:40.981+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:949,-0.002503,-0.003270,0.056951
06-07 17:18:40.981+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:40.981+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:40:972,0.270389,-0.028714,9.858429
06-07 17:18:40.991+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:40.991+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:41.001+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:40:964,0.302996,-0.093914,9.801518
06-07 17:18:41.001+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.001+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.001+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:41.011+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:41:16,877.000000
06-07 17:18:41.021+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.031+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:35,0.140000,-0.070000,0.070000
06-07 17:18:41.031+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:40:999,-0.009879,-0.019876,0.066529
06-07 17:18:41.041+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:31,0.272782,-0.055035,9.839286
06-07 17:18:41.041+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.041+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:27,0.302552,-0.096283,9.801509
06-07 17:18:41.061+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.071+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:56,0.031407,-0.000784,0.054546
06-07 17:18:41.071+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.081+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:88,0.140000,-0.070000,0.070000
06-07 17:18:41.091+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.091+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:83,0.263210,-0.043071,9.872787
06-07 17:18:41.101+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:88,0.301882,-0.097866,9.801514
06-07 17:18:41.131+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:18:41.131+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:18:41.131+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:18:41.141+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.141+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.151+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:154,0.070000,-0.070000,0.070000
06-07 17:18:41.161+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:154,0.308674,-0.090927,9.853643
06-07 17:18:41.161+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.161+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.171+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:170,0.308674,-0.148355,9.887143
06-07 17:18:41.171+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:172,0.070000,-0.070000,0.070000
06-07 17:18:41.171+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.171+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.171+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:182,0.354138,-0.143569,9.824929
06-07 17:18:41.181+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:185,0.070000,-0.070000,0.070000
06-07 17:18:41.181+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.181+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.191+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:194,-0.070000,-0.070000,0.070000
06-07 17:18:41.191+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:193,0.349352,-0.088534,9.858429
06-07 17:18:41.191+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:41.191+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:41.191+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.201+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.201+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:41.211+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:41:213,859.000000
06-07 17:18:41.211+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:205,0.375673,-0.143569,9.858429
06-07 17:18:41.211+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.211+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:209,0.070000,-0.070000,0.070000
06-07 17:18:41.211+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.221+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:225,0.361316,-0.069392,9.868000
06-07 17:18:41.221+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:230,0.070000,-0.070000,0.140000
06-07 17:18:41.231+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:237,0.265603,-0.078963,9.856036
06-07 17:18:41.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.241+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:244,0.070000,-0.070000,0.070000
06-07 17:18:41.251+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.261+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:251,0.279960,-0.033500,9.848858
06-07 17:18:41.261+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.291+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:265,0.070000,-0.070000,0.140000
06-07 17:18:41.291+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:232,0.027774,0.006991,0.035373
06-07 17:18:41.291+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.301+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:283,0.303124,-0.099737,9.801456
06-07 17:18:41.301+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.311+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.311+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.311+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:301,0.270389,-0.088534,9.884750
06-07 17:18:41.321+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:313,0.019985,-0.022077,0.064104
06-07 17:18:41.331+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.341+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.341+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:322,0.070000,-0.070000,0.070000
06-07 17:18:41.351+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:329,0.302863,-0.100358,9.801458
06-07 17:18:41.361+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:348,0.306281,-0.052642,9.832108
06-07 17:18:41.361+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:355,0.012288,-0.029900,0.064114
06-07 17:18:41.371+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.371+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.371+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.381+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:376,0.070000,-0.070000,0.070000
06-07 17:18:41.391+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:41.391+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:41.401+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:18:41.401+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:18:41.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:41.401+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:41.411+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19600
06-07 17:18:41.421+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:41.421+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19600)
06-07 17:18:41.421+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:18:41.421+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:41.431+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:18:41.431+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:18:41.431+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:41.431+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:41.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19605
06-07 17:18:41.441+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19605)
06-07 17:18:41.451+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:18:41.451+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:41.451+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:18:41.451+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:18:41.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:41.451+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:41.461+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:41:428,865.000000
06-07 17:18:41.461+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:405,0.334995,-0.081356,9.879964
06-07 17:18:41.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:18:41.471+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:41.471+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(19621), cmd(0)
06-07 17:18:41.471+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:41.471+0200 I/utils   (19621): specific action
06-07 17:18:41.471+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:18:41.471+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:18:41.471+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:41.471+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:18:41.471+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:18:41.471+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:41.471+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:41.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19836
06-07 17:18:41.491+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19836)
06-07 17:18:41.491+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:18:41.491+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:41.491+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:18:41.491+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:18:41.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:41.491+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:41.501+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19639
06-07 17:18:41.511+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19639)
06-07 17:18:41.511+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:18:41.511+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:41.511+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:18:41.511+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:18:41.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:41.511+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:41.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19651
06-07 17:18:41.531+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19651)
06-07 17:18:41.531+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:18:41.531+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:41.531+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:18:41.531+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:18:41.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:41.531+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:41.541+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:18:41.551+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:18:41.551+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:18:41.551+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:41.551+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:18:41.551+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:18:41.551+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:41.551+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:41.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:18:41.571+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:41.571+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19663), cmd(0)
06-07 17:18:41.571+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:41.571+0200 I/utils   (19663): specific action
06-07 17:18:41.571+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:18:41.571+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:18:41.571+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:41.571+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:18:41.571+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:18:41.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:41.571+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:41.581+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:41.581+0200 I/utils   (19670): specific action
06-07 17:18:41.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:18:41.591+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:41.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(19670), cmd(0)
06-07 17:18:41.591+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:41.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19682), cmd(0)
06-07 17:18:41.601+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:41.601+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:41.601+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:18:41.601+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:18:41.601+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:41.601+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:41.601+0200 I/utils   (19682): specific action
06-07 17:18:41.601+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:381,0.302496,-0.099003,9.801483
06-07 17:18:41.601+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:41.611+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.611+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.611+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:41:616,867.000000
06-07 17:18:41.621+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:624,0.303070,-0.097881,9.801477
06-07 17:18:41.621+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.631+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:635,0.303561,-0.097885,9.801462
06-07 17:18:41.631+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.631+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:642,0.302833,-0.096864,9.801495
06-07 17:18:41.641+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.641+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:648,0.302589,-0.096810,9.801502
06-07 17:18:41.641+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.651+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:655,0.300790,-0.096277,9.801563
06-07 17:18:41.651+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.651+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:661,0.300245,-0.094039,9.801601
06-07 17:18:41.661+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.661+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:667,0.301590,-0.095685,9.801544
06-07 17:18:41.661+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.671+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.691+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.691+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:696,0.308674,-0.138784,9.839286
06-07 17:18:41.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:699,0.070000,-0.070000,0.070000
06-07 17:18:41.701+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:674,0.304195,-0.095711,9.801464
06-07 17:18:41.701+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:624,0.000216,0.032998,0.068909
06-07 17:18:41.701+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.711+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.751+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.751+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:759,0.004818,0.010235,0.033033
06-07 17:18:41.751+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.761+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:712,0.304716,-0.095592,9.801449
06-07 17:18:41.771+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:765,0.330210,-0.124427,9.858429
06-07 17:18:41.771+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.781+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.791+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:771,-0.210000,-0.140000,0.070000
06-07 17:18:41.791+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:793,0.305104,-0.097717,9.801415
06-07 17:18:41.791+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:41.791+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:41.801+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.801+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:797,-0.004104,-0.053853,0.037780
06-07 17:18:41.801+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:41.811+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:41:815,864.000000
06-07 17:18:41.821+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.831+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.831+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.831+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:833,-0.210000,-0.070000,0.070000
06-07 17:18:41.841+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:831,0.342174,-0.117248,9.875179
06-07 17:18:41.851+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.861+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:847,0.304434,-0.097299,9.801440
06-07 17:18:41.861+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.871+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.881+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:850,-0.006286,-0.040084,0.059304
06-07 17:18:41.881+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:874,0.070000,-0.070000,0.070000
06-07 17:18:41.881+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:870,0.332602,-0.148355,9.856036
06-07 17:18:41.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.901+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.901+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:893,0.304570,-0.095822,9.801451
06-07 17:18:41.921+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:905,0.034836,-0.047287,0.076062
06-07 17:18:41.921+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:41.921+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:41.931+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:917,0.070000,-0.070000,0.070000
06-07 17:18:41.931+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:912,0.311067,-0.105284,9.853643
06-07 17:18:41.931+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:41.981+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:41:933,0.302477,-0.094662,9.801527
06-07 17:18:41.981+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:41.991+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:41:943,0.006792,-0.019383,0.016237
06-07 17:18:41.991+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:41.991+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:41.991+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:41:960,0.313460,-0.100499,9.853643
06-07 17:18:42.001+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:42.001+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:42.011+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:42:14,887.000000
06-07 17:18:42.021+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:41:994,0.070000,0.140000,0.070000
06-07 17:18:42.031+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:42.041+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:42.051+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:42.061+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:42:51,0.003157,0.023167,0.090472
06-07 17:18:42.061+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:42:8,0.301034,-0.094287,9.801575
06-07 17:18:42.071+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:42.071+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:42:54,0.279960,-0.093320,9.879964
06-07 17:18:42.081+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:42.091+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:42.091+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:42:75,0.140000,0.140000,0.070000
06-07 17:18:42.101+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:42.101+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:42:92,0.022561,0.021395,0.018686
06-07 17:18:42.101+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:42:84,0.300698,-0.094593,9.801582
06-07 17:18:42.111+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:42.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:18:42.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:18:42.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:18:42.131+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:42:103,0.282353,-0.064606,9.841680
06-07 17:18:42.131+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:42.131+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11198366c6f63152838472
