S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20970
Date: 2018-04-23 19:44:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf762652d, r5   = 0xf7b91f98
r6   = 0xff9f0398, r7   = 0xff9f0248
r8   = 0xf7b8ec18, r9   = 0x00000000
r10  = 0xff9f0324, fp   = 0xff9f0398
ip   = 0x00000001, sp   = 0xff9f0220
lr   = 0xf7626539, pc   = 0xf768f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5752 KB
Buffers:     56888 KB
Cached:     236156 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11664 KB
VmRSS:       11664 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20970 TID = 20970
20970 20972 

Maps Information
f44f1000 f4cf0000 rw-p [stack:20972]
f4cf7000 f4cf9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d01000 f4d05000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d0e000 f4d10000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d18000 f4d1b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d2a000 f4d2f000 r-xp /usr/lib/libsystem.so.0.0.0
f4d3a000 f4d3d000 r-xp /lib/libattr.so.1.1.0
f4d45000 f4d55000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d5d000 f4d66000 r-xp /usr/lib/libedbus.so.1.7.99
f4d6e000 f4d6f000 r-xp /usr/lib/libresponse.so.0.2.96
f4d78000 f4d7d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f661f000 f6725000 r-xp /usr/lib/libicuuc.so.57.1
f673b000 f68c3000 r-xp /usr/lib/libicui18n.so.57.1
f68d3000 f68e0000 r-xp /usr/lib/libail.so.0.1.0
f68e9000 f68f0000 r-xp /usr/lib/libminizip.so.1.0.0
f68f9000 f6aa2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6ac2000 f6b09000 r-xp /usr/lib/libssl.so.1.0.0
f6b15000 f6b17000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b1f000 f6b26000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b2f000 f6b36000 r-xp /lib/libcrypt-2.13.so
f6b67000 f6b6a000 r-xp /lib/libcap.so.2.21
f6b72000 f6b74000 r-xp /usr/lib/libiri.so
f6b7c000 f6bc5000 r-xp /usr/lib/libmdm.so.1.2.69
f6bcd000 f6bd3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6bdb000 f6bfe000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c08000 f6c0a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c12000 f6c2f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c38000 f6c3c000 r-xp /usr/lib/libsmack.so.1.0.0
f6c45000 f6c5e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c67000 f6c6f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c77000 f6c7d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c86000 f6c88000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c91000 f6ca1000 r-xp /lib/libresolv-2.13.so
f6ca5000 f6cbd000 r-xp /usr/lib/liblzma.so.5.0.3
f6cc6000 f6cc8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cd0000 f6cea000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cf2000 f6d21000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d2a000 f6d39000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d43000 f6d4d000 r-xp /usr/lib/libsensord-shared.so
f6d56000 f6e29000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e34000 f6e4a000 r-xp /lib/libz.so.1.2.5
f6e52000 f6e57000 r-xp /usr/lib/libffi.so.5.0.10
f6e5f000 f6e60000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e68000 f6e78000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e80000 f6e99000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ea1000 f6ea3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6eab000 f6f20000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f2a000 f6f30000 r-xp /lib/librt-2.13.so
f6f39000 f6f57000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f61000 f6f62000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f6a000 f6f8d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f95000 f6f9a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fa2000 f6fcc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fd5000 f6fec000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ff4000 f705d000 r-xp /lib/libm-2.13.so
f7066000 f70fa000 r-xp /usr/lib/libstdc++.so.6.0.16
f710d000 f7112000 r-xp /usr/lib/libctx-client.so.0.8.3
f711a000 f7121000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7129000 f7153000 r-xp /usr/lib/libsensor.so.1.9.6
f715c000 f7228000 r-xp /usr/lib/libxml2.so.2.7.8
f7235000 f7237000 r-xp /usr/lib/libiniparser.so.0
f7240000 f7246000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f724f000 f731f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7320000 f7354000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f735d000 f7399000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73a1000 f73a4000 r-xp /usr/lib/libbundle.so.0.1.22
f73ac000 f73b2000 r-xp /usr/lib/libappsvc.so.0.1.0
f73ba000 f73fb000 r-xp /usr/lib/libeina.so.1.7.99
f7404000 f741b000 r-xp /usr/lib/libecore.so.1.7.99
f7432000 f743b000 r-xp /usr/lib/libvconf.so.0.2.45
f7443000 f7457000 r-xp /lib/libpthread-2.13.so
f7462000 f746f000 r-xp /usr/lib/libaul.so.0.1.0
f7479000 f747b000 r-xp /lib/libdl-2.13.so
f7484000 f748f000 r-xp /lib/libunwind.so.8.0.1
f74bc000 f74c4000 r-xp /lib/libgcc_s-4.6.so.1
f74c5000 f75e9000 r-xp /lib/libc-2.13.so
f75f7000 f75f9000 r-xp /usr/lib/libdlog.so.0.0.0
f7601000 f760d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7616000 f761b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7623000 f7632000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f763a000 f763e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7647000 f764a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7652000 f7654000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f765c000 f7660000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7668000 f7685000 r-xp /lib/ld-2.13.so
f768e000 f7691000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7691000 f7695000 r-xp /usr/lib/libsys-assert.so
f7b5e000 f7bcf000 rw-p [heap]
ff9d1000 ff9f2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20970)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf768f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7626539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf732d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf732bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7337e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf733dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf733ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf737275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf736d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf732bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7337e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf733dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf733ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf736fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7370017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73748d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf765e0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4d02171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6dd5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7282fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72847a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7414ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf740fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74105a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7410879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7648183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76487fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf768f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf74dc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf768ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
LOCATION(18958): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:44:28.229+0200 W/LOCATION(18958): module-internal.c: module_new(311) > module (gps) open success
04-23 19:44:28.229+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:44:28.229+0200 E/CAPI_APPFW_APPLICATION(20975): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:44:28.229+0200 E/CAPI_APPFW_APPLICATION(20975): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:44:28.229+0200 I/utils   (20975): trying to start service: es.ugr.frailty.gravity
04-23 19:44:28.239+0200 W/LOCATION(18958): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:44:28.239+0200 W/LOCATION(18958): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:44:28.239+0200 W/LOCATION(18958): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:44:28.239+0200 W/LOCATION(18958): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:44:28.239+0200 W/LOCATION(18958): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:44:28.239+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20975
04-23 19:44:28.239+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20975) was created
04-23 19:44:28.239+0200 I/AUL     (18958): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:44:28.249+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:44:28.249+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.249+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:196,-16.590000,10.430000,2.100000
04-23 19:44:28.249+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.249+0200 I/AUL     (18958): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:44:28.249+0200 E/LOCATION(18958): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:44:28.259+0200 I/servicemanager(20291): es.ugr.frailty.gravity launch request sent!
04-23 19:44:28.259+0200 I/servicemanager(20291): App control destroyed.
04-23 19:44:28.259+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:44:28.259+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:210,0.493469,-1.438786,-0.228762
04-23 19:44:28.259+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:265,9.832108,-2.703890,1.533799
04-23 19:44:28.269+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.269+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:257,16.379999,19.670000,-7.280000
04-23 19:44:28.269+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.269+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.299+0200 I/utils   (20975): es.ugr.frailty.gravity sensor supported
04-23 19:44:28.299+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:283,27.370001,18.830000,-11.970000
04-23 19:44:28.299+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:44:28.299+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:275,0.204050,-1.247267,0.372282
04-23 19:44:28.309+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.309+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:282,9.497113,-1.696511,1.591227
04-23 19:44:28.309+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:44:28.319+0200 I/AUL     (18958): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:44:28.319+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20975
04-23 19:44:28.319+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:44:28.319+0200 I/AUL     (18958): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:44:28.319+0200 E/LOCATION(18958): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 19:44:28.319+0200 I/LOCATION(18958): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 19:44:28.329+0200 I/LOCATION(18958): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:44:28.329+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.329+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.339+0200 I/utils   (20975): es.ugr.frailty.gravity listener started
04-23 19:44:28.339+0200 W/CAPI_APPFW_APP_CONTROL(20975): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.339+0200 I/utils   (20975): specific action
04-23 19:44:28.349+0200 W/LOCATION(20970): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 19:44:28.349+0200 I/LOCATION(20970): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 19:44:28.349+0200 I/LOCATION(20970): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 19:44:28.349+0200 I/location(20970): es.ugr.frailty.location:iniciado servicio de localización
04-23 19:44:28.359+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.359+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:364,9.638324,-1.307764,1.250144
04-23 19:44:28.359+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.369+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:313,-0.116812,-0.195027,0.371234
04-23 19:44:28.369+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:372,9.644460,-1.280352,1.231048
04-23 19:44:28.369+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:339,15.120000,10.500000,-12.250000
04-23 19:44:28.379+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.379+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.379+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:363,9.434900,-1.079163,1.624727
04-23 19:44:28.379+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:388,9.650596,-1.259092,1.204609
04-23 19:44:28.399+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.399+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:409,9.657457,-1.223957,1.185676
04-23 19:44:28.429+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.429+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:433,9.661801,-1.194114,1.180709
04-23 19:44:28.429+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.439+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:436,-0.172262,0.418942,0.348600
04-23 19:44:28.439+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.439+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:444,-3.150000,3.220000,-10.710000
04-23 19:44:28.439+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.439+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:445,0.037486,0.375818,-0.054933
04-23 19:44:28.439+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.449+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.449+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:451,0.241579,0.588431,0.026818
04-23 19:44:28.449+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.449+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:453,9.664284,-1.172260,1.182291
04-23 19:44:28.449+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.449+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:455,0.052523,0.436271,0.285864
04-23 19:44:28.449+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.449+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:457,9.645468,-1.086342,1.256232
04-23 19:44:28.449+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.459+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:459,-0.088611,-0.198392,0.382701
04-23 19:44:28.459+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.459+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:465,0.057500,-0.336192,0.430595
04-23 19:44:28.459+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.459+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.469+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:469,0.065355,0.016459,0.154631
04-23 19:44:28.469+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.469+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:474,0.069521,0.258451,0.022138
04-23 19:44:28.469+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.469+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:471,9.668063,-1.162848,1.160481
04-23 19:44:28.479+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:479,-0.007213,0.259708,0.089837
04-23 19:44:28.479+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.479+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:484,0.017758,0.127012,-0.072922
04-23 19:44:28.479+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.479+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.489+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:490,0.167155,0.402462,0.025301
04-23 19:44:28.489+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.489+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:448,-17.710001,2.590000,-9.590000
04-23 19:44:28.489+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.499+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:461,9.856036,-0.837488,1.330409
04-23 19:44:28.499+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.499+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:495,0.136366,0.501325,0.104055
04-23 19:44:28.499+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.509+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:490,9.670591,-1.166138,1.135858
04-23 19:44:28.509+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.509+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:511,-0.025905,0.459517,0.195164
04-23 19:44:28.509+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.509+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:515,9.674246,-1.144240,1.126976
04-23 19:44:28.509+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:516,-0.045136,0.148132,-0.124663
04-23 19:44:28.509+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.509+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:499,-31.080000,6.580000,-8.820000
04-23 19:44:28.509+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.519+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:520,0.030047,-0.294381,-0.227280
04-23 19:44:28.519+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.519+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:525,0.185445,0.168331,-0.188300
04-23 19:44:28.519+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:506,9.674182,-0.947558,1.581656
04-23 19:44:28.519+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.529+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.529+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:534,0.222468,0.852315,-0.229667
04-23 19:44:28.529+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:531,9.535398,-1.557728,1.686940
04-23 19:44:28.529+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.539+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:540,9.681360,-1.698904,1.732404
04-23 19:44:28.539+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.539+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:522,-42.700001,1.610000,-8.890000
04-23 19:44:28.539+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.539+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.539+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.539+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:549,9.679533,-1.093785,1.131663
04-23 19:44:28.549+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:549,-0.089100,0.320903,-0.248712
04-23 19:44:28.549+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:545,9.690931,-1.344766,1.445265
04-23 19:44:28.549+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.549+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:555,9.700503,-1.081556,1.294517
04-23 19:44:28.549+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.549+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:559,9.631111,-1.048056,1.339981
04-23 19:44:28.559+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.559+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.559+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:563,9.680944,-1.086934,1.126179
04-23 19:44:28.559+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:563,9.662218,-1.153341,1.158126
04-23 19:44:28.559+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.559+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.559+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:569,0.153557,-0.140584,-0.047016
04-23 19:44:28.569+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:546,-32.480000,-4.620000,-9.520000
04-23 19:44:28.569+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.569+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:568,9.817751,-0.856631,1.229911
04-23 19:44:28.569+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.569+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:574,-22.469999,-3.220000,-10.780000
04-23 19:44:28.569+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.569+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:577,9.793823,-0.722632,1.289732
04-23 19:44:28.569+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:578,-21.070000,-3.010000,-10.500000
04-23 19:44:28.569+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.569+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.579+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:582,9.635897,-0.734596,1.375873
04-23 19:44:28.579+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.579+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.579+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.579+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:588,9.680044,-1.100715,1.120517
04-23 19:44:28.579+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.579+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:589,0.144885,-0.390014,0.152465
04-23 19:44:28.589+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:586,9.619147,-1.024128,1.057628
04-23 19:44:28.589+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.589+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:595,9.698111,-1.457229,0.933201
04-23 19:44:28.589+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.589+0200 I/LOCATION(20970): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:44:28.599+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:599,9.856036,-0.997807,0.947558
04-23 19:44:28.599+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.599+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:592,9.676096,-1.123458,1.131990
04-23 19:44:28.599+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:604,9.896714,-0.291924,0.897308
04-23 19:44:28.599+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:581,-24.710001,-3.850000,-8.400000
04-23 19:44:28.599+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.609+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:609,9.590433,-0.772882,0.882952
04-23 19:44:28.609+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.609+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.609+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:614,9.671012,-1.136715,1.161809
04-23 19:44:28.609+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:614,0.000479,-0.180630,0.394631
04-23 19:44:28.609+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.609+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:619,9.834501,-1.227518,1.079163
04-23 19:44:28.609+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.619+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:623,9.824929,-1.490728,1.272982
04-23 19:44:28.619+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.619+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:627,9.676575,-1.304088,1.526621
04-23 19:44:28.619+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.629+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.629+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.629+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:634,9.669424,-1.122464,1.188568
04-23 19:44:28.629+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:634,-0.025544,0.354262,0.369597
04-23 19:44:28.629+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.629+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:638,9.645468,-0.782453,1.531406
04-23 19:44:28.639+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:631,-21.139999,-4.340000,-7.700000
04-23 19:44:28.639+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.639+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:645,-15.540000,-4.550000,-6.580000
04-23 19:44:28.639+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.639+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.639+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:649,0.033471,0.454866,0.089200
04-23 19:44:28.649+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.649+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:650,-21.420000,-0.210000,-4.620000
04-23 19:44:28.649+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.649+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:653,9.671300,-1.103433,1.191125
04-23 19:44:28.649+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.649+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:654,-26.250000,0.770000,-3.360000
04-23 19:44:28.649+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.649+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:657,9.702895,-0.667598,1.277767
04-23 19:44:28.649+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:659,-26.320000,-3.010000,-3.010000
04-23 19:44:28.659+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.659+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:663,-7.000000,-4.060000,-3.570000
04-23 19:44:28.659+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.659+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.659+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:668,17.920000,0.280000,-4.200000
04-23 19:44:28.659+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:669,0.062703,-0.157584,-0.123926
04-23 19:44:28.659+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.669+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.669+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:673,12.040000,3.920000,-1.960000
04-23 19:44:28.669+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.669+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:673,9.671587,-1.116343,1.176679
04-23 19:44:28.669+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:678,-10.290000,3.010000,1.260000
04-23 19:44:28.669+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.679+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.679+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:683,-17.290001,-0.210000,1.890000
04-23 19:44:28.679+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:683,9.734003,-1.261017,1.067199
04-23 19:44:28.679+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.679+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.679+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:687,-8.470000,3.010000,0.420000
04-23 19:44:28.679+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:689,0.146164,-0.403099,0.184837
04-23 19:44:28.679+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.689+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:692,1.400000,5.880000,-0.630000
04-23 19:44:28.689+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.689+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:697,2.660000,4.830000,-0.910000
04-23 19:44:28.689+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.699+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.699+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.699+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:701,-9.520000,-0.630000,1.050000
04-23 19:44:28.699+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.699+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:706,-17.010000,-2.940000,2.030000
04-23 19:44:28.709+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.709+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.709+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:713,-5.950000,-1.890000,0.840000
04-23 19:44:28.709+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.709+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:717,0.065004,-0.228963,0.073689
04-23 19:44:28.709+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:703,9.668999,-1.134946,1.180150
04-23 19:44:28.709+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.709+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:718,13.230000,-0.770000,-1.750000
04-23 19:44:28.719+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:705,9.817751,-1.519442,1.361516
04-23 19:44:28.719+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.719+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:722,9.668373,-1.137077,1.183215
04-23 19:44:28.729+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.729+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.729+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:734,0.034522,0.148842,-0.089695
04-23 19:44:28.729+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:724,9.734003,-1.363909,1.253839
04-23 19:44:28.729+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.739+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:735,17.710001,-0.910000,-3.150000
04-23 19:44:28.739+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.739+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.739+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:749,9.671247,-1.117674,1.178213
04-23 19:44:28.749+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.749+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:753,0.034042,0.340007,-0.362260
04-23 19:44:28.749+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:740,9.702895,-0.988236,1.093520
04-23 19:44:28.749+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.749+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:758,9.705289,-0.777667,0.815953
04-23 19:44:28.749+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:753,9.520000,-2.800000,-1.750000
04-23 19:44:28.749+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.759+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:762,9.676793,-1.092818,1.155769
04-23 19:44:28.759+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.759+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.759+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:769,0.085923,0.023226,-0.162748
04-23 19:44:28.769+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:769,-1.890000,-0.210000,-0.980000
04-23 19:44:28.769+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.779+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.779+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:781,9.678353,-1.089755,1.145557
04-23 19:44:28.779+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:783,9.762716,-1.069592,0.993021
04-23 19:44:28.779+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.779+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.779+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:788,9.750752,-1.277767,1.093520
04-23 19:44:28.779+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.779+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:788,9.677767,-1.098256,1.142383
04-23 19:44:28.789+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.789+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:792,0.072399,-0.188013,-0.052037
04-23 19:44:28.789+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:794,-1.820000,0.070000,-0.140000
04-23 19:44:28.799+0200 E/location(20970): es.ugr.frailty.location: error intentando obtener la última localización
04-23 19:44:28.799+0200 W/AUL     (20970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 19:44:28.799+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:44:28.799+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20970
04-23 19:44:28.799+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.809+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20291
04-23 19:44:28.809+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:44:28.809+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20291), cmd(0)
04-23 19:44:28.809+0200 W/CAPI_APPFW_APP_CONTROL(20291): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.809+0200 I/utils   (20291): specific action
04-23 19:44:28.809+0200 W/CAPI_APPFW_APP_CONTROL(20291): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.809+0200 W/CAPI_APPFW_APP_CONTROL(20291): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.809+0200 W/CAPI_APPFW_APP_CONTROL(20291): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.809+0200 W/AUL     (20291): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 19:44:28.809+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:44:28.809+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.809+0200 W/AUL     (20970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20291)
04-23 19:44:28.809+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20291
04-23 19:44:28.809+0200 I/location(20970): request sent to service es.ugr.frailty.servicemanager
04-23 19:44:28.819+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:821,9.680202,-1.102587,1.117304
04-23 19:44:28.819+0200 W/CAPI_APPFW_APP_CONTROL(20970): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.819+0200 I/utils   (20970): specific action
04-23 19:44:28.819+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20296
04-23 19:44:28.819+0200 W/CAPI_APPFW_APP_CONTROL(20296): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.819+0200 I/utils   (20296): specific action
04-23 19:44:28.819+0200 W/AUL     (20291): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20296)
04-23 19:44:28.819+0200 I/servicemanager(20291): request sent to service es.ugr.frailty.recorder
04-23 19:44:28.819+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:44:28.819+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20296), cmd(0)
04-23 19:44:28.819+0200 I/servicemanager(20291): requesting to save local data
04-23 19:44:28.819+0200 W/CAPI_APPFW_APP_CONTROL(20296): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.819+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.819+0200 W/CAPI_APPFW_APP_CONTROL(20296): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.819+0200 W/CAPI_APPFW_APP_CONTROL(20296): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.819+0200 W/CAPI_APPFW_APP_CONTROL(20296): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:44:28.819+0200 I/recorder(20296): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 19:44:28.819+0200 I/recorder(20296): guardando datos en local
04-23 19:44:28.829+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.829+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:831,0.025128,-0.277617,-0.395823
04-23 19:44:28.829+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.829+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:836,0.333760,-0.031611,0.055179
04-23 19:44:28.829+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:835,9.681939,-1.087602,1.116943
04-23 19:44:28.829+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:809,9.702895,-1.375873,0.746561
04-23 19:44:28.829+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.839+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.839+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:843,11.480000,-3.640000,-1.120000
04-23 19:44:28.839+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.839+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.839+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:849,9.684101,-1.061008,1.123756
04-23 19:44:28.849+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:840,10.013963,-1.134198,1.172483
04-23 19:44:28.849+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.849+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:855,9.683753,-0.763310,1.095913
04-23 19:44:28.849+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.849+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:859,0.001814,0.324292,-0.021031
04-23 19:44:28.859+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.859+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:847,20.860001,-0.910000,-4.060000
04-23 19:44:28.859+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.859+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:868,9.683444,-1.048338,1.141172
04-23 19:44:28.879+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.879+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:883,-0.175024,0.163700,0.457900
04-23 19:44:28.879+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.879+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.879+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:887,9.509077,-0.897308,1.581656
04-23 19:44:28.879+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.879+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:888,9.683974,-1.041080,1.143318
04-23 19:44:28.889+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.889+0200 I/LOCATION(20970): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:44:28.889+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:893,-0.138474,-0.045182,0.258629
04-23 19:44:28.889+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:871,14.420000,4.270000,-5.320000
04-23 19:44:28.889+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.889+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:898,2.730000,-0.700000,-2.590000
04-23 19:44:28.889+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.899+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:891,9.544970,-1.093520,1.399801
04-23 19:44:28.899+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.909+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:909,9.688079,-1.029719,1.118564
04-23 19:44:28.909+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.909+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.909+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:916,9.779467,-1.016950,0.859023
04-23 19:44:28.909+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:913,0.095492,0.024130,-0.284295
04-23 19:44:28.929+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.929+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.929+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:933,0.347420,0.051054,-0.781176
04-23 19:44:28.929+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:933,9.694733,-1.018581,1.070067
04-23 19:44:28.929+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.929+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:902,4.900000,-4.130000,-2.450000
04-23 19:44:28.929+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.939+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:937,10.035499,-0.978664,0.337388
04-23 19:44:28.939+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:941,10.360000,-5.320000,-1.400000
04-23 19:44:28.939+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.939+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.939+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.949+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.949+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:951,9.697248,-0.996041,1.068491
04-23 19:44:28.949+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:950,0.297695,0.315091,-0.191901
04-23 19:44:28.949+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:953,9.992428,-0.703490,0.878166
04-23 19:44:28.959+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:948,14.490000,-2.660000,-3.150000
04-23 19:44:28.959+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.959+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.959+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:969,-0.274312,0.132232,0.618449
04-23 19:44:28.969+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:969,9.693194,-0.994018,1.106481
04-23 19:44:28.979+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.979+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:983,9.422935,-0.863809,1.686940
04-23 19:44:28.979+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.979+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:28.979+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:987,7.700000,5.110000,-4.410000
04-23 19:44:28.979+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.979+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:28:989,9.692385,-0.990261,1.116891
04-23 19:44:28.989+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:28.989+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:28:993,-0.313330,-0.058824,0.403390
04-23 19:44:28.989+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:28.989+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:28:997,9.379865,-1.052842,1.509871
04-23 19:44:28.999+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:28:992,-0.280000,5.880000,-2.310000
04-23 19:44:28.999+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:28.999+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:29:3,0.210000,-2.870000,-2.870000
04-23 19:44:28.999+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:29.009+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:29:9,9.694794,-0.980759,1.104297
04-23 19:44:29.009+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:29.009+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:29.019+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:29:15,0.161259,-0.112830,0.012521
04-23 19:44:29.019+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:29:15,9.853643,-1.103091,1.129412
04-23 19:44:29.019+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:29.019+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:29:26,5.600000,-4.200000,-4.060000
04-23 19:44:29.029+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:29.029+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:29:35,9.697394,-0.964803,1.095485
04-23 19:44:29.039+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:29.039+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:29:46,0.335918,0.023630,-0.104097
04-23 19:44:29.039+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:29.049+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:29:50,10.030712,-0.957129,1.000200
04-23 19:44:29.049+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:29.049+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:29.049+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:29:59,9.701666,-0.952146,1.068399
04-23 19:44:29.059+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:29.059+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:29.059+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:29.069+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:29:65,0.000716,0.014853,-0.540350
04-23 19:44:29.069+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:29.069+0200 I/linearacceleration(20957): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:44:29:76,0.118479,0.236692,0.113655
04-23 19:44:29.079+0200 I/accelerometer(20930): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:44:29:69,9.698111,-0.949951,0.555135
04-23 19:44:29.079+0200 I/accelerometer(20930): capturing data from es.ugr.frailty.accelerometer
04-23 19:44:29.079+0200 I/linearacceleration(20957): capturing data from es.ugr.frailty.linearacceleration
04-23 19:44:29.089+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:29:76,9.703265,-0.928770,1.074435
04-23 19:44:29.089+0200 I/gravity (20975): capturing data from es.ugr.frailty.gravity
04-23 19:44:29.089+0200 I/gyroscope(20944): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:44:29:54,10.290000,0.840000,-5.600000
04-23 19:44:29.089+0200 I/gravity (20975): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:44:29:97,9.702712,-0.922774,1.084552
04-23 19:44:29.099+0200 I/gyroscope(20944): capturing data from es.ugr.frailty.gyroscope
04-23 19:44:29.099+0200 W/CRASH_MANAGER(20380): worker.c: worker_job(1205) > 11209706c6f63152450546
