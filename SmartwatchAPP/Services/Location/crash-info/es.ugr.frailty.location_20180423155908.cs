S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21079
Date: 2018-04-23 15:59:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72c252d, r5   = 0xf75c6f98
r6   = 0xff990378, r7   = 0xff990228
r8   = 0xf75c3c18, r9   = 0x00000000
r10  = 0xff990304, fp   = 0xff990378
ip   = 0x00000001, sp   = 0xff98f0a8
lr   = 0xf72c2539, pc   = 0xf732b2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8980 KB
Buffers:     59044 KB
Cached:     234976 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11768 KB
VmRSS:       11768 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21079 TID = 21079
21079 21082 

Maps Information
f418d000 f498c000 rw-p [stack:21082]
f4993000 f4995000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f499d000 f49a1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49aa000 f49ac000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49b4000 f49b7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49c6000 f49cb000 r-xp /usr/lib/libsystem.so.0.0.0
f49d6000 f49d9000 r-xp /lib/libattr.so.1.1.0
f49e1000 f49f1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49f9000 f4a02000 r-xp /usr/lib/libedbus.so.1.7.99
f4a0a000 f4a0b000 r-xp /usr/lib/libresponse.so.0.2.96
f4a14000 f4a19000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62bb000 f63c1000 r-xp /usr/lib/libicuuc.so.57.1
f63d7000 f655f000 r-xp /usr/lib/libicui18n.so.57.1
f656f000 f657c000 r-xp /usr/lib/libail.so.0.1.0
f6585000 f658c000 r-xp /usr/lib/libminizip.so.1.0.0
f6595000 f673e000 r-xp /usr/lib/libcrypto.so.1.0.0
f675e000 f67a5000 r-xp /usr/lib/libssl.so.1.0.0
f67b1000 f67b3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67bb000 f67c2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67cb000 f67d2000 r-xp /lib/libcrypt-2.13.so
f6803000 f6806000 r-xp /lib/libcap.so.2.21
f680e000 f6810000 r-xp /usr/lib/libiri.so
f6818000 f6861000 r-xp /usr/lib/libmdm.so.1.2.69
f6869000 f686f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6877000 f689a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68a4000 f68a6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68ae000 f68cb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68d4000 f68d8000 r-xp /usr/lib/libsmack.so.1.0.0
f68e1000 f68fa000 r-xp /usr/lib/libnetwork.so.0.0.0
f6903000 f690b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6913000 f6919000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6922000 f6924000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f692d000 f693d000 r-xp /lib/libresolv-2.13.so
f6941000 f6959000 r-xp /usr/lib/liblzma.so.5.0.3
f6962000 f6964000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f696c000 f6986000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f698e000 f69bd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69c6000 f69d5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69df000 f69e9000 r-xp /usr/lib/libsensord-shared.so
f69f2000 f6ac5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ad0000 f6ae6000 r-xp /lib/libz.so.1.2.5
f6aee000 f6af3000 r-xp /usr/lib/libffi.so.5.0.10
f6afb000 f6afc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b04000 f6b14000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b1c000 f6b35000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b3d000 f6b3f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b47000 f6bbc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bc6000 f6bcc000 r-xp /lib/librt-2.13.so
f6bd5000 f6bf3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bfd000 f6bfe000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c06000 f6c29000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c31000 f6c36000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c3e000 f6c68000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c71000 f6c88000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c90000 f6cf9000 r-xp /lib/libm-2.13.so
f6d02000 f6d96000 r-xp /usr/lib/libstdc++.so.6.0.16
f6da9000 f6dae000 r-xp /usr/lib/libctx-client.so.0.8.3
f6db6000 f6dbd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dc5000 f6def000 r-xp /usr/lib/libsensor.so.1.9.6
f6df8000 f6ec4000 r-xp /usr/lib/libxml2.so.2.7.8
f6ed1000 f6ed3000 r-xp /usr/lib/libiniparser.so.0
f6edc000 f6ee2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6eeb000 f6fbb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fbc000 f6ff0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ff9000 f7035000 r-xp /usr/lib/libSLP-location.so.0.9.24
f703d000 f7040000 r-xp /usr/lib/libbundle.so.0.1.22
f7048000 f704e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7056000 f7097000 r-xp /usr/lib/libeina.so.1.7.99
f70a0000 f70b7000 r-xp /usr/lib/libecore.so.1.7.99
f70ce000 f70d7000 r-xp /usr/lib/libvconf.so.0.2.45
f70df000 f70f3000 r-xp /lib/libpthread-2.13.so
f70fe000 f710b000 r-xp /usr/lib/libaul.so.0.1.0
f7115000 f7117000 r-xp /lib/libdl-2.13.so
f7120000 f712b000 r-xp /lib/libunwind.so.8.0.1
f7158000 f7160000 r-xp /lib/libgcc_s-4.6.so.1
f7161000 f7285000 r-xp /lib/libc-2.13.so
f7293000 f7295000 r-xp /usr/lib/libdlog.so.0.0.0
f729d000 f72a9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72b2000 f72b7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72bf000 f72ce000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72d6000 f72da000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72e3000 f72e6000 r-xp /usr/lib/libappcore-agent.so.1.1
f72ee000 f72f0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72f8000 f72fc000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7304000 f7321000 r-xp /lib/ld-2.13.so
f732a000 f732d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f732d000 f7331000 r-xp /usr/lib/libsys-assert.so
f7593000 f7604000 rw-p [heap]
ff971000 ff992000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21079)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf732b2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf72c2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fc93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fc7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fd3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fd9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fd9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf700e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70091f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fc7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fd3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fd9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fd9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf700be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf700c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70108d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf72fa0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf499e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a71663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f1efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f207a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70b0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70abb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70ac5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70ac879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72e4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72e47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf732b6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf717885c) [/lib/libc.so.6] + 0x1785c
29: (0xf732afa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
nch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:59:10.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:10.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:10.211+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.241+0200 I/heartrate(21133): es.ugr.frailty.heartrate listener destroyed
04-23 15:59:10.241+0200 I/utils   (21126): es.ugr.frailty.gyroscope listener started
04-23 15:59:10.241+0200 I/gyroscope(21126): stopping es.ugr.frailty.gyroscope service
04-23 15:59:10.241+0200 E/CAPI_APPFW_APP_CONTROL(21126): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:59:10.241+0200 E/gyroscope(21126): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:59:10.241+0200 I/CAPI_APPFW_APPLICATION(21126): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:59:10.291+0200 E/CAPI_APPFW_APPLICATION(21122): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:10.291+0200 E/CAPI_APPFW_APPLICATION(21122): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:10.291+0200 I/utils   (21122): trying to start service: es.ugr.frailty.accelerometer
04-23 15:59:10.331+0200 I/utils   (21122): es.ugr.frailty.accelerometer sensor supported
04-23 15:59:10.361+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.371+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:10.411+0200 I/gyroscope(21126): es.ugr.frailty.gyroscope listener destroyed
04-23 15:59:10.411+0200 E/AUL     ( 2476): app_sock.c: __app_recv_raw(518) > recv error: 4
04-23 15:59:10.421+0200 W/AUL     (21173): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 15:59:10.421+0200 I/utils   (21122): es.ugr.frailty.accelerometer listener started
04-23 15:59:10.421+0200 I/accelerometer(21122): stopping es.ugr.frailty.accelerometer service
04-23 15:59:10.421+0200 E/CAPI_APPFW_APP_CONTROL(21122): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:59:10.421+0200 E/accelerometer(21122): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:59:10.421+0200 I/CAPI_APPFW_APPLICATION(21122): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:59:10.451+0200 W/LOCATION(21145): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:59:10.471+0200 W/LOCATION(21145): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:59:10.491+0200 W/LOCATION(21145): module-internal.c: module_new(311) > module (wps) open success
04-23 15:59:10.511+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.531+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.541+0200 W/LOCATION(21145): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:59:10.541+0200 W/LOCATION(21145): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:59:10.541+0200 W/LOCATION(21145): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:59:10.541+0200 W/LOCATION(21145): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:59:10.541+0200 I/accelerometer(21122): es.ugr.frailty.accelerometer listener destroyed
04-23 15:59:10.551+0200 E/AUL     ( 2476): app_sock.c: __app_recv_raw(518) > recv error: 4
04-23 15:59:10.561+0200 W/AUL     (21175): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 15:59:10.581+0200 W/LOCATION(21145): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:59:10.581+0200 I/LOCATION(21145): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf746ac18
04-23 15:59:10.581+0200 I/LOCATION(21145): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:59:10.581+0200 I/LOCATION(21145): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf746ac18
04-23 15:59:10.581+0200 I/LOCATION(21145): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:59:10.591+0200 I/location(21145): es.ugr.frailty.location: creado servicio de localización
04-23 15:59:10.601+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.601+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:10.631+0200 E/AUL     ( 2476): app_sock.c: __app_recv_raw(524) > recv error 0 0
04-23 15:59:10.631+0200 E/AUL_AMD ( 2476): amd_request.c: __request_handler(665) > recv error
04-23 15:59:10.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:59:10.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:59:10.641+0200 W/AUL     (21178): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 15:59:10.651+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 15:59:10.651+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:59:10.651+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:59:10.651+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21122) was created
04-23 15:59:10.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21145
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21133
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21126
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 18814
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:10.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:10.681+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21133
04-23 15:59:10.681+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21133)
04-23 15:59:10.681+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21126
04-23 15:59:10.681+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21126)
04-23 15:59:10.681+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18814
04-23 15:59:10.681+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(18814)
04-23 15:59:10.701+0200 W/AUL     (21179): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 15:59:10.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:10.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:10.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21122
04-23 15:59:10.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:10.711+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21122
04-23 15:59:10.711+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21122)
04-23 15:59:10.741+0200 I/LOCATION(21145): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:59:10.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:10.821+0200 W/LOCATION(21145): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:10.821+0200 W/LOCATION(21145): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:10.821+0200 I/LOCATION(21145): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:59:10.911+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:59:10.911+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:59:10.911+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:59:10.911+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:59:10.911+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:59:10.921+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:59:10.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:59:10.921+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:59:10.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:59:10.921+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:59:10.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:59:10.921+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:59:10.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.011+0200 W/LOCATION(21145): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:59:11.011+0200 W/LOCATION(21145): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:59:11.111+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7332cc8]
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:59:11.161+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:59:11.161+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5846823), time2(5841739)
04-23 15:59:11.161+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:59:11.161+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:59:11.161+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:59:11.161+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:59:11.171+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:11.171+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:11.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.191+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:59:11.191+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:59:11.191+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:11.191+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:11.191+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:11.191+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:11.191+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:11.191+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:11.191+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:11.201+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.211+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.211+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:59:11.221+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:11.261+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:11.301+0200 W/LOCATION(21145): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:59:11.311+0200 I/LOCATION(21145): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:59:11.311+0200 I/LOCATION(21145): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:59:11.321+0200 I/location(21145): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:59:11.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:59:11.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:59:11.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:59:11.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:59:11.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:59:11.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:59:11.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:59:11.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:59:11.531+0200 I/LOCATION(21145): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:59:11.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.601+0200 W/AUL     (21145): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:59:11.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:59:11.611+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21145
04-23 15:59:11.611+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:59:11.621+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.621+0200 I/utils   (19708): specific action
04-23 15:59:11.621+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.621+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.621+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.621+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:59:11.621+0200 W/AUL     (21145): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:59:11.621+0200 I/location(21145): request sent to service es.ugr.frailty.servicemanager
04-23 15:59:11.621+0200 I/location(21145): stopping es.ugr.frailty.location service
04-23 15:59:11.621+0200 E/CAPI_APPFW_APP_CONTROL(21145): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:59:11.621+0200 E/location(21145): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:59:11.621+0200 I/CAPI_APPFW_APPLICATION(21145): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:59:11.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:59:11.631+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:59:11.641+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21185
04-23 15:59:11.641+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:59:11.681+0200 E/CAPI_APPFW_APPLICATION(21185): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:11.681+0200 E/CAPI_APPFW_APPLICATION(21185): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.681+0200 I/utils   (21185): specific action
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21185
04-23 15:59:11.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21185) type(svcapp) bg(0)
04-23 15:59:11.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21185) was created
04-23 15:59:11.701+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:59:11.701+0200 I/recorder(21185): guardando datos en local
04-23 15:59:11.701+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21185]
04-23 15:59:11.711+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 15:59:11.711+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:59:11.711+0200 I/servicemanager(19708): requesting to save local data
04-23 15:59:11.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:11.731+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21185
04-23 15:59:11.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:11.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:11.741+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21185
04-23 15:59:11.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:11.791+0200 W/LOCATION(21145): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:59:11.791+0200 I/LOCATION(21145): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:59:11.791+0200 I/LOCATION(21145): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:59:11.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:59:11.881+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:59:11.881+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:59:11.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:59:11.931+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:59:11.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:59:12.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:59:12.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:59:12.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7332cc8
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7346040]
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:59:12.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:12.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:12.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.161+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:59:12.161+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:59:12.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:12.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:12.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:12.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:12.161+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:12.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:12.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:12.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.171+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:59:12.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.231+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:59:12.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:59:12.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:59:12.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7346040
04-23 15:59:12.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73b2f08]
04-23 15:59:12.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:59:12.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:59:12.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:59:12.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:59:12.401+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:12.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:12.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.431+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:59:12.431+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:59:12.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:12.431+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:12.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:12.431+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:12.431+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:12.431+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:12.431+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:12.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.451+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:59:12.451+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.501+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:59:12.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:59:12.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:59:12.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73b2f08
04-23 15:59:12.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.631+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:59:12.661+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:59:12.691+0200 W/AUL     (21192): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:59:12.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:12.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:12.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21079
04-23 15:59:12.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:12.701+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21079
04-23 15:59:12.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21079)
04-23 15:59:12.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:13.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:13.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:13.371+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11209256c6f631524491936
04-23 15:59:13.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:13.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:13.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:13.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:13.671+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [5849.335355] layer(0x5ac2c0) now usable
04-23 15:59:13.671+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [5849.335385] layer[0x5abe10]zpos[1]
04-23 15:59:13.671+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [5849.335408] layer(0x5ac310) now usable
04-23 15:59:13.671+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [5849.335419] layer[0x5abf30]zpos[2]
04-23 15:59:13.671+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [5849.335444] layer(0x5ac250) now usable
04-23 15:59:13.671+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [5849.335454] layer[0x5abcf0]zpos[0]
04-23 15:59:13.671+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [5849.335541] dpms[0 -> 3]sync[1]
04-23 15:59:13.671+0200 I/TDM     ( 1785): 
04-23 15:59:13.671+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 15:59:13.681+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 15:59:13.681+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 15:59:13.681+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 15:59:13.681+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 15:59:13.681+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 15:59:13.681+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 15:59:13.681+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 15:59:13.681+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 15:59:13.681+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 15:59:13.681+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 15:59:13.681+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 15:59:13.681+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 15:59:13.681+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 15:59:13.681+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 15:59:13.691+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 15:59:13.691+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 15:59:13.691+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 15:59:13.691+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 15:59:13.691+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 15:59:13.691+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 15:59:13.691+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 15:59:13.691+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 15:59:13.691+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 15:59:13.701+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:59:13.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:13.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:13.821+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [5849.480911] dpms[3 -> 3]done
04-23 15:59:13.821+0200 I/TDM     ( 1785): 
04-23 15:59:13.821+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 15:59:13.821+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 15:59:13.821+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 15:59:13.821+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 15:59:13.821+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 15:59:13.831+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 15:59:13.831+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 15:59:13.831+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 15:59:13.831+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 15:59:13.831+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 15:59:13.831+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 15:59:13.831+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 15:59:13.841+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 15:59:13.841+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 15:59:13.841+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 15:59:13.841+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 15:59:13.841+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 15:59:13.841+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 15:59:13.841+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 15:59:13.841+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 15:59:13.841+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:13.851+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 15:59:13.851+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 15:59:13.851+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 15:59:13.851+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 15:59:13.851+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 15:59:13.851+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 15:59:13.851+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 15:59:14.341+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 15:59:18.431+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11210436c6f631524491944
04-23 15:59:18.881+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 15:59:20.591+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11210796c6f63152449194
