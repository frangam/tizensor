S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20566
Date: 2018-04-23 19:43:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf777452d, r5   = 0xf79f5f98
r6   = 0xfff5b730, r7   = 0xfff5b5e0
r8   = 0xf79f2c18, r9   = 0x00000000
r10  = 0xfff5b6bc, fp   = 0xfff5b730
ip   = 0x00000001, sp   = 0xfff5b5b8
lr   = 0xf7774539, pc   = 0xf77dd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9064 KB
Buffers:     56620 KB
Cached:     232368 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11656 KB
VmRSS:       11656 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20566 TID = 20566
20566 20595 

Maps Information
f463f000 f4e3e000 rw-p [stack:20595]
f4e45000 f4e47000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e4f000 f4e53000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e5c000 f4e5e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e66000 f4e69000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e78000 f4e7d000 r-xp /usr/lib/libsystem.so.0.0.0
f4e88000 f4e8b000 r-xp /lib/libattr.so.1.1.0
f4e93000 f4ea3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4eab000 f4eb4000 r-xp /usr/lib/libedbus.so.1.7.99
f4ebc000 f4ebd000 r-xp /usr/lib/libresponse.so.0.2.96
f4ec6000 f4ecb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f676d000 f6873000 r-xp /usr/lib/libicuuc.so.57.1
f6889000 f6a11000 r-xp /usr/lib/libicui18n.so.57.1
f6a21000 f6a2e000 r-xp /usr/lib/libail.so.0.1.0
f6a37000 f6a3e000 r-xp /usr/lib/libminizip.so.1.0.0
f6a47000 f6bf0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6c10000 f6c57000 r-xp /usr/lib/libssl.so.1.0.0
f6c63000 f6c65000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c6d000 f6c74000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c7d000 f6c84000 r-xp /lib/libcrypt-2.13.so
f6cb5000 f6cb8000 r-xp /lib/libcap.so.2.21
f6cc0000 f6cc2000 r-xp /usr/lib/libiri.so
f6cca000 f6d13000 r-xp /usr/lib/libmdm.so.1.2.69
f6d1b000 f6d21000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6d29000 f6d4c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d56000 f6d58000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d60000 f6d7d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d86000 f6d8a000 r-xp /usr/lib/libsmack.so.1.0.0
f6d93000 f6dac000 r-xp /usr/lib/libnetwork.so.0.0.0
f6db5000 f6dbd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6dc5000 f6dcb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6dd4000 f6dd6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ddf000 f6def000 r-xp /lib/libresolv-2.13.so
f6df3000 f6e0b000 r-xp /usr/lib/liblzma.so.5.0.3
f6e14000 f6e16000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e1e000 f6e38000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e40000 f6e6f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e78000 f6e87000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e91000 f6e9b000 r-xp /usr/lib/libsensord-shared.so
f6ea4000 f6f77000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f82000 f6f98000 r-xp /lib/libz.so.1.2.5
f6fa0000 f6fa5000 r-xp /usr/lib/libffi.so.5.0.10
f6fad000 f6fae000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6fb6000 f6fc6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6fce000 f6fe7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fef000 f6ff1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ff9000 f706e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7078000 f707e000 r-xp /lib/librt-2.13.so
f7087000 f70a5000 r-xp /usr/lib/libsystemd.so.0.4.0
f70af000 f70b0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70b8000 f70db000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70e3000 f70e8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70f0000 f711a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7123000 f713a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7142000 f71ab000 r-xp /lib/libm-2.13.so
f71b4000 f7248000 r-xp /usr/lib/libstdc++.so.6.0.16
f725b000 f7260000 r-xp /usr/lib/libctx-client.so.0.8.3
f7268000 f726f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7277000 f72a1000 r-xp /usr/lib/libsensor.so.1.9.6
f72aa000 f7376000 r-xp /usr/lib/libxml2.so.2.7.8
f7383000 f7385000 r-xp /usr/lib/libiniparser.so.0
f738e000 f7394000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f739d000 f746d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f746e000 f74a2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f74ab000 f74e7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74ef000 f74f2000 r-xp /usr/lib/libbundle.so.0.1.22
f74fa000 f7500000 r-xp /usr/lib/libappsvc.so.0.1.0
f7508000 f7549000 r-xp /usr/lib/libeina.so.1.7.99
f7552000 f7569000 r-xp /usr/lib/libecore.so.1.7.99
f7580000 f7589000 r-xp /usr/lib/libvconf.so.0.2.45
f7591000 f75a5000 r-xp /lib/libpthread-2.13.so
f75b0000 f75bd000 r-xp /usr/lib/libaul.so.0.1.0
f75c7000 f75c9000 r-xp /lib/libdl-2.13.so
f75d2000 f75dd000 r-xp /lib/libunwind.so.8.0.1
f760a000 f7612000 r-xp /lib/libgcc_s-4.6.so.1
f7613000 f7737000 r-xp /lib/libc-2.13.so
f7745000 f7747000 r-xp /usr/lib/libdlog.so.0.0.0
f774f000 f775b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7764000 f7769000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7771000 f7780000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7788000 f778c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7795000 f7798000 r-xp /usr/lib/libappcore-agent.so.1.1
f77a0000 f77a2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f77aa000 f77ae000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f77b6000 f77d3000 r-xp /lib/ld-2.13.so
f77dc000 f77df000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77df000 f77e3000 r-xp /usr/lib/libsys-assert.so
f79c2000 f7a50000 rw-p [heap]
fff3c000 fff5d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20566)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf77dd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7774539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf747b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7479c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7485e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf748bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf748bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf74c075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74bb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7479c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7485e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf748bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf748bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf74bde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf74be017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74c5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e5d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e50171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6f23663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf73d0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73d27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7562ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf755db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf755e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf755e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7796183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77967fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77dd4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf762a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf77dcf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
760,23/04/2018,19:43:58:671,2.360274,-0.756666,9.488254
04-23 19:43:58.679+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.679+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.679+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.689+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.689+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:689,0.429186,-0.024307,0.057605
04-23 19:43:58.689+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:58.689+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:58:697,76
04-23 19:43:58.699+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:687,2.375581,-0.756686,9.484430
04-23 19:43:58.699+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:690,2.828316,-0.509671,9.413363
04-23 19:43:58.699+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:695,-1.890000,0.560000,0.770000
04-23 19:43:58.699+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.709+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.709+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.709+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:718,2.727818,-0.634098,9.387043
04-23 19:43:58.719+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.719+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:723,0.370671,-0.032690,0.066021
04-23 19:43:58.719+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:713,2.397071,-0.768724,9.478053
04-23 19:43:58.719+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.719+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:721,-2.940000,1.540000,1.400000
04-23 19:43:58.719+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.719+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.729+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:733,0.318242,-0.128752,-0.002577
04-23 19:43:58.739+0200 E/CAPI_TELEPHONY(18958): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:43:58.749+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.749+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:758,0.344438,-0.000277,-0.115468
04-23 19:43:58.759+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:740,2.739782,-0.787239,9.332008
04-23 19:43:58.759+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.759+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.759+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.769+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:769,0.318707,-0.170135,-0.178658
04-23 19:43:58.769+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:766,2.586641,-0.973879,9.449257
04-23 19:43:58.769+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.779+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:778,2.840281,-0.811167,9.530612
04-23 19:43:58.779+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.789+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:789,0.337484,0.002465,-0.037521
04-23 19:43:58.789+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.789+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:786,-5.180000,2.800000,1.890000
04-23 19:43:58.789+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.799+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:733,2.411095,-0.786860,9.473007
04-23 19:43:58.799+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.799+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:795,2.794817,-0.823131,9.535398
04-23 19:43:58.799+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.809+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.809+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:813,0.380887,0.257336,0.208834
04-23 19:43:58.819+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:803,2.424146,-0.790441,9.469378
04-23 19:43:58.819+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.819+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:800,-4.270000,2.520000,1.680000
04-23 19:43:58.819+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.819+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.829+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:830,0.264599,0.126977,-0.040937
04-23 19:43:58.829+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:811,2.754139,-0.921237,9.463614
04-23 19:43:58.829+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.839+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:827,2.435897,-0.792485,9.466190
04-23 19:43:58.839+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.849+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:849,0.269590,-0.211736,-0.072166
04-23 19:43:58.849+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:828,-1.750000,2.870000,1.120000
04-23 19:43:58.849+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.849+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.859+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:840,2.780460,-0.787239,9.351151
04-23 19:43:58.859+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.859+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:860,2.436022,-0.786962,9.466619
04-23 19:43:58.859+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.859+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.869+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:869,0.208408,-0.101391,0.039880
04-23 19:43:58.869+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:864,2.746960,-0.940379,9.291330
04-23 19:43:58.869+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.869+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:856,-0.840000,1.750000,-0.140000
04-23 19:43:58.869+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.879+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:868,2.428253,-0.770244,9.469989
04-23 19:43:58.879+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.879+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.889+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:889,0.230774,0.056144,0.251794
04-23 19:43:58.889+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:878,2.773281,-0.772882,9.430114
04-23 19:43:58.889+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.889+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:881,5.320000,-0.280000,-1.540000
04-23 19:43:58.889+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.899+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:886,2.435797,-0.775346,9.467635
04-23 19:43:58.899+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.899+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:58.899+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:900,7.910000,0.420000,-1.540000
04-23 19:43:58.899+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.909+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.909+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:58:910,76
04-23 19:43:58.909+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:914,0.190501,0.044446,0.142676
04-23 19:43:58.909+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:897,2.825923,-0.516850,9.674182
04-23 19:43:58.909+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:912,0.980000,3.010000,-1.190000
04-23 19:43:58.909+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.909+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.919+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:920,-0.210000,2.450000,-1.470000
04-23 19:43:58.919+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:905,2.445037,-0.774186,9.465348
04-23 19:43:58.919+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.919+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.919+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.919+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:925,3.920000,2.380000,-2.170000
04-23 19:43:58.919+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.919+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:929,0.226271,-0.276135,0.093144
04-23 19:43:58.929+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:919,2.703890,-0.624527,9.427721
04-23 19:43:58.929+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.929+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:930,3.920000,1.890000,-2.380000
04-23 19:43:58.929+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.929+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:925,2.439291,-0.751504,9.468658
04-23 19:43:58.929+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.929+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:935,1.890000,1.400000,-2.030000
04-23 19:43:58.929+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.929+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:938,2.434299,-0.735822,9.471174
04-23 19:43:58.929+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.939+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:940,3.150000,1.330000,-0.980000
04-23 19:43:58.939+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:934,2.703890,-0.947558,9.399008
04-23 19:43:58.939+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.939+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.939+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:944,2.648855,-0.842274,9.509077
04-23 19:43:58.939+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.939+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.939+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:945,2.170000,1.330000,-1.890000
04-23 19:43:58.939+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.939+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:949,0.241226,-0.383401,-0.021390
04-23 19:43:58.949+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:950,2.030000,-2.100000,-2.380000
04-23 19:43:58.949+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.949+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:942,2.440447,-0.740882,9.469197
04-23 19:43:58.949+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.949+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:955,3.430000,-3.150000,-3.570000
04-23 19:43:58.949+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.949+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:956,2.437223,-0.738098,9.470244
04-23 19:43:58.949+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.959+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:960,2.170000,-3.150000,-5.110000
04-23 19:43:58.959+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:960,2.434426,-0.728793,9.471685
04-23 19:43:58.959+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.959+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.959+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:965,2.439334,-0.721672,9.470967
04-23 19:43:58.959+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.959+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:969,0.211956,-0.217541,0.027158
04-23 19:43:58.959+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.969+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:971,2.448307,-0.726869,9.468254
04-23 19:43:58.969+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.969+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:973,2.870000,-5.320000,-6.510000
04-23 19:43:58.969+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:948,2.667997,-0.681954,9.722038
04-23 19:43:58.969+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.969+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:976,2.465613,-0.739588,9.462777
04-23 19:43:58.969+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.969+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:978,2.624927,-0.684347,9.614362
04-23 19:43:58.979+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.979+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:58:982,2.482604,-0.743191,9.458051
04-23 19:43:58.979+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:983,2.665605,-0.997807,9.564112
04-23 19:43:58.979+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.979+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:989,2.689533,-1.110270,9.446864
04-23 19:43:58.979+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:58.989+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:58.989+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:58.989+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:58:994,0.252392,-0.268973,-0.085365
04-23 19:43:58.999+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:58:994,6.510000,-4.270000,-7.840000
04-23 19:43:58.999+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:58.999+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:6,2.491161,-0.741392,9.455942
04-23 19:43:58.999+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:58:993,2.677568,-0.957129,9.489935
04-23 19:43:58.999+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.009+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.009+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:14,10.290000,-4.760000,-7.770000
04-23 19:43:59.009+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.009+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:18,0.329977,-0.076954,-0.049756
04-23 19:43:59.009+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.019+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:23,2.489332,-0.722781,9.457864
04-23 19:43:59.019+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.019+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.029+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:29,16.170000,-2.450000,-7.280000
04-23 19:43:59.029+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:31,0.489732,0.069541,-0.099534
04-23 19:43:59.029+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:12,2.734996,-1.012164,9.372685
04-23 19:43:59.029+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.029+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.039+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:40,2.821138,-0.818345,9.406186
04-23 19:43:59.039+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.039+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.039+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.049+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:51,0.559455,0.426400,-0.165514
04-23 19:43:59.049+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:49,10.780000,1.750000,-7.840000
04-23 19:43:59.049+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:42,2.467466,-0.684825,9.466415
04-23 19:43:59.049+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.059+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:48,2.979064,-0.653241,9.358330
04-23 19:43:59.059+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.059+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.079+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:43:59.079+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:43:59.079+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:43:59.079+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:69,1.260000,0.980000,-7.280000
04-23 19:43:59.089+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:71,0.422514,0.754591,-0.273992
04-23 19:43:59.089+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.089+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.089+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:60,2.448873,-0.639736,9.474394
04-23 19:43:59.089+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.089+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:59.099+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.099+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:94,0.654049,0.443040,-0.342915
04-23 19:43:59.099+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:59:103,76
04-23 19:43:59.099+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:96,-9.380000,3.360000,-4.550000
04-23 19:43:59.099+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:103,2.451835,-0.598573,9.476318
04-23 19:43:59.099+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.109+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.109+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:101,3.026921,-0.258425,9.300901
04-23 19:43:59.109+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.109+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.109+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:116,2.871387,0.114855,9.200402
04-23 19:43:59.109+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:118,-11.690000,7.560000,-0.980000
04-23 19:43:59.109+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.119+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:114,0.590813,0.030725,-0.088655
04-23 19:43:59.119+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:111,2.500714,-0.595431,9.463735
04-23 19:43:59.119+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.119+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:123,3.105884,-0.155533,9.133404
04-23 19:43:59.119+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.119+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.119+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:128,3.091527,-0.564706,9.375079
04-23 19:43:59.119+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:129,0.290878,0.536866,-0.157452
04-23 19:43:59.129+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.129+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.129+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:133,-4.690000,13.020000,-1.610000
04-23 19:43:59.129+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:134,2.842674,-0.078963,9.291330
04-23 19:43:59.129+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:126,2.551795,-0.615830,9.448782
04-23 19:43:59.129+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.129+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:139,2.550161,-0.596122,9.450487
04-23 19:43:59.139+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.139+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.149+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:150,-15.750000,12.670000,-0.980000
04-23 19:43:59.149+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:150,-0.020948,0.837797,-0.412796
04-23 19:43:59.149+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.149+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.149+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:154,2.529213,0.241675,9.037691
04-23 19:43:59.149+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:155,2.586435,-0.583748,9.441397
04-23 19:43:59.159+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.159+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.169+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:170,4.620000,9.520000,-3.010000
04-23 19:43:59.169+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:171,0.064812,-0.454737,0.285427
04-23 19:43:59.169+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.169+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.169+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:174,2.651247,-1.038485,9.726824
04-23 19:43:59.169+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:175,2.552917,-0.591201,9.450052
04-23 19:43:59.179+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.179+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.179+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.189+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:191,0.129437,0.327991,0.413163
04-23 19:43:59.189+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:190,13.720000,7.980000,-3.990000
04-23 19:43:59.189+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.189+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:195,2.482005,-0.543682,9.471771
04-23 19:43:59.189+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:190,2.682354,-0.263210,9.863215
04-23 19:43:59.209+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.209+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.219+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.219+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.219+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:219,-0.134646,0.402505,0.317266
04-23 19:43:59.219+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:224,2.430064,-0.503587,9.487443
04-23 19:43:59.219+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.229+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:217,8.960000,2.520000,-2.660000
04-23 19:43:59.229+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.229+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:232,0.376717,-0.367400,0.246560
04-23 19:43:59.229+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.229+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:224,2.347359,-0.141177,9.789038
04-23 19:43:59.239+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:239,2.397043,-0.494062,9.496340
04-23 19:43:59.239+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.239+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.239+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.249+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:235,12.180000,-0.700000,-1.820000
04-23 19:43:59.249+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:251,0.392988,-0.178321,-0.015976
04-23 19:43:59.249+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:246,2.806781,-0.870987,9.734003
04-23 19:43:59.249+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.259+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.259+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:262,2.790031,-0.672383,9.480364
04-23 19:43:59.259+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.269+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:252,2.356424,-0.473114,9.507566
04-23 19:43:59.269+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.269+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:270,0.256538,0.226653,-0.113344
04-23 19:43:59.269+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.269+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:265,14.280000,-1.750000,-0.490000
04-23 19:43:59.279+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:278,2.612962,-0.246461,9.394222
04-23 19:43:59.279+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.279+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:274,2.319908,-0.440463,9.518109
04-23 19:43:59.279+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.279+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.289+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:289,0.479695,0.146145,-0.083209
04-23 19:43:59.289+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:59.289+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:284,11.130000,-4.340000,0.700000
04-23 19:43:59.299+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:290,2.799603,-0.294317,9.434900
04-23 19:43:59.299+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:59:298,76
04-23 19:43:59.299+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.299+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.299+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:306,2.289794,-0.411570,9.526690
04-23 19:43:59.309+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.309+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.309+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:314,0.536129,0.401999,-0.321502
04-23 19:43:59.309+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.309+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:314,2.825923,-0.009571,9.205189
04-23 19:43:59.309+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:307,11.130000,-4.200000,0.210000
04-23 19:43:59.319+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.319+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:320,2.263742,-0.378087,9.534302
04-23 19:43:59.319+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.319+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.329+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:329,0.564574,0.208196,-0.472682
04-23 19:43:59.329+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.339+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:325,7.420000,-1.680000,0.770000
04-23 19:43:59.339+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:330,2.828316,-0.169890,9.061620
04-23 19:43:59.339+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:338,2.270124,-0.367318,9.533205
04-23 19:43:59.339+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.339+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.339+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.349+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:350,0.574943,-0.063390,-0.162911
04-23 19:43:59.349+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.349+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:352,2.845066,-0.430708,9.370294
04-23 19:43:59.359+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:357,0.840000,1.750000,1.540000
04-23 19:43:59.359+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:361,2.261546,-0.363928,9.535374
04-23 19:43:59.359+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.359+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.359+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.369+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:369,0.372952,0.117467,-0.095688
04-23 19:43:59.369+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.369+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:369,2.634498,-0.246461,9.439686
04-23 19:43:59.369+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:367,2.870000,7.000000,2.240000
04-23 19:43:59.369+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.379+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.379+0200 W/LOCATION(20566): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:43:59.389+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:375,2.207568,-0.340520,9.548879
04-23 19:43:59.389+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.389+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.389+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:390,0.228326,0.364448,0.144446
04-23 19:43:59.389+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:395,2.154071,-0.311099,9.562091
04-23 19:43:59.399+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:395,2.435893,0.023928,9.693325
04-23 19:43:59.399+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:382,7.770000,9.520000,1.050000
04-23 19:43:59.399+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.409+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.409+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.409+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:414,2.447858,-0.198604,9.619147
04-23 19:43:59.409+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.409+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:409,4.830000,7.980000,1.330000
04-23 19:43:59.409+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.409+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:418,2.150852,-0.307007,9.562947
04-23 19:43:59.409+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:419,-0.980000,4.900000,1.750000
04-23 19:43:59.409+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:414,0.293786,0.112495,0.057056
04-23 19:43:59.419+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.419+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.429+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.429+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:430,2.577070,-0.320638,9.588040
04-23 19:43:59.429+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.429+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:433,2.175227,-0.313762,9.557213
04-23 19:43:59.429+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:434,-2.870000,1.890000,2.030000
04-23 19:43:59.429+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:430,0.426218,-0.013631,0.025093
04-23 19:43:59.439+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.439+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.449+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.449+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.449+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:453,2.206561,-0.326666,9.549595
04-23 19:43:59.449+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:453,-1.330000,0.980000,2.380000
04-23 19:43:59.449+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:449,0.593268,-0.207874,0.026042
04-23 19:43:59.449+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:449,2.768496,-0.521635,9.583255
04-23 19:43:59.459+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.459+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.459+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.459+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.469+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:473,2.214658,-0.321139,9.547908
04-23 19:43:59.469+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:469,2.696711,-0.203390,9.456435
04-23 19:43:59.469+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:469,0.490150,0.123276,-0.093160
04-23 19:43:59.469+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:470,0.280000,0.140000,2.660000
04-23 19:43:59.479+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.479+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.489+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.489+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:490,0.517946,-0.049749,-0.117794
04-23 19:43:59.489+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:493,0.280000,-1.540000,1.190000
04-23 19:43:59.489+0200 I/heartrate(20311): capturing data from es.ugr.frailty.heartrate
04-23 19:43:59.489+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:490,2.732604,-0.370888,9.430114
04-23 19:43:59.489+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.489+0200 I/heartrate(20311): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:43:59:498,76
04-23 19:43:59.489+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:499,2.235863,-0.323708,9.542877
04-23 19:43:59.509+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.509+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.509+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.509+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.509+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:516,-1.680000,-1.330000,0.980000
04-23 19:43:59.509+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:514,0.405813,0.158603,-0.268296
04-23 19:43:59.509+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:514,2.641676,-0.165105,9.274581
04-23 19:43:59.509+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:517,2.258320,-0.320451,9.537698
04-23 19:43:59.519+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.519+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.519+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.529+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:530,0.400106,0.054848,0.057521
04-23 19:43:59.529+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.529+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:530,-5.880000,-2.590000,0.140000
04-23 19:43:59.529+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:531,2.658426,-0.265603,9.595219
04-23 19:43:59.529+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:535,2.311087,-0.330373,9.524711
04-23 19:43:59.539+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.539+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.539+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.549+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:549,0.328196,-0.196048,-0.092204
04-23 19:43:59.549+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.549+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:550,-5.320000,-0.770000,-0.420000
04-23 19:43:59.549+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:549,2.639283,-0.526421,9.432507
04-23 19:43:59.549+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:555,2.364603,-0.350766,9.510836
04-23 19:43:59.559+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.559+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.569+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:569,0.181360,-0.163690,-0.145328
04-23 19:43:59.569+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.569+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.569+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:577,2.429717,-0.376208,9.493436
04-23 19:43:59.569+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:570,-8.540000,-0.280000,-0.840000
04-23 19:43:59.579+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:573,2.545963,-0.514457,9.365508
04-23 19:43:59.579+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.579+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.589+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:589,0.202388,-0.054500,0.051534
04-23 19:43:59.589+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.589+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:593,2.632105,-0.430708,9.544970
04-23 19:43:59.589+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.589+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:597,2.457359,-0.386135,9.485920
04-23 19:43:59.599+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:591,-3.570000,0.350000,0.840000
04-23 19:43:59.609+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.609+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.609+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:614,0.174746,0.046354,-0.019914
04-23 19:43:59.609+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.609+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.619+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:615,-0.630000,0.350000,1.260000
04-23 19:43:59.619+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:621,2.465106,-0.385526,9.483934
04-23 19:43:59.619+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.619+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:618,2.632105,-0.339781,9.466006
04-23 19:43:59.619+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.619+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.629+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:630,0.303389,0.115137,0.027535
04-23 19:43:59.629+0200 I/gyroscope(20553): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:43:59:632,-1.400000,-0.490000,1.610000
04-23 19:43:59.629+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.639+0200 I/gravity (20582): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:43:59:642,2.482085,-0.383478,9.479588
04-23 19:43:59.639+0200 I/accelerometer(20540): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:43:59:638,2.768496,-0.270389,9.511470
04-23 19:43:59.639+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.639+0200 I/gravity (20582): capturing data from es.ugr.frailty.gravity
04-23 19:43:59.639+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:649,0.264875,-0.090301,-0.054259
04-23 19:43:59.649+0200 I/gyroscope(20553): capturing data from es.ugr.frailty.gyroscope
04-23 19:43:59.649+0200 I/accelerometer(20540): capturing data from es.ugr.frailty.accelerometer
04-23 19:43:59.659+0200 I/linearacceleration(20568): capturing data from es.ugr.frailty.linearacceleration
04-23 19:43:59.669+0200 I/linearacceleration(20568): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:43:59:670,0.294173,0.249928,-0.063425
04-23 19:43:59.679+0200 W/CRASH_MANAGER(20380): worker.c: worker_job(1205) > 11205666c6f63152450543
