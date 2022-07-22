S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6831
Date: 2018-06-12 13:37:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf745852d, r5   = 0xf785f150
r6   = 0xff9f5b20, r7   = 0xff9f59d0
r8   = 0xf7871c18, r9   = 0x00000000
r10  = 0xff9f5aac, fp   = 0xff9f5b20
ip   = 0x00000001, sp   = 0xff9f59a8
lr   = 0xf7458539, pc   = 0xf74c1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    190572 KB
Buffers:     17916 KB
Cached:     133916 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11584 KB
VmRSS:       11584 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6831 TID = 6831
6831 6876 

Maps Information
f4323000 f4b22000 rw-p [stack:6876]
f4b29000 f4b2b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b33000 f4b37000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b40000 f4b42000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b4a000 f4b4d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b5c000 f4b61000 r-xp /usr/lib/libsystem.so.0.0.0
f4b6c000 f4b6f000 r-xp /lib/libattr.so.1.1.0
f4b77000 f4b87000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b8f000 f4b98000 r-xp /usr/lib/libedbus.so.1.7.99
f4ba0000 f4ba1000 r-xp /usr/lib/libresponse.so.0.2.96
f4baa000 f4baf000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6451000 f6557000 r-xp /usr/lib/libicuuc.so.57.1
f656d000 f66f5000 r-xp /usr/lib/libicui18n.so.57.1
f6705000 f6712000 r-xp /usr/lib/libail.so.0.1.0
f671b000 f6722000 r-xp /usr/lib/libminizip.so.1.0.0
f672b000 f68d4000 r-xp /usr/lib/libcrypto.so.1.0.0
f68f4000 f693b000 r-xp /usr/lib/libssl.so.1.0.0
f6947000 f6949000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6951000 f6958000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6961000 f6968000 r-xp /lib/libcrypt-2.13.so
f6999000 f699c000 r-xp /lib/libcap.so.2.21
f69a4000 f69a6000 r-xp /usr/lib/libiri.so
f69ae000 f69f7000 r-xp /usr/lib/libmdm.so.1.2.69
f69ff000 f6a05000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a0d000 f6a30000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a3a000 f6a3c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a44000 f6a61000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a6a000 f6a6e000 r-xp /usr/lib/libsmack.so.1.0.0
f6a77000 f6a90000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a99000 f6aa1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aa9000 f6aaf000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ab8000 f6aba000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ac3000 f6ad3000 r-xp /lib/libresolv-2.13.so
f6ad7000 f6aef000 r-xp /usr/lib/liblzma.so.5.0.3
f6af8000 f6afa000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b02000 f6b1c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b24000 f6b53000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b5c000 f6b6b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b75000 f6b7f000 r-xp /usr/lib/libsensord-shared.so
f6b88000 f6c5b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c66000 f6c7c000 r-xp /lib/libz.so.1.2.5
f6c84000 f6c89000 r-xp /usr/lib/libffi.so.5.0.10
f6c91000 f6c92000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c9a000 f6caa000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cb2000 f6ccb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cd3000 f6cd5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cdd000 f6d52000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d5c000 f6d62000 r-xp /lib/librt-2.13.so
f6d6b000 f6d89000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d93000 f6d94000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d9c000 f6dbf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dc7000 f6dcc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dd4000 f6dfe000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e07000 f6e1e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e26000 f6e8f000 r-xp /lib/libm-2.13.so
f6e98000 f6f2c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f3f000 f6f44000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f4c000 f6f53000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f5b000 f6f85000 r-xp /usr/lib/libsensor.so.1.9.6
f6f8e000 f705a000 r-xp /usr/lib/libxml2.so.2.7.8
f7067000 f7069000 r-xp /usr/lib/libiniparser.so.0
f7072000 f7078000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7081000 f7151000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7152000 f7186000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f718f000 f71cb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71d3000 f71d6000 r-xp /usr/lib/libbundle.so.0.1.22
f71de000 f71e4000 r-xp /usr/lib/libappsvc.so.0.1.0
f71ec000 f722d000 r-xp /usr/lib/libeina.so.1.7.99
f7236000 f724d000 r-xp /usr/lib/libecore.so.1.7.99
f7264000 f726d000 r-xp /usr/lib/libvconf.so.0.2.45
f7275000 f7289000 r-xp /lib/libpthread-2.13.so
f7294000 f72a1000 r-xp /usr/lib/libaul.so.0.1.0
f72ab000 f72ad000 r-xp /lib/libdl-2.13.so
f72b6000 f72c1000 r-xp /lib/libunwind.so.8.0.1
f72ee000 f72f6000 r-xp /lib/libgcc_s-4.6.so.1
f72f7000 f741b000 r-xp /lib/libc-2.13.so
f7429000 f742b000 r-xp /usr/lib/libdlog.so.0.0.0
f7433000 f743f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7448000 f744d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7455000 f7464000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f746c000 f7470000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7479000 f747c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7484000 f7486000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f748e000 f7492000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f749a000 f74b7000 r-xp /lib/ld-2.13.so
f74c0000 f74c3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74c3000 f74c7000 r-xp /usr/lib/libsys-assert.so
f7841000 f78af000 rw-p [heap]
ff9d7000 ff9f8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6831)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74c1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7458539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf715f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf715dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7169e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf716fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf716fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71a475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf719f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf715dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7169e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf716fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf716fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71a1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71a2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71a9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b411fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b34171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c07663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70b4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70b67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7246ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7241b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72425a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7242879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf747a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf747a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74c15c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf730e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf74c0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.641+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.641+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.641+0200 I/servicemanager( 6788): requesting to save local data for es.ugr.frailty.light
06-12 13:37:08.641+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:37:08.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6834
06-12 13:37:08.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.661+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.661+0200 I/linearacceleration( 6834): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.661+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration - capturing data
06-12 13:37:08.671+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:08.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(6788), cmd(0)
06-12 13:37:08.671+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:37:08:671,0.026584,0.047660,-0.047401
06-12 13:37:08.671+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.671+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:08.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(72) , send fd(15), pid(6791), cmd(0)
06-12 13:37:08.671+0200 I/heartrate( 6818): es.ugr.frailty.heartrate - capturing data
06-12 13:37:08.671+0200 I/heartrate( 6818): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:37:08.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6847
06-12 13:37:08.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.691+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.691+0200 I/gravity ( 6847): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.691+0200 I/gravity ( 6847): es.ugr.frailty.gravity - capturing data
06-12 13:37:08.701+0200 I/gravity ( 6847): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:37:08:703,-0.169068,9.736757,1.156441
06-12 13:37:08.701+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6871
06-12 13:37:08.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.721+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.721+0200 I/light   ( 6871): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.721+0200 I/light   ( 6871): es.ugr.frailty.light - capturing data
06-12 13:37:08.721+0200 I/light   ( 6871): es.ugr.frailty.light: SM-R760,12/06/2018,13:37:08:726,187.000000
06-12 13:37:08.721+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.731+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6796
06-12 13:37:08.741+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.751+0200 W/AUL     ( 6796): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.751+0200 I/gyroscope( 6796): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.751+0200 I/gyroscope( 6796): es.ugr.frailty.gyroscope - capturing data
06-12 13:37:08.751+0200 I/gyroscope( 6796): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:37:08:757,-0.350000,0.140000,-0.070000
06-12 13:37:08.751+0200 W/AUL     ( 6796): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.761+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6794
06-12 13:37:08.771+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.771+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.771+0200 I/accelerometer( 6794): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.781+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer - capturing data
06-12 13:37:08.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6788
06-12 13:37:08.791+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:37:08:787,-0.143569,9.784252,1.110270
06-12 13:37:08.791+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6791
06-12 13:37:08.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.811+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6791)
06-12 13:37:08.811+0200 I/servicemanager( 6788): request sent to service es.ugr.frailty.recorder
06-12 13:37:08.811+0200 I/servicemanager( 6788): requesting to save local data
06-12 13:37:08.821+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.821+0200 I/utils   ( 6788): specific action
06-12 13:37:08.821+0200 I/servicemanager( 6788): requesting to save local data for es.ugr.frailty.accelerometer
06-12 13:37:08.821+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:37:08.821+0200 I/utils   ( 6791): specific action
06-12 13:37:08.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6834
06-12 13:37:08.821+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.821+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.821+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.821+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.821+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.821+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.831+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.831+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.831+0200 I/recorder( 6791): saving local data for es.ugr.frailty.light
06-12 13:37:08.831+0200 I/recorder( 6791): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 13:37:08.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.841+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.841+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:08.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(6788), cmd(0)
06-12 13:37:08.841+0200 I/linearacceleration( 6834): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.841+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:08.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(76) , send fd(15), pid(6791), cmd(0)
06-12 13:37:08.851+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration - capturing data
06-12 13:37:08.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.851+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6847
06-12 13:37:08.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.871+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6871
06-12 13:37:08.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.891+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 13:37:08.891+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 13:37:08.891+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 13:37:08.891+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 13:37:08.901+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:37:08:874,0.020713,0.013995,-0.082064
06-12 13:37:08.901+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.901+0200 I/heartrate( 6818): es.ugr.frailty.heartrate - capturing data
06-12 13:37:08.901+0200 I/heartrate( 6818): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:37:08.901+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6796
06-12 13:37:08.901+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.901+0200 I/light   ( 6871): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.901+0200 I/light   ( 6871): es.ugr.frailty.light - capturing data
06-12 13:37:08.901+0200 I/light   ( 6871): es.ugr.frailty.light: SM-R760,12/06/2018,13:37:08:907,187.000000
06-12 13:37:08.901+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.901+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.901+0200 I/gravity ( 6847): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.901+0200 I/gravity ( 6847): es.ugr.frailty.gravity - capturing data
06-12 13:37:08.911+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.911+0200 I/gravity ( 6847): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:37:08:912,-0.168462,9.737019,1.154328
06-12 13:37:08.911+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.911+0200 W/AUL     ( 6796): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.921+0200 I/gyroscope( 6796): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.921+0200 I/gyroscope( 6796): es.ugr.frailty.gyroscope - capturing data
06-12 13:37:08.921+0200 I/gyroscope( 6796): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:37:08:924,-0.420000,0.210000,-0.140000
06-12 13:37:08.921+0200 W/AUL     ( 6796): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6794
06-12 13:37:08.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:08.941+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:08.941+0200 I/accelerometer( 6794): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:08.941+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer - capturing data
06-12 13:37:08.951+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:37:08:953,-0.148355,9.750752,1.074377
06-12 13:37:08.951+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:08.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6788
06-12 13:37:08.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6791
06-12 13:37:08.971+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.971+0200 I/utils   ( 6791): specific action
06-12 13:37:08.971+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.971+0200 I/recorder( 6791): saving local data for es.ugr.frailty.accelerometer
06-12 13:37:08.971+0200 I/recorder( 6791): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 13:37:08.971+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6791)
06-12 13:37:08.971+0200 I/servicemanager( 6788): request sent to service es.ugr.frailty.recorder
06-12 13:37:08.971+0200 I/servicemanager( 6788): requesting to save local data
06-12 13:37:08.971+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.971+0200 I/utils   ( 6788): specific action
06-12 13:37:08.971+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.971+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.971+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.971+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.971+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:08.971+0200 I/servicemanager( 6788): requesting to save local data for es.ugr.frailty.gravity
06-12 13:37:08.971+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:37:08.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:08.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6834
06-12 13:37:08.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.001+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.001+0200 I/linearacceleration( 6834): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.001+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration - capturing data
06-12 13:37:09.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(6788), cmd(0)
06-12 13:37:09.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(80) , send fd(15), pid(6791), cmd(0)
06-12 13:37:09.001+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:37:09:5,-0.018178,0.078340,-0.115843
06-12 13:37:09.001+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6871
06-12 13:37:09.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.031+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.031+0200 I/light   ( 6871): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.031+0200 I/light   ( 6871): es.ugr.frailty.light - capturing data
06-12 13:37:09.041+0200 I/light   ( 6871): es.ugr.frailty.light: SM-R760,12/06/2018,13:37:09:38,187.000000
06-12 13:37:09.041+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6847
06-12 13:37:09.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.061+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.061+0200 I/gravity ( 6847): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.061+0200 I/gravity ( 6847): es.ugr.frailty.gravity - capturing data
06-12 13:37:09.071+0200 I/gravity ( 6847): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:37:09:68,-0.169572,9.737596,1.149287
06-12 13:37:09.071+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.081+0200 I/heartrate( 6818): es.ugr.frailty.heartrate - capturing data
06-12 13:37:09.081+0200 I/heartrate( 6818): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:37:09.081+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6796
06-12 13:37:09.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.091+0200 W/AUL     ( 6796): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.091+0200 I/gyroscope( 6796): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.091+0200 I/gyroscope( 6796): es.ugr.frailty.gyroscope - capturing data
06-12 13:37:09.101+0200 I/gyroscope( 6796): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:37:09:102,-0.420000,0.210000,-0.070000
06-12 13:37:09.101+0200 W/AUL     ( 6796): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6794
06-12 13:37:09.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.121+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.121+0200 I/accelerometer( 6794): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.121+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer - capturing data
06-12 13:37:09.131+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:37:09:132,-0.186640,9.815358,1.038485
06-12 13:37:09.131+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6788
06-12 13:37:09.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6791
06-12 13:37:09.171+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.171+0200 I/utils   ( 6791): specific action
06-12 13:37:09.171+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.171+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.171+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.171+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.171+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.171+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.171+0200 I/recorder( 6791): saving local data for es.ugr.frailty.gravity
06-12 13:37:09.171+0200 I/recorder( 6791): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 13:37:09.171+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6791)
06-12 13:37:09.171+0200 I/servicemanager( 6788): request sent to service es.ugr.frailty.recorder
06-12 13:37:09.171+0200 I/servicemanager( 6788): requesting to save local data
06-12 13:37:09.171+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.171+0200 I/utils   ( 6788): specific action
06-12 13:37:09.171+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.171+0200 I/servicemanager( 6788): requesting to save local data for es.ugr.frailty.gyroscope
06-12 13:37:09.171+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:37:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6834
06-12 13:37:09.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.211+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.211+0200 I/linearacceleration( 6834): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.211+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration - capturing data
06-12 13:37:09.211+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:09.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(37) , send fd(15), pid(6788), cmd(0)
06-12 13:37:09.221+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:37:09:215,0.030789,0.005978,-0.067732
06-12 13:37:09.221+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:09.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(84) , send fd(15), pid(6791), cmd(0)
06-12 13:37:09.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.231+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6871
06-12 13:37:09.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.251+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.251+0200 I/light   ( 6871): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.251+0200 I/light   ( 6871): es.ugr.frailty.light - capturing data
06-12 13:37:09.251+0200 I/light   ( 6871): es.ugr.frailty.light: SM-R760,12/06/2018,13:37:09:257,187.000000
06-12 13:37:09.251+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.271+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6847
06-12 13:37:09.271+0200 I/heartrate( 6818): es.ugr.frailty.heartrate - capturing data
06-12 13:37:09.271+0200 I/heartrate( 6818): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:37:09.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.291+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.291+0200 I/gravity ( 6847): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.291+0200 I/gravity ( 6847): es.ugr.frailty.gravity - capturing data
06-12 13:37:09.301+0200 I/gravity ( 6847): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:37:09:301,-0.168322,9.737826,1.147514
06-12 13:37:09.301+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6796
06-12 13:37:09.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.341+0200 W/AUL     ( 6796): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.351+0200 I/gyroscope( 6796): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.351+0200 I/gyroscope( 6796): es.ugr.frailty.gyroscope - capturing data
06-12 13:37:09.351+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 13:37:09.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:37:09.351+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 13:37:09.351+0200 I/gyroscope( 6796): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:37:09:355,-0.420000,0.140000,-0.070000
06-12 13:37:09.351+0200 W/AUL     ( 6796): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.371+0200 W/LOCATION( 6831): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 13:37:09.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6794
06-12 13:37:09.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.401+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.401+0200 I/accelerometer( 6794): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.401+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer - capturing data
06-12 13:37:09.411+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:37:09:408,-0.138784,9.743573,1.081556
06-12 13:37:09.411+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6788
06-12 13:37:09.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6791
06-12 13:37:09.441+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6791)
06-12 13:37:09.441+0200 I/servicemanager( 6788): request sent to service es.ugr.frailty.recorder
06-12 13:37:09.441+0200 I/servicemanager( 6788): requesting to save local data
06-12 13:37:09.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.451+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6834
06-12 13:37:09.461+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.461+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.461+0200 I/utils   ( 6791): specific action
06-12 13:37:09.461+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.461+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.461+0200 I/recorder( 6791): saving local data for es.ugr.frailty.gyroscope
06-12 13:37:09.461+0200 I/recorder( 6791): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 13:37:09.461+0200 I/utils   ( 6788): specific action
06-12 13:37:09.461+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.461+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.461+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.461+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.461+0200 I/servicemanager( 6788): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 13:37:09.461+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:37:09.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.471+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.471+0200 I/linearacceleration( 6834): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.471+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration - capturing data
06-12 13:37:09.471+0200 I/heartrate( 6818): es.ugr.frailty.heartrate - capturing data
06-12 13:37:09.471+0200 I/heartrate( 6818): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:37:09.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:09.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(88) , send fd(15), pid(6791), cmd(0)
06-12 13:37:09.481+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:37:09:480,0.005610,0.015319,-0.061172
06-12 13:37:09.481+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6871
06-12 13:37:09.501+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.501+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.501+0200 I/light   ( 6871): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.501+0200 I/light   ( 6871): es.ugr.frailty.light - capturing data
06-12 13:37:09.501+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:09.501+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(38) , send fd(15), pid(6788), cmd(0)
06-12 13:37:09.511+0200 I/light   ( 6871): es.ugr.frailty.light: SM-R760,12/06/2018,13:37:09:511,187.000000
06-12 13:37:09.511+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6847
06-12 13:37:09.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.531+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.541+0200 I/gravity ( 6847): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.541+0200 I/gravity ( 6847): es.ugr.frailty.gravity - capturing data
06-12 13:37:09.541+0200 I/gravity ( 6847): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:37:09:544,-0.168275,9.738044,1.145673
06-12 13:37:09.541+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.551+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6796
06-12 13:37:09.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.571+0200 W/AUL     ( 6796): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.571+0200 I/gyroscope( 6796): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.571+0200 I/gyroscope( 6796): es.ugr.frailty.gyroscope - capturing data
06-12 13:37:09.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6794
06-12 13:37:09.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.591+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.591+0200 I/accelerometer( 6794): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.591+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer - capturing data
06-12 13:37:09.591+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:37:09:599,-0.162712,9.753145,1.086342
06-12 13:37:09.591+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.601+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6788
06-12 13:37:09.611+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6791
06-12 13:37:09.611+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.611+0200 I/utils   ( 6791): specific action
06-12 13:37:09.611+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.611+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.611+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.611+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.611+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.611+0200 I/recorder( 6791): saving local data for es.ugr.frailty.linearacceleration
06-12 13:37:09.611+0200 I/recorder( 6791): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 13:37:09.621+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6791)
06-12 13:37:09.621+0200 I/servicemanager( 6788): request sent to service es.ugr.frailty.recorder
06-12 13:37:09.621+0200 I/servicemanager( 6788): requesting to save local data
06-12 13:37:09.621+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.621+0200 I/utils   ( 6788): specific action
06-12 13:37:09.621+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.621+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.621+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.621+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.621+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.621+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.621+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.621+0200 I/servicemanager( 6788): requesting to save local data for es.ugr.frailty.light
06-12 13:37:09.621+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:37:09.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6834
06-12 13:37:09.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.641+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:09.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(6788), cmd(0)
06-12 13:37:09.651+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.661+0200 I/linearacceleration( 6834): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.661+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration - capturing data
06-12 13:37:09.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:09.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(92) , send fd(15), pid(6791), cmd(0)
06-12 13:37:09.661+0200 I/linearacceleration( 6834): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:37:09:665,0.034277,0.024673,-0.047368
06-12 13:37:09.661+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6871
06-12 13:37:09.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.681+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.681+0200 I/light   ( 6871): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.681+0200 I/light   ( 6871): es.ugr.frailty.light - capturing data
06-12 13:37:09.681+0200 I/light   ( 6871): es.ugr.frailty.light: SM-R760,12/06/2018,13:37:09:689,187.000000
06-12 13:37:09.681+0200 W/AUL     ( 6871): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:37:09.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6847
06-12 13:37:09.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 13:37:09.701+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 13:37:09.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:37:09.701+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 13:37:09.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 13:37:09.701+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 13:37:09.701+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 13:37:09.701+0200 E/CAPI_LOCATION_MANAGER( 6901): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 13:37:09.701+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 13:37:09.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.711+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:37:09.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.731+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6794
06-12 13:37:09.741+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.761+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6788
06-12 13:37:09.761+0200 I/heartrate( 6818): es.ugr.frailty.heartrate - capturing data
06-12 13:37:09.761+0200 I/heartrate( 6818): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:37:09.761+0200 W/AUL     ( 6794): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.761+0200 I/accelerometer( 6794): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.761+0200 I/accelerometer( 6794): es.ugr.frailty.accelerometer - capturing data
06-12 13:37:09.791+0200 W/AUL     ( 6847): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.791+0200 I/gravity ( 6847): request sent to service es.ugr.frailty.servicemanager
06-12 13:37:09.791+0200 I/gravity ( 6847): es.ugr.frailty.gravity - capturing data
06-12 13:37:09.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6791
06-12 13:37:09.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.801+0200 I/utils   ( 6791): specific action
06-12 13:37:09.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.801+0200 W/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.801+0200 I/recorder( 6791): saving local data for es.ugr.frailty.light
06-12 13:37:09.801+0200 W/AUL     ( 6788): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6791)
06-12 13:37:09.801+0200 I/servicemanager( 6788): request sent to service es.ugr.frailty.recorder
06-12 13:37:09.801+0200 I/servicemanager( 6788): requesting to save local data
06-12 13:37:09.821+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.821+0200 I/recorder( 6791): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 13:37:09.821+0200 I/utils   ( 6788): specific action
06-12 13:37:09.821+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.821+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.821+0200 I/CAPI_NETWORK_CONNECTION( 6901): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 13:37:09.821+0200 I/CAPI_NETWORK_CONNECTION( 6901): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 13:37:09.821+0200 I/CAPI_NETWORK_CONNECTION( 6901): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 13:37:09.821+0200 I/CAPI_NETWORK_CONNECTION( 6901): connection.c: connection_destroy(471) > Destroy handle: 0xf776e788
06-12 13:37:09.821+0200 W/CAPI_APPFW_APP_CONTROL( 6788): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:37:09.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:37:09.841+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 6834
06-12 13:37:09.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6788
06-12 13:37:09.861+0200 W/AUL     ( 6834): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6788)
06-12 13:37:09.861+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:37:09.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(39) , send fd(15), pid(6788), cmd(0)
06-12 13:37:09.871+0200 W/CRASH_MANAGER( 6915): worker.c: worker_job(1205) > 11068316c6f63152880342
