S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22076
Date: 2018-04-23 16:01:04+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75ec52d, r5   = 0xf76ac958
r6   = 0xffb400f8, r7   = 0xffb3ffa8
r8   = 0xf76bfc18, r9   = 0x00000000
r10  = 0xffb40084, fp   = 0xffb400f8
ip   = 0x00000001, sp   = 0xffb3ee28
lr   = 0xf75ec539, pc   = 0xf76552b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10748 KB
Buffers:     59944 KB
Cached:     232276 KB
VmPeak:      53548 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12012 KB
VmRSS:       12012 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22076 TID = 22076
22076 22079 

Maps Information
f44b7000 f4cb6000 rw-p [stack:22079]
f4cbd000 f4cbf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cc7000 f4ccb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cd4000 f4cd6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cde000 f4ce1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cf0000 f4cf5000 r-xp /usr/lib/libsystem.so.0.0.0
f4d00000 f4d03000 r-xp /lib/libattr.so.1.1.0
f4d0b000 f4d1b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d23000 f4d2c000 r-xp /usr/lib/libedbus.so.1.7.99
f4d34000 f4d35000 r-xp /usr/lib/libresponse.so.0.2.96
f4d3e000 f4d43000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65e5000 f66eb000 r-xp /usr/lib/libicuuc.so.57.1
f6701000 f6889000 r-xp /usr/lib/libicui18n.so.57.1
f6899000 f68a6000 r-xp /usr/lib/libail.so.0.1.0
f68af000 f68b6000 r-xp /usr/lib/libminizip.so.1.0.0
f68bf000 f6a68000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a88000 f6acf000 r-xp /usr/lib/libssl.so.1.0.0
f6adb000 f6add000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ae5000 f6aec000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6af5000 f6afc000 r-xp /lib/libcrypt-2.13.so
f6b2d000 f6b30000 r-xp /lib/libcap.so.2.21
f6b38000 f6b3a000 r-xp /usr/lib/libiri.so
f6b42000 f6b8b000 r-xp /usr/lib/libmdm.so.1.2.69
f6b93000 f6b99000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ba1000 f6bc4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bce000 f6bd0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bd8000 f6bf5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bfe000 f6c02000 r-xp /usr/lib/libsmack.so.1.0.0
f6c0b000 f6c24000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c2d000 f6c35000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c3d000 f6c43000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c4c000 f6c4e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c57000 f6c67000 r-xp /lib/libresolv-2.13.so
f6c6b000 f6c83000 r-xp /usr/lib/liblzma.so.5.0.3
f6c8c000 f6c8e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c96000 f6cb0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cb8000 f6ce7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cf0000 f6cff000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d09000 f6d13000 r-xp /usr/lib/libsensord-shared.so
f6d1c000 f6def000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dfa000 f6e10000 r-xp /lib/libz.so.1.2.5
f6e18000 f6e1d000 r-xp /usr/lib/libffi.so.5.0.10
f6e25000 f6e26000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e2e000 f6e3e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e46000 f6e5f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e67000 f6e69000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e71000 f6ee6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ef0000 f6ef6000 r-xp /lib/librt-2.13.so
f6eff000 f6f1d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f27000 f6f28000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f30000 f6f53000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f5b000 f6f60000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f68000 f6f92000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f9b000 f6fb2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fba000 f7023000 r-xp /lib/libm-2.13.so
f702c000 f70c0000 r-xp /usr/lib/libstdc++.so.6.0.16
f70d3000 f70d8000 r-xp /usr/lib/libctx-client.so.0.8.3
f70e0000 f70e7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70ef000 f7119000 r-xp /usr/lib/libsensor.so.1.9.6
f7122000 f71ee000 r-xp /usr/lib/libxml2.so.2.7.8
f71fb000 f71fd000 r-xp /usr/lib/libiniparser.so.0
f7206000 f720c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7215000 f72e5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72e6000 f731a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7323000 f735f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7367000 f736a000 r-xp /usr/lib/libbundle.so.0.1.22
f7372000 f7378000 r-xp /usr/lib/libappsvc.so.0.1.0
f7380000 f73c1000 r-xp /usr/lib/libeina.so.1.7.99
f73ca000 f73e1000 r-xp /usr/lib/libecore.so.1.7.99
f73f8000 f7401000 r-xp /usr/lib/libvconf.so.0.2.45
f7409000 f741d000 r-xp /lib/libpthread-2.13.so
f7428000 f7435000 r-xp /usr/lib/libaul.so.0.1.0
f743f000 f7441000 r-xp /lib/libdl-2.13.so
f744a000 f7455000 r-xp /lib/libunwind.so.8.0.1
f7482000 f748a000 r-xp /lib/libgcc_s-4.6.so.1
f748b000 f75af000 r-xp /lib/libc-2.13.so
f75bd000 f75bf000 r-xp /usr/lib/libdlog.so.0.0.0
f75c7000 f75d3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75dc000 f75e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75e9000 f75f8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7600000 f7604000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f760d000 f7610000 r-xp /usr/lib/libappcore-agent.so.1.1
f7618000 f761a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7622000 f7626000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f762e000 f764b000 r-xp /lib/ld-2.13.so
f7654000 f7657000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7657000 f765b000 r-xp /usr/lib/libsys-assert.so
f768f000 f7718000 rw-p [heap]
ffb21000 ffb42000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22076)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf76552b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf75ec539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72f33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72f1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72fde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7303be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7303dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf733875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73331f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72f1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72fde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7303be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7303dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7335e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7336017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf733a8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf76240bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4cc8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d9b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7248fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf724a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73daca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73d5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73d65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73d6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf760e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf760e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76556a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf74a285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7654fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
rror(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.221+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.221+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.221+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.221+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.221+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.221+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:10.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:10.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:10.221+0200 W/LOCATION(22197): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:10.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:10.231+0200 W/LOCATION(22197): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:10.231+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:10.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:10.231+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.231+0200 I/utils   (21185): specific action
04-23 16:01:10.231+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.231+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.231+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.231+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.231+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.231+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 16:01:10.231+0200 W/AUL     (21185): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:10.231+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:10.231+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:10.231+0200 I/servicemanager(19708): eliminar datos locales
04-23 16:01:10.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:10.231+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21185
04-23 16:01:10.241+0200 W/LOCATION(22197): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:10.241+0200 W/AUL     (19711): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:10.241+0200 W/LOCATION(22197): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:10.241+0200 W/LOCATION(22197): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:10.241+0200 W/LOCATION(22197): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:10.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:10.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:10.251+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19711
04-23 16:01:10.251+0200 W/AUL     (21185): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:10.251+0200 I/recorder(21185): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:10.251+0200 I/recorder(21185): eliminando datos en local
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 I/utils   (19708): specific action
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.251+0200 I/servicemanager(19708): launch es.ugr.frailty.gyroscope
04-23 16:01:10.251+0200 I/servicemanager(19708): re launch service
04-23 16:01:10.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/AUL     (19711): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:10.261+0200 I/httppostreq(19711): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:10.261+0200 I/httppostreq(19711): requesting HTTP POST Request Service
04-23 16:01:10.261+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:10.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:10.261+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:10.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(19708), cmd(0)
04-23 16:01:10.261+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:10.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19711), cmd(0)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 I/utils   (19711): specific action
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 I/httppostreq(19711): requesting HTTP POST Request Service. Service ID: es.ugr.frailty.location Data received: SM-R760,23/04/2018,16:00:10:919,756.721665,37.171497,-3.593249,0.000000,0,0.000000,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:13:418,756.721665,37.171497,-3.593249,0.000000,0,0.000000,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:17:819,747.700900,37.171647,-3.593368,0.000000,13.5846,2.600955,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:19:944,747.700900,37.171647,-3.593368,0.000000,13.5846,2.600955,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:22:656,747.700900,37.171647,-3.593368,0.000000,13.5846,2.600955,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:26:1,747.700900,37.171647,-3.593368,0.000000,13.5846,2.600955,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:28:266,753.338748,37.171577,-3.593224,0.000000,0,0.000000,8.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:30:258,752.802489,37.171581,-3.593241,0.000000,0,0.000000,8.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:33:126,752.581390,37.171573,-3.593268,0.000000,0,0.000000,6.00000
04-23 16:01:10.261+0200 I/httppostreq(19711): HTTP POST data service=es.ugr.frailty.location&data=SM-R760,23/04/2018,16:00:10:919,756.721665,37.171497,-3.593249,0.000000,0,0.000000,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:13:418,756.721665,37.171497,-3.593249,0.000000,0,0.000000,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:17:819,747.700900,37.171647,-3.593368,0.000000,13.5846,2.600955,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:19:944,747.700900,37.171647,-3.593368,0.000000,13.5846,2.600955,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:22:656,747.700900,37.171647,-3.593368,0.000000,13.5846,2.600955,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:26:1,747.700900,37.171647,-3.593368,0.000000,13.5846,2.600955,16.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:28:266,753.338748,37.171577,-3.593224,0.000000,0,0.000000,8.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:30:258,752.802489,37.171581,-3.593241,0.000000,0,0.000000,8.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:33:126,752.581390,37.171573,-3.593268,0.000000,0,0.000000,6.000000,-1.000000
04-23 16:01:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:00:
04-23 16:01:10.261+0200 I/utils   (19708): specific action
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.261+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:10.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:10.271+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:10.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:10.281+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:10.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:10.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.281+0200 I/utils   (21185): specific action
04-23 16:01:10.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.291+0200 W/AUL     (19711): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:10.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:10.301+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19711
04-23 16:01:10.311+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:10.311+0200 W/AUL     (19711): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:10.311+0200 I/httppostreq(19711): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:10.311+0200 I/httppostreq(19711): requesting HTTP POST Request Service
04-23 16:01:10.311+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.311+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
04-23 16:01:10.311+0200 W/AUL     (21185): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:10.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:10.311+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21185
04-23 16:01:10.321+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:10.321+0200 W/AUL     (21185): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:10.321+0200 I/recorder(21185): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:10.331+0200 I/recorder(21185): eliminando datos en local
04-23 16:01:10.331+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:10.331+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:10.331+0200 I/servicemanager(19708): eliminar datos locales
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 I/utils   (19708): specific action
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.331+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:10.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:10.341+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:10.341+0200 W/AUL     (22206): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 16:01:10.351+0200 W/LOCATION(22197): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:10.351+0200 W/LOCATION(22197): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:10.371+0200 W/LOCATION(22197): module-internal.c: module_new(311) > module (wps) open success
04-23 16:01:10.381+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:10.381+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:10.381+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:10.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:10.381+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:10.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22183
04-23 16:01:10.381+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:10.381+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:10.391+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:10.391+0200 I/servicemanager(19708): eliminar datos locales
04-23 16:01:10.391+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22183
04-23 16:01:10.391+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22183)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 I/utils   (19708): specific action
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:10.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19708), cmd(0)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 I/servicemanager(19708): launch es.ugr.frailty.heartrate
04-23 16:01:10.391+0200 I/servicemanager(19708): re launch service
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 I/utils   (21185): specific action
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:10.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(21185), cmd(0)
04-23 16:01:10.391+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.391+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:10.391+0200 W/AUL     (21185): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:10.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:10.391+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21185
04-23 16:01:10.391+0200 W/LOCATION(22197): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:01:10.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 I/utils   (19708): specific action
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:10.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 W/AUL     (21185): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:10.401+0200 I/recorder(21185): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:10.401+0200 I/recorder(21185): eliminando datos en local
04-23 16:01:10.401+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:10.401+0200 I/servicemanager(19708): launch es.ugr.frailty.location
04-23 16:01:10.401+0200 I/servicemanager(19708): re launch service
04-23 16:01:10.411+0200 W/LOCATION(22197): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:01:10.411+0200 W/LOCATION(22197): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:10.411+0200 W/LOCATION(22197): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:10.441+0200 W/LOCATION(22197): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:01:10.441+0200 I/LOCATION(22197): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf71dcc18
04-23 16:01:10.441+0200 I/LOCATION(22197): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:01:10.441+0200 I/LOCATION(22197): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf71dcc18
04-23 16:01:10.441+0200 I/LOCATION(22197): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:01:10.451+0200 I/location(22197): es.ugr.frailty.location: creado servicio de localización
04-23 16:01:10.511+0200 I/LOCATION(22197): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:01:10.561+0200 W/LOCATION(22197): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:10.561+0200 W/LOCATION(22197): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:10.561+0200 I/LOCATION(22197): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:10.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:10.641+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:10.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:10.651+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:10.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:10.651+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:10.651+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:10.651+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:10.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:10.651+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:10.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:10.651+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:10.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:10.651+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:10.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:10.651+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:10.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:10.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:10.731+0200 W/LOCATION(22197): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:10.731+0200 W/LOCATION(22197): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:10.821+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:10.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73481e8]
04-23 16:01:10.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:10.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:10.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:10.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:10.871+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:10.871+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:10.881+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:10.891+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:10.891+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:10.891+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:10.891+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:10.891+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:10.891+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:10.891+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:10.891+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:10.891+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:10.891+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:10.891+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:10.901+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:10.901+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:10.901+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:10.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:10.921+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5966584), time2(5963542)
04-23 16:01:10.921+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:01:10.921+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:10.921+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:10.921+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:10.951+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:10.991+0200 W/LOCATION(22197): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:10.991+0200 I/LOCATION(22197): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:10.991+0200 I/LOCATION(22197): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:10.991+0200 I/location(22197): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:11.121+0200 I/LOCATION(22197): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:11.181+0200 W/AUL     (22197): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:11.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:11.181+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22197
04-23 16:01:11.191+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:11.191+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:11.191+0200 I/utils   (19708): specific action
04-23 16:01:11.191+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:11.191+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:11.191+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:11.191+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:11.191+0200 W/AUL     (22197): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:11.191+0200 I/location(22197): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:11.191+0200 I/location(22197): stopping es.ugr.frailty.location service
04-23 16:01:11.191+0200 E/CAPI_APPFW_APP_CONTROL(22197): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:01:11.191+0200 E/location(22197): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:01:11.191+0200 I/CAPI_APPFW_APPLICATION(22197): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:11.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:11.201+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:11.211+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:11.211+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:11.211+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:11.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:11.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:11.211+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:11.211+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:11.211+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:11.211+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:11.211+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(21185), cmd(0)
04-23 16:01:11.211+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:11.211+0200 I/utils   (21185): specific action
04-23 16:01:11.211+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:11.211+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:11.211+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:11.211+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:11.211+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:11.211+0200 I/recorder(21185): guardando datos en local
04-23 16:01:11.251+0200 W/LOCATION(22197): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:11.251+0200 I/LOCATION(22197): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:11.251+0200 I/LOCATION(22197): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:11.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:01:11.351+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:01:11.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:11.351+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:01:11.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:01:11.351+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:01:11.351+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:01:11.351+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:01:11.351+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:11.501+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:11.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:11.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:11.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:11.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73481e8
04-23 16:01:11.601+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:11.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18e80]
04-23 16:01:11.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:11.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:11.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:11.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:11.641+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:11.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:11.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:11.661+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:11.661+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:11.661+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:11.661+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:11.661+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:11.661+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:11.661+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:11.661+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:11.661+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:11.661+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:11.671+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:11.681+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:11.681+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:11.681+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:11.721+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:11.721+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:11.721+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:11.731+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:11.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:11.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:11.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:11.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18e80
04-23 16:01:11.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e17d70]
04-23 16:01:11.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:11.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:11.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:11.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:11.841+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:11.841+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:11.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:11.861+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:11.861+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:11.861+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:11.861+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:11.861+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:11.861+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:11.861+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:11.861+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:11.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:11.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:11.871+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:11.881+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:11.881+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:11.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:11.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:11.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:11.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:11.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:11.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e17d70
04-23 16:01:12.041+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11220766c6f63152449206
