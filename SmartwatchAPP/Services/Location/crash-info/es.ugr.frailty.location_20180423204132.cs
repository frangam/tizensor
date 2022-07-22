S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12456
Date: 2018-04-23 20:41:32+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73fa52d, r5   = 0xf7c7ff98
r6   = 0xff9f3f10, r7   = 0xff9f3dc0
r8   = 0xf7c7cc18, r9   = 0x00000000
r10  = 0xff9f3e9c, fp   = 0xff9f3f10
ip   = 0x00000001, sp   = 0xff9f3d98
lr   = 0xf73fa539, pc   = 0xf7463228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    132196 KB
Buffers:     40296 KB
Cached:     160956 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11988 KB
VmRSS:       11984 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12456 TID = 12456
12456 12464 

Maps Information
f42c5000 f4ac4000 rw-p [stack:12464]
f4acb000 f4acd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ad5000 f4ad9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ae2000 f4ae4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4aec000 f4aef000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4afe000 f4b03000 r-xp /usr/lib/libsystem.so.0.0.0
f4b0e000 f4b11000 r-xp /lib/libattr.so.1.1.0
f4b19000 f4b29000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b31000 f4b3a000 r-xp /usr/lib/libedbus.so.1.7.99
f4b42000 f4b43000 r-xp /usr/lib/libresponse.so.0.2.96
f4b4c000 f4b51000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63f3000 f64f9000 r-xp /usr/lib/libicuuc.so.57.1
f650f000 f6697000 r-xp /usr/lib/libicui18n.so.57.1
f66a7000 f66b4000 r-xp /usr/lib/libail.so.0.1.0
f66bd000 f66c4000 r-xp /usr/lib/libminizip.so.1.0.0
f66cd000 f6876000 r-xp /usr/lib/libcrypto.so.1.0.0
f6896000 f68dd000 r-xp /usr/lib/libssl.so.1.0.0
f68e9000 f68eb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68f3000 f68fa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6903000 f690a000 r-xp /lib/libcrypt-2.13.so
f693b000 f693e000 r-xp /lib/libcap.so.2.21
f6946000 f6948000 r-xp /usr/lib/libiri.so
f6950000 f6999000 r-xp /usr/lib/libmdm.so.1.2.69
f69a1000 f69a7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69af000 f69d2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69dc000 f69de000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69e6000 f6a03000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a0c000 f6a10000 r-xp /usr/lib/libsmack.so.1.0.0
f6a19000 f6a32000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a3b000 f6a43000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a4b000 f6a51000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a5a000 f6a5c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a65000 f6a75000 r-xp /lib/libresolv-2.13.so
f6a79000 f6a91000 r-xp /usr/lib/liblzma.so.5.0.3
f6a9a000 f6a9c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aa4000 f6abe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ac6000 f6af5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6afe000 f6b0d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b17000 f6b21000 r-xp /usr/lib/libsensord-shared.so
f6b2a000 f6bfd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c08000 f6c1e000 r-xp /lib/libz.so.1.2.5
f6c26000 f6c2b000 r-xp /usr/lib/libffi.so.5.0.10
f6c33000 f6c34000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c3c000 f6c4c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c54000 f6c6d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c75000 f6c77000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c7f000 f6cf4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cfe000 f6d04000 r-xp /lib/librt-2.13.so
f6d0d000 f6d2b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d35000 f6d36000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d3e000 f6d61000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d69000 f6d6e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d76000 f6da0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6da9000 f6dc0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dc8000 f6e31000 r-xp /lib/libm-2.13.so
f6e3a000 f6ece000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ee1000 f6ee6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6eee000 f6ef5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6efd000 f6f27000 r-xp /usr/lib/libsensor.so.1.9.6
f6f30000 f6ffc000 r-xp /usr/lib/libxml2.so.2.7.8
f7009000 f700b000 r-xp /usr/lib/libiniparser.so.0
f7014000 f701a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7023000 f70f3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70f4000 f7128000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7131000 f716d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7175000 f7178000 r-xp /usr/lib/libbundle.so.0.1.22
f7180000 f7186000 r-xp /usr/lib/libappsvc.so.0.1.0
f718e000 f71cf000 r-xp /usr/lib/libeina.so.1.7.99
f71d8000 f71ef000 r-xp /usr/lib/libecore.so.1.7.99
f7206000 f720f000 r-xp /usr/lib/libvconf.so.0.2.45
f7217000 f722b000 r-xp /lib/libpthread-2.13.so
f7236000 f7243000 r-xp /usr/lib/libaul.so.0.1.0
f724d000 f724f000 r-xp /lib/libdl-2.13.so
f7258000 f7263000 r-xp /lib/libunwind.so.8.0.1
f7290000 f7298000 r-xp /lib/libgcc_s-4.6.so.1
f7299000 f73bd000 r-xp /lib/libc-2.13.so
f73cb000 f73cd000 r-xp /usr/lib/libdlog.so.0.0.0
f73d5000 f73e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73ea000 f73ef000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73f7000 f7406000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f740e000 f7412000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f741b000 f741e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7426000 f7428000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7430000 f7434000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f743c000 f7459000 r-xp /lib/ld-2.13.so
f7462000 f7465000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7465000 f7469000 r-xp /usr/lib/libsys-assert.so
f7c4c000 f7cba000 rw-p [heap]
ff9d5000 ff9f6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12456)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7463228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73fa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71013f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70ffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf710be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7111be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7111dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf714675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71411f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70ffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf710be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7111be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7111dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7143e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7144017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf714bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ae31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ad6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ba9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7056fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70587a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71e8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71e3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71e45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71e4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf741c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf741c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74635c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf72b085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7462f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
70000,0.070000
04-23 20:41:22.789+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:22.789+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:22.789+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:22.789+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:22:796,-0.070000,0.070000,0.070000
04-23 20:41:22.799+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:22:790,0.059821,9.824929,0.789631
04-23 20:41:22.799+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:22:806,-0.008735,0.031700,-0.012749
04-23 20:41:22.799+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:22.809+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:22:803,0.040249,9.771461,0.829033
04-23 20:41:22.809+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:22.809+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:22.819+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:22.819+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:22:824,-0.070000,-0.070000,-0.070000
04-23 20:41:22.819+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:22:828,0.039958,9.771357,0.830287
04-23 20:41:22.819+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:22:813,0.045464,9.791430,0.847059
04-23 20:41:22.829+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:22.839+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:22.839+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:22.839+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:22:832,0.014786,0.046289,-0.020259
04-23 20:41:22.849+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:22.849+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:22:843,0.031107,9.803394,0.813560
04-23 20:41:22.849+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:22.859+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:22:850,-0.070000,0.070000,0.070000
04-23 20:41:22.859+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:22:866,0.055035,9.817751,0.808774
04-23 20:41:22.869+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:22:857,-0.004066,0.044002,-0.035870
04-23 20:41:22.869+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:22.869+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:22:854,0.040523,9.771633,0.826996
04-23 20:41:22.869+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:22.879+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:22.879+0200 I/servicemanager(12059): es.ugr.frailty.heartrate sleep timeout
04-23 20:41:22.879+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 20:41:22.879+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:22.879+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:22.889+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12076
04-23 20:41:22.889+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:22.889+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(17), pid(12076), cmd(0)
04-23 20:41:22.899+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12076)
04-23 20:41:22.899+0200 I/heartrate(12076): stopping es.ugr.frailty.heartrate service
04-23 20:41:22.899+0200 I/servicemanager(12059): es.ugr.frailty.heartrate stop request sent!
04-23 20:41:22.899+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:22.899+0200 E/CAPI_APPFW_APP_CONTROL(12076): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:41:22.899+0200 E/heartrate(12076): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.heartrate; data: 
04-23 20:41:22.899+0200 I/CAPI_APPFW_APPLICATION(12076): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:41:22.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:41:22.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:41:22.929+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:22:882,-0.070000,0.070000,0.070000
04-23 20:41:22.949+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:22.959+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:22.969+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:22.989+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:22:885,0.040443,9.771614,0.827229
04-23 20:41:22.989+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:22:954,0.043226,0.034154,-0.056507
04-23 20:41:22.999+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:22:991,0.035892,9.815358,0.794417
04-23 20:41:22.999+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:23.009+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:23.009+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.009+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:23.019+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:23:14,0.042673,9.771850,0.824324
04-23 20:41:23.019+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:23:10,-0.070000,0.070000,0.070000
04-23 20:41:23.029+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:17,-0.004551,0.019816,0.003081
04-23 20:41:23.029+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:23.029+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:23.039+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.049+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:23:23,0.083749,9.805787,0.770489
04-23 20:41:23.049+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:23.059+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:23:43,-0.070000,0.070000,0.070000
04-23 20:41:23.059+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:54,0.005184,0.005223,0.005985
04-23 20:41:23.069+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.069+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(12073), cmd(0)
04-23 20:41:23.069+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:23:48,0.042497,9.771675,0.826405
04-23 20:41:23.069+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:23.069+0200 I/gyroscope(12073): stopping es.ugr.frailty.gyroscope service
04-23 20:41:23.069+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.069+0200 W/AUL     (12073): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:41:23.069+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:23:59,0.035892,9.791430,0.830309
04-23 20:41:23.079+0200 I/servicemanager(12059): es.ugr.frailty.linearacceleration sleep timeout
04-23 20:41:23.079+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
04-23 20:41:23.079+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:23.089+0200 I/heartrate(12076): es.ugr.frailty.heartrate listener destroyed
04-23 20:41:23.089+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.099+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12073
04-23 20:41:23.109+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12059
04-23 20:41:23.109+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:83,-0.006605,0.058040,-0.075059
04-23 20:41:23.109+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.109+0200 W/AUL     (12073): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12059)
04-23 20:41:23.109+0200 I/gyroscope(12073): request sent to service es.ugr.frailty.servicemanager
04-23 20:41:23.109+0200 I/CAPI_APPFW_APPLICATION(12073): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:41:23.109+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:116,0.026484,0.042384,-0.023142
04-23 20:41:23.109+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.129+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:23.139+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12097
04-23 20:41:23.139+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:41:23.139+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:41:23.139+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12097)
04-23 20:41:23.139+0200 I/servicemanager(12059): es.ugr.frailty.linearacceleration stop request sent!
04-23 20:41:23.139+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:23.139+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.139+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(12059), cmd(0)
04-23 20:41:23.159+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.159+0200 I/utils   (12059): specific action
04-23 20:41:23.159+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.159+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:41:23.159+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.169+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:23.179+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12064
04-23 20:41:23.179+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.179+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(12064), cmd(0)
04-23 20:41:23.179+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.179+0200 I/utils   (12064): specific action
04-23 20:41:23.179+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.179+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.219+0200 I/recorder(12064): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 20:41:23.239+0200 I/recorder(12064): guardando datos en local
04-23 20:41:23.239+0200 W/AUL     (12435): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 20:41:23.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:23.239+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:23.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12076
04-23 20:41:23.239+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:23.239+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12076
04-23 20:41:23.239+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12076)
04-23 20:41:23.249+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12064)
04-23 20:41:23.249+0200 I/servicemanager(12059): request sent to service es.ugr.frailty.recorder
04-23 20:41:23.249+0200 I/servicemanager(12059): requesting to save local data
04-23 20:41:23.249+0200 I/servicemanager(12059): es.ugr.frailty.gravity sleep timeout
04-23 20:41:23.249+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:41:23.249+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.249+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:23.259+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12110
04-23 20:41:23.259+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12110)
04-23 20:41:23.259+0200 I/servicemanager(12059): es.ugr.frailty.gravity stop request sent!
04-23 20:41:23.259+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:23.269+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:23:79,0.045301,9.770581,0.839094
04-23 20:41:23.269+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.269+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(12110), cmd(0)
04-23 20:41:23.269+0200 I/gravity (12110): stopping es.ugr.frailty.gravity service
04-23 20:41:23.269+0200 W/AUL     (12110): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:41:23.269+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.269+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12110
04-23 20:41:23.279+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12059
04-23 20:41:23.289+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.289+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(12059), cmd(0)
04-23 20:41:23.289+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.289+0200 I/utils   (12059): specific action
04-23 20:41:23.289+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.289+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.289+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.289+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.289+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.289+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:41:23.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.299+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:23.309+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12064
04-23 20:41:23.309+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.309+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(12064), cmd(0)
04-23 20:41:23.309+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.309+0200 I/utils   (12064): specific action
04-23 20:41:23.309+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.309+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.309+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.309+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.309+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.309+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.309+0200 I/recorder(12064): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
04-23 20:41:23.309+0200 I/recorder(12064): guardando datos en local
04-23 20:41:23.309+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12064)
04-23 20:41:23.309+0200 I/servicemanager(12059): request sent to service es.ugr.frailty.recorder
04-23 20:41:23.309+0200 I/servicemanager(12059): requesting to save local data
04-23 20:41:23.309+0200 W/AUL     (12110): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12059)
04-23 20:41:23.309+0200 I/gravity (12110): request sent to service es.ugr.frailty.servicemanager
04-23 20:41:23.309+0200 I/CAPI_APPFW_APPLICATION(12110): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:41:23.319+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:41:23.319+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:41:23.359+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:23.369+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:23.389+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:23.399+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:23.409+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope listener destroyed
04-23 20:41:23.419+0200 I/gravity (12110): es.ugr.frailty.gravity listener destroyed
04-23 20:41:23.419+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:120,-0.035898,0.072095,-0.035549
04-23 20:41:23.419+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.419+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:428,-0.041532,0.055784,-0.040152
04-23 20:41:23.429+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.429+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:434,0.040020,0.042090,-0.060712
04-23 20:41:23.429+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.439+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:440,-0.002300,0.020993,-0.094854
04-23 20:41:23.439+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.439+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:446,-0.007490,0.035414,-0.016280
04-23 20:41:23.439+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.449+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:452,-0.002100,0.017838,-0.013757
04-23 20:41:23.449+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.449+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:459,-0.002524,0.011192,-0.048912
04-23 20:41:23.459+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.459+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:464,0.018834,0.064252,-0.034791
04-23 20:41:23.459+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.459+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:469,-0.036337,0.080470,-0.025991
04-23 20:41:23.469+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:23:95,0.047856,9.777073,0.830309
04-23 20:41:23.469+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:23.469+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:23:476,0.023152,0.035821,-0.074397
04-23 20:41:23.469+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:23.479+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.479+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(17), pid(12097), cmd(0)
04-23 20:41:23.479+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:23:481,0.035892,9.829715,0.751346
04-23 20:41:23.479+0200 I/linearacceleration(12097): stopping es.ugr.frailty.linearacceleration service
04-23 20:41:23.479+0200 W/AUL     (12097): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:41:23.489+0200 I/accelerometer(12070): stopping es.ugr.frailty.accelerometer service
04-23 20:41:23.489+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.489+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12097
04-23 20:41:23.499+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12059
04-23 20:41:23.499+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.499+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(12070), cmd(0)
04-23 20:41:23.499+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.499+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(12059), cmd(0)
04-23 20:41:23.509+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.509+0200 I/utils   (12059): specific action
04-23 20:41:23.509+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.509+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.509+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.509+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.509+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:41:23.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.569+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:23.569+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12064
04-23 20:41:23.579+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.579+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(12064), cmd(0)
04-23 20:41:23.579+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.589+0200 I/utils   (12064): specific action
04-23 20:41:23.589+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.589+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.589+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.589+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.589+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.589+0200 I/recorder(12064): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
04-23 20:41:23.589+0200 I/recorder(12064): guardando datos en local
04-23 20:41:23.589+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12064)
04-23 20:41:23.589+0200 I/servicemanager(12059): request sent to service es.ugr.frailty.recorder
04-23 20:41:23.589+0200 I/servicemanager(12059): requesting to save local data
04-23 20:41:23.589+0200 W/AUL     (12097): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12059)
04-23 20:41:23.589+0200 W/AUL     (12070): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:41:23.589+0200 I/linearacceleration(12097): request sent to service es.ugr.frailty.servicemanager
04-23 20:41:23.589+0200 I/CAPI_APPFW_APPLICATION(12097): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:41:23.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:41:23.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:41:23.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.659+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12070
04-23 20:41:23.669+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12059
04-23 20:41:23.669+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.669+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(12059), cmd(0)
04-23 20:41:23.679+0200 W/CAPI_APPFW_APP_CONTROL(12059): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.679+0200 I/utils   (12059): specific action
04-23 20:41:23.679+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:41:23.689+0200 W/AUL     (12070): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12059)
04-23 20:41:23.689+0200 I/accelerometer(12070): request sent to service es.ugr.frailty.servicemanager
04-23 20:41:23.689+0200 I/CAPI_APPFW_APPLICATION(12070): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:41:23.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:23.699+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:23.709+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12064
04-23 20:41:23.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:41:23.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:41:23.719+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:41:23.719+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(12064), cmd(0)
04-23 20:41:23.719+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.719+0200 I/utils   (12064): specific action
04-23 20:41:23.719+0200 W/CAPI_APPFW_APP_CONTROL(12064): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:23.719+0200 I/recorder(12064): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 20:41:23.719+0200 I/recorder(12064): guardando datos en local
04-23 20:41:23.719+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12064)
04-23 20:41:23.719+0200 I/servicemanager(12059): request sent to service es.ugr.frailty.recorder
04-23 20:41:23.719+0200 I/servicemanager(12059): requesting to save local data
04-23 20:41:23.769+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:23.799+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:23.819+0200 W/AUL     (12441): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
04-23 20:41:23.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:23.829+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:23.829+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12110
04-23 20:41:23.829+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:23.829+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12110
04-23 20:41:23.829+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12110)
04-23 20:41:23.839+0200 W/AUL     (12442): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 20:41:23.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:23.839+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:23.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12073
04-23 20:41:23.839+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:23.839+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12073
04-23 20:41:23.839+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12073)
04-23 20:41:23.939+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:23.949+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:41:23.969+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration listener destroyed
04-23 20:41:23.999+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer listener destroyed
04-23 20:41:24.149+0200 W/AUL     (12445): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.linearacceleration]
04-23 20:41:24.149+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:24.149+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:24.149+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12097
04-23 20:41:24.149+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:24.149+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12097
04-23 20:41:24.149+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12097)
04-23 20:41:24.289+0200 W/AUL     (12447): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 20:41:24.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:24.289+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:24.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12070
04-23 20:41:24.289+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:24.289+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12070
04-23 20:41:24.289+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12070)
04-23 20:41:24.899+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:41:25.139+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:41:25.319+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:41:25.589+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:41:25.709+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:41:29.499+0200 I/servicemanager(12059): es.ugr.frailty.location alive timeout
04-23 20:41:29.499+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:41:29.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:29.499+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:29.509+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12456
04-23 20:41:29.509+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:41:29.559+0200 E/CAPI_APPFW_APPLICATION(12456): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:29.559+0200 E/CAPI_APPFW_APPLICATION(12456): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:29.579+0200 W/LOCATION(12456): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:41:29.579+0200 E/LOCATION(12456): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:41:29.579+0200 E/PKGMGR_INFO(12456): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:41:29.579+0200 W/LOCATION(12456): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:29.599+0200 I/LOCATION(12456): location.c: location_new(269) > method: 0
04-23 20:41:29.599+0200 W/LOCATION(12456): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:29.599+0200 W/LOCATION(12456): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:29.609+0200 W/LOCATION(12456): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:29.609+0200 W/LOCATION(12456): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:29.609+0200 W/LOCATION(12456): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:29.619+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12456
04-23 20:41:29.619+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12456) type(svcapp) bg(0)
04-23 20:41:29.619+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12456) was created
04-23 20:41:29.619+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12456)
04-23 20:41:29.619+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12456]
04-23 20:41:29.629+0200 I/servicemanager(12059): es.ugr.frailty.location launch request sent!
04-23 20:41:29.629+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:29.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:29.639+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12456
04-23 20:41:29.639+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:29.639+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:29.639+0200 W/LOCATION(12456): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:29.639+0200 W/LOCATION(12456): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:29.639+0200 W/LOCATION(12456): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:29.639+0200 W/LOCATION(12456): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:29.649+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12456
04-23 20:41:29.649+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:29.689+0200 W/LOCATION(12456): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:29.689+0200 W/LOCATION(12456): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:29.709+0200 W/LOCATION(12456): module-internal.c: module_new(311) > module (wps) open success
04-23 20:41:29.709+0200 W/LOCATION(12456): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:41:29.709+0200 W/LOCATION(12456): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:41:29.709+0200 W/LOCATION(12456): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:29.709+0200 W/LOCATION(12456): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:29.739+0200 W/LOCATION(12456): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:41:29.739+0200 I/LOCATION(12456): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7c7cc18
04-23 20:41:29.739+0200 I/LOCATION(12456): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:41:29.739+0200 I/LOCATION(12456): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7c7cc18
04-23 20:41:29.739+0200 I/LOCATION(12456): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:41:29.749+0200 I/location(12456): es.ugr.frailty.location: creado servicio de localización
04-23 20:41:29.799+0200 I/LOCATION(12456): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:41:29.899+0200 W/LOCATION(12456): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:29.909+0200 W/LOCATION(12456): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:29.909+0200 I/LOCATION(12456): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:30.029+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:41:30.029+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:41:30.029+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:41:30.029+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:41:30.029+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:41:30.029+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:41:30.029+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:30.029+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:30.039+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:41:30.039+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:41:30.039+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:41:30.039+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:41:30.039+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:41:30.039+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:41:30.049+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:41:30.049+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:41:30.049+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:41:30.049+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:41:30.159+0200 W/LOCATION(12456): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:30.159+0200 W/LOCATION(12456): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:30.239+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:30.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:41:30.279+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2965546), time2(2952262)
04-23 20:41:30.279+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:41:30.279+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:41:30.279+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:41:30.279+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:41:30.309+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf794fe28]
04-23 20:41:30.309+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:30.309+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:30.309+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:30.309+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:30.309+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:30.309+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:30.319+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:30.329+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:30.329+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:30.329+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:30.329+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:30.329+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:30.329+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:30.329+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:30.329+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:30.329+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:30.329+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:30.339+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:30.339+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:30.339+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:30.349+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:30.389+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:30.439+0200 W/LOCATION(12456): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:41:30.439+0200 I/LOCATION(12456): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:30.439+0200 I/LOCATION(12456): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:30.439+0200 I/location(12456): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:41:30.539+0200 I/LOCATION(12456): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:30.599+0200 I/location(12456): es.ugr.frailty.location: waiting for rigth values
04-23 20:41:30.599+0200 W/CAPI_APPFW_APP_CONTROL(12456): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:30.599+0200 I/utils   (12456): specific action
04-23 20:41:30.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:30.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:30.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:31.349+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:41:31.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:31.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:31.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:32.139+0200 W/LOCATION(12456): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:41:32.319+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11124566c6f63152450889
