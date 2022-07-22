S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20507
Date: 2018-06-07 17:22:13+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf733452d, r5   = 0xf798ff98
r6   = 0xffb35b50, r7   = 0xffb35a00
r8   = 0xf798cc18, r9   = 0x00000000
r10  = 0xffb35adc, fp   = 0xffb35b50
ip   = 0x00000001, sp   = 0xffb359d8
lr   = 0xf7334539, pc   = 0xf739d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    177788 KB
Buffers:      9824 KB
Cached:      58076 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11580 KB
VmRSS:       11580 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20507 TID = 20507
20507 20510 

Maps Information
f41ff000 f49fe000 rw-p [stack:20510]
f4a05000 f4a07000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a0f000 f4a13000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a1c000 f4a1e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a26000 f4a29000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a38000 f4a3d000 r-xp /usr/lib/libsystem.so.0.0.0
f4a48000 f4a4b000 r-xp /lib/libattr.so.1.1.0
f4a53000 f4a63000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a6b000 f4a74000 r-xp /usr/lib/libedbus.so.1.7.99
f4a7c000 f4a7d000 r-xp /usr/lib/libresponse.so.0.2.96
f4a86000 f4a8b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f632d000 f6433000 r-xp /usr/lib/libicuuc.so.57.1
f6449000 f65d1000 r-xp /usr/lib/libicui18n.so.57.1
f65e1000 f65ee000 r-xp /usr/lib/libail.so.0.1.0
f65f7000 f65fe000 r-xp /usr/lib/libminizip.so.1.0.0
f6607000 f67b0000 r-xp /usr/lib/libcrypto.so.1.0.0
f67d0000 f6817000 r-xp /usr/lib/libssl.so.1.0.0
f6823000 f6825000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f682d000 f6834000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f683d000 f6844000 r-xp /lib/libcrypt-2.13.so
f6875000 f6878000 r-xp /lib/libcap.so.2.21
f6880000 f6882000 r-xp /usr/lib/libiri.so
f688a000 f68d3000 r-xp /usr/lib/libmdm.so.1.2.69
f68db000 f68e1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68e9000 f690c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6916000 f6918000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6920000 f693d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6946000 f694a000 r-xp /usr/lib/libsmack.so.1.0.0
f6953000 f696c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6975000 f697d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6985000 f698b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6994000 f6996000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f699f000 f69af000 r-xp /lib/libresolv-2.13.so
f69b3000 f69cb000 r-xp /usr/lib/liblzma.so.5.0.3
f69d4000 f69d6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69de000 f69f8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a00000 f6a2f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a38000 f6a47000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a51000 f6a5b000 r-xp /usr/lib/libsensord-shared.so
f6a64000 f6b37000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b42000 f6b58000 r-xp /lib/libz.so.1.2.5
f6b60000 f6b65000 r-xp /usr/lib/libffi.so.5.0.10
f6b6d000 f6b6e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b76000 f6b86000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b8e000 f6ba7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6baf000 f6bb1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bb9000 f6c2e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c38000 f6c3e000 r-xp /lib/librt-2.13.so
f6c47000 f6c65000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c6f000 f6c70000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c78000 f6c9b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ca3000 f6ca8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cb0000 f6cda000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ce3000 f6cfa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d02000 f6d6b000 r-xp /lib/libm-2.13.so
f6d74000 f6e08000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e1b000 f6e20000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e28000 f6e2f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e37000 f6e61000 r-xp /usr/lib/libsensor.so.1.9.6
f6e6a000 f6f36000 r-xp /usr/lib/libxml2.so.2.7.8
f6f43000 f6f45000 r-xp /usr/lib/libiniparser.so.0
f6f4e000 f6f54000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f5d000 f702d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f702e000 f7062000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f706b000 f70a7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70af000 f70b2000 r-xp /usr/lib/libbundle.so.0.1.22
f70ba000 f70c0000 r-xp /usr/lib/libappsvc.so.0.1.0
f70c8000 f7109000 r-xp /usr/lib/libeina.so.1.7.99
f7112000 f7129000 r-xp /usr/lib/libecore.so.1.7.99
f7140000 f7149000 r-xp /usr/lib/libvconf.so.0.2.45
f7151000 f7165000 r-xp /lib/libpthread-2.13.so
f7170000 f717d000 r-xp /usr/lib/libaul.so.0.1.0
f7187000 f7189000 r-xp /lib/libdl-2.13.so
f7192000 f719d000 r-xp /lib/libunwind.so.8.0.1
f71ca000 f71d2000 r-xp /lib/libgcc_s-4.6.so.1
f71d3000 f72f7000 r-xp /lib/libc-2.13.so
f7305000 f7307000 r-xp /usr/lib/libdlog.so.0.0.0
f730f000 f731b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7324000 f7329000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7331000 f7340000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7348000 f734c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7355000 f7358000 r-xp /usr/lib/libappcore-agent.so.1.1
f7360000 f7362000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f736a000 f736e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7376000 f7393000 r-xp /lib/ld-2.13.so
f739c000 f739f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f739f000 f73a3000 r-xp /usr/lib/libsys-assert.so
f795c000 f79ea000 rw-p [heap]
ffb17000 ffb38000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20507)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf739d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7334539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf703b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7039c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7045e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf704bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf704bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf708075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf707b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7039c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7045e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf704bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf704bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf707de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf707e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7085f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a1d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a10171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ae3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f90fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f927a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7122ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf711db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf711e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf711e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7356183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73567fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf739d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf71ea85c) [/lib/libc.so.6] + 0x1785c
29: (0xf739cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
/2018,17:24:22:185,0.070000,0.070000,0.070000
06-07 17:24:22.231+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:235,0.038664,0.012298,0.071441
06-07 17:24:22.241+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:207,0.313460,-0.124427,9.810574
06-07 17:24:22.241+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.241+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:22.251+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.251+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:22.261+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:249,0.070000,0.070000,0.070000
06-07 17:24:22.261+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.261+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.261+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.271+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.271+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.271+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:266,0.042310,0.021115,0.040363
06-07 17:24:22.281+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.281+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:254,0.332602,-0.064606,9.848858
06-07 17:24:22.281+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.281+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:22.281+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.291+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:22.291+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:22.291+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.291+0200 E/AUL     (21049): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:24:22.291+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:22.291+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(21049), cmd(0)
06-07 17:24:22.301+0200 W/CAPI_APPFW_APP_CONTROL(21049): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:22.301+0200 I/utils   (21049): specific action
06-07 17:24:22.311+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:22.311+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(21049), cmd(0)
06-07 17:24:22.311+0200 W/CAPI_APPFW_APP_CONTROL(21049): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:22.311+0200 I/utils   (21049): specific action
06-07 17:24:22.311+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:22.311+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:22.321+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:22:330,0.302547,-0.085492,9.801609
06-07 17:24:22.331+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:287,0.070000,0.070000,0.070000
06-07 17:24:22.331+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.331+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:299,0.342174,-0.124427,9.870394
06-07 17:24:22.341+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:22.351+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:339,-0.002042,-0.003959,0.018859
06-07 17:24:22.351+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:22.361+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:22.361+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:345,0.070000,0.070000,0.140000
06-07 17:24:22.371+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:376,-0.001482,0.008017,0.054733
06-07 17:24:22.371+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.371+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:22:365,0.300817,-0.079754,9.801711
06-07 17:24:22.381+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:355,0.306281,-0.131605,9.863215
06-07 17:24:22.381+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:22.381+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:22:390,680.000000
06-07 17:24:22.391+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:22.401+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:22.401+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:386,0.070000,0.070000,0.070000
06-07 17:24:22.401+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:22.411+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:24:22.411+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:24:22.411+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:22.411+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:22.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21012
06-07 17:24:22.431+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21012)
06-07 17:24:22.431+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer launch request sent!
06-07 17:24:22.431+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:22.441+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:24:22.441+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:24:22.441+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:22.441+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:22.451+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21017
06-07 17:24:22.461+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21017)
06-07 17:24:22.461+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope launch request sent!
06-07 17:24:22.461+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:22.461+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:24:22.461+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:24:22.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:22.461+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:22.481+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21023
06-07 17:24:22.481+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:22.481+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(21023), cmd(0)
06-07 17:24:22.491+0200 W/CAPI_APPFW_APP_CONTROL(21023): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:22.491+0200 I/utils   (21023): specific action
06-07 17:24:22.491+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:22.491+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:22.491+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21023)
06-07 17:24:22.491+0200 I/servicemanager(20992): es.ugr.frailty.heartrate launch request sent!
06-07 17:24:22.491+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:22.491+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:24:22.491+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:24:22.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:22.501+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:22.511+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21188
06-07 17:24:22.511+0200 W/CAPI_APPFW_APP_CONTROL(21188): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:22.521+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:22.521+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(21188), cmd(0)
06-07 17:24:22.531+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21188)
06-07 17:24:22.531+0200 I/servicemanager(20992): es.ugr.frailty.location launch request sent!
06-07 17:24:22.531+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:22.531+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:24:22.531+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:24:22.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:22.531+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:22.541+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21036
06-07 17:24:22.551+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21036)
06-07 17:24:22.551+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:24:22.551+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:22.551+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:24:22.551+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:24:22.551+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:22.551+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:22.571+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21049
06-07 17:24:22.571+0200 I/utils   (21188): specific action
06-07 17:24:22.571+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21049)
06-07 17:24:22.571+0200 I/servicemanager(20992): es.ugr.frailty.gravity launch request sent!
06-07 17:24:22.571+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:22.571+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:24:22.571+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:24:22.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:22.581+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:22.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21054
06-07 17:24:22.591+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:22.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(21054), cmd(0)
06-07 17:24:22.601+0200 W/CAPI_APPFW_APP_CONTROL(21054): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:22.601+0200 I/utils   (21054): specific action
06-07 17:24:22.601+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:22.611+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21054)
06-07 17:24:22.611+0200 I/servicemanager(20992): es.ugr.frailty.pressure launch request sent!
06-07 17:24:22.611+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:22.611+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:24:22.611+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:24:22.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:22.611+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:22.621+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21071
06-07 17:24:22.631+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:22:611,703.000000
06-07 17:24:22.631+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:22.631+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(21071), cmd(0)
06-07 17:24:22.641+0200 W/CAPI_APPFW_APP_CONTROL(21071): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:22.641+0200 I/utils   (21071): specific action
06-07 17:24:22.641+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21071)
06-07 17:24:22.641+0200 I/servicemanager(20992): es.ugr.frailty.light launch request sent!
06-07 17:24:22.641+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:22.641+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:24:22.641+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:24:22.641+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:22.641+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:22.651+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21084
06-07 17:24:22.661+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:22.661+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(21084), cmd(0)
06-07 17:24:22.671+0200 W/CAPI_APPFW_APP_CONTROL(21084): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:22.671+0200 I/utils   (21084): specific action
06-07 17:24:22.671+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21084)
06-07 17:24:22.671+0200 I/servicemanager(20992): es.ugr.frailty.pedometer launch request sent!
06-07 17:24:22.671+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:22.671+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.681+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:681,0.070000,0.070000,0.070000
06-07 17:24:22.681+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.681+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:687,0.070000,0.070000,0.070000
06-07 17:24:22.681+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.691+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:22.691+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:22.691+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:696,0.070000,0.070000,0.070000
06-07 17:24:22.691+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.701+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:703,-0.070000,0.070000,0.070000
06-07 17:24:22.701+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.711+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:711,-0.070000,0.070000,0.070000
06-07 17:24:22.711+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:661,-0.005670,-0.004524,0.018818
06-07 17:24:22.721+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:22:416,0.291631,-0.072450,9.802045
06-07 17:24:22.721+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.731+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:406,0.306281,-0.040678,9.856036
06-07 17:24:22.731+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:22.731+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:22.741+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:22.751+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:735,-0.070000,0.070000,0.070000
06-07 17:24:22.751+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:22:738,0.279989,-0.066031,9.802430
06-07 17:24:22.761+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:754,-0.019284,-0.023624,0.037935
06-07 17:24:22.761+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.781+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:22.791+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:22:793,713.000000
06-07 17:24:22.791+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:22.801+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:22.811+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:777,-0.070000,0.070000,0.070000
06-07 17:24:22.811+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:737,0.308674,-0.129212,9.841680
06-07 17:24:22.821+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:22.831+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:22:804,0.278247,-0.070619,9.802447
06-07 17:24:22.831+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.831+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:22.841+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:810,-0.015466,0.008441,0.057042
06-07 17:24:22.841+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:22.851+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:838,0.279960,-0.078963,9.844072
06-07 17:24:22.851+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:860,0.016883,-0.023265,0.025890
06-07 17:24:22.861+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:843,0.070000,0.070000,0.070000
06-07 17:24:22.871+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:22.871+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:22:844,0.292882,-0.072162,9.802010
06-07 17:24:22.871+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.891+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:22.891+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:22.891+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:22.891+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:882,0.277567,-0.074178,9.810574
06-07 17:24:22.891+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:883,0.070000,0.070000,0.070000
06-07 17:24:22.921+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.921+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:22.931+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:22.941+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:22:931,0.290394,-0.066301,9.802125
06-07 17:24:22.941+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:927,0.004505,-0.039104,0.009163
06-07 17:24:22.951+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:941,0.301496,-0.093320,9.808180
06-07 17:24:22.951+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:22.951+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:22.951+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:936,0.070000,0.070000,0.070000
06-07 17:24:22.951+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:22:959,0.023732,0.022383,0.047460
06-07 17:24:22.951+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:22.961+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:22.971+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:22:975,0.284746,-0.078963,9.844072
06-07 17:24:22.991+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:23.001+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:23:2,709.000000
06-07 17:24:23.001+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:22:974,-0.070000,0.070000,0.070000
06-07 17:24:23.001+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.001+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.001+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:22:964,0.303367,-0.088350,9.801558
06-07 17:24:23.001+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.021+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:24:23.021+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:24:23.021+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:24:23.031+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.041+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:14,0.032258,-0.038370,0.069020
06-07 17:24:23.041+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:34,0.313183,-0.080989,9.801313
06-07 17:24:23.051+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.051+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.051+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:40,0.311067,-0.086142,9.836893
06-07 17:24:23.051+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.061+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:10,0.070000,0.070000,0.070000
06-07 17:24:23.081+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.081+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:60,-0.005356,-0.043671,0.061913
06-07 17:24:23.091+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:63,0.319953,-0.079183,9.801109
06-07 17:24:23.091+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:23.091+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:23.091+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:66,0.325424,-0.129212,9.877571
06-07 17:24:23.091+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:90,0.070000,0.070000,0.070000
06-07 17:24:23.101+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.101+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.111+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.121+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.131+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:115,0.322438,-0.083356,9.800993
06-07 17:24:23.131+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:111,-0.005201,0.049422,0.054749
06-07 17:24:23.141+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:145,0.070000,0.070000,0.140000
06-07 17:24:23.141+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:121,0.289532,-0.045464,9.846465
06-07 17:24:23.151+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.151+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.161+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.161+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:157,-0.002689,-0.041392,0.040367
06-07 17:24:23.181+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.181+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:23.191+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:23:193,691.000000
06-07 17:24:23.191+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.201+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:158,0.312933,-0.079036,9.801337
06-07 17:24:23.201+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.211+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:174,0.323031,-0.110070,9.822537
06-07 17:24:23.211+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.221+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:186,-0.070000,0.070000,0.070000
06-07 17:24:23.221+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.241+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:218,0.318961,-0.085615,9.801087
06-07 17:24:23.241+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:216,-0.030878,0.010619,0.042759
06-07 17:24:23.241+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.251+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.251+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:257,0.308692,-0.080298,9.801461
06-07 17:24:23.261+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:227,0.332602,-0.062213,9.844072
06-07 17:24:23.261+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.261+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:240,-0.070000,0.070000,0.070000
06-07 17:24:23.271+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.271+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:266,-0.031332,0.014707,0.009192
06-07 17:24:23.291+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:23.291+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:23.291+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.291+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.291+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:300,0.307970,-0.082734,9.801464
06-07 17:24:23.301+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:272,0.289532,-0.110070,9.875179
06-07 17:24:23.311+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.311+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:279,0.070000,0.070000,0.070000
06-07 17:24:23.311+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.321+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.331+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:305,-0.005510,-0.005323,0.006732
06-07 17:24:23.331+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:319,0.277567,-0.059821,9.834501
06-07 17:24:23.341+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.341+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:330,-0.070000,0.070000,0.070000
06-07 17:24:23.351+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.351+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.371+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:338,0.307449,-0.082449,9.801482
06-07 17:24:23.371+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.371+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:355,-0.022089,0.009419,0.042623
06-07 17:24:23.381+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:364,0.337388,-0.098106,9.829715
06-07 17:24:23.381+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:23.381+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:23:391,676.000000
06-07 17:24:23.391+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.391+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:381,0.306299,-0.081603,9.801526
06-07 17:24:23.401+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:372,-0.070000,0.070000,0.070000
06-07 17:24:23.401+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.411+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.421+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:422,0.311067,-0.100499,9.846465
06-07 17:24:23.431+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:401,0.005753,0.001600,0.035390
06-07 17:24:23.431+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.431+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.441+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:425,-0.070000,0.070000,0.070000
06-07 17:24:23.451+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.451+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:438,0.307767,-0.081049,9.801484
06-07 17:24:23.451+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.481+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:455,0.020318,-0.041733,0.076059
06-07 17:24:23.501+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:23.501+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:23.501+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.511+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:463,0.337388,-0.081356,9.810574
06-07 17:24:23.511+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:517,0.309744,-0.081086,9.801422
06-07 17:24:23.511+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.521+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.521+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:466,-0.070000,0.070000,0.070000
06-07 17:24:23.521+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.541+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.541+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:551,0.310015,-0.082273,9.801403
06-07 17:24:23.541+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:525,-0.016169,0.043744,0.044987
06-07 17:24:23.551+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.551+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:561,0.017895,-0.022881,0.021024
06-07 17:24:23.551+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:532,0.332602,-0.124427,9.875179
06-07 17:24:23.561+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.561+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:545,-0.070000,0.070000,0.070000
06-07 17:24:23.561+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.561+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:570,0.330210,-0.119641,9.822537
06-07 17:24:23.571+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.571+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:576,0.310248,-0.083858,9.801382
06-07 17:24:23.581+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:574,-0.070000,0.070000,0.070000
06-07 17:24:23.581+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.581+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:23.591+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:23:595,675.000000
06-07 17:24:23.591+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:599,0.026478,0.026170,0.042600
06-07 17:24:23.591+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.591+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.621+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.621+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:605,0.318245,-0.119641,9.860823
06-07 17:24:23.621+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:609,-0.070000,0.070000,0.070000
06-07 17:24:23.621+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.631+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:635,-0.017252,-0.023091,0.073715
06-07 17:24:23.631+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:626,0.309711,-0.084353,9.801395
06-07 17:24:23.631+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.631+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.641+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21036) cmd(0)
06-07 17:24:23.661+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.661+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.661+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:645,0.330210,-0.124427,9.836893
06-07 17:24:23.671+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.671+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:652,0.070000,0.070000,0.070000
06-07 17:24:23.671+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.681+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:673,-0.028349,0.028369,0.033021
06-07 17:24:23.681+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:669,0.309377,-0.084616,9.801403
06-07 17:24:23.681+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.691+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:23.691+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:23.691+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.701+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:684,0.299103,-0.083749,9.827322
06-07 17:24:23.711+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:688,-0.070000,0.070000,0.070000
06-07 17:24:23.711+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.711+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.721+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:699,0.310959,-0.084629,9.801353
06-07 17:24:23.721+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:730,-0.070000,0.070000,0.070000
06-07 17:24:23.731+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.731+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:740,0.312081,-0.083613,9.801327
06-07 17:24:23.741+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:710,0.032631,-0.011183,0.028187
06-07 17:24:23.741+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:723,0.289532,-0.095713,9.798609
06-07 17:24:23.741+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.761+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.761+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.771+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.771+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:776,0.070000,-0.070000,0.070000
06-07 17:24:23.771+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:780,0.310226,-0.083354,9.801388
06-07 17:24:23.781+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:748,0.004688,-0.012927,0.044993
06-07 17:24:23.781+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.781+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:767,0.332602,-0.055035,9.834501
06-07 17:24:23.781+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:23.781+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:23:791,675.000000
06-07 17:24:23.791+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.791+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.801+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.801+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:811,-0.070000,-0.070000,0.070000
06-07 17:24:23.811+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:805,0.301496,-0.100499,9.839286
06-07 17:24:23.821+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:788,0.030739,0.006939,0.009117
06-07 17:24:23.821+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.821+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:824,0.309891,-0.083330,9.801398
06-07 17:24:23.831+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.831+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:834,0.024463,-0.036314,0.073768
06-07 17:24:23.841+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.851+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.851+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:856,0.070000,0.070000,0.070000
06-07 17:24:23.851+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:860,0.309844,-0.085390,9.801382
06-07 17:24:23.851+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:845,0.279960,-0.100499,9.839286
06-07 17:24:23.861+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.861+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.871+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.871+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.871+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:877,0.311067,-0.131605,9.839286
06-07 17:24:23.891+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:23.891+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:23.891+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:867,0.020791,-0.029752,0.021182
06-07 17:24:23.891+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:885,0.070000,0.070000,0.070000
06-07 17:24:23.891+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.891+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:886,0.310688,-0.086476,9.801346
06-07 17:24:23.901+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.901+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.901+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:904,0.007681,-0.028245,0.059518
06-07 17:24:23.911+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:915,0.299103,-0.112463,9.863215
06-07 17:24:23.931+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.941+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:937,0.311827,-0.085722,9.801316
06-07 17:24:23.941+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:925,-0.070000,-0.070000,0.070000
06-07 17:24:23.941+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:23.951+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:23:955,0.019745,-0.031910,0.035595
06-07 17:24:23.951+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:23.961+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:23.971+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:23.971+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:23:965,0.330210,-0.090927,9.865608
06-07 17:24:23.971+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:23:980,-0.070000,-0.070000,0.070000
06-07 17:24:24.001+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:24.001+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:24:9,678.000000
06-07 17:24:24.031+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:24:24.031+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:24:24.031+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:24:24.031+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:24.041+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:24.051+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:24.051+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:23:985,0.313109,-0.084576,9.801286
06-07 17:24:24.071+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:24.081+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:24:83,0.312549,-0.084587,9.801303
06-07 17:24:24.091+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:24:45,-0.012429,0.010363,0.026073
06-07 17:24:24.091+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:24.091+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:24.091+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:24.101+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:24:55,0.303888,-0.074178,9.839286
06-07 17:24:24.111+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:24:60,-0.070000,-0.070000,0.070000
06-07 17:24:24.111+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:24.111+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:24.121+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:24:130,0.140000,0.070000,0.070000
06-07 17:24:24.121+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:24.131+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:24:104,-0.021483,-0.001977,-0.002660
06-07 17:24:24.141+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:24.141+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:24:125,0.282353,-0.102891,9.872787
06-07 17:24:24.141+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:24:137,0.311951,-0.084011,9.801327
06-07 17:24:24.151+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:24:160,0.022751,0.038678,0.033195
06-07 17:24:24.161+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:24.161+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:24.171+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:24:174,-0.140000,0.070000,0.070000
06-07 17:24:24.181+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:24.181+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:24:191,687.000000
06-07 17:24:24.191+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:24:175,0.301496,-0.110070,9.822537
06-07 17:24:24.191+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:24.281+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:24.291+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:24.291+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:24.301+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:24.311+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:24:205,0.311208,-0.084053,9.801351
06-07 17:24:24.381+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:24:300,-0.009725,-0.008435,0.038008
06-07 17:24:24.381+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11205076c6f63152838493
