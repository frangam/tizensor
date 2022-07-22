S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 15928
Date: 2018-04-23 13:38:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7358648, r1   = 0xf74911b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf74911b8, r5   = 0x00012cd0
r6   = 0xf74a3e88, r7   = 0xf7358250
r8   = 0x000005e0, r9   = 0xf6e3b824
r10  = 0xf74899d8, fp   = 0x00000000
ip   = 0xf7357030, sp   = 0xffe48fb0
lr   = 0xf729b5d0, pc   = 0xf72979fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      4776 KB
Buffers:     35768 KB
Cached:     152612 KB
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
VmPTE:          32 KB
VmSwap:          0 KB

Maps Information
f69d2000 f69d5000 r-xp /lib/libattr.so.1.1.0
f69de000 f69e5000 r-xp /lib/libcrypt-2.13.so
f6a15000 f6a18000 r-xp /lib/libcap.so.2.21
f6a20000 f6a22000 r-xp /usr/lib/libiri.so
f6a2a000 f6a47000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a50000 f6a54000 r-xp /usr/lib/libsmack.so.1.0.0
f6a5e000 f6a60000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a68000 f6a6d000 r-xp /usr/lib/libffi.so.5.0.10
f6a75000 f6a76000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a7e000 f6a80000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a88000 f6a8a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a94000 f6aa4000 r-xp /lib/libresolv-2.13.so
f6aa8000 f6ac0000 r-xp /usr/lib/liblzma.so.5.0.3
f6ac8000 f6aca000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ad2000 f6b01000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b0a000 f6b19000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b22000 f6b2c000 r-xp /usr/lib/libsensord-shared.so
f6b35000 f6b69000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b72000 f6c45000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c50000 f6c66000 r-xp /lib/libz.so.1.2.5
f6c6e000 f6c74000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c7d000 f6cf2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cfc000 f6d16000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d1e000 f6d24000 r-xp /lib/librt-2.13.so
f6d2d000 f6d4b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d55000 f6d56000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d5e000 f6d63000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d6b000 f6e3b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e3c000 f6e66000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e6f000 f6e86000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e8e000 f6ef7000 r-xp /lib/libm-2.13.so
f6f00000 f6f94000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fa7000 f6fac000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fb4000 f6fbb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fc3000 f6fed000 r-xp /usr/lib/libsensor.so.1.9.6
f6ff6000 f70c2000 r-xp /usr/lib/libxml2.so.2.7.8
f70cf000 f70d1000 r-xp /usr/lib/libiniparser.so.0
f70da000 f70dd000 r-xp /usr/lib/libbundle.so.0.1.22
f70e5000 f70eb000 r-xp /usr/lib/libappsvc.so.0.1.0
f70f3000 f7116000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f711e000 f715f000 r-xp /usr/lib/libeina.so.1.7.99
f7168000 f717f000 r-xp /usr/lib/libecore.so.1.7.99
f7196000 f719f000 r-xp /usr/lib/libvconf.so.0.2.45
f71a7000 f71bb000 r-xp /lib/libpthread-2.13.so
f71c6000 f71d3000 r-xp /usr/lib/libaul.so.0.1.0
f71dd000 f71df000 r-xp /lib/libdl-2.13.so
f71e8000 f71f3000 r-xp /lib/libunwind.so.8.0.1
f7220000 f7228000 r-xp /lib/libgcc_s-4.6.so.1
f7229000 f734d000 r-xp /lib/libc-2.13.so
f735b000 f735d000 r-xp /usr/lib/libdlog.so.0.0.0
f7365000 f7371000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f737a000 f737f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7387000 f738b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7394000 f7396000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f739f000 f73a2000 r-xp /usr/lib/libappcore-agent.so.1.1
f73c0000 f73dd000 r-xp /lib/ld-2.13.so
f73e6000 f73e9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f73e9000 f73ed000 r-xp /usr/lib/libsys-assert.so
f747f000 f74cd000 rw-p [heap]
ffe2b000 ffe4c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15928)
Call Stack Count: 1
 0: (0xf72979fc) [/lib/libc.so.6] + 0x6e9fc
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
!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.771+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:38:28.771+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:38:28.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:28.781+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:38:28.791+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15855
04-23 13:38:28.791+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:38:28.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:28.831+0200 E/CAPI_APPFW_APPLICATION(15855): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:28.831+0200 E/CAPI_APPFW_APPLICATION(15855): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:28.831+0200 I/utils   (15855): specific action
04-23 13:38:28.831+0200 I/recorder(15855): obteniendo datos locales...
04-23 13:38:28.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15855
04-23 13:38:28.841+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15855) type(svcapp) bg(0)
04-23 13:38:28.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:28.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15847
04-23 13:38:28.851+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15855) was created
04-23 13:38:28.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:28.861+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15855]
04-23 13:38:28.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:28.911+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15855
04-23 13:38:28.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:28.971+0200 I/recorder(15855): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:38:29.021+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 11158557265631524483508
04-23 13:38:29.021+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15855)
04-23 13:38:29.021+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:38:29.041+0200 I/utils   (15847): es.ugr.frailty.accelerometer listener started
04-23 13:38:29.041+0200 I/accelerometer(15847): stopping es.ugr.frailty.accelerometer service
04-23 13:38:29.041+0200 E/CAPI_APPFW_APP_CONTROL(15847): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:38:29.041+0200 E/accelerometer(15847): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:38:29.041+0200 I/CAPI_APPFW_APPLICATION(15847): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:38:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:38:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:38:29.051+0200 W/AUL     (15863): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:38:29.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:38:29.061+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:29.061+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:29.061+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:29.061+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:29.061+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:29.061+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:38:29.061+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:38:29.061+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:38:29.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15855
04-23 13:38:29.061+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:38:29.071+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15855
04-23 13:38:29.071+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15855)
04-23 13:38:29.071+0200 E/AUL     (15863): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:38:29.081+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:28:803,73
04-23 13:38:29.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:29.081+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:29.081+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:29:92,73
04-23 13:38:29.091+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15847
04-23 13:38:29.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:29.131+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 13:38:29.131+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 13:38:29.131+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(15855), proc(0)
04-23 13:38:29.131+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 13:38:29.131+0200 E/AUL     ( 3087): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 13:38:29.131+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 13:38:29.181+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:38:29.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:29.191+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:38:29.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:29:191,73
04-23 13:38:29.211+0200 I/accelerometer(15847): es.ugr.frailty.accelerometer listener destroyed
04-23 13:38:29.341+0200 W/AUL     (15873): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:38:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:38:29.351+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:29.351+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:29.351+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:29.351+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:29.351+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:29.351+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:38:29.351+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:38:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:38:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15847
04-23 13:38:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:38:29.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15847
04-23 13:38:29.361+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15847)
04-23 13:38:29.361+0200 E/AUL     (15873): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:38:29.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:29.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:29:385,73
04-23 13:38:29.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:29.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:29:585,73
04-23 13:38:29.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:29.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:29:785,73
04-23 13:38:29.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:29.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:29:986,73
04-23 13:38:30.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:30.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:30:186,73
04-23 13:38:30.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:30.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:30:386,73
04-23 13:38:30.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:30.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:30:586,73
04-23 13:38:30.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:30.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:30:786,73
04-23 13:38:30.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:30.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:30:986,73
04-23 13:38:31.051+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:38:31.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:31.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:31:186,73
04-23 13:38:31.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:31.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:31:386,73
04-23 13:38:31.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:31.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:31:587,73
04-23 13:38:31.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:31.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:31:789,73
04-23 13:38:31.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:31.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:31:989,73
04-23 13:38:32.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:32.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:32:189,73
04-23 13:38:32.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:32.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:32:387,73
04-23 13:38:32.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:32.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:32:589,74
04-23 13:38:32.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:32.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:32:789,74
04-23 13:38:32.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:32.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:32:989,74
04-23 13:38:33.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:33.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:33:189,74
04-23 13:38:33.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:33.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:33:389,74
04-23 13:38:33.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:33.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:33:588,74
04-23 13:38:33.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:33.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:33:788,75
04-23 13:38:33.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:33.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:33:988,75
04-23 13:38:34.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:34.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:34:189,75
04-23 13:38:34.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:34.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:34:389,75
04-23 13:38:34.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:34.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:34:598,75
04-23 13:38:34.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:34.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:34:789,75
04-23 13:38:34.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:34.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:34:989,75
04-23 13:38:35.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:35.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:35:189,75
04-23 13:38:35.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:35.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:35:398,75
04-23 13:38:35.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:35.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:35:598,75
04-23 13:38:35.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:35.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:35:789,75
04-23 13:38:35.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:35.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:35:990,75
04-23 13:38:36.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:36.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:36:190,75
04-23 13:38:36.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:36.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:36:390,75
04-23 13:38:36.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:36.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:36:590,76
04-23 13:38:36.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:36.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:36:790,76
04-23 13:38:36.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:36.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:36:990,76
04-23 13:38:37.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:37.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:37:190,76
04-23 13:38:37.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:37.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:37:391,76
04-23 13:38:37.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:37.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:37:591,77
04-23 13:38:37.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:37.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:37:791,77
04-23 13:38:37.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:37.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:37:991,77
04-23 13:38:38.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:38.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:38:191,77
04-23 13:38:38.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:38.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:38:391,77
04-23 13:38:38.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:38.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:38:591,77
04-23 13:38:38.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:38.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:38:791,77
04-23 13:38:38.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:38.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:38:992,78
04-23 13:38:39.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:39.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:39:192,78
04-23 13:38:39.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:39.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:39:392,78
04-23 13:38:39.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:39.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:39:592,78
04-23 13:38:39.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:39.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:39:792,79
04-23 13:38:39.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:39.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:39:992,79
04-23 13:38:40.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:40.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:40:192,80
04-23 13:38:40.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:40.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:40:393,80
04-23 13:38:40.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:40.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:40:593,80
04-23 13:38:40.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:40.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:40:793,80
04-23 13:38:40.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:40.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:40:993,80
04-23 13:38:41.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:41.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:41:193,81
04-23 13:38:41.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:41.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:41:393,81
04-23 13:38:41.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:41.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:41:593,81
04-23 13:38:41.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:41.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:41:793,82
04-23 13:38:41.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:41.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:41:994,83
04-23 13:38:42.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:42.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:42:194,83
04-23 13:38:42.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:42.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:42:394,84
04-23 13:38:42.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:42.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:42:594,84
04-23 13:38:42.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:42.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:42:794,84
04-23 13:38:42.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:42.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:42:994,84
04-23 13:38:43.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:43.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:43:194,84
04-23 13:38:43.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:43.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:43:395,84
04-23 13:38:43.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:43.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:43:595,85
04-23 13:38:43.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:43.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:43:795,85
04-23 13:38:43.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:43.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:43:995,85
04-23 13:38:44.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:44.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:44:196,85
04-23 13:38:44.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:44.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:44:395,86
04-23 13:38:44.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:44.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:44:595,86
04-23 13:38:44.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:44.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:44:795,86
04-23 13:38:44.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:44.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:44:996,87
04-23 13:38:45.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:45.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:45:196,86
04-23 13:38:45.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:45.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:45:396,86
04-23 13:38:45.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:45.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:45:596,86
04-23 13:38:45.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:45.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:45:796,86
04-23 13:38:45.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:45.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:45:996,87
04-23 13:38:46.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:46.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:46:196,87
04-23 13:38:46.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:46.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:46:397,87
04-23 13:38:46.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:46.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:46:597,86
04-23 13:38:46.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:46.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:46:797,87
04-23 13:38:46.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:46.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:46:997,86
04-23 13:38:47.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:47.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:47:197,86
04-23 13:38:47.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:47.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:47:397,87
04-23 13:38:47.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:47.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:47:597,87
04-23 13:38:47.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:47.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:47:797,87
04-23 13:38:47.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:47.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:47:998,86
04-23 13:38:48.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:48.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:48:198,86
04-23 13:38:48.381+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:48.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:48:398,86
04-23 13:38:48.581+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:48.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:48:598,86
04-23 13:38:48.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:38:48.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:48.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:38:48.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:38:48.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:38:48.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:38:48.661+0200 I/utils   ( 9745): specific action
04-23 13:38:48.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:38:48.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:38:48.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:38:48.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:38:48.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:38:48.661+0200 I/httppostreq( 9745): internet available
04-23 13:38:48.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:38:48.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:38:48.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:38:48.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:48.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:38:48.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:38:48.681+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:38:48.681+0200 I/utils   ( 9742): specific action
04-23 13:38:48.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:38:48.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:38:48.681+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:38:48.681+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:38:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:38:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:38:48.691+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:38:48.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:38:48.691+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:38:48.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:48.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:38:48.701+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15915
04-23 13:38:48.701+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:38:48.741+0200 E/CAPI_APPFW_APPLICATION(15915): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:48.741+0200 E/CAPI_APPFW_APPLICATION(15915): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:48.741+0200 I/utils   (15915): trying to start service: es.ugr.frailty.accelerometer
04-23 13:38:48.741+0200 I/utils   (15915): es.ugr.frailty.accelerometer sensor supported
04-23 13:38:48.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15915
04-23 13:38:48.751+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(15915) type(svcapp) bg(0)
04-23 13:38:48.751+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15915) was created
04-23 13:38:48.771+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15915)
04-23 13:38:48.771+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:38:48.771+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:48.771+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:48.771+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:48.771+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:48.771+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:48.771+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:48.771+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:48.771+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:48.771+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:48.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:48.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:48.771+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:38:48.771+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:38:48.771+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15915]
04-23 13:38:48.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:48.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:38:48.801+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15928
04-23 13:38:48.801+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:38:48.851+0200 I/utils   (15915): es.ugr.frailty.accelerometer listener started
04-23 13:38:48.851+0200 I/accelerometer(15915): stopping es.ugr.frailty.accelerometer service
04-23 13:38:48.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15928
04-23 13:38:48.851+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15928) type(svcapp) bg(0)
04-23 13:38:48.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:48.861+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15915
04-23 13:38:48.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:48.871+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15915
04-23 13:38:48.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:48.891+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15928]
04-23 13:38:48.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:48.941+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15928
04-23 13:38:48.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:49.001+0200 E/CAPI_APPFW_APPLICATION(15928): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:49.001+0200 E/CAPI_APPFW_APPLICATION(15928): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:49.001+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15928) was created
04-23 13:38:49.011+0200 I/utils   (15928): specific action
04-23 13:38:49.011+0200 I/recorder(15928): obteniendo datos locales...
04-23 13:38:49.031+0200 I/recorder(15928): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:38:49.081+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1115928726563152448352
