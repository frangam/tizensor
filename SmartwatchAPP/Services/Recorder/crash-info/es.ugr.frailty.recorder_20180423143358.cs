S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 6379
Date: 2018-04-23 14:33:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7168648, r1   = 0xf76d91b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf76d91b8, r5   = 0x00012cd0
r6   = 0xf76ebe88, r7   = 0xf7168250
r8   = 0x00000618, r9   = 0xf6c4b824
r10  = 0xf76d19d8, fp   = 0x00000000
ip   = 0xf7167030, sp   = 0xffbdf860
lr   = 0xf70ab5d0, pc   = 0xf70a79fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     63332 KB
Buffers:     38720 KB
Cached:     220852 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7764 KB
VmRSS:        7760 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f67e2000 f67e5000 r-xp /lib/libattr.so.1.1.0
f67ee000 f67f5000 r-xp /lib/libcrypt-2.13.so
f6825000 f6828000 r-xp /lib/libcap.so.2.21
f6830000 f6832000 r-xp /usr/lib/libiri.so
f683a000 f6857000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6860000 f6864000 r-xp /usr/lib/libsmack.so.1.0.0
f686e000 f6870000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6878000 f687d000 r-xp /usr/lib/libffi.so.5.0.10
f6885000 f6886000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f688e000 f6890000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6898000 f689a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68a4000 f68b4000 r-xp /lib/libresolv-2.13.so
f68b8000 f68d0000 r-xp /usr/lib/liblzma.so.5.0.3
f68d8000 f68da000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68e2000 f6911000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f691a000 f6929000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6932000 f693c000 r-xp /usr/lib/libsensord-shared.so
f6945000 f6979000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6982000 f6a55000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a60000 f6a76000 r-xp /lib/libz.so.1.2.5
f6a7e000 f6a84000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a8d000 f6b02000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b0c000 f6b26000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b2e000 f6b34000 r-xp /lib/librt-2.13.so
f6b3d000 f6b5b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b65000 f6b66000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b6e000 f6b73000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b7b000 f6c4b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c4c000 f6c76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c7f000 f6c96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c9e000 f6d07000 r-xp /lib/libm-2.13.so
f6d10000 f6da4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6db7000 f6dbc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dc4000 f6dcb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dd3000 f6dfd000 r-xp /usr/lib/libsensor.so.1.9.6
f6e06000 f6ed2000 r-xp /usr/lib/libxml2.so.2.7.8
f6edf000 f6ee1000 r-xp /usr/lib/libiniparser.so.0
f6eea000 f6eed000 r-xp /usr/lib/libbundle.so.0.1.22
f6ef5000 f6efb000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f03000 f6f26000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f2e000 f6f6f000 r-xp /usr/lib/libeina.so.1.7.99
f6f78000 f6f8f000 r-xp /usr/lib/libecore.so.1.7.99
f6fa6000 f6faf000 r-xp /usr/lib/libvconf.so.0.2.45
f6fb7000 f6fcb000 r-xp /lib/libpthread-2.13.so
f6fd6000 f6fe3000 r-xp /usr/lib/libaul.so.0.1.0
f6fed000 f6fef000 r-xp /lib/libdl-2.13.so
f6ff8000 f7003000 r-xp /lib/libunwind.so.8.0.1
f7030000 f7038000 r-xp /lib/libgcc_s-4.6.so.1
f7039000 f715d000 r-xp /lib/libc-2.13.so
f716b000 f716d000 r-xp /usr/lib/libdlog.so.0.0.0
f7175000 f7181000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f718a000 f718f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7197000 f719b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71a4000 f71a6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f71af000 f71b2000 r-xp /usr/lib/libappcore-agent.so.1.1
f71d0000 f71ed000 r-xp /lib/ld-2.13.so
f71f6000 f71f9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f71f9000 f71fd000 r-xp /usr/lib/libsys-assert.so
f76c7000 f7715000 rw-p [heap]
ffbc1000 ffbe2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6379)
Call Stack Count: 1
 0: (0xf70a79fc) [/lib/libc.so.6] + 0x6e9fc
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
3 14:33:38.331+0200 I/CAPI_APPFW_APPLICATION( 6269): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:33:38.361+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6275
04-23 14:33:38.361+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6275) type(svcapp) bg(0)
04-23 14:33:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:33:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:33:38.381+0200 E/CAPI_APPFW_APPLICATION( 6275): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.381+0200 E/CAPI_APPFW_APPLICATION( 6275): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.381+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6275) was created
04-23 14:33:38.381+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6275)
04-23 14:33:38.381+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:33:38.381+0200 I/utils   ( 6275): specific action
04-23 14:33:38.381+0200 I/recorder( 6275): obteniendo datos locales...
04-23 14:33:38.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:38.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:38.401+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6269]
04-23 14:33:38.401+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6275]
04-23 14:33:38.401+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:33:38.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6247
04-23 14:33:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.431+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6269
04-23 14:33:38.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.451+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.461+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6275
04-23 14:33:38.461+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.471+0200 I/recorder( 6275): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:33:38.481+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:33:38.481+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6269
04-23 14:33:38.481+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:33:38.481+0200 I/accelerometer( 6244): es.ugr.frailty.accelerometer listener destroyed
04-23 14:33:38.491+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:33:38.491+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:33:38.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.521+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.521+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6275
04-23 14:33:38.531+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.531+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.551+0200 I/gyroscope( 6247): es.ugr.frailty.gyroscope listener destroyed
04-23 14:33:38.581+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:38.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:38.591+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.621+0200 W/AUL     ( 6289): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 14:33:38.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:33:38.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:33:38.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6244
04-23 14:33:38.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:33:38.621+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6244
04-23 14:33:38.621+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6244)
04-23 14:33:38.631+0200 I/heartrate( 6269): es.ugr.frailty.heartrate listener destroyed
04-23 14:33:38.651+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 11062757265631524486818
04-23 14:33:38.681+0200 W/AUL     ( 6292): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 14:33:38.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:33:38.681+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:33:38.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6275
04-23 14:33:38.681+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:33:38.681+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6275
04-23 14:33:38.681+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6275)
04-23 14:33:38.701+0200 W/AUL     ( 6294): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 14:33:38.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:33:38.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:33:38.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6247
04-23 14:33:38.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:33:38.701+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6247
04-23 14:33:38.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6247)
04-23 14:33:38.761+0200 W/AUL     ( 6299): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 14:33:38.761+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:33:38.761+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:33:38.761+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6269
04-23 14:33:38.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:33:38.771+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6269
04-23 14:33:38.771+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6269)
04-23 14:33:38.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:38.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:38.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:38.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:39.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:39.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:39.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:39.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:39.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:39.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:39.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:39.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:39.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:39.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:40.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:40.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:40.221+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:33:40.221+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:33:40.361+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:33:40.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:40.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:40.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:40.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:40.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:40.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:40.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:40.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:41.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:41.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:41.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:41.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:41.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:41.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:41.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:41.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:41.871+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 14:33:41.871+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 14:33:41.871+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 14:33:41.871+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 14:33:41.871+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 14:33:41.871+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 14:33:41.871+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 14:33:41.871+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 14:33:41.871+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 14:33:41.871+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 14:33:41.871+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:33:41.871+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 14:33:41.871+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 14:33:41.871+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 14:33:41.871+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 14:33:41.871+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 14:33:41.871+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 14:33:41.881+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 14:33:41.881+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 14:33:41.881+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 14:33:41.891+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [717.558965] layer(0x5ac2c0) now usable
04-23 14:33:41.891+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [717.558992] layer[0x5abe10]zpos[1]
04-23 14:33:41.891+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [717.559015] layer(0x5ac310) now usable
04-23 14:33:41.891+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [717.559026] layer[0x5abf30]zpos[2]
04-23 14:33:41.891+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [717.559045] layer(0x5ac250) now usable
04-23 14:33:41.891+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [717.559054] layer[0x5abcf0]zpos[0]
04-23 14:33:41.891+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [717.559068] dpms[0 -> 3]sync[1]
04-23 14:33:41.891+0200 I/TDM     ( 1785): 
04-23 14:33:41.901+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 14:33:41.901+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 14:33:41.901+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 14:33:41.901+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 14:33:41.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:41.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:42.031+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [717.690849] dpms[3 -> 3]done
04-23 14:33:42.031+0200 I/TDM     ( 1785): 
04-23 14:33:42.031+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 14:33:42.031+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 14:33:42.031+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 14:33:42.031+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 14:33:42.031+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 14:33:42.041+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 14:33:42.041+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 14:33:42.041+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 14:33:42.041+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 14:33:42.041+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 14:33:42.041+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 14:33:42.041+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 14:33:42.041+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 14:33:42.041+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:33:42.041+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:33:42.041+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 14:33:42.041+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:33:42.051+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:42.051+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 14:33:42.051+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 14:33:42.061+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 14:33:42.061+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 14:33:42.061+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 14:33:42.061+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 14:33:42.061+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 14:33:42.061+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 14:33:42.061+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 14:33:42.061+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 14:33:42.551+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 14:33:47.061+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 14:33:57.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:33:57.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:57.991+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:58.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:33:58.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:33:58.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:33:58.011+0200 I/utils   ( 4443): specific action
04-23 14:33:58.011+0200 I/httppostreq( 4443): internet connection check received
04-23 14:33:58.011+0200 I/httppostreq( 4443): internet connection != null
04-23 14:33:58.011+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:33:58.011+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:33:58.011+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:33:58.011+0200 I/httppostreq( 4443): internet connection type...
04-23 14:33:58.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:33:58.011+0200 I/httppostreq( 4443): internet available
04-23 14:33:58.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:33:58.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:58.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:33:58.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:33:58.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:33:58.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:33:58.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:33:58.031+0200 I/utils   ( 4440): specific action
04-23 14:33:58.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:33:58.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:33:58.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:33:58.031+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:33:58.031+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:33:58.031+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:33:58.031+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:33:58.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:58.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:58.051+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6341
04-23 14:33:58.051+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:33:58.101+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6341
04-23 14:33:58.101+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6341) type(svcapp) bg(0)
04-23 14:33:58.101+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6341)
04-23 14:33:58.101+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:33:58.101+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:33:58.101+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:33:58.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:58.111+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6341]
04-23 14:33:58.111+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:58.121+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6342
04-23 14:33:58.121+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:33:58.131+0200 E/CAPI_APPFW_APPLICATION( 6341): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.131+0200 E/CAPI_APPFW_APPLICATION( 6341): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.141+0200 I/utils   ( 6341): trying to start service: es.ugr.frailty.accelerometer
04-23 14:33:58.151+0200 I/utils   ( 6341): es.ugr.frailty.accelerometer sensor supported
04-23 14:33:58.161+0200 I/utils   ( 6341): es.ugr.frailty.accelerometer listener started
04-23 14:33:58.161+0200 I/accelerometer( 6341): stopping es.ugr.frailty.accelerometer service
04-23 14:33:58.161+0200 E/CAPI_APPFW_APP_CONTROL( 6341): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.161+0200 E/accelerometer( 6341): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:33:58.161+0200 I/CAPI_APPFW_APPLICATION( 6341): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:33:58.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6342
04-23 14:33:58.171+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(6342) type(svcapp) bg(0)
04-23 14:33:58.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:58.181+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6342)
04-23 14:33:58.181+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6342]
04-23 14:33:58.181+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6341
04-23 14:33:58.181+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6341) was created
04-23 14:33:58.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6341
04-23 14:33:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:33:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:33:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:58.191+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:33:58.191+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:33:58.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:33:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:58.211+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:58.221+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6356
04-23 14:33:58.251+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:33:58.261+0200 E/CAPI_APPFW_APPLICATION( 6342): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.261+0200 E/CAPI_APPFW_APPLICATION( 6342): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.261+0200 I/utils   ( 6342): trying to start service: es.ugr.frailty.gyroscope
04-23 14:33:58.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6356
04-23 14:33:58.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(6356) type(svcapp) bg(0)
04-23 14:33:58.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:58.281+0200 I/utils   ( 6342): es.ugr.frailty.gyroscope sensor supported
04-23 14:33:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6342
04-23 14:33:58.281+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6342) was created
04-23 14:33:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:58.291+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6356]
04-23 14:33:58.291+0200 I/utils   ( 6342): es.ugr.frailty.gyroscope listener started
04-23 14:33:58.291+0200 I/gyroscope( 6342): stopping es.ugr.frailty.gyroscope service
04-23 14:33:58.291+0200 E/CAPI_APPFW_APP_CONTROL( 6342): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.291+0200 E/gyroscope( 6342): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:33:58.291+0200 I/CAPI_APPFW_APPLICATION( 6342): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:33:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6342
04-23 14:33:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:33:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:33:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:58.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:58.311+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:58.311+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6356
04-23 14:33:58.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:58.321+0200 E/CAPI_APPFW_APPLICATION( 6356): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.321+0200 E/CAPI_APPFW_APPLICATION( 6356): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.321+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:58.321+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6356) was created
04-23 14:33:58.321+0200 I/utils   ( 6356): trying to start service: es.ugr.frailty.heartrate
04-23 14:33:58.321+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6356)
04-23 14:33:58.321+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:33:58.321+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:33:58.321+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:33:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:33:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:33:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:33:58.321+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:33:58.321+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:33:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:33:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:33:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:33:58.321+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:33:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:33:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:33:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:33:58.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:33:58.321+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:33:58.321+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:33:58.321+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:33:58.321+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:33:58.321+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:33:58.321+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:33:58.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:58.321+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:58.331+0200 I/utils   ( 6356): es.ugr.frailty.heartrate sensor supported
04-23 14:33:58.341+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:33:58.341+0200 I/utils   ( 6356): es.ugr.frailty.heartrate listener started
04-23 14:33:58.341+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6379
04-23 14:33:58.341+0200 I/heartrate( 6356): stopping es.ugr.frailty.heartrate service
04-23 14:33:58.341+0200 E/CAPI_APPFW_APP_CONTROL( 6356): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.341+0200 E/heartrate( 6356): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:33:58.341+0200 I/CAPI_APPFW_APPLICATION( 6356): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:33:58.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6379
04-23 14:33:58.391+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6379) type(svcapp) bg(0)
04-23 14:33:58.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:33:58.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:33:58.391+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6379)
04-23 14:33:58.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:58.391+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:33:58.401+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6356
04-23 14:33:58.401+0200 E/CAPI_APPFW_APPLICATION( 6379): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.401+0200 E/CAPI_APPFW_APPLICATION( 6379): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:58.401+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6379) was created
04-23 14:33:58.401+0200 I/utils   ( 6379): specific action
04-23 14:33:58.401+0200 I/recorder( 6379): obteniendo datos locales...
04-23 14:33:58.411+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6379]
04-23 14:33:58.421+0200 I/accelerometer( 6341): es.ugr.frailty.accelerometer listener destroyed
04-23 14:33:58.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:58.431+0200 I/recorder( 6379): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:33:58.431+0200 I/recorder( 6379): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:33:58.431+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6379
04-23 14:33:58.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:58.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:58.461+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:58.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:58.471+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6379
04-23 14:33:58.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:58.481+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:58.531+0200 W/AUL     ( 6386): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 14:33:58.531+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1106379726563152448683
