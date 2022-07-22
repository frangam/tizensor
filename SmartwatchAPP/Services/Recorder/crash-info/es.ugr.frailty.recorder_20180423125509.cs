S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 26783
Date: 2018-04-23 12:55:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7026648, r1   = 0xf77d31b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf77d31b8, r5   = 0x00012cd0
r6   = 0xf77e5e88, r7   = 0xf7026250
r8   = 0x000005c8, r9   = 0xf6b09824
r10  = 0xf77cb9d8, fp   = 0x00000000
ip   = 0xf7025030, sp   = 0xffdace00
lr   = 0xf6f695d0, pc   = 0xf6f659fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     13732 KB
Buffers:     72012 KB
Cached:     184972 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7700 KB
VmRSS:        7696 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f66a0000 f66a3000 r-xp /lib/libattr.so.1.1.0
f66ac000 f66b3000 r-xp /lib/libcrypt-2.13.so
f66e3000 f66e6000 r-xp /lib/libcap.so.2.21
f66ee000 f66f0000 r-xp /usr/lib/libiri.so
f66f8000 f6715000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f671e000 f6722000 r-xp /usr/lib/libsmack.so.1.0.0
f672c000 f672e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6736000 f673b000 r-xp /usr/lib/libffi.so.5.0.10
f6743000 f6744000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f674c000 f674e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6756000 f6758000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6762000 f6772000 r-xp /lib/libresolv-2.13.so
f6776000 f678e000 r-xp /usr/lib/liblzma.so.5.0.3
f6796000 f6798000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67a0000 f67cf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67d8000 f67e7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67f0000 f67fa000 r-xp /usr/lib/libsensord-shared.so
f6803000 f6837000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6840000 f6913000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f691e000 f6934000 r-xp /lib/libz.so.1.2.5
f693c000 f6942000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f694b000 f69c0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69ca000 f69e4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69ec000 f69f2000 r-xp /lib/librt-2.13.so
f69fb000 f6a19000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a23000 f6a24000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a2c000 f6a31000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a39000 f6b09000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6b0a000 f6b34000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b3d000 f6b54000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b5c000 f6bc5000 r-xp /lib/libm-2.13.so
f6bce000 f6c62000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c75000 f6c7a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c82000 f6c89000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c91000 f6cbb000 r-xp /usr/lib/libsensor.so.1.9.6
f6cc4000 f6d90000 r-xp /usr/lib/libxml2.so.2.7.8
f6d9d000 f6d9f000 r-xp /usr/lib/libiniparser.so.0
f6da8000 f6dab000 r-xp /usr/lib/libbundle.so.0.1.22
f6db3000 f6db9000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dc1000 f6de4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dec000 f6e2d000 r-xp /usr/lib/libeina.so.1.7.99
f6e36000 f6e4d000 r-xp /usr/lib/libecore.so.1.7.99
f6e64000 f6e6d000 r-xp /usr/lib/libvconf.so.0.2.45
f6e75000 f6e89000 r-xp /lib/libpthread-2.13.so
f6e94000 f6ea1000 r-xp /usr/lib/libaul.so.0.1.0
f6eab000 f6ead000 r-xp /lib/libdl-2.13.so
f6eb6000 f6ec1000 r-xp /lib/libunwind.so.8.0.1
f6eee000 f6ef6000 r-xp /lib/libgcc_s-4.6.so.1
f6ef7000 f701b000 r-xp /lib/libc-2.13.so
f7029000 f702b000 r-xp /usr/lib/libdlog.so.0.0.0
f7033000 f703f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7048000 f704d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7055000 f7059000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7062000 f7064000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f706d000 f7070000 r-xp /usr/lib/libappcore-agent.so.1.1
f708e000 f70ab000 r-xp /lib/ld-2.13.so
f70b4000 f70b7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f70b7000 f70bb000 r-xp /usr/lib/libsys-assert.so
f77c1000 f780f000 rw-p [heap]
ffd8e000 ffdaf000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26783)
Call Stack Count: 1
 0: (0xf6f659fc) [/lib/libc.so.6] + 0x6e9fc
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
dle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 1
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 2
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 3
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 4
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 5
04-23 12:54:49.501+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:54:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:49.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:49.511+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26652
04-23 12:54:49.511+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:49.521+0200 I/utils   (26640): es.ugr.frailty.accelerometer listener started
04-23 12:54:49.531+0200 I/accelerometer(26640): stopping es.ugr.frailty.accelerometer service
04-23 12:54:49.541+0200 E/CAPI_APPFW_APP_CONTROL(26640): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:54:49.541+0200 E/accelerometer(26640): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:54:49.541+0200 I/CAPI_APPFW_APPLICATION(26640): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:54:49.551+0200 E/CAPI_APPFW_APPLICATION(26652): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:49.551+0200 E/CAPI_APPFW_APPLICATION(26652): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:49.561+0200 I/utils   (26652): specific action
04-23 12:54:49.561+0200 I/recorder(26652): obteniendo datos locales...
04-23 12:54:49.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26652
04-23 12:54:49.561+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26652) type(svcapp) bg(0)
04-23 12:54:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:54:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:54:49.561+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26652) was created
04-23 12:54:49.571+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26652)
04-23 12:54:49.571+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:54:49.571+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26652]
04-23 12:54:49.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:49.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26652
04-23 12:54:49.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:49.601+0200 I/recorder(26652): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:54:49.671+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11266527265631524480889
04-23 12:54:49.681+0200 W/AUL     (26657): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:54:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26652
04-23 12:54:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:49.691+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26652
04-23 12:54:49.691+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26652)
04-23 12:54:49.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:49.701+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26640
04-23 12:54:49.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:49.711+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 12:54:49.711+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 12:54:49.711+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(26652), proc(0)
04-23 12:54:49.711+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 12:54:49.711+0200 E/AUL     ( 3087): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 12:54:49.711+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:54:49.811+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:49.821+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:49.841+0200 I/accelerometer(26640): es.ugr.frailty.accelerometer listener destroyed
04-23 12:54:49.991+0200 W/AUL     (26668): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:54:49.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:49.991+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:49.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26640
04-23 12:54:49.991+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:49.991+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26640
04-23 12:54:49.991+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26640)
04-23 12:54:51.571+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:54:59.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:54:59.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:59.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:54:59.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:54:59.381+0200 I/utils   (25866): specific action
04-23 12:54:59.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:54:59.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:54:59.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:54:59.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:54:59.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:54:59.381+0200 I/httppostreq(25866): internet available
04-23 12:54:59.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:54:59.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:54:59.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:54:59.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:54:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:54:59.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:54:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:59.391+0200 I/utils   (25863): specific action
04-23 12:54:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:59.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:54:59.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:54:59.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:54:59.391+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:54:59.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:59.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:59.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26706
04-23 12:54:59.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:59.451+0200 E/CAPI_APPFW_APPLICATION(26706): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.451+0200 E/CAPI_APPFW_APPLICATION(26706): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.451+0200 I/utils   (26706): trying to start service: es.ugr.frailty.accelerometer
04-23 12:54:59.451+0200 I/utils   (26706): es.ugr.frailty.accelerometer sensor supported
04-23 12:54:59.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26706
04-23 12:54:59.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26706) type(svcapp) bg(0)
04-23 12:54:59.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26706) was created
04-23 12:54:59.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26706)
04-23 12:54:59.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:54:59.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26706]
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:54:59.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:54:59.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:59.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:59.481+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26718
04-23 12:54:59.481+0200 I/utils   (26706): es.ugr.frailty.accelerometer listener started
04-23 12:54:59.481+0200 I/accelerometer(26706): stopping es.ugr.frailty.accelerometer service
04-23 12:54:59.481+0200 E/CAPI_APPFW_APP_CONTROL(26706): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.481+0200 E/accelerometer(26706): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:54:59.481+0200 I/CAPI_APPFW_APPLICATION(26706): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:54:59.481+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:59.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26718
04-23 12:54:59.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26718) type(svcapp) bg(0)
04-23 12:54:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:54:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:54:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26706
04-23 12:54:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:59.551+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26718)
04-23 12:54:59.551+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:54:59.561+0200 E/CAPI_APPFW_APPLICATION(26718): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.561+0200 E/CAPI_APPFW_APPLICATION(26718): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.561+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26718) was created
04-23 12:54:59.571+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26718]
04-23 12:54:59.571+0200 I/utils   (26718): specific action
04-23 12:54:59.571+0200 I/recorder(26718): obteniendo datos locales...
04-23 12:54:59.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:59.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26718
04-23 12:54:59.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:59.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:59.641+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26706
04-23 12:54:59.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:59.641+0200 I/recorder(26718): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:54:59.661+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:54:59.661+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:54:59.661+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:54:59.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:59.671+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26718
04-23 12:54:59.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:59.731+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11267187265631524480899
04-23 12:54:59.751+0200 W/AUL     (26725): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:54:59.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:59.751+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:59.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26718
04-23 12:54:59.751+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:59.751+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26718
04-23 12:54:59.751+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26718)
04-23 12:54:59.771+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:59.781+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:59.821+0200 I/accelerometer(26706): es.ugr.frailty.accelerometer listener destroyed
04-23 12:54:59.971+0200 W/AUL     (26734): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:54:59.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:59.971+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:59.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26706
04-23 12:54:59.971+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:59.971+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26706
04-23 12:54:59.971+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26706)
04-23 12:55:00.311+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 12:55:00.321+0200 W/SHealthService( 3087): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
04-23 12:55:00.321+0200 W/SHealthCommon( 3087): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
04-23 12:55:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
04-23 12:55:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
04-23 12:55:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_get_int(1132) > preference_get_int(3087) : key(pedometer_goal_achieve_percents) error
04-23 12:55:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
04-23 12:55:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
04-23 12:55:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
04-23 12:55:00.331+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
04-23 12:55:00.331+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_get_int(1132) > preference_get_int(3087) : key(best_step_goal) error
04-23 12:55:00.331+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 12:55:00.341+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 12:55:00.351+0200 I/HealthDataService( 2940): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 12:55:00.361+0200 I/healthData( 3087): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 12:55:01.241+0200 W/SHealthService( 3087): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
04-23 12:55:01.531+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:55:09.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:55:09.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:09.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:55:09.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:55:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:55:09.381+0200 I/utils   (25866): specific action
04-23 12:55:09.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:55:09.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:55:09.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:55:09.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:55:09.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:55:09.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:55:09.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:55:09.381+0200 I/httppostreq(25866): internet available
04-23 12:55:09.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:55:09.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:55:09.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:55:09.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:55:09.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:55:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:09.391+0200 I/utils   (25863): specific action
04-23 12:55:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:09.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:55:09.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:55:09.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:09.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:09.401+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26774
04-23 12:55:09.401+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:09.411+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:55:09.411+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:55:09.451+0200 E/CAPI_APPFW_APPLICATION(26774): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.451+0200 E/CAPI_APPFW_APPLICATION(26774): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.451+0200 I/utils   (26774): trying to start service: es.ugr.frailty.accelerometer
04-23 12:55:09.451+0200 I/utils   (26774): es.ugr.frailty.accelerometer sensor supported
04-23 12:55:09.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26774
04-23 12:55:09.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26774) type(svcapp) bg(0)
04-23 12:55:09.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26774) was created
04-23 12:55:09.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26774)
04-23 12:55:09.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:55:09.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:55:09.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:55:09.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26774]
04-23 12:55:09.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:09.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:09.471+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26783
04-23 12:55:09.481+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:09.521+0200 E/CAPI_APPFW_APPLICATION(26783): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.521+0200 E/CAPI_APPFW_APPLICATION(26783): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.521+0200 I/utils   (26783): specific action
04-23 12:55:09.521+0200 I/recorder(26783): obteniendo datos locales...
04-23 12:55:09.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26783
04-23 12:55:09.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26783) type(svcapp) bg(0)
04-23 12:55:09.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:09.531+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26783]
04-23 12:55:09.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26774
04-23 12:55:09.531+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26783) was created
04-23 12:55:09.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:09.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26774
04-23 12:55:09.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:09.541+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26783)
04-23 12:55:09.541+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:55:09.551+0200 I/utils   (26774): es.ugr.frailty.accelerometer listener started
04-23 12:55:09.551+0200 I/accelerometer(26774): stopping es.ugr.frailty.accelerometer service
04-23 12:55:09.551+0200 E/CAPI_APPFW_APP_CONTROL(26774): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.551+0200 E/accelerometer(26774): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:55:09.551+0200 I/CAPI_APPFW_APPLICATION(26774): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:55:09.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:55:09.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:55:09.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:09.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:09.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26783
04-23 12:55:09.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:09.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:09.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26783
04-23 12:55:09.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:09.611+0200 I/recorder(26783): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:55:09.701+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:09.711+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:09.741+0200 I/accelerometer(26774): es.ugr.frailty.accelerometer listener destroyed
04-23 12:55:09.751+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1126783726563152448090
