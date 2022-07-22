S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22314
Date: 2018-04-23 19:47:31+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70b452d, r5   = 0xf71f1f98
r6   = 0xff8ef9b8, r7   = 0xff8ef868
r8   = 0xf71eec18, r9   = 0x00000000
r10  = 0xff8ef944, fp   = 0xff8ef9b8
ip   = 0x00000001, sp   = 0xff8ef840
lr   = 0xf70b4539, pc   = 0xf711d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     18940 KB
Buffers:     57940 KB
Cached:     223264 KB
VmPeak:      53592 KB
VmSize:      53424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11844 KB
VmRSS:       11844 KB
VmData:      11152 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22314 TID = 22314
22314 22331 

Maps Information
f3f7f000 f477e000 rw-p [stack:22331]
f4785000 f4787000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f478f000 f4793000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f479c000 f479e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47a6000 f47a9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47b8000 f47bd000 r-xp /usr/lib/libsystem.so.0.0.0
f47c8000 f47cb000 r-xp /lib/libattr.so.1.1.0
f47d3000 f47e3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47eb000 f47f4000 r-xp /usr/lib/libedbus.so.1.7.99
f47fc000 f47fd000 r-xp /usr/lib/libresponse.so.0.2.96
f4806000 f480b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60ad000 f61b3000 r-xp /usr/lib/libicuuc.so.57.1
f61c9000 f6351000 r-xp /usr/lib/libicui18n.so.57.1
f6361000 f636e000 r-xp /usr/lib/libail.so.0.1.0
f6377000 f637e000 r-xp /usr/lib/libminizip.so.1.0.0
f6387000 f6530000 r-xp /usr/lib/libcrypto.so.1.0.0
f6550000 f6597000 r-xp /usr/lib/libssl.so.1.0.0
f65a3000 f65a5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65ad000 f65b4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65bd000 f65c4000 r-xp /lib/libcrypt-2.13.so
f65f5000 f65f8000 r-xp /lib/libcap.so.2.21
f6600000 f6602000 r-xp /usr/lib/libiri.so
f660a000 f6653000 r-xp /usr/lib/libmdm.so.1.2.69
f665b000 f6661000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6669000 f668c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6696000 f6698000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66a0000 f66bd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66c6000 f66ca000 r-xp /usr/lib/libsmack.so.1.0.0
f66d3000 f66ec000 r-xp /usr/lib/libnetwork.so.0.0.0
f66f5000 f66fd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6705000 f670b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6714000 f6716000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f671f000 f672f000 r-xp /lib/libresolv-2.13.so
f6733000 f674b000 r-xp /usr/lib/liblzma.so.5.0.3
f6754000 f6756000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f675e000 f6778000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6780000 f67af000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67b8000 f67c7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67d1000 f67db000 r-xp /usr/lib/libsensord-shared.so
f67e4000 f68b7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68c2000 f68d8000 r-xp /lib/libz.so.1.2.5
f68e0000 f68e5000 r-xp /usr/lib/libffi.so.5.0.10
f68ed000 f68ee000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68f6000 f6906000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f690e000 f6927000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f692f000 f6931000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6939000 f69ae000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69b8000 f69be000 r-xp /lib/librt-2.13.so
f69c7000 f69e5000 r-xp /usr/lib/libsystemd.so.0.4.0
f69ef000 f69f0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69f8000 f6a1b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a23000 f6a28000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a30000 f6a5a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a63000 f6a7a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a82000 f6aeb000 r-xp /lib/libm-2.13.so
f6af4000 f6b88000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b9b000 f6ba0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ba8000 f6baf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bb7000 f6be1000 r-xp /usr/lib/libsensor.so.1.9.6
f6bea000 f6cb6000 r-xp /usr/lib/libxml2.so.2.7.8
f6cc3000 f6cc5000 r-xp /usr/lib/libiniparser.so.0
f6cce000 f6cd4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cdd000 f6dad000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dae000 f6de2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6deb000 f6e27000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e2f000 f6e32000 r-xp /usr/lib/libbundle.so.0.1.22
f6e3a000 f6e40000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e48000 f6e89000 r-xp /usr/lib/libeina.so.1.7.99
f6e92000 f6ea9000 r-xp /usr/lib/libecore.so.1.7.99
f6ec0000 f6ec9000 r-xp /usr/lib/libvconf.so.0.2.45
f6ed1000 f6ee5000 r-xp /lib/libpthread-2.13.so
f6ef0000 f6efd000 r-xp /usr/lib/libaul.so.0.1.0
f6f07000 f6f09000 r-xp /lib/libdl-2.13.so
f6f12000 f6f1d000 r-xp /lib/libunwind.so.8.0.1
f6f4a000 f6f52000 r-xp /lib/libgcc_s-4.6.so.1
f6f53000 f7077000 r-xp /lib/libc-2.13.so
f7085000 f7087000 r-xp /usr/lib/libdlog.so.0.0.0
f708f000 f709b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70a4000 f70a9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70b1000 f70c0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70c8000 f70cc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70d5000 f70d8000 r-xp /usr/lib/libappcore-agent.so.1.1
f70e0000 f70e2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70ea000 f70ee000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70f6000 f7113000 r-xp /lib/ld-2.13.so
f711c000 f711f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f711f000 f7123000 r-xp /usr/lib/libsys-assert.so
f71be000 f7227000 rw-p [heap]
ff8d1000 ff8f2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22314)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf711d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70b4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dbb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6db9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dc5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dcbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dcbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e0075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6dfb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6db9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dc5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dcbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dcbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6dfde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dfe017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e028d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf70ec0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4790171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6863663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d10fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d127a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ea2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e9db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e9e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e9e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70d6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70d67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf711d4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f6a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf711cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
7:29.559+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22262)
04-23 19:47:29.559+0200 I/servicemanager(21592): es.ugr.frailty.accelerometer launch request sent!
04-23 19:47:29.559+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:29.559+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22262) was created
04-23 19:47:29.569+0200 I/utils   (22262): es.ugr.frailty.accelerometer listener started
04-23 19:47:29.569+0200 W/CAPI_APPFW_APP_CONTROL(22262): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:29.569+0200 I/utils   (22262): specific action
04-23 19:47:29.569+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22262]
04-23 19:47:29.579+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:29.589+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:29.599+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22262
04-23 19:47:29.609+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:29.619+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:29:591,3.857230,-8.195417,-3.220739
04-23 19:47:29.639+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:29.639+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22262
04-23 19:47:29.649+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:29.779+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:29.789+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:29:791,3.414558,-9.241080,-3.134598
04-23 19:47:29.849+0200 I/servicemanager(21592): es.ugr.frailty.gyroscope alive timeout
04-23 19:47:29.849+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 19:47:29.849+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:29.849+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:29.859+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22275
04-23 19:47:29.859+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:29.899+0200 E/CAPI_APPFW_APPLICATION(22275): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:29.899+0200 E/CAPI_APPFW_APPLICATION(22275): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:29.899+0200 I/utils   (22275): trying to start service: es.ugr.frailty.gyroscope
04-23 19:47:29.899+0200 I/utils   (22275): es.ugr.frailty.gyroscope sensor supported
04-23 19:47:29.919+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22275
04-23 19:47:29.919+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(22275) type(svcapp) bg(0)
04-23 19:47:29.919+0200 I/utils   (22275): es.ugr.frailty.gyroscope listener started
04-23 19:47:29.919+0200 W/CAPI_APPFW_APP_CONTROL(22275): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:29.919+0200 I/utils   (22275): specific action
04-23 19:47:29.919+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22275)
04-23 19:47:29.919+0200 I/servicemanager(21592): es.ugr.frailty.gyroscope launch request sent!
04-23 19:47:29.919+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:29.919+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22275) was created
04-23 19:47:29.919+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22275]
04-23 19:47:29.929+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:29.939+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22275
04-23 19:47:29.949+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:29.969+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:29.969+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22275
04-23 19:47:29.979+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:29.979+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:29.979+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:29.989+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:29:991,14.840000,-6.930000,4.480000
04-23 19:47:29.989+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:29:991,2.931208,-9.518648,-2.478964
04-23 19:47:30.179+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:30.179+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:30.189+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:30:192,3.390630,-9.432507,-2.615355
04-23 19:47:30.199+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:30:192,14.630000,-3.640000,4.690000
04-23 19:47:30.379+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:30.379+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:30.399+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:30:396,-0.210000,-0.210000,-0.560000
04-23 19:47:30.399+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:30:393,3.321238,-9.399008,-2.519642
04-23 19:47:30.409+0200 I/servicemanager(21592): es.ugr.frailty.linearacceleration alive timeout
04-23 19:47:30.409+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
04-23 19:47:30.409+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:30.419+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:30.439+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22310
04-23 19:47:30.439+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:30.489+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22310
04-23 19:47:30.489+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.linearacceleration) pid(22310) type(svcapp) bg(0)
04-23 19:47:30.499+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22310]
04-23 19:47:30.529+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22310)
04-23 19:47:30.529+0200 I/servicemanager(21592): es.ugr.frailty.linearacceleration launch request sent!
04-23 19:47:30.549+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:30.549+0200 I/servicemanager(21592): es.ugr.frailty.location alive timeout
04-23 19:47:30.549+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:47:30.549+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:30.569+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22310
04-23 19:47:30.569+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:30.569+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:30.589+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22314
04-23 19:47:30.589+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:30.619+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:30.639+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22314
04-23 19:47:30.639+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22314) type(svcapp) bg(0)
04-23 19:47:30.639+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:30.649+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22314]
04-23 19:47:30.669+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:30.679+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:30.679+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:30:683,3.199204,-9.415757,-2.435893
04-23 19:47:30.679+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22314
04-23 19:47:30.679+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:30.719+0200 E/CAPI_APPFW_APPLICATION(22314): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:30.719+0200 E/CAPI_APPFW_APPLICATION(22314): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:30.719+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22314) was created
04-23 19:47:30.739+0200 W/LOCATION(22314): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 19:47:30.739+0200 E/LOCATION(22314): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 19:47:30.739+0200 E/PKGMGR_INFO(22314): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 19:47:30.749+0200 W/LOCATION(22314): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:30.759+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22314)
04-23 19:47:30.759+0200 I/servicemanager(21592): es.ugr.frailty.location launch request sent!
04-23 19:47:30.759+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:30.759+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:30:633,8.470000,-5.040000,-4.970000
04-23 19:47:30.759+0200 E/CAPI_APPFW_APPLICATION(22310): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:30.759+0200 E/CAPI_APPFW_APPLICATION(22310): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:30.759+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22310) was created
04-23 19:47:30.769+0200 I/utils   (22310): trying to start service: es.ugr.frailty.linearacceleration
04-23 19:47:30.779+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:30.779+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22310
04-23 19:47:30.789+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:30.789+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:30:794,8.330000,-9.030000,3.780000
04-23 19:47:30.789+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:30.799+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:30.799+0200 I/utils   (22310): es.ugr.frailty.linearacceleration sensor supported
04-23 19:47:30.799+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:30:798,3.168097,-8.623734,-2.103291
04-23 19:47:30.819+0200 I/utils   (22310): es.ugr.frailty.linearacceleration listener started
04-23 19:47:30.819+0200 W/CAPI_APPFW_APP_CONTROL(22310): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:30.819+0200 I/utils   (22310): specific action
04-23 19:47:30.819+0200 I/LOCATION(22314): location.c: location_new(269) > method: 0
04-23 19:47:30.819+0200 W/LOCATION(22314): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:30.829+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:30.839+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22314
04-23 19:47:30.839+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:30.849+0200 W/LOCATION(22314): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:30.849+0200 W/LOCATION(22314): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:30.859+0200 W/LOCATION(22314): module-internal.c: module_new(311) > module (gps) open success
04-23 19:47:30.859+0200 W/LOCATION(22314): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:47:30.859+0200 W/LOCATION(22314): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:47:30.859+0200 W/LOCATION(22314): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:30.859+0200 W/LOCATION(22314): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:30.859+0200 W/LOCATION(22314): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:30.889+0200 W/LOCATION(22314): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:47:30.889+0200 W/LOCATION(22314): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:47:30.889+0200 W/LOCATION(22314): module-internal.c: module_new(311) > module (wps) open success
04-23 19:47:30.899+0200 W/LOCATION(22314): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 19:47:30.899+0200 W/LOCATION(22314): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 19:47:30.899+0200 W/LOCATION(22314): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:47:30.899+0200 W/LOCATION(22314): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:47:30.919+0200 W/LOCATION(22314): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 19:47:30.919+0200 I/LOCATION(22314): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf71eec18
04-23 19:47:30.919+0200 I/LOCATION(22314): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 19:47:30.919+0200 I/LOCATION(22314): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf71eec18
04-23 19:47:30.919+0200 I/LOCATION(22314): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 19:47:30.919+0200 I/location(22314): es.ugr.frailty.location: creado servicio de localización
04-23 19:47:30.969+0200 I/LOCATION(22314): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 19:47:30.979+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:30.979+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:30.989+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:30.999+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:30:995,4.270000,-1.820000,-1.330000
04-23 19:47:30.999+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:30:996,-0.365674,-0.821051,1.112638
04-23 19:47:30.999+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:30:993,3.342773,-9.238688,-2.287539
04-23 19:47:31.009+0200 W/LOCATION(22314): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:31.009+0200 W/LOCATION(22314): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:31.009+0200 I/LOCATION(22314): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:31.009+0200 I/servicemanager(21592): es.ugr.frailty.gravity alive timeout
04-23 19:47:31.009+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 19:47:31.009+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:31.009+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:31.019+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22332
04-23 19:47:31.049+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:31.069+0200 E/CAPI_APPFW_APPLICATION(22332): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:31.069+0200 E/CAPI_APPFW_APPLICATION(22332): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:31.069+0200 I/utils   (22332): trying to start service: es.ugr.frailty.gravity
04-23 19:47:31.069+0200 I/utils   (22332): es.ugr.frailty.gravity sensor supported
04-23 19:47:31.069+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22332
04-23 19:47:31.069+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(22332) type(svcapp) bg(0)
04-23 19:47:31.079+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22332]
04-23 19:47:31.079+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22332)
04-23 19:47:31.089+0200 I/servicemanager(21592): es.ugr.frailty.gravity launch request sent!
04-23 19:47:31.089+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:31.089+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22332) was created
04-23 19:47:31.089+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:31.099+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22332
04-23 19:47:31.099+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:31.109+0200 I/utils   (22332): es.ugr.frailty.gravity listener started
04-23 19:47:31.109+0200 W/CAPI_APPFW_APP_CONTROL(22332): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.109+0200 I/utils   (22332): specific action
04-23 19:47:31.109+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22332
04-23 19:47:31.119+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:31.119+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:31.119+0200 W/libgps_d( 3158): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 19:47:31.119+0200 W/libgps  ( 3158): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 19:47:31.119+0200 W/libgps_d( 3158): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 19:47:31.119+0200 W/libgps_d( 3158): GpsiHookStateIdle             : EXIT
04-23 19:47:31.119+0200 W/libgps_d( 3158): GpsiHookStateGps              : ENTRY
04-23 19:47:31.119+0200 W/libgps  ( 3158): [proxy__gps_start][line = 1022]: called.
04-23 19:47:31.119+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:47:31.119+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:47:31.129+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:26
04-23 19:47:31.129+0200 D/gpsd_d  ( 3126): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 19:47:31.129+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:27
04-23 19:47:31.129+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:8
04-23 19:47:31.129+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 19:47:31.129+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:1
04-23 19:47:31.129+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(11), data(0xf7672238), size(4)
04-23 19:47:31.129+0200 W/libgps_d( 3158): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 19:47:31.129+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 19:47:31.129+0200 W/libgps_d( 3158): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 19:47:31.179+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.179+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.189+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.199+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:197,10.150000,2.170000,-1.960000
04-23 19:47:31.199+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:199,0.033289,-0.101802,-0.365213
04-23 19:47:31.199+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:193,3.282953,-9.083155,-2.589034
04-23 19:47:31.209+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.209+0200 W/LOCATION(22314): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:47:31.209+0200 W/LOCATION(22314): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:47:31.209+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:215,3.195371,-9.008409,-2.192845
04-23 19:47:31.289+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:31.339+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: connection_create(453) > New handle created[0xf7b22ab8]
04-23 19:47:31.349+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 19:47:31.349+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 19:47:31.349+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 19:47:31.349+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: connection_get_type(507) > Connected Network = 2
04-23 19:47:31.359+0200 W/LOCATION(21673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:31.359+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:31.359+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 19:47:31.359+0200 W/libgps  ( 3158): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3311645), time2(3301346)
04-23 19:47:31.359+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 19:47:31.359+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 19:47:31.359+0200 I/libgps_d( 3158): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 19:47:31.359+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:25
04-23 19:47:31.369+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:31.379+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:31.379+0200 E/LOCATION(21673): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 19:47:31.379+0200 I/LOCATION(21673): location.c: location_new(269) > method: 1
04-23 19:47:31.379+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:31.379+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (gps) open success
04-23 19:47:31.379+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:47:31.379+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:47:31.379+0200 W/LOCATION(21673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:31.379+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:31.379+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:31.389+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.389+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.389+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.399+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:31.399+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.409+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:31.409+0200 E/LOCATION(21673): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:47:31.409+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:31.419+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:398,3.199204,-9.059227,-2.727818
04-23 19:47:31.429+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:396,0.003833,-0.050818,-0.534973
04-23 19:47:31.429+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:411,3.131196,-8.998139,-2.323680
04-23 19:47:31.429+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:399,1.330000,-0.070000,3.010000
04-23 19:47:31.469+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:31.499+0200 W/LOCATION(22314): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 19:47:31.499+0200 I/LOCATION(22314): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 19:47:31.499+0200 I/LOCATION(22314): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 19:47:31.499+0200 I/location(22314): es.ugr.frailty.location:iniciado servicio de localización
04-23 19:47:31.579+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.579+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.589+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.589+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.609+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:591,3.360000,-0.700000,0.770000
04-23 19:47:31.609+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:593,3.115114,-8.977709,-2.422228
04-23 19:47:31.609+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:592,3.239882,-9.006584,-2.804388
04-23 19:47:31.609+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:596,0.108686,-0.008445,-0.480708
04-23 19:47:31.639+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:47:31.639+0200 W/libgps_d( 3158): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 19:47:31.649+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 19:47:31.649+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:47:31.649+0200 E/CAPI_LOCATION_MANAGER(21673): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:47:31.649+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.649+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:656,-1.540000,0.140000,2.310000
04-23 19:47:31.659+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.659+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:31.659+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:665,3.232704,-9.008978,-2.591427
04-23 19:47:31.659+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.659+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.669+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:671,0.117590,-0.031269,-0.169199
04-23 19:47:31.669+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:31.669+0200 E/LOCATION(21673): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 19:47:31.669+0200 I/LOCATION(21673): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 19:47:31.669+0200 I/LOCATION(21673): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:31.669+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:670,3.118441,-8.970560,-2.444331
04-23 19:47:31.669+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.669+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.679+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.679+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.679+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:680,0.138191,-0.026453,-0.247594
04-23 19:47:31.679+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:683,3.256632,-8.997013,-2.691926
04-23 19:47:31.679+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.689+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:683,3.117078,-8.969801,-2.448851
04-23 19:47:31.689+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:692,0.070162,-0.302387,-0.453643
04-23 19:47:31.689+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:690,2.240000,0.070000,1.960000
04-23 19:47:31.689+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.689+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.689+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.699+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.709+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:701,3.111152,-8.968161,-2.462360
04-23 19:47:31.709+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:712,0.150265,-0.076709,-0.227173
04-23 19:47:31.709+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:710,0.630000,0.210000,1.540000
04-23 19:47:31.709+0200 I/LOCATION(22314): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:31.709+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:703,3.187240,-9.272188,-2.902494
04-23 19:47:31.709+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.709+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.709+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.719+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:723,3.261417,-9.044869,-2.689533
04-23 19:47:31.729+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.729+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:727,3.115863,-8.963762,-2.472399
04-23 19:47:31.729+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:733,0.121626,0.081604,-0.154921
04-23 19:47:31.729+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.729+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:729,-1.400000,0.910000,0.980000
04-23 19:47:31.729+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.729+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.739+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:745,2.170000,1.260000,1.120000
04-23 19:47:31.739+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:743,3.237489,-8.882158,-2.627320
04-23 19:47:31.739+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:740,3.118118,-8.962494,-2.474152
04-23 19:47:31.749+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.749+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.749+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:757,0.042801,0.197585,-0.241702
04-23 19:47:31.749+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.759+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.759+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:763,4.410000,0.490000,1.470000
04-23 19:47:31.759+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:762,3.160919,-8.764909,-2.715853
04-23 19:47:31.759+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:758,3.115014,-8.962688,-2.477357
04-23 19:47:31.759+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.769+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.769+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.769+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.769+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:772,0.134439,0.032674,-0.338995
04-23 19:47:31.769+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:776,3.249453,-8.930015,-2.816352
04-23 19:47:31.779+0200 E/location(22314): es.ugr.frailty.location: error intentando obtener la última localización
04-23 19:47:31.779+0200 W/AUL     (22314): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 19:47:31.779+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:31.779+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 22314
04-23 19:47:31.779+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:780,3.920000,0.140000,1.890000
04-23 19:47:31.779+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:775,3.112643,-8.961875,-2.483272
04-23 19:47:31.779+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.789+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21592
04-23 19:47:31.789+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.789+0200 I/utils   (21592): specific action
04-23 19:47:31.789+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.789+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.789+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:47:31.789+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21592), cmd(0)
04-23 19:47:31.789+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.789+0200 W/AUL     (22314): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21592)
04-23 19:47:31.789+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 19:47:31.789+0200 I/location(22314): request sent to service es.ugr.frailty.servicemanager
04-23 19:47:31.789+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:793,0.065026,-0.240921,-0.337866
04-23 19:47:31.789+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:31.789+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.789+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:31.789+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:799,3.177669,-9.202796,-2.821138
04-23 19:47:31.789+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.789+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.799+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21598
04-23 19:47:31.799+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21598)
04-23 19:47:31.799+0200 I/servicemanager(21592): request sent to service es.ugr.frailty.recorder
04-23 19:47:31.799+0200 I/servicemanager(21592): requesting to save local data
04-23 19:47:31.799+0200 W/CAPI_APPFW_APP_CONTROL(22314): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.799+0200 I/utils   (22314): specific action
04-23 19:47:31.799+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:47:31.799+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21598), cmd(0)
04-23 19:47:31.799+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.799+0200 I/utils   (21598): specific action
04-23 19:47:31.799+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.799+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.799+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.799+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:31.799+0200 I/recorder(21598): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 19:47:31.799+0200 I/recorder(21598): guardando datos en local
04-23 19:47:31.799+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.809+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:812,0.151785,-0.257055,-0.209633
04-23 19:47:31.809+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:803,3.112025,-8.957705,-2.499043
04-23 19:47:31.809+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:806,-2.660000,0.420000,1.050000
04-23 19:47:31.819+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.819+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.819+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:823,3.263810,-9.214760,-2.708675
04-23 19:47:31.819+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.819+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:824,-6.930000,-0.140000,0.980000
04-23 19:47:31.819+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:827,3.119204,-8.950090,-2.517306
04-23 19:47:31.829+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.829+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.829+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:834,-0.770000,0.280000,-0.070000
04-23 19:47:31.829+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.829+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:834,0.149392,-0.078029,0.002449
04-23 19:47:31.829+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:837,3.268596,-9.028119,-2.514857
04-23 19:47:31.829+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.839+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:841,3.125518,-8.947940,-2.517122
04-23 19:47:31.849+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.849+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.849+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:857,0.116757,0.068175,-0.112590
04-23 19:47:31.849+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:858,3.500000,-0.420000,0.350000
04-23 19:47:31.849+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.859+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.859+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:863,3.126532,-8.947944,-2.515848
04-23 19:47:31.859+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:862,3.242275,-8.879765,-2.629712
04-23 19:47:31.859+0200 I/LOCATION(22314): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:31.859+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.859+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.869+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:872,0.163599,-0.044284,-0.113864
04-23 19:47:31.869+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:873,2.660000,-0.070000,0.630000
04-23 19:47:31.869+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.869+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:877,3.290131,-8.992228,-2.629712
04-23 19:47:31.869+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.879+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:881,3.128432,-8.947698,-2.514360
04-23 19:47:31.879+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.879+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.889+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:893,0.042058,-0.121099,-0.227814
04-23 19:47:31.889+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:893,0.420000,-0.140000,0.770000
04-23 19:47:31.889+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.889+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:897,3.170490,-9.068797,-2.742175
04-23 19:47:31.889+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.899+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:901,3.125775,-8.946602,-2.521555
04-23 19:47:31.899+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.899+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.909+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.909+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:916,-2.660000,0.140000,0.770000
04-23 19:47:31.909+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:915,3.103491,-9.219545,-2.780460
04-23 19:47:31.919+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:913,-0.022283,-0.272943,-0.258905
04-23 19:47:31.919+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.919+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:926,3.121527,-8.944493,-2.534263
04-23 19:47:31.929+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.929+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.929+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:935,3.144169,-8.997013,-2.653640
04-23 19:47:31.929+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:939,1.190000,0.280000,0.700000
04-23 19:47:31.929+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.939+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:943,0.022642,-0.052520,-0.119378
04-23 19:47:31.939+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.939+0200 I/gravity (22332): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:31:948,3.118982,-8.944902,-2.535954
04-23 19:47:31.949+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.949+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.949+0200 I/accelerometer(22262): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:31:958,3.282953,-8.930015,-2.744568
04-23 19:47:31.949+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.959+0200 I/gyroscope(22275): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:31:962,6.300000,-0.280000,0.280000
04-23 19:47:31.959+0200 I/linearacceleration(22310): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:31:963,0.163971,0.014888,-0.208614
04-23 19:47:31.959+0200 I/gravity (22332): capturing data from es.ugr.frailty.gravity
04-23 19:47:31.969+0200 I/linearacceleration(22310): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:31.999+0200 I/accelerometer(22262): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:31.999+0200 I/gyroscope(22275): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:31.999+0200 W/CRASH_MANAGER(21684): worker.c: worker_job(1205) > 11223146c6f63152450565
