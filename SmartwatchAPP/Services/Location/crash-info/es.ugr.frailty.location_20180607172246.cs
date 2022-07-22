S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20579
Date: 2018-06-07 17:22:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf766252d, r5   = 0xf7e6ff98
r6   = 0xffab99a0, r7   = 0xffab9850
r8   = 0xf7e6cc18, r9   = 0x00000000
r10  = 0xffab992c, fp   = 0xffab99a0
ip   = 0x00000001, sp   = 0xffab9828
lr   = 0xf7662539, pc   = 0xf76cb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10116 KB
Buffers:     11132 KB
Cached:      53680 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11656 KB
VmRSS:       11656 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20579 TID = 20579
20579 20590 

Maps Information
f452d000 f4d2c000 rw-p [stack:20590]
f4d33000 f4d35000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d3d000 f4d41000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d4a000 f4d4c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d54000 f4d57000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d66000 f4d6b000 r-xp /usr/lib/libsystem.so.0.0.0
f4d76000 f4d79000 r-xp /lib/libattr.so.1.1.0
f4d81000 f4d91000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d99000 f4da2000 r-xp /usr/lib/libedbus.so.1.7.99
f4daa000 f4dab000 r-xp /usr/lib/libresponse.so.0.2.96
f4db4000 f4db9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f665b000 f6761000 r-xp /usr/lib/libicuuc.so.57.1
f6777000 f68ff000 r-xp /usr/lib/libicui18n.so.57.1
f690f000 f691c000 r-xp /usr/lib/libail.so.0.1.0
f6925000 f692c000 r-xp /usr/lib/libminizip.so.1.0.0
f6935000 f6ade000 r-xp /usr/lib/libcrypto.so.1.0.0
f6afe000 f6b45000 r-xp /usr/lib/libssl.so.1.0.0
f6b51000 f6b53000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b5b000 f6b62000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b6b000 f6b72000 r-xp /lib/libcrypt-2.13.so
f6ba3000 f6ba6000 r-xp /lib/libcap.so.2.21
f6bae000 f6bb0000 r-xp /usr/lib/libiri.so
f6bb8000 f6c01000 r-xp /usr/lib/libmdm.so.1.2.69
f6c09000 f6c0f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c17000 f6c3a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c44000 f6c46000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c4e000 f6c6b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c74000 f6c78000 r-xp /usr/lib/libsmack.so.1.0.0
f6c81000 f6c9a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6ca3000 f6cab000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cb3000 f6cb9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cc2000 f6cc4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ccd000 f6cdd000 r-xp /lib/libresolv-2.13.so
f6ce1000 f6cf9000 r-xp /usr/lib/liblzma.so.5.0.3
f6d02000 f6d04000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d0c000 f6d26000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d2e000 f6d5d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d66000 f6d75000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d7f000 f6d89000 r-xp /usr/lib/libsensord-shared.so
f6d92000 f6e65000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e70000 f6e86000 r-xp /lib/libz.so.1.2.5
f6e8e000 f6e93000 r-xp /usr/lib/libffi.so.5.0.10
f6e9b000 f6e9c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ea4000 f6eb4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ebc000 f6ed5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6edd000 f6edf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ee7000 f6f5c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f66000 f6f6c000 r-xp /lib/librt-2.13.so
f6f75000 f6f93000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f9d000 f6f9e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fa6000 f6fc9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fd1000 f6fd6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fde000 f7008000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7011000 f7028000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7030000 f7099000 r-xp /lib/libm-2.13.so
f70a2000 f7136000 r-xp /usr/lib/libstdc++.so.6.0.16
f7149000 f714e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7156000 f715d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7165000 f718f000 r-xp /usr/lib/libsensor.so.1.9.6
f7198000 f7264000 r-xp /usr/lib/libxml2.so.2.7.8
f7271000 f7273000 r-xp /usr/lib/libiniparser.so.0
f727c000 f7282000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f728b000 f735b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f735c000 f7390000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7399000 f73d5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73dd000 f73e0000 r-xp /usr/lib/libbundle.so.0.1.22
f73e8000 f73ee000 r-xp /usr/lib/libappsvc.so.0.1.0
f73f6000 f7437000 r-xp /usr/lib/libeina.so.1.7.99
f7440000 f7457000 r-xp /usr/lib/libecore.so.1.7.99
f746e000 f7477000 r-xp /usr/lib/libvconf.so.0.2.45
f747f000 f7493000 r-xp /lib/libpthread-2.13.so
f749e000 f74ab000 r-xp /usr/lib/libaul.so.0.1.0
f74b5000 f74b7000 r-xp /lib/libdl-2.13.so
f74c0000 f74cb000 r-xp /lib/libunwind.so.8.0.1
f74f8000 f7500000 r-xp /lib/libgcc_s-4.6.so.1
f7501000 f7625000 r-xp /lib/libc-2.13.so
f7633000 f7635000 r-xp /usr/lib/libdlog.so.0.0.0
f763d000 f7649000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7652000 f7657000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f765f000 f766e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7676000 f767a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7683000 f7686000 r-xp /usr/lib/libappcore-agent.so.1.1
f768e000 f7690000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7698000 f769c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76a4000 f76c1000 r-xp /lib/ld-2.13.so
f76ca000 f76cd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76cd000 f76d1000 r-xp /usr/lib/libsys-assert.so
f7e3c000 f7ead000 rw-p [heap]
ffa9b000 ffabc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20579)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76cb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7662539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73693f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7367c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7373e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7379be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7379dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73ae75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73a91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7367c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7373e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7379be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7379dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73abe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73ac017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73b3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d4b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d3e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e11663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72befcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72c07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7450ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf744bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf744c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf744c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7684183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76847fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76cb5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf751885c) [/lib/libc.so.6] + 0x1785c
29: (0xf76caf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.331+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:11.321+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:298,0.014049,-0.014224,0.085955
06-07 17:25:11.331+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:11.341+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:320,0.277567,-0.107677,9.839286
06-07 17:25:11.341+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.351+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:339,0.070000,0.070000,0.070000
06-07 17:25:11.351+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.351+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:321,0.314155,-0.090952,9.801195
06-07 17:25:11.361+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.361+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.371+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:353,0.034328,0.021789,0.016527
06-07 17:25:11.381+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.391+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:365,0.260818,-0.076570,9.812965
06-07 17:25:11.391+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:371,0.312437,-0.091233,9.801247
06-07 17:25:11.401+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.401+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:378,0.070000,0.070000,0.070000
06-07 17:25:11.401+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.411+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.411+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:11.421+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21012) cmd(0)
06-07 17:25:11.421+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:11:428,665.000000
06-07 17:25:11.431+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:398,0.012581,0.027017,0.064396
06-07 17:25:11.441+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:415,0.299103,-0.107677,9.891929
06-07 17:25:11.451+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.461+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:462,0.040678,-0.017559,0.050043
06-07 17:25:11.471+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:419,0.312743,-0.089572,9.801252
06-07 17:25:11.471+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.481+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.481+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:444,0.140000,-0.070000,0.140000
06-07 17:25:11.481+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.491+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.501+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:488,0.325424,-0.114855,9.887143
06-07 17:25:11.511+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:494,0.312766,-0.090076,9.801248
06-07 17:25:11.511+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:495,0.140000,-0.070000,0.070000
06-07 17:25:11.521+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.521+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:11.521+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:11.521+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.531+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.541+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:507,0.023869,-0.014181,0.026101
06-07 17:25:11.541+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.551+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:542,0.344566,-0.078963,9.817751
06-07 17:25:11.561+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:546,0.140000,-0.070000,0.070000
06-07 17:25:11.561+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.561+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:558,-0.006326,0.082222,0.042906
06-07 17:25:11.581+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.581+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:550,0.313344,-0.091133,9.801219
06-07 17:25:11.581+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.591+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.601+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:590,0.323031,-0.074178,9.865608
06-07 17:25:11.611+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:592,0.314110,-0.091490,9.801191
06-07 17:25:11.611+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:11.621+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:11:623,656.000000
06-07 17:25:11.631+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:592,0.070000,-0.070000,0.070000
06-07 17:25:11.631+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.631+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21036) cmd(0)
06-07 17:25:11.641+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.651+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.651+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21049) cmd(0)
06-07 17:25:11.661+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:612,-0.006970,0.008492,0.035751
06-07 17:25:11.661+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.681+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:656,0.351745,-0.117248,9.851252
06-07 17:25:11.681+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:660,0.312499,-0.093707,9.801222
06-07 17:25:11.691+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:660,0.070000,-0.070000,0.070000
06-07 17:25:11.691+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.691+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.691+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.701+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:706,0.334995,-0.112463,9.827322
06-07 17:25:11.711+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:680,0.027289,0.004132,0.050043
06-07 17:25:11.711+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.721+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:11.721+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:11.721+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:717,0.070000,-0.070000,0.070000
06-07 17:25:11.731+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:718,0.310970,-0.094531,9.801263
06-07 17:25:11.731+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.741+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:729,-0.029882,0.018407,0.064390
06-07 17:25:11.741+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.761+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.761+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.781+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:756,0.306281,-0.016750,9.844072
06-07 17:25:11.781+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.781+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:769,0.070000,-0.070000,0.070000
06-07 17:25:11.781+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:767,0.311377,-0.093371,9.801261
06-07 17:25:11.791+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.791+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.801+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:781,-0.021893,-0.015118,0.035726
06-07 17:25:11.811+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.821+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:11.821+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:11:827,656.000000
06-07 17:25:11.831+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:800,0.306281,-0.090927,9.836893
06-07 17:25:11.841+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.841+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:810,0.312052,-0.094289,9.801230
06-07 17:25:11.841+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:840,0.010347,0.022429,0.018933
06-07 17:25:11.851+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:814,0.140000,-0.070000,0.070000
06-07 17:25:11.851+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.851+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.871+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.871+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:869,0.312816,-0.094910,9.801200
06-07 17:25:11.881+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:860,0.339781,-0.090927,9.851252
06-07 17:25:11.881+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:887,0.054121,0.009003,0.030884
06-07 17:25:11.891+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:875,0.070000,-0.070000,0.070000
06-07 17:25:11.891+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.891+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.901+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:905,0.282353,-0.076570,9.865608
06-07 17:25:11.901+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.901+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:910,0.311673,-0.093489,9.801250
06-07 17:25:11.921+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.921+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:11.921+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:11.921+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:928,0.015261,-0.018300,0.071571
06-07 17:25:11.931+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.931+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.931+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:915,0.070000,0.070000,0.070000
06-07 17:25:11.951+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:940,0.291924,-0.110070,9.836893
06-07 17:25:11.951+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.971+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:11.971+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:960,0.312530,-0.093526,9.801223
06-07 17:25:11.971+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:11:964,0.140000,-0.070000,0.070000
06-07 17:25:11.981+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:11.981+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:11.981+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:11.981+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:11:979,0.023163,-0.002223,0.042904
06-07 17:25:12.001+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.011+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:11:999,0.313834,-0.093395,9.801182
06-07 17:25:12.011+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:12.021+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:12:23,649.000000
06-07 17:25:12.041+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:25:12.041+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:25:12.041+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:25:12.051+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:21,-0.003059,-0.004086,0.023763
06-07 17:25:12.061+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:11:995,0.323031,-0.071785,9.820145
06-07 17:25:12.061+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.071+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:0,0.070000,-0.070000,0.070000
06-07 17:25:12.071+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.081+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.091+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.101+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:91,0.314768,-0.094233,9.801144
06-07 17:25:12.111+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:93,0.070000,-0.070000,0.070000
06-07 17:25:12.111+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:85,0.366102,-0.086142,9.832108
06-07 17:25:12.111+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.121+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.121+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:12.121+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:12.131+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:135,0.327817,-0.112463,9.872787
06-07 17:25:12.141+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.141+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:146,0.316167,-0.094578,9.801096
06-07 17:25:12.141+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:151,-0.070000,-0.070000,0.070000
06-07 17:25:12.151+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:109,0.003006,-0.003888,0.064479
06-07 17:25:12.151+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.161+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.161+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.161+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.161+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:162,0.005747,0.010517,0.016611
06-07 17:25:12.191+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:183,0.318637,-0.093497,9.801026
06-07 17:25:12.201+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.201+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:180,0.337388,-0.095713,9.844072
06-07 17:25:12.211+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:12.221+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:12:224,655.000000
06-07 17:25:12.221+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.221+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.231+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:190,-0.070000,-0.070000,0.140000
06-07 17:25:12.231+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.241+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:208,0.015671,0.008104,0.021386
06-07 17:25:12.241+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:247,0.311067,-0.098106,9.824929
06-07 17:25:12.261+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.271+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:239,0.319120,-0.094166,9.801004
06-07 17:25:12.271+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.271+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:254,-0.070000,-0.070000,0.070000
06-07 17:25:12.281+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:275,-0.015278,0.007426,0.045302
06-07 17:25:12.281+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.291+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.301+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:305,0.320455,-0.094935,9.800953
06-07 17:25:12.301+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.311+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:302,0.318245,-0.098106,9.865608
06-07 17:25:12.311+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.321+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:12.321+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:12.321+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:309,0.140000,0.070000,0.070000
06-07 17:25:12.331+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.331+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.341+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:338,0.320402,-0.095206,9.800952
06-07 17:25:12.341+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:315,0.005981,0.004505,0.040521
06-07 17:25:12.341+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.351+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:343,0.320638,-0.083749,9.817751
06-07 17:25:12.361+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:358,-0.002374,-0.034302,0.009371
06-07 17:25:12.361+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.361+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.371+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:371,0.319655,-0.094646,9.800982
06-07 17:25:12.381+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.381+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:379,0.330210,-0.086142,9.822537
06-07 17:25:12.391+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:336,0.140000,0.070000,0.070000
06-07 17:25:12.401+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.401+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.411+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.411+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:392,0.004950,-0.022716,0.045254
06-07 17:25:12.411+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:12.421+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:12:426,655.000000
06-07 17:25:12.431+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:406,0.318522,-0.093220,9.801032
06-07 17:25:12.441+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.441+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:419,0.210000,0.070000,0.070000
06-07 17:25:12.451+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:25:12.461+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:25:12.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:12.461+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:12.471+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21012
06-07 17:25:12.481+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21012)
06-07 17:25:12.481+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer launch request sent!
06-07 17:25:12.481+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:12.481+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:25:12.481+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:25:12.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:12.481+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:12.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21017
06-07 17:25:12.501+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21017)
06-07 17:25:12.511+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope launch request sent!
06-07 17:25:12.511+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:12.511+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:25:12.511+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:25:12.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:12.511+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:12.521+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21023
06-07 17:25:12.531+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:12.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(21023), cmd(0)
06-07 17:25:12.541+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21023)
06-07 17:25:12.541+0200 I/servicemanager(20992): es.ugr.frailty.heartrate launch request sent!
06-07 17:25:12.541+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:12.541+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:25:12.541+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:25:12.541+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:12.541+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:12.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21308
06-07 17:25:12.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:12.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(21308), cmd(0)
06-07 17:25:12.561+0200 W/CAPI_APPFW_APP_CONTROL(21308): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:12.561+0200 I/utils   (21308): specific action
06-07 17:25:12.561+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21308)
06-07 17:25:12.561+0200 I/servicemanager(20992): es.ugr.frailty.location launch request sent!
06-07 17:25:12.561+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:12.561+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:25:12.571+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:25:12.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:12.571+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:12.581+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21036
06-07 17:25:12.591+0200 W/CAPI_APPFW_APP_CONTROL(21023): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:12.591+0200 I/utils   (21023): specific action
06-07 17:25:12.591+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:12.591+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21036)
06-07 17:25:12.591+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:25:12.591+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:12.591+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:25:12.591+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:25:12.591+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:12.601+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:12.601+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:12.601+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:451,0.002526,0.014942,0.050058
06-07 17:25:12.611+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21049
06-07 17:25:12.611+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:418,0.299103,-0.086142,9.846465
06-07 17:25:12.611+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:12.621+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21049)
06-07 17:25:12.621+0200 I/servicemanager(20992): es.ugr.frailty.gravity launch request sent!
06-07 17:25:12.621+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:12.621+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:25:12.621+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:25:12.621+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.621+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:12:623,654.000000
06-07 17:25:12.621+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:12.621+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:12.631+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21054
06-07 17:25:12.641+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:12.641+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(21054), cmd(0)
06-07 17:25:12.641+0200 W/CAPI_APPFW_APP_CONTROL(21054): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:12.641+0200 I/utils   (21054): specific action
06-07 17:25:12.651+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21054)
06-07 17:25:12.651+0200 I/servicemanager(20992): es.ugr.frailty.pressure launch request sent!
06-07 17:25:12.651+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:12.651+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:25:12.651+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:25:12.651+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:12.651+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:12.661+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21071
06-07 17:25:12.671+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:12.671+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(21071), cmd(0)
06-07 17:25:12.681+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21071)
06-07 17:25:12.681+0200 I/servicemanager(20992): es.ugr.frailty.light launch request sent!
06-07 17:25:12.681+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:12.681+0200 W/CAPI_APPFW_APP_CONTROL(21071): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:12.681+0200 I/utils   (21071): specific action
06-07 17:25:12.691+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:25:12.691+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:25:12.691+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:25:12.691+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:25:12.701+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21084
06-07 17:25:12.711+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:25:12.711+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(21084), cmd(0)
06-07 17:25:12.711+0200 W/CAPI_APPFW_APP_CONTROL(21084): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:25:12.711+0200 I/utils   (21084): specific action
06-07 17:25:12.721+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21084)
06-07 17:25:12.721+0200 I/servicemanager(20992): es.ugr.frailty.pedometer launch request sent!
06-07 17:25:12.721+0200 I/servicemanager(20992): App control destroyed.
06-07 17:25:12.721+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:12.721+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:12.751+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.771+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:761,0.317670,-0.092910,9.801064
06-07 17:25:12.771+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.801+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:807,0.028570,-0.003100,0.040505
06-07 17:25:12.801+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.801+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:697,0.320638,-0.088534,9.841680
06-07 17:25:12.811+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:815,0.070000,0.070000,0.070000
06-07 17:25:12.811+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:12.821+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:12:825,653.000000
06-07 17:25:12.831+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.831+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.831+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.841+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:844,0.019374,-0.042345,0.054841
06-07 17:25:12.861+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:780,0.316705,-0.092520,9.801098
06-07 17:25:12.861+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:853,0.311067,-0.126820,9.810574
06-07 17:25:12.861+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.861+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.871+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:876,0.315108,-0.094013,9.801135
06-07 17:25:12.871+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.871+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:862,0.070000,0.070000,0.070000
06-07 17:25:12.881+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.901+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:899,0.070000,0.070000,0.070000
06-07 17:25:12.901+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:890,-0.019535,-0.004205,0.052466
06-07 17:25:12.901+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.911+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.911+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:895,0.318245,-0.114855,9.846465
06-07 17:25:12.921+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.921+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:12.921+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:12.921+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.941+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:945,0.070000,0.070000,0.070000
06-07 17:25:12.951+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:940,0.315853,-0.078963,9.851252
06-07 17:25:12.951+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:918,0.317128,-0.096881,9.801043
06-07 17:25:12.951+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:12.951+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:935,-0.012662,-0.000193,0.030957
06-07 17:25:12.961+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:12.971+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:12.971+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:12:977,-0.035140,-0.009830,0.047660
06-07 17:25:12.981+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:12.991+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:12:970,0.318119,-0.098912,9.800990
06-07 17:25:12.991+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:12:990,0.342174,-0.098106,9.841680
06-07 17:25:13.001+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.001+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.021+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:25:13.021+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:25:13.021+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:25:13.021+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:13.051+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:13:40,652.000000
06-07 17:25:13.051+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:12:992,0.140000,0.070000,0.070000
06-07 17:25:13.051+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.051+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.071+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:75,0.140000,-0.070000,0.070000
06-07 17:25:13.071+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:9,0.319723,-0.098929,9.800938
06-07 17:25:13.071+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.081+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:63,-0.017893,-0.007305,0.038074
06-07 17:25:13.081+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:73,0.332602,-0.136391,9.856036
06-07 17:25:13.091+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.091+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.101+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.101+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:106,0.140000,0.070000,0.070000
06-07 17:25:13.111+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:89,0.320673,-0.100201,9.800894
06-07 17:25:13.111+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:97,-0.010649,-0.007159,-0.017037
06-07 17:25:13.121+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:13.121+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:13.121+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:113,0.294317,-0.098106,9.853643
06-07 17:25:13.121+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.131+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.131+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.131+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.141+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:145,0.009949,-0.031082,0.025987
06-07 17:25:13.151+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:133,0.319228,-0.101384,9.800928
06-07 17:25:13.151+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:143,0.140000,0.070000,0.070000
06-07 17:25:13.161+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.161+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:153,0.301496,-0.095713,9.832108
06-07 17:25:13.171+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.171+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.171+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.191+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:195,0.070000,0.070000,0.070000
06-07 17:25:13.201+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:184,0.015554,-0.002188,0.028356
06-07 17:25:13.201+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:209,0.277567,-0.105284,9.848858
06-07 17:25:13.211+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:173,0.316340,-0.101881,9.801017
06-07 17:25:13.211+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.211+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.211+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.211+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:13.221+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:13:227,652.000000
06-07 17:25:13.231+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.231+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:217,0.313927,-0.101996,9.801093
06-07 17:25:13.251+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.261+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:245,-0.070000,0.070000,0.070000
06-07 17:25:13.261+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:243,0.000732,0.008693,0.052312
06-07 17:25:13.271+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.271+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:247,0.294317,-0.102891,9.839286
06-07 17:25:13.271+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.271+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.281+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:285,-0.070000,0.070000,0.070000
06-07 17:25:13.291+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:270,0.311374,-0.100631,9.801188
06-07 17:25:13.311+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:294,-0.002227,-0.000973,0.009259
06-07 17:25:13.321+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.321+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:326,0.310239,-0.100752,9.801224
06-07 17:25:13.321+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:13.321+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:13.321+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.321+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.321+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:297,0.299103,-0.102891,9.784252
06-07 17:25:13.331+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:335,-0.070000,-0.070000,0.070000
06-07 17:25:13.341+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.341+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:346,0.318245,-0.126820,9.827322
06-07 17:25:13.351+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.351+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:343,-0.004453,-0.032640,0.006854
06-07 17:25:13.351+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.361+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.361+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.371+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:358,0.310450,-0.101195,9.801212
06-07 17:25:13.381+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:385,0.323031,-0.098106,9.829715
06-07 17:25:13.381+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:374,0.070000,0.070000,0.070000
06-07 17:25:13.381+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.391+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:375,-0.009030,-0.039875,0.030776
06-07 17:25:13.391+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.401+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.401+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.481+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:13.481+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:13:485,652.000000
06-07 17:25:13.521+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:13.521+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:13.541+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:393,0.311067,-0.099690,9.801208
06-07 17:25:13.551+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.571+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:409,0.070000,0.070000,0.070000
06-07 17:25:13.571+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:554,0.308674,-0.088534,9.853643
06-07 17:25:13.581+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:544,0.012751,0.018975,0.045138
06-07 17:25:13.581+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.591+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.601+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:25:13:587,0.311126,-0.098281,9.801221
06-07 17:25:13.611+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.611+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:25:13.621+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:25:13:625,651.000000
06-07 17:25:13.631+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:605,0.070000,0.070000,0.070000
06-07 17:25:13.631+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:25:13.651+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:25:13:615,-0.022344,-0.027246,0.052308
06-07 17:25:13.651+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:25:13:634,0.306281,-0.098106,9.810574
06-07 17:25:13.661+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:25:13.681+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:25:13.681+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:25:13:680,0.070000,0.070000,0.070000
06-07 17:25:13.691+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:25:13.741+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:25:13.741+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:25:13.791+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11205796c6f63152838496
