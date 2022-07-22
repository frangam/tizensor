S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7294
Date: 2018-04-23 20:09:53+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf777252d, r5   = 0xf7d93f98
r6   = 0xfffb2c60, r7   = 0xfffb2b10
r8   = 0xf7d90c18, r9   = 0x00000000
r10  = 0xfffb2bec, fp   = 0xfffb2c60
ip   = 0x00000001, sp   = 0xfffb2ae8
lr   = 0xf7772539, pc   = 0xf77db228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    107476 KB
Buffers:     40364 KB
Cached:     186740 KB
VmPeak:      52408 KB
VmSize:      52404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11768 KB
VmRSS:       11764 KB
VmData:      10132 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7294 TID = 7294
7294 7297 

Maps Information
f463d000 f4e3c000 rw-p [stack:7297]
f4e43000 f4e45000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e4d000 f4e51000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e5a000 f4e5c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e64000 f4e67000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e76000 f4e7b000 r-xp /usr/lib/libsystem.so.0.0.0
f4e86000 f4e89000 r-xp /lib/libattr.so.1.1.0
f4e91000 f4ea1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ea9000 f4eb2000 r-xp /usr/lib/libedbus.so.1.7.99
f4eba000 f4ebb000 r-xp /usr/lib/libresponse.so.0.2.96
f4ec4000 f4ec9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f676b000 f6871000 r-xp /usr/lib/libicuuc.so.57.1
f6887000 f6a0f000 r-xp /usr/lib/libicui18n.so.57.1
f6a1f000 f6a2c000 r-xp /usr/lib/libail.so.0.1.0
f6a35000 f6a3c000 r-xp /usr/lib/libminizip.so.1.0.0
f6a45000 f6bee000 r-xp /usr/lib/libcrypto.so.1.0.0
f6c0e000 f6c55000 r-xp /usr/lib/libssl.so.1.0.0
f6c61000 f6c63000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c6b000 f6c72000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c7b000 f6c82000 r-xp /lib/libcrypt-2.13.so
f6cb3000 f6cb6000 r-xp /lib/libcap.so.2.21
f6cbe000 f6cc0000 r-xp /usr/lib/libiri.so
f6cc8000 f6d11000 r-xp /usr/lib/libmdm.so.1.2.69
f6d19000 f6d1f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6d27000 f6d4a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d54000 f6d56000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d5e000 f6d7b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d84000 f6d88000 r-xp /usr/lib/libsmack.so.1.0.0
f6d91000 f6daa000 r-xp /usr/lib/libnetwork.so.0.0.0
f6db3000 f6dbb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6dc3000 f6dc9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6dd2000 f6dd4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ddd000 f6ded000 r-xp /lib/libresolv-2.13.so
f6df1000 f6e09000 r-xp /usr/lib/liblzma.so.5.0.3
f6e12000 f6e14000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e1c000 f6e36000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e3e000 f6e6d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e76000 f6e85000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e8f000 f6e99000 r-xp /usr/lib/libsensord-shared.so
f6ea2000 f6f75000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f80000 f6f96000 r-xp /lib/libz.so.1.2.5
f6f9e000 f6fa3000 r-xp /usr/lib/libffi.so.5.0.10
f6fab000 f6fac000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6fb4000 f6fc4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6fcc000 f6fe5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fed000 f6fef000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ff7000 f706c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7076000 f707c000 r-xp /lib/librt-2.13.so
f7085000 f70a3000 r-xp /usr/lib/libsystemd.so.0.4.0
f70ad000 f70ae000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70b6000 f70d9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70e1000 f70e6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70ee000 f7118000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7121000 f7138000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7140000 f71a9000 r-xp /lib/libm-2.13.so
f71b2000 f7246000 r-xp /usr/lib/libstdc++.so.6.0.16
f7259000 f725e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7266000 f726d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7275000 f729f000 r-xp /usr/lib/libsensor.so.1.9.6
f72a8000 f7374000 r-xp /usr/lib/libxml2.so.2.7.8
f7381000 f7383000 r-xp /usr/lib/libiniparser.so.0
f738c000 f7392000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f739b000 f746b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f746c000 f74a0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f74a9000 f74e5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74ed000 f74f0000 r-xp /usr/lib/libbundle.so.0.1.22
f74f8000 f74fe000 r-xp /usr/lib/libappsvc.so.0.1.0
f7506000 f7547000 r-xp /usr/lib/libeina.so.1.7.99
f7550000 f7567000 r-xp /usr/lib/libecore.so.1.7.99
f757e000 f7587000 r-xp /usr/lib/libvconf.so.0.2.45
f758f000 f75a3000 r-xp /lib/libpthread-2.13.so
f75ae000 f75bb000 r-xp /usr/lib/libaul.so.0.1.0
f75c5000 f75c7000 r-xp /lib/libdl-2.13.so
f75d0000 f75db000 r-xp /lib/libunwind.so.8.0.1
f7608000 f7610000 r-xp /lib/libgcc_s-4.6.so.1
f7611000 f7735000 r-xp /lib/libc-2.13.so
f7743000 f7745000 r-xp /usr/lib/libdlog.so.0.0.0
f774d000 f7759000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7762000 f7767000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f776f000 f777e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7786000 f778a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7793000 f7796000 r-xp /usr/lib/libappcore-agent.so.1.1
f779e000 f77a0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f77a8000 f77ac000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f77b4000 f77d1000 r-xp /lib/ld-2.13.so
f77da000 f77dd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77dd000 f77e1000 r-xp /usr/lib/libsys-assert.so
f7d60000 f7dd0000 rw-p [heap]
fff94000 fffb5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7294)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf77db228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7772539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74793f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7477c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7483e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7489be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7489dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf74be75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74b91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7477c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7483e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7489be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7489dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf74bbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf74bc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74c3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e5b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e4e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6f21663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf73cefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73d07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7560ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf755bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf755c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf755c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7794183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77947fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77db4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf762885c) [/lib/libc.so.6] + 0x1785c
29: (0xf77daf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
sg id:2
04-23 20:09:42.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:411,0.056605,9.772438,0.816474
04-23 20:09:42.429+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.429+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:433,0.058379,9.772589,0.814551
04-23 20:09:42.449+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:453,0.056022,9.772439,0.816509
04-23 20:09:42.459+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.469+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:467,0.056025,9.772543,0.815261
04-23 20:09:42.489+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.489+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:493,0.054433,9.772504,0.815840
04-23 20:09:42.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:42.499+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:507,0.053982,9.772376,0.817392
04-23 20:09:42.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.529+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:530,0.054797,9.772346,0.817695
04-23 20:09:42.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:555,0.055454,9.772282,0.818428
04-23 20:09:42.549+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:42.549+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:42.549+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:42.549+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f12e10
04-23 20:09:42.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:573,0.056093,9.772389,0.817099
04-23 20:09:42.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:587,0.056974,9.772235,0.818881
04-23 20:09:42.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.599+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:606,0.058091,9.772229,0.818871
04-23 20:09:42.619+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.619+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:627,0.056522,9.772130,0.820158
04-23 20:09:42.619+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f1dbd8]
04-23 20:09:42.619+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:42.619+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:42.619+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:42.619+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:42.629+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:42.629+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:42.639+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.639+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:42.649+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:42.649+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:42.649+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:42.649+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:42.649+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:42.649+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:42.649+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:42.649+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:42.649+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:42.649+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:42.649+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:648,0.056820,9.772285,0.818302
04-23 20:09:42.649+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:42.659+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.659+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:666,0.055052,9.772326,0.817917
04-23 20:09:42.659+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:42.659+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:42.659+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:42.679+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.689+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:686,0.055242,9.772213,0.819258
04-23 20:09:42.699+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.699+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:706,0.053891,9.772132,0.820311
04-23 20:09:42.709+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:42.719+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.719+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:42.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:725,0.054441,9.772419,0.816848
04-23 20:09:42.739+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.739+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:746,0.053480,9.772367,0.817540
04-23 20:09:42.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:766,0.053129,9.772547,0.815408
04-23 20:09:42.769+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:42.769+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:42.779+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:42.779+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f1dbd8
04-23 20:09:42.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:785,0.054147,9.772386,0.817269
04-23 20:09:42.799+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.799+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:805,0.054006,9.772374,0.817417
04-23 20:09:42.819+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.819+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:825,0.056026,9.772458,0.816281
04-23 20:09:42.839+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.839+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:846,0.054516,9.772552,0.815249
04-23 20:09:42.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f12de8]
04-23 20:09:42.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:42.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:42.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:42.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:42.859+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:42.859+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:42.869+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:42.879+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:42.879+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:42.879+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:42.879+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:42.879+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:42.879+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:42.879+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:42.879+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:42.879+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:42.879+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:42.899+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:42.899+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:42.899+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:42.909+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.909+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:42.909+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:914,0.052982,9.772462,0.816436
04-23 20:09:42.909+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.919+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:920,0.051734,9.772459,0.816553
04-23 20:09:42.919+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.919+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:925,0.052290,9.772597,0.814854
04-23 20:09:42.919+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.929+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:930,0.052032,9.772444,0.816717
04-23 20:09:42.939+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.939+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:946,0.052209,9.772591,0.814938
04-23 20:09:42.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.959+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:42:967,0.054228,9.772897,0.811126
04-23 20:09:42.969+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:42.979+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:42.979+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:42.979+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:42.979+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f12de8
04-23 20:09:42.989+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:42.999+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:0,0.053845,9.772961,0.810389
04-23 20:09:43.009+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.019+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:19,0.053372,9.773049,0.809345
04-23 20:09:43.019+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.019+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:26,0.052346,9.773140,0.808324
04-23 20:09:43.039+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.039+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:45,0.050791,9.773172,0.808023
04-23 20:09:43.059+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.069+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:69,0.050463,9.773283,0.806704
04-23 20:09:43.079+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.079+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:84,0.049820,9.773127,0.808635
04-23 20:09:43.099+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.099+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:104,0.051827,9.773374,0.805520
04-23 20:09:43.119+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.119+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:125,0.052139,9.773571,0.803100
04-23 20:09:43.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:154,0.052078,9.773511,0.803835
04-23 20:09:43.159+0200 W/AUL     ( 7255): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:09:43.159+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:09:43.159+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:09:43.159+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7217
04-23 20:09:43.159+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:09:43.159+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7217
04-23 20:09:43.159+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7217)
04-23 20:09:43.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:168,0.052618,9.773376,0.805436
04-23 20:09:43.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:184,0.051615,9.773377,0.805486
04-23 20:09:43.199+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.199+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:204,0.053306,9.773674,0.801776
04-23 20:09:43.219+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.219+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:224,0.052285,9.773528,0.803611
04-23 20:09:43.239+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.239+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:245,0.053018,9.773636,0.802255
04-23 20:09:43.259+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.259+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:264,0.054072,9.773851,0.799552
04-23 20:09:43.279+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.279+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:284,0.055039,9.773697,0.801377
04-23 20:09:43.299+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.299+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:305,0.057122,9.773808,0.799866
04-23 20:09:43.319+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.319+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:324,0.059436,9.773827,0.799476
04-23 20:09:43.339+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.349+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:345,0.059140,9.773855,0.799149
04-23 20:09:43.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:366,0.059651,9.773724,0.800719
04-23 20:09:43.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.379+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:384,0.057975,9.773710,0.801006
04-23 20:09:43.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:584,0.061271,9.774390,0.792419
04-23 20:09:43.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:784,0.060237,9.773619,0.801952
04-23 20:09:43.979+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:43.979+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:43:984,0.059585,9.774863,0.786692
04-23 20:09:44.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:44.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:44:184,0.049454,9.774797,0.788205
04-23 20:09:44.269+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:09:44.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:44.379+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:44:383,0.046744,9.774428,0.792934
04-23 20:09:44.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:44.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:44:584,0.055450,9.775913,0.773845
04-23 20:09:44.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:44.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:44:784,0.053391,9.776971,0.760505
04-23 20:09:44.979+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:44.979+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:44:985,0.051274,9.776337,0.768763
04-23 20:09:45.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:45.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:45:184,0.056166,9.777025,0.759616
04-23 20:09:45.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:45.379+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:45:384,0.043981,9.776405,0.768338
04-23 20:09:45.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:45.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:45:585,0.052529,9.774223,0.795105
04-23 20:09:45.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:45.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:45:784,0.053534,9.773605,0.802594
04-23 20:09:45.979+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:45.979+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:45:984,0.066066,9.772524,0.814734
04-23 20:09:46.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:46.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:46:185,0.076191,9.773117,0.806702
04-23 20:09:46.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:46.379+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:46:384,0.065529,9.772610,0.813750
04-23 20:09:46.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:46.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:46:584,0.071055,9.773153,0.806729
04-23 20:09:46.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:46.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:46:784,0.059540,9.772958,0.810023
04-23 20:09:46.979+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:46.979+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:46:984,0.055005,9.772890,0.811155
04-23 20:09:47.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:47.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:47:184,0.055960,9.773005,0.809703
04-23 20:09:47.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:47.379+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:47:384,0.041600,9.771866,0.824188
04-23 20:09:47.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:47.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:47:584,0.047961,9.773235,0.807441
04-23 20:09:47.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:47.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:47:784,0.056045,9.774051,0.796975
04-23 20:09:47.979+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:47.979+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:47:984,0.053469,9.773681,0.801682
04-23 20:09:48.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:48.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:48:184,0.044969,9.772985,0.810638
04-23 20:09:48.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:48.379+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:48:384,0.051074,9.773777,0.800657
04-23 20:09:48.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:48.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:48:584,0.046227,9.773917,0.799246
04-23 20:09:48.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:48.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:48:784,0.058044,9.773025,0.809330
04-23 20:09:48.979+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:48.979+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:48:983,0.062039,9.773541,0.802756
04-23 20:09:49.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:49.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:49:184,0.061524,9.772975,0.809663
04-23 20:09:49.329+0200 I/servicemanager( 5532): es.ugr.frailty.gravity sleep timeout
04-23 20:09:49.329+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:09:49.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:49.329+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:49.339+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6942
04-23 20:09:49.349+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6942)
04-23 20:09:49.359+0200 I/servicemanager( 5532): es.ugr.frailty.gravity stop request sent!
04-23 20:09:49.359+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:09:49.359+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:49.359+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(6942), cmd(0)
04-23 20:09:49.359+0200 I/gravity ( 6942): stopping es.ugr.frailty.gravity service
04-23 20:09:49.359+0200 W/AUL     ( 6942): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:09:49.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:49.359+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6942
04-23 20:09:49.369+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:09:49.379+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:49.379+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:09:49.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.379+0200 I/utils   ( 5532): specific action
04-23 20:09:49.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.379+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:09:49.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:49.389+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:49.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:09:49.399+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:49.399+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:09:49.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.399+0200 I/utils   ( 5538): specific action
04-23 20:09:49.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:49.399+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
04-23 20:09:49.399+0200 I/recorder( 5538): guardando datos en local
04-23 20:09:49.399+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:09:49.399+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:09:49.399+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:09:49.399+0200 W/AUL     ( 6942): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:09:49.399+0200 I/gravity ( 6942): request sent to service es.ugr.frailty.servicemanager
04-23 20:09:49.399+0200 I/CAPI_APPFW_APPLICATION( 6942): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:09:49.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:09:49.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:09:49.449+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:09:49.459+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:09:49.479+0200 I/gravity ( 6942): es.ugr.frailty.gravity listener destroyed
04-23 20:09:49.619+0200 W/AUL     ( 7293): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
04-23 20:09:49.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:09:49.619+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:09:49.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6942
04-23 20:09:49.619+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:09:49.619+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6942
04-23 20:09:49.629+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6942)
04-23 20:09:51.399+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:09:51.499+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:09:51.499+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:09:51.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:51.499+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:51.509+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7294
04-23 20:09:51.509+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:09:51.559+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7294
04-23 20:09:51.559+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7294) type(svcapp) bg(0)
04-23 20:09:51.569+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7294)
04-23 20:09:51.569+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:09:51.569+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:09:51.569+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7294]
04-23 20:09:51.579+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:51.589+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7294
04-23 20:09:51.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:51.599+0200 E/CAPI_APPFW_APPLICATION( 7294): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:51.599+0200 E/CAPI_APPFW_APPLICATION( 7294): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:51.599+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7294) was created
04-23 20:09:51.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:51.609+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7294
04-23 20:09:51.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:51.619+0200 W/LOCATION( 7294): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:09:51.619+0200 E/LOCATION( 7294): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:09:51.619+0200 E/PKGMGR_INFO( 7294): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:09:51.629+0200 W/LOCATION( 7294): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:51.639+0200 I/LOCATION( 7294): location.c: location_new(269) > method: 0
04-23 20:09:51.639+0200 W/LOCATION( 7294): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:51.649+0200 W/LOCATION( 7294): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:51.649+0200 W/LOCATION( 7294): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:51.659+0200 W/LOCATION( 7294): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:51.659+0200 W/LOCATION( 7294): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:51.659+0200 W/LOCATION( 7294): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:51.659+0200 W/LOCATION( 7294): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:51.659+0200 W/LOCATION( 7294): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:51.659+0200 W/LOCATION( 7294): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:51.679+0200 W/LOCATION( 7294): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:51.679+0200 W/LOCATION( 7294): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:51.689+0200 W/LOCATION( 7294): module-internal.c: module_new(311) > module (wps) open success
04-23 20:09:51.689+0200 W/LOCATION( 7294): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:09:51.689+0200 W/LOCATION( 7294): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:09:51.689+0200 W/LOCATION( 7294): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:51.689+0200 W/LOCATION( 7294): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:51.709+0200 W/LOCATION( 7294): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:09:51.709+0200 I/LOCATION( 7294): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7d90c18
04-23 20:09:51.709+0200 I/LOCATION( 7294): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:09:51.709+0200 I/LOCATION( 7294): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7d90c18
04-23 20:09:51.709+0200 I/LOCATION( 7294): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:09:51.709+0200 I/location( 7294): es.ugr.frailty.location: creado servicio de localización
04-23 20:09:51.759+0200 I/LOCATION( 7294): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:09:51.799+0200 W/LOCATION( 7294): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:51.799+0200 W/LOCATION( 7294): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:51.799+0200 I/LOCATION( 7294): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:51.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:09:51.869+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:09:51.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:09:51.869+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:09:51.869+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:09:51.869+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:09:51.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:51.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:51.869+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:09:51.869+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:09:51.869+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:09:51.869+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:09:51.869+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:09:51.869+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:09:51.879+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:09:51.879+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:09:51.879+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:09:51.879+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:09:51.929+0200 W/LOCATION( 7294): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:51.929+0200 W/LOCATION( 7294): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:52.019+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:52.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f16888]
04-23 20:09:52.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:52.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:52.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:52.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:52.069+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:52.069+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:52.079+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:52.079+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:52.079+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:52.079+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:52.079+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:52.079+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:52.079+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:52.079+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:52.079+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:52.079+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:52.079+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:52.089+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:52.099+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:52.099+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:52.099+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:52.109+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:09:52.109+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1067378), time2(1054298)
04-23 20:09:52.109+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:09:52.109+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:09:52.109+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:09:52.109+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:09:52.149+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:52.179+0200 W/LOCATION( 7294): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:09:52.179+0200 I/LOCATION( 7294): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:52.179+0200 I/LOCATION( 7294): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:52.179+0200 I/location( 7294): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:09:52.259+0200 I/LOCATION( 7294): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:52.319+0200 E/location( 7294): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:09:52.319+0200 W/AUL     ( 7294): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:09:52.319+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:52.319+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7294
04-23 20:09:52.329+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:09:52.329+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:52.329+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:09:52.329+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.329+0200 I/utils   ( 5532): specific action
04-23 20:09:52.329+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.329+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.329+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.329+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:09:52.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:52.329+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:52.339+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:09:52.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:52.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:52.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:52.359+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:52.359+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:09:52.359+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.359+0200 I/utils   ( 5538): specific action
04-23 20:09:52.359+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.359+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.359+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.359+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.359+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:09:52.359+0200 I/recorder( 5538): guardando datos en local
04-23 20:09:52.359+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:09:52.359+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:09:52.359+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:09:52.359+0200 W/AUL     ( 7294): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:09:52.359+0200 I/location( 7294): request sent to service es.ugr.frailty.servicemanager
04-23 20:09:52.369+0200 W/CAPI_APPFW_APP_CONTROL( 7294): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:52.369+0200 I/utils   ( 7294): specific action
04-23 20:09:53.109+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:09:53.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:53.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:53.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:53.769+0200 W/LOCATION( 7294): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:09:53.939+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11072946c6f63152450699
