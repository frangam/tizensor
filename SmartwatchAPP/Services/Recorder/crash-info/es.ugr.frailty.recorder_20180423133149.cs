S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 14496
Date: 2018-04-23 13:31:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7580648, r1   = 0xf7e121b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7e121b8, r5   = 0x00012cd0
r6   = 0xf7e24e88, r7   = 0xf7580250
r8   = 0x000005e0, r9   = 0xf7063824
r10  = 0xf7e0a9d8, fp   = 0x00000000
ip   = 0xf757f030, sp   = 0xff9a82e0
lr   = 0xf74c35d0, pc   = 0xf74bf9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     11988 KB
Buffers:     70520 KB
Cached:     178564 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7716 KB
VmRSS:        7716 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6bfa000 f6bfd000 r-xp /lib/libattr.so.1.1.0
f6c06000 f6c0d000 r-xp /lib/libcrypt-2.13.so
f6c3d000 f6c40000 r-xp /lib/libcap.so.2.21
f6c48000 f6c4a000 r-xp /usr/lib/libiri.so
f6c52000 f6c6f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c78000 f6c7c000 r-xp /usr/lib/libsmack.so.1.0.0
f6c86000 f6c88000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c90000 f6c95000 r-xp /usr/lib/libffi.so.5.0.10
f6c9d000 f6c9e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ca6000 f6ca8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cb0000 f6cb2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cbc000 f6ccc000 r-xp /lib/libresolv-2.13.so
f6cd0000 f6ce8000 r-xp /usr/lib/liblzma.so.5.0.3
f6cf0000 f6cf2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cfa000 f6d29000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d32000 f6d41000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d4a000 f6d54000 r-xp /usr/lib/libsensord-shared.so
f6d5d000 f6d91000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d9a000 f6e6d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e78000 f6e8e000 r-xp /lib/libz.so.1.2.5
f6e96000 f6e9c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ea5000 f6f1a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f24000 f6f3e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f46000 f6f4c000 r-xp /lib/librt-2.13.so
f6f55000 f6f73000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f7d000 f6f7e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f86000 f6f8b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f93000 f7063000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7064000 f708e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7097000 f70ae000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70b6000 f711f000 r-xp /lib/libm-2.13.so
f7128000 f71bc000 r-xp /usr/lib/libstdc++.so.6.0.16
f71cf000 f71d4000 r-xp /usr/lib/libctx-client.so.0.8.3
f71dc000 f71e3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71eb000 f7215000 r-xp /usr/lib/libsensor.so.1.9.6
f721e000 f72ea000 r-xp /usr/lib/libxml2.so.2.7.8
f72f7000 f72f9000 r-xp /usr/lib/libiniparser.so.0
f7302000 f7305000 r-xp /usr/lib/libbundle.so.0.1.22
f730d000 f7313000 r-xp /usr/lib/libappsvc.so.0.1.0
f731b000 f733e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7346000 f7387000 r-xp /usr/lib/libeina.so.1.7.99
f7390000 f73a7000 r-xp /usr/lib/libecore.so.1.7.99
f73be000 f73c7000 r-xp /usr/lib/libvconf.so.0.2.45
f73cf000 f73e3000 r-xp /lib/libpthread-2.13.so
f73ee000 f73fb000 r-xp /usr/lib/libaul.so.0.1.0
f7405000 f7407000 r-xp /lib/libdl-2.13.so
f7410000 f741b000 r-xp /lib/libunwind.so.8.0.1
f7448000 f7450000 r-xp /lib/libgcc_s-4.6.so.1
f7451000 f7575000 r-xp /lib/libc-2.13.so
f7583000 f7585000 r-xp /usr/lib/libdlog.so.0.0.0
f758d000 f7599000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75a2000 f75a7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75af000 f75b3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75bc000 f75be000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f75c7000 f75ca000 r-xp /usr/lib/libappcore-agent.so.1.1
f75e8000 f7605000 r-xp /lib/ld-2.13.so
f760e000 f7611000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7611000 f7615000 r-xp /usr/lib/libsys-assert.so
f7e00000 f7e4e000 rw-p [heap]
ff98a000 ff9ab000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14496)
Call Stack Count: 1
 0: (0xf74bf9fc) [/lib/libc.so.6] + 0x6e9fc
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
51+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:31:28.951+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12855)
04-23 13:31:28.951+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:31:28.951+0200 I/recorder(12855): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 13:31:28.951+0200 I/recorder(12855): obteniendo datos locales, DATA: SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:31:28.951+0200 I/recorder(12855): SM-R760,23/04/2018,13:31:14:973
04-23 13:31:28.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:31:28.971+0200 E/CAPI_APPFW_APP_CONTROL(14413): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:31:28.971+0200 E/accelerometer(14413): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:31:28.971+0200 I/CAPI_APPFW_APPLICATION(14413): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:31:28.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:31:28.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(12855), cmd(0)
04-23 13:31:28.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:31:29.031+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:31:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:31:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:31:29.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:31:29.051+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14413
04-23 13:31:29.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:31:29.061+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14413
04-23 13:31:29.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:31:29.081+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:31:29.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:31:29.121+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:29.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:29:138,0
04-23 13:31:29.161+0200 I/accelerometer(14413): es.ugr.frailty.accelerometer listener destroyed
04-23 13:31:29.171+0200 W/AUL     (14434): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:31:29.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:31:29.171+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:31:29.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12855
04-23 13:31:29.171+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:31:29.181+0200 E/AUL     (14434): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:31:29.191+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 06128557265631524483088
04-23 13:31:29.191+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12855
04-23 13:31:29.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12855)
04-23 13:31:29.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:29.321+0200 W/AUL     (14444): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:31:29.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:31:29.321+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:29.321+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:29.321+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:29.321+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:29.321+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:29.321+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:31:29.321+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:31:29.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:31:29.321+0200 E/AUL     (14444): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:31:29.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 14413
04-23 13:31:29.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:31:29.331+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14413
04-23 13:31:29.331+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14413)
04-23 13:31:29.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:29:322,0
04-23 13:31:29.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:29.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:29:506,0
04-23 13:31:29.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:29.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:29:706,0
04-23 13:31:29.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:29.921+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:29:906,0
04-23 13:31:30.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:30.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:30:106,0
04-23 13:31:30.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:30.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:30:307,0
04-23 13:31:30.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:30.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:30:506,0
04-23 13:31:30.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:30.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:30:706,0
04-23 13:31:30.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:30.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:30:907,0
04-23 13:31:31.051+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:31:31.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:31.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:31:107,0
04-23 13:31:31.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:31.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:31:307,0
04-23 13:31:31.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:31.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:31:507,0
04-23 13:31:31.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:31.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:31:707,0
04-23 13:31:31.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:31.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:31:907,0
04-23 13:31:32.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:32.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:32:107,0
04-23 13:31:32.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:32.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:32:307,0
04-23 13:31:32.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:32.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:32:508,0
04-23 13:31:32.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:32.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:32:708,0
04-23 13:31:32.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:32.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:32:908,0
04-23 13:31:33.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:33.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:33:108,0
04-23 13:31:33.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:33.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:33:308,0
04-23 13:31:33.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:33.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:33:508,0
04-23 13:31:33.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:33.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:33:708,0
04-23 13:31:33.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:33.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:33:909,0
04-23 13:31:34.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:34.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:34:109,0
04-23 13:31:34.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:34.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:34:309,0
04-23 13:31:34.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:34.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:34:509,0
04-23 13:31:34.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:34.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:34:709,0
04-23 13:31:34.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:34.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:34:909,0
04-23 13:31:35.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:35.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:35:109,0
04-23 13:31:35.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:35.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:35:310,0
04-23 13:31:35.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:35.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:35:510,0
04-23 13:31:35.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:35.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:35:710,0
04-23 13:31:35.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:35.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:35:911,0
04-23 13:31:36.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:36.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:36:111,0
04-23 13:31:36.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:36.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:36:314,0
04-23 13:31:36.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:36.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:36:515,0
04-23 13:31:36.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:36.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:36:711,0
04-23 13:31:36.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:36.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:36:911,0
04-23 13:31:37.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:37.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:37:115,0
04-23 13:31:37.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:37.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:37:312,0
04-23 13:31:37.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:37.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:37:512,0
04-23 13:31:37.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:37.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:37:712,0
04-23 13:31:37.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:37.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:37:912,0
04-23 13:31:38.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:38.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:38:112,73
04-23 13:31:38.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:38.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:38:312,73
04-23 13:31:38.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:38.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:38:512,72
04-23 13:31:38.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:38.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:38:712,72
04-23 13:31:38.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:38.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:38:913,72
04-23 13:31:39.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:39.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:39:113,72
04-23 13:31:39.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:39.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:39:313,72
04-23 13:31:39.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:39.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:39:513,72
04-23 13:31:39.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:39.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:39:713,72
04-23 13:31:39.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:39.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:39:913,72
04-23 13:31:40.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:40.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:40:113,72
04-23 13:31:40.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:40.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:40:313,72
04-23 13:31:40.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:40.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:40:514,72
04-23 13:31:40.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:40.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:40:714,72
04-23 13:31:40.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:40.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:40:914,72
04-23 13:31:41.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:41.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:41:114,72
04-23 13:31:41.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:41.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:41:314,73
04-23 13:31:41.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:41.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:41:514,73
04-23 13:31:41.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:41.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:41:714,73
04-23 13:31:41.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:41.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:41:914,73
04-23 13:31:42.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:42.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:42:115,73
04-23 13:31:42.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:42.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:42:315,73
04-23 13:31:42.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:42.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:42:515,73
04-23 13:31:42.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:42.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:42:715,73
04-23 13:31:42.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:42.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:42:915,73
04-23 13:31:43.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:43.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:43:115,73
04-23 13:31:43.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:43.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:43:316,74
04-23 13:31:43.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:43.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:43:516,74
04-23 13:31:43.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:43.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:43:716,73
04-23 13:31:43.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:43.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:43:916,73
04-23 13:31:44.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:44.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:44:116,73
04-23 13:31:44.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:44.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:44:316,73
04-23 13:31:44.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:44.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:44:516,73
04-23 13:31:44.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:44.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:44:716,73
04-23 13:31:44.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:44.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:44:916,73
04-23 13:31:45.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:45.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:45:117,73
04-23 13:31:45.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:45.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:45:317,73
04-23 13:31:45.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:45.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:45:517,73
04-23 13:31:45.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:45.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:45:717,73
04-23 13:31:45.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:45.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:45:917,72
04-23 13:31:46.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:46.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:46:117,72
04-23 13:31:46.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:46.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:46:317,72
04-23 13:31:46.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:46.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:46:517,72
04-23 13:31:46.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:46.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:46:718,72
04-23 13:31:46.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:46.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:46:918,72
04-23 13:31:47.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:47.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:47:118,72
04-23 13:31:47.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:47.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:47:318,72
04-23 13:31:47.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:47.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:47:518,72
04-23 13:31:47.711+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:47.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:47:718,72
04-23 13:31:47.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:47.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:47:919,72
04-23 13:31:48.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:48.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:48:119,72
04-23 13:31:48.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:48.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:48:319,73
04-23 13:31:48.511+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:48.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:48:519,72
04-23 13:31:48.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:31:48.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:31:48.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:31:48.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:31:48.671+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:31:48.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:31:48.691+0200 I/utils   ( 9745): specific action
04-23 13:31:48.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:31:48.691+0200 I/httppostreq( 9745): internet connection check received
04-23 13:31:48.691+0200 I/httppostreq( 9745): internet connection != null
04-23 13:31:48.691+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:31:48.691+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:31:48.691+0200 I/httppostreq( 9745): internet connection type...
04-23 13:31:48.691+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:31:48.691+0200 I/httppostreq( 9745): internet available
04-23 13:31:48.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:31:48.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:31:48.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:31:48.721+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:31:48.731+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:31:48.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:31:48.741+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:31:48.741+0200 I/utils   ( 9742): specific action
04-23 13:31:48.741+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:31:48.741+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:31:48.741+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:31:48.741+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:31:48.741+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:31:48.751+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:31:48.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:31:48.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:31:48.771+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:31:48.771+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 14482
04-23 13:31:48.771+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:31:48.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:48.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:48:784,72
04-23 13:31:48.821+0200 E/CAPI_APPFW_APPLICATION(14482): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:31:48.821+0200 E/CAPI_APPFW_APPLICATION(14482): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:31:48.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14482
04-23 13:31:48.821+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(14482) type(svcapp) bg(0)
04-23 13:31:48.821+0200 I/utils   (14482): trying to start service: es.ugr.frailty.accelerometer
04-23 13:31:48.821+0200 I/utils   (14482): es.ugr.frailty.accelerometer sensor supported
04-23 13:31:48.821+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14482]
04-23 13:31:48.831+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (14482) was created
04-23 13:31:48.841+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14482)
04-23 13:31:48.841+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:31:48.841+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:31:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:31:48.841+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:31:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:31:48.841+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:31:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:31:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:31:48.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:31:48.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14482
04-23 13:31:48.851+0200 I/utils   (14482): es.ugr.frailty.accelerometer listener started
04-23 13:31:48.851+0200 I/accelerometer(14482): stopping es.ugr.frailty.accelerometer service
04-23 13:31:48.851+0200 E/CAPI_APPFW_APP_CONTROL(14482): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:31:48.851+0200 E/accelerometer(14482): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:31:48.851+0200 I/CAPI_APPFW_APPLICATION(14482): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:31:48.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:31:48.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:31:48.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:31:48.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:48.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:48:919,72
04-23 13:31:48.921+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:31:48.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:48.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:48.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:48.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:31:48.931+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:31:48.931+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:31:48.931+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:31:48.931+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:31:48.931+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:31:48.931+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:31:48.931+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:31:48.931+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:31:48.931+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:31:48.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:31:48.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:31:48.931+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:31:48.941+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 14496
04-23 13:31:48.951+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:31:48.951+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:31:48.981+0200 I/accelerometer(14482): es.ugr.frailty.accelerometer listener destroyed
04-23 13:31:48.991+0200 E/CAPI_APPFW_APPLICATION(14496): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:31:48.991+0200 E/CAPI_APPFW_APPLICATION(14496): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:31:48.991+0200 I/utils   (14496): specific action
04-23 13:31:48.991+0200 I/recorder(14496): obteniendo datos locales...
04-23 13:31:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14496
04-23 13:31:48.991+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(14496) type(svcapp) bg(0)
04-23 13:31:49.001+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14496]
04-23 13:31:49.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:31:49.001+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14496)
04-23 13:31:49.001+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:31:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14482
04-23 13:31:49.011+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (14496) was created
04-23 13:31:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:31:49.031+0200 I/recorder(14496): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:31:49.031+0200 I/recorder(14496): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:31:49.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:31:49.051+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14496
04-23 13:31:49.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:31:49.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:31:49.101+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14496
04-23 13:31:49.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:31:49.121+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:31:49.121+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:31:49:131,73
04-23 13:31:49.131+0200 W/AUL     (14499): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:31:49.131+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1114496726563152448310
