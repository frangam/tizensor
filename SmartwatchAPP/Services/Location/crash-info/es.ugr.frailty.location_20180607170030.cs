S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14227
Date: 2018-06-07 17:00:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf762e52d, r5   = 0xf7da4f98
r6   = 0xffbcf460, r7   = 0xffbcf310
r8   = 0xf7da1c18, r9   = 0x00000000
r10  = 0xffbcf3ec, fp   = 0xffbcf460
ip   = 0x00000001, sp   = 0xffbcf2e8
lr   = 0xf762e539, pc   = 0xf7697228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      4256 KB
Buffers:      8496 KB
Cached:      45628 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11484 KB
VmRSS:       11484 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14227 TID = 14227
14227 14231 

Maps Information
f44f9000 f4cf8000 rw-p [stack:14231]
f4cff000 f4d01000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d09000 f4d0d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d16000 f4d18000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d20000 f4d23000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d32000 f4d37000 r-xp /usr/lib/libsystem.so.0.0.0
f4d42000 f4d45000 r-xp /lib/libattr.so.1.1.0
f4d4d000 f4d5d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d65000 f4d6e000 r-xp /usr/lib/libedbus.so.1.7.99
f4d76000 f4d77000 r-xp /usr/lib/libresponse.so.0.2.96
f4d80000 f4d85000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6627000 f672d000 r-xp /usr/lib/libicuuc.so.57.1
f6743000 f68cb000 r-xp /usr/lib/libicui18n.so.57.1
f68db000 f68e8000 r-xp /usr/lib/libail.so.0.1.0
f68f1000 f68f8000 r-xp /usr/lib/libminizip.so.1.0.0
f6901000 f6aaa000 r-xp /usr/lib/libcrypto.so.1.0.0
f6aca000 f6b11000 r-xp /usr/lib/libssl.so.1.0.0
f6b1d000 f6b1f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b27000 f6b2e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b37000 f6b3e000 r-xp /lib/libcrypt-2.13.so
f6b6f000 f6b72000 r-xp /lib/libcap.so.2.21
f6b7a000 f6b7c000 r-xp /usr/lib/libiri.so
f6b84000 f6bcd000 r-xp /usr/lib/libmdm.so.1.2.69
f6bd5000 f6bdb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6be3000 f6c06000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c10000 f6c12000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c1a000 f6c37000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c40000 f6c44000 r-xp /usr/lib/libsmack.so.1.0.0
f6c4d000 f6c66000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c6f000 f6c77000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c7f000 f6c85000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c8e000 f6c90000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c99000 f6ca9000 r-xp /lib/libresolv-2.13.so
f6cad000 f6cc5000 r-xp /usr/lib/liblzma.so.5.0.3
f6cce000 f6cd0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cd8000 f6cf2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cfa000 f6d29000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d32000 f6d41000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d4b000 f6d55000 r-xp /usr/lib/libsensord-shared.so
f6d5e000 f6e31000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e3c000 f6e52000 r-xp /lib/libz.so.1.2.5
f6e5a000 f6e5f000 r-xp /usr/lib/libffi.so.5.0.10
f6e67000 f6e68000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e70000 f6e80000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e88000 f6ea1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ea9000 f6eab000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6eb3000 f6f28000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f32000 f6f38000 r-xp /lib/librt-2.13.so
f6f41000 f6f5f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f69000 f6f6a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f72000 f6f95000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f9d000 f6fa2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6faa000 f6fd4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fdd000 f6ff4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ffc000 f7065000 r-xp /lib/libm-2.13.so
f706e000 f7102000 r-xp /usr/lib/libstdc++.so.6.0.16
f7115000 f711a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7122000 f7129000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7131000 f715b000 r-xp /usr/lib/libsensor.so.1.9.6
f7164000 f7230000 r-xp /usr/lib/libxml2.so.2.7.8
f723d000 f723f000 r-xp /usr/lib/libiniparser.so.0
f7248000 f724e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7257000 f7327000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7328000 f735c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7365000 f73a1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73a9000 f73ac000 r-xp /usr/lib/libbundle.so.0.1.22
f73b4000 f73ba000 r-xp /usr/lib/libappsvc.so.0.1.0
f73c2000 f7403000 r-xp /usr/lib/libeina.so.1.7.99
f740c000 f7423000 r-xp /usr/lib/libecore.so.1.7.99
f743a000 f7443000 r-xp /usr/lib/libvconf.so.0.2.45
f744b000 f745f000 r-xp /lib/libpthread-2.13.so
f746a000 f7477000 r-xp /usr/lib/libaul.so.0.1.0
f7481000 f7483000 r-xp /lib/libdl-2.13.so
f748c000 f7497000 r-xp /lib/libunwind.so.8.0.1
f74c4000 f74cc000 r-xp /lib/libgcc_s-4.6.so.1
f74cd000 f75f1000 r-xp /lib/libc-2.13.so
f75ff000 f7601000 r-xp /usr/lib/libdlog.so.0.0.0
f7609000 f7615000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f761e000 f7623000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f762b000 f763a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7642000 f7646000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f764f000 f7652000 r-xp /usr/lib/libappcore-agent.so.1.1
f765a000 f765c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7664000 f7668000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7670000 f768d000 r-xp /lib/ld-2.13.so
f7696000 f7699000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7699000 f769d000 r-xp /usr/lib/libsys-assert.so
f7d71000 f7ddf000 rw-p [heap]
ffbb0000 ffbd1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14227)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7697228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf762e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73353f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7333c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf733fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7345be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7345dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf737a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73751f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7333c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf733fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7345be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7345dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7377e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7378017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf737ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d171fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d0a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ddd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf728afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf728c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf741cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7417b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74185a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7418879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7650183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76507fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76975c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf74e485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7696f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.gravity: SM-R760,07/06/2018,17:00:29:913,2.211793,-0.695334,9.528634
06-07 17:00:29.911+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:29.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 17:00:29.911+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:29.911+0200 I/utils   (12595): specific action
06-07 17:00:29.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 17:00:29.911+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:00:29.911+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:29.911+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:29.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12595), cmd(0)
06-07 17:00:29.911+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:00:29.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:00:29.911+0200 I/utils   (14069): specific action
06-07 17:00:29.911+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:29.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:29.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:29.921+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:29.921+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:29:928,0.091871,-0.040241,0.022307
06-07 17:00:29.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14227
06-07 17:00:29.941+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:29:925,2.364109,-0.725025,9.568897
06-07 17:00:29.941+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:29.941+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:29:950,2.342573,-0.667598,9.525827
06-07 17:00:29.951+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:29:888,0.770000,-0.350000,-0.560000
06-07 17:00:29.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:29.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14151), cmd(0)
06-07 17:00:29.951+0200 W/CAPI_APPFW_APP_CONTROL(14151): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:29.951+0200 I/utils   (14151): specific action
06-07 17:00:29.951+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:29.951+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:29:958,-0.420000,0.840000,-0.630000
06-07 17:00:29.961+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:29.961+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:29.961+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:29:970,2.309074,-0.734596,9.549755
06-07 17:00:29.971+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:29:966,-0.560000,0.350000,-0.420000
06-07 17:00:29.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14227)
06-07 17:00:29.981+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:00:29.981+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:29.981+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:00:29.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:00:29.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:29.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:29.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14164
06-07 17:00:30.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14164)
06-07 17:00:30.001+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:00:30.001+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:30.001+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:00:30.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:00:30.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:30.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:30.001+0200 W/CAPI_APPFW_APP_CONTROL(14227): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:30.001+0200 I/utils   (14227): specific action
06-07 17:00:30.001+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:30.011+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:30:14,83
06-07 17:00:30.011+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14114
06-07 17:00:30.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:30.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(14227), cmd(0)
06-07 17:00:30.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14114)
06-07 17:00:30.011+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:00:30.021+0200 W/CAPI_APPFW_APP_CONTROL(14164): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:30.021+0200 I/utils   (14164): specific action
06-07 17:00:30.021+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:30.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14164), cmd(0)
06-07 17:00:30.021+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:30.021+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:00:30.021+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:30.021+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:29:920,2.217203,-0.694356,9.527448
06-07 17:00:30.021+0200 W/CAPI_APPFW_APP_CONTROL(14114): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:30.021+0200 I/utils   (14114): specific action
06-07 17:00:30.021+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:30.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(14114), cmd(0)
06-07 17:00:30.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:00:30.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:30.031+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:30.031+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:27,0.115475,0.019869,0.097871
06-07 17:00:30.031+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.031+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:22,0.630000,0.630000,-0.560000
06-07 17:00:30.031+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:00:30.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:30.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12603), cmd(0)
06-07 17:00:30.041+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:30.041+0200 I/utils   (12603): specific action
06-07 17:00:30.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:00:30.041+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:30:29,747.000000
06-07 17:00:30.041+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:00:30.041+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:30.041+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:00:30.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:00:30.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:30.051+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:30.051+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:44,0.910000,0.070000,-0.420000
06-07 17:00:30.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:00:30.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:00:30.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:00:30.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 17:00:30.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 17:00:30.071+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:33,2.222312,-0.697038,9.526062
06-07 17:00:30.071+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.071+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.071+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:39,0.078631,0.031223,0.059587
06-07 17:00:30.071+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:00:30.071+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:30.071+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:00:30.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:00:30.071+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.071+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:30.071+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:30.081+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:79,0.700000,-0.630000,-0.210000
06-07 17:00:30.081+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.081+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:77,2.223264,-0.694035,9.526059
06-07 17:00:30.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:00:30.091+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:30.091+0200 I/utils   (12618): specific action
06-07 17:00:30.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:30.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12618), cmd(0)
06-07 17:00:30.091+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:00:30.091+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:00:30.091+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:30.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:30.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12614), cmd(0)
06-07 17:00:30.091+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:30.091+0200 I/utils   (12614): specific action
06-07 17:00:30.091+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.091+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:101,2.337788,-0.677169,9.623933
06-07 17:00:30.101+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.101+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:107,2.301895,-0.662812,9.585647
06-07 17:00:30.101+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.111+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:112,2.316252,-0.646062,9.583255
06-07 17:00:30.111+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.111+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:118,2.311467,-0.617348,9.561719
06-07 17:00:30.111+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.121+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.121+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:124,2.325824,-0.653241,9.561719
06-07 17:00:30.121+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.121+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:130,2.337788,-0.610170,9.549755
06-07 17:00:30.121+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:86,0.093024,0.044213,0.056914
06-07 17:00:30.131+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.131+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.131+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:90,0.770000,-0.630000,-0.140000
06-07 17:00:30.131+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:137,2.323431,-0.650848,9.585647
06-07 17:00:30.131+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.141+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:143,2.321038,-0.660419,9.540184
06-07 17:00:30.141+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.141+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:149,2.344966,-0.607777,9.571291
06-07 17:00:30.141+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.151+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:155,2.335395,-0.674776,9.566505
06-07 17:00:30.151+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.151+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:132,2.223228,-0.690275,9.526340
06-07 17:00:30.151+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.161+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:161,2.299503,-0.653241,9.561719
06-07 17:00:30.161+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.161+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.161+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:141,0.085718,0.069276,0.035704
06-07 17:00:30.161+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:167,2.359323,-0.669990,9.635897
06-07 17:00:30.161+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.171+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:167,0.910000,-0.490000,0.070000
06-07 17:00:30.171+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.171+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:175,0.098005,0.028485,0.035835
06-07 17:00:30.181+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:168,2.225748,-0.686624,9.526015
06-07 17:00:30.181+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.181+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:183,2.287539,-0.631705,9.595219
06-07 17:00:30.181+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.181+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.181+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:190,0.350000,-0.350000,0.210000
06-07 17:00:30.181+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.191+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:188,2.227819,-0.681726,9.525884
06-07 17:00:30.191+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:192,0.108182,0.068321,0.024058
06-07 17:00:30.191+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.191+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.201+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:203,2.337788,-0.650848,9.525827
06-07 17:00:30.201+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:195,0.350000,-0.140000,0.350000
06-07 17:00:30.201+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.211+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:212,0.140000,-0.140000,0.350000
06-07 17:00:30.211+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.211+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:218,0.140000,0.070000,-0.210000
06-07 17:00:30.211+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.221+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:222,-0.350000,0.350000,-0.140000
06-07 17:00:30.221+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.221+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:30.221+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:30.221+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:30:230,748.000000
06-07 17:00:30.231+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.231+0200 W/LOCATION(14227): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:00:30.231+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:235,2.347359,-0.641276,9.566505
06-07 17:00:30.231+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:30:231,84
06-07 17:00:30.231+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.241+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:229,-0.420000,0.140000,-0.140000
06-07 17:00:30.241+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.241+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.241+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:243,2.385644,-0.684347,9.619147
06-07 17:00:30.251+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:207,2.229606,-0.678491,9.525697
06-07 17:00:30.251+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:250,-0.420000,0.140000,-0.280000
06-07 17:00:30.251+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.251+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.251+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:258,0.770000,-0.140000,-0.280000
06-07 17:00:30.251+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.251+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:249,0.090253,0.023706,0.060508
06-07 17:00:30.251+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.261+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:264,2.294717,-0.727418,9.604790
06-07 17:00:30.261+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.261+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:270,0.560000,-0.210000,0.140000
06-07 17:00:30.261+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.271+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:265,2.233178,-0.674554,9.525139
06-07 17:00:30.271+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:269,0.085834,0.012180,0.015382
06-07 17:00:30.271+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:275,-1.610000,-0.210000,0.280000
06-07 17:00:30.271+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.271+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.271+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.271+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.281+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:283,2.335395,-0.696311,9.566505
06-07 17:00:30.281+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:280,-1.330000,0.070000,0.070000
06-07 17:00:30.281+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.291+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:292,0.560000,0.490000,-0.070000
06-07 17:00:30.291+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.291+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:288,0.106725,0.063989,0.047143
06-07 17:00:30.291+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:286,2.235204,-0.672599,9.524802
06-07 17:00:30.291+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:297,0.770000,0.420000,-0.140000
06-07 17:00:30.291+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.291+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.291+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.301+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:303,2.318645,-0.672383,9.542577
06-07 17:00:30.301+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.301+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:308,0.140000,-0.140000,0.070000
06-07 17:00:30.301+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:304,2.238241,-0.671766,9.524148
06-07 17:00:30.301+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:307,0.093741,-0.006616,0.042907
06-07 17:00:30.311+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.311+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.311+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:316,2.241654,-0.668160,9.523599
06-07 17:00:30.311+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.311+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:320,0.053747,0.015606,0.039135
06-07 17:00:30.311+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:321,2.245755,-0.668847,9.522584
06-07 17:00:30.321+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.321+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.321+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.321+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.321+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:331,2.342573,-0.629312,9.561719
06-07 17:00:30.331+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:328,0.420000,0.070000,0.070000
06-07 17:00:30.331+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:331,0.110519,-0.001269,0.114023
06-07 17:00:30.331+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.331+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.331+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:00:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:00:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:00:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:00:30.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390830350,000000, pattern:[H:mm][0;m
06-07 17:00:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:00:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:00:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:00:30.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:00:30.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:00:30.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:00][0;m
06-07 17:00:30.351+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:344,0.033873,0.037388,0.074521
06-07 17:00:30.351+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:344,2.342573,-0.602991,9.588040
06-07 17:00:30.351+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.351+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:326,2.248804,-0.668722,9.521873
06-07 17:00:30.351+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.351+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:342,1.050000,0.140000,0.140000
06-07 17:00:30.351+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:358,0.085521,0.014581,0.004541
06-07 17:00:30.351+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.361+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.361+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.361+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:366,2.347359,-0.557528,9.568897
06-07 17:00:30.361+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:368,0.093006,0.022343,0.045588
06-07 17:00:30.361+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:365,0.490000,-0.280000,0.140000
06-07 17:00:30.371+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:360,2.253666,-0.669093,9.520698
06-07 17:00:30.371+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.371+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.371+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.371+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.381+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:379,2.252266,-0.665429,9.521286
06-07 17:00:30.381+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.381+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:387,2.254353,-0.663620,9.520918
06-07 17:00:30.381+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.381+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:386,2.323431,-0.605384,9.525827
06-07 17:00:30.391+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:392,2.263394,-0.665822,9.518620
06-07 17:00:30.391+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:384,-0.350000,-0.280000,0.070000
06-07 17:00:30.391+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.391+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:398,2.271877,-0.669035,9.516373
06-07 17:00:30.391+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.391+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.401+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.401+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:382,0.122251,-0.018525,0.100528
06-07 17:00:30.401+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:404,2.269162,-0.670172,9.516940
06-07 17:00:30.401+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.401+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.401+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:30.401+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:410,2.268251,-0.669451,9.517208
06-07 17:00:30.411+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:30:411,84
06-07 17:00:30.411+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.411+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:404,0.350000,0.210000,-0.070000
06-07 17:00:30.411+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:416,2.269959,-0.669247,9.516815
06-07 17:00:30.411+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.421+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:422,2.270980,-0.666307,9.516778
06-07 17:00:30.421+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.421+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:30.421+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:417,2.313859,-0.646062,9.588040
06-07 17:00:30.421+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:30:429,747.000000
06-07 17:00:30.431+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:426,0.022840,-0.058383,0.088417
06-07 17:00:30.431+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.431+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:427,2.269315,-0.660888,9.517553
06-07 17:00:30.431+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.431+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.431+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:440,2.270819,-0.654905,9.517608
06-07 17:00:30.441+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.441+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.441+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:436,0.280000,0.560000,-0.210000
06-07 17:00:30.441+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:447,2.274678,-0.653313,9.516796
06-07 17:00:30.441+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.451+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:452,2.274043,-0.651921,9.517043
06-07 17:00:30.451+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:451,0.066233,-0.026139,0.049565
06-07 17:00:30.451+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.451+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.451+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:458,2.275298,-0.648307,9.516990
06-07 17:00:30.451+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.461+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:446,2.349752,-0.593420,9.516255
06-07 17:00:30.461+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:464,2.279588,-0.648369,9.515959
06-07 17:00:30.461+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.461+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.461+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.461+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:470,2.283025,-0.649655,9.515047
06-07 17:00:30.471+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:476,2.347359,-0.629312,9.559326
06-07 17:00:30.471+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:466,-0.630000,0.350000,-0.210000
06-07 17:00:30.471+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.471+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.481+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:474,0.050394,-0.002932,0.025369
06-07 17:00:30.481+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.481+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:483,2.284307,-0.650547,9.514679
06-07 17:00:30.481+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:488,-0.700000,0.350000,-0.140000
06-07 17:00:30.481+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:482,2.333002,-0.653241,9.583255
06-07 17:00:30.481+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.491+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:494,2.340181,-0.672383,9.614362
06-07 17:00:30.491+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.491+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.491+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.491+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.501+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:504,2.283724,-0.650542,9.514819
06-07 17:00:30.501+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:503,2.301895,-0.662812,9.580862
06-07 17:00:30.501+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:501,-0.140000,0.350000,-0.070000
06-07 17:00:30.501+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:498,0.072614,0.039935,0.044904
06-07 17:00:30.501+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.501+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.511+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:512,0.140000,0.140000,-0.140000
06-07 17:00:30.511+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:514,0.071594,0.063316,0.071262
06-07 17:00:30.511+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.511+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:521,0.078044,0.103361,0.051344
06-07 17:00:30.521+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.521+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.521+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.521+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.521+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:526,0.052612,0.049521,0.008220
06-07 17:00:30.521+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.531+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:530,2.309074,-0.677169,9.578469
06-07 17:00:30.531+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:532,0.039182,0.007251,0.071244
06-07 17:00:30.531+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.531+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:531,0.420000,0.140000,-0.350000
06-07 17:00:30.531+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:528,2.282741,-0.650581,9.515053
06-07 17:00:30.531+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:537,0.075709,0.058501,-0.000788
06-07 17:00:30.531+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.531+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.541+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.541+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:543,0.072061,0.018995,0.042336
06-07 17:00:30.541+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.541+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.541+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:549,0.053414,-0.004871,0.067296
06-07 17:00:30.541+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.551+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:549,1.260000,-0.280000,-0.490000
06-07 17:00:30.551+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:554,0.057155,-0.022728,0.099315
06-07 17:00:30.551+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.551+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:559,0.017588,-0.012265,0.066183
06-07 17:00:30.551+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.561+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:549,2.281120,-0.648659,9.515573
06-07 17:00:30.561+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:553,2.333002,-0.669990,9.564112
06-07 17:00:30.561+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.561+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:565,0.025350,-0.026627,0.063650
06-07 17:00:30.561+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.561+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.561+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.561+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:571,0.050261,-0.019410,0.049059
06-07 17:00:30.571+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.571+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:576,0.078203,0.067203,0.036575
06-07 17:00:30.571+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.581+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:575,1.610000,-0.210000,-0.560000
06-07 17:00:30.581+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:576,2.279404,-0.641916,9.516440
06-07 17:00:30.581+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.581+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.581+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:583,0.082312,0.120281,0.040493
06-07 17:00:30.591+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:578,2.359323,-0.581456,9.552148
06-07 17:00:30.591+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.591+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:590,2.279784,-0.634291,9.516861
06-07 17:00:30.591+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:597,0.840000,-0.070000,-0.210000
06-07 17:00:30.591+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.591+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.601+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:602,0.058003,0.119834,0.064001
06-07 17:00:30.601+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:599,2.361716,-0.521635,9.556933
06-07 17:00:30.601+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:603,2.282120,-0.628492,9.516685
06-07 17:00:30.601+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:30.601+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.601+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:30:610,84
06-07 17:00:30.601+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:611,2.337788,-0.514457,9.580862
06-07 17:00:30.611+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.611+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:618,-0.070000,-0.070000,-0.210000
06-07 17:00:30.621+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.621+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.621+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:30.621+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.621+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:630,2.284607,-0.626113,9.516246
06-07 17:00:30.621+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.631+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:30:631,746.000000
06-07 17:00:30.631+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:636,-0.350000,0.140000,-0.210000
06-07 17:00:30.631+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:629,0.046096,0.059000,0.059391
06-07 17:00:30.631+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.631+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.641+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:632,2.328217,-0.569492,9.576077
06-07 17:00:30.641+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.641+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:644,2.287165,-0.627233,9.515557
06-07 17:00:30.641+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.641+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:648,2.344966,-0.641276,9.561719
06-07 17:00:30.651+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:645,0.060359,-0.015163,0.045473
06-07 17:00:30.651+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:651,-0.280000,0.210000,0.210000
06-07 17:00:30.651+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.651+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.661+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:663,0.064980,0.005099,0.050948
06-07 17:00:30.661+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:663,2.290430,-0.627457,9.514758
06-07 17:00:30.661+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.661+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.661+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:668,-0.280000,-0.070000,0.210000
06-07 17:00:30.671+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:30:670,2.352145,-0.622134,9.566505
06-07 17:00:30.671+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.671+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:30.681+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:30.681+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:684,2.293799,-0.628749,9.513861
06-07 17:00:30.681+0200 I/linearacceleration(14164): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:30:684,0.059322,-0.020998,0.070889
06-07 17:00:30.681+0200 I/gyroscope(14151): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:30:688,-0.280000,-0.140000,-0.210000
06-07 17:00:30.681+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:30.691+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 17:00:30.701+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:30:704,2.293885,-0.627023,9.513954
06-07 17:00:30.711+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11142276c6f63152838363
