S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20076
Date: 2018-06-07 17:20:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf767052d, r5   = 0xf7d1cf98
r6   = 0xffb78840, r7   = 0xffb786f0
r8   = 0xf7d19c18, r9   = 0x00000000
r10  = 0xffb787cc, fp   = 0xffb78840
ip   = 0x00000001, sp   = 0xffb786c8
lr   = 0xf7670539, pc   = 0xf76d9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    245572 KB
Buffers:      4680 KB
Cached:      55788 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11824 KB
VmRSS:       11824 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20076 TID = 20076
20076 20112 

Maps Information
f453b000 f4d3a000 rw-p [stack:20112]
f4d41000 f4d43000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d4b000 f4d4f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d58000 f4d5a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d62000 f4d65000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d74000 f4d79000 r-xp /usr/lib/libsystem.so.0.0.0
f4d84000 f4d87000 r-xp /lib/libattr.so.1.1.0
f4d8f000 f4d9f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4da7000 f4db0000 r-xp /usr/lib/libedbus.so.1.7.99
f4db8000 f4db9000 r-xp /usr/lib/libresponse.so.0.2.96
f4dc2000 f4dc7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6669000 f676f000 r-xp /usr/lib/libicuuc.so.57.1
f6785000 f690d000 r-xp /usr/lib/libicui18n.so.57.1
f691d000 f692a000 r-xp /usr/lib/libail.so.0.1.0
f6933000 f693a000 r-xp /usr/lib/libminizip.so.1.0.0
f6943000 f6aec000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b0c000 f6b53000 r-xp /usr/lib/libssl.so.1.0.0
f6b5f000 f6b61000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b69000 f6b70000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b79000 f6b80000 r-xp /lib/libcrypt-2.13.so
f6bb1000 f6bb4000 r-xp /lib/libcap.so.2.21
f6bbc000 f6bbe000 r-xp /usr/lib/libiri.so
f6bc6000 f6c0f000 r-xp /usr/lib/libmdm.so.1.2.69
f6c17000 f6c1d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c25000 f6c48000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c52000 f6c54000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c5c000 f6c79000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c82000 f6c86000 r-xp /usr/lib/libsmack.so.1.0.0
f6c8f000 f6ca8000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cb1000 f6cb9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cc1000 f6cc7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cd0000 f6cd2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cdb000 f6ceb000 r-xp /lib/libresolv-2.13.so
f6cef000 f6d07000 r-xp /usr/lib/liblzma.so.5.0.3
f6d10000 f6d12000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d1a000 f6d34000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d3c000 f6d6b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d74000 f6d83000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d8d000 f6d97000 r-xp /usr/lib/libsensord-shared.so
f6da0000 f6e73000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e7e000 f6e94000 r-xp /lib/libz.so.1.2.5
f6e9c000 f6ea1000 r-xp /usr/lib/libffi.so.5.0.10
f6ea9000 f6eaa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6eb2000 f6ec2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6eca000 f6ee3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6eeb000 f6eed000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ef5000 f6f6a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f74000 f6f7a000 r-xp /lib/librt-2.13.so
f6f83000 f6fa1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fab000 f6fac000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fb4000 f6fd7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fdf000 f6fe4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fec000 f7016000 r-xp /usr/lib/libdbus-1.so.3.8.12
f701f000 f7036000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f703e000 f70a7000 r-xp /lib/libm-2.13.so
f70b0000 f7144000 r-xp /usr/lib/libstdc++.so.6.0.16
f7157000 f715c000 r-xp /usr/lib/libctx-client.so.0.8.3
f7164000 f716b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7173000 f719d000 r-xp /usr/lib/libsensor.so.1.9.6
f71a6000 f7272000 r-xp /usr/lib/libxml2.so.2.7.8
f727f000 f7281000 r-xp /usr/lib/libiniparser.so.0
f728a000 f7290000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7299000 f7369000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f736a000 f739e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73a7000 f73e3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73eb000 f73ee000 r-xp /usr/lib/libbundle.so.0.1.22
f73f6000 f73fc000 r-xp /usr/lib/libappsvc.so.0.1.0
f7404000 f7445000 r-xp /usr/lib/libeina.so.1.7.99
f744e000 f7465000 r-xp /usr/lib/libecore.so.1.7.99
f747c000 f7485000 r-xp /usr/lib/libvconf.so.0.2.45
f748d000 f74a1000 r-xp /lib/libpthread-2.13.so
f74ac000 f74b9000 r-xp /usr/lib/libaul.so.0.1.0
f74c3000 f74c5000 r-xp /lib/libdl-2.13.so
f74ce000 f74d9000 r-xp /lib/libunwind.so.8.0.1
f7506000 f750e000 r-xp /lib/libgcc_s-4.6.so.1
f750f000 f7633000 r-xp /lib/libc-2.13.so
f7641000 f7643000 r-xp /usr/lib/libdlog.so.0.0.0
f764b000 f7657000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7660000 f7665000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f766d000 f767c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7684000 f7688000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7691000 f7694000 r-xp /usr/lib/libappcore-agent.so.1.1
f769c000 f769e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76a6000 f76aa000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76b2000 f76cf000 r-xp /lib/ld-2.13.so
f76d8000 f76db000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76db000 f76df000 r-xp /usr/lib/libsys-assert.so
f7ce9000 f7d77000 rw-p [heap]
ffb59000 ffb7a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20076)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76d9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7670539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73773f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7375c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7381e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7387be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7387dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73bc75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73b71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7375c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7381e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7387be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7387dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73b9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73ba017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73c1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d591fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d4c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e1f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72ccfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72ce7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf745eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7459b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf745a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf745a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7692183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76927fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76d95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf752685c) [/lib/libc.so.6] + 0x1785c
29: (0xf76d8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:20:39.431+0200 W/LOCATION(20194): module-internal.c: module_is_supported(340) > module name(wps) is found
06-07 17:20:39.431+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:39.431+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:39.431+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:20:39.441+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:39.441+0200 I/utils   (19621): specific action
06-07 17:20:39.441+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:39.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(19621), cmd(0)
06-07 17:20:39.451+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:39:455,0.140000,0.070000,-0.070000
06-07 17:20:39.461+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:398,0.024092,0.005176,0.037910
06-07 17:20:39.461+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:39:451,0.308808,-0.092346,9.801352
06-07 17:20:39.461+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:39.461+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.471+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:476,-0.000470,0.011926,0.025961
06-07 17:20:39.481+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:39.481+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:39.481+0200 W/LOCATION(20194): module-internal.c: module_new(311) > module (wps) open success
06-07 17:20:39.491+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:39.491+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:39:496,721.000000
06-07 17:20:39.501+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:20:39.501+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:20:39.501+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:39.501+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:20:39.501+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:20:39.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:39.501+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:39.501+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.501+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:39:476,0.287139,-0.141177,9.834501
06-07 17:20:39.511+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:39.511+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20194
06-07 17:20:39.521+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:39.531+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.531+0200 W/LOCATION(20194): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
06-07 17:20:39.531+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:540,-0.009576,-0.007976,0.054653
06-07 17:20:39.551+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:39:517,0.310348,-0.092922,9.801297
06-07 17:20:39.551+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:39:518,0.070000,0.070000,0.070000
06-07 17:20:39.561+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:39.561+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.571+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20194)
06-07 17:20:39.571+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:20:39.571+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:39.571+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:20:39.571+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:20:39.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:39.571+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:39.571+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:39:549,0.323031,-0.086142,9.836893
06-07 17:20:39.581+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19983
06-07 17:20:39.581+0200 W/LOCATION(20194): module-internal.c: module_new(311) > module (remote_wps) open success
06-07 17:20:39.581+0200 W/LOCATION(20194): location-wps.c: __update_remote_connection_status(215) > update FALSE
06-07 17:20:39.581+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:39.581+0200 W/LOCATION(20194): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
06-07 17:20:39.601+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.601+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:606,0.020300,-0.022300,0.035475
06-07 17:20:39.611+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:39:577,0.310363,-0.093589,9.801291
06-07 17:20:39.611+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:39:577,0.070000,0.070000,0.070000
06-07 17:20:39.611+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:39.621+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.621+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:39:617,0.358923,-0.119641,9.827322
06-07 17:20:39.631+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:39:635,0.140000,0.070000,0.070000
06-07 17:20:39.651+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19983)
06-07 17:20:39.651+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:20:39.651+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:39.651+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:20:39.651+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:20:39.651+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:39.651+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:39.651+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.651+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:660,-0.001585,-0.002454,0.061814
06-07 17:20:39.661+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:39.661+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19995
06-07 17:20:39.661+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:39:630,0.310037,-0.095428,9.801283
06-07 17:20:39.661+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.671+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:39.671+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:39.681+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:39:667,0.308674,-0.074178,9.815358
06-07 17:20:39.681+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:39.691+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:39:694,717.000000
06-07 17:20:39.701+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:39.701+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19995)
06-07 17:20:39.701+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:20:39.701+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:39.701+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:20:39.701+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:20:39.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:39.711+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.711+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:39.711+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:39.721+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:20:39.721+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:39:706,0.310223,-0.092604,9.801305
06-07 17:20:39.741+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:39:705,0.140000,0.070000,0.070000
06-07 17:20:39.741+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.741+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:718,-0.015152,-0.024229,0.064180
06-07 17:20:39.741+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:39.751+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:39:756,0.140000,-0.070000,0.070000
06-07 17:20:39.761+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.771+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:39.771+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19663), cmd(0)
06-07 17:20:39.771+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:39:731,0.351745,-0.074178,9.848858
06-07 17:20:39.771+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:39.781+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:39.781+0200 I/utils   (19663): specific action
06-07 17:20:39.781+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:20:39.781+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:20:39.781+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:39.781+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:20:39.781+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:20:39.781+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:39.781+0200 W/LOCATION(20194): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
06-07 17:20:39.781+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:39.781+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:39:790,0.323031,-0.112463,9.865608
06-07 17:20:39.791+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:20:39.791+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:39:766,0.310023,-0.091943,9.801317
06-07 17:20:39.791+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.791+0200 I/LOCATION(20194): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf775fc18
06-07 17:20:39.791+0200 I/LOCATION(20194): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
06-07 17:20:39.801+0200 I/LOCATION(20194): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf775fc18
06-07 17:20:39.801+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:39.801+0200 I/LOCATION(20194): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
06-07 17:20:39.801+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:39.801+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19670), cmd(0)
06-07 17:20:39.801+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:772,0.012361,-0.008911,0.049796
06-07 17:20:39.811+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.821+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:830,0.026815,0.005516,0.059365
06-07 17:20:39.831+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:39.831+0200 I/utils   (19670): specific action
06-07 17:20:39.831+0200 I/location(20194): es.ugr.frailty.location: creado servicio de localización
06-07 17:20:39.831+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:39.841+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:39:812,0.140000,0.070000,0.070000
06-07 17:20:39.841+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.851+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:20:39.851+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:20:39.851+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:39.851+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:20:39.851+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:20:39.851+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:39:820,0.310378,-0.091823,9.801307
06-07 17:20:39.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:39.851+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:39.861+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:20:39.871+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:39.871+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:39:846,0.363709,-0.112463,9.827322
06-07 17:20:39.871+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:39.871+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:39.881+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:39.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19682), cmd(0)
06-07 17:20:39.881+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:39.891+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:39:894,706.000000
06-07 17:20:39.891+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:39.901+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:39.901+0200 I/utils   (19682): specific action
06-07 17:20:39.911+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:39:869,-0.070000,-0.070000,0.140000
06-07 17:20:39.921+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:20:39.921+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:20:39.921+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:39.921+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:881,0.031340,0.002366,0.068936
06-07 17:20:39.921+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:39:880,0.310873,-0.093054,9.801280
06-07 17:20:39.921+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.921+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:39:924,0.284746,-0.095713,9.827322
06-07 17:20:39.941+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.941+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:39.961+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:39:965,0.013676,0.033167,0.030677
06-07 17:20:39.961+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:39.981+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:39:943,0.140000,0.140000,0.140000
06-07 17:20:39.991+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:39.991+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:39:950,0.310531,-0.093879,9.801283
06-07 17:20:39.991+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:39.991+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.001+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:39:993,0.308674,-0.124427,9.801002
06-07 17:20:40.001+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:4,0.310295,-0.095053,9.801279
06-07 17:20:40.001+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.011+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:0,0.070000,0.140000,0.070000
06-07 17:20:40.021+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.031+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:7,0.016658,0.009404,0.052172
06-07 17:20:40.031+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.031+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:24,0.291924,-0.117248,9.832108
06-07 17:20:40.051+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:60,0.312065,-0.093596,9.801236
06-07 17:20:40.061+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.061+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.071+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:40.071+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:40.071+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:43,0.070000,0.140000,0.070000
06-07 17:20:40.081+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.081+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.081+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:40.091+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:40:94,707.000000
06-07 17:20:40.091+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:66,0.016402,-0.003200,0.016281
06-07 17:20:40.101+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.111+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:82,0.323031,-0.129212,9.841680
06-07 17:20:40.111+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:114,0.312909,-0.094311,9.801203
06-07 17:20:40.131+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.131+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:140,0.314729,-0.095202,9.801136
06-07 17:20:40.141+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.141+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:146,0.312547,-0.093125,9.801226
06-07 17:20:40.141+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.151+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:152,0.312276,-0.093511,9.801230
06-07 17:20:40.151+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.151+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:159,0.312966,-0.093853,9.801206
06-07 17:20:40.151+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.161+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:164,0.312045,-0.092391,9.801249
06-07 17:20:40.161+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.161+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:170,0.311745,-0.091003,9.801271
06-07 17:20:40.161+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.171+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:175,0.311356,-0.090925,9.801285
06-07 17:20:40.171+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.171+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:180,0.310276,-0.091156,9.801316
06-07 17:20:40.181+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.181+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:186,0.309209,-0.092661,9.801336
06-07 17:20:40.181+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.181+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:191,0.311309,-0.092956,9.801267
06-07 17:20:40.191+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.191+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:196,0.309915,-0.092174,9.801318
06-07 17:20:40.191+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.191+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:202,0.309584,-0.092000,9.801331
06-07 17:20:40.201+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.211+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.211+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:117,-0.010107,0.020677,0.037821
06-07 17:20:40.211+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:216,0.272782,-0.066999,9.844072
06-07 17:20:40.211+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:106,0.140000,0.070000,0.070000
06-07 17:20:40.221+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.231+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.241+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:242,0.070000,0.070000,0.140000
06-07 17:20:40.241+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.241+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:223,0.310333,-0.091732,9.801310
06-07 17:20:40.251+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:255,0.315853,-0.112463,9.834501
06-07 17:20:40.251+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:242,0.036431,0.062529,0.013848
06-07 17:20:40.251+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.261+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.271+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.271+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:274,0.070000,0.070000,0.140000
06-07 17:20:40.271+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:40.271+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:40.281+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.281+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:40.291+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:40:295,714.000000
06-07 17:20:40.311+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:265,0.310377,-0.092076,9.801305
06-07 17:20:40.311+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.311+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:276,0.026094,0.006766,-0.000514
06-07 17:20:40.321+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.341+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.341+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:347,0.070000,0.070000,0.070000
06-07 17:20:40.351+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:356,-0.036711,-0.000918,0.076070
06-07 17:20:40.351+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:308,0.342174,-0.110070,9.832108
06-07 17:20:40.351+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.351+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:326,0.310110,-0.091144,9.801322
06-07 17:20:40.361+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.381+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.381+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.391+0200 I/LOCATION(20194): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
06-07 17:20:40.391+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:365,0.323031,-0.093320,9.841680
06-07 17:20:40.401+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.401+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:391,0.070000,0.070000,0.070000
06-07 17:20:40.401+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:394,0.032742,-0.010651,0.064029
06-07 17:20:40.411+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:384,0.307472,-0.090857,9.801408
06-07 17:20:40.411+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.411+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.431+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:437,0.307744,-0.090125,9.801406
06-07 17:20:40.431+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.441+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:449,0.048607,0.008774,0.071238
06-07 17:20:40.451+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:421,0.330210,-0.129212,9.839286
06-07 17:20:40.461+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:444,0.140000,0.070000,0.070000
06-07 17:20:40.461+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.461+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.471+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.471+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:40.471+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:40.481+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.481+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:40.501+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:40:497,727.000000
06-07 17:20:40.511+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:474,0.301496,-0.129212,9.824929
06-07 17:20:40.511+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:478,0.308007,-0.089180,9.801406
06-07 17:20:40.511+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.511+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.521+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:490,0.022783,-0.025261,0.066504
06-07 17:20:40.521+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:488,0.070000,0.070000,0.070000
06-07 17:20:40.541+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.541+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.541+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:537,0.287139,-0.141177,9.834501
06-07 17:20:40.551+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19935) cmd(0)
06-07 17:20:40.561+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:537,0.307851,-0.090414,9.801400
06-07 17:20:40.571+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.571+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.581+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:560,-0.070000,-0.070000,0.070000
06-07 17:20:40.591+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:564,0.014640,-0.040986,0.035438
06-07 17:20:40.591+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.591+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.591+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20019) cmd(0)
06-07 17:20:40.611+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:586,0.308535,-0.089647,9.801385
06-07 17:20:40.641+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:589,0.306281,-0.126820,9.810574
06-07 17:20:40.641+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.641+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.651+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:604,0.070000,0.140000,0.070000
06-07 17:20:40.651+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:657,0.308489,-0.091085,9.801373
06-07 17:20:40.651+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:606,0.000110,-0.001126,0.037850
06-07 17:20:40.661+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.661+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.671+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.671+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:661,0.294317,-0.112463,9.834501
06-07 17:20:40.671+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:40.671+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:40.681+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:671,0.038855,-0.025191,0.023478
06-07 17:20:40.681+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:40.691+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:40:695,727.000000
06-07 17:20:40.701+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.701+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:709,0.296710,-0.107677,9.815358
06-07 17:20:40.701+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:670,0.070000,0.140000,0.070000
06-07 17:20:40.711+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.711+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.721+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:730,0.023009,-0.026588,0.064213
06-07 17:20:40.731+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:690,0.309898,-0.092454,9.801316
06-07 17:20:40.741+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.741+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:725,0.070000,0.070000,0.140000
06-07 17:20:40.741+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.751+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:755,0.344566,-0.105284,9.822537
06-07 17:20:40.751+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.771+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.771+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:751,0.312011,-0.094047,9.801234
06-07 17:20:40.781+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.781+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:780,-0.031110,0.008303,0.057094
06-07 17:20:40.781+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.801+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:776,0.070000,0.070000,0.070000
06-07 17:20:40.801+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19983) cmd(0)
06-07 17:20:40.801+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.801+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.831+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:795,0.313500,-0.093346,9.801193
06-07 17:20:40.831+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:801,0.301496,-0.052642,9.822537
06-07 17:20:40.831+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.831+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:825,0.070000,0.070000,0.070000
06-07 17:20:40.841+0200 W/LOCATION(20194): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-07 17:20:40.841+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.841+0200 W/LOCATION(20194): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-07 17:20:40.841+0200 I/LOCATION(20194): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 17:20:40.841+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.851+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:825,-0.015584,0.020026,0.013984
06-07 17:20:40.851+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.851+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:845,0.312169,-0.093797,9.801231
06-07 17:20:40.861+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:40.861+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:860,-0.070000,0.070000,0.070000
06-07 17:20:40.861+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:856,0.330210,-0.131605,9.851252
06-07 17:20:40.861+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:40.871+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:40.871+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:40.871+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:40.871+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19995) cmd(0)
06-07 17:20:40.881+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:40.891+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:40:895,727.000000
06-07 17:20:40.901+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:862,0.032915,0.021570,0.071383
06-07 17:20:40.921+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.921+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:927,0.022705,-0.022852,0.071391
06-07 17:20:40.951+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.961+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:956,0.050292,0.023779,-0.036241
06-07 17:20:40.981+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:40.981+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:40:991,-0.004104,-0.020518,0.011660
06-07 17:20:41.001+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:41.001+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:40:873,0.313853,-0.093670,9.801179
06-07 17:20:41.011+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:40:876,0.325424,-0.074178,9.836893
06-07 17:20:41.021+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:41.031+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:40:885,0.070000,-0.070000,0.070000
06-07 17:20:41.031+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:41.051+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:41.051+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:41:53,0.313523,-0.092984,9.801196
06-07 17:20:41.061+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:41:26,0.015334,-0.000526,0.100194
06-07 17:20:41.031+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:41:40,0.344566,-0.074178,9.829715
06-07 17:20:41.061+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:41.071+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:41.071+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:41.091+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:41.101+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:41:62,0.070000,-0.070000,0.070000
06-07 17:20:41.101+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:41.111+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:41.121+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:41:71,0.008010,-0.019860,0.069090
06-07 17:20:41.131+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:41.131+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:41:140,726.000000
06-07 17:20:41.161+0200 W/libgps_d( 3131): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
06-07 17:20:41.161+0200 W/libgps  ( 3131): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
06-07 17:20:41.161+0200 W/libgps_d( 3131): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
06-07 17:20:41.161+0200 W/libgps_d( 3131): GpsiHookStateIdle             : EXIT
06-07 17:20:41.161+0200 W/libgps_d( 3131): GpsiHookStateGps              : ENTRY
06-07 17:20:41.161+0200 W/libgps  ( 3131): [proxy__gps_start][line = 1022]: called.
06-07 17:20:41.161+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:20:41.161+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:20:41.161+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:26
06-07 17:20:41.161+0200 D/gpsd_d  ( 3111): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
06-07 17:20:41.161+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:27
06-07 17:20:41.161+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:8
06-07 17:20:41.161+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:1
06-07 17:20:41.171+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 17:20:41.171+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
06-07 17:20:41.171+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(11), data(0xf7cebb38), size(4)
06-07 17:20:41.171+0200 W/libgps_d( 3131): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
06-07 17:20:41.171+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
06-07 17:20:41.171+0200 W/libgps_d( 3131): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
06-07 17:20:41.201+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:41:206,0.070000,0.140000,0.070000
06-07 17:20:41.201+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:41.231+0200 W/LOCATION(20194): location-wps.c: __update_remote_connection_status(215) > update FALSE
06-07 17:20:41.231+0200 W/LOCATION(20194): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
06-07 17:20:41.271+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:41.271+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:41.281+0200 W/LOCATION(20194): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-07 17:20:41.281+0200 I/LOCATION(20194): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-07 17:20:41.281+0200 I/LOCATION(20194): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-07 17:20:41.281+0200 I/location(20194): es.ugr.frailty.location:iniciado servicio de localización
06-07 17:20:41.281+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:41.291+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:41:294,723.000000
06-07 17:20:41.311+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:41:123,0.308674,-0.107677,9.868000
06-07 17:20:41.311+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:41:112,0.311320,-0.092443,9.801271
06-07 17:20:41.321+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:41.321+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:41.321+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:41.341+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:41:330,0.005704,0.004798,0.049952
06-07 17:20:41.351+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:41:339,0.318245,-0.093320,9.887143
06-07 17:20:41.351+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:41:335,0.309964,-0.093535,9.801304
06-07 17:20:41.351+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:41.361+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:41.361+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:41:211,0.140000,0.070000,0.070000
06-07 17:20:41.371+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:41.391+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:41.401+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:41:375,-0.006032,0.018732,0.023618
06-07 17:20:41.401+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:41:374,0.308707,-0.093902,9.801340
06-07 17:20:41.401+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:41.421+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:41.421+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:41:385,0.303888,-0.122034,9.815358
06-07 17:20:41.441+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:41:405,0.140000,0.070000,0.070000
06-07 17:20:41.441+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:41.441+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:41.451+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:41:429,0.308152,-0.095033,9.801347
06-07 17:20:41.451+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
06-07 17:20:41.451+0200 W/libgps  ( 3131): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(8666226), time2(8649275)
06-07 17:20:41.451+0200 W/libgps  ( 3131): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
06-07 17:20:41.451+0200 W/libgps  ( 3131): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
06-07 17:20:41.451+0200 I/libgps_d( 3131): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
06-07 17:20:41.451+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:25
06-07 17:20:41.461+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:41:438,0.023408,-0.001498,0.078620
06-07 17:20:41.461+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:41.461+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:41:448,0.311067,-0.129212,9.824929
06-07 17:20:41.461+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:41.471+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:41:475,0.310526,-0.096266,9.801260
06-07 17:20:41.471+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:41:453,0.140000,-0.070000,0.070000
06-07 17:20:41.471+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:41.471+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:41.481+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:41.491+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:41:495,742.000000
06-07 17:20:41.491+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:41.501+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:41.511+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:41:509,0.354138,-0.112463,9.870394
06-07 17:20:41.511+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:41.531+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:41.531+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:41:491,-0.056102,-0.018380,0.107349
06-07 17:20:41.581+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11200766c6f63152838480
