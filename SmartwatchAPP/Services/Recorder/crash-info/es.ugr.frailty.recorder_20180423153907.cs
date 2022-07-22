S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 16327
Date: 2018-04-23 15:39:07+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf74ba250, r1   = 0x00000000
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf76fa3e0, r5   = 0x00000170
r6   = 0xf76fa550, r7   = 0xf74ba250
r8   = 0x000005e0, r9   = 0xf6f9d824
r10  = 0xf76dd9d8, fp   = 0x00000000
ip   = 0xf74b9030, sp   = 0xff860b48
lr   = 0xf73fd5d0, pc   = 0xf73f99fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     33964 KB
Buffers:     54372 KB
Cached:     231660 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7760 KB
VmRSS:        7756 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6b34000 f6b37000 r-xp /lib/libattr.so.1.1.0
f6b40000 f6b47000 r-xp /lib/libcrypt-2.13.so
f6b77000 f6b7a000 r-xp /lib/libcap.so.2.21
f6b82000 f6b84000 r-xp /usr/lib/libiri.so
f6b8c000 f6ba9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bb2000 f6bb6000 r-xp /usr/lib/libsmack.so.1.0.0
f6bc0000 f6bc2000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bca000 f6bcf000 r-xp /usr/lib/libffi.so.5.0.10
f6bd7000 f6bd8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6be0000 f6be2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bea000 f6bec000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bf6000 f6c06000 r-xp /lib/libresolv-2.13.so
f6c0a000 f6c22000 r-xp /usr/lib/liblzma.so.5.0.3
f6c2a000 f6c2c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c34000 f6c63000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c6c000 f6c7b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c84000 f6c8e000 r-xp /usr/lib/libsensord-shared.so
f6c97000 f6ccb000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cd4000 f6da7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6db2000 f6dc8000 r-xp /lib/libz.so.1.2.5
f6dd0000 f6dd6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ddf000 f6e54000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e5e000 f6e78000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e80000 f6e86000 r-xp /lib/librt-2.13.so
f6e8f000 f6ead000 r-xp /usr/lib/libsystemd.so.0.4.0
f6eb7000 f6eb8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ec0000 f6ec5000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ecd000 f6f9d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f9e000 f6fc8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fd1000 f6fe8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ff0000 f7059000 r-xp /lib/libm-2.13.so
f7062000 f70f6000 r-xp /usr/lib/libstdc++.so.6.0.16
f7109000 f710e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7116000 f711d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7125000 f714f000 r-xp /usr/lib/libsensor.so.1.9.6
f7158000 f7224000 r-xp /usr/lib/libxml2.so.2.7.8
f7231000 f7233000 r-xp /usr/lib/libiniparser.so.0
f723c000 f723f000 r-xp /usr/lib/libbundle.so.0.1.22
f7247000 f724d000 r-xp /usr/lib/libappsvc.so.0.1.0
f7255000 f7278000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7280000 f72c1000 r-xp /usr/lib/libeina.so.1.7.99
f72ca000 f72e1000 r-xp /usr/lib/libecore.so.1.7.99
f72f8000 f7301000 r-xp /usr/lib/libvconf.so.0.2.45
f7309000 f731d000 r-xp /lib/libpthread-2.13.so
f7328000 f7335000 r-xp /usr/lib/libaul.so.0.1.0
f733f000 f7341000 r-xp /lib/libdl-2.13.so
f734a000 f7355000 r-xp /lib/libunwind.so.8.0.1
f7382000 f738a000 r-xp /lib/libgcc_s-4.6.so.1
f738b000 f74af000 r-xp /lib/libc-2.13.so
f74bd000 f74bf000 r-xp /usr/lib/libdlog.so.0.0.0
f74c7000 f74d3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74dc000 f74e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74e9000 f74ed000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74f6000 f74f8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7501000 f7504000 r-xp /usr/lib/libappcore-agent.so.1.1
f7522000 f753f000 r-xp /lib/ld-2.13.so
f7548000 f754b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f754b000 f754f000 r-xp /usr/lib/libsys-assert.so
f76d3000 f7721000 rw-p [heap]
ff842000 ff863000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16327)
Call Stack Count: 1
 0: (0xf73f99fc) [/lib/libc.so.6] + 0x6e9fc
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: recorder
App ID: es.ugr.frailty.recorder
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:39:06.871+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16286]
04-23 15:39:06.871+0200 E/accelerometer(16283): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:39:06.871+0200 I/CAPI_APPFW_APPLICATION(16283): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:39:06.881+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16283
04-23 15:39:06.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:39:06.881+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 16055
04-23 15:39:06.891+0200 I/utils   (16286): es.ugr.frailty.gyroscope listener started
04-23 15:39:06.891+0200 I/gyroscope(16286): stopping es.ugr.frailty.gyroscope service
04-23 15:39:06.891+0200 E/CAPI_APPFW_APP_CONTROL(16286): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:39:06.891+0200 E/gyroscope(16286): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:39:06.891+0200 I/CAPI_APPFW_APPLICATION(16286): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:39:06.891+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 16306
04-23 15:39:06.891+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:39:06.941+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16306
04-23 15:39:06.941+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(16306) type(svcapp) bg(0)
04-23 15:39:06.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:39:06.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:39:06.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:39:06.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:39:06.941+0200 E/CAPI_APPFW_APPLICATION(16306): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:39:06.941+0200 E/CAPI_APPFW_APPLICATION(16306): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:39:06.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:39:06.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:39:06.951+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (16306) was created
04-23 15:39:06.951+0200 I/utils   (16306): trying to start service: es.ugr.frailty.heartrate
04-23 15:39:06.951+0200 W/AUL     (16055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16306)
04-23 15:39:06.961+0200 I/utils   (16306): es.ugr.frailty.heartrate sensor supported
04-23 15:39:06.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:39:06.971+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16286
04-23 15:39:06.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:39:06.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:39:06.981+0200 I/utils   (16306): es.ugr.frailty.heartrate listener started
04-23 15:39:06.981+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16286
04-23 15:39:06.981+0200 I/heartrate(16306): stopping es.ugr.frailty.heartrate service
04-23 15:39:06.981+0200 E/CAPI_APPFW_APP_CONTROL(16306): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:39:06.981+0200 E/heartrate(16306): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:39:06.981+0200 I/CAPI_APPFW_APPLICATION(16306): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:39:06.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:39:06.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:39:06.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:39:06.991+0200 I/servicemanager(16055): es.ugr.frailty.heartrate stop request sent!
04-23 15:39:06.991+0200 I/servicemanager(16055): App control destroyed.
04-23 15:39:07.001+0200 W/AUL     (16055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:39:07.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:39:07.001+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 16055
04-23 15:39:07.001+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16306]
04-23 15:39:07.011+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 16323
04-23 15:39:07.031+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:39:07.041+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:39:07.061+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:39:07.061+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16323
04-23 15:39:07.061+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(16323) type(svcapp) bg(0)
04-23 15:39:07.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:39:07.071+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16306
04-23 15:39:07.081+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16323]
04-23 15:39:07.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:39:07.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:39:07.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16323
04-23 15:39:07.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:39:07.111+0200 W/AUL     (16055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16323)
04-23 15:39:07.111+0200 I/servicemanager(16055): es.ugr.frailty.location stop request sent!
04-23 15:39:07.111+0200 I/servicemanager(16055): App control destroyed.
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:573 _ecore_magic_fail() 
04-23 15:39:07.111+0200 E/EFL     (16055): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** IN FUNCTION: ecore_timer_del()
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** SPANK SPANK SPANK!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** Now go fix your code. Tut tut tut!
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 0
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:573 _ecore_magic_fail() 
04-23 15:39:07.111+0200 E/EFL     (16055): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** IN FUNCTION: ecore_timer_del()
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** SPANK SPANK SPANK!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** Now go fix your code. Tut tut tut!
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 1
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:573 _ecore_magic_fail() 
04-23 15:39:07.111+0200 E/EFL     (16055): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** IN FUNCTION: ecore_timer_del()
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** SPANK SPANK SPANK!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** Now go fix your code. Tut tut tut!
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 2
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:573 _ecore_magic_fail() 
04-23 15:39:07.111+0200 E/EFL     (16055): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** IN FUNCTION: ecore_timer_del()
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** SPANK SPANK SPANK!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** Now go fix your code. Tut tut tut!
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 3
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:573 _ecore_magic_fail() 
04-23 15:39:07.111+0200 E/EFL     (16055): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** IN FUNCTION: ecore_timer_del()
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** SPANK SPANK SPANK!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** Now go fix your code. Tut tut tut!
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 4
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:573 _ecore_magic_fail() 
04-23 15:39:07.111+0200 E/EFL     (16055): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** IN FUNCTION: ecore_timer_del()
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** SPANK SPANK SPANK!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** Now go fix your code. Tut tut tut!
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 5
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:573 _ecore_magic_fail() 
04-23 15:39:07.111+0200 E/EFL     (16055): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** IN FUNCTION: ecore_timer_del()
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** SPANK SPANK SPANK!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** Now go fix your code. Tut tut tut!
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 6
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:573 _ecore_magic_fail() 
04-23 15:39:07.111+0200 E/EFL     (16055): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** IN FUNCTION: ecore_timer_del()
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 15:39:07.111+0200 E/EFL     (16055): ecore<16055> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** SPANK SPANK SPANK!!!
04-23 15:39:07.111+0200 E/EFL     (16055): *** Now go fix your code. Tut tut tut!
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 7
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 8
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 9
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 10
04-23 15:39:07.111+0200 I/servicemanager(16055): deleting dead timer 11
04-23 15:39:07.111+0200 W/AUL     (16055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:39:07.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:39:07.111+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 16055
04-23 15:39:07.121+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 16327
04-23 15:39:07.121+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:39:07.131+0200 I/accelerometer(16283): es.ugr.frailty.accelerometer listener destroyed
04-23 15:39:07.141+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:39:07.151+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:39:07.171+0200 E/CAPI_APPFW_APPLICATION(16327): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:39:07.171+0200 E/CAPI_APPFW_APPLICATION(16327): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:39:07.171+0200 I/utils   (16327): specific action
04-23 15:39:07.171+0200 I/recorder(16327): obteniendo datos locales...
04-23 15:39:07.171+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:39:07.181+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:39:07.191+0200 I/recorder(16327): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:08:844,2.569891,-1.143769,9.430114
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:08:944,2.663212,-1.127020,9.382257
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:72,2.419144,-1.237089,9.248260
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:142,2.627320,-1.251446,9.561719
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:243,2.431108,-1.280160,9.578469
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:342,2.524428,-1.201197,9.544970
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:443,2.529213,-1.179662,9.525827
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:543,2.459821,-1.258625,9.590433
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:645,2.553142,-1.215554,9.434900
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:743,2.507678,-1.210768,9.559326
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:844,2.502892,-1.191626,9.439686
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:942,2.529213,-1.225125,9.564112
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:44,2.526821,-1.246661,9.513863
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:143,2.486143,-1.198804,9.537791
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:245,2.579463,-1.225125,9.475577
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:343,2.526821,-1.304088,9.482756
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:444,2.471786,-1.184447,9.489935
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:544,2.579463,-1.323231,9.511470
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:644,2.519642,-1.201197,9.537791
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:744,2.584249,-1.308874,9.487542
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:845,2.502892,-1.316052,9.518648
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:943,2.567499,-1.179662,9.470792
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:46,2.569891,-1.249053,9.473185
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:143,2.569891,-1.282553,9.482756
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:244,2.565106,-1.258625,9.489935
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:344,2.533999,-1.194018,9.547362
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:444,2.529213,-1.162912,9.497113
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:544,2.531606,-1.229911,9.509077
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:645,2.584249,-1.205983,9.485149
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:744,2.589034,-1.215554,9.437292
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:844,2.545963,-1.222732,9.504292
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:944,2.533999,-1.239482,9.489935
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:51,2.524428,-1.170090,9.489935
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:144,2.529213,-1.227518,9.535398
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:245,2.593820,-1.220340,9.489935
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:344,2.567499,-1.213161,9.432507
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:445,2.569891,-1.198804,9.530612
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:545,2.543570,-1.246661,9.461221
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:644,2.560320,-1.203590,9.444471
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:744,2.538785,-1.136591,9.494720
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:845,2.574677,-1.107877,9.497113
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:945,2.589034,-1.141376,9.499505
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:46,2.550749,-1.136591,9.480364
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:144,2.560320,-1.198804,9.556933
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:250,2.608176,-1.198804,9.468399
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:345,2.600998,-1.256232,9.501899
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:445,2.586641,-1.220340,9.477970
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:545,2.555535,-1.177269,9.497113
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:645,2.574677,-1.158126,9.516255
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:745,2.605784,-1.217947,9.494720
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:43:954,1.895115,-2.926422,9.243474
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:44:154,1.818545,-3.012564,9.257831
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:44:353,1.892723,-3.053242,9.284152
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:44:552,1.931008,-2.943172,9.272188
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:44:753,1.868794,-3.079563,9.224331
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:44:954,1.926222,-3.002992,9.358330
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:45:153,2.038685,-2.890530,9.365508
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:45:353,2.002793,-2.892922,9.365508
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:45:553,1.966900,-2.904887,9.317651
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:45:753,1.954936,-2.768496,9.387043
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:45:953,1.950150,-2.924029,9.360723
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:46:153,1.950150,-2.835495,9.303294
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:46:353,2.201397,-2.914458,8.958728
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:46:553,2.005185,-2.943172,8.941978
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:46:753,2.151148,-2.890530,9.820145
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:46:953,1.804188,-2.694318,9.355937
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:47:153,2.050649,-3.235096,9.212367
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:47:354,1.897508,-2.840281,9.466006
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:47:553,1.797010,-3.029313,9.260223
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:47:753,1.854438,-2.763710,9.363115
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:47:953,1.789831,-2.768496,9.427721
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:48:152,1.797010,-2.514857,9.513863
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:48:353,1.842474,-2.737389,9.480364
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:48:553,1.837688,-2.557927,9.518648
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:48:752,1.861616,-2.790031,9.399008
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:48:952,1.883151,-2.488536,9.284152
04-23 15:39:07.191+0200 I/recorder(16327): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 15:39:07.191+0200 I/recorder(16327): obteniendo datos locales, DATA: SM-R760,23/04/2018,15:37:08:844,2.569891,-1.143769,9.430114
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:08:944,2.663212,-1.127020,9.382257
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:72,2.419144,-1.237089,9.248260
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:142,2.627320,-1.251446,9.561719
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:243,2.431108,-1.280160,9.578469
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:342,2.524428,-1.201197,9.544970
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:443,2.529213,-1.179662,9.525827
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:543,2.459821,-1.258625,9.590433
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:645,2.553142,-1.215554,9.434900
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:743,2.507678,-1.210768,9.559326
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:844,2.502892,-1.191626,9.439686
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:942,2.529213,-1.225125,9.564112
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:44,2.526821,-1.246661,9.513863
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:143,2.486143,-1.198804,9.537791
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:245,2.579463,-1.225125,9.475577
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:343,2.526821,-1.304088,9.482756
04-23 15:39:07.191+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:444,2
04-23 15:39:07.191+0200 W/AUL     (16327): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:39:07.191+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16327
04-23 15:39:07.191+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(16327) type(svcapp) bg(0)
04-23 15:39:07.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:39:07.191+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16327]
04-23 15:39:07.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16306
04-23 15:39:07.201+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (16327) was created
04-23 15:39:07.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:39:07.201+0200 W/AUL     (16055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16327)
04-23 15:39:07.201+0200 I/servicemanager(16055): request sent to service es.ugr.frailty.recorder
04-23 15:39:07.201+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 16327
04-23 15:39:07.211+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16055
04-23 15:39:07.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:39:07.221+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16327
04-23 15:39:07.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:39:07.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:39:07.231+0200 W/AUL     (16327): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16055)
04-23 15:39:07.231+0200 I/recorder(16327): request sent to service es.ugr.frailty.servicemanager
04-23 15:39:07.231+0200 I/recorder(16327): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:08:852,6.160000,27.580000,15.050000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:55,-3.360000,5.810000,1.820000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:243,-0.280000,0.700000,0.070000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:444,1.470000,-1.470000,0.630000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:643,1.190000,-0.910000,-0.350000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:09:844,0.140000,0.560000,-0.350000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:43,-0.420000,0.490000,0.210000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:243,-0.420000,0.560000,-0.140000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:446,-0.560000,0.560000,0.140000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:644,0.140000,0.280000,0.140000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:10:844,-0.420000,-0.140000,0.140000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:44,0.140000,-0.560000,0.140000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:246,-0.140000,-0.490000,0.140000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:445,0.420000,0.280000,-0.070000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:646,0.210000,-0.070000,-0.280000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:11:846,0.210000,0.140000,-0.140000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:45,0.140000,-0.350000,0.210000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:246,0.420000,-0.140000,-0.350000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:445,0.420000,0.140000,0.280000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:646,0.350000,0.280000,-0.070000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:12:849,0.350000,-0.210000,-0.070000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:45,0.350000,0.070000,-0.070000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:246,0.560000,0.490000,-0.070000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:446,-0.350000,0.280000,0.490000
04-23 15:39:07.231+0200 I/recorder(16327): SM-R760,23/04/2018,15:37:13:646,0.140000,0.070000,0.490000
04-23 15:39:07.231+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:39:07.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(16055), cmd(0)
04-23 15:39:07.231+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.231+0200 I/utils   (16055): specific action
04-23 15:39:07.231+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.231+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.231+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.231+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.231+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.231+0200 W/AUL     (16055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 15:39:07.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:39:07.231+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 16055
04-23 15:39:07.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16058
04-23 15:39:07.241+0200 W/CAPI_APPFW_APP_CONTROL(16058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.241+0200 I/utils   (16058): specific action
04-23 15:39:07.241+0200 W/CAPI_APPFW_APP_CONTROL(16058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.241+0200 I/httppostreq(16058): requesting HTTP POST Request Service. Service ID: es.ugr.frailty.accelerometer Data received: SM-R760,23/04/2018,15:37:08:844,2.569891,-1.143769,9.430114
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:08:944,2.663212,-1.127020,9.382257
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:72,2.419144,-1.237089,9.248260
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:142,2.627320,-1.251446,9.561719
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:243,2.431108,-1.280160,9.578469
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:342,2.524428,-1.201197,9.544970
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:443,2.529213,-1.179662,9.525827
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:543,2.459821,-1.258625,9.590433
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:645,2.553142,-1.215554,9.434900
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:743,2.507678,-1.210768,9.559326
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:844,2.502892,-1.191626,9.439686
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:942,2.529213,-1.225125,9.564112
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:10:44,2.526821,-1.246661,9.513863
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:10:143,2.486143,-1.198804,9.537791
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:10:245,2.579463,-1.225125,9.475577
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:10:343
04-23 15:39:07.241+0200 I/httppostreq(16058): HTTP POST data service=es.ugr.frailty.accelerometer&data=SM-R760,23/04/2018,15:37:08:844,2.569891,-1.143769,9.430114
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:08:944,2.663212,-1.127020,9.382257
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:72,2.419144,-1.237089,9.248260
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:142,2.627320,-1.251446,9.561719
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:243,2.431108,-1.280160,9.578469
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:342,2.524428,-1.201197,9.544970
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:443,2.529213,-1.179662,9.525827
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:543,2.459821,-1.258625,9.590433
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:645,2.553142,-1.215554,9.434900
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:743,2.507678,-1.210768,9.559326
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:844,2.502892,-1.191626,9.439686
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:09:942,2.529213,-1.225125,9.564112
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:10:44,2.526821,-1.246661,9.513863
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:10:143,2.486143,-1.198804,9.537791
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:10:245,2.579463,-1.225125,9.475577
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,23/04/2018,15:37:10:343,2.526821,-1.304088,9.482756
04-23 15:39:07.241+0200 I/httppostreq(16058): SM-R760,
04-23 15:39:07.241+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:39:07.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(16058), cmd(0)
04-23 15:39:07.241+0200 W/AUL     (16055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16058)
04-23 15:39:07.241+0200 I/servicemanager(16055): request sent to service es.ugr.frailty.httppostreq
04-23 15:39:07.241+0200 I/servicemanager(16055): obteniendo datos locales. Datos recibidos
04-23 15:39:07.251+0200 I/heartrate(16306): es.ugr.frailty.heartrate listener destroyed
04-23 15:39:07.261+0200 I/gyroscope(16286): es.ugr.frailty.gyroscope listener destroyed
04-23 15:39:07.281+0200 W/AUL     (16332): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 15:39:07.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:39:07.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:39:07.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16283
04-23 15:39:07.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:39:07.291+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16283
04-23 15:39:07.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16283)
04-23 15:39:07.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:39:07.311+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16323
04-23 15:39:07.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:39:07.331+0200 W/AUL     (16336): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 15:39:07.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:39:07.331+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:39:07.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16061
04-23 15:39:07.331+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:39:07.331+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16061
04-23 15:39:07.331+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16061)
04-23 15:39:07.341+0200 W/AUL     (16058): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:39:07.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:39:07.341+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 16058
04-23 15:39:07.351+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16055
04-23 15:39:07.351+0200 W/AUL     (16058): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16055)
04-23 15:39:07.351+0200 I/httppostreq(16058): request sent to service es.ugr.frailty.servicemanager
04-23 15:39:07.351+0200 I/httppostreq(16058): requesting HTTP POST Request Service
04-23 15:39:07.351+0200 I/AUL     ( 3091): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
04-23 15:39:07.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 15
04-23 15:39:07.361+0200 E/CAPI_APPFW_APP_MANAGER( 3091): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 15:39:07.371+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:39:07.371+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(16055), cmd(0)
04-23 15:39:07.371+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.371+0200 I/utils   (16055): specific action
04-23 15:39:07.371+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.381+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.381+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.381+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.381+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.381+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.381+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.381+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.381+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.381+0200 W/AUL     (16055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:39:07.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:39:07.381+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 16055
04-23 15:39:07.391+0200 W/AUL     (16339): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 15:39:07.391+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 16340
04-23 15:39:07.411+0200 E/CAPI_APPFW_APPLICATION(16323): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:39:07.411+0200 E/CAPI_APPFW_APPLICATION(16323): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:39:07.431+0200 E/CAPI_APPFW_APPLICATION(16340): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:39:07.431+0200 E/CAPI_APPFW_APPLICATION(16340): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:39:07.431+0200 W/CAPI_APPFW_APP_CONTROL(16340): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.431+0200 I/utils   (16340): specific action
04-23 15:39:07.431+0200 W/CAPI_APPFW_APP_CONTROL(16340): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.431+0200 W/CAPI_APPFW_APP_CONTROL(16340): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.431+0200 W/CAPI_APPFW_APP_CONTROL(16340): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.431+0200 W/CAPI_APPFW_APP_CONTROL(16340): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.431+0200 W/CAPI_APPFW_APP_CONTROL(16340): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.441+0200 W/LOCATION(16323): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:39:07.441+0200 E/LOCATION(16323): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:39:07.441+0200 E/PKGMGR_INFO(16323): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:39:07.441+0200 W/LOCATION(16323): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:39:07.451+0200 I/recorder(16340): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 15:39:07.451+0200 W/AUL     (16340): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:39:07.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16340
04-23 15:39:07.451+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(16340) type(svcapp) bg(0)
04-23 15:39:07.451+0200 W/AUL     (16055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16340)
04-23 15:39:07.451+0200 I/servicemanager(16055): request sent to service es.ugr.frailty.recorder
04-23 15:39:07.451+0200 I/servicemanager(16055): eliminar datos locales
04-23 15:39:07.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:39:07.451+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:39:07.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16286
04-23 15:39:07.451+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:39:07.451+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (16323) was created
04-23 15:39:07.451+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (16340) was created
04-23 15:39:07.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:39:07.451+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 16340
04-23 15:39:07.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16055
04-23 15:39:07.461+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.461+0200 I/utils   (16055): specific action
04-23 15:39:07.461+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.461+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.461+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.461+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.461+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:39:07.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(16055), cmd(0)
04-23 15:39:07.461+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.461+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.461+0200 W/AUL     (16340): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16055)
04-23 15:39:07.461+0200 I/recorder(16340): request sent to service es.ugr.frailty.servicemanager
04-23 15:39:07.461+0200 I/recorder(16340): eliminando datos en local
04-23 15:39:07.461+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.461+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.471+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.471+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.471+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.471+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.471+0200 W/CAPI_APPFW_APP_CONTROL(16055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:39:07.471+0200 I/servicemanager(16055): launch es.ugr.frailty.accelerometer
04-23 15:39:07.471+0200 I/servicemanager(16055): re launch service
04-23 15:39:07.471+0200 I/LOCATION(16323): location.c: location_new(269) > method: 1
04-23 15:39:07.471+0200 W/LOCATION(16323): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:39:07.481+0200 W/LOCATION(16323): module-internal.c: module_new(311) > module (gps) open success
04-23 15:39:07.481+0200 W/LOCATION(16323): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:39:07.481+0200 W/LOCATION(16323): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:39:07.491+0200 W/LOCATION(16323): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:39:07.491+0200 W/LOCATION(16323): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:39:07.491+0200 W/LOCATION(16323): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:39:07.501+0200 W/CRASH_MANAGER(16334): worker.c: worker_job(1205) > 1116327726563152449074
