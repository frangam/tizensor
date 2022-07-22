S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13005
Date: 2018-04-23 20:43:05+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71c652d, r5   = 0xf7645f98
r6   = 0xffcb82f0, r7   = 0xffcb81a0
r8   = 0xf7642c18, r9   = 0x00000000
r10  = 0xffcb827c, fp   = 0xffcb82f0
ip   = 0x00000001, sp   = 0xffcb8178
lr   = 0xf71c6539, pc   = 0xf722f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    113080 KB
Buffers:     41020 KB
Cached:     161632 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11668 KB
VmRSS:       11668 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13005 TID = 13005
13005 13008 

Maps Information
f4091000 f4890000 rw-p [stack:13008]
f4897000 f4899000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48a1000 f48a5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48ae000 f48b0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48b8000 f48bb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48ca000 f48cf000 r-xp /usr/lib/libsystem.so.0.0.0
f48da000 f48dd000 r-xp /lib/libattr.so.1.1.0
f48e5000 f48f5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48fd000 f4906000 r-xp /usr/lib/libedbus.so.1.7.99
f490e000 f490f000 r-xp /usr/lib/libresponse.so.0.2.96
f4918000 f491d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61bf000 f62c5000 r-xp /usr/lib/libicuuc.so.57.1
f62db000 f6463000 r-xp /usr/lib/libicui18n.so.57.1
f6473000 f6480000 r-xp /usr/lib/libail.so.0.1.0
f6489000 f6490000 r-xp /usr/lib/libminizip.so.1.0.0
f6499000 f6642000 r-xp /usr/lib/libcrypto.so.1.0.0
f6662000 f66a9000 r-xp /usr/lib/libssl.so.1.0.0
f66b5000 f66b7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66bf000 f66c6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66cf000 f66d6000 r-xp /lib/libcrypt-2.13.so
f6707000 f670a000 r-xp /lib/libcap.so.2.21
f6712000 f6714000 r-xp /usr/lib/libiri.so
f671c000 f6765000 r-xp /usr/lib/libmdm.so.1.2.69
f676d000 f6773000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f677b000 f679e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67a8000 f67aa000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67b2000 f67cf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67d8000 f67dc000 r-xp /usr/lib/libsmack.so.1.0.0
f67e5000 f67fe000 r-xp /usr/lib/libnetwork.so.0.0.0
f6807000 f680f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6817000 f681d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6826000 f6828000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6831000 f6841000 r-xp /lib/libresolv-2.13.so
f6845000 f685d000 r-xp /usr/lib/liblzma.so.5.0.3
f6866000 f6868000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6870000 f688a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6892000 f68c1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68ca000 f68d9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68e3000 f68ed000 r-xp /usr/lib/libsensord-shared.so
f68f6000 f69c9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69d4000 f69ea000 r-xp /lib/libz.so.1.2.5
f69f2000 f69f7000 r-xp /usr/lib/libffi.so.5.0.10
f69ff000 f6a00000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a08000 f6a18000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a20000 f6a39000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a41000 f6a43000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a4b000 f6ac0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6aca000 f6ad0000 r-xp /lib/librt-2.13.so
f6ad9000 f6af7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b01000 f6b02000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b0a000 f6b2d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b35000 f6b3a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b42000 f6b6c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b75000 f6b8c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b94000 f6bfd000 r-xp /lib/libm-2.13.so
f6c06000 f6c9a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cad000 f6cb2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cba000 f6cc1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cc9000 f6cf3000 r-xp /usr/lib/libsensor.so.1.9.6
f6cfc000 f6dc8000 r-xp /usr/lib/libxml2.so.2.7.8
f6dd5000 f6dd7000 r-xp /usr/lib/libiniparser.so.0
f6de0000 f6de6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6def000 f6ebf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ec0000 f6ef4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6efd000 f6f39000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f41000 f6f44000 r-xp /usr/lib/libbundle.so.0.1.22
f6f4c000 f6f52000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f5a000 f6f9b000 r-xp /usr/lib/libeina.so.1.7.99
f6fa4000 f6fbb000 r-xp /usr/lib/libecore.so.1.7.99
f6fd2000 f6fdb000 r-xp /usr/lib/libvconf.so.0.2.45
f6fe3000 f6ff7000 r-xp /lib/libpthread-2.13.so
f7002000 f700f000 r-xp /usr/lib/libaul.so.0.1.0
f7019000 f701b000 r-xp /lib/libdl-2.13.so
f7024000 f702f000 r-xp /lib/libunwind.so.8.0.1
f705c000 f7064000 r-xp /lib/libgcc_s-4.6.so.1
f7065000 f7189000 r-xp /lib/libc-2.13.so
f7197000 f7199000 r-xp /usr/lib/libdlog.so.0.0.0
f71a1000 f71ad000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71b6000 f71bb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71c3000 f71d2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71da000 f71de000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71e7000 f71ea000 r-xp /usr/lib/libappcore-agent.so.1.1
f71f2000 f71f4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71fc000 f7200000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7208000 f7225000 r-xp /lib/ld-2.13.so
f722e000 f7231000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7231000 f7235000 r-xp /usr/lib/libsys-assert.so
f7612000 f7680000 rw-p [heap]
ffc99000 ffcba000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13005)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf722f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71c6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ecd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ecbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ed7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6eddbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6edddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f1275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f0d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ecbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ed7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6eddbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6edddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f0fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f10017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f17f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48af1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48a2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6975663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e22fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e247a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fb4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fafb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fb05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fb0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71e8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71e87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf722f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf707c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf722ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
9+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:55.449+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:55.449+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:55.449+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:55.449+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:55.469+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:55.479+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:55.479+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:55.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:55.529+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:55.539+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:55.589+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:55.589+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:55.589+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:55.589+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf798f758
04-23 20:42:55.659+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf79587f8]
04-23 20:42:55.659+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:55.659+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:55.659+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:55.659+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:55.669+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:55.669+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:55.699+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:55.709+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:55.709+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:55.709+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:55.709+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:55.709+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:55.709+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:55.709+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:55.709+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:55.709+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:55.709+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:55.719+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:55.729+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:55.729+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:55.729+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:55.769+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:55.779+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:55.779+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:55.779+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:55.779+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf79587f8
04-23 20:42:55.799+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.799+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:804,0.042204,9.772130,0.821019
04-23 20:42:55.859+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.879+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:872,0.043441,9.772405,0.817679
04-23 20:42:55.879+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.889+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:890,0.042218,9.772292,0.819095
04-23 20:42:55.889+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.899+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:898,0.040557,9.772268,0.819456
04-23 20:42:55.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:914,0.039126,9.772105,0.821472
04-23 20:42:55.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.939+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:932,0.039007,9.772004,0.822682
04-23 20:42:55.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.939+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:945,0.039244,9.772030,0.822360
04-23 20:42:55.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.959+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:966,0.040481,9.772034,0.822254
04-23 20:42:55.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:971,0.039721,9.772161,0.820782
04-23 20:42:55.969+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:55.999+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:55:979,0.041156,9.772233,0.819848
04-23 20:42:55.999+0200 W/AUL     (12969): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:42:56.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:42:56.009+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:42:56.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12933
04-23 20:42:56.009+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:42:56.009+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12933
04-23 20:42:56.009+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12933)
04-23 20:42:56.009+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.019+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:23,0.040586,9.772259,0.819574
04-23 20:42:56.019+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.029+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:32,0.041538,9.772228,0.819889
04-23 20:42:56.029+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.029+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:37,0.040175,9.772132,0.821098
04-23 20:42:56.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.039+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:44,0.042192,9.772376,0.818095
04-23 20:42:56.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:53,0.040907,9.772321,0.818819
04-23 20:42:56.049+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:58,0.039241,9.772167,0.820728
04-23 20:42:56.049+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.059+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:62,0.038322,9.772142,0.821064
04-23 20:42:56.059+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.069+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:73,0.039489,9.772148,0.820945
04-23 20:42:56.069+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.069+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:78,0.040065,9.771907,0.823784
04-23 20:42:56.069+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.079+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:83,0.037192,9.771661,0.826834
04-23 20:42:56.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:90,0.037057,9.771668,0.826744
04-23 20:42:56.089+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:98,0.036598,9.771580,0.827815
04-23 20:42:56.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.099+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:104,0.038160,9.772083,0.821778
04-23 20:42:56.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:118,0.038661,9.774619,0.791022
04-23 20:42:56.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.319+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:323,0.037459,9.774813,0.788676
04-23 20:42:56.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:523,0.027831,9.776087,0.773130
04-23 20:42:56.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:717,0.034201,9.776520,0.767380
04-23 20:42:56.849+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:42:56.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:56.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:56:923,0.042948,9.775075,0.785146
04-23 20:42:57.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:57.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:57:123,0.041634,9.773753,0.801495
04-23 20:42:57.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:57.319+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:57:323,0.038683,9.772366,0.818393
04-23 20:42:57.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:57.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:57:523,0.046047,9.773458,0.804844
04-23 20:42:57.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:57.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:57:717,0.046404,9.772087,0.821311
04-23 20:42:57.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:57.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:57:923,0.047162,9.771854,0.824025
04-23 20:42:58.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:58.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:58:117,0.047695,9.771807,0.824559
04-23 20:42:58.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:58.319+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:58:323,0.043160,9.771935,0.823287
04-23 20:42:58.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:58.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:58:519,0.041728,9.773333,0.806609
04-23 20:42:58.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:58.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:58:718,0.043911,9.772812,0.812777
04-23 20:42:58.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:58.939+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:58:921,0.043066,9.772954,0.811110
04-23 20:42:59.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:59.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:59:123,0.035363,9.773088,0.809878
04-23 20:42:59.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:59.319+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:59:319,0.029494,9.771915,0.824124
04-23 20:42:59.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:59.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:59:520,0.027157,9.771892,0.824494
04-23 20:42:59.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:59.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:59:720,0.021586,9.770458,0.841468
04-23 20:42:59.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:59.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:59:923,0.017100,9.768457,0.864488
04-23 20:43:00.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:00.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:00:121,0.020736,9.766794,0.883003
04-23 20:43:00.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:00.339+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:00:322,0.029564,9.769540,0.851822
04-23 20:43:00.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:00.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:00:523,0.035994,9.769193,0.855551
04-23 20:43:00.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:00.759+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:00:724,0.041953,9.769040,0.857017
04-23 20:43:00.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:00.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:00:933,0.026610,9.764915,0.903389
04-23 20:43:01.129+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:01.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:01:133,0.034157,9.767336,0.876562
04-23 20:43:01.329+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:01.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:01:333,0.030448,9.771876,0.824552
04-23 20:43:01.529+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:01.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:01:533,0.022482,9.772301,0.819762
04-23 20:43:01.729+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:01.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:01:733,0.024342,9.775003,0.786825
04-23 20:43:01.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:01.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:01:933,0.028024,9.776398,0.769186
04-23 20:43:02.129+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:02.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:02:133,0.032009,9.776996,0.761387
04-23 20:43:02.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:02.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:02:327,0.029902,9.776814,0.763809
04-23 20:43:02.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:02.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:02:527,0.023551,9.778172,0.746453
04-23 20:43:02.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:02.719+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:02:728,0.028167,9.777641,0.753204
04-23 20:43:02.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:02.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:02:929,0.020798,9.779000,0.735596
04-23 20:43:03.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:03.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:03:129,0.023996,9.778565,0.741261
04-23 20:43:03.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:03.319+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:03:328,0.032265,9.776676,0.765471
04-23 20:43:03.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:03.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:03:529,0.039669,9.773852,0.800387
04-23 20:43:03.579+0200 I/servicemanager(12059): es.ugr.frailty.location alive timeout
04-23 20:43:03.579+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:43:03.579+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:43:03.579+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:43:03.589+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 13005
04-23 20:43:03.589+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:43:03.639+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 13005
04-23 20:43:03.639+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(13005) type(svcapp) bg(0)
04-23 20:43:03.649+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [13005]
04-23 20:43:03.649+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13005)
04-23 20:43:03.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:43:03.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13005
04-23 20:43:03.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:43:03.689+0200 I/servicemanager(12059): es.ugr.frailty.location launch request sent!
04-23 20:43:03.689+0200 I/servicemanager(12059): App control destroyed.
04-23 20:43:03.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:43:03.699+0200 E/CAPI_APPFW_APPLICATION(13005): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:43:03.699+0200 E/CAPI_APPFW_APPLICATION(13005): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:43:03.709+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13005
04-23 20:43:03.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:43:03.709+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (13005) was created
04-23 20:43:03.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:03.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:03:730,0.053677,9.771643,0.826133
04-23 20:43:03.729+0200 W/LOCATION(13005): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:43:03.729+0200 E/LOCATION(13005): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:43:03.729+0200 E/PKGMGR_INFO(13005): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:43:03.739+0200 W/LOCATION(13005): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:03.749+0200 I/LOCATION(13005): location.c: location_new(269) > method: 0
04-23 20:43:03.749+0200 W/LOCATION(13005): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:03.759+0200 W/LOCATION(13005): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:03.759+0200 W/LOCATION(13005): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:03.769+0200 W/LOCATION(13005): module-internal.c: module_new(311) > module (gps) open success
04-23 20:43:03.769+0200 W/LOCATION(13005): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:43:03.769+0200 W/LOCATION(13005): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:43:03.769+0200 W/LOCATION(13005): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:03.769+0200 W/LOCATION(13005): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:03.769+0200 W/LOCATION(13005): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:03.799+0200 W/LOCATION(13005): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:43:03.799+0200 W/LOCATION(13005): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:43:03.799+0200 W/LOCATION(13005): module-internal.c: module_new(311) > module (wps) open success
04-23 20:43:03.809+0200 W/LOCATION(13005): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:43:03.809+0200 W/LOCATION(13005): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:43:03.809+0200 W/LOCATION(13005): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:43:03.809+0200 W/LOCATION(13005): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:43:03.829+0200 W/LOCATION(13005): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:43:03.829+0200 I/LOCATION(13005): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7642c18
04-23 20:43:03.829+0200 I/LOCATION(13005): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:43:03.829+0200 I/LOCATION(13005): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7642c18
04-23 20:43:03.829+0200 I/LOCATION(13005): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:43:03.829+0200 I/location(13005): es.ugr.frailty.location: creado servicio de localización
04-23 20:43:03.879+0200 I/LOCATION(13005): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:43:03.919+0200 W/LOCATION(13005): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:03.919+0200 W/LOCATION(13005): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:03.919+0200 I/LOCATION(13005): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:43:03.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:03.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:03:930,0.048706,9.771937,0.822958
04-23 20:43:03.979+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:43:03.979+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:43:03.979+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:43:03.979+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:43:03.979+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:43:03.979+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:43:03.979+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:03.979+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:03.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:43:03.989+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:43:03.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:43:03.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:43:03.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:43:03.989+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:43:03.989+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:43:03.989+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:43:03.989+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:43:03.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:43:04.049+0200 W/LOCATION(13005): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:43:04.049+0200 W/LOCATION(13005): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:43:04.119+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:04.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf79cddd8]
04-23 20:43:04.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:43:04.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:43:04.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:43:04.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:43:04.169+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:04.179+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:04.189+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:04.199+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:04.199+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:43:04.199+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:43:04.199+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:04.199+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:43:04.199+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:43:04.199+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:43:04.199+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:04.199+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:04.199+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:04.209+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:04.219+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:04.219+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:43:04.219+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:04.229+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:43:04.229+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3059493), time2(3046014)
04-23 20:43:04.229+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:43:04.229+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:43:04.229+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:43:04.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:43:04.269+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:04.299+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:131,0.042967,9.772554,0.815916
04-23 20:43:04.299+0200 W/LOCATION(13005): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:43:04.299+0200 I/LOCATION(13005): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:43:04.299+0200 I/LOCATION(13005): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:43:04.299+0200 I/location(13005): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:43:04.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:332,0.046466,9.773409,0.805419
04-23 20:43:04.389+0200 I/LOCATION(13005): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:43:04.439+0200 I/location(13005): es.ugr.frailty.location: waiting for rigth values
04-23 20:43:04.439+0200 W/CAPI_APPFW_APP_CONTROL(13005): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:43:04.439+0200 I/utils   (13005): specific action
04-23 20:43:04.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:531,0.041657,9.772873,0.812159
04-23 20:43:04.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:43:04.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:04.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:43:04.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:733,0.039928,9.772156,0.820830
04-23 20:43:04.749+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.749+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:753,0.040450,9.772058,0.821970
04-23 20:43:04.759+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.769+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:773,0.040606,9.771933,0.823452
04-23 20:43:04.779+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:792,0.040868,9.771902,0.823800
04-23 20:43:04.809+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.809+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:814,0.039843,9.771929,0.823528
04-23 20:43:04.819+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.829+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:833,0.038891,9.771826,0.824798
04-23 20:43:04.839+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.849+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:852,0.040254,9.771857,0.824359
04-23 20:43:04.869+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.869+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:874,0.039513,9.771755,0.825599
04-23 20:43:04.879+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.889+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:893,0.036892,9.771475,0.829041
04-23 20:43:04.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:914,0.035597,9.771493,0.828881
04-23 20:43:04.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:933,0.036871,9.771503,0.828698
04-23 20:43:04.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.949+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:952,0.037545,9.771660,0.826826
04-23 20:43:04.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:973,0.038294,9.771707,0.826241
04-23 20:43:04.989+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:04.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:04:993,0.038551,9.771935,0.823514
04-23 20:43:05.009+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.009+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:14,0.038563,9.772045,0.822212
04-23 20:43:05.019+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.029+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:32,0.038469,9.771983,0.822957
04-23 20:43:05.049+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:53,0.039055,9.771949,0.823327
04-23 20:43:05.059+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:73,0.036979,9.771788,0.825338
04-23 20:43:05.129+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:137,0.037762,9.772017,0.822576
04-23 20:43:05.139+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.149+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:146,0.037513,9.772346,0.818679
04-23 20:43:05.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:166,0.036940,9.772502,0.816842
04-23 20:43:05.169+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:176,0.035923,9.772753,0.813881
04-23 20:43:05.179+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.189+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:188,0.035980,9.772911,0.811972
04-23 20:43:05.199+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.199+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:205,0.035006,9.773235,0.808103
04-23 20:43:05.259+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:43:05.259+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.269+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:271,0.034425,9.773450,0.805525
04-23 20:43:05.269+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.269+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:278,0.034209,9.773748,0.801909
04-23 20:43:05.279+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.279+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:283,0.033452,9.774042,0.798352
04-23 20:43:05.279+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.289+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:290,0.034302,9.774039,0.798350
04-23 20:43:05.289+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.289+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:295,0.034983,9.774025,0.798502
04-23 20:43:05.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:316,0.036849,9.773987,0.798879
04-23 20:43:05.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:332,0.036030,9.773905,0.799922
04-23 20:43:05.349+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:355,0.036051,9.773791,0.801309
04-23 20:43:05.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.369+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:372,0.036187,9.773841,0.800688
04-23 20:43:05.379+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.389+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:392,0.035229,9.773868,0.800414
04-23 20:43:05.409+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.409+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:414,0.033282,9.773996,0.798918
04-23 20:43:05.419+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.429+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:432,0.032457,9.774081,0.797913
04-23 20:43:05.439+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.449+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:452,0.030625,9.774290,0.795420
04-23 20:43:05.469+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.469+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:474,0.029685,9.774485,0.793067
04-23 20:43:05.489+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.499+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:493,0.027093,9.774199,0.796667
04-23 20:43:05.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:514,0.026280,9.774083,0.798116
04-23 20:43:05.529+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:533,0.025068,9.773912,0.800243
04-23 20:43:05.539+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.549+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:552,0.026202,9.774078,0.798180
04-23 20:43:05.579+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.579+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:584,0.026020,9.773909,0.800265
04-23 20:43:05.639+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.649+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:650,0.028478,9.774091,0.797945
04-23 20:43:05.649+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.649+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:656,0.027619,9.773831,0.801151
04-23 20:43:05.649+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.659+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:661,0.028384,9.773796,0.801557
04-23 20:43:05.659+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.659+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:667,0.029440,9.773643,0.803376
04-23 20:43:05.659+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.669+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:673,0.029583,9.773832,0.801066
04-23 20:43:05.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:43:05.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:05.689+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:43:05.689+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.699+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:697,0.028539,9.773723,0.802445
04-23 20:43:05.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:713,0.029256,9.773469,0.805507
04-23 20:43:05.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:732,0.029823,9.773384,0.806514
04-23 20:43:05.739+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.749+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:752,0.028900,9.773137,0.809528
04-23 20:43:05.769+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.769+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:773,0.028812,9.772847,0.813029
04-23 20:43:05.779+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:792,0.030325,9.772949,0.811743
04-23 20:43:05.809+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.809+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:813,0.029757,9.772928,0.812020
04-23 20:43:05.819+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.829+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:833,0.031916,9.773170,0.809024
04-23 20:43:05.839+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.849+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:852,0.031601,9.773388,0.806393
04-23 20:43:05.859+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.869+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:872,0.032403,9.773270,0.807801
04-23 20:43:05.879+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.899+0200 W/LOCATION(13005): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:43:05.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:893,0.031680,9.773202,0.808649
04-23 20:43:05.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:926,0.031229,9.773028,0.810753
04-23 20:43:05.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:936,0.032043,9.772894,0.812347
04-23 20:43:05.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.949+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:953,0.029619,9.772669,0.815134
04-23 20:43:05.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:972,0.030279,9.772639,0.815467
04-23 20:43:05.979+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:05.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:05:992,0.032394,9.772734,0.814256
04-23 20:43:06.009+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:06.009+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:06:14,0.031441,9.772605,0.815837
04-23 20:43:06.019+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:06.029+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:06:32,0.031260,9.772780,0.813734
04-23 20:43:06.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:06.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:06:52,0.032231,9.773164,0.809086
04-23 20:43:06.069+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:06.069+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:06:73,0.032700,9.773414,0.806044
04-23 20:43:06.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:06.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:06:92,0.033117,9.773348,0.806822
04-23 20:43:06.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:06.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:06:119,0.032291,9.773595,0.803860
04-23 20:43:06.129+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:06.149+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:06:142,0.030955,9.773652,0.803214
04-23 20:43:06.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:06.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:06:169,0.030237,9.773838,0.800969
04-23 20:43:06.169+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:06.179+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:06:182,0.029443,9.773976,0.799311
04-23 20:43:06.179+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11130056c6f63152450898
