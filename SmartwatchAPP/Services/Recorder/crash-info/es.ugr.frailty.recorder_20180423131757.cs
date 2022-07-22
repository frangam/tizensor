S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 30193
Date: 2018-04-23 13:17:57+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf74b6648, r1   = 0xf75901b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf75901b8, r5   = 0x00012cd0
r6   = 0xf75a2e88, r7   = 0xf74b6250
r8   = 0x00000608, r9   = 0xf6f99824
r10  = 0xf75889d8, fp   = 0x00000000
ip   = 0xf74b5030, sp   = 0xff9895e0
lr   = 0xf73f95d0, pc   = 0xf73f59fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     10660 KB
Buffers:     70748 KB
Cached:     180788 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7692 KB
VmRSS:        7688 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6b30000 f6b33000 r-xp /lib/libattr.so.1.1.0
f6b3c000 f6b43000 r-xp /lib/libcrypt-2.13.so
f6b73000 f6b76000 r-xp /lib/libcap.so.2.21
f6b7e000 f6b80000 r-xp /usr/lib/libiri.so
f6b88000 f6ba5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bae000 f6bb2000 r-xp /usr/lib/libsmack.so.1.0.0
f6bbc000 f6bbe000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bc6000 f6bcb000 r-xp /usr/lib/libffi.so.5.0.10
f6bd3000 f6bd4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bdc000 f6bde000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6be6000 f6be8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bf2000 f6c02000 r-xp /lib/libresolv-2.13.so
f6c06000 f6c1e000 r-xp /usr/lib/liblzma.so.5.0.3
f6c26000 f6c28000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c30000 f6c5f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c68000 f6c77000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c80000 f6c8a000 r-xp /usr/lib/libsensord-shared.so
f6c93000 f6cc7000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cd0000 f6da3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dae000 f6dc4000 r-xp /lib/libz.so.1.2.5
f6dcc000 f6dd2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ddb000 f6e50000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e5a000 f6e74000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e7c000 f6e82000 r-xp /lib/librt-2.13.so
f6e8b000 f6ea9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6eb3000 f6eb4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ebc000 f6ec1000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ec9000 f6f99000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f9a000 f6fc4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fcd000 f6fe4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fec000 f7055000 r-xp /lib/libm-2.13.so
f705e000 f70f2000 r-xp /usr/lib/libstdc++.so.6.0.16
f7105000 f710a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7112000 f7119000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7121000 f714b000 r-xp /usr/lib/libsensor.so.1.9.6
f7154000 f7220000 r-xp /usr/lib/libxml2.so.2.7.8
f722d000 f722f000 r-xp /usr/lib/libiniparser.so.0
f7238000 f723b000 r-xp /usr/lib/libbundle.so.0.1.22
f7243000 f7249000 r-xp /usr/lib/libappsvc.so.0.1.0
f7251000 f7274000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f727c000 f72bd000 r-xp /usr/lib/libeina.so.1.7.99
f72c6000 f72dd000 r-xp /usr/lib/libecore.so.1.7.99
f72f4000 f72fd000 r-xp /usr/lib/libvconf.so.0.2.45
f7305000 f7319000 r-xp /lib/libpthread-2.13.so
f7324000 f7331000 r-xp /usr/lib/libaul.so.0.1.0
f733b000 f733d000 r-xp /lib/libdl-2.13.so
f7346000 f7351000 r-xp /lib/libunwind.so.8.0.1
f737e000 f7386000 r-xp /lib/libgcc_s-4.6.so.1
f7387000 f74ab000 r-xp /lib/libc-2.13.so
f74b9000 f74bb000 r-xp /usr/lib/libdlog.so.0.0.0
f74c3000 f74cf000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74d8000 f74dd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74e5000 f74e9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74f2000 f74f4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f74fd000 f7500000 r-xp /usr/lib/libappcore-agent.so.1.1
f751e000 f753b000 r-xp /lib/ld-2.13.so
f7544000 f7547000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7547000 f754b000 r-xp /usr/lib/libsys-assert.so
f757e000 f75cc000 rw-p [heap]
ff96b000 ff98c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30193)
Call Stack Count: 1
 0: (0xf73f59fc) [/lib/libc.so.6] + 0x6e9fc
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
1,0.490000,-0.840000,0.490000
04-23 13:17:24.341+0200 I/accelerometer(30079): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,13:17:24:348,8.228917,3.381058,4.371687
04-23 13:17:24.531+0200 I/gyroscope(30092): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,13:17:24:541,2.100000,-2.520000,0.560000
04-23 13:17:24.541+0200 I/accelerometer(30079): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,13:17:24:548,8.197811,3.385844,4.182654
04-23 13:17:24.731+0200 I/gyroscope(30092): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,13:17:24:742,3.010000,-2.590000,-1.610000
04-23 13:17:24.741+0200 I/accelerometer(30079): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,13:17:24:748,8.283953,3.639483,3.984050
04-23 13:17:24.931+0200 I/gyroscope(30092): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,13:17:24:942,2.450000,1.610000,-1.050000
04-23 13:17:24.941+0200 I/accelerometer(30079): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,13:17:24:948,8.207381,3.711268,3.651447
04-23 13:17:24.961+0200 I/servicemanager(29360): es.ugr.frailty.accelerometer sleep timeout
04-23 13:17:24.961+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:17:24.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:24.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:24.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30079
04-23 13:17:24.981+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30079)
04-23 13:17:24.981+0200 I/servicemanager(29360): es.ugr.frailty.accelerometer stop request sent!
04-23 13:17:24.981+0200 I/servicemanager(29360): App control destroyed.
04-23 13:17:24.991+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:24.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(30079), cmd(0)
04-23 13:17:24.991+0200 I/accelerometer(30079): stopping es.ugr.frailty.accelerometer service
04-23 13:17:24.991+0200 W/AUL     (30079): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:17:25.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:25.001+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30079
04-23 13:17:25.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29360
04-23 13:17:25.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:25.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(29360), cmd(0)
04-23 13:17:25.031+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:25.031+0200 I/utils   (29360): specific action
04-23 13:17:25.031+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:17:25.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:25.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:25.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29365
04-23 13:17:25.061+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:25.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(29365), cmd(0)
04-23 13:17:25.061+0200 W/CAPI_APPFW_APP_CONTROL(29365): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:25.061+0200 I/utils   (29365): specific action
04-23 13:17:25.061+0200 W/CAPI_APPFW_APP_CONTROL(29365): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:25.061+0200 I/recorder(29365): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:17:25.061+0200 I/recorder(29365): guardando datos en local
04-23 13:17:25.071+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29365)
04-23 13:17:25.071+0200 I/servicemanager(29360): request sent to service es.ugr.frailty.recorder
04-23 13:17:25.071+0200 I/servicemanager(29360): requesting to save local data
04-23 13:17:25.071+0200 I/servicemanager(29360): es.ugr.frailty.gyroscope sleep timeout
04-23 13:17:25.071+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 13:17:25.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:25.071+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:25.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30092
04-23 13:17:25.091+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30092)
04-23 13:17:25.091+0200 I/servicemanager(29360): es.ugr.frailty.gyroscope stop request sent!
04-23 13:17:25.091+0200 I/servicemanager(29360): App control destroyed.
04-23 13:17:25.091+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:25.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(30092), cmd(0)
04-23 13:17:25.091+0200 W/AUL     (30079): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29360)
04-23 13:17:25.091+0200 I/accelerometer(30079): request sent to service es.ugr.frailty.servicemanager
04-23 13:17:25.091+0200 I/CAPI_APPFW_APPLICATION(30079): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:17:25.091+0200 I/gyroscope(30092): stopping es.ugr.frailty.gyroscope service
04-23 13:17:25.101+0200 W/AUL     (30092): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:17:25.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:25.101+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30092
04-23 13:17:25.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29360
04-23 13:17:25.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:17:25.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:17:25.111+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:25.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(29360), cmd(0)
04-23 13:17:25.121+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:25.121+0200 I/utils   (29360): specific action
04-23 13:17:25.121+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:25.121+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:17:25.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:25.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:25.131+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29365
04-23 13:17:25.131+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29365)
04-23 13:17:25.131+0200 I/servicemanager(29360): request sent to service es.ugr.frailty.recorder
04-23 13:17:25.131+0200 I/servicemanager(29360): requesting to save local data
04-23 13:17:25.131+0200 W/AUL     (30092): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29360)
04-23 13:17:25.131+0200 I/gyroscope(30092): request sent to service es.ugr.frailty.servicemanager
04-23 13:17:25.131+0200 I/CAPI_APPFW_APPLICATION(30092): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:17:25.131+0200 W/CAPI_APPFW_APP_CONTROL(29365): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:25.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:17:25.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:17:25.131+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:25.131+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(29365), cmd(0)
04-23 13:17:25.141+0200 I/utils   (29365): specific action
04-23 13:17:25.141+0200 W/CAPI_APPFW_APP_CONTROL(29365): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:25.141+0200 W/CAPI_APPFW_APP_CONTROL(29365): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:25.141+0200 I/recorder(29365): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 13:17:25.141+0200 I/recorder(29365): guardando datos en local
04-23 13:17:25.201+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:17:25.211+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:17:25.221+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:17:25.221+0200 I/accelerometer(30079): es.ugr.frailty.accelerometer listener destroyed
04-23 13:17:25.231+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:17:25.251+0200 I/gyroscope(30092): es.ugr.frailty.gyroscope listener destroyed
04-23 13:17:25.351+0200 W/AUL     (30109): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:17:25.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:17:25.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 13:17:25.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30079
04-23 13:17:25.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:17:25.381+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30079
04-23 13:17:25.381+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30079)
04-23 13:17:25.411+0200 W/AUL     (30110): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 13:17:25.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:17:25.411+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 13:17:25.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30092
04-23 13:17:25.411+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:17:25.431+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30092
04-23 13:17:25.431+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30092)
04-23 13:17:27.121+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:17:27.141+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:17:37.341+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:17:37.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:37.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:37.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29363
04-23 13:17:37.371+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:37.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(29363), cmd(0)
04-23 13:17:37.371+0200 I/utils   (29363): specific action
04-23 13:17:37.371+0200 I/httppostreq(29363): internet connection check received
04-23 13:17:37.371+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29363)
04-23 13:17:37.371+0200 I/httppostreq(29363): internet connection != null
04-23 13:17:37.371+0200 I/CAPI_NETWORK_CONNECTION(29363): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:17:37.371+0200 I/servicemanager(29360): request sent to service es.ugr.frailty.httppostreq
04-23 13:17:37.371+0200 I/httppostreq(29363): internet connection type...
04-23 13:17:37.371+0200 I/httppostreq(29363): internet connection type 1
04-23 13:17:37.371+0200 I/httppostreq(29363): internet available
04-23 13:17:37.371+0200 W/AUL     (29363): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:17:37.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:37.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29363
04-23 13:17:37.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29360
04-23 13:17:37.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:37.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(29360), cmd(0)
04-23 13:17:37.401+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:37.401+0200 I/utils   (29360): specific action
04-23 13:17:37.401+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:37.401+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:37.401+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:37.401+0200 I/servicemanager(29360): internet connection available. stop all sensors
04-23 13:17:37.401+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:17:37.401+0200 W/AUL     (29363): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29360)
04-23 13:17:37.411+0200 I/httppostreq(29363): request sent to service es.ugr.frailty.servicemanager
04-23 13:17:37.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:37.411+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:37.431+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 30111
04-23 13:17:37.431+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:17:37.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 30111
04-23 13:17:37.481+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(30111) type(svcapp) bg(0)
04-23 13:17:37.491+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30111)
04-23 13:17:37.491+0200 I/servicemanager(29360): es.ugr.frailty.accelerometer stop request sent!
04-23 13:17:37.491+0200 I/servicemanager(29360): App control destroyed.
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:37.491+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:37.491+0200 E/servicemanager(29360): deleting timer 0
04-23 13:17:37.491+0200 E/servicemanager(29360): deleting timer 1
04-23 13:17:37.491+0200 E/servicemanager(29360): deleting timer 2
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:37.491+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:37.491+0200 E/servicemanager(29360): deleting timer 3
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:37.491+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:37.491+0200 E/servicemanager(29360): deleting timer 4
04-23 13:17:37.491+0200 E/EFL     (29360): <29360> ecore_timer.c:559 _ecore_timer_del() safety check failed: timer->delete_me is true
04-23 13:17:37.491+0200 E/servicemanager(29360): deleting timer 5
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:37.491+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:37.491+0200 E/servicemanager(29360): deleting timer 6
04-23 13:17:37.491+0200 E/EFL     (29360): <29360> ecore_timer.c:559 _ecore_timer_del() safety check failed: timer->delete_me is true
04-23 13:17:37.491+0200 E/servicemanager(29360): deleting timer 7
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:37.491+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:37.491+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:37.491+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:37.491+0200 E/servicemanager(29360): deleting timer 8
04-23 13:17:37.491+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:17:37.491+0200 E/CAPI_APPFW_APPLICATION(30111): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:17:37.491+0200 E/CAPI_APPFW_APPLICATION(30111): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:17:37.491+0200 I/utils   (30111): trying to start service: es.ugr.frailty.accelerometer
04-23 13:17:37.491+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30111]
04-23 13:17:37.501+0200 I/utils   (30111): es.ugr.frailty.accelerometer sensor supported
04-23 13:17:37.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:37.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:37.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29365
04-23 13:17:37.511+0200 I/utils   (30111): es.ugr.frailty.accelerometer listener started
04-23 13:17:37.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:17:37.511+0200 I/accelerometer(30111): stopping es.ugr.frailty.accelerometer service
04-23 13:17:37.511+0200 E/CAPI_APPFW_APP_CONTROL(30111): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:17:37.511+0200 E/accelerometer(30111): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:17:37.521+0200 I/utils   (29365): specific action
04-23 13:17:37.521+0200 I/recorder(29365): obteniendo datos locales...
04-23 13:17:37.521+0200 I/recorder(29365): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:19:941,3.259024,-8.740981,-0.945165
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:143,2.677568,-3.739982,5.910272
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:344,4.697111,-0.172283,7.085148
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:543,5.761917,-2.014757,7.262216
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:743,5.582455,0.217747,8.219346
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:943,5.903094,2.380858,7.824530
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:143,6.898508,2.955136,7.496714
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:342,9.102298,2.699104,4.304688
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:542,6.147161,5.548956,4.402793
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:743,6.245267,4.606184,3.950550
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:949,8.338986,4.141976,2.443072
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:142,12.468999,4.969893,2.933600
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:342,8.834301,3.495914,2.493321
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:548,9.011370,2.593820,3.096312
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:748,8.834301,2.577070,3.290131
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:949,8.645268,2.971886,3.469593
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:23:142,8.324631,3.988836,3.352344
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:23:342,8.391629,4.091727,3.493521
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:23:549,8.494520,3.601198,3.455236
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:23:748,8.212167,3.689733,3.790231
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:23:948,8.133204,3.972085,3.902694
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:24:149,8.159525,3.314059,4.491328
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:24:348,8.228917,3.381058,4.371687
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:24:548,8.197811,3.385844,4.182654
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:24:748,8.283953,3.639483,3.984050
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:24:948,8.207381,3.711268,3.651447
04-23 13:17:37.521+0200 I/recorder(29365): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 13:17:37.521+0200 I/recorder(29365): obteniendo datos locales, DATA: SM-R760,23/04/2018,13:17:19:941,3.259024,-8.740981,-0.945165
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:143,2.677568,-3.739982,5.910272
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:344,4.697111,-0.172283,7.085148
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:543,5.761917,-2.014757,7.262216
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:743,5.582455,0.217747,8.219346
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:20:943,5.903094,2.380858,7.824530
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:143,6.898508,2.955136,7.496714
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:342,9.102298,2.699104,4.304688
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:542,6.147161,5.548956,4.402793
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:743,6.245267,4.606184,3.950550
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:21:949,8.338986,4.141976,2.443072
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:142,12.468999,4.969893,2.933600
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:342,8.834301,3.495914,2.493321
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:548,9.011370,2.593820,3.096312
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:748,8.834301,2.577070,3.290131
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:22:949,8.645268,2.971886,3.469593
04-23 13:17:37.521+0200 I/recorder(29365): SM-R760,23/04/2018,13:17:23:142,8.324631,
04-23 13:17:37.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30111
04-23 13:17:37.521+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (30111) was created
04-23 13:17:37.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:17:37.531+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:37.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(29365), cmd(0)
04-23 13:17:37.531+0200 I/CAPI_APPFW_APPLICATION(30111): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:17:37.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:17:37.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:17:37.541+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29365)
04-23 13:17:37.541+0200 I/servicemanager(29360): request sent to service es.ugr.frailty.recorder
04-23 13:17:37.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:17:37.561+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30111
04-23 13:17:37.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:17:37.621+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:17:37.631+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:17:37.651+0200 I/accelerometer(30111): es.ugr.frailty.accelerometer listener destroyed
04-23 13:17:37.691+0200 W/AUL     (30131): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:17:37.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:17:37.691+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 13:17:37.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 29365
04-23 13:17:37.691+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:17:37.711+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29365
04-23 13:17:37.711+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29365)
04-23 13:17:37.711+0200 W/CRASH_MANAGER(30127): worker.c: worker_job(1205) > 06293657265631524482257
04-23 13:17:37.781+0200 W/AUL     (30140): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:17:37.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:17:37.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 13:17:37.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30111
04-23 13:17:37.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:17:37.791+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30111
04-23 13:17:37.791+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30111)
04-23 13:17:39.531+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:17:57.351+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:17:57.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:57.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:57.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29363
04-23 13:17:57.371+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:57.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(29363), cmd(0)
04-23 13:17:57.371+0200 I/utils   (29363): specific action
04-23 13:17:57.371+0200 I/httppostreq(29363): internet connection check received
04-23 13:17:57.371+0200 I/httppostreq(29363): internet connection != null
04-23 13:17:57.371+0200 I/CAPI_NETWORK_CONNECTION(29363): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:17:57.371+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29363)
04-23 13:17:57.371+0200 I/servicemanager(29360): request sent to service es.ugr.frailty.httppostreq
04-23 13:17:57.371+0200 I/httppostreq(29363): internet connection type...
04-23 13:17:57.371+0200 I/httppostreq(29363): internet connection type 1
04-23 13:17:57.371+0200 I/httppostreq(29363): internet available
04-23 13:17:57.371+0200 W/AUL     (29363): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:17:57.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:57.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29363
04-23 13:17:57.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29360
04-23 13:17:57.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:17:57.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(29360), cmd(0)
04-23 13:17:57.401+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:57.401+0200 I/utils   (29360): specific action
04-23 13:17:57.401+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:57.401+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:57.401+0200 W/CAPI_APPFW_APP_CONTROL(29360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:17:57.401+0200 I/servicemanager(29360): internet connection available. stop all sensors
04-23 13:17:57.401+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:17:57.401+0200 W/AUL     (29363): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29360)
04-23 13:17:57.401+0200 I/httppostreq(29363): request sent to service es.ugr.frailty.servicemanager
04-23 13:17:57.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:57.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:57.431+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:17:57.431+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 30181
04-23 13:17:57.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 30181
04-23 13:17:57.481+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(30181) type(svcapp) bg(0)
04-23 13:17:57.481+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30181]
04-23 13:17:57.491+0200 E/CAPI_APPFW_APPLICATION(30181): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:17:57.491+0200 E/CAPI_APPFW_APPLICATION(30181): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:17:57.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:17:57.501+0200 I/utils   (30181): trying to start service: es.ugr.frailty.accelerometer
04-23 13:17:57.501+0200 I/utils   (30181): es.ugr.frailty.accelerometer sensor supported
04-23 13:17:57.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30181
04-23 13:17:57.511+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (30181) was created
04-23 13:17:57.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:17:57.511+0200 I/utils   (30181): es.ugr.frailty.accelerometer listener started
04-23 13:17:57.511+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30181)
04-23 13:17:57.511+0200 I/servicemanager(29360): es.ugr.frailty.accelerometer stop request sent!
04-23 13:17:57.511+0200 I/servicemanager(29360): App control destroyed.
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:57.511+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:57.511+0200 E/servicemanager(29360): deleting timer 0
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:57.511+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:57.511+0200 E/servicemanager(29360): deleting timer 1
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:57.511+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:57.511+0200 E/servicemanager(29360): deleting timer 2
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:57.511+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:57.511+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:57.511+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:57.511+0200 E/servicemanager(29360): deleting timer 3
04-23 13:17:57.521+0200 I/accelerometer(30181): stopping es.ugr.frailty.accelerometer service
04-23 13:17:57.521+0200 E/CAPI_APPFW_APP_CONTROL(30181): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:17:57.521+0200 E/accelerometer(30181): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:17:57.521+0200 I/CAPI_APPFW_APPLICATION(30181): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:17:57.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:17:57.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:57.521+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:57.521+0200 E/servicemanager(29360): deleting timer 4
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:57.521+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:57.521+0200 E/servicemanager(29360): deleting timer 5
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:57.521+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:57.521+0200 E/servicemanager(29360): deleting timer 6
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:57.521+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:57.521+0200 E/servicemanager(29360): deleting timer 7
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:573 _ecore_magic_fail() 
04-23 13:17:57.521+0200 E/EFL     (29360): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** IN FUNCTION: ecore_timer_del()
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:17:57.521+0200 E/EFL     (29360): ecore<29360> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** SPANK SPANK SPANK!!!
04-23 13:17:57.521+0200 E/EFL     (29360): *** Now go fix your code. Tut tut tut!
04-23 13:17:57.521+0200 E/servicemanager(29360): deleting timer 8
04-23 13:17:57.521+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:17:57.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:17:57.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 29360
04-23 13:17:57.541+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 30193
04-23 13:17:57.541+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:17:57.581+0200 E/CAPI_APPFW_APPLICATION(30193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:17:57.581+0200 E/CAPI_APPFW_APPLICATION(30193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:17:57.591+0200 I/utils   (30193): specific action
04-23 13:17:57.591+0200 I/recorder(30193): obteniendo datos locales...
04-23 13:17:57.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 30193
04-23 13:17:57.591+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(30193) type(svcapp) bg(0)
04-23 13:17:57.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:17:57.591+0200 W/AUL     (29360): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30193)
04-23 13:17:57.591+0200 I/servicemanager(29360): request sent to service es.ugr.frailty.recorder
04-23 13:17:57.601+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30181
04-23 13:17:57.601+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (30193) was created
04-23 13:17:57.611+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30193]
04-23 13:17:57.621+0200 I/recorder(30193): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:19:941,3.259024,-8.740981,-0.945165
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:20:143,2.677568,-3.739982,5.910272
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:20:344,4.697111,-0.172283,7.085148
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:20:543,5.761917,-2.014757,7.262216
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:20:743,5.582455,0.217747,8.219346
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:20:943,5.903094,2.380858,7.824530
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:21:143,6.898508,2.955136,7.496714
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:21:342,9.102298,2.699104,4.304688
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:21:542,6.147161,5.548956,4.402793
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:21:743,6.245267,4.606184,3.950550
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:21:949,8.338986,4.141976,2.443072
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:22:142,12.468999,4.969893,2.933600
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:22:342,8.834301,3.495914,2.493321
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:22:548,9.011370,2.593820,3.096312
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:22:748,8.834301,2.577070,3.290131
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:22:949,8.645268,2.971886,3.469593
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:23:142,8.324631,3.988836,3.352344
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:23:342,8.391629,4.091727,3.493521
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:23:549,8.494520,3.601198,3.455236
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:23:748,8.212167,3.689733,3.790231
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:23:948,8.133204,3.972085,3.902694
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:24:149,8.159525,3.314059,4.491328
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:24:348,8.228917,3.381058,4.371687
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:24:548,8.197811,3.385844,4.182654
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:24:748,8.283953,3.639483,3.984050
04-23 13:17:57.621+0200 I/recorder(30193): SM-R760,23/04/2018,13:17:24:948,8.207381,3.711268,3.651447
04-23 13:17:57.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:17:57.641+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30193
04-23 13:17:57.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:17:57.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:17:57.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:17:57.671+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:17:57.671+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30193
04-23 13:17:57.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:17:57.681+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:17:57.701+0200 W/CRASH_MANAGER(30127): worker.c: worker_job(1205) > 1130193726563152448227
