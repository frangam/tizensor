S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15193
Date: 2018-04-23 19:28:37+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf717252d, r5   = 0xf77bef98
r6   = 0xffa65b00, r7   = 0xffa659b0
r8   = 0xf77bbc18, r9   = 0x00000000
r10  = 0xffa65a8c, fp   = 0xffa65b00
ip   = 0x00000001, sp   = 0xffa65988
lr   = 0xf7172539, pc   = 0xf71db228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     15412 KB
Buffers:     52564 KB
Cached:     234404 KB
VmPeak:      53524 KB
VmSize:      53520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11892 KB
VmRSS:       11892 KB
VmData:      11248 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15193 TID = 15193
15193 15233 

Maps Information
f403d000 f483c000 rw-p [stack:15233]
f4843000 f4845000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f484d000 f4851000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f485a000 f485c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4864000 f4867000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4876000 f487b000 r-xp /usr/lib/libsystem.so.0.0.0
f4886000 f4889000 r-xp /lib/libattr.so.1.1.0
f4891000 f48a1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48a9000 f48b2000 r-xp /usr/lib/libedbus.so.1.7.99
f48ba000 f48bb000 r-xp /usr/lib/libresponse.so.0.2.96
f48c4000 f48c9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f616b000 f6271000 r-xp /usr/lib/libicuuc.so.57.1
f6287000 f640f000 r-xp /usr/lib/libicui18n.so.57.1
f641f000 f642c000 r-xp /usr/lib/libail.so.0.1.0
f6435000 f643c000 r-xp /usr/lib/libminizip.so.1.0.0
f6445000 f65ee000 r-xp /usr/lib/libcrypto.so.1.0.0
f660e000 f6655000 r-xp /usr/lib/libssl.so.1.0.0
f6661000 f6663000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f666b000 f6672000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f667b000 f6682000 r-xp /lib/libcrypt-2.13.so
f66b3000 f66b6000 r-xp /lib/libcap.so.2.21
f66be000 f66c0000 r-xp /usr/lib/libiri.so
f66c8000 f6711000 r-xp /usr/lib/libmdm.so.1.2.69
f6719000 f671f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6727000 f674a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6754000 f6756000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f675e000 f677b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6784000 f6788000 r-xp /usr/lib/libsmack.so.1.0.0
f6791000 f67aa000 r-xp /usr/lib/libnetwork.so.0.0.0
f67b3000 f67bb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67c3000 f67c9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67d2000 f67d4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67dd000 f67ed000 r-xp /lib/libresolv-2.13.so
f67f1000 f6809000 r-xp /usr/lib/liblzma.so.5.0.3
f6812000 f6814000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f681c000 f6836000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f683e000 f686d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6876000 f6885000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f688f000 f6899000 r-xp /usr/lib/libsensord-shared.so
f68a2000 f6975000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6980000 f6996000 r-xp /lib/libz.so.1.2.5
f699e000 f69a3000 r-xp /usr/lib/libffi.so.5.0.10
f69ab000 f69ac000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69b4000 f69c4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69cc000 f69e5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69ed000 f69ef000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69f7000 f6a6c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a76000 f6a7c000 r-xp /lib/librt-2.13.so
f6a85000 f6aa3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aad000 f6aae000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ab6000 f6ad9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ae1000 f6ae6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aee000 f6b18000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b21000 f6b38000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b40000 f6ba9000 r-xp /lib/libm-2.13.so
f6bb2000 f6c46000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c59000 f6c5e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c66000 f6c6d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c75000 f6c9f000 r-xp /usr/lib/libsensor.so.1.9.6
f6ca8000 f6d74000 r-xp /usr/lib/libxml2.so.2.7.8
f6d81000 f6d83000 r-xp /usr/lib/libiniparser.so.0
f6d8c000 f6d92000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d9b000 f6e6b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e6c000 f6ea0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ea9000 f6ee5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6eed000 f6ef0000 r-xp /usr/lib/libbundle.so.0.1.22
f6ef8000 f6efe000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f06000 f6f47000 r-xp /usr/lib/libeina.so.1.7.99
f6f50000 f6f67000 r-xp /usr/lib/libecore.so.1.7.99
f6f7e000 f6f87000 r-xp /usr/lib/libvconf.so.0.2.45
f6f8f000 f6fa3000 r-xp /lib/libpthread-2.13.so
f6fae000 f6fbb000 r-xp /usr/lib/libaul.so.0.1.0
f6fc5000 f6fc7000 r-xp /lib/libdl-2.13.so
f6fd0000 f6fdb000 r-xp /lib/libunwind.so.8.0.1
f7008000 f7010000 r-xp /lib/libgcc_s-4.6.so.1
f7011000 f7135000 r-xp /lib/libc-2.13.so
f7143000 f7145000 r-xp /usr/lib/libdlog.so.0.0.0
f714d000 f7159000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7162000 f7167000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f716f000 f717e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7186000 f718a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7193000 f7196000 r-xp /usr/lib/libappcore-agent.so.1.1
f719e000 f71a0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71a8000 f71ac000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71b4000 f71d1000 r-xp /lib/ld-2.13.so
f71da000 f71dd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71dd000 f71e1000 r-xp /usr/lib/libsys-assert.so
f778b000 f780e000 rw-p [heap]
ffa47000 ffa68000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15193)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71db228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7172539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e793f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e77c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e83e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e89be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e89dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ebe75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6eb91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e77c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e83e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e89be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e89dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ebbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ebc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ec3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf485b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf484e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6921663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6dcefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dd07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f60ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f5bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f5c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f5c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7194183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71947fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71db4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf702885c) [/lib/libc.so.6] + 0x1785c
29: (0xf71daf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
reated
04-23 19:28:32.509+0200 W/CAPI_APPFW_APP_CONTROL(15150): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.519+0200 I/utils   (15150): specific action
04-23 19:28:32.519+0200 W/CAPI_APPFW_APP_CONTROL(15150): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.519+0200 W/CAPI_APPFW_APP_CONTROL(15150): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.519+0200 W/CAPI_APPFW_APP_CONTROL(15150): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.519+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 19:28:32.519+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:28:32.519+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15150
04-23 19:28:32.529+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15156
04-23 19:28:32.529+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:32.539+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15156
04-23 19:28:32.539+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:32.549+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15156
04-23 19:28:32.549+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:32.549+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:32.559+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:28:32.559+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(15156), cmd(0)
04-23 19:28:32.559+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15156)
04-23 19:28:32.559+0200 I/servicemanager(15150): request sent to service es.ugr.frailty.recorder
04-23 19:28:32.559+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.559+0200 I/utils   (15156): specific action
04-23 19:28:32.559+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.559+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.559+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.559+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.559+0200 I/servicemanager(15150): requesting to save local data
04-23 19:28:32.569+0200 W/libgps_d( 3158): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 19:28:32.569+0200 W/libgps  ( 3158): [proxy__gps_stop][line = 1067]: called.
04-23 19:28:32.569+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:32.569+0200 W/libgps_d( 3158): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 19:28:32.569+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 19:28:32.569+0200 W/libgps_d( 3158): GpsiHookStateGps              : EXIT
04-23 19:28:32.569+0200 W/libgps_d( 3158): GpsiHookStateIdle             : ENTRY
04-23 19:28:32.569+0200 E/CAPI_LOCATION_MANAGER(14323): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:28:32.579+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:2
04-23 19:28:32.589+0200 I/recorder(15156): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 19:28:32.589+0200 I/recorder(15156): guardando datos en local
04-23 19:28:32.629+0200 I/CAPI_NETWORK_CONNECTION(15153): connection.c: connection_create(453) > New handle created[0xf730e3d8]
04-23 19:28:32.629+0200 I/httppostreq(15153): internet creating connection
04-23 19:28:32.629+0200 W/CAPI_APPFW_APP_CONTROL(15153): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.629+0200 I/utils   (15153): specific action
04-23 19:28:32.629+0200 W/CAPI_APPFW_APP_CONTROL(15153): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.629+0200 W/CAPI_APPFW_APP_CONTROL(15153): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.629+0200 W/CAPI_APPFW_APP_CONTROL(15153): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.639+0200 W/CAPI_APPFW_APP_CONTROL(15153): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.639+0200 W/CAPI_APPFW_APP_CONTROL(15153): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.639+0200 W/CAPI_APPFW_APP_CONTROL(15153): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.639+0200 W/CAPI_APPFW_APP_CONTROL(15153): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:32.659+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:28:32.659+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:28:32.659+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:28:32.679+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:32.729+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 19:28:32.729+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 19:28:32.729+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 19:28:32.729+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: connection_destroy(471) > Destroy handle: 0xf42006c8
04-23 19:28:32.769+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: connection_create(453) > New handle created[0xf4216ce8]
04-23 19:28:32.769+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 19:28:32.769+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 19:28:32.769+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 19:28:32.769+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: connection_get_type(507) > Connected Network = 2
04-23 19:28:32.779+0200 W/LOCATION(14323): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:28:32.779+0200 W/LOCATION(14323): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:28:32.789+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:32.789+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:32.789+0200 E/LOCATION(14323): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 19:28:32.789+0200 I/LOCATION(14323): location.c: location_new(269) > method: 1
04-23 19:28:32.789+0200 W/LOCATION(14323): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:28:32.789+0200 W/LOCATION(14323): module-internal.c: module_new(311) > module (gps) open success
04-23 19:28:32.789+0200 W/LOCATION(14323): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:28:32.789+0200 W/LOCATION(14323): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:28:32.789+0200 W/LOCATION(14323): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:28:32.789+0200 W/LOCATION(14323): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:28:32.789+0200 W/LOCATION(14323): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:28:32.799+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:32.809+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:32.809+0200 E/LOCATION(14323): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:28:32.809+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:32.829+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:28:32.919+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:32.979+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:28:32.989+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:28:32.999+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:33.039+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 19:28:33.039+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 19:28:33.039+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 19:28:33.039+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: connection_destroy(471) > Destroy handle: 0xf4216ce8
04-23 19:28:33.089+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: connection_create(453) > New handle created[0xf7afa928]
04-23 19:28:33.089+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 19:28:33.089+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 19:28:33.089+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 19:28:33.089+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: connection_get_type(507) > Connected Network = 2
04-23 19:28:33.099+0200 W/LOCATION(14323): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:28:33.099+0200 W/LOCATION(14323): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:28:33.099+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:33.109+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:33.109+0200 E/LOCATION(14323): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 19:28:33.109+0200 I/LOCATION(14323): location.c: location_new(269) > method: 1
04-23 19:28:33.109+0200 W/LOCATION(14323): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:28:33.109+0200 W/LOCATION(14323): module-internal.c: module_new(311) > module (gps) open success
04-23 19:28:33.109+0200 W/LOCATION(14323): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:28:33.109+0200 W/LOCATION(14323): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:28:33.109+0200 W/LOCATION(14323): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:28:33.109+0200 W/LOCATION(14323): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:28:33.109+0200 W/LOCATION(14323): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:28:33.119+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:33.119+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:28:33.119+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:33.119+0200 E/LOCATION(14323): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:28:33.129+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:33.169+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:33.169+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 19:28:33.169+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 19:28:33.169+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 19:28:33.169+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: connection_destroy(471) > Destroy handle: 0xf7afa928
04-23 19:28:33.319+0200 W/AUL     (15164): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 19:28:33.319+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 19:28:33.329+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 19:28:33.329+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 14601
04-23 19:28:33.329+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 19:28:33.339+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14601
04-23 19:28:33.339+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14601)
04-23 19:28:34.389+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:28:34.509+0200 I/servicemanager(15150): es.ugr.frailty.accelerometer alive timeout
04-23 19:28:34.509+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 19:28:34.509+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:28:34.519+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15150
04-23 19:28:34.539+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15165
04-23 19:28:34.539+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:28:34.589+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15165
04-23 19:28:34.589+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(15165) type(svcapp) bg(0)
04-23 19:28:34.599+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15165]
04-23 19:28:34.619+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15165)
04-23 19:28:34.619+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:34.629+0200 E/CAPI_APPFW_APPLICATION(15165): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.629+0200 E/CAPI_APPFW_APPLICATION(15165): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.629+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15165
04-23 19:28:34.629+0200 I/utils   (15165): trying to start service: es.ugr.frailty.accelerometer
04-23 19:28:34.639+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15165) was created
04-23 19:28:34.639+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:34.639+0200 I/utils   (15165): es.ugr.frailty.accelerometer sensor supported
04-23 19:28:34.639+0200 I/servicemanager(15150): es.ugr.frailty.accelerometer launch request sent!
04-23 19:28:34.639+0200 I/servicemanager(15150): App control destroyed.
04-23 19:28:34.639+0200 I/servicemanager(15150): es.ugr.frailty.gyroscope alive timeout
04-23 19:28:34.639+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 19:28:34.649+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:28:34.649+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15150
04-23 19:28:34.659+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15176
04-23 19:28:34.659+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:28:34.669+0200 I/utils   (15165): es.ugr.frailty.accelerometer listener started
04-23 19:28:34.669+0200 W/CAPI_APPFW_APP_CONTROL(15165): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:34.669+0200 I/utils   (15165): specific action
04-23 19:28:34.709+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15176
04-23 19:28:34.709+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(15176) type(svcapp) bg(0)
04-23 19:28:34.709+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:34.719+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15176]
04-23 19:28:34.719+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15165
04-23 19:28:34.719+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15176)
04-23 19:28:34.719+0200 I/servicemanager(15150): es.ugr.frailty.gyroscope launch request sent!
04-23 19:28:34.719+0200 I/servicemanager(15150): App control destroyed.
04-23 19:28:34.719+0200 I/servicemanager(15150): es.ugr.frailty.heartrate alive timeout
04-23 19:28:34.719+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 19:28:34.719+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:28:34.719+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15150
04-23 19:28:34.739+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15180
04-23 19:28:34.739+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:28:34.739+0200 E/CAPI_APPFW_APPLICATION(15176): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.739+0200 E/CAPI_APPFW_APPLICATION(15176): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.739+0200 I/utils   (15176): trying to start service: es.ugr.frailty.gyroscope
04-23 19:28:34.739+0200 I/utils   (15176): es.ugr.frailty.gyroscope sensor supported
04-23 19:28:34.759+0200 I/utils   (15176): es.ugr.frailty.gyroscope listener started
04-23 19:28:34.759+0200 W/CAPI_APPFW_APP_CONTROL(15176): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:34.759+0200 I/utils   (15176): specific action
04-23 19:28:34.789+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15180
04-23 19:28:34.789+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(15180) type(svcapp) bg(0)
04-23 19:28:34.789+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:34.789+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15180]
04-23 19:28:34.799+0200 E/CAPI_APPFW_APPLICATION(15180): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.799+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15176
04-23 19:28:34.799+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15176) was created
04-23 19:28:34.799+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:34.799+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:34.799+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15180)
04-23 19:28:34.799+0200 I/servicemanager(15150): es.ugr.frailty.heartrate launch request sent!
04-23 19:28:34.799+0200 I/servicemanager(15150): App control destroyed.
04-23 19:28:34.799+0200 I/servicemanager(15150): es.ugr.frailty.location alive timeout
04-23 19:28:34.799+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:28:34.799+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:28:34.799+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15150
04-23 19:28:34.819+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15193
04-23 19:28:34.819+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:28:34.839+0200 E/CAPI_APPFW_APPLICATION(15180): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.839+0200 I/utils   (15180): trying to start service: es.ugr.frailty.heartrate
04-23 19:28:34.849+0200 I/utils   (15180): es.ugr.frailty.heartrate sensor supported
04-23 19:28:34.849+0200 I/utils   (15180): es.ugr.frailty.heartrate listener started
04-23 19:28:34.849+0200 W/CAPI_APPFW_APP_CONTROL(15180): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:34.849+0200 I/utils   (15180): specific action
04-23 19:28:34.869+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15193
04-23 19:28:34.869+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(15193) type(svcapp) bg(0)
04-23 19:28:34.869+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:34.869+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15193)
04-23 19:28:34.869+0200 I/servicemanager(15150): es.ugr.frailty.location launch request sent!
04-23 19:28:34.869+0200 I/servicemanager(15150): App control destroyed.
04-23 19:28:34.869+0200 I/servicemanager(15150): es.ugr.frailty.linearacceleration alive timeout
04-23 19:28:34.869+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
04-23 19:28:34.879+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15180
04-23 19:28:34.879+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15180) was created
04-23 19:28:34.879+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:34.889+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15176
04-23 19:28:34.889+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:28:34.889+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15150
04-23 19:28:34.899+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15204
04-23 19:28:34.899+0200 E/CAPI_APPFW_APPLICATION(15193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.899+0200 E/CAPI_APPFW_APPLICATION(15193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.919+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15193]
04-23 19:28:34.929+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:28:34.929+0200 W/LOCATION(15193): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 19:28:34.929+0200 E/LOCATION(15193): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 19:28:34.929+0200 E/PKGMGR_INFO(15193): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 19:28:34.939+0200 W/LOCATION(15193): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:28:34.949+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15204
04-23 19:28:34.949+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.linearacceleration) pid(15204) type(svcapp) bg(0)
04-23 19:28:34.949+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:34.949+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15193) was created
04-23 19:28:34.949+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:34.949+0200 I/LOCATION(15193): location.c: location_new(269) > method: 0
04-23 19:28:34.949+0200 W/LOCATION(15193): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:28:34.959+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15204]
04-23 19:28:34.959+0200 W/LOCATION(15193): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:28:34.959+0200 W/LOCATION(15193): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:28:34.969+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15204)
04-23 19:28:34.969+0200 I/servicemanager(15150): es.ugr.frailty.linearacceleration launch request sent!
04-23 19:28:34.969+0200 I/servicemanager(15150): App control destroyed.
04-23 19:28:34.969+0200 I/servicemanager(15150): es.ugr.frailty.gravity alive timeout
04-23 19:28:34.969+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 19:28:34.969+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:28:34.969+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15150
04-23 19:28:34.979+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15207
04-23 19:28:34.979+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:28:34.999+0200 E/CAPI_APPFW_APPLICATION(15204): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.999+0200 E/CAPI_APPFW_APPLICATION(15204): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:34.999+0200 I/utils   (15204): trying to start service: es.ugr.frailty.linearacceleration
04-23 19:28:34.999+0200 I/utils   (15204): es.ugr.frailty.linearacceleration sensor supported
04-23 19:28:35.009+0200 I/utils   (15204): es.ugr.frailty.linearacceleration listener started
04-23 19:28:35.009+0200 W/CAPI_APPFW_APP_CONTROL(15204): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.009+0200 I/utils   (15204): specific action
04-23 19:28:35.019+0200 E/CAPI_APPFW_APPLICATION(15207): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:35.019+0200 E/CAPI_APPFW_APPLICATION(15207): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:28:35.019+0200 I/utils   (15207): trying to start service: es.ugr.frailty.gravity
04-23 19:28:35.019+0200 W/LOCATION(15193): module-internal.c: module_new(311) > module (gps) open success
04-23 19:28:35.029+0200 W/LOCATION(15193): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:28:35.029+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15207
04-23 19:28:35.029+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(15207) type(svcapp) bg(0)
04-23 19:28:35.029+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:35.039+0200 I/utils   (15207): es.ugr.frailty.gravity sensor supported
04-23 19:28:35.039+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15193
04-23 19:28:35.039+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15204) was created
04-23 19:28:35.039+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15207) was created
04-23 19:28:35.039+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:35.049+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15180
04-23 19:28:35.049+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:35.059+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15207]
04-23 19:28:35.059+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15207)
04-23 19:28:35.059+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:35.059+0200 I/servicemanager(15150): es.ugr.frailty.gravity launch request sent!
04-23 19:28:35.059+0200 I/servicemanager(15150): App control destroyed.
04-23 19:28:35.069+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:35.069+0200 I/utils   (15207): es.ugr.frailty.gravity listener started
04-23 19:28:35.069+0200 W/CAPI_APPFW_APP_CONTROL(15207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.069+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15204
04-23 19:28:35.069+0200 I/utils   (15207): specific action
04-23 19:28:35.069+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:35.079+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:35.089+0200 W/LOCATION(15193): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:28:35.089+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15193
04-23 19:28:35.099+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:35.099+0200 W/LOCATION(15193): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:28:35.099+0200 W/LOCATION(15193): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:28:35.099+0200 W/LOCATION(15193): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:28:35.109+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15207
04-23 19:28:35.109+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:35.109+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:35.129+0200 W/LOCATION(15193): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:28:35.129+0200 W/LOCATION(15193): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:28:35.139+0200 W/LOCATION(15193): module-internal.c: module_new(311) > module (wps) open success
04-23 19:28:35.139+0200 W/LOCATION(15193): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 19:28:35.139+0200 W/LOCATION(15193): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 19:28:35.139+0200 W/LOCATION(15193): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:28:35.139+0200 W/LOCATION(15193): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:28:35.159+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:35.159+0200 W/LOCATION(15193): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 19:28:35.159+0200 I/LOCATION(15193): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77bbc18
04-23 19:28:35.159+0200 I/LOCATION(15193): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 19:28:35.159+0200 I/LOCATION(15193): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77bbc18
04-23 19:28:35.159+0200 I/LOCATION(15193): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 19:28:35.169+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15204
04-23 19:28:35.169+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:35.169+0200 I/location(15193): es.ugr.frailty.location: creado servicio de localización
04-23 19:28:35.179+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:28:35.189+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15207
04-23 19:28:35.189+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:28:35.219+0200 I/LOCATION(15193): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 19:28:35.259+0200 W/LOCATION(15193): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:28:35.259+0200 W/LOCATION(15193): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:28:35.259+0200 I/LOCATION(15193): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:28:35.319+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:26
04-23 19:28:35.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 19:28:35.319+0200 D/gpsd_d  ( 3126): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 19:28:35.319+0200 W/libgps  ( 3158): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 19:28:35.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 19:28:35.319+0200 W/libgps_d( 3158): GpsiHookStateIdle             : EXIT
04-23 19:28:35.319+0200 W/libgps_d( 3158): GpsiHookStateGps              : ENTRY
04-23 19:28:35.319+0200 W/libgps  ( 3158): [proxy__gps_start][line = 1022]: called.
04-23 19:28:35.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:35.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:35.319+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:27
04-23 19:28:35.319+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:8
04-23 19:28:35.319+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:1
04-23 19:28:35.319+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 19:28:35.319+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(11), data(0xf7672238), size(4)
04-23 19:28:35.319+0200 W/libgps_d( 3158): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 19:28:35.319+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 19:28:35.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 19:28:35.359+0200 W/LOCATION(15193): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:28:35.359+0200 W/LOCATION(15193): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:28:35.429+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:35.469+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: connection_create(453) > New handle created[0xf7af2190]
04-23 19:28:35.469+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 19:28:35.469+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 19:28:35.469+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 19:28:35.469+0200 I/CAPI_NETWORK_CONNECTION(14323): connection.c: connection_get_type(507) > Connected Network = 2
04-23 19:28:35.479+0200 W/LOCATION(14323): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:28:35.479+0200 W/LOCATION(14323): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:28:35.489+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:35.499+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:35.499+0200 E/LOCATION(14323): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 19:28:35.499+0200 I/LOCATION(14323): location.c: location_new(269) > method: 1
04-23 19:28:35.499+0200 W/LOCATION(14323): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:28:35.499+0200 W/LOCATION(14323): module-internal.c: module_new(311) > module (gps) open success
04-23 19:28:35.499+0200 W/LOCATION(14323): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:28:35.499+0200 W/LOCATION(14323): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:28:35.499+0200 W/LOCATION(14323): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:28:35.499+0200 W/LOCATION(14323): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:28:35.499+0200 W/LOCATION(14323): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:28:35.509+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:35.509+0200 I/AUL     (14323): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:28:35.509+0200 E/LOCATION(14323): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:28:35.519+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:35.549+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 19:28:35.549+0200 W/libgps  ( 3158): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2175833), time2(2089756)
04-23 19:28:35.549+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 19:28:35.549+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 19:28:35.549+0200 I/libgps_d( 3158): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 19:28:35.549+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:25
04-23 19:28:35.569+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:35.609+0200 W/LOCATION(15193): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 19:28:35.609+0200 I/LOCATION(15193): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 19:28:35.609+0200 I/LOCATION(15193): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 19:28:35.609+0200 I/location(15193): es.ugr.frailty.location:iniciado servicio de localización
04-23 19:28:35.729+0200 I/LOCATION(15193): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:28:35.789+0200 E/location(15193): es.ugr.frailty.location: error intentando obtener la última localización
04-23 19:28:35.789+0200 W/AUL     (15193): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 19:28:35.789+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:28:35.789+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15193
04-23 19:28:35.799+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15150
04-23 19:28:35.799+0200 W/CAPI_APPFW_APP_CONTROL(15150): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.799+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:28:35.799+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(15150), cmd(0)
04-23 19:28:35.799+0200 W/AUL     (15193): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15150)
04-23 19:28:35.799+0200 I/location(15193): request sent to service es.ugr.frailty.servicemanager
04-23 19:28:35.799+0200 W/CAPI_APPFW_APP_CONTROL(15193): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.799+0200 I/utils   (15193): specific action
04-23 19:28:35.799+0200 I/utils   (15150): specific action
04-23 19:28:35.799+0200 W/CAPI_APPFW_APP_CONTROL(15150): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.799+0200 W/CAPI_APPFW_APP_CONTROL(15150): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.799+0200 W/CAPI_APPFW_APP_CONTROL(15150): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.799+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 19:28:35.799+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:28:35.799+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15150
04-23 19:28:35.809+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15156
04-23 19:28:35.819+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:28:35.819+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(15156), cmd(0)
04-23 19:28:35.819+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.819+0200 I/utils   (15156): specific action
04-23 19:28:35.819+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.819+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.819+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.819+0200 W/CAPI_APPFW_APP_CONTROL(15156): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:28:35.819+0200 I/recorder(15156): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 19:28:35.819+0200 I/recorder(15156): guardando datos en local
04-23 19:28:35.819+0200 W/AUL     (15150): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15156)
04-23 19:28:35.819+0200 I/servicemanager(15150): request sent to service es.ugr.frailty.recorder
04-23 19:28:35.819+0200 I/servicemanager(15150): requesting to save local data
04-23 19:28:35.819+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:28:35.819+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:35.819+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:28:36.609+0200 E/CAPI_TELEPHONY(14323): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:28:36.609+0200 I/APP_CORE( 2773): appcore-efl.c: __do_app(453) > [APP 2773] Event: MEM_FLUSH State: PAUSED
04-23 19:28:36.769+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:28:36.769+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:36.769+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:28:36.809+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:28:36.809+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:36.809+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:28:37.359+0200 W/LOCATION(15193): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:28:37.599+0200 W/libgps_d( 3158): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 19:28:37.599+0200 W/libgps  ( 3158): [proxy__gps_stop][line = 1067]: called.
04-23 19:28:37.599+0200 W/AUL     (15243): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 19:28:37.599+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:28:37.599+0200 W/libgps_d( 3158): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 19:28:37.599+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 19:28:37.599+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 19:28:37.599+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 19:28:37.599+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 14649
04-23 19:28:37.599+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 19:28:37.599+0200 W/libgps_d( 3158): GpsiHookStateGps              : EXIT
04-23 19:28:37.599+0200 W/libgps_d( 3158): GpsiHookStateIdle             : ENTRY
04-23 19:28:37.599+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:2
04-23 19:28:37.599+0200 E/CAPI_LOCATION_MANAGER(14323): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:28:37.609+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14649
04-23 19:28:37.609+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14649)
04-23 19:28:37.619+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:28:37.659+0200 W/CRASH_MANAGER(15241): worker.c: worker_job(1205) > 11151936c6f63152450451
