S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8625
Date: 2018-04-23 20:28:17+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73f652d, r5   = 0xf7651f98
r6   = 0xffe1cdd0, r7   = 0xffe1cc80
r8   = 0xf764ec18, r9   = 0x00000000
r10  = 0xffe1cd5c, fp   = 0xffe1cdd0
ip   = 0x00000001, sp   = 0xffe1cc58
lr   = 0xf73f6539, pc   = 0xf745f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    149928 KB
Buffers:     33060 KB
Cached:     151884 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11680 KB
VmRSS:       11676 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8625 TID = 8625
8625 8637 

Maps Information
f42c1000 f4ac0000 rw-p [stack:8637]
f4ac7000 f4ac9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ad1000 f4ad5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ade000 f4ae0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ae8000 f4aeb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4afa000 f4aff000 r-xp /usr/lib/libsystem.so.0.0.0
f4b0a000 f4b0d000 r-xp /lib/libattr.so.1.1.0
f4b15000 f4b25000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b2d000 f4b36000 r-xp /usr/lib/libedbus.so.1.7.99
f4b3e000 f4b3f000 r-xp /usr/lib/libresponse.so.0.2.96
f4b48000 f4b4d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63ef000 f64f5000 r-xp /usr/lib/libicuuc.so.57.1
f650b000 f6693000 r-xp /usr/lib/libicui18n.so.57.1
f66a3000 f66b0000 r-xp /usr/lib/libail.so.0.1.0
f66b9000 f66c0000 r-xp /usr/lib/libminizip.so.1.0.0
f66c9000 f6872000 r-xp /usr/lib/libcrypto.so.1.0.0
f6892000 f68d9000 r-xp /usr/lib/libssl.so.1.0.0
f68e5000 f68e7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68ef000 f68f6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68ff000 f6906000 r-xp /lib/libcrypt-2.13.so
f6937000 f693a000 r-xp /lib/libcap.so.2.21
f6942000 f6944000 r-xp /usr/lib/libiri.so
f694c000 f6995000 r-xp /usr/lib/libmdm.so.1.2.69
f699d000 f69a3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69ab000 f69ce000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69d8000 f69da000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69e2000 f69ff000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a08000 f6a0c000 r-xp /usr/lib/libsmack.so.1.0.0
f6a15000 f6a2e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a37000 f6a3f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a47000 f6a4d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a56000 f6a58000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a61000 f6a71000 r-xp /lib/libresolv-2.13.so
f6a75000 f6a8d000 r-xp /usr/lib/liblzma.so.5.0.3
f6a96000 f6a98000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aa0000 f6aba000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ac2000 f6af1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6afa000 f6b09000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b13000 f6b1d000 r-xp /usr/lib/libsensord-shared.so
f6b26000 f6bf9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c04000 f6c1a000 r-xp /lib/libz.so.1.2.5
f6c22000 f6c27000 r-xp /usr/lib/libffi.so.5.0.10
f6c2f000 f6c30000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c38000 f6c48000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c50000 f6c69000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c71000 f6c73000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c7b000 f6cf0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cfa000 f6d00000 r-xp /lib/librt-2.13.so
f6d09000 f6d27000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d31000 f6d32000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d3a000 f6d5d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d65000 f6d6a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d72000 f6d9c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6da5000 f6dbc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dc4000 f6e2d000 r-xp /lib/libm-2.13.so
f6e36000 f6eca000 r-xp /usr/lib/libstdc++.so.6.0.16
f6edd000 f6ee2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6eea000 f6ef1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ef9000 f6f23000 r-xp /usr/lib/libsensor.so.1.9.6
f6f2c000 f6ff8000 r-xp /usr/lib/libxml2.so.2.7.8
f7005000 f7007000 r-xp /usr/lib/libiniparser.so.0
f7010000 f7016000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f701f000 f70ef000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70f0000 f7124000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f712d000 f7169000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7171000 f7174000 r-xp /usr/lib/libbundle.so.0.1.22
f717c000 f7182000 r-xp /usr/lib/libappsvc.so.0.1.0
f718a000 f71cb000 r-xp /usr/lib/libeina.so.1.7.99
f71d4000 f71eb000 r-xp /usr/lib/libecore.so.1.7.99
f7202000 f720b000 r-xp /usr/lib/libvconf.so.0.2.45
f7213000 f7227000 r-xp /lib/libpthread-2.13.so
f7232000 f723f000 r-xp /usr/lib/libaul.so.0.1.0
f7249000 f724b000 r-xp /lib/libdl-2.13.so
f7254000 f725f000 r-xp /lib/libunwind.so.8.0.1
f728c000 f7294000 r-xp /lib/libgcc_s-4.6.so.1
f7295000 f73b9000 r-xp /lib/libc-2.13.so
f73c7000 f73c9000 r-xp /usr/lib/libdlog.so.0.0.0
f73d1000 f73dd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73e6000 f73eb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73f3000 f7402000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f740a000 f740e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7417000 f741a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7422000 f7424000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f742c000 f7430000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7438000 f7455000 r-xp /lib/ld-2.13.so
f745e000 f7461000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7461000 f7465000 r-xp /usr/lib/libsys-assert.so
f761e000 f768f000 rw-p [heap]
ffdfe000 ffe1f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8625)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf745f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73f6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70fd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70fbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7107e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf710dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf710ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf714275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf713d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70fbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7107e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf710dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf710ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf713fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7140017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7147f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4adf1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ad2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ba5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7052fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70547a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71e4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71dfb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71e05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71e0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7418183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74187fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf745f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf72ac85c) [/lib/libc.so.6] + 0x1785c
29: (0xf745ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
inearacceleration
04-23 20:28:08.689+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:08:656,-0.070000,-0.070000,0.070000
04-23 20:28:08.699+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:08:681,-0.032754,0.044394,-0.005215
04-23 20:28:08.709+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:08.719+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:08.729+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:08:732,0.015978,9.769278,0.855189
04-23 20:28:08.759+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:08.769+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:08.779+0200 I/servicemanager( 8242): es.ugr.frailty.linearacceleration sleep timeout
04-23 20:28:08.779+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
04-23 20:28:08.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:08.779+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:08.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8294
04-23 20:28:08.799+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:08.809+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8294)
04-23 20:28:08.809+0200 I/servicemanager( 8242): es.ugr.frailty.linearacceleration stop request sent!
04-23 20:28:08.809+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:28:08.809+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:08:669,0.028714,9.841680,0.806381
04-23 20:28:08.819+0200 I/servicemanager( 8242): es.ugr.frailty.gravity sleep timeout
04-23 20:28:08.819+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:28:08.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:08.819+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:08.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8302
04-23 20:28:08.829+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8302)
04-23 20:28:08.829+0200 I/servicemanager( 8242): es.ugr.frailty.gravity stop request sent!
04-23 20:28:08.829+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:28:08.839+0200 I/heartrate( 8278): es.ugr.frailty.heartrate listener destroyed
04-23 20:28:08.839+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:08.839+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:08:727,-0.070000,0.070000,0.070000
04-23 20:28:08.879+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:08.879+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:08.879+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:08:867,0.028714,9.796216,0.808774
04-23 20:28:08.879+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:08:863,0.045210,0.025694,-0.043909
04-23 20:28:08.899+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:08:903,0.023496,9.769807,0.848946
04-23 20:28:08.909+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:08:893,-0.070000,0.070000,0.070000
04-23 20:28:08.919+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:08.919+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:08.939+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:08:943,0.016750,9.805787,0.751346
04-23 20:28:08.949+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:08.979+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:08.979+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:08:983,0.024673,9.770577,0.840000
04-23 20:28:08.989+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:08:929,-0.012131,0.018190,-0.066377
04-23 20:28:08.999+0200 W/AUL     ( 8588): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 20:28:09.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:28:09.009+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:28:09.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8278
04-23 20:28:09.009+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:28:09.009+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8278
04-23 20:28:09.009+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8278)
04-23 20:28:09.009+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:09.009+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:09.039+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:09:43,-0.033242,0.049336,-0.004636
04-23 20:28:09.049+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:08:992,-0.070000,0.070000,0.070000
04-23 20:28:09.059+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:09.059+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:09.079+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:09:27,0.045464,9.772287,0.811167
04-23 20:28:09.099+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:09.099+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:09.109+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:09:72,0.037478,9.773324,0.806921
04-23 20:28:09.129+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:09:111,0.013638,0.033028,-0.062448
04-23 20:28:09.129+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:09:89,-0.070000,0.070000,-0.070000
04-23 20:28:09.139+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:28:09.149+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:28:09:154,0.026732,9.772265,0.820063
04-23 20:28:09.169+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:09:112,-0.009571,9.815358,0.768096
04-23 20:28:09.169+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:09.169+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:09:174,-0.070000,0.070000,0.070000
04-23 20:28:09.189+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:09.209+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:28:09.209+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:28:09:213,-0.007178,9.844072,0.765703
04-23 20:28:09.229+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:09.229+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:09.229+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(17), pid(8302), cmd(0)
04-23 20:28:09.229+0200 I/gravity ( 8302): stopping es.ugr.frailty.gravity service
04-23 20:28:09.229+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:09:236,-0.070000,0.070000,0.070000
04-23 20:28:09.239+0200 W/AUL     ( 8302): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:09.239+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:09:197,-0.006302,0.042459,-0.058412
04-23 20:28:09.249+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:09.249+0200 I/accelerometer( 8253): stopping es.ugr.frailty.accelerometer service
04-23 20:28:09.269+0200 W/AUL     ( 8253): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:09.269+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:09.269+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8302
04-23 20:28:09.289+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:09.299+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:09.299+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8253), cmd(0)
04-23 20:28:09.299+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:09.299+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(17), pid(8242), cmd(0)
04-23 20:28:09.309+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.309+0200 I/utils   ( 8242): specific action
04-23 20:28:09.309+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.309+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.319+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.319+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.319+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.319+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:09.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:09.329+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:09.339+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:09.339+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:09.339+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:09.339+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.349+0200 I/utils   ( 8247): specific action
04-23 20:28:09.349+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.349+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.349+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.349+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.349+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.349+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.349+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
04-23 20:28:09.349+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:09.349+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:09.349+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:09.349+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:09.349+0200 W/AUL     ( 8302): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:09.349+0200 I/gravity ( 8302): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:09.349+0200 I/CAPI_APPFW_APPLICATION( 8302): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:28:09.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:28:09.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:28:09.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:09.359+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8253
04-23 20:28:09.369+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:09:263,0.005819,0.071244,-0.035311
04-23 20:28:09.369+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:09.379+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:09.379+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:28:09.379+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.379+0200 I/utils   ( 8242): specific action
04-23 20:28:09.379+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:09.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:09.379+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:09.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:09.389+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:09.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:09.399+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.399+0200 I/utils   ( 8247): specific action
04-23 20:28:09.399+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:09.399+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 20:28:09.399+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:09.399+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:09.399+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:09.399+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:09.399+0200 W/AUL     ( 8253): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:09.399+0200 I/accelerometer( 8253): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:09.399+0200 I/CAPI_APPFW_APPLICATION( 8253): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:28:09.409+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:28:09.409+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:28:09.459+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:09.469+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:09.469+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:09.499+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer listener destroyed
04-23 20:28:09.529+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:09.549+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:09:475,-0.070000,0.070000,-0.070000
04-23 20:28:09.589+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:09:537,0.005707,0.025340,-0.027785
04-23 20:28:09.639+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:09.639+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:09.709+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:09.719+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:09.729+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:09:735,-0.006671,0.035019,-0.086460
04-23 20:28:09.749+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:09:711,-0.070000,0.070000,-0.070000
04-23 20:28:09.759+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:09.759+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:09.779+0200 I/gravity ( 8302): es.ugr.frailty.gravity listener destroyed
04-23 20:28:09.789+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:09:788,-0.070000,0.070000,-0.070000
04-23 20:28:09.809+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:09:788,0.022219,0.001473,-0.026110
04-23 20:28:09.859+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:28:09.869+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:09.879+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:28:09:885,-0.070000,0.140000,-0.070000
04-23 20:28:09.909+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:09:918,-0.039107,0.042241,-0.041654
04-23 20:28:09.979+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:09.979+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(8256), cmd(0)
04-23 20:28:10.019+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:28:10.019+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:28:10:25,-0.022460,0.068699,-0.016747
04-23 20:28:10.029+0200 W/AUL     ( 8595): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 20:28:10.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:28:10.029+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:28:10.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8253
04-23 20:28:10.029+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:28:10.039+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8253
04-23 20:28:10.039+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8253)
04-23 20:28:10.049+0200 I/gyroscope( 8256): stopping es.ugr.frailty.gyroscope service
04-23 20:28:10.049+0200 W/AUL     ( 8256): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:10.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:10.069+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8256
04-23 20:28:10.069+0200 I/linearacceleration( 8294): stopping es.ugr.frailty.linearacceleration service
04-23 20:28:10.069+0200 W/AUL     ( 8294): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:10.069+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:10.079+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:10.079+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8294
04-23 20:28:10.089+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:10.089+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:10.089+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(17), pid(8294), cmd(0)
04-23 20:28:10.089+0200 W/AUL     ( 8294): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:10.089+0200 I/linearacceleration( 8294): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:10.089+0200 I/CAPI_APPFW_APPLICATION( 8294): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:28:10.099+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:28:10.099+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:28:10.129+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:10.129+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:28:10.139+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.149+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:10.149+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:10.159+0200 W/AUL     ( 8256): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:10.159+0200 I/gyroscope( 8256): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:10.159+0200 I/CAPI_APPFW_APPLICATION( 8256): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:28:10.159+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:28:10.159+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:28:10.199+0200 I/utils   ( 8242): specific action
04-23 20:28:10.199+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.209+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:10.209+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:10.219+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:28:10.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:10.239+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:10.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:10.249+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration listener destroyed
04-23 20:28:10.249+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:10.249+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:10.249+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:10.249+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:10.249+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(8242), cmd(0)
04-23 20:28:10.259+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.289+0200 W/AUL     ( 8598): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
04-23 20:28:10.289+0200 I/utils   ( 8242): specific action
04-23 20:28:10.289+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:28:10.289+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:28:10.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8302
04-23 20:28:10.289+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:28:10.289+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8302
04-23 20:28:10.289+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8302)
04-23 20:28:10.289+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.289+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.289+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.289+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:10.299+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:10.299+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:10.299+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.299+0200 I/utils   ( 8247): specific action
04-23 20:28:10.299+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.299+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.309+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 20:28:10.309+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:10.309+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope listener destroyed
04-23 20:28:10.309+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:10.319+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:10.319+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:10.329+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:10.329+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:10.359+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.359+0200 I/utils   ( 8247): specific action
04-23 20:28:10.359+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.359+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.369+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.369+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.369+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:10.369+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
04-23 20:28:10.369+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:10.369+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:10.379+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:10.379+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:10.469+0200 W/AUL     ( 8600): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.linearacceleration]
04-23 20:28:10.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:28:10.469+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:28:10.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8294
04-23 20:28:10.469+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:28:10.469+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8294
04-23 20:28:10.469+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8294)
04-23 20:28:10.609+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:28:10.619+0200 W/AUL     ( 8602): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 20:28:10.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:28:10.619+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:28:10.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8256
04-23 20:28:10.619+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:28:10.619+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8256
04-23 20:28:10.619+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8256)
04-23 20:28:11.359+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:28:11.409+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:28:12.099+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:28:12.159+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:28:14.609+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:28:14.609+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:28:14.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:14.609+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:14.619+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:28:14.619+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 8625
04-23 20:28:14.669+0200 E/CAPI_APPFW_APPLICATION( 8625): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:14.669+0200 E/CAPI_APPFW_APPLICATION( 8625): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:14.669+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8625
04-23 20:28:14.669+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(8625) type(svcapp) bg(0)
04-23 20:28:14.679+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (8625) was created
04-23 20:28:14.679+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8625]
04-23 20:28:14.699+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8625)
04-23 20:28:14.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:14.709+0200 W/LOCATION( 8625): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:28:14.709+0200 E/LOCATION( 8625): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:28:14.709+0200 E/PKGMGR_INFO( 8625): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:28:14.719+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8625
04-23 20:28:14.719+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:28:14.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:14.719+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:28:14.729+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8625
04-23 20:28:14.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:14.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:14.749+0200 W/LOCATION( 8625): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:14.779+0200 I/LOCATION( 8625): location.c: location_new(269) > method: 0
04-23 20:28:14.779+0200 W/LOCATION( 8625): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:14.779+0200 W/LOCATION( 8625): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:14.789+0200 W/LOCATION( 8625): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:14.789+0200 W/LOCATION( 8625): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:14.799+0200 W/LOCATION( 8625): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:14.799+0200 W/LOCATION( 8625): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:14.799+0200 W/LOCATION( 8625): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:14.799+0200 W/LOCATION( 8625): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:14.799+0200 W/LOCATION( 8625): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:14.829+0200 W/LOCATION( 8625): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:14.849+0200 W/LOCATION( 8625): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:14.849+0200 W/LOCATION( 8625): module-internal.c: module_new(311) > module (wps) open success
04-23 20:28:14.849+0200 W/LOCATION( 8625): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:28:14.859+0200 W/LOCATION( 8625): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:28:14.859+0200 W/LOCATION( 8625): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:14.859+0200 W/LOCATION( 8625): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:14.879+0200 W/LOCATION( 8625): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:28:14.879+0200 I/LOCATION( 8625): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf764ec18
04-23 20:28:14.879+0200 I/LOCATION( 8625): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:28:14.879+0200 I/LOCATION( 8625): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf764ec18
04-23 20:28:14.879+0200 I/LOCATION( 8625): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:28:14.879+0200 I/location( 8625): es.ugr.frailty.location: creado servicio de localización
04-23 20:28:14.929+0200 I/LOCATION( 8625): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:28:14.969+0200 W/LOCATION( 8625): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:14.969+0200 W/LOCATION( 8625): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:14.969+0200 I/LOCATION( 8625): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:15.049+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:28:15.049+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:28:15.049+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:28:15.049+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:28:15.049+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:28:15.049+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:28:15.049+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:28:15.049+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:28:15.049+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:15.049+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:15.049+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:28:15.049+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:28:15.049+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:28:15.049+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:28:15.049+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:28:15.049+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:28:15.049+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:28:15.049+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:28:15.209+0200 W/LOCATION( 8625): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:15.209+0200 W/LOCATION( 8625): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:15.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:28:15.279+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2170543), time2(2157546)
04-23 20:28:15.279+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:28:15.279+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:28:15.279+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:28:15.279+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:28:15.289+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:15.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:15.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:15.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:15.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4005390]
04-23 20:28:15.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:15.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:15.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:15.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:15.339+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:15.339+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:15.349+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:15.359+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:15.359+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:15.359+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:15.359+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:15.359+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:15.359+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:15.359+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:15.359+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:15.359+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:15.359+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:15.369+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:15.379+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:15.379+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:15.379+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:15.419+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:15.459+0200 W/LOCATION( 8625): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:28:15.459+0200 I/LOCATION( 8625): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:15.459+0200 I/LOCATION( 8625): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:15.459+0200 I/location( 8625): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:28:15.539+0200 I/LOCATION( 8625): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:15.589+0200 E/location( 8625): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:28:15.599+0200 W/AUL     ( 8625): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:15.599+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:15.599+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8625
04-23 20:28:15.609+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:15.609+0200 W/AUL     ( 8625): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:15.609+0200 I/location( 8625): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:15.609+0200 W/CAPI_APPFW_APP_CONTROL( 8625): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.609+0200 I/utils   ( 8625): specific action
04-23 20:28:15.609+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:15.609+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:28:15.609+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.609+0200 I/utils   ( 8242): specific action
04-23 20:28:15.609+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.609+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.609+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.609+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:15.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:15.609+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:15.619+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:15.619+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:15.619+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:15.619+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.619+0200 I/utils   ( 8247): specific action
04-23 20:28:15.619+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.619+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.619+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.619+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:15.619+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:28:15.619+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:15.619+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:15.619+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:15.619+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:16.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:16.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:16.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:16.379+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:28:17.019+0200 W/LOCATION( 8625): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:28:17.219+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11086256c6f63152450809
