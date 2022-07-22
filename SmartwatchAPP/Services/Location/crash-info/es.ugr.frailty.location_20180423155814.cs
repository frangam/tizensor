S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20397
Date: 2018-04-23 15:58:14+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf769452d, r5   = 0xf79c7f98
r6   = 0xfff98688, r7   = 0xfff98538
r8   = 0xf79c4c18, r9   = 0x00000000
r10  = 0xfff98614, fp   = 0xfff98688
ip   = 0x00000001, sp   = 0xfff973b8
lr   = 0xf7694539, pc   = 0xf76fd2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      4396 KB
Buffers:     58360 KB
Cached:     236160 KB
VmPeak:      53648 KB
VmSize:      53644 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11652 KB
VmRSS:       11652 KB
VmData:      11372 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20397 TID = 20397
20397 20400 

Maps Information
f455f000 f4d5e000 rw-p [stack:20400]
f4d65000 f4d67000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d6f000 f4d73000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d7c000 f4d7e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d86000 f4d89000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d98000 f4d9d000 r-xp /usr/lib/libsystem.so.0.0.0
f4da8000 f4dab000 r-xp /lib/libattr.so.1.1.0
f4db3000 f4dc3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4dcb000 f4dd4000 r-xp /usr/lib/libedbus.so.1.7.99
f4ddc000 f4ddd000 r-xp /usr/lib/libresponse.so.0.2.96
f4de6000 f4deb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f668d000 f6793000 r-xp /usr/lib/libicuuc.so.57.1
f67a9000 f6931000 r-xp /usr/lib/libicui18n.so.57.1
f6941000 f694e000 r-xp /usr/lib/libail.so.0.1.0
f6957000 f695e000 r-xp /usr/lib/libminizip.so.1.0.0
f6967000 f6b10000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b30000 f6b77000 r-xp /usr/lib/libssl.so.1.0.0
f6b83000 f6b85000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b8d000 f6b94000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b9d000 f6ba4000 r-xp /lib/libcrypt-2.13.so
f6bd5000 f6bd8000 r-xp /lib/libcap.so.2.21
f6be0000 f6be2000 r-xp /usr/lib/libiri.so
f6bea000 f6c33000 r-xp /usr/lib/libmdm.so.1.2.69
f6c3b000 f6c41000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c49000 f6c6c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c76000 f6c78000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c80000 f6c9d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ca6000 f6caa000 r-xp /usr/lib/libsmack.so.1.0.0
f6cb3000 f6ccc000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cd5000 f6cdd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ce5000 f6ceb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cf4000 f6cf6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cff000 f6d0f000 r-xp /lib/libresolv-2.13.so
f6d13000 f6d2b000 r-xp /usr/lib/liblzma.so.5.0.3
f6d34000 f6d36000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d3e000 f6d58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d60000 f6d8f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d98000 f6da7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6db1000 f6dbb000 r-xp /usr/lib/libsensord-shared.so
f6dc4000 f6e97000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ea2000 f6eb8000 r-xp /lib/libz.so.1.2.5
f6ec0000 f6ec5000 r-xp /usr/lib/libffi.so.5.0.10
f6ecd000 f6ece000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ed6000 f6ee6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6eee000 f6f07000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f0f000 f6f11000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f19000 f6f8e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f98000 f6f9e000 r-xp /lib/librt-2.13.so
f6fa7000 f6fc5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fcf000 f6fd0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fd8000 f6ffb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7003000 f7008000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7010000 f703a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7043000 f705a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7062000 f70cb000 r-xp /lib/libm-2.13.so
f70d4000 f7168000 r-xp /usr/lib/libstdc++.so.6.0.16
f717b000 f7180000 r-xp /usr/lib/libctx-client.so.0.8.3
f7188000 f718f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7197000 f71c1000 r-xp /usr/lib/libsensor.so.1.9.6
f71ca000 f7296000 r-xp /usr/lib/libxml2.so.2.7.8
f72a3000 f72a5000 r-xp /usr/lib/libiniparser.so.0
f72ae000 f72b4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72bd000 f738d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f738e000 f73c2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73cb000 f7407000 r-xp /usr/lib/libSLP-location.so.0.9.24
f740f000 f7412000 r-xp /usr/lib/libbundle.so.0.1.22
f741a000 f7420000 r-xp /usr/lib/libappsvc.so.0.1.0
f7428000 f7469000 r-xp /usr/lib/libeina.so.1.7.99
f7472000 f7489000 r-xp /usr/lib/libecore.so.1.7.99
f74a0000 f74a9000 r-xp /usr/lib/libvconf.so.0.2.45
f74b1000 f74c5000 r-xp /lib/libpthread-2.13.so
f74d0000 f74dd000 r-xp /usr/lib/libaul.so.0.1.0
f74e7000 f74e9000 r-xp /lib/libdl-2.13.so
f74f2000 f74fd000 r-xp /lib/libunwind.so.8.0.1
f752a000 f7532000 r-xp /lib/libgcc_s-4.6.so.1
f7533000 f7657000 r-xp /lib/libc-2.13.so
f7665000 f7667000 r-xp /usr/lib/libdlog.so.0.0.0
f766f000 f767b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7684000 f7689000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7691000 f76a0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76a8000 f76ac000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76b5000 f76b8000 r-xp /usr/lib/libappcore-agent.so.1.1
f76c0000 f76c2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76ca000 f76ce000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76d6000 f76f3000 r-xp /lib/ld-2.13.so
f76fc000 f76ff000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76ff000 f7703000 r-xp /usr/lib/libsys-assert.so
f7994000 f7a36000 rw-p [heap]
fff79000 fff9a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20397)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf76fd2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7694539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf739b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7399c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73a5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73abbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73abdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73e075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73db1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7399c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73a5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73abbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73abdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73dde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73de017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73e28d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf76cc0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4d70171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e43663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72f0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72f27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7482ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf747db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf747e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf747e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76b6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76b67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76fd6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf754a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf76fcfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
+0200 I/accelerometer(20356): capturing data from es.ugr.frailty.accelerometer
04-23 15:58:16.121+0200 I/accelerometer(20356): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:58:16:130,9.609575,0.035892,1.966900
04-23 15:58:16.141+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:16.141+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:16.151+0200 W/LOCATION(20413): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:16.151+0200 I/LOCATION(20413): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:16.151+0200 I/LOCATION(20413): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:16.231+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 15:58:16.231+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:16.231+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:16.231+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:16.231+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 15:58:16.231+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:16.231+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:16.241+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:16.241+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:16.311+0200 I/gyroscope(20369): capturing data from es.ugr.frailty.gyroscope
04-23 15:58:16.321+0200 I/accelerometer(20356): capturing data from es.ugr.frailty.accelerometer
04-23 15:58:16.321+0200 I/accelerometer(20356): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:58:16:325,9.600004,-0.806381,2.368894
04-23 15:58:16.321+0200 I/gyroscope(20369): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:58:16:324,-6.020000,-8.960000,-10.570000
04-23 15:58:16.331+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:16.331+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:16.391+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:16.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:16.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:16.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:16.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e19ad0
04-23 15:58:16.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734a560]
04-23 15:58:16.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:16.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:16.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:16.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:16.511+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:16.511+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:16.521+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:16.531+0200 I/gyroscope(20369): capturing data from es.ugr.frailty.gyroscope
04-23 15:58:16.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:16.531+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:16.531+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:16.531+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:16.531+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:16.531+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:16.531+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:16.531+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:16.531+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:16.531+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:16.541+0200 I/accelerometer(20356): capturing data from es.ugr.frailty.accelerometer
04-23 15:58:16.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:16.541+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:16.541+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:16.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:16.551+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:16.551+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:16.561+0200 I/gyroscope(20369): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:58:16:535,-125.230003,-22.400000,-21.280001
04-23 15:58:16.561+0200 I/accelerometer(20356): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:58:16:545,9.954143,-0.162712,1.385444
04-23 15:58:16.591+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:16.601+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:16.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:16.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:16.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:16.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734a560
04-23 15:58:16.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf738c470]
04-23 15:58:16.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:16.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:16.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:16.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:16.721+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:16.721+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:16.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:16.741+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:16.741+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:16.751+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:16.751+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:16.751+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:16.751+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:16.751+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:16.751+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:16.751+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:16.751+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:16.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:16.761+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:16.761+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:16.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:16.761+0200 I/accelerometer(20356): capturing data from es.ugr.frailty.accelerometer
04-23 15:58:16.761+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:16.771+0200 I/gyroscope(20369): capturing data from es.ugr.frailty.gyroscope
04-23 15:58:16.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:16.771+0200 I/accelerometer(20356): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:58:16:774,10.226924,0.265603,0.825524
04-23 15:58:16.771+0200 I/gyroscope(20369): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:58:16:772,-114.029999,-7.140000,-26.250000
04-23 15:58:16.821+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:16.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:16.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:16.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:16.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf738c470
04-23 15:58:16.921+0200 I/gyroscope(20369): capturing data from es.ugr.frailty.gyroscope
04-23 15:58:16.921+0200 I/accelerometer(20356): capturing data from es.ugr.frailty.accelerometer
04-23 15:58:16.931+0200 I/accelerometer(20356): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:58:16:927,9.619147,1.634298,1.249053
04-23 15:58:16.931+0200 I/gyroscope(20369): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:58:16:926,-51.450001,42.279999,-18.690001
04-23 15:58:16.941+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:16.941+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:16.991+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:58:16.991+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:16.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:16.991+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:17.011+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20427
04-23 15:58:17.011+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:17.061+0200 E/CAPI_APPFW_APPLICATION(20427): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:17.061+0200 E/CAPI_APPFW_APPLICATION(20427): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:17.081+0200 W/LOCATION(20427): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:17.081+0200 E/LOCATION(20427): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:17.081+0200 E/PKGMGR_INFO(20427): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:17.081+0200 W/LOCATION(20427): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:17.101+0200 I/LOCATION(20427): location.c: location_new(269) > method: 0
04-23 15:58:17.101+0200 W/LOCATION(20427): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:17.101+0200 W/LOCATION(20427): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:17.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20427
04-23 15:58:17.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20427) type(svcapp) bg(0)
04-23 15:58:17.111+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20427) was created
04-23 15:58:17.111+0200 W/LOCATION(20427): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:17.111+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20427)
04-23 15:58:17.111+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:58:17.111+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:17.111+0200 W/LOCATION(20427): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:17.121+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20427]
04-23 15:58:17.121+0200 W/LOCATION(20427): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:17.131+0200 I/accelerometer(20356): capturing data from es.ugr.frailty.accelerometer
04-23 15:58:17.131+0200 W/LOCATION(20427): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:17.131+0200 I/accelerometer(20356): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:58:17:139,8.975478,0.787239,4.232903
04-23 15:58:17.131+0200 I/gyroscope(20369): capturing data from es.ugr.frailty.gyroscope
04-23 15:58:17.141+0200 W/LOCATION(20427): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:17.141+0200 W/LOCATION(20427): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:17.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:17.141+0200 W/LOCATION(20427): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:17.151+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20427
04-23 15:58:17.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:17.161+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20427
04-23 15:58:17.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:17.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:17.171+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:17.171+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:17.181+0200 I/gyroscope(20369): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:58:17:143,-14.140000,30.940001,-0.630000
04-23 15:58:17.181+0200 W/LOCATION(20427): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:17.191+0200 W/LOCATION(20427): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:17.191+0200 W/LOCATION(20427): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:17.201+0200 W/LOCATION(20427): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:17.201+0200 W/LOCATION(20427): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:17.201+0200 W/LOCATION(20427): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:17.201+0200 W/LOCATION(20427): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:17.241+0200 W/LOCATION(20427): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:17.241+0200 I/LOCATION(20427): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a07c18
04-23 15:58:17.241+0200 I/LOCATION(20427): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:17.241+0200 I/LOCATION(20427): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a07c18
04-23 15:58:17.241+0200 I/LOCATION(20427): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:17.251+0200 I/location(20427): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:17.331+0200 I/accelerometer(20356): capturing data from es.ugr.frailty.accelerometer
04-23 15:58:17.331+0200 I/accelerometer(20356): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:58:17:335,9.150154,1.356731,3.737589
04-23 15:58:17.331+0200 I/gyroscope(20369): capturing data from es.ugr.frailty.gyroscope
04-23 15:58:17.331+0200 I/gyroscope(20369): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:58:17:339,6.790000,2.520000,-2.030000
04-23 15:58:17.331+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:17.331+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:17.391+0200 I/LOCATION(20427): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:17.461+0200 W/LOCATION(20427): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:17.461+0200 W/LOCATION(20427): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:17.461+0200 I/LOCATION(20427): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:17.511+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer sleep timeout
04-23 15:58:17.511+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 15:58:17.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:17.521+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:17.521+0200 I/gyroscope(20369): capturing data from es.ugr.frailty.gyroscope
04-23 15:58:17.521+0200 I/gyroscope(20369): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:58:17:528,0.420000,0.980000,1.750000
04-23 15:58:17.521+0200 I/accelerometer(20356): capturing data from es.ugr.frailty.accelerometer
04-23 15:58:17.521+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20356
04-23 15:58:17.531+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20356)
04-23 15:58:17.531+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer stop request sent!
04-23 15:58:17.531+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:17.531+0200 I/accelerometer(20356): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:58:17:531,9.123833,1.636691,3.460021
04-23 15:58:17.531+0200 I/accelerometer(20356): stopping es.ugr.frailty.accelerometer service
04-23 15:58:17.531+0200 W/AUL     (20356): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:17.531+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:17.531+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20356), cmd(0)
04-23 15:58:17.531+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:17.531+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20356
04-23 15:58:17.541+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:17.541+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:17.541+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:17.541+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:17.541+0200 I/utils   (19708): specific action
04-23 15:58:17.541+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:17.541+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:17.541+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:17.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:17.541+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:17.551+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:17.561+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:17.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:17.561+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:17.561+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:17.561+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:17.561+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:17.561+0200 I/utils   (19713): specific action
04-23 15:58:17.561+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:17.561+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 15:58:17.561+0200 I/recorder(19713): guardando datos en local
04-23 15:58:17.561+0200 W/AUL     (20356): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:17.561+0200 I/accelerometer(20356): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:17.561+0200 I/CAPI_APPFW_APPLICATION(20356): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:17.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:17.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:17.621+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope sleep timeout
04-23 15:58:17.621+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:58:17.621+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 15:58:17.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:17.631+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:17.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:17.631+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:17.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:17.631+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:17.631+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:17.631+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:17.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:17.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:17.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:17.641+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:17.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:17.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:17.641+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:58:17.641+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20369
04-23 15:58:17.651+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20369)
04-23 15:58:17.651+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:17.651+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20369), cmd(0)
04-23 15:58:17.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:17.651+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:17.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:17.651+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:17.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:17.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:17.661+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope stop request sent!
04-23 15:58:17.651+0200 I/gyroscope(20369): stopping es.ugr.frailty.gyroscope service
04-23 15:58:17.661+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:17.661+0200 W/AUL     (20369): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:17.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:17.661+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20369
04-23 15:58:17.671+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:17.671+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:17.671+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:17.671+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:17.671+0200 W/AUL     (20369): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:17.671+0200 I/gyroscope(20369): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:17.671+0200 I/CAPI_APPFW_APPLICATION(20369): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:17.671+0200 I/utils   (19708): specific action
04-23 15:58:17.671+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:17.671+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:17.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:17.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:17.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:17.681+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:17.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:17.691+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:17.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:17.691+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:17.691+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:17.691+0200 I/utils   (19713): specific action
04-23 15:58:17.691+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:17.691+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:17.691+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:17.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:17.691+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 15:58:17.691+0200 I/recorder(19713): guardando datos en local
04-23 15:58:17.691+0200 I/accelerometer(20356): es.ugr.frailty.accelerometer listener destroyed
04-23 15:58:17.741+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:58:17.741+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:17.741+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:17.761+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:58:17.781+0200 W/LOCATION(20427): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:17.781+0200 W/LOCATION(20427): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:17.791+0200 I/gyroscope(20369): es.ugr.frailty.gyroscope listener destroyed
04-23 15:58:17.831+0200 W/AUL     (20433): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 15:58:17.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:17.831+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:17.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20356
04-23 15:58:17.831+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:17.831+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20356
04-23 15:58:17.831+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20356)
04-23 15:58:17.891+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:17.891+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5793557), time2(5789275)
04-23 15:58:17.891+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:17.891+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:17.891+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:17.891+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:17.901+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:17.941+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:17.941+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:17.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e14118]
04-23 15:58:17.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:17.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:17.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:17.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:17.971+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:17.971+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:17.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:17.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:17.991+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:17.991+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:17.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:17.991+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:17.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:17.991+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:17.991+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:17.991+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:17.991+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:18.001+0200 W/AUL     (20434): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 15:58:18.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:18.001+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:18.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20369
04-23 15:58:18.001+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:18.001+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20369
04-23 15:58:18.001+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20369)
04-23 15:58:18.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.021+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:18.021+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.061+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.101+0200 W/LOCATION(20427): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:18.101+0200 I/LOCATION(20427): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:18.101+0200 I/LOCATION(20427): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:18.101+0200 I/location(20427): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:18.111+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:18.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:18.151+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:18.231+0200 I/LOCATION(20427): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:18.311+0200 W/AUL     (20427): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:18.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:18.321+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20427
04-23 15:58:18.321+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:18.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.331+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:18.331+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:18.331+0200 W/AUL     (20427): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:18.331+0200 I/location(20427): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:18.331+0200 W/CAPI_APPFW_APP_CONTROL(20427): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.331+0200 I/utils   (20427): specific action
04-23 15:58:18.331+0200 I/utils   (19708): specific action
04-23 15:58:18.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.331+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:18.341+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:18.341+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:18.351+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:18.351+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:18.351+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:18.351+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:18.351+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:18.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:18.351+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:18.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:18.391+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 I/utils   (19713): specific action
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:18.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:18.401+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:18.401+0200 I/recorder(19713): guardando datos en local
04-23 15:58:18.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.421+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:18.421+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:18.421+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:18.441+0200 I/LOCATION(20427): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:18.541+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:18.541+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:18.581+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:18.581+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:18.581+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:18.591+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.591+0200 W/AUL     (20442): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20413
04-23 15:58:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:18.601+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20413
04-23 15:58:18.601+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20413)
04-23 15:58:18.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:18.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:18.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:18.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e14118
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7375eb8]
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:18.701+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:18.701+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:18.711+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.711+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.711+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:18.711+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:18.711+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:18.711+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:18.711+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:18.711+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:18.711+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:18.711+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:18.711+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:18.721+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.731+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:18.731+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.741+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:18.741+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:18.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:18.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:18.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:18.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7375eb8
04-23 15:58:18.841+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11203976c6f63152449189
