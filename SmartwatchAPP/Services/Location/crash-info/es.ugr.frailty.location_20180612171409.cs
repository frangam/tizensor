S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16440
Date: 2018-06-12 17:14:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72b052d, r5   = 0xf7a65fe0
r6   = 0xff9df4d0, r7   = 0xff9df380
r8   = 0xf7a37c18, r9   = 0x00000000
r10  = 0xff9df45c, fp   = 0xff9df4d0
ip   = 0x00000001, sp   = 0xff9df358
lr   = 0xf72b0539, pc   = 0xf7319228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    129536 KB
Buffers:     43020 KB
Cached:     169308 KB
VmPeak:      53444 KB
VmSize:      53420 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11944 KB
VmRSS:       11944 KB
VmData:      11148 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16440 TID = 16440
16440 16458 

Maps Information
f417b000 f497a000 rw-p [stack:16458]
f4981000 f4983000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f498b000 f498f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4998000 f499a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49a2000 f49a5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49b4000 f49b9000 r-xp /usr/lib/libsystem.so.0.0.0
f49c4000 f49c7000 r-xp /lib/libattr.so.1.1.0
f49cf000 f49df000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49e7000 f49f0000 r-xp /usr/lib/libedbus.so.1.7.99
f49f8000 f49f9000 r-xp /usr/lib/libresponse.so.0.2.96
f4a02000 f4a07000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62a9000 f63af000 r-xp /usr/lib/libicuuc.so.57.1
f63c5000 f654d000 r-xp /usr/lib/libicui18n.so.57.1
f655d000 f656a000 r-xp /usr/lib/libail.so.0.1.0
f6573000 f657a000 r-xp /usr/lib/libminizip.so.1.0.0
f6583000 f672c000 r-xp /usr/lib/libcrypto.so.1.0.0
f674c000 f6793000 r-xp /usr/lib/libssl.so.1.0.0
f679f000 f67a1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67a9000 f67b0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67b9000 f67c0000 r-xp /lib/libcrypt-2.13.so
f67f1000 f67f4000 r-xp /lib/libcap.so.2.21
f67fc000 f67fe000 r-xp /usr/lib/libiri.so
f6806000 f684f000 r-xp /usr/lib/libmdm.so.1.2.69
f6857000 f685d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6865000 f6888000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6892000 f6894000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f689c000 f68b9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68c2000 f68c6000 r-xp /usr/lib/libsmack.so.1.0.0
f68cf000 f68e8000 r-xp /usr/lib/libnetwork.so.0.0.0
f68f1000 f68f9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6901000 f6907000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6910000 f6912000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f691b000 f692b000 r-xp /lib/libresolv-2.13.so
f692f000 f6947000 r-xp /usr/lib/liblzma.so.5.0.3
f6950000 f6952000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f695a000 f6974000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f697c000 f69ab000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69b4000 f69c3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69cd000 f69d7000 r-xp /usr/lib/libsensord-shared.so
f69e0000 f6ab3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6abe000 f6ad4000 r-xp /lib/libz.so.1.2.5
f6adc000 f6ae1000 r-xp /usr/lib/libffi.so.5.0.10
f6ae9000 f6aea000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6af2000 f6b02000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b0a000 f6b23000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b2b000 f6b2d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b35000 f6baa000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bb4000 f6bba000 r-xp /lib/librt-2.13.so
f6bc3000 f6be1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6beb000 f6bec000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bf4000 f6c17000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c1f000 f6c24000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c2c000 f6c56000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c5f000 f6c76000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c7e000 f6ce7000 r-xp /lib/libm-2.13.so
f6cf0000 f6d84000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d97000 f6d9c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6da4000 f6dab000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6db3000 f6ddd000 r-xp /usr/lib/libsensor.so.1.9.6
f6de6000 f6eb2000 r-xp /usr/lib/libxml2.so.2.7.8
f6ebf000 f6ec1000 r-xp /usr/lib/libiniparser.so.0
f6eca000 f6ed0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ed9000 f6fa9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6faa000 f6fde000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fe7000 f7023000 r-xp /usr/lib/libSLP-location.so.0.9.24
f702b000 f702e000 r-xp /usr/lib/libbundle.so.0.1.22
f7036000 f703c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7044000 f7085000 r-xp /usr/lib/libeina.so.1.7.99
f708e000 f70a5000 r-xp /usr/lib/libecore.so.1.7.99
f70bc000 f70c5000 r-xp /usr/lib/libvconf.so.0.2.45
f70cd000 f70e1000 r-xp /lib/libpthread-2.13.so
f70ec000 f70f9000 r-xp /usr/lib/libaul.so.0.1.0
f7103000 f7105000 r-xp /lib/libdl-2.13.so
f710e000 f7119000 r-xp /lib/libunwind.so.8.0.1
f7146000 f714e000 r-xp /lib/libgcc_s-4.6.so.1
f714f000 f7273000 r-xp /lib/libc-2.13.so
f7281000 f7283000 r-xp /usr/lib/libdlog.so.0.0.0
f728b000 f7297000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72a0000 f72a5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72ad000 f72bc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72c4000 f72c8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72d1000 f72d4000 r-xp /usr/lib/libappcore-agent.so.1.1
f72dc000 f72de000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72e6000 f72ea000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72f2000 f730f000 r-xp /lib/ld-2.13.so
f7318000 f731b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f731b000 f731f000 r-xp /usr/lib/libsys-assert.so
f7a31000 f7a99000 rw-p [heap]
ff9c0000 ff9e1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16440)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7319228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72b0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fb73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fb5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fc1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fc7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fc7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ffc75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ff71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fb5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fc1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fc7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fc7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ff9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ffa017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7001f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49991fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf498c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a5f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f0cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f0e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf709eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7099b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf709a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf709a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72d2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72d27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73195c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf716685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7318f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
railty.gyroscope: SM-R760,12/06/2018,17:14:08:323,-0.070000,0.070000,-0.070000
06-12 17:14:08.311+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.311+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:320,-0.078412,9.766890,0.878693
06-12 17:14:08.321+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.321+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:324,-0.100499,9.784252,0.863809
06-12 17:14:08.321+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:327,-0.070000,0.070000,-0.070000
06-12 17:14:08.321+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.321+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:330,-0.079320,9.767038,0.876958
06-12 17:14:08.321+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:331,-0.070000,0.070000,0.070000
06-12 17:14:08.331+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.331+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.331+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:340,-0.117248,9.769895,0.887737
06-12 17:14:08.331+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:339,-0.037928,0.002856,0.010779
06-12 17:14:08.331+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.331+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.331+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:344,-0.070000,0.070000,0.070000
06-12 17:14:08.341+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:344,-0.080971,9.767052,0.876653
06-12 17:14:08.351+0200 I/light   (16478): es.ugr.frailty.light - capturing data
06-12 17:14:08.351+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.351+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.351+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:362,-0.093320,9.786645,0.937986
06-12 17:14:08.351+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:362,-0.012349,0.019593,0.061333
06-12 17:14:08.351+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.361+0200 I/light   (16478): es.ugr.frailty.light: SM-R760,12/06/2018,17:14:08:361,76.000000
06-12 17:14:08.361+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.361+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:366,-0.081368,9.766865,0.878697
06-12 17:14:08.361+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:371,0.070000,-0.140000,0.070000
06-12 17:14:08.371+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.371+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.371+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:379,0.071797,0.048493,-0.057959
06-12 17:14:08.371+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.371+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.371+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:384,0.070000,0.070000,0.070000
06-12 17:14:08.371+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:380,-0.009571,9.815358,0.820738
06-12 17:14:08.381+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:384,-0.077726,9.767154,0.875813
06-12 17:14:08.391+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 17:14:08.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 17:14:08.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 17:14:08.391+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 17:14:08.391+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.391+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.391+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:404,0.046620,0.064955,0.002353
06-12 17:14:08.391+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:404,-0.031107,9.832108,0.878166
06-12 17:14:08.391+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.401+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:402,-0.070000,0.210000,0.070000
06-12 17:14:08.401+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:408,-0.075373,9.767255,0.874894
06-12 17:14:08.411+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.411+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.411+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.411+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.411+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:419,-0.070000,0.140000,-0.070000
06-12 17:14:08.411+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:420,0.010767,0.038532,-0.006299
06-12 17:14:08.421+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:425,-0.075019,9.767216,0.875357
06-12 17:14:08.421+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:425,-0.064606,9.805787,0.868595
06-12 17:14:08.431+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.431+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.441+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.441+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:444,-0.015909,0.033786,-0.061798
06-12 17:14:08.441+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:449,-0.075958,9.767437,0.872807
06-12 17:14:08.441+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.451+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.451+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.451+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:462,-0.031720,0.004850,-0.013784
06-12 17:14:08.461+0200 I/heartrate(16428): es.ugr.frailty.heartrate - capturing data
06-12 17:14:08.461+0200 I/heartrate(16428): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:14:08.461+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:449,-0.070000,0.140000,-0.070000
06-12 17:14:08.461+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.461+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:473,-0.077640,9.767423,0.872815
06-12 17:14:08.461+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:474,-0.070000,0.140000,-0.070000
06-12 17:14:08.471+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.471+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.471+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:479,-0.070000,0.140000,-0.070000
06-12 17:14:08.471+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.481+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:480,-0.051572,0.012044,0.022101
06-12 17:14:08.481+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:484,-0.080231,9.767230,0.874742
06-12 17:14:08.481+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:458,-0.090927,9.801002,0.813560
06-12 17:14:08.481+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.481+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:491,-0.107677,9.772287,0.859023
06-12 17:14:08.481+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.491+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.491+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.491+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:500,-0.210000,0.350000,-0.140000
06-12 17:14:08.491+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:500,0.034768,0.017022,0.003424
06-12 17:14:08.491+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.491+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:495,-0.129212,9.779467,0.894916
06-12 17:14:08.491+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.501+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:504,-0.078932,9.767065,0.876693
06-12 17:14:08.501+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:507,-0.045464,9.784252,0.878166
06-12 17:14:08.511+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.511+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.511+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:519,-0.070000,0.140000,-0.140000
06-12 17:14:08.511+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:519,0.023897,0.045900,-0.005705
06-12 17:14:08.511+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.511+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.511+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:524,-0.078102,9.766949,0.878062
06-12 17:14:08.511+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:524,-0.055035,9.812965,0.870987
06-12 17:14:08.531+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.531+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.531+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:541,-0.070000,0.140000,-0.140000
06-12 17:14:08.531+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.531+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:541,-0.012825,-0.028160,-0.057324
06-12 17:14:08.531+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.541+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:545,-0.079065,9.767049,0.876868
06-12 17:14:08.541+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:547,-0.090927,9.738789,0.820738
06-12 17:14:08.551+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.561+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.561+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.561+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:565,0.014459,0.012418,-0.017845
06-12 17:14:08.571+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:576,-0.078693,9.766971,0.877764
06-12 17:14:08.571+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.591+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:573,-0.064606,9.779467,0.859023
06-12 17:14:08.591+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:587,0.097836,-0.009041,-0.011562
06-12 17:14:08.601+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.601+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.601+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.611+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:618,0.019143,9.757930,0.866202
06-12 17:14:08.621+0200 I/light   (16478): es.ugr.frailty.light - capturing data
06-12 17:14:08.621+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.631+0200 I/light   (16478): es.ugr.frailty.light: SM-R760,12/06/2018,17:14:08:630,76.000000
06-12 17:14:08.631+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:635,-0.070000,0.140000,-0.140000
06-12 17:14:08.631+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:620,-0.028694,0.055633,0.047134
06-12 17:14:08.641+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:611,-0.074198,9.766905,0.878888
06-12 17:14:08.641+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.641+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.641+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.651+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.661+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:659,-0.070000,0.140000,-0.070000
06-12 17:14:08.661+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:667,-0.024816,0.043945,0.001116
06-12 17:14:08.661+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:663,-0.102891,9.822537,0.926022
06-12 17:14:08.661+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:651,-0.075683,9.766628,0.881836
06-12 17:14:08.661+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.661+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.671+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.671+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:681,-0.077009,9.766542,0.882666
06-12 17:14:08.681+0200 I/heartrate(16428): es.ugr.frailty.heartrate - capturing data
06-12 17:14:08.681+0200 I/heartrate(16428): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:14:08.681+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.681+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:690,-0.100499,9.810574,0.882952
06-12 17:14:08.691+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:686,-0.070000,0.140000,-0.070000
06-12 17:14:08.691+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.691+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.691+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.701+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:694,0.048295,0.008138,-0.033214
06-12 17:14:08.701+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.701+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:710,-0.140000,0.070000,-0.070000
06-12 17:14:08.701+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:714,-0.028714,9.774680,0.849452
06-12 17:14:08.711+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.711+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:705,-0.074866,9.766558,0.882678
06-12 17:14:08.711+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:720,0.053330,0.029658,-0.016477
06-12 17:14:08.711+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.711+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.721+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:725,-0.140000,0.140000,-0.070000
06-12 17:14:08.721+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.721+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:730,0.070000,0.140000,-0.070000
06-12 17:14:08.721+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.721+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.731+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:735,-0.070000,0.070000,-0.070000
06-12 17:14:08.731+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.731+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:739,-0.070000,0.140000,-0.070000
06-12 17:14:08.731+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.731+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:730,-0.021535,9.796216,0.866202
06-12 17:14:08.731+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:729,-0.072473,9.766556,0.882907
06-12 17:14:08.731+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:735,-0.028026,0.055982,0.028759
06-12 17:14:08.741+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:744,-0.070000,0.070000,-0.070000
06-12 17:14:08.741+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.741+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.741+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.741+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.741+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:749,-0.070000,0.070000,-0.070000
06-12 17:14:08.741+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:754,-0.067251,0.077716,0.009926
06-12 17:14:08.741+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.751+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.751+0200 I/light   (16478): es.ugr.frailty.light - capturing data
06-12 17:14:08.751+0200 I/light   (16478): es.ugr.frailty.light: SM-R760,12/06/2018,17:14:08:762,75.000000
06-12 17:14:08.751+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:751,-0.100499,9.822537,0.911665
06-12 17:14:08.751+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:754,-0.073926,9.766356,0.884990
06-12 17:14:08.761+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 17:14:08.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 17:14:08.761+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 17:14:08.761+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:758,-0.099849,0.051490,0.037868
06-12 17:14:08.761+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.761+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:761,-0.140000,0.070000,-0.070000
06-12 17:14:08.761+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.761+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:773,-0.047211,0.054175,0.037479
06-12 17:14:08.761+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.761+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.771+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.771+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:777,0.000594,0.008957,-0.039180
06-12 17:14:08.771+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.771+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:782,0.072522,0.020840,-0.038267
06-12 17:14:08.771+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:780,-0.210000,0.280000,-0.070000
06-12 17:14:08.781+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:778,-0.077220,9.766261,0.885761
06-12 17:14:08.781+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.781+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:786,-0.141177,9.844072,0.894916
06-12 17:14:08.781+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.781+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:791,-0.082002,9.765969,0.888543
06-12 17:14:08.781+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:792,-0.177069,9.817751,0.923629
06-12 17:14:08.781+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.781+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.791+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:796,-0.129212,9.820145,0.926022
06-12 17:14:08.791+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.791+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.791+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.791+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:801,-0.083749,9.774680,0.851845
06-12 17:14:08.791+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.791+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:804,-0.210000,0.070000,-0.070000
06-12 17:14:08.791+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:805,-0.011964,9.786645,0.851845
06-12 17:14:08.801+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.801+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:801,0.057269,0.025601,-0.102911
06-12 17:14:08.801+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:796,-0.084343,9.765723,0.891025
06-12 17:14:08.801+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.801+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:809,-0.023928,9.791430,0.787239
06-12 17:14:08.801+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:812,-0.084486,9.765805,0.890112
06-12 17:14:08.811+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.811+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.811+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.811+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:821,0.037880,-0.015309,-0.055127
06-12 17:14:08.811+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:821,-0.210000,0.350000,0.070000
06-12 17:14:08.811+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.811+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:825,-0.040678,9.750752,0.832702
06-12 17:14:08.821+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:819,-0.081197,9.765829,0.890150
06-12 17:14:08.821+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.821+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:830,-0.078558,9.766062,0.887829
06-12 17:14:08.821+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.821+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:833,-0.076637,9.766332,0.885032
06-12 17:14:08.831+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.831+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.831+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:840,-0.035825,0.094491,-0.011652
06-12 17:14:08.831+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.831+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:841,-0.070000,0.280000,0.070000
06-12 17:14:08.831+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.831+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:844,-0.112463,9.860823,0.873380
06-12 17:14:08.841+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:846,-0.078178,9.766528,0.882724
06-12 17:14:08.851+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.851+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.851+0200 I/heartrate(16428): es.ugr.frailty.heartrate - capturing data
06-12 17:14:08.851+0200 I/heartrate(16428): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:14:08.851+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.851+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:863,-0.077162,9.766882,0.878892
06-12 17:14:08.861+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.861+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:867,0.018358,0.051223,-0.059592
06-12 17:14:08.861+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:863,-0.070000,0.280000,0.070000
06-12 17:14:08.861+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:869,-0.059821,9.817751,0.823131
06-12 17:14:08.871+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.871+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.871+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.871+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:880,-0.078884,9.767419,0.872750
06-12 17:14:08.871+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.881+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:880,-0.070000,0.280000,0.070000
06-12 17:14:08.881+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:880,-0.037694,0.041298,-0.084475
06-12 17:14:08.881+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:886,-0.114855,9.808180,0.794417
06-12 17:14:08.891+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.891+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.891+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.891+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:902,-0.070000,0.140000,0.070000
06-12 17:14:08.891+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:902,-0.076207,9.767710,0.869721
06-12 17:14:08.891+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.901+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:901,0.052563,-0.047773,-0.066369
06-12 17:14:08.901+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:907,-0.026321,9.719646,0.806381
06-12 17:14:08.911+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.911+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.911+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.911+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:921,0.070000,0.140000,0.070000
06-12 17:14:08.911+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:921,-0.074705,9.767797,0.868875
06-12 17:14:08.911+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.921+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:920,0.028350,0.052435,0.010837
06-12 17:14:08.921+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:928,-0.047856,9.820145,0.880559
06-12 17:14:08.931+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.931+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.931+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.931+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:943,-0.070000,0.140000,0.070000
06-12 17:14:08.941+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:943,-0.075665,9.767809,0.868657
06-12 17:14:08.941+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.941+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:942,-0.023401,0.033204,0.016469
06-12 17:14:08.941+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:951,-0.098106,9.801002,0.885344
06-12 17:14:08.951+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.951+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.951+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.951+0200 I/light   (16478): es.ugr.frailty.light - capturing data
06-12 17:14:08.961+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:962,-0.070000,0.070000,0.070000
06-12 17:14:08.961+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:961,-0.101404,0.076263,-0.021598
06-12 17:14:08.961+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:08.961+0200 I/light   (16478): es.ugr.frailty.light: SM-R760,12/06/2018,17:14:08:963,73.000000
06-12 17:14:08.961+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:964,-0.080311,9.767994,0.866160
06-12 17:14:08.971+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:08.971+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.971+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:08:981,-0.070000,0.070000,0.070000
06-12 17:14:08.971+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:08.981+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:08:988,-0.079651,9.767878,0.867529
06-12 17:14:08.991+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:08.991+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.001+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:4,-0.081260,9.768008,0.865911
06-12 17:14:09.001+0200 W/LOCATION(16440): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 17:14:09.011+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:2,0.070000,0.070000,0.070000
06-12 17:14:09.011+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.011+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:08:980,0.010919,0.035400,0.050291
06-12 17:14:09.011+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:08:976,-0.177069,9.844072,0.847059
06-12 17:14:09.011+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.011+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.011+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.021+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:24,0.070000,0.070000,-0.070000
06-12 17:14:09.021+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:25,-0.037598,0.057052,-0.006113
06-12 17:14:09.021+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:31,-0.069392,9.803394,0.916451
06-12 17:14:09.021+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.021+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.031+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.031+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:40,0.070000,0.140000,-0.070000
06-12 17:14:09.041+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:37,0.095617,-0.043577,-0.109779
06-12 17:14:09.041+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:25,-0.076667,9.768247,0.863629
06-12 17:14:09.041+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.041+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.041+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:51,-0.072348,9.768425,0.861989
06-12 17:14:09.041+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:52,0.091024,-0.022280,-0.088354
06-12 17:14:09.051+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:36,-0.117248,9.824929,0.861416
06-12 17:14:09.051+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.051+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.051+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:59,0.014357,9.724431,0.756132
06-12 17:14:09.051+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.051+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.051+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.051+0200 I/heartrate(16428): es.ugr.frailty.heartrate - capturing data
06-12 17:14:09.051+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:61,-0.070000,0.140000,-0.070000
06-12 17:14:09.051+0200 I/heartrate(16428): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:14:09.061+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:66,-0.072161,9.768722,0.858636
06-12 17:14:09.061+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:65,0.007742,-0.024852,-0.091500
06-12 17:14:09.061+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:65,0.014357,9.745967,0.775275
06-12 17:14:09.061+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.071+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.071+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.071+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.071+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:81,-0.072870,9.768881,0.856758
06-12 17:14:09.071+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:81,0.070000,0.070000,-0.070000
06-12 17:14:09.081+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:78,-0.064606,9.743573,0.770489
06-12 17:14:09.081+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.081+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:92,-0.083749,9.789038,0.811167
06-12 17:14:09.091+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:80,-0.011588,0.020316,-0.047469
06-12 17:14:09.091+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.091+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.091+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:100,0.010657,0.041693,-0.009699
06-12 17:14:09.091+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.101+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.101+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:105,-0.072513,9.768849,0.857152
06-12 17:14:09.101+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:101,-0.070000,0.070000,-0.070000
06-12 17:14:09.101+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:109,-0.062213,9.810574,0.847059
06-12 17:14:09.111+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.111+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.111+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:120,-0.072602,9.768786,0.857858
06-12 17:14:09.111+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:120,0.000729,0.005831,-0.000521
06-12 17:14:09.111+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.111+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.111+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:124,0.140000,-0.140000,-0.070000
06-12 17:14:09.121+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:125,-0.071785,9.774680,0.856631
06-12 17:14:09.131+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.131+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.131+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.131+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:140,0.000817,0.053751,-0.006014
06-12 17:14:09.131+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:140,-0.072393,9.768891,0.856687
06-12 17:14:09.131+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.141+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:144,-0.070000,-0.070000,0.070000
06-12 17:14:09.141+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:147,-0.071785,9.822537,0.851845
06-12 17:14:09.151+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.151+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.151+0200 I/light   (16478): es.ugr.frailty.light - capturing data
06-12 17:14:09.151+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.161+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:162,-0.061605,0.020146,0.016693
06-12 17:14:09.161+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:162,-0.070000,0.140000,0.070000
06-12 17:14:09.161+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:164,-0.075153,9.768876,0.856622
06-12 17:14:09.161+0200 I/light   (16478): es.ugr.frailty.light: SM-R760,12/06/2018,17:14:09:163,54.000000
06-12 17:14:09.161+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.161+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:174,-0.133998,9.789038,0.873380
06-12 17:14:09.171+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.171+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.171+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.171+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:180,-0.070000,0.210000,-0.070000
06-12 17:14:09.171+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:184,0.041654,0.032125,-0.026312
06-12 17:14:09.171+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:180,-0.073323,9.768909,0.856402
06-12 17:14:09.181+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.181+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:189,-0.033500,9.801002,0.830309
06-12 17:14:09.191+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.191+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.191+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:200,-0.070000,0.140000,-0.070000
06-12 17:14:09.191+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:200,-0.073074,9.769080,0.854473
06-12 17:14:09.191+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.191+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:205,0.008717,0.010557,-0.059592
06-12 17:14:09.201+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.201+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:210,-0.064606,9.779467,0.796810
06-12 17:14:09.211+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.211+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.211+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:219,-0.070000,0.070000,0.070000
06-12 17:14:09.211+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.211+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.211+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:220,-0.071149,9.769271,0.852454
06-12 17:14:09.211+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:224,0.037181,-0.013542,-0.033735
06-12 17:14:09.221+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:224,-0.035892,9.755538,0.820738
06-12 17:14:09.231+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.231+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.231+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:240,-0.070000,-0.070000,-0.070000
06-12 17:14:09.231+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.231+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:244,-0.098741,0.029338,-0.007787
06-12 17:14:09.231+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:240,-0.075965,9.769197,0.852890
06-12 17:14:09.231+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.241+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:249,-0.169890,9.798609,0.844666
06-12 17:14:09.251+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.251+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.251+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.251+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:261,-0.070000,-0.070000,-0.070000
06-12 17:14:09.251+0200 I/heartrate(16428): es.ugr.frailty.heartrate - capturing data
06-12 17:14:09.251+0200 I/heartrate(16428): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:14:09.261+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:262,-0.074758,9.769167,0.853326
06-12 17:14:09.261+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:264,0.028108,0.053341,-0.013010
06-12 17:14:09.261+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.261+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:273,-0.047856,9.822537,0.839881
06-12 17:14:09.271+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.271+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.271+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.271+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:280,0.070000,-0.070000,-0.070000
06-12 17:14:09.281+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:280,-0.075196,9.768910,0.856219
06-12 17:14:09.281+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.291+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.291+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:301,-0.070000,0.210000,-0.070000
06-12 17:14:09.291+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.301+0200 I/gravity (16454): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:14:09:307,-0.075653,9.769060,0.854475
06-12 17:14:09.311+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope - capturing data
06-12 17:14:09.311+0200 I/gyroscope(16416): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:14:09:320,-0.070000,0.140000,-0.070000
06-12 17:14:09.311+0200 I/gravity (16454): es.ugr.frailty.gravity - capturing data
06-12 17:14:09.321+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:282,-0.006598,0.024656,0.046375
06-12 17:14:09.321+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.361+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:293,-0.081356,9.793823,0.899701
06-12 17:14:09.371+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.371+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:14:09:375,-0.006160,0.063198,-0.045052
06-12 17:14:09.371+0200 I/linearacceleration(16442): es.ugr.frailty.linearacceleration - capturing data
06-12 17:14:09.381+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:14:09:381,-0.081356,9.832108,0.811167
06-12 17:14:09.381+0200 I/accelerometer(16403): es.ugr.frailty.accelerometer - capturing data
06-12 17:14:09.381+0200 W/CRASH_MANAGER(16518): worker.c: worker_job(1205) > 11164406c6f63152881644
