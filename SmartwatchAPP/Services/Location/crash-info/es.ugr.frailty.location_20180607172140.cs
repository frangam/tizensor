S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20394
Date: 2018-06-07 17:21:40+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf751a52d, r5   = 0xf7768f98
r6   = 0xffbc79a0, r7   = 0xffbc7850
r8   = 0xf7765c18, r9   = 0x00000000
r10  = 0xffbc792c, fp   = 0xffbc79a0
ip   = 0x00000001, sp   = 0xffbc7828
lr   = 0xf751a539, pc   = 0xf7583228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    285204 KB
Buffers:      8868 KB
Cached:      52624 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11856 KB
VmRSS:       11856 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20394 TID = 20394
20394 20397 

Maps Information
f43e5000 f4be4000 rw-p [stack:20397]
f4beb000 f4bed000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bf5000 f4bf9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c02000 f4c04000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c0c000 f4c0f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c1e000 f4c23000 r-xp /usr/lib/libsystem.so.0.0.0
f4c2e000 f4c31000 r-xp /lib/libattr.so.1.1.0
f4c39000 f4c49000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c51000 f4c5a000 r-xp /usr/lib/libedbus.so.1.7.99
f4c62000 f4c63000 r-xp /usr/lib/libresponse.so.0.2.96
f4c6c000 f4c71000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6513000 f6619000 r-xp /usr/lib/libicuuc.so.57.1
f662f000 f67b7000 r-xp /usr/lib/libicui18n.so.57.1
f67c7000 f67d4000 r-xp /usr/lib/libail.so.0.1.0
f67dd000 f67e4000 r-xp /usr/lib/libminizip.so.1.0.0
f67ed000 f6996000 r-xp /usr/lib/libcrypto.so.1.0.0
f69b6000 f69fd000 r-xp /usr/lib/libssl.so.1.0.0
f6a09000 f6a0b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a13000 f6a1a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a23000 f6a2a000 r-xp /lib/libcrypt-2.13.so
f6a5b000 f6a5e000 r-xp /lib/libcap.so.2.21
f6a66000 f6a68000 r-xp /usr/lib/libiri.so
f6a70000 f6ab9000 r-xp /usr/lib/libmdm.so.1.2.69
f6ac1000 f6ac7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6acf000 f6af2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6afc000 f6afe000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b06000 f6b23000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b2c000 f6b30000 r-xp /usr/lib/libsmack.so.1.0.0
f6b39000 f6b52000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b5b000 f6b63000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b6b000 f6b71000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b7a000 f6b7c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b85000 f6b95000 r-xp /lib/libresolv-2.13.so
f6b99000 f6bb1000 r-xp /usr/lib/liblzma.so.5.0.3
f6bba000 f6bbc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bc4000 f6bde000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6be6000 f6c15000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c1e000 f6c2d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c37000 f6c41000 r-xp /usr/lib/libsensord-shared.so
f6c4a000 f6d1d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d28000 f6d3e000 r-xp /lib/libz.so.1.2.5
f6d46000 f6d4b000 r-xp /usr/lib/libffi.so.5.0.10
f6d53000 f6d54000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d5c000 f6d6c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d74000 f6d8d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d95000 f6d97000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d9f000 f6e14000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e1e000 f6e24000 r-xp /lib/librt-2.13.so
f6e2d000 f6e4b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e55000 f6e56000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e5e000 f6e81000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e89000 f6e8e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e96000 f6ec0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ec9000 f6ee0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ee8000 f6f51000 r-xp /lib/libm-2.13.so
f6f5a000 f6fee000 r-xp /usr/lib/libstdc++.so.6.0.16
f7001000 f7006000 r-xp /usr/lib/libctx-client.so.0.8.3
f700e000 f7015000 r-xp /usr/lib/libctx-shared.so.0.8.3
f701d000 f7047000 r-xp /usr/lib/libsensor.so.1.9.6
f7050000 f711c000 r-xp /usr/lib/libxml2.so.2.7.8
f7129000 f712b000 r-xp /usr/lib/libiniparser.so.0
f7134000 f713a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7143000 f7213000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7214000 f7248000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7251000 f728d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7295000 f7298000 r-xp /usr/lib/libbundle.so.0.1.22
f72a0000 f72a6000 r-xp /usr/lib/libappsvc.so.0.1.0
f72ae000 f72ef000 r-xp /usr/lib/libeina.so.1.7.99
f72f8000 f730f000 r-xp /usr/lib/libecore.so.1.7.99
f7326000 f732f000 r-xp /usr/lib/libvconf.so.0.2.45
f7337000 f734b000 r-xp /lib/libpthread-2.13.so
f7356000 f7363000 r-xp /usr/lib/libaul.so.0.1.0
f736d000 f736f000 r-xp /lib/libdl-2.13.so
f7378000 f7383000 r-xp /lib/libunwind.so.8.0.1
f73b0000 f73b8000 r-xp /lib/libgcc_s-4.6.so.1
f73b9000 f74dd000 r-xp /lib/libc-2.13.so
f74eb000 f74ed000 r-xp /usr/lib/libdlog.so.0.0.0
f74f5000 f7501000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f750a000 f750f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7517000 f7526000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f752e000 f7532000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f753b000 f753e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7546000 f7548000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7550000 f7554000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f755c000 f7579000 r-xp /lib/ld-2.13.so
f7582000 f7585000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7585000 f7589000 r-xp /usr/lib/libsys-assert.so
f7735000 f77a6000 rw-p [heap]
ffba9000 ffbca000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20394)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7583228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf751a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72213f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf721fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf722be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7231be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7231dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf726675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72611f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf721fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf722be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7231be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7231dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7263e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7264017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf726bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c031fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bf6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cc9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7176fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71787a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7308ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7303b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73045a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7304879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf753c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf753c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75835c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf73d085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7582f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
-07 17:23:14.861+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:23:14.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: restart, dead pid: 19682
06-07 17:23:14.861+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:23:14.871+0200 E/AUL     (20757): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-07 17:23:14.871+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19682
06-07 17:23:14.871+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19682)
06-07 17:23:14.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:14.901+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19663
06-07 17:23:14.901+0200 E/rpm-installer(20721): installer-util.c: __check_running_app(1774) > app[es.ugr.frailty.pressure] is running, need to terminate it.
06-07 17:23:14.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:23:14.911+0200 W/AUL     (20721): launch.c: app_request_to_launchpad(284) > request cmd(5) to(19663)
06-07 17:23:14.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 5
06-07 17:23:14.911+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(es.ugr.frailty.pressure) pid(19663) type(svcapp)
06-07 17:23:14.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:23:14.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:23:14.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19663), cmd(4)
06-07 17:23:14.921+0200 W/AUL     (20721): launch.c: app_request_to_launchpad(298) > request cmd(5) result(0)
06-07 17:23:14.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:14.941+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19663
06-07 17:23:14.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:14.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:15.001+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:23:15.011+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:23:15.021+0200 I/pressure(19663): es.ugr.frailty.pressure listener destroyed
06-07 17:23:15.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:15.051+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19663
06-07 17:23:15.091+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:23:15.091+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:23:15.101+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:15.101+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:23:15.101+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:23:15.101+0200 E/CAPI_APPFW_APP_CONTROL(19582): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:23:15.101+0200 E/servicemanager(19582): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:23:15.101+0200 I/servicemanager(19582): App control destroyed.
06-07 17:23:15.101+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:23:15.101+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:23:15.101+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:15.111+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:23:15.111+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:23:15.111+0200 E/CAPI_APPFW_APP_CONTROL(19582): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:23:15.111+0200 E/servicemanager(19582): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:23:15.111+0200 I/servicemanager(19582): App control destroyed.
06-07 17:23:15.111+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:23:15.111+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:23:15.111+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:15.121+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:23:15.121+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:23:15.121+0200 E/CAPI_APPFW_APP_CONTROL(19582): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:23:15.121+0200 E/servicemanager(19582): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:23:15.121+0200 I/servicemanager(19582): App control destroyed.
06-07 17:23:15.121+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:23:15.121+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:23:15.121+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:15.121+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:23:15.151+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:23:15.151+0200 E/CAPI_APPFW_APP_CONTROL(19582): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:23:15.151+0200 E/servicemanager(19582): es.ugr.frailty.location launch request sending failed!
06-07 17:23:15.151+0200 I/servicemanager(19582): App control destroyed.
06-07 17:23:15.151+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:23:15.151+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:23:15.151+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:15.151+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:23:15.151+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:15.171+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:23:15.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:15.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:15.201+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:15.211+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19585
06-07 17:23:15.211+0200 E/rpm-installer(20721): installer-util.c: __check_running_app(1774) > app[es.ugr.frailty.recorder] is running, need to terminate it.
06-07 17:23:15.221+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:23:15.221+0200 W/AUL     (20721): launch.c: app_request_to_launchpad(284) > request cmd(5) to(19585)
06-07 17:23:15.221+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 5
06-07 17:23:15.221+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:23:15.221+0200 E/CAPI_APPFW_APP_CONTROL(19582): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:23:15.221+0200 E/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:23:15.221+0200 I/servicemanager(19582): App control destroyed.
06-07 17:23:15.221+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:23:15.221+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:23:15.221+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(es.ugr.frailty.recorder) pid(19585) type(svcapp)
06-07 17:23:15.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:15.231+0200 E/PKGMGR_SERVER(20720): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:23:15.231+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:23:15.241+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:23:15.241+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:23:15.241+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19585), cmd(4)
06-07 17:23:15.241+0200 W/AUL     (20721): launch.c: app_request_to_launchpad(298) > request cmd(5) result(0)
06-07 17:23:15.241+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:15.251+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19585
06-07 17:23:15.261+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:23:15.261+0200 E/CAPI_APPFW_APP_CONTROL(19582): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:23:15.261+0200 E/servicemanager(19582): es.ugr.frailty.gravity launch request sending failed!
06-07 17:23:15.261+0200 I/servicemanager(19582): App control destroyed.
06-07 17:23:15.261+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:23:15.261+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:23:15.261+0200 W/AUL     (20760): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.pressure]
06-07 17:23:15.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:15.261+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:23:15.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:23:15.271+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:23:15.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: restart, dead pid: 19663
06-07 17:23:15.271+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:23:15.271+0200 E/AUL     (20760): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-07 17:23:15.271+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19663
06-07 17:23:15.271+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19663)
06-07 17:23:15.281+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:23:15.281+0200 E/CAPI_APPFW_APP_CONTROL(19582): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:23:15.281+0200 E/servicemanager(19582): es.ugr.frailty.pressure launch request sending failed!
06-07 17:23:15.281+0200 I/servicemanager(19582): App control destroyed.
06-07 17:23:15.281+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:23:15.281+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:23:15.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:15.281+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:23:15.291+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:23:15.291+0200 E/CAPI_APPFW_APP_CONTROL(19582): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:23:15.291+0200 E/servicemanager(19582): es.ugr.frailty.light launch request sending failed!
06-07 17:23:15.291+0200 I/servicemanager(19582): App control destroyed.
06-07 17:23:15.291+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:23:15.291+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:23:15.291+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:15.291+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:23:15.301+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:23:15.301+0200 E/CAPI_APPFW_APP_CONTROL(19582): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:23:15.301+0200 E/servicemanager(19582): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:23:15.301+0200 I/servicemanager(19582): App control destroyed.
06-07 17:23:15.361+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:15.371+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:23:15.381+0200 W/AUL     (20761): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
06-07 17:23:15.381+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:23:15.381+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:23:15.381+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: restart, dead pid: 19585
06-07 17:23:15.381+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:23:15.391+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19585
06-07 17:23:15.391+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19585)
06-07 17:23:15.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:15.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:15.391+0200 E/AUL     (20761): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-07 17:23:15.421+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:15.421+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19582
06-07 17:23:15.431+0200 E/rpm-installer(20721): installer-util.c: __check_running_app(1774) > app[es.ugr.frailty.servicemanager] is running, need to terminate it.
06-07 17:23:15.431+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:23:15.441+0200 W/AUL     (20721): launch.c: app_request_to_launchpad(284) > request cmd(5) to(19582)
06-07 17:23:15.441+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 5
06-07 17:23:15.441+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(es.ugr.frailty.servicemanager) pid(19582) type(svcapp)
06-07 17:23:15.451+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19582), cmd(4)
06-07 17:23:15.451+0200 W/AUL     (20721): launch.c: app_request_to_launchpad(298) > request cmd(5) result(0)
06-07 17:23:15.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:23:15.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:23:15.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:15.471+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19582
06-07 17:23:15.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:23:15.581+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:23:15.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:15.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:15.601+0200 W/AUL     (20762): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.servicemanager]
06-07 17:23:15.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:23:15.601+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:23:15.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: restart, dead pid: 19582
06-07 17:23:15.601+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:23:15.611+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19582
06-07 17:23:15.611+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19582)
06-07 17:23:15.621+0200 E/AUL     (20762): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-07 17:23:15.631+0200 E/PKGMGR_PARSER(20721): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-07 17:23:15.651+0200 I/PRIVACY-MANAGER-CLIENT(20721): SocketClient.cpp: SocketClient(37) > Client created
06-07 17:23:15.651+0200 I/PRIVACY-MANAGER-CLIENT(20721): SocketStream.h: SocketStream(31) > Created
06-07 17:23:15.661+0200 I/PRIVACY-MANAGER-CLIENT(20721): SocketConnection.h: SocketConnection(44) > Created
06-07 17:23:15.661+0200 I/PRIVACY-MANAGER-CLIENT(20721): SocketClient.cpp: connect(62) > Client connected
06-07 17:23:15.661+0200 I/PRIVACY-MANAGER-SERVER( 2458): SocketService.cpp: mainloop(227) > Got incoming connection
06-07 17:23:15.661+0200 I/PRIVACY-MANAGER-SERVER( 2458): SocketService.cpp: connectionThread(253) > Starting connection thread
06-07 17:23:15.661+0200 I/PRIVACY-MANAGER-SERVER( 2458): SocketStream.h: SocketStream(31) > Created
06-07 17:23:15.661+0200 I/PRIVACY-MANAGER-SERVER( 2458): SocketConnection.h: SocketConnection(44) > Created
06-07 17:23:15.661+0200 I/PRIVACY-MANAGER-SERVER( 2458): SocketService.cpp: connectionService(304) > Calling service
06-07 17:23:15.691+0200 I/PRIVACY-MANAGER-SERVER( 2458): SocketService.cpp: connectionService(307) > Removing client
06-07 17:23:15.691+0200 I/PRIVACY-MANAGER-SERVER( 2458): SocketService.cpp: connectionService(311) > Call served
06-07 17:23:15.691+0200 I/PRIVACY-MANAGER-SERVER( 2458): SocketService.cpp: connectionThread(262) > Client serviced
06-07 17:23:15.691+0200 I/PRIVACY-MANAGER-CLIENT(20721): SocketClient.cpp: disconnect(72) > Client disconnected
06-07 17:23:15.731+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 17:23:15.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:15.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:15.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:15.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:16.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:16.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:16.221+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 17:23:16.251+0200 E/PKGMGR_CERT(20721): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Transaction Begin
06-07 17:23:16.291+0200 E/PKGMGR_CERT(20721): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(621) > Certificate Deletion Success
06-07 17:23:16.301+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 19566 pgid = 19566
06-07 17:23:16.301+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
06-07 17:23:16.321+0200 E/PKGMGR_CERT(20721): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(634) > Transaction Commit and End
06-07 17:23:16.321+0200 E/rpm-installer(20721): coretpk-installer.c: _coretpk_installer_uninstall_package(4163) > success
06-07 17:23:16.321+0200 E/rpm-installer(20721): coretpk-installer.c: _coretpk_installer_uninstall_package(4164) > try to classify and delete residual files
06-07 17:23:16.351+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19566
06-07 17:23:16.351+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19566)
06-07 17:23:16.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:16.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:16.451+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-07 17:23:16.451+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 19553 pgid = -1
06-07 17:23:16.451+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
06-07 17:23:16.451+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-07 17:23:16.451+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19553
06-07 17:23:16.451+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19553)
06-07 17:23:16.541+0200 E/STORAGE_CLEANER(20721): storage-cleaner.c: __create_handle(448) > Failed to prepare stmt
06-07 17:23:16.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:16.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:16.591+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 17:23:16.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:16.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:16.921+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 17:23:16.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:16.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:17.111+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19387
06-07 17:23:17.111+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19387)
06-07 17:23:17.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:17.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:17.231+0200 E/PKGMGR_SERVER(20720): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:23:17.241+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 17:23:17.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:17.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:17.461+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 17:23:17.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:17.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:17.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:17.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:17.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:17.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:18.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:18.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:18.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:18.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:18.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:18.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:18.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:18.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:18.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:18.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:19.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:19.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:19.231+0200 E/PKGMGR_SERVER(20720): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:23:19.291+0200 W/W_HOME  ( 2762): clock_event.c: _pkgmgr_event_cb(226) > Pkg:es.ugr.frailty.frailtylauncher is uninstalled, delete related resource
06-07 17:23:19.291+0200 W/W_HOME  ( 2762): clock_event.c: _pkgmgr_event_cb(230) > attacheck clock:com.samsung.watchface
06-07 17:23:19.291+0200 W/W_HOME  ( 2762): dbox.c: uninstall_cb(1406) > uninstalled:es.ugr.frailty.frailtylauncher
06-07 17:23:19.291+0200 E/PUSHD   ( 3162): db.c: _get_app_info_by_query(316) > DB step: 101 [unknown error]
06-07 17:23:19.291+0200 E/PUSHD   ( 3162): db.c: db_reg_get_by_tizen_pkg_id(393) > Fail to get app_info
06-07 17:23:19.311+0200 E/STARTER ( 2696): pkg-monitor.c: _pkg_monitor_get_mainappid(105) > [_pkg_monitor_get_mainappid:105] Failed to get pkginfo[-1]
06-07 17:23:19.321+0200 W/AUL_AMD ( 2479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(es.ugr.frailty.frailtylauncher), key(end), value(ok)
06-07 17:23:19.321+0200 W/AUL_AMD ( 2479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1037) > g_hash_table_foreach_remove, 13
06-07 17:23:19.321+0200 W/APPS    ( 2762): AppsViewNecklace.cpp: onRemoveItem(466) >  [frailtylauncher]
06-07 17:23:19.321+0200 W/APPS    ( 2762): AppsItem.cpp: onItemBadgeRemove(848) >  [frailtylauncher] remove badge db
06-07 17:23:19.331+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_log_package(4743) > package [_________] callback : [UNINSTALL, COMPLETED]
06-07 17:23:19.331+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7022) > package uninstall complete
06-07 17:23:19.331+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7028) > disabled_pkg_list : 
06-07 17:23:19.331+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_package_uninstall_event(4922) > 
06-07 17:23:19.331+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2038) > Found in install_req_list?[0], index[-1]
06-07 17:23:19.331+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_package_uninstall_event(4928) > installe_req_list is NULL.
06-07 17:23:19.341+0200 E/rpm-installer(20721): rpm-appcore-intf.c: main(273) > ------------------------------------------------
06-07 17:23:19.341+0200 E/rpm-installer(20721): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
06-07 17:23:19.341+0200 E/rpm-installer(20721): rpm-appcore-intf.c: main(275) > ------------------------------------------------
06-07 17:23:19.351+0200 E/PKGMGR_SERVER(20720): pkgmgr-server.c: sighandler(486) > child NORMAL exit [20721]
06-07 17:23:19.361+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
06-07 17:23:19.371+0200 E/WMS     ( 2465): wms_db.c: wms_db_package_event_insert_record(190) > 
06-07 17:23:19.381+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-07 17:23:19.381+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-6-2018, 21:48:26 (UTC).
06-07 17:23:19.381+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-07 17:23:19.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:19.441+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/20721/oom_score_adj failed
06-07 17:23:19.451+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:19.451+0200 E/RESOURCED( 2560): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 20721
06-07 17:23:19.471+0200 W/APPS    ( 2762): AppsItem.cpp: setLastIndex(1264) >  This is last index app [17:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[0]
06-07 17:23:19.471+0200 W/APPS    ( 2762): AppsViewNecklace.cpp: __onSignalHideNextPage(7041) >  Hide next page [0->0]
06-07 17:23:19.471+0200 E/EFL     ( 2762): elementary<2762> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0xf7d8af90 into part 'elm.swallow.event.0'
06-07 17:23:19.491+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
06-07 17:23:19.491+0200 W/APPS    ( 2762): AppsItem.cpp: aniFocusIndex(2351) >  [Teléfono:0] Focused[0], focusIdx[0]
06-07 17:23:19.501+0200 W/APPS    ( 2762): AppsItem.cpp: setLastIndex(1264) >  This is last index app [17:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[0]
06-07 17:23:19.501+0200 W/APPS    ( 2762): AppsViewNecklace.cpp: __onSignalHideNextPage(7041) >  Hide next page [0->0]
06-07 17:23:19.501+0200 W/APPS    ( 2762): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
06-07 17:23:19.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:19.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:19.721+0200 E/PKGMGR  (20773): pkgmgr.c: pkgmgr_client_install(1656) > install pkg start.
06-07 17:23:19.771+0200 E/PKGMGR  (20720): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/es.ugr.frailty.frailtylauncher-1.0.0-arm.tpk is core
06-07 17:23:19.771+0200 E/PKGMGR  (20720): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/es.ugr.frailty.frailtylauncher-1.0.0-arm.tpk is core
06-07 17:23:19.781+0200 E/rpm-installer(20720): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-07 17:23:19.791+0200 E/BACKEND_LIB(20720): librpm.c: __is_symlink_file(70) > file is safe
06-07 17:23:19.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:19.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:19.821+0200 E/PKGMGR  (20773): pkgmgr.c: pkgmgr_client_install(1773) > install pkg finish, ret=[207730002]
06-07 17:23:19.831+0200 E/PKGMGR_SERVER(20776): pkgmgr-server.c: queue_job(1943) > INSTALL start, pkg path=[/opt/usr/apps/tmp/es.ugr.frailty.frailtylauncher-1.0.0-arm.tpk]
06-07 17:23:19.841+0200 E/PKGMGR_SERVER(20775): pkgmgr-server.c: queue_job(2137) > COMM_REQ_OBSERVER start, pkgid=[]
06-07 17:23:19.941+0200 E/rpm-installer(20776): rpm-appcore-intf.c: main(120) > ------------------------------------------------
06-07 17:23:19.951+0200 E/rpm-installer(20776): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
06-07 17:23:19.951+0200 E/rpm-installer(20776): rpm-appcore-intf.c: main(122) > ------------------------------------------------
06-07 17:23:19.951+0200 E/PKGMGR_OBSERVER(20775): pkg_observer.c: main(601) > OBSERVER start
06-07 17:23:19.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:19.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:20.101+0200 E/rpm-installer(20776): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/es.ugr.frailty.frailtylauncher-1.0.0-arm.tpk] is tpk package.
06-07 17:23:20.111+0200 E/rpm-installer(20776): coretpk-parser.c: __coretpk_parser_get_value(1713) > (result_value == NULL) [install-location] is empty.
06-07 17:23:20.121+0200 E/rpm-installer(20776): coretpk-parser.c: _coretpk_parser_is_widget(1586) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget'])
06-07 17:23:20.131+0200 E/rpm-installer(20776): coretpk-parser.c: _coretpk_parser_is_custom_clock(1480) > (ret == 1) metadata(watchface) is empty.
06-07 17:23:20.131+0200 E/rpm-installer(20776): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/es.ugr.frailty.frailtylauncher/) failed. [2][No such file or directory]
06-07 17:23:20.131+0200 E/rpm-installer(20776): coretpk-installer.c: _coretpk_installer_install_package(3579) > Deletion failed: [/opt/usr/data/pkgmgr/es.ugr.frailty.frailtylauncher/]
06-07 17:23:20.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:20.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:20.211+0200 E/PKGMGR_OBSERVER(20775): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[207750002] pkg_type[tpk] pkgid[es.ugr.frailty.frailtylauncher] key[start] val[install]
06-07 17:23:20.221+0200 W/AUL_AMD ( 2479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(es.ugr.frailty.frailtylauncher), key(start), value(install)
06-07 17:23:20.231+0200 E/PKGMGR_OBSERVER(20775): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[207750002] pkg_type[tpk] pkgid[es.ugr.frailty.frailtylauncher] key[install_percent] val[30]
06-07 17:23:20.241+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_log_package(4743) > package [_________] callback : [INSTALL, STARTED]
06-07 17:23:20.271+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_log_package(4743) > package [_________] callback : [INSTALL, PROCESSING]
06-07 17:23:20.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:20.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:20.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:20.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:20.631+0200 W/CERT_SVC(20776): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
06-07 17:23:20.671+0200 E/rpm-installer(20776): coretpk-parser.c: __coretpk_parser_verify_metadata(48) > (ret == 1) metadata is empty.
06-07 17:23:20.671+0200 E/rpm-installer(20776): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-07 17:23:20.671+0200 E/rpm-installer(20776): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
06-07 17:23:20.671+0200 E/rpm-installer(20776): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
06-07 17:23:20.771+0200 E/PKGMGR_PARSER(20776): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
06-07 17:23:20.771+0200 E/PKGMGR_PARSER(20776): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/es.ugr.frailty.frailtylauncher.xml
06-07 17:23:20.781+0200 E/PKGMGR_PARSER(20776): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-07 17:23:20.781+0200 E/PKGMGR_PARSER(20776): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
06-07 17:23:20.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:20.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:20.851+0200 W/SHealthService( 3178): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-07 17:23:20.941+0200 W/SHealthService( 3178): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-07 17:23:20.951+0200 W/SHealthService( 3178): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-07 17:23:20.961+0200 W/SHealthCommon( 3178): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1528329600000,000000[0;m
06-07 17:23:20.981+0200 I/PRIVACY-MANAGER-CLIENT(20776): SocketClient.cpp: SocketClient(37) > Client created
06-07 17:23:20.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:20.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:20.991+0200 W/SHealthCommon( 3178): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 2[0;m
06-07 17:23:21.001+0200 I/HealthDataService( 2933): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-07 17:23:21.021+0200 I/healthData( 3178): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-07 17:23:21.121+0200 I/efl-extension(20776): efl_extension.c: eext_mod_init(40) > Init
06-07 17:23:21.121+0200 I/efl-extension(20776): efl_extension.c: eext_mod_shutdown(46) > Shutdown
06-07 17:23:21.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:21.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:21.231+0200 E/PKGMGR_SERVER(20720): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:23:21.241+0200 E/PKGMGR_PARSER(20776): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
06-07 17:23:21.311+0200 E/PKGMGR_CERT(20776): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
06-07 17:23:21.311+0200 E/PKGMGR_CERT(20776): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 110
06-07 17:23:21.311+0200 E/PKGMGR_CERT(20776): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 110
06-07 17:23:21.311+0200 E/PKGMGR_CERT(20776): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 3
06-07 17:23:21.311+0200 E/PKGMGR_CERT(20776): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 3
06-07 17:23:21.311+0200 E/PKGMGR_CERT(20776): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 3
06-07 17:23:21.321+0200 E/PKGMGR_CERT(20776): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 14 3
06-07 17:23:21.331+0200 E/PKGMGR_CERT(20776): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
06-07 17:23:21.341+0200 E/PKGMGR_OBSERVER(20775): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[207750002] pkg_type[tpk] pkgid[es.ugr.frailty.frailtylauncher] key[install_percent] val[60]
06-07 17:23:21.351+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_log_package(4743) > package [_________] callback : [INSTALL, PROCESSING]
06-07 17:23:21.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:21.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:21.421+0200 E/rpm-installer(20776): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
06-07 17:23:21.431+0200 E/rpm-installer(20776): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [lZCJYx9VRInISaU4WvMLrFr+wIIhRrIfI4N1MiqufA8=] for shared/trusted.
06-07 17:23:21.471+0200 E/rpm-installer(20776): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
06-07 17:23:21.471+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20765 pgid = 20765
06-07 17:23:21.471+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
06-07 17:23:21.471+0200 E/PKGMGR_OBSERVER(20775): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[207750002] pkg_type[tpk] pkgid[es.ugr.frailty.frailtylauncher] key[install_percent] val[100]
06-07 17:23:21.541+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20765
06-07 17:23:21.541+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20765)
06-07 17:23:21.551+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_log_package(4743) > package [_________] callback : [INSTALL, PROCESSING]
06-07 17:23:21.581+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:21.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:21.601+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-07 17:23:21.601+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20766 pgid = -1
06-07 17:23:21.601+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
06-07 17:23:21.601+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-07 17:23:21.601+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20766
06-07 17:23:21.601+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20766)
06-07 17:23:21.651+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.681+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.721+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.751+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.781+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:21.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:21.821+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.851+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.881+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.911+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.941+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.971+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:21.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:21.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:22.001+0200 E/rpm-installer(20776): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-07 17:23:22.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:22.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:22.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:22.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:22.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:22.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:22.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:22.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:22.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:22.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:23.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:23.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:23.231+0200 E/PKGMGR_SERVER(20720): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:23:23.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:23.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:23.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:23:23.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:23:23.591+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20764
06-07 17:23:23.591+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20764)
06-07 17:23:23.771+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11203946c6f63152838490
