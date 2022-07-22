S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19844
Date: 2018-04-23 15:57:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf723652d, r5   = 0xf73e5f98
r6   = 0xffee4538, r7   = 0xffee43e8
r8   = 0xf73e2c18, r9   = 0x00000000
r10  = 0xffee44c4, fp   = 0xffee4538
ip   = 0x00000001, sp   = 0xffee3268
lr   = 0xf7236539, pc   = 0xf729f2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      4868 KB
Buffers:     57816 KB
Cached:     241280 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11680 KB
VmRSS:       11680 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19844 TID = 19844
19844 19849 

Maps Information
f4101000 f4900000 rw-p [stack:19849]
f4907000 f4909000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4911000 f4915000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f491e000 f4920000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4928000 f492b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f493a000 f493f000 r-xp /usr/lib/libsystem.so.0.0.0
f494a000 f494d000 r-xp /lib/libattr.so.1.1.0
f4955000 f4965000 r-xp /usr/lib/libmdm-common.so.1.1.24
f496d000 f4976000 r-xp /usr/lib/libedbus.so.1.7.99
f497e000 f497f000 r-xp /usr/lib/libresponse.so.0.2.96
f4988000 f498d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f622f000 f6335000 r-xp /usr/lib/libicuuc.so.57.1
f634b000 f64d3000 r-xp /usr/lib/libicui18n.so.57.1
f64e3000 f64f0000 r-xp /usr/lib/libail.so.0.1.0
f64f9000 f6500000 r-xp /usr/lib/libminizip.so.1.0.0
f6509000 f66b2000 r-xp /usr/lib/libcrypto.so.1.0.0
f66d2000 f6719000 r-xp /usr/lib/libssl.so.1.0.0
f6725000 f6727000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f672f000 f6736000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f673f000 f6746000 r-xp /lib/libcrypt-2.13.so
f6777000 f677a000 r-xp /lib/libcap.so.2.21
f6782000 f6784000 r-xp /usr/lib/libiri.so
f678c000 f67d5000 r-xp /usr/lib/libmdm.so.1.2.69
f67dd000 f67e3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67eb000 f680e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6818000 f681a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6822000 f683f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6848000 f684c000 r-xp /usr/lib/libsmack.so.1.0.0
f6855000 f686e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6877000 f687f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6887000 f688d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6896000 f6898000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68a1000 f68b1000 r-xp /lib/libresolv-2.13.so
f68b5000 f68cd000 r-xp /usr/lib/liblzma.so.5.0.3
f68d6000 f68d8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68e0000 f68fa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6902000 f6931000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f693a000 f6949000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6953000 f695d000 r-xp /usr/lib/libsensord-shared.so
f6966000 f6a39000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a44000 f6a5a000 r-xp /lib/libz.so.1.2.5
f6a62000 f6a67000 r-xp /usr/lib/libffi.so.5.0.10
f6a6f000 f6a70000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a78000 f6a88000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a90000 f6aa9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ab1000 f6ab3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6abb000 f6b30000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b3a000 f6b40000 r-xp /lib/librt-2.13.so
f6b49000 f6b67000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b71000 f6b72000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b7a000 f6b9d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ba5000 f6baa000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bb2000 f6bdc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6be5000 f6bfc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c04000 f6c6d000 r-xp /lib/libm-2.13.so
f6c76000 f6d0a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d1d000 f6d22000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d2a000 f6d31000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d39000 f6d63000 r-xp /usr/lib/libsensor.so.1.9.6
f6d6c000 f6e38000 r-xp /usr/lib/libxml2.so.2.7.8
f6e45000 f6e47000 r-xp /usr/lib/libiniparser.so.0
f6e50000 f6e56000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e5f000 f6f2f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f30000 f6f64000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f6d000 f6fa9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fb1000 f6fb4000 r-xp /usr/lib/libbundle.so.0.1.22
f6fbc000 f6fc2000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fca000 f700b000 r-xp /usr/lib/libeina.so.1.7.99
f7014000 f702b000 r-xp /usr/lib/libecore.so.1.7.99
f7042000 f704b000 r-xp /usr/lib/libvconf.so.0.2.45
f7053000 f7067000 r-xp /lib/libpthread-2.13.so
f7072000 f707f000 r-xp /usr/lib/libaul.so.0.1.0
f7089000 f708b000 r-xp /lib/libdl-2.13.so
f7094000 f709f000 r-xp /lib/libunwind.so.8.0.1
f70cc000 f70d4000 r-xp /lib/libgcc_s-4.6.so.1
f70d5000 f71f9000 r-xp /lib/libc-2.13.so
f7207000 f7209000 r-xp /usr/lib/libdlog.so.0.0.0
f7211000 f721d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7226000 f722b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7233000 f7242000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f724a000 f724e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7257000 f725a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7262000 f7264000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f726c000 f7270000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7278000 f7295000 r-xp /lib/ld-2.13.so
f729e000 f72a1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72a1000 f72a5000 r-xp /usr/lib/libsys-assert.so
f73b2000 f7423000 rw-p [heap]
ffec5000 ffee6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19844)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf729f2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7236539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f3d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f3bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f47e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f4dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f4ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f8275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f7d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f3bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f47e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f4dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f4ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f7fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f80017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f848d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf726e0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4912171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69e5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e92fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e947a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7024ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf701fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70205a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7020879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7258183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72587fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf729f6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf70ec85c) [/lib/libc.so.6] + 0x1785c
29: (0xf729efa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
ly de-registered(0)
04-23 15:57:26.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:26.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:26.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7381820
04-23 15:57:26.191+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:26.191+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:26.371+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:57:26.371+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:57:26.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:26.381+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:26.391+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:26.391+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:26.401+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 19831
04-23 15:57:26.401+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:57:26.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19831
04-23 15:57:26.451+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(19831) type(svcapp) bg(0)
04-23 15:57:26.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19831)
04-23 15:57:26.461+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:57:26.461+0200 I/servicemanager(19708): App control destroyed.
04-23 15:57:26.461+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19831]
04-23 15:57:26.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:26.501+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19831
04-23 15:57:26.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:26.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:26.521+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19831
04-23 15:57:26.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:26.561+0200 E/CAPI_APPFW_APPLICATION(19831): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:26.561+0200 E/CAPI_APPFW_APPLICATION(19831): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:26.561+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (19831) was created
04-23 15:57:26.591+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:26.601+0200 W/LOCATION(19831): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:57:26.601+0200 E/LOCATION(19831): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:57:26.601+0200 E/PKGMGR_INFO(19831): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:57:26.601+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:26.601+0200 W/LOCATION(19831): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:26.631+0200 I/LOCATION(19831): location.c: location_new(269) > method: 0
04-23 15:57:26.631+0200 W/LOCATION(19831): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:26.631+0200 W/LOCATION(19831): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:26.641+0200 W/LOCATION(19831): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:26.651+0200 W/LOCATION(19831): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:26.651+0200 W/LOCATION(19831): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:26.661+0200 W/LOCATION(19831): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:26.661+0200 W/LOCATION(19831): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:26.661+0200 W/LOCATION(19831): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:26.661+0200 W/LOCATION(19831): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:26.691+0200 W/LOCATION(19831): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:26.691+0200 W/LOCATION(19831): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:26.691+0200 W/LOCATION(19831): module-internal.c: module_new(311) > module (wps) open success
04-23 15:57:26.701+0200 W/LOCATION(19831): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:57:26.701+0200 W/LOCATION(19831): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:57:26.701+0200 W/LOCATION(19831): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:26.701+0200 W/LOCATION(19831): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:26.721+0200 W/LOCATION(19831): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:57:26.721+0200 I/LOCATION(19831): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf792ec18
04-23 15:57:26.721+0200 I/LOCATION(19831): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:57:26.721+0200 I/LOCATION(19831): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf792ec18
04-23 15:57:26.721+0200 I/LOCATION(19831): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:57:26.721+0200 I/location(19831): es.ugr.frailty.location: creado servicio de localización
04-23 15:57:26.791+0200 I/LOCATION(19831): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:57:26.831+0200 W/LOCATION(19831): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:26.831+0200 W/LOCATION(19831): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:26.831+0200 I/LOCATION(19831): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:26.851+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:26.851+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:26.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:57:26.891+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:57:26.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:57:26.891+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:57:26.891+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:57:26.891+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:57:26.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:26.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:26.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:57:26.901+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:57:26.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:57:26.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:57:26.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:57:26.901+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:57:26.901+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:57:26.901+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:57:26.901+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:57:26.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:57:26.951+0200 W/LOCATION(19831): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:26.951+0200 W/LOCATION(19831): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:27.011+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:27.011+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:27.031+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 15:57:27.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734a1c8]
04-23 15:57:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:27.081+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:27.081+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:27.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.101+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:27.101+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:27.101+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:27.101+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:27.101+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:27.101+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:27.101+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:27.101+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:27.101+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:27.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.111+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:27.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:27.141+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:57:27.141+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5742801), time2(5740657)
04-23 15:57:27.141+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:57:27.141+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:57:27.141+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:57:27.141+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:57:27.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:27.191+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:27.191+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:27.191+0200 W/LOCATION(19831): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:27.191+0200 I/LOCATION(19831): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:27.191+0200 I/LOCATION(19831): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:27.191+0200 I/location(19831): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:57:27.271+0200 I/LOCATION(19831): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:27.361+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:57:27.361+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:57:27.361+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:27.361+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:57:27.361+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:57:27.371+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.381+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:57:27.381+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:57:27.381+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:27.391+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:27.391+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:27.401+0200 W/AUL     (19831): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:57:27.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:27.401+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19831
04-23 15:57:27.411+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:57:27.411+0200 W/AUL     (19831): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:57:27.411+0200 I/location(19831): request sent to service es.ugr.frailty.servicemanager
04-23 15:57:27.411+0200 I/location(19831): stopping es.ugr.frailty.location service
04-23 15:57:27.411+0200 E/CAPI_APPFW_APP_CONTROL(19831): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:57:27.411+0200 E/location(19831): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:57:27.411+0200 I/CAPI_APPFW_APPLICATION(19831): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:57:27.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:57:27.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:57:27.421+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:27.421+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:27.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:57:27.421+0200 I/utils   (19708): specific action
04-23 15:57:27.431+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:27.431+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:27.431+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:27.431+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:57:27.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:27.431+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:27.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:57:27.441+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:27.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:57:27.441+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:27.441+0200 I/utils   (19713): specific action
04-23 15:57:27.441+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:27.441+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:27.441+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:27.441+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:27.441+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:57:27.441+0200 I/recorder(19713): guardando datos en local
04-23 15:57:27.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:57:27.461+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:57:27.461+0200 I/servicemanager(19708): requesting to save local data
04-23 15:57:27.471+0200 W/LOCATION(19831): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:27.471+0200 I/LOCATION(19831): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:57:27.471+0200 I/LOCATION(19831): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:57:27.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:57:27.541+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:57:27.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:27.541+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:57:27.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:57:27.541+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:57:27.541+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:57:27.541+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:57:27.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:57:27.591+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:27.591+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:27.631+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:27.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:27.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:27.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:27.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734a1c8
04-23 15:57:27.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7372b20]
04-23 15:57:27.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:27.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:27.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:27.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:27.751+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:27.751+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:27.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.761+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:27.761+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:27.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:27.761+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:27.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:27.761+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:27.761+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:27.761+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:27.761+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:27.771+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.781+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:27.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:27.791+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:27.791+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:27.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:27.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:27.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:27.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:27.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:27.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7372b20
04-23 15:57:27.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e058b0]
04-23 15:57:27.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:27.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:27.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:27.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:27.951+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:27.951+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:27.951+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:27.991+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:27.991+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:27.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:27.991+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:27.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:27.991+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:27.991+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:27.991+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:27.991+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:28.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:28.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:28.001+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:28.011+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:28.041+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:28.041+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:28.051+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:28.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:28.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:28.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:28.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e058b0
04-23 15:57:28.191+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:28.191+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:28.271+0200 W/AUL     (19843): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:57:28.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:57:28.271+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:57:28.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 19831
04-23 15:57:28.271+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:57:28.271+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19831
04-23 15:57:28.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19831)
04-23 15:57:28.391+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:28.391+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:28.461+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:57:28.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:57:28.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:28.461+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:28.471+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 19844
04-23 15:57:28.471+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:57:28.521+0200 E/CAPI_APPFW_APPLICATION(19844): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:28.521+0200 E/CAPI_APPFW_APPLICATION(19844): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:28.521+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19844
04-23 15:57:28.521+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(19844) type(svcapp) bg(0)
04-23 15:57:28.521+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (19844) was created
04-23 15:57:28.531+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19844]
04-23 15:57:28.531+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19844)
04-23 15:57:28.531+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:57:28.531+0200 I/servicemanager(19708): App control destroyed.
04-23 15:57:28.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:28.551+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19844
04-23 15:57:28.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:28.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:28.581+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19844
04-23 15:57:28.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:28.591+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:28.591+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:28.601+0200 W/LOCATION(19844): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:57:28.601+0200 E/LOCATION(19844): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:57:28.601+0200 E/PKGMGR_INFO(19844): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:57:28.601+0200 W/LOCATION(19844): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:28.621+0200 I/LOCATION(19844): location.c: location_new(269) > method: 0
04-23 15:57:28.621+0200 W/LOCATION(19844): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:28.631+0200 W/LOCATION(19844): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:28.631+0200 W/LOCATION(19844): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:28.641+0200 W/LOCATION(19844): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:28.641+0200 W/LOCATION(19844): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:28.641+0200 W/LOCATION(19844): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:28.641+0200 W/LOCATION(19844): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:28.651+0200 W/LOCATION(19844): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:28.651+0200 W/LOCATION(19844): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:28.671+0200 W/LOCATION(19844): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:28.671+0200 W/LOCATION(19844): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:28.671+0200 W/LOCATION(19844): module-internal.c: module_new(311) > module (wps) open success
04-23 15:57:28.671+0200 W/LOCATION(19844): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:57:28.681+0200 W/LOCATION(19844): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:57:28.681+0200 W/LOCATION(19844): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:28.681+0200 W/LOCATION(19844): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:28.701+0200 W/LOCATION(19844): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:57:28.701+0200 I/LOCATION(19844): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf73e2c18
04-23 15:57:28.701+0200 I/LOCATION(19844): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:57:28.701+0200 I/LOCATION(19844): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf73e2c18
04-23 15:57:28.701+0200 I/LOCATION(19844): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:57:28.701+0200 I/location(19844): es.ugr.frailty.location: creado servicio de localización
04-23 15:57:28.751+0200 I/LOCATION(19844): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:57:28.791+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:28.791+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:28.791+0200 W/LOCATION(19844): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:28.791+0200 W/LOCATION(19844): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:28.791+0200 I/LOCATION(19844): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:28.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:57:28.861+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:57:28.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:57:28.861+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:57:28.861+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:57:28.861+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:57:28.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:28.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:28.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:57:28.871+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:57:28.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:57:28.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:57:28.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:57:28.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:57:28.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:57:28.871+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:57:28.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:57:28.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:57:28.971+0200 W/LOCATION(19844): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:28.971+0200 W/LOCATION(19844): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:28.991+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:28.991+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:29.121+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:57:29.121+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5744782), time2(5740657)
04-23 15:57:29.121+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:57:29.121+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:57:29.121+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:57:29.121+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:57:29.211+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:29.211+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:29.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:57:29.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:57:29.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:29.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:57:29.411+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:29.411+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:57:29.421+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:29.481+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:29.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e05a38]
04-23 15:57:29.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:29.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:29.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:29.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:29.571+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:29.571+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:29.591+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:29.591+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:29.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:29.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:29.621+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:29.621+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:29.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:29.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:29.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:29.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:29.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:29.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:29.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:29.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:29.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:29.651+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:29.651+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:29.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:29.711+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:29.711+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:29.711+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:57:29.711+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:57:29.711+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:29.771+0200 W/LOCATION(19844): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:29.771+0200 I/LOCATION(19844): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:29.771+0200 I/LOCATION(19844): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:29.771+0200 I/location(19844): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:57:29.791+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:29.791+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:29.961+0200 I/LOCATION(19844): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:29.991+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:29.991+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:30.071+0200 W/AUL     (19844): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:57:30.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:30.081+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19844
04-23 15:57:30.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:57:30.091+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.091+0200 I/utils   (19708): specific action
04-23 15:57:30.091+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.091+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.091+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.091+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:57:30.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:30.091+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:30.101+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:57:30.101+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:30.101+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:57:30.111+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:30.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19713), cmd(0)
04-23 15:57:30.111+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.111+0200 I/utils   (19713): specific action
04-23 15:57:30.111+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.111+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.111+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.111+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.111+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:57:30.111+0200 I/recorder(19713): guardando datos en local
04-23 15:57:30.111+0200 W/AUL     (19844): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:57:30.111+0200 I/location(19844): request sent to service es.ugr.frailty.servicemanager
04-23 15:57:30.111+0200 W/CAPI_APPFW_APP_CONTROL(19844): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:30.111+0200 I/utils   (19844): specific action
04-23 15:57:30.121+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:57:30.121+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:57:30.121+0200 I/servicemanager(19708): requesting to save local data
04-23 15:57:30.151+0200 I/LOCATION(19844): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:30.191+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:30.191+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:30.251+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11198446c6f63152449185
