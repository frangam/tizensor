S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5311
Date: 2018-06-12 13:27:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf746252d, r5   = 0xf7664150
r6   = 0xffb922f0, r7   = 0xffb921a0
r8   = 0xf7676c18, r9   = 0x00000000
r10  = 0xffb9227c, fp   = 0xffb922f0
ip   = 0x00000001, sp   = 0xffb92178
lr   = 0xf7462539, pc   = 0xf74cb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    242776 KB
Buffers:      8948 KB
Cached:     113656 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11624 KB
VmRSS:       11624 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5311 TID = 5311
5311 5393 

Maps Information
f432d000 f4b2c000 rw-p [stack:5393]
f4b33000 f4b35000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b3d000 f4b41000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b4a000 f4b4c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b54000 f4b57000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b66000 f4b6b000 r-xp /usr/lib/libsystem.so.0.0.0
f4b76000 f4b79000 r-xp /lib/libattr.so.1.1.0
f4b81000 f4b91000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b99000 f4ba2000 r-xp /usr/lib/libedbus.so.1.7.99
f4baa000 f4bab000 r-xp /usr/lib/libresponse.so.0.2.96
f4bb4000 f4bb9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f645b000 f6561000 r-xp /usr/lib/libicuuc.so.57.1
f6577000 f66ff000 r-xp /usr/lib/libicui18n.so.57.1
f670f000 f671c000 r-xp /usr/lib/libail.so.0.1.0
f6725000 f672c000 r-xp /usr/lib/libminizip.so.1.0.0
f6735000 f68de000 r-xp /usr/lib/libcrypto.so.1.0.0
f68fe000 f6945000 r-xp /usr/lib/libssl.so.1.0.0
f6951000 f6953000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f695b000 f6962000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f696b000 f6972000 r-xp /lib/libcrypt-2.13.so
f69a3000 f69a6000 r-xp /lib/libcap.so.2.21
f69ae000 f69b0000 r-xp /usr/lib/libiri.so
f69b8000 f6a01000 r-xp /usr/lib/libmdm.so.1.2.69
f6a09000 f6a0f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a17000 f6a3a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a44000 f6a46000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a4e000 f6a6b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a74000 f6a78000 r-xp /usr/lib/libsmack.so.1.0.0
f6a81000 f6a9a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6aa3000 f6aab000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ab3000 f6ab9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ac2000 f6ac4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6acd000 f6add000 r-xp /lib/libresolv-2.13.so
f6ae1000 f6af9000 r-xp /usr/lib/liblzma.so.5.0.3
f6b02000 f6b04000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b0c000 f6b26000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b2e000 f6b5d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b66000 f6b75000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b7f000 f6b89000 r-xp /usr/lib/libsensord-shared.so
f6b92000 f6c65000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c70000 f6c86000 r-xp /lib/libz.so.1.2.5
f6c8e000 f6c93000 r-xp /usr/lib/libffi.so.5.0.10
f6c9b000 f6c9c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ca4000 f6cb4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cbc000 f6cd5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cdd000 f6cdf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ce7000 f6d5c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d66000 f6d6c000 r-xp /lib/librt-2.13.so
f6d75000 f6d93000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d9d000 f6d9e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6da6000 f6dc9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dd1000 f6dd6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dde000 f6e08000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e11000 f6e28000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e30000 f6e99000 r-xp /lib/libm-2.13.so
f6ea2000 f6f36000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f49000 f6f4e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f56000 f6f5d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f65000 f6f8f000 r-xp /usr/lib/libsensor.so.1.9.6
f6f98000 f7064000 r-xp /usr/lib/libxml2.so.2.7.8
f7071000 f7073000 r-xp /usr/lib/libiniparser.so.0
f707c000 f7082000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f708b000 f715b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f715c000 f7190000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7199000 f71d5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71dd000 f71e0000 r-xp /usr/lib/libbundle.so.0.1.22
f71e8000 f71ee000 r-xp /usr/lib/libappsvc.so.0.1.0
f71f6000 f7237000 r-xp /usr/lib/libeina.so.1.7.99
f7240000 f7257000 r-xp /usr/lib/libecore.so.1.7.99
f726e000 f7277000 r-xp /usr/lib/libvconf.so.0.2.45
f727f000 f7293000 r-xp /lib/libpthread-2.13.so
f729e000 f72ab000 r-xp /usr/lib/libaul.so.0.1.0
f72b5000 f72b7000 r-xp /lib/libdl-2.13.so
f72c0000 f72cb000 r-xp /lib/libunwind.so.8.0.1
f72f8000 f7300000 r-xp /lib/libgcc_s-4.6.so.1
f7301000 f7425000 r-xp /lib/libc-2.13.so
f7433000 f7435000 r-xp /usr/lib/libdlog.so.0.0.0
f743d000 f7449000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7452000 f7457000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f745f000 f746e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7476000 f747a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7483000 f7486000 r-xp /usr/lib/libappcore-agent.so.1.1
f748e000 f7490000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7498000 f749c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74a4000 f74c1000 r-xp /lib/ld-2.13.so
f74ca000 f74cd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74cd000 f74d1000 r-xp /usr/lib/libsys-assert.so
f7646000 f76b7000 rw-p [heap]
ffb73000 ffb94000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5311)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74cb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7462539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71693f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7167c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7173e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7179be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7179dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71ae75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71a91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7167c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7173e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7179be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7179dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71abe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71ac017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71b3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b4b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b3e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c11663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70befcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70c07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7250ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf724bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf724c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf724c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7484183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74847fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74cb5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf731885c) [/lib/libc.so.6] + 0x1785c
29: (0xf74caf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
: app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:58.911+0200 I/servicemanager( 5276): requesting to save local data for es.ugr.frailty.gyroscope
06-12 13:27:58.921+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:27:58.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:58.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5349
06-12 13:27:58.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:58.931+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:58.931+0200 I/light   ( 5349): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:58.931+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:58.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(5276), cmd(0)
06-12 13:27:58.951+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:58.951+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(87) , send fd(15), pid(5279), cmd(0)
06-12 13:27:58.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:58.951+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5287
06-12 13:27:58.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:58.971+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:58.971+0200 I/gyroscope( 5287): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:58.971+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope - capturing data
06-12 13:27:58.971+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:27:58:975,-167.930008,-95.199997,416.220001
06-12 13:27:58.971+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5322
06-12 13:27:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.001+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.001+0200 I/linearacceleration( 5322): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.001+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration - capturing data
06-12 13:27:59.011+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:27:59:13,-12.819183,0.115241,-1.351429
06-12 13:27:59.011+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5335
06-12 13:27:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.041+0200 I/light   ( 5349): es.ugr.frailty.light - capturing data
06-12 13:27:59.041+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.041+0200 I/gravity ( 5335): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.041+0200 I/gravity ( 5335): es.ugr.frailty.gravity - capturing data
06-12 13:27:59.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5284
06-12 13:27:59.061+0200 I/gravity ( 5335): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:27:59:53,-6.499366,-5.812419,4.488252
06-12 13:27:59.061+0200 I/light   ( 5349): es.ugr.frailty.light: SM-R760,12/06/2018,13:27:59:45,25.000000
06-12 13:27:59.061+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.061+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.061+0200 I/heartrate( 5300): es.ugr.frailty.heartrate - capturing data
06-12 13:27:59.061+0200 I/heartrate( 5300): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:27:59.071+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.071+0200 I/accelerometer( 5284): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.071+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer - capturing data
06-12 13:27:59.071+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:27:59:76,-17.606390,-7.537392,2.481357
06-12 13:27:59.071+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.081+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5276
06-12 13:27:59.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5279
06-12 13:27:59.091+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.091+0200 I/utils   ( 5279): specific action
06-12 13:27:59.101+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.101+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.101+0200 I/recorder( 5279): saving local data for es.ugr.frailty.gyroscope
06-12 13:27:59.101+0200 I/recorder( 5279): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 13:27:59.101+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5279)
06-12 13:27:59.101+0200 I/servicemanager( 5276): request sent to service es.ugr.frailty.recorder
06-12 13:27:59.101+0200 I/servicemanager( 5276): requesting to save local data
06-12 13:27:59.101+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.101+0200 I/utils   ( 5276): specific action
06-12 13:27:59.101+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.101+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.101+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.101+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.101+0200 I/servicemanager( 5276): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 13:27:59.101+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:27:59.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.101+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5287
06-12 13:27:59.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.121+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.121+0200 I/gyroscope( 5287): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.121+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope - capturing data
06-12 13:27:59.121+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(44) , send fd(15), pid(5276), cmd(0)
06-12 13:27:59.121+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(91) , send fd(15), pid(5279), cmd(0)
06-12 13:27:59.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5322
06-12 13:27:59.131+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:27:59:125,-131.740005,-99.750000,398.579987
06-12 13:27:59.131+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.141+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.141+0200 I/linearacceleration( 5322): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.141+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration - capturing data
06-12 13:27:59.151+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:27:59:153,-13.108906,1.065302,-2.444866
06-12 13:27:59.151+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.171+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5349
06-12 13:27:59.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.181+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.181+0200 I/light   ( 5349): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5335
06-12 13:27:59.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.201+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.201+0200 I/gravity ( 5335): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.201+0200 I/gravity ( 5335): es.ugr.frailty.gravity - capturing data
06-12 13:27:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5284
06-12 13:27:59.211+0200 I/gravity ( 5335): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:27:59:213,-6.607522,-5.354804,4.882327
06-12 13:27:59.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.241+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5276
06-12 13:27:59.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5279
06-12 13:27:59.261+0200 I/heartrate( 5300): es.ugr.frailty.heartrate - capturing data
06-12 13:27:59.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.261+0200 I/heartrate( 5300): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:27:59.261+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5287
06-12 13:27:59.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.281+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5322
06-12 13:27:59.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.311+0200 I/light   ( 5349): es.ugr.frailty.light - capturing data
06-12 13:27:59.311+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5279)
06-12 13:27:59.311+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(95) , send fd(15), pid(5279), cmd(0)
06-12 13:27:59.341+0200 I/light   ( 5349): es.ugr.frailty.light: SM-R760,12/06/2018,13:27:59:344,25.000000
06-12 13:27:59.341+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.341+0200 I/linearacceleration( 5322): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.341+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration - capturing data
06-12 13:27:59.351+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 13:27:59.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:27:59.351+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 13:27:59.351+0200 I/servicemanager( 5276): request sent to service es.ugr.frailty.recorder
06-12 13:27:59.351+0200 I/servicemanager( 5276): requesting to save local data
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 I/utils   ( 5276): specific action
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 I/servicemanager( 5276): requesting to save local data for es.ugr.frailty.light
06-12 13:27:59.351+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:27:59.351+0200 I/utils   ( 5279): specific action
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.351+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.361+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.361+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.361+0200 I/recorder( 5279): saving local data for es.ugr.frailty.linearacceleration
06-12 13:27:59.361+0200 I/recorder( 5279): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 13:27:59.361+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(5276), cmd(0)
06-12 13:27:59.361+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.361+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.361+0200 I/gyroscope( 5287): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.361+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope - capturing data
06-12 13:27:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.361+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.361+0200 I/accelerometer( 5284): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.361+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer - capturing data
06-12 13:27:59.361+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.361+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5276
06-12 13:27:59.371+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:27:59:365,-93.660004,-110.809998,367.850006
06-12 13:27:59.371+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.371+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:27:59:368,-18.455841,-6.226124,1.351945
06-12 13:27:59.371+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5279
06-12 13:27:59.371+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.371+0200 I/utils   ( 5279): specific action
06-12 13:27:59.371+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.371+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.371+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.371+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.371+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.371+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.371+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.371+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.371+0200 I/recorder( 5279): saving local data for es.ugr.frailty.light
06-12 13:27:59.381+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5279)
06-12 13:27:59.381+0200 I/servicemanager( 5276): request sent to service es.ugr.frailty.recorder
06-12 13:27:59.381+0200 I/servicemanager( 5276): requesting to save local data
06-12 13:27:59.381+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.381+0200 I/utils   ( 5276): specific action
06-12 13:27:59.381+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.381+0200 I/recorder( 5279): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 13:27:59.381+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.381+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.381+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.381+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.381+0200 I/servicemanager( 5276): requesting to save local data for es.ugr.frailty.gravity
06-12 13:27:59.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.381+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:27:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5349
06-12 13:27:59.381+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:27:59:353,-13.842573,1.323995,-3.366102
06-12 13:27:59.381+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.391+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(5276), cmd(0)
06-12 13:27:59.391+0200 I/light   ( 5349): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.411+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(5279), cmd(0)
06-12 13:27:59.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5335
06-12 13:27:59.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.431+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.431+0200 I/gravity ( 5335): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.431+0200 I/gravity ( 5335): es.ugr.frailty.gravity - capturing data
06-12 13:27:59.441+0200 I/gravity ( 5335): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:27:59:439,-6.601733,-4.980654,5.270730
06-12 13:27:59.441+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.441+0200 I/light   ( 5349): es.ugr.frailty.light - capturing data
06-12 13:27:59.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.441+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5284
06-12 13:27:59.441+0200 I/light   ( 5349): es.ugr.frailty.light: SM-R760,12/06/2018,13:27:59:446,29.000000
06-12 13:27:59.451+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.461+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.461+0200 I/accelerometer( 5284): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.461+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer - capturing data
06-12 13:27:59.461+0200 I/heartrate( 5300): es.ugr.frailty.heartrate - capturing data
06-12 13:27:59.461+0200 I/heartrate( 5300): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:27:59.471+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:27:59:468,-19.690536,-5.513064,0.535992
06-12 13:27:59.471+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.481+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5287
06-12 13:27:59.491+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.491+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.491+0200 I/gyroscope( 5287): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.491+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope - capturing data
06-12 13:27:59.501+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:27:59:500,-50.750000,-114.239998,329.209991
06-12 13:27:59.501+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5276
06-12 13:27:59.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5279
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 I/utils   ( 5279): specific action
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 I/recorder( 5279): saving local data for es.ugr.frailty.gravity
06-12 13:27:59.521+0200 I/recorder( 5279): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 13:27:59.521+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5279)
06-12 13:27:59.521+0200 I/servicemanager( 5276): request sent to service es.ugr.frailty.recorder
06-12 13:27:59.521+0200 I/servicemanager( 5276): requesting to save local data
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 I/utils   ( 5276): specific action
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.521+0200 I/servicemanager( 5276): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 13:27:59.521+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:27:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.541+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5322
06-12 13:27:59.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.551+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.561+0200 I/linearacceleration( 5322): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.561+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration - capturing data
06-12 13:27:59.561+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(5276), cmd(0)
06-12 13:27:59.561+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:27:59:564,-13.707088,-0.178700,-4.115437
06-12 13:27:59.561+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.571+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(99) , send fd(15), pid(5279), cmd(0)
06-12 13:27:59.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5335
06-12 13:27:59.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.601+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.601+0200 I/gravity ( 5335): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.601+0200 I/gravity ( 5335): es.ugr.frailty.gravity - capturing data
06-12 13:27:59.601+0200 I/gravity ( 5335): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:27:59:604,-6.574054,-4.678067,5.573857
06-12 13:27:59.601+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.611+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5349
06-12 13:27:59.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.651+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.651+0200 I/light   ( 5349): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.651+0200 I/light   ( 5349): es.ugr.frailty.light - capturing data
06-12 13:27:59.651+0200 I/light   ( 5349): es.ugr.frailty.light: SM-R760,12/06/2018,13:27:59:654,28.000000
06-12 13:27:59.651+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5284
06-12 13:27:59.671+0200 I/heartrate( 5300): es.ugr.frailty.heartrate - capturing data
06-12 13:27:59.671+0200 I/heartrate( 5300): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:27:59.671+0200 W/LOCATION( 5311): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 13:27:59.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.681+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.681+0200 I/accelerometer( 5284): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.681+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer - capturing data
06-12 13:27:59.681+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:27:59:684,-19.951355,-6.503692,0.028714
06-12 13:27:59.681+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5287
06-12 13:27:59.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.711+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.711+0200 I/gyroscope( 5287): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.711+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope - capturing data
06-12 13:27:59.721+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:27:59:721,-18.690001,-107.870003,285.459991
06-12 13:27:59.721+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5276
06-12 13:27:59.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5279
06-12 13:27:59.751+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.751+0200 I/utils   ( 5279): specific action
06-12 13:27:59.751+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.751+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.751+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.751+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.751+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.751+0200 I/recorder( 5279): saving local data for es.ugr.frailty.linearacceleration
06-12 13:27:59.751+0200 I/recorder( 5279): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 13:27:59.751+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5279)
06-12 13:27:59.751+0200 I/servicemanager( 5276): request sent to service es.ugr.frailty.recorder
06-12 13:27:59.751+0200 I/servicemanager( 5276): requesting to save local data
06-12 13:27:59.751+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.751+0200 I/utils   ( 5276): specific action
06-12 13:27:59.751+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.751+0200 I/servicemanager( 5276): requesting to save local data for es.ugr.frailty.gyroscope
06-12 13:27:59.751+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:27:59.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.771+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5322
06-12 13:27:59.781+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.791+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(5276), cmd(0)
06-12 13:27:59.791+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.791+0200 I/linearacceleration( 5322): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.791+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration - capturing data
06-12 13:27:59.811+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(103) , send fd(15), pid(5279), cmd(0)
06-12 13:27:59.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.811+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5335
06-12 13:27:59.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.831+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.831+0200 I/gravity ( 5335): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.831+0200 I/gravity ( 5335): es.ugr.frailty.gravity - capturing data
06-12 13:27:59.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.841+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5349
06-12 13:27:59.841+0200 I/gravity ( 5335): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:27:59:836,-6.579264,-4.436460,5.762074
06-12 13:27:59.841+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.841+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:27:59:797,-12.521179,-0.932948,-4.019258
06-12 13:27:59.841+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.851+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.851+0200 I/light   ( 5349): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.851+0200 I/light   ( 5349): es.ugr.frailty.light - capturing data
06-12 13:27:59.861+0200 I/light   ( 5349): es.ugr.frailty.light: SM-R760,12/06/2018,13:27:59:857,23.000000
06-12 13:27:59.861+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.861+0200 I/heartrate( 5300): es.ugr.frailty.heartrate - capturing data
06-12 13:27:59.861+0200 I/heartrate( 5300): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:27:59.861+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5284
06-12 13:27:59.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.871+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.871+0200 I/accelerometer( 5284): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.871+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer - capturing data
06-12 13:27:59.881+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:27:59:883,-19.020546,-6.745367,0.468993
06-12 13:27:59.881+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.891+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5287
06-12 13:27:59.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.901+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.901+0200 I/gyroscope( 5287): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.901+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope - capturing data
06-12 13:27:59.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.901+0200 I/gyroscope( 5287): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:27:59:909,-18.059999,-89.180000,238.210007
06-12 13:27:59.901+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5276
06-12 13:27:59.901+0200 W/AUL     ( 5287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.911+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5279
06-12 13:27:59.911+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.911+0200 I/utils   ( 5279): specific action
06-12 13:27:59.921+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5279)
06-12 13:27:59.921+0200 I/servicemanager( 5276): request sent to service es.ugr.frailty.recorder
06-12 13:27:59.921+0200 I/servicemanager( 5276): requesting to save local data
06-12 13:27:59.921+0200 W/CAPI_APPFW_APP_CONTROL( 5276): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.921+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.921+0200 W/CAPI_APPFW_APP_CONTROL( 5279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:27:59.921+0200 I/recorder( 5279): saving local data for es.ugr.frailty.gyroscope
06-12 13:27:59.921+0200 I/recorder( 5279): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 13:27:59.921+0200 I/utils   ( 5276): specific action
06-12 13:27:59.931+0200 I/servicemanager( 5276): requesting to save local data for es.ugr.frailty.accelerometer
06-12 13:27:59.931+0200 W/AUL     ( 5276): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:27:59.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5335
06-12 13:27:59.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.941+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(37) , send fd(15), pid(5276), cmd(0)
06-12 13:27:59.951+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.961+0200 I/gravity ( 5335): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.961+0200 I/gravity ( 5335): es.ugr.frailty.gravity - capturing data
06-12 13:27:59.961+0200 I/gravity ( 5335): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:27:59:965,-6.595597,-4.242869,5.887830
06-12 13:27:59.961+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:27:59.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(107) , send fd(15), pid(5279), cmd(0)
06-12 13:27:59.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:27:59.971+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5322
06-12 13:27:59.971+0200 W/AUL     ( 5335): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:27:59.981+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:27:59.981+0200 I/linearacceleration( 5322): request sent to service es.ugr.frailty.servicemanager
06-12 13:27:59.981+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration - capturing data
06-12 13:27:59.991+0200 I/linearacceleration( 5322): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:27:59:991,-9.898167,-0.115189,-4.444440
06-12 13:27:59.991+0200 W/AUL     ( 5322): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:27:59.991+0200 W/AUL     ( 5408): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 13:28:00.001+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 13:28:00.001+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 13:28:00.001+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:28:00.001+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 13:28:00.001+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 13:28:00.001+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 13:28:00.001+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 13:28:00.001+0200 E/CAPI_LOCATION_MANAGER( 5395): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 13:28:00.001+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 13:28:00.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:28:00.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5349
06-12 13:28:00.031+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:28:00.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:28:00.041+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:28:00.041+0200 I/light   ( 5349): request sent to service es.ugr.frailty.servicemanager
06-12 13:28:00.041+0200 I/light   ( 5349): es.ugr.frailty.light - capturing data
06-12 13:28:00.051+0200 I/light   ( 5349): es.ugr.frailty.light: SM-R760,12/06/2018,13:28:00:48,23.000000
06-12 13:28:00.051+0200 W/AUL     ( 5349): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:28:00.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:28:00.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 5284
06-12 13:28:00.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5276
06-12 13:28:00.071+0200 I/heartrate( 5300): es.ugr.frailty.heartrate - capturing data
06-12 13:28:00.071+0200 W/AUL     ( 5284): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5276)
06-12 13:28:00.071+0200 I/heartrate( 5300): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:28:00.081+0200 I/accelerometer( 5284): request sent to service es.ugr.frailty.servicemanager
06-12 13:28:00.081+0200 I/accelerometer( 5284): es.ugr.frailty.accelerometer - capturing data
06-12 13:28:00.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:28:00.091+0200 W/CRASH_MANAGER( 5407): worker.c: worker_job(1205) > 11053116c6f63152880287
