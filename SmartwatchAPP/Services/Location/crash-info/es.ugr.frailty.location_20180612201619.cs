S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23685
Date: 2018-06-12 20:16:19+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf772652d, r5   = 0xf7efffe0
r6   = 0xff97ee28, r7   = 0xff97ecd8
r8   = 0xf7ed1c18, r9   = 0x00000000
r10  = 0xff97edb4, fp   = 0xff97ee28
ip   = 0x00000001, sp   = 0xff97ecb0
lr   = 0xf7726539, pc   = 0xf778f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    111812 KB
Buffers:     51848 KB
Cached:     176076 KB
VmPeak:      53444 KB
VmSize:      53384 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11824 KB
VmRSS:       11820 KB
VmData:      11112 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23685 TID = 23685
23685 23686 

Maps Information
f45f1000 f4df0000 rw-p [stack:23686]
f4df7000 f4df9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e01000 f4e05000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e0e000 f4e10000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e18000 f4e1b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e2a000 f4e2f000 r-xp /usr/lib/libsystem.so.0.0.0
f4e3a000 f4e3d000 r-xp /lib/libattr.so.1.1.0
f4e45000 f4e55000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e5d000 f4e66000 r-xp /usr/lib/libedbus.so.1.7.99
f4e6e000 f4e6f000 r-xp /usr/lib/libresponse.so.0.2.96
f4e78000 f4e7d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f671f000 f6825000 r-xp /usr/lib/libicuuc.so.57.1
f683b000 f69c3000 r-xp /usr/lib/libicui18n.so.57.1
f69d3000 f69e0000 r-xp /usr/lib/libail.so.0.1.0
f69e9000 f69f0000 r-xp /usr/lib/libminizip.so.1.0.0
f69f9000 f6ba2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bc2000 f6c09000 r-xp /usr/lib/libssl.so.1.0.0
f6c15000 f6c17000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c1f000 f6c26000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c2f000 f6c36000 r-xp /lib/libcrypt-2.13.so
f6c67000 f6c6a000 r-xp /lib/libcap.so.2.21
f6c72000 f6c74000 r-xp /usr/lib/libiri.so
f6c7c000 f6cc5000 r-xp /usr/lib/libmdm.so.1.2.69
f6ccd000 f6cd3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cdb000 f6cfe000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d08000 f6d0a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d12000 f6d2f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d38000 f6d3c000 r-xp /usr/lib/libsmack.so.1.0.0
f6d45000 f6d5e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d67000 f6d6f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d77000 f6d7d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d86000 f6d88000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d91000 f6da1000 r-xp /lib/libresolv-2.13.so
f6da5000 f6dbd000 r-xp /usr/lib/liblzma.so.5.0.3
f6dc6000 f6dc8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6dd0000 f6dea000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6df2000 f6e21000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e2a000 f6e39000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e43000 f6e4d000 r-xp /usr/lib/libsensord-shared.so
f6e56000 f6f29000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f34000 f6f4a000 r-xp /lib/libz.so.1.2.5
f6f52000 f6f57000 r-xp /usr/lib/libffi.so.5.0.10
f6f5f000 f6f60000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f68000 f6f78000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f80000 f6f99000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fa1000 f6fa3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fab000 f7020000 r-xp /usr/lib/libsqlite3.so.0.8.6
f702a000 f7030000 r-xp /lib/librt-2.13.so
f7039000 f7057000 r-xp /usr/lib/libsystemd.so.0.4.0
f7061000 f7062000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f706a000 f708d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7095000 f709a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70a2000 f70cc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70d5000 f70ec000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70f4000 f715d000 r-xp /lib/libm-2.13.so
f7166000 f71fa000 r-xp /usr/lib/libstdc++.so.6.0.16
f720d000 f7212000 r-xp /usr/lib/libctx-client.so.0.8.3
f721a000 f7221000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7229000 f7253000 r-xp /usr/lib/libsensor.so.1.9.6
f725c000 f7328000 r-xp /usr/lib/libxml2.so.2.7.8
f7335000 f7337000 r-xp /usr/lib/libiniparser.so.0
f7340000 f7346000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f734f000 f741f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7420000 f7454000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f745d000 f7499000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74a1000 f74a4000 r-xp /usr/lib/libbundle.so.0.1.22
f74ac000 f74b2000 r-xp /usr/lib/libappsvc.so.0.1.0
f74ba000 f74fb000 r-xp /usr/lib/libeina.so.1.7.99
f7504000 f751b000 r-xp /usr/lib/libecore.so.1.7.99
f7532000 f753b000 r-xp /usr/lib/libvconf.so.0.2.45
f7543000 f7557000 r-xp /lib/libpthread-2.13.so
f7562000 f756f000 r-xp /usr/lib/libaul.so.0.1.0
f7579000 f757b000 r-xp /lib/libdl-2.13.so
f7584000 f758f000 r-xp /lib/libunwind.so.8.0.1
f75bc000 f75c4000 r-xp /lib/libgcc_s-4.6.so.1
f75c5000 f76e9000 r-xp /lib/libc-2.13.so
f76f7000 f76f9000 r-xp /usr/lib/libdlog.so.0.0.0
f7701000 f770d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7716000 f771b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7723000 f7732000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f773a000 f773e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7747000 f774a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7752000 f7754000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f775c000 f7760000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7768000 f7785000 r-xp /lib/ld-2.13.so
f778e000 f7791000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7791000 f7795000 r-xp /usr/lib/libsys-assert.so
f7ecb000 f7f2a000 rw-p [heap]
ff960000 ff981000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23685)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf778f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7726539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf742d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf742bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7437e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf743dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf743ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf747275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf746d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf742bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7437e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf743dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf743ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf746fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7470017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74748d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf775e0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4e02171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ed5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7382fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73847a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7514ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf750fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf75105a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7510879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7748183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77487fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf778f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75dc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf778ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 request cmd(0) result(23641)
06-12 20:16:16.411+0200 I/light   (23729): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:16.411+0200 I/light   (23729): es.ugr.frailty.light - capturing data
06-12 20:16:16.411+0200 I/light   (23729): es.ugr.frailty.light: SM-R760,12/06/2018,20:16:16:417,136.000000
06-12 20:16:16.411+0200 W/AUL     (23729): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:16.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:16.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:16.451+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:16.451+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:16.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 20:16:16.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:16.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23648
06-12 20:16:16.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:16.541+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:16.541+0200 I/accelerometer(23648): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:16.541+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer - capturing data
06-12 20:16:16.551+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,20:16:16:554,3.381058,1.440479,9.102298
06-12 20:16:16.551+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:16.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:16.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:16.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:16.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23700
06-12 20:16:16.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:16.631+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:16.631+0200 I/gravity (23700): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:16.631+0200 I/gravity (23700): es.ugr.frailty.gravity - capturing data
06-12 20:16:16.641+0200 I/gravity (23700): es.ugr.frailty.gravity: SM-R760,12/06/2018,20:16:16:644,3.454040,-1.125298,9.108990
06-12 20:16:16.641+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:16.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:16.651+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:16.651+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:16.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:16.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23687
06-12 20:16:16.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:16.711+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:16.721+0200 I/linearacceleration(23687): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:16.721+0200 I/linearacceleration(23687): es.ugr.frailty.linearacceleration - capturing data
06-12 20:16:16.731+0200 I/linearacceleration(23687): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,20:16:16:726,-0.040665,-0.432647,0.148587
06-12 20:16:16.731+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:16.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 20:16:16.771+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:16.771+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-12 20:16:16.801+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:16.801+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:16.801+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-12 20:16:16.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:16.811+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23641
06-12 20:16:16.821+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-12 20:16:16.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23644
06-12 20:16:16.831+0200 W/CAPI_APPFW_APP_CONTROL(23644): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:16.831+0200 I/utils   (23644): specific action
06-12 20:16:16.831+0200 W/CAPI_APPFW_APP_CONTROL(23644): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:16.831+0200 I/recorder(23644): saving local data for es.ugr.frailty.accelerometer
06-12 20:16:16.831+0200 I/recorder(23644): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 20:16:16.851+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:16.851+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:16.861+0200 W/AUL     (23641): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23644)
06-12 20:16:16.861+0200 I/servicemanager(23641): request sent to service es.ugr.frailty.recorder
06-12 20:16:16.861+0200 I/servicemanager(23641): requesting to save local data
06-12 20:16:16.861+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:16.861+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:16.861+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:16.861+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:16.861+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:16.861+0200 I/utils   (23641): specific action
06-12 20:16:16.861+0200 I/servicemanager(23641): requesting to save local data for es.ugr.frailty.accelerometer
06-12 20:16:16.861+0200 W/AUL     (23641): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 20:16:16.911+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 20:16:16.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 20:16:16.911+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 20:16:16.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:16.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23651
06-12 20:16:16.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:16.961+0200 W/AUL     (23651): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:16.961+0200 I/gyroscope(23651): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:16.961+0200 I/gyroscope(23651): es.ugr.frailty.gyroscope - capturing data
06-12 20:16:16.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 20:16:16.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 20:16:16.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 20:16:16.971+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 20:16:16.971+0200 I/gyroscope(23651): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,20:16:16:972,1.050000,-0.280000,-0.140000
06-12 20:16:16.971+0200 W/AUL     (23651): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:16.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:16.991+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 20:16:16.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(23644), cmd(0)
06-12 20:16:16.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:16.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:17.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:17.031+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23729
06-12 20:16:17.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:17.051+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:17.051+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:17.071+0200 W/AUL     (23729): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:17.071+0200 I/light   (23729): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:17.071+0200 I/light   (23729): es.ugr.frailty.light - capturing data
06-12 20:16:17.081+0200 I/light   (23729): es.ugr.frailty.light: SM-R760,12/06/2018,20:16:17:84,136.000000
06-12 20:16:17.081+0200 W/AUL     (23729): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:17.091+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:17.091+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:17.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 20:16:17.141+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23743
06-12 20:16:17.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:17.181+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23648
06-12 20:16:17.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:17.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:17.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:17.221+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:17.221+0200 I/accelerometer(23648): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:17.231+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer - capturing data
06-12 20:16:17.231+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,20:16:17:237,3.390630,-1.129412,10.437491
06-12 20:16:17.231+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:17.251+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:17.251+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:17.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:17.271+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23700
06-12 20:16:17.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:17.311+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:17.311+0200 I/gravity (23700): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:17.321+0200 I/gravity (23700): es.ugr.frailty.gravity - capturing data
06-12 20:16:17.321+0200 I/gravity (23700): es.ugr.frailty.gravity: SM-R760,12/06/2018,20:16:17:325,3.451102,-1.132794,9.109174
06-12 20:16:17.321+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:17.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:17.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:17.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23687
06-12 20:16:17.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:17.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:17.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:17.411+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:17.421+0200 I/linearacceleration(23687): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:17.421+0200 I/linearacceleration(23687): es.ugr.frailty.linearacceleration - capturing data
06-12 20:16:17.421+0200 I/linearacceleration(23687): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,20:16:17:426,0.006076,-0.350179,0.138820
06-12 20:16:17.431+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:17.431+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:17.451+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:17.451+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:17.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:17.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23641
06-12 20:16:17.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23644
06-12 20:16:17.481+0200 W/CAPI_APPFW_APP_CONTROL(23644): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:17.481+0200 I/utils   (23644): specific action
06-12 20:16:17.481+0200 W/CAPI_APPFW_APP_CONTROL(23644): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:17.481+0200 I/recorder(23644): saving local data for es.ugr.frailty.accelerometer
06-12 20:16:17.481+0200 I/recorder(23644): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 20:16:17.511+0200 W/AUL     (23641): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23644)
06-12 20:16:17.511+0200 I/servicemanager(23641): request sent to service es.ugr.frailty.recorder
06-12 20:16:17.511+0200 I/servicemanager(23641): requesting to save local data
06-12 20:16:17.511+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:17.511+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:17.511+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:17.511+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:17.511+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:17.511+0200 I/utils   (23641): specific action
06-12 20:16:17.511+0200 I/servicemanager(23641): requesting to save local data for es.ugr.frailty.accelerometer
06-12 20:16:17.511+0200 W/AUL     (23641): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 20:16:17.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 20:16:17.561+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23743
06-12 20:16:17.561+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:17.571+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 20:16:17.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(23644), cmd(0)
06-12 20:16:17.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:17.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:17.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:17.621+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23651
06-12 20:16:17.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:17.651+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:17.651+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:17.661+0200 W/AUL     (23651): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:17.661+0200 I/gyroscope(23651): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:17.661+0200 I/gyroscope(23651): es.ugr.frailty.gyroscope - capturing data
06-12 20:16:17.671+0200 I/gyroscope(23651): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,20:16:17:674,1.260000,0.560000,0.210000
06-12 20:16:17.671+0200 W/AUL     (23651): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:17.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:17.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:17.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23729
06-12 20:16:17.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:17.761+0200 W/AUL     (23729): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:17.761+0200 I/light   (23729): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:17.761+0200 I/light   (23729): es.ugr.frailty.light - capturing data
06-12 20:16:17.761+0200 I/light   (23729): es.ugr.frailty.light: SM-R760,12/06/2018,20:16:17:769,136.000000
06-12 20:16:17.761+0200 W/AUL     (23729): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:17.771+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:17.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:17.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:17.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 20:16:17.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:17.851+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23648
06-12 20:16:17.851+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:17.851+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:17.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:17.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:17.941+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:17.941+0200 I/accelerometer(23648): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:17.941+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer - capturing data
06-12 20:16:17.951+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,20:16:17:953,3.842873,-1.947758,9.293723
06-12 20:16:17.951+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:17.951+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 20:16:17.951+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 20:16:17.951+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 20:16:17.951+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23700
06-12 20:16:17.961+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 20:16:17.961+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 20:16:17.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 20:16:17.971+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 20:16:17.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:17.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:17.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:18.001+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:18.001+0200 I/gravity (23700): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:18.001+0200 I/gravity (23700): es.ugr.frailty.gravity - capturing data
06-12 20:16:18.011+0200 I/gravity (23700): es.ugr.frailty.gravity: SM-R760,12/06/2018,20:16:18:7,3.448507,-1.141572,9.109061
06-12 20:16:18.011+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:18.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:18.051+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:18.051+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:18.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:18.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23687
06-12 20:16:18.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:18.091+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:18.091+0200 I/linearacceleration(23687): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:18.091+0200 I/linearacceleration(23687): es.ugr.frailty.linearacceleration - capturing data
06-12 20:16:18.101+0200 I/linearacceleration(23687): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,20:16:18:104,-0.008338,-0.340009,0.131563
06-12 20:16:18.101+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:18.111+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:18.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:18.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23641
06-12 20:16:18.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23644
06-12 20:16:18.151+0200 W/CAPI_APPFW_APP_CONTROL(23644): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.151+0200 I/utils   (23644): specific action
06-12 20:16:18.151+0200 W/CAPI_APPFW_APP_CONTROL(23644): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.151+0200 I/recorder(23644): saving local data for es.ugr.frailty.accelerometer
06-12 20:16:18.151+0200 I/recorder(23644): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 20:16:18.181+0200 W/AUL     (23641): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23644)
06-12 20:16:18.181+0200 I/servicemanager(23641): request sent to service es.ugr.frailty.recorder
06-12 20:16:18.181+0200 I/servicemanager(23641): requesting to save local data
06-12 20:16:18.181+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:18.181+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:18.181+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:18.191+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:18.191+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.191+0200 I/utils   (23641): specific action
06-12 20:16:18.191+0200 I/servicemanager(23641): requesting to save local data for es.ugr.frailty.accelerometer
06-12 20:16:18.191+0200 W/AUL     (23641): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 20:16:18.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:18.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:18.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 20:16:18.231+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:18.251+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 20:16:18.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(23644), cmd(0)
06-12 20:16:18.251+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:18.251+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:18.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:18.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23651
06-12 20:16:18.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:18.331+0200 W/AUL     (23651): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:18.331+0200 I/gyroscope(23651): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:18.331+0200 I/gyroscope(23651): es.ugr.frailty.gyroscope - capturing data
06-12 20:16:18.341+0200 I/gyroscope(23651): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,20:16:18:344,0.770000,0.070000,-0.070000
06-12 20:16:18.341+0200 W/AUL     (23651): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:18.351+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:18.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:18.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23729
06-12 20:16:18.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:18.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:18.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:18.421+0200 W/AUL     (23729): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:18.421+0200 I/light   (23729): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:18.421+0200 I/light   (23729): es.ugr.frailty.light - capturing data
06-12 20:16:18.431+0200 I/light   (23729): es.ugr.frailty.light: SM-R760,12/06/2018,20:16:18:430,136.000000
06-12 20:16:18.441+0200 W/AUL     (23729): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:18.441+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:18.451+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:18.451+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:18.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:18.481+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23648
06-12 20:16:18.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:18.511+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:18.511+0200 I/accelerometer(23648): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:18.521+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer - capturing data
06-12 20:16:18.521+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,20:16:18:526,3.419343,-1.160519,9.241080
06-12 20:16:18.521+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:18.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:18.571+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23700
06-12 20:16:18.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:18.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:18.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:18.611+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:18.611+0200 I/gravity (23700): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:18.611+0200 I/gravity (23700): es.ugr.frailty.gravity - capturing data
06-12 20:16:18.611+0200 I/gravity (23700): es.ugr.frailty.gravity: SM-R760,12/06/2018,20:16:18:619,3.447471,-1.151625,9.108188
06-12 20:16:18.611+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:18.651+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:18.651+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:18.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:18.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23687
06-12 20:16:18.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:18.701+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:18.701+0200 I/linearacceleration(23687): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:18.701+0200 I/linearacceleration(23687): es.ugr.frailty.linearacceleration - capturing data
06-12 20:16:18.711+0200 I/linearacceleration(23687): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,20:16:18:709,-0.027093,-0.300628,0.095223
06-12 20:16:18.711+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:18.711+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:18.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:18.761+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23641
06-12 20:16:18.771+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23644
06-12 20:16:18.781+0200 W/CAPI_APPFW_APP_CONTROL(23644): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.781+0200 I/utils   (23644): specific action
06-12 20:16:18.781+0200 W/CAPI_APPFW_APP_CONTROL(23644): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.781+0200 I/recorder(23644): saving local data for es.ugr.frailty.accelerometer
06-12 20:16:18.781+0200 I/recorder(23644): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 20:16:18.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:18.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:18.811+0200 W/AUL     (23641): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23644)
06-12 20:16:18.811+0200 I/servicemanager(23641): request sent to service es.ugr.frailty.recorder
06-12 20:16:18.811+0200 I/servicemanager(23641): requesting to save local data
06-12 20:16:18.811+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:18.811+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:18.811+0200 E/AUL     (23641): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 20:16:18.811+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.811+0200 I/utils   (23641): specific action
06-12 20:16:18.811+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.811+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.811+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.811+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.811+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.811+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.811+0200 W/CAPI_APPFW_APP_CONTROL(23641): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 20:16:18.811+0200 I/servicemanager(23641): requesting to save local data for es.ugr.frailty.light
06-12 20:16:18.811+0200 W/AUL     (23641): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 20:16:18.821+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:18.851+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:18.851+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:18.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:18.871+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23651
06-12 20:16:18.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:18.921+0200 W/AUL     (23651): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:18.921+0200 I/gyroscope(23651): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:18.921+0200 I/gyroscope(23651): es.ugr.frailty.gyroscope - capturing data
06-12 20:16:18.931+0200 I/gyroscope(23651): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,20:16:18:932,0.910000,0.280000,0.070000
06-12 20:16:18.931+0200 W/AUL     (23651): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:18.941+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23480) > _wms_event_handler_cb_nomove_detector is called
06-12 20:16:18.951+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 20:16:18.951+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(55) , send fd(21), pid(23644), cmd(0)
06-12 20:16:18.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:19.001+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23729
06-12 20:16:19.011+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:19.011+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:19.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:19.031+0200 W/gpsd    ( 3103): CALL_SENTRY(main()): GlEngine::ChipData took 115 ms (from 24771138 to 24771253) (logOverhead=0,0,0,0,0,0,0), start: 20:16:18.923
06-12 20:16:19.031+0200 W/gpsd    ( 3103): CALL_SENTRY(main()): ProcessEvent took 115 ms (from 24771138 to 24771253) (logOverhead=0,0,0,0,0,0,0), start: 20:16:18.923
06-12 20:16:19.031+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 20:16:19.031+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
06-12 20:16:19.041+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
06-12 20:16:19.041+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 20:16:19.041+0200 E/CAPI_LOCATION_MANAGER(23701): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 20:16:19.051+0200 I/AUL     (23701): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 20:16:19.051+0200 W/AUL     (23729): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:19.061+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:19.061+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:19.071+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 20:16:19.071+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 20:16:19.071+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 20:16:19.071+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 20:16:19.081+0200 I/AUL     (23701): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 20:16:19.081+0200 E/LOCATION(23701): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
06-12 20:16:19.081+0200 I/LOCATION(23701): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
06-12 20:16:19.081+0200 I/LOCATION(23701): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 20:16:19.081+0200 I/light   (23729): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:19.071+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:19.081+0200 I/light   (23729): es.ugr.frailty.light - capturing data
06-12 20:16:19.091+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:19.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:19.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23648
06-12 20:16:19.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:19.151+0200 I/light   (23729): es.ugr.frailty.light: SM-R760,12/06/2018,20:16:19:91,136.000000
06-12 20:16:19.151+0200 W/AUL     (23729): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:19.151+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:19.151+0200 I/accelerometer(23648): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:19.151+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer - capturing data
06-12 20:16:19.161+0200 I/accelerometer(23648): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,20:16:19:164,3.450450,-1.375873,9.157332
06-12 20:16:19.161+0200 W/AUL     (23648): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:19.171+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:19.181+0200 I/LOCATION(23685): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 20:16:19.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:19.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:19.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:19.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23700
06-12 20:16:19.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:19.251+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:19.251+0200 I/heartrate(23672): es.ugr.frailty.heartrate: waiting for rigth values
06-12 20:16:19.261+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:19.261+0200 I/gravity (23700): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:19.261+0200 I/gravity (23700): es.ugr.frailty.gravity - capturing data
06-12 20:16:19.291+0200 I/gravity (23700): es.ugr.frailty.gravity: SM-R760,12/06/2018,20:16:19:265,3.445549,-1.160644,9.107771
06-12 20:16:19.291+0200 W/AUL     (23700): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 20:16:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:19.301+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23687
06-12 20:16:19.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:19.361+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:19.361+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:19.361+0200 I/linearacceleration(23687): request sent to service es.ugr.frailty.servicemanager
06-12 20:16:19.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:19.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:19.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:19.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23641
06-12 20:16:19.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
06-12 20:16:19.411+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 20:16:19.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
06-12 20:16:19.411+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 20:16:19.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
06-12 20:16:19.411+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 20:16:19.411+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 20:16:19.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23644
06-12 20:16:19.411+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 20:16:19.411+0200 E/CAPI_LOCATION_MANAGER(23701): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 20:16:19.421+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 20:16:19.461+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(23641) cmd(0)
06-12 20:16:19.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:19.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23651
06-12 20:16:19.501+0200 W/AUL     (23641): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23644)
06-12 20:16:19.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:19.551+0200 W/AUL     (23651): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23641)
06-12 20:16:19.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 20:16:19.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 23729
06-12 20:16:19.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 20:16:19.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 20:16:19.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23641
06-12 20:16:19.601+0200 I/CAPI_NETWORK_CONNECTION(23701): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 20:16:19.601+0200 I/CAPI_NETWORK_CONNECTION(23701): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 20:16:19.601+0200 I/CAPI_NETWORK_CONNECTION(23701): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 20:16:19.601+0200 I/CAPI_NETWORK_CONNECTION(23701): connection.c: connection_destroy(471) > Destroy handle: 0xf74d8828
06-12 20:16:19.601+0200 I/heartrate(23672): es.ugr.frailty.heartrate - capturing data
06-12 20:16:19.621+0200 W/CRASH_MANAGER(23768): worker.c: worker_job(1205) > 11236856c6f63152882737
