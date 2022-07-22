S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7436
Date: 2018-06-14 13:10:45+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf716e52d, r5   = 0xf78dc150
r6   = 0xffa71760, r7   = 0xffa71610
r8   = 0xf78eec18, r9   = 0x00000000
r10  = 0xffa716ec, fp   = 0xffa71760
ip   = 0x00000001, sp   = 0xffa715e8
lr   = 0xf716e539, pc   = 0xf71d7270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    312180 KB
Buffers:      4412 KB
Cached:      52920 KB
VmPeak:      53468 KB
VmSize:      53444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11112 KB
VmRSS:       10052 KB
VmData:      11172 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7436 TID = 7436
7436 7494 

Maps Information
f4039000 f4838000 rw-p [stack:7494]
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
f6a72000 f6a90000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a9a000 f6a9b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6aa3000 f6ac6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ace000 f6ad3000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6adb000 f6b05000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b0e000 f6b25000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b2d000 f6b33000 r-xp /lib/librt-2.13.so
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
f6f4c000 f6f55000 r-xp /usr/lib/libvconf.so.0.2.45
f6f5d000 f6f71000 r-xp /lib/libpthread-2.13.so
f6f7c000 f6f89000 r-xp /usr/lib/libaul.so.0.1.0
f6f93000 f6f95000 r-xp /lib/libdl-2.13.so
f6f9e000 f6fa9000 r-xp /lib/libunwind.so.8.0.1
f6fd6000 f6fde000 r-xp /lib/libgcc_s-4.6.so.1
f6fdf000 f7103000 r-xp /lib/libc-2.13.so
f7111000 f7128000 r-xp /usr/lib/libecore.so.1.7.99
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
f78be000 f792c000 rw-p [heap]
ffa52000 ffa73000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7436)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71d7270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
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
21: (0xf7121ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf711cb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf711d5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf711d879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7190183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71907fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71d760b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf6ff685c) [/lib/libc.so.6] + 0x1785c
29: (0xf71d6f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
n( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.281+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:41:279,378.000000
06-14 13:10:41.281+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:275,9.078232,-2.529791,2.712241
06-14 13:10:41.291+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.291+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:280,-0.006880,-0.235614,0.947418
06-14 13:10:41.301+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:298,9.058928,-2.535275,2.771028
06-14 13:10:41.301+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.301+0200 W/libgps_d( 3118): OnGpsExtensionMessage: message_id(1), data(0xf78e2f38), size(2752)
06-14 13:10:41.301+0200 W/libgps_d( 3118): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-14 13:10:41.301+0200 W/libgps  ( 3118): proxy__gps_sv_status_cb : called
06-14 13:10:41.301+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.311+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:268,8.394022,-0.562313,3.278167
06-14 13:10:41.311+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.321+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:315,-0.171462,-0.423446,0.402445
06-14 13:10:41.321+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.321+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:323,8.676375,-2.892922,4.307081
06-14 13:10:41.321+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.321+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:311,9.048834,-2.524512,2.813509
06-14 13:10:41.331+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:329,9.052048,-2.770889,3.718446
06-14 13:10:41.331+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.331+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.341+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:329,-0.280863,0.196733,-0.670535
06-14 13:10:41.341+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:341,8.877372,-2.947958,3.215954
06-14 13:10:41.341+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.341+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.341+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:343,9.033808,-2.536914,2.850396
06-14 13:10:41.351+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:350,8.752945,-2.340181,2.179861
06-14 13:10:41.351+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.351+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.351+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:357,8.662018,-2.419144,1.708475
06-14 13:10:41.351+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:351,-0.372541,0.119976,-1.137574
06-14 13:10:41.351+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.361+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.361+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:362,9.109475,-2.828316,1.658226
06-14 13:10:41.361+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:368,0.067579,-0.269251,-1.146359
06-14 13:10:41.361+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:362,9.034559,-2.539120,2.846050
06-14 13:10:41.361+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.371+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.371+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.371+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:374,9.041896,-2.559065,2.804585
06-14 13:10:41.371+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.371+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:379,0.059756,-1.069294,-0.987096
06-14 13:10:41.381+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:378,9.116654,-3.646662,1.751546
06-14 13:10:41.381+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:383,9.056898,-2.577368,2.738642
06-14 13:10:41.381+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.391+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:391,9.063606,-2.622994,2.672327
06-14 13:10:41.391+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.391+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.391+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:399,9.133404,-3.565305,2.151148
06-14 13:10:41.391+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.391+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:400,0.069798,-0.942312,-0.521179
06-14 13:10:41.401+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:404,9.070004,-2.649855,2.623676
06-14 13:10:41.411+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.411+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.411+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.411+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:41.421+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:421,9.068797,-3.225525,2.548356
06-14 13:10:41.421+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:41:425,78
06-14 13:10:41.421+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:423,-0.001207,-0.575670,-0.075320
06-14 13:10:41.431+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:424,9.072114,-2.666692,2.599208
06-14 13:10:41.441+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.441+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.441+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:445,9.074927,-2.670964,2.584961
06-14 13:10:41.441+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:447,8.973085,-2.778067,2.739782
06-14 13:10:41.441+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.451+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.451+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.451+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:455,-0.099029,-0.111375,0.140574
06-14 13:10:41.461+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:460,9.079891,-2.667302,2.571278
06-14 13:10:41.461+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:460,9.097511,-2.474179,2.754139
06-14 13:10:41.461+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.471+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.471+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:41.481+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:41:480,370.000000
06-14 13:10:41.481+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:472,0.022584,0.196786,0.169178
06-14 13:10:41.481+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:480,9.072929,-2.691370,2.570771
06-14 13:10:41.481+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.481+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.491+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:490,9.066404,-2.737389,2.888137
06-14 13:10:41.491+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.491+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.501+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:501,9.008978,-2.720639,2.522035
06-14 13:10:41.501+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:488,-0.013487,-0.070087,0.316859
06-14 13:10:41.501+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.501+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:501,9.081062,-2.683659,2.550031
06-14 13:10:41.501+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:508,-0.063951,-0.029269,-0.048736
06-14 13:10:41.511+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.511+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.511+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.521+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:520,9.389436,-2.514857,2.361716
06-14 13:10:41.521+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:521,9.096189,-2.655229,2.525764
06-14 13:10:41.521+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:523,0.308373,0.168803,-0.188315
06-14 13:10:41.541+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.541+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.541+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.541+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:547,9.056834,-3.488736,2.139183
06-14 13:10:41.551+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.551+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:547,9.093115,-2.682731,2.507708
06-14 13:10:41.551+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.561+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:548,-0.039355,-0.833506,-0.386581
06-14 13:10:41.561+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.561+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:565,9.094091,-2.689223,2.497191
06-14 13:10:41.561+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:560,9.097511,-3.096312,2.199004
06-14 13:10:41.571+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:569,0.004396,-0.413581,-0.308704
06-14 13:10:41.571+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.571+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.581+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:582,9.123833,-3.189633,2.007578
06-14 13:10:41.581+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.581+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:583,9.094002,-2.706726,2.478536
06-14 13:10:41.591+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:590,0.029741,-0.500410,-0.489613
06-14 13:10:41.591+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.591+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.591+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.601+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:600,9.116654,-3.034099,1.875973
06-14 13:10:41.601+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:602,0.022653,-0.327373,-0.602563
06-14 13:10:41.601+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:603,9.095224,-2.725978,2.452819
06-14 13:10:41.611+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.611+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.621+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:41.621+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:621,9.109475,-2.658426,1.864009
06-14 13:10:41.621+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.631+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:630,0.014251,0.067552,-0.588810
06-14 13:10:41.631+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:41:627,78
06-14 13:10:41.641+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.641+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.641+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:647,9.095119,-2.866602,2.055435
06-14 13:10:41.651+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:621,9.101320,-2.733003,2.422198
06-14 13:10:41.651+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.651+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:650,-0.006201,-0.133598,-0.366764
06-14 13:10:41.651+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.651+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.661+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:661,9.054441,-3.041277,2.196611
06-14 13:10:41.661+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:661,-0.050433,-0.297319,-0.199705
06-14 13:10:41.661+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:657,9.104875,-2.743958,2.396316
06-14 13:10:41.661+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.671+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.671+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.671+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:41.681+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:41:682,394.000000
06-14 13:10:41.691+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:679,8.870193,-2.979064,2.450250
06-14 13:10:41.691+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:674,9.105758,-2.756805,2.378146
06-14 13:10:41.691+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.691+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.701+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:700,9.105966,-2.759078,2.374712
06-14 13:10:41.701+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.701+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:706,9.109755,-2.744574,2.376986
06-14 13:10:41.701+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:706,9.047262,-2.818745,2.687140
06-14 13:10:41.701+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:680,-0.235564,-0.222259,0.072105
06-14 13:10:41.711+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.711+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.711+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.711+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:720,9.125405,-2.690561,2.378707
06-14 13:10:41.721+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:720,9.272188,-2.100898,2.653640
06-14 13:10:41.721+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:716,-0.058703,-0.059667,0.312428
06-14 13:10:41.721+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.721+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:727,0.162434,0.643676,0.276654
06-14 13:10:41.741+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.741+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.741+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:747,9.135078,-2.651972,2.384904
06-14 13:10:41.741+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,13:10:41:747,9.547362,-2.380858,2.890530
06-14 13:10:41.741+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.751+0200 I/accelerometer( 7403): es.ugr.frailty.accelerometer - capturing data
06-14 13:10:41.751+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.761+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:759,9.135089,-2.632843,2.405965
06-14 13:10:41.761+0200 E/RESOURCED( 2547): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
06-14 13:10:41.761+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:753,0.421957,0.309703,0.511822
06-14 13:10:41.761+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.771+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:772,0.244786,0.216078,0.613303
06-14 13:10:41.771+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.781+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:782,0.041386,0.170628,0.664026
06-14 13:10:41.781+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.791+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:789,9.130575,-2.626404,2.430016
06-14 13:10:41.791+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.791+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.801+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:800,0.024364,-0.386160,0.314552
06-14 13:10:41.801+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:805,9.121541,-2.648339,2.440117
06-14 13:10:41.811+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.811+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.821+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:821,-0.083850,-0.402510,0.012527
06-14 13:10:41.821+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:823,9.113116,-2.674284,2.443297
06-14 13:10:41.831+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:41.831+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:41:837,78
06-14 13:10:41.841+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.841+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:847,-0.113710,-0.319137,-0.153366
06-14 13:10:41.841+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.851+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.851+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:860,0.080069,-0.038018,-0.593816
06-14 13:10:41.861+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:855,9.108371,-2.694585,2.438682
06-14 13:10:41.861+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.861+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:868,9.115525,-2.697019,2.409080
06-14 13:10:41.871+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.871+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:41.871+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:879,0.154269,0.014665,-0.614463
06-14 13:10:41.881+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:41:880,422.000000
06-14 13:10:41.881+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.891+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:889,9.126573,-2.690133,2.374706
06-14 13:10:41.891+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.891+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.901+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:900,0.136044,-0.466000,-0.537019
06-14 13:10:41.901+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:903,9.131086,-2.702924,2.342616
06-14 13:10:41.911+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.911+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.921+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:921,-0.055110,-0.314425,-0.038327
06-14 13:10:41.921+0200 I/gravity ( 7456): es.ugr.frailty.gravity: SM-R760,14/06/2018,13:10:41:925,9.129945,-2.715123,2.332939
06-14 13:10:41.941+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.941+0200 W/AUL     ( 7575): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
06-14 13:10:41.941+0200 I/gravity ( 7456): es.ugr.frailty.gravity - capturing data
06-14 13:10:41.941+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 23
06-14 13:10:41.941+0200 W/AUL_AMD ( 2477): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-14 13:10:41.941+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7403
06-14 13:10:41.941+0200 W/AUL_AMD ( 2477): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-14 13:10:41.951+0200 I/AUL_AMD ( 2477): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7403
06-14 13:10:41.951+0200 W/AUL     ( 2477): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7403)
06-14 13:10:41.951+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:947,-0.061148,-0.237620,0.380522
06-14 13:10:41.951+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.951+0200 E/RESOURCED( 2547): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
06-14 13:10:41.961+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:964,0.272308,0.024643,0.872798
06-14 13:10:41.971+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.971+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:980,-0.069196,0.634870,0.758628
06-14 13:10:41.991+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:41.991+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:41:999,-0.082965,0.629692,0.642076
06-14 13:10:42.011+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:42.021+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:42.021+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:42:22,0.131046,-0.043996,0.393792
06-14 13:10:42.021+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:42:25,78
06-14 13:10:42.041+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:42.041+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:42:46,0.033638,-0.010813,-0.073739
06-14 13:10:42.051+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:42.051+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,13:10:42:59,-0.049075,-0.466925,-0.554355
06-14 13:10:42.071+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:42.071+0200 W/AUL     ( 7576): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
06-14 13:10:42.081+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:42:81,412.000000
06-14 13:10:42.081+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 23
06-14 13:10:42.081+0200 W/AUL_AMD ( 2477): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-14 13:10:42.081+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7456
06-14 13:10:42.081+0200 W/AUL_AMD ( 2477): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-14 13:10:42.081+0200 I/linearacceleration( 7444): es.ugr.frailty.linearacceleration - capturing data
06-14 13:10:42.091+0200 I/AUL_AMD ( 2477): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7456
06-14 13:10:42.091+0200 W/AUL     ( 2477): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7456)
06-14 13:10:42.091+0200 E/RESOURCED( 2547): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
06-14 13:10:42.201+0200 W/AUL     ( 7577): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.linearacceleration]
06-14 13:10:42.201+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 23
06-14 13:10:42.201+0200 W/AUL_AMD ( 2477): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-14 13:10:42.201+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7444
06-14 13:10:42.201+0200 W/AUL_AMD ( 2477): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-14 13:10:42.221+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:42.221+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:42:227,78
06-14 13:10:42.231+0200 I/AUL_AMD ( 2477): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7444
06-14 13:10:42.231+0200 W/AUL     ( 2477): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7444)
06-14 13:10:42.271+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:42.281+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:42:282,383.000000
06-14 13:10:42.291+0200 W/libgps_d( 3118): OnGpsExtensionMessage: message_id(1), data(0xf78e2f38), size(2752)
06-14 13:10:42.291+0200 W/libgps_d( 3118): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-14 13:10:42.291+0200 W/libgps  ( 3118): proxy__gps_sv_status_cb : called
06-14 13:10:42.421+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:42.421+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:42:426,78
06-14 13:10:42.471+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:42.481+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:42:481,370.000000
06-14 13:10:42.621+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:42.621+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:42:626,78
06-14 13:10:42.671+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:42.681+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:42:681,351.000000
06-14 13:10:42.821+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:42.821+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:42:826,78
06-14 13:10:42.871+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:42.881+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:42:880,371.000000
06-14 13:10:43.021+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:43.031+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:43:26,78
06-14 13:10:43.071+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:43.081+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:43:80,397.000000
06-14 13:10:43.221+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:43.231+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:43:226,78
06-14 13:10:43.271+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:43.301+0200 W/libgps_d( 3118): OnGpsExtensionMessage: message_id(1), data(0xf78e2f38), size(2752)
06-14 13:10:43.301+0200 W/libgps_d( 3118): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-14 13:10:43.311+0200 W/libgps  ( 3118): proxy__gps_sv_status_cb : called
06-14 13:10:43.311+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:43:281,396.000000
06-14 13:10:43.421+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:43.421+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:43:427,78
06-14 13:10:43.471+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:43.481+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:43:481,383.000000
06-14 13:10:43.621+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:43.621+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:43:627,78
06-14 13:10:43.671+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:43.681+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:43:681,330.000000
06-14 13:10:43.821+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:43.831+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:43:827,78
06-14 13:10:43.871+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:43.881+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:43:881,313.000000
06-14 13:10:44.021+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:44.031+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:44:27,78
06-14 13:10:44.071+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:44.081+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:44:81,314.000000
06-14 13:10:44.221+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:44.221+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:44:227,79
06-14 13:10:44.271+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:44.301+0200 W/libgps_d( 3118): OnGpsExtensionMessage: message_id(1), data(0xf78e2f38), size(2752)
06-14 13:10:44.301+0200 W/libgps_d( 3118): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-14 13:10:44.301+0200 W/libgps  ( 3118): proxy__gps_sv_status_cb : called
06-14 13:10:44.311+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:44:281,346.000000
06-14 13:10:44.421+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:44.421+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:44:427,79
06-14 13:10:44.431+0200 W/AUL     ( 7426): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-14 13:10:44.431+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 0
06-14 13:10:44.431+0200 W/AUL_AMD ( 2477): amd_launch.c: _start_app(1782) > caller pid : 7426
06-14 13:10:44.451+0200 W/AUL_AMD ( 2477): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7194
06-14 13:10:44.481+0200 E/AUL_AMD ( 2477): amd_launch.c: __real_send(909) > send fail to client
06-14 13:10:44.481+0200 W/AUL_AMD ( 2477): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(7194), cmd(0)
06-14 13:10:44.491+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:44.491+0200 I/utils   ( 7194): specific action
06-14 13:10:44.491+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:44.491+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:44.491+0200 I/servicemanager( 7194): requesting to save local data for es.ugr.frailty.heartrate
06-14 13:10:44.491+0200 W/AUL     ( 7194): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-14 13:10:44.501+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 0
06-14 13:10:44.501+0200 W/AUL_AMD ( 2477): amd_launch.c: _start_app(1782) > caller pid : 7194
06-14 13:10:44.511+0200 W/AUL_AMD ( 2477): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7399
06-14 13:10:44.531+0200 W/AUL     ( 7194): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7399)
06-14 13:10:44.531+0200 I/servicemanager( 7194): request sent to service es.ugr.frailty.recorder
06-14 13:10:44.531+0200 I/servicemanager( 7194): requesting to save local data
06-14 13:10:44.531+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:44.531+0200 E/AUL_AMD ( 2477): amd_launch.c: __real_send(909) > send fail to client
06-14 13:10:44.531+0200 W/AUL_AMD ( 2477): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(7399), cmd(0)
06-14 13:10:44.541+0200 W/AUL     ( 7426): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7194)
06-14 13:10:44.541+0200 I/heartrate( 7426): request sent to service es.ugr.frailty.servicemanager
06-14 13:10:44.541+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:44.541+0200 I/utils   ( 7399): specific action
06-14 13:10:44.541+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:44.541+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:44.541+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:44.541+0200 I/recorder( 7399): saving local data for es.ugr.frailty.heartrate
06-14 13:10:44.541+0200 I/recorder( 7399): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
06-14 13:10:44.541+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:44:542,342.000000
06-14 13:10:44.621+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:44.631+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:44:631,78
06-14 13:10:44.671+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:44.681+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:44:682,318.000000
06-14 13:10:44.821+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:44.821+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:44:828,79
06-14 13:10:44.831+0200 E/CAPI_APPFW_APP_CONTROL( 7468): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
06-14 13:10:44.831+0200 E/pressure( 7468): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pressure; data: 
06-14 13:10:44.871+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:44.881+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:44:882,288.000000
06-14 13:10:45.021+0200 E/CAPI_APPFW_APP_CONTROL( 7482): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
06-14 13:10:45.021+0200 E/pedometer( 7482): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pedometer; data: 
06-14 13:10:45.021+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:45.031+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:45:28,79
06-14 13:10:45.061+0200 E/CAPI_TELEPHONY( 7511): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-14 13:10:45.071+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:45.081+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:45:82,260.000000
06-14 13:10:45.091+0200 W/AUL     ( 7479): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-14 13:10:45.101+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 0
06-14 13:10:45.101+0200 W/AUL_AMD ( 2477): amd_launch.c: _start_app(1782) > caller pid : 7479
06-14 13:10:45.111+0200 W/AUL_AMD ( 2477): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7194
06-14 13:10:45.121+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.121+0200 I/utils   ( 7194): specific action
06-14 13:10:45.121+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.121+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.121+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.121+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.121+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.121+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.121+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.121+0200 I/servicemanager( 7194): requesting to save local data for es.ugr.frailty.light
06-14 13:10:45.121+0200 W/AUL     ( 7194): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-14 13:10:45.121+0200 W/AUL     ( 7479): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7194)
06-14 13:10:45.121+0200 I/light   ( 7479): request sent to service es.ugr.frailty.servicemanager
06-14 13:10:45.121+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 0
06-14 13:10:45.131+0200 W/AUL_AMD ( 2477): amd_launch.c: _start_app(1782) > caller pid : 7194
06-14 13:10:45.141+0200 W/AUL_AMD ( 2477): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7399
06-14 13:10:45.141+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.141+0200 I/utils   ( 7399): specific action
06-14 13:10:45.151+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.151+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.151+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.151+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.151+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.151+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.151+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.151+0200 W/CAPI_APPFW_APP_CONTROL( 7399): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-14 13:10:45.151+0200 I/recorder( 7399): saving local data for es.ugr.frailty.light
06-14 13:10:45.151+0200 I/recorder( 7399): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-14 13:10:45.151+0200 E/AUL_AMD ( 2477): amd_launch.c: __real_send(909) > send fail to client
06-14 13:10:45.151+0200 W/AUL_AMD ( 2477): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(7194), cmd(0)
06-14 13:10:45.151+0200 W/AUL     ( 7194): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7399)
06-14 13:10:45.151+0200 I/servicemanager( 7194): request sent to service es.ugr.frailty.recorder
06-14 13:10:45.151+0200 I/servicemanager( 7194): requesting to save local data
06-14 13:10:45.151+0200 E/AUL_AMD ( 2477): amd_launch.c: __real_send(909) > send fail to client
06-14 13:10:45.151+0200 W/AUL_AMD ( 2477): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(7399), cmd(0)
06-14 13:10:45.221+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:45.231+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:45:229,78
06-14 13:10:45.271+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:45.281+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:45:283,275.000000
06-14 13:10:45.291+0200 W/libgps_d( 3118): OnGpsExtensionMessage: message_id(1), data(0xf78e2f38), size(2752)
06-14 13:10:45.291+0200 W/libgps_d( 3118): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-14 13:10:45.291+0200 W/libgps  ( 3118): proxy__gps_sv_status_cb : called
06-14 13:10:45.421+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:45.431+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:45:429,78
06-14 13:10:45.471+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:45.481+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:45:481,339.000000
06-14 13:10:45.621+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:45.631+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:45:629,78
06-14 13:10:45.671+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:45.681+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:45:683,399.000000
06-14 13:10:45.771+0200 W/LOCATION( 7436): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-14 13:10:45.821+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:45.831+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:45:829,78
06-14 13:10:45.871+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:45.881+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:45:882,492.000000
06-14 13:10:46.031+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:46.041+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:46:36,78
06-14 13:10:46.071+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:46.081+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:46:82,592.000000
06-14 13:10:46.121+0200 W/AUL     ( 7585): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-14 13:10:46.121+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 23
06-14 13:10:46.121+0200 W/AUL_AMD ( 2477): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-14 13:10:46.121+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7097
06-14 13:10:46.121+0200 W/AUL_AMD ( 2477): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-14 13:10:46.141+0200 I/AUL_AMD ( 2477): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7097
06-14 13:10:46.141+0200 W/AUL     ( 2477): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7097)
06-14 13:10:46.141+0200 W/libgps_d( 3118): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-14 13:10:46.141+0200 W/libgps  ( 3118): [proxy__gps_stop][line = 1067]: called.
06-14 13:10:46.141+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-14 13:10:46.141+0200 W/libgps_d( 3118): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-14 13:10:46.141+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-14 13:10:46.151+0200 W/libgps_d( 3118): GpsiHookStateGps              : EXIT
06-14 13:10:46.151+0200 W/libgps_d( 3118): GpsiHookStateIdle             : ENTRY
06-14 13:10:46.151+0200 E/CAPI_LOCATION_MANAGER( 7511): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-14 13:10:46.161+0200 W/gpsd    ( 3090): HandleIncomingMessage() dest id:0, msg id:2
06-14 13:10:46.171+0200 I/SECURE_STORAGE( 2511): ss_server_ipc.c: SsServerComm(251) > write succeed
06-14 13:10:46.221+0200 I/heartrate( 7426): es.ugr.frailty.heartrate - capturing data
06-14 13:10:46.231+0200 I/heartrate( 7426): es.ugr.frailty.heartrate: SM-R760,14/06/2018,13:10:46:229,77
06-14 13:10:46.271+0200 I/CAPI_NETWORK_CONNECTION( 7511): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-14 13:10:46.271+0200 I/CAPI_NETWORK_CONNECTION( 7511): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-14 13:10:46.271+0200 I/CAPI_NETWORK_CONNECTION( 7511): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-14 13:10:46.271+0200 I/CAPI_NETWORK_CONNECTION( 7511): connection.c: connection_destroy(471) > Destroy handle: 0xf749cc90
06-14 13:10:46.271+0200 I/light   ( 7479): es.ugr.frailty.light - capturing data
06-14 13:10:46.281+0200 I/light   ( 7479): es.ugr.frailty.light: SM-R760,14/06/2018,13:10:46:282,648.000000
06-14 13:10:46.321+0200 W/CRASH_MANAGER( 7584): worker.c: worker_job(1205) > 11074366c6f63152897464
