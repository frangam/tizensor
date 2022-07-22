S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 6772
Date: 2018-04-23 14:35:18+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf747e648, r1   = 0xf78a41b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf78a41b8, r5   = 0x00012cd0
r6   = 0xf78b6e88, r7   = 0xf747e250
r8   = 0x00000618, r9   = 0xf6f61824
r10  = 0xf789c9d8, fp   = 0x00000000
ip   = 0xf747d030, sp   = 0xffbca9b0
lr   = 0xf73c15d0, pc   = 0xf73bd9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     61864 KB
Buffers:     39584 KB
Cached:     221404 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7680 KB
VmRSS:        7676 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6af8000 f6afb000 r-xp /lib/libattr.so.1.1.0
f6b04000 f6b0b000 r-xp /lib/libcrypt-2.13.so
f6b3b000 f6b3e000 r-xp /lib/libcap.so.2.21
f6b46000 f6b48000 r-xp /usr/lib/libiri.so
f6b50000 f6b6d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b76000 f6b7a000 r-xp /usr/lib/libsmack.so.1.0.0
f6b84000 f6b86000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b8e000 f6b93000 r-xp /usr/lib/libffi.so.5.0.10
f6b9b000 f6b9c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ba4000 f6ba6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bae000 f6bb0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bba000 f6bca000 r-xp /lib/libresolv-2.13.so
f6bce000 f6be6000 r-xp /usr/lib/liblzma.so.5.0.3
f6bee000 f6bf0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bf8000 f6c27000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c30000 f6c3f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c48000 f6c52000 r-xp /usr/lib/libsensord-shared.so
f6c5b000 f6c8f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6c98000 f6d6b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d76000 f6d8c000 r-xp /lib/libz.so.1.2.5
f6d94000 f6d9a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6da3000 f6e18000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e22000 f6e3c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e44000 f6e4a000 r-xp /lib/librt-2.13.so
f6e53000 f6e71000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e7b000 f6e7c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e84000 f6e89000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e91000 f6f61000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f62000 f6f8c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f95000 f6fac000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fb4000 f701d000 r-xp /lib/libm-2.13.so
f7026000 f70ba000 r-xp /usr/lib/libstdc++.so.6.0.16
f70cd000 f70d2000 r-xp /usr/lib/libctx-client.so.0.8.3
f70da000 f70e1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70e9000 f7113000 r-xp /usr/lib/libsensor.so.1.9.6
f711c000 f71e8000 r-xp /usr/lib/libxml2.so.2.7.8
f71f5000 f71f7000 r-xp /usr/lib/libiniparser.so.0
f7200000 f7203000 r-xp /usr/lib/libbundle.so.0.1.22
f720b000 f7211000 r-xp /usr/lib/libappsvc.so.0.1.0
f7219000 f723c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7244000 f7285000 r-xp /usr/lib/libeina.so.1.7.99
f728e000 f72a5000 r-xp /usr/lib/libecore.so.1.7.99
f72bc000 f72c5000 r-xp /usr/lib/libvconf.so.0.2.45
f72cd000 f72e1000 r-xp /lib/libpthread-2.13.so
f72ec000 f72f9000 r-xp /usr/lib/libaul.so.0.1.0
f7303000 f7305000 r-xp /lib/libdl-2.13.so
f730e000 f7319000 r-xp /lib/libunwind.so.8.0.1
f7346000 f734e000 r-xp /lib/libgcc_s-4.6.so.1
f734f000 f7473000 r-xp /lib/libc-2.13.so
f7481000 f7483000 r-xp /usr/lib/libdlog.so.0.0.0
f748b000 f7497000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74a0000 f74a5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74ad000 f74b1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74ba000 f74bc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f74c5000 f74c8000 r-xp /usr/lib/libappcore-agent.so.1.1
f74e6000 f7503000 r-xp /lib/ld-2.13.so
f750c000 f750f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f750f000 f7513000 r-xp /usr/lib/libsys-assert.so
f7892000 f78e0000 rw-p [heap]
ffbac000 ffbcd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6772)
Call Stack Count: 1
 0: (0xf73bd9fc) [/lib/libc.so.6] + 0x6e9fc
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
e
04-23 14:34:58.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:34:58.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:34:58.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:34:58.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:34:58.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:34:58.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:58.041+0200 I/utils   ( 4440): specific action
04-23 14:34:58.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:58.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:58.041+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:34:58.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:34:58.041+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:34:58.041+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:34:58.041+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:34:58.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:58.061+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:58.061+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6639
04-23 14:34:58.121+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6639
04-23 14:34:58.121+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6639) type(svcapp) bg(0)
04-23 14:34:58.121+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6639)
04-23 14:34:58.121+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:34:58.121+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:34:58.121+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:34:58.121+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6639]
04-23 14:34:58.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:58.131+0200 E/CAPI_APPFW_APPLICATION( 6639): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.141+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6642
04-23 14:34:58.141+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:58.151+0200 E/CAPI_APPFW_APPLICATION( 6639): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.151+0200 I/utils   ( 6639): trying to start service: es.ugr.frailty.accelerometer
04-23 14:34:58.161+0200 I/utils   ( 6639): es.ugr.frailty.accelerometer sensor supported
04-23 14:34:58.171+0200 I/utils   ( 6639): es.ugr.frailty.accelerometer listener started
04-23 14:34:58.171+0200 I/accelerometer( 6639): stopping es.ugr.frailty.accelerometer service
04-23 14:34:58.171+0200 E/CAPI_APPFW_APP_CONTROL( 6639): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.171+0200 E/accelerometer( 6639): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:34:58.171+0200 I/CAPI_APPFW_APPLICATION( 6639): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:34:58.181+0200 E/CAPI_APPFW_APPLICATION( 6642): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.181+0200 E/CAPI_APPFW_APPLICATION( 6642): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.191+0200 I/utils   ( 6642): trying to start service: es.ugr.frailty.gyroscope
04-23 14:34:58.191+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6642
04-23 14:34:58.191+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(6642) type(svcapp) bg(0)
04-23 14:34:58.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6642)
04-23 14:34:58.191+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:34:58.191+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:34:58.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:34:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6639
04-23 14:34:58.201+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6639) was created
04-23 14:34:58.201+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6642) was created
04-23 14:34:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6639
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.211+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:58.211+0200 I/utils   ( 6642): es.ugr.frailty.gyroscope sensor supported
04-23 14:34:58.221+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6661
04-23 14:34:58.231+0200 I/utils   ( 6642): es.ugr.frailty.gyroscope listener started
04-23 14:34:58.231+0200 I/gyroscope( 6642): stopping es.ugr.frailty.gyroscope service
04-23 14:34:58.231+0200 E/CAPI_APPFW_APP_CONTROL( 6642): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.231+0200 E/gyroscope( 6642): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:34:58.231+0200 I/CAPI_APPFW_APPLICATION( 6642): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:34:58.241+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6642]
04-23 14:34:58.241+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:58.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6661
04-23 14:34:58.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(6661) type(svcapp) bg(0)
04-23 14:34:58.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:34:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:34:58.281+0200 E/CAPI_APPFW_APPLICATION( 6661): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.281+0200 E/CAPI_APPFW_APPLICATION( 6661): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.291+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6661) was created
04-23 14:34:58.291+0200 I/utils   ( 6661): trying to start service: es.ugr.frailty.heartrate
04-23 14:34:58.291+0200 I/utils   ( 6661): es.ugr.frailty.heartrate sensor supported
04-23 14:34:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.301+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6642
04-23 14:34:58.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.311+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6661]
04-23 14:34:58.311+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6661)
04-23 14:34:58.311+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:34:58.311+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:34:58.321+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:34:58.321+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:34:58.321+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:34:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:34:58.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:34:58.321+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:34:58.321+0200 I/utils   ( 6661): es.ugr.frailty.heartrate listener started
04-23 14:34:58.321+0200 I/heartrate( 6661): stopping es.ugr.frailty.heartrate service
04-23 14:34:58.321+0200 E/CAPI_APPFW_APP_CONTROL( 6661): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.321+0200 E/heartrate( 6661): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:34:58.321+0200 I/CAPI_APPFW_APPLICATION( 6661): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:34:58.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:34:58.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:34:58.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:34:58.331+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:34:58.331+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:34:58.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:34:58.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.341+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6661
04-23 14:34:58.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.351+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6642
04-23 14:34:58.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.351+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:34:58.351+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:34:58.351+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:34:58.351+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:34:58.351+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:34:58.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:34:58.361+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:34:58.371+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6677
04-23 14:34:58.381+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:34:58.391+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.401+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.411+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6677
04-23 14:34:58.421+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6677) type(svcapp) bg(0)
04-23 14:34:58.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.421+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6677]
04-23 14:34:58.421+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6677
04-23 14:34:58.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.451+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6677)
04-23 14:34:58.451+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:34:58.471+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.481+0200 I/accelerometer( 6639): es.ugr.frailty.accelerometer listener destroyed
04-23 14:34:58.481+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:34:58.481+0200 E/CAPI_APPFW_APPLICATION( 6677): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.481+0200 E/CAPI_APPFW_APPLICATION( 6677): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:34:58.481+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6677) was created
04-23 14:34:58.481+0200 I/utils   ( 6677): specific action
04-23 14:34:58.481+0200 I/recorder( 6677): obteniendo datos locales...
04-23 14:34:58.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.511+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6661
04-23 14:34:58.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:34:58.541+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6677
04-23 14:34:58.541+0200 I/heartrate( 6661): es.ugr.frailty.heartrate listener destroyed
04-23 14:34:58.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:34:58.541+0200 I/gyroscope( 6642): es.ugr.frailty.gyroscope listener destroyed
04-23 14:34:58.541+0200 I/recorder( 6677): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:34:58.541+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:34:58.551+0200 I/recorder( 6677): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:34:58.601+0200 W/AUL     ( 6684): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 14:34:58.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:34:58.601+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:34:58.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6639
04-23 14:34:58.601+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:34:58.601+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6639
04-23 14:34:58.601+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6639)
04-23 14:34:58.611+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 11066777265631524486898
04-23 14:34:58.631+0200 W/AUL     ( 6687): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 14:34:58.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:34:58.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:34:58.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6677
04-23 14:34:58.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:34:58.631+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6677
04-23 14:34:58.631+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6677)
04-23 14:34:58.671+0200 W/AUL     ( 6689): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 14:34:58.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:34:58.671+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:34:58.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6642
04-23 14:34:58.671+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:34:58.681+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6642
04-23 14:34:58.681+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6642)
04-23 14:34:58.691+0200 W/AUL     ( 6691): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 14:34:58.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:34:58.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:34:58.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6661
04-23 14:34:58.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:34:58.701+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6661
04-23 14:34:58.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6661)
04-23 14:34:59.851+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 14:34:59.861+0200 W/SHealthService( 3091): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
04-23 14:34:59.871+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_int(1132) > preference_get_int(3091) : key(pedometer_goal_achieve_percents) error
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_int(1132) > preference_get_int(3091) : key(best_step_goal) error
04-23 14:34:59.871+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:34:59.881+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:34:59.891+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 14:34:59.911+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 14:35:00.211+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:35:00.281+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:35:00.331+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:35:00.501+0200 W/SHealthService( 3091): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
04-23 14:35:17.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:35:17.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:17.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:35:18.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:35:18.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:35:18.001+0200 I/utils   ( 4443): specific action
04-23 14:35:18.001+0200 I/httppostreq( 4443): internet connection check received
04-23 14:35:18.001+0200 I/httppostreq( 4443): internet connection != null
04-23 14:35:18.001+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:35:18.001+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:35:18.001+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:35:18.001+0200 I/httppostreq( 4443): internet connection type...
04-23 14:35:18.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:35:18.011+0200 I/httppostreq( 4443): internet available
04-23 14:35:18.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:35:18.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:35:18.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:35:18.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:35:18.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:35:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:18.031+0200 I/utils   ( 4440): specific action
04-23 14:35:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:18.031+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:35:18.031+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:35:18.031+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:35:18.031+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:35:18.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.061+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6735
04-23 14:35:18.061+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:18.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6735
04-23 14:35:18.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6735) type(svcapp) bg(0)
04-23 14:35:18.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6735)
04-23 14:35:18.111+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:35:18.111+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:35:18.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:35:18.111+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6735]
04-23 14:35:18.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6738
04-23 14:35:18.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:18.151+0200 E/CAPI_APPFW_APPLICATION( 6735): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.151+0200 E/CAPI_APPFW_APPLICATION( 6735): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.151+0200 I/utils   ( 6735): trying to start service: es.ugr.frailty.accelerometer
04-23 14:35:18.161+0200 I/utils   ( 6735): es.ugr.frailty.accelerometer sensor supported
04-23 14:35:18.171+0200 I/utils   ( 6735): es.ugr.frailty.accelerometer listener started
04-23 14:35:18.171+0200 I/accelerometer( 6735): stopping es.ugr.frailty.accelerometer service
04-23 14:35:18.171+0200 E/CAPI_APPFW_APP_CONTROL( 6735): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.171+0200 E/accelerometer( 6735): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:35:18.171+0200 I/CAPI_APPFW_APPLICATION( 6735): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:35:18.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6738
04-23 14:35:18.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(6738) type(svcapp) bg(0)
04-23 14:35:18.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6738)
04-23 14:35:18.191+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:35:18.191+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:35:18.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:35:18.191+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6738]
04-23 14:35:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6735
04-23 14:35:18.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6735) was created
04-23 14:35:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6735
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.201+0200 E/CAPI_APPFW_APPLICATION( 6738): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.201+0200 E/CAPI_APPFW_APPLICATION( 6738): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.201+0200 I/utils   ( 6738): trying to start service: es.ugr.frailty.gyroscope
04-23 14:35:18.211+0200 I/utils   ( 6738): es.ugr.frailty.gyroscope sensor supported
04-23 14:35:18.221+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6758
04-23 14:35:18.221+0200 I/utils   ( 6738): es.ugr.frailty.gyroscope listener started
04-23 14:35:18.221+0200 I/gyroscope( 6738): stopping es.ugr.frailty.gyroscope service
04-23 14:35:18.221+0200 E/CAPI_APPFW_APP_CONTROL( 6738): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.221+0200 E/gyroscope( 6738): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:35:18.221+0200 I/CAPI_APPFW_APPLICATION( 6738): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:35:18.241+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6758
04-23 14:35:18.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(6758) type(svcapp) bg(0)
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6738) was created
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:35:18.281+0200 E/CAPI_APPFW_APPLICATION( 6758): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.281+0200 E/CAPI_APPFW_APPLICATION( 6758): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.281+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6758) was created
04-23 14:35:18.281+0200 I/utils   ( 6758): trying to start service: es.ugr.frailty.heartrate
04-23 14:35:18.291+0200 I/utils   ( 6758): es.ugr.frailty.heartrate sensor supported
04-23 14:35:18.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.301+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6738
04-23 14:35:18.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.311+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6758]
04-23 14:35:18.321+0200 I/utils   ( 6758): es.ugr.frailty.heartrate listener started
04-23 14:35:18.321+0200 I/heartrate( 6758): stopping es.ugr.frailty.heartrate service
04-23 14:35:18.321+0200 E/CAPI_APPFW_APP_CONTROL( 6758): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.321+0200 E/heartrate( 6758): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:35:18.321+0200 I/CAPI_APPFW_APPLICATION( 6758): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:35:18.321+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6758)
04-23 14:35:18.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.321+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:35:18.321+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:35:18.321+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:35:18.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:35:18.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:35:18.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:35:18.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:35:18.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:35:18.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:35:18.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:35:18.321+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:35:18.321+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:35:18.331+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:35:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6738
04-23 14:35:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:35:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:35:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.341+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6758
04-23 14:35:18.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.341+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.351+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6772
04-23 14:35:18.371+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:18.401+0200 E/CAPI_APPFW_APPLICATION( 6772): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.401+0200 E/CAPI_APPFW_APPLICATION( 6772): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6772
04-23 14:35:18.401+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6772) type(svcapp) bg(0)
04-23 14:35:18.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.411+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6772) was created
04-23 14:35:18.411+0200 I/utils   ( 6772): specific action
04-23 14:35:18.411+0200 I/recorder( 6772): obteniendo datos locales...
04-23 14:35:18.411+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6772]
04-23 14:35:18.421+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6772)
04-23 14:35:18.421+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:35:18.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.431+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6772
04-23 14:35:18.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6758
04-23 14:35:18.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.451+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.471+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.491+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.501+0200 I/accelerometer( 6735): es.ugr.frailty.accelerometer listener destroyed
04-23 14:35:18.501+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.521+0200 I/recorder( 6772): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:35:18.521+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6772
04-23 14:35:18.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.521+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.531+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.551+0200 I/gyroscope( 6738): es.ugr.frailty.gyroscope listener destroyed
04-23 14:35:18.551+0200 I/heartrate( 6758): es.ugr.frailty.heartrate listener destroyed
04-23 14:35:18.571+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1106772726563152448691
