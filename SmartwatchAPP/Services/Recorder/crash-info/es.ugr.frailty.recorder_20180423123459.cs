S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 20928
Date: 2018-04-23 12:34:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7328648, r1   = 0xf74b11b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf74b11b8, r5   = 0x00012cd0
r6   = 0xf74c3e88, r7   = 0xf7328250
r8   = 0x000005d8, r9   = 0xf6e0b824
r10  = 0xf74a99d8, fp   = 0x00000000
ip   = 0xf7327030, sp   = 0xff84faa8
lr   = 0xf726b5d0, pc   = 0xf72679fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     11852 KB
Buffers:     70432 KB
Cached:     189688 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7756 KB
VmRSS:        7752 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f69a2000 f69a5000 r-xp /lib/libattr.so.1.1.0
f69ae000 f69b5000 r-xp /lib/libcrypt-2.13.so
f69e5000 f69e8000 r-xp /lib/libcap.so.2.21
f69f0000 f69f2000 r-xp /usr/lib/libiri.so
f69fa000 f6a17000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a20000 f6a24000 r-xp /usr/lib/libsmack.so.1.0.0
f6a2e000 f6a30000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a38000 f6a3d000 r-xp /usr/lib/libffi.so.5.0.10
f6a45000 f6a46000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a4e000 f6a50000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a58000 f6a5a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a64000 f6a74000 r-xp /lib/libresolv-2.13.so
f6a78000 f6a90000 r-xp /usr/lib/liblzma.so.5.0.3
f6a98000 f6a9a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aa2000 f6ad1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ada000 f6ae9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6af2000 f6afc000 r-xp /usr/lib/libsensord-shared.so
f6b05000 f6b39000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b42000 f6c15000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c20000 f6c36000 r-xp /lib/libz.so.1.2.5
f6c3e000 f6c44000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c4d000 f6cc2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ccc000 f6ce6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cee000 f6cf4000 r-xp /lib/librt-2.13.so
f6cfd000 f6d1b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d25000 f6d26000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d2e000 f6d33000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d3b000 f6e0b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e0c000 f6e36000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e3f000 f6e56000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e5e000 f6ec7000 r-xp /lib/libm-2.13.so
f6ed0000 f6f64000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f77000 f6f7c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f84000 f6f8b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f93000 f6fbd000 r-xp /usr/lib/libsensor.so.1.9.6
f6fc6000 f7092000 r-xp /usr/lib/libxml2.so.2.7.8
f709f000 f70a1000 r-xp /usr/lib/libiniparser.so.0
f70aa000 f70ad000 r-xp /usr/lib/libbundle.so.0.1.22
f70b5000 f70bb000 r-xp /usr/lib/libappsvc.so.0.1.0
f70c3000 f70e6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70ee000 f712f000 r-xp /usr/lib/libeina.so.1.7.99
f7138000 f714f000 r-xp /usr/lib/libecore.so.1.7.99
f7166000 f716f000 r-xp /usr/lib/libvconf.so.0.2.45
f7177000 f718b000 r-xp /lib/libpthread-2.13.so
f7196000 f71a3000 r-xp /usr/lib/libaul.so.0.1.0
f71ad000 f71af000 r-xp /lib/libdl-2.13.so
f71b8000 f71c3000 r-xp /lib/libunwind.so.8.0.1
f71f0000 f71f8000 r-xp /lib/libgcc_s-4.6.so.1
f71f9000 f731d000 r-xp /lib/libc-2.13.so
f732b000 f732d000 r-xp /usr/lib/libdlog.so.0.0.0
f7335000 f7341000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f734a000 f734f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7357000 f735b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7364000 f7366000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f736f000 f7372000 r-xp /usr/lib/libappcore-agent.so.1.1
f7390000 f73ad000 r-xp /lib/ld-2.13.so
f73b6000 f73b9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f73b9000 f73bd000 r-xp /usr/lib/libsys-assert.so
f749f000 f74ed000 rw-p [heap]
ff831000 ff852000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20928)
Call Stack Count: 1
 0: (0xf72679fc) [/lib/libc.so.6] + 0x6e9fc
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
0,23/04/2018,12:34:32:95,-0.009571,9.791430,0.861416
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:32:296,-0.026321,9.822537,0.806381
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:32:495,-0.026321,9.801002,0.777667
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:32:695,-0.009571,9.812965,0.803988
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:32:895,0.007178,9.767502,0.787239
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:95,-0.011964,9.803394,0.827917
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:296,-0.069392,9.786645,0.827917
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:496,0.011964,9.781858,0.775275
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:696,0.016750,9.786645,0.787239
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:896,0.016750,9.786645,0.818345
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:34:96,0.019143,9.834501,0.799203
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:34:296,-0.019143,9.801002,0.803988
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:34:497,0.01675
04-23 12:34:39.181+0200 I/httppostreq(20587): HTTP POST data service=es.ugr.frailty.accelerometer&data=SM-R760,23/04/2018,12:34:31:496,9.841680,0.011964,0.796810
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:31:699,-0.009571,9.791430,0.835095
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:31:895,0.019143,9.781858,0.780060
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:32:95,-0.009571,9.791430,0.861416
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:32:296,-0.026321,9.822537,0.806381
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:32:495,-0.026321,9.801002,0.777667
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:32:695,-0.009571,9.812965,0.803988
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:32:895,0.007178,9.767502,0.787239
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:95,-0.011964,9.803394,0.827917
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:296,-0.069392,9.786645,0.827917
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:496,0.011964,9.781858,0.775275
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:696,0.016750,9.786645,0.787239
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:33:896,0.016750,9.786645,0.818345
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:34:96,0.019143,9.834501,0.799203
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:34:296,-0.019143,9.801002,0.803988
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/2018,12:34:34:497,0.016750,9.791430,0.780060
04-23 12:34:39.181+0200 I/httppostreq(20587): SM-R760,23/04/201
04-23 12:34:39.191+0200 I/utils   (20826): es.ugr.frailty.accelerometer listener started
04-23 12:34:39.191+0200 I/accelerometer(20826): stopping es.ugr.frailty.accelerometer service
04-23 12:34:39.191+0200 E/CAPI_APPFW_APP_CONTROL(20826): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:34:39.191+0200 E/accelerometer(20826): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:34:39.191+0200 I/CAPI_APPFW_APPLICATION(20826): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:34:39.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:34:39.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:34:39.271+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:39.281+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:39.291+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:34:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:39.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:34:39.301+0200 I/accelerometer(20826): es.ugr.frailty.accelerometer listener destroyed
04-23 12:34:39.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:34:39.301+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.301+0200 I/utils   (20584): specific action
04-23 12:34:39.301+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.301+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.301+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.301+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:34:39.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:39.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:34:39.311+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:34:39.311+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:34:39.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:39.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:39.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20589
04-23 12:34:39.321+0200 W/CAPI_APPFW_APP_CONTROL(20589): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.321+0200 I/utils   (20589): specific action
04-23 12:34:39.321+0200 W/CAPI_APPFW_APP_CONTROL(20589): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:39.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20589), cmd(0)
04-23 12:34:39.321+0200 W/CAPI_APPFW_APP_CONTROL(20589): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.321+0200 I/recorder(20589): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:34:39.321+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20589)
04-23 12:34:39.321+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:34:39.321+0200 I/servicemanager(20584): eliminar datos locales
04-23 12:34:39.321+0200 W/AUL     (20589): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:34:39.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:39.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20589
04-23 12:34:39.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:34:39.331+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.331+0200 I/utils   (20584): specific action
04-23 12:34:39.331+0200 W/AUL     (20589): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:34:39.331+0200 I/recorder(20589): request sent to service es.ugr.frailty.servicemanager
04-23 12:34:39.341+0200 I/recorder(20589): eliminando datos en local
04-23 12:34:39.341+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.341+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:39.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:34:39.341+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.341+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.341+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:39.341+0200 I/servicemanager(20584): launch es.ugr.frailty.accelerometer
04-23 12:34:39.341+0200 I/servicemanager(20584): re launch service
04-23 12:34:39.421+0200 W/AUL     (20840): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:34:39.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:34:39.431+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:34:39.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20826
04-23 12:34:39.431+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:34:39.451+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20826
04-23 12:34:39.451+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20826)
04-23 12:34:41.201+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:34:41.341+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer alive timeout
04-23 12:34:41.341+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:34:41.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:41.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:41.371+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20841
04-23 12:34:41.371+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:34:41.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20841
04-23 12:34:41.421+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(20841) type(svcapp) bg(0)
04-23 12:34:41.431+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20841)
04-23 12:34:41.431+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer launch request sent!
04-23 12:34:41.431+0200 I/servicemanager(20584): App control destroyed.
04-23 12:34:41.431+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20841]
04-23 12:34:41.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:34:41.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20841
04-23 12:34:41.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:34:41.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:34:41.481+0200 E/CAPI_APPFW_APPLICATION(20841): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:41.481+0200 E/CAPI_APPFW_APPLICATION(20841): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:41.481+0200 I/utils   (20841): trying to start service: es.ugr.frailty.accelerometer
04-23 12:34:41.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20841
04-23 12:34:41.491+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20841) was created
04-23 12:34:41.491+0200 I/utils   (20841): es.ugr.frailty.accelerometer sensor supported
04-23 12:34:41.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:34:41.501+0200 I/utils   (20841): es.ugr.frailty.accelerometer listener started
04-23 12:34:41.501+0200 W/CAPI_APPFW_APP_CONTROL(20841): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:41.501+0200 I/utils   (20841): specific action
04-23 12:34:41.531+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:34:41.731+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:34:41.931+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:34:42.131+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:34:42.331+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:34:42.531+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:34:42.731+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:34:42.941+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:34:43.131+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:34:43.331+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:34:43.531+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:34:43.731+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:34:43.931+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:34:44.131+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:34:44.331+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:34:44.531+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:34:44.731+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:34:44.931+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:34:45.131+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:34:45.331+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:34:45.531+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:34:45.731+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:34:45.931+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:34:46.131+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:34:46.331+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:34:46.531+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer sleep timeout
04-23 12:34:46.531+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:34:46.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:46.531+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:46.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20841
04-23 12:34:46.551+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20841)
04-23 12:34:46.551+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:34:46.551+0200 I/servicemanager(20584): App control destroyed.
04-23 12:34:46.561+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:46.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20841), cmd(0)
04-23 12:34:46.561+0200 I/accelerometer(20841): stopping es.ugr.frailty.accelerometer service
04-23 12:34:46.561+0200 W/AUL     (20841): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:34:46.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:46.561+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20841
04-23 12:34:46.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:34:46.591+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:46.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:34:46.591+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:46.591+0200 I/utils   (20584): specific action
04-23 12:34:46.591+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:34:46.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:46.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:46.611+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20589
04-23 12:34:46.611+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:46.611+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20589), cmd(0)
04-23 12:34:46.611+0200 W/CAPI_APPFW_APP_CONTROL(20589): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:46.611+0200 I/utils   (20589): specific action
04-23 12:34:46.611+0200 W/CAPI_APPFW_APP_CONTROL(20589): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:46.611+0200 I/recorder(20589): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:34:46.611+0200 I/recorder(20589): guardando datos en local
04-23 12:34:46.621+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20589)
04-23 12:34:46.621+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:34:46.621+0200 I/servicemanager(20584): requesting to save local data
04-23 12:34:46.621+0200 W/AUL     (20841): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:34:46.621+0200 I/accelerometer(20841): request sent to service es.ugr.frailty.servicemanager
04-23 12:34:46.621+0200 I/CAPI_APPFW_APPLICATION(20841): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:34:46.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:34:46.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:34:46.691+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:46.701+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:46.721+0200 I/accelerometer(20841): es.ugr.frailty.accelerometer listener destroyed
04-23 12:34:46.851+0200 W/AUL     (20855): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:34:46.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:34:46.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:34:46.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20841
04-23 12:34:46.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:34:46.881+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20841
04-23 12:34:46.881+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20841)
04-23 12:34:48.631+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:34:48.981+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:34:48.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:48.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:34:49.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:34:49.001+0200 I/utils   (20587): specific action
04-23 12:34:49.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:34:49.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:34:49.001+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:34:49.001+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:34:49.001+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:34:49.001+0200 I/httppostreq(20587): internet connection type...
04-23 12:34:49.001+0200 I/httppostreq(20587): internet connection type 1
04-23 12:34:49.001+0200 I/httppostreq(20587): internet available
04-23 12:34:49.001+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:34:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:34:49.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:34:49.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:34:49.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:49.031+0200 I/utils   (20584): specific action
04-23 12:34:49.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:49.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:34:49.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:34:49.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:34:49.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:49.051+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20856
04-23 12:34:49.051+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:34:49.051+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:34:49.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20856
04-23 12:34:49.101+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(20856) type(svcapp) bg(0)
04-23 12:34:49.101+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20856)
04-23 12:34:49.101+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:34:49.101+0200 I/servicemanager(20584): App control destroyed.
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:49.101+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:49.101+0200 E/servicemanager(20584): deleting timer 0
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:49.101+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:49.101+0200 E/servicemanager(20584): deleting timer 1
04-23 12:34:49.101+0200 E/servicemanager(20584): deleting timer 2
04-23 12:34:49.101+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:34:49.111+0200 E/CAPI_APPFW_APPLICATION(20856): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:49.111+0200 E/CAPI_APPFW_APPLICATION(20856): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:49.111+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20856]
04-23 12:34:49.111+0200 I/utils   (20856): trying to start service: es.ugr.frailty.accelerometer
04-23 12:34:49.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:49.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20589
04-23 12:34:49.121+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20856) was created
04-23 12:34:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:34:49.121+0200 I/utils   (20856): es.ugr.frailty.accelerometer sensor supported
04-23 12:34:49.141+0200 I/utils   (20856): es.ugr.frailty.accelerometer listener started
04-23 12:34:49.141+0200 I/accelerometer(20856): stopping es.ugr.frailty.accelerometer service
04-23 12:34:49.141+0200 E/CAPI_APPFW_APP_CONTROL(20856): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:34:49.141+0200 E/accelerometer(20856): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:34:49.141+0200 I/CAPI_APPFW_APPLICATION(20856): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20856
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:34:49.141+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20589), cmd(0)
04-23 12:34:49.151+0200 I/utils   (20589): specific action
04-23 12:34:49.151+0200 I/recorder(20589): obteniendo datos locales...
04-23 12:34:49.151+0200 I/recorder(20589): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:34:49.151+0200 I/recorder(20589): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 12:34:49.151+0200 I/recorder(20589): obteniendo datos locales, DATA: SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:738,-0.0
04-23 12:34:49.151+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20589)
04-23 12:34:49.151+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:34:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:34:49.171+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20856
04-23 12:34:49.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:34:49.261+0200 W/AUL     (20872): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:34:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:34:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:34:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20589
04-23 12:34:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:34:49.271+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20589
04-23 12:34:49.271+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20589)
04-23 12:34:49.301+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 06205897265631524479689
04-23 12:34:49.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:49.331+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:49.341+0200 I/accelerometer(20856): es.ugr.frailty.accelerometer listener destroyed
04-23 12:34:49.501+0200 W/AUL     (20884): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:34:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:34:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:34:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20856
04-23 12:34:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:34:49.511+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20856
04-23 12:34:49.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20856)
04-23 12:34:51.141+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:34:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:34:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:34:59.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:34:59.001+0200 I/utils   (20587): specific action
04-23 12:34:59.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:34:59.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:34:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:34:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:34:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:34:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:34:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:34:59.011+0200 I/httppostreq(20587): internet available
04-23 12:34:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:34:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:34:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:34:59.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:34:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:59.041+0200 I/utils   (20584): specific action
04-23 12:34:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:59.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:34:59.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:34:59.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:34:59.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:34:59.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:59.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20926
04-23 12:34:59.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:34:59.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20926
04-23 12:34:59.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(20926) type(svcapp) bg(0)
04-23 12:34:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20926)
04-23 12:34:59.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:34:59.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:59.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:59.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:59.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:34:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:34:59.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:59.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20926]
04-23 12:34:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:59.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20928
04-23 12:34:59.141+0200 E/CAPI_APPFW_APPLICATION(20926): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.141+0200 E/CAPI_APPFW_APPLICATION(20926): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.141+0200 I/utils   (20926): trying to start service: es.ugr.frailty.accelerometer
04-23 12:34:59.141+0200 I/utils   (20926): es.ugr.frailty.accelerometer sensor supported
04-23 12:34:59.151+0200 I/utils   (20926): es.ugr.frailty.accelerometer listener started
04-23 12:34:59.151+0200 I/accelerometer(20926): stopping es.ugr.frailty.accelerometer service
04-23 12:34:59.161+0200 E/CAPI_APPFW_APP_CONTROL(20926): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.161+0200 E/accelerometer(20926): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:34:59.161+0200 I/CAPI_APPFW_APPLICATION(20926): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:34:59.181+0200 E/CAPI_APPFW_APPLICATION(20928): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.181+0200 E/CAPI_APPFW_APPLICATION(20928): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.181+0200 I/utils   (20928): specific action
04-23 12:34:59.181+0200 I/recorder(20928): obteniendo datos locales...
04-23 12:34:59.201+0200 I/recorder(20928): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:34:59.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20928
04-23 12:34:59.251+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(20928) type(svcapp) bg(0)
04-23 12:34:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:34:59.261+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1120928726563152447969
