S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21549
Date: 2018-04-23 16:00:17+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76d252d, r5   = 0xf7b2cf98
r6   = 0xffa64b78, r7   = 0xffa64a28
r8   = 0xf7b29c18, r9   = 0x00000000
r10  = 0xffa64b04, fp   = 0xffa64b78
ip   = 0x00000001, sp   = 0xffa638a8
lr   = 0xf76d2539, pc   = 0xf773b2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11712 KB
Buffers:     59416 KB
Cached:     232544 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12048 KB
VmRSS:       12048 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21549 TID = 21549
21549 21552 

Maps Information
f459d000 f4d9c000 rw-p [stack:21552]
f4da3000 f4da5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dad000 f4db1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dba000 f4dbc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dc4000 f4dc7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dd6000 f4ddb000 r-xp /usr/lib/libsystem.so.0.0.0
f4de6000 f4de9000 r-xp /lib/libattr.so.1.1.0
f4df1000 f4e01000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e09000 f4e12000 r-xp /usr/lib/libedbus.so.1.7.99
f4e1a000 f4e1b000 r-xp /usr/lib/libresponse.so.0.2.96
f4e24000 f4e29000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66cb000 f67d1000 r-xp /usr/lib/libicuuc.so.57.1
f67e7000 f696f000 r-xp /usr/lib/libicui18n.so.57.1
f697f000 f698c000 r-xp /usr/lib/libail.so.0.1.0
f6995000 f699c000 r-xp /usr/lib/libminizip.so.1.0.0
f69a5000 f6b4e000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b6e000 f6bb5000 r-xp /usr/lib/libssl.so.1.0.0
f6bc1000 f6bc3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bcb000 f6bd2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bdb000 f6be2000 r-xp /lib/libcrypt-2.13.so
f6c13000 f6c16000 r-xp /lib/libcap.so.2.21
f6c1e000 f6c20000 r-xp /usr/lib/libiri.so
f6c28000 f6c71000 r-xp /usr/lib/libmdm.so.1.2.69
f6c79000 f6c7f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c87000 f6caa000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cb4000 f6cb6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cbe000 f6cdb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ce4000 f6ce8000 r-xp /usr/lib/libsmack.so.1.0.0
f6cf1000 f6d0a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d13000 f6d1b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d23000 f6d29000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d32000 f6d34000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d3d000 f6d4d000 r-xp /lib/libresolv-2.13.so
f6d51000 f6d69000 r-xp /usr/lib/liblzma.so.5.0.3
f6d72000 f6d74000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d7c000 f6d96000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d9e000 f6dcd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dd6000 f6de5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6def000 f6df9000 r-xp /usr/lib/libsensord-shared.so
f6e02000 f6ed5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ee0000 f6ef6000 r-xp /lib/libz.so.1.2.5
f6efe000 f6f03000 r-xp /usr/lib/libffi.so.5.0.10
f6f0b000 f6f0c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f14000 f6f24000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f2c000 f6f45000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f4d000 f6f4f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f57000 f6fcc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fd6000 f6fdc000 r-xp /lib/librt-2.13.so
f6fe5000 f7003000 r-xp /usr/lib/libsystemd.so.0.4.0
f700d000 f700e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7016000 f7039000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7041000 f7046000 r-xp /usr/lib/libxdgmime.so.1.1.0
f704e000 f7078000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7081000 f7098000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70a0000 f7109000 r-xp /lib/libm-2.13.so
f7112000 f71a6000 r-xp /usr/lib/libstdc++.so.6.0.16
f71b9000 f71be000 r-xp /usr/lib/libctx-client.so.0.8.3
f71c6000 f71cd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71d5000 f71ff000 r-xp /usr/lib/libsensor.so.1.9.6
f7208000 f72d4000 r-xp /usr/lib/libxml2.so.2.7.8
f72e1000 f72e3000 r-xp /usr/lib/libiniparser.so.0
f72ec000 f72f2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72fb000 f73cb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73cc000 f7400000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7409000 f7445000 r-xp /usr/lib/libSLP-location.so.0.9.24
f744d000 f7450000 r-xp /usr/lib/libbundle.so.0.1.22
f7458000 f745e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7466000 f74a7000 r-xp /usr/lib/libeina.so.1.7.99
f74b0000 f74c7000 r-xp /usr/lib/libecore.so.1.7.99
f74de000 f74e7000 r-xp /usr/lib/libvconf.so.0.2.45
f74ef000 f7503000 r-xp /lib/libpthread-2.13.so
f750e000 f751b000 r-xp /usr/lib/libaul.so.0.1.0
f7525000 f7527000 r-xp /lib/libdl-2.13.so
f7530000 f753b000 r-xp /lib/libunwind.so.8.0.1
f7568000 f7570000 r-xp /lib/libgcc_s-4.6.so.1
f7571000 f7695000 r-xp /lib/libc-2.13.so
f76a3000 f76a5000 r-xp /usr/lib/libdlog.so.0.0.0
f76ad000 f76b9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76c2000 f76c7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76cf000 f76de000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76e6000 f76ea000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76f3000 f76f6000 r-xp /usr/lib/libappcore-agent.so.1.1
f76fe000 f7700000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7708000 f770c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7714000 f7731000 r-xp /lib/ld-2.13.so
f773a000 f773d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f773d000 f7741000 r-xp /usr/lib/libsys-assert.so
f7af9000 f7b5b000 rw-p [heap]
ffa46000 ffa67000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21549)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf773b2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf76d2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73d93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73d7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73e3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73e9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73e9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf741e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74191f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73d7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73e3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73e9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73e9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf741be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf741c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74208d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf770a0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4dae171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e81663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf732efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73307a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74c0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74bbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74bc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74bc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76f4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76f47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf773b6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf758885c) [/lib/libc.so.6] + 0x1785c
29: (0xf773afa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
0 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.271+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:278,2.007578,-3.280560,9.492328
04-23 16:00:15.281+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.291+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:293,6.230000,-0.770000,-0.560000
04-23 16:00:15.291+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.291+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:298,1.966900,-3.122634,9.339187
04-23 16:00:15.311+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.311+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:15.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:15.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:15.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e03ec0
04-23 16:00:15.321+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:315,0.770000,-1.400000,0.210000
04-23 16:00:15.341+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.341+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:317,1.969293,-3.273381,9.111869
04-23 16:00:15.341+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:345,-0.910000,-1.120000,0.840000
04-23 16:00:15.341+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.351+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.351+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:352,2.026721,-3.318845,9.212367
04-23 16:00:15.361+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.361+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:359,0.070000,-0.350000,0.350000
04-23 16:00:15.371+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.371+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:365,1.964507,-3.282953,9.020942
04-23 16:00:15.371+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:376,2.520000,0.140000,-0.210000
04-23 16:00:15.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01338]
04-23 16:00:15.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:15.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:15.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:15.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:15.381+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.381+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:15.381+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:15.381+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:386,1.974079,-3.352344,8.970692
04-23 16:00:15.381+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.391+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:394,4.060000,0.840000,-0.350000
04-23 16:00:15.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:15.391+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.391+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:15.391+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:15.391+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:399,1.964507,-3.285345,9.083155
04-23 16:00:15.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:15.401+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:15.401+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:15.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:15.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:15.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:15.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:15.401+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:15.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:15.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:15.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:15.411+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.411+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:415,4.830000,0.770000,-0.490000
04-23 16:00:15.411+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:15.411+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:15.411+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:15.411+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:420,1.923829,-3.361916,9.080762
04-23 16:00:15.421+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.431+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:434,-0.140000,1.750000,-0.770000
04-23 16:00:15.431+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.431+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:439,2.060220,-3.230310,9.212367
04-23 16:00:15.441+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.451+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:454,-2.310000,1.330000,-0.840000
04-23 16:00:15.451+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.451+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:458,1.959722,-3.311667,9.183653
04-23 16:00:15.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:15.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:15.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:15.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:15.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01338
04-23 16:00:15.461+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.461+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.471+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:473,1.947758,-3.235096,9.147761
04-23 16:00:15.481+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:473,0.350000,0.070000,-0.630000
04-23 16:00:15.481+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.491+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.491+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:494,2.310000,-0.280000,-0.350000
04-23 16:00:15.491+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:495,1.969293,-3.242275,9.147761
04-23 16:00:15.511+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.511+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.511+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:515,1.990828,-3.242275,9.138189
04-23 16:00:15.511+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:515,1.540000,-0.280000,-0.280000
04-23 16:00:15.521+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.521+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.531+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:531,-0.070000,0.980000,0.420000
04-23 16:00:15.541+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:531,2.050649,-3.292524,9.138189
04-23 16:00:15.541+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.551+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:553,1.988436,-3.244668,9.109475
04-23 16:00:15.581+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.581+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.591+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:15.591+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:15.591+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:594,1.928615,-3.290131,9.188439
04-23 16:00:15.591+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:594,1.050000,0.490000,-0.420000
04-23 16:00:15.631+0200 W/AUL     (21548): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:00:15.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:15.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:15.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21469
04-23 16:00:15.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:15.641+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21469
04-23 16:00:15.641+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21469)
04-23 16:00:15.791+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.791+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.791+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:15.791+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:15.791+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:796,0.840000,0.700000,0.280000
04-23 16:00:15.801+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:796,1.990828,-3.232704,9.162118
04-23 16:00:15.991+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:15.991+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:15.991+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:15.991+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:16.001+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:15:994,0.210000,0.420000,0.070000
04-23 16:00:16.001+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:15:995,1.986043,-3.139383,9.219545
04-23 16:00:16.181+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:16.191+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:16.191+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:16.191+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:16.201+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:16:195,0.280000,-0.070000,0.070000
04-23 16:00:16.211+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:16:194,1.945365,-3.366701,9.241080
04-23 16:00:16.381+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:16.391+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:16.391+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:16.391+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:16.401+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:16:395,1.952543,-3.259024,9.164511
04-23 16:00:16.401+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:16:394,-0.560000,-1.050000,0.210000
04-23 16:00:16.591+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:16.591+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:16.591+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:16.591+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:16.611+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:16:599,1.792224,-3.321238,8.949157
04-23 16:00:16.611+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:16:597,37.310001,-7.980000,-0.140000
04-23 16:00:16.671+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:16.691+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:00:16.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:16.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:16.691+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:16.711+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21549
04-23 16:00:16.711+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:16.761+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21549
04-23 16:00:16.761+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21549) type(svcapp) bg(0)
04-23 16:00:16.771+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21549]
04-23 16:00:16.801+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:16.811+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21549
04-23 16:00:16.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:16.821+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:16.821+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:16.821+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21549)
04-23 16:00:16.821+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:00:16.831+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:16.831+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:16.831+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:16:837,2.758924,-0.593420,9.427721
04-23 16:00:16.831+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:16.841+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:16:842,-1.120000,6.650000,10.010000
04-23 16:00:16.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:16.851+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21549
04-23 16:00:16.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:16.881+0200 E/CAPI_APPFW_APPLICATION(21549): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:16.881+0200 E/CAPI_APPFW_APPLICATION(21549): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:16.881+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21549) was created
04-23 16:00:16.901+0200 W/LOCATION(21549): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:16.901+0200 E/LOCATION(21549): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:16.901+0200 E/PKGMGR_INFO(21549): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:16.911+0200 W/LOCATION(21549): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:16.931+0200 I/LOCATION(21549): location.c: location_new(269) > method: 0
04-23 16:00:16.931+0200 W/LOCATION(21549): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:16.931+0200 W/LOCATION(21549): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:16.941+0200 W/LOCATION(21549): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:16.941+0200 W/LOCATION(21549): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:16.951+0200 W/LOCATION(21549): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:16.951+0200 W/LOCATION(21549): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:16.951+0200 W/LOCATION(21549): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:16.951+0200 W/LOCATION(21549): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:16.951+0200 W/LOCATION(21549): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:16.971+0200 W/LOCATION(21549): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:16.981+0200 W/LOCATION(21549): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:16.981+0200 W/LOCATION(21549): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:16.981+0200 W/LOCATION(21549): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:16.981+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:16.991+0200 W/LOCATION(21549): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:16.991+0200 W/LOCATION(21549): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:16.991+0200 W/LOCATION(21549): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:16.991+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:16:994,2.634498,-1.828116,9.399008
04-23 16:00:16.991+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:16.991+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:16.991+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:16.991+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:16:999,9.310000,5.180000,-5.880000
04-23 16:00:17.011+0200 W/LOCATION(21549): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:17.011+0200 I/LOCATION(21549): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b29c18
04-23 16:00:17.011+0200 I/LOCATION(21549): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:17.011+0200 I/LOCATION(21549): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b29c18
04-23 16:00:17.011+0200 I/LOCATION(21549): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:17.011+0200 I/location(21549): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:17.051+0200 I/LOCATION(21549): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:17.091+0200 W/LOCATION(21549): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:17.091+0200 W/LOCATION(21549): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:17.091+0200 I/LOCATION(21549): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:17.151+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:17.151+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:17.151+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:17.151+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:17.151+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:17.151+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:17.151+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:17.151+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:17.151+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:17.151+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:17.151+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:17.151+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:17.151+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:17.151+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:17.161+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:17.161+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:17.161+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:17.161+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:17.181+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:17.181+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:17.191+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:17:194,2.383251,-1.737189,9.224331
04-23 16:00:17.191+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:17:194,-26.880001,4.830000,-4.970000
04-23 16:00:17.191+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:17.191+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:17.221+0200 W/LOCATION(21549): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:17.221+0200 W/LOCATION(21549): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:17.301+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:17.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7376080]
04-23 16:00:17.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:17.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:17.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:17.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:17.351+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:17.351+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:17.361+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:17.371+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:17.371+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:17.371+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:17.371+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:17.371+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:17.371+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:17.371+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:17.371+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:17.371+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:17.371+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:17.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:17.381+0200 I/gyroscope(21508): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:17.391+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:17:394,-1.610000,0.070000,0.350000
04-23 16:00:17.391+0200 I/accelerometer(21496): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:17.391+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:17.391+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:17.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:17.401+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:17.401+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:17:401,2.136791,-1.502693,9.590433
04-23 16:00:17.401+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:17.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:17.461+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:17.461+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5913123), time2(5908847)
04-23 16:00:17.461+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:00:17.461+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:17.461+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:17.461+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:17.461+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer sleep timeout
04-23 16:00:17.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 16:00:17.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:17.471+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:17.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21496
04-23 16:00:17.491+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21496)
04-23 16:00:17.491+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer stop request sent!
04-23 16:00:17.491+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:17.491+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope sleep timeout
04-23 16:00:17.491+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 16:00:17.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:17.491+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:17.501+0200 I/accelerometer(21496): stopping es.ugr.frailty.accelerometer service
04-23 16:00:17.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21508
04-23 16:00:17.511+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:17.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:17.531+0200 W/LOCATION(21549): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:17.531+0200 I/LOCATION(21549): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:17.531+0200 I/LOCATION(21549): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:17.531+0200 I/location(21549): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:17.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:17.551+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:17.571+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21508)
04-23 16:00:17.571+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope stop request sent!
04-23 16:00:17.571+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21496
04-23 16:00:17.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:17.571+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:17.581+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:17.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:17.581+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:17.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21496), cmd(0)
04-23 16:00:17.581+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:17.581+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:17.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(19708), cmd(0)
04-23 16:00:17.581+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.581+0200 I/utils   (19708): specific action
04-23 16:00:17.581+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:17.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:17.581+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:17.581+0200 I/accelerometer(21496): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:17.581+0200 I/CAPI_APPFW_APPLICATION(21496): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:00:17.591+0200 I/gyroscope(21508): stopping es.ugr.frailty.gyroscope service
04-23 16:00:17.591+0200 W/AUL     (21508): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:17.591+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:17.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:17.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:00:17.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:00:17.601+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:17.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(21508), cmd(0)
04-23 16:00:17.601+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:17.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:17.601+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.601+0200 I/utils   (21185): specific action
04-23 16:00:17.601+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.601+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 16:00:17.601+0200 I/recorder(21185): guardando datos en local
04-23 16:00:17.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:17.601+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:17.601+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:17.601+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:17.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:17.611+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21508
04-23 16:00:17.621+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:17.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:17.631+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:17.631+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:17.631+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:17.631+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:17.631+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:17.631+0200 W/AUL     (21508): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:17.631+0200 I/gyroscope(21508): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:17.631+0200 I/CAPI_APPFW_APPLICATION(21508): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:00:17.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:00:17.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:00:17.641+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.641+0200 I/utils   (19708): specific action
04-23 16:00:17.641+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.641+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:17.651+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:17.651+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:17.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:17.651+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:17.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:17.661+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.661+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:17.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:17.671+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:00:17.681+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:00:17.681+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:17.681+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:17.681+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:17.681+0200 I/utils   (21185): specific action
04-23 16:00:17.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.681+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 16:00:17.681+0200 I/recorder(21185): guardando datos en local
04-23 16:00:17.701+0200 I/accelerometer(21496): es.ugr.frailty.accelerometer listener destroyed
04-23 16:00:17.721+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:00:17.731+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:00:17.741+0200 I/gyroscope(21508): es.ugr.frailty.gyroscope listener destroyed
04-23 16:00:17.771+0200 I/LOCATION(21549): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:17.791+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:17.791+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:17.821+0200 W/AUL     (21557): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 16:00:17.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:17.821+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:17.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21496
04-23 16:00:17.821+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:17.831+0200 W/AUL     (21549): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:17.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:17.831+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21549
04-23 16:00:17.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:17.841+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21496
04-23 16:00:17.841+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21496)
04-23 16:00:17.851+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.851+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:17.851+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:17.861+0200 I/utils   (19708): specific action
04-23 16:00:17.861+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.861+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.861+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.861+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:17.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:17.861+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:17.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:17.871+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:17.871+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:17.871+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:17.871+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:17.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:17.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.871+0200 I/utils   (21185): specific action
04-23 16:00:17.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.871+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.871+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:17.871+0200 I/recorder(21185): guardando datos en local
04-23 16:00:17.871+0200 W/AUL     (21549): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:17.871+0200 I/location(21549): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:17.871+0200 W/CAPI_APPFW_APP_CONTROL(21549): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:17.871+0200 I/utils   (21549): specific action
04-23 16:00:17.881+0200 W/AUL     (21558): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 16:00:17.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:17.881+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:17.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21508
04-23 16:00:17.881+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:17.881+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21508
04-23 16:00:17.881+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21508)
04-23 16:00:17.921+0200 I/LOCATION(21549): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:17.991+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:17.991+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:18.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:00:18.051+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:00:18.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:18.051+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:00:18.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:00:18.051+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:00:18.051+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:00:18.061+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:18.061+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:00:18.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:18.111+0200 W/AUL     (21564): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:00:18.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:18.111+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:18.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21533
04-23 16:00:18.111+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:18.111+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21533
04-23 16:00:18.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21533)
04-23 16:00:18.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:18.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:18.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:18.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7376080
04-23 16:00:18.151+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11215496c6f63152449201
