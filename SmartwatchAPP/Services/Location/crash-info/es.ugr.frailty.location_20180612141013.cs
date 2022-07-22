S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9923
Date: 2018-06-12 14:10:13+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf730652d, r5   = 0xf761e150
r6   = 0xff8ef1d0, r7   = 0xff8ef080
r8   = 0xf7630c18, r9   = 0x00000000
r10  = 0xff8ef15c, fp   = 0xff8ef1d0
ip   = 0x00000001, sp   = 0xff8ef058
lr   = 0xf7306539, pc   = 0xf736f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    175468 KB
Buffers:     31388 KB
Cached:     142380 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11652 KB
VmRSS:       11652 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9923 TID = 9923
9923 10135 

Maps Information
f41d1000 f49d0000 rw-p [stack:10135]
f49d7000 f49d9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49e1000 f49e5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49ee000 f49f0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49f8000 f49fb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a0a000 f4a0f000 r-xp /usr/lib/libsystem.so.0.0.0
f4a1a000 f4a1d000 r-xp /lib/libattr.so.1.1.0
f4a25000 f4a35000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a3d000 f4a46000 r-xp /usr/lib/libedbus.so.1.7.99
f4a4e000 f4a4f000 r-xp /usr/lib/libresponse.so.0.2.96
f4a58000 f4a5d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62ff000 f6405000 r-xp /usr/lib/libicuuc.so.57.1
f641b000 f65a3000 r-xp /usr/lib/libicui18n.so.57.1
f65b3000 f65c0000 r-xp /usr/lib/libail.so.0.1.0
f65c9000 f65d0000 r-xp /usr/lib/libminizip.so.1.0.0
f65d9000 f6782000 r-xp /usr/lib/libcrypto.so.1.0.0
f67a2000 f67e9000 r-xp /usr/lib/libssl.so.1.0.0
f67f5000 f67f7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67ff000 f6806000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f680f000 f6816000 r-xp /lib/libcrypt-2.13.so
f6847000 f684a000 r-xp /lib/libcap.so.2.21
f6852000 f6854000 r-xp /usr/lib/libiri.so
f685c000 f68a5000 r-xp /usr/lib/libmdm.so.1.2.69
f68ad000 f68b3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68bb000 f68de000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68e8000 f68ea000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68f2000 f690f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6918000 f691c000 r-xp /usr/lib/libsmack.so.1.0.0
f6925000 f693e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6947000 f694f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6957000 f695d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6966000 f6968000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6971000 f6981000 r-xp /lib/libresolv-2.13.so
f6985000 f699d000 r-xp /usr/lib/liblzma.so.5.0.3
f69a6000 f69a8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69b0000 f69ca000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69d2000 f6a01000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a0a000 f6a19000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a23000 f6a2d000 r-xp /usr/lib/libsensord-shared.so
f6a36000 f6b09000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b14000 f6b2a000 r-xp /lib/libz.so.1.2.5
f6b32000 f6b37000 r-xp /usr/lib/libffi.so.5.0.10
f6b3f000 f6b40000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b48000 f6b58000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b60000 f6b79000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b81000 f6b83000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b8b000 f6c00000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c0a000 f6c10000 r-xp /lib/librt-2.13.so
f6c19000 f6c37000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c41000 f6c42000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c4a000 f6c6d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c75000 f6c7a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c82000 f6cac000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cb5000 f6ccc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cd4000 f6d3d000 r-xp /lib/libm-2.13.so
f6d46000 f6dda000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ded000 f6df2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dfa000 f6e01000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e09000 f6e33000 r-xp /usr/lib/libsensor.so.1.9.6
f6e3c000 f6f08000 r-xp /usr/lib/libxml2.so.2.7.8
f6f15000 f6f17000 r-xp /usr/lib/libiniparser.so.0
f6f20000 f6f26000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f2f000 f6fff000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7000000 f7034000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f703d000 f7079000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7081000 f7084000 r-xp /usr/lib/libbundle.so.0.1.22
f708c000 f7092000 r-xp /usr/lib/libappsvc.so.0.1.0
f709a000 f70db000 r-xp /usr/lib/libeina.so.1.7.99
f70e4000 f70fb000 r-xp /usr/lib/libecore.so.1.7.99
f7112000 f711b000 r-xp /usr/lib/libvconf.so.0.2.45
f7123000 f7137000 r-xp /lib/libpthread-2.13.so
f7142000 f714f000 r-xp /usr/lib/libaul.so.0.1.0
f7159000 f715b000 r-xp /lib/libdl-2.13.so
f7164000 f716f000 r-xp /lib/libunwind.so.8.0.1
f719c000 f71a4000 r-xp /lib/libgcc_s-4.6.so.1
f71a5000 f72c9000 r-xp /lib/libc-2.13.so
f72d7000 f72d9000 r-xp /usr/lib/libdlog.so.0.0.0
f72e1000 f72ed000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72f6000 f72fb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7303000 f7312000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f731a000 f731e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7327000 f732a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7332000 f7334000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f733c000 f7340000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7348000 f7365000 r-xp /lib/ld-2.13.so
f736e000 f7371000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7371000 f7375000 r-xp /usr/lib/libsys-assert.so
f7600000 f768e000 rw-p [heap]
ff8d0000 ff8f1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9923)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf736f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7306539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf700d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf700bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7017e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf701dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf701ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf705275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf704d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf700bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7017e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf701dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf701ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf704fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7050017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7057f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49ef1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49e2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ab5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f62fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f647a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70f4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70efb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70f05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70f0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7328183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73287fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf736f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf71bc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf736ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
_send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:11.821+0200 E/AUL     ( 9923): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:11.821+0200 E/AUL     ( 9923): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:11.821+0200 E/AUL     ( 9923): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:11.821+0200 E/AUL     ( 9923): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:11.821+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:11.821+0200 I/utils   ( 9470): specific action
06-12 14:10:11.821+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:11.821+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:11.821+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:11.821+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:11.821+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:11.821+0200 I/recorder( 9470): saving local data for es.ugr.frailty.linearacceleration
06-12 14:10:11.821+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:10:11.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:10:11.831+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:11.831+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:11.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(54) , send fd(15), pid(9923), cmd(0)
06-12 14:10:11.841+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
06-12 14:10:11.841+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3863640), time2(3828852)
06-12 14:10:11.841+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
06-12 14:10:11.841+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
06-12 14:10:11.841+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
06-12 14:10:11.841+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:2, msg id:25
06-12 14:10:11.841+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:11.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(47) , send fd(15), pid(9470), cmd(0)
06-12 14:10:11.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:11.861+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:11.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:11.881+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:11.881+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:11.881+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:11.891+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:11.891+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:11:894,0.159295,0.011058,9.805350
06-12 14:10:11.891+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:11.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:11.901+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10121
06-12 14:10:11.911+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:11.921+0200 I/heartrate(10093): es.ugr.frailty.heartrate - capturing data
06-12 14:10:11.921+0200 I/heartrate(10093): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:11.921+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:11.921+0200 I/light   (10121): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:11.931+0200 I/light   (10121): es.ugr.frailty.light - capturing data
06-12 14:10:11.931+0200 I/light   (10121): es.ugr.frailty.light: SM-R760,12/06/2018,14:10:11:934,57.000000
06-12 14:10:11.931+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:11.931+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:11.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:11.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:11.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:11.981+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:11.981+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:11.981+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:11.981+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:11:986,0.117248,0.033500,9.877571
06-12 14:10:11.981+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:11.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:12.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.001+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:12.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.021+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.021+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.021+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:12.021+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:12:29,-0.026676,0.026507,-0.037970
06-12 14:10:12.021+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.021+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:12.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:10:12.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:12.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:12.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.081+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.081+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.081+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:12.081+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:12.081+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:12:85,-0.070000,-0.280000,-0.070000
06-12 14:10:12.081+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.091+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:12.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:10:12.111+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.111+0200 I/utils   ( 9470): specific action
06-12 14:10:12.111+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.111+0200 I/recorder( 9470): saving local data for es.ugr.frailty.accelerometer
06-12 14:10:12.111+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:10:12.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.151+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:12.161+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.171+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:12.171+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:12.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(65) , send fd(15), pid(9470), cmd(0)
06-12 14:10:12.181+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:10:12.181+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:10:12.181+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:10:12.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.191+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:10:12.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10121
06-12 14:10:12.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:10:12.201+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:10:12.201+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.201+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.201+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:12.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.211+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:12:211,0.156930,0.009087,9.805390
06-12 14:10:12.211+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.211+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.211+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.211+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.211+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.211+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.211+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.211+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.211+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.211+0200 I/utils   ( 9467): specific action
06-12 14:10:12.211+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:10:12.221+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.221+0200 I/light   (10121): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.221+0200 I/light   (10121): es.ugr.frailty.light - capturing data
06-12 14:10:12.221+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:10:12.221+0200 I/light   (10121): es.ugr.frailty.light: SM-R760,12/06/2018,14:10:12:224,57.000000
06-12 14:10:12.221+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.221+0200 I/heartrate(10093): es.ugr.frailty.heartrate - capturing data
06-12 14:10:12.221+0200 I/heartrate(10093): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:12.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.241+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:12.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.261+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.261+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.261+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:12.261+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:12:268,0.141177,0.150748,9.779467
06-12 14:10:12.261+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:12.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(73) , send fd(15), pid(9467), cmd(0)
06-12 14:10:12.261+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:12.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.301+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.301+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.301+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:12.311+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:12:308,-0.011503,0.062492,-0.059518
06-12 14:10:12.311+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.321+0200 I/heartrate(10093): es.ugr.frailty.heartrate - capturing data
06-12 14:10:12.321+0200 I/heartrate(10093): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:12.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:10:12.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10125
06-12 14:10:12.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:12.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:12.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.401+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.401+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.411+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:12.411+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.411+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.411+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:12.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:12.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:12.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:10:12.451+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:10:12.451+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:10:12.451+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:10:12.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.451+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.451+0200 I/utils   ( 9467): specific action
06-12 14:10:12.451+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.451+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.451+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.451+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.451+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:10:12.451+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:10:12.461+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:12:421,0.158688,0.008930,9.805362
06-12 14:10:12.461+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:12:414,-0.070000,-0.280000,-0.070000
06-12 14:10:12.461+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.461+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.461+0200 I/utils   ( 9470): specific action
06-12 14:10:12.461+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.461+0200 I/recorder( 9470): saving local data for es.ugr.frailty.accelerometer
06-12 14:10:12.461+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:10:12.461+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.481+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10121
06-12 14:10:12.491+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.501+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.501+0200 I/light   (10121): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.501+0200 I/light   (10121): es.ugr.frailty.light - capturing data
06-12 14:10:12.511+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:12.511+0200 I/light   (10121): es.ugr.frailty.light: SM-R760,12/06/2018,14:10:12:510,57.000000
06-12 14:10:12.511+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.521+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:12.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(71) , send fd(15), pid(9470), cmd(0)
06-12 14:10:12.531+0200 I/heartrate(10093): es.ugr.frailty.heartrate - capturing data
06-12 14:10:12.531+0200 I/heartrate(10093): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:12.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.531+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:12.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.561+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.561+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.571+0200 E/CAPI_TELEPHONY( 9545): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:10:12.571+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:12.581+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:12:579,0.143569,-0.074178,9.762716
06-12 14:10:12.581+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:12.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.601+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.601+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.601+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:12.611+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:12.611+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:12:612,0.029101,-0.036571,0.076839
06-12 14:10:12.611+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:10:12.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:12.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:10:12.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.651+0200 I/utils   ( 9470): specific action
06-12 14:10:12.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.651+0200 I/recorder( 9470): saving local data for es.ugr.frailty.linearacceleration
06-12 14:10:12.651+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:10:12.661+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:10:12.661+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:10:12.661+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:10:12.661+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:12.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.661+0200 I/utils   ( 9467): specific action
06-12 14:10:12.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.661+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.671+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.671+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.light
06-12 14:10:12.671+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:10:12.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:12.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.701+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.711+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.711+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:12.711+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:12.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(50) , send fd(15), pid(9467), cmd(0)
06-12 14:10:12.711+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:12:714,-0.070000,-0.280000,-0.070000
06-12 14:10:12.711+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.721+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:12.721+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(75) , send fd(15), pid(9470), cmd(0)
06-12 14:10:12.721+0200 I/heartrate(10093): es.ugr.frailty.heartrate - capturing data
06-12 14:10:12.721+0200 I/heartrate(10093): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:12.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:12.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.761+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.761+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.761+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:12.761+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:12:767,0.157581,0.008892,9.805380
06-12 14:10:12.761+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.781+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10121
06-12 14:10:12.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.801+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.801+0200 I/light   (10121): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.801+0200 I/light   (10121): es.ugr.frailty.light - capturing data
06-12 14:10:12.811+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9474) cmd(0)
06-12 14:10:12.811+0200 I/light   (10121): es.ugr.frailty.light: SM-R760,12/06/2018,14:10:12:811,57.000000
06-12 14:10:12.811+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:12.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.871+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.871+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:12.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.901+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9477) cmd(0)
06-12 14:10:12.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:12.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:10:12.931+0200 I/heartrate(10093): es.ugr.frailty.heartrate - capturing data
06-12 14:10:12.931+0200 I/heartrate(10093): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:12.931+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.931+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:12.941+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.941+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:12:944,0.064606,0.122034,9.946963
06-12 14:10:12.941+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.941+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:12.941+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:12.941+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:10:12.941+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:10:12.941+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:10:12.941+0200 I/servicemanager( 9467): es.ugr.frailty.accelerometer sleep timeout
06-12 14:10:12.941+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-12 14:10:12.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.941+0200 I/utils   ( 9470): specific action
06-12 14:10:12.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.951+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.951+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:10:12.951+0200 I/recorder( 9470): saving local data for es.ugr.frailty.light
06-12 14:10:12.951+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 14:10:12.951+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:12:949,0.035154,-0.032247,-0.061922
06-12 14:10:12.951+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.951+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:12.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:12.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:12.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:12.981+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:12.981+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:12.981+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:12.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:10:12.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(51) , send fd(15), pid(9470), cmd(0)
06-12 14:10:12.991+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:12:988,-0.070000,-0.280000,-0.070000
06-12 14:10:12.991+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:13.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.001+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:13.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.021+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:13.021+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:13.031+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:13.031+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:13:34,0.154462,0.011465,9.805427
06-12 14:10:13.031+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:13.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10121
06-12 14:10:13.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.071+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:13.071+0200 I/light   (10121): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:13.071+0200 I/light   (10121): es.ugr.frailty.light - capturing data
06-12 14:10:13.071+0200 I/light   (10121): es.ugr.frailty.light: SM-R760,12/06/2018,14:10:13:75,57.000000
06-12 14:10:13.071+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:13.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.081+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:13.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9474
06-12 14:10:13.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:10:13.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:10:13.111+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:10:13.111+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9474)
06-12 14:10:13.111+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.accelerometer
06-12 14:10:13.111+0200 I/servicemanager( 9467): es.ugr.frailty.gyroscope sleep timeout
06-12 14:10:13.111+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-12 14:10:13.121+0200 I/heartrate(10093): es.ugr.frailty.heartrate - capturing data
06-12 14:10:13.121+0200 I/heartrate(10093): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:13.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:13.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.151+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:13.151+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:13.151+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:10:13.161+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:10:13:160,0.138784,0.040678,9.801002
06-12 14:10:13.161+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:13.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.171+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:13.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.191+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:13.191+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:13.191+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:10:13.201+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:13.201+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:10:13:203,-0.034162,0.036677,0.057714
06-12 14:10:13.201+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:13.221+0200 W/LOCATION( 9923): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:10:13.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.231+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:13.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.251+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:13.251+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:13.251+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:10:13.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.271+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:13.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.291+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:10:13:262,-0.070000,-0.350000,-0.070000
06-12 14:10:13.291+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:13.291+0200 I/gravity ( 9734): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:13.291+0200 I/gravity ( 9734): es.ugr.frailty.gravity - capturing data
06-12 14:10:13.291+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:13.301+0200 I/gravity ( 9734): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:10:13:299,0.153036,0.008955,9.805451
06-12 14:10:13.301+0200 W/AUL     ( 9734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:13.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10121
06-12 14:10:13.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.341+0200 I/heartrate(10093): es.ugr.frailty.heartrate - capturing data
06-12 14:10:13.341+0200 I/heartrate(10093): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:13.351+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:13.351+0200 I/light   (10121): request sent to service es.ugr.frailty.servicemanager
06-12 14:10:13.361+0200 I/light   (10121): es.ugr.frailty.light - capturing data
06-12 14:10:13.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.361+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:10:13.371+0200 I/light   (10121): es.ugr.frailty.light: SM-R760,12/06/2018,14:10:13:364,57.000000
06-12 14:10:13.371+0200 W/AUL     (10121): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:10:13.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9477
06-12 14:10:13.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.401+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9477)
06-12 14:10:13.401+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.gyroscope
06-12 14:10:13.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:10:13.401+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:10:13.401+0200 I/servicemanager( 9467): es.ugr.frailty.heartrate sleep timeout
06-12 14:10:13.401+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-12 14:10:13.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 14:10:13.421+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 14:10:13.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:10:13.421+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 14:10:13.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 14:10:13.421+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 14:10:13.421+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 14:10:13.421+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 14:10:13.421+0200 E/CAPI_LOCATION_MANAGER( 9545): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 14:10:13.431+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:10:13.431+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:10:13.431+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:13.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.451+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:10:13.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:10:13.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.531+0200 I/heartrate(10093): es.ugr.frailty.heartrate - capturing data
06-12 14:10:13.531+0200 I/heartrate(10093): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:10:13.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.541+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9734
06-12 14:10:13.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:10:13.561+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:10:13.581+0200 I/CAPI_NETWORK_CONNECTION( 9545): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 14:10:13.581+0200 I/CAPI_NETWORK_CONNECTION( 9545): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 14:10:13.591+0200 I/CAPI_NETWORK_CONNECTION( 9545): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 14:10:13.591+0200 I/CAPI_NETWORK_CONNECTION( 9545): connection.c: connection_destroy(471) > Destroy handle: 0xf79fbcb0
06-12 14:10:13.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:10:13.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10121
06-12 14:10:13.591+0200 W/CRASH_MANAGER(10155): worker.c: worker_job(1205) > 11099236c6f63152880541
