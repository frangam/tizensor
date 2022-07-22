S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20844
Date: 2018-04-23 19:44:20+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf716e52d, r5   = 0xf77fdf98
r6   = 0xffcc5d70, r7   = 0xffcc5c20
r8   = 0xf77fac18, r9   = 0x00000000
r10  = 0xffcc5cfc, fp   = 0xffcc5d70
ip   = 0x00000001, sp   = 0xffcc5bf8
lr   = 0xf716e539, pc   = 0xf71d7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      7624 KB
Buffers:     56792 KB
Cached:     233064 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12000 KB
VmRSS:       11996 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20844 TID = 20844
20844 20852 

Maps Information
f4039000 f4838000 rw-p [stack:20852]
f483f000 f4841000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4849000 f484d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4856000 f4858000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4860000 f4863000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4872000 f4877000 r-xp /usr/lib/libsystem.so.0.0.0
f4882000 f4885000 r-xp /lib/libattr.so.1.1.0
f488d000 f489d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48a5000 f48ae000 r-xp /usr/lib/libedbus.so.1.7.99
f48b6000 f48b7000 r-xp /usr/lib/libresponse.so.0.2.96
f48c0000 f48c5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6167000 f626d000 r-xp /usr/lib/libicuuc.so.57.1
f6283000 f640b000 r-xp /usr/lib/libicui18n.so.57.1
f641b000 f6428000 r-xp /usr/lib/libail.so.0.1.0
f6431000 f6438000 r-xp /usr/lib/libminizip.so.1.0.0
f6441000 f65ea000 r-xp /usr/lib/libcrypto.so.1.0.0
f660a000 f6651000 r-xp /usr/lib/libssl.so.1.0.0
f665d000 f665f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6667000 f666e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6677000 f667e000 r-xp /lib/libcrypt-2.13.so
f66af000 f66b2000 r-xp /lib/libcap.so.2.21
f66ba000 f66bc000 r-xp /usr/lib/libiri.so
f66c4000 f670d000 r-xp /usr/lib/libmdm.so.1.2.69
f6715000 f671b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6723000 f6746000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6750000 f6752000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f675a000 f6777000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6780000 f6784000 r-xp /usr/lib/libsmack.so.1.0.0
f678d000 f67a6000 r-xp /usr/lib/libnetwork.so.0.0.0
f67af000 f67b7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67bf000 f67c5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67ce000 f67d0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67d9000 f67e9000 r-xp /lib/libresolv-2.13.so
f67ed000 f6805000 r-xp /usr/lib/liblzma.so.5.0.3
f680e000 f6810000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6818000 f6832000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f683a000 f6869000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6872000 f6881000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f688b000 f6895000 r-xp /usr/lib/libsensord-shared.so
f689e000 f6971000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f697c000 f6992000 r-xp /lib/libz.so.1.2.5
f699a000 f699f000 r-xp /usr/lib/libffi.so.5.0.10
f69a7000 f69a8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69b0000 f69c0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69c8000 f69e1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69e9000 f69eb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69f3000 f6a68000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a72000 f6a78000 r-xp /lib/librt-2.13.so
f6a81000 f6a9f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aa9000 f6aaa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ab2000 f6ad5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6add000 f6ae2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aea000 f6b14000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b1d000 f6b34000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b3c000 f6ba5000 r-xp /lib/libm-2.13.so
f6bae000 f6c42000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c55000 f6c5a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c62000 f6c69000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c71000 f6c9b000 r-xp /usr/lib/libsensor.so.1.9.6
f6ca4000 f6d70000 r-xp /usr/lib/libxml2.so.2.7.8
f6d7d000 f6d7f000 r-xp /usr/lib/libiniparser.so.0
f6d88000 f6d8e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d97000 f6e67000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e68000 f6e9c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ea5000 f6ee1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ee9000 f6eec000 r-xp /usr/lib/libbundle.so.0.1.22
f6ef4000 f6efa000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f02000 f6f43000 r-xp /usr/lib/libeina.so.1.7.99
f6f4c000 f6f63000 r-xp /usr/lib/libecore.so.1.7.99
f6f7a000 f6f83000 r-xp /usr/lib/libvconf.so.0.2.45
f6f8b000 f6f9f000 r-xp /lib/libpthread-2.13.so
f6faa000 f6fb7000 r-xp /usr/lib/libaul.so.0.1.0
f6fc1000 f6fc3000 r-xp /lib/libdl-2.13.so
f6fcc000 f6fd7000 r-xp /lib/libunwind.so.8.0.1
f7004000 f700c000 r-xp /lib/libgcc_s-4.6.so.1
f700d000 f7131000 r-xp /lib/libc-2.13.so
f713f000 f7141000 r-xp /usr/lib/libdlog.so.0.0.0
f7149000 f7155000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f715e000 f7163000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f716b000 f717a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7182000 f7186000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f718f000 f7192000 r-xp /usr/lib/libappcore-agent.so.1.1
f719a000 f719c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71a4000 f71a8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71b0000 f71cd000 r-xp /lib/ld-2.13.so
f71d6000 f71d9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71d9000 f71dd000 r-xp /usr/lib/libsys-assert.so
f77ca000 f7858000 rw-p [heap]
ffca7000 ffcc8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20844)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71d7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf716e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e753f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e73c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e7fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e85be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e85dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6eba75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6eb51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e73c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e7fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e85be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e85dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6eb7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6eb8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ebff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48571fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf484a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf691d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6dcafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dcc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f5cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f57b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f585a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f58879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7190183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71907fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71d74f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf702485c) [/lib/libc.so.6] + 0x1785c
29: (0xf71d6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:604,-0.063972,-0.067603,-0.280311
04-23 19:44:19.599+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:607,9.592826,-1.311267,0.890130
04-23 19:44:19.619+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.619+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.619+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:628,9.658050,-1.290404,1.107848
04-23 19:44:19.619+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.629+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.629+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:628,-19.809999,-7.560000,5.110000
04-23 19:44:19.629+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:633,9.726824,-1.801795,0.758525
04-23 19:44:19.629+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:631,0.068523,-0.542551,-0.382491
04-23 19:44:19.629+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.639+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.639+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:643,9.656412,-1.320130,1.086898
04-23 19:44:19.639+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.639+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:643,5.320000,-2.240000,3.570000
04-23 19:44:19.639+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:647,9.896714,-1.954936,0.646062
04-23 19:44:19.639+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.649+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:651,0.238665,-0.664532,-0.461786
04-23 19:44:19.649+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.649+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.659+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.659+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:663,9.655465,-1.325403,1.088891
04-23 19:44:19.659+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.669+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:668,0.230731,-0.273489,-0.239839
04-23 19:44:19.669+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:663,9.887143,-1.593620,0.847059
04-23 19:44:19.669+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:665,29.260000,3.570000,-0.700000
04-23 19:44:19.669+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.669+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.679+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.679+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:683,9.658519,-1.299544,1.092968
04-23 19:44:19.679+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.689+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:689,0.155108,0.358702,-0.210725
04-23 19:44:19.689+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:683,9.810574,-0.966700,0.878166
04-23 19:44:19.689+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:686,28.910000,4.130000,-2.170000
04-23 19:44:19.699+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.699+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.709+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.709+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:711,9.604790,-0.878166,0.921237
04-23 19:44:19.709+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:705,14.420000,1.680000,-1.610000
04-23 19:44:19.709+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:713,9.662097,-1.273516,1.091985
04-23 19:44:19.719+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.719+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.729+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.729+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:724,-0.053729,0.421378,-0.171732
04-23 19:44:19.739+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:728,8.400000,-0.840000,0.700000
04-23 19:44:19.739+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:733,9.635897,-1.060020,0.937986
04-23 19:44:19.739+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.749+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.749+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:755,9.815358,-1.478764,0.952343
04-23 19:44:19.759+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:753,23.030001,-1.120000,0.700000
04-23 19:44:19.759+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.759+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.769+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:773,9.824929,-1.588834,0.873380
04-23 19:44:19.769+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:768,38.639999,2.800000,-1.050000
04-23 19:44:19.769+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.779+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:782,-0.026200,0.213495,-0.153999
04-23 19:44:19.779+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.789+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.789+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:794,55.020000,4.060000,-2.310000
04-23 19:44:19.789+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.799+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.799+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:788,0.151041,-0.217009,-0.133627
04-23 19:44:19.799+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.809+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.809+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:799,9.738789,-1.540978,0.815953
04-23 19:44:19.809+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.819+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:806,9.664317,-1.261755,1.085970
04-23 19:44:19.819+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:817,0.160616,-0.324447,-0.209561
04-23 19:44:19.829+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.829+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.829+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:822,9.779467,-1.395016,1.172483
04-23 19:44:19.829+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:820,72.800003,4.200000,-4.480000
04-23 19:44:19.829+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.829+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:836,9.664313,-1.264387,1.082941
04-23 19:44:19.829+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.829+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.839+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:841,9.663334,-1.268194,1.087224
04-23 19:44:19.839+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.839+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:839,0.075455,-0.272784,-0.271271
04-23 19:44:19.839+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:846,9.662946,-1.264884,1.094503
04-23 19:44:19.839+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.849+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:850,9.662361,-1.245919,1.121091
04-23 19:44:19.849+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.849+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:840,74.550003,7.210000,-6.020000
04-23 19:44:19.849+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:849,9.714860,-0.303888,1.069592
04-23 19:44:19.849+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.849+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.849+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:855,9.667566,-1.172078,1.155323
04-23 19:44:19.849+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.859+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.859+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:859,9.673124,-1.109337,1.170648
04-23 19:44:19.859+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.859+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:865,9.669919,-1.112708,1.193702
04-23 19:44:19.859+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:860,50.889999,4.480000,-2.310000
04-23 19:44:19.859+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.859+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:859,0.116521,-0.130132,0.077980
04-23 19:44:19.869+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.869+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:865,9.583255,-0.241675,0.818345
04-23 19:44:19.869+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:872,36.889999,0.490000,1.260000
04-23 19:44:19.869+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.869+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:873,0.052499,0.942031,-0.051499
04-23 19:44:19.869+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.869+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.879+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:879,-0.084311,0.930403,-0.336978
04-23 19:44:19.879+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.879+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:883,9.666420,-1.118230,1.216664
04-23 19:44:19.879+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:876,9.712467,-1.304088,1.387837
04-23 19:44:19.879+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.879+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:885,59.290001,-0.490000,0.840000
04-23 19:44:19.879+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.889+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:889,9.786645,-1.536192,1.311267
04-23 19:44:19.889+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:890,0.039343,-0.194751,0.217189
04-23 19:44:19.889+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.889+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:895,0.116726,-0.423484,0.117565
04-23 19:44:19.899+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.899+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.899+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:903,9.665344,-1.077318,1.261303
04-23 19:44:19.899+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.899+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:904,9.992428,-0.535992,1.536192
04-23 19:44:19.899+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.899+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:908,63.840000,5.320000,-1.680000
04-23 19:44:19.909+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:909,0.326008,0.582238,0.319528
04-23 19:44:19.919+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.919+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.919+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:928,9.665850,-1.022151,1.302670
04-23 19:44:19.919+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:928,9.659825,0.119641,1.464408
04-23 19:44:19.919+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.919+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.929+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:932,35.139999,3.850000,3.010000
04-23 19:44:19.929+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:933,-0.005519,1.196959,0.203105
04-23 19:44:19.939+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.939+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.939+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:944,9.662071,-1.013361,1.337110
04-23 19:44:19.939+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:944,9.413363,-0.545564,1.835295
04-23 19:44:19.939+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.939+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.939+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:948,10.640000,-2.940000,7.000000
04-23 19:44:19.949+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:950,-0.252486,0.476587,0.532624
04-23 19:44:19.949+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.949+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.959+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.959+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.959+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:963,9.506684,-1.414158,1.820938
04-23 19:44:19.959+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:966,-0.155387,-0.400797,0.483829
04-23 19:44:19.969+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:965,7.350000,-9.870000,8.260000
04-23 19:44:19.969+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:963,9.656638,-1.040845,1.355129
04-23 19:44:19.969+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:19.969+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.979+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:19:983,9.748360,-1.576870,1.301696
04-23 19:44:19.979+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.979+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:19:983,0.091722,-0.536025,-0.053433
04-23 19:44:19.989+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.989+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:19:993,9.654930,-1.066589,1.347253
04-23 19:44:19.989+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:19:989,17.360001,-10.080000,7.070000
04-23 19:44:19.999+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:19.999+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:19.999+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:3,9.937392,-1.502693,0.803988
04-23 19:44:19.999+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:19.999+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.009+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:9,0.282462,-0.436103,-0.543265
04-23 19:44:20.009+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:5,9.657245,-1.080486,1.319303
04-23 19:44:20.009+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:10,26.040001,-4.830000,2.660000
04-23 19:44:20.019+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.019+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.019+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.029+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.029+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:28,9.875179,-1.351945,0.607777
04-23 19:44:20.039+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.039+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:30,9.661131,-1.085458,1.286356
04-23 19:44:20.039+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:29,26.740000,-0.210000,-0.560000
04-23 19:44:20.039+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.039+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.039+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:34,0.217935,-0.271459,-0.711526
04-23 19:44:20.039+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.049+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:44,9.757930,-1.339981,1.060020
04-23 19:44:20.049+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:52,19.950001,2.800000,-2.240000
04-23 19:44:20.049+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:51,0.096799,-0.254523,-0.226336
04-23 19:44:20.059+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.059+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:50,9.661143,-1.089060,1.283219
04-23 19:44:20.059+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.059+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:63,9.501899,-1.607977,1.538585
04-23 19:44:20.059+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.059+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:65,9.656962,-1.102695,1.302894
04-23 19:44:20.069+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.069+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.079+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:82,9.583255,-1.469193,1.354338
04-23 19:44:20.079+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:70,-0.159245,-0.518917,0.255366
04-23 19:44:20.079+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.089+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.089+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:44:20.089+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:44:20.089+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:44:20.099+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:74,19.809999,1.260000,-2.870000
04-23 19:44:20.099+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.099+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.099+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:98,9.656581,-1.103052,1.305414
04-23 19:44:20.099+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.109+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:112,9.655905,-1.098989,1.313818
04-23 19:44:20.109+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:109,25.480000,-1.750000,-4.130000
04-23 19:44:20.109+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.119+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.119+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:91,-0.073708,-0.366498,0.051443
04-23 19:44:20.119+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.119+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:110,9.765109,-1.450050,1.447658
04-23 19:44:20.119+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:125,0.108528,-0.346998,0.142244
04-23 19:44:20.119+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.119+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.129+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:125,9.654788,-1.079556,1.337916
04-23 19:44:20.129+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:120,32.340000,-1.120000,-4.900000
04-23 19:44:20.129+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.129+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:132,9.700503,-1.112662,1.543371
04-23 19:44:20.129+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:136,42.279999,3.360000,-6.440000
04-23 19:44:20.139+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.139+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.139+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:143,9.528220,-0.729811,1.428515
04-23 19:44:20.139+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:144,9.654848,-1.047284,1.362898
04-23 19:44:20.139+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.139+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:131,0.044599,-0.013673,0.229552
04-23 19:44:20.139+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.149+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:149,40.880001,5.040000,-5.530000
04-23 19:44:20.149+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:152,-0.126568,0.349745,0.090599
04-23 19:44:20.159+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.159+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.159+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:163,9.501899,-0.868595,1.593620
04-23 19:44:20.159+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:163,9.652862,-1.031367,1.388859
04-23 19:44:20.159+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.159+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.159+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:168,32.689999,1.330000,-1.330000
04-23 19:44:20.169+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:168,-0.152949,0.178689,0.230722
04-23 19:44:20.169+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.169+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.179+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:183,9.667004,-0.993021,1.316052
04-23 19:44:20.179+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:183,9.654376,-1.017433,1.388612
04-23 19:44:20.179+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.179+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.179+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:188,34.930000,-3.990000,-0.980000
04-23 19:44:20.189+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:189,0.014142,0.038346,-0.072806
04-23 19:44:20.199+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.199+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.199+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:204,9.891929,-0.945165,1.122234
04-23 19:44:20.199+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:204,9.657247,-0.999596,1.381587
04-23 19:44:20.199+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.199+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.209+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:210,0.237553,0.072268,-0.266379
04-23 19:44:20.209+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:211,38.709999,-1.540000,-2.310000
04-23 19:44:20.219+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.219+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.229+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.229+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:229,9.658220,-0.987079,1.383777
04-23 19:44:20.229+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.229+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:233,0.107862,-0.026925,-0.218675
04-23 19:44:20.229+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:229,9.765109,-1.026521,1.162912
04-23 19:44:20.229+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:236,38.290001,2.380000,-3.430000
04-23 19:44:20.239+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.239+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.239+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:244,9.638289,-0.859023,1.045663
04-23 19:44:20.239+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:244,9.660089,-0.972459,1.381081
04-23 19:44:20.239+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.239+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.249+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:250,-0.019931,0.128056,-0.338113
04-23 19:44:20.249+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:251,29.610001,3.500000,-2.660000
04-23 19:44:20.259+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.259+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:266,9.658787,-0.969159,1.392464
04-23 19:44:20.269+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.269+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:275,21.070000,3.920000,-1.470000
04-23 19:44:20.279+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.289+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:285,9.657306,-0.968223,1.403344
04-23 19:44:20.289+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.289+0200 W/LOCATION(20844): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:44:20.289+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.299+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.299+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.309+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:294,24.010000,8.680000,-3.080000
04-23 19:44:20.309+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.309+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:306,9.659677,-0.959173,1.393203
04-23 19:44:20.319+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:316,39.480000,9.240000,-5.670000
04-23 19:44:20.319+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.329+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:330,9.659131,-0.932928,1.414641
04-23 19:44:20.329+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.339+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.349+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:347,9.660466,-0.868600,1.446137
04-23 19:44:20.349+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:340,61.040001,10.080000,-10.220000
04-23 19:44:20.349+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.359+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.359+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:302,9.772287,-1.019342,1.347159
04-23 19:44:20.359+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.359+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:310,0.112198,-0.046883,-0.033922
04-23 19:44:20.359+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.369+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:365,9.661663,-0.822365,1.465048
04-23 19:44:20.369+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:371,0.173322,-0.121968,-0.198445
04-23 19:44:20.369+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:360,47.040001,13.300000,-12.670000
04-23 19:44:20.369+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.369+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.369+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:366,9.832108,-1.091127,1.194018
04-23 19:44:20.369+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.379+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.379+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:381,9.851252,-1.050449,0.789631
04-23 19:44:20.389+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:378,16.240000,7.700000,-7.420000
04-23 19:44:20.389+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.389+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:385,9.661779,-0.805229,1.473774
04-23 19:44:20.389+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:376,0.193946,-0.082226,-0.613712
04-23 19:44:20.389+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.389+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:396,0.304037,-0.060169,-0.091507
04-23 19:44:20.389+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.389+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:395,3.920000,1.050000,-5.110000
04-23 19:44:20.399+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.399+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:405,9.661164,-0.787304,1.487429
04-23 19:44:20.399+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.409+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.409+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:409,16.590000,-0.350000,-5.180000
04-23 19:44:20.409+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:413,9.963714,-1.019342,1.301696
04-23 19:44:20.409+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.409+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:418,9.652647,-0.191426,1.430908
04-23 19:44:20.409+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.419+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:400,-0.006484,0.741502,0.016267
04-23 19:44:20.419+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.419+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.419+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.419+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:423,9.399008,-0.196211,1.543371
04-23 19:44:20.419+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.429+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:432,9.616754,-0.679562,1.785046
04-23 19:44:20.429+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.429+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:430,9.662205,-0.746792,1.501497
04-23 19:44:20.429+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:432,38.849998,-0.350000,-6.510000
04-23 19:44:20.429+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:437,9.753145,-0.729811,1.892723
04-23 19:44:20.429+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.439+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.439+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:425,-0.261458,0.672388,0.097234
04-23 19:44:20.439+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.439+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.439+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:446,-0.044909,0.142803,0.319998
04-23 19:44:20.439+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.449+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:451,0.091366,0.075418,0.418948
04-23 19:44:20.449+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.449+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:445,9.663098,-0.717202,1.510144
04-23 19:44:20.449+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:442,9.688539,-0.385244,1.737189
04-23 19:44:20.449+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.459+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:456,0.027374,0.402060,0.249760
04-23 19:44:20.459+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:446,56.139999,-0.980000,-8.330000
04-23 19:44:20.459+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.459+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.459+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.459+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:465,0.062226,-0.002161,0.089730
04-23 19:44:20.459+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.459+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:469,0.159439,0.257780,-0.045737
04-23 19:44:20.469+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:469,9.664519,-0.672973,1.521369
04-23 19:44:20.469+0200 I/servicemanager(20291): es.ugr.frailty.location sleep timeout
04-23 19:44:20.469+0200 W/AUL     (20291): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:44:20.469+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:462,9.724431,-0.748954,1.591227
04-23 19:44:20.469+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:44:20.469+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.469+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20291
04-23 19:44:20.469+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:477,9.822537,-0.459422,1.464408
04-23 19:44:20.479+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20844
04-23 19:44:20.479+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:467,65.379997,1.540000,-9.100000
04-23 19:44:20.479+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.479+0200 W/AUL     (20291): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20844)
04-23 19:44:20.479+0200 I/servicemanager(20291): es.ugr.frailty.location stop request sent!
04-23 19:44:20.479+0200 I/servicemanager(20291): App control destroyed.
04-23 19:44:20.479+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.489+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.489+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.489+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:491,9.683753,-0.181855,1.481157
04-23 19:44:20.489+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:493,0.019234,0.491118,-0.040211
04-23 19:44:20.489+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:490,60.410000,3.920000,-8.610000
04-23 19:44:20.499+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.499+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.499+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:504,50.330002,2.660000,-7.770000
04-23 19:44:20.499+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.499+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:508,-0.012367,0.290649,0.072500
04-23 19:44:20.499+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:504,9.652647,-0.330210,1.612763
04-23 19:44:20.509+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:494,9.665014,-0.620859,1.540263
04-23 19:44:20.509+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.509+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:515,9.664769,-0.582108,1.556844
04-23 19:44:20.519+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.519+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.519+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:528,42.910000,3.080000,-7.210000
04-23 19:44:20.519+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.529+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.529+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:532,0.014198,0.283006,-0.008688
04-23 19:44:20.529+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:528,9.678967,-0.299103,1.548156
04-23 19:44:20.529+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:533,9.665008,-0.546268,1.568311
04-23 19:44:20.539+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.539+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.539+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:543,42.139999,3.500000,-7.210000
04-23 19:44:20.539+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.539+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.539+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:547,9.664707,-0.518818,1.579445
04-23 19:44:20.539+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:544,9.669396,-0.433101,1.567299
04-23 19:44:20.539+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:548,0.004389,0.113167,-0.001013
04-23 19:44:20.549+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.559+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.559+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.559+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:563,46.270000,3.360000,-5.950000
04-23 19:44:20.559+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.559+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:567,0.054938,0.047431,0.042889
04-23 19:44:20.559+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:563,9.662724,-0.496125,1.598754
04-23 19:44:20.559+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:563,9.719646,-0.471386,1.622334
04-23 19:44:20.569+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.579+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.579+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.579+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:583,61.810001,4.760000,-7.070000
04-23 19:44:20.579+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.579+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:587,0.013851,0.323841,0.126471
04-23 19:44:20.579+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:587,9.658706,-0.455678,1.634672
04-23 19:44:20.579+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:583,9.676575,-0.172283,1.725225
04-23 19:44:20.599+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.599+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.599+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:603,68.599998,4.620000,-8.540000
04-23 19:44:20.599+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.599+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.599+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:607,0.041798,0.546606,0.047482
04-23 19:44:20.599+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:604,9.700503,0.090927,1.682154
04-23 19:44:20.599+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:608,9.654662,-0.400004,1.672687
04-23 19:44:20.619+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.619+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.619+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:628,9.628718,0.088534,1.672583
04-23 19:44:20.619+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.629+0200 I/linearacceleration(20836): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:20.629+0200 I/linearacceleration(20836): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:20:633,-0.025944,0.488539,-0.000104
04-23 19:44:20.629+0200 I/gyroscope(20823): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:20:632,65.800003,3.780000,-9.030000
04-23 19:44:20.629+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:628,9.650426,-0.346200,1.708744
04-23 19:44:20.639+0200 I/gravity (20853): capturing data from es.ugr.frailty.gravity
04-23 19:44:20.639+0200 I/accelerometer(20810): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:20.639+0200 I/accelerometer(20810): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:20:646,9.707682,0.083749,1.749153
04-23 19:44:20.639+0200 I/gravity (20853): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:20:646,9.645180,-0.293398,1.747800
04-23 19:44:20.639+0200 I/gyroscope(20823): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:20.659+0200 W/CRASH_MANAGER(20380): worker.c: worker_job(1205) > 11208446c6f63152450546
