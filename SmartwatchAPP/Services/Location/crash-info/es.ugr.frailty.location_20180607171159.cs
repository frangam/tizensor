S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17582
Date: 2018-06-07 17:11:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75b652d, r5   = 0xf7bc3f98
r6   = 0xff81d370, r7   = 0xff81d220
r8   = 0xf7bc0c18, r9   = 0x00000000
r10  = 0xff81d2fc, fp   = 0xff81d370
ip   = 0x00000001, sp   = 0xff81d1f8
lr   = 0xf75b6539, pc   = 0xf761f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    150432 KB
Buffers:     10172 KB
Cached:      56352 KB
VmPeak:      53460 KB
VmSize:      53456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11744 KB
VmRSS:       11744 KB
VmData:      11184 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17582 TID = 17582
17582 17587 

Maps Information
f4481000 f4c80000 rw-p [stack:17587]
f4c87000 f4c89000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c91000 f4c95000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c9e000 f4ca0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ca8000 f4cab000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cba000 f4cbf000 r-xp /usr/lib/libsystem.so.0.0.0
f4cca000 f4ccd000 r-xp /lib/libattr.so.1.1.0
f4cd5000 f4ce5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ced000 f4cf6000 r-xp /usr/lib/libedbus.so.1.7.99
f4cfe000 f4cff000 r-xp /usr/lib/libresponse.so.0.2.96
f4d08000 f4d0d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65af000 f66b5000 r-xp /usr/lib/libicuuc.so.57.1
f66cb000 f6853000 r-xp /usr/lib/libicui18n.so.57.1
f6863000 f6870000 r-xp /usr/lib/libail.so.0.1.0
f6879000 f6880000 r-xp /usr/lib/libminizip.so.1.0.0
f6889000 f6a32000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a52000 f6a99000 r-xp /usr/lib/libssl.so.1.0.0
f6aa5000 f6aa7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6aaf000 f6ab6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6abf000 f6ac6000 r-xp /lib/libcrypt-2.13.so
f6af7000 f6afa000 r-xp /lib/libcap.so.2.21
f6b02000 f6b04000 r-xp /usr/lib/libiri.so
f6b0c000 f6b55000 r-xp /usr/lib/libmdm.so.1.2.69
f6b5d000 f6b63000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b6b000 f6b8e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b98000 f6b9a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ba2000 f6bbf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bc8000 f6bcc000 r-xp /usr/lib/libsmack.so.1.0.0
f6bd5000 f6bee000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bf7000 f6bff000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c07000 f6c0d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c16000 f6c18000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c21000 f6c31000 r-xp /lib/libresolv-2.13.so
f6c35000 f6c4d000 r-xp /usr/lib/liblzma.so.5.0.3
f6c56000 f6c58000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c60000 f6c7a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c82000 f6cb1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cba000 f6cc9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cd3000 f6cdd000 r-xp /usr/lib/libsensord-shared.so
f6ce6000 f6db9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dc4000 f6dda000 r-xp /lib/libz.so.1.2.5
f6de2000 f6de7000 r-xp /usr/lib/libffi.so.5.0.10
f6def000 f6df0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6df8000 f6e08000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e10000 f6e29000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e31000 f6e33000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e3b000 f6eb0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6eba000 f6ec0000 r-xp /lib/librt-2.13.so
f6ec9000 f6ee7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ef1000 f6ef2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6efa000 f6f1d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f25000 f6f2a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f32000 f6f5c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f65000 f6f7c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f84000 f6fed000 r-xp /lib/libm-2.13.so
f6ff6000 f708a000 r-xp /usr/lib/libstdc++.so.6.0.16
f709d000 f70a2000 r-xp /usr/lib/libctx-client.so.0.8.3
f70aa000 f70b1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70b9000 f70e3000 r-xp /usr/lib/libsensor.so.1.9.6
f70ec000 f71b8000 r-xp /usr/lib/libxml2.so.2.7.8
f71c5000 f71c7000 r-xp /usr/lib/libiniparser.so.0
f71d0000 f71d6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71df000 f72af000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72b0000 f72e4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72ed000 f7329000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7331000 f7334000 r-xp /usr/lib/libbundle.so.0.1.22
f733c000 f7342000 r-xp /usr/lib/libappsvc.so.0.1.0
f734a000 f738b000 r-xp /usr/lib/libeina.so.1.7.99
f7394000 f73ab000 r-xp /usr/lib/libecore.so.1.7.99
f73c2000 f73cb000 r-xp /usr/lib/libvconf.so.0.2.45
f73d3000 f73e7000 r-xp /lib/libpthread-2.13.so
f73f2000 f73ff000 r-xp /usr/lib/libaul.so.0.1.0
f7409000 f740b000 r-xp /lib/libdl-2.13.so
f7414000 f741f000 r-xp /lib/libunwind.so.8.0.1
f744c000 f7454000 r-xp /lib/libgcc_s-4.6.so.1
f7455000 f7579000 r-xp /lib/libc-2.13.so
f7587000 f7589000 r-xp /usr/lib/libdlog.so.0.0.0
f7591000 f759d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75a6000 f75ab000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75b3000 f75c2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75ca000 f75ce000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75d7000 f75da000 r-xp /usr/lib/libappcore-agent.so.1.1
f75e2000 f75e4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75ec000 f75f0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75f8000 f7615000 r-xp /lib/ld-2.13.so
f761e000 f7621000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7621000 f7625000 r-xp /usr/lib/libsys-assert.so
f7b90000 f7c01000 rw-p [heap]
ff7fe000 ff81f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17582)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf761f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75b6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72bd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72bbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72c7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72cdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72cddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf730275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72fd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72bbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72c7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72cdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72cddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72ffe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7300017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7307f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c9f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c92171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d65663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7212fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72147a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73a4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf739fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73a05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73a0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75d8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75d87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf761f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf746c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf761ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ght - capturing data
06-07 17:11:59.491+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:469,-0.023600,-0.192866,0.025068
06-07 17:11:59.491+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.491+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:59:496,558.000000
06-07 17:11:59.511+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xf80dfb80) is deleting
06-07 17:11:59.511+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xf80dfb80) is deleting
06-07 17:11:59.511+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xf80defc0) is deleting
06-07 17:11:59.511+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xf80defc0) is deleting
06-07 17:11:59.511+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:498,1.220340,-1.296910,9.382257
06-07 17:11:59.511+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:492,0.818569,-1.550699,9.648609
06-07 17:11:59.511+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:491,1.120000,1.260000,0.700000
06-07 17:11:59.511+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.521+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.521+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.531+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:508,-0.174222,-0.245836,0.116298
06-07 17:11:59.531+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:530,-0.980000,3.080000,1.050000
06-07 17:11:59.541+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:531,0.817830,-1.546973,9.649270
06-07 17:11:59.541+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.541+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:549,1.268196,-1.785046,9.690931
06-07 17:11:59.551+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:555,-0.176170,-0.261202,0.136637
06-07 17:11:59.551+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.551+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.561+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.561+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.571+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:563,-0.980000,1.750000,2.170000
06-07 17:11:59.571+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:575,1.222732,-2.029114,8.183454
06-07 17:11:59.581+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:568,0.815624,-1.549109,9.649114
06-07 17:11:59.581+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.581+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.591+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:594,0.810713,-1.553567,9.648811
06-07 17:11:59.591+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:576,-0.036742,-0.403662,0.016139
06-07 17:11:59.591+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.591+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.601+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:603,0.031955,-0.372058,-0.134862
06-07 17:11:59.601+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:588,-3.150000,-1.680000,3.290000
06-07 17:11:59.611+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.611+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:59.611+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(17469), cmd(0)
06-07 17:11:59.611+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:621,-4.480000,-0.210000,2.870000
06-07 17:11:59.621+0200 W/CAPI_APPFW_APP_CONTROL(17469): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:59.621+0200 I/utils   (17469): specific action
06-07 17:11:59.621+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:605,1.220340,-3.259024,9.908678
06-07 17:11:59.621+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:59.621+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(17469), cmd(0)
06-07 17:11:59.631+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.631+0200 W/CAPI_APPFW_APP_CONTROL(17469): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:59.631+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.631+0200 I/utils   (17469): specific action
06-07 17:11:59.631+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.641+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.641+0200 W/LOCATION(17582): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:11:59.661+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:644,0.065860,-0.222519,-0.151064
06-07 17:11:59.671+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:639,0.798304,-1.552557,9.650008
06-07 17:11:59.671+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:11:59.671+0200 I/heartrate(17619): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:11:59.671+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.671+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:645,1.500300,-2.943172,9.973285
06-07 17:11:59.681+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.681+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:670,-2.870000,1.120000,1.750000
06-07 17:11:59.691+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:59.691+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.691+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:59:696,559.000000
06-07 17:11:59.691+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:691,0.048735,-0.190163,-0.085441
06-07 17:11:59.701+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:680,0.785695,-1.553667,9.650865
06-07 17:11:59.701+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.701+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.711+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.711+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:706,1.586441,-2.201397,9.659825
06-07 17:11:59.711+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.711+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:716,0.776819,-1.556557,9.651117
06-07 17:11:59.721+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:700,0.420000,1.120000,0.420000
06-07 17:11:59.721+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.731+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:718,1.600798,-2.029114,9.504292
06-07 17:11:59.731+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.731+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:726,0.054917,-0.183259,0.004501
06-07 17:11:59.731+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.731+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:737,1.296910,-2.139183,9.645468
06-07 17:11:59.731+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.731+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.741+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:732,2.800000,-0.840000,-1.050000
06-07 17:11:59.751+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.751+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:751,0.011419,-0.057682,0.204713
06-07 17:11:59.751+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:744,0.771628,-1.562527,9.650569
06-07 17:11:59.751+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:757,3.010000,-0.840000,-1.750000
06-07 17:11:59.761+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:742,1.024128,-2.038685,9.442079
06-07 17:11:59.761+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.761+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.771+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.771+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:767,0.861416,-2.184647,9.611969
06-07 17:11:59.771+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.771+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.771+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:778,0.069653,-0.260023,0.089138
06-07 17:11:59.781+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:776,0.767218,-1.570955,9.649552
06-07 17:11:59.781+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:779,0.842274,-1.914258,9.611969
06-07 17:11:59.781+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.791+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.791+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.791+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:782,2.310000,1.540000,-1.330000
06-07 17:11:59.801+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:790,0.854238,-1.801795,9.710074
06-07 17:11:59.801+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.801+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.811+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:805,0.765822,-1.580251,9.648146
06-07 17:11:59.811+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:811,0.910000,2.870000,0.070000
06-07 17:11:59.811+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:804,-0.072603,-0.396675,0.219628
06-07 17:11:59.811+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:811,0.815953,-1.782653,9.590433
06-07 17:11:59.821+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.821+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.821+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.821+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:832,0.741775,-1.770689,9.516255
06-07 17:11:59.831+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.831+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:837,-0.213072,-0.362532,0.136807
06-07 17:11:59.831+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:842,-1.750000,1.960000,1.050000
06-07 17:11:59.841+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.841+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:832,0.763856,-1.590973,9.646539
06-07 17:11:59.841+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.841+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:847,0.787239,-1.964507,9.645468
06-07 17:11:59.851+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.851+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.851+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.861+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:861,0.844666,-1.816152,9.722038
06-07 17:11:59.861+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.871+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:11:59.871+0200 I/heartrate(17619): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:11:59.881+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:860,-0.162398,-0.325993,0.005569
06-07 17:11:59.881+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:873,0.916451,-1.792224,9.779467
06-07 17:11:59.881+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:857,0.767835,-1.613557,9.642471
06-07 17:11:59.881+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.891+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.891+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:863,-2.100000,-0.210000,1.890000
06-07 17:11:59.891+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.891+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:59.901+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:59:903,562.000000
06-07 17:11:59.901+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:59.901+0200 I/utils   (17419): specific action
06-07 17:11:59.901+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:59.901+0200 I/utils   (17419): specific action
06-07 17:11:59.901+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.901+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:59.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(17419), cmd(0)
06-07 17:11:59.901+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:59.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(17419), cmd(0)
06-07 17:11:59.911+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:903,-0.025647,-0.427727,-0.145110
06-07 17:11:59.911+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:905,-1.400000,-1.400000,2.940000
06-07 17:11:59.911+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:911,0.947558,-1.610370,9.798609
06-07 17:11:59.911+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:898,0.768914,-1.634831,9.638801
06-07 17:11:59.911+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.921+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.921+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.931+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:925,1.002593,-1.674976,9.793823
06-07 17:11:59.931+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.931+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.951+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:945,0.961915,-1.708475,9.552148
06-07 17:11:59.951+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:935,0.078152,-0.307975,-0.039773
06-07 17:11:59.951+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.961+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:939,0.768207,-1.654618,9.635480
06-07 17:11:59.961+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.961+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:960,0.792024,-1.741975,9.674182
06-07 17:11:59.961+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:946,-1.680000,-1.120000,3.010000
06-07 17:11:59.971+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.971+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:59.971+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:59:980,0.032067,-0.143919,-0.036783
06-07 17:11:59.981+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.981+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:59:986,0.755818,-1.662443,9.635113
06-07 17:11:59.981+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:59:986,0.636491,-1.799403,9.765109
06-07 17:11:59.991+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:59.991+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:59:990,-1.470000,0.140000,2.590000
06-07 17:11:59.991+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:59.991+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:11:59.991+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:0,0.622134,-1.813759,9.786645
06-07 17:12:00.001+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.001+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.011+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:10,0.743493,-1.668386,9.635045
06-07 17:12:00.021+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:15,0.748954,-1.957329,9.667004
06-07 17:12:00.021+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.021+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:5,-0.068516,-0.175247,0.036238
06-07 17:12:00.031+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:30,0.808774,-1.928615,9.516255
06-07 17:12:00.031+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.031+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.041+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:14,-1.400000,0.140000,1.960000
06-07 17:12:00.041+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.041+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.041+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:40,0.837488,-1.785046,9.499505
06-07 17:12:00.041+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.051+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:50,0.742586,-1.682853,9.632599
06-07 17:12:00.051+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:52,-2.380000,0.350000,0.630000
06-07 17:12:00.061+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:48,-0.135409,-0.094974,0.045663
06-07 17:12:00.061+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:12:00.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:12:00.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:12:00.061+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.071+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.071+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:00.071+0200 I/heartrate(17619): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:12:00.081+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:53,0.815953,-1.761117,9.564112
06-07 17:12:00.081+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.081+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:88,0.820738,-1.763510,9.652647
06-07 17:12:00.081+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.091+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:77,-1.330000,2.240000,0.910000
06-07 17:12:00.091+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:71,0.010700,-0.123919,0.182302
06-07 17:12:00.091+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:75,0.745600,-1.698555,9.629609
06-07 17:12:00.091+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.101+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.101+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.101+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:12:00.101+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:12:00.101+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:00.101+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:00.101+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:00.111+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:00:112,564.000000
06-07 17:12:00.121+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
06-07 17:12:00.121+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
06-07 17:12:00.121+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:12:00.121+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:00.121+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:12:00.121+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:12:00.131+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:93,0.775275,-1.648655,9.851252
06-07 17:12:00.131+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:00.131+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:00.141+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.141+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17548
06-07 17:12:00.151+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17548)
06-07 17:12:00.151+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:12:00.151+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:00.151+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:12:00.151+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:12:00.151+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:146,0.837488,-1.873580,9.731609
06-07 17:12:00.151+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:00.161+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:00.161+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.171+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17619
06-07 17:12:00.171+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:00.171+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(17619), cmd(0)
06-07 17:12:00.171+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:170,0.696311,-2.031506,9.858429
06-07 17:12:00.181+0200 W/CAPI_APPFW_APP_CONTROL(17619): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:00.181+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17619)
06-07 17:12:00.181+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:12:00.181+0200 I/utils   (17619): specific action
06-07 17:12:00.181+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:00.181+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:12:00.181+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:12:00.181+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:00.181+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:00.181+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.191+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17582
06-07 17:12:00.191+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:192,0.555135,-2.017149,9.772287
06-07 17:12:00.201+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17582)
06-07 17:12:00.201+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:12:00.201+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:00.201+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:12:00.201+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:12:00.211+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:00.211+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:00.211+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:108,0.039597,-0.239972,0.244275
06-07 17:12:00.221+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.221+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17504
06-07 17:12:00.221+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17504)
06-07 17:12:00.221+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:12:00.221+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:00.221+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:12:00.221+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:12:00.231+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:110,0.745685,-1.705512,9.628373
06-07 17:12:00.231+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.231+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:110,-1.610000,3.360000,0.350000
06-07 17:12:00.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:00.231+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:00.241+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.241+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.241+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17469
06-07 17:12:00.251+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17469)
06-07 17:12:00.251+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:12:00.251+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:00.251+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:12:00.251+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:12:00.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:00.251+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:00.251+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:231,0.593420,-1.988436,9.640682
06-07 17:12:00.261+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:239,-0.033795,-0.324632,0.186996
06-07 17:12:00.261+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:254,0.740793,-1.706821,9.628519
06-07 17:12:00.261+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:12:00.261+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:00.261+0200 I/utils   (12603): specific action
06-07 17:12:00.271+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:00.271+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(12603), cmd(0)
06-07 17:12:00.271+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:00.271+0200 I/heartrate(17619): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:12:00.271+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:12:00.271+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:12:00.271+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:00.271+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:12:00.271+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:12:00.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:00.271+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:00.271+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:256,1.470000,2.520000,0.070000
06-07 17:12:00.281+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16749
06-07 17:12:00.281+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.281+0200 W/CAPI_APPFW_APP_CONTROL(16749): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:00.291+0200 I/utils   (16749): specific action
06-07 17:12:00.291+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:00.291+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:00.291+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(16749), cmd(0)
06-07 17:12:00.291+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16749)
06-07 17:12:00.291+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:12:00.291+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:00.291+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:12:00.291+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:12:00.291+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:00.291+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:00.291+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:00:296,566.000000
06-07 17:12:00.301+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:12:00.311+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:00.311+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:12:00.311+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:00.311+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(12618), cmd(0)
06-07 17:12:00.311+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:12:00.311+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:00.311+0200 I/utils   (12618): specific action
06-07 17:12:00.311+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.311+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:318,0.717847,-2.096112,9.489935
06-07 17:12:00.311+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.321+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.321+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:325,0.820738,-1.990828,9.592826
06-07 17:12:00.321+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.321+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.331+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:333,0.777667,-1.842474,9.592826
06-07 17:12:00.331+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.331+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:339,0.677169,-1.880759,9.664611
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:00.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391520343,000000, pattern:[H:mm][0;m
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:00.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:00.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:12:00.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:12][0;m
06-07 17:12:00.341+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:319,-0.090188,-0.311616,-0.027962
06-07 17:12:00.351+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.351+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:333,0.733467,-1.711376,9.628271
06-07 17:12:00.351+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.351+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:358,0.605384,-1.801795,9.674182
06-07 17:12:00.331+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:339,3.290000,-1.120000,1.400000
06-07 17:12:00.351+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.361+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.361+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.361+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:363,0.744168,-1.835295,9.810574
06-07 17:12:00.361+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.361+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:371,0.770489,-1.964507,9.870394
06-07 17:12:00.371+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.371+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:362,0.003132,-0.314009,-0.106925
06-07 17:12:00.371+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:378,0.698704,-2.062613,9.810574
06-07 17:12:00.371+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.381+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:374,0.910000,-2.310000,1.820000
06-07 17:12:00.381+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:384,0.636491,-2.067399,9.592826
06-07 17:12:00.381+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.381+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.381+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:375,0.730892,-1.724536,9.626119
06-07 17:12:00.391+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:391,0.729811,-2.069792,9.513863
06-07 17:12:00.391+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.391+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.391+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:399,0.765703,-1.998007,9.434900
06-07 17:12:00.401+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.401+0200 W/APPS    ( 2762): apps_main.c: _time_changed_cb(308) >  date : 7->7
06-07 17:12:00.401+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:406,0.722632,-1.945365,9.635897
06-07 17:12:00.401+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.401+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.411+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:413,0.674776,-1.837688,9.767502
06-07 17:12:00.411+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.411+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:395,0.042626,-0.235317,-0.184896
06-07 17:12:00.411+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:419,0.629312,-1.890330,9.822537
06-07 17:12:00.421+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.421+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:427,0.636491,-2.002793,9.779467
06-07 17:12:00.421+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:412,0.732499,-1.737981,9.623578
06-07 17:12:00.421+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.431+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.431+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:404,-0.070000,-1.190000,1.470000
06-07 17:12:00.431+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.431+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:434,0.701097,-1.892723,9.702895
06-07 17:12:00.431+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.431+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.431+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:437,-0.001896,-0.174971,0.017625
06-07 17:12:00.441+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:441,0.684347,-1.871187,9.736395
06-07 17:12:00.441+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.441+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:448,0.691526,-1.875973,9.604790
06-07 17:12:00.441+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.451+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:454,0.710668,-1.830509,9.449257
06-07 17:12:00.451+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.451+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:454,0.731751,-1.748992,9.621640
06-07 17:12:00.451+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:459,0.760918,-1.952543,9.485149
06-07 17:12:00.451+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:448,2.590000,-0.770000,0.350000
06-07 17:12:00.461+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.461+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.461+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:466,0.768096,-2.036292,9.506684
06-07 17:12:00.461+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.461+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.471+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.471+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:00.471+0200 I/heartrate(17619): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:12:00.471+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:474,0.713061,-2.139183,9.729217
06-07 17:12:00.471+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.471+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:480,0.607777,-2.282753,9.827322
06-07 17:12:00.471+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.481+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:474,-0.048327,-0.065417,0.149468
06-07 17:12:00.491+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:00.491+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:485,0.569492,-2.129612,9.710074
06-07 17:12:00.491+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:492,0.726679,-1.755783,9.620788
06-07 17:12:00.491+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:478,4.410000,-1.400000,-1.050000
06-07 17:12:00.491+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.501+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:00:498,567.000000
06-07 17:12:00.501+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.501+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.501+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.511+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:511,5.600000,-1.120000,-2.450000
06-07 17:12:00.521+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:507,-0.087058,-0.120021,0.203639
06-07 17:12:00.521+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.521+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.531+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:00:519,0.723077,-1.762690,9.619796
06-07 17:12:00.531+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:00:521,0.574277,-2.076970,9.681360
06-07 17:12:00.531+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:00.541+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:00.551+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:00:535,4.970000,0.070000,-1.400000
06-07 17:12:00.551+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:00:534,-0.073580,-0.231945,0.160200
06-07 17:12:00.581+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:00.591+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:00.591+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11175826c6f63152838431
