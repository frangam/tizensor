S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 27169
Date: 2018-04-23 12:56:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7470648, r1   = 0xf7cf41b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7cf41b8, r5   = 0x00012cd0
r6   = 0xf7d06e88, r7   = 0xf7470250
r8   = 0x000005c8, r9   = 0xf6f53824
r10  = 0xf7cec9d8, fp   = 0x00000000
ip   = 0xf746f030, sp   = 0xff96dac0
lr   = 0xf73b35d0, pc   = 0xf73af9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     13188 KB
Buffers:     72132 KB
Cached:     185444 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7708 KB
VmRSS:        7708 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6aea000 f6aed000 r-xp /lib/libattr.so.1.1.0
f6af6000 f6afd000 r-xp /lib/libcrypt-2.13.so
f6b2d000 f6b30000 r-xp /lib/libcap.so.2.21
f6b38000 f6b3a000 r-xp /usr/lib/libiri.so
f6b42000 f6b5f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b68000 f6b6c000 r-xp /usr/lib/libsmack.so.1.0.0
f6b76000 f6b78000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b80000 f6b85000 r-xp /usr/lib/libffi.so.5.0.10
f6b8d000 f6b8e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b96000 f6b98000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ba0000 f6ba2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bac000 f6bbc000 r-xp /lib/libresolv-2.13.so
f6bc0000 f6bd8000 r-xp /usr/lib/liblzma.so.5.0.3
f6be0000 f6be2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bea000 f6c19000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c22000 f6c31000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c3a000 f6c44000 r-xp /usr/lib/libsensord-shared.so
f6c4d000 f6c81000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6c8a000 f6d5d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d68000 f6d7e000 r-xp /lib/libz.so.1.2.5
f6d86000 f6d8c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d95000 f6e0a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e14000 f6e2e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e36000 f6e3c000 r-xp /lib/librt-2.13.so
f6e45000 f6e63000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e6d000 f6e6e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e76000 f6e7b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e83000 f6f53000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f54000 f6f7e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f87000 f6f9e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fa6000 f700f000 r-xp /lib/libm-2.13.so
f7018000 f70ac000 r-xp /usr/lib/libstdc++.so.6.0.16
f70bf000 f70c4000 r-xp /usr/lib/libctx-client.so.0.8.3
f70cc000 f70d3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70db000 f7105000 r-xp /usr/lib/libsensor.so.1.9.6
f710e000 f71da000 r-xp /usr/lib/libxml2.so.2.7.8
f71e7000 f71e9000 r-xp /usr/lib/libiniparser.so.0
f71f2000 f71f5000 r-xp /usr/lib/libbundle.so.0.1.22
f71fd000 f7203000 r-xp /usr/lib/libappsvc.so.0.1.0
f720b000 f722e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7236000 f7277000 r-xp /usr/lib/libeina.so.1.7.99
f7280000 f7297000 r-xp /usr/lib/libecore.so.1.7.99
f72ae000 f72b7000 r-xp /usr/lib/libvconf.so.0.2.45
f72bf000 f72d3000 r-xp /lib/libpthread-2.13.so
f72de000 f72eb000 r-xp /usr/lib/libaul.so.0.1.0
f72f5000 f72f7000 r-xp /lib/libdl-2.13.so
f7300000 f730b000 r-xp /lib/libunwind.so.8.0.1
f7338000 f7340000 r-xp /lib/libgcc_s-4.6.so.1
f7341000 f7465000 r-xp /lib/libc-2.13.so
f7473000 f7475000 r-xp /usr/lib/libdlog.so.0.0.0
f747d000 f7489000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7492000 f7497000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f749f000 f74a3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74ac000 f74ae000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f74b7000 f74ba000 r-xp /usr/lib/libappcore-agent.so.1.1
f74d8000 f74f5000 r-xp /lib/ld-2.13.so
f74fe000 f7501000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7501000 f7505000 r-xp /usr/lib/libsys-assert.so
f7ce2000 f7d30000 rw-p [heap]
ff94f000 ff970000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27169)
Call Stack Count: 1
 0: (0xf73af9fc) [/lib/libc.so.6] + 0x6e9fc
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
7) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:49.451+0200 E/CAPI_APPFW_APPLICATION(27033): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:49.451+0200 I/utils   (27033): trying to start service: es.ugr.frailty.accelerometer
04-23 12:55:49.461+0200 I/utils   (27033): es.ugr.frailty.accelerometer sensor supported
04-23 12:55:49.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27033
04-23 12:55:49.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27033) type(svcapp) bg(0)
04-23 12:55:49.471+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27033) was created
04-23 12:55:49.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27033)
04-23 12:55:49.471+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:55:49.471+0200 I/servicemanager(25863): App control destroyed.
04-23 12:55:49.471+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27033]
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:49.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:49.471+0200 E/servicemanager(25863): deleting timer 0
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:49.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:49.471+0200 E/servicemanager(25863): deleting timer 1
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:49.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:49.471+0200 E/servicemanager(25863): deleting timer 2
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:49.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:49.471+0200 E/servicemanager(25863): deleting timer 3
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:49.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:49.471+0200 E/servicemanager(25863): deleting timer 4
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:49.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:49.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:49.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:49.471+0200 E/servicemanager(25863): deleting timer 5
04-23 12:55:49.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:55:49.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:49.481+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:49.491+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:49.491+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27044
04-23 12:55:49.511+0200 I/utils   (27033): es.ugr.frailty.accelerometer listener started
04-23 12:55:49.511+0200 I/accelerometer(27033): stopping es.ugr.frailty.accelerometer service
04-23 12:55:49.531+0200 E/CAPI_APPFW_APP_CONTROL(27033): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:55:49.531+0200 E/accelerometer(27033): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:55:49.531+0200 I/CAPI_APPFW_APPLICATION(27033): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:55:49.531+0200 E/CAPI_APPFW_APPLICATION(27044): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:49.531+0200 E/CAPI_APPFW_APPLICATION(27044): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:49.531+0200 I/utils   (27044): specific action
04-23 12:55:49.531+0200 I/recorder(27044): obteniendo datos locales...
04-23 12:55:49.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27044
04-23 12:55:49.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27044) type(svcapp) bg(0)
04-23 12:55:49.541+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27044)
04-23 12:55:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27033
04-23 12:55:49.551+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27044) was created
04-23 12:55:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:55:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:55:49.561+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27044]
04-23 12:55:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:49.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:49.571+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:55:49.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27044
04-23 12:55:49.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:49.591+0200 I/recorder(27044): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:55:49.591+0200 I/recorder(27044): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:55:49.701+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:49.711+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:49.761+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11270447265631524480949
04-23 12:55:49.761+0200 I/accelerometer(27033): es.ugr.frailty.accelerometer listener destroyed
04-23 12:55:49.771+0200 W/AUL     (27052): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:55:49.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:55:49.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:55:49.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27044
04-23 12:55:49.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:55:49.781+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27044
04-23 12:55:49.781+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27044)
04-23 12:55:49.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:49.791+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27033
04-23 12:55:49.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:49.791+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 12:55:49.791+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 12:55:49.791+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(27044), proc(0)
04-23 12:55:49.791+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 12:55:49.791+0200 E/AUL     ( 3087): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 12:55:49.791+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:55:49.891+0200 W/AUL     (27059): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:55:49.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:55:49.891+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:55:49.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27033
04-23 12:55:49.891+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:55:49.911+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27033
04-23 12:55:49.911+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27033)
04-23 12:55:51.561+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:55:59.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:55:59.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:59.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:55:59.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:55:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:55:59.381+0200 I/utils   (25866): specific action
04-23 12:55:59.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:55:59.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:55:59.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:55:59.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:55:59.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:55:59.381+0200 I/httppostreq(25866): internet available
04-23 12:55:59.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:55:59.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:55:59.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:55:59.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:55:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:55:59.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:55:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:55:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:59.391+0200 I/utils   (25863): specific action
04-23 12:55:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:59.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:55:59.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:55:59.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:55:59.391+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:55:59.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:59.401+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27093
04-23 12:55:59.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:59.451+0200 E/CAPI_APPFW_APPLICATION(27093): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:59.451+0200 E/CAPI_APPFW_APPLICATION(27093): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:59.451+0200 I/utils   (27093): trying to start service: es.ugr.frailty.accelerometer
04-23 12:55:59.451+0200 I/utils   (27093): es.ugr.frailty.accelerometer sensor supported
04-23 12:55:59.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27093
04-23 12:55:59.451+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27093) type(svcapp) bg(0)
04-23 12:55:59.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27093) was created
04-23 12:55:59.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27093)
04-23 12:55:59.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:55:59.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:59.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:59.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:59.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:59.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:59.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:59.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:55:59.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:55:59.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27093]
04-23 12:55:59.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:59.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:59.481+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27100
04-23 12:55:59.481+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:59.521+0200 E/CAPI_APPFW_APPLICATION(27100): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:59.521+0200 E/CAPI_APPFW_APPLICATION(27100): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:59.521+0200 I/utils   (27100): specific action
04-23 12:55:59.521+0200 I/recorder(27100): obteniendo datos locales...
04-23 12:55:59.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27100
04-23 12:55:59.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27100) type(svcapp) bg(0)
04-23 12:55:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:59.531+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27100]
04-23 12:55:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27093
04-23 12:55:59.541+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27100) was created
04-23 12:55:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:59.541+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27100)
04-23 12:55:59.541+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:55:59.551+0200 I/utils   (27093): es.ugr.frailty.accelerometer listener started
04-23 12:55:59.551+0200 I/accelerometer(27093): stopping es.ugr.frailty.accelerometer service
04-23 12:55:59.551+0200 E/CAPI_APPFW_APP_CONTROL(27093): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:55:59.551+0200 E/accelerometer(27093): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:55:59.551+0200 I/CAPI_APPFW_APPLICATION(27093): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:55:59.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:55:59.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:55:59.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:59.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27100
04-23 12:55:59.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:59.591+0200 I/recorder(27100): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:55:59.591+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:55:59.591+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:55:59.591+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:55:59.591+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:55:59.601+0200 I/recorder(27100): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:55:59.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:59.631+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27093
04-23 12:55:59.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:59.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:59.691+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27100
04-23 12:55:59.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:59.711+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:59.721+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:59.731+0200 I/accelerometer(27093): es.ugr.frailty.accelerometer listener destroyed
04-23 12:55:59.751+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11271007265631524480959
04-23 12:55:59.761+0200 W/AUL     (27111): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:55:59.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:55:59.761+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:55:59.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27100
04-23 12:55:59.761+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:55:59.761+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27100
04-23 12:55:59.771+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27100)
04-23 12:55:59.871+0200 W/AUL     (27119): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:55:59.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:55:59.881+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:55:59.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27093
04-23 12:55:59.881+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:55:59.881+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27093
04-23 12:55:59.881+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27093)
04-23 12:56:01.551+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:56:09.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:56:09.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:09.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:56:09.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:56:09.381+0200 I/utils   (25866): specific action
04-23 12:56:09.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:56:09.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:56:09.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:56:09.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:56:09.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:56:09.381+0200 I/httppostreq(25866): internet available
04-23 12:56:09.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:56:09.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:56:09.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:56:09.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:56:09.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:56:09.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:09.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:56:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:09.391+0200 I/utils   (25863): specific action
04-23 12:56:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:09.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:56:09.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:56:09.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:56:09.391+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:56:09.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:09.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:09.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27159
04-23 12:56:09.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:09.441+0200 E/CAPI_APPFW_APPLICATION(27159): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:09.441+0200 E/CAPI_APPFW_APPLICATION(27159): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:09.441+0200 I/utils   (27159): trying to start service: es.ugr.frailty.accelerometer
04-23 12:56:09.451+0200 I/utils   (27159): es.ugr.frailty.accelerometer sensor supported
04-23 12:56:09.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27159
04-23 12:56:09.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27159) type(svcapp) bg(0)
04-23 12:56:09.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27159)
04-23 12:56:09.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:56:09.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:09.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:09.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:09.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:09.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:09.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:09.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:56:09.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:56:09.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:09.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:09.471+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27159]
04-23 12:56:09.471+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27169
04-23 12:56:09.471+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:09.471+0200 I/utils   (27159): es.ugr.frailty.accelerometer listener started
04-23 12:56:09.481+0200 I/accelerometer(27159): stopping es.ugr.frailty.accelerometer service
04-23 12:56:09.481+0200 E/CAPI_APPFW_APP_CONTROL(27159): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:56:09.481+0200 E/accelerometer(27159): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:56:09.481+0200 I/CAPI_APPFW_APPLICATION(27159): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:56:09.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27169
04-23 12:56:09.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27169) type(svcapp) bg(0)
04-23 12:56:09.521+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27159) was created
04-23 12:56:09.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:09.521+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27169]
04-23 12:56:09.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27159
04-23 12:56:09.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:56:09.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:56:09.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:09.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:09.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27169
04-23 12:56:09.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:09.551+0200 E/CAPI_APPFW_APPLICATION(27169): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:09.551+0200 E/CAPI_APPFW_APPLICATION(27169): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:09.561+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27169) was created
04-23 12:56:09.561+0200 I/utils   (27169): specific action
04-23 12:56:09.561+0200 I/recorder(27169): obteniendo datos locales...
04-23 12:56:09.581+0200 I/recorder(27169): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:56:09.581+0200 I/recorder(27169): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:56:09.591+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27169)
04-23 12:56:09.591+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:56:09.671+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:09.681+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:09.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:09.701+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27159
04-23 12:56:09.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:09.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:09.731+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27169
04-23 12:56:09.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:09.761+0200 I/accelerometer(27159): es.ugr.frailty.accelerometer listener destroyed
04-23 12:56:09.791+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1127169726563152448096
